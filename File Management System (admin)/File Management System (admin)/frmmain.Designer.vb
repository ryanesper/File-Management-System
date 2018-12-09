<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_refreshmysubjects = New System.Windows.Forms.Button()
        Me.fullname = New System.Windows.Forms.Label()
        Me.btn_addstudent = New System.Windows.Forms.Button()
        Me.btn_addsubject = New System.Windows.Forms.Button()
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        Me.listview = New System.Windows.Forms.ListView()
        Me.btn_deletestudents = New System.Windows.Forms.Button()
        Me.btn_deletesubject = New System.Windows.Forms.Button()
        Me.btn_minimize = New adminform_minimize.adminform_minimize()
        Me.btn_logout = New adminform_close.adminform_close()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_studentregistration = New System.Windows.Forms.Button()
        Me.txtsearchbox = New System.Windows.Forms.TextBox()
        Me.cbosubject = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgrid_mystudents = New System.Windows.Forms.DataGridView()
        Me.cbosday = New System.Windows.Forms.ComboBox()
        Me.cbostime = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ovalpicture = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdescription = New System.Windows.Forms.Label()
        Me.cbosearch = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnstudents = New System.Windows.Forms.Button()
        Me.btninstructors = New System.Windows.Forms.Button()
        Me.btndirectories = New System.Windows.Forms.Button()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrid_mystudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_refreshmysubjects
        '
        Me.btn_refreshmysubjects.BackColor = System.Drawing.Color.Gray
        Me.btn_refreshmysubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refreshmysubjects.ForeColor = System.Drawing.Color.White
        Me.btn_refreshmysubjects.Location = New System.Drawing.Point(1244, 145)
        Me.btn_refreshmysubjects.Name = "btn_refreshmysubjects"
        Me.btn_refreshmysubjects.Size = New System.Drawing.Size(75, 40)
        Me.btn_refreshmysubjects.TabIndex = 49
        Me.btn_refreshmysubjects.Text = "Refresh"
        Me.btn_refreshmysubjects.UseVisualStyleBackColor = False
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
        Me.fullname.TabIndex = 44
        Me.fullname.Text = "fullname"
        '
        'btn_addstudent
        '
        Me.btn_addstudent.BackColor = System.Drawing.Color.Gray
        Me.btn_addstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addstudent.ForeColor = System.Drawing.Color.White
        Me.btn_addstudent.Location = New System.Drawing.Point(807, 145)
        Me.btn_addstudent.Name = "btn_addstudent"
        Me.btn_addstudent.Size = New System.Drawing.Size(93, 40)
        Me.btn_addstudent.TabIndex = 47
        Me.btn_addstudent.Text = "Add Student"
        Me.btn_addstudent.UseVisualStyleBackColor = False
        '
        'btn_addsubject
        '
        Me.btn_addsubject.BackColor = System.Drawing.Color.Gray
        Me.btn_addsubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addsubject.ForeColor = System.Drawing.Color.White
        Me.btn_addsubject.Location = New System.Drawing.Point(1023, 145)
        Me.btn_addsubject.Name = "btn_addsubject"
        Me.btn_addsubject.Size = New System.Drawing.Size(90, 40)
        Me.btn_addsubject.TabIndex = 46
        Me.btn_addsubject.Text = "Add Subject"
        Me.btn_addsubject.UseVisualStyleBackColor = False
        '
        'icons
        '
        Me.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.icons.ImageSize = New System.Drawing.Size(32, 32)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'listview
        '
        Me.listview.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.listview.BackgroundImageTiled = True
        Me.listview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.listview.LargeImageList = Me.icons
        Me.listview.Location = New System.Drawing.Point(6, 11)
        Me.listview.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.listview.Name = "listview"
        Me.listview.Size = New System.Drawing.Size(634, 425)
        Me.listview.TabIndex = 50
        Me.listview.UseCompatibleStateImageBehavior = False
        '
        'btn_deletestudents
        '
        Me.btn_deletestudents.BackColor = System.Drawing.Color.Gray
        Me.btn_deletestudents.Enabled = False
        Me.btn_deletestudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletestudents.ForeColor = System.Drawing.Color.White
        Me.btn_deletestudents.Location = New System.Drawing.Point(906, 145)
        Me.btn_deletestudents.Name = "btn_deletestudents"
        Me.btn_deletestudents.Size = New System.Drawing.Size(111, 40)
        Me.btn_deletestudents.TabIndex = 52
        Me.btn_deletestudents.Text = "Remove Student"
        Me.btn_deletestudents.UseVisualStyleBackColor = False
        '
        'btn_deletesubject
        '
        Me.btn_deletesubject.BackColor = System.Drawing.Color.Gray
        Me.btn_deletesubject.Enabled = False
        Me.btn_deletesubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletesubject.ForeColor = System.Drawing.Color.White
        Me.btn_deletesubject.Location = New System.Drawing.Point(1119, 145)
        Me.btn_deletesubject.Name = "btn_deletesubject"
        Me.btn_deletesubject.Size = New System.Drawing.Size(119, 40)
        Me.btn_deletesubject.TabIndex = 51
        Me.btn_deletesubject.Text = "Remove this Subject"
        Me.btn_deletesubject.UseVisualStyleBackColor = False
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
        Me.btn_minimize.TabIndex = 53
        Me.btn_minimize.UseVisualStyleBackColor = False
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
        Me.btn_logout.TabIndex = 54
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.listview)
        Me.GroupBox1.Location = New System.Drawing.Point(673, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 441)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'btn_studentregistration
        '
        Me.btn_studentregistration.BackColor = System.Drawing.Color.Gray
        Me.btn_studentregistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_studentregistration.ForeColor = System.Drawing.Color.White
        Me.btn_studentregistration.Location = New System.Drawing.Point(673, 145)
        Me.btn_studentregistration.Name = "btn_studentregistration"
        Me.btn_studentregistration.Size = New System.Drawing.Size(128, 40)
        Me.btn_studentregistration.TabIndex = 63
        Me.btn_studentregistration.Text = "Student Registration"
        Me.btn_studentregistration.UseVisualStyleBackColor = False
        '
        'txtsearchbox
        '
        Me.txtsearchbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchbox.ForeColor = System.Drawing.Color.Gray
        Me.txtsearchbox.Location = New System.Drawing.Point(275, 159)
        Me.txtsearchbox.Name = "txtsearchbox"
        Me.txtsearchbox.ReadOnly = True
        Me.txtsearchbox.Size = New System.Drawing.Size(237, 26)
        Me.txtsearchbox.TabIndex = 64
        '
        'cbosubject
        '
        Me.cbosubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosubject.DropDownWidth = 250
        Me.cbosubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbosubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubject.FormattingEnabled = True
        Me.cbosubject.Location = New System.Drawing.Point(45, 658)
        Me.cbosubject.MaxDropDownItems = 4
        Me.cbosubject.Name = "cbosubject"
        Me.cbosubject.Size = New System.Drawing.Size(250, 28)
        Me.cbosubject.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Search"
        '
        'dgrid_mystudents
        '
        Me.dgrid_mystudents.AllowUserToAddRows = False
        Me.dgrid_mystudents.AllowUserToDeleteRows = False
        Me.dgrid_mystudents.BackgroundColor = System.Drawing.Color.Silver
        Me.dgrid_mystudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgrid_mystudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgrid_mystudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrid_mystudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgrid_mystudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid_mystudents.GridColor = System.Drawing.Color.DarkGray
        Me.dgrid_mystudents.Location = New System.Drawing.Point(45, 199)
        Me.dgrid_mystudents.Name = "dgrid_mystudents"
        Me.dgrid_mystudents.ReadOnly = True
        Me.dgrid_mystudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgrid_mystudents.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgrid_mystudents.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgrid_mystudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrid_mystudents.Size = New System.Drawing.Size(622, 433)
        Me.dgrid_mystudents.TabIndex = 73
        '
        'cbosday
        '
        Me.cbosday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosday.Enabled = False
        Me.cbosday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbosday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosday.FormattingEnabled = True
        Me.cbosday.Location = New System.Drawing.Point(786, 658)
        Me.cbosday.Name = "cbosday"
        Me.cbosday.Size = New System.Drawing.Size(231, 28)
        Me.cbosday.TabIndex = 74
        '
        'cbostime
        '
        Me.cbostime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostime.Enabled = False
        Me.cbostime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbostime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostime.FormattingEnabled = True
        Me.cbostime.Location = New System.Drawing.Point(1022, 658)
        Me.cbostime.Name = "cbostime"
        Me.cbostime.Size = New System.Drawing.Size(297, 28)
        Me.cbostime.TabIndex = 75
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.ovalpicture})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1378, 728)
        Me.ShapeContainer1.TabIndex = 76
        Me.ShapeContainer1.TabStop = False
        '
        'ovalpicture
        '
        Me.ovalpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ovalpicture.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.ovalpicture.Location = New System.Drawing.Point(1209, 8)
        Me.ovalpicture.Name = "ovalpicture"
        Me.ovalpicture.Size = New System.Drawing.Size(40, 40)
        Me.ovalpicture.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(42, 639)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(298, 640)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(783, 639)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(1019, 639)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Time"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.settings
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1215, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 81
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.Color.White
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(301, 658)
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(479, 28)
        Me.txtdescription.TabIndex = 82
        Me.txtdescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbosearch
        '
        Me.cbosearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbosearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbosearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosearch.FormattingEnabled = True
        Me.cbosearch.Items.AddRange(New Object() {"Account ID", "Firstname", "Middlename", "Lastname"})
        Me.cbosearch.Location = New System.Drawing.Point(101, 160)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(166, 26)
        Me.cbosearch.TabIndex = 83
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(140, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 60)
        Me.Button3.TabIndex = 89
        Me.Button3.Text = "My Subject"
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.btnstudents.TabIndex = 90
        Me.btnstudents.Text = "Students"
        Me.btnstudents.UseVisualStyleBackColor = False
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
        Me.btninstructors.TabIndex = 91
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
        Me.btndirectories.TabIndex = 92
        Me.btndirectories.Text = "Directories"
        Me.btndirectories.UseVisualStyleBackColor = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 23
        Me.LineShape2.X2 = 1339
        Me.LineShape2.Y1 = 707
        Me.LineShape2.Y2 = 707
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Silver
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 1339
        Me.LineShape4.X2 = 1339
        Me.LineShape4.Y1 = 708
        Me.LineShape4.Y2 = 128
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 250
        Me.LineShape1.X2 = 1339
        Me.LineShape1.Y1 = 129
        Me.LineShape1.Y2 = 129
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
        Me.LineShape5.X2 = 138
        Me.LineShape5.Y1 = 129
        Me.LineShape5.Y2 = 129
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.Silver
        Me.LineShape6.BorderWidth = 2
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 138
        Me.LineShape6.X2 = 138
        Me.LineShape6.Y1 = 65
        Me.LineShape6.Y2 = 130
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.Color.Silver
        Me.LineShape7.BorderWidth = 2
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 251
        Me.LineShape7.X2 = 251
        Me.LineShape7.Y1 = 66
        Me.LineShape7.Y2 = 129
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.Silver
        Me.LineShape8.BorderWidth = 2
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 138
        Me.LineShape8.X2 = 252
        Me.LineShape8.Y1 = 66
        Me.LineShape8.Y2 = 66
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 728)
        Me.Controls.Add(Me.btndirectories)
        Me.Controls.Add(Me.btninstructors)
        Me.Controls.Add(Me.btnstudents)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbosearch)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbostime)
        Me.Controls.Add(Me.cbosday)
        Me.Controls.Add(Me.dgrid_mystudents)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbosubject)
        Me.Controls.Add(Me.btn_refreshmysubjects)
        Me.Controls.Add(Me.txtsearchbox)
        Me.Controls.Add(Me.btn_addstudent)
        Me.Controls.Add(Me.btn_studentregistration)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_minimize)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.btn_addsubject)
        Me.Controls.Add(Me.btn_deletestudents)
        Me.Controls.Add(Me.btn_deletesubject)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1386, 728)
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jkm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgrid_mystudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_refreshmysubjects As System.Windows.Forms.Button
    Friend WithEvents fullname As System.Windows.Forms.Label
    Friend WithEvents btn_addstudent As System.Windows.Forms.Button
    Friend WithEvents btn_addsubject As System.Windows.Forms.Button
    Friend WithEvents icons As System.Windows.Forms.ImageList
    Friend WithEvents listview As System.Windows.Forms.ListView
    Friend WithEvents btn_deletestudents As System.Windows.Forms.Button
    Friend WithEvents btn_deletesubject As System.Windows.Forms.Button
    Friend WithEvents btn_minimize As adminform_minimize.adminform_minimize
    Friend WithEvents btn_logout As adminform_close.adminform_close
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_studentregistration As System.Windows.Forms.Button
    Friend WithEvents txtsearchbox As System.Windows.Forms.TextBox
    Friend WithEvents cbosubject As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgrid_mystudents As System.Windows.Forms.DataGridView
    Friend WithEvents cbosday As System.Windows.Forms.ComboBox
    Friend WithEvents cbostime As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ovalpicture As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtdescription As System.Windows.Forms.Label
    Friend WithEvents cbosearch As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnstudents As System.Windows.Forms.Button
    Friend WithEvents btninstructors As System.Windows.Forms.Button
    Friend WithEvents btndirectories As System.Windows.Forms.Button
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
