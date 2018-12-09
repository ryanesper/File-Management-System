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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtpassword.Text = ""
        txtpassword.Focus()
        Me.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnok.Click

        If Directory.Exists(path) Then
            If Directory.Exists(path & "\images") Then
                Dim converter As New encryptanddecrypt
                Dim decryptedtext As String = converter.decrypt(password, "Keys")
                If txtpassword.Text = decryptedtext Then
                    If frmmyprofile.txtfname.Text.Contains("\") Or frmmyprofile.txtfname.Text.Contains("/") Or frmmyprofile.txtfname.Text.Contains(":") Or frmmyprofile.txtfname.Text.Contains("*") Or frmmyprofile.txtfname.Text.Contains("?") Or frmmyprofile.txtfname.Text.Contains("<") Or frmmyprofile.txtfname.Text.Contains(">") Or frmmyprofile.txtfname.Text.Contains("|") Or frmmyprofile.txtfname.Text.Contains("""") Then
                        MessageBox.Show("Your fullname must not contain this following characters." & " \ / : * ? < > | "" ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf frmmyprofile.txtmname.Text.Contains("\") Or frmmyprofile.txtmname.Text.Contains("/") Or frmmyprofile.txtmname.Text.Contains(":") Or frmmyprofile.txtmname.Text.Contains("*") Or frmmyprofile.txtmname.Text.Contains("?") Or frmmyprofile.txtmname.Text.Contains("<") Or frmmyprofile.txtmname.Text.Contains(">") Or frmmyprofile.txtmname.Text.Contains("|") Or frmmyprofile.txtmname.Text.Contains("""") Then
                        MessageBox.Show("Your fullname must not contain this following characters." & " \ / : * ? < > | "" ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf frmmyprofile.txtlname.Text.Contains("\") Or frmmyprofile.txtlname.Text.Contains("/") Or frmmyprofile.txtlname.Text.Contains(":") Or frmmyprofile.txtlname.Text.Contains("*") Or frmmyprofile.txtlname.Text.Contains("?") Or frmmyprofile.txtlname.Text.Contains("<") Or frmmyprofile.txtlname.Text.Contains(">") Or frmmyprofile.txtlname.Text.Contains("|") Or frmmyprofile.txtlname.Text.Contains("""") Then
                        MessageBox.Show("Your fullname must not contain this following characters." & " \ / : * ? < > | "" ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        If frmmyprofile.cbogender.Text = "Male" Or frmmyprofile.cbogender.Text = "Female" Then
                            If frmmyprofile.cbocourse.Text = "BSBA" Or frmmyprofile.cbocourse.Text = "BSCRIM" Or frmmyprofile.cbocourse.Text = "BSED" Or frmmyprofile.cbocourse.Text = "BSHRM" Or frmmyprofile.cbocourse.Text = "BSIT" Then
                                If frmmyprofile.cboyear.Text = "1st Year" Or frmmyprofile.cboyear.Text = "2nd Year" Or frmmyprofile.cboyear.Text = "3rd Year" Or frmmyprofile.cboyear.Text = "4th Year" Then
                                    If frmmyprofile.txtfname.TextLength > 1 Or frmmyprofile.txtmname.TextLength > 1 Or frmmyprofile.txtlname.TextLength > 1 Or frmmyprofile.txtaddress.TextLength > 1 Then
                                        frmmyprofile.txtfname.Text = frmmyprofile.txtfname.Text.Substring(0, 1).ToUpper() + frmmyprofile.txtfname.Text.Substring(1).ToLower()
                                        frmmyprofile.txtmname.Text = frmmyprofile.txtmname.Text.Substring(0, 1).ToUpper() + frmmyprofile.txtmname.Text.Substring(1).ToLower()
                                        frmmyprofile.txtlname.Text = frmmyprofile.txtlname.Text.Substring(0, 1).ToUpper() + frmmyprofile.txtlname.Text.Substring(1).ToLower()
                                        'txtaddress.Text = txtaddress.Text.Substring(0, 1).ToUpper() + txtaddress.Text.Substring(1).ToLower()
                                    ElseIf frmmyprofile.txtfname.TextLength = 1 Then
                                        frmmyprofile.txtfname.Text = frmmyprofile.txtfname.Text.ToUpper()
                                        frmmyprofile.txtmname.Text = frmmyprofile.txtmname.Text.ToUpper()
                                        frmmyprofile.txtlname.Text = frmmyprofile.txtlname.Text.ToUpper()
                                        'txtaddress.Text = txtaddress.Text.ToUpper()
                                    End If
                                    Try
                                        If firstname <> frmmyprofile.txtfname.Text Or middlename <> frmmyprofile.txtmname.Text Or lastname <> frmmyprofile.txtlname.Text Then
                                            Dim foldera0 As String = path & "\" & maxname
                                            Dim foldera1 As String = System.IO.Path.Combine(foldera0, maxname)
                                            My.Computer.FileSystem.RenameDirectory(combination, frmmyprofile.txtlname.Text & ", " & frmmyprofile.txtfname.Text & " " & frmmyprofile.txtmname.Text)

                                            Dim folderb0 As String = path & "\"
                                            Dim folderb1 As String = System.IO.Path.Combine(folderb0, maxname)
                                            My.Computer.FileSystem.RenameDirectory(combinate, frmmyprofile.txtlname.Text & ", " & frmmyprofile.txtfname.Text & " " & frmmyprofile.txtmname.Text)

                                            combinate = System.IO.Path.Combine(path, frmmyprofile.txtlname.Text & ", " & frmmyprofile.txtfname.Text & " " & frmmyprofile.txtmname.Text)
                                            combination = System.IO.Path.Combine(combinate, frmmyprofile.txtlname.Text & ", " & frmmyprofile.txtfname.Text & " " & frmmyprofile.txtmname.Text)

                                        End If
                                    Catch ex As Exception
                                        My.Computer.FileSystem.RenameDirectory(path & "\" & maxname & "\" & frmmyprofile.txtlname.Text & ", " & frmmyprofile.txtfname.Text & " " & frmmyprofile.txtmname.Text, maxname)
                                        MessageBox.Show("Your folder might be open on the server, please close it to complete the action.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End Try
                                    Dim wholename As String
                                    wholename = frmmyprofile.txtlname.Text & ", " & frmmyprofile.txtfname.Text & " " & frmmyprofile.txtmname.Text
                                    openconnection()
                                    cmd = New MySqlCommand("UPDATE `students_account` SET `firstname`= '" & frmmyprofile.txtfname.Text & "' ,`middlename`= '" & frmmyprofile.txtmname.Text & "' ,`lastname`= '" & frmmyprofile.txtlname.Text & "' , `fullname`= '" & wholename & "' , `gender`= '" & frmmyprofile.cbogender.Text & "' , `profilepic`= '" & picname & "' ,`year`= '" & frmmyprofile.cboyear.Text & "' ,`course`= '" & frmmyprofile.cbocourse.Text & "' ,`cpnumber`= '" & frmmyprofile.txtnumber.Text & "' ,`address`= '" & frmmyprofile.txtaddress.Text & "' ,`email`= '" & frmmyprofile.txtemail.Text & "' where account_id='" & accountid & "'", con)
                                    cmd.ExecuteNonQuery()
                                    con.Close()
                                    frmmain.fullname.Text = wholename
                                    frmmain.lblyc.Text = frmmyprofile.cbocourse.Text & " - " & frmmyprofile.cboyear.Text
                                    If File.Exists(loadmypicture) Then
                                        If picfullname <> "" Then
                                            frmmain.ovalpicture.BackgroundImage = Image.FromFile(picfullname)
                                            FileSystem.Kill(loadmypicture)
                                            Dim newcopy As String = System.IO.Path.Combine(path, "images", picname)
                                            System.IO.File.Copy(picfullname, newcopy)
                                            'My.Computer.FileSystem.RenameFile(newcopy, accountid & getpictypeforprofpic)
                                        End If
                                    Else
                                        If picfullname <> "" Then
                                            Dim newcopy As String = System.IO.Path.Combine(path, "images", picname)
                                            System.IO.File.Copy(picfullname, newcopy)
                                            'My.Computer.FileSystem.RenameFile(newcopy, accountid & getpictypeforprofpic)
                                            loadmypicture = path & "\images\" & picname
                                            Using fs As New System.IO.FileStream(loadmypicture, IO.FileMode.Open, IO.FileAccess.Read)
                                                frmmain.ovalpicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
                                            End Using
                                        End If
                                    End If

                                    firstname = frmmyprofile.txtfname.Text
                                    middlename = frmmyprofile.txtmname.Text
                                    lastname = frmmyprofile.txtlname.Text
                                    gender = frmmyprofile.cbogender.Text
                                    maxname = wholename
                                    year = frmmyprofile.cboyear.Text
                                    course = frmmyprofile.cbocourse.Text
                                    number = frmmyprofile.txtnumber.Text
                                    email = frmmyprofile.txtemail.Text
                                    address = frmmyprofile.txtaddress.Text

                                    MessageBox.Show("Successfully Updated.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    frmmyprofile.btncancel.PerformClick()
                                    txtpassword.Text = ""
                                    Me.Close()
                                Else
                                    MessageBox.Show("Invalid year.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                End If
                            Else
                                MessageBox.Show("Invalid department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If
                        Else
                            MessageBox.Show("Invalid gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End If
                Else
                    MessageBox.Show("Incorrect Password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            Else
                MessageBox.Show("The path for images could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                getsettingsfromdatabase()
                path = serverinitialpath
            End If
        Else
            MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            getsettingsfromdatabase()
            path = serverinitialpath
        End If

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnok.PerformClick()
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub frmupdateconfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        Button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        txtpassword.Focus()
    End Sub
End Class