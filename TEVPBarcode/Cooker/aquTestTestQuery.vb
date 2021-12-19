

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

Public Class aquTestTestQuery
    'Private Sub ReleaseObject(ByVal o As Object)
    '    Try
    '        While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
    '        End While
    '    Catch
    '    Finally
    '        o = Nothing
    '    End Try
    'End Sub
    Private Sub frmResturantQueryUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.C_Atc_1' table. You can move, or remove it, as needed.
        Me.C_Atc_1TableAdapter.Fill(Me.DataSet1.C_Atc_1)

        Try
            Dim sql As String = ""
            sql += "SELECT P1 FROM [barcode].[dbo].[C_Atc_1] group by P1"
            '  sql += " where fLine_Name ='EWH1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "C_Atc_1")
            cmb_Pcode.DataSource = ds.Tables(0)
            ' cmb_Pcode.ValueMember = "CSetID"
            ' cmb_Pcode.ValueMember = "model_S_Power"
            cmb_Pcode.DisplayMember = "P1"
            cmb_Pcode.Sorted = True
            '   _Refresh1()
        Catch ex As Exception
        End Try
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
    Private Function _Refr2() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  COUNT(P7) AS QTY FROM C_Atc_1"
            sql += "   WHERE DT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and DT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            ' sql += " GROUP BY RMFID, RMMID, RMMName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Atc_1")
            ' ds.Tables("C_Atc_1").Columns(0).ColumnName = "اسم الوجبه  "
            ds.Tables("C_Atc_1").Columns(0).ColumnName = "الكمية"
            dgff.DataSource = ds.Tables("C_Atc_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr22() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  COUNT(P7) AS QTY FROM C_Atc_1"
            sql += "   WHERE DT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and DT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and P1='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Atc_1")
            ' ds.Tables("C_Atc_1").Columns(0).ColumnName = "اسم الوجبه  "
            ds.Tables("C_Atc_1").Columns(0).ColumnName = "الكمية"
            dgff.DataSource = ds.Tables("C_Atc_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Function _Refr21() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT   COUNT(RMMName) AS QTY FROM Restaurant_request_User"
    '        sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
    '        '  sql += " GROUP BY RMFID, RMMID, RMMName"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Restaurant_request_User")
    '        '   ds.Tables("Restaurant_request_User").Columns(0).ColumnName = "اسم الوجبه  "
    '        ds.Tables("Restaurant_request_User").Columns(0).ColumnName = "الكمية"
    '        dgff.DataSource = ds.Tables("Restaurant_request_User")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '_Refr21()
        '_Refr2()

        Try
            Dim dt As New DataTable
            cn.Open()
            Using sql As New SqlCommand("SELECT P1, P4, P5, P7, P13, P17, P21, P25, P29, P33, DT FROM C_Atc_1 where  DT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'and DT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'", cn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = sql
                da.Fill(dt)
            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "E:\rezk\Debug\Report22.rdlc"

                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            '_Refr0001()
            '_Refr001()
            _Refr2()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try
            Dim dt As New DataTable
            cn.Open()
            Using sql As New SqlCommand("SELECT P1, P4, P5, P7, P13, P17, P21, P25, P29, P33, DT FROM C_Atc_1 where  DT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'and DT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "' and P1='" & cmb_Pcode.Text & "'", cn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = sql

                da.Fill(dt)

            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "E:\rezk\Debug\Report22.rdlc"

                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            '_Refr000()
            '_Refr00()
            _Refr22()
        Catch ex As Exception
        End Try
    End Sub
    'Private Function _Refr001() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT sum(RMPrice) FROM Resturantalldata"
    '        sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
    '        ' sql += " and RSap=" & txtuser.Text & ""
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Resturantalldata")
    '        ds.Tables("Resturantalldata").Columns(0).ColumnName = "Total price"
    '        dgff.DataSource = ds.Tables("Resturantalldata")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    'Private Function _Refr0001() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT sum(RMPrice)/count(RDateDay) FROM Resturantalldata"
    '        sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
    '        '      sql += " and RSap=" & txtuser.Text & ""
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Resturantalldata")
    '        ds.Tables("Resturantalldata").Columns(0).ColumnName = "avg price"
    '        gf.DataSource = ds.Tables("Resturantalldata")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function

End Class