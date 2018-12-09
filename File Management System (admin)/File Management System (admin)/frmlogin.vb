Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmlogin

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

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtusername.BackColor = System.Drawing.ColorTranslator.FromHtml("#b2b2b2")
        txtpassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#b2b2b2")
        txtusername.Focus()
        Try
            openconnection()
            cmd = New MySqlCommand("SELECT COUNT(username) as nameCount FROM admin", con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While (reader.Read())
                If reader("nameCount") = 0 Then
                    confirm = MessageBox.Show("No account existed yet. Want to create?", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frminstructorregistration.Show()
                    Me.Close()
                End If
            End While
            reader.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Cannot connect to the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmdatabaseconnector.Show()
            Me.Close()
        End Try

    End Sub


    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        If txtusername.Text = "" Then
            MessageBox.Show("All fields are required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Text = ""
            txtpassword.Text = ""
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("All fields are required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Text = ""
            txtpassword.Text = ""
        Else
            Dim converter As New encryptanddecrypt
            Dim encryptedtext As String = converter.encrypt(txtpassword.Text, "Keys")

            openconnection()
            cmd.CommandText = "select * from admin where username = '" & txtusername.Text & "' and password = '" & encryptedtext & "' "

            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()

                id = dr("id").ToString()
                username = dr("username").ToString()
                password = dr("password").ToString()
                firstname = dr("firstname").ToString()
                middlename = dr("middlename").ToString()
                lastname = dr("lastname").ToString()
                number = dr("cpnumber").ToString()
                address = dr("address").ToString()
                email = dr("email").ToString()
                picname = dr("profilepic").ToString()
                account_type = dr("account_type").ToString()
                regdate = dr("dateregistered").ToString()
                If account_type = "Head Admin" Then
                    dr.Close()
                    frmmain.Show()
                    Me.Close()
                Else
                    frmmain.btninstructors.Visible = False
                    frmmain.btnstudents.Visible = False
                    frmmain.btndirectories.Visible = False
                    dr.Close()
                    txtusername.Focus()
                    frmmain.Show()
                    Me.Close()
                End If

                'End While
            Else
                MessageBox.Show("Account doesn't exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtusername.Text = ""
                txtpassword.Text = ""
                txtusername.Focus()
            End If

            txtusername.Text = ""
            txtpassword.Text = ""
            con.Close()
        End If

    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnlogin.PerformClick()
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class
