Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmaddstudents

    Private Sub btn_addstudents_Click(sender As Object, e As EventArgs) Handles btn_addstudents.Click

        If TextBox1.Text <> "" Then
            If Directory.Exists(serverinitialpath) Then
                openconnection()
                cmd.CommandText = "select student_subject.student_id, student_subject.student_id, students_account.account_id, students_account.fullname from student_subject inner join students_account where student_id = '" & TextBox1.Text & "' and subject_id = '" & subject_id & "' and account_id = '" & TextBox1.Text & "'"
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    Dim polneym As String = dr("fullname").ToString()
                    TextBox1.Focus()
                    MessageBox.Show(polneym & " already added on the subject.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Text = ""
                    dr.Close()
                Else
                    dr.Close()
                    cmd.CommandText = "select * from students_account where account_id = '" & TextBox1.Text & "'"
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()
                        student_id = dr("account_id").ToString()
                        Dim polneym As String = dr("fullname").ToString()
                        cmd = New MySqlCommand("INSERT INTO `student_subject`(`subject_id`, `student_id`, `instructor_id`, `subject_name`, `time`, `day`) VALUES ('" & subject_id & "','" & student_id & "','" & id & "','" & subject_name & "','" & subject_time & "','" & subject_day & "')", con)
                        dr.Close()
                        cmd.ExecuteNonQuery()
                        TextBox1.Focus()
                        MessageBox.Show(polneym & " successfully added.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox1.Text = ""
                        Dim supercombination As String
                        supercombination = serverinitialpath & "\" & polneym
                        For Each item As String In My.Computer.FileSystem.GetDirectories(supercombination)
                            frmmain.icons.Images.Add(frmmain.GetShellIcon(item))
                            frmmain.listview.Items.Add(My.Computer.FileSystem.GetName(item), frmmain.icons.Images.Count - 1)
                        Next
                        con.Close()
                    Else
                        TextBox1.Focus()
                        MessageBox.Show("Student ID '" & TextBox1.Text & "' doesn't exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox1.Text = ""
                        dr.Close()
                    End If

                    querystudents()
                    frmmain.dgrid_mystudents.DataSource = dt
                    frmmain.dgrid_mystudents.ClearSelection()
                    con.Close()
                End If
            Else
                MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                frmsettings.ShowDialog()
            End If
        End If

    End Sub

    Private Sub frmaddstudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_addstudents.PerformClick()
        End If
    End Sub
End Class