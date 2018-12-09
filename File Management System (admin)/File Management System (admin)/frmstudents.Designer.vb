<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstudents))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_logout = New adminform_close.adminform_close()
        Me.btn_minimize = New adminform_minimize.adminform_minimize()
        Me.btn_students = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblnumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblyear = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbldepartment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.TextBox()
        Me.lblgender = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbllname = New System.Windows.Forms.TextBox()
        Me.lblmname = New System.Windows.Forms.TextBox()
        Me.lblfname = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.TextBox()
        Me.mypicture = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.fullname = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttotalstudents = New System.Windows.Forms.TextBox()
        Me.dgrid_studentsacount = New System.Windows.Forms.DataGridView()
        Me.btn_studentregistration = New System.Windows.Forms.Button()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btndirectories = New System.Windows.Forms.Button()
        Me.btninstructors = New System.Windows.Forms.Button()
        Me.btnmysubject = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.mypicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgrid_studentsacount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Gray
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(885, 144)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 40)
        Me.btn_delete.TabIndex = 13
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Transparent
        Me.btn_logout.BackgroundImage = CType(resources.GetObject("btn_logout.BackgroundImage"), System.Drawing.Image)
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(1307, 9)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(40, 40)
        Me.btn_logout.TabIndex = 56
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.BackgroundImage = CType(resources.GetObject("btn_minimize.BackgroundImage"), System.Drawing.Image)
        Me.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimize.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.Location = New System.Drawing.Point(1261, 19)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(40, 30)
        Me.btn_minimize.TabIndex = 55
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_students
        '
        Me.btn_students.BackColor = System.Drawing.Color.Gray
        Me.btn_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_students.ForeColor = System.Drawing.Color.White
        Me.btn_students.Location = New System.Drawing.Point(1237, 144)
        Me.btn_students.Name = "btn_students"
        Me.btn_students.Size = New System.Drawing.Size(80, 40)
        Me.btn_students.TabIndex = 59
        Me.btn_students.Text = "Refresh"
        Me.btn_students.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblemail)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.lbladdress)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblnumber)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblyear)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbldepartment)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbldate)
        Me.GroupBox1.Controls.Add(Me.lblgender)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbllname)
        Me.GroupBox1.Controls.Add(Me.lblmname)
        Me.GroupBox1.Controls.Add(Me.lblfname)
        Me.GroupBox1.Controls.Add(Me.lblid)
        Me.GroupBox1.Controls.Add(Me.mypicture)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(751, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 442)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(118, 400)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(12, 18)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(118, 355)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(12, 18)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(118, 330)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(12, 18)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(118, 305)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(12, 18)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(118, 280)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 18)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(118, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 18)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(118, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 18)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = ":"
        '
        'lblemail
        '
        Me.lblemail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(142, 356)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.ReadOnly = True
        Me.lblemail.Size = New System.Drawing.Size(406, 17)
        Me.lblemail.TabIndex = 98
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(59, 355)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(45, 18)
        Me.Email.TabIndex = 97
        Me.Email.Text = "Email"
        '
        'lbladdress
        '
        Me.lbladdress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbladdress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(142, 331)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.ReadOnly = True
        Me.lbladdress.Size = New System.Drawing.Size(406, 17)
        Me.lbladdress.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 330)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Address"
        '
        'lblnumber
        '
        Me.lblnumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumber.Location = New System.Drawing.Point(142, 306)
        Me.lblnumber.Name = "lblnumber"
        Me.lblnumber.ReadOnly = True
        Me.lblnumber.Size = New System.Drawing.Size(406, 17)
        Me.lblnumber.TabIndex = 94
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 18)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Cp Number"
        '
        'lblyear
        '
        Me.lblyear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblyear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.Location = New System.Drawing.Point(142, 281)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.ReadOnly = True
        Me.lblyear.Size = New System.Drawing.Size(406, 17)
        Me.lblyear.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(66, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Year"
        '
        'lbldepartment
        '
        Me.lbldepartment.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbldepartment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbldepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepartment.Location = New System.Drawing.Point(142, 256)
        Me.lbldepartment.Name = "lbldepartment"
        Me.lbldepartment.ReadOnly = True
        Me.lbldepartment.Size = New System.Drawing.Size(406, 17)
        Me.lbldepartment.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 18)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Regdate"
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbldate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(142, 401)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.ReadOnly = True
        Me.lbldate.Size = New System.Drawing.Size(406, 17)
        Me.lbldate.TabIndex = 87
        '
        'lblgender
        '
        Me.lblgender.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblgender.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(142, 231)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.ReadOnly = True
        Me.lblgender.Size = New System.Drawing.Size(406, 17)
        Me.lblgender.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 18)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Lastname       :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(218, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Middlename   :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Firstname       :"
        '
        'lbllname
        '
        Me.lbllname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbllname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbllname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.Location = New System.Drawing.Point(342, 151)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.ReadOnly = True
        Me.lbllname.Size = New System.Drawing.Size(206, 19)
        Me.lbllname.TabIndex = 81
        '
        'lblmname
        '
        Me.lblmname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblmname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblmname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmname.Location = New System.Drawing.Point(342, 122)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.ReadOnly = True
        Me.lblmname.Size = New System.Drawing.Size(206, 19)
        Me.lblmname.TabIndex = 80
        '
        'lblfname
        '
        Me.lblfname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.Location = New System.Drawing.Point(342, 94)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.ReadOnly = True
        Me.lblfname.Size = New System.Drawing.Size(206, 19)
        Me.lblfname.TabIndex = 79
        '
        'lblid
        '
        Me.lblid.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(213, 32)
        Me.lblid.Name = "lblid"
        Me.lblid.ReadOnly = True
        Me.lblid.Size = New System.Drawing.Size(335, 28)
        Me.lblid.TabIndex = 75
        Me.lblid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mypicture
        '
        Me.mypicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mypicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mypicture.Location = New System.Drawing.Point(1, 7)
        Me.mypicture.Name = "mypicture"
        Me.mypicture.Size = New System.Drawing.Size(200, 200)
        Me.mypicture.TabIndex = 14
        Me.mypicture.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(130, 444)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Label14"
        Me.Label14.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date Registered:"
        Me.Label7.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(560, 423)
        Me.ShapeContainer1.TabIndex = 78
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 211
        Me.LineShape2.X2 = 544
        Me.LineShape2.Y1 = 46
        Me.LineShape2.Y2 = 46
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 211
        Me.LineShape1.X2 = 544
        Me.LineShape1.Y1 = 14
        Me.LineShape1.Y2 = 14
        '
        'fullname
        '
        Me.fullname.AutoSize = True
        Me.fullname.BackColor = System.Drawing.Color.Transparent
        Me.fullname.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.fullname.Location = New System.Drawing.Point(12, 9)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(96, 24)
        Me.fullname.TabIndex = 63
        Me.fullname.Text = "fullname"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cbocourse)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 55)
        Me.GroupBox2.TabIndex = 75
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Department"
        '
        'cbocourse
        '
        Me.cbocourse.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbocourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbocourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Items.AddRange(New Object() {"", "BSIT", "BSED", "BSCRIM", "BSHRM", "BSBA"})
        Me.cbocourse.Location = New System.Drawing.Point(10, 19)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(183, 26)
        Me.cbocourse.TabIndex = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(45, 666)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 24)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Total Accounts :"
        '
        'txttotalstudents
        '
        Me.txttotalstudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalstudents.Location = New System.Drawing.Point(196, 663)
        Me.txttotalstudents.Name = "txttotalstudents"
        Me.txttotalstudents.ReadOnly = True
        Me.txttotalstudents.Size = New System.Drawing.Size(100, 29)
        Me.txttotalstudents.TabIndex = 78
        '
        'dgrid_studentsacount
        '
        Me.dgrid_studentsacount.AllowUserToAddRows = False
        Me.dgrid_studentsacount.AllowUserToDeleteRows = False
        Me.dgrid_studentsacount.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrid_studentsacount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrid_studentsacount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgrid_studentsacount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrid_studentsacount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrid_studentsacount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_studentsacount.GridColor = System.Drawing.Color.DarkGray
        Me.dgrid_studentsacount.Location = New System.Drawing.Point(45, 199)
        Me.dgrid_studentsacount.Name = "dgrid_studentsacount"
        Me.dgrid_studentsacount.ReadOnly = True
        Me.dgrid_studentsacount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgrid_studentsacount.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgrid_studentsacount.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgrid_studentsacount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrid_studentsacount.Size = New System.Drawing.Size(700, 434)
        Me.dgrid_studentsacount.TabIndex = 84
        '
        'btn_studentregistration
        '
        Me.btn_studentregistration.BackColor = System.Drawing.Color.Gray
        Me.btn_studentregistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_studentregistration.ForeColor = System.Drawing.Color.White
        Me.btn_studentregistration.Location = New System.Drawing.Point(751, 144)
        Me.btn_studentregistration.Name = "btn_studentregistration"
        Me.btn_studentregistration.Size = New System.Drawing.Size(128, 40)
        Me.btn_studentregistration.TabIndex = 85
        Me.btn_studentregistration.Text = "Student Registration"
        Me.btn_studentregistration.UseVisualStyleBackColor = False
        '
        'cboyear
        '
        Me.cboyear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboyear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Items.AddRange(New Object() {"", "1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cboyear.Location = New System.Drawing.Point(13, 19)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(177, 26)
        Me.cboyear.TabIndex = 86
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cboyear)
        Me.GroupBox4.Location = New System.Drawing.Point(256, 137)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 55)
        Me.GroupBox4.TabIndex = 87
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Year"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.settings
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(1215, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 88
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Silver
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 23
        Me.LineShape3.X2 = 23
        Me.LineShape3.Y1 = 708
        Me.LineShape3.Y2 = 129
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.Silver
        Me.LineShape5.BorderWidth = 2
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 22
        Me.LineShape5.X2 = 258
        Me.LineShape5.Y1 = 129
        Me.LineShape5.Y2 = 129
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.Silver
        Me.LineShape6.BorderWidth = 2
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 258
        Me.LineShape6.X2 = 258
        Me.LineShape6.Y1 = 65
        Me.LineShape6.Y2 = 130
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.Silver
        Me.LineShape8.BorderWidth = 2
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 258
        Me.LineShape8.X2 = 372
        Me.LineShape8.Y1 = 66
        Me.LineShape8.Y2 = 66
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Silver
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 371
        Me.LineShape4.X2 = 1339
        Me.LineShape4.Y1 = 129
        Me.LineShape4.Y2 = 129
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.Color.Silver
        Me.LineShape7.BorderWidth = 2
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 1339
        Me.LineShape7.X2 = 1339
        Me.LineShape7.Y1 = 708
        Me.LineShape7.Y2 = 128
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.Color.Silver
        Me.LineShape9.BorderWidth = 2
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 23
        Me.LineShape9.X2 = 1339
        Me.LineShape9.Y1 = 707
        Me.LineShape9.Y2 = 707
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.Color.Silver
        Me.LineShape10.BorderWidth = 2
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 371
        Me.LineShape10.X2 = 371
        Me.LineShape10.Y1 = 66
        Me.LineShape10.Y2 = 129
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape10, Me.LineShape9, Me.LineShape7, Me.LineShape4, Me.LineShape8, Me.LineShape6, Me.LineShape5, Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1378, 728)
        Me.ShapeContainer2.TabIndex = 89
        Me.ShapeContainer2.TabStop = False
        '
        'btndirectories
        '
        Me.btndirectories.BackColor = System.Drawing.Color.LightGray
        Me.btndirectories.FlatAppearance.BorderSize = 0
        Me.btndirectories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndirectories.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndirectories.ForeColor = System.Drawing.Color.DimGray
        Me.btndirectories.Location = New System.Drawing.Point(500, 68)
        Me.btndirectories.Name = "btndirectories"
        Me.btndirectories.Size = New System.Drawing.Size(110, 60)
        Me.btndirectories.TabIndex = 95
        Me.btndirectories.Text = "Directories"
        Me.btndirectories.UseVisualStyleBackColor = False
        '
        'btninstructors
        '
        Me.btninstructors.BackColor = System.Drawing.Color.LightGray
        Me.btninstructors.FlatAppearance.BorderSize = 0
        Me.btninstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninstructors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninstructors.ForeColor = System.Drawing.Color.DimGray
        Me.btninstructors.Location = New System.Drawing.Point(380, 68)
        Me.btninstructors.Name = "btninstructors"
        Me.btninstructors.Size = New System.Drawing.Size(110, 60)
        Me.btninstructors.TabIndex = 94
        Me.btninstructors.Text = "Instructors"
        Me.btninstructors.UseVisualStyleBackColor = False
        '
        'btnmysubject
        '
        Me.btnmysubject.BackColor = System.Drawing.Color.LightGray
        Me.btnmysubject.FlatAppearance.BorderSize = 0
        Me.btnmysubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmysubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmysubject.ForeColor = System.Drawing.Color.DimGray
        Me.btnmysubject.Location = New System.Drawing.Point(140, 68)
        Me.btnmysubject.Name = "btnmysubject"
        Me.btnmysubject.Size = New System.Drawing.Size(110, 60)
        Me.btnmysubject.TabIndex = 93
        Me.btnmysubject.Text = "My Subject"
        Me.btnmysubject.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(260, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 60)
        Me.Button3.TabIndex = 96
        Me.Button3.Text = "Students"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmstudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 728)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btndirectories)
        Me.Controls.Add(Me.btninstructors)
        Me.Controls.Add(Me.btnmysubject)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_studentregistration)
        Me.Controls.Add(Me.dgrid_studentsacount)
        Me.Controls.Add(Me.txttotalstudents)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_students)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_minimize)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1386, 728)
        Me.Name = "frmstudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmstudents"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.mypicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgrid_studentsacount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_logout As adminform_close.adminform_close
    Friend WithEvents btn_minimize As adminform_minimize.adminform_minimize
    Friend WithEvents btn_students As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents fullname As System.Windows.Forms.Label
    Friend WithEvents mypicture As System.Windows.Forms.PictureBox
    Friend WithEvents lblid As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbllname As System.Windows.Forms.TextBox
    Friend WithEvents lblmname As System.Windows.Forms.TextBox
    Friend WithEvents lblfname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.TextBox
    Friend WithEvents lblyear As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbldepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.TextBox
    Friend WithEvents Email As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txttotalstudents As System.Windows.Forms.TextBox
    Friend WithEvents dgrid_studentsacount As System.Windows.Forms.DataGridView
    Friend WithEvents btn_studentregistration As System.Windows.Forms.Button
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents cbocourse As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btndirectories As System.Windows.Forms.Button
    Friend WithEvents btninstructors As System.Windows.Forms.Button
    Friend WithEvents btnmysubject As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
