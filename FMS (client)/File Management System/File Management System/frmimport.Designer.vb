<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmimport
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
        Me.exportlistview = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'exportlistview
        '
        Me.exportlistview.Location = New System.Drawing.Point(12, 12)
        Me.exportlistview.Name = "exportlistview"
        Me.exportlistview.Size = New System.Drawing.Size(1000, 400)
        Me.exportlistview.TabIndex = 0
        Me.exportlistview.UseCompatibleStateImageBehavior = False
        '
        'frmexport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 497)
        Me.Controls.Add(Me.exportlistview)
        Me.DoubleBuffered = True
        Me.Name = "frmexport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmexport"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exportlistview As System.Windows.Forms.ListView
End Class
