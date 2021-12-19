<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmarduino
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.clear_BTN = New System.Windows.Forms.Button()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(38, 54)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.comPort_ComboBox.TabIndex = 0
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Location = New System.Drawing.Point(68, 29)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(55, 13)
        Me.Timer_LBL.TabIndex = 2
        Me.Timer_LBL.Text = "Timer_LBL"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(219, 26)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(146, 222)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'clear_BTN
        '
        Me.clear_BTN.Location = New System.Drawing.Point(264, 270)
        Me.clear_BTN.Name = "clear_BTN"
        Me.clear_BTN.Size = New System.Drawing.Size(75, 23)
        Me.clear_BTN.TabIndex = 4
        Me.clear_BTN.Text = "clear_BTN"
        Me.clear_BTN.UseVisualStyleBackColor = True
        '
        'connect_BTN
        '
        Me.connect_BTN.Location = New System.Drawing.Point(59, 94)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(75, 23)
        Me.connect_BTN.TabIndex = 5
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'frmarduino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 322)
        Me.Controls.Add(Me.connect_BTN)
        Me.Controls.Add(Me.clear_BTN)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Name = "frmarduino"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents comPort_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Timer_LBL As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents clear_BTN As System.Windows.Forms.Button
    Friend WithEvents connect_BTN As System.Windows.Forms.Button
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
End Class
