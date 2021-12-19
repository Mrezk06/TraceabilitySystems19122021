Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports TEVPBarcode.sher
Public Class frmRefrigerator_Body_CompletedQuery
    Private Sub frmRefrigerator_Body_CompletedQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/SteelBlack.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT   R_ModelName FROM  Refrigerator_Models "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Refrigerator_Models")
            btnPCode.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            btnPCode.DisplayMember = "R_ModelName"
            btnPCode.Sorted = True
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnsearch1_Click(sender As Object, e As EventArgs) Handles btnsearch1.Click
        _Refresh1()
        _Refresh511()
        _Refresh155()

    End Sub

    Private Function _Refresh1551() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_ModelName, count(R_Barcode) AS tot"
            sql += " FROM Refrigerator_InputView"
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += " and R_FactoryCode ='C'"
            sql += " GROUP BY R_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = "الكمية"
            dg9.DataSource = ds.Tables("Refrigerator_InputView")
            dg9.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh5111() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM Refrigerator_InputView "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("Refrigerator_InputView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT R_Date, R_Time,R_ModelName, R_ColorName, R_Barcode, R_Line, R_FactoryCode, R_SapUser, R_ProductionType FROM Refrigerator_InputView "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_InputView").Columns(2).ColumnName = "اسم الموديل "
            ds.Tables("Refrigerator_InputView").Columns(3).ColumnName = "اللون"
            ds.Tables("Refrigerator_InputView").Columns(4).ColumnName = "الباركود"
            ds.Tables("Refrigerator_InputView").Columns(5).ColumnName = "الوردية"
            ds.Tables("Refrigerator_InputView").Columns(6).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_InputView").Columns(7).ColumnName = "رقم ساب المسئول"
            ds.Tables("Refrigerator_InputView").Columns(8).ColumnName = "نوع الانتاج "
            dg.DataSource = ds.Tables("Refrigerator_InputView")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_ModelName, count(R_Barcode) AS tot"
            sql += " FROM Refrigerator_InputView"
            sql += " where R_Barcode ='" & txtFATSERIAL.Text & "'"
            sql += " and R_FactoryCode ='C'"
            sql += " GROUP BY R_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = " اسم الموديل "
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = " الكمية"
            dg9.DataSource = ds.Tables("Refrigerator_InputView")
            dg9.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM Refrigerator_InputView "
            sql += " where R_Barcode ='" & txtFATSERIAL.Text & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = "الكمية "
            dg6.DataSource = ds.Tables("Refrigerator_InputView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT R_Date, R_Time,R_ModelName, R_ColorName, R_Barcode, R_Line, R_FactoryCode, R_SapUser, R_ProductionType FROM Refrigerator_InputView "
            sql += " where R_Barcode ='" & txtFATSERIAL.Text & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_InputView").Columns(2).ColumnName = "اسم الموديل "
            ds.Tables("Refrigerator_InputView").Columns(3).ColumnName = "اللون"
            ds.Tables("Refrigerator_InputView").Columns(4).ColumnName = "الباركود"
            ds.Tables("Refrigerator_InputView").Columns(5).ColumnName = "الوردية"
            ds.Tables("Refrigerator_InputView").Columns(6).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_InputView").Columns(7).ColumnName = "رقم ساب المسئول"
            ds.Tables("Refrigerator_InputView").Columns(8).ColumnName = "نوع الانتاج "
            dg.DataSource = ds.Tables("Refrigerator_InputView")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        If txttotime.Text = "" Or txtfromTime.Text = "" Then
            _Refresh11()
            _Refresh5111()
            _Refresh1551()

        Else
            _Refresh15511()
            _Refresh51111()
            _Refresh111()

        End If
    End Sub
    Private Function _Refresh15511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_ModelName, count(R_Barcode) AS tot"
            sql += " FROM Refrigerator_InputView"
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode ='C'"
            sql += " GROUP BY R_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = " اسم الموديل"
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = " الكمية"
            dg9.DataSource = ds.Tables("Refrigerator_InputView")
            dg9.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh51111() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM Refrigerator_InputView "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("Refrigerator_InputView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT R_Date, R_Time,R_ModelName, R_ColorName, R_Barcode, R_Line, R_FactoryCode, R_SapUser, R_ProductionType FROM Refrigerator_InputView "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_InputView").Columns(2).ColumnName = "اسم الموديل "
            ds.Tables("Refrigerator_InputView").Columns(3).ColumnName = "اللون"
            ds.Tables("Refrigerator_InputView").Columns(4).ColumnName = "الباركود"
            ds.Tables("Refrigerator_InputView").Columns(5).ColumnName = "الوردية"
            ds.Tables("Refrigerator_InputView").Columns(6).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_InputView").Columns(7).ColumnName = "رقم ساب المسئول"
            ds.Tables("Refrigerator_InputView").Columns(8).ColumnName = "نوع الانتاج "
            dg.DataSource = ds.Tables("Refrigerator_InputView")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnsearchModel_Click(sender As Object, e As EventArgs) Handles btnsearchModel.Click
        _Refresh155111()
        _Refresh511111()
        _Refresh1111()
    End Sub

    Private Function _Refresh155111() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_ModelName, count(R_Barcode) AS tot"
            sql += " FROM Refrigerator_InputView"
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " and R_Line ='" & cbl.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode ='C'"
            sql += " GROUP BY R_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = " اسم الموديل "
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = " الكية"
            dg9.DataSource = ds.Tables("Refrigerator_InputView")
            dg9.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh511111() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM Refrigerator_InputView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " and R_Line ='" & cbl.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("Refrigerator_InputView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1111() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT R_Date, R_Time,R_ModelName, R_ColorName, R_Barcode, R_Line, R_FactoryCode, R_SapUser, R_ProductionType FROM Refrigerator_InputView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " and R_Line ='" & cbl.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTo.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_InputView").Columns(2).ColumnName = "اسم الموديل "
            ds.Tables("Refrigerator_InputView").Columns(3).ColumnName = "اللون"
            ds.Tables("Refrigerator_InputView").Columns(4).ColumnName = "الباركود"
            ds.Tables("Refrigerator_InputView").Columns(5).ColumnName = "الوردية"
            ds.Tables("Refrigerator_InputView").Columns(6).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_InputView").Columns(7).ColumnName = "رقم ساب المسئول"
            ds.Tables("Refrigerator_InputView").Columns(8).ColumnName = "نوع الانتاج "
            dg.DataSource = ds.Tables("Refrigerator_InputView")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
End Class