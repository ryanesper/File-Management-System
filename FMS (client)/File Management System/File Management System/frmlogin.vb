Imports MySql.Data.MySqlClient
Imports IWshRuntimeLibrary
Imports System.IO

Public Class frmlogin

    Dim getpcname As String = ""
    Dim getlastuser As String = ""
    Dim getlastlogin As String = ""
    Dim getlastlogout As String = ""
    Dim getlastuserfullname As String = ""
    Dim getlastuserimage As String = ""
    Dim firstuse As String
    Dim letmelogin As String

    Dim currentuser As String
    Dim pathofitemtoberenameanddelete As String

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

    Private Sub createshortcut(ByVal filepath As String, ByVal shortcutdirectory As String, ByVal description As String)
        Try
            Dim myshortcut As IWshShortcut
            Dim wsh As New WshShell
            Dim str As String = My.Computer.FileSystem.GetFileInfo(filepath).Name.Replace(My.Computer.FileSystem.GetFileInfo(filepath).Extension, Nothing)

            myshortcut = CType(wsh.CreateShortcut(shortcutdirectory & "\" & str & ".lnk"), IWshShortcut)
            With myshortcut
                .TargetPath = filepath
                .WindowStyle = 1
                .Description = description
                .IconLocation = filepath & ", 0"
                .Save()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub recordlastuser()

        Dim computername As String = My.Computer.Name
        Dim lastuser As String = accountid
        Dim lastlogin As String = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss GG")
        openconnection()
        cmd.CommandText = "select * from client_pc where pc_name = '" & computername & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Close()
            cmd = New MySqlCommand("UPDATE `client_pc` SET `pc_name`= '" & computername & "' ,`last_user`= '" & lastuser & "' ,`last_login`= '" & lastlogin & "' where pc_name='" & computername & "'", con)
            cmd.ExecuteNonQuery()
        Else
            dr.Close()
            cmd = New MySqlCommand("INSERT INTO `client_pc`(`pc_name`, `last_user`, `last_login`) VALUES ('" & computername & "','" & lastuser & "','" & lastlogin & "')", con)
            cmd.ExecuteNonQuery()
        End If
        dr.Close()
        con.Close()

    End Sub

    Private Sub btn_login_Click_1(sender As Object, e As EventArgs) Handles btn_login.Click

        'Try
        If txtusername.Text = "" Then
            MessageBox.Show("All fields are required.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        ElseIf txtpassword.Text = "" Then
            MessageBox.Show("All fields are required.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusername.Text = ""
            txtpassword.Text = ""
            txtusername.Focus()
        ElseIf txtusername.Text = "Administrator" And txtpassword.Text = "filemanagementsystem" Then
            frmdatabaseconnector.Show()
            Me.Close()
        Else

            getsettingsfromdatabase()
            impersonate()
            If Directory.Exists(myinitialpath) Then
                Dim converter As New encryptanddecrypt
                Dim encryptedpassword As String = converter.encrypt(txtpassword.Text, "Keys")
                openconnection()
                cmd.CommandText = "select * from students_account where username = '" & txtusername.Text & "' and password = '" & encryptedpassword & "' "

                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read()
                        accountid = dr("account_id").ToString()
                        username = dr("username").ToString()
                        password = dr("password").ToString()
                        firstname = dr("firstname").ToString()
                        middlename = dr("middlename").ToString()
                        lastname = dr("lastname").ToString()
                        gender = dr("gender").ToString()
                        picname = dr("profilepic").ToString()
                        maxname = dr("fullname").ToString()
                        year = dr("year").ToString()
                        course = dr("course").ToString()
                        number = dr("cpnumber").ToString()
                        email = dr("email").ToString()
                        address = dr("address").ToString()
                        dateregistered = dr("registereddate").ToString
                    End While
                    dr.Close()
                    ispcnameexists()
                    If firstuse = "No" Then
                        'MsgBox("No, it's already been used.")
                        If getlastuser <> "" Then
                            If getlastuser = accountid Then
                                'MsgBox("Yes, last user and current user are equal.")
                            ElseIf getlastuser <> accountid Then
                                'MsgBox("No, last user and current user are not equal.")
                                'formatworkingarea()
                                'If letmelogin = "No" Then

                                If Directory.Exists(pathofitemtoberenameanddelete) = False Then
                                    MessageBox.Show("You must restart the computer before you can login.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Exit Sub
                                Else

                                    'MsgBox("yess!!! " & pathofitemtoberenameanddelete & " exists.")
                                End If
                                'End If
                            End If
                        Else
                            MessageBox.Show("Last user has not been identified, please close the program and open again.", "Last user not found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    ElseIf firstuse = "Yes" Then
                        'MsgBox("Yes, it has not been use yet.")
                    End If

                    If Directory.Exists(pathofitemtoberenameanddelete) Then
                        If Not Directory.Exists("C:\Users\" & currentuser & "\Picture") Then
                            My.Computer.FileSystem.RenameDirectory(pathofitemtoberenameanddelete, "Picture")
                        End If
                    End If
                    recordlastuser()
                    frmmain.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Account doesn't exist.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtusername.Focus()
                    con.Close()
                    txtusername.Text = ""
                    txtpassword.Text = ""
                End If
            Else
                MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub Loginclose1_Click(sender As Object, e As EventArgs) Handles Loginclose1.Click
        Me.Close()
    End Sub

    Private Sub frmlogin_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.MaximizeBox = False
    End Sub

    Private Sub ispcnameexists()

        openconnection()
        Dim computername As String = My.Computer.Name
        cmd.CommandText = "select pc_name from client_pc where pc_name = '" & computername & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            firstuse = "No"
            'MsgBox("No, it's already been used.")
        Else
            firstuse = "Yes"
            'MsgBox("Yes, it has not been use yet.")
        End If
        dr.Close()
        con.Close()

    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        currentuser = Environment.UserName
        pathofitemtoberenameanddelete = "C:\Users\" & currentuser & "\Pictures"

        txtusername.BackColor = System.Drawing.ColorTranslator.FromHtml("#272f32")
        txtpassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#272f32")
        Me.TransparencyKey = Me.BackColor

        Try
            openconnection()
            getsettingsfromdatabase()
            impersonate()
            myinitialpath = clientinitialpath
            If Directory.Exists(myinitialpath) Then
                openconnection()
                Dim computername As String = My.Computer.Name
                cmd.CommandText = "select * from client_pc where pc_name = '" & computername & "'"
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read()
                        getpcname = dr("pc_name").ToString()
                        getlastuser = dr("last_user").ToString()
                        getlastlogin = dr("last_login").ToString()
                        getlastlogout = dr("last_logout").ToString()
                    End While
                End If
                dr.Close()
                loadlastuserinfo()
            Else
                MessageBox.Show("The initial path for client could not be found. Inform your admin about this error.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Can't connect to the database.", "Connection Fialed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmdatabaseconnector.Show()
            Me.Close()
        End Try

    End Sub

    Private Sub loadlastuserinfo()

        cmd.CommandText = "select * from students_account where account_id = '" & getlastuser & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read()
                getlastuserfullname = dr("firstname").ToString() & " " & dr("middlename").ToString() & " " & dr("lastname").ToString()
                getlastuserimage = dr("profilepic").ToString()
            End While
        End If
        dr.Close()

        Dim loadlastuserpic As String = myinitialpath & "\images\" & getlastuserimage
        If System.IO.File.Exists(loadlastuserpic) Then
            Using fs As New System.IO.FileStream(loadlastuserpic, IO.FileMode.Open, IO.FileAccess.Read)
                mypicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
            End Using
        End If

        lblfullname.Text = getlastuserfullname
        Label1.Visible = True
        lblfullname.Visible = True
        mypicture.Visible = True

    End Sub

    Private Sub formatworkingarea()

        If Directory.Exists("Z:\") Then
            For Each item As String In My.Computer.FileSystem.GetFiles("Z:\", FileIO.SearchOption.SearchTopLevelOnly, "*.*")
                'Dim type As String = My.Computer.FileSystem.GetFileInfo(item).Extension
                'MsgBox(item)
                Try
                    My.Computer.FileSystem.DeleteFile(item, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                Catch ex As Exception
                    letmelogin = "No"
                End Try
            Next

            For Each item As String In My.Computer.FileSystem.GetDirectories("Z:\", FileIO.SearchOption.SearchTopLevelOnly)
                'MsgBox(item)
                If item = "Z:\$RECYCLE.BIN" Or item = "Z:\System Volume Information" Then

                Else
                    Try
                        My.Computer.FileSystem.DeleteDirectory(item, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
                    Catch ex As Exception
                        letmelogin = "No"
                    End Try
                End If
            Next

            For Each item In My.Computer.FileSystem.GetFiles("C:\Application Shortcut")
                Dim filename As String = My.Computer.FileSystem.GetFileInfo(item).Name
                Dim filetocopy As String = item
                Dim newcopy As String = "Z:\" & filename
                My.Computer.FileSystem.CopyFile(item, newcopy)
            Next
        Else
            MessageBox.Show("Drive Z: not found.", "Path Error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            letmelogin = "No"
            Exit Sub
        End If

    End Sub

    Private Sub Loginminimize1_Click(sender As Object, e As EventArgs) Handles Loginminimize1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

End Class