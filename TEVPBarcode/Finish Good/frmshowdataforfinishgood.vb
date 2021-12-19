Imports TEVPBarcode.sher
Public Class frmshowdataforfinishgood

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
    Private Sub frmshowdataforfinishgood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        _Refresh1dd()
        _Refresh13tt()
        _Refresht()
        _RefreshDiff()
    End Sub
    Private Function _RefreshDiff() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT [fQty]- count([Expr1]) as qty2 FROM View_5ddiff"
            sql += "   where [fPDate] >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0) and  [fdate]>=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)   group by [fQty]"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_5ddiff")
            ds.Tables("View_5ddiff").Columns(0).ColumnName = " difference_Plan "
            dgt.DataSource = ds.Tables("View_5ddiff")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
    Private Function _Refresh13tt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(fLCDBarcode)as qty"
            sql += " FROM Output"
            sql += " where fPDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Output")
            ds.Tables("Output").Columns(0).ColumnName = "Actual  plan"
            dga.DataSource = ds.Tables("Output")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresht() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  fQty "
            sql += " FROM PlanforMonth"
            sql += " where fdate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PlanforMonth")
            ds.Tables("PlanforMonth").Columns(0).ColumnName = "Target plan"
            dgd.DataSource = ds.Tables("PlanforMonth")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1dd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += " where fPDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("View_2").Columns(1).ColumnName = " Qty"
            dgm.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh1dd()
        _Refresh13tt()
        _Refresht()
        _RefreshDiff()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        _Refresh1dd()
        _Refresh13tt()
    End Sub
End Class