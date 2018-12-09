Imports System.Runtime.InteropServices
Imports System.IO

Public Class frmexplorer

    Dim trimmedpath As String
    Dim ngalan As String
    Dim selectedfile As String

    Dim getfilesizeinexplorer As Long = 0
    Dim getfoldersizeinexplorer As Long = 0
    'Dim separatepath As String
    Dim foldername As String
    Dim readytoexport As String
    Dim fileorfolder As String

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

    Private Sub frmexplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For Each Control In Me.Controls
        '    Control.visible = False
        'Next

        txtpathlength.Text = pathlength
        txtselecetditemlength.Text = selectedfolderlength

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
        cbofileorfolder.Text = "File"
        explorerlistview.Items.Clear()
        displayfilesandfolders()
        myspace()
        spaceconsumed()
        remainingspacee()
        countfilesandfolders()
        If imageszeroallocatedspace = True Then
            lblallocatedspace.Text = "Allocated Space       :   "
            lblremainingspace.Text = "Remaining Space :  "
            imageszeroallocatedspace = False
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click

        If Directory.Exists(combination2) Then
            If readytoexport = "Yes" Then
                Dim msg As Boolean = False
                If fileorfolder = "File" Then
                    getfilesizeinexplorer = 0
                    Dim itemcounter As Integer = 0
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        getfilesizeinexplorer += My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileNames(x)).Length
                        If remainingspace > getfilesizeinexplorer Then
                            Dim filetocopy As String = OpenFileDialog1.FileNames(x)
                            Dim newcopy As String = System.IO.Path.Combine(combination2, OpenFileDialog1.SafeFileNames(x))
                            If Not File.Exists(newcopy) Then
                                'System.IO.File.Copy(filetocopy, newcopy)
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
                            txtitemname.Text = ""
                            fileorfolder = ""
                            spaceconsumed()
                            remainingspacee()
                            explorerlistview.Items.Clear()
                            displayfilesandfolders()
                            Exit Sub
                        End If
                    Next
                    txtitemname.Text = ""
                    fileorfolder = ""
                    spaceconsumed()
                    remainingspacee()
                    explorerlistview.Items.Clear()
                    displayfilesandfolders()
                    OpenFileDialog1.Dispose()
                    If msg = True Then
                        If itemcounter > 1 Then
                            MessageBox.Show("Items successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Item successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                ElseIf fileorfolder = "Folder" Then
                    If remainingspace > getfoldersizeinexplorer Then
                        Dim foldertocopy As String = FolderBrowserDialog1.SelectedPath
                        Dim newcopy As String = System.IO.Path.Combine(combination2, foldername)
                        If Directory.Exists(newcopy) Then
                            MessageBox.Show("Folder '" & foldername & "' already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            txtitemname.Text = ""
                            fileorfolder = ""
                            Exit Sub
                        Else
                            My.Computer.FileSystem.CopyDirectory(foldertocopy, newcopy)
                            Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly
                            For Each Files In My.Computer.FileSystem.GetFiles(newcopy, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                File.SetAttributes(Files, attribute)
                            Next
                            msg = True
                            explorerlistview.Items.Clear()
                            displayfilesandfolders()
                            spaceconsumed()
                            remainingspacee()
                            txtitemname.Text = ""
                            fileorfolder = ""
                            FolderBrowserDialog1.Dispose()
                            MessageBox.Show("Items successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("Cannot complete the process because there is no enough space left.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtitemname.Text = ""
                        fileorfolder = ""
                        FolderBrowserDialog1.Dispose()
                        Exit Sub
                    End If
                End If
                txtsearch.Text = ""
            ElseIf readytoexport = "No" Then
                MessageBox.Show("Select an item to import.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root forlder has been deleted. Please close the explorer an open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click

        If Directory.Exists(combination2) Then
            txtsearch.Text = ""
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
            explorerlistview.Items.Clear()
            displayfilesandfolders()
            countfilesandfolders()
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root forlder has been deleted. Please close the explorer an open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub opentheitem()

        If Directory.Exists(combination2) Then
            If txtsearch.Text = "" Then
                For Each item1 As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item1 = explorerlistview.SelectedItems.Item(0)
                        Dim itemlocation As String = combination2 & "\" & (item1.SubItems(0).Text)
                        If item1.SubItems(2).Text = "Folder" Then
                            If Directory.Exists(itemlocation) Then
                                path2.Text += "\" & item1.SubItems(0).Text
                                combination2 += "\" & item1.SubItems(0).Text
                                txtexploreritemlength.Text = Microsoft.VisualBasic.Len(ngalan)
                                txtcombination2length.Text = Microsoft.VisualBasic.Len(combination2)
                                txtexplorerpathlength.Text = Microsoft.VisualBasic.Len(path2.Text)
                                If txtselecetditemlength.Text = txtexplorerpathlength.Text Then
                                    btnback.Enabled = False
                                Else
                                    btnback.Enabled = True
                                End If
                                explorerlistview.Items.Clear()
                                displayfilesandfolders()
                                countfilesandfolders()
                            Else
                                MessageBox.Show("Directory '" & item1.SubItems(0).Text & "' cannot be located, it might be renamed, removed or has been deleted. Please refresh and try again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        Else
                            If File.Exists(itemlocation & item1.SubItems(2).Text) Then
                                Process.Start(itemlocation & item1.SubItems(2).Text)
                            Else
                                MessageBox.Show("File '" & item1.SubItems(0).Text & "' cannot be located, it might be renamed, removed or has been deleted. Please refresh and try again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If
                        item1.Selected = False
                    End If
                Next
            Else
                For Each item1 As ListViewItem In explorerlistview.Items
                    If explorerlistview.SelectedItems.Count > 0 Then
                        item1 = explorerlistview.SelectedItems.Item(0)
                        Dim replacepath As String
                        Dim itemlocation As String
                        If item1.SubItems(4).Text = ".." Then
                            replacepath = item1.SubItems(4).Text.Replace("..", combination2)
                            itemlocation = replacepath & "\" & item1.SubItems(0).Text
                        Else
                            replacepath = item1.SubItems(4).Text.Replace("..\", combination2 & "\")
                            itemlocation = replacepath & "\" & item1.SubItems(0).Text
                        End If
                        If item1.SubItems(2).Text = "Folder" Then
                            If Directory.Exists(itemlocation) Then
                                If item1.SubItems(4).Text = ".." Then
                                    path2.Text = selectedfoldername & "\" & item1.SubItems(4).Text.Replace("..", "") & item1.SubItems(0).Text
                                Else
                                    path2.Text = selectedfoldername & "\" & item1.SubItems(4).Text.Replace("..\", "") & "\" & item1.SubItems(0).Text
                                End If
                                combination2 = itemlocation

                                txtexploreritemlength.Text = Microsoft.VisualBasic.Len(item1.SubItems(0).Text)
                                txtcombination2length.Text = Microsoft.VisualBasic.Len(combination2)
                                txtexplorerpathlength.Text = Microsoft.VisualBasic.Len(path2.Text)
                                txtsearch.Text = ""
                                If txtselecetditemlength.Text = txtexplorerpathlength.Text Then
                                    btnback.Enabled = False
                                Else
                                    btnback.Enabled = True
                                End If
                                explorerlistview.Items.Clear()
                                displayfilesandfolders()
                                countfilesandfolders()
                                Exit Sub
                            Else
                                MessageBox.Show("Directory '" & item1.SubItems(0).Text & "' cannot be located, it might be renamed, removed or has been deleted. Please refresh and try again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        Else
                            If File.Exists(itemlocation & item1.SubItems(2).Text.ToLower) Then
                                Process.Start(itemlocation & item1.SubItems(2).Text.ToLower)
                                Exit Sub
                            Else
                                MessageBox.Show("File '" & item1.SubItems(0).Text & "' cannot be located, it might be renamed, removed or has been deleted. Please refresh and try again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        End If
                        item1.Selected = False
                        End If
                Next
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root forlder has been deleted. Please close the explorer an open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub explorerlistview_DoubleClick(sender As Object, e As EventArgs) Handles explorerlistview.DoubleClick

        opentheitem()

    End Sub

    Private Sub txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsearch.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnrefresh.PerformClick()
        End If
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click

        If Directory.Exists(combination2) Then
            If txtexportationpath.Text = Nothing Then
                MessageBox.Show("Enter the destination path.", "alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If txtsearch.Text = "" Then
                    Dim msg As Boolean = False
                    'Dim itemcounter As Boolean
                    For Each item As ListViewItem In explorerlistview.Items
                        If explorerlistview.SelectedItems.Count > 0 Then
                            item = explorerlistview.SelectedItems.Item(0)
                            Dim itemlocation As String = combination2 & "\" & (item.SubItems(0).Text)

                            If File.Exists(itemlocation & item.SubItems(2).Text.ToLower) Then
                                If Directory.Exists(txtexportationpath.Text) = True Then
                                    Dim FileToCopy As String = itemlocation & item.SubItems(2).Text.ToLower
                                    Dim NewCopy As String = txtexportationpath.Text & "\" & (item.SubItems(0).Text) & item.SubItems(2).Text.ToLower
                                    If File.Exists(NewCopy) Then
                                        MessageBox.Show("File '" & item.SubItems(0).Text & "' already exist on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Else
                                        System.IO.File.Copy(FileToCopy, NewCopy)
                                        Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly = False
                                        File.SetAttributes(NewCopy, attribute)
                                        msg = True
                                    End If
                                Else
                                    MessageBox.Show("Destination path does not exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If

                            ElseIf Directory.Exists(itemlocation) Then
                                If Directory.Exists(txtexportationpath.Text) = False Then
                                    MessageBox.Show("Destination path does not exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                Else
                                    Dim FileToCopy As String = itemlocation
                                    Dim destination As String = txtexportationpath.Text & "\" & (item.SubItems(0).Text)
                                    If Directory.Exists(destination) = True Then
                                        MessageBox.Show("Folder '" & item.SubItems(0).Text & "' already exist on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Else
                                        My.Computer.FileSystem.CopyDirectory(FileToCopy, destination)
                                        My.Computer.FileSystem.CopyDirectory(item.SubItems(1).Text, FolderBrowserDialog2.SelectedPath & "\" & item.SubItems(0).Text)
                                        Dim attribute As System.IO.FileAttributes = IO.FileAttributes.ReadOnly = False
                                        For Each Files In My.Computer.FileSystem.GetFiles(FolderBrowserDialog2.SelectedPath & "\" & item.SubItems(0).Text, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                                            File.SetAttributes(destination, attribute)
                                        Next
                                        msg = True
                                    End If

                                End If
                            End If
                            item.Selected = False
                            If explorerlistview.SelectedItems.Count = 0 Then
                                txtexportationpath.Text = ""
                                If msg = True Then
                                    MessageBox.Show("Items successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                        End If
                    Next
                Else ' ========== Export in Search Mode ==========
                    Dim msg As Boolean = False
                    For Each item As ListViewItem In explorerlistview.Items
                        If explorerlistview.SelectedItems.Count > 0 Then
                            item = explorerlistview.SelectedItems.Item(0)
                            Dim itemlocation As String = item.SubItems(4).Text.Replace("..", combination2) & "\" & (item.SubItems(0).Text)

                            If File.Exists(itemlocation & item.SubItems(2).Text.ToLower) Then
                                'MsgBox(itemlocation & item.SubItems(2).Text.ToLower)
                                If Directory.Exists(txtexportationpath.Text) = True Then
                                    Dim FileToCopy As String = itemlocation & item.SubItems(2).Text.ToLower
                                    Dim NewCopy As String = txtexportationpath.Text & "\" & (item.SubItems(0).Text) & item.SubItems(2).Text.ToLower
                                    If File.Exists(NewCopy) Then
                                        MessageBox.Show("File '" & item.SubItems(0).Text & "' already exist on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Else
                                        System.IO.File.Copy(FileToCopy, NewCopy)
                                        msg = True
                                    End If
                                Else
                                    MessageBox.Show("Destination path does not exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If

                            ElseIf Directory.Exists(itemlocation) Then
                                'MsgBox(itemlocation)
                                If Directory.Exists(txtexportationpath.Text) = False Then
                                    MessageBox.Show("Destination path does not exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                Else
                                    Dim FileToCop As String = itemlocation
                                    Dim destination As String = txtexportationpath.Text & "\" & (item.SubItems(0).Text)

                                    If Directory.Exists(destination) = True Then
                                        MessageBox.Show("Folder '" & item.SubItems(0).Text & "' already exist on the selected path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Else
                                        My.Computer.FileSystem.CopyDirectory(FileToCop, destination)
                                        msg = True
                                    End If
                                End If
                            End If
                            item.Selected = False
                            If explorerlistview.SelectedItems.Count = 0 Then
                                txtexportationpath.Text = ""
                                If msg = True Then
                                    MessageBox.Show("Items successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                        End If
                    Next
                End If
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root forlder has been deleted. Please close the explorer an open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    'Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

    '    If txtsearch.Text = "" Then
    '        explorerlistview.Items.Clear()
    '    Else

    '        explorerlistview.Items.Clear()
    '        For Each item As String In My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
    '            If item.Contains(txtsearch.Text) Then
    '                explorerlistview.Items.Add(My.Computer.FileSystem.GetName(item))
    '            End If
    '        Next

    '        For Each item As String In My.Computer.FileSystem.GetDirectories(combination2, FileIO.SearchOption.SearchAllSubDirectories)
    '            'icons.Images.Add(frmmain.GetShellIcon(item))
    '            'ListView1.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
    '            If item.Contains(txtsearch.Text) Then
    '                explorerlistview.Items.Add(My.Computer.FileSystem.GetName(item))
    '            End If
    '        Next

    '    End If

    'End Sub

    Private Sub search()

        If Directory.Exists(combination2) Then
            explorerlistview.Items.Clear()
            If txtsearch.Text = "" Then
                displayfilesandfolders()
            Else
                explorerlistview.Items.Clear()
                Me.explorerlistview.Columns.Clear()
                Me.explorerlistview.Columns.Add("Name", 300, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Date Modified", 150, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Type", 150, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Size", 100, HorizontalAlignment.Left)
                Me.explorerlistview.Columns.Add("Location", 400, HorizontalAlignment.Left)
                If cbofileorfolder.Text = "File" Then
                    For Each item As String In My.Computer.FileSystem.GetFiles(combination2, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                        If item.Contains(txtsearch.Text) Then
                            icons.Images.Add(Icon.ExtractAssociatedIcon(item).ToBitmap)
                            'Dim lvi As New ListViewItem(My.Computer.FileSystem.GetFileInfo(item).Name, icons.Images.Count - 1)
                            Dim lvi As New ListViewItem(IO.Path.GetFileNameWithoutExtension(item), icons.Images.Count - 1)
                            lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).CreationTime)
                            lvi.SubItems.Add(My.Computer.FileSystem.GetFileInfo(item).Extension.ToUpper)
                            Dim itemsize As Decimal = My.Computer.FileSystem.GetFileInfo(item).Length
                            If (itemsize >= 0 And itemsize < kb) Then
                                lvi.SubItems.Add(itemsize & " bytes")
                            ElseIf (itemsize >= kb AndAlso itemsize < mb) Then
                                lvi.SubItems.Add(Format((itemsize / 1024), "0") & " KB")
                                'lvi.SubItems.Add((itemsize / 1024) & " KB")
                            ElseIf (itemsize >= mb AndAlso itemsize < gb) Then
                                lvi.SubItems.Add(Format((itemsize / 1024 / 1024), "0.00") & " MB")
                            ElseIf (itemsize >= gb) Then
                                lvi.SubItems.Add(Format((itemsize / 1024 / 1024 / 1024), "0.00") & " GB")
                            End If
                            Dim itemlocation As String = My.Computer.FileSystem.GetDirectoryInfo(item).FullName
                            Dim replaceditemlocation As String = item.Replace(combination2, "..")
                            Dim replaceditemlocationlen As String = Microsoft.VisualBasic.Len(replaceditemlocation)
                            Dim spliter As String() = replaceditemlocation.Split("\")
                            Dim trimmedpath As String = spliter.Last.Trim
                            Dim numberoftrimmedpart As Integer = Microsoft.VisualBasic.Len(trimmedpath)
                            lvi.SubItems.Add(Microsoft.VisualBasic.Left(replaceditemlocation, replaceditemlocationlen - (numberoftrimmedpart + 1)))
                            explorerlistview.Items.Add(lvi)
                        End If
                    Next
                ElseIf cbofileorfolder.Text = "Folder" Then
                    For Each item As String In My.Computer.FileSystem.GetDirectories(combination2, FileIO.SearchOption.SearchAllSubDirectories)
                        If item.Contains(txtsearch.Text) Then
                            icons.Images.Add(frmexplorer.GetShellIcon(item))
                            Dim lvi As New ListViewItem(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
                            lvi.SubItems.Add(My.Computer.FileSystem.GetDirectoryInfo(item).CreationTime)
                            lvi.SubItems.Add("Folder")
                            lvi.SubItems.Add("")
                            Dim itemlocation As String = My.Computer.FileSystem.GetDirectoryInfo(item).FullName
                            Dim replaceditemlocation As String = item.Replace(combination2, "..")
                            Dim replaceditemlocationlen As String = Microsoft.VisualBasic.Len(replaceditemlocation)
                            Dim spliter As String() = replaceditemlocation.Split("\")
                            Dim trimmedpath As String = spliter.Last.Trim
                            Dim numberoftrimmedpart As Integer = Microsoft.VisualBasic.Len(trimmedpath)
                            lvi.SubItems.Add(Microsoft.VisualBasic.Left(replaceditemlocation, replaceditemlocationlen - (numberoftrimmedpart + 1)))
                            explorerlistview.Items.Add(lvi)
                        End If
                    Next
                End If
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root forlder has been deleted. Please close the explorer an open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        search()

    End Sub

    Private Sub btnfilebrowser_Click(sender As Object, e As EventArgs) Handles btnfilebrowser.Click

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim filename As String = ""
            Dim counter As Integer = 0
            getfilesizeinexplorer = 0
            For x = 0 To OpenFileDialog1.FileNames.Count - 1
                getfilesizeinexplorer += My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileNames(x)).Length
                counter += 1
                filename = OpenFileDialog1.SafeFileNames(x)
            Next
            Dim size As String = ""
            If (getfilesizeinexplorer >= 0 And getfilesizeinexplorer < kb) Then
                size = getfilesizeinexplorer & " bytes"
            ElseIf (getfilesizeinexplorer >= kb AndAlso getfilesizeinexplorer < mb) Then
                size = Format((getfilesizeinexplorer / 1024), "0") & " KB"
            ElseIf (getfilesizeinexplorer >= mb AndAlso getfilesizeinexplorer < gb) Then
                size = Format((getfilesizeinexplorer / 1024 / 1024), "0.0") & " MB"
            ElseIf (getfilesizeinexplorer >= gb) Then
                size = Format((getfilesizeinexplorer / 1024 / 1024 / 1024), "0.0") & " GB"
            End If
            If counter = 1 Then
                txtitemname.Text = filename & " - " & size
            Else
                txtitemname.Text = counter & " files - " & size
            End If
            readytoexport = "Yes"
            fileorfolder = "File"
        End If

    End Sub

    Private Sub txtfolderbrowser_Click(sender As Object, e As EventArgs) Handles txtfolderbrowser.Click

        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            getfoldersizeinexplorer = 0
            Dim foldersize As String = ""
            Try
                For Each item As String In My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                    getfoldersizeinexplorer += My.Computer.FileSystem.GetFileInfo(item).Length
                Next
            Catch ex As Exception
                MessageBox.Show("Acces to the path '" & FolderBrowserDialog1.SelectedPath & "' is denied.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            If (getfoldersizeinexplorer >= 0 And getfoldersizeinexplorer < kb) Then
                foldersize = getfoldersizeinexplorer & " bytes"
            ElseIf (getfoldersizeinexplorer >= kb AndAlso getfoldersizeinexplorer < mb) Then
                foldersize = Format((getfoldersizeinexplorer / 1024), "0") & " KB"
            ElseIf (getfoldersizeinexplorer >= mb AndAlso getfoldersizeinexplorer < gb) Then
                foldersize = Format((getfoldersizeinexplorer / 1024 / 1024), "0.0") & " MB"
            ElseIf (getfoldersizeinexplorer >= gb) Then
                foldersize = Format((getfoldersizeinexplorer / 1024 / 1024 / 1024), "0.0") & " GB"
            End If
            Dim spliter As String() = FolderBrowserDialog1.SelectedPath.Split("\")
            foldername = spliter.Last.Trim
            txtitemname.Text = foldername & " - " & foldersize
            fileorfolder = "Folder"
            readytoexport = "Yes"
        End If

    End Sub

    Private Sub explorerlistview_KeyDown(sender As Object, e As KeyEventArgs) Handles explorerlistview.KeyDown
        If e.KeyCode = Keys.Enter Then
            opentheitem()
        ElseIf e.KeyCode = Keys.F5 Then
            btnrefresh.PerformClick()
        End If
    End Sub

    Private Sub explorerlistview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles explorerlistview.SelectedIndexChanged

    End Sub


    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

        If Directory.Exists(combination2) Then
            If txtsearch.Text = "" Then
                explorerlistview.Items.Clear()
                displayfilesandfolders()
                myspace()
                spaceconsumed()
                remainingspacee()
                countfilesandfolders()
            Else
                search()
            End If
        Else
            explorerlistview.Items.Clear()
            MessageBox.Show("The path might have change or the root folder has been deleted. Please close the explorer and open again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cboviewmode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboviewmode.SelectedIndexChanged

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

    End Sub


    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If FolderBrowserDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtexportationpath.Text = FolderBrowserDialog2.SelectedPath
        End If

    End Sub

    Private Sub path2_KeyDown(sender As Object, e As KeyEventArgs) Handles path2.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnrefresh.PerformClick()
        End If
    End Sub

    Private Sub path2_TextChanged(sender As Object, e As EventArgs) Handles path2.TextChanged

    End Sub

    Private Sub cbofileorfolder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofileorfolder.SelectedIndexChanged
        txtsearch.Text = ""
    End Sub

    Private Sub btncancelimport_Click(sender As Object, e As EventArgs) Handles btncancelimport.Click
        readytoexport = ""
        fileorfolder = ""
        txtitemname.Text = ""
    End Sub
End Class