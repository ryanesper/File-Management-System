<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btn_login = New loginbutton.loginbutton()
        Me.Loginclose1 = New loginclose.loginclose()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mypicture = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.Loginminimize1 = New loginminize.loginminimize()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtpassword.Location = New System.Drawing.Point(204, 299)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(141, 14)
        Me.txtpassword.TabIndex = 9
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtusername.Location = New System.Drawing.Point(204, 254)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(141, 15)
        Me.txtusername.TabIndex = 8
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BackgroundImage = CType(resources.GetObject("btn_login.BackgroundImage"), System.Drawing.Image)
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(325, 331)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(35, 35)
        Me.btn_login.TabIndex = 12
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Loginclose1
        '
        Me.Loginclose1.BackColor = System.Drawing.Color.Transparent
        Me.Loginclose1.BackgroundImage = CType(resources.GetObject("Loginclose1.BackgroundImage"), System.Drawing.Image)
        Me.Loginclose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Loginclose1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Loginclose1.FlatAppearance.BorderSize = 0
        Me.Loginclose1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Loginclose1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Loginclose1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Loginclose1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginclose1.Location = New System.Drawing.Point(479, 124)
        Me.Loginclose1.Name = "Loginclose1"
        Me.Loginclose1.Size = New System.Drawing.Size(15, 15)
        Me.Loginclose1.TabIndex = 14
        Me.Loginclose1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(227, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Last User"
        Me.Label1.Visible = False
        '
        'mypicture
        '
        Me.mypicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mypicture.BorderColor = System.Drawing.Color.White
        Me.mypicture.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.mypicture.Location = New System.Drawing.Point(183, 24)
        Me.mypicture.Name = "mypicture"
        Me.mypicture.Size = New System.Drawing.Size(140, 140)
        Me.mypicture.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.mypicture})
        Me.ShapeContainer1.Size = New System.Drawing.Size(500, 400)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'lblfullname
        '
        Me.lblfullname.BackColor = System.Drawing.Color.Transparent
        Me.lblfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.Color.White
        Me.lblfullname.Location = New System.Drawing.Point(141, 173)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(218, 20)
        Me.lblfullname.TabIndex = 19
        Me.lblfullname.Text = "Name"
        Me.lblfullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblfullname.Visible = False
        '
        'Loginminimize1
        '
        Me.Loginminimize1.BackColor = System.Drawing.Color.Transparent
        Me.Loginminimize1.BackgroundImage = CType(resources.GetObject("Loginminimize1.BackgroundImage"), System.Drawing.Image)
        Me.Loginminimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Loginminimize1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Loginminimize1.FlatAppearance.BorderSize = 0
        Me.Loginminimize1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Loginminimize1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Loginminimize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Loginminimize1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginminimize1.Location = New System.Drawing.Point(458, 128)
        Me.Loginminimize1.Name = "Loginminimize1"
        Me.Loginminimize1.Size = New System.Drawing.Size(15, 10)
        Me.Loginminimize1.TabIndex = 13
        Me.Loginminimize1.UseVisualStyleBackColor = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.File_Management_System.My.Resources.Resources.login_forn__client_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 400)
        Me.Controls.Add(Me.lblfullname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Loginclose1)
        Me.Controls.Add(Me.Loginminimize1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(500, 400)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmlogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As loginbutton.loginbutton
    Friend WithEvents Loginclose1 As loginclose.loginclose
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mypicture As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblfullname As System.Windows.Forms.Label
    Friend WithEvents Loginminimize1 As loginminize.loginminimize
End Class
