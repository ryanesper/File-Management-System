<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcopyandpaste
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
        Me.copyandpastelistview1 = New System.Windows.Forms.ListView()
        Me.copyandpastelistview2 = New System.Windows.Forms.ListView()
        Me.btn_removeto1 = New System.Windows.Forms.Button()
        Me.btn_removeto2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'copyandpastelistview1
        '
        Me.copyandpastelistview1.FullRowSelect = True
        Me.copyandpastelistview1.Location = New System.Drawing.Point(12, 12)
        Me.copyandpastelistview1.Name = "copyandpastelistview1"
        Me.copyandpastelistview1.Size = New System.Drawing.Size(1026, 325)
        Me.copyandpastelistview1.TabIndex = 0
        Me.copyandpastelistview1.UseCompatibleStateImageBehavior = False
        Me.copyandpastelistview1.View = System.Windows.Forms.View.Details
        '
        'copyandpastelistview2
        '
        Me.copyandpastelistview2.Enabled = False
        Me.copyandpastelistview2.FullRowSelect = True
        Me.copyandpastelistview2.Location = New System.Drawing.Point(12, 343)
        Me.copyandpastelistview2.Name = "copyandpastelistview2"
        Me.copyandpastelistview2.Size = New System.Drawing.Size(1026, 325)
        Me.copyandpastelistview2.TabIndex = 1
        Me.copyandpastelistview2.UseCompatibleStateImageBehavior = False
        Me.copyandpastelistview2.View = System.Windows.Forms.View.Details
        '
        'btn_removeto1
        '
        Me.btn_removeto1.Location = New System.Drawing.Point(1044, 343)
        Me.btn_removeto1.Name = "btn_removeto1"
        Me.btn_removeto1.Size = New System.Drawing.Size(86, 23)
        Me.btn_removeto1.TabIndex = 2
        Me.btn_removeto1.Text = "Remove to 1"
        Me.btn_removeto1.UseVisualStyleBackColor = True
        '
        'btn_removeto2
        '
        Me.btn_removeto2.Location = New System.Drawing.Point(1044, 312)
        Me.btn_removeto2.Name = "btn_removeto2"
        Me.btn_removeto2.Size = New System.Drawing.Size(86, 23)
        Me.btn_removeto2.TabIndex = 3
        Me.btn_removeto2.Text = "Remove to 2"
        Me.btn_removeto2.UseVisualStyleBackColor = True
        '
        'frmcopyandpaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 678)
        Me.Controls.Add(Me.btn_removeto2)
        Me.Controls.Add(Me.btn_removeto1)
        Me.Controls.Add(Me.copyandpastelistview2)
        Me.Controls.Add(Me.copyandpastelistview1)
        Me.DoubleBuffered = True
        Me.Name = "frmcopyandpaste"
        Me.Text = "frmcopyandpaste"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents copyandpastelistview1 As System.Windows.Forms.ListView
    Friend WithEvents copyandpastelistview2 As System.Windows.Forms.ListView
    Friend WithEvents btn_removeto1 As System.Windows.Forms.Button
    Friend WithEvents btn_removeto2 As System.Windows.Forms.Button
End Class
