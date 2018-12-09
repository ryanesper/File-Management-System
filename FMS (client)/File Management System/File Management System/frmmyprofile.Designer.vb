<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmyprofile
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.mypicture = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ovalpicture = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnbrowseapic = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblday = New System.Windows.Forms.Label()
        Me.lblcpno = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblremainingspace = New System.Windows.Forms.Label()
        Me.lblmyspace = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblrsb = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgrid_mysubjects = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblscib = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblsc = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.lblasinbytes = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lbloverallitems = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.cbocourse = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboyear = New System.Windows.Forms.ComboBox()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.btncp = New System.Windows.Forms.Button()
        CType(Me.dgrid_mysubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.mypicture, Me.ovalpicture})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1300, 660)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'mypicture
        '
        Me.mypicture.BackgroundImage = Global.File_Management_System.My.Resources.Resources.Koala2
        Me.mypicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mypicture.BorderColor = System.Drawing.Color.White
        Me.mypicture.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.mypicture.Location = New System.Drawing.Point(231, 74)
        Me.mypicture.Name = "mypicture"
        Me.mypicture.Size = New System.Drawing.Size(145, 145)
        '
        'ovalpicture
        '
        Me.ovalpicture.BackgroundImage = Global.File_Management_System.My.Resources.Resources.normi_logo
        Me.ovalpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ovalpicture.BorderColor = System.Drawing.Color.Transparent
        Me.ovalpicture.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.ovalpicture.FillColor = System.Drawing.Color.Transparent
        Me.ovalpicture.Location = New System.Drawing.Point(556, 11)
        Me.ovalpicture.Name = "ovalpicture"
        Me.ovalpicture.SelectionColor = System.Drawing.Color.Transparent
        Me.ovalpicture.Size = New System.Drawing.Size(185, 185)
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnedit.Location = New System.Drawing.Point(29, 613)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(86, 23)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "Edit Profile"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnbrowseapic
        '
        Me.btnbrowseapic.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnbrowseapic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowseapic.ForeColor = System.Drawing.Color.White
        Me.btnbrowseapic.Location = New System.Drawing.Point(341, 198)
        Me.btnbrowseapic.Name = "btnbrowseapic"
        Me.btnbrowseapic.Size = New System.Drawing.Size(36, 22)
        Me.btnbrowseapic.TabIndex = 5
        Me.btnbrowseapic.Text = "..."
        Me.btnbrowseapic.UseVisualStyleBackColor = False
        Me.btnbrowseapic.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnupdate.Location = New System.Drawing.Point(213, 613)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(86, 23)
        Me.btnupdate.TabIndex = 3
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        Me.btnupdate.Visible = False
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.BackColor = System.Drawing.Color.Transparent
        Me.lblfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.Color.White
        Me.lblfullname.Location = New System.Drawing.Point(50, 290)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(61, 24)
        Me.lblfullname.TabIndex = 6
        Me.lblfullname.Text = "Name"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.BackColor = System.Drawing.Color.Transparent
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.White
        Me.lblid.Location = New System.Drawing.Point(50, 240)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(27, 24)
        Me.lblid.TabIndex = 7
        Me.lblid.Text = "ID"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.BackColor = System.Drawing.Color.Transparent
        Me.lblgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.ForeColor = System.Drawing.Color.White
        Me.lblgender.Location = New System.Drawing.Point(50, 335)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(74, 24)
        Me.lblgender.TabIndex = 8
        Me.lblgender.Text = "Gender"
        '
        'lblday
        '
        Me.lblday.AutoSize = True
        Me.lblday.BackColor = System.Drawing.Color.Transparent
        Me.lblday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblday.ForeColor = System.Drawing.Color.White
        Me.lblday.Location = New System.Drawing.Point(50, 380)
        Me.lblday.Name = "lblday"
        Me.lblday.Size = New System.Drawing.Size(152, 24)
        Me.lblday.TabIndex = 9
        Me.lblday.Text = "Course and Year"
        '
        'lblcpno
        '
        Me.lblcpno.AutoSize = True
        Me.lblcpno.BackColor = System.Drawing.Color.Transparent
        Me.lblcpno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcpno.ForeColor = System.Drawing.Color.White
        Me.lblcpno.Location = New System.Drawing.Point(50, 425)
        Me.lblcpno.Name = "lblcpno"
        Me.lblcpno.Size = New System.Drawing.Size(69, 24)
        Me.lblcpno.TabIndex = 11
        Me.lblcpno.Text = "Cp No."
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.BackColor = System.Drawing.Color.Transparent
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.Color.White
        Me.lbladdress.Location = New System.Drawing.Point(50, 470)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(80, 24)
        Me.lbladdress.TabIndex = 12
        Me.lbladdress.Text = "Address"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.Color.White
        Me.lblemail.Location = New System.Drawing.Point(50, 515)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(57, 24)
        Me.lblemail.TabIndex = 13
        Me.lblemail.Text = "Email"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnclose.Location = New System.Drawing.Point(1248, 67)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(30, 30)
        Me.btnclose.TabIndex = 22
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblremainingspace
        '
        Me.lblremainingspace.AutoSize = True
        Me.lblremainingspace.BackColor = System.Drawing.Color.Transparent
        Me.lblremainingspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremainingspace.ForeColor = System.Drawing.Color.Lime
        Me.lblremainingspace.Location = New System.Drawing.Point(772, 216)
        Me.lblremainingspace.Name = "lblremainingspace"
        Me.lblremainingspace.Size = New System.Drawing.Size(98, 37)
        Me.lblremainingspace.TabIndex = 74
        Me.lblremainingspace.Text = "00.00"
        '
        'lblmyspace
        '
        Me.lblmyspace.AutoSize = True
        Me.lblmyspace.BackColor = System.Drawing.Color.Transparent
        Me.lblmyspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmyspace.ForeColor = System.Drawing.Color.White
        Me.lblmyspace.Location = New System.Drawing.Point(888, 108)
        Me.lblmyspace.Name = "lblmyspace"
        Me.lblmyspace.Size = New System.Drawing.Size(150, 55)
        Me.lblmyspace.TabIndex = 73
        Me.lblmyspace.Text = "00.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(779, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 16)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "remaining space"
        '
        'lblrsb
        '
        Me.lblrsb.AutoSize = True
        Me.lblrsb.BackColor = System.Drawing.Color.Transparent
        Me.lblrsb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrsb.ForeColor = System.Drawing.Color.Lime
        Me.lblrsb.Location = New System.Drawing.Point(779, 246)
        Me.lblrsb.Name = "lblrsb"
        Me.lblrsb.Size = New System.Drawing.Size(157, 16)
        Me.lblrsb.TabIndex = 76
        Me.lblrsb.Text = "remaining space in bytes"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGray
        Me.Label13.Location = New System.Drawing.Point(674, 388)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(599, 24)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Subjects"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgrid_mysubjects
        '
        Me.dgrid_mysubjects.AllowUserToAddRows = False
        Me.dgrid_mysubjects.AllowUserToDeleteRows = False
        Me.dgrid_mysubjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgrid_mysubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgrid_mysubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrid_mysubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgrid_mysubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrid_mysubjects.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgrid_mysubjects.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgrid_mysubjects.Location = New System.Drawing.Point(674, 415)
        Me.dgrid_mysubjects.Name = "dgrid_mysubjects"
        Me.dgrid_mysubjects.ReadOnly = True
        Me.dgrid_mysubjects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrid_mysubjects.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgrid_mysubjects.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dgrid_mysubjects.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgrid_mysubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrid_mysubjects.Size = New System.Drawing.Size(599, 158)
        Me.dgrid_mysubjects.TabIndex = 79
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(895, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 16)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "allocated space"
        '
        'lblscib
        '
        Me.lblscib.AutoSize = True
        Me.lblscib.BackColor = System.Drawing.Color.Transparent
        Me.lblscib.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscib.ForeColor = System.Drawing.Color.Red
        Me.lblscib.Location = New System.Drawing.Point(1040, 246)
        Me.lblscib.Name = "lblscib"
        Me.lblscib.Size = New System.Drawing.Size(128, 16)
        Me.lblscib.TabIndex = 83
        Me.lblscib.Text = "used space in bytes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(1041, 205)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 16)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "used space"
        '
        'lblsc
        '
        Me.lblsc.AutoSize = True
        Me.lblsc.BackColor = System.Drawing.Color.Transparent
        Me.lblsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsc.ForeColor = System.Drawing.Color.Red
        Me.lblsc.Location = New System.Drawing.Point(1034, 216)
        Me.lblsc.Name = "lblsc"
        Me.lblsc.Size = New System.Drawing.Size(98, 37)
        Me.lblsc.TabIndex = 81
        Me.lblsc.Text = "00.00"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancel.Location = New System.Drawing.Point(305, 613)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(86, 23)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        Me.btncancel.Visible = False
        '
        'btnminimize
        '
        Me.btnminimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnminimize.Location = New System.Drawing.Point(1212, 67)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(30, 30)
        Me.btnminimize.TabIndex = 92
        Me.btnminimize.Text = "_"
        Me.btnminimize.UseVisualStyleBackColor = False
        '
        'lblasinbytes
        '
        Me.lblasinbytes.AutoSize = True
        Me.lblasinbytes.BackColor = System.Drawing.Color.Transparent
        Me.lblasinbytes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblasinbytes.ForeColor = System.Drawing.Color.White
        Me.lblasinbytes.Location = New System.Drawing.Point(895, 156)
        Me.lblasinbytes.Name = "lblasinbytes"
        Me.lblasinbytes.Size = New System.Drawing.Size(105, 16)
        Me.lblasinbytes.TabIndex = 94
        Me.lblasinbytes.Text = "allocated space"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(670, 368)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(43, 24)
        Me.lbltotal.TabIndex = 95
        Me.lbltotal.Text = "total"
        Me.lbltotal.Visible = False
        '
        'lbloverallitems
        '
        Me.lbloverallitems.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbloverallitems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbloverallitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloverallitems.ForeColor = System.Drawing.Color.DarkGray
        Me.lbloverallitems.Location = New System.Drawing.Point(3, 25)
        Me.lbloverallitems.Name = "lbloverallitems"
        Me.lbloverallitems.ReadOnly = True
        Me.lbloverallitems.Size = New System.Drawing.Size(593, 19)
        Me.lbloverallitems.TabIndex = 96
        Me.lbloverallitems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbloverallitems)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(674, 311)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 54)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contains"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(50, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Account ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(50, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Fullname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(50, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(50, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 15)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Department and Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(50, 445)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Contact Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(50, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(50, 535)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Email"
        '
        'txtfname
        '
        Me.txtfname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.ForeColor = System.Drawing.Color.DarkGray
        Me.txtfname.Location = New System.Drawing.Point(54, 290)
        Me.txtfname.MaxLength = 10
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(176, 22)
        Me.txtfname.TabIndex = 6
        Me.txtfname.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGray
        Me.Label8.Location = New System.Drawing.Point(248, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Middlename"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(444, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 15)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Lastname"
        Me.Label9.Visible = False
        '
        'txtmname
        '
        Me.txtmname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.ForeColor = System.Drawing.Color.DarkGray
        Me.txtmname.Location = New System.Drawing.Point(251, 290)
        Me.txtmname.MaxLength = 10
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(176, 22)
        Me.txtmname.TabIndex = 7
        Me.txtmname.Visible = False
        '
        'txtlname
        '
        Me.txtlname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.ForeColor = System.Drawing.Color.DarkGray
        Me.txtlname.Location = New System.Drawing.Point(447, 290)
        Me.txtlname.MaxLength = 10
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(176, 22)
        Me.txtlname.TabIndex = 8
        Me.txtlname.Visible = False
        '
        'cbocourse
        '
        Me.cbocourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbocourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocourse.ForeColor = System.Drawing.Color.DarkGray
        Me.cbocourse.FormattingEnabled = True
        Me.cbocourse.Items.AddRange(New Object() {"BSBA", "BSCRIM", "BSED", "BSHRM", "BSIT"})
        Me.cbocourse.Location = New System.Drawing.Point(53, 379)
        Me.cbocourse.Name = "cbocourse"
        Me.cbocourse.Size = New System.Drawing.Size(176, 23)
        Me.cbocourse.TabIndex = 10
        Me.cbocourse.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGray
        Me.Label10.Location = New System.Drawing.Point(248, 400)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 15)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Year"
        Me.Label10.Visible = False
        '
        'cboyear
        '
        Me.cboyear.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboyear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboyear.ForeColor = System.Drawing.Color.DarkGray
        Me.cboyear.FormattingEnabled = True
        Me.cboyear.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cboyear.Location = New System.Drawing.Point(251, 379)
        Me.cboyear.Name = "cboyear"
        Me.cboyear.Size = New System.Drawing.Size(176, 23)
        Me.cboyear.TabIndex = 11
        Me.cboyear.Visible = False
        '
        'txtnumber
        '
        Me.txtnumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumber.ForeColor = System.Drawing.Color.DarkGray
        Me.txtnumber.Location = New System.Drawing.Point(54, 425)
        Me.txtnumber.MaxLength = 60
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(569, 22)
        Me.txtnumber.TabIndex = 12
        Me.txtnumber.Visible = False
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.DarkGray
        Me.txtaddress.Location = New System.Drawing.Point(54, 470)
        Me.txtaddress.MaxLength = 60
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(569, 22)
        Me.txtaddress.TabIndex = 13
        Me.txtaddress.Visible = False
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.DarkGray
        Me.txtemail.Location = New System.Drawing.Point(54, 515)
        Me.txtemail.MaxLength = 60
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(569, 22)
        Me.txtemail.TabIndex = 14
        Me.txtemail.Visible = False
        '
        'cbogender
        '
        Me.cbogender.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbogender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogender.ForeColor = System.Drawing.Color.DarkGray
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(54, 334)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(176, 23)
        Me.cbogender.TabIndex = 9
        Me.cbogender.Visible = False
        '
        'btncp
        '
        Me.btncp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btncp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncp.Location = New System.Drawing.Point(121, 613)
        Me.btncp.Name = "btncp"
        Me.btncp.Size = New System.Drawing.Size(86, 23)
        Me.btncp.TabIndex = 2
        Me.btncp.Text = "Change Pass"
        Me.btncp.UseVisualStyleBackColor = False
        Me.btncp.Visible = False
        '
        'frmmyprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.File_Management_System.My.Resources.Resources.Untitled_15
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1300, 660)
        Me.Controls.Add(Me.btncp)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.cboyear)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.lblcpno)
        Me.Controls.Add(Me.lblday)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lblfullname)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblasinbytes)
        Me.Controls.Add(Me.btnminimize)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lblscib)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblsc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dgrid_mysubjects)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblrsb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblremainingspace)
        Me.Controls.Add(Me.lblmyspace)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnbrowseapic)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.cbocourse)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1300, 660)
        Me.Name = "frmmyprofile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmmyprofile"
        CType(Me.dgrid_mysubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ovalpicture As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnbrowseapic As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents lblfullname As System.Windows.Forms.Label
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblday As System.Windows.Forms.Label
    Friend WithEvents lblcpno As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents mypicture As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblremainingspace As System.Windows.Forms.Label
    Friend WithEvents lblmyspace As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblrsb As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgrid_mysubjects As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblscib As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblsc As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents lblasinbytes As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lbloverallitems As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtmname As System.Windows.Forms.TextBox
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents cbocourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboyear As System.Windows.Forms.ComboBox
    Friend WithEvents txtnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents btncp As System.Windows.Forms.Button
End Class
