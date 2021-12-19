Imports TEVPBarcode.sher
Imports System.IO.Directory
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Microsoft.Reporting.WinForms
Public Class frmvimrecipitmeal

    Private Sub frmvimrecipitmeal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox4.Enabled = False

    End Sub
    Private Function Add1_New1() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_request_vip_recipt "
            sql += "(RDateDay, RID, RSap, RQTYPerson)"
            sql += " VALUES ('" & Format(txttime.Value, "hh:mm:ss") & "'," & TextBox1.Text & ",'" & txtphone.Text & "'," & txtqmeal.Text & ")"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = "SELECT  RCOUNTER,RDateDayFrom, RDateDayTO, RQPersone, RCOstCenter, RNFectory, Rtimerequst, RNote, RPhone FROM Restaurant_request_VIP"
            sql1 += "   where RCOUNTER = " & TextBox1.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_request_VIP")
            ds.Tables("Restaurant_request_VIP").Columns(0).ColumnName = "كود الطلب"
            ds.Tables("Restaurant_request_VIP").Columns(1).ColumnName = "التاريخ من"
            ds.Tables("Restaurant_request_VIP").Columns(2).ColumnName = "التاريخ الى"
            ds.Tables("Restaurant_request_VIP").Columns(3).ColumnName = "عدد الوجبات المطلوبة"
            ds.Tables("Restaurant_request_VIP").Columns(4).ColumnName = "مركز التكلفه"
            ds.Tables("Restaurant_request_VIP").Columns(5).ColumnName = "اسم الجها الطالبه"
            ds.Tables("Restaurant_request_VIP").Columns(6).ColumnName = "وقت تناول الواجبة"
            ds.Tables("Restaurant_request_VIP").Columns(7).ColumnName = "مواصفات خاصه للواجبة"
            ds.Tables("Restaurant_request_VIP").Columns(8).ColumnName = "رقم التلفون "
            dg.DataSource = ds.Tables("Restaurant_request_VIP")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh11()
        GroupBox4.Enabled = True
        GroupBox7.Enabled = False
        txtphone.Focus()

    End Sub
    Private Function _Refresh101() As Boolean
        Try
            Dim sql1 As String = "SELECT   RDateDay, RID, RSap, RQTYPerson FROM Restaurant_request_vip_recipt"
            sql1 += "   where RID = " & TextBox1.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_request_vip_recipt")
            ds.Tables("Restaurant_request_vip_recipt").Columns(0).ColumnName = " وقت الاستلام"
            ds.Tables("Restaurant_request_vip_recipt").Columns(1).ColumnName = "كود الطلب"
            ds.Tables("Restaurant_request_vip_recipt").Columns(2).ColumnName = "رقم ساب طالب الوجبه"
            ds.Tables("Restaurant_request_vip_recipt").Columns(3).ColumnName = "عدد الافراد "
            dg.DataSource = ds.Tables("Restaurant_request_vip_recipt")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Add1_New1()
        _Refresh101()

    End Sub
End Class