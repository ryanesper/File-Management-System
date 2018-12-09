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
        Me.listview = New System.Windows.Forms.ListView()
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fullname = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblyc = New System.Windows.Forms.Label()
        Me.lblaccountid = New System.Windows.Forms.Label()
        Me.User_main_minimize11 = New user_main_minimize1.user_main_minimize1()
        Me.User_main_close11 = New user_main_close1.user_main_close1()
        Me.button_search = New user_main_search.user_main_search()
        Me.button_copy = New user_main_copy.user_main_copy()
        Me.button_delete = New user_main_delete.user_main_delete()
        Me.button_details = New user_main_details.user_main_details()
        Me.button_file = New user_main_file.user_main_file()
        Me.button_folder = New user_main_folder.user_main_folder()
        Me.button_newfolder = New user_main_newfolder.user_main_newfolder()
        Me.button_profile = New user_main_profile.user_main_profile()
        Me.button_refresh = New user_main_refresh.user_main_refresh()
        Me.button_rename = New user_main_rename.user_main_rename()
        Me.btn_import1 = New import.import()
        Me.ovalpicture = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.txtcancel = New System.Windows.Forms.Button()
        Me.button_import = New import.Class1()
        Me.button_export = New export.Class1()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'listview
        '
        Me.listview.AllowDrop = True
        Me.listview.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.listview.BackgroundImage = Global.File_Management_System.My.Resources.Resources.lvbg
        Me.listview.BackgroundImageTiled = True
        Me.listview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listview.ForeColor = System.Drawing.SystemColors.Info
        Me.listview.LargeImageList = Me.icons
        Me.listview.Location = New System.Drawing.Point(16, 13)
        Me.listview.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.listview.Name = "listview"
        Me.listview.Size = New System.Drawing.Size(662, 664)
        Me.listview.TabIndex = 0
        Me.listview.UseCompatibleStateImageBehavior = False
        '
        'icons
        '
        Me.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.icons.ImageSize = New System.Drawing.Size(32, 32)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(829, 321)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(349, 22)
        Me.TextBox1.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 704)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "0 bytes"
        Me.Label1.Visible = False
        '
        'fullname
        '
        Me.fullname.AutoSize = True
        Me.fullname.BackColor = System.Drawing.Color.Transparent
        Me.fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname.ForeColor = System.Drawing.Color.White
        Me.fullname.Location = New System.Drawing.Point(963, 138)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(71, 18)
        Me.fullname.TabIndex = 70
        Me.fullname.Text = "fullname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1175, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "myspace"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(951, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "remaining space and allocated space"
        '
        'lblyc
        '
        Me.lblyc.AutoSize = True
        Me.lblyc.BackColor = System.Drawing.Color.Transparent
        Me.lblyc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyc.ForeColor = System.Drawing.Color.White
        Me.lblyc.Location = New System.Drawing.Point(963, 169)
        Me.lblyc.Name = "lblyc"
        Me.lblyc.Size = New System.Drawing.Size(129, 18)
        Me.lblyc.TabIndex = 73
        Me.lblyc.Text = "year and course"
        '
        'lblaccountid
        '
        Me.lblaccountid.AutoSize = True
        Me.lblaccountid.BackColor = System.Drawing.Color.Transparent
        Me.lblaccountid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccountid.ForeColor = System.Drawing.Color.White
        Me.lblaccountid.Location = New System.Drawing.Point(961, 100)
        Me.lblaccountid.Name = "lblaccountid"
        Me.lblaccountid.Size = New System.Drawing.Size(92, 20)
        Me.lblaccountid.TabIndex = 74
        Me.lblaccountid.Text = "account id"
        Me.lblaccountid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'User_main_minimize11
        '
        Me.User_main_minimize11.BackColor = System.Drawing.Color.Transparent
        Me.User_main_minimize11.BackgroundImage = CType(resources.GetObject("User_main_minimize11.BackgroundImage"), System.Drawing.Image)
        Me.User_main_minimize11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.User_main_minimize11.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.User_main_minimize11.FlatAppearance.BorderSize = 0
        Me.User_main_minimize11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.User_main_minimize11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.User_main_minimize11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.User_main_minimize11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_main_minimize11.Location = New System.Drawing.Point(1254, 16)
        Me.User_main_minimize11.Name = "User_main_minimize11"
        Me.User_main_minimize11.Size = New System.Drawing.Size(40, 40)
        Me.User_main_minimize11.TabIndex = 14
        Me.User_main_minimize11.UseVisualStyleBackColor = False
        '
        'User_main_close11
        '
        Me.User_main_close11.BackColor = System.Drawing.Color.Transparent
        Me.User_main_close11.BackgroundImage = CType(resources.GetObject("User_main_close11.BackgroundImage"), System.Drawing.Image)
        Me.User_main_close11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.User_main_close11.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.User_main_close11.FlatAppearance.BorderSize = 0
        Me.User_main_close11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.User_main_close11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.User_main_close11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.User_main_close11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_main_close11.Location = New System.Drawing.Point(1303, 8)
        Me.User_main_close11.Name = "User_main_close11"
        Me.User_main_close11.Size = New System.Drawing.Size(40, 40)
        Me.User_main_close11.TabIndex = 15
        Me.User_main_close11.UseVisualStyleBackColor = False
        '
        'button_search
        '
        Me.button_search.BackColor = System.Drawing.Color.Transparent
        Me.button_search.BackgroundImage = CType(resources.GetObject("button_search.BackgroundImage"), System.Drawing.Image)
        Me.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_search.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_search.FlatAppearance.BorderSize = 0
        Me.button_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_search.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_search.Location = New System.Drawing.Point(1052, 586)
        Me.button_search.Name = "button_search"
        Me.button_search.Size = New System.Drawing.Size(80, 80)
        Me.button_search.TabIndex = 12
        Me.button_search.UseVisualStyleBackColor = False
        Me.button_search.Visible = False
        '
        'button_copy
        '
        Me.button_copy.BackColor = System.Drawing.Color.Transparent
        Me.button_copy.BackgroundImage = CType(resources.GetObject("button_copy.BackgroundImage"), System.Drawing.Image)
        Me.button_copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_copy.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_copy.FlatAppearance.BorderSize = 0
        Me.button_copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_copy.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_copy.Location = New System.Drawing.Point(880, 375)
        Me.button_copy.Name = "button_copy"
        Me.button_copy.Size = New System.Drawing.Size(80, 80)
        Me.button_copy.TabIndex = 3
        Me.button_copy.UseVisualStyleBackColor = False
        '
        'button_delete
        '
        Me.button_delete.BackColor = System.Drawing.Color.Transparent
        Me.button_delete.BackgroundImage = CType(resources.GetObject("button_delete.BackgroundImage"), System.Drawing.Image)
        Me.button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_delete.FlatAppearance.BorderSize = 0
        Me.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_delete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_delete.Location = New System.Drawing.Point(1138, 586)
        Me.button_delete.Name = "button_delete"
        Me.button_delete.Size = New System.Drawing.Size(80, 80)
        Me.button_delete.TabIndex = 13
        Me.button_delete.UseVisualStyleBackColor = False
        '
        'button_details
        '
        Me.button_details.BackColor = System.Drawing.Color.Transparent
        Me.button_details.BackgroundImage = CType(resources.GetObject("button_details.BackgroundImage"), System.Drawing.Image)
        Me.button_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_details.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_details.FlatAppearance.BorderSize = 0
        Me.button_details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_details.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_details.Location = New System.Drawing.Point(794, 586)
        Me.button_details.Name = "button_details"
        Me.button_details.Size = New System.Drawing.Size(80, 80)
        Me.button_details.TabIndex = 8
        Me.button_details.UseVisualStyleBackColor = False
        '
        'button_file
        '
        Me.button_file.BackColor = System.Drawing.Color.Transparent
        Me.button_file.BackgroundImage = CType(resources.GetObject("button_file.BackgroundImage"), System.Drawing.Image)
        Me.button_file.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_file.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_file.FlatAppearance.BorderSize = 0
        Me.button_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_file.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_file.Location = New System.Drawing.Point(880, 586)
        Me.button_file.Name = "button_file"
        Me.button_file.Size = New System.Drawing.Size(80, 80)
        Me.button_file.TabIndex = 10
        Me.button_file.UseVisualStyleBackColor = False
        '
        'button_folder
        '
        Me.button_folder.BackColor = System.Drawing.Color.Transparent
        Me.button_folder.BackgroundImage = CType(resources.GetObject("button_folder.BackgroundImage"), System.Drawing.Image)
        Me.button_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_folder.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_folder.FlatAppearance.BorderSize = 0
        Me.button_folder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_folder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_folder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_folder.Location = New System.Drawing.Point(966, 586)
        Me.button_folder.Name = "button_folder"
        Me.button_folder.Size = New System.Drawing.Size(80, 80)
        Me.button_folder.TabIndex = 11
        Me.button_folder.UseVisualStyleBackColor = False
        '
        'button_newfolder
        '
        Me.button_newfolder.BackColor = System.Drawing.Color.Transparent
        Me.button_newfolder.BackgroundImage = CType(resources.GetObject("button_newfolder.BackgroundImage"), System.Drawing.Image)
        Me.button_newfolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_newfolder.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_newfolder.FlatAppearance.BorderSize = 0
        Me.button_newfolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_newfolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_newfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_newfolder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_newfolder.Location = New System.Drawing.Point(794, 375)
        Me.button_newfolder.Name = "button_newfolder"
        Me.button_newfolder.Size = New System.Drawing.Size(80, 80)
        Me.button_newfolder.TabIndex = 2
        Me.button_newfolder.UseVisualStyleBackColor = False
        '
        'button_profile
        '
        Me.button_profile.BackColor = System.Drawing.Color.Transparent
        Me.button_profile.BackgroundImage = CType(resources.GetObject("button_profile.BackgroundImage"), System.Drawing.Image)
        Me.button_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_profile.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_profile.FlatAppearance.BorderSize = 0
        Me.button_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_profile.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_profile.Location = New System.Drawing.Point(1138, 500)
        Me.button_profile.Name = "button_profile"
        Me.button_profile.Size = New System.Drawing.Size(80, 80)
        Me.button_profile.TabIndex = 9
        Me.button_profile.UseVisualStyleBackColor = False
        '
        'button_refresh
        '
        Me.button_refresh.BackColor = System.Drawing.Color.Transparent
        Me.button_refresh.BackgroundImage = CType(resources.GetObject("button_refresh.BackgroundImage"), System.Drawing.Image)
        Me.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_refresh.FlatAppearance.BorderSize = 0
        Me.button_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_refresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_refresh.Location = New System.Drawing.Point(794, 500)
        Me.button_refresh.Name = "button_refresh"
        Me.button_refresh.Size = New System.Drawing.Size(80, 80)
        Me.button_refresh.TabIndex = 7
        Me.button_refresh.UseVisualStyleBackColor = False
        '
        'button_rename
        '
        Me.button_rename.BackColor = System.Drawing.Color.Transparent
        Me.button_rename.BackgroundImage = CType(resources.GetObject("button_rename.BackgroundImage"), System.Drawing.Image)
        Me.button_rename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_rename.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_rename.FlatAppearance.BorderSize = 0
        Me.button_rename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_rename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_rename.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_rename.Location = New System.Drawing.Point(966, 375)
        Me.button_rename.Name = "button_rename"
        Me.button_rename.Size = New System.Drawing.Size(80, 80)
        Me.button_rename.TabIndex = 4
        Me.button_rename.UseVisualStyleBackColor = False
        '
        'btn_import1
        '
        Me.btn_import1.BackColor = System.Drawing.Color.Transparent
        Me.btn_import1.BackgroundImage = CType(resources.GetObject("btn_import1.BackgroundImage"), System.Drawing.Image)
        Me.btn_import1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_import1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_import1.FlatAppearance.BorderSize = 0
        Me.btn_import1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_import1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_import1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_import1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_import1.Location = New System.Drawing.Point(1138, 500)
        Me.btn_import1.Name = "btn_import1"
        Me.btn_import1.Size = New System.Drawing.Size(80, 80)
        Me.btn_import1.TabIndex = 88
        Me.btn_import1.UseVisualStyleBackColor = False
        Me.btn_import1.Visible = False
        '
        'ovalpicture
        '
        Me.ovalpicture.BackgroundImage = Global.File_Management_System.My.Resources.Resources._me
        Me.ovalpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ovalpicture.BorderColor = System.Drawing.Color.Transparent
        Me.ovalpicture.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.ovalpicture.FillColor = System.Drawing.Color.Transparent
        Me.ovalpicture.Location = New System.Drawing.Point(726, 53)
        Me.ovalpicture.Name = "ovalpicture"
        Me.ovalpicture.SelectionColor = System.Drawing.Color.Transparent
        Me.ovalpicture.Size = New System.Drawing.Size(223, 226)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.ovalpicture})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1348, 692)
        Me.ShapeContainer1.TabIndex = 89
        Me.ShapeContainer1.TabStop = False
        '
        'txtcancel
        '
        Me.txtcancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtcancel.FlatAppearance.BorderSize = 0
        Me.txtcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcancel.ForeColor = System.Drawing.Color.Red
        Me.txtcancel.Location = New System.Drawing.Point(1160, 321)
        Me.txtcancel.Name = "txtcancel"
        Me.txtcancel.Size = New System.Drawing.Size(22, 22)
        Me.txtcancel.TabIndex = 91
        Me.txtcancel.Text = "X"
        Me.txtcancel.UseVisualStyleBackColor = False
        Me.txtcancel.Visible = False
        '
        'button_import
        '
        Me.button_import.BackColor = System.Drawing.Color.Transparent
        Me.button_import.BackgroundImage = CType(resources.GetObject("button_import.BackgroundImage"), System.Drawing.Image)
        Me.button_import.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_import.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_import.FlatAppearance.BorderSize = 0
        Me.button_import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_import.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_import.Location = New System.Drawing.Point(966, 500)
        Me.button_import.Name = "button_import"
        Me.button_import.Size = New System.Drawing.Size(80, 80)
        Me.button_import.TabIndex = 5
        Me.button_import.UseVisualStyleBackColor = False
        '
        'button_export
        '
        Me.button_export.BackColor = System.Drawing.Color.Transparent
        Me.button_export.BackgroundImage = CType(resources.GetObject("button_export.BackgroundImage"), System.Drawing.Image)
        Me.button_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.button_export.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.button_export.FlatAppearance.BorderSize = 0
        Me.button_export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.button_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_export.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_export.Location = New System.Drawing.Point(880, 500)
        Me.button_export.Name = "button_export"
        Me.button_export.Size = New System.Drawing.Size(80, 80)
        Me.button_export.TabIndex = 6
        Me.button_export.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.File_Management_System.My.Resources.Resources.winbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1348, 692)
        Me.Controls.Add(Me.button_export)
        Me.Controls.Add(Me.button_import)
        Me.Controls.Add(Me.txtcancel)
        Me.Controls.Add(Me.button_rename)
        Me.Controls.Add(Me.button_refresh)
        Me.Controls.Add(Me.button_profile)
        Me.Controls.Add(Me.button_newfolder)
        Me.Controls.Add(Me.button_folder)
        Me.Controls.Add(Me.button_file)
        Me.Controls.Add(Me.button_details)
        Me.Controls.Add(Me.button_delete)
        Me.Controls.Add(Me.button_copy)
        Me.Controls.Add(Me.button_search)
        Me.Controls.Add(Me.User_main_close11)
        Me.Controls.Add(Me.User_main_minimize11)
        Me.Controls.Add(Me.lblaccountid)
        Me.Controls.Add(Me.lblyc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.listview)
        Me.Controls.Add(Me.btn_import1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1364, 730)
        Me.MinimizeBox = False
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FMS Desktop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listview As System.Windows.Forms.ListView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents icons As System.Windows.Forms.ImageList
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fullname As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblyc As System.Windows.Forms.Label
    Friend WithEvents lblaccountid As System.Windows.Forms.Label
    Friend WithEvents User_main_minimize11 As user_main_minimize1.user_main_minimize1
    Friend WithEvents User_main_close11 As user_main_close1.user_main_close1
    Friend WithEvents button_search As user_main_search.user_main_search
    Friend WithEvents button_copy As user_main_copy.user_main_copy
    Friend WithEvents button_delete As user_main_delete.user_main_delete
    Friend WithEvents button_details As user_main_details.user_main_details
    Friend WithEvents button_file As user_main_file.user_main_file
    Friend WithEvents button_folder As user_main_folder.user_main_folder
    Friend WithEvents button_newfolder As user_main_newfolder.user_main_newfolder
    Friend WithEvents button_profile As user_main_profile.user_main_profile
    Friend WithEvents button_refresh As user_main_refresh.user_main_refresh
    Friend WithEvents button_rename As user_main_rename.user_main_rename
    Friend WithEvents btn_import1 As import.import
    Friend WithEvents ovalpicture As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtcancel As System.Windows.Forms.Button
    Friend WithEvents button_import As import.Class1
    Friend WithEvents button_export As export.Class1
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
