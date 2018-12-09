<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmexplorer
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
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.txtpathlength = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtselecetditemlength = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtexploreritemlength = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcombination2length = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtexplorerpathlength = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttrimmedpathlength = New System.Windows.Forms.TextBox()
        Me.path2 = New System.Windows.Forms.TextBox()
        Me.explorerlistview = New System.Windows.Forms.ListView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtexportationpath = New System.Windows.Forms.TextBox()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnfilebrowser = New System.Windows.Forms.Button()
        Me.txtfolderbrowser = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cbofileorfolder = New System.Windows.Forms.ComboBox()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.btn_lock = New System.Windows.Forms.Button()
        Me.btnlock = New System.Windows.Forms.GroupBox()
        Me.btncancelimport = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_import = New System.Windows.Forms.Button()
        Me.lblitems = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblfiles = New System.Windows.Forms.Label()
        Me.lblfolders = New System.Windows.Forms.Label()
        Me.lblallocatedspace = New System.Windows.Forms.Label()
        Me.lblusedspace = New System.Windows.Forms.Label()
        Me.lblremainingspace = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cboviewmode = New System.Windows.Forms.ComboBox()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.btnlock.SuspendLayout()
        Me.SuspendLayout()
        '
        'icons
        '
        Me.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.icons.ImageSize = New System.Drawing.Size(27, 27)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnclose
        '
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnclose.Location = New System.Drawing.Point(1263, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 1
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Enabled = False
        Me.btnback.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Location = New System.Drawing.Point(28, 59)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(29, 24)
        Me.btnback.TabIndex = 67
        Me.btnback.Text = "<"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'txtpathlength
        '
        Me.txtpathlength.Location = New System.Drawing.Point(1058, 231)
        Me.txtpathlength.Name = "txtpathlength"
        Me.txtpathlength.ReadOnly = True
        Me.txtpathlength.Size = New System.Drawing.Size(148, 20)
        Me.txtpathlength.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(959, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Initial path length"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(901, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "selected folder in main lenght"
        '
        'txtselecetditemlength
        '
        Me.txtselecetditemlength.Location = New System.Drawing.Point(1058, 205)
        Me.txtselecetditemlength.Name = "txtselecetditemlength"
        Me.txtselecetditemlength.ReadOnly = True
        Me.txtselecetditemlength.Size = New System.Drawing.Size(148, 20)
        Me.txtselecetditemlength.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(867, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "selected folder here in explorer length"
        '
        'txtexploreritemlength
        '
        Me.txtexploreritemlength.Location = New System.Drawing.Point(1058, 273)
        Me.txtexploreritemlength.Name = "txtexploreritemlength"
        Me.txtexploreritemlength.ReadOnly = True
        Me.txtexploreritemlength.Size = New System.Drawing.Size(148, 20)
        Me.txtexploreritemlength.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(943, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "combination2 length"
        '
        'txtcombination2length
        '
        Me.txtcombination2length.Location = New System.Drawing.Point(1058, 299)
        Me.txtcombination2length.Name = "txtcombination2length"
        Me.txtcombination2length.ReadOnly = True
        Me.txtcombination2length.Size = New System.Drawing.Size(148, 20)
        Me.txtcombination2length.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(985, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "path length"
        '
        'txtexplorerpathlength
        '
        Me.txtexplorerpathlength.Location = New System.Drawing.Point(1058, 325)
        Me.txtexplorerpathlength.Name = "txtexplorerpathlength"
        Me.txtexplorerpathlength.ReadOnly = True
        Me.txtexplorerpathlength.Size = New System.Drawing.Size(148, 20)
        Me.txtexplorerpathlength.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(952, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "trimmed path length"
        '
        'txttrimmedpathlength
        '
        Me.txttrimmedpathlength.Location = New System.Drawing.Point(1058, 358)
        Me.txttrimmedpathlength.Name = "txttrimmedpathlength"
        Me.txttrimmedpathlength.ReadOnly = True
        Me.txttrimmedpathlength.Size = New System.Drawing.Size(148, 20)
        Me.txttrimmedpathlength.TabIndex = 80
        '
        'path2
        '
        Me.path2.BackColor = System.Drawing.Color.White
        Me.path2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path2.Location = New System.Drawing.Point(62, 59)
        Me.path2.Name = "path2"
        Me.path2.ReadOnly = True
        Me.path2.Size = New System.Drawing.Size(599, 24)
        Me.path2.TabIndex = 82
        '
        'explorerlistview
        '
        Me.explorerlistview.BackColor = System.Drawing.Color.White
        Me.explorerlistview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.explorerlistview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.explorerlistview.LargeImageList = Me.icons
        Me.explorerlistview.Location = New System.Drawing.Point(28, 88)
        Me.explorerlistview.Name = "explorerlistview"
        Me.explorerlistview.Size = New System.Drawing.Size(1246, 456)
        Me.explorerlistview.TabIndex = 83
        Me.explorerlistview.UseCompatibleStateImageBehavior = False
        Me.explorerlistview.View = System.Windows.Forms.View.Details
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Black
        Me.txtsearch.Location = New System.Drawing.Point(862, 59)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(231, 24)
        Me.txtsearch.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 20)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "File Management System Explorer"
        '
        'txtexportationpath
        '
        Me.txtexportationpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexportationpath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtexportationpath.Location = New System.Drawing.Point(49, 47)
        Me.txtexportationpath.Name = "txtexportationpath"
        Me.txtexportationpath.Size = New System.Drawing.Size(268, 21)
        Me.txtexportationpath.TabIndex = 87
        '
        'txtitemname
        '
        Me.txtitemname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtitemname.Location = New System.Drawing.Point(22, 47)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.ReadOnly = True
        Me.txtitemname.Size = New System.Drawing.Size(275, 21)
        Me.txtitemname.TabIndex = 93
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'btnfilebrowser
        '
        Me.btnfilebrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfilebrowser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfilebrowser.ForeColor = System.Drawing.Color.Black
        Me.btnfilebrowser.Location = New System.Drawing.Point(22, 87)
        Me.btnfilebrowser.Name = "btnfilebrowser"
        Me.btnfilebrowser.Size = New System.Drawing.Size(88, 27)
        Me.btnfilebrowser.TabIndex = 94
        Me.btnfilebrowser.Text = "File Browser"
        Me.btnfilebrowser.UseVisualStyleBackColor = True
        '
        'txtfolderbrowser
        '
        Me.txtfolderbrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtfolderbrowser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfolderbrowser.ForeColor = System.Drawing.Color.Black
        Me.txtfolderbrowser.Location = New System.Drawing.Point(116, 87)
        Me.txtfolderbrowser.Name = "txtfolderbrowser"
        Me.txtfolderbrowser.Size = New System.Drawing.Size(105, 27)
        Me.txtfolderbrowser.TabIndex = 95
        Me.txtfolderbrowser.Text = "Folder Browser"
        Me.txtfolderbrowser.UseVisualStyleBackColor = True
        '
        'cbofileorfolder
        '
        Me.cbofileorfolder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbofileorfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofileorfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofileorfolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbofileorfolder.FormattingEnabled = True
        Me.cbofileorfolder.Items.AddRange(New Object() {"File", "Folder"})
        Me.cbofileorfolder.Location = New System.Drawing.Point(776, 59)
        Me.cbofileorfolder.Name = "cbofileorfolder"
        Me.cbofileorfolder.Size = New System.Drawing.Size(81, 26)
        Me.cbofileorfolder.TabIndex = 97
        '
        'btnminimize
        '
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnminimize.Location = New System.Drawing.Point(1232, 12)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(25, 25)
        Me.btnminimize.TabIndex = 98
        Me.btnminimize.Text = "_"
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtexportationpath)
        Me.GroupBox1.Controls.Add(Me.btn_export)
        Me.GroupBox1.Controls.Add(Me.btn_lock)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(608, 556)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 126)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export"
        '
        'btn_edit
        '
        Me.btn_edit.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.edit
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Location = New System.Drawing.Point(22, 47)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(21, 21)
        Me.btn_edit.TabIndex = 90
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(18, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 15)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Destination Path"
        '
        'btn_export
        '
        Me.btn_export.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.upload
        Me.btn_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_export.FlatAppearance.BorderSize = 0
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.ForeColor = System.Drawing.Color.Black
        Me.btn_export.Location = New System.Drawing.Point(287, 85)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(30, 30)
        Me.btn_export.TabIndex = 63
        Me.btn_export.UseVisualStyleBackColor = True
        '
        'btn_lock
        '
        Me.btn_lock.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.lock
        Me.btn_lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_lock.FlatAppearance.BorderSize = 0
        Me.btn_lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_lock.Location = New System.Drawing.Point(21, 47)
        Me.btn_lock.Name = "btn_lock"
        Me.btn_lock.Size = New System.Drawing.Size(21, 21)
        Me.btn_lock.TabIndex = 91
        Me.btn_lock.UseVisualStyleBackColor = True
        Me.btn_lock.Visible = False
        '
        'btnlock
        '
        Me.btnlock.Controls.Add(Me.btncancelimport)
        Me.btnlock.Controls.Add(Me.Label10)
        Me.btnlock.Controls.Add(Me.txtfolderbrowser)
        Me.btnlock.Controls.Add(Me.txtitemname)
        Me.btnlock.Controls.Add(Me.btnfilebrowser)
        Me.btnlock.Controls.Add(Me.btn_import)
        Me.btnlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnlock.Location = New System.Drawing.Point(949, 556)
        Me.btnlock.Name = "btnlock"
        Me.btnlock.Size = New System.Drawing.Size(335, 126)
        Me.btnlock.TabIndex = 100
        Me.btnlock.TabStop = False
        Me.btnlock.Text = "Import"
        '
        'btncancelimport
        '
        Me.btncancelimport.FlatAppearance.BorderSize = 0
        Me.btncancelimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelimport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelimport.ForeColor = System.Drawing.Color.Black
        Me.btncancelimport.Location = New System.Drawing.Point(299, 47)
        Me.btncancelimport.Name = "btncancelimport"
        Me.btncancelimport.Size = New System.Drawing.Size(21, 21)
        Me.btncancelimport.TabIndex = 96
        Me.btncancelimport.Text = "x"
        Me.btncancelimport.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(19, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Item"
        '
        'btn_import
        '
        Me.btn_import.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.download
        Me.btn_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_import.FlatAppearance.BorderSize = 0
        Me.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_import.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_import.ForeColor = System.Drawing.Color.Black
        Me.btn_import.Location = New System.Drawing.Point(290, 87)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(30, 30)
        Me.btn_import.TabIndex = 62
        Me.btn_import.UseVisualStyleBackColor = True
        '
        'lblitems
        '
        Me.lblitems.AutoSize = True
        Me.lblitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblitems.Location = New System.Drawing.Point(42, 637)
        Me.lblitems.Name = "lblitems"
        Me.lblitems.Size = New System.Drawing.Size(109, 18)
        Me.lblitems.TabIndex = 103
        Me.lblitems.Text = "No items found"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(721, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Search"
        '
        'lblfiles
        '
        Me.lblfiles.AutoSize = True
        Me.lblfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfiles.ForeColor = System.Drawing.Color.DimGray
        Me.lblfiles.Location = New System.Drawing.Point(42, 592)
        Me.lblfiles.Name = "lblfiles"
        Me.lblfiles.Size = New System.Drawing.Size(42, 16)
        Me.lblfiles.TabIndex = 105
        Me.lblfiles.Text = "0 files"
        '
        'lblfolders
        '
        Me.lblfolders.AutoSize = True
        Me.lblfolders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfolders.ForeColor = System.Drawing.Color.DimGray
        Me.lblfolders.Location = New System.Drawing.Point(42, 613)
        Me.lblfolders.Name = "lblfolders"
        Me.lblfolders.Size = New System.Drawing.Size(59, 16)
        Me.lblfolders.TabIndex = 106
        Me.lblfolders.Text = "0 folders"
        '
        'lblallocatedspace
        '
        Me.lblallocatedspace.AutoSize = True
        Me.lblallocatedspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblallocatedspace.ForeColor = System.Drawing.Color.DimGray
        Me.lblallocatedspace.Location = New System.Drawing.Point(208, 592)
        Me.lblallocatedspace.Name = "lblallocatedspace"
        Me.lblallocatedspace.Size = New System.Drawing.Size(108, 16)
        Me.lblallocatedspace.TabIndex = 107
        Me.lblallocatedspace.Text = "Allocated Space"
        '
        'lblusedspace
        '
        Me.lblusedspace.AutoSize = True
        Me.lblusedspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusedspace.ForeColor = System.Drawing.Color.DimGray
        Me.lblusedspace.Location = New System.Drawing.Point(208, 613)
        Me.lblusedspace.Name = "lblusedspace"
        Me.lblusedspace.Size = New System.Drawing.Size(201, 16)
        Me.lblusedspace.TabIndex = 108
        Me.lblusedspace.Text = "Used Space               :   0.00 bytes"
        '
        'lblremainingspace
        '
        Me.lblremainingspace.AutoSize = True
        Me.lblremainingspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblremainingspace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblremainingspace.Location = New System.Drawing.Point(208, 637)
        Me.lblremainingspace.Name = "lblremainingspace"
        Me.lblremainingspace.Size = New System.Drawing.Size(124, 18)
        Me.lblremainingspace.TabIndex = 109
        Me.lblremainingspace.Text = "Remaining Space"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1300, 700)
        Me.ShapeContainer1.TabIndex = 110
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.Black
        Me.LineShape6.BorderWidth = 2
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 1298
        Me.LineShape6.X2 = 1298
        Me.LineShape6.Y1 = 1
        Me.LineShape6.Y2 = 700
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.Black
        Me.LineShape5.BorderWidth = 2
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 1
        Me.LineShape5.X2 = 1
        Me.LineShape5.Y1 = 0
        Me.LineShape5.Y2 = 699
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Black
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 0
        Me.LineShape4.X2 = 1300
        Me.LineShape4.Y1 = 1
        Me.LineShape4.Y2 = 1
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Black
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 0
        Me.LineShape3.X2 = 1300
        Me.LineShape3.Y1 = 698
        Me.LineShape3.Y2 = 698
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -2
        Me.LineShape2.X2 = 1298
        Me.LineShape2.Y1 = 544
        Me.LineShape2.Y2 = 544
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.Visible = False
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 1300
        Me.LineShape1.Y1 = 87
        Me.LineShape1.Y2 = 87
        '
        'cboviewmode
        '
        Me.cboviewmode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboviewmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboviewmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboviewmode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboviewmode.FormattingEnabled = True
        Me.cboviewmode.Items.AddRange(New Object() {"Large Icons", "Small Icons", "List", "Details", "Tiles"})
        Me.cboviewmode.Location = New System.Drawing.Point(1120, 58)
        Me.cboviewmode.Name = "cboviewmode"
        Me.cboviewmode.Size = New System.Drawing.Size(154, 26)
        Me.cboviewmode.TabIndex = 111
        '
        'btnrefresh
        '
        Me.btnrefresh.BackgroundImage = Global.File_Management_System__admin_.My.Resources.Resources.refresh
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.Black
        Me.btnrefresh.Location = New System.Drawing.Point(666, 59)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(25, 25)
        Me.btnrefresh.TabIndex = 102
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'frmexplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.cboviewmode)
        Me.Controls.Add(Me.lblremainingspace)
        Me.Controls.Add(Me.lblusedspace)
        Me.Controls.Add(Me.lblallocatedspace)
        Me.Controls.Add(Me.lblfolders)
        Me.Controls.Add(Me.lblfiles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblitems)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnlock)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnminimize)
        Me.Controls.Add(Me.cbofileorfolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.explorerlistview)
        Me.Controls.Add(Me.path2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttrimmedpathlength)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtexplorerpathlength)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcombination2length)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtexploreritemlength)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtselecetditemlength)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpathlength)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1300, 700)
        Me.Name = "frmexplorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmexplorer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.btnlock.ResumeLayout(False)
        Me.btnlock.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents icons As System.Windows.Forms.ImageList
    Friend WithEvents btn_import As System.Windows.Forms.Button
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents txtpathlength As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtselecetditemlength As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtexploreritemlength As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcombination2length As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtexplorerpathlength As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttrimmedpathlength As System.Windows.Forms.TextBox
    Friend WithEvents path2 As System.Windows.Forms.TextBox
    Friend WithEvents explorerlistview As System.Windows.Forms.ListView
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtexportationpath As System.Windows.Forms.TextBox
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnfilebrowser As System.Windows.Forms.Button
    Friend WithEvents txtfolderbrowser As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents cbofileorfolder As System.Windows.Forms.ComboBox
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnlock As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents lblitems As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblfiles As System.Windows.Forms.Label
    Friend WithEvents lblfolders As System.Windows.Forms.Label
    Friend WithEvents lblallocatedspace As System.Windows.Forms.Label
    Friend WithEvents lblusedspace As System.Windows.Forms.Label
    Friend WithEvents lblremainingspace As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cboviewmode As System.Windows.Forms.ComboBox
    Friend WithEvents btn_lock As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btncancelimport As System.Windows.Forms.Button
End Class
