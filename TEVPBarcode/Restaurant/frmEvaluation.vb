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
Public Class frmEvaluation
    'Private Function _Refr000() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT RDate, RName, RPosation, fname, RMMName, RNote, Expr1 FROM barcode.dbo.Evaluation"
    '        sql += "   WHERE RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
    '        ' sql += " and RSap=" & txtuser.Text & ""
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Evaluation")
    '        ds.Tables("Evaluation").Columns(0).ColumnName = "التاريخ"
    '        ds.Tables("Evaluation").Columns(1).ColumnName = "اسم الشخص"
    '        ds.Tables("Evaluation").Columns(2).ColumnName = "المسمى الوظيفى "
    '        ds.Tables("Evaluation").Columns(3).ColumnName = "نوع الطلب"
    '        ds.Tables("Evaluation").Columns(4).ColumnName = "اسم الوجبه"
    '        ds.Tables("Evaluation").Columns(5).ColumnName = "وصف المشكله "
    '        ds.Tables("Evaluation").Columns(6).ColumnName = "تقييم المشكله "
    '        dg.DataSource = ds.Tables("Evaluation")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refr000q() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count( fname) FROM barcode.dbo.Evaluation"
            sql += "   WHERE RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            ' sql += " and RSap=" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Evaluation")
            ds.Tables("Evaluation").Columns(0).ColumnName = "العدد المقدم "
            dg1.DataSource = ds.Tables("Evaluation")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmEvaluation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += " SELECT  fID,fname FROM Restaurant_preferment "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Restaurant_preferment")
            ComboBox3.DataSource = ds.Tables(0)
            ComboBox3.ValueMember = "fID"
            ComboBox3.DisplayMember = "fname"
            ComboBox3.Sorted = True
        Catch ex As Exception
        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT  RMMID, RMMName FROM Evaluation "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Evaluation")
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "RMMID"
            ComboBox1.DisplayMember = "RMMName"
            ComboBox1.Sorted = True
        Catch ex As Exception
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim dt As New DataTable
            cn.Open()
            Using sql As New SqlCommand("SELECT RDate, RName, RPosation, fname, RMMName, RNote, Expr1 FROM barcode.dbo.Evaluation where  RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'", cn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = sql
                da.Fill(dt)
            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "E:\rezk\Debug\Report2.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            '  _Refr000()
            _Refr000q()
        Catch ex As Exception
        End Try
    End Sub
    'Private Function _Refr000t() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT RDate, RName, RPosation, fname, RMMName, RNote, Expr1 FROM barcode.dbo.Evaluation"
    '        sql += "   WHERE RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += " and fname='" & ComboBox3.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Evaluation")
    '        ds.Tables("Evaluation").Columns(0).ColumnName = "التاريخ"
    '        ds.Tables("Evaluation").Columns(1).ColumnName = "اسم الشخص"
    '        ds.Tables("Evaluation").Columns(2).ColumnName = "المسمى الوظيفى "
    '        ds.Tables("Evaluation").Columns(3).ColumnName = "نوع الطلب"
    '        ds.Tables("Evaluation").Columns(4).ColumnName = "اسم الوجبه"
    '        ds.Tables("Evaluation").Columns(5).ColumnName = "وصف المشكله "
    '        ds.Tables("Evaluation").Columns(6).ColumnName = "تقييم المشكله "
    '        dg.DataSource = ds.Tables("Evaluation")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refr000qt() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count( fname) FROM barcode.dbo.Evaluation"
            sql += "   WHERE RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and fname='" & ComboBox3.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Evaluation")
            ds.Tables("Evaluation").Columns(0).ColumnName = "العدد المقدم "
            dg1.DataSource = ds.Tables("Evaluation")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
     
        Try
            Dim dt As New DataTable
            cn.Open()
            Using sql As New SqlCommand("SELECT RDate, RName, RPosation, fname, RMMName, RNote, Expr1 FROM barcode.dbo.Evaluation where fname='" & ComboBox3.Text & "'and  RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'", cn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = sql
                da.Fill(dt)
            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "E:\rezk\Debug\Report2.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            _Refr000qt()
            '   _Refr000t()
        Catch ex As Exception
        End Try
    End Sub
    'Private Function _Refr000tm() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT RDate, RName, RPosation, fname, RMMName, RNote, Expr1 FROM barcode.dbo.Evaluation"
    '        sql += "   WHERE RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += " and RMMName='" & ComboBox1.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Evaluation")
    '        ds.Tables("Evaluation").Columns(0).ColumnName = "التاريخ"
    '        ds.Tables("Evaluation").Columns(1).ColumnName = "اسم الشخص"
    '        ds.Tables("Evaluation").Columns(2).ColumnName = "المسمى الوظيفى "
    '        ds.Tables("Evaluation").Columns(3).ColumnName = "نوع الطلب"
    '        ds.Tables("Evaluation").Columns(4).ColumnName = "اسم الوجبه"
    '        ds.Tables("Evaluation").Columns(5).ColumnName = "وصف المشكله "
    '        ds.Tables("Evaluation").Columns(6).ColumnName = "تقييم المشكله "
    '        dg.DataSource = ds.Tables("Evaluation")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refr000qtm() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count( fname) FROM barcode.dbo.Evaluation"
            sql += "   WHERE RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and RMMName='" & ComboBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Evaluation")
            ds.Tables("Evaluation").Columns(0).ColumnName = "العدد المقدم "
            dg1.DataSource = ds.Tables("Evaluation")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    
        Try
            Dim dt As New DataTable
            cn.Open()
            Using sql As New SqlCommand("SELECT RDate, RName, RPosation, fname, RMMName, RNote, Expr1 FROM barcode.dbo.Evaluation where RMMName='" & ComboBox1.Text & "'and  RDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'and RDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'", cn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = sql
                da.Fill(dt)
            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "E:\rezk\Debug\Report2.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            _Refr000qtm()
            '  _Refr000tm()
        Catch ex As Exception
        End Try
    End Sub
End Class