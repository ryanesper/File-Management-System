Public Class frmrunningapplication

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        ListView1.Columns.Add("Programs", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Full Path", 800, HorizontalAlignment.Left)
        ListView1.FullRowSelect = True
        ListView1.View = View.Details

        For Each proc As Process In Process.GetProcesses
            If proc.MainWindowTitle <> "" Then
                Dim lvi As New ListViewItem(proc.ProcessName)
                lvi.SubItems.Add(proc.MainModule.FileName)
                ListView1.Items.Add(lvi)
            End If
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ListView2.Items.Clear()
        ListView2.Columns.Clear()
        ListView2.Columns.Add("Programs", 200, HorizontalAlignment.Left)
        ListView2.Columns.Add("Full Path", 800, HorizontalAlignment.Left)
        ListView2.FullRowSelect = True
        ListView2.View = View.Details

        For Each item As ListViewItem In ListView1.Items
            If ListView1.Items.Count > 0 Then
                item = ListView1.Items.Item(0)
                item.Remove()

                Dim lvi As New ListViewItem(item.SubItems(0).Text & ".exe")
                lvi.SubItems.Add(item.SubItems(1).Text)
                'If item.SubItems(0).Text = "devenv" Then

                'Else
                ListView2.Items.Add(lvi)
                'End If
            End If
        Next
        Dim lvi2 As New ListViewItem("explorer")
        ListView2.Items.Add(lvi2)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each item As ListViewItem In ListView2.Items
            If ListView2.Items.Count > 0 Then
                item = ListView2.Items.Item(0)

                If item.SubItems(0).Text = "devenv" Then
                    item.Remove()
                Else
                    For Each p As Process In Process.GetProcessesByName(item.SubItems(0).Text)
                        If ListView2.Items.Count > 0 Then
                            Try
                                p.Kill()
                                item.Remove()
                            Catch ex As Exception
                                MsgBox("Close " & item.SubItems(0).Text & " to logout successfully.")
                                Exit Sub
                            End Try
                        End If
                    Next
                End If
            End If
        Next

        Button6.PerformClick()
        For Each bye As Process In Process.GetProcessesByName("devenv")
            bye.Kill()
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
    End Sub

    Private Sub frmrunningapplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnprojectname_Click(sender As Object, e As EventArgs) Handles btnprojectname.Click
        MsgBox(My.Application.Info.AssemblyName)
    End Sub
End Class