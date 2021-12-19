<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LED_BAR_barcode_structure
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LED_BAR_barcode_structure))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_Pcode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Pcode_Value = New System.Windows.Forms.Label()
        Me.btnCHModel = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dg2 = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_Msg = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPARTSSERIAL = New System.Windows.Forms.TextBox()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.btnBACKTOTOP = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFATSERIAL = New System.Windows.Forms.TextBox()
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ggg = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dg5 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ggg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dg5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_Pcode)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_Pcode_Value)
        Me.GroupBox1.Controls.Add(Me.btnCHModel)
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1244, 142)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(848, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(385, 111)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = " "
        '
        'cmb_Pcode
        '
        Me.cmb_Pcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmb_Pcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Pcode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Pcode.FormattingEnabled = True
        Me.cmb_Pcode.Location = New System.Drawing.Point(296, 80)
        Me.cmb_Pcode.Name = "cmb_Pcode"
        Me.cmb_Pcode.Size = New System.Drawing.Size(328, 27)
        Me.cmb_Pcode.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(96, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(695, 45)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = " SCANNING        STAION 3        L C M"
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(132, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PRODUCTION CODE"
        '
        'lbl_Pcode_Value
        '
        Me.lbl_Pcode_Value.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lbl_Pcode_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Pcode_Value.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pcode_Value.Location = New System.Drawing.Point(630, 85)
        Me.lbl_Pcode_Value.Name = "lbl_Pcode_Value"
        Me.lbl_Pcode_Value.Size = New System.Drawing.Size(63, 19)
        Me.lbl_Pcode_Value.TabIndex = 8
        Me.lbl_Pcode_Value.Text = " "
        '
        'btnCHModel
        '
        Me.btnCHModel.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnCHModel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCHModel.Location = New System.Drawing.Point(782, 24)
        Me.btnCHModel.Name = "btnCHModel"
        Me.btnCHModel.Size = New System.Drawing.Size(91, 53)
        Me.btnCHModel.TabIndex = 5
        Me.btnCHModel.Text = "Search Model "
        Me.btnCHModel.UseVisualStyleBackColor = True
        Me.btnCHModel.Visible = False
        '
        'btnStart
        '
        Me.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnStart.Location = New System.Drawing.Point(700, 78)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(91, 29)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'dg1
        '
        Me.dg1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg1.Location = New System.Drawing.Point(3, 16)
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.Size = New System.Drawing.Size(566, 195)
        Me.dg1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox3.Controls.Add(Me.dg2)
        Me.GroupBox3.Location = New System.Drawing.Point(854, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 213)
        Me.GroupBox3.TabIndex = 27
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
        Me.dg2.Size = New System.Drawing.Size(393, 194)
        Me.dg2.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.Location = New System.Drawing.Point(1541, 57)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(10, 24)
        Me.btnLogout.TabIndex = 24
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.ToolToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.ToolToolStripMenuItem.Text = "Tool"
        '
        'lbl_Msg
        '
        Me.lbl_Msg.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lbl_Msg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Msg.BackColor = System.Drawing.Color.Black
        Me.lbl_Msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Msg.Font = New System.Drawing.Font("Tahoma", 47.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Msg.Location = New System.Drawing.Point(0, 525)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Size = New System.Drawing.Size(1265, 169)
        Me.lbl_Msg.TabIndex = 22
        Me.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1265, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox2.Controls.Add(Me.dg1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 214)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(252, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "LED SERIAL :"
        '
        'txtPARTSSERIAL
        '
        Me.txtPARTSSERIAL.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.txtPARTSSERIAL.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPARTSSERIAL.Location = New System.Drawing.Point(378, 45)
        Me.txtPARTSSERIAL.Name = "txtPARTSSERIAL"
        Me.txtPARTSSERIAL.Size = New System.Drawing.Size(347, 27)
        Me.txtPARTSSERIAL.TabIndex = 2
        '
        'btnCLEAR
        '
        Me.btnCLEAR.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnCLEAR.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnCLEAR.Location = New System.Drawing.Point(754, 70)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(104, 27)
        Me.btnCLEAR.TabIndex = 11
        Me.btnCLEAR.Text = "Clear"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnBACKTOTOP
        '
        Me.btnBACKTOTOP.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnBACKTOTOP.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnBACKTOTOP.Location = New System.Drawing.Point(919, 61)
        Me.btnBACKTOTOP.Name = "btnBACKTOTOP"
        Me.btnBACKTOTOP.Size = New System.Drawing.Size(143, 29)
        Me.btnBACKTOTOP.TabIndex = 12
        Me.btnBACKTOTOP.Text = "BACK TO TOP"
        Me.btnBACKTOTOP.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.txtPARTSSERIAL)
        Me.GroupBox5.Controls.Add(Me.btnCLEAR)
        Me.GroupBox5.Controls.Add(Me.btnBACKTOTOP)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtFATSERIAL)
        Me.GroupBox5.Controls.Add(Me.btnSEARCH)
        Me.GroupBox5.Location = New System.Drawing.Point(14, 386)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1239, 127)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(754, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = " "
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(251, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "LED SERIAL :"
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(378, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(347, 27)
        Me.TextBox1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(251, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FAT SERIAL :"
        '
        'txtFATSERIAL
        '
        Me.txtFATSERIAL.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.txtFATSERIAL.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFATSERIAL.Location = New System.Drawing.Point(378, 15)
        Me.txtFATSERIAL.Name = "txtFATSERIAL"
        Me.txtFATSERIAL.Size = New System.Drawing.Size(347, 27)
        Me.txtFATSERIAL.TabIndex = 0
        '
        'btnSEARCH
        '
        Me.btnSEARCH.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.btnSEARCH.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnSEARCH.Location = New System.Drawing.Point(754, 13)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(104, 27)
        Me.btnSEARCH.TabIndex = 8
        Me.btnSEARCH.Text = "Search"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox4.Controls.Add(Me.ggg)
        Me.GroupBox4.Location = New System.Drawing.Point(589, 174)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 98)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        '
        'ggg
        '
        Me.ggg.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.ggg.AllowUserToAddRows = False
        Me.ggg.AllowUserToDeleteRows = False
        Me.ggg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.ggg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ggg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ggg.Location = New System.Drawing.Point(3, 16)
        Me.ggg.Name = "ggg"
        Me.ggg.ReadOnly = True
        Me.ggg.Size = New System.Drawing.Size(242, 79)
        Me.ggg.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.GroupBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox6.Controls.Add(Me.dg5)
        Me.GroupBox6.Location = New System.Drawing.Point(592, 275)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(245, 109)
        Me.GroupBox6.TabIndex = 28
        Me.GroupBox6.TabStop = False
        '
        'dg5
        '
        Me.dg5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.dg5.AllowUserToAddRows = False
        Me.dg5.AllowUserToDeleteRows = False
        Me.dg5.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg5.Location = New System.Drawing.Point(3, 16)
        Me.dg5.Name = "dg5"
        Me.dg5.ReadOnly = True
        Me.dg5.Size = New System.Drawing.Size(239, 90)
        Me.dg5.TabIndex = 0
        '
        'LED_BAR_barcode_structure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1265, 694)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lbl_Msg)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LED_BAR_barcode_structure"
        Me.Text = "شاشة  تسجيل اللد بار - نظم تتبع المنتج - مصنع التلفزيون- مجموعة العربى "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ggg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dg5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Pcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Pcode_Value As System.Windows.Forms.Label
    Friend WithEvents btnCHModel As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_Msg As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPARTSSERIAL As System.Windows.Forms.TextBox
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents btnBACKTOTOP As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFATSERIAL As System.Windows.Forms.TextBox
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    ' Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dg5 As System.Windows.Forms.DataGridView
    Friend WithEvents ggg As System.Windows.Forms.DataGridView
End Class
