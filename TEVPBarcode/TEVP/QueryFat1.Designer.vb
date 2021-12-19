<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QueryFat1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QueryFat1))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotime = New System.Windows.Forms.ComboBox()
        Me.txtfromTime = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPCode = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dg6 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFATSERIAL = New System.Windows.Forms.TextBox()
        Me.btnsearch1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.dtpFROMDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dg9 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dg9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 19)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "TO Time"
        '
        'txttotime
        '
        Me.txttotime.FormattingEnabled = True
        Me.txttotime.Items.AddRange(New Object() {"01:00:00", "01:30:00", "02:00:00", "02:30:00", "03:00:00", "03:30:00", "04:00:00", "04:30:00", "05:00:00", "05:30:00", "06:00:00", "06:30:00", "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00", "18:30:00", "19:00:00", "19:30:00", "20:00:00", "20:30:00", "21:00:00", "21:30:00", "22:00:00", "22:30:00", "23:00:00", "23:30:00"})
        Me.txttotime.Location = New System.Drawing.Point(124, 125)
        Me.txttotime.Name = "txttotime"
        Me.txttotime.Size = New System.Drawing.Size(143, 21)
        Me.txttotime.TabIndex = 28
        '
        'txtfromTime
        '
        Me.txtfromTime.FormattingEnabled = True
        Me.txtfromTime.Items.AddRange(New Object() {"01:15:00", "01:30:00", "01:45:00", "01:59:59", "02:15:00", "02:30:00", "02:45:00", "02:59:59", "03:15:00", "03:30:00", "03:45:00", "03:59:59", "04:15:00", "04:30:00", "04:45:00", "04:59:59", "05:15:00", "05:30:00", "05:45:00", "05:59:59", "06:15:00", "06:30:00", "06:45:00", "06:59:59", "07:15:00", "07:30:00", "07:45:00", "07:59:59", "08:15:00", "08:30:00", "08:45:00", "08:59:59", "09:15:00", "09:30:00", "09:45:00", "09:59:59", "10:15:00", "10:30:00", "10:45:00", "10:59:59", "11:15:00", "11:30:00", "11:45:00", "11:59:59", "12:15:00", "12:30:00", "12:45:00", "12:59:59", "13:15:00", "13:30:00", "13:45:00", "13:59:59", "14:15:00", "14:30:00", "14:45:00", "14:59:59", "15:15:00", "15:30:00", "15:45:00", "15:59:59", "16:15:00", "16:30:00", "16:45:00", "16:59:59", "17:15:00", "17:30:00", "17:45:00", "17:59:59", "18:15:00", "18:30:00", "18:45:00", "18:59:59", "19:15:00", "19:30:00", "19:45:00", "19:59:59", "20:15:00", "20:30:00", "20:45:00", "20:59:59", "21:15:00", "21:30:00", "21:45:00", "21:59:59", "22:15:00", "22:30:00", "22:45:00", "22:59:59", "23:15:00", "23:30:00", "23:45:00", "23:59:59"})
        Me.txtfromTime.Location = New System.Drawing.Point(124, 152)
        Me.txtfromTime.Name = "txtfromTime"
        Me.txtfromTime.Size = New System.Drawing.Size(143, 21)
        Me.txtfromTime.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txttotime)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtfromTime)
        Me.GroupBox1.Controls.Add(Me.btnPCode)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbl)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnReport)
        Me.GroupBox1.Controls.Add(Me.btnSEARCH)
        Me.GroupBox1.Controls.Add(Me.dtpFROMDATE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(645, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 328)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(306, 20)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "To  Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "FROM Time"
        '
        'btnPCode
        '
        Me.btnPCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.btnPCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.btnPCode.FormattingEnabled = True
        Me.btnPCode.Location = New System.Drawing.Point(230, 218)
        Me.btnPCode.Name = "btnPCode"
        Me.btnPCode.Size = New System.Drawing.Size(200, 21)
        Me.btnPCode.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(353, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(326, 33)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Search Model , Line , Date And Time"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbl
        '
        Me.cbl.FormattingEnabled = True
        Me.cbl.Items.AddRange(New Object() {"1A", "1B", "1C", "--", "2A", "2B", "2C", "--", "3A", "3B", "3C", "--", "4A", "4B", "4C", "--", "5A", "5B", "5C"})
        Me.cbl.Location = New System.Drawing.Point(230, 189)
        Me.cbl.Name = "cbl"
        Me.cbl.Size = New System.Drawing.Size(200, 21)
        Me.cbl.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(182, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Line"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dg6)
        Me.GroupBox4.Location = New System.Drawing.Point(450, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(229, 98)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        '
        'dg6
        '
        Me.dg6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg6.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dg6.Location = New System.Drawing.Point(3, 16)
        Me.dg6.Name = "dg6"
        Me.dg6.Size = New System.Drawing.Size(223, 79)
        Me.dg6.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtFATSERIAL)
        Me.GroupBox3.Controls.Add(Me.btnsearch1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 48)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FAT  SERIAL"
        '
        'txtFATSERIAL
        '
        Me.txtFATSERIAL.Location = New System.Drawing.Point(118, 19)
        Me.txtFATSERIAL.Name = "txtFATSERIAL"
        Me.txtFATSERIAL.Size = New System.Drawing.Size(200, 20)
        Me.txtFATSERIAL.TabIndex = 8
        '
        'btnsearch1
        '
        Me.btnsearch1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch1.Location = New System.Drawing.Point(324, 16)
        Me.btnsearch1.Name = "btnsearch1"
        Me.btnsearch1.Size = New System.Drawing.Size(97, 27)
        Me.btnsearch1.TabIndex = 17
        Me.btnsearch1.Text = "Search"
        Me.btnsearch1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "PRODUCTION Model"
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(453, 129)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(223, 39)
        Me.btnReport.TabIndex = 16
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnSEARCH
        '
        Me.btnSEARCH.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSEARCH.Location = New System.Drawing.Point(285, 125)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(145, 46)
        Me.btnSEARCH.TabIndex = 15
        Me.btnSEARCH.Text = "Search Date "
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'dtpFROMDATE
        '
        Me.dtpFROMDATE.Location = New System.Drawing.Point(124, 73)
        Me.dtpFROMDATE.Name = "dtpFROMDATE"
        Me.dtpFROMDATE.Size = New System.Drawing.Size(306, 20)
        Me.dtpFROMDATE.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = " From Date"
        '
        'dg
        '
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(3, 16)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(690, 311)
        Me.dg.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dg)
        Me.GroupBox2.Location = New System.Drawing.Point(645, 342)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 330)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.dg9)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(616, 664)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        '
        'dg9
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        Me.dg9.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg9.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dg9.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg9.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg9.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg9.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg9.Location = New System.Drawing.Point(3, 16)
        Me.dg9.Name = "dg9"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg9.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg9.RowHeadersWidth = 120
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10)
        Me.dg9.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg9.RowTemplate.DividerHeight = 18
        Me.dg9.RowTemplate.Height = 70
        Me.dg9.Size = New System.Drawing.Size(610, 645)
        Me.dg9.TabIndex = 0
        '
        'Timer1
        '
        '
        'QueryFat1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1354, 680)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QueryFat1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dg9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txttotime As ComboBox
    Friend WithEvents txtfromTime As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnPCode As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbl As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dg6 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFATSERIAL As TextBox
    Friend WithEvents btnsearch1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents btnSEARCH As Button
    Friend WithEvents dtpFROMDATE As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dg As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    '  Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dg9 As System.Windows.Forms.DataGridView
End Class
