Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmQueryTransport_Traffic
    Private Sub frmQueryTransport_Traffic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT TM_NUM_CAR,TM_TEXT_CAR FROM   TM_Car "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "TM_Car")
            txtcarNum.DataSource = ds.Tables(0)
            txtcarNum.ValueMember = "TM_TEXT_CAR"
            txtcarNum.DisplayMember = "TM_NUM_CAR"
            txtcarNum.Sorted = True
        Catch ex As Exception
        End Try
    End Sub
    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = "SELECT   TM_NAME_EMP,  Expr8,Expr10 FROM  TM_Operating_diary1 "
            sql1 += " where TM_NUM_CAR =" & txtcarNum.Text & ""
            sql1 += "  and TM_TEXT_CAR = '" & llbl_carText.Text & "'"
            sql1 += "  and TM_Dmamouriy = '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_Operating_diary1")
            ds.Tables("TM_Operating_diary1").Columns(0).ColumnName = "اسم السائق"
            ds.Tables("TM_Operating_diary1").Columns(1).ColumnName = " اسم المندوب"
            ds.Tables("TM_Operating_diary1").Columns(2).ColumnName = " الاتجاه"
            dgf.DataSource = ds.Tables("TM_Operating_diary1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try
            Dim sql1 As String = "SELECT  TM_NAME_EMP,TM_COUNTER, TM_STATUS FROM  TM_DailyMaintenance_and_garageView01 "
            sql1 += " where TM_NUM_CAR =" & txtcarNum.Text & ""
            sql1 += "  and TM_TEXT_CAR = '" & llbl_carText.Text & "'"
            sql1 += "  and TM_Dmamouriy = '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_DailyMaintenance_and_garageView01")
            ds.Tables("TM_DailyMaintenance_and_garageView01").Columns(0).ColumnName = "اسم السائق"
            ds.Tables("TM_DailyMaintenance_and_garageView01").Columns(1).ColumnName = "العداد "
            ds.Tables("TM_DailyMaintenance_and_garageView01").Columns(2).ColumnName = " حالة السيارة"
            dg.DataSource = ds.Tables("TM_DailyMaintenance_and_garageView01")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1111() As Boolean
        Try
            Dim sql1 As String = "SELECT  TM_Ordernum, TM_DITRCTION FROM  TM_DailySVShipping "
            sql1 += " where TM_NUM_CAR =" & txtcarNum.Text & ""
            sql1 += "  and TM_TEXT_CAR = '" & llbl_carText.Text & "'"
            sql1 += "  and TM_Dmamouriy = '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_DailySVShipping")
            ds.Tables("TM_DailySVShipping").Columns(0).ColumnName = "رقم الاوردار"
            ds.Tables("TM_DailySVShipping").Columns(1).ColumnName = "الاتجاه "
            dgg.DataSource = ds.Tables("TM_DailySVShipping")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh111112() As Boolean
        Try
            Dim sql1 As String = "SELECT  Min(Diff) FROM  TM_DiffEmpView_5 "
            sql1 += " where TM_NUM_CAR =" & txtcarNum.Text & ""
            sql1 += "  and TM_TEXT_CAR = '" & llbl_carText.Text & "'"
            sql1 += "and TM_ID=(select max(TM_ID) from TM_DiffEmpView_5 )"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_DiffEmpView_5")
            ds.Tables("TM_DiffEmpView_5").Columns(0).ColumnName = "متبقى كام كيلو على تغيير العداد"
            dgw.DataSource = ds.Tables("TM_DiffEmpView_5")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11111() As Boolean
        Try
            Dim sql1 As String = "SELECT  TM_counterOld, TM_CounterKeepChange, TM_DIR, TM_NAME_EMP FROM  TM_Oil_ChangeViwe01 "
            sql1 += " where TM_NUM_CAR =" & txtcarNum.Text & ""
            sql1 += " and  TM_TEXT_CAR = '" & llbl_carText.Text & "'"
            sql1 += " and [TM_Dmamouriy] = (select Max([TM_Dmamouriy]) from [TM_Oil_ChangeViwe01] where [TM_Oil_ChangeViwe01].[TM_ID]= [TM_Oil_ChangeViwe01].[TM_ID] )"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_Oil_ChangeViwe01")
            ds.Tables("TM_Oil_ChangeViwe01").Columns(0).ColumnName = "العداد عند تغيير الزيت"
            ds.Tables("TM_Oil_ChangeViwe01").Columns(1).ColumnName = "العداد الواجب تغيير الزيت عليه "
            ds.Tables("TM_Oil_ChangeViwe01").Columns(2).ColumnName = " مكان تغيير الزيت"
            ds.Tables("TM_Oil_ChangeViwe01").Columns(3).ColumnName = " القائم بتغيير الزيت"
            dgd.DataSource = ds.Tables("TM_Oil_ChangeViwe01")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtcarNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcarNum.SelectedIndexChanged
        Try
            llbl_carText.Text = txtcarNum.SelectedValue.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            _Refresh11()
            _Refresh111()
            _Refresh1111()
            _Refresh11111()
            _Refresh111112()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class