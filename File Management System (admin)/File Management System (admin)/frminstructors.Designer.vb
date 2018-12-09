<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminstructors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminstructors))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_logout = New adminform_close.adminform_close()
        Me.btn_minimize = New adminform_minimize.adminform_minimize()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_instructorregister = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fullname = New System.Windows.Forms.Label()
        Me.lblsubjects = New System.Windows.Forms.Label()
        Me.lblstudents = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgrid_instructorsstudents = New System.Windows.Forms.DataGridView()
        Me.dgrid_instructorssubjects = New System.Windows.Forms.DataGridView()
        Me.txtsched = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtstudents = New System.Windows.Forms.TextBox()
        Me.txtsubjects = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgrid_instructorsacount = New System.Windows.Forms.DataGridView()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.txttotalinstructor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btninstructors = New System.Windows.Forms.Button()
        Me.btndirectories = New System.Windows.Forms.Button()
        Me.btnstudents = New System.Windows.Forms.Button()
        Me.btnmysubject = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgrid_instructorsstudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrid_instructorssubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrid_instructorsacount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.Color.Gray
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.Location = New System.Drawing.Point(1239, 144)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(80, 40)
        Me.btnrefresh.TabIndex = 61
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Gray
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(803, 144)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 40)
        Me.btn_delete.TabIndex = 60
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_instructorregister
        '
        Me.btn_instructorregister.BackColor = System.Drawing.Color.Gray
        Me.btn_instructorregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_instructorregister.ForeColor = System.Drawing.Color.White
        Me.btn_instructorregister.Location = New System.Drawing.Point(673, 144)
        Me.btn_instructorregister.Name = "btn_instructorregister"
        Me.btn_instructorregister.Size = New System.Drawing.Size(124, 40)
        Me.btn_instructorregister.TabIndex = 62
        Me.btn_instructorregister.Text = "Instructor Registration"
        Me.btn_instructorregister.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(1239, 652)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
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
        Me.fullname.TabIndex = 64
        Me.fullname.Text = "fullname"
        '
        'lblsubjects
        '
        Me.lblsubjects.AutoSize = True
        Me.lblsubjects.BackColor = System.Drawing.Color.Transparent
        Me.lblsubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubjects.ForeColor = System.Drawing.Color.DimGray
        Me.lblsubjects.Location = New System.Drawing.Point(3, 16)
        Me.lblsubjects.Name = "lblsubjects"
        Me.lblsubjects.Size = New System.Drawing.Size(142, 18)
        Me.lblsubjects.TabIndex = 77
        Me.lblsubjects.Text = "Instructor's Subjects"
        '
        'lblstudents
        '
        Me.lblstudents.AutoSize = True
        Me.lblstudents.BackColor = System.Drawing.Color.Transparent
        Me.lblstudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudents.ForeColor = System.Drawing.Color.DimGray
        Me.lblstudents.Location = New System.Drawing.Point(3, 237)
        Me.lblstudents.Name = "lblstudents"
        Me.lblstudents.Size = New System.Drawing.Size(143, 18)
        Me.lblstudents.TabIndex = 78
        Me.lblstudents.Text = "Instructor's Students"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dgrid_instructorsstudents)
        Me.GroupBox2.Controls.Add(Me.dgrid_instructorssubjects)
        Me.GroupBox2.Controls.Add(Me.txtsched)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtstudents)
        Me.GroupBox2.Controls.Add(Me.txtsubjects)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblstudents)
        Me.GroupBox2.Controls.Add(Me.lblsubjects)
        Me.GroupBox2.Location = New System.Drawing.Point(673, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(646, 441)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        '
        'dgrid_instructorsstudents
        '
        Me.dgrid_instructorsstudents.AllowUserToAddRows = False
        Me.dgrid_instructorsstudents.AllowUserToDeleteRows = False
        Me.dgrid_instructorsstudents.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrid_instructorsstudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrid_instructorsstudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgrid_instructorsstudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrid_instructorsstudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrid_instructorsstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_instructorsstudents.GridColor = System.Drawing.Color.DarkGray
        Me.dgrid_instructorsstudents.Location = New System.Drawing.Point(6, 258)
        Me.dgrid_instructorsstudents.Name = "dgrid_instructorsstudents"
        Me.dgrid_instructorsstudents.ReadOnly = True
        Me.dgrid_instructorsstudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgrid_instructorsstudents.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgrid_instructorsstudents.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgrid_instructorsstudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrid_instructorsstudents.Size = New System.Drawing.Size(624, 178)
        Me.dgrid_instructorsstudents.TabIndex = 85
        '
        'dgrid_instructorssubjects
        '
        Me.dgrid_instructorssubjects.AllowUserToAddRows = False
        Me.dgrid_instructorssubjects.AllowUserToDeleteRows = False
        Me.dgrid_instructorssubjects.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrid_instructorssubjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrid_instructorssubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgrid_instructorssubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrid_instructorssubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgrid_instructorssubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_instructorssubjects.GridColor = System.Drawing.Color.DarkGray
        Me.dgrid_instructorssubjects.Location = New System.Drawing.Point(6, 37)
        Me.dgrid_instructorssubjects.Name = "dgrid_instructorssubjects"
        Me.dgrid_instructorssubjects.ReadOnly = True
        Me.dgrid_instructorssubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgrid_instructorssubjects.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgrid_instructorssubjects.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgrid_instructorssubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrid_instructorssubjects.Size = New System.Drawing.Size(624, 194)
        Me.dgrid_instructorssubjects.TabIndex = 84
        '
        'txtsched
        '
        Me.txtsched.ForeColor = System.Drawing.Color.Lime
        Me.txtsched.Location = New System.Drawing.Point(559, 14)
        Me.txtsched.Name = "txtsched"
        Me.txtsched.ReadOnly = True
        Me.txtsched.Size = New System.Drawing.Size(71, 20)
        Me.txtsched.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(298, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Subject(s) :"
        '
        'txtstudents
        '
        Me.txtstudents.ForeColor = System.Drawing.Color.Lime
        Me.txtstudents.Location = New System.Drawing.Point(559, 235)
        Me.txtstudents.Name = "txtstudents"
        Me.txtstudents.ReadOnly = True
        Me.txtstudents.Size = New System.Drawing.Size(71, 20)
        Me.txtstudents.TabIndex = 82
        '
        'txtsubjects
        '
        Me.txtsubjects.ForeColor = System.Drawing.Color.Lime
        Me.txtsubjects.Location = New System.Drawing.Point(383, 14)
        Me.txtsubjects.Name = "txtsubjects"
        Me.txtsubjects.ReadOnly = True
        Me.txtsubjects.Size = New System.Drawing.Size(71, 20)
        Me.txtsubjects.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(463, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Schedule(s) :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(507, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Total :"
        '
        'dgrid_instructorsacount
        '
        Me.dgrid_instructorsacount.AllowUserToAddRows = False
        Me.dgrid_instructorsacount.AllowUserToDeleteRows = False
        Me.dgrid_instructorsacount.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrid_instructorsacount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrid_instructorsacount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgrid_instructorsacount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrid_instructorsacount.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgrid_instructorsacount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_instructorsacount.GridColor = System.Drawing.Color.DarkGray
        Me.dgrid_instructorsacount.Location = New System.Drawing.Point(45, 199)
        Me.dgrid_instructorsacount.Name = "dgrid_instructorsacount"
        Me.dgrid_instructorsacount.ReadOnly = True
        Me.dgrid_instructorsacount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgrid_instructorsacount.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgrid_instructorsacount.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgrid_instructorsacount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrid_instructorsacount.Size = New System.Drawing.Size(622, 433)
        Me.dgrid_instructorsacount.TabIndex = 83
        '
        'cbosearch
        '
        Me.cbosearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbosearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Account ID", "Firstname", "Middlename", "Lastname"})
        Me.cbosearch.Location = New System.Drawing.Point(103, 158)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(166, 26)
        Me.cbosearch.TabIndex = 86
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Search"
        '
        'txtsearchbox
        '
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchbox.ForeColor = System.Drawing.Color.Gray
        Me.txtsearchbox.Location = New System.Drawing.Point(275, 157)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.Size = New System.Drawing.Size(237, 26)
        Me.txtsearchbox.TabIndex = 84
        '
        'txttotalinstructor
        '
        Me.txttotalinstructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalinstructor.Location = New System.Drawing.Point(196, 663)
        Me.txttotalinstructor.Name = "txttotalinstructor"
        Me.txttotalinstructor.ReadOnly = True
        Me.txttotalinstructor.Size = New System.Drawing.Size(100, 29)
        Me.txttotalinstructor.TabIndex = 88
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
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Total Accounts :"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.settings
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(1215, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(40, 40)
        Me.Button6.TabIndex = 89
        Me.Button6.UseVisualStyleBackColor = False
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
        Me.LineShape5.X2 = 378
        Me.LineShape5.Y1 = 129
        Me.LineShape5.Y2 = 129
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.Silver
        Me.LineShape6.BorderWidth = 2
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 378
        Me.LineShape6.X2 = 378
        Me.LineShape6.Y1 = 65
        Me.LineShape6.Y2 = 130
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.Silver
        Me.LineShape8.BorderWidth = 2
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 378
        Me.LineShape8.X2 = 492
        Me.LineShape8.Y1 = 66
        Me.LineShape8.Y2 = 66
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.Color.Silver
        Me.LineShape10.BorderWidth = 2
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 491
        Me.LineShape10.X2 = 491
        Me.LineShape10.Y1 = 66
        Me.LineShape10.Y2 = 129
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Silver
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 491
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape9, Me.LineShape7, Me.LineShape4, Me.LineShape10, Me.LineShape8, Me.LineShape6, Me.LineShape5, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1378, 728)
        Me.ShapeContainer1.TabIndex = 90
        Me.ShapeContainer1.TabStop = False
        '
        'btninstructors
        '
        Me.btninstructors.BackColor = System.Drawing.Color.Transparent
        Me.btninstructors.Enabled = False
        Me.btninstructors.FlatAppearance.BorderSize = 0
        Me.btninstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninstructors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninstructors.ForeColor = System.Drawing.Color.Black
        Me.btninstructors.Location = New System.Drawing.Point(380, 68)
        Me.btninstructors.Name = "btninstructors"
        Me.btninstructors.Size = New System.Drawing.Size(110, 60)
        Me.btninstructors.TabIndex = 100
        Me.btninstructors.Text = "Instructors"
        Me.btninstructors.UseVisualStyleBackColor = False
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
        Me.btndirectories.TabIndex = 99
        Me.btndirectories.Text = "Directories"
        Me.btndirectories.UseVisualStyleBackColor = False
        '
        'btnstudents
        '
        Me.btnstudents.BackColor = System.Drawing.Color.LightGray
        Me.btnstudents.FlatAppearance.BorderSize = 0
        Me.btnstudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstudents.ForeColor = System.Drawing.Color.DimGray
        Me.btnstudents.Location = New System.Drawing.Point(260, 68)
        Me.btnstudents.Name = "btnstudents"
        Me.btnstudents.Size = New System.Drawing.Size(110, 60)
        Me.btnstudents.TabIndex = 98
        Me.btnstudents.Text = "Students"
        Me.btnstudents.UseVisualStyleBackColor = False
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
        Me.btnmysubject.TabIndex = 97
        Me.btnmysubject.Text = "My Subject"
        Me.btnmysubject.UseVisualStyleBackColor = False
        '
        'frminstructors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 728)
        Me.Controls.Add(Me.btninstructors)
        Me.Controls.Add(Me.btndirectories)
        Me.Controls.Add(Me.btnstudents)
        Me.Controls.Add(Me.btnmysubject)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txttotalinstructor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbosearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsearchbox)
        Me.Controls.Add(Me.dgrid_instructorsacount)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_instructorregister)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_minimize)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1386, 728)
        Me.Name = "frminstructors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructors"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgrid_instructorsstudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrid_instructorssubjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrid_instructorsacount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_logout As adminform_close.adminform_close
    Friend WithEvents btn_minimize As adminform_minimize.adminform_minimize
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_instructorregister As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents fullname As System.Windows.Forms.Label
    Friend WithEvents lblsubjects As System.Windows.Forms.Label
    Friend WithEvents lblstudents As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtstudents As System.Windows.Forms.TextBox
    Friend WithEvents txtsubjects As System.Windows.Forms.TextBox
    Friend WithEvents txtsched As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgrid_instructorsacount As System.Windows.Forms.DataGridView
    Friend WithEvents dgrid_instructorsstudents As System.Windows.Forms.DataGridView
    Friend WithEvents dgrid_instructorssubjects As System.Windows.Forms.DataGridView
    Friend WithEvents cbosearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsearchbox As System.Windows.Forms.TextBox
    Friend WithEvents txttotalinstructor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents btninstructors As System.Windows.Forms.Button
    Friend WithEvents btndirectories As System.Windows.Forms.Button
    Friend WithEvents btnstudents As System.Windows.Forms.Button
    Friend WithEvents btnmysubject As System.Windows.Forms.Button
End Class
