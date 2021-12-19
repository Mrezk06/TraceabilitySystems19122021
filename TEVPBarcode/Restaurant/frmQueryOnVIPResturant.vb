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


Public Class frmQueryOnVIPResturant

    Private Sub frmQueryOnVIPResturant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT  RCOUNTER,RDateDayFrom, RDateDayTO, RQPersone, RCOstCenter, RNFectory, Rtimerequst, RNote, RPhone FROM Restaurant_request_VIP"
            'sql1 += "   where RCOstCenter = '" & txtcostcenter.Text & "'"
            'sql1 += "   and RPhone = '" & txtphone.Text & "'"
            sql1 += " where RDate >='" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql1 += " and RDate <='" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _Refresh11()

    End Sub
End Class