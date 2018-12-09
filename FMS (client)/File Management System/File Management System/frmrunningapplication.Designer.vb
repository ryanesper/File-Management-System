<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrunningapplication
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
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnprojectname = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(12, 192)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(915, 166)
        Me.ListView2.TabIndex = 6
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(915, 174)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(330, 387)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(153, 63)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Kill"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(489, 387)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(153, 63)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Restart"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(171, 387)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 63)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Transter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 63)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Get"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnprojectname
        '
        Me.btnprojectname.Location = New System.Drawing.Point(933, 12)
        Me.btnprojectname.Name = "btnprojectname"
        Me.btnprojectname.Size = New System.Drawing.Size(46, 29)
        Me.btnprojectname.TabIndex = 13
        Me.btnprojectname.Text = "Get"
        Me.btnprojectname.UseVisualStyleBackColor = True
        '
        'frmrunningapplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.btnprojectname)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.DoubleBuffered = True
        Me.Name = "frmrunningapplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmrunningapplication"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnprojectname As System.Windows.Forms.Button
End Class
