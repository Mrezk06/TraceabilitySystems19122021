Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SqlClient
'Imports System.Data
Imports System.IO.Directory
Imports Microsoft.Office.Interop.Excel 'Before you add this reference to your project,
' you need to install Microsoft Office and find last version of this file.
Imports Microsoft.Office.Interop
Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmFollowupQuery

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtmodel.Text = "" And txtline.Text = "" And txtsv.Text = "" Then


            _Refreshdgd()
            _Refreshdgd1()
            _Refreshdgd2()
        ElseIf txtline.Text = "" And txtsv.Text = "" Then
            _Refreshdgd3()
            _Refreshdgd4()
            _Refreshdgd5()
        ElseIf txtmodel.Text = "" And txtsv.Text = "" Then
            _Refreshdgd6()
            _Refreshdgd7()
            _Refreshdgd8()
        Else
            _Refreshdgd9()
            _Refreshdgd10()
            _Refreshdgd11()
        End If

    End Sub

    Private Sub frmFollowupQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function _Refreshdgd() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fModel, fBarcode, fLineAndShift, fSV, R_Name_Problem, R_Name_Laber, Expr1 FROM VQuerytest"

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("VQuerytest").Columns(0).ColumnName = "التاريخ"
            ds.Tables("VQuerytest").Columns(1).ColumnName = "الوقت"
            ds.Tables("VQuerytest").Columns(2).ColumnName = "الموديل"
            ds.Tables("VQuerytest").Columns(3).ColumnName = "الباركود"

            ds.Tables("VQuerytest").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("VQuerytest").Columns(5).ColumnName = "المشرف "
            ds.Tables("VQuerytest").Columns(6).ColumnName = "اسم المشكلة"
            ds.Tables("VQuerytest").Columns(7).ColumnName = "مسئول الفحص "
            ds.Tables("VQuerytest").Columns(8).ColumnName = " اسم المتسبب "
            'ds.Tables("VQuerytest").Columns(9).ColumnName = "اسم المشرف"
            dg9.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refreshdgd1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_Name_Problem, count(R_Name_Problem) FROM VQuerytest "

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("VQuerytest").Columns(0).ColumnName = "الموديل "
            ds.Tables("VQuerytest").Columns(1).ColumnName = "الكمية"
            'ds.Tables("VQuerytest").Columns(2).ColumnName = "الموديل"
            'ds.Tables("VQuerytest").Columns(3).ColumnName = "الباركود"

            'ds.Tables("VQuerytest").Columns(4).ColumnName = " الخط والوردية"
            'ds.Tables("VQuerytest").Columns(5).ColumnName = "المشرف "
            'ds.Tables("VQuerytest").Columns(6).ColumnName = "اسم المشكلة"
            'ds.Tables("VQuerytest").Columns(7).ColumnName = "مسئول الفحص "
            'ds.Tables("VQuerytest").Columns(8).ColumnName = " اسم المتسبب "
            'ds.Tables("VQuerytest").Columns(9).ColumnName = "اسم المشرف"
            dgf.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshdgd2() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(R_Name_Problem) FROM VQuerytest "

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ' ds.Tables("VQuerytest").Columns(0).ColumnName = "الموديل "
            ds.Tables("VQuerytest").Columns(0).ColumnName = "الكمية"
            'ds.Tables("VQuerytest").Columns(2).ColumnName = "الموديل"
            'ds.Tables("VQuerytest").Columns(3).ColumnName = "الباركود"

            'ds.Tables("VQuerytest").Columns(4).ColumnName = " الخط والوردية"
            'ds.Tables("VQuerytest").Columns(5).ColumnName = "المشرف "
            'ds.Tables("VQuerytest").Columns(6).ColumnName = "اسم المشكلة"
            'ds.Tables("VQuerytest").Columns(7).ColumnName = "مسئول الفحص "
            'ds.Tables("VQuerytest").Columns(8).ColumnName = " اسم المتسبب "
            'ds.Tables("VQuerytest").Columns(9).ColumnName = "اسم المشرف"
            dgq.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Function _Refreshdgd3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fModel, fBarcode, fLineAndShift, fSV, R_Name_Problem, R_Name_Laber, Expr1 FROM VQuerytest"

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & txtmodel.Text & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("VQuerytest").Columns(0).ColumnName = "التاريخ"
            ds.Tables("VQuerytest").Columns(1).ColumnName = "الوقت"
            ds.Tables("VQuerytest").Columns(2).ColumnName = "الموديل"
            ds.Tables("VQuerytest").Columns(3).ColumnName = "الباركود"

            ds.Tables("VQuerytest").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("VQuerytest").Columns(5).ColumnName = "المشرف "
            ds.Tables("VQuerytest").Columns(6).ColumnName = "اسم المشكلة"
            ds.Tables("VQuerytest").Columns(7).ColumnName = "مسئول الفحص "
            ds.Tables("VQuerytest").Columns(8).ColumnName = " اسم المتسبب "
            'ds.Tables("VQuerytest").Columns(9).ColumnName = "اسم المشرف"
            dg9.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refreshdgd4() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_Name_Problem, count(R_Name_Problem) FROM VQuerytest "

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & txtmodel.Text & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("VQuerytest").Columns(0).ColumnName = "الموديل "
            ds.Tables("VQuerytest").Columns(1).ColumnName = "الكمية"

            dgf.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshdgd5() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(R_Name_Problem) FROM VQuerytest "

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"

            sql += " and fModel='" & txtmodel.Text & "'"
            sql += " and R_Line = fSV"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")

            ds.Tables("VQuerytest").Columns(0).ColumnName = "الكمية"

            dgq.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Function _Refreshdgd6() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fModel, fBarcode, fLineAndShift, fSV, R_Name_Problem, R_Name_Laber, Expr1 FROM VQuerytest"

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            '  sql += " and fModel='" & txtmodel.Text & "'"
            sql += " and fLineAndShift='" & txtline.Text & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("VQuerytest").Columns(0).ColumnName = "التاريخ"
            ds.Tables("VQuerytest").Columns(1).ColumnName = "الوقت"
            ds.Tables("VQuerytest").Columns(2).ColumnName = "الموديل"
            ds.Tables("VQuerytest").Columns(3).ColumnName = "الباركود"

            ds.Tables("VQuerytest").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("VQuerytest").Columns(5).ColumnName = "المشرف "
            ds.Tables("VQuerytest").Columns(6).ColumnName = "اسم المشكلة"
            ds.Tables("VQuerytest").Columns(7).ColumnName = "مسئول الفحص "
            ds.Tables("VQuerytest").Columns(8).ColumnName = " اسم المتسبب "
            'ds.Tables("VQuerytest").Columns(9).ColumnName = "اسم المشرف"
            dg9.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refreshdgd7() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_Name_Problem, count(R_Name_Problem) FROM VQuerytest "

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fLineAndShift='" & txtline.Text & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("VQuerytest").Columns(0).ColumnName = "الموديل "
            ds.Tables("VQuerytest").Columns(1).ColumnName = "الكمية"

            dgf.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshdgd8() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(R_Name_Problem) FROM VQuerytest "

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fLineAndShift='" & txtline.Text & "'"
            sql += " and R_Line = fSV"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")

            ds.Tables("VQuerytest").Columns(0).ColumnName = "الكمية"

            dgq.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Function _Refreshdgd9() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fModel, fBarcode, fLineAndShift, fSV, R_Name_Problem, R_Name_Laber, Expr1 FROM VQuerytest"

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            '  sql += " and fModel='" & txtmodel.Text & "'"
            sql += " and fSV='" & txtsv.Text & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("VQuerytest").Columns(0).ColumnName = "التاريخ"
            ds.Tables("VQuerytest").Columns(1).ColumnName = "الوقت"
            ds.Tables("VQuerytest").Columns(2).ColumnName = "الموديل"
            ds.Tables("VQuerytest").Columns(3).ColumnName = "الباركود"

            ds.Tables("VQuerytest").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("VQuerytest").Columns(5).ColumnName = "المشرف "
            ds.Tables("VQuerytest").Columns(6).ColumnName = "اسم المشكلة"
            ds.Tables("VQuerytest").Columns(7).ColumnName = "مسئول الفحص "
            ds.Tables("VQuerytest").Columns(8).ColumnName = " اسم المتسبب "
            'ds.Tables("VQuerytest").Columns(9).ColumnName = "اسم المشرف"
            dg9.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refreshdgd10() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_Name_Problem, count(R_Name_Problem) FROM VQuerytest "

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fSV='" & txtsv.Text & "'"
            sql += " and R_Line = fSV"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("VQuerytest").Columns(0).ColumnName = "الموديل "
            ds.Tables("VQuerytest").Columns(1).ColumnName = "الكمية"

            dgf.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshdgd11() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(R_Name_Problem) FROM VQuerytest "

            ' sql += " FROM Output"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fSV='" & txtsv.Text & "'"
            sql += " and R_Line = fSV"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "VQuerytest")

            ds.Tables("VQuerytest").Columns(0).ColumnName = "الكمية"

            dgq.DataSource = ds.Tables("VQuerytest")
            Return True
        Catch ex As Exception
        End Try
    End Function
End Class