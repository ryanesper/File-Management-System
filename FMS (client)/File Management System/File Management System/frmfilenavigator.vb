Public Class frmfilenavigator

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

    'Private Sub filtercourse1(valuetosearch As String)

    '    Dim searchquery As String = "select * from students_account where course like '%" & valuetosearch & "%' and year = '" & cboyear.Text & "'"
    '    Dim command As New MySqlCommand(searchquery, con)
    '    Dim adapter As New MySqlDataAdapter(command)
    '    Dim table As New DataTable()

    '    adapter.Fill(table)

    '    dgrid_studentsacount.DataSource = table

    'End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    '    For Each item As String In My.Computer.FileSystem.GetFiles(combination, FileIO.SearchOption.SearchAllSubDirectories, TextBox1.Text.Contains(TextBox1.Text))
    '        'icons.Images.Add(Drawing.Icon.ExtractAssociatedIcon(item))
    '        ListView1.Items.Add(My.Computer.FileSystem.GetName(item))
    '        'listview.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
    '    Next
    'End Sub

 
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged

        If txtsearch.Text = "" Then
            listviewnavigator.Items.Clear()
        Else
            If cbofileorfolder.Text = "File" Then
                listviewnavigator.Items.Clear()
                For Each item As String In My.Computer.FileSystem.GetFiles(combination, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                    If item.Contains(txtsearch.Text) Then
                        listviewnavigator.Items.Add(My.Computer.FileSystem.GetName(item))
                    End If
                Next
            ElseIf cbofileorfolder.Text = "Folder" Then
                listviewnavigator.Items.Clear()
                For Each item As String In My.Computer.FileSystem.GetDirectories(combination, FileIO.SearchOption.SearchAllSubDirectories)
                    'icons.Images.Add(frmmain.GetShellIcon(item))
                    'ListView1.Items.Add(My.Computer.FileSystem.GetName(item), icons.Images.Count - 1)
                    If item.Contains(txtsearch.Text) Then
                        listviewnavigator.Items.Add(My.Computer.FileSystem.GetName(item))
                    End If
                Next
            Else
                listviewnavigator.Items.Clear()
            End If
        End If

    End Sub

    Private Sub cbofileorfolder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofileorfolder.SelectedIndexChanged
        txtsearch.Text = ""
        listviewnavigator.Items.Clear()
    End Sub

    Private Sub frmfilenavigator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbofileorfolder.Text = "File"
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        txtsearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        cbofileorfolder.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")
        listviewnavigator.BackColor = System.Drawing.ColorTranslator.FromHtml("#20242d")


    End Sub
End Class