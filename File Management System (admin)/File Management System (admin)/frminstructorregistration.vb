Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frminstructorregistration

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

    Private Sub txtfname_Click(sender As Object, e As EventArgs) Handles txtfname.Click
        If txtfname.Text = "First Name" Then
            txtfname.Text = ""
        End If

        '--------------------------

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If


        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If

        If txtpassword.Text = "" Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Password"
        End If

        If txtcfpassword.Text = "" Then
            txtcfpassword.PasswordChar = ""
            txtcfpassword.Text = "Confirm Password"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtmname_Click(sender As Object, e As EventArgs) Handles txtmname.Click
        If txtmname.Text = "Middle Name" Then
            txtmname.Text = ""
        End If

        '--------------------------

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If


        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If

        If txtpassword.Text = "" Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Password"
        End If

        If txtcfpassword.Text = "" Then
            txtcfpassword.PasswordChar = ""
            txtcfpassword.Text = "Confirm Password"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtlname_Click(sender As Object, e As EventArgs) Handles txtlname.Click
        If txtlname.Text = "Last Name" Then
            txtlname.Text = ""
        End If

        '--------------------------

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If


        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If

        If txtpassword.Text = "" Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Password"
        End If

        If txtcfpassword.Text = "" Then
            txtcfpassword.PasswordChar = ""
            txtcfpassword.Text = "Confirm Password"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtlname_TextChanged(sender As Object, e As EventArgs) Handles txtlname.TextChanged

    End Sub

    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
        End If

        '--------------------------

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If


        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtpassword.Text = "" Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Password"
        End If

        If txtcfpassword.Text = "" Then
            txtcfpassword.PasswordChar = ""
            txtcfpassword.Text = "Confirm Password"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtpassword_Click(sender As Object, e As EventArgs) Handles txtpassword.Click
        'txtpassword.PasswordChar = "*"
        If txtpassword.Text = "Password" Then
            txtpassword.PasswordChar = "*"
            txtpassword.Text = ""
        End If

        '--------------------------

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If


        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtcfpassword.Text = "" Then
            txtcfpassword.PasswordChar = ""
            txtcfpassword.Text = "Confirm Password"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtcfpassword_Click(sender As Object, e As EventArgs) Handles txtcfpassword.Click
        If txtcfpassword.Text = "Confirm Password" Then
            txtcfpassword.PasswordChar = "*"
            txtcfpassword.Text = ""
        End If

        '--------------------------

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If


        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If

        If txtpassword.Text = "" Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Password"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtnumber_Click(sender As Object, e As EventArgs) Handles txtnumber.Click
        If txtnumber.Text = "Cellphone Number" Then
            txtnumber.Text = ""
        End If

        '--------------------------

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If

        If txtpassword.Text = "" Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Password"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtaddress_Click(sender As Object, e As EventArgs) Handles txtaddress.Click
        If txtaddress.Text = "Address" Then
            txtaddress.Text = ""
        End If

        '--------------------------

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If


        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If

        If txtpassword.Text = "" Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Password"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtcfpassword.Text = "" Then
            txtcfpassword.PasswordChar = ""
            txtcfpassword.Text = "Confirm Password"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtaddress_TextChanged(sender As Object, e As EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub txtemail_Click(sender As Object, e As EventArgs) Handles txtemail.Click
        If txtemail.Text = "Email" Then
            txtemail.Text = ""
        End If

        '--------------------------

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If


        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtuser.Text = "" Then
            txtuser.Text = "Username"
        End If

        If txtpassword.Text = "" Then
            txtpassword.PasswordChar = ""
            txtpassword.Text = "Password"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtcfpassword.Text = "" Then
            txtcfpassword.PasswordChar = ""
            txtcfpassword.Text = "Confirm Password"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        '-----------------------------
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txtfname.Text = "First Name"
        txtmname.Text = "Middle Name"
        txtlname.Text = "Last Name"
        txtnumber.Text = "Cellphone Number"
        txtuser.Text = "Username"
        txtpassword.PasswordChar = ""
        txtpassword.Text = "Password"
        txtcfpassword.PasswordChar = ""
        txtcfpassword.Text = "Confirm Password"
        txtaddress.Text = "Address"
        txtemail.Text = "Email"
    End Sub

    Private Sub adminidgenerator()

        openconnection()
        Dim idinitial As String = "ADN"
        Dim counter As Integer = 1
        Dim idnumber As String = "00"
        finalizeid = idinitial & idnumber & counter.ToString
        Dim isidexists As Boolean = True

        dr.Close()
        cmd.CommandText = "select id from admin where id = '" & finalizeid & "'"
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
                    idnumber = "0"
                ElseIf counter > 99 Then
                    idnumber = ""
                End If
                finalizeid = idinitial & idnumber & counter.ToString
                cmd.CommandText = "select id from admin where id = '" & finalizeid & "'"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtfname.Text = "First Name" Or txtfname.Text = "" Or
            txtmname.Text = "Middle Name" Or txtmname.Text = "" Or
            txtlname.Text = "Last Name" Or txtlname.Text = "" Or
            txtnumber.Text = "Cellphone Number" Or txtnumber.Text = "" Or
            txtuser.Text = "Username" Or txtuser.Text = "" Or
            txtpassword.Text = "Password" Or txtpassword.Text = "" Or
            txtcfpassword.Text = "Confirm Password" Or txtcfpassword.Text = "" Or
            txtemail.Text = "Email" Or txtemail.Text = "" Or
            txtaddress.Text = "Address" Or txtaddress.Text = "" Then


            'txtnumber.Text = "Cellphone Number" Or txtnumber.Text = "" Then
            'txtage.Text = "Age" Or txtage.Text = "" Or
            'cbogender.Text = "Gender" Or cbogender.Text = "" Or
            MessageBox.Show("All field/s required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If txtfname.Text = "" Then
                txtfname.Text = "First Name"
            End If

            If txtmname.Text = "" Then
                txtmname.Text = "Middle Name"
            End If

            If txtnumber.Text = "" Then
                txtnumber.Text = "Cellphone Number"
            End If

            If txtlname.Text = "" Then
                txtlname.Text = "Last Name"
            End If

            If txtuser.Text = "" Then
                txtuser.Text = "Username"
            End If

            If txtpassword.Text = "" Then
                txtpassword.PasswordChar = ""
                txtpassword.Text = "Password"
            End If

            If txtcfpassword.Text = "" Then
                txtcfpassword.PasswordChar = ""
                txtcfpassword.Text = "Confirm Password"
            End If

            If txtemail.Text = "" Then
                txtemail.Text = "Email"
            End If

            If txtaddress.Text = "" Then
                txtaddress.Text = "Address"
            End If

        Else
            If txtpassword.Text = txtcfpassword.Text Then
                openconnection()

                If txtfname.TextLength > 1 Or txtmname.TextLength > 1 Or txtlname.TextLength > 1 Or txtaddress.TextLength > 1 Then
                    txtfname.Text = txtfname.Text.Substring(0, 1).ToUpper() + txtfname.Text.Substring(1).ToLower()
                    txtmname.Text = txtmname.Text.Substring(0, 1).ToUpper() + txtmname.Text.Substring(1).ToLower()
                    txtlname.Text = txtlname.Text.Substring(0, 1).ToUpper() + txtlname.Text.Substring(1).ToLower()
                    txtaddress.Text = txtaddress.Text.Substring(0, 1).ToUpper() + txtaddress.Text.Substring(1).ToLower()
                ElseIf txtfname.TextLength = 1 Then
                    txtfname.Text = txtfname.Text.ToUpper()
                    txtmname.Text = txtmname.Text.ToUpper()
                    txtlname.Text = txtlname.Text.ToUpper()
                    txtaddress.Text = txtaddress.Text.ToUpper()
                End If

                Dim wholename As String
                wholename = txtfname.Text & " " & txtmname.Text & " " & txtlname.Text

                cmd.CommandText = "select * from admin where username = '" & txtuser.Text & "'"

                dr = cmd.ExecuteReader
                user = cmd.CommandText
                If dr.HasRows Then
                    MsgBox("Username '" & txtuser.Text & "' already taken!", MsgBoxStyle.Critical, "Alert")
                    dr.Close()
                    Exit Sub
                Else

                    con.Close()

                    Dim registrationdate As String
                    registrationdate = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss GG")
                    Dim converter As New encryptanddecrypt
                    Dim encryptedpassword As String = converter.encrypt(txtcfpassword.Text, "Keys")

                    openconnection()

                    cmd = New MySqlCommand("SELECT COUNT(username) as NameCount FROM admin", con)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    If dr("NameCount") = 0 Then
                        adminidgenerator()
                        cmd = New MySqlCommand("INSERT INTO `admin`(`id`, `firstname`, `middlename`, `lastname`, `fullname`, `username`, `password`, `cpnumber`, `address`, `email`, `account_type`, `dateregistered`) VALUES ('" & finalizeid & "','" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & wholename & "','" & txtuser.Text & "','" & encryptedpassword & "', '" & txtnumber.Text & "', '" & txtaddress.Text & "', '" & txtemail.Text & "', '" & "Head Admin" & "', '" & registrationdate & "')", con)
                        cmd.ExecuteNonQuery()
                        dr.Close()

                        MessageBox.Show("You have successfully created an Account", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        con.Close()

                        txtfname.Text = "First Name"
                        txtmname.Text = "Middle Name"
                        txtlname.Text = "Last Name"
                        txtuser.Text = "Username"
                        txtpassword.PasswordChar = ""
                        txtpassword.Text = "Password"
                        txtcfpassword.PasswordChar = ""
                        txtcfpassword.Text = "Confirm Password"
                        txtnumber.Text = "Cellphone Number"
                        txtaddress.Text = "Address"
                        txtemail.Text = "Email"

                        frmlogin.Show()
                        Me.Close()
                        'Directory.CreateDirectory("C:\Students_Accounts")

                    Else
                        adminidgenerator()
                        cmd = New MySqlCommand("INSERT INTO `admin`(`id`, `firstname`, `middlename`, `lastname`, `fullname`, `username`, `password`, `cpnumber`, `address`, `email`, `account_type`, `dateregistered`) VALUES ('" & finalizeid & "','" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & wholename & "','" & txtuser.Text & "','" & encryptedpassword & "', '" & txtnumber.Text & "', '" & txtaddress.Text & "', '" & txtemail.Text & "', '" & "Instructor Admin" & "', '" & registrationdate & "')", con)
                        cmd.ExecuteNonQuery()
                        dr.Close()

                        MessageBox.Show("You have successfully created an Account", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        con.Close()

                        txtfname.Text = "First Name"
                        txtmname.Text = "Middle Name"
                        txtlname.Text = "Last Name"
                        txtuser.Text = "Username"
                        txtpassword.PasswordChar = ""
                        txtpassword.Text = "Password"
                        txtcfpassword.PasswordChar = ""
                        txtcfpassword.Text = "Confirm Password"
                        txtnumber.Text = "Cellphone Number"
                        txtaddress.Text = "Address"
                        txtemail.Text = "Email"

                        openconnection()

                        queryallinstructors()
                        frminstructors.dgrid_instructorsacount.DataSource = dt
                        frminstructors.dgrid_instructorsacount.ClearSelection()
                        con.Close()

                        frminstructors.btnrefresh.PerformClick()
                        'frmlogin.Show()
                        'frmaddstudents.Close()
                        'frmaddsubjects.Close()
                        'frmexplorer.Close()
                        'frminstructors.Close()
                        'frmmain.Close()
                        'frmmyprofile.Close()
                        'frmsettings.Close()
                        'frmstudents.Close()
                        'frmstudentsfile.Close()
                        'frmstudentsregistration.Close()

                    End If
                End If
            Else
                MessageBox.Show("Password did not match", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub txtcfpassword_TextChanged(sender As Object, e As EventArgs) Handles txtcfpassword.TextChanged
        If txtcfpassword.Text = "Confirm Password" Then

        Else
            txtcfpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub frminstructorregistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text = "Password" Then

        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

End Class