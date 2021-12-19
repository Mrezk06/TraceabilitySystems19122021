Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports TEVPBarcode.sher
Public Class frmHeaterStepTwoOfflinQuery




    ' Public Class frmHeaterStepOneQuery



    ' Imports TEVPBarcode.sher

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtPCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function _Refresh001() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count(H_BoardBarcode) FROM Heater_BoardReg "
            sql += "   where H_Date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = " summation "
            dg6.DataSource = ds.Tables("Heater_BoardReg")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( H_BoardBarcode) FROM Heater_BoardReg "
            sql += " where H_BoardBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = " summation "
            dg6.DataSource = ds.Tables("Heater_BoardReg")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(H_BoardBarcode) FROM  Heater_BoardReg "
            sql += " where H_ModelName ='" & btnPCode.Text & "'"
            sql += "   and H_Date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = " summation "
            dg6.DataSource = ds.Tables("Heater_BoardReg")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT  H_Date, H_time, H_ModelName, H_BoardBarcode, H_NameBoard, H_LineAndShift, H_Sap FROM  Heater_BoardReg "
            sql += "   where H_Date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = "Date "
            ds.Tables("Heater_BoardReg").Columns(1).ColumnName = "Time "
            ds.Tables("Heater_BoardReg").Columns(2).ColumnName = "Model Name"
            ds.Tables("Heater_BoardReg").Columns(3).ColumnName = "Board Barcode"
            ds.Tables("Heater_BoardReg").Columns(4).ColumnName = "Board Name"
            ds.Tables("Heater_BoardReg").Columns(5).ColumnName = "Line And Shift"
            ds.Tables("Heater_BoardReg").Columns(6).ColumnName = "Sap"
            'ds.Tables("Heater_BoardReg").Columns(7).ColumnName = "H_Sap"
            dg.DataSource = ds.Tables("Heater_BoardReg")
            Return True
        Catch ex As Exception
        End Try
    End Function
   
    'Private Function _Refresh11() As Boolean
    '    Try


    '        Dim sql As String = ""
    '        sql += " SELECT  H_date, H_time, H_Model_Name, H_Heater_Code, H_PCB_P, H_PCB_C, H_Shift_Line, H_Name_Laber FROM  barcode.dbo.Heater_BoardReg "
    '        sql += " where H_Model_Name ='" & btnPCode.Text & "'"
    '        sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and H_time>='" & txttotime.Text & "'"
    '        sql += "   and H_time<= '" & txtfromTime.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Heater_BoardReg")
    '        ds.Tables("Heater_BoardReg").Columns(0).ColumnName = "Date "
    '        ds.Tables("Heater_BoardReg").Columns(1).ColumnName = "Time "
    '        ds.Tables("Heater_BoardReg").Columns(2).ColumnName = "Model Name"
    '        ds.Tables("Heater_BoardReg").Columns(3).ColumnName = "H_Heater_Code"
    '        ds.Tables("Heater_BoardReg").Columns(4).ColumnName = "H_PCB_P"
    '        ds.Tables("Heater_BoardReg").Columns(5).ColumnName = "H_PCB_C"
    '        ds.Tables("Heater_BoardReg").Columns(6).ColumnName = "H_Shift_Line"
    '        ds.Tables("Heater_BoardReg").Columns(7).ColumnName = "H_Sap"
    '        dg.DataSource = ds.Tables("Heater_BoardReg")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh11() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT  H_Date, H_time, H_ModelName, H_BoardBarcode, H_NameBoard, H_LineAndShift, H_Sap FROM  Heater_BoardReg "
            sql += " where H_ModelName ='" & btnPCode.Text & "'"
            sql += "   and H_Date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = "Date "
            ds.Tables("Heater_BoardReg").Columns(1).ColumnName = "Time "
            ds.Tables("Heater_BoardReg").Columns(2).ColumnName = "Model Name"
            ds.Tables("Heater_BoardReg").Columns(3).ColumnName = "Board Barcode"
            ds.Tables("Heater_BoardReg").Columns(4).ColumnName = "Board Name"
            ds.Tables("Heater_BoardReg").Columns(5).ColumnName = "Line And Shift"
            ds.Tables("Heater_BoardReg").Columns(6).ColumnName = "Sap"
            'ds.Tables("Heater_BoardReg").Columns(7).ColumnName = "H_Sap"
            dg.DataSource = ds.Tables("Heater_BoardReg")
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Function _Refresh1() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += " SELECT H_date, H_time, H_Model_Name, H_Heater_Code, H_Tank, H_Shift_Line, H_sap  FROM  barcode.dbo.Heater_registration_one1 "
    '        sql += " where H_Heater_Code ='" & txtFATSERIAL.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Heater_registration_one1")
    '        ds.Tables("Heater_registration_one1").Columns(0).ColumnName = " Date "
    '        ds.Tables("Heater_registration_one1").Columns(1).ColumnName = "time "
    '        ds.Tables("Heater_registration_one1").Columns(2).ColumnName = "Model Name"
    '        ds.Tables("Heater_registration_one1").Columns(3).ColumnName = "Heater_Code"
    '        ds.Tables("Heater_registration_one1").Columns(4).ColumnName = "Heater_Tank"
    '        ds.Tables("Heater_registration_one1").Columns(5).ColumnName = "Shift_Line"
    '        ds.Tables("Heater_registration_one1").Columns(6).ColumnName = "Sap"
    '        dg.DataSource = ds.Tables("Heater_registration_one1")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    'Private Function _Refresh1() As Boolean
    '    Try


    '        Dim sql As String = ""
    '        sql += " SELECT  H_date, H_time, H_Model_Name, H_Heater_Code, H_PCB_P, H_PCB_C, H_Shift_Line, H_Name_Laber FROM  barcode.dbo.Heater_BoardReg "
    '        sql += " where H_Heater_Code ='" & txtFATSERIAL.Text & "'"
    '        sql += " or H_PCB_C ='" & txtFATSERIAL.Text & "'"
    '        sql += " or H_PCB_P ='" & txtFATSERIAL.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Heater_BoardReg")
    '        ds.Tables("Heater_BoardReg").Columns(0).ColumnName = "Date "
    '        ds.Tables("Heater_BoardReg").Columns(1).ColumnName = "Time "
    '        ds.Tables("Heater_BoardReg").Columns(2).ColumnName = "Model Name"
    '        ds.Tables("Heater_BoardReg").Columns(3).ColumnName = "H_Heater_Code"
    '        ds.Tables("Heater_BoardReg").Columns(4).ColumnName = "H_PCB_P"
    '        ds.Tables("Heater_BoardReg").Columns(5).ColumnName = "H_PCB_C"
    '        ds.Tables("Heater_BoardReg").Columns(6).ColumnName = "H_Shift_Line"
    '        ds.Tables("Heater_BoardReg").Columns(7).ColumnName = "H_Sap"
    '        dg.DataSource = ds.Tables("Heater_BoardReg")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh1() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT  H_Date, H_time, H_ModelName, H_BoardBarcode, H_NameBoard, H_LineAndShift, H_Sap FROM  Heater_BoardReg "
            sql += " where H_BoardBarcode ='" & txtFATSERIAL.Text & "'"
            'sql += " or H_PCB_C ='" & txtFATSERIAL.Text & "'"
            'sql += " or H_PCB_P ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = "Date "
            ds.Tables("Heater_BoardReg").Columns(1).ColumnName = "Time "
            ds.Tables("Heater_BoardReg").Columns(2).ColumnName = "Model Name"
            ds.Tables("Heater_BoardReg").Columns(3).ColumnName = "Board Barcode"
            ds.Tables("Heater_BoardReg").Columns(4).ColumnName = "Board Name"
            ds.Tables("Heater_BoardReg").Columns(5).ColumnName = "Line And Shift"
            ds.Tables("Heater_BoardReg").Columns(6).ColumnName = "Sap"
            'ds.Tables("Heater_BoardReg").Columns(7).ColumnName = "H_Sap"
            dg.DataSource = ds.Tables("Heater_BoardReg")
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
    'Private Function _Refresh119() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += " SELECT  H_date, H_time, H_Model_Name, H_Heater_Code, H_Tank, H_Shift_Line, H_sap FROM  barcode.dbo.Heater_registration_one1 "
    '        sql += " where H_Model_Name ='" & btnPCode.Text & "'"
    '        sql += " and H_Shift_Line ='" & cbl.Text & "'"
    '        sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and H_time>='" & txttotime.Text & "'"
    '        sql += "   and H_time<= '" & txtfromTime.Text & "'"
    '        'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        '    da.Fill(ds, "DailyP")
    '        da.Fill(ds, "Heater_registration_one1")
    '        ds.Tables("Heater_registration_one1").Columns(0).ColumnName = " Date "
    '        ds.Tables("Heater_registration_one1").Columns(1).ColumnName = "time "
    '        ds.Tables("Heater_registration_one1").Columns(2).ColumnName = "Model Name"
    '        ds.Tables("Heater_registration_one1").Columns(3).ColumnName = "Heater_Code"
    '        ds.Tables("Heater_registration_one1").Columns(4).ColumnName = "Heater_Tank"
    '        ds.Tables("Heater_registration_one1").Columns(5).ColumnName = "Shift_Line"
    '        ds.Tables("Heater_registration_one1").Columns(6).ColumnName = "Sap"
    '        dg.DataSource = ds.Tables("Heater_registration_one1")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    'Private Function _Refresh119() As Boolean
    '    Try


    '        Dim sql As String = ""
    '        sql += " SELECT  H_date, H_time, H_Model_Name, H_Heater_Code, H_PCB_P, H_PCB_C, H_Shift_Line, H_Name_Laber FROM  barcode.dbo.Heater_BoardReg "
    '        sql += " where H_Model_Name ='" & btnPCode.Text & "'"
    '        sql += " and H_Shift_Line ='" & cbl.Text & "'"
    '        sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and H_time>='" & txttotime.Text & "'"
    '        sql += "   and H_time<= '" & txtfromTime.Text & "'"
    '        'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Heater_BoardReg")
    '        ds.Tables("Heater_BoardReg").Columns(0).ColumnName = "Date "
    '        ds.Tables("Heater_BoardReg").Columns(1).ColumnName = "Time "
    '        ds.Tables("Heater_BoardReg").Columns(2).ColumnName = "Model Name"
    '        ds.Tables("Heater_BoardReg").Columns(3).ColumnName = "H_Heater_Code"
    '        ds.Tables("Heater_BoardReg").Columns(4).ColumnName = "H_PCB_P"
    '        ds.Tables("Heater_BoardReg").Columns(5).ColumnName = "H_PCB_C"
    '        ds.Tables("Heater_BoardReg").Columns(6).ColumnName = "H_Shift_Line"
    '        ds.Tables("Heater_BoardReg").Columns(7).ColumnName = "H_Sap"
    '        dg.DataSource = ds.Tables("Heater_BoardReg")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh119() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT  H_Date, H_time, H_ModelName, H_BoardBarcode, H_NameBoard, H_LineAndShift, H_Sap FROM  Heater_BoardReg "
            sql += " where H_ModelName ='" & btnPCode.Text & "'"
            sql += " and H_LineAndShift ='" & cbl.Text & "'"
            sql += "   and H_Date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = "Date "
            ds.Tables("Heater_BoardReg").Columns(1).ColumnName = "Time "
            ds.Tables("Heater_BoardReg").Columns(2).ColumnName = "Model Name"
            ds.Tables("Heater_BoardReg").Columns(3).ColumnName = "Board Barcode"
            ds.Tables("Heater_BoardReg").Columns(4).ColumnName = "Board Name"
            ds.Tables("Heater_BoardReg").Columns(5).ColumnName = "Line And Shift"
            ds.Tables("Heater_BoardReg").Columns(6).ColumnName = "Sap"
            'ds.Tables("Heater_BoardReg").Columns(7).ColumnName = "H_Sap"
            dg.DataSource = ds.Tables("Heater_BoardReg")
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
            'Me.Hide()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/SteelBlack.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT   Model_Name FROM  Heater_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_ModelName")
            btnPCode.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            btnPCode.DisplayMember = "Model_Name"
            btnPCode.Sorted = True
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Function _Refresh0119() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(H_BoardBarcode) FROM Heater_BoardReg "
            sql += " where H_ModelName ='" & btnPCode.Text & "'"
            sql += " and H_LineAndShift ='" & cbl.Text & "'"
            sql += "   and H_Date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("Heater_BoardReg")
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
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        _Refresh0119()
        _Refresh119()
        ' _Refresh111()
    End Sub

    Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
        _Refresh1()
        _Refresh511()
    End Sub

    Private Sub btnsearchModel_Click_1(sender As Object, e As EventArgs) Handles btnsearchModel.Click
        _Refresh11()
        _Refresh011()

    End Sub

    Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg9.CellContentClick
        btnPCode.Text = dg9.Item(0, dg9.CurrentRow.Index).Value
    End Sub
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT H_ModelName, count(H_BoardBarcode) AS tot"
            sql += " FROM Heater_BoardReg"
            sql += " WHERE H_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and H_LineAndShift ='" & cbl.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY H_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = " Model Name"
            ds.Tables("Heater_BoardReg").Columns(1).ColumnName = " Qty"
            dg9.DataSource = ds.Tables("Heater_BoardReg")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs) Handles cbl.Leave
        _Refresh155()
    End Sub
End Class