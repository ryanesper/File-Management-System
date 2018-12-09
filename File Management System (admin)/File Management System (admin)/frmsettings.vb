Imports System.IO

Public Class frmsettings

    Dim computername As String
    Dim accountallocatedspaceinbytes As Long

    Private Const MAX_PATH As Integer = 256
    Private Const NAMESIZE As Integer = 80
    Private Const SHGFI_ICON As Int32 = &H100

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
    Private Sub frmsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each drive In IO.DriveInfo.GetDrives
            'get all removable and fixed drives
            If drive.DriveType = IO.DriveType.Removable Or drive.DriveType = IO.DriveType.Fixed Then
                'add all found drives into the combobox
                cbodrives.Items.Add(drive)
            End If
        Next

        If account_type = "Head Admin" Then
            openconnection()
            cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(client_initial_path) as Count FROM settings", con)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()

            While (reader.Read())
                If reader("Count") = 0 Then
                    btnsave.Visible = True
                    cbodrives.Enabled = True
                    txtclientinitialpath.ReadOnly = False
                    txtsize.ReadOnly = False
                    cbounit.Enabled = True
                    txtusername.ReadOnly = False
                    txtpassword.ReadOnly = False
                Else
                    txtclientinitialpath.Text = clientinitialpath
                    cbodrives.Text = drive_location
                    txtserverinitialpath.Text = serverinitialpath
                    txtsize.Text = sizenumber
                    cbounit.Text = unit
                    txtinbytes.Text = Format(asinbytes, "#,##0")
                    txtusername.Text = serverpcusername
                    txtpassword.Text = serverpcpassword
                End If
            End While
            reader.Close()
        ElseIf account_type = "Instructor Admin" Then
            txtclientinitialpath.ReadOnly = True
            cbodrives.Enabled = False
            txtserverinitialpath.ReadOnly = True
            txtsize.ReadOnly = True
            cbounit.Enabled = False
            txtinbytes.ReadOnly = True
            txtusername.ReadOnly = True
            txtpassword.ReadOnly = True
            btnsave.Enabled = False
            btneau.Enabled = False

            openconnection()
            cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(client_initial_path) as Count FROM settings", con)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()

            While (reader.Read())
                If reader("Count") = 0 Then
                    btnsave.Visible = True
                    txtclientinitialpath.ReadOnly = False
                    cbodrives.Enabled = True
                    txtsize.ReadOnly = False
                    cbounit.Enabled = True
                    txtusername.ReadOnly = False
                    txtpassword.ReadOnly = False
                Else
                    txtclientinitialpath.Text = clientinitialpath
                    cbodrives.Text = drive_location
                    txtserverinitialpath.Text = serverinitialpath
                    txtsize.Text = sizenumber
                    cbounit.Text = unit
                    txtinbytes.Text = Format(asinbytes, "#,##0")
                    txtusername.Text = serverpcusername
                    txtpassword.Text = serverpcpassword
                End If
            End While
            reader.Close()
        End If

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If txtclientinitialpath.Text = "" Or cbodrives.Text = "" Or txtserverinitialpath.Text = "" Or txtsize.Text = "" Or cbounit.Text = "" Or txtinbytes.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Some field(s) are empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Directory.Exists(txtserverinitialpath.Text) Then
                Me.Close()
            Else
                MessageBox.Show("The network path that has been set does not exists.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btneau_Click(sender As Object, e As EventArgs) Handles btneau.Click

        If btneau.Text = "Edit" Then
            btneau.Text = "Update"
            txtclientinitialpath.ReadOnly = False
            cbodrives.Enabled = True
            txtsize.ReadOnly = False
            txtusername.ReadOnly = False
            txtpassword.ReadOnly = False
            cbounit.Enabled = True
        ElseIf btneau.Text = "Update" Then
            If txtclientinitialpath.Text = "" Or cbodrives.Text = "" Or txtsize.Text = "" Or cbounit.Text = "" Or txtinbytes.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Then
                MessageBox.Show("Cannot complete the action because some field(s) are missing.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Dim replaceclientpath As String = txtclientinitialpath.Text.Replace("\", "\\")
                Dim replacedrivepath As String = cbodrives.Text.Replace("\", "\\")
                Dim replaceserverpath As String = txtserverinitialpath.Text.Replace("\", "\\")
                Dim converter As New encryptanddecrypt
                Dim encryptedpassword As String = converter.encrypt(txtpassword.Text, "Keys")
                Dim serverpcname As String = "\\\\" & computername & "\\"
                Dim alsp As String = txtsize.Text & " " & cbounit.Text
                If Directory.Exists(replaceserverpath) Then
                    btneau.Text = "Edit"
                    openconnection()
                    cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE `settings` SET `serverpcname`= '" & serverpcname & "' ,`client_initial_path`= '" & replaceclientpath & "' , `drive_location`= '" & replacedrivepath & "' , `server_initial_path`= '" & replaceserverpath & "' ,`size`= '" & txtsize.Text & "' ,`unit`= '" & cbounit.Text & "' , `allocated_space`= '" & alsp & "' , `asinbytes`= '" & accountallocatedspaceinbytes & "' , `username`= '" & txtusername.Text & "' , `password`= '" & encryptedpassword & "'", con)
                    cmd.ExecuteNonQuery()
                    Dim imagefolder As String = txtserverinitialpath.Text & "\images"
                    If Not System.IO.Directory.Exists(imagefolder) Then
                        System.IO.Directory.CreateDirectory(imagefolder)
                    End If
                    MessageBox.Show("Sucessfully Updated", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con.Close()
                    getsettingsfromdatabase()
                    txtclientinitialpath.ReadOnly = True
                    cbodrives.Enabled = False
                    txtsize.ReadOnly = True
                    txtusername.ReadOnly = True
                    txtpassword.ReadOnly = True
                    cbounit.Enabled = False
                    frmdirectories.btn_refresh.PerformClick()
                Else
                    MessageBox.Show("The initial path for server does not exists.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        If txtclientinitialpath.Text = "" Or cbodrives.Text = "" Or txtsize.Text = "" Or cbounit.Text = "" Or txtinbytes.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Then
            MessageBox.Show("Cannot complete the action because some field(s) are missing.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim replaceclientpath As String = txtclientinitialpath.Text.Replace("\", "\\")
            Dim replacedrivepath As String = cbodrives.Text.Replace("\", "\\")
            Dim replaceserverpath As String = txtserverinitialpath.Text.Replace("\", "\\")
            Dim alsp As String = txtsize.Text & " " & cbounit.Text
            btneau.Text = "Edit"
            Dim converter As New encryptanddecrypt
            Dim encryptedpassword As String = converter.encrypt(txtpassword.Text, "Keys")
            Dim serverpcname As String = "\\\\" & computername & "\\"
            If Directory.Exists(replaceserverpath) Then
                openconnection()
                cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO `settings`(`serverpcname`, `client_initial_path`, `drive_location`, `server_initial_path`, `size`, `unit`, `allocated_space`, `asinbytes`, `username`, `password`) VALUES ('" & serverpcname & "','" & replaceclientpath & "','" & replacedrivepath & "','" & replaceserverpath & "','" & txtsize.Text & "','" & cbounit.Text & "','" & alsp & "','" & accountallocatedspaceinbytes & "','" & txtusername.Text & "','" & encryptedpassword & "')", con)
                cmd.ExecuteNonQuery()

                Dim imagefolder As String = txtserverinitialpath.Text & "\images"
                If Not System.IO.Directory.Exists(imagefolder) Then
                    System.IO.Directory.CreateDirectory(imagefolder)
                End If
                MessageBox.Show("Settings Sucessfully Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()

                getsettingsfromdatabase()
                txtclientinitialpath.ReadOnly = True
                cbodrives.Enabled = False
                txtsize.ReadOnly = True
                cbounit.Enabled = False
                txtusername.ReadOnly = True
                txtpassword.ReadOnly = True
                btnsave.Visible = False
                txtclientinitialpath.ReadOnly = True
                txtsize.ReadOnly = True
                txtusername.ReadOnly = True
                txtpassword.ReadOnly = True
                cbounit.Enabled = False
            Else
                MessageBox.Show("The initial path for server does not exists.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub


    Private Sub txtclientinitialpath_TextChanged(sender As Object, e As EventArgs) Handles txtclientinitialpath.TextChanged
        If txtclientinitialpath.Text.Contains("'") Then
            MessageBox.Show("Must not contain a single quotation", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtclientinitialpath.Text = ""
        Else
            If txtclientinitialpath.Text.Contains("\\" & computername & "\") Then
                txtserverinitialpath.Text = txtclientinitialpath.Text.Replace("\\" & computername & "\", cbodrives.Text)
            End If
        End If
    End Sub

    Private Sub cbounit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbounit.SelectedIndexChanged

        Try
            If txtsize.Text <> "" Then
                If cbounit.Text = "kb" Then
                    txtinbytes.Text = Format((txtsize.Text * kb), "#,##0")
                    accountallocatedspaceinbytes = txtsize.Text * kb
                ElseIf cbounit.Text = "mb" Then
                    txtinbytes.Text = Format((txtsize.Text * mb), "#,##0")
                    accountallocatedspaceinbytes = txtsize.Text * mb
                ElseIf cbounit.Text = "gb" Then
                    txtinbytes.Text = Format((txtsize.Text * gb), "#,##0")
                    accountallocatedspaceinbytes = txtsize.Text * gb
                End If
            Else
                txtinbytes.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show("Numbers only.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtsize.Text = ""
            txtinbytes.Text = ""
        End Try

    End Sub

    Private Sub txtallocatedspace_TextChanged(sender As Object, e As EventArgs) Handles txtsize.TextChanged

        Try
            If txtsize.Text <> "" Then
                If cbounit.Text = "kb" Then
                    txtinbytes.Text = Format((txtsize.Text * kb), "#,##0")
                    accountallocatedspaceinbytes = txtsize.Text * kb
                ElseIf cbounit.Text = "mb" Then
                    txtinbytes.Text = Format((txtsize.Text * mb), "#,##0")
                    accountallocatedspaceinbytes = txtsize.Text * mb
                ElseIf cbounit.Text = "gb" Then
                    txtinbytes.Text = Format((txtsize.Text * gb), "#,##0")
                    accountallocatedspaceinbytes = txtsize.Text * gb
                End If
            Else
                txtinbytes.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show("Numbers only.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtsize.Text = ""
            txtinbytes.Text = ""
        End Try

    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        If txtusername.Text.Contains("'") Or txtusername.Text.Contains("\") Then
            MessageBox.Show("Single qoutation and slash not allowed.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Text = ""
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text.Contains("'") Or txtpassword.Text.Contains("\") Then
            MessageBox.Show("Single qoutation and slash not allowed.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpassword.Text = ""
        End If
    End Sub

    Private Sub cbodrives_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodrives.SelectedIndexChanged
        computername = My.Computer.Name
        If txtclientinitialpath.Text.Contains("\\" & computername & "\") Then
            txtserverinitialpath.Text = txtclientinitialpath.Text.Replace("\\" & computername & "\", cbodrives.Text)
        Else
            txtserverinitialpath.Text = ""
        End If
    End Sub


End Class