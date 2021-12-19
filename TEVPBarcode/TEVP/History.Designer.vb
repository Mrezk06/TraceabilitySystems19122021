<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.dtpTODATE = New System.Windows.Forms.DateTimePicker()
        Me.dtpFROMDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.dtpTODATE)
        Me.GroupBox1.Controls.Add(Me.dtpFROMDATE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1182, 231)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnPCode
        '
        Me.btnPCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.btnPCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.btnPCode.FormattingEnabled = True
        Me.btnPCode.Location = New System.Drawing.Point(281, 135)
        Me.btnPCode.Name = "btnPCode"
        Me.btnPCode.Size = New System.Drawing.Size(200, 21)
        Me.btnPCode.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(808, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 108)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Search Model And Line"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbl
        '
        Me.cbl.FormattingEnabled = True
        Me.cbl.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbl.Location = New System.Drawing.Point(281, 106)
        Me.cbl.Name = "cbl"
        Me.cbl.Size = New System.Drawing.Size(200, 21)
        Me.cbl.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(219, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Line"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dg6)
        Me.GroupBox4.Location = New System.Drawing.Point(939, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 98)
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
        Me.dg6.Size = New System.Drawing.Size(231, 79)
        Me.dg6.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtFATSERIAL)
        Me.GroupBox3.Controls.Add(Me.btnsearch1)
        Me.GroupBox3.Location = New System.Drawing.Point(161, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(665, 48)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "FAT  SERIAL"
        '
        'txtFATSERIAL
        '
        Me.txtFATSERIAL.Location = New System.Drawing.Point(120, 18)
        Me.txtFATSERIAL.Name = "txtFATSERIAL"
        Me.txtFATSERIAL.Size = New System.Drawing.Size(200, 20)
        Me.txtFATSERIAL.TabIndex = 8
        '
        'btnsearch1
        '
        Me.btnsearch1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnsearch1.Location = New System.Drawing.Point(370, 15)
        Me.btnsearch1.Name = "btnsearch1"
        Me.btnsearch1.Size = New System.Drawing.Size(103, 27)
        Me.btnsearch1.TabIndex = 17
        Me.btnsearch1.Text = "Search"
        Me.btnsearch1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(113, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "PRODUCTION Model"
        '
        'btnsearchModel
        '
        Me.btnsearchModel.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btnsearchModel.Location = New System.Drawing.Point(671, 134)
        Me.btnsearchModel.Name = "btnsearchModel"
        Me.btnsearchModel.Size = New System.Drawing.Size(103, 81)
        Me.btnsearchModel.TabIndex = 18
        Me.btnsearchModel.Text = "Search Model"
        Me.btnsearchModel.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnReport.Location = New System.Drawing.Point(971, 163)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(106, 52)
        Me.btnReport.TabIndex = 16
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnSEARCH
        '
        Me.btnSEARCH.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnSEARCH.Location = New System.Drawing.Point(531, 163)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(103, 52)
        Me.btnSEARCH.TabIndex = 15
        Me.btnSEARCH.Text = "Search Day"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'dtpTODATE
        '
        Me.dtpTODATE.Location = New System.Drawing.Point(281, 195)
        Me.dtpTODATE.Name = "dtpTODATE"
        Me.dtpTODATE.Size = New System.Drawing.Size(200, 20)
        Me.dtpTODATE.TabIndex = 14
        '
        'dtpFROMDATE
        '
        Me.dtpFROMDATE.Location = New System.Drawing.Point(281, 162)
        Me.dtpFROMDATE.Name = "dtpFROMDATE"
        Me.dtpFROMDATE.Size = New System.Drawing.Size(200, 20)
        Me.dtpFROMDATE.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(180, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TO DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(174, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "FROM DATE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dg)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1181, 238)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dg
        '
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(3, 16)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(1175, 219)
        Me.dg.TabIndex = 0
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1206, 491)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "History"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFATSERIAL As System.Windows.Forms.TextBox
    Friend WithEvents dtpTODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFROMDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btnsearch1 As System.Windows.Forms.Button
    Friend WithEvents btnsearchModel As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dg6 As System.Windows.Forms.DataGridView
    ' Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents Button1 As Button
    Friend WithEvents cbl As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnPCode As ComboBox
End Class
