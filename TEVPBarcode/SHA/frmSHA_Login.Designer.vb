﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSHA_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSHA_Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.cmb_Pcode = New System.Windows.Forms.ComboBox()
        Me.txttype = New System.Windows.Forms.ComboBox()
        Me.UsernameTextBox = New System.Windows.Forms.ComboBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.cmb_Pcode)
        Me.GroupBox1.Controls.Add(Me.txttype)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(Me.OK)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 136)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(433, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "صلاحيات المستخدمين"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PasswordLabel.Location = New System.Drawing.Point(433, 62)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(186, 23)
        Me.PasswordLabel.TabIndex = 47
        Me.PasswordLabel.Text = "كلمة المرور"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UsernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UsernameLabel.Location = New System.Drawing.Point(433, 24)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(186, 23)
        Me.UsernameLabel.TabIndex = 46
        Me.UsernameLabel.Text = "أسم المستخدم"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_Pcode
        '
        Me.cmb_Pcode.FormattingEnabled = True
        Me.cmb_Pcode.Location = New System.Drawing.Point(537, 61)
        Me.cmb_Pcode.Name = "cmb_Pcode"
        Me.cmb_Pcode.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Pcode.TabIndex = 37
        Me.cmb_Pcode.Visible = False
        '
        'txttype
        '
        Me.txttype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txttype.FormattingEnabled = True
        Me.txttype.Items.AddRange(New Object() {"Admin", "MFG_InPut", "MFG_OutPut", "Repair", "FinishGood", "DashBoard", "Add_Schedule", "Add_Model", "Add_DatToRepair"})
        Me.txttype.Location = New System.Drawing.Point(156, 96)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(270, 28)
        Me.txttype.TabIndex = 35
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.FormattingEnabled = True
        Me.UsernameTextBox.Location = New System.Drawing.Point(156, 26)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(270, 28)
        Me.UsernameTextBox.TabIndex = 29
        '
        'OK
        '
        Me.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OK.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OK.Location = New System.Drawing.Point(20, 55)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(117, 69)
        Me.OK.TabIndex = 31
        Me.OK.Text = "دخول"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(156, 61)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(270, 26)
        Me.PasswordTextBox.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 48)
        Me.Panel2.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(614, 25)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "شاشة الدخول - نظم تتبع المنتج - مصنع المنتجات الصغيرة - مجموعة العربى "
        '
        'frmSHA_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(703, 216)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSHA_Login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشة تسجيل الدخول - نظم تتبع المنتج - مصنع المنتجات الصغيرة - مجموعة العربى "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_Pcode As ComboBox
    Friend WithEvents txttype As ComboBox
    Friend WithEvents UsernameTextBox As ComboBox
    Friend WithEvents OK As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    '  Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
