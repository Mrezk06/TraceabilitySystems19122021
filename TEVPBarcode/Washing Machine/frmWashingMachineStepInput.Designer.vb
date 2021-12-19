<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWashingMachineStepInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWashingMachineStepInput))
        Me.dgn = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtParts1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtshift = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtline = New System.Windows.Forms.ComboBox()
        Me.cmb_Pcode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Pcode_Value = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.btnBACKTOTOP = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBarcodeThree = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBarcodeOne = New System.Windows.Forms.TextBox()
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtBarcodeTwo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgn
        '
        Me.dgn.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dgn.AllowUserToAddRows = False
        Me.dgn.AllowUserToDeleteRows = False
        Me.dgn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgn.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgn.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgn.Location = New System.Drawing.Point(3, 26)
        Me.dgn.Name = "dgn"
        Me.dgn.ReadOnly = True
        Me.dgn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgn.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgn.RowHeadersWidth = 50
        Me.dgn.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow
        Me.dgn.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgn.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(10)
        Me.dgn.RowTemplate.Height = 50
        Me.dgn.Size = New System.Drawing.Size(568, 157)
        Me.dgn.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.txtParts1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtshift)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtline)
        Me.GroupBox1.Controls.Add(Me.cmb_Pcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_Pcode_Value)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(980, 144)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(343, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(613, 33)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = " SCANNING        STAION 1 Washing Machine"
        Me.Label6.Visible = False
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(32, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 29)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "اقر بالمسئولية"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtParts1
        '
        Me.txtParts1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParts1.Location = New System.Drawing.Point(32, 74)
        Me.txtParts1.Name = "txtParts1"
        Me.txtParts1.Size = New System.Drawing.Size(187, 27)
        Me.txtParts1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(225, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "رقم ساب المسئول"
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(444, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "الخط"
        '
        'txtshift
        '
        Me.txtshift.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtshift.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtshift.FormattingEnabled = True
        Me.txtshift.Items.AddRange(New Object() {"A1", "A2", "A3", "", "B1", "B2", "B3", "", "C1", "C2", "C3"})
        Me.txtshift.Location = New System.Drawing.Point(391, 75)
        Me.txtshift.Name = "txtshift"
        Me.txtshift.Size = New System.Drawing.Size(46, 27)
        Me.txtshift.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(59, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Line"
        Me.Label3.Visible = False
        '
        'txtline
        '
        Me.txtline.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtline.FormattingEnabled = True
        Me.txtline.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.txtline.Location = New System.Drawing.Point(6, 107)
        Me.txtline.Name = "txtline"
        Me.txtline.Size = New System.Drawing.Size(47, 24)
        Me.txtline.TabIndex = 14
        Me.txtline.Visible = False
        '
        'cmb_Pcode
        '
        Me.cmb_Pcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_Pcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Pcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Pcode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Pcode.FormattingEnabled = True
        Me.cmb_Pcode.Location = New System.Drawing.Point(397, 75)
        Me.cmb_Pcode.Name = "cmb_Pcode"
        Me.cmb_Pcode.Size = New System.Drawing.Size(336, 27)
        Me.cmb_Pcode.TabIndex = 10
        Me.cmb_Pcode.Visible = False
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(486, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "الموديل"
        Me.Label1.Visible = False
        '
        'lbl_Pcode_Value
        '
        Me.lbl_Pcode_Value.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lbl_Pcode_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Pcode_Value.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pcode_Value.Location = New System.Drawing.Point(711, 64)
        Me.lbl_Pcode_Value.Name = "lbl_Pcode_Value"
        Me.lbl_Pcode_Value.Size = New System.Drawing.Size(82, 24)
        Me.lbl_Pcode_Value.TabIndex = 8
        Me.lbl_Pcode_Value.Text = " "
        Me.lbl_Pcode_Value.Visible = False
        '
        'btnStart
        '
        Me.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(391, 41)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(93, 29)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "ابداء العمل"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'dg2
        '
        Me.dg2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dg2.AllowUserToAddRows = False
        Me.dg2.AllowUserToDeleteRows = False
        Me.dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg2.DefaultCellStyle = DataGridViewCellStyle5
        Me.dg2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg2.Location = New System.Drawing.Point(3, 26)
        Me.dg2.Name = "dg2"
        Me.dg2.ReadOnly = True
        Me.dg2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg2.RowHeadersWidth = 50
        Me.dg2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow
        Me.dg2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg2.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(10)
        Me.dg2.RowTemplate.Height = 50
        Me.dg2.Size = New System.Drawing.Size(388, 319)
        Me.dg2.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgn)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 186)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lbl_Msg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.Color.Black
        Me.lbl_Msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Msg.Font = New System.Drawing.Font("Tahoma", 47.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Msg.Location = New System.Drawing.Point(8, 527)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(998, 160)
        Me.lbl_Msg.TabIndex = 39
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.Location = New System.Drawing.Point(1539, 58)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(10, 24)
        Me.btnLogout.TabIndex = 40
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox3.Controls.Add(Me.dg2)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(601, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(394, 348)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'btnCLEAR
        '
        Me.btnCLEAR.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnCLEAR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLEAR.Location = New System.Drawing.Point(23, 104)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(104, 40)
        Me.btnCLEAR.TabIndex = 11
        Me.btnCLEAR.Text = "اعادة ادخال الغسالة"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnBACKTOTOP
        '
        Me.btnBACKTOTOP.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnBACKTOTOP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBACKTOTOP.Location = New System.Drawing.Point(23, 59)
        Me.btnBACKTOTOP.Name = "btnBACKTOTOP"
        Me.btnBACKTOTOP.Size = New System.Drawing.Size(104, 40)
        Me.btnBACKTOTOP.TabIndex = 12
        Me.btnBACKTOTOP.Text = "الرجوع لاختيار موديل اخر"
        Me.btnBACKTOTOP.UseVisualStyleBackColor = True
        Me.btnBACKTOTOP.Visible = False
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(30, 543)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 19)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Barcode Three :"
        Me.Label7.Visible = False
        '
        'txtBarcodeThree
        '
        Me.txtBarcodeThree.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.txtBarcodeThree.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeThree.Location = New System.Drawing.Point(171, 539)
        Me.txtBarcodeThree.Name = "txtBarcodeThree"
        Me.txtBarcodeThree.Size = New System.Drawing.Size(268, 23)
        Me.txtBarcodeThree.TabIndex = 37
        Me.txtBarcodeThree.Visible = False
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(457, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "باركود السلة"
        '
        'txtBarcodeOne
        '
        Me.txtBarcodeOne.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.txtBarcodeOne.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeOne.Location = New System.Drawing.Point(183, 32)
        Me.txtBarcodeOne.Name = "txtBarcodeOne"
        Me.txtBarcodeOne.Size = New System.Drawing.Size(268, 27)
        Me.txtBarcodeOne.TabIndex = 0
        '
        'btnSEARCH
        '
        Me.btnSEARCH.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnSEARCH.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnSEARCH.Location = New System.Drawing.Point(23, 15)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(104, 40)
        Me.btnSEARCH.TabIndex = 8
        Me.btnSEARCH.Text = "البحث"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtBarcodeTwo)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.btnCLEAR)
        Me.GroupBox5.Controls.Add(Me.btnBACKTOTOP)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtBarcodeOne)
        Me.GroupBox5.Controls.Add(Me.btnSEARCH)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 358)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(571, 150)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        '
        'txtBarcodeTwo
        '
        Me.txtBarcodeTwo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeTwo.Location = New System.Drawing.Point(183, 80)
        Me.txtBarcodeTwo.Name = "txtBarcodeTwo"
        Me.txtBarcodeTwo.Size = New System.Drawing.Size(268, 27)
        Me.txtBarcodeTwo.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(462, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "باركود الغسالة"
        '
        'frmWashingMachineStepInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1007, 694)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBarcodeThree)
        Me.Controls.Add(Me.GroupBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmWashingMachineStepInput"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشة المرحلة الاولة من التجميع - نظم تتبع المنتج - مصنع الغسالة - مجموعة العربى "
        CType(Me.dgn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgn As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtParts1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtshift As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtline As ComboBox
    Friend WithEvents cmb_Pcode As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Pcode_Value As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents dg2 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_Msg As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnCLEAR As Button
    Friend WithEvents btnBACKTOTOP As Button
    '   Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBarcodeThree As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBarcodeOne As TextBox
    Friend WithEvents btnSEARCH As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtBarcodeTwo As TextBox
    Friend WithEvents Label4 As Label
End Class
