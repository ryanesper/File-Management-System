Imports MySql.Data.MySqlClient

Public Class frmprofile

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
    Private Sub frmprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        openconnection()
        Me.TransparencyKey = BackColor

        lblid.Text = id
        lblfullname.Text = firstname & " " & middlename & " " & lastname
        lblnumber.Text = number
        lbladdress.Text = address
        lblemail.Text = email
        lblaccounttype.Text = account_type

        cmdselect = "SELECT * FROM `instructor_subject` where instructor_id = '" & id & "'"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
        dgridsubjects.DataSource = dt

        dgridsubjects.Columns(1).Visible = False
        dgridsubjects.Columns(0).HeaderText = "Suject ID"
        dgridsubjects.Columns(2).HeaderText = "Name"
        dgridsubjects.Columns(3).HeaderText = "Description"
        dgridsubjects.Columns(4).HeaderText = "Time"
        dgridsubjects.Columns(5).HeaderText = "Day"

        dgridsubjects.Columns(3).Width = "250"
        dgridsubjects.Columns(4).Width = "150"

        dgridsubjects.Sort(dgridsubjects.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
        dgridsubjects.ClearSelection()

        cmd = New MySqlCommand("SELECT COUNT(DISTINCT subject_name) as nameCount FROM instructor_subject where instructor_id='" & id & "'", con)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While (reader.Read())
            txtsubjects.Text = reader("nameCount")
        End While

        reader.Close()

        Dim totalschedule As Integer = 0
        For a As Integer = 0 To dgridsubjects.RowCount - 1
            totalschedule = totalschedule + 1
        Next
        txtsched.Text = totalschedule

        con.Close()

        If System.IO.File.Exists(loadmypicture) Then
            Using fs As New System.IO.FileStream(loadmypicture, IO.FileMode.Open, IO.FileAccess.Read)
                mypicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
            End Using
        End If

    End Sub

    Private Sub btnbrowseapic_Click(sender As Object, e As EventArgs) Handles btnbrowseapic.Click
        OpenFileDialog1.Filter = "JPEG Files|*.jpg|GIF Files|*.gif|PNG Files|*.png|BitMap Files|*.bmp"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            getpictypeforprofpic = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Extension
            picfullname = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).FullName
            picname = id & My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Extension
            'picname = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Name
            'Label1.Text = picfullname
            'Label2.Text = getpictypeforprofpic

            Using fs As New System.IO.FileStream(picfullname, IO.FileMode.Open, IO.FileAccess.Read)
                mypicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
            End Using

        End If

        mypicture.BorderStyle = Drawing2D.DashStyle.Custom
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        btnedit.Visible = False
        btnchangepass.Visible = True
        btnupdate.Visible = True
        btncancel.Visible = True

        lblfullname.Visible = False
        lblnumber.Visible = False
        lbladdress.Visible = False
        lblemail.Visible = False

        txtfname.Visible = True
        txtmname.Visible = True
        txtlname.Visible = True
        txtnumber.Visible = True
        txtaddress.Visible = True
        txtemail.Visible = True

        txtfname.Text = firstname
        txtmname.Text = middlename
        txtlname.Text = lastname
        txtnumber.Text = number
        txtaddress.Text = address
        txtemail.Text = email

        Label10.Visible = True
        Label11.Visible = True
        Label8.Text = "Firstname"
        btnbrowseapic.Visible = True
        mypicture.BorderStyle = Drawing2D.DashStyle.Solid
    End Sub

    Private Sub btnchangepass_Click(sender As Object, e As EventArgs) Handles btnchangepass.Click
        frmchangepassword.ShowInTaskbar = False
        frmchangepassword.ShowDialog()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        frmupdateconfirmation.ShowInTaskbar = False
        frmupdateconfirmation.ShowDialog()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        btnedit.Visible = True
        btnchangepass.Visible = False
        btnupdate.Visible = False
        btncancel.Visible = False

        lblfullname.Visible = True
        lblnumber.Visible = True
        lbladdress.Visible = True
        lblemail.Visible = True

        txtfname.Visible = False
        txtmname.Visible = False
        txtlname.Visible = False
        txtnumber.Visible = False
        txtaddress.Visible = False
        txtemail.Visible = False

        lblid.Text = id
        lblfullname.Text = firstname & " " & middlename & " " & lastname
        lblnumber.Text = number
        lbladdress.Text = address
        lblemail.Text = email
        lblaccounttype.Text = account_type

        Label10.Visible = False
        Label11.Visible = False
        Label8.Text = "Fullname"
        mypicture.BorderStyle = Drawing2D.DashStyle.Custom
        btnbrowseapic.Visible = False
        If System.IO.File.Exists(loadmypicture) Then
            Using fs As New System.IO.FileStream(loadmypicture, IO.FileMode.Open, IO.FileAccess.Read)
                mypicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
            End Using
        End If
    End Sub

    Private Sub btnrefresh1_Click(sender As Object, e As EventArgs) Handles btnrefresh1.Click
        openconnection()

        cmdselect = "SELECT * FROM `instructor_subject` where instructor_id = '" & id & "'"
        sqlda = New MySqlDataAdapter(cmdselect, con)
        dt = New DataTable
        sqlda.Fill(dt)
        dgridsubjects.DataSource = dt

        dgridsubjects.Columns(1).Visible = False

        dgridsubjects.Columns(0).HeaderText = "Suject ID"
        dgridsubjects.Columns(2).HeaderText = "Name"
        dgridsubjects.Columns(3).HeaderText = "Description"
        dgridsubjects.Columns(4).HeaderText = "Time"
        dgridsubjects.Columns(5).HeaderText = "Day"

        dgridsubjects.Columns(3).Width = "250"
        dgridsubjects.Columns(4).Width = "150"

        dgridsubjects.Sort(dgridsubjects.Columns(2), System.ComponentModel.ListSortDirection.Ascending)

        cmd = New MySqlCommand("SELECT COUNT(DISTINCT subject_name) as nameCount FROM instructor_subject where instructor_id='" & id & "'", con)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While (reader.Read())
            txtsubjects.Text = reader("nameCount")
        End While

        reader.Close()

        Dim totalschedule As Integer = 0
        For a As Integer = 0 To dgridsubjects.RowCount - 1
            totalschedule = totalschedule + 1
        Next
        txtsched.Text = totalschedule

        con.Close()

        dgridsubjects.ClearSelection()
        txtstudents.Text = ""
        dgridstudents.DataSource = Nothing
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub dgridsubjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridsubjects.CellContentClick

        Dim totalschedule As Integer = 0
        For a As Integer = 0 To dgridsubjects.RowCount - 1
            totalschedule = totalschedule + 1
        Next
        If totalschedule > 0 Then
            openconnection()

            Dim s_id As String = Me.dgridsubjects.SelectedRows(0).Cells(0).Value.ToString()
            Dim s_name As String = Me.dgridsubjects.SelectedRows(0).Cells(2).Value.ToString()
            Dim s_time As String = Me.dgridsubjects.SelectedRows(0).Cells(4).Value.ToString()
            Dim s_day As String = Me.dgridsubjects.SelectedRows(0).Cells(5).Value.ToString()

            cmdselect = "select students_account.account_id, students_account.firstname, students_account.middlename, students_account.lastname, students_account.year, students_account.course from students_account inner join student_subject on students_account.account_id = student_subject.student_id where subject_id = '" & s_id & "' and subject_name = '" & s_name & "' and time = '" & s_time & "' and day = '" & s_day & "'"
            sqlda = New MySqlDataAdapter(cmdselect, con)
            dt = New DataTable
            sqlda.Fill(dt)
            dgridstudents.DataSource = dt

            dgridstudents.Columns(0).HeaderText = "Account ID"
            dgridstudents.Columns(1).HeaderText = "Firstname"
            dgridstudents.Columns(2).HeaderText = "Middlename"
            dgridstudents.Columns(3).HeaderText = "Lastname"
            dgridstudents.Columns(4).HeaderText = "Year"
            dgridstudents.Columns(5).HeaderText = "Course"
            dgridstudents.Sort(dgridstudents.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)

            dgridstudents.Columns(0).Width = "95"
            dgridstudents.Columns(1).Width = "115"
            dgridstudents.Columns(2).Width = "115"
            dgridstudents.Columns(3).Width = "115"
            dgridstudents.Columns(4).Width = "91"
            dgridstudents.Columns(5).Width = "91"

            Dim totalstudents As Integer = 0
            totalstudents = 0
            For a As Integer = 0 To dgridstudents.RowCount - 1
                totalstudents = totalstudents + 1
            Next
            txtstudents.Text = totalstudents

            con.Close()
        End If

    End Sub

    Private Sub btnadd1_Click(sender As Object, e As EventArgs) Handles btnadd1.Click
        frmaddsubjects.ShowDialog()
    End Sub

    Private Sub btndelete1_Click(sender As Object, e As EventArgs) Handles btndelete1.Click
        confirm = MsgBox("Are you Sure? ", vbYesNo, "Delete Confirmation")
        If confirm = vbYes Then
            openconnection()
            For i As Integer = Me.dgridsubjects.SelectedRows.Count - 1 To 0 Step -1

                MsgBox("Goodbye: " & dgridsubjects.SelectedRows(i).Cells(0).Value.ToString())

                cmddelete = "DELETE FROM `student_subject` where subject_name='" & Me.dgridsubjects.SelectedRows(i).Cells(2).Value.ToString() & "' and time = '" & Me.dgridsubjects.SelectedRows(i).Cells(4).Value.ToString() & "' and day = '" & Me.dgridsubjects.SelectedRows(i).Cells(5).Value.ToString() & "'"
                sqlda = New MySqlDataAdapter(cmddelete, con)
                ds = New DataSet()
                sqlda.Fill(ds)

                cmddelete = "DELETE FROM `instructor_subject` where subject_name='" & Me.dgridsubjects.SelectedRows(i).Cells(2).Value.ToString() & "' and subject_time = '" & Me.dgridsubjects.SelectedRows(i).Cells(4).Value.ToString() & "' and subject_day = '" & Me.dgridsubjects.SelectedRows(i).Cells(5).Value.ToString() & "'"
                sqlda = New MySqlDataAdapter(cmddelete, con)
                ds = New DataSet()
                sqlda.Fill(ds)

                Me.dgridsubjects.Rows.Remove(Me.dgridsubjects.SelectedRows(i))
            Next

            MessageBox.Show("Subject(s) has been successfully deleted.", "informed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'frmmain.cbosday.Items.Clear()
            'frmmain.cbostime.Items.Clear()
            'frmmain.cbosubject.Items.Clear()
            'frmmain.cbosday.Text = ""
            'frmmain.cbostime.Text = ""
            'frmmain.cbosubject.Text = ""
            'frmmain.txtdescription.Text = ""
            'frmmain.cbosday.Enabled = False
            'frmmain.cbostime.Enabled = False
            'frmmain.btn_deletestudents.Enabled = False
            'frmmain.btn_deletesubject.Enabled = False
            'frmmain.txtsearchbox.ReadOnly = True
            'frmmain.dgrid_mystudents.DataSource = dt
            'frmmain.listview.Items.Clear()

            'loadsubjectincombobox()
        End If
    End Sub
End Class