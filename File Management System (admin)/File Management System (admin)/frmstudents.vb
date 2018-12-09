Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmstudents
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

    Private Sub btn_mysubjects_Click(sender As Object, e As EventArgs)
        frmmain.Show()
        Me.Close()
    End Sub

    Private Sub btn_instructors_Click(sender As Object, e As EventArgs)
        frminstructors.Show()
        Me.Close()
    End Sub

    Private Sub btn_studentsfile_Click(sender As Object, e As EventArgs)
        frmdirectories.Show()
        Me.Close()
    End Sub

    Private Sub frmstudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        fullname.Text = firstname & " " & middlename & " " & lastname & " - " & account_type

        openconnection()
        studentsaccountquery()
        dgrid_studentsacount.DataSource = dt
        con.Close()

        dgrid_studentsacount.Columns(4).Visible = False
        dgrid_studentsacount.Columns(5).Visible = False
        dgrid_studentsacount.Columns(6).Visible = False
        dgrid_studentsacount.Columns(9).Visible = False
        dgrid_studentsacount.Columns(10).Visible = False
        dgrid_studentsacount.Columns(11).Visible = False
        dgrid_studentsacount.Columns(12).Visible = False
        dgrid_studentsacount.Columns(13).Visible = False
        dgrid_studentsacount.Columns(14).Visible = False

        dgrid_studentsacount.Columns(0).Width = "109"
        dgrid_studentsacount.Columns(1).Width = "122"
        dgrid_studentsacount.Columns(2).Width = "122"
        dgrid_studentsacount.Columns(3).Width = "122"
        dgrid_studentsacount.Columns(7).Width = "115"
        dgrid_studentsacount.Columns(8).Width = "108"

        dgrid_studentsacount.Columns("account_id").HeaderText = "Account ID"
        dgrid_studentsacount.Columns("firstname").HeaderText = "Firstname"
        dgrid_studentsacount.Columns("middlename").HeaderText = "Middlename"
        dgrid_studentsacount.Columns("lastname").HeaderText = "Lastname"
        dgrid_studentsacount.Columns("year").HeaderText = "Year"
        dgrid_studentsacount.Columns("course").HeaderText = "Department"
        dgrid_studentsacount.ForeColor = Color.Azure
        dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("Year"), System.ComponentModel.ListSortDirection.Ascending)
        dgrid_studentsacount.ClearSelection()

        lblid.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lblfname.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lblmname.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lbllname.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lblgender.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lbldepartment.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lblyear.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lblnumber.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lbladdress.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lblemail.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")
        lbldate.BackColor = System.Drawing.ColorTranslator.FromHtml("#e2e2e2")

        Dim totalstudents As Integer = 0
        For a As Integer = 0 To dgrid_studentsacount.RowCount - 1
            totalstudents = totalstudents + 1
        Next
        txttotalstudents.Text = totalstudents

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If Directory.Exists(serverinitialpath) Then
            Dim counter As Integer
            For b As Integer = 0 To dgrid_studentsacount.SelectedRows.Count - 1
                counter = counter + 1
            Next
            If counter > 0 Then
                confirm = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If confirm = vbOK Then
                    For i As Integer = Me.dgrid_studentsacount.SelectedRows.Count - 1 To 0 Step -1
                        If Directory.Exists(serverinitialpath & "\" & dgrid_studentsacount.SelectedRows(i).Cells(4).Value.ToString) Then
                            cmddelete = "DELETE FROM `students_account` WHERE account_id='" & Me.dgrid_studentsacount.SelectedRows(i).Cells(0).Value.ToString() & "'"
                            sqlda = New MySqlDataAdapter(cmddelete, con)
                            ds = New DataSet()
                            sqlda.Fill(ds)

                            cmddelete = "DELETE FROM `student_subject` WHERE student_id='" & Me.dgrid_studentsacount.SelectedRows(i).Cells(0).Value.ToString() & "'"
                            sqlda = New MySqlDataAdapter(cmddelete, con)
                            ds = New DataSet()
                            sqlda.Fill(ds)

                            If lblid.Text = dgrid_studentsacount.SelectedRows(i).Cells(0).Value.ToString() Then
                                mypicture.BackgroundImage = Nothing
                                lblid.Text = ""
                                lblfname.Text = ""
                                lblmname.Text = ""
                                lbllname.Text = ""
                                lblgender.Text = ""
                                lbldepartment.Text = ""
                                lblyear.Text = ""
                                lblnumber.Text = ""
                                lbladdress.Text = ""
                                lblemail.Text = ""
                                lbldate.Text = ""
                            End If

                            getsettingsfromdatabase()

                            Dim killmyimage As String = serverinitialpath & "\images\" & dgrid_studentsacount.SelectedRows(i).Cells(6).Value.ToString
                            Dim killfolder As String = serverinitialpath & "\" & dgrid_studentsacount.SelectedRows(i).Cells(4).Value.ToString
                            If File.Exists(killmyimage) Then
                                My.Computer.FileSystem.DeleteFile(killmyimage, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                            End If
                            If Directory.Exists(killfolder) Then
                                My.Computer.FileSystem.DeleteDirectory(killfolder, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                            End If

                            Me.dgrid_studentsacount.Rows.Remove(Me.dgrid_studentsacount.SelectedRows(i))
                        Else
                            MessageBox.Show("Account ID '" & dgrid_studentsacount.SelectedRows(i).Cells(4).Value.ToString & "' cannot be deleted, because its directory: " & dgrid_studentsacount.SelectedRows(i).Cells(4).Value.ToString & "' cannot be located. Try to refresh.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            If counter = 1 Then
                                Exit Sub
                            End If
                        End If
                    Next
                    dgrid_studentsacount.ClearSelection()
                    MessageBox.Show("Deleted successfully.", "informed", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim totalstudents As Integer = 0
                    For a As Integer = 0 To dgrid_studentsacount.RowCount - 1
                        totalstudents = totalstudents + 1
                    Next
                    txttotalstudents.Text = totalstudents

                End If
            End If
        Else
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
        End If

    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

        frmexplorer.Close()
        frmprofile.Close()
        frminstructors.Close()
        frmprofile.Close()
        frmsettings.Close()
        frmmain.Close()
        frmdirectories.Close()

        frmlogin.txtusername.Focus()
        frmlogin.Show()
        Me.Close()

    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub filteryear0(valuetosearch As String)

        Dim searchquery As String = "select * from students_account where year like '%" & valuetosearch & "%'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgrid_studentsacount.DataSource = table

    End Sub
    Private Sub filteryear1(valuetosearch As String)

        Dim searchquery As String = "select * from students_account where year like '%" & valuetosearch & "%' and course = '" & cbocourse.Text & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgrid_studentsacount.DataSource = table

    End Sub


    Private Sub filtercourse0(valuetosearch As String)

        Dim searchquery As String = "select * from students_account where course like '%" & valuetosearch & "%'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgrid_studentsacount.DataSource = table

    End Sub
    Private Sub filtercourse1(valuetosearch As String)

        Dim searchquery As String = "select * from students_account where course like '%" & valuetosearch & "%' and year = '" & cboyear.Text & "'"
        Dim command As New MySqlCommand(searchquery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        dgrid_studentsacount.DataSource = table

    End Sub

    Private Sub btn_students_Click(sender As Object, e As EventArgs) Handles btn_students.Click

        openconnection()

        studentsaccountquery()
        dgrid_studentsacount.DataSource = dt

        con.Close()

        mypicture.BackgroundImage = Nothing
        lblid.Text = ""
        lblfname.Text = ""
        lblmname.Text = ""
        lbllname.Text = ""
        lblgender.Text = ""
        lbldepartment.Text = ""
        lblyear.Text = ""
        lblnumber.Text = ""
        lbladdress.Text = ""
        lblemail.Text = ""
        lbldate.Text = ""
        dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("Year"), System.ComponentModel.ListSortDirection.Ascending)
        'lblusername.Text = "Username"
        'lblpassword.Text = "Password"
        Dim totalstudents As Integer = 0
        For a As Integer = 0 To dgrid_studentsacount.RowCount - 1
            totalstudents = totalstudents + 1
        Next
        txttotalstudents.Text = totalstudents
        dgrid_studentsacount.ClearSelection()
        cbocourse.Text = ""
        cboyear.Text = ""

    End Sub

    Private Sub fullname_Click(sender As Object, e As EventArgs) Handles fullname.Click
        frmprofile.Close()
        frmprofile.Show()
    End Sub

    Private Sub dgrid_studentsacount_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgrid_studentsacount.CellContentClick

        If Directory.Exists(serverinitialpath) Then
            For Each dgv As DataGridViewRow In dgrid_studentsacount.Rows
                If dgv.Selected Then
                    lblid.Text = dgv.Cells(0).Value.ToString
                    lblfname.Text = dgv.Cells(1).Value.ToString
                    lblmname.Text = dgv.Cells(2).Value.ToString
                    lbllname.Text = dgv.Cells(3).Value.ToString
                    lblgender.Text = dgv.Cells(5).Value.ToString
                    lbldepartment.Text = dgv.Cells(8).Value.ToString
                    lblyear.Text = dgv.Cells(7).Value.ToString
                    lblnumber.Text = dgv.Cells(11).Value.ToString
                    lbladdress.Text = dgv.Cells(12).Value.ToString
                    lblemail.Text = dgv.Cells(13).Value.ToString
                    lbldate.Text = dgv.Cells(14).Value.ToString
                    getsettingsfromdatabase()
                    mypicture.BackgroundImage = Nothing
                    Dim studpic As String = serverinitialpath & "\images\" & dgv.Cells(0).Value.ToString & ".jpg"
                    If File.Exists(studpic) Then
                        Using fs As New System.IO.FileStream(studpic, IO.FileMode.Open, IO.FileAccess.Read)
                            mypicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
                        End Using
                    End If
                End If
            Next
        Else
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
        End If

    End Sub

    Private Sub btn_studentregistration_Click(sender As Object, e As EventArgs) Handles btn_studentregistration.Click
        frmstudentsregistration.ShowInTaskbar = False
        frmstudentsregistration.ShowDialog()
    End Sub

    Private Sub cbocourse_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbocourse.SelectedIndexChanged

        mypicture.BackgroundImage = Nothing
        lblid.Text = ""
        lblfname.Text = ""
        lblmname.Text = ""
        lbllname.Text = ""
        lblgender.Text = ""
        lbldepartment.Text = ""
        lblyear.Text = ""
        lblnumber.Text = ""
        lbladdress.Text = ""
        lblemail.Text = ""
        lbldate.Text = ""
        If cboyear.Text = "" Then
            filtercourse0(cbocourse.Text)
        Else
            filtercourse1(cbocourse.Text)
        End If
        For Each dgv As DataGridViewRow In dgrid_studentsacount.Rows
            If dgv.Selected Then
                lblid.Text = dgv.Cells(0).Value.ToString
                lblfname.Text = dgv.Cells(1).Value.ToString
                lblmname.Text = dgv.Cells(2).Value.ToString
                lbllname.Text = dgv.Cells(3).Value.ToString
                lblgender.Text = dgv.Cells(5).Value.ToString
                lbldepartment.Text = dgv.Cells(8).Value.ToString
                lblyear.Text = dgv.Cells(7).Value.ToString
                lblnumber.Text = dgv.Cells(11).Value.ToString
                lbladdress.Text = dgv.Cells(12).Value.ToString
                lblemail.Text = dgv.Cells(13).Value.ToString
                lbldate.Text = dgv.Cells(14).Value.ToString

                getsettingsfromdatabase()
                Dim studpic As String = serverinitialpath & "\images\" & dgv.Cells(0).Value.ToString & ".jpg"
                If File.Exists(studpic) Then
                    mypicture.BackgroundImage = Image.FromFile(studpic)
                End If
            End If
        Next
        mypicture.BackgroundImage = Nothing
        lblid.Text = ""
        lblfname.Text = ""
        lblmname.Text = ""
        lbllname.Text = ""
        lblgender.Text = ""
        lbldepartment.Text = ""
        lblyear.Text = ""
        lblnumber.Text = ""
        lbladdress.Text = ""
        lblemail.Text = ""
        lbldate.Text = ""
        Dim totalstudents As Integer = 0
        For a As Integer = 0 To dgrid_studentsacount.RowCount - 1
            totalstudents = totalstudents + 1
        Next
        txttotalstudents.Text = totalstudents

        If cbocourse.Text = "" And cboyear.Text <> "" Then
            dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("course"), System.ComponentModel.ListSortDirection.Ascending)
        ElseIf cbocourse.Text <> "" And cboyear.Text = "" Then
            dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("year"), System.ComponentModel.ListSortDirection.Ascending)
        ElseIf cbocourse.Text <> "" And cboyear.Text <> "" Then
            dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)
        Else
            dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("year"), System.ComponentModel.ListSortDirection.Ascending)
        End If
        dgrid_studentsacount.ClearSelection()

    End Sub

    Private Sub cboyear_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cboyear.SelectedIndexChanged

        mypicture.BackgroundImage = Nothing
        lblid.Text = ""
        lblfname.Text = ""
        lblmname.Text = ""
        lbllname.Text = ""
        lblgender.Text = ""
        lbldepartment.Text = ""
        lblyear.Text = ""
        lblnumber.Text = ""
        lbladdress.Text = ""
        lblemail.Text = ""
        lbldate.Text = ""

        If cbocourse.Text = "" Then
            filteryear0(cboyear.Text)
        Else
            filteryear1(cboyear.Text)
        End If

        For Each dgv As DataGridViewRow In dgrid_studentsacount.Rows

            If dgv.Selected Then
                lblid.Text = dgv.Cells(0).Value.ToString
                lblfname.Text = dgv.Cells(1).Value.ToString
                lblmname.Text = dgv.Cells(2).Value.ToString
                lbllname.Text = dgv.Cells(3).Value.ToString
                lblgender.Text = dgv.Cells(5).Value.ToString
                lbldepartment.Text = dgv.Cells(8).Value.ToString
                lblyear.Text = dgv.Cells(7).Value.ToString
                lblnumber.Text = dgv.Cells(11).Value.ToString
                lbladdress.Text = dgv.Cells(12).Value.ToString
                lblemail.Text = dgv.Cells(13).Value.ToString
                lbldate.Text = dgv.Cells(14).Value.ToString

                getsettingsfromdatabase()
                Dim studpic As String = serverinitialpath & "\images\" & dgv.Cells(0).Value.ToString & ".jpg"
                If File.Exists(studpic) Then
                    mypicture.BackgroundImage = Image.FromFile(studpic)
                End If
                'If TextBox1.Text = password Then
                '    lblusername.Text = dgv.Cells(9).Value.ToString
                '    lblpassword.Text = dgv.Cells(10).Value.ToString
                'ElseIf TextBox1.Text = "" Then
                '    lblusername.Text = "Username"
                '    lblpassword.Text = "Password"
                'Else
                '    lblusername.Text = "Username"
                '    lblpassword.Text = "Password"
                'End If
            End If

        Next
        mypicture.BackgroundImage = Nothing
        lblid.Text = ""
        lblfname.Text = ""
        lblmname.Text = ""
        lbllname.Text = ""
        lblgender.Text = ""
        lbldepartment.Text = ""
        lblyear.Text = ""
        lblnumber.Text = ""
        lbladdress.Text = ""
        lblemail.Text = ""
        lbldate.Text = ""
        Dim totalstudents As Integer = 0
        For a As Integer = 0 To dgrid_studentsacount.RowCount - 1
            totalstudents = totalstudents + 1
        Next
        txttotalstudents.Text = totalstudents
        If cbocourse.Text <> "" And cboyear.Text = "" Then
            dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("year"), System.ComponentModel.ListSortDirection.Ascending)
        ElseIf cbocourse.Text = "" And cboyear.Text <> "" Then
            dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("course"), System.ComponentModel.ListSortDirection.Ascending)
        ElseIf cbocourse.Text <> "" And cboyear.Text <> "" Then
            dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("lastname"), System.ComponentModel.ListSortDirection.Ascending)
        Else
            dgrid_studentsacount.Sort(dgrid_studentsacount.Columns("year"), System.ComponentModel.ListSortDirection.Ascending)
        End If
        dgrid_studentsacount.ClearSelection()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmsettings.Close()
        frmsettings.ShowInTaskbar = False
        frmsettings.ShowDialog()
    End Sub

    Private Sub btnmysubject_Click(sender As Object, e As EventArgs) Handles btnmysubject.Click
        frmmain.Show()
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
End Class