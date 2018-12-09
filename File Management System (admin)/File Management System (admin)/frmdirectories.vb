Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmdirectories

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

    Private Sub frmstudentsfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        studentfiles_listview.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        fullname.Text = firstname & " " & middlename & " " & lastname & " - " & account_type

        If Directory.Exists(serverinitialpath) Then

            gbxvolume.Text = "Volume " & drive_location.Replace("\", "")

            For Each item As String In My.Computer.FileSystem.GetDirectories(serverinitialpath)
                icons.Images.Add(GetShellIcon(item))
                studentfiles_listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
            Next

            '================================ COUNT THE FILES AND FOLDER =========================================

            Dim filenumber As Integer = 0
            Dim foldernumber As Integer = 0
            Dim accountfoldernumber As Integer = 0

            Dim files As Object = My.Computer.FileSystem.GetFiles(serverinitialpath, FileIO.SearchOption.SearchAllSubDirectories)
            Dim folders As Object = My.Computer.FileSystem.GetDirectories(serverinitialpath, FileIO.SearchOption.SearchAllSubDirectories)
            Dim accountfolder As Object = My.Computer.FileSystem.GetDirectories(serverinitialpath, FileIO.SearchOption.SearchTopLevelOnly)

            For Each filee In files
                filenumber += 1
            Next
            For Each folderr In folders
                foldernumber += 1
            Next

            txttfiles.Text = filenumber
            txttfolders.Text = foldernumber
            txtot.Text = filenumber + foldernumber

            For Each accountfolderr In accountfolder
                accountfoldernumber += 1
            Next
            txtaf.Text = accountfoldernumber - 1

            '======================== GET DRIVE TOTAL SIZE =============================

            Dim drivespace As Long = My.Computer.FileSystem.GetDriveInfo(drive_location).TotalSize
            Dim drivefreespace As Long = My.Computer.FileSystem.GetDriveInfo(drive_location).TotalFreeSpace
            Dim driveusedspace As Long = 0

            If (drivespace >= 0 And drivespace < kb) Then
                txtds.Text = drivespace & " bytes"
            ElseIf (drivespace >= kb AndAlso drivespace < mb) Then
                txtds.Text = Format((drivespace / 1024), "0.00") & " KB"
            ElseIf (drivespace >= mb AndAlso drivespace < gb) Then
                txtds.Text = Format((drivespace / 1024 / 1024), "0.00") & " MB"
            ElseIf (drivespace >= gb) Then
                txtds.Text = Format((drivespace / 1024 / 1024 / 1024), "0.00") & " GB"
            End If

            '================================== DRIVE FREE SPACE ===========================================

            If (drivefreespace >= 0 And drivefreespace < kb) Then
                txtfs.Text = drivefreespace & " bytes"
            ElseIf (drivefreespace >= kb AndAlso drivefreespace < mb) Then
                txtfs.Text = Format((drivefreespace / 1024), "0.00") & " KB"
            ElseIf (drivefreespace >= mb AndAlso drivefreespace < gb) Then
                txtfs.Text = Format((drivefreespace / 1024 / 1024), "0.00") & " MB"
            ElseIf (drivefreespace >= gb) Then
                txtfs.Text = Format((drivefreespace / 1024 / 1024 / 1024), "0.00") & " GB"
            End If


            '================================== DRIVE USED SPACE ===========================================

            driveusedspace = drivespace - drivefreespace

            If (driveusedspace >= 0 And driveusedspace < kb) Then
                txtus.Text = driveusedspace & " bytes"
            ElseIf (driveusedspace >= kb AndAlso driveusedspace < mb) Then
                txtus.Text = Format((driveusedspace / 1024), "0.00") & " KB"
            ElseIf (driveusedspace >= mb AndAlso driveusedspace < gb) Then
                txtus.Text = Format((driveusedspace / 1024 / 1024), "0.00") & " MB"
            ElseIf (driveusedspace >= gb) Then
                txtus.Text = Format((driveusedspace / 1024 / 1024 / 1024), "0.00") & " GB"
            End If

            '============================== OVERALL SPACE CONSUMED ====================================

            Dim totalspaceconsumed As Decimal = 0
            For Each itemer As String In My.Computer.FileSystem.GetFiles(serverinitialpath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                totalspaceconsumed += My.Computer.FileSystem.GetFileInfo(itemer).Length

                If (totalspaceconsumed >= 0 And totalspaceconsumed < kb) Then
                    txtosc.Text = totalspaceconsumed & " bytes"
                ElseIf (totalspaceconsumed >= kb AndAlso totalspaceconsumed < mb) Then
                    txtosc.Text = Format((totalspaceconsumed / 1024), "0.00") & " KB"
                ElseIf (totalspaceconsumed >= mb AndAlso totalspaceconsumed < gb) Then
                    txtosc.Text = Format((totalspaceconsumed / 1024 / 1024), "0.00") & " MB"
                ElseIf (totalspaceconsumed >= gb) Then
                    txtosc.Text = Format((totalspaceconsumed / 1024 / 1024 / 1024), "0.00") & " GB"
                End If
            Next

            '================================ TOTAL PROVIDED SPACE ==========================================

            Dim tps As Decimal = 0
            tps = asinbytes * txtaf.Text
            If (tps >= 0 And tps < kb) Then
                txtgsfal.Text = tps & " bytes"
            ElseIf (tps >= kb AndAlso tps < mb) Then
                txtgsfal.Text = Format((tps / 1024), "0.00") & " KB"
            ElseIf (tps >= mb AndAlso tps < gb) Then
                txtgsfal.Text = Format((tps / 1024 / 1024), "0.00") & " MB"
            ElseIf (tps >= gb) Then
                txtgsfal.Text = Format((tps / 1024 / 1024 / 1024), "0.00") & " GB"
            End If


            '================================= ESTIMATED USED SPACE ============================================

            Dim eus As Decimal = driveusedspace + tps - totalspaceconsumed
            If (eus >= 0 And eus < kb) Then
                txteus.Text = eus & " bytes"
            ElseIf (eus >= kb AndAlso eus < mb) Then
                txteus.Text = Format((eus / 1024), "0.00") & " KB"
            ElseIf (eus >= mb AndAlso eus < gb) Then
                txteus.Text = Format((eus / 1024 / 1024), "0.00") & " MB"
            ElseIf (eus >= gb) Then
                txteus.Text = Format((eus / 1024 / 1024 / 1024), "0.00") & " GB"
            End If

            '=====================================  ESTIMATED REMAINING SPACE ==========================================

            Dim ers As Long = drivespace - eus
            Dim ers0 As Integer = 0

            If ers < 1 Then
                txters.Text = "0 bytes"
            ElseIf ers.ToString.Contains("-") Then
                txters.Text = "0 bytes"
            Else
                If (ers >= 0 And ers < kb) Then
                    txters.Text = ers & " bytes"
                    ers0 = ers
                ElseIf (ers >= kb AndAlso ers < mb) Then
                    txters.Text = Format((ers / 1024), "0.00") & " KB"
                    ers0 = (ers / 1024)
                ElseIf (ers >= mb AndAlso ers < gb) Then
                    txters.Text = Format((ers / 1024 / 1024), "0.00") & " MB"
                    ers0 = (ers / 1024 / 1024)
                ElseIf (ers >= gb) Then
                    txters.Text = Format((ers / 1024 / 1024 / 1024), "0.00") & " GB"
                    ers0 = (ers / 1024 / 1024 / 1024)
                End If
            End If

            '========================================== TOTAL OF ACCOUNTS TO BE CREATED ==========================================

            Dim aspace As Integer = 0
            If (asinbytes >= 0 And asinbytes < kb) Then
                aspace = asinbytes ' & " bytes"
            ElseIf (asinbytes >= kb AndAlso asinbytes < mb) Then
                aspace = (asinbytes / 1024) ' & " KB"
            ElseIf (asinbytes >= mb AndAlso asinbytes < gb) Then
                aspace = (asinbytes / 1024 / 1024) ' & " MB"
            ElseIf (asinbytes >= gb) Then
                aspace = (asinbytes / 1024 / 1024 / 1024) ' & " GB"
            End If

            If txters.Text = "0 bytes" Then
                txtatbc.Text = "0"
            Else
                txtatbc.Text = Math.Truncate(ers0 / aspace)
            End If


        Else
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
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

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        
        frmexplorer.Close()
        frmprofile.Close()
        frminstructors.Close()
        frmprofile.Close()
        frmsettings.Close()
        frmstudents.Close()
        frmmain.Close()

        frmlogin.txtusername.Focus()
        frmlogin.Show()
        Me.Close()

    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub studentfiles_listview_Click(sender As Object, e As EventArgs) Handles studentfiles_listview.Click

        If Directory.Exists(serverinitialpath) Then
            For Each item As ListViewItem In studentfiles_listview.Items
                If studentfiles_listview.SelectedItems.Count > 0 Then
                    item = studentfiles_listview.SelectedItems.Item(0)
                    Dim itemlocation As String = serverinitialpath & "\" & (item.SubItems(0).Text)

                    If Directory.Exists(itemlocation) Then
                        Label8.Text = item.SubItems(0).Text

                        '---------------------------------------START TOTAL ITEMS--------------------------------------

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
                        Label10.Text = filenumber & " file(s)"
                        Label11.Text = foldernumber & " folder(s)"
                        Label9.Text = filenumber + foldernumber
                        If filenumber = 0 Then
                            Label13.Text = "0 bytes"
                        End If

                        '---------------------------------------END TOTAL ITEMS---------------------------------------

                        '------------------------------------- START ALLOCATED SPACE -----------------------------------------

                        Dim totalspace As Decimal = asinbytes

                        If (totalspace >= 0 And totalspace < kb) Then
                            Label12.Text = totalspace & " bytes"
                        ElseIf (totalspace >= kb AndAlso totalspace < mb) Then
                            Label12.Text = Format((totalspace / 1024), "0.00") & " KB"
                            'Label3.Text = Format(6648972.265, "#,##0.00")
                        ElseIf (totalspace >= mb AndAlso totalspace < gb) Then
                            Label12.Text = Format((totalspace / 1024 / 1024), "0.00") & " MB"
                        ElseIf (totalspace >= gb) Then
                            Label12.Text = Format((totalspace / 1024 / 1024 / 1024), "0.00") & " GB"
                        End If

                        '--------------------------------------END ALLOCATED SPACE -----------------------------------

                        '----------------------------------- START TOTAL SIZE ----------------------------------------

                        Dim totalsize As Long
                        totalsize = 0
                        For Each item0 As String In My.Computer.FileSystem.GetFiles(itemlocation, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                            totalsize += My.Computer.FileSystem.GetFileInfo(item0).Length
                            If (totalsize >= 0 And totalsize < kb) Then
                                Label13.Text = Format(totalsize, "#,##0") & " bytes"
                            ElseIf (totalsize >= kb AndAlso totalsize < mb) Then
                                Label13.Text = Format((totalsize / 1024), "0.00") & " KB" & " (" & Format(totalsize, "#,##0") & " bytes)"
                            ElseIf (totalsize >= mb AndAlso totalsize < gb) Then
                                Label13.Text = Format((totalsize / 1024 / 1024), "0.00") & " MB" & " (" & Format(totalsize, "#,##0") & " bytes)"
                            ElseIf (totalsize >= gb) Then
                                Label13.Text = Format((totalsize / 1024 / 1024 / 1024), "0.00") & " GB" & " (" & Format(totalsize, "#,##0") & " bytes)"
                            End If
                        Next

                        ' ------------------------------------ END TOTAL SIZE ---------------------------------------------------

                        ' ------------------------------------ START REMAINING SPACE -------------------------------------

                        Dim remainingspace As Decimal = totalspace - totalsize

                        If (remainingspace >= 0 And remainingspace < kb) Then
                            Label14.Text = remainingspace & " bytes"
                        ElseIf (remainingspace >= kb AndAlso remainingspace < mb) Then
                            Label14.Text = Format((remainingspace / 1024), "0.00") & " KB (" & Format(remainingspace, "#,##0") & " bytes)"
                        ElseIf (remainingspace >= mb AndAlso remainingspace < gb) Then
                            Label14.Text = Format((remainingspace / 1024 / 1024), "0.00") & " MB (" & Format(remainingspace, "#,##0") & " bytes)"
                        ElseIf (remainingspace >= gb) Then
                            Label14.Text = Format((remainingspace / 1024 / 1024 / 1024), "0.00") & " GB (" & Format(remainingspace, "#,##0") & " bytes)"
                        End If

                        ' ------------------------------------ END REMAINING SPACE --------------------------------------

                        If item.SubItems(0).Text = "images" Then
                            Label8.Text = "Images (for profile pics)"
                            Label12.Text = ""
                            Label14.Text = ""
                        End If
                    Else
                        MessageBox.Show("Directory '" & item.SubItems(0).Text & "' cannot be located, it might be renamed, removed or has been deleted. Please refresh and try again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            Next
        Else
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
        End If

    End Sub

    Private Sub opentheitem()

        If Directory.Exists(serverinitialpath) Then
            For Each item As ListViewItem In studentfiles_listview.Items
                If studentfiles_listview.SelectedItems.Count > 0 Then
                    item = studentfiles_listview.SelectedItems.Item(0)
                    Dim itemlocation As String = serverinitialpath & "\" & (item.SubItems(0).Text)
                    If Directory.Exists(itemlocation) Then
                        Dim type As String = My.Computer.FileSystem.GetFileInfo(itemlocation).Extension
                        Dim ngalan As String = My.Computer.FileSystem.GetDirectoryInfo(itemlocation).Name

                        If System.IO.File.Exists(itemlocation) Then
                            Process.Start(itemlocation)
                        ElseIf System.IO.Directory.Exists(itemlocation) Then
                            frmexplorer.Close()

                            getstudentfoldersize = serverinitialpath & "\" & ngalan
                            selectedfoldername = ngalan
                            If ngalan = "images" Then
                                combination2 = System.IO.Path.Combine(serverinitialpath, ngalan)
                                imageszeroallocatedspace = True
                            Else
                                combination2 = System.IO.Path.Combine(serverinitialpath, ngalan, ngalan)
                            End If
                            pathlength = Microsoft.VisualBasic.Len(ngalan) * 2
                            selectedfolderlength = Microsoft.VisualBasic.Len(ngalan)
                            frmexplorer.path2.Text = ngalan

                            frmexplorer.Show()
                        End If
                        item.Selected = False
                    Else
                        MessageBox.Show("Directory '" & item.SubItems(0).Text & "' cannot be located, it might be renamed, removed or has been deleted. Please refresh and try again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            Next
        Else
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
        End If

    End Sub

    Private Sub studentfiles_listview_DoubleClick(sender As Object, e As EventArgs) Handles studentfiles_listview.DoubleClick

        opentheitem()

    End Sub

    Private Sub studentfiles_listview_KeyDown(sender As Object, e As KeyEventArgs) Handles studentfiles_listview.KeyDown
        If e.KeyCode = Keys.Enter Then
            opentheitem()
        End If
    End Sub

    Private Sub studentfiles_listview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentfiles_listview.SelectedIndexChanged

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        If System.IO.Directory.Exists(serverinitialpath) Then
            Label8.Text = ""
            Label9.Text = ""
            Label10.Text = ""
            Label11.Text = ""
            Label12.Text = ""
            Label13.Text = ""
            Label14.Text = ""

            studentfiles_listview.Items.Clear()
            getsettingsfromdatabase()

            gbxvolume.Text = "Volume " & drive_location.Replace("\", "")

            For Each item As String In My.Computer.FileSystem.GetDirectories(serverinitialpath)
                icons.Images.Add(GetShellIcon(item))
                studentfiles_listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
            Next

            '================================ COUNT THE FILES AND FOLDER =========================================

            Dim filenumber As Integer = 0
            Dim foldernumber As Integer = 0
            Dim accountfoldernumber As Integer = 0

            Dim files As Object = My.Computer.FileSystem.GetFiles(serverinitialpath, FileIO.SearchOption.SearchAllSubDirectories)
            Dim folders As Object = My.Computer.FileSystem.GetDirectories(serverinitialpath, FileIO.SearchOption.SearchAllSubDirectories)
            Dim accountfolder As Object = My.Computer.FileSystem.GetDirectories(serverinitialpath, FileIO.SearchOption.SearchTopLevelOnly)

            For Each filee In files
                filenumber += 1
            Next
            For Each folderr In folders
                foldernumber += 1
            Next

            txttfiles.Text = filenumber
            txttfolders.Text = foldernumber
            txtot.Text = filenumber + foldernumber

            For Each accountfolderr In accountfolder
                accountfoldernumber += 1
            Next
            txtaf.Text = accountfoldernumber - 1

            '======================== GET DRIVE TOTAL SIZE =============================

            Dim drivespace As Decimal = My.Computer.FileSystem.GetDriveInfo("C:").TotalSize
            Dim drivefreespace As Decimal = My.Computer.FileSystem.GetDriveInfo("C:").TotalFreeSpace
            Dim driveusedspace As Decimal = 0

            If (drivespace >= 0 And drivespace < kb) Then
                txtds.Text = drivespace & " bytes"
            ElseIf (drivespace >= kb AndAlso drivespace < mb) Then
                txtds.Text = Format((drivespace / 1024), "0.00") & " KB"
            ElseIf (drivespace >= mb AndAlso drivespace < gb) Then
                txtds.Text = Format((drivespace / 1024 / 1024), "0.00") & " MB"
            ElseIf (drivespace >= gb) Then
                txtds.Text = Format((drivespace / 1024 / 1024 / 1024), "0.00") & " GB"
            End If

            '================================== DRIVE FREE SPACE ===========================================

            If (drivefreespace >= 0 And drivefreespace < kb) Then
                txtfs.Text = drivefreespace & " bytes"
            ElseIf (drivefreespace >= kb AndAlso drivefreespace < mb) Then
                txtfs.Text = Format((drivefreespace / 1024), "0.00") & " KB"
            ElseIf (drivefreespace >= mb AndAlso drivefreespace < gb) Then
                txtfs.Text = Format((drivefreespace / 1024 / 1024), "0.00") & " MB"
            ElseIf (drivefreespace >= gb) Then
                txtfs.Text = Format((drivefreespace / 1024 / 1024 / 1024), "0.00") & " GB"
            End If


            '================================== DRIVE USED SPACE ===========================================

            driveusedspace = drivespace - drivefreespace

            If (driveusedspace >= 0 And driveusedspace < kb) Then
                txtus.Text = driveusedspace & " bytes"
            ElseIf (driveusedspace >= kb AndAlso driveusedspace < mb) Then
                txtus.Text = Format((driveusedspace / 1024), "0.00") & " KB"
            ElseIf (driveusedspace >= mb AndAlso driveusedspace < gb) Then
                txtus.Text = Format((driveusedspace / 1024 / 1024), "0.00") & " MB"
            ElseIf (driveusedspace >= gb) Then
                txtus.Text = Format((driveusedspace / 1024 / 1024 / 1024), "0.00") & " GB"
            End If

            '============================== OVERALL SPACE CONSUMED ====================================

            Dim totalspaceconsumed As Decimal = 0
            For Each itemer As String In My.Computer.FileSystem.GetFiles(serverinitialpath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")

                totalspaceconsumed += My.Computer.FileSystem.GetFileInfo(itemer).Length
                If (totalspaceconsumed >= 0 And totalspaceconsumed < kb) Then
                    txtosc.Text = totalspaceconsumed & " bytes"
                ElseIf (totalspaceconsumed >= kb AndAlso totalspaceconsumed < mb) Then
                    txtosc.Text = Format((totalspaceconsumed / 1024), "0.00") & " KB"
                ElseIf (totalspaceconsumed >= mb AndAlso totalspaceconsumed < gb) Then
                    txtosc.Text = Format((totalspaceconsumed / 1024 / 1024), "0.00") & " MB"
                ElseIf (totalspaceconsumed >= gb) Then
                    txtosc.Text = Format((totalspaceconsumed / 1024 / 1024 / 1024), "0.00") & " GB"
                End If
            Next

            '================================ TOTAL PROVIDED SPACE ==========================================

            Dim tps As Decimal = 0
            tps = asinbytes * txtaf.Text
            If (tps >= 0 And tps < kb) Then
                txtgsfal.Text = tps & " bytes"
            ElseIf (tps >= kb AndAlso tps < mb) Then
                txtgsfal.Text = Format((tps / 1024), "0.00") & " KB"
            ElseIf (tps >= mb AndAlso tps < gb) Then
                txtgsfal.Text = Format((tps / 1024 / 1024), "0.00") & " MB"
            ElseIf (tps >= gb) Then
                txtgsfal.Text = Format((tps / 1024 / 1024 / 1024), "0.00") & " GB"
            End If


            '================================= ESTIMATED USED SPACE ============================================

            Dim eus As Decimal = driveusedspace + tps - totalspaceconsumed
            If (eus >= 0 And eus < kb) Then
                txteus.Text = eus & " bytes"
            ElseIf (eus >= kb AndAlso eus < mb) Then
                txteus.Text = Format((eus / 1024), "0.00") & " KB"
            ElseIf (eus >= mb AndAlso eus < gb) Then
                txteus.Text = Format((eus / 1024 / 1024), "0.00") & " MB"
            ElseIf (eus >= gb) Then
                txteus.Text = Format((eus / 1024 / 1024 / 1024), "0.00") & " GB"
            End If

            '=====================================  ESTIMATED REMAINING SPACE ==========================================

            Dim ers As Long = drivespace - eus
            Dim ers0 As Integer = 0

            If ers.ToString.Contains("-") Then
                txters.Text = "0 bytes"
            ElseIf (ers >= 0 And ers < kb) Then
                txters.Text = ers & " bytes"
                ers0 = ers
            ElseIf (ers >= kb AndAlso ers < mb) Then
                txters.Text = Format((ers / 1024), "0.00") & " KB"
                ers0 = (ers / 1024)
            ElseIf (ers >= mb AndAlso ers < gb) Then
                txters.Text = Format((ers / 1024 / 1024), "0.00") & " MB"
                ers0 = (ers / 1024 / 1024)
            ElseIf (ers >= gb) Then
                txters.Text = Format((ers / 1024 / 1024 / 1024), "0.00") & " GB"
                ers0 = (ers / 1024 / 1024 / 1024)
            End If

            '========================================== TOTAL OF ACCOUNTS TO BE CREATED ==========================================

            Dim aspace As Integer = 0
            If (asinbytes >= 0 And asinbytes < kb) Then
                aspace = asinbytes ' & " bytes"
            ElseIf (asinbytes >= kb AndAlso asinbytes < mb) Then
                aspace = (asinbytes / 1024) ' & " KB"
            ElseIf (asinbytes >= mb AndAlso asinbytes < gb) Then
                aspace = (asinbytes / 1024 / 1024) ' & " MB"
            ElseIf (asinbytes >= gb) Then
                aspace = (asinbytes / 1024 / 1024 / 1024) ' & " GB"
            End If

            If txters.Text = "0 bytes" Then
                txtatbc.Text = "0"
            Else
                txtatbc.Text = Math.Truncate(ers0 / aspace)
            End If

        Else
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
        End If

    End Sub

    Private Sub fullname_Click(sender As Object, e As EventArgs) Handles fullname.Click
        frmprofile.Close()
        frmprofile.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmsettings.Close()
        frmsettings.ShowInTaskbar = False
        frmsettings.ShowDialog()
    End Sub

    Private Sub btninstructors_Click(sender As Object, e As EventArgs) Handles btninstructors.Click
        frminstructors.Show()
        Me.Close()
    End Sub

    Private Sub btnstudents_Click(sender As Object, e As EventArgs) Handles btnstudents.Click
        frmstudents.Show()
        Me.Close()
    End Sub

    Private Sub btnmysubject_Click(sender As Object, e As EventArgs) Handles btnmysubject.Click
        frmmain.Show()
        Me.Close()
    End Sub

End Class