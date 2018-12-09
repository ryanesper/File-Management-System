<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudentsregistration
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtcfpassword = New System.Windows.Forms.TextBox()
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtid
        '
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(172, 96)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(250, 17)
        Me.txtid.TabIndex = 1
        Me.txtid.Text = "Account ID"
        '
        'txtnumber
        '
        Me.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber.Location = New System.Drawing.Point(26, 374)
        Me.txtnumber.MaxLength = 60
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(250, 17)
        Me.txtnumber.TabIndex = 6
        Me.txtnumber.Text = "Cellphone Number"
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(26, 481)
        Me.txtemail.MaxLength = 60
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(549, 17)
        Me.txtemail.TabIndex = 8
        Me.txtemail.Text = "Email"
        '
        'txtcfpassword
        '
        Me.txtcfpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcfpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcfpassword.Location = New System.Drawing.Point(325, 374)
        Me.txtcfpassword.Name = "txtcfpassword"
        Me.txtcfpassword.Size = New System.Drawing.Size(250, 17)
        Me.txtcfpassword.TabIndex = 13
        Me.txtcfpassword.Text = "Confirm Password"
        '
        'cbocourse
        '
        Me.cbocourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Items.AddRange(New Object() {"BSIT", "BSED", "BSCRIM", "BSHRM", "BSBA"})
        Me.cbocourse.Location = New System.Drawing.Point(324, 150)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(262, 26)
        Me.cbocourse.TabIndex = 9
        Me.cbocourse.Text = "Department"
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(26, 429)
        Me.txtaddress.MaxLength = 60
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(549, 17)
        Me.txtaddress.TabIndex = 7
        Me.txtaddress.Text = "Address"
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(496, 548)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(90, 35)
        Me.btnclear.TabIndex = 16
        Me.btnclear.Text = "Close"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Location = New System.Drawing.Point(12, 548)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(90, 35)
        Me.btnadd.TabIndex = 14
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(325, 321)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(250, 17)
        Me.txtpassword.TabIndex = 12
        Me.txtpassword.Text = "Password"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(269, 260)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(0, 24)
        Me.txtusername.TabIndex = 49
        Me.txtusername.Text = "Username"
        '
        'txtlname
        '
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(25, 267)
        Me.txtlname.MaxLength = 10
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(250, 17)
        Me.txtlname.TabIndex = 4
        Me.txtlname.Text = "Last Name"
        '
        'txtmname
        '
        Me.txtmname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(25, 210)
        Me.txtmname.MaxLength = 10
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(250, 17)
        Me.txtmname.TabIndex = 3
        Me.txtmname.Text = "Middle Name"
        '
        'txtfname
        '
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(25, 154)
        Me.txtfname.MaxLength = 10
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(250, 17)
        Me.txtfname.TabIndex = 2
        Me.txtfname.Text = "First Name"
        '
        'cboyear
        '
        Me.cboyear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cboyear.Location = New System.Drawing.Point(324, 207)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(262, 26)
        Me.cboyear.TabIndex = 10
        Me.cboyear.Text = "Year"
        '
        'txtuser
        '
        Me.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(325, 266)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(251, 19)
        Me.txtuser.TabIndex = 11
        Me.txtuser.Text = "Username"
        '
        'cbogender
        '
        Me.cbogender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbogender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(25, 317)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(262, 26)
        Me.cbogender.TabIndex = 5
        Me.cbogender.Text = "Gender"
        '
        'btn_clear
        '
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Location = New System.Drawing.Point(108, 548)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(90, 35)
        Me.btn_clear.TabIndex = 15
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'frmstudentsregistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.Untitled_11
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.cboyear)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtcfpassword)
        Me.Controls.Add(Me.cbocourse)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtfname)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(600, 600)
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "frmstudentsregistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmstudentsregistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtcfpassword As System.Windows.Forms.TextBox
    Friend WithEvents cbocourse As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
End Class
