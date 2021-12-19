Imports TEVPBarcode.sher
Public Class frmshow_plan

    Private Sub frmshow_plan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO PlanforMonth "
            sql += "(fMonthName,fQty)"
            sql += " VALUES ('" & txttotime.Text & "','" & txtqty.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add1_New()
        _Refresh11()
    End Sub
    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT fMonthName,fQty,fdate FROM PlanforMonth"
            '  sql1 += "   where fModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PlanforMonth")
            ds.Tables("PlanforMonth").Columns(0).ColumnName = " Month"
            ds.Tables("PlanforMonth").Columns(1).ColumnName = " Qty "
            ds.Tables("PlanforMonth").Columns(2).ColumnName = "date"
            'ds.Tables("Material").Columns(3).ColumnName = " Area"


            dgv.DataSource = ds.Tables("PlanforMonth")

            Return True

        Catch ex As Exception

        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Del_Rec()
        _Refresh11()
    End Sub
    Private Function Del_Rec() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM PlanforMonth"
            sql += " where fMonthName ='" & txttotime.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
End Class