Public Class frmcopyandpaste


    Private Sub btn_removeto1_Click(sender As Object, e As EventArgs) Handles btn_removeto1.Click

        copyandpastelistview2.Enabled = False
        copyandpastelistview1.Items.Clear()
        copyandpastelistview1.Columns.Clear()
        copyandpastelistview1.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
        copyandpastelistview1.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
        For Each item As ListViewItem In copyandpastelistview2.Items
            item = copyandpastelistview2.Items.Item(0)
            Dim lvi As New ListViewItem(item.SubItems(0).Text)
            lvi.SubItems.Add(item.SubItems(1).Text)
            copyandpastelistview1.Items.Add(lvi)
            item.Remove()
        Next

    End Sub

    Private Sub copyandpastelistview1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles copyandpastelistview1.SelectedIndexChanged

    End Sub

    Private Sub btn_removeto2_Click(sender As Object, e As EventArgs) Handles btn_removeto2.Click

        copyandpastelistview1.Enabled = False
        copyandpastelistview2.Items.Clear()
        copyandpastelistview2.Columns.Clear()
        copyandpastelistview2.Columns.Add("Item Name", 100, HorizontalAlignment.Left)
        copyandpastelistview2.Columns.Add("Item Location ", 900, HorizontalAlignment.Left)
        For Each item As ListViewItem In copyandpastelistview1.Items
            item = copyandpastelistview1.Items.Item(0)
            Dim lvi As New ListViewItem(item.SubItems(0).Text)
            lvi.SubItems.Add(item.SubItems(1).Text)
            copyandpastelistview2.Items.Add(lvi)
            item.Remove()
        Next

    End Sub
End Class