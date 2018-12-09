Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmupdateconfirmation

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
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        txtpassword.Text = ""
        txtpassword.Focus()
        Me.Close()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click

        If Directory.Exists(serverinitialpath & "\images") Then
            Dim converter As New encryptanddecrypt
            Dim decryptedpassword As String = converter.decrypt(password, "Keys")
            If txtpassword.Text = decryptedpassword Then

                Dim wholename As String = frmprofile.txtfname.Text & " " & frmprofile.txtmname.Text & " " & frmprofile.txtlname.Text & " - " & account_type
                openconnection()

                cmd = New MySqlCommand("UPDATE `admin` SET `firstname`= '" & frmprofile.txtfname.Text & "' ,`middlename`= '" & frmprofile.txtmname.Text & "' ,`lastname`= '" & frmprofile.txtlname.Text & "' , `fullname`= '" & wholename & "' , `profilepic`= '" & picname & "' ,`cpnumber`= '" & frmprofile.txtnumber.Text & "' ,`address`= '" & frmprofile.txtaddress.Text & "' ,`email`= '" & frmprofile.txtemail.Text & "' where id='" & id & "'", con)
                cmd.ExecuteNonQuery()

                con.Close()
                frmmain.fullname.Text = wholename
                frminstructors.fullname.Text = wholename
                frmstudents.fullname.Text = wholename
                frmdirectories.fullname.Text = wholename

                getsettingsfromdatabase()
                If System.IO.File.Exists(loadmypicture) Then
                    If picfullname <> "" Then
                        'frmmain.ovalpicture.BackgroundImage = Image.FromFile(picfullname)
                        FileSystem.Kill(loadmypicture)
                        Dim newcopy As String = System.IO.Path.Combine(serverinitialpath, "images", picname)
                        System.IO.File.Copy(picfullname, newcopy)
                        loadmypicture = newcopy
                        'My.Computer.FileSystem.RenameFile(newcopy, accountid & getpictypeforprofpic)
                    End If
                Else
                    If picfullname <> "" Then
                        Dim newcopy As String = System.IO.Path.Combine(serverinitialpath, "images", picname)
                        System.IO.File.Copy(picfullname, newcopy)
                        'My.Computer.FileSystem.RenameFile(newcopy, accountid & getpictypeforprofpic)
                        loadmypicture = newcopy
                        Using fs As New System.IO.FileStream(loadmypicture, IO.FileMode.Open, IO.FileAccess.Read)
                            frmmain.ovalpicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
                        End Using
                    End If
                End If

                MessageBox.Show("Updated Successfully.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)

                firstname = frmprofile.txtfname.Text
                middlename = frmprofile.txtmname.Text
                lastname = frmprofile.txtlname.Text
                number = frmprofile.txtnumber.Text
                address = frmprofile.txtaddress.Text
                email = frmprofile.txtemail.Text
                txtpassword.Text = ""
                txtpassword.Focus()
                frmprofile.btncancel.PerformClick()
                Me.Close()
            Else
                MessageBox.Show("Current Password was Incorrect.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
        End If

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnok.PerformClick()
        End If
    End Sub

    Private Sub frmupdateconfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class