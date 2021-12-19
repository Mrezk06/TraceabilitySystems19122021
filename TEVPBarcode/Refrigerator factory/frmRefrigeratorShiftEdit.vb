Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class frmRefrigeratorShiftEdit
    Private Function Update12() As Boolean
        Try
            Dim sql As String

            sql = "UPDATE Refrigerator_Shift Set"
            sql += " F_TimeFrom ='" & Format(DateTimePicker1.Value, "hh:mm tt") & "',"
            sql += " F_TimeTo ='" & Format(DateTimePicker2.Value, "hh:mm tt") & "'"
            sql += " where F_ShiftCode = '" & txtShiftCode.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub frmRefrigeratorShiftEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Refresh199()
    End Sub
    Private Function _Refresh199() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  F_date, F_Time, F_ShiftCode, F_TimeFrom, F_TimeTo"
            sql += " FROM Refrigerator_Shift"
            '  sql += " WHERE F_date >= Convert(nvarchar(10), GETDATE(), 121)"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_Shift")
            ds.Tables("Refrigerator_Shift").Columns(0).ColumnName = "تاريخ التسجيل"
            ds.Tables("Refrigerator_Shift").Columns(1).ColumnName = "وقت التسجيل"
            ds.Tables("Refrigerator_Shift").Columns(2).ColumnName = "كود الوردية"
            ds.Tables("Refrigerator_Shift").Columns(3).ColumnName = "وقت بداية الوردية"
            ds.Tables("Refrigerator_Shift").Columns(4).ColumnName = "وقت نهاية الوردية"
            dg.DataSource = ds.Tables("Refrigerator_Shift")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh199()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Update12()
        _Refresh199()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _Refresh199()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        _Refresh199()
    End Sub
End Class