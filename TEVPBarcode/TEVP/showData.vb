Imports TEVPBarcode.sher
Public Class showData
    Private Sub showData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM   LCDTVModels "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")

            btnPCode.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            btnPCode.DisplayMember = "fLCDModelName"
            btnPCode.Sorted = True

            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql += " and fLCDPline ='" & cbl.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            dg9.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh102() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLCDModelName='" & btnPCode.Text & "'"
            sql += " and fLCDPline ='" & cbl.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            dg.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh102()
        _Refresh1()
    End Sub

    Private Sub Timer1_Disposed(sender As Object, e As EventArgs) Handles Timer1.Disposed
        _Refresh102()
        _Refresh1()
    End Sub

    Private Sub btnPCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles btnPCode.SelectedIndexChanged

    End Sub

    Private Sub btnPCode_Leave(sender As Object, e As EventArgs) Handles btnPCode.Leave
        _Refresh102()
        _Refresh1()
    End Sub

    Private Sub cbl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs) Handles cbl.Leave
        '_Refresh102()
        _Refresh1()
    End Sub
End Class