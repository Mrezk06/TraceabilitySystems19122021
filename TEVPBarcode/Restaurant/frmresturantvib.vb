Imports TEVPBarcode.sher
Imports System.IO.Directory
'References that we need
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
'Imports System.IO.Directory
'Imports Microsoft.Office.Interop.Excel 'Before you add this reference to your project,
' you need to install Microsoft Office and find last version of this file.
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Microsoft.Reporting.WinForms

Public Class frmresturantvib

    Private Sub frmresturantvib_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += " SELECT  RID, RName FROM Restaurant_Name_area_VIP "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Restaurant_Name_area_VIP")
            txtnamerequst.DataSource = ds.Tables(0)
            txtnamerequst.ValueMember = "RID"
            txtnamerequst.DisplayMember = "RName"
            txtnamerequst.Sorted = True
        Catch ex As Exception
        End Try
    End Sub
    Private Function Add1_New1() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_request_VIP "
            sql += "( RDateDayFrom, RDateDayTO, RQPersone, RCOstCenter, RNFectory, Rtimerequst, RNote, RPhone)"
            sql += " VALUES ('" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "','" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'," & txtqmeal.Text & ",'" & txtcostcenter.Text & "','" & txtnamerequst.Text & "','" & Format(txttime.Value, "hh:mm:ss") & "','" & txtnote.Text & "','" & txtphone.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec1() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[Restaurant_request_VIP]"
            sql += " where RCOstCenter ='" & txtcostcenter.Text & "'"
            sql += " and RNFectory ='" & txtnamerequst.Text & "'"
            sql += " and RPhone ='" & txtphone.Text & "'"
            sql += " and RDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update11A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  Restaurant_request_VIP set"
            sql += " RDateDayFrom ='" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " RDateDayTO ='" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"

            sql += " where RCOstCenter = " & txtcostcenter.Text & ""
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
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
            sql1 += "   where RCOstCenter = '" & txtcostcenter.Text & "'"
            sql1 += "   and RPhone = '" & txtphone.Text & "'"
            sql1 += "and RDateDayFrom ='" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql1 += " and RDateDayTO ='" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
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
            ' ds.Tables("Restaurant_request_VIP").Columns(9).ColumnName = "reason Name"
            dg.DataSource = ds.Tables("Restaurant_request_VIP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Function _Refresh1111() As Boolean
    '    Try

    '        Dim sql1 As String = "SELECT  RCOUNTER,RDateDayFrom, RDateDayTO, RQPersone, RCOstCenter, RNFectory, Rtimerequst, RNote, RPhone FROM Restaurant_request_VIP"
    '        sql1 += "   where RDate >= Convert(nvarchar(10), GETDATE(), 121)"
    '        Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Restaurant_request_VIP")
    '        ds.Tables("Restaurant_request_VIP").Columns(0).ColumnName = "كود الطلب"
    '        ds.Tables("Restaurant_request_VIP").Columns(1).ColumnName = "التاريخ من"
    '        ds.Tables("Restaurant_request_VIP").Columns(2).ColumnName = "التاريخ الى"
    '        ds.Tables("Restaurant_request_VIP").Columns(3).ColumnName = "عدد الوجبات المطلوبة"
    '        ds.Tables("Restaurant_request_VIP").Columns(4).ColumnName = "مركز التكلفه"
    '        ds.Tables("Restaurant_request_VIP").Columns(5).ColumnName = "اسم الجها الطالبه"
    '        ds.Tables("Restaurant_request_VIP").Columns(6).ColumnName = "وقت تناول الواجبة"
    '        ds.Tables("Restaurant_request_VIP").Columns(7).ColumnName = "مواصفات خاصه للواجبة"
    '        ds.Tables("Restaurant_request_VIP").Columns(8).ColumnName = "رقم التلفون "
    '        ' ds.Tables("Restaurant_request_VIP").Columns(9).ColumnName = "reason Name"
    '        dg.DataSource = ds.Tables("Restaurant_request_VIP")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcostcenter.Text = "" Or txtnamerequst.Text = "" Or txtphone.Text = "" Or txtqmeal.Text = "" Then
           MsgBox("من فضلك اكمل باقى البيانات")
        Else

            Add1_New1()
            _Refresh11()
            MsgBox("تم تسجيل طلبكم بنجاح من فضلك احتفظ بكود الطلب ")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        _Refresh11()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Del_Rec1()
        _Refresh11()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _Refresh11()

    End Sub
End Class