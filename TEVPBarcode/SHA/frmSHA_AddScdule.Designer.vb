<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSHA_AddScdule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSHA_AddScdule))
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmonthqty = New System.Windows.Forms.TextBox()
        Me.txtmonthname = New System.Windows.Forms.ComboBox()
        Me.txtstartmonth = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtstartday = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.txxtmodel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtline = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdaliyqty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg1
        '
        Me.dg1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg1.Location = New System.Drawing.Point(3, 22)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(502, 274)
        Me.dg1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dg1)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 249)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(508, 299)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1055, 41)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 520)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add a monthly plan"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dg)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 249)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(508, 299)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'dg
        '
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(3, 22)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(502, 274)
        Me.dg.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtmonthqty)
        Me.GroupBox3.Controls.Add(Me.txtmonthname)
        Me.GroupBox3.Controls.Add(Me.txtstartmonth)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(508, 205)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(332, 17)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 36)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 140)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 36)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(332, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Show Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Month QTY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Month Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start Plan"
        '
        'txtmonthqty
        '
        Me.txtmonthqty.Location = New System.Drawing.Point(126, 112)
        Me.txtmonthqty.Name = "txtmonthqty"
        Me.txtmonthqty.Size = New System.Drawing.Size(200, 26)
        Me.txtmonthqty.TabIndex = 2
        '
        'txtmonthname
        '
        Me.txtmonthname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtmonthname.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtmonthname.FormattingEnabled = True
        Me.txtmonthname.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec"})
        Me.txtmonthname.Location = New System.Drawing.Point(126, 64)
        Me.txtmonthname.Name = "txtmonthname"
        Me.txtmonthname.Size = New System.Drawing.Size(200, 26)
        Me.txtmonthname.TabIndex = 1
        '
        'txtstartmonth
        '
        Me.txtstartmonth.Location = New System.Drawing.Point(126, 20)
        Me.txtstartmonth.Name = "txtstartmonth"
        Me.txtstartmonth.Size = New System.Drawing.Size(200, 26)
        Me.txtstartmonth.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(540, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 520)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add a daily plan"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(13, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(505, 202)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.txtstartday)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Button8)
        Me.TabPage1.Controls.Add(Me.txxtmodel)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtline)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtdaliyqty)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(497, 171)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Production Line"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(383, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 36)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txtstartday
        '
        Me.txtstartday.Location = New System.Drawing.Point(154, 18)
        Me.txtstartday.Name = "txtstartday"
        Me.txtstartday.Size = New System.Drawing.Size(200, 26)
        Me.txtstartday.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(383, 129)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 36)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(383, 47)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 36)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Update"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Line Name"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(383, 87)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 36)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Show Data"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'txxtmodel
        '
        Me.txxtmodel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txxtmodel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txxtmodel.FormattingEnabled = True
        Me.txxtmodel.Location = New System.Drawing.Point(154, 50)
        Me.txxtmodel.Name = "txxtmodel"
        Me.txxtmodel.Size = New System.Drawing.Size(200, 26)
        Me.txxtmodel.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Start Plan"
        '
        'txtline
        '
        Me.txtline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtline.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtline.FormattingEnabled = True
        Me.txtline.Items.AddRange(New Object() {"SHA2_A_1", "SHA2_B_1", "SHA2_C_1", "", "SHA2_A_2", "SHA2_B_2", "SHA2_C_2", "", "SHA2_A_3", "SHA2_B_3", "SHA2_C_3", "", "SHA2_A_4", "SHA2_B_4", "SHA2_C_4", "", "SHA2_A_5", "SHA2_B_5", "SHA2_C_5", " "})
        Me.txtline.Location = New System.Drawing.Point(154, 82)
        Me.txtline.Name = "txtline"
        Me.txtline.Size = New System.Drawing.Size(200, 26)
        Me.txtline.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Model Name"
        '
        'txtdaliyqty
        '
        Me.txtdaliyqty.Location = New System.Drawing.Point(154, 113)
        Me.txtdaliyqty.Name = "txtdaliyqty"
        Me.txtdaliyqty.Size = New System.Drawing.Size(200, 26)
        Me.txtdaliyqty.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = " QTY"
        '
        'frmSHA_AddScdule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1078, 589)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1094, 628)
        Me.Name = "frmSHA_AddScdule"
        Me.Text = "Add Plans Screen - Traceability Systems -  Small Products Factory- Elaraby Group"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtmonthqty As TextBox
    Friend WithEvents txtmonthname As ComboBox
    Friend WithEvents txtstartmonth As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents txtstartday As DateTimePicker
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents txxtmodel As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtline As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdaliyqty As TextBox
    Friend WithEvents Label4 As Label
End Class
