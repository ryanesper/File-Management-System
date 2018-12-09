Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmstudentsregistration

    Dim solution1 As Integer
    Dim solution2 As Long
    Dim solution3 As Long
    Dim solution4 As Long
    Dim solution5 As Long
    Dim solution6 As Long
    Dim drivefreespace As Decimal
    Dim overallspaceconsumed As Decimal = 0
    Dim driveoriginalfreespace As Decimal = 0

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

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

    Private Sub txtid_Click(sender As Object, e As EventArgs) Handles txtid.Click
        If txtid.Text = "Account ID" Then
            txtid.Text = ""
        End If

        '--------------------------

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

    Private Sub cbogender_Click(sender As Object, e As EventArgs) Handles cbogender.Click
        If cbogender.Text = "Gender" Then
            cbogender.Text = ""
        End If

        '--------------------------

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

    Private Sub txtnumber_Click(sender As Object, e As EventArgs) Handles txtnumber.Click
        If txtnumber.Text = "Cellphone Number" Then
            txtnumber.Text = ""
        End If

        '--------------------------

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

    Private Sub cbocourse_Click(sender As Object, e As EventArgs) Handles cbocourse.Click
        If cbocourse.Text = "Department" Then
            cbocourse.Text = ""
        End If

        '--------------------------

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

    Private Sub cboyear_Click(sender As Object, e As EventArgs) Handles cboyear.Click
        If cboyear.Text = "Year" Then
            cboyear.Text = ""
        End If

        '--------------------------

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
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

    Private Sub txtuser_Click(sender As Object, e As EventArgs) Handles txtuser.Click
        If txtuser.Text = "Username" Then
            txtuser.Text = ""
        End If

        '--------------------------

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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
        If txtpassword.Text = "Password" Then
            txtpassword.PasswordChar = "*"
            txtpassword.Text = ""
        End If

        '--------------------------

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtemail.Text = "" Then
            txtemail.Text = "Email"
        End If

        '-----------------------------
    End Sub

    Private Sub txtemail_Click(sender As Object, e As EventArgs) Handles txtemail.Click
        If txtemail.Text = "Email" Then
            txtemail.Text = ""
        End If

        '--------------------------

        If txtid.Text = "" Then
            txtid.Text = "Account ID"
        End If

        If txtmname.Text = "" Then
            txtmname.Text = "Middle Name"
        End If

        If txtlname.Text = "" Then
            txtlname.Text = "Last Name"
        End If

        If cbogender.Text = "" Then
            cbogender.Text = "Gender"
        End If

        If txtnumber.Text = "" Then
            txtnumber.Text = "Cellphone Number"
        End If

        If cbocourse.Text = "" Then
            cbocourse.Text = "Department"
        End If

        If cboyear.Text = "" Then
            cboyear.Text = "Year"
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

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        If txtaddress.Text = "" Then
            txtaddress.Text = "Address"
        End If

        If txtfname.Text = "" Then
            txtfname.Text = "First Name"
        End If

        '-----------------------------
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Me.Dispose()
    End Sub

    Private Sub totalestimatedfreespace()

        '===================== Solution 1 ==================================
        Dim accountfoldernumber As Integer = 0
        Dim accountfolder As Object = My.Computer.FileSystem.GetDirectories(serverinitialpath, FileIO.SearchOption.SearchTopLevelOnly)
        For Each accountfolderr In accountfolder
            accountfoldernumber += 1
        Next
        solution1 = accountfoldernumber - 1
        'MsgBox("Account folders: " & solution1)

        '===================== Solution 2 ==================================
        drivefreespace = My.Computer.FileSystem.GetDriveInfo("C:").TotalFreeSpace
        solution2 = drivefreespace
        'Dim two As String = ""
        'If (solution2 >= 0 And solution2 < kb) Then
        '    two = solution2 & " bytes"
        'ElseIf (solution2 >= kb AndAlso solution2 < mb) Then
        '    two = Format((solution2 / 1024), "0.00") & " KB"
        'ElseIf (solution2 >= mb AndAlso solution2 < gb) Then
        '    two = Format((solution2 / 1024 / 1024), "0.00") & " MB"
        'ElseIf (solution2 >= gb) Then
        '    two = Format((solution2 / 1024 / 1024 / 1024), "0.00") & " GB"
        'End If
        'MsgBox("Drive free space: " & two)

        '===================== Solution 3 ==================================
        overallspaceconsumed = 0
        For Each item As String In My.Computer.FileSystem.GetFiles(serverinitialpath, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            overallspaceconsumed += My.Computer.FileSystem.GetFileInfo(item).Length
        Next
        solution3 = overallspaceconsumed
        'Dim three As String = ""
        'If (solution3 >= 0 And solution3 < kb) Then
        '    three = solution3 & " bytes"
        'ElseIf (solution3 >= kb AndAlso solution3 < mb) Then
        '    three = Format((solution3 / 1024), "0.00") & " KB"
        'ElseIf (solution3 >= mb AndAlso solution3 < gb) Then
        '    three = Format((solution3 / 1024 / 1024), "0.00") & " MB"
        'ElseIf (solution3 >= gb) Then
        '    three = Format((solution3 / 1024 / 1024 / 1024), "0.00") & " GB"
        'End If
        'MsgBox("Overall space consumed:  " & three)

        '===================== Solution 4 ==================================
        driveoriginalfreespace = drivefreespace + overallspaceconsumed
        solution4 = driveoriginalfreespace
        'Dim four As String = ""
        'If (solution4 >= 0 And solution4 < kb) Then
        '    four = solution4 & " bytes"
        'ElseIf (solution4 >= kb AndAlso solution4 < mb) Then
        '    four = Format((solution4 / 1024), "0.00") & " KB"
        'ElseIf (solution4 >= mb AndAlso solution4 < gb) Then
        '    four = Format((solution4 / 1024 / 1024), "0.00") & " MB"
        'ElseIf (solution4 >= gb) Then
        '    four = Format((solution4 / 1024 / 1024 / 1024), "0.00") & " GB"
        'End If
        'MsgBox("Drive original free space: " & four)

        '===================== Solution 5 ==================================
        solution5 = asinbytes
        'Dim five As String = ""
        'If (asinbytes >= 0 And asinbytes < kb) Then
        '    five = asinbytes & " bytes"
        'ElseIf (asinbytes >= kb AndAlso asinbytes < mb) Then
        '    five = Format((asinbytes / 1024), "0.00") & " KB"
        'ElseIf (asinbytes >= mb AndAlso asinbytes < gb) Then
        '    five = Format((asinbytes / 1024 / 1024), "0.00") & " MB"
        'ElseIf (asinbytes >= gb) Then
        '    five = Format((asinbytes / 1024 / 1024 / 1024), "0.00") & " GB"
        'End If
        'MsgBox("Allocated space: " & five)

        '===================== Solution 6 ==================================
        Dim defs As Long = driveoriginalfreespace - (asinbytes * solution1)
        If defs < 1 Then
            solution6 = 0
        Else
            solution6 = defs
        End If
        'Dim six As String = ""
        'If (solution6 >= 0 And solution6 < kb) Then
        '    six = solution6 & " bytes"
        'ElseIf (solution6 >= kb AndAlso solution6 < mb) Then
        '    six = Format((solution6 / 1024), "0.00") & " KB"
        'ElseIf (solution6 >= mb AndAlso solution6 < gb) Then
        '    six = Format((solution6 / 1024 / 1024), "0.00") & " MB"
        'ElseIf (solution6 >= gb) Then
        '    six = Format((solution6 / 1024 / 1024 / 1024), "0.00") & " GB"
        'End If
        'MsgBox("Estimated remaing space: " & six)

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If Directory.Exists(serverinitialpath) Then
            totalestimatedfreespace()
            getsettingsfromdatabase()
            If solution6 > asinbytes Then

                'Dim one As String = ""
                'If (solution6 >= 0 And solution6 < kb) Then
                '    one = solution6 & " bytes"
                'ElseIf (solution6 >= kb AndAlso solution6 < mb) Then
                '    one = Format((solution6 / 1024), "0.00") & " KB"
                'ElseIf (solution6 >= mb AndAlso solution6 < gb) Then
                '    one = Format((solution6 / 1024 / 1024), "0.00") & " MB"
                'ElseIf (solution6 >= gb) Then
                '    one = Format((solution6 / 1024 / 1024 / 1024), "0.00") & " GB"
                'End If

                'Dim two As String = ""
                'If (asinbytes >= 0 And asinbytes < kb) Then
                '    two = asinbytes & " bytes"
                'ElseIf (asinbytes >= kb AndAlso asinbytes < mb) Then
                '    two = Format((asinbytes / 1024), "0.00") & " KB"
                'ElseIf (asinbytes >= mb AndAlso asinbytes < gb) Then
                '    two = Format((asinbytes / 1024 / 1024), "0.00") & " MB"
                'ElseIf (asinbytes >= gb) Then
                '    two = Format((asinbytes / 1024 / 1024 / 1024), "0.00") & " GB"
                'End If

                If txtid.Text = "Account ID" Or txtid.Text = "" Or
                txtfname.Text = "First Name" Or txtfname.Text = "" Or
                txtmname.Text = "Middle Name" Or txtmname.Text = "" Or
                txtlname.Text = "Last Name" Or txtlname.Text = "" Or
                cbogender.Text = "Gender" Or cbogender.Text = "" Or
                txtnumber.Text = "Cellphone Number" Or txtnumber.Text = "" Or
                txtuser.Text = "Username" Or txtuser.Text = "" Or
                txtpassword.Text = "Password" Or txtpassword.Text = "" Or
                txtcfpassword.Text = "Confirm Password" Or txtcfpassword.Text = "" Or
                cboyear.Text = "Year" Or cboyear.Text = "" Or
                cbocourse.Text = "Department" Or cbocourse.Text = "" Or
                txtemail.Text = "Email" Or txtemail.Text = "" Or
                txtaddress.Text = "Address" Or txtaddress.Text = "" Then
                    'txtnumber.Text = "Cellphone Number" Or txtnumber.Text = "" Then
                    'txtage.Text = "Age" Or txtage.Text = "" Or
                    'cbogender.Text = "Gender" Or cbogender.Text = "" Or
                    MessageBox.Show("All field/s required", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    If txtid.Text = "" Then
                        txtid.Text = "Account ID"
                    End If

                    If txtfname.Text = "" Then
                        txtfname.Text = "First Name"
                    End If

                    If txtmname.Text = "" Then
                        txtmname.Text = "Middle Name"
                    End If

                    If cbogender.Text = "" Then
                        cbogender.Text = "Gender"
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

                    'If txtnumber.Text = "" Then
                    '    txtnumber.Text = "Cellphone Number"
                    'End If

                    'If cbogender.Text = "" Then
                    '    cbogender.Text = "Gender"
                    'End If

                    If cboyear.Text = "" Then
                        cboyear.Text = "Year"
                    End If

                    If cbocourse.Text = "" Then
                        cbocourse.Text = "Department"
                    End If
                Else


                    If txtpassword.Text = txtcfpassword.Text Then
                        openconnection()

                        If txtfname.TextLength > 1 Or txtmname.TextLength > 1 Or txtlname.TextLength > 1 Or txtaddress.TextLength > 1 Then
                            txtfname.Text = txtfname.Text.Substring(0, 1).ToUpper() + txtfname.Text.Substring(1).ToLower()
                            txtmname.Text = txtmname.Text.Substring(0, 1).ToUpper() + txtmname.Text.Substring(1).ToLower()
                            txtlname.Text = txtlname.Text.Substring(0, 1).ToUpper() + txtlname.Text.Substring(1).ToLower()
                            'txtaddress.Text = txtaddress.Text.Substring(0, 1).ToUpper() + txtaddress.Text.Substring(1).ToLower()
                        ElseIf txtfname.TextLength = 1 Then
                            txtfname.Text = txtfname.Text.ToUpper()
                            txtmname.Text = txtmname.Text.ToUpper()
                            txtlname.Text = txtlname.Text.ToUpper()
                            'txtaddress.Text = txtaddress.Text.ToUpper()
                        End If

                        Dim wholename As String
                        wholename = txtlname.Text & ", " & txtfname.Text & " " & txtmname.Text

                        cmd.CommandText = "select account_id from students_account where account_id = '" & txtid.Text & "'"
                        dr = cmd.ExecuteReader
                        If dr.HasRows Then
                            MessageBox.Show("Account ID '" & txtid.Text & "' already taken!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            dr.Close()
                        Else
                            dr.Close()
                            cmd.CommandText = "select * from students_account where fullname = '" & wholename & "'"
                            dr = cmd.ExecuteReader
                            If dr.HasRows Then
                                ' User already exists
                                MessageBox.Show("Fullname '" & wholename & "' already exists!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                dr.Close()
                            Else
                                dr.Close()
                                cmd.CommandText = "select * from students_account where username = '" & txtuser.Text & "'"
                                dr = cmd.ExecuteReader
                                If dr.HasRows Then
                                    MessageBox.Show("Username '" & txtuser.Text & "' already taken!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    dr.Close()
                                Else
                                    If cbogender.Text = "Male" Or cbogender.Text = "Female" Then

                                        If cbocourse.Text = "BSIT" Or cbocourse.Text = "BSBA" Or cbocourse.Text = "BSHRM" Or cbocourse.Text = "BSED" Or cbocourse.Text = "BSCRIM" Then

                                            If cboyear.Text = "1st Year" Or cboyear.Text = "2nd Year" Or cboyear.Text = "3rd Year" Or cboyear.Text = "4th Year" Then


                                                'con.Close()

                                                Dim registrationdate As String
                                                registrationdate = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss GG")

                                                Dim converter As New encryptanddecrypt
                                                Dim encryptedpassword As String = converter.encrypt(txtcfpassword.Text, "Keys")

                                                'openconnection()
                                                dr.Close()
                                                cmd = New MySqlCommand("INSERT INTO `students_account`(`account_id`,`firstname`, `middlename`, `lastname`, `fullname`, `gender`, `year`, `course`, `username`, `password`, `cpnumber`, `address`, `email`, `registereddate`) VALUES ('" & txtid.Text & "','" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & wholename & "','" & cbogender.Text & "','" & cboyear.Text & "','" & cbocourse.Text & "','" & txtuser.Text & "','" & encryptedpassword & "','" & txtnumber.Text & "','" & txtaddress.Text & "','" & txtemail.Text & "','" & registrationdate & "')", con)
                                                cmd.ExecuteNonQuery()
                                                dr.Close()
                                                con.Close()
                                                getsettingsfromdatabase()
                                                ''" & txtfname.Text & "','" & txtmname.Text & "','" & txtlname.Text & "','" & wholename & "','" & cboyear.Text & "','" & cbocourse.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "','" & registrationdate & "'
                                                Dim folder As String = System.IO.Path.Combine(serverinitialpath, wholename)

                                                'If Not Directory.Exists(folder) Then
                                                Directory.CreateDirectory(folder)

                                                Dim folder0 As String = System.IO.Path.Combine(folder, wholename)
                                                'Dim folderpic As String = System.IO.Path.Combine(folder, "MyProfilePicture")

                                                Directory.CreateDirectory(folder0)
                                                'Directory.CreateDirectory(folderpic)
                                                'Else
                                                '    MessageBox.Show("folder already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                'End If


                                                MessageBox.Show("Account successfully created.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                frmstudents.btn_students.PerformClick()

                                                txtid.Text = "Account ID"
                                                txtfname.Text = "First Name"
                                                txtmname.Text = "Middle Name"
                                                txtlname.Text = "Last Name"
                                                cbogender.Text = "Gender"
                                                txtuser.Text = "Username"
                                                txtpassword.PasswordChar = ""
                                                txtpassword.Text = "Password"
                                                txtcfpassword.PasswordChar = ""
                                                txtcfpassword.Text = "Confirm Password"
                                                txtnumber.Text = "Cellphone Number"
                                                txtaddress.Text = "Address"
                                                txtemail.Text = "Email"
                                                'txtage.Text = "Age"
                                                'txtaddress.Text = "Address"
                                                'txtnumber.Text = "Cellphone Number"
                                                'cbogender.Text = "Gender"
                                                cboyear.Text = "Year"
                                                cbocourse.Text = "Course"

                                                'frmlogin.radiouser.Visible = True
                                                'frmlogin.radiouser.Checked = True
                                                'frmlogin.radioadmin.Visible = True
                                                'frmlogin.radioadmin.Checked = False
                                                'frmlogin.Button1.Visible = False
                                                'frmlogin.txtusername.Text = ""
                                                'frmlogin.txtpassword.Text = ""
                                            Else
                                                MessageBox.Show("Select a valid year", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                dr.Close()

                                            End If
                                        Else
                                            MessageBox.Show("Select a valid department", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            dr.Close()
                                        End If
                                    Else
                                        MessageBox.Show("Select a valid gender", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        dr.Close()
                                    End If
                                End If
                            End If
                        End If
                    Else
                        MessageBox.Show("Password did not match", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Sorry but the hard drive cannot provide a space anymore for a new account.", "Insufficient Space", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("The network path that has been set in the settings does not exists.", "Path Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmsettings.ShowDialog()
        End If
        
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txtid.Text = "Account ID"
        txtfname.Text = "First Name"
        txtmname.Text = "Middle Name"
        txtlname.Text = "Last Name"
        cbogender.Text = "Gender"
        txtnumber.Text = "Cellphone Number"
        cbocourse.Text = "Department"
        cboyear.Text = "Year"
        txtuser.Text = "Username"
        txtpassword.PasswordChar = ""
        txtpassword.Text = "Password"
        txtcfpassword.PasswordChar = ""
        txtcfpassword.Text = "Confirm Password"
        txtaddress.Text = "Address"
        txtemail.Text = "Email"
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text = "Password" Then

        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtcfpassword_TextChanged(sender As Object, e As EventArgs) Handles txtcfpassword.TextChanged
        If txtcfpassword.Text = "Confirm Password" Then

        Else
            txtcfpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub frmstudentsregistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class