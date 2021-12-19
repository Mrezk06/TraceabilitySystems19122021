<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newshowforData
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtcurrentCout = New System.Windows.Forms.ComboBox()
        Me.txtModelName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Pcode_Value = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Count_Target = New System.Windows.Forms.ComboBox()
        Me.Mlbl = New System.Windows.Forms.Label()
        Me.txtstartTime = New System.Windows.Forms.TextBox()
        Me.EndTime = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLine = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblline = New System.Windows.Forms.Label()
        '  Me.SkinEngine1 = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Qty Target"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(28, 211)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Currnt  Qty"
        Me.Label3.Visible = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'txtcurrentCout
        '
        Me.txtcurrentCout.FormattingEnabled = True
        Me.txtcurrentCout.Location = New System.Drawing.Point(15, 324)
        Me.txtcurrentCout.Name = "txtcurrentCout"
        Me.txtcurrentCout.Size = New System.Drawing.Size(121, 21)
        Me.txtcurrentCout.TabIndex = 4
        Me.txtcurrentCout.Visible = False
        '
        'txtModelName
        '
        Me.txtModelName.FormattingEnabled = True
        Me.txtModelName.Location = New System.Drawing.Point(11, 138)
        Me.txtModelName.Name = "txtModelName"
        Me.txtModelName.Size = New System.Drawing.Size(120, 21)
        Me.txtModelName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Model Name"
        '
        'lbl_Pcode_Value
        '
        Me.lbl_Pcode_Value.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lbl_Pcode_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Pcode_Value.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pcode_Value.Location = New System.Drawing.Point(170, 204)
        Me.lbl_Pcode_Value.Name = "lbl_Pcode_Value"
        Me.lbl_Pcode_Value.Size = New System.Drawing.Size(270, 57)
        Me.lbl_Pcode_Value.TabIndex = 9
        Me.lbl_Pcode_Value.Text = " "
        Me.lbl_Pcode_Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(169, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 57)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = " "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 57)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = " "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Count_Target
        '
        Me.txt_Count_Target.FormattingEnabled = True
        Me.txt_Count_Target.Location = New System.Drawing.Point(12, 93)
        Me.txt_Count_Target.Name = "txt_Count_Target"
        Me.txt_Count_Target.Size = New System.Drawing.Size(121, 21)
        Me.txt_Count_Target.TabIndex = 15
        '
        'Mlbl
        '
        Me.Mlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Mlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mlbl.Location = New System.Drawing.Point(190, 285)
        Me.Mlbl.Name = "Mlbl"
        Me.Mlbl.Size = New System.Drawing.Size(120, 37)
        Me.Mlbl.TabIndex = 16
        Me.Mlbl.Text = " "
        Me.Mlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Mlbl.Visible = False
        '
        'txtstartTime
        '
        Me.txtstartTime.Location = New System.Drawing.Point(22, 344)
        Me.txtstartTime.Name = "txtstartTime"
        Me.txtstartTime.Size = New System.Drawing.Size(120, 20)
        Me.txtstartTime.TabIndex = 17
        Me.txtstartTime.Visible = False
        '
        'EndTime
        '
        Me.EndTime.Location = New System.Drawing.Point(268, 325)
        Me.EndTime.Name = "EndTime"
        Me.EndTime.Size = New System.Drawing.Size(121, 20)
        Me.EndTime.TabIndex = 18
        Me.EndTime.Visible = False
        '
        'Timer3
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(142, 325)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 57)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Model Name "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Label7
        '
        Me.Label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 57)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Target Production"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 57)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Actually Production"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 40)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "New Model"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(170, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(270, 57)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = " "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 57)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Diff"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.Visible = False
        '
        'txtLine
        '
        Me.txtLine.FormattingEnabled = True
        Me.txtLine.Items.AddRange(New Object() {"1A", "1B", "1C", "---", "2A", "2B", "2C", "---", "3A", "3B", "3C", "---", "4A", "4B", "4C", "---", "5A", "5B", "5C"})
        Me.txtLine.Location = New System.Drawing.Point(10, 181)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.Size = New System.Drawing.Size(121, 21)
        Me.txtLine.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Line Name"
        '
        'Timer4
        '
        '
        'Label12
        '
        Me.Label12.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(202, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 68)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "L"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblline
        '
        Me.lblline.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.lblline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblline.Font = New System.Drawing.Font("Elephant", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblline.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblline.Location = New System.Drawing.Point(305, 5)
        Me.lblline.Name = "lblline"
        Me.lblline.Size = New System.Drawing.Size(108, 68)
        Me.lblline.TabIndex = 29
        Me.lblline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SkinEngine1
        '
        'Me.SkinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText
        'Me.SkinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText
        'Me.SkinEngine1.SerialNumber = ""
        'Me.SkinEngine1.SkinFile = Nothing
        '
        'newshowforData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 339)
        Me.Controls.Add(Me.txtLine)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtModelName)
        Me.Controls.Add(Me.EndTime)
        Me.Controls.Add(Me.lblline)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtstartTime)
        Me.Controls.Add(Me.txt_Count_Target)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Pcode_Value)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcurrentCout)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mlbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(562, 378)
        Me.Name = "newshowforData"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.ShowIcon = False
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtcurrentCout As ComboBox
    Friend WithEvents txtModelName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_Pcode_Value As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Count_Target As System.Windows.Forms.ComboBox
    Friend WithEvents Mlbl As System.Windows.Forms.Label
    Friend WithEvents txtstartTime As System.Windows.Forms.TextBox
    Friend WithEvents EndTime As System.Windows.Forms.TextBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLine As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblline As System.Windows.Forms.Label
    '  Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    '  Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
End Class
