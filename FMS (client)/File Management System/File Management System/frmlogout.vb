Imports MySql.Data.MySqlClient

Public Class frmlogout

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
    Private Sub frmlogout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_logout.Click

        Dim converter As New encryptanddecrypt
        Dim encryptedpassword As String = converter.encrypt(TextBox1.Text, "Keys")
        If encryptedpassword = password Then
            totalsize = 0
            TextBox1.Text = ""
            frmlogin.txtusername.Text = ""
            frmlogin.txtpassword.Text = ""
            frmcopyandpaste.copyandpastelistview1.Items.Clear()
            frmcopyandpaste.copyandpastelistview2.Items.Clear()

            openconnection()

            Dim computername As String = My.Computer.Name
            Dim lastlogout As String = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss GG")
            cmd.CommandText = "select * from client_pc"
            'dr = cmd.ExecuteReader
            cmd = New MySqlCommand("UPDATE `client_pc` SET `last_logout`= '" & lastlogout & "' where pc_name = '" & computername & "'", con)
            cmd.ExecuteNonQuery()
            'dr.Close()
            con.Close()

            'frmlogin.Show()
            'frmmain.Close()
            logout()
        Else
            TextBox1.Text = ""
            MessageBox.Show("Incorrect Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub button_cancel_Click(sender As Object, e As EventArgs) Handles button_cancel.Click
        TextBox1.Text = ""
        TextBox1.Focus()
        Me.Close()
    End Sub

    Private Sub logout()

        frmrunningapplication.ListView1.Items.Clear()
        frmrunningapplication.ListView1.Columns.Clear()
        frmrunningapplication.ListView1.Columns.Add("Programs", 200, HorizontalAlignment.Left)
        frmrunningapplication.ListView1.Columns.Add("Full Path", 800, HorizontalAlignment.Left)
        frmrunningapplication.ListView1.FullRowSelect = True
        frmrunningapplication.ListView1.View = View.Details

        frmrunningapplication.ListView2.Items.Clear()
        frmrunningapplication.ListView2.Columns.Clear()
        frmrunningapplication.ListView2.Columns.Add("Programs", 200, HorizontalAlignment.Left)
        frmrunningapplication.ListView2.Columns.Add("Full Path", 800, HorizontalAlignment.Left)
        frmrunningapplication.ListView2.FullRowSelect = True
        frmrunningapplication.ListView2.View = View.Details

        '======================================= get the processes ======================================================

        Try
            For Each proc As Process In Process.GetProcesses
                If proc.MainWindowTitle <> "" Then
                    Dim lvi As New ListViewItem(proc.ProcessName)
                    'lvi.SubItems.Add(proc.MainModule.FileName)
                    frmrunningapplication.ListView1.Items.Add(lvi)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("There's an open program that preventing the system to close. Please close it immediately before you logout.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        '============================================ transfer ========================================================
        For Each item As ListViewItem In frmrunningapplication.ListView1.Items
            If frmrunningapplication.ListView1.Items.Count > 0 Then
                item = frmrunningapplication.ListView1.Items.Item(0)
                item.Remove()

                Dim lvi As New ListViewItem(item.SubItems(0).Text & ".exe")
                'lvi.SubItems.Add(item.SubItems(1).Text)
                'If item.SubItems(0).Text = "devenv" Then

                'Else
                frmrunningapplication.ListView2.Items.Add(lvi)
                'End If
            End If
        Next
        Dim lvi2 As New ListViewItem("explorer.exe")
        frmrunningapplication.ListView2.Items.Add(lvi2)

        '=============================================== start killing =======================================================

        For Each item As ListViewItem In frmrunningapplication.ListView2.Items
            If frmrunningapplication.ListView2.Items.Count > 0 Then
                item = frmrunningapplication.ListView2.Items.Item(0)

                'If item.SubItems(0).Text = "devenv" Then
                If item.SubItems(0).Text = "File Management System" Then
                    item.Remove()
                Else
                    For Each p As Process In Process.GetProcessesByName(item.SubItems(0).Text)
                        If frmrunningapplication.ListView2.Items.Count > 0 Then
                            Try
                                p.Kill()
                                item.Remove()
                            Catch ex As Exception
                                MessageBox.Show("'" & item.SubItems(0).Text & ".exe' needs to be close first.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                        End If
                    Next
                End If
            End If
        Next

        'MsgBox("The End")
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
        For Each bye As Process In Process.GetProcessesByName("devenv")
            bye.Kill()
        Next

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            button_logout.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class