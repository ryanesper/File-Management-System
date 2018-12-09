Public Class frmfiledetails

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

    Private Sub frmfiledetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '------- files properties ------
        txtitemname.Text = fname
        txttype.Text = ftype
        txtcreationtime.Text = flastmodified
        txtlat.Text = flastaccesstime
        txtlwt.Text = flastwritetime

        '----- folder properties -----
        txtitemname.Text = fname
        txtfoldertype.Text = ftype
        'txtfoldersize.Text = fsize
        txtfiles.Text = ffilenumber
        txtfolders.Text = ffoldernumber
        txtitems.Text = ftotalitems
        txtfoldercreationtime.Text = flastmodified
        txtfolderlat.Text = flastaccesstime
        txtfolderlwt.Text = flastwritetime

        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242e")
        txtitemname.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242e")
        'txtitemname.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        'txttype.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        'txtsize.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        'txtcreationtime.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        'txtlat.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        'txtlwt.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        foldersayz = 0
        fsize = 0
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Try
            If System.IO.File.Exists(getpathinpropertiesfordelete) Then
                My.Computer.FileSystem.DeleteFile(getpathinpropertiesfordelete, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
                If deleteiteminitemproperties = "main" Then
                    frmmain.listview.Items.Clear()
                    displayfilesandfolders()
                    spaceconsumed()
                    remainingspacee()
                    countfilesandfolders()
                ElseIf deleteiteminitemproperties = "explorer" Then
                    frmexplorer.explorerlistview.Items.Clear()
                    fileandfolderexplorer()
                    spaceconsumed()
                    remainingspacee()
                    countfilesandfoldersinexplorer()
                End If
                MessageBox.Show("File deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                My.Computer.FileSystem.DeleteDirectory(getpathinpropertiesfordelete, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
                If deleteiteminitemproperties = "main" Then
                    frmmain.listview.Items.Clear()
                    displayfilesandfolders()
                    spaceconsumed()
                    remainingspacee()
                    countfilesandfolders()
                ElseIf deleteiteminitemproperties = "explorer" Then
                    frmexplorer.explorerlistview.Items.Clear()
                    fileandfolderexplorer()
                    spaceconsumed()
                    remainingspacee()
                    countfilesandfoldersinexplorer()
                End If
                MessageBox.Show("Folder deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(Err.ToString)
        End Try

    End Sub
End Class