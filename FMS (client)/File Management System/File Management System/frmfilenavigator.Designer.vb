<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfilenavigator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.listviewnavigator = New System.Windows.Forms.ListView()
        Me.cbofileorfolder = New System.Windows.Forms.ComboBox()
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'txtsearch
        '
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.White
        Me.txtsearch.Location = New System.Drawing.Point(12, 10)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(307, 22)
        Me.txtsearch.TabIndex = 0
        '
        'listviewnavigator
        '
        Me.listviewnavigator.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listviewnavigator.ForeColor = System.Drawing.Color.White
        Me.listviewnavigator.Location = New System.Drawing.Point(12, 38)
        Me.listviewnavigator.Name = "listviewnavigator"
        Me.listviewnavigator.Size = New System.Drawing.Size(394, 330)
        Me.listviewnavigator.TabIndex = 2
        Me.listviewnavigator.UseCompatibleStateImageBehavior = False
        Me.listviewnavigator.View = System.Windows.Forms.View.List
        '
        'cbofileorfolder
        '
        Me.cbofileorfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofileorfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbofileorfolder.ForeColor = System.Drawing.Color.White
        Me.cbofileorfolder.FormattingEnabled = True
        Me.cbofileorfolder.Items.AddRange(New Object() {"File", "Folder"})
        Me.cbofileorfolder.Location = New System.Drawing.Point(325, 11)
        Me.cbofileorfolder.Name = "cbofileorfolder"
        Me.cbofileorfolder.Size = New System.Drawing.Size(81, 21)
        Me.cbofileorfolder.TabIndex = 3
        '
        'icons
        '
        Me.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.icons.ImageSize = New System.Drawing.Size(16, 16)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmfilenavigator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 380)
        Me.Controls.Add(Me.cbofileorfolder)
        Me.Controls.Add(Me.listviewnavigator)
        Me.Controls.Add(Me.txtsearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmfilenavigator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Navigator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents listviewnavigator As System.Windows.Forms.ListView
    Friend WithEvents cbofileorfolder As System.Windows.Forms.ComboBox
    Friend WithEvents icons As System.Windows.Forms.ImageList
End Class
