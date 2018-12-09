Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmaddsubjects

    Dim finalizeid As String
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


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        'txtname.Text = ""
        cbomysubjects.Text = ""
        txtdescription.Text = ""
        txth1.Text = ""
        txth2.Text = ""
        txtm1.Text = ""
        txtm2.Text = ""
        cboap1.Text = ""
        cboap2.Text = ""
        cbofirstday.Text = ""
        cbosecondday.Text = ""
        Me.Hide()
    End Sub

    Private Sub subjectidgenerator()

        openconnection()
        Dim idinitial As String = "IS"
        Dim counter As Integer = 1
        Dim idnumber As String = "000"
        finalizeid = idinitial & idnumber & counter.ToString
        Dim isidexists As Boolean = True

        dr.Close()
        cmd.CommandText = "select subject_id from instructor_subject where subject_id = '" & finalizeid & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows = False Then
            dr.Close()
            'cmd = New MySqlCommand("INSERT INTO `id`(`id`) VALUES ('" & finalizeid & "')", con)
            'cmd.ExecuteNonQuery()
            finalizeid = idinitial & idnumber & counter.ToString
        Else
            Do Until isidexists = False
                dr.Close()
                counter += 1
                If counter > 9 And counter < 100 Then
                    idnumber = "00"
                ElseIf counter > 99 And counter < 1000 Then
                    idnumber = "0"
                ElseIf counter > 999 Then
                    idnumber = ""
                End If
                finalizeid = idinitial & idnumber & counter.ToString
                cmd.CommandText = "select subject_id from instructor_subject where subject_id = '" & finalizeid & "'"
                dr = cmd.ExecuteReader
                If dr.HasRows = True Then
                    isidexists = True
                Else
                    isidexists = False
                End If
            Loop
            dr.Close()
            'cmd = New MySqlCommand("INSERT INTO `id`(`id`) VALUES ('" & finalizeid & "')", con)
            'cmd.ExecuteNonQuery()
        End If

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If cbomysubjects.Text = "" Or txtdescription.Text = "" Or txth1.Text = "" Or txth2.Text = "" Or txtm1.Text = "" Or txtm2.Text = "" Or cboap1.Text = "" Or cboap2.Text = "" Or cbofirstday.Text = "" Then
            MessageBox.Show("Some field/s are empty", "informed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            openconnection()

            If cbofirstday.Text = "Monday" Or cbofirstday.Text = "Tuesday" Or cbofirstday.Text = "Wednesday" Or cbofirstday.Text = "Thursday" Or cbofirstday.Text = "Friday" Or cbofirstday.Text = "Saturday" Or
               cbosecondday.Text = "Monday" Or cbosecondday.Text = "Monday" Or cbosecondday.Text = "Wednesday" Or cbosecondday.Text = "Thurday" Or cbosecondday.Text = "Friday" Or cbosecondday.Text = "Saturday" Then
                txtdescription.Text = StrConv(txtdescription.Text, VbStrConv.ProperCase)
                Dim subjecttime As String
                subjecttime = txth1.Text & ":" & txtm1.Text & " " & cboap1.Text & " - " & txth2.Text & ":" & txtm2.Text & " " & cboap2.Text
                Dim subjectday As String
                If cbothirdday.Text <> "" Then
                    subjectday = Microsoft.VisualBasic.Left(cbofirstday.Text, 3) & " - " & Microsoft.VisualBasic.Left(cbosecondday.Text, 3) & " - " & Microsoft.VisualBasic.Left(cbothirdday.Text, 3)
                ElseIf cbosecondday.Text <> "" Then
                    subjectday = Microsoft.VisualBasic.Left(cbofirstday.Text, 3) & " - " & Microsoft.VisualBasic.Left(cbosecondday.Text, 3)
                Else
                    subjectday = cbofirstday.Text
                End If

                subjectidgenerator()
                cmd = New MySqlCommand("INSERT INTO `instructor_subject`(`subject_id`, `instructor_id`, `subject_name`, `subject_description`, `subject_time`, `subject_day`) VALUES ('" & finalizeid & "','" & id & "','" & cbomysubjects.Text & "','" & txtdescription.Text & "','" & subjecttime & "','" & subjectday & "')", con)
                cmd.ExecuteNonQuery()

                'Dim folder As String = System.IO.Path.Combine(path, txtusername.Text)

                ''If Not Directory.Exists(folder) Then
                'Directory.CreateDirectory(folder)
                ''Else
                ''    MessageBox.Show("folder already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ''End If
                cbomysubjects.Focus()
                MessageBox.Show("Subject successfully added.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Invalid day/s", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

            Dim ds As New DataSet
            Dim sql As String

            'openconnection()

            sql = "SELECT distinct subject_name FROM `instructor_subject` where instructor_id = '" & id & "'"
            sqlda = New MySqlDataAdapter(sql, con)

            sqlda.Fill(ds, "fms")

            'con.Close()

            'lblname.Text = user
            'lblname.Text = ds.Tables("fms").Rows(user).Item(8)

            frmmain.cbosubject.Items.Clear()
            cbomysubjects.Items.Clear()
            For Each r As DataRow In ds.Tables(0).Rows
                frmmain.cbosubject.Items.Add(r("subject_name"))
                cbomysubjects.Items.Add(r("subject_name"))
            Next

            con.Close()

            frmmain.cbosubject.Text = subjectgrabber
            frmmain.cbosday.Text = daygrabber
            frmmain.cbostime.Text = timegrabber
            cbomysubjects.Text = ""
            txtdescription.Text = ""
            txth1.Text = ""
            txth2.Text = ""
            txtm1.Text = ""
            txtm2.Text = ""
            cboap1.Text = "am"
            cboap2.Text = "am"
            cbofirstday.Text = ""
            cbosecondday.Text = ""
        End If

    End Sub

    Private Sub txtm2_Click(sender As Object, e As EventArgs) Handles txtm2.Click
        txtm2.Text = ""
    End Sub

    Private Sub txth2_Click(sender As Object, e As EventArgs) Handles txth2.Click
        txth2.Text = ""
    End Sub

    Private Sub txtm1_Click(sender As Object, e As EventArgs) Handles txtm1.Click
        txtm1.Text = ""
    End Sub

    Private Sub txth1_Click(sender As Object, e As EventArgs) Handles txth1.Click
        txth1.Text = ""
    End Sub

    Private Sub cbofirstday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofirstday.SelectedIndexChanged
        If cbofirstday.Text = "" Then
            cbosecondday.Text = ""
            cbosecondday.Enabled = False
        Else
            cbosecondday.Enabled = True
        End If
    End Sub

    'Private Sub cbomysubjects_Click(sender As Object, e As EventArgs) Handles cbomysubjects.Click
    '    cbomysubjects.Text = ""
    '    txtdescription.Text = ""
    'End Sub

    Private Sub cbomysubjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomysubjects.SelectedIndexChanged

        openconnection()
        cmd.CommandText = "select subject_description from instructor_subject where subject_name = '" & cbomysubjects.Text & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            txtdescription.Text = dr("subject_description").ToString()
            dr.Close()
        Else
            MessageBox.Show("account doesn't exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()

    End Sub

    Private Sub cbomysubjects_TextChanged(sender As Object, e As EventArgs) Handles cbomysubjects.TextChanged
        If cbomysubjects.Text = "" Then
            txtdescription.Text = ""
        End If
    End Sub

    Private Sub txth1_TextChanged(sender As Object, e As EventArgs) Handles txth1.TextChanged
        If txth1.TextLength = 2 Then
            Try
                If txth1.Text > 12 Then
                    MessageBox.Show("Invalid hour(s)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txth1.Text = ""
                Else
                    txtm1.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Must only contain a number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txth1.Text = ""
            End Try
        End If
    End Sub

    Private Sub txtm1_TextChanged(sender As Object, e As EventArgs) Handles txtm1.TextChanged
        If txtm1.TextLength = 2 Then
            Try
                If txtm1.Text > 60 Then
                    MessageBox.Show("Invalid minute(s)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtm1.Text = ""
                Else
                    cboap2.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Must only contain a number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtm1.Text = ""
            End Try
        End If
    End Sub

    Private Sub cboap2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboap2.SelectedIndexChanged
        txth2.Focus()
    End Sub

    Private Sub txth2_TextChanged(sender As Object, e As EventArgs) Handles txth2.TextChanged
        If txth2.TextLength = 2 Then
            Try
                If txth2.Text > 12 Then
                    MessageBox.Show("Invalid hour(s)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txth2.Text = ""
                Else
                    txtm2.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Must only contain a number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txth2.Text = ""
            End Try
        End If
    End Sub

    Private Sub txtm2_TextChanged(sender As Object, e As EventArgs) Handles txtm2.TextChanged
        If txtm2.TextLength = 2 Then
            Try
                If txtm2.Text > 60 Then
                    MessageBox.Show("Invalid minute(s)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtm2.Text = ""
                Else
                    cboap1.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Must only contain a number.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtm2.Text = ""
            End Try
        End If
    End Sub

    Private Sub frmaddsubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboap1.Text = "am"
        cboap2.Text = "am"
    End Sub

    Private Sub cbosecondday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosecondday.SelectedIndexChanged
        If cbosecondday.Text = "" Then
            cbothirdday.Text = ""
            cbothirdday.Enabled = False
        Else
            cbothirdday.Enabled = True
        End If
    End Sub

End Class