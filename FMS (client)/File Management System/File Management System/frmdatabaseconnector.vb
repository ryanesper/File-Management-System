Public Class frmdatabaseconnector

    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If txtserver.Text = "" And txtuser.Text = "" And txtpassword.Text = "" And txtdatabase.Text = "" Then
            MessageBox.Show("Cannot connect to the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                If con.State = ConnectionState.Closed Then
                    'con.ConnectionString = "Server= " & My.Settings.serversettings & "; User Id= " & My.Settings.usersettings & "; Password= " & My.Settings.passwordsettings & "; Database= " & My.Settings.databasesettings & ";"
                    con.ConnectionString = "Server= " & txtserver.Text & "; User Id= " & txtuser.Text & "; Password= " & txtpassword.Text & "; Database= " & txtdatabase.Text & ";"
                    con.Open()
                    cmd.Connection = con
                    MessageBox.Show("Connection Sucessfull", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con.Close()

                    My.Settings.serversettings = txtserver.Text
                    My.Settings.usersettings = txtuser.Text
                    My.Settings.passwordsettings = txtpassword.Text
                    My.Settings.databasesettings = txtdatabase.Text
                    MessageBox.Show("The program must be close in order for the settings to take effect.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Cannot connect to the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub frmdatabaseconnector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'txtserver.Text = My.Settings.serversettings
        'txtuser.Text = My.Settings.usersettings
        'txtpassword.Text = My.Settings.passwordsettings
        'txtdatabase.Text = My.Settings.databasesettings

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        If txtserver.Text = "" And txtuser.Text = "" And txtpassword.Text = "" And txtdatabase.Text = "" Then
            MessageBox.Show("Connection Sucessfull", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            My.Settings.serversettings = txtserver.Text
            My.Settings.usersettings = txtuser.Text
            My.Settings.passwordsettings = txtpassword.Text
            My.Settings.databasesettings = txtdatabase.Text
            MessageBox.Show("The program must be close in order for the settings to take effect.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtserver.PasswordChar = ""
        Else
            txtserver.PasswordChar = "*"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtuser.PasswordChar = ""
        Else
            txtuser.PasswordChar = "*"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            txtdatabase.PasswordChar = ""
        Else
            txtdatabase.PasswordChar = "*"
        End If
    End Sub
End Class