<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSony
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSony))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtS_Laber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.df = New System.Windows.Forms.GroupBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.cmb_Pcode3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_Pcode_Value = New System.Windows.Forms.Label()
        Me.cmb_Pcode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDelete = New System.Windows.Forms.TextBox()
        Me.dg5 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFATSERIAL = New System.Windows.Forms.TextBox()
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txteancode = New System.Windows.Forms.TextBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.dd = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.df.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dd.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 23)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowHeadersWidth = 50
        Me.dgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(10)
        Me.dgv.RowTemplate.Height = 50
        Me.dgv.Size = New System.Drawing.Size(368, 189)
        Me.dgv.TabIndex = 40
        '
        'txtS_Laber
        '
        Me.txtS_Laber.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtS_Laber.Location = New System.Drawing.Point(93, 37)
        Me.txtS_Laber.Name = "txtS_Laber"
        Me.txtS_Laber.Size = New System.Drawing.Size(219, 29)
        Me.txtS_Laber.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Sap_Num"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Shift"
        '
        'df
        '
        Me.df.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.df.Controls.Add(Me.txtS_Laber)
        Me.df.Controls.Add(Me.Label2)
        Me.df.Controls.Add(Me.Label1)
        Me.df.Controls.Add(Me.btnStart)
        Me.df.Controls.Add(Me.cmb_Pcode3)
        Me.df.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.df.Location = New System.Drawing.Point(954, 317)
        Me.df.Name = "df"
        Me.df.Size = New System.Drawing.Size(371, 199)
        Me.df.TabIndex = 51
        Me.df.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(93, 139)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(219, 29)
        Me.btnStart.TabIndex = 31
        Me.btnStart.Text = "Start_Work"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'cmb_Pcode3
        '
        Me.cmb_Pcode3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Pcode3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Pcode3.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Pcode3.FormattingEnabled = True
        Me.cmb_Pcode3.Items.AddRange(New Object() {"A", "B", "C"})
        Me.cmb_Pcode3.Location = New System.Drawing.Point(93, 87)
        Me.cmb_Pcode3.Name = "cmb_Pcode3"
        Me.cmb_Pcode3.Size = New System.Drawing.Size(219, 29)
        Me.cmb_Pcode3.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lbl_Pcode_Value)
        Me.GroupBox1.Controls.Add(Me.cmb_Pcode)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(316, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 58)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Model Name"
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(534, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 29)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbl_Pcode_Value
        '
        Me.lbl_Pcode_Value.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lbl_Pcode_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Pcode_Value.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbl_Pcode_Value.Location = New System.Drawing.Point(436, 24)
        Me.lbl_Pcode_Value.Name = "lbl_Pcode_Value"
        Me.lbl_Pcode_Value.Size = New System.Drawing.Size(92, 23)
        Me.lbl_Pcode_Value.TabIndex = 34
        Me.lbl_Pcode_Value.Text = " "
        '
        'cmb_Pcode
        '
        Me.cmb_Pcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Pcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Pcode.FormattingEnabled = True
        Me.cmb_Pcode.Location = New System.Drawing.Point(19, 21)
        Me.cmb_Pcode.Name = "cmb_Pcode"
        Me.cmb_Pcode.Size = New System.Drawing.Size(411, 26)
        Me.cmb_Pcode.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(299, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(629, 44)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = " SCANNING        STAION   OUTPUT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox4.Controls.Add(Me.txtDelete)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(9, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(277, 100)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delete"
        '
        'txtDelete
        '
        Me.txtDelete.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelete.Location = New System.Drawing.Point(19, 38)
        Me.txtDelete.Name = "txtDelete"
        Me.txtDelete.Size = New System.Drawing.Size(242, 29)
        Me.txtDelete.TabIndex = 36
        '
        'dg5
        '
        Me.dg5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dg5.AllowUserToAddRows = False
        Me.dg5.AllowUserToDeleteRows = False
        Me.dg5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg5.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg5.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg5.DefaultCellStyle = DataGridViewCellStyle5
        Me.dg5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg5.Location = New System.Drawing.Point(3, 22)
        Me.dg5.Name = "dg5"
        Me.dg5.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg5.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg5.RowHeadersWidth = 50
        Me.dg5.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow
        Me.dg5.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg5.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(10)
        Me.dg5.RowTemplate.Height = 50
        Me.dg5.Size = New System.Drawing.Size(368, 135)
        Me.dg5.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox2.Controls.Add(Me.dg5)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(954, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 160)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total for day"
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " SERIAL :"
        '
        'txtFATSERIAL
        '
        Me.txtFATSERIAL.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.txtFATSERIAL.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFATSERIAL.Location = New System.Drawing.Point(108, 34)
        Me.txtFATSERIAL.Name = "txtFATSERIAL"
        Me.txtFATSERIAL.Size = New System.Drawing.Size(347, 30)
        Me.txtFATSERIAL.TabIndex = 3
        '
        'btnSEARCH
        '
        Me.btnSEARCH.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnSEARCH.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSEARCH.Location = New System.Drawing.Point(484, 17)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(104, 30)
        Me.btnSEARCH.TabIndex = 8
        Me.btnSEARCH.Text = "Search"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lbl_Msg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.Color.Black
        Me.lbl_Msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Msg.Font = New System.Drawing.Font("Tahoma", 47.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Msg.Location = New System.Drawing.Point(-3, 553)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(1354, 178)
        Me.lbl_Msg.TabIndex = 43
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.ToolToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ToolToolStripMenuItem.Text = "Tool"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GroupBox5
        '
        Me.GroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txteancode)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtFATSERIAL)
        Me.GroupBox5.Controls.Add(Me.btnSEARCH)
        Me.GroupBox5.Location = New System.Drawing.Point(319, 457)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(606, 93)
        Me.GroupBox5.TabIndex = 48
        Me.GroupBox5.TabStop = False
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(484, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Ean Code :"
        Me.Label5.Visible = False
        '
        'txteancode
        '
        Me.txteancode.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.txteancode.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteancode.Location = New System.Drawing.Point(108, 53)
        Me.txteancode.Name = "txteancode"
        Me.txteancode.Size = New System.Drawing.Size(347, 30)
        Me.txteancode.TabIndex = 12
        Me.txteancode.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.Location = New System.Drawing.Point(1537, 48)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(10, 24)
        Me.btnLogout.TabIndex = 45
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'dg2
        '
        Me.dg2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dg2.AllowUserToAddRows = False
        Me.dg2.AllowUserToDeleteRows = False
        Me.dg2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg2.Location = New System.Drawing.Point(3, 16)
        Me.dg2.Name = "dg2"
        Me.dg2.ReadOnly = True
        Me.dg2.Size = New System.Drawing.Size(606, 248)
        Me.dg2.TabIndex = 0
        '
        'dd
        '
        Me.dd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.dd.Controls.Add(Me.dgv)
        Me.dd.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd.Location = New System.Drawing.Point(954, 299)
        Me.dd.Name = "dd"
        Me.dd.Size = New System.Drawing.Size(374, 215)
        Me.dd.TabIndex = 41
        Me.dd.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.dg2)
        Me.GroupBox3.Location = New System.Drawing.Point(316, 179)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(612, 267)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1171, 56)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "ركز عشان لو جهاز مر بدون تسجيل ده هيبقا تقصير منك فى عملك ياقلبى "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmSony
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.df)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.dd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSony"
        Me.Text = "MFG FG O/P"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.df.ResumeLayout(False)
        Me.df.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dg5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dd.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents txtS_Laber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents df As System.Windows.Forms.GroupBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents cmb_Pcode3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_Pcode_Value As System.Windows.Forms.Label
    Friend WithEvents cmb_Pcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDelete As System.Windows.Forms.TextBox
    Friend WithEvents dg5 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    ' Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFATSERIAL As System.Windows.Forms.TextBox
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents dd As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txteancode As System.Windows.Forms.TextBox
End Class
