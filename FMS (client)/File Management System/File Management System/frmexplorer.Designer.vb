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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmexplorer))
        Me.explorerlistview = New System.Windows.Forms.ListView()
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        Me.lblfolders = New System.Windows.Forms.Label()
        Me.lblfiles = New System.Windows.Forms.Label()
        Me.lblitems = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcancel = New System.Windows.Forms.Button()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnexport = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtfolderbrowser = New System.Windows.Forms.Button()
        Me.btnfilebrowser = New System.Windows.Forms.Button()
        Me.cboviewmode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbofileorfolder = New System.Windows.Forms.ComboBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.path2 = New System.Windows.Forms.TextBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttrimmedpathlength = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtexplorerpathlength = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcombination2length = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtexploreritemlength = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtselecetditemlength = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpathlength = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btncancel2 = New System.Windows.Forms.Button()
        Me.txtdestinationpath = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnimport = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnfolderbrowser2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btn_rename = New renameeeee.renameeeeeeee()
        Me.btn_copy = New copy.copy()
        Me.btn_delete = New deleeete.deleeeete()
        Me.btn_details = New details.details()
        Me.btn_newfolder = New buttons.Class1()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'explorerlistview
        '
        Me.explorerlistview.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.explorerlistview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.explorerlistview.ForeColor = System.Drawing.Color.White
        Me.explorerlistview.LabelEdit = True
        Me.explorerlistview.LargeImageList = Me.icons
        Me.explorerlistview.Location = New System.Drawing.Point(28, 88)
        Me.explorerlistview.Name = "explorerlistview"
        Me.explorerlistview.Size = New System.Drawing.Size(1246, 456)
        Me.explorerlistview.TabIndex = 84
        Me.explorerlistview.UseCompatibleStateImageBehavior = False
        Me.explorerlistview.View = System.Windows.Forms.View.Details
        '
        'icons
        '
        Me.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.icons.ImageSize = New System.Drawing.Size(27, 27)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblfolders
        '
        Me.lblfolders.AutoSize = True
        Me.lblfolders.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfolders.ForeColor = System.Drawing.Color.Silver
        Me.lblfolders.Location = New System.Drawing.Point(41, 616)
        Me.lblfolders.Name = "lblfolders"
        Me.lblfolders.Size = New System.Drawing.Size(59, 16)
        Me.lblfolders.TabIndex = 112
        Me.lblfolders.Text = "0 folders"
        '
        'lblfiles
        '
        Me.lblfiles.AutoSize = True
        Me.lblfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfiles.ForeColor = System.Drawing.Color.Silver
        Me.lblfiles.Location = New System.Drawing.Point(41, 595)
        Me.lblfiles.Name = "lblfiles"
        Me.lblfiles.Size = New System.Drawing.Size(42, 16)
        Me.lblfiles.TabIndex = 111
        Me.lblfiles.Text = "0 files"
        '
        'lblitems
        '
        Me.lblitems.AutoSize = True
        Me.lblitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitems.ForeColor = System.Drawing.Color.White
        Me.lblitems.Location = New System.Drawing.Point(41, 637)
        Me.lblitems.Name = "lblitems"
        Me.lblitems.Size = New System.Drawing.Size(109, 18)
        Me.lblitems.TabIndex = 110
        Me.lblitems.Text = "No items found"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcancel)
        Me.GroupBox2.Controls.Add(Me.txtitemname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnexport)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtfolderbrowser)
        Me.GroupBox2.Controls.Add(Me.btnfilebrowser)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox2.Location = New System.Drawing.Point(947, 556)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 126)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Export"
        '
        'txtcancel
        '
        Me.txtcancel.BackColor = System.Drawing.Color.Transparent
        Me.txtcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtcancel.FlatAppearance.BorderSize = 0
        Me.txtcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcancel.ForeColor = System.Drawing.Color.Red
        Me.txtcancel.Location = New System.Drawing.Point(289, 47)
        Me.txtcancel.Name = "txtcancel"
        Me.txtcancel.Size = New System.Drawing.Size(26, 26)
        Me.txtcancel.TabIndex = 96
        Me.txtcancel.Text = "X"
        Me.txtcancel.UseVisualStyleBackColor = False
        '
        'txtitemname
        '
        Me.txtitemname.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtitemname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtitemname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitemname.ForeColor = System.Drawing.Color.White
        Me.txtitemname.Location = New System.Drawing.Point(27, 51)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.ReadOnly = True
        Me.txtitemname.Size = New System.Drawing.Size(259, 17)
        Me.txtitemname.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(20, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(298, 29)
        Me.Label9.TabIndex = 148
        '
        'btnexport
        '
        Me.btnexport.BackgroundImage = Global.File_Management_System.My.Resources.Resources.upload2
        Me.btnexport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnexport.FlatAppearance.BorderSize = 0
        Me.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexport.ForeColor = System.Drawing.Color.Black
        Me.btnexport.Location = New System.Drawing.Point(290, 84)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(30, 30)
        Me.btnexport.TabIndex = 62
        Me.btnexport.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(19, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Item"
        '
        'txtfolderbrowser
        '
        Me.txtfolderbrowser.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.txtfolderbrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtfolderbrowser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfolderbrowser.ForeColor = System.Drawing.Color.White
        Me.txtfolderbrowser.Location = New System.Drawing.Point(117, 86)
        Me.txtfolderbrowser.Name = "txtfolderbrowser"
        Me.txtfolderbrowser.Size = New System.Drawing.Size(105, 27)
        Me.txtfolderbrowser.TabIndex = 95
        Me.txtfolderbrowser.Text = "Folder Browser"
        Me.txtfolderbrowser.UseVisualStyleBackColor = True
        '
        'btnfilebrowser
        '
        Me.btnfilebrowser.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnfilebrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfilebrowser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfilebrowser.ForeColor = System.Drawing.Color.White
        Me.btnfilebrowser.Location = New System.Drawing.Point(22, 86)
        Me.btnfilebrowser.Name = "btnfilebrowser"
        Me.btnfilebrowser.Size = New System.Drawing.Size(88, 27)
        Me.btnfilebrowser.TabIndex = 94
        Me.btnfilebrowser.Text = "File Browser"
        Me.btnfilebrowser.UseVisualStyleBackColor = True
        '
        'cboviewmode
        '
        Me.cboviewmode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboviewmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboviewmode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboviewmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboviewmode.ForeColor = System.Drawing.Color.White
        Me.cboviewmode.FormattingEnabled = True
        Me.cboviewmode.Items.AddRange(New Object() {"Large Icons", "Small Icons", "List", "Details", "Tiles"})
        Me.cboviewmode.Location = New System.Drawing.Point(1120, 57)
        Me.cboviewmode.Name = "cboviewmode"
        Me.cboviewmode.Size = New System.Drawing.Size(154, 26)
        Me.cboviewmode.TabIndex = 120
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(721, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Search"
        '
        'cbofileorfolder
        '
        Me.cbofileorfolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbofileorfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofileorfolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbofileorfolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofileorfolder.ForeColor = System.Drawing.Color.White
        Me.cbofileorfolder.FormattingEnabled = True
        Me.cbofileorfolder.Items.AddRange(New Object() {"File", "Folder"})
        Me.cbofileorfolder.Location = New System.Drawing.Point(776, 58)
        Me.cbofileorfolder.Name = "cbofileorfolder"
        Me.cbofileorfolder.Size = New System.Drawing.Size(81, 26)
        Me.cbofileorfolder.TabIndex = 117
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.White
        Me.txtsearch.Location = New System.Drawing.Point(862, 58)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(231, 24)
        Me.txtsearch.TabIndex = 116
        '
        'path2
        '
        Me.path2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.path2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.path2.ForeColor = System.Drawing.Color.White
        Me.path2.Location = New System.Drawing.Point(62, 58)
        Me.path2.Name = "path2"
        Me.path2.ReadOnly = True
        Me.path2.Size = New System.Drawing.Size(599, 24)
        Me.path2.TabIndex = 115
        '
        'btnback
        '
        Me.btnback.Enabled = False
        Me.btnback.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.ForeColor = System.Drawing.Color.White
        Me.btnback.Location = New System.Drawing.Point(28, 58)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(29, 24)
        Me.btnback.TabIndex = 114
        Me.btnback.Text = "<"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 20)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "File Management System Explorer"
        '
        'btnminimize
        '
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.ForeColor = System.Drawing.Color.White
        Me.btnminimize.Location = New System.Drawing.Point(1232, 12)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(25, 25)
        Me.btnminimize.TabIndex = 123
        Me.btnminimize.Text = "_"
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(1263, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 122
        Me.btnclose.Text = "X"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1300, 700)
        Me.ShapeContainer1.TabIndex = 124
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.Silver
        Me.LineShape5.BorderWidth = 2
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 1298
        Me.LineShape5.X2 = 1299
        Me.LineShape5.Y1 = 2
        Me.LineShape5.Y2 = 698
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Silver
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 0
        Me.LineShape4.X2 = 1
        Me.LineShape4.Y1 = 2
        Me.LineShape4.Y2 = 698
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Silver
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 0
        Me.LineShape3.X2 = 1300
        Me.LineShape3.Y1 = 1
        Me.LineShape3.Y2 = 1
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Silver
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 0
        Me.LineShape2.X2 = 1300
        Me.LineShape2.Y1 = 698
        Me.LineShape2.Y2 = 698
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Silver
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 1298
        Me.LineShape1.Y1 = 544
        Me.LineShape1.Y2 = 544
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(218, 586)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(336, 24)
        Me.TextBox1.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(960, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "trimmed path length"
        '
        'txttrimmedpathlength
        '
        Me.txttrimmedpathlength.Location = New System.Drawing.Point(1066, 361)
        Me.txttrimmedpathlength.Name = "txttrimmedpathlength"
        Me.txttrimmedpathlength.ReadOnly = True
        Me.txttrimmedpathlength.Size = New System.Drawing.Size(148, 20)
        Me.txttrimmedpathlength.TabIndex = 140
        Me.txttrimmedpathlength.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(993, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "path length"
        '
        'txtexplorerpathlength
        '
        Me.txtexplorerpathlength.Location = New System.Drawing.Point(1066, 328)
        Me.txtexplorerpathlength.Name = "txtexplorerpathlength"
        Me.txtexplorerpathlength.ReadOnly = True
        Me.txtexplorerpathlength.Size = New System.Drawing.Size(148, 20)
        Me.txtexplorerpathlength.TabIndex = 138
        Me.txtexplorerpathlength.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(951, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "combination2 length"
        '
        'txtcombination2length
        '
        Me.txtcombination2length.Location = New System.Drawing.Point(1066, 302)
        Me.txtcombination2length.Name = "txtcombination2length"
        Me.txtcombination2length.ReadOnly = True
        Me.txtcombination2length.Size = New System.Drawing.Size(148, 20)
        Me.txtcombination2length.TabIndex = 136
        Me.txtcombination2length.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(875, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 13)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "selected folder here in explorer length"
        '
        'txtexploreritemlength
        '
        Me.txtexploreritemlength.Location = New System.Drawing.Point(1066, 276)
        Me.txtexploreritemlength.Name = "txtexploreritemlength"
        Me.txtexploreritemlength.ReadOnly = True
        Me.txtexploreritemlength.Size = New System.Drawing.Size(148, 20)
        Me.txtexploreritemlength.TabIndex = 134
        Me.txtexploreritemlength.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(909, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 13)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "selected folder in main lenght"
        '
        'txtselecetditemlength
        '
        Me.txtselecetditemlength.Location = New System.Drawing.Point(1066, 208)
        Me.txtselecetditemlength.Name = "txtselecetditemlength"
        Me.txtselecetditemlength.ReadOnly = True
        Me.txtselecetditemlength.Size = New System.Drawing.Size(148, 20)
        Me.txtselecetditemlength.TabIndex = 132
        Me.txtselecetditemlength.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(967, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Initial path length"
        '
        'txtpathlength
        '
        Me.txtpathlength.Location = New System.Drawing.Point(1066, 234)
        Me.txtpathlength.Name = "txtpathlength"
        Me.txtpathlength.ReadOnly = True
        Me.txtpathlength.Size = New System.Drawing.Size(148, 20)
        Me.txtpathlength.TabIndex = 130
        Me.txtpathlength.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncancel2)
        Me.GroupBox1.Controls.Add(Me.txtdestinationpath)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnimport)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.btnfolderbrowser2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox1.Location = New System.Drawing.Point(606, 556)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 126)
        Me.GroupBox1.TabIndex = 149
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Import"
        '
        'btncancel2
        '
        Me.btncancel2.BackColor = System.Drawing.Color.Transparent
        Me.btncancel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel2.FlatAppearance.BorderSize = 0
        Me.btncancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel2.ForeColor = System.Drawing.Color.Red
        Me.btncancel2.Location = New System.Drawing.Point(289, 47)
        Me.btncancel2.Name = "btncancel2"
        Me.btncancel2.Size = New System.Drawing.Size(26, 26)
        Me.btncancel2.TabIndex = 96
        Me.btncancel2.Text = "X"
        Me.btncancel2.UseVisualStyleBackColor = False
        '
        'txtdestinationpath
        '
        Me.txtdestinationpath.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdestinationpath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdestinationpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestinationpath.ForeColor = System.Drawing.Color.White
        Me.txtdestinationpath.Location = New System.Drawing.Point(27, 51)
        Me.txtdestinationpath.Name = "txtdestinationpath"
        Me.txtdestinationpath.Size = New System.Drawing.Size(259, 17)
        Me.txtdestinationpath.TabIndex = 93
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Gray
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(20, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(298, 29)
        Me.Label11.TabIndex = 148
        '
        'btnimport
        '
        Me.btnimport.BackgroundImage = Global.File_Management_System.My.Resources.Resources.downloadwhite
        Me.btnimport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnimport.FlatAppearance.BorderSize = 0
        Me.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimport.ForeColor = System.Drawing.Color.Black
        Me.btnimport.Location = New System.Drawing.Point(290, 84)
        Me.btnimport.Name = "btnimport"
        Me.btnimport.Size = New System.Drawing.Size(30, 30)
        Me.btnimport.TabIndex = 62
        Me.btnimport.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(19, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 15)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Destination Path"
        '
        'btnfolderbrowser2
        '
        Me.btnfolderbrowser2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnfolderbrowser2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfolderbrowser2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfolderbrowser2.ForeColor = System.Drawing.Color.White
        Me.btnfolderbrowser2.Location = New System.Drawing.Point(20, 86)
        Me.btnfolderbrowser2.Name = "btnfolderbrowser2"
        Me.btnfolderbrowser2.Size = New System.Drawing.Size(107, 27)
        Me.btnfolderbrowser2.TabIndex = 95
        Me.btnfolderbrowser2.Text = "Folder Browser"
        Me.btnfolderbrowser2.UseVisualStyleBackColor = True
        '
        'btn_rename
        '
        Me.btn_rename.BackColor = System.Drawing.Color.Transparent
        Me.btn_rename.BackgroundImage = CType(resources.GetObject("btn_rename.BackgroundImage"), System.Drawing.Image)
        Me.btn_rename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_rename.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_rename.FlatAppearance.BorderSize = 0
        Me.btn_rename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_rename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rename.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rename.Location = New System.Drawing.Point(342, 616)
        Me.btn_rename.Name = "btn_rename"
        Me.btn_rename.Size = New System.Drawing.Size(50, 50)
        Me.btn_rename.TabIndex = 147
        Me.btn_rename.UseVisualStyleBackColor = False
        '
        'btn_copy
        '
        Me.btn_copy.BackColor = System.Drawing.Color.Transparent
        Me.btn_copy.BackgroundImage = CType(resources.GetObject("btn_copy.BackgroundImage"), System.Drawing.Image)
        Me.btn_copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_copy.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_copy.FlatAppearance.BorderSize = 0
        Me.btn_copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_copy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_copy.Location = New System.Drawing.Point(292, 616)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(50, 50)
        Me.btn_copy.TabIndex = 146
        Me.btn_copy.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(494, 617)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(51, 48)
        Me.btn_delete.TabIndex = 145
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_details
        '
        Me.btn_details.BackColor = System.Drawing.Color.Transparent
        Me.btn_details.BackgroundImage = CType(resources.GetObject("btn_details.BackgroundImage"), System.Drawing.Image)
        Me.btn_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_details.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_details.FlatAppearance.BorderSize = 0
        Me.btn_details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_details.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_details.Location = New System.Drawing.Point(444, 616)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(50, 50)
        Me.btn_details.TabIndex = 144
        Me.btn_details.UseVisualStyleBackColor = False
        '
        'btn_newfolder
        '
        Me.btn_newfolder.BackColor = System.Drawing.Color.Transparent
        Me.btn_newfolder.BackgroundImage = CType(resources.GetObject("btn_newfolder.BackgroundImage"), System.Drawing.Image)
        Me.btn_newfolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_newfolder.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_newfolder.FlatAppearance.BorderSize = 0
        Me.btn_newfolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_newfolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_newfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_newfolder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newfolder.Location = New System.Drawing.Point(228, 616)
        Me.btn_newfolder.Name = "btn_newfolder"
        Me.btn_newfolder.Size = New System.Drawing.Size(57, 49)
        Me.btn_newfolder.TabIndex = 143
        Me.btn_newfolder.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackgroundImage = Global.File_Management_System.My.Resources.Resources.refresh2
        Me.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnrefresh.FlatAppearance.BorderSize = 0
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.ForeColor = System.Drawing.Color.White
        Me.btnrefresh.Location = New System.Drawing.Point(666, 58)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(25, 25)
        Me.btnrefresh.TabIndex = 118
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'frmexplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_rename)
        Me.Controls.Add(Me.btn_copy)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_details)
        Me.Controls.Add(Me.btn_newfolder)
        Me.Controls.Add(Me.explorerlistview)
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
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnminimize)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboviewmode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.cbofileorfolder)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.path2)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblfolders)
        Me.Controls.Add(Me.lblfiles)
        Me.Controls.Add(Me.lblitems)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1300, 700)
        Me.Name = "frmexplorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmexplorer"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents explorerlistview As System.Windows.Forms.ListView
    Friend WithEvents lblfolders As System.Windows.Forms.Label
    Friend WithEvents lblfiles As System.Windows.Forms.Label
    Friend WithEvents lblitems As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtfolderbrowser As System.Windows.Forms.Button
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents btnfilebrowser As System.Windows.Forms.Button
    Friend WithEvents btnexport As System.Windows.Forms.Button
    Friend WithEvents cboviewmode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnrefresh As System.Windows.Forms.Button
    Friend WithEvents cbofileorfolder As System.Windows.Forms.ComboBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents path2 As System.Windows.Forms.TextBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnminimize As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttrimmedpathlength As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtexplorerpathlength As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcombination2length As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtexploreritemlength As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtselecetditemlength As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpathlength As System.Windows.Forms.TextBox
    Friend WithEvents icons As System.Windows.Forms.ImageList
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_newfolder As buttons.Class1
    Friend WithEvents btn_details As details.details
    Friend WithEvents btn_delete As deleeete.deleeeete
    Friend WithEvents btn_copy As copy.copy
    Friend WithEvents btn_rename As renameeeee.renameeeeeeee
    Friend WithEvents txtcancel As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncancel2 As System.Windows.Forms.Button
    Friend WithEvents txtdestinationpath As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnimport As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnfolderbrowser2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
