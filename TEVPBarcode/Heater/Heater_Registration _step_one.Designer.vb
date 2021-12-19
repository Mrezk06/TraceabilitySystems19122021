<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Heater_Registration__step_one
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
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(436, 242)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(100, 20)
        Me.Text1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(436, 287)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Heater_Registration__step_one
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(976, 549)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Text1)
        Me.MaximumSize = New System.Drawing.Size(992, 588)
        Me.MinimumSize = New System.Drawing.Size(992, 588)
        Me.Name = "Heater_Registration__step_one"
        Me.Text = "Heater_Registration__step_one"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    '  Friend WithEvents SkinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
