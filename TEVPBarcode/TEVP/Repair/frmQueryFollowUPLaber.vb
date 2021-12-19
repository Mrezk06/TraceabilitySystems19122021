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
Public Class frmQueryFollowUPLaber

    Private Sub frmQueryFollowUPLaber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function _RefreshdgdDate1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fTypeFollow, fTypeProcess, fNote, FNAME, fSV, fLineAndShift, Heater_Name_Laber FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            ' sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "التاريخ"
            ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "الوقت"
            ds.Tables("FollowUpLaberV").Columns(2).ColumnName = "نوع المتابعة"
            ds.Tables("FollowUpLaberV").Columns(3).ColumnName = "الحركة"
            ds.Tables("FollowUpLaberV").Columns(4).ColumnName = "الملاحظات "
            ds.Tables("FollowUpLaberV").Columns(5).ColumnName = "اسم الفنى "
            ds.Tables("FollowUpLaberV").Columns(6).ColumnName = "اسم المشرف "
            ds.Tables("FollowUpLaberV").Columns(7).ColumnName = "الخط والوردية "
            ds.Tables("FollowUpLaberV").Columns(8).ColumnName = " اسم مدخل البيانات "
            ' ds.Tables("FollowUpLaberV").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate2() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fTypeFollow,count(fTypeFollow) FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            ' sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += "group by fTypeFollow"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "نوع المتابعة "
            ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "العدد"
            dgf.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fTypeFollow) FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            ' sql += " and R_ModelName='" & txtmodel.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += "group by fTypeFollow"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "عدد العمليات"
            ' ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "العدد"
            dgq.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtsap.Text = "" And txtline.Text = "" And txtsv.Text = "" Then
            _RefreshdgdDate1()
            _RefreshdgdDate2()
            _RefreshdgdDate3()

        ElseIf txtline.Text = "" And txtsv.Text = "" Then
            _RefreshdgdDate4()
            _RefreshdgdDate5()
            _RefreshdgdDate6()
        ElseIf txtsap.Text = "" And txtsv.Text = "" Then
            _RefreshdgdDate7()
            _RefreshdgdDate8()
            _RefreshdgdDate9()
        ElseIf txtsap.Text = "" And txtline.Text = "" Then
            _RefreshdgdDate10()
            _RefreshdgdDate11()
            _RefreshdgdDate12()
        End If
    End Sub
    Private Function _RefreshdgdDate10() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fTypeFollow, fTypeProcess, fNote, FNAME, fSV, fLineAndShift, Heater_Name_Laber FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fSV='" & txtsv.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "التاريخ"
            ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "الوقت"
            ds.Tables("FollowUpLaberV").Columns(2).ColumnName = "نوع المتابعة"
            ds.Tables("FollowUpLaberV").Columns(3).ColumnName = "الحركة"
            ds.Tables("FollowUpLaberV").Columns(4).ColumnName = "الملاحظات "
            ds.Tables("FollowUpLaberV").Columns(5).ColumnName = "اسم الفنى "
            ds.Tables("FollowUpLaberV").Columns(6).ColumnName = "اسم المشرف "
            ds.Tables("FollowUpLaberV").Columns(7).ColumnName = "الخط والوردية "
            ds.Tables("FollowUpLaberV").Columns(8).ColumnName = " اسم مدخل البيانات "
            ' ds.Tables("FollowUpLaberV").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate11() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fTypeFollow,count(fTypeFollow) FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fSV='" & txtsv.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += "group by fTypeFollow"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "نوع المتابعة "
            ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "العدد"
            dgf.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate12() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fTypeFollow) FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fSV='" & txtsv.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += "group by fTypeFollow"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "عدد العمليات"
            ' ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "العدد"
            dgq.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate4() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fTypeFollow, fTypeProcess, fNote, FNAME, fSV, fLineAndShift, Heater_Name_Laber FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fSapLaber=" & txtsap.Text & ""
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "التاريخ"
            ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "الوقت"
            ds.Tables("FollowUpLaberV").Columns(2).ColumnName = "نوع المتابعة"
            ds.Tables("FollowUpLaberV").Columns(3).ColumnName = "الحركة"
            ds.Tables("FollowUpLaberV").Columns(4).ColumnName = "الملاحظات "
            ds.Tables("FollowUpLaberV").Columns(5).ColumnName = "اسم الفنى "
            ds.Tables("FollowUpLaberV").Columns(6).ColumnName = "اسم المشرف "
            ds.Tables("FollowUpLaberV").Columns(7).ColumnName = "الخط والوردية "
            ds.Tables("FollowUpLaberV").Columns(8).ColumnName = " اسم مدخل البيانات "
            ' ds.Tables("FollowUpLaberV").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate5() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fTypeFollow,count(fTypeFollow) FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fSapLaber=" & txtsap.Text & ""
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += "group by fTypeFollow"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "نوع المتابعة "
            ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "العدد"
            dgf.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate6() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fTypeFollow) FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fSapLaber=" & txtsap.Text & ""
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += "group by fTypeFollow"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "عدد العمليات"
            ' ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "العدد"
            dgq.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate7() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fTypeFollow, fTypeProcess, fNote, FNAME, fSV, fLineAndShift, Heater_Name_Laber FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fLineAndShift='" & txtline.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += " group by R_Name_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "التاريخ"
            ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "الوقت"
            ds.Tables("FollowUpLaberV").Columns(2).ColumnName = "نوع المتابعة"
            ds.Tables("FollowUpLaberV").Columns(3).ColumnName = "الحركة"
            ds.Tables("FollowUpLaberV").Columns(4).ColumnName = "الملاحظات "
            ds.Tables("FollowUpLaberV").Columns(5).ColumnName = "اسم الفنى "
            ds.Tables("FollowUpLaberV").Columns(6).ColumnName = "اسم المشرف "
            ds.Tables("FollowUpLaberV").Columns(7).ColumnName = "الخط والوردية "
            ds.Tables("FollowUpLaberV").Columns(8).ColumnName = " اسم مدخل البيانات "
            ' ds.Tables("FollowUpLaberV").Columns(9).ColumnName = "اسم المشرف"




            dg9.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate8() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fTypeFollow,count(fTypeFollow) FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fLineAndShift='" & txtline.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += "group by fTypeFollow"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "نوع المتابعة "
            ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "العدد"
            dgf.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshdgdDate9() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fTypeFollow) FROM FollowUpLaberV"

            ' sql += " FROM Output"
            ' sql += " where R_Barcode1='" & txtbarcode.Text & "'"
            sql += "   where fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and fLineAndShift='" & txtline.Text & "'"
            ' sql += " and R_Type_Problem='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            ' sql += " and R_SV='" & txtbarcode.Text & "'"
            ' sql += " and R_Line='" & txtbarcode.Text & "'"
            'sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += "group by fTypeFollow"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaberV")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("FollowUpLaberV").Columns(0).ColumnName = "عدد العمليات"
            ' ds.Tables("FollowUpLaberV").Columns(1).ColumnName = "العدد"
            dgq.DataSource = ds.Tables("FollowUpLaberV")
            Return True
        Catch ex As Exception
        End Try
    End Function
End Class