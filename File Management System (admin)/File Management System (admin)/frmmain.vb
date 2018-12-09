'Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Sockets
Imports System.Net.NetworkInformation
Imports System.IO

Public Class frmmain

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

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fullname.Text = firstname & " " & middlename & " " & lastname & " - " & account_type
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        getsettingsfromdatabase()

        'dgrid_mystudents.Columns.Add(0, "Account ID")
        'dgrid_mystudents.Columns.Add(1, "Firstname")
        'dgrid_mystudents.Columns.Add(2, "Middlename")
        'dgrid_mystudents.Columns.Add(3, "Lastname")
        'dgrid_mystudents.Columns.Add(4, "Department")
        'dgrid_mystudents.Columns.Add(5, "Year")
        'dgrid_mystudents.Columns.Add(6, "Fullname")
        'dgrid_mystudents.Columns(6).Visible = False

        'dgrid_mystudents.Columns(0).Width = "100"
        'dgrid_mystudents.Columns(1).Width = "113"
        'dgrid_mystudents.Columns(2).Width = "113"
        'dgrid_mystudents.Columns(3).Width = "113"
        'dgrid_mystudents.Columns(4).Width = "90"
        'dgrid_mystudents.Columns(5).Width = "91"
        'dgrid_mystudents.ForeColor = Color.Azure
        'dgrid_mystudents.ClearSelection()

        openconnection()
        Dim ds As New DataSet
        Dim sql As String

        sql = "select distinct subject_name from instructor_subject where instructor_id = '" & id & "'"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")
        For Each r As DataRow In ds.Tables(0).Rows
            cbosubject.Items.Add(r("subject_name"))
        Next

        con.Close()

        loadmypicture = serverinitialpath & "\images\" & picname
        listview.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        cbosearch.Text = "Account ID"

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


    Private Sub btn_instructors_Click(sender As Object, e As EventArgs)
        frminstructors.Show()
        Me.Close()
    End Sub

    Private Sub btn_students_Click(sender As Object, e As EventArgs)
        frmstudents.Show()
        Me.Hide()
    End Sub

    Private Sub cbotry1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosubject.SelectedIndexChanged

        dgrid_mystudents.DataSource = Nothing
        cbosday.Items.Clear()
        cbostime.Items.Clear()
        txtsearchbox.ReadOnly = True
        txtsearchbox.Text = ""

        openconnection()
        cmd.CommandText = "select subject_description from instructor_subject where subject_name = '" & cbosubject.Text & "' and instructor_id = '" & id & "'"
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            txtdescription.Text = dr("subject_description").ToString()
            dr.Close()

            '----------------------------------------------
            Dim ds As New DataSet
            Dim sql As String

            sql = "select distinct subject_day from instructor_subject where subject_name = '" & cbosubject.Text & "' and subject_description = '" & txtdescription.Text & "' and instructor_id = '" & id & "'"
            sqlda = New MySqlDataAdapter(sql, con)

            sqlda.Fill(ds, "fms")

            For Each r As DataRow In ds.Tables(0).Rows
                cbosday.Items.Add(r("subject_day"))
            Next

            cbosday.Text = ""
            cbosday.Enabled = True
            cbostime.Text = ""
            cbostime.Enabled = False
            btn_deletestudents.Enabled = False
            btn_deletesubject.Enabled = False
            listview.Items.Clear()

        Else
            MessageBox.Show("Subject doesn't exist anymore.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        con.Close()

    End Sub

    Private Sub btn_addsubject_Click(sender As Object, e As EventArgs) Handles btn_addsubject.Click

        Dim ds As New DataSet
        Dim sql As String
        sql = "SELECT distinct subject_name FROM `instructor_subject` where instructor_id = '" & id & "'"
        sqlda = New MySqlDataAdapter(sql, con)
        sqlda.Fill(ds, "fms")
        frmaddsubjects.cbomysubjects.Items.Clear()
        For Each r As DataRow In ds.Tables(0).Rows
            frmaddsubjects.cbomysubjects.Items.Add(r("subject_name"))
        Next

        con.Close()

        subjectgrabber = cbosubject.Text
        daygrabber = cbosday.Text
        timegrabber = cbostime.Text
        frmaddsubjects.cbosecondday.Enabled = False
        frmaddsubjects.ShowInTaskbar = False
        frmaddsubjects.ShowDialog()

    End Sub

    Private Sub btn_addstudent_Click(sender As Object, e As EventArgs) Handles btn_addstudent.Click
        If cbosubject.Text <> "" And cbosday.Text <> "" And cbostime.Text <> "" Then
            openconnection()
            cmd.CommandText = "select * from instructor_subject where instructor_id = '" & id & "' and subject_name = '" & cbosubject.Text & "' and subject_time = '" & cbostime.Text & "' and subject_day = '" & cbosday.Text & "'"

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()

                subject_id = dr("subject_id").ToString()
                subject_name = dr("subject_name").ToString()
                subject_time = dr("subject_time").ToString()
                subject_day = dr("subject_day").ToString()
                dr.Close()
                frmaddstudents.ShowInTaskbar = False
                frmaddstudents.ShowDialog()

            Else
                MessageBox.Show("Subject doesn't exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            con.Close()
        Else
            MessageBox.Show("Select a subject.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_deletesubject_Click(sender As Object, e As EventArgs) Handles btn_deletesubject.Click

        If cbosubject.Text <> "" And txtdescription.Text <> "" And cbosday.Text <> "" And cbostime.Text <> "" Then
            confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If confirm = vbOK Then

                openconnection()

                cmddelete = "DELETE FROM `student_subject` where subject_name='" & cbosubject.Text & "' and time = '" & cbostime.Text & "' and day = '" & cbosday.Text & "'"
                sqlda = New MySqlDataAdapter(cmddelete, con)
                ds = New DataSet()
                sqlda.Fill(ds)

                cmddelete = "DELETE FROM `instructor_subject` where subject_name='" & cbosubject.Text & "' and subject_time = '" & cbostime.Text & "' and subject_day = '" & cbosday.Text & "'"
                sqlda = New MySqlDataAdapter(cmddelete, con)
                ds = New DataSet()
                sqlda.Fill(ds)

                MessageBox.Show("Subject '" & cbosubject.Text & "' has been successfully deleted.", "informed", MessageBoxButtons.OK, MessageBoxIcon.Information)


                cbosday.Items.Clear()
                cbostime.Items.Clear()
                cbosubject.Items.Clear()
                cbosday.Text = ""
                cbostime.Text = ""
                cbosubject.Text = ""
                txtdescription.Text = ""
                cbosday.Enabled = False
                cbostime.Enabled = False
                btn_deletestudents.Enabled = False
                btn_deletesubject.Enabled = False
                txtsearchbox.ReadOnly = True

                'selectstudentfrommysubject()
                dgrid_mystudents.DataSource = Nothing
                listview.Items.Clear()

                loadsubjectincombobox()
            End If
        Else
            MessageBox.Show("Choose a subject to delete.", "informed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_deletestudents_Click(sender As Object, e As EventArgs) Handles btn_deletestudents.Click

        confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If confirm = vbOK Then
            openconnection()
            For i As Integer = Me.dgrid_mystudents.SelectedRows.Count - 1 To 0 Step -1
                cmddelete = "DELETE FROM `student_subject` where student_id='" & Me.dgrid_mystudents.SelectedRows(i).Cells(0).Value.ToString() & "' and subject_name = '" & cbosubject.Text & "' and time = '" & cbostime.Text & "' and day = '" & cbosday.Text & "'"
                sqlda = New MySqlDataAdapter(cmddelete, con)
                ds = New DataSet()
                sqlda.Fill(ds)
                Me.dgrid_mystudents.Rows.Remove(Me.dgrid_mystudents.SelectedRows(i))
            Next

            listview.Items.Clear()

            For i As Integer = 0 To dgrid_mystudents.RowCount - 1
                Dim supercombination As String = serverinitialpath & "\" & dgrid_mystudents.Rows(i).Cells(6).Value.ToString
                For Each item As String In My.Computer.FileSystem.GetDirectories(supercombination)
                    icons.Images.Add(GetShellIcon(item))
                    listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
                Next
            Next
            MessageBox.Show("Deleted successfully.", "informed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_refreshmysubjects_Click(sender As Object, e As EventArgs) Handles btn_refreshmysubjects.Click

        If cbosubject.Text = "" Or cbosday.Text = "" Or cbostime.Text = "" Then

        Else
            txtsearchbox.Text = ""
            openconnection()
            listview.Items.Clear()

            querystudents()
            dgrid_mystudents.DataSource = dt
            dgrid_mystudents.Sort(dgrid_mystudents.Columns("Lastname"), System.ComponentModel.ListSortDirection.Ascending)
            dgrid_mystudents.Sort(dgrid_mystudents.Columns("fullname"), System.ComponentModel.ListSortDirection.Ascending)

            dgrid_mystudents.Columns(6).Visible = False
            dgrid_mystudents.Columns("account_id").HeaderText = "Account ID"
            dgrid_mystudents.Columns("firstname").HeaderText = "Firstname"
            dgrid_mystudents.Columns("middlename").HeaderText = "Middlename"
            dgrid_mystudents.Columns("lastname").HeaderText = "Lastname"
            dgrid_mystudents.Columns("year").HeaderText = "Year"
            dgrid_mystudents.Columns("course").HeaderText = "Department"

            dgrid_mystudents.Columns("account_id").Width = "100"
            dgrid_mystudents.Columns("firstname").Width = "113"
            dgrid_mystudents.Columns("middlename").Width = "113"
            dgrid_mystudents.Columns("lastname").Width = "113"
            dgrid_mystudents.Columns("year").Width = "90"
            dgrid_mystudents.Columns("course").Width = "91"
            dgrid_mystudents.ClearSelection()

            If System.IO.Directory.Exists(serverinitialpath) Then
                For i As Integer = 0 To dgrid_mystudents.RowCount - 1
                    Dim supercombination As String = serverinitialpath & "\" & dgrid_mystudents.Rows(i).Cells(6).Value.ToString

                    For Each item As String In My.Computer.FileSystem.GetDirectories(supercombination)
                        icons.Images.Add(GetShellIcon(item))
                        listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
                    Next
                Next

                Dim ds As New DataSet
                Dim sql As String


                sql = "select subject_name from instructor_subject where instructor_id = '" & id & "'"
                sqlda = New MySqlDataAdapter(sql, con)

                sqlda.Fill(ds, "fms")

                'For Each r As DataRow In ds.Tables(0).Rows
                '    cbo_mysubjects.Items.Add(r("subject_name"))
                'Next

                con.Close()
            Else
                MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                frmsettings.ShowDialog()
            End If
        End If

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

        frmexplorer.Close()
        frmprofile.Close()
        frminstructors.Close()
        frmprofile.Close()
        frmsettings.Close()
        frmstudents.Close()
        frmdirectories.Close()

        frmlogin.txtusername.Focus()
        frmlogin.Show()
        Me.Close()

    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub opentheitem()

        Dim path1 As String = serverinitialpath & "\"
        For Each item As ListViewItem In listview.Items
            If listview.SelectedItems.Count > 0 Then
                item = listview.SelectedItems.Item(0)
                item.Selected = False

                Dim itemlocation As String = path1 & (item.SubItems(0).Text)
                If System.IO.File.Exists(itemlocation) Then
                    Process.Start(itemlocation)
                ElseIf System.IO.Directory.Exists(itemlocation) Then
                    frmexplorer.Close()

                    getstudentfoldersize = serverinitialpath & "\" & item.SubItems(0).Text
                    selectedfoldername = item.SubItems(0).Text
                    combination2 = System.IO.Path.Combine(serverinitialpath, item.SubItems(0).Text, item.SubItems(0).Text)
                    pathlength = Microsoft.VisualBasic.Len(item.SubItems(0).Text) * 2
                    selectedfolderlength = Microsoft.VisualBasic.Len(item.SubItems(0).Text)
                    frmexplorer.path2.Text = item.SubItems(0).Text

                    frmexplorer.Show()
                Else
                    MessageBox.Show("Directory '" & item.SubItems(0).Text & "' cannot be located, it might be renamed, removed or has been deleted. Please refresh and try again.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next

    End Sub

    Private Sub listview_DoubleClick(sender As Object, e As EventArgs) Handles listview.DoubleClick

        opentheitem()

    End Sub


    Private Sub btn_studentregistration_Click(sender As Object, e As EventArgs) Handles btn_studentregistration.Click
        frmstudentsregistration.ShowInTaskbar = False
        frmstudentsregistration.ShowDialog()
    End Sub

    Private Sub fullname_Click(sender As Object, e As EventArgs) Handles fullname.Click
        frmprofile.Close()
        frmprofile.Show()
        frmprofile.btnedit.Focus()
    End Sub

    Private Sub searchid(valuetosearch As String)

        Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where account_id like '%" & valuetosearch & "%' and student_subject.subject_name = '" & cbosubject.Text & "' and student_subject.time = '" & cbostime.Text & "' and student_subject.day = '" & cbosday.Text & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgrid_mystudents.DataSource = table

        dgrid_mystudents.Sort(dgrid_mystudents.Columns("Lastname"), System.ComponentModel.ListSortDirection.Ascending)
        dgrid_mystudents.Sort(dgrid_mystudents.Columns("fullname"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub searchfname(valuetosearch As String)

        Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where firstname like '%" & valuetosearch & "%' and student_subject.subject_name = '" & cbosubject.Text & "' and student_subject.time = '" & cbostime.Text & "' and student_subject.day = '" & cbosday.Text & "'"
        'Dim searchquery As String = "SELECT driver_id as 'Driver ID', fname as 'Firstname', mname as 'Middlename', lname as 'Lastname', address, age as 'Age', gender, contact_number as 'Contact Number', date_of_birth, date_registered, liters_consumed, distance_traveled, travel_status as 'Availability Status', service_start FROM tbl_drivers where address like '%" & valuetosearch & "%' and travel_status = '" & cboavailability.Text & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgrid_mystudents.DataSource = table

        dgrid_mystudents.Sort(dgrid_mystudents.Columns("Lastname"), System.ComponentModel.ListSortDirection.Ascending)
        dgrid_mystudents.Sort(dgrid_mystudents.Columns("fullname"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub searchmname(valuetosearch As String)

        Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where middlename like '%" & valuetosearch & "%' and student_subject.subject_name = '" & cbosubject.Text & "' and student_subject.time = '" & cbostime.Text & "' and student_subject.day = '" & cbosday.Text & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgrid_mystudents.DataSource = table

        dgrid_mystudents.Sort(dgrid_mystudents.Columns("Lastname"), System.ComponentModel.ListSortDirection.Ascending)
        dgrid_mystudents.Sort(dgrid_mystudents.Columns("fullname"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub searchlname(valuetosearch As String)

        Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where lastname like '%" & valuetosearch & "%' and student_subject.subject_name = '" & cbosubject.Text & "' and student_subject.time = '" & cbostime.Text & "' and student_subject.day = '" & cbosday.Text & "'"
        '"select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where lastname like '%" & valuetosearch & "%' and student_subject.subject_name = '" & frmmain.cbotry1.Text & "' and student_subject.time = '" & frmmain.cbotry2.Text & "' and student_subject.day = '" & frmmain.txtdays.Text & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgrid_mystudents.DataSource = table

        dgrid_mystudents.Sort(dgrid_mystudents.Columns("Lastname"), System.ComponentModel.ListSortDirection.Ascending)
        dgrid_mystudents.Sort(dgrid_mystudents.Columns("fullname"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub txtsearchbox_TextChanged(sender As Object, e As EventArgs) Handles txtsearchbox.TextChanged

        If cbosearch.Text = "Account ID" Then
            searchid(txtsearchbox.Text)
            dgrid_mystudents.ClearSelection()
            'selectstudentfrommysubject()
            'dgrid_mystudents.DataSource = dt
        ElseIf cbosearch.Text = "Firstname" Then
            searchfname(txtsearchbox.Text)
            dgrid_mystudents.ClearSelection()
        ElseIf cbosearch.Text = "Middlename" Then
            searchmname(txtsearchbox.Text)
            dgrid_mystudents.ClearSelection()
        ElseIf cbosearch.Text = "Lastname" Then
            searchlname(txtsearchbox.Text)
            dgrid_mystudents.ClearSelection()
        End If

        listview.Items.Clear()

        For i As Integer = 0 To dgrid_mystudents.RowCount - 1
            'getsettingsfromdatabase()
            Dim supercombination As String = serverinitialpath & "\" & dgrid_mystudents.Rows(i).Cells(6).Value.ToString

            For Each item As String In My.Computer.FileSystem.GetDirectories(supercombination)
                icons.Images.Add(GetShellIcon(item))
                listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
            Next
        Next

    End Sub

    Private Sub cbosearch_SelectedIndexChanged(sender As Object, e As EventArgs)
        txtsearchbox.Text = ""
    End Sub

    Private Sub cbosday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosday.SelectedIndexChanged

        dgrid_mystudents.DataSource = Nothing
        cbostime.Items.Clear()
        listview.Items.Clear()

        openconnection()

        Dim ds As New DataSet
        Dim sql As String

        sql = "select subject_time from instructor_subject where subject_name = '" & cbosubject.Text & "' and subject_day = '" & cbosday.Text & "' and instructor_id = '" & id & "'"
        sqlda = New MySqlDataAdapter(sql, con)

        sqlda.Fill(ds, "fms")

        For Each r As DataRow In ds.Tables(0).Rows
            cbostime.Items.Add(r("subject_time"))
        Next

        con.Close()

        cbostime.Text = ""
        cbostime.Enabled = True
        btn_deletestudents.Enabled = False
        btn_deletesubject.Enabled = False
        txtsearchbox.ReadOnly = True
        txtsearchbox.Text = ""
        selectedsubject = cbosubject.Text
        selectedday = cbosday.Text
        selectedtime = cbostime.Text

        'querystudents()
        'dgrid_mystudents.DataSource = dt

        'For i As Integer = 0 To dgrid_mystudents.RowCount - 1
        '    Dim supercombination As String = serverinitialpath & "\" & dgrid_mystudents.Rows(i).Cells(6).Value.ToString

        '    For Each item As String In My.Computer.FileSystem.GetDirectories(supercombination)
        '        icons.Images.Add(GetShellIcon(item))
        '        listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
        '    Next
        'Next

    End Sub

    Private Sub cbostime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostime.SelectedIndexChanged

        If Directory.Exists(serverinitialpath) Then
            txtsearchbox.ReadOnly = False
            txtsearchbox.Text = ""
            selectedsubject = cbosubject.Text
            selectedday = cbosday.Text
            selectedtime = cbostime.Text
            btn_deletestudents.Enabled = True
            btn_deletesubject.Enabled = True

            querystudents()
            dgrid_mystudents.DataSource = dt
            dgrid_mystudents.Columns(0).HeaderText = "Account ID"
            dgrid_mystudents.Columns(1).HeaderText = "Firstname"
            dgrid_mystudents.Columns(2).HeaderText = "Middlename"
            dgrid_mystudents.Columns(3).HeaderText = "Lastname"
            dgrid_mystudents.Columns(4).HeaderText = "Department"
            dgrid_mystudents.Columns(5).HeaderText = "Year"
            dgrid_mystudents.Columns(6).HeaderText = "Fullname"
            dgrid_mystudents.Columns(6).Visible = False

            dgrid_mystudents.Columns(0).Width = "100"
            dgrid_mystudents.Columns(1).Width = "113"
            dgrid_mystudents.Columns(2).Width = "113"
            dgrid_mystudents.Columns(3).Width = "113"
            dgrid_mystudents.Columns(4).Width = "90"
            dgrid_mystudents.Columns(5).Width = "91"
            dgrid_mystudents.Sort(dgrid_mystudents.Columns("Lastname"), System.ComponentModel.ListSortDirection.Ascending)
            dgrid_mystudents.Sort(dgrid_mystudents.Columns("Fullname"), System.ComponentModel.ListSortDirection.Ascending)
            dgrid_mystudents.ForeColor = Color.Azure
            dgrid_mystudents.ClearSelection()

            listview.Items.Clear()

            For i As Integer = 0 To dgrid_mystudents.RowCount - 1
                Dim supercombination As String = serverinitialpath & "\" & dgrid_mystudents.Rows(i).Cells(6).Value.ToString

                For Each item As String In My.Computer.FileSystem.GetDirectories(supercombination)
                    icons.Images.Add(GetShellIcon(item))
                    listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
                Next
            Next
        Else
            cbostime.Items.Clear()
            listview.Items.Clear()
            dgrid_mystudents.DataSource = Nothing
            openconnection()
            Dim ds As New DataSet
            Dim sql As String
            sql = "select subject_time from instructor_subject where subject_name = '" & cbosubject.Text & "' and subject_day = '" & cbosday.Text & "' and instructor_id = '" & id & "'"
            sqlda = New MySqlDataAdapter(sql, con)
            sqlda.Fill(ds, "fms")
            For Each r As DataRow In ds.Tables(0).Rows
                cbostime.Items.Add(r("subject_time"))
            Next
            con.Close()
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
        End If

    End Sub

    Private Sub listview_KeyDown(sender As Object, e As KeyEventArgs) Handles listview.KeyDown
        If e.KeyCode = Keys.Enter Then
            opentheitem()
        End If
    End Sub

    Private Sub listview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview.SelectedIndexChanged

    End Sub

    Private Sub ovalpicture_Click(sender As Object, e As EventArgs) Handles ovalpicture.Click
        frmprofile.Close()
        frmprofile.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmsettings.Close()
        frmsettings.ShowInTaskbar = False
        frmsettings.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As Integer
        time = Val(time) + 1
        If time = 1 Then
            Timer1.Enabled = False
            Timer1.Stop()
            Timer1.Dispose()
            openconnection()
            cmd = New MySqlCommand("SELECT COUNT(client_initial_path) as Count FROM settings", con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                If reader("Count") = 0 Then
                    reader.Close()
                    MessageBox.Show("Setup the settings first before you start.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    frmsettings.ShowDialog()
                    Exit Sub
                End If
            End While
            reader.Close()
            Timer1.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        getsettingsfromdatabase()
    End Sub

    Private Sub dgrid_mystudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_mystudents.CellContentClick

    End Sub

    Private Sub btnstudents_Click(sender As Object, e As EventArgs) Handles btnstudents.Click
        frmstudents.Show()
        Me.Close()
    End Sub

    Private Sub btninstructors_Click(sender As Object, e As EventArgs) Handles btninstructors.Click
        frminstructors.Show()
        Me.Close()
    End Sub

    Private Sub btndirectories_Click(sender As Object, e As EventArgs) Handles btndirectories.Click
        frmdirectories.Show()
        Me.Close()
    End Sub

    Private Sub cbosearch_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbosearch.SelectedIndexChanged
        txtsearchbox.Text = ""
    End Sub
End Class