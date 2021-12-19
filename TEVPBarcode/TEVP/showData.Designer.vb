<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class showData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(showData))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dg9 = New System.Windows.Forms.DataGridView()
        Me.btnPCode = New System.Windows.Forms.ComboBox()
        Me.cbl = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dg9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dg9)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(203, 254)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        '
        'dg9
        '
        Me.dg9.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg9.Location = New System.Drawing.Point(3, 16)
        Me.dg9.Name = "dg9"
        Me.dg9.Size = New System.Drawing.Size(197, 235)
        Me.dg9.TabIndex = 0
        '
        'btnPCode
        '
        Me.btnPCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.btnPCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.btnPCode.FormattingEnabled = True
        Me.btnPCode.Location = New System.Drawing.Point(489, 17)
        Me.btnPCode.Name = "btnPCode"
        Me.btnPCode.Size = New System.Drawing.Size(200, 21)
        Me.btnPCode.TabIndex = 30
        '
        'cbl
        '
        Me.cbl.FormattingEnabled = True
        Me.cbl.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cbl.Location = New System.Drawing.Point(92, 17)
        Me.cbl.Name = "cbl"
        Me.cbl.Size = New System.Drawing.Size(200, 21)
        Me.cbl.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(48, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Line"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(325, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "PRODUCTION Model"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dg)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(231, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 353)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'dg
        '
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg.Location = New System.Drawing.Point(3, 45)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(522, 305)
        Me.dg.TabIndex = 0
        '
        'showData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(781, 423)
        Me.Controls.Add(Me.btnPCode)
        Me.Controls.Add(Me.cbl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "showData"
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dg9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dg9 As DataGridView
    Friend WithEvents btnPCode As ComboBox
    Friend WithEvents cbl As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dg As DataGridView
End Class
