﻿Imports TEVPBarcode.DataSet1TableAdapters

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptRdlc
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptRdlc))
        Me.ResturantalldataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.barcodeDataSet = New TEVPBarcode.barcodeDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ResturantalldataTableAdapter = New ResturantalldataTableAdapter()
        CType(Me.ResturantalldataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barcodeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResturantalldataBindingSource
        '
        Me.ResturantalldataBindingSource.DataMember = "Resturantalldata"
        Me.ResturantalldataBindingSource.DataSource = Me.barcodeDataSet
        '
        'barcodeDataSet
        '
        Me.barcodeDataSet.DataSetName = "barcodeDataSet"
        Me.barcodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ResturantalldataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TEVPBarcode.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(697, 434)
        Me.ReportViewer1.TabIndex = 0
        '
        'ResturantalldataTableAdapter
        '
        Me.ResturantalldataTableAdapter.ClearBeforeFill = True
        '
        'rptRdlc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 434)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rptRdlc"
        CType(Me.ResturantalldataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barcodeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ResturantalldataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents barcodeDataSet As TEVPBarcode.barcodeDataSet1
    Friend WithEvents ResturantalldataTableAdapter As DataSet1TableAdapters.ResturantalldataTableAdapter
End Class
