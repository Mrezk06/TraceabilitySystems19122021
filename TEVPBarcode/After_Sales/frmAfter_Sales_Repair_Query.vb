Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Imports Microsoft.Office.Interop.Excel.ApplicationClass
Public Class frmAfter_Sales_Repair_Query
    Private Function _Refresh001() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_Barcode_Old) FROM AfterSales_View1 "
            sql += " where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            ' sql += " and R_FactoryCode='Refrigerator_B'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("AfterSales_View1")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_Barcode_New) FROM  barcode.dbo.AfterSales_View1 "
            sql += " where R_Barcode_New ='" & txtFATSERIAL.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("AfterSales_View1")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " and R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Time>='" & txttotime.Text & "'"
            sql += " and R_Time <= '" & txtfromTime.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("AfterSales_View1")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh0115() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            '    sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Time>='" & txttotime.Text & "'"
            sql += " and R_Time <= '" & txtfromTime.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("AfterSales_View1")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_date,R_Time,R_Barcode_Old,R_Barcode_New,R_SN_Sap_User,R_SN_Problem,R_SN_ResonProblem,Expr1,R_Areat,R_factory,R_InspactionResult,R_ModelName,Expr2,R_SN_ResonToReturn,Expr3 FROM  AfterSales_View1 "
            sql += "   where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "التاريخ"
            ds.Tables("AfterSales_View1").Columns(1).ColumnName = "الوقت"
            ds.Tables("AfterSales_View1").Columns(2).ColumnName = "الباركود القديم"
            ds.Tables("AfterSales_View1").Columns(3).ColumnName = "الباركود الجديد"
            ds.Tables("AfterSales_View1").Columns(4).ColumnName = "ساب فنى الصيانه"
            ds.Tables("AfterSales_View1").Columns(5).ColumnName = "المشكله"
            ds.Tables("AfterSales_View1").Columns(6).ColumnName = "سبب المشكله"
            ds.Tables("AfterSales_View1").Columns(7).ColumnName = "نوع المشكلة"
            ds.Tables("AfterSales_View1").Columns(8).ColumnName = "المنطقة "
            ds.Tables("AfterSales_View1").Columns(9).ColumnName = "المصنع "
            ds.Tables("AfterSales_View1").Columns(10).ColumnName = "تقرير الصيانة "
            ds.Tables("AfterSales_View1").Columns(11).ColumnName = "الموديل"
            ds.Tables("AfterSales_View1").Columns(12).ColumnName = "كود المشكلة"
            ds.Tables("AfterSales_View1").Columns(13).ColumnName = "كود الارتجاع"
            ds.Tables("AfterSales_View1").Columns(14).ColumnName = "سبب الارتجاع"
            dg.DataSource = ds.Tables("AfterSales_View1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT R_date,R_Time,R_Barcode_Old,R_Barcode_New,R_SN_Sap_User,R_SN_Problem,R_SN_ResonProblem,Expr1,R_Areat,R_factory,R_InspactionResult,R_ModelName,Expr2,R_SN_ResonToReturn,Expr3 FROM  AfterSales_View1 "
            sql += "where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "and R_Time>='" & txttotime.Text & "'"
            sql += "and R_Time<= '" & txtfromTime.Text & "'"
            sql += "and R_ModelName ='" & btnPCode.Text & "'"
            sql += "and R_factory='Cooker'"
            sql += "and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "التاريخ"
            ds.Tables("AfterSales_View1").Columns(1).ColumnName = "الوقت"
            ds.Tables("AfterSales_View1").Columns(2).ColumnName = "الباركود القديم"
            ds.Tables("AfterSales_View1").Columns(3).ColumnName = "الباركود الجديد"
            ds.Tables("AfterSales_View1").Columns(4).ColumnName = "ساب فنى الصيانه"
            ds.Tables("AfterSales_View1").Columns(5).ColumnName = "المشكله"
            ds.Tables("AfterSales_View1").Columns(6).ColumnName = "سبب المشكله"
            ds.Tables("AfterSales_View1").Columns(7).ColumnName = "نوع المشكلة"
            ds.Tables("AfterSales_View1").Columns(8).ColumnName = "المنطقة "
            ds.Tables("AfterSales_View1").Columns(9).ColumnName = "المصنع "
            ds.Tables("AfterSales_View1").Columns(10).ColumnName = "تقرير الصيانة "
            ds.Tables("AfterSales_View1").Columns(11).ColumnName = "الموديل"
            ds.Tables("AfterSales_View1").Columns(12).ColumnName = "كود المشكلة"
            ds.Tables("AfterSales_View1").Columns(13).ColumnName = "كود الارتجاع"
            ds.Tables("AfterSales_View1").Columns(14).ColumnName = "سبب الارتجاع"
            dg.DataSource = ds.Tables("AfterSales_View1")
            '  dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_date,R_Time,R_Barcode_Old,R_Barcode_New,R_SN_Sap_User,R_SN_Problem,R_SN_ResonProblem,Expr1,R_Areat,R_factory,R_InspactionResult,R_ModelName,Expr2,R_SN_ResonToReturn,Expr3 FROM  AfterSales_View1 "
            sql += "where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "and R_Time>='" & txttotime.Text & "'"
            sql += "and R_Time<= '" & txtfromTime.Text & "'"
            sql += "and R_ModelName ='" & btnPCode.Text & "'"
            sql += "and R_factory='Cooker'"
            sql += "and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "التاريخ"
            ds.Tables("AfterSales_View1").Columns(1).ColumnName = "الوقت"
            ds.Tables("AfterSales_View1").Columns(2).ColumnName = "الباركود القديم"
            ds.Tables("AfterSales_View1").Columns(3).ColumnName = "الباركود الجديد"
            ds.Tables("AfterSales_View1").Columns(4).ColumnName = "ساب فنى الصيانه"
            ds.Tables("AfterSales_View1").Columns(5).ColumnName = "المشكله"
            ds.Tables("AfterSales_View1").Columns(6).ColumnName = "سبب المشكله"
            ds.Tables("AfterSales_View1").Columns(7).ColumnName = "نوع المشكلة"
            ds.Tables("AfterSales_View1").Columns(8).ColumnName = "المنطقة "
            ds.Tables("AfterSales_View1").Columns(9).ColumnName = "المصنع "
            ds.Tables("AfterSales_View1").Columns(10).ColumnName = "تقرير الصيانة "
            ds.Tables("AfterSales_View1").Columns(11).ColumnName = "الموديل"
            ds.Tables("AfterSales_View1").Columns(12).ColumnName = "كود المشكلة"
            ds.Tables("AfterSales_View1").Columns(13).ColumnName = "كود الارتجاع"
            ds.Tables("AfterSales_View1").Columns(14).ColumnName = "سبب الارتجاع"
            dg.DataSource = ds.Tables("AfterSales_View1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Refresh1()
        _Refresh511()

    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Refresh111()
        _Refresh001()

    End Sub

    Private Sub btnsearchModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Refresh11()
        _Refresh011()
    End Sub
    Private Function _Refresh119() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_date,R_Time,R_Barcode_Old,R_Barcode_New,R_SN_Sap_User,R_SN_Problem,R_SN_ResonProblem,Expr1,R_Areat,R_factory,R_InspactionResult,R_ModelName,Expr2,R_SN_ResonToReturn,Expr3 FROM  AfterSales_View1 "
            sql += "where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "and R_Time>='" & txttotime.Text & "'"
            sql += "and R_Time<= '" & txtfromTime.Text & "'"
            '   sql += "and R_ModelName ='" & btnPCode.Text & "'"
            sql += "and R_factory='Cooker'"
            sql += "and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "التاريخ"
            ds.Tables("AfterSales_View1").Columns(1).ColumnName = "الوقت"
            ds.Tables("AfterSales_View1").Columns(2).ColumnName = "الباركود القديم"
            ds.Tables("AfterSales_View1").Columns(3).ColumnName = "الباركود الجديد"
            ds.Tables("AfterSales_View1").Columns(4).ColumnName = "ساب فنى الصيانه"
            ds.Tables("AfterSales_View1").Columns(5).ColumnName = "المشكله"
            ds.Tables("AfterSales_View1").Columns(6).ColumnName = "سبب المشكله"
            ds.Tables("AfterSales_View1").Columns(7).ColumnName = "نوع المشكلة"
            ds.Tables("AfterSales_View1").Columns(8).ColumnName = "المنطقة "
            ds.Tables("AfterSales_View1").Columns(9).ColumnName = "المصنع "
            ds.Tables("AfterSales_View1").Columns(10).ColumnName = "تقرير الصيانة "
            ds.Tables("AfterSales_View1").Columns(11).ColumnName = "الموديل"
            ds.Tables("AfterSales_View1").Columns(12).ColumnName = "كود المشكلة"
            ds.Tables("AfterSales_View1").Columns(13).ColumnName = "كود الارتجاع"
            ds.Tables("AfterSales_View1").Columns(14).ColumnName = "سبب الارتجاع"
            dg.DataSource = ds.Tables("AfterSales_View1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11999() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_date,R_Time,R_Barcode_Old,R_Barcode_New,R_SN_Sap_User,R_SN_Problem,R_SN_ResonProblem,Expr1,R_Areat,R_factory,R_InspactionResult,R_ModelName,Expr2,R_SN_ResonToReturn,Expr3 FROM  AfterSales_View1 "
            sql += "where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "and R_Time>='" & txttotime.Text & "'"
            sql += "and R_Time<= '" & txtfromTime.Text & "'"
            sql += "and R_ModelName ='" & btnPCode.Text & "'"
            sql += "and R_factory='Cooker'"
            sql += "and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "التاريخ"
            ds.Tables("AfterSales_View1").Columns(1).ColumnName = "الوقت"
            ds.Tables("AfterSales_View1").Columns(2).ColumnName = "الباركود القديم"
            ds.Tables("AfterSales_View1").Columns(3).ColumnName = "الباركود الجديد"
            ds.Tables("AfterSales_View1").Columns(4).ColumnName = "ساب فنى الصيانه"
            ds.Tables("AfterSales_View1").Columns(5).ColumnName = "المشكله"
            ds.Tables("AfterSales_View1").Columns(6).ColumnName = "سبب المشكله"
            ds.Tables("AfterSales_View1").Columns(7).ColumnName = "نوع المشكلة"
            ds.Tables("AfterSales_View1").Columns(8).ColumnName = "المنطقة "
            ds.Tables("AfterSales_View1").Columns(9).ColumnName = "المصنع "
            ds.Tables("AfterSales_View1").Columns(10).ColumnName = "تقرير الصيانة "
            ds.Tables("AfterSales_View1").Columns(11).ColumnName = "الموديل"
            ds.Tables("AfterSales_View1").Columns(12).ColumnName = "كود المشكلة"
            ds.Tables("AfterSales_View1").Columns(13).ColumnName = "كود الارتجاع"
            ds.Tables("AfterSales_View1").Columns(14).ColumnName = "سبب الارتجاع"
            dg.DataSource = ds.Tables("AfterSales_View1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmReport
            Dim rpt As New rptDate

            rpt.SetDatabaseLogon("sa", "201015")

            rpt.RecordSelectionFormula = "{DailyP.fLCDPline}='2'"

            '  rpt.RecordSelectionFormula = "  {DESIGNER.fcurrent} ='" & btnPCode.Text & "'"
            'rpt.RecordSelectionFormula += " and  {yearlyp.fPDate}>= # " & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "#"
            'rpt.RecordSelectionFormula += " and {yearlyp.fPDate}<= # " & Format(dtpTODATE.Value, "yyyy-MM-dd") & "#"



            'frm.crv.ReportSource = rpt
            'frm.Show()
            ''Me.Hide()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Timer1.Enabled = True
        Try
            Dim sql As String = ""
            sql += " SELECT  CModelName FROM CModels "
            ' sql += " where R_FactoryCode ='B'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")
            btnPCode.DataSource = ds.Tables(0)
            btnPCode.DisplayMember = "CModelName"
            btnPCode.Sorted = True
            _Refresh1()
        Catch ex As Exception

        End Try

        btnPCode.Text = ""

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Function _Refresh0119() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            sql += "where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "and R_Time>='" & txttotime.Text & "'"
            sql += "and R_Time<= '" & txtfromTime.Text & "'"
            sql += "and R_ModelName ='" & btnPCode.Text & "'"
            sql += "and R_factory='Cooker'"
            sql += "and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("AfterSales_View1")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        _Refresh0119()
        _Refresh119()
    End Sub

    Private Sub cbl_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSEARCH_Click_1(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        _Refresh001()
        _Refresh111()
        _RefreshDDDnn()
        _RefreshDDn()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        _Refresh0119()

        _Refresh11999()
        _RefreshDDDnnv()
        _RefreshDDnV()
        ' _Refresh111()
    End Sub

    Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
        _Refresh10()
        _Refresh5110()
    End Sub
    Private Function _Refresh5110() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  C_Output_Production "
            sql += " where CBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("C_Output_Production")

            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh10() As Boolean
        '  Try
        Try

            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  C_Output_Production "
            sql += " where CBarcode ='" & txtFATSERIAL.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("C_Output_Production").Columns(1).ColumnName = " الوقت "

            ds.Tables("C_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("C_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("C_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("C_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ' ds.Tables("TW_V_new").Columns(5).ColumnName = "اسم المسئول"
            ds.Tables("C_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            '  ds.Tables("Heater_registration_Two").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("C_Output_Production")
            Return True
        Catch ex As Exception
        End Try

    End Function
    Private Function _Refresh1010() As Boolean
        '  Try
        Try

            Dim sql As String = ""
            sql += " SELECT R_date,R_Time,R_Barcode_Old,R_Barcode_New,R_SN_Sap_User,R_SN_Problem,R_SN_ResonProblem,Expr1,R_Areat,R_factory,R_InspactionResult,R_ModelName,Expr2,R_SN_ResonToReturn,Expr3 FROM  AfterSales_View1 "
            sql += " where R_Barcode_New ='" & TextBox2.Text & "'"
            sql += " or R_Barcode_Old ='" & TextBox2.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = " التاريخ "
            ds.Tables("AfterSales_View1").Columns(1).ColumnName = " الوقت "
            ds.Tables("AfterSales_View1").Columns(2).ColumnName = " الباركود القديم"
            ds.Tables("AfterSales_View1").Columns(3).ColumnName = "الباركود الجديد"
            ds.Tables("AfterSales_View1").Columns(4).ColumnName = "ساب فنى الصيانه"
            ds.Tables("AfterSales_View1").Columns(5).ColumnName = " المشكله "
            ds.Tables("AfterSales_View1").Columns(6).ColumnName = "سبب المشكله "
            ds.Tables("AfterSales_View1").Columns(7).ColumnName = "نوع المشكلة "
            ds.Tables("AfterSales_View1").Columns(8).ColumnName = " المنطقة "
            ds.Tables("AfterSales_View1").Columns(9).ColumnName = " المصنع "
            ds.Tables("AfterSales_View1").Columns(10).ColumnName = "تقرير الصيانة "
            ds.Tables("AfterSales_View1").Columns(11).ColumnName = "الموديل"
            ds.Tables("AfterSales_View1").Columns(12).ColumnName = " كود المشكلة"
            ds.Tables("AfterSales_View1").Columns(13).ColumnName = "كود الارتجاع"
            ds.Tables("AfterSales_View1").Columns(14).ColumnName = "سبب الارتجاع"
            dg.DataSource = ds.Tables("AfterSales_View1")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh100() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT count(R_Barcode_Old) FROM  AfterSales_View1 "
            sql += " where R_Barcode_New ='" & TextBox2.Text & "'"
            sql += " or R_Barcode_Old ='" & TextBox2.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية "
            dg6.DataSource = ds.Tables("AfterSales_View1")
            Return True
        Catch ex As Exception
        End Try



    End Function

    Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        btnPCode.Text = dg9.Item(0, dg9.CurrentRow.Index).Value
    End Sub


    Private Sub cbl_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs)
        '    _Refresh155()
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh3()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReport_Click_1(sender As Object, e As EventArgs) Handles btnReport.Click

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = SaveFileDialog1.FileName
        End If
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        For i = 0 To dg.RowCount - 2
            For j = 0 To dg.ColumnCount - 1
                For k As Integer = 1 To dg.Columns.Count
                    xlWorkSheet.Cells(1, k) = dg.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dg(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.SaveAs(TextBox1.Text)
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("You can find the file in " + TextBox1.Text)
    End Sub
    Private Function _Refresh3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_ModelName,count(R_ModelName) FROM  AfterSales_MainRepair "
            sql += " where R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_MainRepair")
            ds.Tables("AfterSales_MainRepair").Columns(0).ColumnName = "الموديل"
            ds.Tables("AfterSales_MainRepair").Columns(1).ColumnName = "الكمية"
            dg9.DataSource = ds.Tables("AfterSales_MainRepair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh1010()
        _Refresh100()
        _RefreshDDnV1()
        _RefreshDDDnnv1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _Refresh119()
        _Refresh0115()
        _RefreshDD()
        _RefreshDDD()

    End Sub

    Private Function _RefreshDD() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            '    sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Time>='" & txttotime.Text & "'"
            sql += " and R_Time <= '" & txtfromTime.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += " and Expr2 = R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dge.DataSource = ds.Tables("AfterSales_View1")
            dge.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDDD() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            '    sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Time>='" & txttotime.Text & "'"
            sql += " and R_Time <= '" & txtfromTime.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += " and Expr2 <> R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dgn.DataSource = ds.Tables("AfterSales_View1")
            dgn.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function







    Private Function _RefreshDDn() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            '    sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += "and Expr2 = R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dge.DataSource = ds.Tables("AfterSales_View1")
            dge.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDDDnn() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            '    sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " where R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"

            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += "and Expr2 <> R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dgn.DataSource = ds.Tables("AfterSales_View1")
            dgn.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function





    Private Function _RefreshDDnV() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " and R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Time>='" & txttotime.Text & "'"
            sql += " and R_Time <= '" & txtfromTime.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += " and Expr2 = R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dge.DataSource = ds.Tables("AfterSales_View1")
            dge.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDDDnnv() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " and R_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Time>='" & txttotime.Text & "'"
            sql += " and R_Time <= '" & txtfromTime.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += " and Expr2 <> R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dgn.DataSource = ds.Tables("AfterSales_View1")
            dgn.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Function _RefreshDDnV1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            sql += " where R_Barcode_New ='" & TextBox2.Text & "'"
            sql += " or R_Barcode_Old ='" & TextBox2.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += "and Expr2 = R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dge.DataSource = ds.Tables("AfterSales_View1")
            dge.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDDDnnv1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            sql += " where R_Barcode_New ='" & TextBox2.Text & "'"
            sql += " or R_Barcode_Old ='" & TextBox2.Text & "'"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += "and Expr2 <> R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dgn.DataSource = ds.Tables("AfterSales_View1")
            dgn.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function



End Class


