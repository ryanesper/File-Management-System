<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudentregistration
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
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtcfpassword = New System.Windows.Forms.TextBox()
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbogender
        '
        Me.cbogender.BackColor = System.Drawing.SystemColors.Window
        Me.cbogender.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbogender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(25, 317)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(261, 26)
        Me.cbogender.TabIndex = 60
        Me.cbogender.Text = "Gender"
        '
        'txtid
        '
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(173, 96)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(250, 17)
        Me.txtid.TabIndex = 59
        Me.txtid.Text = "Account ID"
        '
        'txtnumber
        '
        Me.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber.Location = New System.Drawing.Point(25, 373)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(250, 17)
        Me.txtnumber.TabIndex = 58
        Me.txtnumber.Text = "Cellphone Number"
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(25, 481)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(550, 17)
        Me.txtemail.TabIndex = 57
        Me.txtemail.Text = "Email"
        '
        'txtcfpassword
        '
        Me.txtcfpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcfpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcfpassword.Location = New System.Drawing.Point(325, 373)
        Me.txtcfpassword.Name = "txtcfpassword"
        Me.txtcfpassword.Size = New System.Drawing.Size(250, 17)
        Me.txtcfpassword.TabIndex = 56
        Me.txtcfpassword.Text = "Confirm Password"
        '
        'cbocourse
        '
        Me.cbocourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Items.AddRange(New Object() {"BSIT", "BSED", "BSCRIM", "BSHRM", "BSBA"})
        Me.cbocourse.Location = New System.Drawing.Point(325, 150)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(260, 26)
        Me.cbocourse.TabIndex = 55
        Me.cbocourse.Text = "Department"
        '
        'cboyear
        '
        Me.cboyear.BackColor = System.Drawing.SystemColors.Window
        Me.cboyear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cboyear.Location = New System.Drawing.Point(325, 207)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(260, 26)
        Me.cboyear.TabIndex = 54
        Me.cboyear.Text = "Year"
        '
        'txtaddress
        '
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(25, 428)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(550, 17)
        Me.txtaddress.TabIndex = 53
        Me.txtaddress.Text = "Address"
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Location = New System.Drawing.Point(488, 539)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(97, 37)
        Me.btnclear.TabIndex = 52
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Location = New System.Drawing.Point(385, 539)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(97, 37)
        Me.btnadd.TabIndex = 46
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(325, 320)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(250, 17)
        Me.txtpassword.TabIndex = 51
        Me.txtpassword.Text = "Password"
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(325, 267)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(250, 17)
        Me.txtusername.TabIndex = 50
        Me.txtusername.Text = "Username"
        '
        'txtlname
        '
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(25, 267)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(250, 17)
        Me.txtlname.TabIndex = 49
        Me.txtlname.Text = "Last Name"
        '
        'txtmname
        '
        Me.txtmname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(25, 210)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(250, 17)
        Me.txtmname.TabIndex = 48
        Me.txtmname.Text = "Middle Name"
        '
        'txtfname
        '
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(25, 153)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(250, 17)
        Me.txtfname.TabIndex = 47
        Me.txtfname.Text = "First Name"
        '
        'frmstudentregistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.Untitled_1
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtcfpassword)
        Me.Controls.Add(Me.cbocourse)
        Me.Controls.Add(Me.cboyear)
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
        Me.Name = "frmstudentregistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmstudentregistration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtcfpassword As System.Windows.Forms.TextBox
    Friend WithEvents cbocourse As System.Windows.Forms.ComboBox
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
End Class
