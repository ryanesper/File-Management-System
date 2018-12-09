Imports MySql.Data.MySqlClient

Public Class frminstructors

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

    Private Sub frminstructors_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        fullname.Text = firstname & " " & middlename & " " & lastname & " - " & account_type
        openconnection()

        queryallinstructors()
        dgrid_instructorsacount.DataSource = dt

        con.Close()
        cbosearch.Text = "Account ID"
        dgrid_instructorsacount.Columns("id").HeaderText = "Account ID"
        dgrid_instructorsacount.Columns("firstname").HeaderText = "Firstname"
        dgrid_instructorsacount.Columns("middlename").HeaderText = "Middlename"
        dgrid_instructorsacount.Columns("lastname").HeaderText = "Lastname"
        dgrid_instructorsacount.Columns("cpnumber").HeaderText = "Cellphone Number"
        dgrid_instructorsacount.Columns("address").HeaderText = "Address"
        dgrid_instructorsacount.Columns("email").HeaderText = "Email"
        dgrid_instructorsacount.Columns("account_type").HeaderText = "Account Type"
        dgrid_instructorsacount.Columns("dateregistered").HeaderText = "Date Registered"
        'dgrid_instructorsacount.Sort(dgrid_instructorsacount.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)

        dgrid_instructorsacount.Columns(0).Width = "100"
        dgrid_instructorsacount.Columns(1).Width = "140"
        dgrid_instructorsacount.Columns(2).Width = "140"
        dgrid_instructorsacount.Columns(3).Width = "140"
        dgrid_instructorsacount.Columns(7).Width = "150"
        dgrid_instructorsacount.Columns(8).Width = "150"
        dgrid_instructorsacount.Columns(9).Width = "200"
        dgrid_instructorsacount.Columns(11).Width = "137"
        dgrid_instructorsacount.Columns(12).Width = "150"

        dgrid_instructorsacount.Columns(4).Visible = False
        dgrid_instructorsacount.Columns(5).Visible = False
        dgrid_instructorsacount.Columns(6).Visible = False
        'dgrid_instructorsacount.Columns(7).Visible = False
        dgrid_instructorsacount.Columns(10).Visible = False
        ''dgrid_instructorsacount.Columns(8).Visible = False
        ''dgrid_instructorsacount.Columns(9).Visible = False
        ''dgrid_instructorsacount.Columns(10).Visible = False
        ''dgrid_instructorsacount.Columns(12).Visible = False
        dgrid_instructorsacount.ForeColor = Color.Azure
        dgrid_instructorssubjects.ForeColor = Color.Azure
        dgrid_instructorsstudents.ForeColor = Color.Azure
        dgrid_instructorsacount.ClearSelection()
        dgrid_instructorssubjects.ClearSelection()
        dgrid_instructorsstudents.ClearSelection()

        Dim totalinstructor As Integer = 0
        For a As Integer = 0 To dgrid_instructorsacount.RowCount - 1
            totalinstructor = totalinstructor + 1
        Next
        txttotalinstructor.Text = totalinstructor

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        
        frmexplorer.Close()
        frmprofile.Close()
        frmmain.Close()
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

    Private Sub btn_instructorregister_Click(sender As Object, e As EventArgs) Handles btn_instructorregister.Click
        frminstructorregistration.ShowInTaskbar = False
        frminstructorregistration.ShowDialog()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        confirm = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = vbYes Then
            openconnection()

            For i As Integer = Me.dgrid_instructorsacount.SelectedRows.Count - 1 To 0 Step -1
                cmddelete = "DELETE FROM `admin` WHERE id='" & Me.dgrid_instructorsacount.SelectedRows(i).Cells(0).Value.ToString() & "'"
                sqlda = New MySqlDataAdapter(cmddelete, con)
                ds = New DataSet()
                sqlda.Fill(ds)

                cmddelete2 = "DELETE FROM `instructor_subject` WHERE instructor_id='" & Me.dgrid_instructorsacount.SelectedRows(i).Cells(0).Value.ToString() & "'"
                sqlda = New MySqlDataAdapter(cmddelete2, con)
                ds = New DataSet()
                sqlda.Fill(ds)

                cmddelete3 = "DELETE FROM `student_subject` WHERE instructor_id='" & Me.dgrid_instructorsacount.SelectedRows(i).Cells(0).Value.ToString() & "'"
                sqlda = New MySqlDataAdapter(cmddelete3, con)
                ds = New DataSet()
                sqlda.Fill(ds)

                Dim killmyimage As String = serverinitialpath & "\images\" & Me.dgrid_instructorsacount.SelectedRows(i).Cells(10).Value.ToString()
                If System.IO.File.Exists(killmyimage) Then
                    My.Computer.FileSystem.DeleteFile(killmyimage, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                End If
                Me.dgrid_instructorsacount.Rows.Remove(Me.dgrid_instructorsacount.SelectedRows(i))

            Next

            MessageBox.Show("Deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnrefresh.PerformClick()
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmstudentsregistration.Show()
    End Sub

    Private Sub fullname_Click(sender As Object, e As EventArgs) Handles fullname.Click
        frmprofile.Close()
        frmprofile.Show()
    End Sub

    Private Sub dgrid_instructorsacount_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_instructorsacount.CellContentClick

        Dim totalinstructor As Integer = 0
        For a As Integer = 0 To dgrid_instructorsacount.RowCount - 1
            totalinstructor = totalinstructor + 1
        Next
        If totalinstructor > 0 Then
            openconnection()

            'MsgBox("'" & Me.dgrid_instructorsacount.SelectedRows(0).Cells(0).Value.ToString() & "'")

            cmdselect = "SELECT * FROM `instructor_subject` where instructor_id = '" & Me.dgrid_instructorsacount.SelectedRows(0).Cells(0).Value.ToString() & "'"
            sqlda = New MySqlDataAdapter(cmdselect, con)
            dt = New DataTable
            sqlda.Fill(dt)
            dgrid_instructorssubjects.DataSource = dt

            dgrid_instructorssubjects.Columns(1).Visible = False
            dgrid_instructorssubjects.Columns(0).HeaderText = "Subject ID"
            dgrid_instructorssubjects.Columns(2).HeaderText = "Name"
            dgrid_instructorssubjects.Columns(3).HeaderText = "Description"
            dgrid_instructorssubjects.Columns(4).HeaderText = "Time"
            dgrid_instructorssubjects.Columns(5).HeaderText = "Day"
            dgrid_instructorssubjects.Sort(dgrid_instructorssubjects.Columns("subject_name"), System.ComponentModel.ListSortDirection.Ascending)
            dgrid_instructorssubjects.ClearSelection()
            dgrid_instructorssubjects.Columns(0).Width = "95"
            dgrid_instructorssubjects.Columns(2).Width = "95"
            dgrid_instructorssubjects.Columns(3).Width = "230"
            dgrid_instructorssubjects.Columns(4).Width = "112"
            dgrid_instructorssubjects.Columns(5).Width = "90"

            Dim fname As String = Me.dgrid_instructorsacount.SelectedRows(0).Cells(1).Value.ToString()
            Dim mname As String = Me.dgrid_instructorsacount.SelectedRows(0).Cells(2).Value.ToString()
            Dim lname As String = Me.dgrid_instructorsacount.SelectedRows(0).Cells(3).Value.ToString()

            'dgrid_instructorsstudents.Rows.Clear()
            dgrid_instructorsstudents.DataSource = Nothing

            lblsubjects.Text = fname & " " & mname & " " & lname & "'s Subjects"
            lblstudents.Text = fname & " " & mname & " " & lname & "'s Students"

            cmd = New MySqlCommand("SELECT COUNT(DISTINCT subject_name) as nameCount FROM instructor_subject where instructor_id='" & Me.dgrid_instructorsacount.SelectedRows(0).Cells(0).Value.ToString() & "'", con)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                txtsubjects.Text = reader("nameCount")
            End While

            reader.Close()

            Dim totalschedule As Integer = 0
            For a As Integer = 0 To dgrid_instructorssubjects.RowCount - 1
                totalschedule = totalschedule + 1
            Next
            txtsched.Text = totalschedule
            txtstudents.Text = ""

            con.Close()
        End If

    End Sub

    Private Sub dgrid_instructorssubjects_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_instructorssubjects.CellContentClick
        openconnection()

        'MsgBox("'" & Me.dgrid_instructorsacount.SelectedRows(0).Cells(0).Value.ToString() & "'")

        Dim s_id As String = Me.dgrid_instructorssubjects.SelectedRows(0).Cells(0).Value.ToString()
        Dim s_name As String = Me.dgrid_instructorssubjects.SelectedRows(0).Cells(2).Value.ToString()
        Dim s_time As String = Me.dgrid_instructorssubjects.SelectedRows(0).Cells(4).Value.ToString()
        Dim s_day As String = Me.dgrid_instructorssubjects.SelectedRows(0).Cells(5).Value.ToString()

        'Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where subject_id = '" & s_id & "' and subject_name = '" & s_name & "' and time = '" & s_time & "' and day = '" & s_day & "'"

        cmdselect = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course from students_account inner join student_subject on students_account.account_id = student_subject.student_id where subject_id = '" & s_id & "' and subject_name = '" & s_name & "' and time = '" & s_time & "' and day = '" & s_day & "'"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
        dgrid_instructorsstudents.DataSource = dt

        dgrid_instructorsstudents.Columns(0).HeaderText = "Account ID"
        dgrid_instructorsstudents.Columns(1).HeaderText = "Firstname"
        dgrid_instructorsstudents.Columns(2).HeaderText = "Middlename"
        dgrid_instructorsstudents.Columns(3).HeaderText = "Lastname"
        dgrid_instructorsstudents.Columns(4).HeaderText = "Year"
        dgrid_instructorsstudents.Columns(5).HeaderText = "Course"
        dgrid_instructorsstudents.Sort(dgrid_instructorsstudents.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)
        dgrid_instructorsstudents.ClearSelection()
        dgrid_instructorsstudents.Columns(0).Width = "95"
        dgrid_instructorsstudents.Columns(1).Width = "115"
        dgrid_instructorsstudents.Columns(2).Width = "115"
        dgrid_instructorsstudents.Columns(3).Width = "115"
        dgrid_instructorsstudents.Columns(4).Width = "91"
        dgrid_instructorsstudents.Columns(5).Width = "91"

        Dim totalstudents As Integer = 0
        totalstudents = 0
        For a As Integer = 0 To dgrid_instructorsstudents.RowCount - 1
            totalstudents = totalstudents + 1
        Next
        txtstudents.Text = totalstudents

        con.Close()
    End Sub

    Private Sub dgrid_instructorsstudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_instructorsstudents.CellContentClick

    End Sub

    Private Sub txtsearchbox_TextChanged(sender As Object, e As EventArgs) Handles txtsearchbox.TextChanged

        If cbosearch.Text = "Account ID" Then
            searchid(txtsearchbox.Text)
        ElseIf cbosearch.Text = "Firstname" Then
            searchfname(txtsearchbox.Text)
        ElseIf cbosearch.Text = "Middlename" Then
            searchmname(txtsearchbox.Text)
        ElseIf cbosearch.Text = "Lastname" Then
            searchlname(txtsearchbox.Text)
        End If
        dgrid_instructorsstudents.DataSource = Nothing
        dgrid_instructorssubjects.DataSource = Nothing
        lblsubjects.Text = "Instructor's Subjects"
        lblstudents.Text = "Instructor's Students"
        txtsubjects.Text = ""
        txtsched.Text = ""
        txtstudents.Text = ""
        dgrid_instructorsacount.ClearSelection()

    End Sub

    Private Sub searchid(valuetosearch As String)

        'Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where lastname like '%" & valuetosearch & "%' and student_subject.subject_name = '" & cbosubject.Text & "' and student_subject.time = '" & cbostime.Text & "' and student_subject.day = '" & cbosday.Text & "'"
        Dim searchquery As String = "SELECT * FROM `admin` where id like '%" & valuetosearch & "%' and account_type = '" & "Instructor Admin" & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgrid_instructorsacount.DataSource = table
        dgrid_instructorsacount.Sort(dgrid_instructorsacount.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub searchfname(valuetosearch As String)

        'Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where lastname like '%" & valuetosearch & "%' and student_subject.subject_name = '" & cbosubject.Text & "' and student_subject.time = '" & cbostime.Text & "' and student_subject.day = '" & cbosday.Text & "'"
        Dim searchquery As String = "SELECT * FROM `admin` where firstname like '%" & valuetosearch & "%' and account_type = '" & "Instructor Admin" & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgrid_instructorsacount.DataSource = table
        dgrid_instructorsacount.Sort(dgrid_instructorsacount.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub searchmname(valuetosearch As String)

        'Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where lastname like '%" & valuetosearch & "%' and student_subject.subject_name = '" & cbosubject.Text & "' and student_subject.time = '" & cbostime.Text & "' and student_subject.day = '" & cbosday.Text & "'"
        Dim searchquery As String = "SELECT * FROM `admin` where middlename like '%" & valuetosearch & "%' and account_type = '" & "Instructor Admin" & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgrid_instructorsacount.DataSource = table
        dgrid_instructorsacount.Sort(dgrid_instructorsacount.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub searchlname(valuetosearch As String)

        'Dim searchquery As String = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course, students_account.fullname from students_account inner join student_subject on students_account.account_id = student_subject.student_id where lastname like '%" & valuetosearch & "%' and student_subject.subject_name = '" & cbosubject.Text & "' and student_subject.time = '" & cbostime.Text & "' and student_subject.day = '" & cbosday.Text & "'"
        Dim searchquery As String = "SELECT * FROM `admin` where lastname like '%" & valuetosearch & "%' and account_type = '" & "Instructor Admin" & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgrid_instructorsacount.DataSource = table
        dgrid_instructorsacount.Sort(dgrid_instructorsacount.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub cbosearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosearch.SelectedIndexChanged
        txtsearchbox.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmsettings.Close()
        frmsettings.ShowInTaskbar = False
        frmsettings.ShowDialog()
    End Sub

    Private Sub btnmysubject_Click(sender As Object, e As EventArgs) Handles btnmysubject.Click
        frmmain.Show()
        Me.Close()
    End Sub

    Private Sub btnstudents_Click(sender As Object, e As EventArgs) Handles btnstudents.Click
        frmstudents.Show()
        Me.Close()
    End Sub

    Private Sub btndirectories_Click(sender As Object, e As EventArgs) Handles btndirectories.Click
        frmdirectories.Show()
        Me.Close()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click

        openconnection()

        queryallinstructors()
        dgrid_instructorsacount.DataSource = dt

        con.Close()

        txtsearchbox.Text = ""
        dgrid_instructorsstudents.DataSource = Nothing
        dgrid_instructorssubjects.DataSource = Nothing
        lblsubjects.Text = "Instructor's Subjects"
        lblstudents.Text = "Instructor's Students"
        txtsubjects.Text = ""
        txtsched.Text = ""
        txtstudents.Text = ""
        'dgrid_instructorsacount.Sort(dgrid_instructorsacount.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)
        dgrid_instructorsacount.ClearSelection()

        Dim totalinstructor As Integer = 0
        For a As Integer = 0 To dgrid_instructorsacount.RowCount - 1
            totalinstructor = totalinstructor + 1
        Next
        txttotalinstructor.Text = totalinstructor

    End Sub
End Class