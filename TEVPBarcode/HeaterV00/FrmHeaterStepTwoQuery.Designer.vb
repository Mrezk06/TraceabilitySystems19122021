<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHeaterStepTwoQuery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHeaterStepTwoQuery))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotime = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfromTime = New System.Windows.Forms.ComboBox()
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
        Me.btnsearchModel = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnSEARCH = New System.Windows.Forms.Button()
        Me.dtpFROMDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg9 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox1.Controls.Add(Me.btnsearchModel)
        Me.GroupBox1.Controls.Add(Me.btnReport)
        Me.GroupBox1.Controls.Add(Me.btnSEARCH)
        Me.GroupBox1.Controls.Add(Me.dtpFROMDATE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1182, 224)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(516, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 19)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "TO Time"
        '
        'txttotime
        '
        Me.txttotime.FormattingEnabled = True
        Me.txttotime.Items.AddRange(New Object() {"01:00:00", "01:30:00", "02:00:00", "02:30:00", "03:00:00", "03:30:00", "04:00:00", "04:30:00", "05:00:00", "05:30:00", "06:00:00", "06:30:00", "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:00:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00", "18:30:00", "19:00:00", "19:30:00", "20:00:00", "20:30:00", "21:00:00", "21:30:00", "22:00:00", "22:30:00", "23:00:00", "23:30:00"})
        Me.txttotime.Location = New System.Drawing.Point(593, 101)
        Me.txttotime.Name = "txttotime"
        Me.txttotime.Size = New System.Drawing.Size(117, 21)
        Me.txttotime.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(495, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "FROM Time"
        '
        'txtfromTime
        '
        Me.txtfromTime.FormattingEnabled = True
        Me.txtfromTime.Items.AddRange(New Object() {"01:15:00", "01:30:00", "01:45:00", "01:59:59", "02:15:00", "02:30:00", "02:45:00", "02:59:59", "03:15:00", "03:30:00", "03:45:00", "03:59:59", "04:15:00", "04:30:00", "04:45:00", "04:59:59", "05:15:00", "05:30:00", "05:45:00", "05:59:59", "06:15:00", "06:30:00", "06:45:00", "06:59:59", "07:15:00", "07:30:00", "07:45:00", "07:59:59", "08:15:00", "08:30:00", "08:45:00", "08:59:59", "09:15:00", "09:30:00", "09:45:00", "09:59:59", "10:15:00", "10:30:00", "10:45:00", "10:59:59", "11:15:00", "11:30:00", "11:45:00", "11:59:59", "12:15:00", "12:30:00", "12:45:00", "12:59:59", "13:15:00", "13:30:00", "13:45:00", "13:59:59", "14:15:00", "14:30:00", "14:45:00", "14:59:59", "15:15:00", "15:30:00", "15:45:00", "15:59:59", "16:15:00", "16:30:00", "16:45:00", "16:59:59", "17:15:00", "17:30:00", "17:45:00", "17:59:59", "18:15:00", "18:30:00", "18:45:00", "18:59:59", "19:15:00", "19:30:00", "19:45:00", "19:59:59", "20:15:00", "20:30:00", "20:45:00", "20:59:59", "21:15:00", "21:30:00", "21:45:00", "21:59:59", "22:15:00", "22:30:00", "22:45:00", "22:59:59", "23:15:00", "23:30:00", "23:45:00", "23:59:59"})
        Me.txtfromTime.Location = New System.Drawing.Point(594, 127)
        Me.txtfromTime.Name = "txtfromTime"
        Me.txtfromTime.Size = New System.Drawing.Size(117, 21)
        Me.txtfromTime.TabIndex = 27
        '
        'btnPCode
        '
        Me.btnPCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.btnPCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.btnPCode.FormattingEnabled = True
        Me.btnPCode.Location = New System.Drawing.Point(281, 130)
        Me.btnPCode.Name = "btnPCode"
        Me.btnPCode.Size = New System.Drawing.Size(200, 21)
        Me.btnPCode.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(499, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(354, 51)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Search Model , Line , Date And Time"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbl
        '
        Me.cbl.FormattingEnabled = True
        Me.cbl.Items.AddRange(New Object() {"H1", "A1", "A2", "A3", "A4", "A5", "", "B1", "B2", "B3", "B4", "B5", "", "C1", "C2", "C3", "C4", "C5"})
        Me.cbl.Location = New System.Drawing.Point(281, 101)
        Me.cbl.Name = "cbl"
        Me.cbl.Size = New System.Drawing.Size(200, 21)
        Me.cbl.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(233, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Line"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.dg6)
        Me.GroupBox4.Location = New System.Drawing.Point(939, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 110)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        '
        'dg6
        '
        Me.dg6.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg6.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dg6.Location = New System.Drawing.Point(3, 16)
        Me.dg6.Name = "dg6"
        Me.dg6.Size = New System.Drawing.Size(231, 91)
        Me.dg6.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtFATSERIAL)
        Me.GroupBox3.Controls.Add(Me.btnsearch1)
        Me.GroupBox3.Location = New System.Drawing.Point(117, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(736, 55)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(36, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Heater  SERIAL"
        '
        'txtFATSERIAL
        '
        Me.txtFATSERIAL.Location = New System.Drawing.Point(164, 17)
        Me.txtFATSERIAL.Multiline = True
        Me.txtFATSERIAL.Name = "txtFATSERIAL"
        Me.txtFATSERIAL.Size = New System.Drawing.Size(200, 28)
        Me.txtFATSERIAL.TabIndex = 8
        '
        'btnsearch1
        '
        Me.btnsearch1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnsearch1.Location = New System.Drawing.Point(370, 16)
        Me.btnsearch1.Name = "btnsearch1"
        Me.btnsearch1.Size = New System.Drawing.Size(103, 29)
        Me.btnsearch1.TabIndex = 17
        Me.btnsearch1.Text = "Search"
        Me.btnsearch1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(113, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "PRODUCTION Model"
        '
        'btnsearchModel
        '
        Me.btnsearchModel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchModel.Location = New System.Drawing.Point(225, 159)
        Me.btnsearchModel.Name = "btnsearchModel"
        Me.btnsearchModel.Size = New System.Drawing.Size(256, 52)
        Me.btnsearchModel.TabIndex = 18
        Me.btnsearchModel.Text = "Search Model , Date And Time"
        Me.btnsearchModel.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnReport.Location = New System.Drawing.Point(942, 159)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(106, 52)
        Me.btnReport.TabIndex = 16
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnSEARCH
        '
        Me.btnSEARCH.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnSEARCH.Location = New System.Drawing.Point(717, 101)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(136, 49)
        Me.btnSEARCH.TabIndex = 15
        Me.btnSEARCH.Text = "Search Date And Time"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'dtpFROMDATE
        '
        Me.dtpFROMDATE.Location = New System.Drawing.Point(594, 73)
        Me.dtpFROMDATE.Name = "dtpFROMDATE"
        Me.dtpFROMDATE.Size = New System.Drawing.Size(259, 20)
        Me.dtpFROMDATE.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(527, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = " DATE"
        '
        'dg9
        '
        Me.dg9.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg9.Location = New System.Drawing.Point(3, 16)
        Me.dg9.Name = "dg9"
        Me.dg9.Size = New System.Drawing.Size(327, 222)
        Me.dg9.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dg)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(842, 245)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'dg
        '
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(3, 16)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(836, 226)
        Me.dg.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.dg9)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(333, 241)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        '
        'FrmHeaterStepTwoQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1206, 494)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHeaterStepTwoQuery"
        Me.Text = "شاشة أستعلام الخطوة الثانية - نظم تتبع المنتج - مصنع السخان  - مجموعة العربى "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttotime As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfromTime As System.Windows.Forms.ComboBox
    Friend WithEvents btnPCode As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbl As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dg6 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFATSERIAL As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsearchModel As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents dtpFROMDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dg9 As System.Windows.Forms.DataGridView
    '    Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
End Class
