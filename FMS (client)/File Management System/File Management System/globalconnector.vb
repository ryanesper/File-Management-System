'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Module globalconnector

    Private Const MAX_PATH As Integer = 256
    Private Const NAMESIZE As Integer = 80
    Private Const SHGFI_ICON As Int32 = &H100

    'Public con As New SqlConnection("data source = Boss-PC\SQLEXPRESS; initial catalog=fms; integrated security=true")
    Public con As New MySqlConnection
    Public mysqlconn As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    'Public datetime As New DateTime
    Public sqlda As MySqlDataAdapter
    Public user As String
    Public myinitialpath As String
    Public combinate As String
    Public combination As String
    Public mypath As String
    Public combination1 As String
    Public dt As DataTable
    Public ds As DataSet

    Public getpictypeforprofpic As String
    Public picfullname As String
    Public loadmypicture As String

    'Public serverusername As String = "Administrator"
    'Public serverpassword As String = "admin"
    Public cmdselect1, cmdselect, cmddelete, confirm, strconn, fileid, i, o, fullview As String
    'Public path As String = "\\192.168.0.6\Students_Accounts"
    'Public path As String = "\\199.102.0.1\Students_Accounts /user:Administrator Password:admin /persistent:yes"
    Public path As String
    Public combination2 As String


    Public accountid As String = ""
    Public firstname As String = ""
    Public middlename As String = ""
    Public lastname As String = ""
    Public gender As String = ""
    Public picname As String = ""
    Public username As String = ""
    Public password As String = ""
    Public maxname As String = ""
    Public year As String = ""
    Public course As String = ""
    Public number As String = ""
    Public email As String = ""
    Public address As String = ""
    Public dateregistered As String = ""

    Public remoteserverpcname As String
    Public clientinitialpath As String
    Public serverinitialpath As String
    Public sizenumber As String
    Public unit As String
    Public allocatedspace As String
    Public asinbytes As Decimal
    Public serverpcusername As String
    Public serverpcpassword As String

    Public totalsize As Decimal
    Public kb As Decimal = 1024
    Public mb As Decimal = kb * 1024
    Public gb As Decimal = mb * 1024
    'Public allocatedspace As Decimal = 4 * gb

    'Public folderpath As String
    'Public allocatedspace As Decimal
    'Public unit As String
    'Public adminusername As String
    'Public adminpassword As String

    Public fname As String
    Public fsize As Decimal = 0
    Public ftype As String
    Public ffilenumber As String
    Public ffoldernumber As String
    Public ftotalitems As String
    Public flastmodified As String
    Public flastaccesstime As String
    Public flastwritetime As String
    Public getpathinpropertiesfordelete As String
    Public deleteiteminitemproperties As String

    Public foldersayz As Integer
    'Public foldername As String
    'Public foldersize As String
    'Public foldertype As String
    'Public folderlastmodified As String
    'Public folderlastaccesstime As String
    'Public folderlastwritetime As String

    Public overallsizez As Decimal

    'Public getfilesize As String
    'Public getfolderlenght As String
    Public remainingspace As Decimal

    Public pathlength As Integer = 0
    Public selectedfolderlength As String = 0
    Public selectedfoldername As String
    Public getstudentfoldersize As String

    'Public dbUser As String
    'Public dbPass As String
    'Public dbDataBase As String
    'Public dbServer As String

    'Public Sub SaveSettings()
    '    SaveSetting("fms", "Database", "Server", dbServer)
    '    SaveSetting("fms", "Database", "Database", dbDataBase)
    '    SaveSetting("fms", "Database", "Password", dbPass)
    '    SaveSetting("fms", "Database", "User", dbUser)
    'End Sub

    'Public Sub GetSettings()
    '    dbServer = GetSetting("fms", "Database", "Server", "")
    '    dbDataBase = GetSetting("fms", "Database", "Database", "")
    '    dbUser = GetSetting("fms", "Database", "User", "")
    '    dbPass = GetSetting("fms", "Database", "Password", "")
    'End Sub

    Public Sub openconnection()
        If con.State = ConnectionState.Closed Then
            con.ConnectionString = "Server= " & My.Settings.serversettings & "; User Id= " & My.Settings.usersettings & "; Password= " & My.Settings.passwordsettings & "; Database= " & My.Settings.databasesettings & ";"
            'con.ConnectionString = "Server=localhost; User Id=esper; Password=root; Database=fms;"
            'con.ConnectionString = "Server=localhost; User Id=root; Password=; Database=fms;"
            'con.ConnectionString = "Server=192.168.0.1; User Id=esper; Password=root; Database=fms;"
            con.Open()
            cmd.Connection = con
        End If
    End Sub

    'Public Sub Connect()

    '    GetSettings()
    '    MysqlConn = "Data source=" & dbServer & "; user id=" & dbUser & _
    '                              "; password=" & dbPass & "; database=" & dbDatabase
    '    Dim Conn As New MySqlConnection(MysqlConn)
    '    Try
    '        Conn.Open()
    '        'frmLogin.Show()
    '        'frmDatabase.Hide()
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '        'frmDatabase.ShowDialog()
    '        frmdatabaseconnector.Show()
    '    End Try
    'End Sub

    Public Sub getsettingsfromdatabase()

        Dim openorclose As Boolean = False
        If con.State = ConnectionState.Closed Then
            openconnection()
            openorclose = True
        End If

        cmd = New MySqlCommand("SELECT COUNT(client_initial_path) as Count FROM settings", con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While (reader.Read())
            If reader("Count") = 0 Then
                reader.Close()
            Else
                reader.Close()
                cmd.CommandText = "select * from settings"
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    remoteserverpcname = reader("serverpcname").ToString()
                    clientinitialpath = reader("client_initial_path").ToString()
                    serverinitialpath = reader("server_initial_path").ToString()
                    sizenumber = reader("size").ToString()
                    unit = reader("unit").ToString()
                    allocatedspace = reader("allocated_space").ToString()
                    asinbytes = reader("asinbytes").ToString()
                    serverpcusername = reader("username").ToString()
                    Dim converter As New encryptanddecrypt
                    serverpcpassword = converter.decrypt(reader("password").ToString(), "Keys")
                End If
            End If
        End While
        reader.Close()

        If openorclose = True Then
            con.Close()
        End If

    End Sub

    Public Sub fileandfolderexplorer()

        frmexplorer.explorerlistview.FullRowSelect = True
        frmexplorer.explorerlistview.SmallImageList = frmexplorer.icons

        frmexplorer.explorerlistview.Columns.Clear()
        frmexplorer.explorerlistview.Columns.Add("Name", 300, HorizontalAlignment.Left)
        frmexplorer.explorerlistview.Columns.Add("Date Modified", 150, HorizontalAlignment.Left)
        frmexplorer.explorerlistview.Columns.Add("Type", 150, HorizontalAlignment.Left)
        frmexplorer.explorerlistview.Columns.Add("Size", 100, HorizontalAlignment.Left)

        For Each item As String In My.Computer.FileSystem.GetDirectories(combination2)
            'frmexplorer.icons.Images.Add(frmexplorer.GetShellIcon(item))

            frmexplorer.icons.Images.Add(frmexplorer.GetShellIcon(item))
            'frmexplorer.explorerlistview.Items.Add(My.Computer.FileSystem.GetName(item), frmexplorer.icons.Images.Count - 1)

            Dim lvi As New ListViewItem(My.Computer.FileSystem.GetName(item), frmexplorer.icons.Images.Count - 1)
            lvi.SubItems.Add(My.Computer.FileSystem.GetDirectoryInfo(item).CreationTime)
            lvi.SubItems.Add("Folder")
            lvi.SubItems.Add("")

            'Dim itemlocation As String = My.Computer.FileSystem.GetDirectoryInfo(item).FullName
            'Dim replaceditemlocation As String = item.Replace(combination, "..")
            'Dim replaceditemlocationlen As String = Microsoft.VisualBasic.Len(replaceditemlocation)
            'Dim spliter As String() = replaceditemlocation.Split("\")
            'Dim trimmedpath As String = spliter.Last.Trim
            'Dim numberoftrimmedpart As Integer = Microsoft.VisualBasic.Len(trimmedpath)
            'lvi.SubItems.Add(Microsoft.VisualBasic.Left(replaceditemlocation, replaceditemlocationlen - (numberoftrimmedpart + 1)))

            'lvi.SubItems.Add(replaceditemlocation)
            'For Each itemsize As String In My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            '    totalsize += My.Computer.FileSystem.GetFileInfo(item).Length
            '    If (totalsize >= 0 And totalsize < kb) Then
            '        lvi.SubItems.Add(itemsize & " bytes")
            '    ElseIf (totalsize >= kb AndAlso totalsize < mb) Then
            '        lvi.SubItems.Add(Format((itemsize / 1024), "0.00") & " KB")
            '    ElseIf (totalsize >= mb AndAlso totalsize < gb) Then
            '        lvi.SubItems.Add(Format((itemsize / 1024 / 1024), "0.00") & " MB")
            '    ElseIf (totalsize >= gb) Then
            '        lvi.SubItems.Add(Format((itemsize / 1024 / 1024 / 1024), "0.00") & " GB")
            '    End If
            'Next

            frmexplorer.explorerlistview.Items.Add(lvi) 'add the new ListViewItem to the ListView
        Next

        '-----------------------------------------------------------------------------

        For Each item As String In My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
            'frmexplorer.icons.Images.Add(Drawing.Icon.ExtractAssociatedIcon(item))
            'frmexplorer.explorerlistview.Items.Add(My.Computer.FileSystem.GetName(item), frmexplorer.icons.Images.Count - 1)

            frmexplorer.icons.Images.Add(frmexplorer.GetShellIcon(item))
            'frmexplorer.icons.Images.Add(Icon.ExtractAssociatedIcon(item).ToBitmap)
            Dim lvi As New ListViewItem(IO.Path.GetFileNameWithoutExtension(item), frmexplorer.icons.Images.Count - 1)
            'Dim lvi As New ListViewItem(My.Computer.FileSystem.GetFileInfo(item).Name, frmexplorer.icons.Images.Count - 1)
            lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).CreationTime)
            lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).Extension.ToUpper)

            Dim itemsize As Decimal = My.Computer.FileSystem.GetFileInfo(item).Length
            If (itemsize >= 0 And itemsize < kb) Then
                lvi.SubItems.Add(itemsize & " bytes")
            ElseIf (itemsize >= kb AndAlso itemsize < mb) Then
                lvi.SubItems.Add(Format((itemsize / 1024), "0") & " KB")
                'lvi.SubItems.Add((itemsize / 1024) & " KB")
            ElseIf (itemsize >= mb AndAlso itemsize < gb) Then
                lvi.SubItems.Add(Format((itemsize / 1024 / 1024), "0.0") & " MB")
            ElseIf (itemsize >= gb) Then
                lvi.SubItems.Add(Format((itemsize / 1024 / 1024 / 1024), "0.0") & " GB")
            End If

            'Dim itemlocation As String = My.Computer.FileSystem.GetDirectoryInfo(item).FullName
            'Dim replaceditemlocation As String = item.Replace(combination, "..")
            'Dim replaceditemlocationlen As String = Microsoft.VisualBasic.Len(replaceditemlocation)
            'Dim spliter As String() = replaceditemlocation.Split("\")
            'Dim trimmedpath As String = spliter.Last.Trim
            'Dim numberoftrimmedpart As Integer = Microsoft.VisualBasic.Len(trimmedpath)
            'lvi.SubItems.Add(Microsoft.VisualBasic.Left(replaceditemlocation, replaceditemlocationlen - (numberoftrimmedpart + 1)))

            frmexplorer.explorerlistview.Items.Add(lvi) 'add the new ListViewItem to the ListView
        Next

    End Sub

    Public Sub displayfilesandfolders()

        For Each item As String In My.Computer.FileSystem.GetDirectories(combination)
            frmmain.icons.Images.Add(frmmain.GetShellIcon(item))
            Dim lvi As New ListViewItem(My.Computer.FileSystem.GetName(item), frmmain.icons.Images.Count - 1)
            lvi.SubItems.Add("Folder")
            frmmain.listview.Items.Add(lvi)
        Next

        For Each item As String In My.Computer.FileSystem.GetFiles(combination, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
            'For Each item As String In My.Computer.FileSystem.GetFiles(combination, FileIO.SearchOption.SearchAllSubDirectories, frmmain.TextBox1.Text)
            'frmmain.icons.Images.Add(Drawing.Icon.ExtractAssociatedIcon(item))
            frmmain.icons.Images.Add(frmmain.GetShellIcon(item))
            Dim lvi As New ListViewItem(IO.Path.GetFileNameWithoutExtension(item), frmmain.icons.Images.Count - 1)
            lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).Extension)
            'frmmain.listview.Items.Add(My.Computer.FileSystem.GetName(item))
            frmmain.listview.Items.Add(lvi)
        Next

    End Sub

    Public Sub copyitemsinmain()

        If frmcopyandpaste.copyandpastelistview1.Enabled = True And frmcopyandpaste.copyandpastelistview2.Enabled = False Then
            frmcopyandpaste.copyandpastelistview1.Items.Clear()
            frmcopyandpaste.copyandpastelistview1.Columns.Clear()
            frmcopyandpaste.copyandpastelistview1.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
            frmcopyandpaste.copyandpastelistview1.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
            For Each item As ListViewItem In frmmain.listview.Items
                If frmmain.listview.SelectedItems.Count > 0 Then
                    item = frmmain.listview.SelectedItems.Item(0)
                    item.Selected = False
                    Dim itemname As String = item.SubItems(0).Text
                    Dim itemlocation As String = combination & "\" & itemname
                    If item.SubItems(1).Text = "Folder" Then
                        Dim lvi As New ListViewItem(itemname)
                        lvi.SubItems.Add(itemlocation)
                        frmcopyandpaste.copyandpastelistview1.Items.Add(lvi)
                    Else
                        Dim lvi As New ListViewItem(itemname & item.SubItems(1).Text)
                        lvi.SubItems.Add(itemlocation & item.SubItems(1).Text)
                        frmcopyandpaste.copyandpastelistview1.Items.Add(lvi)
                    End If
                End If
            Next
        ElseIf frmcopyandpaste.copyandpastelistview1.Enabled = False And frmcopyandpaste.copyandpastelistview2.Enabled = True Then
            frmcopyandpaste.copyandpastelistview2.Items.Clear()
            frmcopyandpaste.copyandpastelistview2.Columns.Clear()
            frmcopyandpaste.copyandpastelistview2.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
            frmcopyandpaste.copyandpastelistview2.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
            For Each item As ListViewItem In frmmain.listview.Items
                If frmmain.listview.SelectedItems.Count > 0 Then
                    item = frmmain.listview.SelectedItems.Item(0)
                    item.Selected = False
                    Dim itemname As String = item.SubItems(0).Text
                    Dim itemlocation As String = combination & "\" & itemname
                    If item.SubItems(1).Text = "Folder" Then
                        Dim lvi As New ListViewItem(itemname)
                        lvi.SubItems.Add(itemlocation)
                        frmcopyandpaste.copyandpastelistview2.Items.Add(lvi)
                    Else
                        Dim lvi As New ListViewItem(itemname & item.SubItems(1).Text)
                        lvi.SubItems.Add(itemlocation & item.SubItems(1).Text)
                        frmcopyandpaste.copyandpastelistview2.Items.Add(lvi)
                    End If
                End If
            Next
        End If

    End Sub

    Public Sub pasteitemsinmain()

        If frmcopyandpaste.copyandpastelistview1.Enabled = True And frmcopyandpaste.copyandpastelistview2.Enabled = False Then
            frmcopyandpaste.copyandpastelistview2.Items.Clear()
            frmcopyandpaste.copyandpastelistview2.Columns.Clear()
            frmcopyandpaste.copyandpastelistview2.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
            frmcopyandpaste.copyandpastelistview2.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
            For Each item As ListViewItem In frmcopyandpaste.copyandpastelistview1.Items
                If frmcopyandpaste.copyandpastelistview1.Items.Count > 0 Then
                    item = frmcopyandpaste.copyandpastelistview1.Items.Item(0)
                    Dim lvi As New ListViewItem(item.SubItems(0).Text)
                    lvi.SubItems.Add(item.SubItems(1).Text)
                    frmcopyandpaste.copyandpastelistview2.Items.Add(lvi)
                    item.Remove()
                    Dim itemname As String = item.SubItems(0).Text
                    Dim itemlocation As String = item.SubItems(1).Text
                    Dim newcopy As String = combination & "\" & itemname
                    If Directory.Exists(itemlocation) Then
                        If Not Directory.Exists(newcopy) Then
                            Dim foldersizetopasteinmain As Long = 0
                            For Each files In My.Computer.FileSystem.GetFiles(itemlocation, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                foldersizetopasteinmain += My.Computer.FileSystem.GetFileInfo(files).Length
                            Next
                            MsgBox(itemlocation & "=" & foldersizetopasteinmain)
                            If remainingspace > foldersizetopasteinmain Then
                                Try
                                    My.Computer.FileSystem.CopyDirectory(itemlocation, newcopy)
                                Catch ex As Exception
                                    'MessageBox.Show("Could not copy folder '" & item.SubItems(0).Text & "', since target directory '" & TextBox1.Text & "' is under source directory '" & item.SubItems(0).Text & "'.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    MessageBox.Show("Could not copy folder '" & itemname & "', since target directory is under source directory.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            Else
                                MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                frmcopyandpaste.copyandpastelistview1.Enabled = False
                                frmcopyandpaste.copyandpastelistview2.Enabled = True
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Folder '" & itemname & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    ElseIf File.Exists(itemlocation) Then
                        Dim filesizetopasteinmain As Long = My.Computer.FileSystem.GetFileInfo(itemlocation).Length
                        If remainingspace > filesizetopasteinmain Then
                            If Not File.Exists(newcopy) Then
                                My.Computer.FileSystem.CopyFile(itemlocation, newcopy)
                            Else
                                MessageBox.Show("File '" & itemname & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            frmcopyandpaste.copyandpastelistview1.Enabled = False
                            frmcopyandpaste.copyandpastelistview2.Enabled = True
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Could not find this item '" & itemname & "'", "Item not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    If frmcopyandpaste.copyandpastelistview1.Items.Count = 0 Then
                        frmmain.listview.Items.Clear()
                        myspace()
                        spaceconsumed()
                        remainingspacee()
                        displayfilesandfolders()
                        countfilesandfolders()
                    End If
                End If
            Next
            frmcopyandpaste.copyandpastelistview1.Enabled = False
            frmcopyandpaste.copyandpastelistview2.Enabled = True
        ElseIf frmcopyandpaste.copyandpastelistview1.Enabled = False And frmcopyandpaste.copyandpastelistview2.Enabled = True Then
            frmcopyandpaste.copyandpastelistview1.Items.Clear()
            frmcopyandpaste.copyandpastelistview1.Columns.Clear()
            frmcopyandpaste.copyandpastelistview1.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
            frmcopyandpaste.copyandpastelistview1.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
            For Each item As ListViewItem In frmcopyandpaste.copyandpastelistview2.Items
                If frmcopyandpaste.copyandpastelistview2.Items.Count > 0 Then
                    item = frmcopyandpaste.copyandpastelistview2.Items.Item(0)
                    Dim lvi As New ListViewItem(item.SubItems(0).Text)
                    lvi.SubItems.Add(item.SubItems(1).Text)
                    frmcopyandpaste.copyandpastelistview1.Items.Add(lvi)
                    item.Remove()
                    Dim itemname As String = item.SubItems(0).Text
                    Dim itemlocation As String = item.SubItems(1).Text
                    Dim newcopy As String = combination & "\" & itemname
                    If Directory.Exists(itemlocation) Then
                        If Not Directory.Exists(newcopy) Then
                            Dim foldersizetopasteinmain As Long = 0
                            For Each files In My.Computer.FileSystem.GetFiles(itemlocation, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                foldersizetopasteinmain += My.Computer.FileSystem.GetFileInfo(files).Length
                            Next
                            MsgBox(itemlocation & "=" & foldersizetopasteinmain)
                            If remainingspace > foldersizetopasteinmain Then
                                Try
                                    My.Computer.FileSystem.CopyDirectory(itemlocation, newcopy)
                                Catch ex As Exception
                                    'MessageBox.Show("Could not copy folder '" & item.SubItems(0).Text & "', since target directory '" & TextBox1.Text & "' is under source directory '" & item.SubItems(0).Text & "'.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    MessageBox.Show("Could not copy folder '" & itemname & "', since target directory is under source directory.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            Else
                                MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                frmcopyandpaste.copyandpastelistview1.Enabled = True
                                frmcopyandpaste.copyandpastelistview2.Enabled = False
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Folder '" & itemname & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    ElseIf File.Exists(itemlocation) Then
                        Dim filesizetopasteinmain As Long = My.Computer.FileSystem.GetFileInfo(itemlocation).Length
                        If remainingspace > filesizetopasteinmain Then
                            If Not File.Exists(newcopy) Then
                                My.Computer.FileSystem.CopyFile(itemlocation, newcopy)
                            Else
                                MessageBox.Show("File '" & itemname & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            frmcopyandpaste.copyandpastelistview1.Enabled = True
                            frmcopyandpaste.copyandpastelistview2.Enabled = False
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Could not find this item '" & itemname & "'", "Item not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    If frmcopyandpaste.copyandpastelistview2.Items.Count = 0 Then
                        frmmain.listview.Items.Clear()
                        myspace()
                        spaceconsumed()
                        remainingspacee()
                        displayfilesandfolders()
                        countfilesandfolders()
                    End If
                End If
            Next
            frmcopyandpaste.copyandpastelistview1.Enabled = True
            frmcopyandpaste.copyandpastelistview2.Enabled = False
        End If

    End Sub
 
    Public Sub copyitemsinexplorer()

        If Directory.Exists(combination2) Then
            If frmcopyandpaste.copyandpastelistview1.Enabled = True And frmcopyandpaste.copyandpastelistview2.Enabled = False Then
                frmcopyandpaste.copyandpastelistview1.Items.Clear()
                frmcopyandpaste.copyandpastelistview1.Columns.Clear()
                frmcopyandpaste.copyandpastelistview1.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
                frmcopyandpaste.copyandpastelistview1.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
                If frmexplorer.txtsearch.Text = "" Then
                    For Each item As ListViewItem In frmexplorer.explorerlistview.Items
                        If frmexplorer.explorerlistview.SelectedItems.Count > 0 Then
                            item = frmexplorer.explorerlistview.SelectedItems.Item(0)
                            item.Selected = False
                            Dim iteminlvi As String = combination2 & "\" & item.SubItems(0).Text
                            Dim itemlocation As String = My.Computer.FileSystem.GetDirectoryInfo(iteminlvi).FullName
                            If item.SubItems(2).Text = "Folder" Then
                                Dim itemname As String = My.Computer.FileSystem.GetDirectoryInfo(iteminlvi).Name
                                Dim lvi As New ListViewItem(itemname)
                                lvi.SubItems.Add(itemlocation)
                                frmcopyandpaste.copyandpastelistview1.Items.Add(lvi)
                            ElseIf File.Exists(iteminlvi & item.SubItems(2).Text.ToLower) Then
                                Dim itemname As String = My.Computer.FileSystem.GetFileInfo(iteminlvi).Name
                                Dim lvi As New ListViewItem(itemname & item.SubItems(2).Text.ToLower)
                                lvi.SubItems.Add(itemlocation & item.SubItems(2).Text.ToLower)
                                frmcopyandpaste.copyandpastelistview1.Items.Add(lvi)
                            End If
                        End If
                    Next
                Else
                    For Each item As ListViewItem In frmexplorer.explorerlistview.Items
                        If frmexplorer.explorerlistview.SelectedItems.Count > 0 Then
                            item = frmexplorer.explorerlistview.SelectedItems.Item(0)
                            item.Selected = False
                            Dim itemlocation As String = item.SubItems(4).Text.Replace("..", combination)
                            'MsgBox(item.SubItems(4).Text.Replace("..", combination2))
                            Dim itemname As String = item.SubItems(0).Text
                            If item.SubItems(2).Text = "Folder" Then
                                Dim lvi As New ListViewItem(itemname)
                                lvi.SubItems.Add(itemlocation & "\" & itemname)
                                frmcopyandpaste.copyandpastelistview1.Items.Add(lvi)
                            ElseIf File.Exists(itemlocation & "\" & itemname & item.SubItems(2).Text.ToLower) Then
                                MsgBox(itemlocation & "\" & itemname & item.SubItems(2).Text.ToLower)
                                Dim lvi As New ListViewItem(itemname & item.SubItems(2).Text.ToLower)
                                lvi.SubItems.Add(itemlocation & "\" & itemname & item.SubItems(2).Text.ToLower)
                                frmcopyandpaste.copyandpastelistview1.Items.Add(lvi)
                            End If
                        End If
                    Next
                End If
            ElseIf frmcopyandpaste.copyandpastelistview2.Enabled = True And frmcopyandpaste.copyandpastelistview1.Enabled = False Then
                frmcopyandpaste.copyandpastelistview2.Items.Clear()
                frmcopyandpaste.copyandpastelistview2.Columns.Clear()
                frmcopyandpaste.copyandpastelistview2.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
                frmcopyandpaste.copyandpastelistview2.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)

                If frmexplorer.txtsearch.Text = "" Then
                    For Each item As ListViewItem In frmexplorer.explorerlistview.Items
                        If frmexplorer.explorerlistview.SelectedItems.Count > 0 Then
                            item = frmexplorer.explorerlistview.SelectedItems.Item(0)
                            item.Selected = False
                            Dim iteminlvi As String = combination2 & "\" & item.SubItems(0).Text
                            Dim itemlocation As String = My.Computer.FileSystem.GetDirectoryInfo(iteminlvi).FullName
                            If item.SubItems(2).Text = "Folder" Then
                                Dim itemname As String = My.Computer.FileSystem.GetDirectoryInfo(iteminlvi).Name
                                Dim lvi As New ListViewItem(itemname)
                                lvi.SubItems.Add(itemlocation)
                                frmcopyandpaste.copyandpastelistview2.Items.Add(lvi)
                            ElseIf File.Exists(iteminlvi & item.SubItems(2).Text.ToLower) Then
                                Dim itemname As String = My.Computer.FileSystem.GetFileInfo(iteminlvi).Name
                                Dim lvi As New ListViewItem(itemname & item.SubItems(2).Text.ToLower)
                                lvi.SubItems.Add(itemlocation & item.SubItems(2).Text.ToLower)
                                frmcopyandpaste.copyandpastelistview2.Items.Add(lvi)
                            End If
                        End If
                    Next
                Else
                    For Each item As ListViewItem In frmexplorer.explorerlistview.Items
                        If frmexplorer.explorerlistview.SelectedItems.Count > 0 Then
                            item = frmexplorer.explorerlistview.SelectedItems.Item(0)
                            item.Selected = False
                            Dim itemlocation As String = item.SubItems(4).Text.Replace("..", combination)
                            'MsgBox(item.SubItems(4).Text.Replace("..", combination2))
                            Dim itemname As String = item.SubItems(0).Text
                            If item.SubItems(2).Text = "Folder" Then
                                Dim lvi As New ListViewItem(itemname)
                                lvi.SubItems.Add(itemlocation & "\" & itemname)
                                frmcopyandpaste.copyandpastelistview2.Items.Add(lvi)
                            ElseIf File.Exists(itemlocation & "\" & itemname & item.SubItems(2).Text.ToLower) Then
                                MsgBox(itemlocation & "\" & itemname & item.SubItems(2).Text.ToLower)
                                Dim lvi As New ListViewItem(itemname & item.SubItems(2).Text.ToLower)
                                lvi.SubItems.Add(itemlocation & "\" & itemname & item.SubItems(2).Text.ToLower)
                                frmcopyandpaste.copyandpastelistview2.Items.Add(lvi)
                            End If
                        End If
                    Next
                End If
            End If
            'frmexplorer.txtsearch.Text = ""
        Else
            frmexplorer.explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Sub pasteitemsinexplorer()

        If Directory.Exists(combination2) Then
            If frmcopyandpaste.copyandpastelistview1.Enabled = True And frmcopyandpaste.copyandpastelistview2.Enabled = False Then
                frmcopyandpaste.copyandpastelistview2.Items.Clear()
                frmcopyandpaste.copyandpastelistview2.Columns.Clear()
                frmcopyandpaste.copyandpastelistview2.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
                frmcopyandpaste.copyandpastelistview2.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
                For Each item As ListViewItem In frmcopyandpaste.copyandpastelistview1.Items
                    If frmcopyandpaste.copyandpastelistview1.Items.Count > 0 Then
                        item = frmcopyandpaste.copyandpastelistview1.Items.Item(0)
                        Dim lvi As New ListViewItem(item.SubItems(0).Text)
                        lvi.SubItems.Add(item.SubItems(1).Text)
                        frmcopyandpaste.copyandpastelistview2.Items.Add(lvi)
                        item.Remove()
                        Dim itemname As String = item.SubItems(0).Text
                        Dim itemlocation As String = item.SubItems(1).Text
                        Dim newcopy As String = combination2 & "\" & itemname
                        If Directory.Exists(itemlocation) Then
                            Dim foldersizetopasteinexplorer As Long = 0
                            For Each files In My.Computer.FileSystem.GetFiles(itemlocation, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                foldersizetopasteinexplorer += My.Computer.FileSystem.GetFileInfo(files).Length
                            Next
                            If remainingspace > foldersizetopasteinexplorer Then
                                If Not Directory.Exists(newcopy) Then
                                    Try
                                        My.Computer.FileSystem.CopyDirectory(itemlocation, newcopy)
                                    Catch ex As Exception
                                        MessageBox.Show("Could not copy folder '" & itemname & "', since target directory is under source directory.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        'MsgBox("Could not complete operation since target directory is under source directory.")
                                    End Try
                                Else
                                    MessageBox.Show("Folder '" & itemname & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                frmcopyandpaste.copyandpastelistview1.Enabled = False
                                frmcopyandpaste.copyandpastelistview2.Enabled = True
                                Exit Sub
                            End If
                        ElseIf File.Exists(itemlocation) Then
                            Dim filesizetopasteinexplorer As Long = 0
                            filesizetopasteinexplorer = My.Computer.FileSystem.GetFileInfo(itemlocation).Length
                            If remainingspace > filesizetopasteinexplorer Then
                                If Not File.Exists(newcopy) Then
                                    My.Computer.FileSystem.CopyFile(itemlocation, newcopy)
                                Else
                                    MessageBox.Show("File '" & itemname & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                frmcopyandpaste.copyandpastelistview1.Enabled = False
                                frmcopyandpaste.copyandpastelistview2.Enabled = True
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Could not find this item '" & itemname & "'", "Item not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        If frmcopyandpaste.copyandpastelistview1.Items.Count = 0 Then
                            frmexplorer.explorerlistview.Items.Clear()
                            myspace()
                            spaceconsumed()
                            remainingspacee()
                            fileandfolderexplorer()
                            countfilesandfolders()
                            countfilesandfoldersinexplorer()
                        End If
                    End If
                Next
                frmcopyandpaste.copyandpastelistview1.Enabled = False
                frmcopyandpaste.copyandpastelistview2.Enabled = True
            ElseIf frmcopyandpaste.copyandpastelistview2.Enabled = True And frmcopyandpaste.copyandpastelistview1.Enabled = False Then
                frmcopyandpaste.copyandpastelistview1.Items.Clear()
                frmcopyandpaste.copyandpastelistview1.Columns.Clear()
                frmcopyandpaste.copyandpastelistview1.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
                frmcopyandpaste.copyandpastelistview1.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
                For Each item As ListViewItem In frmcopyandpaste.copyandpastelistview2.Items
                    If frmcopyandpaste.copyandpastelistview2.Items.Count > 0 Then
                        item = frmcopyandpaste.copyandpastelistview2.Items.Item(0)
                        Dim lvi As New ListViewItem(item.SubItems(0).Text)
                        lvi.SubItems.Add(item.SubItems(1).Text)
                        frmcopyandpaste.copyandpastelistview1.Items.Add(lvi)
                        item.Remove()
                        Dim itemname As String = item.SubItems(0).Text
                        Dim itemlocation As String = item.SubItems(1).Text
                        Dim newcopy As String = combination2 & "\" & itemname
                        If Directory.Exists(itemlocation) Then
                            Dim foldersizetopasteinexplorer As Long = 0
                            For Each files In My.Computer.FileSystem.GetFiles(itemlocation, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                foldersizetopasteinexplorer += My.Computer.FileSystem.GetFileInfo(files).Length
                            Next
                            If remainingspace > foldersizetopasteinexplorer Then
                                If Not Directory.Exists(newcopy) Then
                                    Try
                                        My.Computer.FileSystem.CopyDirectory(itemlocation, newcopy)
                                    Catch ex As Exception
                                        'MessageBox.Show("Could not copy folder '" & item.SubItems(0).Text & "', since target directory '" & TextBox1.Text & "' is under source directory '" & item.SubItems(0).Text & "'.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        MessageBox.Show("Could not copy folder '" & itemname & "', since target directory is under source directory.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    MessageBox.Show("Folder '" & itemname & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                frmcopyandpaste.copyandpastelistview1.Enabled = True
                                frmcopyandpaste.copyandpastelistview2.Enabled = False
                                Exit Sub
                            End If
                        ElseIf File.Exists(itemlocation) Then
                            Dim filesizetopasteinexplorer As Long = 0
                            filesizetopasteinexplorer = My.Computer.FileSystem.GetFileInfo(itemlocation).Length
                            If remainingspace > filesizetopasteinexplorer Then
                                If Not File.Exists(newcopy) Then
                                    My.Computer.FileSystem.CopyFile(itemlocation, newcopy)
                                Else
                                    MessageBox.Show("File '" & itemname & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                frmcopyandpaste.copyandpastelistview1.Enabled = True
                                frmcopyandpaste.copyandpastelistview2.Enabled = False
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Could not find this item '" & itemname & "'", "Item not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        If frmcopyandpaste.copyandpastelistview2.Items.Count = 0 Then
                            frmexplorer.explorerlistview.Items.Clear()
                            myspace()
                            spaceconsumed()
                            remainingspacee()
                            fileandfolderexplorer()
                            countfilesandfolders()
                            countfilesandfoldersinexplorer()
                        End If
                    End If
                Next
                frmcopyandpaste.copyandpastelistview1.Enabled = True
                frmcopyandpaste.copyandpastelistview2.Enabled = False
            End If
        Else
            frmexplorer.explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Sub myspace()

        If (asinbytes >= 0 And asinbytes < kb) Then
            frmmain.Label4.Text = asinbytes & " bytes"
            frmmyprofile.lblmyspace.Text = asinbytes & " bytes"
            frmmyprofile.lblasinbytes.Text = "(" & Format(asinbytes, "#,##0") & " bytes)"
        ElseIf (asinbytes >= kb AndAlso asinbytes < mb) Then
            frmmain.Label4.Text = Format((asinbytes / 1024), "0.00") & " KB"
            frmmyprofile.lblmyspace.Text = Format((asinbytes / 1024), "0.00") & " KB"
            frmmyprofile.lblasinbytes.Text = "(" & Format(asinbytes, "#,##0") & " bytes)"
        ElseIf (asinbytes >= mb AndAlso asinbytes < gb) Then
            frmmain.Label4.Text = Format((asinbytes / 1024 / 1024), "0.00") & " MB"
            frmmyprofile.lblmyspace.Text = Format((asinbytes / 1024 / 1024), "0.00") & " MB"
            frmmyprofile.lblasinbytes.Text = "(" & Format(asinbytes, "#,##0") & " bytes)"
        ElseIf (asinbytes >= gb) Then
            frmmain.Label4.Text = Format((asinbytes / 1024 / 1024 / 1024), "0.00") & " GB"
            frmmyprofile.lblmyspace.Text = Format((asinbytes / 1024 / 1024 / 1024), "0.00") & " GB"
            frmmyprofile.lblasinbytes.Text = "(" & Format(asinbytes, "#,##0") & " bytes)"
        End If

    End Sub

    Public Sub spaceconsumed()
        totalsize = 0
        For Each item As String In My.Computer.FileSystem.GetFiles(combination, FileIO.SearchOption.SearchAllSubDirectories, "*.*")

            totalsize += My.Computer.FileSystem.GetFileInfo(item).Length
            If (totalsize >= 0 And totalsize < kb) Then
                frmmyprofile.lblsc.Text = Format(totalsize, "#,##0") & " bytes"
                frmmyprofile.lblscib.Text = Format(totalsize, "#,##0") & " bytes"
            ElseIf (totalsize >= kb AndAlso totalsize < mb) Then
                frmmyprofile.lblsc.Text = Format((totalsize / 1024), "0.00") & " KB"
                frmmyprofile.lblscib.Text = "(" & Format(totalsize, "#,##0") & " bytes)"
            ElseIf (totalsize >= mb AndAlso totalsize < gb) Then
                frmmyprofile.lblsc.Text = Format((totalsize / 1024 / 1024), "0.00") & " MB"
                frmmyprofile.lblscib.Text = "(" & Format(totalsize, "#,##0") & " bytes)"
            ElseIf (totalsize >= gb) Then
                frmmyprofile.lblsc.Text = Format((totalsize / 1024 / 1024 / 1024), "0.00") & " GB"
                frmmyprofile.lblscib.Text = "(" & Format(totalsize, "#,##0") & " bytes)"
            End If
        Next

    End Sub

    Public Sub remainingspacee()

        remainingspace = asinbytes - totalsize

        If (remainingspace >= 0 And remainingspace < kb) Then
            frmmain.Label5.Text = remainingspace & " bytes free of " & frmmain.Label4.Text
            frmmyprofile.lblremainingspace.Text = Format(remainingspace, "#,##0") & " bytes"
            frmmyprofile.lblrsb.Text = Format(remainingspace, "#,##0") & " bytes"
        ElseIf (remainingspace >= kb AndAlso remainingspace < mb) Then
            frmmain.Label5.Text = Format((remainingspace / 1024), "0.00") & " KB free of " & frmmain.Label4.Text
            frmmyprofile.lblremainingspace.Text = Format((remainingspace / 1024), "0.00") & " KB"
            frmmyprofile.lblrsb.Text = "(" & Format(remainingspace, "#,##0") & " bytes)"
        ElseIf (remainingspace >= mb AndAlso remainingspace < gb) Then
            frmmain.Label5.Text = Format((remainingspace / 1024 / 1024), "0.00") & " MB free of " & frmmain.Label4.Text
            frmmyprofile.lblremainingspace.Text = Format((remainingspace / 1024 / 1024), "0.00") & " MB"
            frmmyprofile.lblrsb.Text = "(" & Format(remainingspace, "#,##0") & " bytes)"
        ElseIf (remainingspace >= gb) Then
            frmmain.Label5.Text = Format((remainingspace / 1024 / 1024 / 1024), "0.00") & " GB free of " & frmmain.Label4.Text
            frmmyprofile.lblremainingspace.Text = Format((remainingspace / 1024 / 1024 / 1024), "0.00") & " GB"
            frmmyprofile.lblrsb.Text = "(" & Format(remainingspace, "#,##0") & " bytes)"
        End If

    End Sub

    Public Sub countfilesandfolders()

        Dim filenumber As Integer = 0
        Dim foldernumber As Integer = 0

        Dim files As Object = My.Computer.FileSystem.GetFiles(combination, FileIO.SearchOption.SearchAllSubDirectories)
        Dim folders As Object = My.Computer.FileSystem.GetDirectories(combination, FileIO.SearchOption.SearchAllSubDirectories)

        For Each filee In files
            filenumber += 1
        Next
        For Each folderr In folders
            foldernumber += 1
        Next
        frmmyprofile.lbloverallitems.Text = "Files: " & filenumber & "                    Folders: " & foldernumber & "                    Total: " & filenumber + foldernumber
        frmmyprofile.lbltotal.Text = filenumber + foldernumber

    End Sub

    Public Sub countfilesandfoldersinexplorer()

        Dim filenumber As Integer = 0
        Dim foldernumber As Integer = 0

        Dim files As Object = My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchTopLevelOnly)
        Dim folders As Object = My.Computer.FileSystem.GetDirectories(combination2, FileIO.SearchOption.SearchTopLevelOnly)

        For Each filee In files
            filenumber += 1
        Next
        For Each folderr In folders
            foldernumber += 1
        Next

        frmexplorer.lblfiles.Text = filenumber & " files"
        frmexplorer.lblfolders.Text = foldernumber & " folders"
        frmexplorer.lblitems.Text = filenumber + foldernumber & " items"
        If frmexplorer.lblitems.Text = "0 items" Then
            frmexplorer.lblitems.Text = "No items found"
        End If

    End Sub

    Public Sub selectmysubjects()
        cmdselect = "select instructor_subject.subject_name, instructor_subject.subject_description, instructor_subject.subject_time, instructor_subject.subject_day from instructor_subject inner join student_subject on student_subject.subject_id = instructor_subject.subject_id where student_subject.student_id = '" & accountid & "'"
        'cmdselect = "select instructor_subject.subject_name, instructor_subject.subject_description, instructor_subject.subject_time, instructor_subject.subject_day, admin.fullname from instructor_subject inner join student_subject inner join admin on student_subject.subject_id = instructor_subject.subject_id, student_subject.instructor_id = admin.id where student_subject.student_id = '" & accountid & "'"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
    End Sub

    '====================================================== IMPERSONATION =========================================================

    Public Class AliasAccount
        Private _username, _password, _domainname As String

        Private _tokenHandle As New IntPtr(0)
        Private _dupeTokenHandle As New IntPtr(0)
        Private _impersonatedUser As System.Security.Principal.WindowsImpersonationContext


        Public Sub New(ByVal username As String, ByVal password As String)
            Dim nameparts() As String = username.Split("\")
            If nameparts.Length > 1 Then
                _domainname = nameparts(0)
                _username = nameparts(1)
            Else
                _username = username
            End If
            _password = password
        End Sub

        Public Sub New(ByVal username As String, ByVal password As String, ByVal domainname As String)
            _username = username
            _password = password
            _domainname = domainname
        End Sub


        Public Sub BeginImpersonation()
            'Const LOGON32_PROVIDER_DEFAULT As Integer = 0
            'Const LOGON32_LOGON_INTERACTIVE As Integer = 2
            Const LOGON32_LOGON_NEW_CREDENTIALS As Integer = 9
            Const LOGON32_PROVIDER_WINNT50 As Integer = 3
            Const SecurityImpersonation As Integer = 2

            Dim win32ErrorNumber As Integer

            _tokenHandle = IntPtr.Zero
            _dupeTokenHandle = IntPtr.Zero

            If Not LogonUser(_username, _domainname, _password, LOGON32_LOGON_NEW_CREDENTIALS, LOGON32_PROVIDER_WINNT50, _tokenHandle) Then
                win32ErrorNumber = System.Runtime.InteropServices.Marshal.GetLastWin32Error()
                Throw New ImpersonationException(win32ErrorNumber, GetErrorMessage(win32ErrorNumber), _username, _domainname)
            End If

            If Not DuplicateToken(_tokenHandle, SecurityImpersonation, _dupeTokenHandle) Then
                win32ErrorNumber = System.Runtime.InteropServices.Marshal.GetLastWin32Error()

                CloseHandle(_tokenHandle)
                Throw New ImpersonationException(win32ErrorNumber, "Unable to duplicate token!", _username, _domainname)
            End If

            Dim newId As New System.Security.Principal.WindowsIdentity(_dupeTokenHandle)
            _impersonatedUser = newId.Impersonate()
        End Sub


        Public Sub EndImpersonation()
            If Not _impersonatedUser Is Nothing Then
                _impersonatedUser.Undo()
                _impersonatedUser = Nothing

                If Not System.IntPtr.op_Equality(_tokenHandle, IntPtr.Zero) Then
                    CloseHandle(_tokenHandle)
                End If
                If Not System.IntPtr.op_Equality(_dupeTokenHandle, IntPtr.Zero) Then
                    CloseHandle(_dupeTokenHandle)
                End If
            End If
        End Sub


        Public ReadOnly Property username() As String
            Get
                Return _username
            End Get
        End Property

        Public ReadOnly Property domainname() As String
            Get
                Return _domainname
            End Get
        End Property


        Public ReadOnly Property currentWindowsUsername() As String
            Get
                Return System.Security.Principal.WindowsIdentity.GetCurrent().Name
            End Get
        End Property


#Region "Exception Class"
        Public Class ImpersonationException
            Inherits System.Exception

            Public ReadOnly win32ErrorNumber As Integer

            Public Sub New(ByVal win32ErrorNumber As Integer, ByVal msg As String, ByVal username As String, ByVal domainname As String)
                MyBase.New(String.Format("Impersonation of {1}\{0} failed! [{2}] {3}", username, domainname, win32ErrorNumber, msg))
                Me.win32ErrorNumber = win32ErrorNumber
            End Sub
        End Class
#End Region


#Region "External Declarations and Helpers"
        Private Declare Auto Function LogonUser Lib "advapi32.dll" (ByVal lpszUsername As [String], _
                ByVal lpszDomain As [String], ByVal lpszPassword As [String], _
                ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer, _
                ByRef phToken As IntPtr) As Boolean


        Private Declare Auto Function DuplicateToken Lib "advapi32.dll" (ByVal ExistingTokenHandle As IntPtr, _
                    ByVal SECURITY_IMPERSONATION_LEVEL As Integer, _
                    ByRef DuplicateTokenHandle As IntPtr) As Boolean


        Private Declare Auto Function CloseHandle Lib "kernel32.dll" (ByVal handle As IntPtr) As Boolean


        <System.Runtime.InteropServices.DllImport("kernel32.dll")> _
        Private Shared Function FormatMessage(ByVal dwFlags As Integer, ByRef lpSource As IntPtr, _
          ByVal dwMessageId As Integer, ByVal dwLanguageId As Integer, ByRef lpBuffer As [String], _
          ByVal nSize As Integer, ByRef Arguments As IntPtr) As Integer
        End Function


        Private Function GetErrorMessage(ByVal errorCode As Integer) As String
            Dim FORMAT_MESSAGE_ALLOCATE_BUFFER As Integer = &H100
            Dim FORMAT_MESSAGE_IGNORE_INSERTS As Integer = &H200
            Dim FORMAT_MESSAGE_FROM_SYSTEM As Integer = &H1000

            Dim messageSize As Integer = 255
            Dim lpMsgBuf As String = ""
            Dim dwFlags As Integer = FORMAT_MESSAGE_ALLOCATE_BUFFER Or FORMAT_MESSAGE_FROM_SYSTEM Or FORMAT_MESSAGE_IGNORE_INSERTS

            Dim ptrlpSource As IntPtr = IntPtr.Zero
            Dim prtArguments As IntPtr = IntPtr.Zero

            Dim retVal As Integer = FormatMessage(dwFlags, ptrlpSource, errorCode, 0, lpMsgBuf, messageSize, prtArguments)
            If 0 = retVal Then
                Throw New System.Exception("Failed to format message for error code " + errorCode.ToString() + ". ")
            End If

            Return lpMsgBuf
        End Function

#End Region

    End Class

    Public Sub impersonate()

        Dim domain, username, passwordStr, remoteServerName As String
        Dim password As New Security.SecureString
        Dim command As New Process

        'domain = "domain.com"
        domain = ""
        username = serverpcusername
        passwordStr = serverpcpassword
        remoteServerName = remoteserverpcname
        Dim impersonator As New AliasAccount(username, passwordStr)

        'For Each c As Char In passwordStr.ToCharArray
        '    password.AppendChar(c)
        'Next

        'command.StartInfo.FileName = "Koala.jpg"
        ''command.StartInfo.Arguments = "\\" & serverName & "\admin$\Temp"
        'command.StartInfo.Arguments = clientinitialpath 'initial path for client

        'command.StartInfo.UserName = username
        'command.StartInfo.Password = password
        'command.StartInfo.Domain = domain
        'command.StartInfo.Verb = "open"
        'command.StartInfo.UseShellExecute = False

        impersonator.BeginImpersonation()
        'command.Start()
        'impersonator.EndImpersonation()

    End Sub

    Public Class encryptanddecrypt

        Dim DES As New TripleDESCryptoServiceProvider
        Dim MDS As New MD5CryptoServiceProvider

        Function MDShash(value As String) As Byte()

            Return MDS.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))

        End Function

        Function encrypt(stringinput As String, key As String) As String

            DES.Key = MDShash(key)
            DES.Mode = CipherMode.ECB

            Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringinput)

            Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))

        End Function

        Function decrypt(encryptedstring As String, key As String) As String

            DES.Key = MDShash(key)
            DES.Mode = CipherMode.ECB
            Dim buffer As Byte() = Convert.FromBase64String(encryptedstring)

            Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length))

        End Function

    End Class

End Module


