Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmmain

    Dim time As Integer
    Dim selecteditemtorename As String
    Dim pathofselecteditemtorename As String
    Dim itemindex As Integer

    Dim readytoexport As String
    Dim getfilesize As Long = 0
    Dim getfoldersizeoftheselectedfolderinfolderbrowser As Long = 0
    Dim fileorfolder As String
    Dim foldername As String
    Private Const MAX_PATH As Integer = 256
    Private Const NAMESIZE As Integer = 80
    Private Const SHGFI_ICON As Int32 = &H100

    Const wm_nchittest As Integer = &H84
    Const htclient As Integer = &H1
    Const htcaption As Integer = &H2
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case wm_nchittest
                MyBase.WndProc(m)
                If m.Result = htclient Then m.Result = htcaption
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub

    Private Sub frmmain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            button_newfolder.PerformClick()
        End If
    End Sub

    'Private Sub impersonate()

    '    Dim domain, username, passwordStr, remoteServerName As String
    '    'Dim password As New Security.SecureString
    '    Dim command As New Process

    '    'domain = "domain.com"
    '    domain = ""
    '    username = serverpcusername
    '    passwordStr = serverpcpassword
    '    remoteServerName = remoteserverpcname
    '    Dim impersonator As New AliasAccount(username, passwordStr)

    '    'For Each c As Char In passwordStr.ToCharArray
    '    '    password.AppendChar(c)
    '    'Next

    '    'command.StartInfo.FileName = item.SubItems(1).Text
    '    ''command.StartInfo.Arguments = itemlocation
    '    'command.StartInfo.Arguments = clientinitialpath 'initial path for client

    '    'command.StartInfo.UserName = username
    '    'command.StartInfo.Password = password
    '    'command.StartInfo.Domain = domain
    '    'command.StartInfo.Verb = "open"
    '    'command.StartInfo.UseShellExecute = False

    '    impersonator.BeginImpersonation()
    '    'command.Start()
    '    'impersonator.EndImpersonation()

    'End Sub
    '========
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Try
        path = myinitialpath
        combinate = System.IO.Path.Combine(path, maxname)
        combination = System.IO.Path.Combine(combinate, maxname)

        lblaccountid.Text = "ID: " & accountid
        fullname.Text = firstname & " " & middlename & " " & lastname
        lblyc.Text = course & " - " & year

        displayfilesandfolders()
        myspace()
        spaceconsumed()
        remainingspacee()

        TextBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#2d2d2d")
        txtcancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#2d2d2d")

        loadmypicture = path & "\images\" & picname
        If File.Exists(loadmypicture) Then
            Using fs As New System.IO.FileStream(loadmypicture, IO.FileMode.Open, IO.FileAccess.Read)
                ovalpicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
            End Using
        End If
        Me.ControlBox = False
        'Catch ex As Exception
        '    MessageBox.Show("Your key cannot unlock the server.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    'Public Sub displayfilesandfolders()
    '    For Each item As String In My.Computer.FileSystem.GetFiles(combination, FileIO.SearchOption.SearchTopLevelOnly, "*.*")
    '        'icons.Images.Add(Drawing.Icon.ExtractAssociatedIcon(item))
    '        listview.Items.Add(My.Computer.FileSystem.GetName(item))
    '        'listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
    '    Next



    '    For Each item As String In My.Computer.FileSystem.GetDirectories(combination)
    '        icons.Images.Add(GetShellIcon(item))
    '        listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
    '    Next
    'End Sub

    Private Sub opentheitem()


        If Directory.Exists(combination) Then
            Dim path1 As String = combination & "\"
            For Each item As ListViewItem In listview.Items
                If listview.SelectedItems.Count > 0 Then
                    item = listview.SelectedItems.Item(0)
                    Dim itemlocation As String = path1 & (item.SubItems(0).Text)

                    Dim type As String = My.Computer.FileSystem.GetFileInfo(itemlocation).Extension
                    Dim ngalan As String = My.Computer.FileSystem.GetDirectoryInfo(itemlocation).Name
                    If File.Exists(itemlocation & item.SubItems(1).Text) Then
                        '    Dim domain, username, passwordStr, remoteServerName As String
                        '    Dim password As New Security.SecureString
                        '    Dim command As New Process

                        '    domain = "domain.com"
                        '    domain = ""
                        '    username = serverpcusername
                        '    passwordStr = serverpcpassword
                        '    remoteServerName = remoteserverpcname
                        '    Dim impersonator As New AliasAccount(username, passwordStr)

                        '    For Each c As Char In passwordStr.ToCharArray
                        '        password.AppendChar(c)
                        '    Next

                        '    command.StartInfo.FileName = item.SubItems(1).Text
                        '    command.StartInfo.Arguments = itemlocation
                        '    command.StartInfo.Arguments = clientinitialpath 'initial path for client

                        '    command.StartInfo.UserName = username
                        '    command.StartInfo.Password = password
                        '    command.StartInfo.Domain = domain
                        '    command.StartInfo.Verb = "open"
                        '    command.StartInfo.UseShellExecute = False

                        '    impersonator.BeginImpersonation()
                        '    command.Start()
                        '    'impersonator.EndImpersonation()
                        Process.Start(itemlocation & item.SubItems(1).Text)
                        Exit Sub
                    Else
                        frmexplorer.Close()
                        combination2 = System.IO.Path.Combine(combination, ngalan)
                        pathlength = Microsoft.VisualBasic.Len(ngalan) * 2
                        selectedfolderlength = Microsoft.VisualBasic.Len(ngalan)
                        frmexplorer.path2.Text = ngalan
                        frmexplorer.Show()
                    End If
                    listview.Items.Clear()
                    displayfilesandfolders()
                End If
            Next
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub listview_AfterLabelEdit(sender As Object, e As LabelEditEventArgs) Handles listview.AfterLabelEdit

        time = 0
        Timer1.Enabled = True

    End Sub

    Private Sub listview_DoubleClick(sender As Object, e As EventArgs) Handles listview.DoubleClick

        opentheitem()

    End Sub

    Private Sub listview_KeyDown(sender As Object, e As KeyEventArgs) Handles listview.KeyDown

        If Directory.Exists(combination) Then
            If e.KeyCode = Keys.N And e.Modifiers = Keys.Control Then
                If Not Directory.Exists(combination & "\New folder") Then
                    Directory.CreateDirectory(combination & "\New folder")
                    button_refresh.PerformClick()
                Else
                    Dim foldercounter As Integer = 2
                    If Not Directory.Exists(combination & "\New folder (" & foldercounter.ToString & ")") Then
                        Directory.CreateDirectory(combination & "\New folder (" & foldercounter.ToString & ")")
                        button_refresh.PerformClick()
                    Else
                        Do Until Directory.Exists(combination & "\New folder (" & foldercounter.ToString & ")") = False
                            foldercounter += 1
                        Loop
                        Directory.CreateDirectory(combination & "\New folder (" & foldercounter.ToString & ")")
                        button_refresh.PerformClick()
                        Exit Sub
                    End If
                End If
            ElseIf e.KeyCode = Keys.Delete Then
                button_delete.PerformClick()
            ElseIf e.KeyCode = Keys.F2 Then
                listview.LabelEdit = True
                Dim counter As Integer = -1
                For Each item As ListViewItem In listview.Items
                    If listview.SelectedItems.Count > 0 Then
                        item = listview.SelectedItems.Item(0)
                        selecteditemtorename = item.SubItems(0).Text
                        If File.Exists(combination & "\" & item.SubItems(0).Text & item.SubItems(1).Text.ToLower) Then
                            pathofselecteditemtorename = combination & "\" & item.SubItems(0).Text & item.SubItems(1).Text.ToLower
                        ElseIf Directory.Exists(combination & "\" & item.SubItems(0).Text) Then
                            pathofselecteditemtorename = combination & "\" & item.SubItems(0).Text
                        End If
                        item.BeginEdit()
                        item.Selected = False
                    Else
                        Exit Sub
                    End If
                    For Each item2 As ListViewItem In listview.Items
                        counter += 1
                        item2 = listview.Items.Item(counter)
                        Dim itemtocompare As String = combination & "\" & item2.SubItems(0).Text
                        If File.Exists(pathofselecteditemtorename) Then
                            If itemtocompare & item2.SubItems(1).Text.ToLower = pathofselecteditemtorename Then
                                itemindex = counter
                                Exit Sub
                            End If
                        ElseIf Directory.Exists(pathofselecteditemtorename) Then
                            If itemtocompare = pathofselecteditemtorename Then
                                itemindex = counter
                                Exit Sub
                            End If
                        End If
                    Next
                Next
            ElseIf e.KeyCode = Keys.F4 Then
                TextBox1.Focus()
            ElseIf e.KeyCode = Keys.F1 Then
                button_profile.PerformClick()
            ElseIf e.KeyCode = Keys.F5 Then
                button_refresh.PerformClick()
            ElseIf e.KeyCode = Keys.I And e.Modifiers = Keys.Control Then
                button_file.PerformClick()
            ElseIf e.KeyCode = Keys.O And e.Modifiers = Keys.Control Then
                button_folder.PerformClick()
            ElseIf e.KeyCode = Keys.F6 Then
                button_export.PerformClick()
            ElseIf e.KeyCode = Keys.F7 Then
                button_import.PerformClick()
            ElseIf e.KeyCode = Keys.A And e.Modifiers = Keys.Control Then
                For Each item As ListViewItem In listview.Items
                    item.Selected = True
                Next
            ElseIf e.KeyCode = Keys.Enter And e.Modifiers = Keys.Alt Then
                button_details.PerformClick()
            ElseIf e.KeyCode = Keys.C And e.Modifiers = Keys.Control Then
                copyitemsinmain()
            ElseIf e.KeyCode = Keys.V And e.Modifiers = Keys.Control Then
                pasteitemsinmain()
            ElseIf e.KeyCode = Keys.Enter Then
                opentheitem()
            End If
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As Integer
        Public dwAttributes As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=MAX_PATH)>
        Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=NAMESIZE)>
        Public szTypeName As String
    End Structure

    <DllImport("Shell32.dll")>
    Private Shared Function SHGetFileInfo(pszPath As String,
                                          dwFileAttributes As Integer,
                                          ByRef psfi As SHFILEINFO,
                                          cbFileInfo As Integer,
                                          uFlags As Integer) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function DestroyIcon(hIcon As IntPtr) As Boolean
    End Function

    Public Shared Function GetShellIcon(path As String) As Bitmap
        Dim shfi As SHFILEINFO = New SHFILEINFO()

        Dim ret As IntPtr = SHGetFileInfo(path, 0, shfi, Marshal.SizeOf(shfi), SHGFI_ICON)
        If ret <> IntPtr.Zero Then
            Dim bmp As Bitmap = System.Drawing.Icon.FromHandle(shfi.hIcon).ToBitmap
            DestroyIcon(shfi.hIcon)
            Return bmp
        Else
            Return Nothing
        End If
    End Function

    Private Sub btn_duplicate_Click(sender As Object, e As EventArgs)
        ''If Type <> "" Then

        ''Else

        ''End If


        'Dim path1 As String = combination & "\"
        'Dim named As String

        'For Each item As ListViewItem In listview.Items
        '    If listview.SelectedItems.Count > 0 Then
        '        item = listview.SelectedItems.Item(0)
        '        named = path1 & (item.SubItems(0).Text)

        '        Dim type As String = My.Computer.FileSystem.GetFileInfo(named).Extension
        '        'Label1.Text = type

        '        If type <> "" Then
        '            Dim FileToCopy As String
        '            Dim NewCopy As String

        '            FileToCopy = combination & "\" & IO.Path.GetFileName(named)
        '            NewCopy = combination & "\" & IO.Path.GetFileName(named)

        '            'If System.IO.File.Exists(FileToCopy) = True Then

        '            '    System.IO.File.Copy(FileToCopy, NewCopy)
        '            '    MessageBox.Show("File Copied")

        '            'End If


        '            If File.Exists(NewCopy) Then
        '                'MessageBox.Show("file already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '                Dim counter As String = (0)
        '                Dim types As String = My.Computer.FileSystem.GetFileInfo(named).Extension

        '                System.IO.File.Copy(FileToCopy, NewCopy & counter + +counter & types)
        '                MessageBox.Show("File Copied")
        '            Else
        '                System.IO.File.Copy(FileToCopy, NewCopy)
        '                MessageBox.Show("File Copied")
        '            End If
        '        Else
        '            My.Computer.FileSystem.RenameDirectory(named, TextBox1.Text)
        '        End If

        '    End If
        'Next
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.N And e.Modifiers = Keys.Control Then
            button_newfolder.PerformClick()
        ElseIf e.KeyCode = Keys.F1 Then
            button_profile.PerformClick()
        ElseIf e.KeyCode = Keys.F2 Then
            button_rename.PerformClick()
        ElseIf e.KeyCode = Keys.I And e.Modifiers = Keys.Control Then
            button_file.PerformClick()
        ElseIf e.KeyCode = Keys.O And e.Modifiers = Keys.Control Then
            button_folder.PerformClick()
        ElseIf e.KeyCode = Keys.F6 Then
            button_export.PerformClick()
        ElseIf e.KeyCode = Keys.F7 Then
            button_import.PerformClick()
        End If

    End Sub

    'Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
    '    If TextBox1.Text = "" Then
    '        TextBox1.Text = " search"
    '    End If
    'End Sub

    'Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
    '    TextBox1.Text = ""
    'End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Contains("/") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
            MessageBox.Show("Illegal characters detected" & " \ / : * ? < > | "" ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim path1 As String = combination & "\"
        Dim named As String

        For Each item As ListViewItem In listview.Items
            If listview.SelectedItems.Count > 0 Then
                item = listview.SelectedItems.Item(0)
                named = path1 & (item.SubItems(0).Text)
                item.Remove()

                Dim type As String = My.Computer.FileSystem.GetFileInfo(named).Extension
                'Label1.Text = type


            End If
        Next
    End Sub

    Private Sub User_main_close11_Click(sender As Object, e As EventArgs) Handles User_main_close11.Click

        'totalsize = 0
        'frmlogin.txtusername.Text = ""
        'frmlogin.txtpassword.Text = ""
        'frmcopyandpaste.copyandpastelistview1.Items.Clear()
        'frmcopyandpaste.copyandpastelistview2.Items.Clear()
        'logout()
        frmlogout.ShowInTaskbar = False
        frmlogout.ShowDialog()

    End Sub

    Private Sub User_main_minimize11_Click(sender As Object, e As EventArgs) Handles User_main_minimize11.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub button_copy_Click(sender As Object, e As EventArgs) Handles button_copy.Click

        If Directory.Exists(combination) Then
            If TextBox1.Text <> "" Then
                Dim destinationpath As String = System.IO.Path.Combine(combination, TextBox1.Text)
                Dim named As String
                If Directory.Exists(destinationpath) Then
                    For Each item As ListViewItem In listview.Items
                        If listview.SelectedItems.Count > 0 Then
                            item = listview.SelectedItems.Item(0)
                            named = combination & "\" & (item.SubItems(0).Text)
                            item.Selected = False
                            Dim itemtocopys As String = named
                            Dim newcopys As String = destinationpath & "\" & (item.SubItems(0).Text)
                            If Directory.Exists(named) Then
                                Try
                                    If Not Directory.Exists(newcopys) Then
                                        Dim foldersizetocopyinmain As Long = 0
                                        For Each item1 As String In My.Computer.FileSystem.GetFiles(itemtocopys, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                            foldersizetocopyinmain += My.Computer.FileSystem.GetFileInfo(item1).Length
                                        Next
                                        'MsgBox(foldersizetocopyinmain)
                                        If remainingspace > foldersizetocopyinmain Then
                                            My.Computer.FileSystem.CopyDirectory(itemtocopys, newcopys)
                                            listview.Focus()
                                        Else
                                            button_refresh.PerformClick()
                                            MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Exit Sub
                                        End If
                                    Else
                                        MessageBox.Show("Folder '" & item.SubItems(0).Text & "' already exists on the specified destination path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        listview.Focus()
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show("Could not copy folder '" & item.SubItems(0).Text & "', since target directory '" & TextBox1.Text & "' is under source directory '" & item.SubItems(0).Text & "'.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            ElseIf File.Exists(named & item.SubItems(1).Text) Then
                                If Not File.Exists(newcopys & item.SubItems(1).Text) Then
                                    Dim filesizetocopyinmain As Long = 0
                                    filesizetocopyinmain = My.Computer.FileSystem.GetFileInfo(itemtocopys & item.SubItems(1).Text).Length
                                    'MsgBox(filesizetocopyinmain)
                                    If remainingspace > filesizetocopyinmain Then
                                        System.IO.File.Copy(itemtocopys & item.SubItems(1).Text, newcopys & item.SubItems(1).Text)
                                        listview.Focus()
                                    Else
                                        button_refresh.PerformClick()
                                        MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("File '" & item.SubItems(0).Text & "' already exists on the specified destination path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    listview.Focus()
                                End If
                            End If
                            If listview.SelectedItems.Count = 0 Then
                                TextBox1.Text = ""
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Please select an item.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            listview.Focus()
                            Exit Sub
                        End If
                    Next
                Else
                    MessageBox.Show("Destination path '" & TextBox1.Text & "' does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Enter the destination path to complete the process.", "Information Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Focus()
            End If
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click

        If Directory.Exists(combination) Then
            Dim path1 As String = combination & "\"
            For Each item As ListViewItem In listview.Items
                If listview.SelectedItems.Count > 0 Then
                    item = listview.SelectedItems.Item(0)
                    Dim itemlocation As String = path1 & (item.SubItems(0).Text)
                    item.Remove()
                    If File.Exists(itemlocation & item.SubItems(1).Text) Then
                        My.Computer.FileSystem.DeleteFile(itemlocation & item.SubItems(1).Text, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                    Else
                        My.Computer.FileSystem.DeleteDirectory(itemlocation, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                    End If
                Else

                End If
            Next

            totalsize = 0
            myspace()
            spaceconsumed()
            remainingspacee()
            countfilesandfolders()

            If frmmyprofile.lbltotal.Text = "0" Then
                frmmyprofile.lblsc.Text = "00.00"
                frmmyprofile.lblscib.Text = "space consumed in bytes"
            End If
            listview.Focus()
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    'Private Sub fileandfolder()

    '    spaceconsumed()
    '    remainingspacee()
    '    countfilesandfolders()

    'End Sub

    Private Sub button_export_Click_1(sender As Object, e As EventArgs) Handles button_export.Click

        If Directory.Exists(combination) Then
            If readytoexport = "Yes" Then
                If fileorfolder = "File" Then
                    Dim msg As Boolean = False
                    getfilesize = 0
                    Dim itemcounter As Integer = 0
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        getfilesize += My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileNames(x)).Length
                        If remainingspace > getfilesize Then
                            Dim filetocopy As String = OpenFileDialog1.FileNames(x)
                            Dim newcopy As String = System.IO.Path.Combine(combination, OpenFileDialog1.SafeFileNames(x))
                            If Not File.Exists(newcopy) Then
                                My.Computer.FileSystem.CopyFile(filetocopy, newcopy)
                                Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly
                                File.SetAttributes(newcopy, attribute)
                                msg = True
                                itemcounter += 1
                            Else
                                MessageBox.Show("File '" & OpenFileDialog1.SafeFileNames(x) & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            'TextBox1.Text = ""
                            'fileorfolder = ""
                            'spaceconsumed()
                            'remainingspacee()
                            'listview.Items.Clear()
                            'displayfilesandfolders()
                            'TextBox1.ReadOnly = False
                            'txtcancel.Visible = False
                            'TextBox1.Size = New System.Drawing.Size(349, 22)
                            Exit Sub
                        End If
                    Next
                    TextBox1.Text = ""
                    fileorfolder = ""
                    spaceconsumed()
                    remainingspacee()
                    listview.Items.Clear()
                    displayfilesandfolders()
                    OpenFileDialog1.Dispose()
                    TextBox1.ReadOnly = False
                    txtcancel.Visible = False
                    TextBox1.Size = New System.Drawing.Size(349, 22)
                    If msg = True Then
                        If itemcounter > 1 Then
                            MessageBox.Show("Items successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Item successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                ElseIf fileorfolder = "Folder" Then
                    If remainingspace > getfoldersizeoftheselectedfolderinfolderbrowser Then
                        Dim foldertocopy As String = FolderBrowserDialog1.SelectedPath
                        Dim newcopy As String = System.IO.Path.Combine(combination, foldername)
                        If Directory.Exists(newcopy) Then
                            MessageBox.Show("Folder '" & foldername & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            TextBox1.Text = ""
                            fileorfolder = ""
                            TextBox1.ReadOnly = False
                            txtcancel.Visible = False
                            TextBox1.Size = New System.Drawing.Size(349, 22)
                            Exit Sub
                        Else

                            My.Computer.FileSystem.CopyDirectory(foldertocopy, newcopy)
                            Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly
                            For Each Files In My.Computer.FileSystem.GetFiles(newcopy, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                File.SetAttributes(Files, attribute)
                            Next
                            listview.Items.Clear()
                            displayfilesandfolders()
                            spaceconsumed()
                            remainingspacee()
                            TextBox1.Text = ""
                            fileorfolder = ""
                            TextBox1.ReadOnly = False
                            txtcancel.Visible = False
                            FolderBrowserDialog1.Dispose()
                            TextBox1.Size = New System.Drawing.Size(349, 22)
                            MessageBox.Show("Item successfully exported", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            readytoexport = "No"
                        End If
                    Else
                        MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'TextBox1.Text = ""
                        'fileorfolder = ""
                        'TextBox1.ReadOnly = False
                        'txtcancel.Visible = False
                        'FolderBrowserDialog1.Dispose()
                        'TextBox1.Size = New System.Drawing.Size(349, 22)
                        Exit Sub
                    End If
                End If
            ElseIf readytoexport = "No" Then
                MessageBox.Show("Select an item to export.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = myinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub button_newfolder_Click(sender As Object, e As EventArgs) Handles button_newfolder.Click

        If Directory.Exists(combination) Then
            Dim folder As String
            folder = System.IO.Path.Combine(combination, TextBox1.Text)
            If TextBox1.Text <> "" Then
                If Not Directory.Exists(folder) Then

                    If TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
                        MessageBox.Show("Illegal characters detected" & " \ / : * ? < > | "" ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        TextBox1.Text = ""
                    ElseIf TextBox1.Text = "con" Or TextBox1.Text = "Con" Or TextBox1.Text = "cOn" Or TextBox1.Text = "coN" Or TextBox1.Text = "COn" Or TextBox1.Text = "CoN" Or TextBox1.Text = "cON" Or TextBox1.Text = "CON" Then
                        MessageBox.Show("Invalid name con", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Directory.CreateDirectory(folder)
                        listview.Items.Clear()
                        refresher()
                        listview.Focus()
                        TextBox1.Text = ""
                    End If
                Else
                    If TextBox1.Text.Contains("\") Then
                        MessageBox.Show("Illegal characters detected" & " \ / : * ? < > | "" ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Folder already exists on this location", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        listview.Focus()
                        Exit Sub
                    End If
                End If
            Else
                If Not Directory.Exists(combination & "\New folder") Then
                    Directory.CreateDirectory(combination & "\New folder")
                    button_refresh.PerformClick()
                Else
                    Dim foldercounter As Integer = 2
                    If Not Directory.Exists(combination & "\New folder (" & foldercounter.ToString & ")") Then
                        Directory.CreateDirectory(combination & "\New folder (" & foldercounter.ToString & ")")
                        button_refresh.PerformClick()
                    Else
                        Do Until Directory.Exists(combination & "\New folder (" & foldercounter.ToString & ")") = False
                            foldercounter += 1
                        Loop
                        Directory.CreateDirectory(combination & "\New folder (" & foldercounter.ToString & ")")
                        button_refresh.PerformClick()
                        listview.Focus()
                        Exit Sub
                    End If
                End If
            End If
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub button_refresh_Click(sender As Object, e As EventArgs) Handles button_refresh.Click
        refresher()
    End Sub
    Private Sub refresher()

        'Try
        If Directory.Exists(combination) Then
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)

            listview.Items.Clear()
            myspace()
            spaceconsumed()
            remainingspacee()
            displayfilesandfolders()
            countfilesandfolders()

            button_search.Enabled = True
            button_refresh.Enabled = True
            button_newfolder.Enabled = True
            button_copy.Enabled = True
            button_export.Enabled = True
            button_rename.Enabled = True
            button_file.Enabled = True
            button_folder.Enabled = True
            button_delete.Enabled = True
            TextBox1.Enabled = True
            'powerrefresher()
            listview.Focus()
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub button_rename_Click(sender As Object, e As EventArgs) Handles button_rename.Click

        If Directory.Exists(combination) Then
            Dim path1 As String = combination & "\"
            For Each item As ListViewItem In listview.Items
                If listview.SelectedItems.Count > 0 Then
                    item = listview.SelectedItems.Item(0)
                    Dim itemlocation As String = path1 & (item.SubItems(0).Text)

                    If TextBox1.Text <> "" Then
                        If File.Exists(itemlocation & item.SubItems(1).Text) Then
                            If Not File.Exists(combination & "\" & TextBox1.Text & item.SubItems(1).Text) Then
                                If TextBox1.Text = "con" Or TextBox1.Text = "Con" Or TextBox1.Text = "cOn" Or TextBox1.Text = "coN" Or TextBox1.Text = "COn" Or TextBox1.Text = "CoN" Or TextBox1.Text = "cON" Or TextBox1.Text = "CON" Then
                                    MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    TextBox1.Text = ""
                                    Exit Sub
                                Else
                                    If TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
                                        MessageBox.Show("A filename can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        TextBox1.Text = ""
                                        Exit Sub
                                    Else
                                        My.Computer.FileSystem.RenameFile(itemlocation & item.SubItems(1).Text, TextBox1.Text & item.SubItems(1).Text)
                                        listview.Items.Clear()
                                        displayfilesandfolders()
                                        TextBox1.Text = ""
                                        Exit Sub
                                    End If
                                End If
                            Else
                                MessageBox.Show("Could not complete operation since a file already exists in this path.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                TextBox1.Text = ""
                                Exit Sub
                            End If
                        ElseIf Directory.Exists(itemlocation) Then
                            If TextBox1.Text = "con" Or TextBox1.Text = "Con" Or TextBox1.Text = "cOn" Or TextBox1.Text = "coN" Or TextBox1.Text = "COn" Or TextBox1.Text = "CoN" Or TextBox1.Text = "cON" Or TextBox1.Text = "CON" Then
                                MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                TextBox1.Text = ""
                                Exit Sub
                            ElseIf Directory.Exists(combination & "\" & TextBox1.Text) Then
                                MessageBox.Show("Could not complete operation since a directory already exists in this path.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                TextBox1.Text = ""
                                Exit Sub
                            Else
                                If TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
                                    MessageBox.Show("A foldername can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    TextBox1.Text = ""
                                    Exit Sub
                                Else
                                    Try
                                        My.Computer.FileSystem.RenameDirectory(itemlocation, TextBox1.Text)
                                        listview.Items.Clear()
                                        displayfilesandfolders()
                                        TextBox1.Text = ""
                                        Exit Sub
                                    Catch ex As Exception
                                        MessageBox.Show("The action can't be completed because the folder or a file in it is open in another program.", "Folder in Use", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        Exit Sub
                                    End Try
                                End If
                            End If
                        End If
                    Else
                        MessageBox.Show("Name cannot be null.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox1.Focus()
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Please select an item.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    listview.Focus()
                    Exit Sub
                End If
            Next

            listview.Items.Clear()
            displayfilesandfolders()
            TextBox1.Text = ""
            listview.Focus()
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub button_file_Click(sender As Object, e As EventArgs) Handles button_file.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim counter As Integer = 0
            getfilesize = 0
            Dim filename As String = ""
            For x = 0 To OpenFileDialog1.FileNames.Count - 1
                getfilesize += My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileNames(x)).Length
                counter += 1
                filename = OpenFileDialog1.SafeFileNames(x)
            Next
            Dim size As String = ""
            If (getfilesize >= 0 And getfilesize < kb) Then
                size = getfilesize & " bytes"
            ElseIf (getfilesize >= kb AndAlso getfilesize < mb) Then
                size = Format((getfilesize / 1024), "0") & " KB"
            ElseIf (getfilesize >= mb AndAlso getfilesize < gb) Then
                size = Format((getfilesize / 1024 / 1024), "0.0") & " MB"
            ElseIf (getfilesize >= gb) Then
                size = Format((getfilesize / 1024 / 1024 / 1024), "0.0") & " GB"
            End If
            If counter = 1 Then
                TextBox1.Text = filename & " - " & size
            Else
                TextBox1.Text = counter & " files - " & size
            End If
            TextBox1.ReadOnly = True
            TextBox1.Size = New System.Drawing.Size(319, 22)
            txtcancel.Visible = True
            readytoexport = "Yes"
            fileorfolder = "File"

        End If

    End Sub

    Private Sub button_folder_Click(sender As Object, e As EventArgs) Handles button_folder.Click
        'Try
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            FolderBrowserDialog1.Description = ""
            Dim foldersize As String = ""
            getfoldersizeoftheselectedfolderinfolderbrowser = 0
            Try
                For Each item As String In My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                    getfoldersizeoftheselectedfolderinfolderbrowser += My.Computer.FileSystem.GetFileInfo(item).Length
                Next
            Catch ex As Exception
                MessageBox.Show("Acces to the path '" & FolderBrowserDialog1.SelectedPath & "' is denied.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If (getfoldersizeoftheselectedfolderinfolderbrowser >= 0 And getfoldersizeoftheselectedfolderinfolderbrowser < kb) Then
                foldersize = getfoldersizeoftheselectedfolderinfolderbrowser & " bytes"
            ElseIf (getfoldersizeoftheselectedfolderinfolderbrowser >= kb AndAlso getfoldersizeoftheselectedfolderinfolderbrowser < mb) Then
                foldersize = Format((getfoldersizeoftheselectedfolderinfolderbrowser / 1024), "0") & " KB"
            ElseIf (getfoldersizeoftheselectedfolderinfolderbrowser >= mb AndAlso getfoldersizeoftheselectedfolderinfolderbrowser < gb) Then
                foldersize = Format((getfoldersizeoftheselectedfolderinfolderbrowser / 1024 / 1024), "0.0") & " MB"
            ElseIf (getfoldersizeoftheselectedfolderinfolderbrowser >= gb) Then
                foldersize = Format((getfoldersizeoftheselectedfolderinfolderbrowser / 1024 / 1024 / 1024), "0.0") & " GB"
            End If

            Dim spliter As String() = FolderBrowserDialog1.SelectedPath.Split("\")
            foldername = spliter.Last.Trim
            TextBox1.Text = foldername & " - " & foldersize
            TextBox1.ReadOnly = True
            fileorfolder = "Folder"
            TextBox1.Size = New System.Drawing.Size(319, 22)
            txtcancel.Visible = True
            readytoexport = "Yes"

        End If

        'Catch ex As Exception
        '    MsgBox(Err.ToString)
        'End Try
    End Sub


    Private Sub btn_import1_Click(sender As Object, e As EventArgs) Handles btn_import1.Click


        Dim path1 As String = combination & "\"
        Dim named As String

        For Each item As ListViewItem In listview.Items
            If listview.SelectedItems.Count > 0 Then
                item = listview.SelectedItems.Item(0)
                named = path1 & (item.SubItems(0).Text)
                'item.Remove()

                Dim ext As String = My.Computer.FileSystem.GetFileInfo(named).Extension
                'Label1.Text = type

                If ext <> "" Then
                    Dim FileToCopy As String
                    Dim NewCopy As String
                    Dim transfer As String

                    FileToCopy = named
                    transfer = "C:\Users\Boss\Desktop"
                    NewCopy = transfer & "\" & (item.SubItems(0).Text)

                    'If System.IO.File.Exists(FileToCopy) = True Then

                    '    System.IO.File.Copy(FileToCopy, NewCopy)
                    '    MessageBox.Show("File Copied")

                    'End If

                    If Directory.Exists(transfer) = True Then
                        If File.Exists(NewCopy) Then
                            MessageBox.Show("file already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            listview.Items.Clear()
                        Else

                            If NewCopy.Contains(combination) = False Then
                                MessageBox.Show("trying to cheat? you motherfucker?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                listview.Items.Clear()
                            Else
                                System.IO.File.Copy(FileToCopy, NewCopy)
                                MessageBox.Show("File Copied")
                                listview.Items.Clear()
                            End If
                        End If
                    Else
                        MessageBox.Show("destination path does not exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        listview.Items.Clear()
                    End If

                Else
                    Dim path As String = named
                    Dim transferfolder As String = "C:\Users\Boss\Desktop"
                    Dim destination As String = transferfolder & "\" & (item.SubItems(0).Text)

                    'My.Computer.FileSystem.CopyDirectory("C:\TestDirectory1", "C:\TestDirectory2", True)

                    If Directory.Exists(transferfolder) = False Then
                        MessageBox.Show("destination path does not exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        listview.Items.Clear()
                    Else

                        If Directory.Exists(destination) = True Then
                            MessageBox.Show("folder already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            listview.Items.Clear()
                        Else
                            My.Computer.FileSystem.CopyDirectory(path, destination, True)
                            'MsgBox("Folder Copied")
                            listview.Items.Clear()
                        End If

                    End If
                End If

            End If
        Next

        listview.Items.Clear()

        displayfilesandfolders()

        TextBox1.Text = ""
    End Sub

    Private Sub listview_Leave(sender As Object, e As EventArgs) Handles listview.Leave
        Timer1.Enabled = True
        Exit Sub
    End Sub

    Private Sub button_details_Click(sender As Object, e As EventArgs) Handles button_details.Click

        If Directory.Exists(combination) Then
            Dim path1 As String = combination & "\"
            For Each item As ListViewItem In listview.Items
                If listview.SelectedItems.Count > 0 Then
                    item = listview.SelectedItems.Item(0)
                    Dim itemlocation As String = path1 & (item.SubItems(0).Text)
                    deleteiteminitemproperties = "main"
                    If File.Exists(itemlocation & item.SubItems(1).Text) Then
                        frmfiledetails.Close()

                        getpathinpropertiesfordelete = itemlocation & item.SubItems(1).Text
                        frmfiledetails.PictureBox1.BackgroundImage = frmmain.GetShellIcon(itemlocation & item.SubItems(1).Text)
                        fname = IO.Path.GetFileNameWithoutExtension(itemlocation & item.SubItems(1).Text)
                        fsize = My.Computer.FileSystem.GetFileInfo(itemlocation & item.SubItems(1).Text).Length

                        If (fsize >= 0 And fsize < kb) Then
                            frmfiledetails.txtsize.Text = Format(fsize, "#,##0") & " bytes"
                        ElseIf (fsize >= kb AndAlso fsize < mb) Then
                            frmfiledetails.txtsize.Text = Format((fsize / 1024), "0") & " KB" & " (" & Format(fsize, "#,##0") & " bytes)"
                            'Label3.Text = Format(6648972.265, "#,##0.00")
                        ElseIf (fsize >= mb AndAlso fsize < gb) Then
                            frmfiledetails.txtsize.Text = Format((fsize / 1024 / 1024), "0.0") & " MB" & " (" & Format(fsize, "#,##0") & " bytes)"
                        ElseIf (fsize >= gb) Then
                            frmfiledetails.txtsize.Text = Format((fsize / 1024 / 1024 / 1024), "0.0") & " GB" & " (" & Format(fsize, "#,##0") & " bytes)"
                        End If

                        ftype = (UCase(My.Computer.FileSystem.GetFileInfo(itemlocation & item.SubItems(1).Text).Extension))
                        flastmodified = My.Computer.FileSystem.GetFileInfo(itemlocation & item.SubItems(1).Text).CreationTime
                        flastaccesstime = My.Computer.FileSystem.GetFileInfo(itemlocation & item.SubItems(1).Text).LastAccessTime
                        flastwritetime = My.Computer.FileSystem.GetFileInfo(itemlocation & item.SubItems(1).Text).LastWriteTime

                        frmfiledetails.ShowInTaskbar = False
                        frmfiledetails.ShowDialog()
                        'listview.Items.Clear()
                        'displayfilesandfolders()
                        Exit Sub

                    ElseIf Directory.Exists(itemlocation) Then
                        frmfiledetails.Close()

                        getpathinpropertiesfordelete = itemlocation
                        frmfiledetails.PictureBox1.BackgroundImage = frmmain.GetShellIcon(itemlocation)
                        fname = My.Computer.FileSystem.GetDirectoryInfo(itemlocation).Name
                        For Each itemfolder As String In My.Computer.FileSystem.GetFiles(itemlocation, FileIO.SearchOption.SearchAllSubDirectories, "*.*")

                            foldersayz += My.Computer.FileSystem.GetFileInfo(itemfolder).Length

                            If (foldersayz >= 0 And foldersayz < kb) Then
                                frmfiledetails.txtfoldersize.Text = Format(foldersayz, "#,##0") & " bytes"
                            ElseIf (foldersayz >= kb AndAlso foldersayz < mb) Then
                                frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024), "0") & " KB" & " (" & Format(foldersayz, "#,##0") & " bytes)"
                            ElseIf (foldersayz >= mb AndAlso foldersayz < gb) Then
                                frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024 / 1024), "0.0") & " MB" & " (" & Format(foldersayz, "#,##0") & " bytes)"
                            ElseIf (foldersayz >= gb) Then
                                frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024 / 1024 / 1024), "0.0") & " GB" & " (" & Format(foldersayz, "#,##0") & " bytes)"
                            End If

                        Next

                        ftype = "Folder"


                        Dim filenumber As Integer = 0
                        Dim foldernumber As Integer = 0

                        Dim files As Object = My.Computer.FileSystem.GetFiles(itemlocation, FileIO.SearchOption.SearchAllSubDirectories)
                        Dim folders As Object = My.Computer.FileSystem.GetDirectories(itemlocation, FileIO.SearchOption.SearchAllSubDirectories)

                        For Each filee In files
                            filenumber += 1
                        Next
                        For Each folderr In folders
                            foldernumber += 1
                        Next

                        ffilenumber = filenumber
                        ffoldernumber = foldernumber
                        ftotalitems = filenumber + foldernumber

                        flastmodified = My.Computer.FileSystem.GetDirectoryInfo(itemlocation).CreationTime
                        flastmodified = My.Computer.FileSystem.GetDirectoryInfo(itemlocation).LastAccessTime
                        flastwritetime = My.Computer.FileSystem.GetDirectoryInfo(itemlocation).LastWriteTime
                        frmfiledetails.folderdetailpanel.Visible = True

                        frmfiledetails.ShowInTaskbar = False
                        frmfiledetails.ShowDialog()
                        Exit Sub

                    End If
                Else
                    MessageBox.Show("Please select an item", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    listview.Focus()
                    Exit Sub
                End If
            Next
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub button_profile_Click(sender As Object, e As EventArgs) Handles button_profile.Click

        If Directory.Exists(combination) Then
            frmmyprofile.Close()
            myspace()
            spaceconsumed()
            remainingspacee()
            countfilesandfolders()
            'frmmyprofile.ShowInTaskbar = False
            frmmyprofile.Show()
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub button_search_Click(sender As Object, e As EventArgs) Handles button_search.Click
        frmfilenavigator.Show()
    End Sub

    Private Sub txtcancel_Click(sender As Object, e As EventArgs) Handles txtcancel.Click

        fileorfolder = ""
        TextBox1.Text = ""
        OpenFileDialog1.Dispose()
        FolderBrowserDialog1.Dispose()
        txtcancel.Visible = False
        TextBox1.ReadOnly = False
        TextBox1.Size = New System.Drawing.Size(349, 22)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim folder As String = System.IO.Path.Combine(combination, TextBox1.Text)
        Directory.CreateDirectory(folder)
    End Sub

    Private Sub ovalpicture_Click(sender As Object, e As EventArgs) Handles ovalpicture.Click

        If Directory.Exists(combination) Then
            frmmyprofile.Close()
            myspace()
            spaceconsumed()
            remainingspacee()
            countfilesandfolders()
            'frmmyprofile.ShowInTaskbar = False
            frmmyprofile.Show()
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = clientinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub button_import_Click(sender As Object, e As EventArgs) Handles button_import.Click

        If Directory.Exists(combination) Then
            Dim itemcounter As Integer = 0

            For Each item As ListViewItem In listview.Items
                If listview.SelectedItems.Count = 0 Then
                    MessageBox.Show("Please select an item to import.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    listview.Focus()
                    Exit Sub
                End If
            Next
            frmimport.exportlistview.Items.Clear()
            frmimport.exportlistview.Columns.Clear()
            frmimport.exportlistview.View = View.Details
            frmimport.exportlistview.Columns.Add("Item Name", 200, HorizontalAlignment.Left)
            frmimport.exportlistview.Columns.Add("Item Location", 800, HorizontalAlignment.Left)
            For Each item As ListViewItem In listview.Items
                If listview.SelectedItems.Count > 0 Then
                    item = listview.SelectedItems.Item(0)
                    If item.SubItems(1).Text = "Folder" Then
                        Dim lvi As New ListViewItem(item.SubItems(0).Text)
                        lvi.SubItems.Add(combination & "\" & item.SubItems(0).Text)
                        frmimport.exportlistview.Items.Add(lvi)
                        itemcounter += 1
                        item.Selected = False
                    Else
                        Dim lvi As New ListViewItem(item.SubItems(0).Text & item.SubItems(1).Text)
                        lvi.SubItems.Add(combination & "\" & item.SubItems(0).Text & item.SubItems(1).Text)
                        frmimport.exportlistview.Items.Add(lvi)
                        itemcounter += 1
                        item.Selected = False
                    End If
                End If
            Next
            If FolderBrowserDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
                For Each item As ListViewItem In frmimport.exportlistview.Items
                    Dim msg As Boolean = False
                    If frmimport.exportlistview.Items.Count > 1 Then
                        msg = True
                    ElseIf frmimport.exportlistview.Items.Count = 1 Then
                        msg = True
                    End If
                    If frmimport.exportlistview.Items.Count > 0 Then
                        item = frmimport.exportlistview.Items.Item(0)
                        If File.Exists(item.SubItems(1).Text) Then
                            If Not File.Exists(FolderBrowserDialog2.SelectedPath & "\" & item.SubItems(0).Text) Then
                                My.Computer.FileSystem.CopyFile(item.SubItems(1).Text, FolderBrowserDialog2.SelectedPath & "\" & item.SubItems(0).Text)
                                Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly = False
                                File.SetAttributes(FolderBrowserDialog2.SelectedPath & "\" & item.SubItems(0).Text, attribute)
                                'itemcounter += 1
                            Else
                                MessageBox.Show("File '" & item.SubItems(0).Text & "' already exists on the selected path.'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                itemcounter -= 1
                                'If itemcounter = 0 Then
                                '    Exit Sub
                                'End If
                            End If
                        ElseIf Directory.Exists(item.SubItems(1).Text) Then
                            If Not Directory.Exists(FolderBrowserDialog2.SelectedPath & "\" & item.SubItems(0).Text) Then
                                My.Computer.FileSystem.CopyDirectory(item.SubItems(1).Text, FolderBrowserDialog2.SelectedPath & "\" & item.SubItems(0).Text)
                                Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly = False
                                For Each Files In My.Computer.FileSystem.GetFiles(FolderBrowserDialog2.SelectedPath & "\" & item.SubItems(0).Text, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                    File.SetAttributes(Files, attribute)
                                Next
                                'itemcounter += 1
                            Else
                                MessageBox.Show("Folder '" & item.SubItems(0).Text & "' already exists on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                itemcounter -= 1
                                'If itemcounter = 0 Then
                                '    Exit Sub
                                'End If
                            End If
                        End If
                        item.Remove()
                        If frmimport.exportlistview.Items.Count = 0 Then
                            If msg = True Then
                                If itemcounter > 1 Then
                                    MessageBox.Show("Items successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ElseIf itemcounter = 1 Then
                                    MessageBox.Show("Item successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = myinitialpath
            combinate = System.IO.Path.Combine(path, maxname)
            combination = System.IO.Path.Combine(combinate, maxname)
        End If

    End Sub

    Private Sub renamefileinmain()

        For Each item As ListViewItem In listview.Items
            item = listview.Items.Item(itemindex)
            If File.Exists(pathofselecteditemtorename) Then
                If Not File.Exists(combination & "\" & item.SubItems(0).Text & item.SubItems(1).Text) Then
                    If item.SubItems(0).Text.Contains("\") Or item.SubItems(0).Text.Contains("/") Or item.SubItems(0).Text.Contains("*") Or item.SubItems(0).Text.Contains("?") Or item.SubItems(0).Text.Contains("<") Or item.SubItems(0).Text.Contains(":") Or item.SubItems(0).Text.Contains(">") Or item.SubItems(0).Text.Contains("|") Or item.SubItems(0).Text.Contains("""") Then
                        MessageBox.Show("A filename can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        listview.Items.Clear()
                        displayfilesandfolders()
                        Exit Sub
                    ElseIf item.SubItems(0).Text = "con" Or item.SubItems(0).Text = "Con" Or item.SubItems(0).Text = "cOn" Or item.SubItems(0).Text = "coN" Or item.SubItems(0).Text = "COn" Or item.SubItems(0).Text = "cON" Or item.SubItems(0).Text = "CoN" Or item.SubItems(0).Text = "CON" Then
                        MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        listview.Items.Clear()
                        displayfilesandfolders()
                        Exit Sub
                    Else
                        My.Computer.FileSystem.RenameFile(pathofselecteditemtorename, item.SubItems(0).Text & item.SubItems(1).Text.ToLower)
                        listview.Items.Clear()
                        displayfilesandfolders()
                        itemindex = 0
                        Exit Sub
                    End If
                ElseIf selecteditemtorename = item.SubItems(0).Text Then
                    Exit Sub
                Else
                    Timer1.Dispose()
                    pathofselecteditemtorename = ""
                    MessageBox.Show("Could not complete operation since a file already exists in this path.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    listview.Items.Clear()
                    displayfilesandfolders()
                    listview.Focus()
                    Exit Sub
                End If
            ElseIf Directory.Exists(pathofselecteditemtorename) Then
                If Not Directory.Exists(combination & "\" & item.SubItems(0).Text) Then
                    If item.SubItems(0).Text.Contains("\") Or item.SubItems(0).Text.Contains("/") Or item.SubItems(0).Text.Contains("*") Or item.SubItems(0).Text.Contains("?") Or item.SubItems(0).Text.Contains("<") Or item.SubItems(0).Text.Contains(":") Or item.SubItems(0).Text.Contains(">") Or item.SubItems(0).Text.Contains("|") Or item.SubItems(0).Text.Contains("""") Then
                        MessageBox.Show("A foldername can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        listview.Items.Clear()
                        displayfilesandfolders()
                        Exit Sub
                    ElseIf item.SubItems(0).Text = "con" Or item.SubItems(0).Text = "Con" Or item.SubItems(0).Text = "cOn" Or item.SubItems(0).Text = "coN" Or item.SubItems(0).Text = "COn" Or item.SubItems(0).Text = "cON" Or item.SubItems(0).Text = "CoN" Or item.SubItems(0).Text = "CON" Then
                        MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        listview.Items.Clear()
                        displayfilesandfolders()
                        Exit Sub
                    Else
                        Try
                            My.Computer.FileSystem.RenameDirectory(pathofselecteditemtorename, item.SubItems(0).Text)
                            listview.Items.Clear()
                            displayfilesandfolders()
                            itemindex = 0
                        Catch ex As Exception
                            MessageBox.Show("The action can't be completed because the folder or a file in it is open in another program.", "Folder in Use", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            listview.Items.Clear()
                            displayfilesandfolders()
                            Exit Sub
                        End Try
                    End If
                    Exit Sub
                ElseIf selecteditemtorename = item.SubItems(0).Text Then
                    Exit Sub
                Else
                    Timer1.Dispose()
                    pathofselecteditemtorename = ""
                    MessageBox.Show("Could not complete operation since a directory already exists in this path.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    listview.Items.Clear()
                    displayfilesandfolders()
                    listview.Focus()
                    Exit Sub
                End If
            End If
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = Val(time) + 1
        If time = 1 Then
            renamefileinmain()
            time = 0
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub listview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview.SelectedIndexChanged

    End Sub
End Class
