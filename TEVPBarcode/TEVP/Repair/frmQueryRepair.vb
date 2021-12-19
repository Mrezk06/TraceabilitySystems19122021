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
Public Class frmQueryRepair
   
    Private Sub frmQueryRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDModelName FROM   LCDTVModels "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")
            txtmodel.DataSource = ds.Tables(0)
            '  txtmodel.ValueMember = "fpanelIDLCM"
            txtmodel.DisplayMember = "fLCDModelName"
            txtmodel.Sorted = True
            '_Refresh110()
            '_Refresh1()
        Catch ex As Exception
        End Try
        txtmodel.Text = ""
    End Sub
    Private Function _Refreshdgd() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_date,R_Time,  R_Barcode1, R_ModelName, R_Name_Problem, Expr1, R_Type_Problem, R_Line, R_Name_Laber, R_SV FROM  repair"

            ' sql += " FROM Output"
            sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            ' sql += " and R_Type_Problem='Vendor'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "التاريخ"
            ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"
            dg9.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        _Refreshdgd()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txtline.Text = "" And txtmodel.Text = "" And txtstetue.Text = "" And txtsv.Text = "" Then
            _RefreshdgdDate()
            _RefreshdgdDateq()
            _RefreshdgdDatem()

        ElseIf txtline.Text = "" And txtstetue.Text = "" And txtsv.Text = "" Then

            _RefreshdgdDate1()
            _RefreshdgdDate1q()
            _RefreshdgdDate1M()
        ElseIf txtmodel.Text = "" And txtstetue.Text = "" And txtsv.Text = "" Then

            _RefreshdgdDate1x()
            _RefreshdgdDate1qx()
            _RefreshdgdDate1Mx()
        ElseIf txtstetue.Text = "" And txtsv.Text = "" Then
            _RefreshdgdDate2()
            _RefreshdgdDate2q()
            _RefreshdgdDate2qm()
        ElseIf txtsv.Text = "" Then

            _RefreshdgdDate3()
            _RefreshdgdDate3q()
            _RefreshdgdDate3m()
        Else
            _RefreshdgdDate4()
            _RefreshdgdDate4q()
            _RefreshdgdDate4m()
        End If
    End Sub
    Private Function _RefreshdgdDate() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_date,R_Time,  R_Barcode1, R_ModelName, R_Name_Problem, Expr1, R_Type_Problem, R_Line, R_Name_Laber, R_SV FROM  repair"

            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ds.Tables("repair").Columns(0).ColumnName = "التاريخ"
            ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"
            dg9.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDatem() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_ModelName, count(R_ModelName) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            ' sql += " and R_ModelName='" & txtbarcode.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الموديل"
            ds.Tables("repair").Columns(1).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgf.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDateq() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count( R_Barcode1) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            ' sql += " and R_ModelName='" & txtbarcode.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgq.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_date,R_Time,  R_Barcode1, R_ModelName, R_Name_Problem, Expr1, R_Type_Problem, R_Line, R_Name_Laber, R_SV FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "التاريخ"
            ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate1M() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  R_ModelName, count(R_ModelName) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الموديل"
            ds.Tables("repair").Columns(1).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgf.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate1q() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (R_Barcode1) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgq.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate2() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_date,R_Time,  R_Barcode1, R_ModelName, R_Name_Problem, Expr1, R_Type_Problem, R_Line, R_Name_Laber, R_SV FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "التاريخ"
            ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate2q() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(R_Barcode1) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgq.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate2qm() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_ModelName,count(R_ModelName) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الموديل"
            ds.Tables("repair").Columns(1).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgf.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_date,R_Time,  R_Barcode1, R_ModelName, R_Name_Problem, Expr1, R_Type_Problem, R_Line, R_Name_Laber, R_SV FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            sql += " and R_Type_Problem='" & txtstetue.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "التاريخ"
            ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate3m() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_ModelName, count(R_ModelName)FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            sql += " and R_Type_Problem='" & txtstetue.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الموديل"
            ds.Tables("repair").Columns(1).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgf.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate3q() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(R_Barcode1) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            sql += " and R_Type_Problem='" & txtstetue.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgq.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate4() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_date,R_Time,  R_Barcode1, R_ModelName, R_Name_Problem, Expr1, R_Type_Problem, R_Line, R_Name_Laber, R_SV FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            sql += " and R_Type_Problem='" & txtstetue.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            sql += " and R_SV='" & txtsv.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "التاريخ"
            ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate4m() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  R_ModelName,count(R_ModelName) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            sql += " and R_Type_Problem='" & txtstetue.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            sql += " and R_SV='" & txtsv.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الموديل"
            ds.Tables("repair").Columns(1).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgf.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate4q() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count( R_Barcode1) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_ModelName='" & txtmodel.Text & "'"
            sql += " and R_Type_Problem='" & txtstetue.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            sql += " and R_SV='" & txtsv.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgq.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    'Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)



    'End Sub

    Private Sub dgq_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dg9_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg9.CellContentClick
        txtmodel.Text = dg9.Item(3, dg9.CurrentRow.Index).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        Dim connection As New SqlClient.SqlConnection

        'Assign your connection string to connection object
        connection.ConnectionString = "Data Source=EUCSSQL02\TRACEABILITY;Initial Catalog=TRACEABILITY_QUESNA;Persist Security Info=True;User ID=TRACEABILITY;Password=Tr@$e@b!l!ty1964"
        command.Connection = connection
        command.CommandType = CommandType.Text
        'You can use any command select
        command.CommandText = "SELECT R_ModelName, R_SV, R_Barcode1, R_Line, R_Type_Problem, R_SN_ProblemLaber, R_Time, R_date, R_Name_Problem, Expr1 FROM repair1 where R_ModelName ='" & txtmodel.Text & "'"
        dataAdapter.SelectCommand = command
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then
                'This section help you if your language is not English.
                System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
                Dim oExcel As Excel.Application
                Dim oBook As Excel.Workbook
                Dim oSheet As Excel.Worksheet
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add(Type.Missing)
                oSheet = oBook.Worksheets(1)

                Dim dc As System.Data.DataColumn
                Dim dr As System.Data.DataRow
                Dim colIndex As Integer = 0
                Dim rowIndex As Integer = 0

                'Fill data to datatable
                connection.Open()
                dataAdapter.Fill(datatableMain)
                connection.Close()


                'Export the Columns to excel file
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(1, colIndex) = dc.ColumnName
                Next

                'Export the rows to excel file
                For Each dr In datatableMain.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In datatableMain.Columns
                        colIndex = colIndex + 1
                        oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next

                'Set final path
                Dim fileName As String = "\ExportedAuthors" + ".xlsx"
                Dim finalPath = f.SelectedPath + fileName
                TextBox1.Text = finalPath
                oSheet.Columns.AutoFit()
                'Save file in final path
                oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

                'Release the objects
                ReleaseObject(oSheet)
                oBook.Close(False, Type.Missing, Type.Missing)
                ReleaseObject(oBook)
                oExcel.Quit()
                ReleaseObject(oExcel)
                'Some time Office application does not quit after automation: 
                'so i am calling GC.Collect method.
                GC.Collect()

                MessageBox.Show("Export done successfully!")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub
    Private Function _RefreshdgdDate1x() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_date,R_Time,  R_Barcode1, R_ModelName, R_Name_Problem, Expr1, R_Type_Problem, R_Line, R_Name_Laber, R_SV FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            'sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "التاريخ"
            ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate1Mx() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  R_ModelName, count(R_ModelName) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الموديل"
            ds.Tables("repair").Columns(1).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgf.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate1qx() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (R_Barcode1) FROM  repair"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Line='" & txtline.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "repair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("repair").Columns(0).ColumnName = "الكمية"
            'ds.Tables("repair").Columns(1).ColumnName = "الوقت"
            'ds.Tables("repair").Columns(2).ColumnName = "الباركود"
            'ds.Tables("repair").Columns(3).ColumnName = "الموديل"
            'ds.Tables("repair").Columns(4).ColumnName = "اسم المشكلة"
            'ds.Tables("repair").Columns(5).ColumnName = "سبب المشكلة"
            'ds.Tables("repair").Columns(6).ColumnName = "نوع المشكلة"
            'ds.Tables("repair").Columns(7).ColumnName = "الخط والوردية"
            'ds.Tables("repair").Columns(8).ColumnName = "اسم سبب المشكلة"
            'ds.Tables("repair").Columns(9).ColumnName = "اسم المشرف"




            dgq.DataSource = ds.Tables("repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
End Class