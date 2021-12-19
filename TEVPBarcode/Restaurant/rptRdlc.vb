Public Class rptRdlc

    Private Sub rptRdlc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'barcodeDataSet.Resturantalldata' table. You can move, or remove it, as needed.
        Me.ResturantalldataTableAdapter.Fill(Me.barcodeDataSet.Resturantalldata)

        ' Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class