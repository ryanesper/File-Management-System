Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmmyprofile

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

    Private Sub frmmyprofile_Click(sender As Object, e As EventArgs) Handles Me.Click
        dgrid_mysubjects.ClearSelection()
    End Sub
    Private Sub frmmyprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim bgfile = Me.BackgroundImage
        'Me.SuspendLayout()
        'Me.BackgroundImage = Nothing

        lblid.Text = accountid
        lblfullname.Text = firstname & " " & middlename & " " & lastname
        lblgender.Text = gender
        lblday.Text = course & " - " & year
        lblcpno.Text = number
        lbladdress.Text = address
        lblemail.Text = email

        btnminimize.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        btnclose.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        lbloverallitems.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")

        txtfname.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        txtmname.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        txtlname.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        cbogender.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        cbocourse.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        cboyear.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        txtnumber.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        txtaddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        txtemail.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")

        dgrid_mysubjects.BackgroundColor = System.Drawing.ColorTranslator.FromHtml("#272b35")

        Me.TransparencyKey = BackColor

        openconnection()

        selectmysubjects()
        dgrid_mysubjects.DataSource = dt

        con.Close()

        dgrid_mysubjects.Columns("subject_name").HeaderText = "Subject"
        dgrid_mysubjects.Columns("subject_description").HeaderText = "Description"
        dgrid_mysubjects.Columns("subject_time").HeaderText = "Time"
        dgrid_mysubjects.Columns("subject_day").HeaderText = "Day"

        dgrid_mysubjects.Columns(0).Width = "110"
        dgrid_mysubjects.Columns(1).Width = "250"
        dgrid_mysubjects.Columns(2).Width = "139"
        dgrid_mysubjects.Columns(3).Width = "100"
        dgrid_mysubjects.ClearSelection()
        'mypicture.BackgroundImage = Image.FromFile(loadmypicture)

        'Dim FileStream1 As New System.IO.FileStream(loadmypicture, IO.FileMode.Open, IO.FileAccess.Read)
        'Dim MyImage As Image = Image.FromStream(FileStream1)
        'mypicture.BackgroundImage = MyImage

        If File.Exists(loadmypicture) Then
            Using fs As New System.IO.FileStream(loadmypicture, IO.FileMode.Open, IO.FileAccess.Read)
                mypicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
            End Using
        End If

        'Me.BackgroundImage = bgfile
        'Me.ResumeLayout()
    End Sub


    Private Sub btnbrowseapic_Click(sender As Object, e As EventArgs) Handles btnbrowseapic.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.gif;*.png;*.bmp"
        OpenFileDialog1.FileName = ""
        'OpenFileDialog1.CustomPlaces.

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            getpictypeforprofpic = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Extension
            picfullname = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).FullName
            picname = accountid & My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Extension
            'picname = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Name
            'Label1.Text = picfullname
            'Label2.Text = getpictypeforprofpic

            Using fs As New System.IO.FileStream(picfullname, IO.FileMode.Open, IO.FileAccess.Read)
                mypicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
            End Using

        End If
        mypicture.BorderStyle = Drawing2D.DashStyle.Custom
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        btnupdate.Visible = True
        btncancel.Visible = True
        btncp.Visible = True
        btnbrowseapic.Visible = True
        btnedit.Visible = False

        Label2.Text = "Firstname"
        Label4.Text = "Department"

        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True

        lblfullname.Visible = False
        lblgender.Visible = False
        lblday.Visible = False
        lblcpno.Visible = False
        lbladdress.Visible = False
        lblemail.Visible = False

        txtfname.Visible = True
        txtmname.Visible = True
        txtlname.Visible = True
        cbocourse.Visible = True
        cboyear.Visible = True
        cbogender.Visible = True
        txtnumber.Visible = True
        txtaddress.Visible = True
        txtemail.Visible = True


        txtfname.Text = firstname
        txtmname.Text = middlename
        txtlname.Text = lastname
        cbocourse.Text = course
        cboyear.Text = year
        cbogender.Text = gender
        txtnumber.Text = number
        txtaddress.Text = address
        txtemail.Text = email

        mypicture.BorderStyle = Drawing2D.DashStyle.Solid

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        frmupdateconfirmation.txtpassword.Focus()
        frmupdateconfirmation.ShowInTaskbar = False
        frmupdateconfirmation.ShowDialog()

        'btnupdate.Visible = False
        'btncancel.Visible = False
        'btnbrowseapic.Visible = False
        'btnedit.Visible = True
        'mypicture.BorderStyle = Drawing2D.DashStyle.Custom
        'lblpassword2.Visible = False
        'Label10.Visible = False

        'Panel2.Visible = False
        'Panel1.Visible = True

        ''txtfname.Text.Contains("\") Or txtfname.Text.Contains("/") Or txtfname.Text.Contains(":") Or txtfname.Text.Contains("*") Or txtfname.Text.Contains("?") Or txtfname.Text.Contains("<") Or txtfname.Text.Contains(">") Or txtfname.Text.Contains("|") Or txtfname.Text.Contains("""") Or txtfname.Text.Contains(".") And
        ''    txtmname.Text.Contains("\") Or txtmname.Text.Contains("/") Or txtmname.Text.Contains(":") Or txtmname.Text.Contains("*") Or txtmname.Text.Contains("?") Or txtmname.Text.Contains("<") Or txtmname.Text.Contains(">") Or txtmname.Text.Contains("|") Or txtmname.Text.Contains("""") Or txtmname.Text.Contains(".") And
        ''    txtlname.Text.Contains("\") Or txtlname.Text.Contains("/") Or txtlname.Text.Contains(":") Or txtlname.Text.Contains("*") Or txtlname.Text.Contains("?") Or txtlname.Text.Contains("<") Or txtlname.Text.Contains(">") Or txtlname.Text.Contains("|") Or txtlname.Text.Contains("""") Or txtlname.Text.Contains(".") Then



        'If txtfname.Text.Contains("\") Or txtfname.Text.Contains("/") Or txtfname.Text.Contains(":") Or txtfname.Text.Contains("*") Or txtfname.Text.Contains("?") Or txtfname.Text.Contains("<") Or txtfname.Text.Contains(">") Or txtfname.Text.Contains("|") Or txtfname.Text.Contains("""") Or txtfname.Text.Contains(".") Then
        '    MessageBox.Show("illegal characters detected" & " \ / : * ? < > | "" .", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtfname.Text = ""
        'ElseIf txtmname.Text.Contains("\") Or txtmname.Text.Contains("/") Or txtmname.Text.Contains(":") Or txtmname.Text.Contains("*") Or txtmname.Text.Contains("?") Or txtmname.Text.Contains("<") Or txtmname.Text.Contains(">") Or txtmname.Text.Contains("|") Or txtmname.Text.Contains("""") Or txtmname.Text.Contains(".") Then
        '    MessageBox.Show("illegal characters detected" & " \ / : * ? < > | "" .", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtmname.Text = ""
        'ElseIf txtlname.Text.Contains("\") Or txtlname.Text.Contains("/") Or txtlname.Text.Contains(":") Or txtlname.Text.Contains("*") Or txtlname.Text.Contains("?") Or txtlname.Text.Contains("<") Or txtlname.Text.Contains(">") Or txtlname.Text.Contains("|") Or txtlname.Text.Contains("""") Or txtlname.Text.Contains(".") Then
        '    MessageBox.Show("illegal characters detected" & " \ / : * ? < > | "" .", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtlname.Text = ""
        'Else

        '    Try
        '        If firstname <> txtfname.Text Or middlename <> txtmname.Text Or lastname <> txtlname.Text Then
        '            'Dim foldera0 As String = path & "\" & maxname
        '            'Dim foldera1 As String = System.IO.Path.Combine(foldera0, maxname)
        '            My.Computer.FileSystem.RenameDirectory(combination, txtlname.Text & ", " & txtfname.Text & " " & txtmname.Text)

        '            'Dim folderb0 As String = path & "\"
        '            'Dim folderb1 As String = System.IO.Path.Combine(folderb0, maxname)
        '            My.Computer.FileSystem.RenameDirectory(combinate, txtlname.Text & ", " & txtfname.Text & " " & txtmname.Text)

        '            combinate = System.IO.Path.Combine(path, txtlname.Text & ", " & txtfname.Text & " " & txtmname.Text)
        '            combination = System.IO.Path.Combine(combinate, txtlname.Text & ", " & txtfname.Text & " " & txtmname.Text)

        '        End If
        '    Catch ex As Exception
        '        My.Computer.FileSystem.RenameDirectory(path & "\" & maxname & "\" & txtlname.Text & ", " & txtfname.Text & " " & txtmname.Text, maxname)
        '        MessageBox.Show("Your folder might be open on the server, please close it to complete the action", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End Try

        '    'confirm = MsgBox("Are you sure you want to update? ", vbYesNo, "Update Confirmation")
        '    'If confirm = vbYes Then
        '    openconnection()

        '    Dim wholename As String
        '    wholename = txtlname.Text & ", " & txtfname.Text & " " & txtmname.Text

        '    cmd = New MySqlCommand("UPDATE `students_account` SET `firstname`= '" & txtfname.Text & "' ,`middlename`= '" & txtmname.Text & "' ,`lastname`= '" & txtlname.Text & "' , `fullname`= '" & wholename & "' , `gender`= '" & cbogender.Text & "' , `profilepic`= '" & picname & "' ,`year`= '" & cboyear.Text & "' ,`course`= '" & cbodepartment.Text & "' ,`cpnumber`= '" & txtnumber.Text & "' ,`address`= '" & txtaddress.Text & "' ,`email`= '" & txtemail.Text & "' where account_id='" & accountid & "'", con)
        '    cmd.ExecuteNonQuery()

        '    frmmain.fullname.Text = wholename
        '    frmmain.lblyc.Text = lbldepartment.Text & " - " & lblyear.Text

        '    '' ''If firstname <> txtfname.Text Or middlename <> txtmname.Text Or lastname <> txtlname.Text Then
        '    '' ''    'Dim foldera0 As String = path & "\" & maxname
        '    '' ''    'Dim foldera1 As String = System.IO.Path.Combine(foldera0, maxname)
        '    '' ''    My.Computer.FileSystem.RenameDirectory(combination, wholename)

        '    '' ''    'Dim folderb0 As String = path & "\"
        '    '' ''    'Dim folderb1 As String = System.IO.Path.Combine(folderb0, maxname)
        '    '' ''    My.Computer.FileSystem.RenameDirectory(combinate, wholename)

        '    '' ''    combinate = System.IO.Path.Combine(path, wholename)
        '    '' ''    combination = System.IO.Path.Combine(combinate, wholename)
        '    '' ''End If

        '    If File.Exists(loadmypicture) Then
        '        If picfullname <> "" Then
        '            frmmain.ovalpicture.BackgroundImage = Image.FromFile(picfullname)
        '            FileSystem.Kill(loadmypicture)
        '            Dim newcopy As String = System.IO.Path.Combine(path, "images", picname)
        '            System.IO.File.Copy(picfullname, newcopy)
        '            'My.Computer.FileSystem.RenameFile(newcopy, accountid & getpictypeforprofpic)
        '        End If
        '    Else
        '        If picfullname <> "" Then
        '            Dim newcopy As String = System.IO.Path.Combine(path, "images", picname)
        '            System.IO.File.Copy(picfullname, newcopy)
        '            'My.Computer.FileSystem.RenameFile(newcopy, accountid & getpictypeforprofpic)
        '            loadmypicture = path & "\images\" & picname
        '            Using fs As New System.IO.FileStream(loadmypicture, IO.FileMode.Open, IO.FileAccess.Read)
        '                frmmain.ovalpicture.BackgroundImage = System.Drawing.Image.FromStream(fs)
        '            End Using
        '        End If
        '    End If

        '    'Dim newcopy As String = System.IO.Path.Combine(combinate, "MyProfilePicture", picname)
        '    'System.IO.File.Copy(picfullname, newcopy)
        '    'My.Computer.FileSystem.RenameFile(newcopy, wholename & getpictypeforprofpic)

        '    firstname = txtfname.Text
        '    middlename = txtmname.Text
        '    lastname = txtlname.Text
        '    gender = cbogender.Text
        '    username = txtusername.Text
        '    password = txtnewpass.Text
        '    maxname = wholename
        '    year = cboyear.Text
        '    course = cbodepartment.Text
        '    number = txtnumber.Text
        '    email = txtemail.Text
        '    address = txtaddress.Text
        '    dateregistered = txtregdate.Text
        '    btncancel.Visible = False

        '    lblfullname.Text = maxname
        '    lblgender.Text = gender
        '    lbldepartment.Text = course
        '    lblyear.Text = year
        '    lblcpnumber.Text = number
        '    lbladdress.Text = address
        '    lblemail.Text = email
        '    lblregdate.Text = dateregistered
        '    lblusername.Text = username

        '    MsgBox("Updated Successfully")

        '    con.Close()


        'End If

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        lblid.Text = accountid
        lblfullname.Text = firstname & " " & middlename & " " & lastname
        lblgender.Text = gender
        lblday.Text = course & " - " & year
        lblcpno.Text = number
        lbladdress.Text = address
        lblemail.Text = email

        Label2.Text = "Fullname"
        Label4.Text = "Department and Year"

        btncancel.Visible = False
        btnupdate.Visible = False
        btncp.Visible = False
        btnbrowseapic.Visible = False
        btnedit.Visible = True

        lblfullname.Visible = True
        lblgender.Visible = True
        lblday.Visible = True
        lblcpno.Visible = True
        lbladdress.Visible = True
        lblemail.Visible = True

        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        txtfname.Visible = False
        txtmname.Visible = False
        txtlname.Visible = False
        cbocourse.Visible = False
        cboyear.Visible = False
        cbogender.Visible = False
        txtnumber.Visible = False
        txtaddress.Visible = False
        txtemail.Visible = False

        mypicture.BorderStyle = Drawing2D.DashStyle.Custom

    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncp_Click(sender As Object, e As EventArgs) Handles btncp.Click
        frmchangepassword.ShowInTaskbar = False
        frmchangepassword.ShowDialog()
    End Sub
End Class