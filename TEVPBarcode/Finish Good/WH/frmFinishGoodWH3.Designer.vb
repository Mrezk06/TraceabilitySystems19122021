<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinishGoodWH3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_Pcode_Value = New System.Windows.Forms.Label()
        Me.cmb_Pcode = New System.Windows.Forms.ComboBox()
        Me.dd = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtS_Laber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.df = New System.Windows.Forms.GroupBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.cmb_Pcode3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.dg5 = New System.Windows.Forms.DataGridView()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.txtFATSERIAL = New System.Windows.Forms.TextBox()
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDelete = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtStoreCode = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.ComboBox()
        Me.txtCustomer = New System.Windows.Forms.ComboBox()
        Me.txtContainer = New System.Windows.Forms.TextBox()
        Me.txtcar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.dd.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.df.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lbl_Pcode_Value)
        Me.GroupBox1.Controls.Add(Me.cmb_Pcode)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(247, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 58)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Model Name"
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(295, 20)
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
        Me.lbl_Pcode_Value.Location = New System.Drawing.Point(297, 23)
        Me.lbl_Pcode_Value.Name = "lbl_Pcode_Value"
        Me.lbl_Pcode_Value.Size = New System.Drawing.Size(63, 23)
        Me.lbl_Pcode_Value.TabIndex = 34
        Me.lbl_Pcode_Value.Text = " "
        Me.lbl_Pcode_Value.Visible = False
        '
        'cmb_Pcode
        '
        Me.cmb_Pcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Pcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Pcode.FormattingEnabled = True
        Me.cmb_Pcode.Location = New System.Drawing.Point(17, 20)
        Me.cmb_Pcode.Name = "cmb_Pcode"
        Me.cmb_Pcode.Size = New System.Drawing.Size(272, 26)
        Me.cmb_Pcode.TabIndex = 2
        '
        'dd
        '
        Me.dd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.dd.Controls.Add(Me.dgv)
        Me.dd.Font = New System.Drawing.Font("Tempus Sans ITC", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dd.Location = New System.Drawing.Point(693, 146)
        Me.dd.Name = "dd"
        Me.dd.Size = New System.Drawing.Size(312, 186)
        Me.dd.TabIndex = 64
        Me.dd.TabStop = False
        '
        'dgv
        '
        Me.dgv.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
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
        Me.dgv.Size = New System.Drawing.Size(306, 160)
        Me.dgv.TabIndex = 40
        '
        'txtS_Laber
        '
        Me.txtS_Laber.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtS_Laber.Location = New System.Drawing.Point(93, 36)
        Me.txtS_Laber.Name = "txtS_Laber"
        Me.txtS_Laber.Size = New System.Drawing.Size(187, 29)
        Me.txtS_Laber.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Sap_Num"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 90)
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
        Me.df.Location = New System.Drawing.Point(693, 161)
        Me.df.Name = "df"
        Me.df.Size = New System.Drawing.Size(306, 168)
        Me.df.TabIndex = 74
        Me.df.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(93, 138)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(187, 29)
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
        Me.cmb_Pcode3.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmb_Pcode3.Location = New System.Drawing.Point(93, 86)
        Me.cmb_Pcode3.Name = "cmb_Pcode3"
        Me.cmb_Pcode3.Size = New System.Drawing.Size(187, 29)
        Me.cmb_Pcode3.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.dg2)
        Me.GroupBox3.Location = New System.Drawing.Point(247, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 237)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
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
        Me.dg2.Size = New System.Drawing.Size(434, 218)
        Me.dg2.TabIndex = 0
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
        Me.dg5.Size = New System.Drawing.Size(306, 115)
        Me.dg5.TabIndex = 41
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lbl_Msg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.Color.Black
        Me.lbl_Msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Msg.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(11, 364)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(1008, 131)
        Me.lbl_Msg.TabIndex = 66
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.Location = New System.Drawing.Point(1543, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(10, 24)
        Me.btnLogout.TabIndex = 68
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'txtFATSERIAL
        '
        Me.txtFATSERIAL.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.txtFATSERIAL.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFATSERIAL.Location = New System.Drawing.Point(98, 16)
        Me.txtFATSERIAL.Name = "txtFATSERIAL"
        Me.txtFATSERIAL.Size = New System.Drawing.Size(253, 30)
        Me.txtFATSERIAL.TabIndex = 3
        '
        'btnSEARCH
        '
        Me.btnSEARCH.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnSEARCH.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSEARCH.Location = New System.Drawing.Point(353, 15)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(82, 30)
        Me.btnSEARCH.TabIndex = 8
        Me.btnSEARCH.Text = "Search"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtFATSERIAL)
        Me.GroupBox5.Controls.Add(Me.btnSEARCH)
        Me.GroupBox5.Location = New System.Drawing.Point(246, 300)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(440, 59)
        Me.GroupBox5.TabIndex = 71
        Me.GroupBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " SERIAL :"
        '
        'txtDelete
        '
        Me.txtDelete.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDelete.Location = New System.Drawing.Point(9, 21)
        Me.txtDelete.Name = "txtDelete"
        Me.txtDelete.Size = New System.Drawing.Size(206, 29)
        Me.txtDelete.TabIndex = 36
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox4.Controls.Add(Me.txtDelete)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 65)
        Me.GroupBox4.TabIndex = 72
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delete"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox2.Controls.Add(Me.dg5)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(693, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 140)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total for day"
        '
        'Button3
        '
        Me.Button3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(155, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 30)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "Hide"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(11, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 30)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox6.Controls.Add(Me.txtStoreCode)
        Me.GroupBox6.Controls.Add(Me.txtCompany)
        Me.GroupBox6.Controls.Add(Me.txtCustomer)
        Me.GroupBox6.Controls.Add(Me.txtContainer)
        Me.GroupBox6.Controls.Add(Me.txtcar)
        Me.GroupBox6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(229, 221)
        Me.GroupBox6.TabIndex = 76
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Data for Use"
        '
        'txtStoreCode
        '
        Me.txtStoreCode.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoreCode.Location = New System.Drawing.Point(12, 177)
        Me.txtStoreCode.Name = "txtStoreCode"
        Me.txtStoreCode.Size = New System.Drawing.Size(206, 28)
        Me.txtStoreCode.TabIndex = 41
        Me.txtStoreCode.Text = "Store code"
        '
        'txtCompany
        '
        Me.txtCompany.FormattingEnabled = True
        Me.txtCompany.Location = New System.Drawing.Point(12, 71)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(206, 24)
        Me.txtCompany.TabIndex = 40
        Me.txtCompany.Text = "Company"
        '
        'txtCustomer
        '
        Me.txtCustomer.FormattingEnabled = True
        Me.txtCustomer.Location = New System.Drawing.Point(12, 39)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(206, 24)
        Me.txtCustomer.TabIndex = 39
        Me.txtCustomer.Text = "Customer"
        '
        'txtContainer
        '
        Me.txtContainer.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContainer.Location = New System.Drawing.Point(12, 143)
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.Size = New System.Drawing.Size(206, 27)
        Me.txtContainer.TabIndex = 37
        Me.txtContainer.Text = "Container"
        '
        'txtcar
        '
        Me.txtcar.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcar.Location = New System.Drawing.Point(12, 104)
        Me.txtcar.Name = "txtcar"
        Me.txtcar.Size = New System.Drawing.Size(206, 27)
        Me.txtcar.TabIndex = 36
        Me.txtcar.Text = "Car"
        '
        'frmFinishGoodWH3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1008, 504)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dd)
        Me.Controls.Add(Me.df)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmFinishGoodWH3"
        Me.Text = "FG Shipping "
        Me.GroupBox1.ResumeLayout(False)
        Me.dd.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.df.ResumeLayout(False)
        Me.df.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_Pcode_Value As System.Windows.Forms.Label
    Friend WithEvents cmb_Pcode As System.Windows.Forms.ComboBox
    Friend WithEvents dd As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents txtS_Laber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents df As System.Windows.Forms.GroupBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents cmb_Pcode3 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents dg5 As System.Windows.Forms.DataGridView
    '   Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents txtFATSERIAL As System.Windows.Forms.TextBox
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDelete As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcar As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents txtStoreCode As System.Windows.Forms.TextBox
End Class
