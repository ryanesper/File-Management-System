Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmexplorer

    Dim itempath As String
    Dim time As Integer
    Dim selecteditemtorename As String
    Dim pathofselecteditemtorename As String
    Dim itemindex As Integer

    Dim foldername As String
    Dim trimmedpath As String
    Dim getfoldersizeoftheselectedfolderinfolderbrowser As Long = 0
    Dim fileorfolder As String
    Dim getfilesize As Long = 0

    Private Const MAX_PATH As Integer = 256
    Private Const NAMESIZE As Integer = 80
    Private Const SHGFI_ICON As Int32 = &H100
    Dim pathcounter As String
    Dim ngalan As String
    Dim separatepath As String
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

    Private Sub frmexplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtpathlength.Text = pathlength
        txtselecetditemlength.Text = selectedfolderlength

        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#252933")
        explorerlistview.BackColor = System.Drawing.ColorTranslator.FromHtml("#252933")
        Label9.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040")
        Label11.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040")
        txtcancel.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040")
        btncancel2.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040")

        cbofileorfolder.Text = "File"
        cboviewmode.Text = "Details"
        If cboviewmode.Text = "Large Icons" Then
            explorerlistview.View = View.LargeIcon
        ElseIf cboviewmode.Text = "Small Icons" Then
            explorerlistview.View = View.SmallIcon
        ElseIf cboviewmode.Text = "List" Then
            explorerlistview.View = View.List
        ElseIf cboviewmode.Text = "Details" Then
            explorerlistview.View = View.Details
        ElseIf cboviewmode.Text = "Tiles" Then
            explorerlistview.View = View.Tile
        End If
        explorerlistview.Items.Clear()
        fileandfolderexplorer()
        countfilesandfoldersinexplorer()

    End Sub

    Private Sub opentheitem()

        If Directory.Exists(combination2) Then
            If txtsearch.Text = "" Then
                Dim path1 As String = combination2 & "\"
                Dim named1, filetype As String

                For Each item1 As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item1 = explorerlistview.SelectedItems.Item(0)
                        named1 = path1 & item1.SubItems(0).Text
                        filetype = item1.SubItems(2).Text.ToLower

                        Dim type As String = My.Computer.FileSystem.GetFileInfo(named1).Extension
                        ngalan = My.Computer.FileSystem.GetDirectoryInfo(named1).Name

                        If File.Exists(named1 & filetype) Then
                            'Process.Start(named1 & filetype)
                            Exit Sub
                        ElseIf Directory.Exists(named1) Then
                            path2.Text += "\" & ngalan
                            combination2 += "\" & ngalan

                            txtexploreritemlength.Text = Microsoft.VisualBasic.Len(ngalan)
                            txtcombination2length.Text = Microsoft.VisualBasic.Len(combination2)
                            txtexplorerpathlength.Text = Microsoft.VisualBasic.Len(path2.Text)

                            If txtselecetditemlength.Text = txtexplorerpathlength.Text Then
                                btnback.Enabled = False
                            Else
                                btnback.Enabled = True
                            End If
                        End If
                        explorerlistview.Items.Clear()
                        fileandfolderexplorer()
                        countfilesandfoldersinexplorer()
                    End If
                Next
            Else ' ======================================== In search mode ================================================
                Dim path1 As String = combination2 & "\"
                Dim named1, filename, replace, filetype As String

                For Each item1 As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item1 = explorerlistview.SelectedItems.Item(0)
                        filename = item1.SubItems(0).Text
                        filetype = item1.SubItems(2).Text.ToLower
                        named1 = item1.SubItems(4).Text
                        replace = named1.Replace("..", combination)
                        Dim filetoopen As String = replace & "\" & filename & filetype

                        Dim type As String = My.Computer.FileSystem.GetFileInfo(named1).Extension
                        ngalan = My.Computer.FileSystem.GetDirectoryInfo(named1).Name

                        If File.Exists(filetoopen) Then
                            Process.Start(filetoopen)
                            Exit Sub
                        Else
                            For Each item As String In My.Computer.FileSystem.GetDirectories(combination2, FileIO.SearchOption.SearchAllSubDirectories)
                                If item.Contains(txtsearch.Text) Then
                                    Dim pathtoreplace As String
                                    Dim location As String = item1.SubItems(4).Text & "\" & item1.SubItems(0).Text
                                    pathtoreplace = location.Replace("..\", combination & "\")
                                    path2.Text = location.Replace("..\", "")
                                    combination2 = pathtoreplace
                                    txtexploreritemlength.Text = Microsoft.VisualBasic.Len(ngalan)
                                    txtcombination2length.Text = Microsoft.VisualBasic.Len(combination2)
                                    txtexplorerpathlength.Text = Microsoft.VisualBasic.Len(path2.Text)
                                    txtsearch.Text = ""
                                    If txtselecetditemlength.Text = txtexplorerpathlength.Text Then
                                        btnback.Enabled = False
                                    Else
                                        btnback.Enabled = True
                                    End If
                                    Exit Sub
                                End If
                            Next
                        End If
                        If txtsearch.Text = "" Then
                            explorerlistview.Items.Clear()
                            fileandfolderexplorer()
                            countfilesandfoldersinexplorer()
                        Else

                        End If
                    End If
                Next
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub explorerlistview_AfterLabelEdit(sender As Object, e As LabelEditEventArgs) Handles explorerlistview.AfterLabelEdit
        time = 0
        Timer1.Enabled = True
    End Sub

    Private Sub explorerlistview_DoubleClick(sender As Object, e As EventArgs) Handles explorerlistview.DoubleClick

        opentheitem()
        
    End Sub

    Private Sub explorerlistview_KeyDown(sender As Object, e As KeyEventArgs) Handles explorerlistview.KeyDown

        If Directory.Exists(combination2) Then
            If e.KeyCode = Keys.Delete Then
                btn_delete.PerformClick()
            ElseIf e.KeyCode = Keys.F5 Then
                btnrefresh.PerformClick()
            ElseIf e.KeyCode = Keys.F2 Then
                If txtsearch.Text = "" Then
                    Dim counter As Integer = -1
                    For Each item As ListViewItem In explorerlistview.Items
                        If explorerlistview.SelectedItems.Count > 0 Then
                            item = explorerlistview.SelectedItems.Item(0)
                            selecteditemtorename = item.SubItems(0).Text
                            If File.Exists(combination2 & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower) Then
                                pathofselecteditemtorename = combination2 & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower
                            Else
                                pathofselecteditemtorename = combination2 & "\" & item.SubItems(0).Text
                            End If
                            item.BeginEdit()
                            item.Selected = False
                        End If
                        For Each item2 As ListViewItem In explorerlistview.Items
                            counter += 1
                            item2 = explorerlistview.Items.Item(counter)
                            Dim itemtocompare As String = combination2 & "\" & item2.SubItems(0).Text
                            If File.Exists(pathofselecteditemtorename) Then
                                If itemtocompare & item2.SubItems(2).Text.ToLower = pathofselecteditemtorename Then
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
                Else
                    Dim counter As Integer = -1
                    For Each item As ListViewItem In explorerlistview.Items
                        If explorerlistview.SelectedItems.Count > 0 Then
                            item = explorerlistview.SelectedItems.Item(0)
                            selecteditemtorename = item.SubItems(0).Text
                            itempath = item.SubItems(4).Text.Replace("..\", "")
                            Dim itemlocation As String = item.SubItems(4).Text.Replace("..\", "")
                            If File.Exists(combination & "\" & itemlocation & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower) Then
                                pathofselecteditemtorename = combination & "\" & itemlocation & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower
                            Else
                                pathofselecteditemtorename = combination & "\" & itemlocation & "\" & item.SubItems(0).Text
                            End If
                            item.BeginEdit()
                            item.Selected = False
                        End If
                        For Each item2 As ListViewItem In explorerlistview.Items
                            counter += 1
                            item2 = explorerlistview.Items.Item(counter)
                            If item2.SubItems(0).Text = selecteditemtorename And item2.SubItems(4).Text.Replace("..\", "") = itempath Then
                                itemindex = counter
                                Exit Sub
                            End If
                        Next
                    Next
                End If
            ElseIf e.KeyCode = Keys.F3 Then
                txtsearch.Focus()
            ElseIf e.KeyCode = Keys.F4 Then
                TextBox1.Focus()
            ElseIf e.KeyCode = Keys.A And e.Modifiers = Keys.Control Then
                For Each item As ListViewItem In explorerlistview.Items
                    item.Selected = True
                Next
            ElseIf e.KeyCode = Keys.N And e.Modifiers = Keys.Control Then
                If Not Directory.Exists(combination2 & "\New folder") Then
                    Directory.CreateDirectory(combination2 & "\New folder")
                    btnrefresh.PerformClick()
                Else
                    Dim foldercounter As Integer = 2
                    If Not Directory.Exists(combination2 & "\New folder (" & foldercounter.ToString & ")") Then
                        Directory.CreateDirectory(combination2 & "\New folder (" & foldercounter.ToString & ")")
                        btnrefresh.PerformClick()
                    Else
                        Do Until Directory.Exists(combination2 & "\New folder (" & foldercounter.ToString & ")") = False
                            foldercounter += 1
                        Loop
                        Directory.CreateDirectory(combination2 & "\New folder (" & foldercounter.ToString & ")")
                        btnrefresh.PerformClick()
                        Exit Sub
                    End If
                End If
            ElseIf e.KeyCode = Keys.C And e.Modifiers = Keys.Control Then
                copyitemsinexplorer()
            ElseIf e.KeyCode = Keys.V And e.Modifiers = Keys.Control Then
                pasteitemsinexplorer()
            ElseIf e.KeyCode = Keys.Enter And e.Modifiers = Keys.Alt Then
                btn_details.PerformClick()
            ElseIf e.KeyCode = Keys.Enter Then
                opentheitem()
            ElseIf e.KeyCode = Keys.Escape Then
                btnclose.PerformClick()
            ElseIf e.KeyCode = Keys.I And e.Modifiers = Keys.Control Then
                btnfilebrowser.PerformClick()
            ElseIf e.KeyCode = Keys.O And e.Modifiers = Keys.Control Then
                txtfolderbrowser.PerformClick()
            ElseIf e.KeyCode = Keys.F6 Then
                btnexport.PerformClick()
            ElseIf e.KeyCode = Keys.F7 Then
                btnimport.PerformClick()
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub explorerlistview_Leave(sender As Object, e As EventArgs) Handles explorerlistview.Leave
        time = 0
        Timer1.Enabled = True
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        combination2 = ""
        Me.Close()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click

        If Directory.Exists(combination2) Then
            txtsearch.Text = ""
            explorerlistview.Items.Clear()
            Dim spliter As String() = path2.Text.Split("\")
            trimmedpath = spliter.Last.Trim
            txttrimmedpathlength.Text = Microsoft.VisualBasic.Len(trimmedpath)

            combination2 = Microsoft.VisualBasic.Left(combination2, txtcombination2length.Text - (txttrimmedpathlength.Text + 1))
            path2.Text = Microsoft.VisualBasic.Left(path2.Text, txtexplorerpathlength.Text - (txttrimmedpathlength.Text + 1))

            txtcombination2length.Text = Microsoft.VisualBasic.Len(combination2)
            txtexplorerpathlength.Text = Microsoft.VisualBasic.Len(path2.Text)

            If txtselecetditemlength.Text = txtexplorerpathlength.Text Then
                btnback.Enabled = False
            Else
                btnback.Enabled = True
            End If

            fileandfolderexplorer()
            countfilesandfoldersinexplorer()
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cboviewmode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboviewmode.SelectedIndexChanged

            Try
                If cboviewmode.Text = "Large Icons" Then
                    explorerlistview.View = View.LargeIcon
                ElseIf cboviewmode.Text = "Small Icons" Then
                    explorerlistview.View = View.SmallIcon
                ElseIf cboviewmode.Text = "List" Then
                    explorerlistview.View = View.List
                ElseIf cboviewmode.Text = "Details" Then
                    explorerlistview.View = View.Details
                ElseIf cboviewmode.Text = "Tiles" Then
                    explorerlistview.View = View.Tile
                End If
            Catch ex As Exception

            End Try

    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

            If Directory.Exists(combination2) Then
                If txtsearch.Text = "" Then
                    explorerlistview.Items.Clear()
                    myspace()
                    spaceconsumed()
                    remainingspacee()
                    fileandfolderexplorer()
                    countfilesandfoldersinexplorer()
                Else
                    search()
                End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

    End Sub

    Private Sub btnfilebrowser_Click(sender As Object, e As EventArgs) Handles btnfilebrowser.Click

        fileorfolder = "File"
        Dim counter As Integer = 0
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
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
            getfilesize = 0
            If counter = 1 Then
                txtitemname.Text = filename & " - " & size
            Else
                txtitemname.Text = counter & " files - " & size
            End If
        End If

    End Sub

    Private Sub txtfolderbrowser_Click(sender As Object, e As EventArgs) Handles txtfolderbrowser.Click

        Dim foldersize As String = ""
        getfoldersizeoftheselectedfolderinfolderbrowser = 0
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
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
            txtitemname.Text = foldername & " - " & foldersize
            txtitemname.ReadOnly = True
            fileorfolder = "Folder"
        End If

    End Sub

    Private Sub btn_newfolder_Click(sender As Object, e As EventArgs) Handles btn_newfolder.Click

        If Directory.Exists(combination2) Then
            If TextBox1.Text = "" Then
                If Not Directory.Exists(combination2 & "\New folder") Then
                    Directory.CreateDirectory(combination2 & "\New folder")
                    btnrefresh.PerformClick()
                Else
                    Dim foldercounter As Integer = 2
                    If Not Directory.Exists(combination2 & "\New folder (" & foldercounter.ToString & ")") Then
                        Directory.CreateDirectory(combination2 & "\New folder (" & foldercounter.ToString & ")")
                        btnrefresh.PerformClick()
                    Else
                        Do Until Directory.Exists(combination2 & "\New folder (" & foldercounter.ToString & ")") = False
                            foldercounter += 1
                        Loop
                        Directory.CreateDirectory(combination2 & "\New folder (" & foldercounter.ToString & ")")
                        btnrefresh.PerformClick()
                        Exit Sub
                    End If
                End If
                ElseIf TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
                    MessageBox.Show("Illegal characters detected" & " \ / : * ? < > | "" ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Text = ""
            ElseIf TextBox1.Text = "con" Or TextBox1.Text = "Con" Or TextBox1.Text = "cOn" Or TextBox1.Text = "coN" Or TextBox1.Text = "COn" Or TextBox1.Text = "CoN" Or TextBox1.Text = "cON" Or TextBox1.Text = "CON" Then
                MessageBox.Show("con cannot be use as an folder name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim newfolder As String
                    newfolder = System.IO.Path.Combine(combination2, TextBox1.Text)
                    If Not Directory.Exists(newfolder) Then
                        Directory.CreateDirectory(newfolder)
                        explorerlistview.Items.Clear()
                        fileandfolderexplorer()
                        countfilesandfoldersinexplorer()
                        TextBox1.Text = ""
                    Else
                        MessageBox.Show("Folder """ & TextBox1.Text & """ already exists", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox1.Text = ""
                    End If
                End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtsearch.Text = ""

    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click

        If txtsearch.Text = "" Then
            If Directory.Exists(combination2) Then
                For Each item As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item = explorerlistview.SelectedItems.Item(0)
                        Dim named As String = combination2 & "\" & (item.SubItems(0).Text)
                        deleteiteminitemproperties = "explorer"
                        If File.Exists(named & item.SubItems(2).Text.ToLower) Then
                            frmfiledetails.Close()
                            getpathinpropertiesfordelete = named & item.SubItems(2).Text.ToLower
                            frmfiledetails.PictureBox1.BackgroundImage = frmmain.GetShellIcon(named & item.SubItems(2).Text.ToLower)
                            fname = IO.Path.GetFileNameWithoutExtension(named & item.SubItems(2).Text.ToLower)
                            fsize = My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text.ToLower).Length
                            If (fsize >= 0 And fsize < kb) Then
                                frmfiledetails.txtsize.Text = Format(fsize, "#,##0") & " bytes"
                            ElseIf (fsize >= kb AndAlso fsize < mb) Then
                                frmfiledetails.txtsize.Text = Format((fsize / 1024), "0") & " KB" & " (" & Format(fsize, "#,##0") & " bytes)"
                            ElseIf (fsize >= mb AndAlso fsize < gb) Then
                                frmfiledetails.txtsize.Text = Format((fsize / 1024 / 1024), "0.0") & " MB" & " (" & Format(fsize, "#,##0") & " bytes)"
                            ElseIf (fsize >= gb) Then
                                frmfiledetails.txtsize.Text = Format((fsize / 1024 / 1024 / 1024), "0.0") & " GB" & " (" & Format(fsize, "#,##0") & " bytes)"
                            End If
                            ftype = (UCase(My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text.ToLower).Extension))
                            flastmodified = My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text.ToLower).CreationTime
                            flastaccesstime = My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text.ToLower).LastAccessTime
                            flastwritetime = My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text.ToLower).LastWriteTime
                            frmfiledetails.Show()
                            Exit Sub
                        ElseIf item.SubItems(2).Text = "Folder" Then
                            frmfiledetails.Close()
                            getpathinpropertiesfordelete = named
                            frmfiledetails.PictureBox1.BackgroundImage = frmmain.GetShellIcon(named)
                            fname = My.Computer.FileSystem.GetDirectoryInfo(named).Name
                            For Each itemfolder As String In My.Computer.FileSystem.GetFiles(named, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                foldersayz += My.Computer.FileSystem.GetFileInfo(itemfolder).Length
                                If (foldersayz >= 0 And foldersayz < kb) Then
                                    frmfiledetails.txtfoldersize.Text = Format(foldersayz, "#,##0") & " bytes"
                                ElseIf (foldersayz >= kb AndAlso foldersayz < mb) Then
                                    frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024), "0") & " KB" & " ( " & Format(foldersayz, "#,##0") & " bytes)"
                                ElseIf (foldersayz >= mb AndAlso foldersayz < gb) Then
                                    frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024 / 1024), "0.0") & " MB" & " (" & Format(foldersayz, "#,##0") & " bytes)"
                                ElseIf (foldersayz >= gb) Then
                                    frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024 / 1024 / 1024), "0.0") & " GB" & " (" & Format(foldersayz, "#,##0") & " bytes)"
                                End If
                            Next
                            ftype = "Folder"
                            Dim filenumber As Integer = 0
                            Dim foldernumber As Integer = 0
                            Dim files As Object = My.Computer.FileSystem.GetFiles(named, FileIO.SearchOption.SearchAllSubDirectories)
                            Dim folders As Object = My.Computer.FileSystem.GetDirectories(named, FileIO.SearchOption.SearchAllSubDirectories)
                            For Each filee In files
                                filenumber += 1
                            Next
                            For Each folderr In folders
                                foldernumber += 1
                            Next
                            ffilenumber = filenumber
                            ffoldernumber = foldernumber
                            ftotalitems = filenumber + foldernumber
                            flastmodified = My.Computer.FileSystem.GetDirectoryInfo(named).CreationTime
                            flastmodified = My.Computer.FileSystem.GetDirectoryInfo(named).LastAccessTime
                            flastwritetime = My.Computer.FileSystem.GetDirectoryInfo(named).LastWriteTime
                            frmfiledetails.folderdetailpanel.Visible = True
                            frmfiledetails.ShowDialog()
                            Exit Sub
                        Else
                            MessageBox.Show("Unidentified item selected", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        'MessageBox.Show("Please select an item", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Exit Sub
                    End If
                Next
            Else
                explorerlistview.Items.Clear()
                MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else ' ================================= Details in Search Mode =================================================
            If Directory.Exists(combination2) Then
                For Each item As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item = explorerlistview.SelectedItems.Item(0)
                        Dim pathtoreplacefordetials As String = item.SubItems(4).Text.Replace("..\", "")
                        Dim named As String = combination & "\" & pathtoreplacefordetials & "\" & (item.SubItems(0).Text)

                        If item.SubItems(2).Text = "Folder" Then
                            frmfiledetails.Close()
                            getpathinpropertiesfordelete = named
                            frmfiledetails.PictureBox1.BackgroundImage = frmmain.GetShellIcon(named)
                            fname = My.Computer.FileSystem.GetDirectoryInfo(named).Name
                            For Each itemfolder As String In My.Computer.FileSystem.GetFiles(named, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                foldersayz += My.Computer.FileSystem.GetFileInfo(itemfolder).Length
                                If (foldersayz >= 0 And foldersayz < kb) Then
                                    frmfiledetails.txtfoldersize.Text = Format(foldersayz, "#,##0") & " bytes"
                                ElseIf (foldersayz >= kb AndAlso foldersayz < mb) Then
                                    frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024), "0") & " KB" & " ( " & Format(foldersayz, "#,##0") & " bytes)"
                                ElseIf (foldersayz >= mb AndAlso foldersayz < gb) Then
                                    frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024 / 1024), "0.0") & " MB" & " (" & Format(foldersayz, "#,##0") & " bytes)"
                                ElseIf (foldersayz >= gb) Then
                                    frmfiledetails.txtfoldersize.Text = Format((foldersayz / 1024 / 1024 / 1024), "0.0") & " GB" & " (" & Format(foldersayz, "#,##0") & " bytes)"
                                End If
                            Next
                            ftype = "Folder"
                            Dim filenumber As Integer = 0
                            Dim foldernumber As Integer = 0
                            Dim files As Object = My.Computer.FileSystem.GetFiles(named, FileIO.SearchOption.SearchAllSubDirectories)
                            Dim folders As Object = My.Computer.FileSystem.GetDirectories(named, FileIO.SearchOption.SearchAllSubDirectories)
                            For Each filee In files
                                filenumber += 1
                            Next
                            For Each folderr In folders
                                foldernumber += 1
                            Next
                            ffilenumber = filenumber
                            ffoldernumber = foldernumber
                            ftotalitems = filenumber + foldernumber
                            flastmodified = My.Computer.FileSystem.GetDirectoryInfo(named).CreationTime
                            flastmodified = My.Computer.FileSystem.GetDirectoryInfo(named).LastAccessTime
                            flastwritetime = My.Computer.FileSystem.GetDirectoryInfo(named).LastWriteTime
                            frmfiledetails.folderdetailpanel.Visible = True
                            frmfiledetails.Show()
                            Exit Sub
                        ElseIf File.Exists(named & item.SubItems(2).Text) Then
                            frmfiledetails.Close()
                            getpathinpropertiesfordelete = named & item.SubItems(2).Text
                            frmfiledetails.PictureBox1.BackgroundImage = frmmain.GetShellIcon(named & item.SubItems(2).Text)
                            fname = IO.Path.GetFileNameWithoutExtension(named & item.SubItems(2).Text)
                            fsize = My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text).Length
                            If (fsize >= 0 And fsize < kb) Then
                                frmfiledetails.txtsize.Text = Format(fsize, "#,##0") & " bytes"
                            ElseIf (fsize >= kb AndAlso fsize < mb) Then
                                frmfiledetails.txtsize.Text = Format((fsize / 1024), "0") & " KB" & " (" & Format(fsize, "#,##0") & " bytes)"
                            ElseIf (fsize >= mb AndAlso fsize < gb) Then
                                frmfiledetails.txtsize.Text = Format((fsize / 1024 / 1024), "0.0") & " MB" & " (" & Format(fsize, "#,##0") & " bytes)"
                            ElseIf (fsize >= gb) Then
                                frmfiledetails.txtsize.Text = Format((fsize / 1024 / 1024 / 1024), "0.0") & " GB" & " (" & Format(fsize, "#,##0") & " bytes)"
                            End If
                            ftype = (UCase(My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text).Extension))
                            flastmodified = My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text).CreationTime
                            flastaccesstime = My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text).LastAccessTime
                            flastwritetime = My.Computer.FileSystem.GetFileInfo(named & item.SubItems(2).Text).LastWriteTime
                            frmfiledetails.ShowDialog()
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please select an item", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            Else
                explorerlistview.Items.Clear()
                MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        'Try
        If Directory.Exists(combination2) Then
            If txtsearch.Text = "" Then
                For Each item As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item = explorerlistview.SelectedItems.Item(0)
                        Dim named As String = combination2 & "\" & (item.SubItems(0).Text) & (item.SubItems(2).Text)

                        Dim type As String = My.Computer.FileSystem.GetFileInfo(named).Extension
                        If item.SubItems(2).Text <> "Folder" Then
                            My.Computer.FileSystem.DeleteFile(named, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                            item.Remove()
                        Else
                            My.Computer.FileSystem.DeleteDirectory(named.Replace("Folder", ""), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                            item.Remove()
                        End If
                    End If
                Next
                spaceconsumed()
                remainingspacee()
                countfilesandfolders()
                countfilesandfoldersinexplorer()
            Else ' ====================================== delete in search mode ==========================================
                For Each item As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item = explorerlistview.SelectedItems.Item(0)
                        Dim pathtoreplacefordelete As String = item.SubItems(4).Text.Replace("..\", "")
                        Dim named As String = combination & "\" & pathtoreplacefordelete & "\" & item.SubItems(0).Text

                        Dim type As String = My.Computer.FileSystem.GetFileInfo(named).Extension
                        If File.Exists(named & item.SubItems(2).Text) Then
                            My.Computer.FileSystem.DeleteFile(named & item.SubItems(2).Text, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                            item.Remove()
                        ElseIf Directory.Exists(named) Then
                            My.Computer.FileSystem.DeleteDirectory(named, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                            item.Remove()
                        End If
                    End If
                Next
                search()
                spaceconsumed()
                remainingspacee()
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Catch ex As Exception
        '    MessageBox.Show("The path might have change or the root folder has been deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub btn_copy_Click(sender As Object, e As EventArgs) Handles btn_copy.Click

        If txtsearch.Text = "" Then
            If Directory.Exists(combination2) Then
                If TextBox1.Text <> "" Then

                    Dim destinationpath0 As String = ""
                    Dim refreshinmain As Boolean = False

                    If TextBox1.Text = ".." Then
                        destinationpath0 = combination
                        refreshinmain = True
                    Else
                        destinationpath0 = combination2 & "\" & TextBox1.Text
                    End If
                    Dim destinationpath As String = destinationpath0

                    If Directory.Exists(destinationpath) Then
                        For Each item As ListViewItem In explorerlistview.Items
                            If explorerlistview.SelectedItems.Count > 0 Then
                                item = explorerlistview.SelectedItems.Item(0)
                                Dim itemlocation As String = combination2 & "\" & (item.SubItems(0).Text)
                                item.Selected = False
                                If item.SubItems(2).Text = "Folder" Then
                                    Dim itemtocopys As String = itemlocation
                                    Dim newcopys As String = destinationpath & "\" & (item.SubItems(0).Text)
                                    Try
                                        If Not Directory.Exists(newcopys) Then
                                            Dim foldersizetocopyinmain As Long = 0
                                            For Each item1 As String In My.Computer.FileSystem.GetFiles(itemtocopys, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                                foldersizetocopyinmain += My.Computer.FileSystem.GetFileInfo(item1).Length
                                            Next
                                            If remainingspace > foldersizetocopyinmain Then
                                                My.Computer.FileSystem.CopyDirectory(itemtocopys, newcopys)
                                            Else
                                                btnrefresh.PerformClick()
                                                MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                Exit Sub
                                            End If
                                        Else
                                            MessageBox.Show("Folder '" & item.SubItems(0).Text & "' already exists on the specified destination path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If
                                    Catch ex As Exception
                                        MessageBox.Show("Could not copy folder '" & item.SubItems(0).Text & "', since target directory is under source directory.", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    Dim itemtocopys As String = itemlocation & item.SubItems(2).Text.ToLower
                                    Dim newcopys As String = destinationpath & "\" & (item.SubItems(0).Text) & item.SubItems(2).Text.ToLower
                                    If Not File.Exists(newcopys) Then
                                        Dim filesizetocopyinmain As Long = 0
                                        filesizetocopyinmain = My.Computer.FileSystem.GetFileInfo(itemtocopys).Length
                                        If remainingspace > filesizetocopyinmain Then
                                            System.IO.File.Copy(itemtocopys, newcopys)
                                        Else
                                            btnrefresh.PerformClick()
                                            MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Exit Sub
                                        End If
                                    Else
                                        MessageBox.Show("File '" & item.SubItems(0).Text & "' already exists on the specified destination path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                End If
                                If explorerlistview.SelectedItems.Count = 0 Then
                                    btnrefresh.PerformClick()
                                    If refreshinmain = True Then
                                        frmmain.button_refresh.PerformClick()
                                    End If
                                    Exit Sub
                                End If
                            Else
                                MessageBox.Show("Please select an item to copy.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Next
                    Else
                        MessageBox.Show("Destination path '" & TextBox1.Text & "' does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Enter the destination path to complete the process.", "Information Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox1.Focus()
                End If
            Else
                explorerlistview.Items.Clear()
                MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            


        Else '========================================== Copy in Search Mode ==============================================



            If Directory.Exists(combination2) Then
                If TextBox1.Text <> "" Then

                    Dim destinationpath0 As String = ""
                    Dim refreshinmain As Boolean = False

                    If TextBox1.Text = ".." Then
                        destinationpath0 = combination
                        refreshinmain = True
                    Else
                        destinationpath0 = System.IO.Path.Combine(combination2, TextBox1.Text)
                    End If
                    Dim destinationpath As String = destinationpath0

                    If Directory.Exists(destinationpath) Then
                        For Each item As ListViewItem In explorerlistview.Items
                            If explorerlistview.SelectedItems.Count > 0 Then
                                item = explorerlistview.SelectedItems.Item(0)

                                Dim pathtoreplaceforcopy As String = item.SubItems(4).Text.Replace("..\", "")
                                Dim itemlocation As String = combination & "\" & pathtoreplaceforcopy & "\" & item.SubItems(0).Text
                                item.Selected = False
                                If item.SubItems(2).Text = "Folder" Then
                                    Dim itemtocopys As String = itemlocation
                                    Dim newcopys As String = destinationpath & "\" & (item.SubItems(0).Text)
                                    Try
                                        If Not Directory.Exists(newcopys) Then
                                            Dim foldersizetocopyinmain As Long = 0
                                            For Each item1 As String In My.Computer.FileSystem.GetFiles(itemtocopys, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                                foldersizetocopyinmain += My.Computer.FileSystem.GetFileInfo(item1).Length
                                            Next
                                            If remainingspace > foldersizetocopyinmain Then
                                                My.Computer.FileSystem.CopyDirectory(itemtocopys, newcopys)
                                            Else
                                                btnrefresh.PerformClick()
                                                MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                Exit Sub
                                            End If
                                        Else
                                            MessageBox.Show("Folder '" & item.SubItems(0).Text & "' already exists on the specified destination path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If
                                    Catch ex As Exception
                                        MessageBox.Show("Could not copy folder '" & item.SubItems(0).Text & "', since target directory is under source directory.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End Try
                                Else
                                    Dim itemtocopys As String = itemlocation & item.SubItems(2).Text.ToLower
                                    Dim newcopys As String = destinationpath & "\" & (item.SubItems(0).Text) & item.SubItems(2).Text.ToLower
                                    If Not File.Exists(newcopys) Then
                                        Dim filesizetocopyinmain As Long = 0
                                        filesizetocopyinmain = My.Computer.FileSystem.GetFileInfo(itemtocopys).Length
                                        If remainingspace > filesizetocopyinmain Then
                                            System.IO.File.Copy(itemtocopys, newcopys)
                                        Else
                                            btnrefresh.PerformClick()
                                            MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Exit Sub
                                        End If
                                    Else
                                        MessageBox.Show("File '" & item.SubItems(0).Text & "' already exists on the specified destination path.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                End If
                                If explorerlistview.SelectedItems.Count = 0 Then
                                    search()
                                    Exit Sub
                                End If
                            Else
                                MessageBox.Show("Please select an item.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Next
                    Else
                        MessageBox.Show("Destination path '" & TextBox1.Text & "' does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Enter the destination path to complete the process.", "Information Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox1.Focus()
                End If
            Else
                explorerlistview.Items.Clear()
                MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btn_rename_Click(sender As Object, e As EventArgs) Handles btn_rename.Click

        If txtsearch.Text = "" Then
            If Directory.Exists(combination2) Then
                Dim path1 As String = combination2 & "\"
                Dim named As String
                For Each item As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item = explorerlistview.SelectedItems.Item(0)
                        named = path1 & (item.SubItems(0).Text)

                        If TextBox1.Text <> "" Then
                            If item.SubItems(2).Text = "Folder" Then
                                If TextBox1.Text = "con" Or TextBox1.Text = "Con" Or TextBox1.Text = "cOn" Or TextBox1.Text = "coN" Or TextBox1.Text = "COn" Or TextBox1.Text = "CoN" Or TextBox1.Text = "cON" Or TextBox1.Text = "CON" Then
                                    MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    TextBox1.Text = ""
                                    Exit Sub
                                ElseIf Directory.Exists(combination2 & "\" & TextBox1.Text) Then
                                    MessageBox.Show("Could not complete operation since a directory already exists in this path.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    TextBox1.Text = ""
                                    Exit Sub
                                Else
                                    If TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
                                        MessageBox.Show("A foldername can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        TextBox1.Text = ""
                                        Exit Sub
                                    Else
                                        My.Computer.FileSystem.RenameDirectory(named, TextBox1.Text)
                                        explorerlistview.Items.Clear()
                                        fileandfolderexplorer()
                                        TextBox1.Text = ""
                                        Exit Sub
                                    End If
                                End If
                            ElseIf File.Exists(named & item.SubItems(2).Text) Then
                                If Not File.Exists(combination2 & "\" & TextBox1.Text & item.SubItems(2).Text) Then
                                    If TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
                                        MessageBox.Show("A filename can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        TextBox1.Text = ""
                                        Exit Sub
                                    ElseIf TextBox1.Text = "con" Or TextBox1.Text = "Con" Or TextBox1.Text = "cOn" Or TextBox1.Text = "coN" Or TextBox1.Text = "COn" Or TextBox1.Text = "CoN" Or TextBox1.Text = "cON" Or TextBox1.Text = "CON" Then
                                        MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        TextBox1.Text = ""
                                        Exit Sub
                                    Else
                                        My.Computer.FileSystem.RenameFile(named & item.SubItems(2).Text.ToLower, TextBox1.Text & item.SubItems(2).Text.ToLower)
                                        explorerlistview.Items.Clear()
                                        fileandfolderexplorer()
                                        TextBox1.Text = ""
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("Could not complete operation since a file already exists in this path.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    TextBox1.Text = ""
                                    Exit Sub
                                End If
                            End If
                        Else
                            MessageBox.Show("Name cannot be null.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please select an item to rename.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            Else
                explorerlistview.Items.Clear()
                MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else '============================== Rename Search Mode ==========================================

            If Directory.Exists(combination2) Then
                Dim named As String
                For Each item As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item = explorerlistview.SelectedItems.Item(0)

                        Dim pathtoreplaceforrename As String = item.SubItems(4).Text.Replace("..\", "")
                        named = combination & "\" & pathtoreplaceforrename & "\" & (item.SubItems(0).Text)
                        If TextBox1.Text <> "" Then
                            If item.SubItems(2).Text = "Folder" Then
                                If TextBox1.Text = "con" Or TextBox1.Text = "Con" Or TextBox1.Text = "cOn" Or TextBox1.Text = "coN" Or TextBox1.Text = "COn" Or TextBox1.Text = "CoN" Or TextBox1.Text = "cON" Or TextBox1.Text = "CON" Then
                                    MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                ElseIf Directory.Exists(combination & "\" & pathtoreplaceforrename & "\" & TextBox1.Text) Then
                                    MessageBox.Show("Could not complete operation since a directory already exists in this same location.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    TextBox1.Text = ""
                                    Exit Sub
                                Else
                                    If TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
                                        MessageBox.Show("A foldername can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        TextBox1.Text = ""
                                        Exit Sub
                                    Else
                                        Try
                                            My.Computer.FileSystem.RenameDirectory(named, TextBox1.Text)
                                            TextBox1.Text = ""
                                            Exit Sub
                                        Catch ex As Exception
                                            MessageBox.Show("The action can't be completed because the folder or a file in it is open in another program.", "Folder in Use", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                            TextBox1.Text = ""
                                            Exit Sub
                                        End Try
                                    End If
                                End If
                            ElseIf File.Exists(named & item.SubItems(2).Text) Then
                                If Not File.Exists(combination & "\" & pathtoreplaceforrename & "\" & TextBox1.Text & item.SubItems(2).Text.ToLower) Then
                                    If TextBox1.Text.Contains("\") Or TextBox1.Text.Contains("/") Or TextBox1.Text.Contains(":") Or TextBox1.Text.Contains("*") Or TextBox1.Text.Contains("?") Or TextBox1.Text.Contains("<") Or TextBox1.Text.Contains(">") Or TextBox1.Text.Contains("|") Or TextBox1.Text.Contains("""") Then
                                        MessageBox.Show("A filename can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        TextBox1.Text = ""
                                        Exit Sub
                                    ElseIf TextBox1.Text = "con" Or TextBox1.Text = "Con" Or TextBox1.Text = "cOn" Or TextBox1.Text = "coN" Or TextBox1.Text = "COn" Or TextBox1.Text = "CoN" Or TextBox1.Text = "cON" Or TextBox1.Text = "CON" Then
                                        MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    Else
                                        My.Computer.FileSystem.RenameFile(named & item.SubItems(2).Text.ToLower, TextBox1.Text & item.SubItems(2).Text.ToLower)
                                        TextBox1.Text = ""
                                        search()
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("Could not complete operation since a file already exists in this same location.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    TextBox1.Text = ""
                                    Exit Sub
                                End If
                            End If
                        Else
                            MessageBox.Show("Name cannot be null", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Please select an item", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            Else
                explorerlistview.Items.Clear()
                MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If

    End Sub

    Private Sub txtcancel_Click(sender As Object, e As EventArgs) Handles txtcancel.Click
        fileorfolder = ""
        txtitemname.Text = ""
        OpenFileDialog1.Dispose()
        FolderBrowserDialog1.Dispose()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        search()
    End Sub
    Private Sub search()

        If Directory.Exists(combination2) Then
            explorerlistview.Items.Clear()
            If txtsearch.Text = "" Then
                fileandfolderexplorer()
            ElseIf cbofileorfolder.Text = "File" Then
                Me.explorerlistview.Columns.Clear()
                Me.explorerlistview.Columns.Add("Name", 300, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Date Modified", 150, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Type", 150, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Size", 100, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Location", 400, HorizontalAlignment.Left)
                For Each item As String In My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                    If item.Contains(txtsearch.Text) Then
                        icons.Images.Add(frmexplorer.GetShellIcon(item))
                        Dim lvi As New ListViewItem(IO.Path.GetFileNameWithoutExtension(item), icons.Images.Count - 1)
                        lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).CreationTime)
                        lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).Extension.ToUpper)
                        Dim itemsize As Decimal = My.Computer.FileSystem.GetFileInfo(item).Length
                        If (itemsize >= 0 And itemsize < kb) Then
                            lvi.SubItems.Add(itemsize & " bytes")
                        ElseIf (itemsize >= kb AndAlso itemsize < mb) Then
                            lvi.SubItems.Add(Format((itemsize / 1024), "0") & " KB")
                        ElseIf (itemsize >= mb AndAlso itemsize < gb) Then
                            lvi.SubItems.Add(Format((itemsize / 1024 / 1024), "0.0") & " MB")
                        ElseIf (itemsize >= gb) Then
                            lvi.SubItems.Add(Format((itemsize / 1024 / 1024 / 1024), "0.0") & " GB")
                        End If

                        Dim itemlocation As String = My.Computer.FileSystem.GetDirectoryInfo(item).FullName
                        Dim replaceditemlocation As String = item.Replace(combination, "..")
                        Dim replaceditemlocationlen As String = Microsoft.VisualBasic.Len(replaceditemlocation)
                        Dim spliter As String() = replaceditemlocation.Split("\")
                        Dim trimmedpath As String = spliter.Last.Trim
                        Dim numberoftrimmedpart As Integer = Microsoft.VisualBasic.Len(trimmedpath)
                        lvi.SubItems.Add(Microsoft.VisualBasic.Left(replaceditemlocation, replaceditemlocationlen - (numberoftrimmedpart + 1)))
                        explorerlistview.Items.Add(lvi)
                    End If
                Next

            ElseIf cbofileorfolder.Text = "Folder" Then
                Me.explorerlistview.Columns.Clear()
                Me.explorerlistview.Columns.Add("Name", 300, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Date Modified", 150, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Type", 150, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Size", 100, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Location", 400, HorizontalAlignment.Left)
                For Each item As String In My.Computer.FileSystem.GetDirectories(combination2, FileIO.SearchOption.SearchAllSubDirectories)
                    If item.Contains(txtsearch.Text) Then
                        icons.Images.Add(frmexplorer.GetShellIcon(item))
                        Dim lvi As New ListViewItem(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
                        lvi.SubItems.Add(My.Computer.FileSystem.GetDirectoryInfo(item).CreationTime)
                        lvi.SubItems.Add("Folder")

                        lvi.SubItems.Add("")

                        Dim itemlocation As String = My.Computer.FileSystem.GetDirectoryInfo(item).FullName
                        Dim replaceditemlocation As String = item.Replace(combination, "..")
                        Dim replaceditemlocationlen As String = Microsoft.VisualBasic.Len(replaceditemlocation)
                        Dim spliter As String() = replaceditemlocation.Split("\")
                        Dim trimmedpath As String = spliter.Last.Trim
                        Dim numberoftrimmedpart As Integer = Microsoft.VisualBasic.Len(trimmedpath)
                        lvi.SubItems.Add(Microsoft.VisualBasic.Left(replaceditemlocation, replaceditemlocationlen - (numberoftrimmedpart + 1)))
                        explorerlistview.Items.Add(lvi)
                    End If
                Next
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cbofileorfolder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofileorfolder.SelectedIndexChanged
        txtsearch.Text = ""
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.F2 Then
            btn_rename.PerformClick()
        ElseIf e.KeyCode = Keys.N And e.Modifiers = Keys.Control Then
            btn_newfolder.PerformClick()
        ElseIf e.KeyCode = Keys.I And e.Modifiers = Keys.Control Then
            btnfilebrowser.PerformClick()
        ElseIf e.KeyCode = Keys.O And e.Modifiers = Keys.Control Then
            txtfolderbrowser.PerformClick()
        ElseIf e.KeyCode = Keys.F6 Then
            btnexport.PerformClick()
        ElseIf e.KeyCode = Keys.F7 Then
            btnimport.PerformClick()
        End If

    End Sub

    Private Sub btnfolderbrowser2_Click(sender As Object, e As EventArgs) Handles btnfolderbrowser2.Click
        If FolderBrowserDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtdestinationpath.Text = FolderBrowserDialog2.SelectedPath
        End If
    End Sub

    Private Sub btncancel2_Click(sender As Object, e As EventArgs) Handles btncancel2.Click
        txtdestinationpath.Text = ""
    End Sub

    Private Sub btnimport_Click(sender As Object, e As EventArgs) Handles btnimport.Click

        If Directory.Exists(combination2) Then
            If txtdestinationpath.Text <> "" Then
                If Directory.Exists(txtdestinationpath.Text) Then
                    If txtsearch.Text = "" Then
                        Dim itemcounter As Integer = 0
                        For Each item As ListViewItem In explorerlistview.Items
                            Dim msg As Boolean = False
                            If explorerlistview.SelectedItems.Count > 1 Then
                                msg = True
                            ElseIf explorerlistview.SelectedItems.Count = 1 Then
                                msg = True
                            End If
                            If explorerlistview.SelectedItems.Count > 0 Then
                                item = explorerlistview.SelectedItems.Item(0)
                                itemcounter += 1
                                If item.SubItems(2).Text = "Folder" Then
                                    If Not Directory.Exists(txtdestinationpath.Text & "\" & item.SubItems(0).Text) Then
                                        Dim itemlocation As String = combination2 & "\" & item.SubItems(0).Text
                                        My.Computer.FileSystem.CopyDirectory(itemlocation, txtdestinationpath.Text & "\" & item.SubItems(0).Text)
                                        Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly = False
                                        For Each Files In My.Computer.FileSystem.GetFiles(txtdestinationpath.Text & "\" & item.SubItems(0).Text, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                            File.SetAttributes(Files, attribute)
                                        Next
                                    Else
                                        MessageBox.Show("Folder '" & item.SubItems(0).Text & "' already exists on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        itemcounter -= 1
                                    End If
                                ElseIf File.Exists(combination2 & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower) Then
                                    If Not File.Exists(txtdestinationpath.Text & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower) Then
                                        Dim itemlocation As String = combination2 & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower
                                        My.Computer.FileSystem.CopyFile(itemlocation, txtdestinationpath.Text & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower)
                                        Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly = False
                                        File.SetAttributes(txtdestinationpath.Text & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower, attribute)
                                    Else
                                        MessageBox.Show("File '" & item.SubItems(0).Text & "' already exists on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        itemcounter -= 1
                                    End If
                                End If
                                item.Selected = False
                                If explorerlistview.SelectedItems.Count = 0 Then
                                    If msg = True Then
                                        If itemcounter > 1 Then
                                            MessageBox.Show("Items successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        ElseIf itemcounter = 1 Then
                                            MessageBox.Show("Item successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If
                                    End If
                                    Exit Sub
                                End If
                            ElseIf explorerlistview.SelectedItems.Count = 0 Then
                                MessageBox.Show("Please select an item to import.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Next



                    Else
                        Dim itemcounter As Integer = 0
                        For Each item As ListViewItem In explorerlistview.Items
                            Dim msg As Boolean = False
                            If explorerlistview.SelectedItems.Count > 1 Then
                                msg = True
                            ElseIf explorerlistview.SelectedItems.Count = 1 Then
                                msg = True
                            End If
                            If explorerlistview.SelectedItems.Count > 0 Then
                                item = explorerlistview.SelectedItems.Item(0)
                                itemcounter += 1
                                Dim initialimportpath As String = item.SubItems(4).Text.Replace("..", combination)
                                If item.SubItems(2).Text = "Folder" Then
                                    If Not Directory.Exists(txtdestinationpath.Text & "\" & item.SubItems(0).Text) Then
                                        Dim itemlocation As String = initialimportpath & "\" & item.SubItems(0).Text
                                        My.Computer.FileSystem.CopyDirectory(itemlocation, txtdestinationpath.Text & "\" & item.SubItems(0).Text)
                                        Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly = False
                                        For Each Files In My.Computer.FileSystem.GetFiles(txtdestinationpath.Text & "\" & item.SubItems(0).Text, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                            File.SetAttributes(Files, attribute)
                                        Next
                                    Else
                                        MessageBox.Show("Folder '" & item.SubItems(0).Text & "' already exists on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        itemcounter -= 1
                                    End If
                                ElseIf File.Exists(initialimportpath & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower) Then
                                    If Not File.Exists(txtdestinationpath.Text & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower) Then
                                        Dim itemlocation As String = initialimportpath & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower
                                        My.Computer.FileSystem.CopyFile(itemlocation, txtdestinationpath.Text & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower)
                                        Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly = False
                                        File.SetAttributes(txtdestinationpath.Text & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower, attribute)
                                    Else
                                        MessageBox.Show("File '" & item.SubItems(0).Text & "' already exists on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                        itemcounter -= 1
                                    End If
                                End If
                                item.Selected = False
                                If explorerlistview.SelectedItems.Count = 0 Then
                                    If msg = True Then
                                        If itemcounter > 1 Then
                                            MessageBox.Show("Items successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        ElseIf itemcounter = 1 Then
                                            MessageBox.Show("Item successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If
                                    End If
                                    Exit Sub
                                End If
                            ElseIf explorerlistview.SelectedItems.Count = 0 Then
                                MessageBox.Show("Please select an item to import.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                        Next
                    End If





                Else
                    MessageBox.Show("Destination path '" & txtdestinationpath.Text & "' does not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else
                MessageBox.Show("Enter the destination path to complete the process.", "Information Guide", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnfolderbrowser2.Focus()
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = Val(time) + 1
        If time = 1 Then
            renamefileinexplorer()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub renamefileinexplorer()

        If txtsearch.Text = "" Then
            For Each item As ListViewItem In explorerlistview.Items
                item = explorerlistview.Items.Item(itemindex)
                If File.Exists(pathofselecteditemtorename) Then
                    If Not File.Exists(combination2 & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower) Then
                        If item.SubItems(0).Text.Contains("\") Or item.SubItems(0).Text.Contains("/") Or item.SubItems(0).Text.Contains("*") Or item.SubItems(0).Text.Contains("?") Or item.SubItems(0).Text.Contains("<") Or item.SubItems(0).Text.Contains(":") Or item.SubItems(0).Text.Contains(">") Or item.SubItems(0).Text.Contains("|") Or item.SubItems(0).Text.Contains("""") Then
                            MessageBox.Show("A filename can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            explorerlistview.Items.Clear()
                            fileandfolderexplorer()
                            Exit Sub
                        ElseIf item.SubItems(0).Text = "con" Or item.SubItems(0).Text = "Con" Or item.SubItems(0).Text = "cOn" Or item.SubItems(0).Text = "coN" Or item.SubItems(0).Text = "COn" Or item.SubItems(0).Text = "cON" Or item.SubItems(0).Text = "CoN" Or item.SubItems(0).Text = "CON" Then
                            MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            explorerlistview.Items.Clear()
                            fileandfolderexplorer()
                            Exit Sub
                        Else
                            My.Computer.FileSystem.RenameFile(pathofselecteditemtorename, item.SubItems(0).Text & item.SubItems(2).Text.ToLower)
                            explorerlistview.Items.Clear()
                            fileandfolderexplorer()
                            itemindex = 0
                            Exit Sub
                        End If
                    ElseIf selecteditemtorename = item.SubItems(0).Text Then
                        Exit Sub
                    Else
                        pathofselecteditemtorename = ""
                        MessageBox.Show("Could not complete operation since a file already exists in this path.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        explorerlistview.Items.Clear()
                        fileandfolderexplorer()
                        explorerlistview.Focus()
                        Exit Sub
                    End If
                ElseIf Directory.Exists(pathofselecteditemtorename) Then
                    If Not Directory.Exists(combination2 & "\" & item.SubItems(0).Text) Then
                        If item.SubItems(0).Text.Contains("\") Or item.SubItems(0).Text.Contains("/") Or item.SubItems(0).Text.Contains("*") Or item.SubItems(0).Text.Contains("?") Or item.SubItems(0).Text.Contains("<") Or item.SubItems(0).Text.Contains(":") Or item.SubItems(0).Text.Contains(">") Or item.SubItems(0).Text.Contains("|") Or item.SubItems(0).Text.Contains("""") Then
                            MessageBox.Show("A foldername can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            explorerlistview.Items.Clear()
                            fileandfolderexplorer()
                            Exit Sub
                        ElseIf item.SubItems(0).Text = "con" Or item.SubItems(0).Text = "Con" Or item.SubItems(0).Text = "cOn" Or item.SubItems(0).Text = "coN" Or item.SubItems(0).Text = "COn" Or item.SubItems(0).Text = "cON" Or item.SubItems(0).Text = "CoN" Or item.SubItems(0).Text = "CON" Then
                            MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            explorerlistview.Items.Clear()
                            fileandfolderexplorer()
                            Exit Sub
                        Else
                            Try
                                My.Computer.FileSystem.RenameDirectory(pathofselecteditemtorename, item.SubItems(0).Text)
                                explorerlistview.Items.Clear()
                                fileandfolderexplorer()
                                itemindex = 0
                                Exit Sub
                            Catch ex As Exception
                                MessageBox.Show("The action can't be completed because the folder or a file in it is open in another program.", "Folder in Use", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                explorerlistview.Items.Clear()
                                fileandfolderexplorer()
                                Exit Sub
                            End Try
                        End If
                    ElseIf selecteditemtorename = item.SubItems(0).Text Then
                        Exit Sub
                    Else
                        pathofselecteditemtorename = ""
                        MessageBox.Show("Could not complete operation since a directory already exists in this path.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        explorerlistview.Items.Clear()
                        fileandfolderexplorer()
                        explorerlistview.Focus()
                        Exit Sub
                    End If
                End If
            Next
        Else
            For Each item As ListViewItem In explorerlistview.Items
                item = explorerlistview.Items.Item(itemindex)
                If File.Exists(pathofselecteditemtorename) Then
                    If Not File.Exists(combination & "\" & itempath & "\" & item.SubItems(0).Text & item.SubItems(2).Text.ToLower) Then
                        If item.SubItems(0).Text.Contains("\") Or item.SubItems(0).Text.Contains("/") Or item.SubItems(0).Text.Contains("*") Or item.SubItems(0).Text.Contains("?") Or item.SubItems(0).Text.Contains("<") Or item.SubItems(0).Text.Contains(":") Or item.SubItems(0).Text.Contains(">") Or item.SubItems(0).Text.Contains("|") Or item.SubItems(0).Text.Contains("""") Then
                            MessageBox.Show("A filename can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            search()
                            Exit Sub
                        ElseIf item.SubItems(0).Text = "con" Or item.SubItems(0).Text = "Con" Or item.SubItems(0).Text = "cOn" Or item.SubItems(0).Text = "coN" Or item.SubItems(0).Text = "COn" Or item.SubItems(0).Text = "cON" Or item.SubItems(0).Text = "CoN" Or item.SubItems(0).Text = "CON" Then
                            MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            explorerlistview.Items.Clear()
                            fileandfolderexplorer()
                            Exit Sub
                        Else
                            My.Computer.FileSystem.RenameFile(pathofselecteditemtorename, item.SubItems(0).Text & item.SubItems(2).Text.ToLower)
                            explorerlistview.Items.Clear()
                            itemindex = 0
                            search()
                            Exit Sub
                        End If
                    ElseIf selecteditemtorename = item.SubItems(0).Text Then
                        Exit Sub
                    Else
                        pathofselecteditemtorename = ""
                        MessageBox.Show("Could not complete operation since a file already exists in the same location.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        explorerlistview.Items.Clear()
                        search()
                        explorerlistview.Focus()
                        Exit Sub
                    End If
                ElseIf Directory.Exists(pathofselecteditemtorename) Then
                    If Not Directory.Exists(combination & "\" & itempath & "\" & item.SubItems(0).Text) Then
                        If item.SubItems(0).Text.Contains("\") Or item.SubItems(0).Text.Contains("/") Or item.SubItems(0).Text.Contains("*") Or item.SubItems(0).Text.Contains("?") Or item.SubItems(0).Text.Contains("<") Or item.SubItems(0).Text.Contains(":") Or item.SubItems(0).Text.Contains(">") Or item.SubItems(0).Text.Contains("|") Or item.SubItems(0).Text.Contains("""") Then
                            MessageBox.Show("A foldername can't contain any of the following characters: \ / : * ? "" < > | ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            search()
                            Exit Sub
                        ElseIf item.SubItems(0).Text = "con" Or item.SubItems(0).Text = "Con" Or item.SubItems(0).Text = "cOn" Or item.SubItems(0).Text = "coN" Or item.SubItems(0).Text = "COn" Or item.SubItems(0).Text = "cON" Or item.SubItems(0).Text = "CoN" Or item.SubItems(0).Text = "CON" Then
                            MessageBox.Show("The specified device name is invalid.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            explorerlistview.Items.Clear()
                            fileandfolderexplorer()
                            Exit Sub
                        Else
                            Try
                                My.Computer.FileSystem.RenameDirectory(pathofselecteditemtorename, item.SubItems(0).Text)
                                explorerlistview.Items.Clear()
                                itemindex = 0
                                search()
                                Exit Sub
                            Catch ex As Exception
                                MessageBox.Show("The action can't be completed because the folder or a file in it is open in another program.", "Folder in Use", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                explorerlistview.Items.Clear()
                                fileandfolderexplorer()
                                Exit Sub
                            End Try
                        End If
                    ElseIf selecteditemtorename = item.SubItems(0).Text Then
                        Exit Sub
                    Else
                        Timer1.Dispose()
                        pathofselecteditemtorename = ""
                        MessageBox.Show("Could not complete operation since a directory already exists in the same location.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        explorerlistview.Items.Clear()
                        search()
                        explorerlistview.Focus()
                        Exit Sub
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub explorerlistview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles explorerlistview.SelectedIndexChanged

    End Sub

    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click

        If Directory.Exists(combination2) Then
            If fileorfolder = "File" Then
                getfilesize = 0
                For x = 0 To OpenFileDialog1.FileNames.Count - 1
                    getfilesize += My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileNames(x)).Length
                    If remainingspace > getfilesize Then
                        Dim filetocopy As String = OpenFileDialog1.FileNames(x)
                        Dim newcopy As String = System.IO.Path.Combine(combination2, OpenFileDialog1.SafeFileNames(x))
                        If Not File.Exists(newcopy) Then
                            System.IO.File.Copy(filetocopy, newcopy)
                        Else
                            MessageBox.Show("File '" & OpenFileDialog1.SafeFileNames(x) & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtitemname.Text = ""
                        fileorfolder = ""
                        spaceconsumed()
                        remainingspacee()
                        explorerlistview.Items.Clear()
                        fileandfolderexplorer()
                        OpenFileDialog1.Dispose()
                        'txtcancel.Visible = False
                        Exit Sub
                    End If
                Next
                txtitemname.Text = ""
                fileorfolder = ""
                spaceconsumed()
                remainingspacee()
                explorerlistview.Items.Clear()
                fileandfolderexplorer()
                OpenFileDialog1.Dispose()
                'txtcancel.Visible = False
                'MessageBox.Show("File Exported", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf fileorfolder = "Folder" Then
                If remainingspace > getfoldersizeoftheselectedfolderinfolderbrowser Then
                    Dim foldertocopy As String = FolderBrowserDialog1.SelectedPath
                    Dim newcopy As String = System.IO.Path.Combine(combination2, foldername)
                    If Directory.Exists(newcopy) Then
                        MessageBox.Show("Folder '" & foldername & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtitemname.Text = ""
                        fileorfolder = ""
                        'txtcancel.Visible = False
                        Exit Sub
                    Else
                        My.Computer.FileSystem.CopyDirectory(foldertocopy, newcopy)
                        'MessageBox.Show("Folder exported.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        explorerlistview.Items.Clear()
                        fileandfolderexplorer()
                        spaceconsumed()
                        remainingspacee()
                        txtitemname.Text = ""
                        fileorfolder = ""
                        'txtcancel.Visible = False
                        FolderBrowserDialog1.Dispose()
                    End If
                Else
                    MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtitemname.Text = ""
                    fileorfolder = ""
                    'txtcancel.Visible = False
                    FolderBrowserDialog1.Dispose()
                End If
            Else

            End If
            txtsearch.Text = ""
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class