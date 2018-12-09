Imports MySql.Data.MySqlClient

Public Class frmchangepassword
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
    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Dim converter As New encryptanddecrypt
        If txtcp.Text = "" Then
            MessageBox.Show("Please enter your current password.", "Password Missing", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcp.Focus()
        Else
            Dim decryptedpassword As String = converter.decrypt(password, "Keys")
            If txtcp.Text = decryptedpassword Then
                If txtnp.Text = txtcnp.Text Then
                    If txtnp.Text = "" And txtcnp.Text = "" Then
                        If txtusername.Text <> "" Then
                            openconnection()
                            If username = txtusername.Text Then
                                cmd = New MySqlCommand("UPDATE `students_account` SET `username`= '" & txtusername.Text & "' ,`password`= '" & password & "' where account_id='" & accountid & "'", con)
                            Else
                                cmd.CommandText = "select * from students_account where username = '" & txtusername.Text & "'"
                                dr = cmd.ExecuteReader
                                If dr.HasRows Then
                                    MessageBox.Show("Username '" & txtusername.Text & "' already taken!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    dr.Close()
                                    Exit Sub
                                Else
                                    cmd = New MySqlCommand("UPDATE `students_account` SET `username`= '" & txtusername.Text & "' ,`password`= '" & password & "' where account_id='" & accountid & "'", con)
                                End If
                            End If
                            cmd.ExecuteNonQuery()
                            con.Close()
                            MessageBox.Show("Successfully Updated.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtnp.Text = ""
                            txtcnp.Text = ""
                            txtcp.Text = ""
                            Exit Sub
                        Else
                            MessageBox.Show("Username value cannot be null.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        If txtusername.Text <> "" Then
                            openconnection()
                            Dim encryptedpassword As String = converter.encrypt(txtcnp.Text, "Keys")

                            If username = txtusername.Text Then
                                cmd = New MySqlCommand("UPDATE `students_account` SET `username`= '" & txtusername.Text & "' ,`password`= '" & encryptedpassword & "' where account_id='" & accountid & "'", con)
                            Else
                                cmd.CommandText = "select * from students_account where username = '" & txtusername.Text & "'"
                                dr = cmd.ExecuteReader
                                If dr.HasRows Then
                                    MessageBox.Show("Username '" & txtusername.Text & "' already taken!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    dr.Close()
                                    Exit Sub
                                Else
                                    cmd = New MySqlCommand("UPDATE `students_account` SET `username`= '" & txtusername.Text & "' ,`password`= '" & encryptedpassword & "' where account_id='" & accountid & "'", con)
                                End If
                            End If
                            dr.Close()
                            cmd.ExecuteNonQuery()
                            con.Close()
                            MessageBox.Show("Successfully Updated.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            username = txtusername.Text
                            password = encryptedpassword
                            txtnp.Text = ""
                            txtcnp.Text = ""
                            txtcp.Text = ""
                            Exit Sub
                        Else
                            MessageBox.Show("Username value cannot be null.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    MessageBox.Show("Password did not match.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Your current password was incorrect.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub frmchangepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        txtusername.Text = username
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtusername.Focus()
        Me.Close()
    End Sub

    Private Sub txtcp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcp.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnok.PerformClick()
        End If
    End Sub

    Private Sub txtcp_TextChanged(sender As Object, e As EventArgs) Handles txtcp.TextChanged

    End Sub

End Class