Public Class frmDatabase
    Private Sub cmdConnect_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        dbServer = txtServer.Text
        dbUser = txtUser.Text
        dbPass = txtPassword.Text
        dbDatabase = txtDatabase.Text
        SaveSettings()
        MsgBox("Please restart the application for the settings to take effect.", _
                       MsgBoxStyle.Exclamation, "Database Connection")
        Me.Close()
        End
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Dispose()
        End
    End Sub

    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSettings()
        txtServer.Text = dbServer
        txtUser.Text = dbUser
        txtPassword.Text = dbPass
        txtDatabase.Text = dbDatabase
    End Sub
End Class