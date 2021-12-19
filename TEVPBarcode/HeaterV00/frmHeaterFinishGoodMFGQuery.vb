Imports TEVPBarcode.sher
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SqlClient
'Imports System.Data
Imports System.IO.Directory
Public Class frmHeaterFinishGoodMFGQuery



    Private Sub Heater_Step_Two_Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        Try
            Timer1.Enabled = True

            Dim sql As String = ""
            sql += "SELECT Model_Name FROM Heater_ModelName"
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
    Private Function _Refresh001() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  Heater_FinishGood_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh0000() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM   Heater_FinishGood_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  Heater_FinishGood_Production "
            sql += " where CBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  Heater_FinishGood_Production "
            sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += "   and CDate '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  CDate, Ctime, CBarcode, CModelName, C_Line_Shift, CSapUser FROM Heater_FinishGood_Production"
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("Heater_FinishGood_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("Heater_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("Heater_FinishGood_Production").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("Heater_FinishGood_Production").Columns(5).ColumnName = "رقم ساب المسئول"
            dg.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh10011() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  CDate, Ctime, CBarcode, CModelName, C_Line_Shift, CSapUser FROM Heater_FinishGood_Production"
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("Heater_FinishGood_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("Heater_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("Heater_FinishGood_Production").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("Heater_FinishGood_Production").Columns(5).ColumnName = "رقم ساب المسئول"
            dg.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  CDate, Ctime, CBarcode, CModelName, C_Line_Shift, CSapUser FROM Heater_FinishGood_Production"
            sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += "   and CDate= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("Heater_FinishGood_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("Heater_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("Heater_FinishGood_Production").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("Heater_FinishGood_Production").Columns(5).ColumnName = "رقم ساب المسئول"
            dg.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh10() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  CDate, Ctime, CBarcode, CModelName, C_Line_Shift, CSapUser FROM Heater_FinishGood_Production"
            sql += " where CBarcode ='" & btnPCode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("Heater_FinishGood_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("Heater_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("Heater_FinishGood_Production").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("Heater_FinishGood_Production").Columns(5).ColumnName = "رقم ساب المسئول"
            dg.DataSource = ds.Tables("Heater_FinishGood_Production")
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
            sql += "SELECT  CDate, Ctime, CBarcode, CModelName, C_Line_Shift, CSapUser FROM Heater_FinishGood_Production"
            sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += " and C_Line_Shift ='" & cbl.Text & "'"
            sql += "   and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("Heater_FinishGood_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("Heater_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("Heater_FinishGood_Production").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("Heater_FinishGood_Production").Columns(5).ColumnName = "رقم ساب المسئول"
            dg.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1719() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  CDate, Ctime, CBarcode, CModelName, C_Line_Shift, CSapUser FROM Heater_FinishGood_Production"
            sql += " where C_Line_Shift ='" & cbl.Text & "'"
            sql += "   and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("Heater_FinishGood_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("Heater_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("Heater_FinishGood_Production").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("Heater_FinishGood_Production").Columns(5).ColumnName = "رقم ساب المسئول"
            dg.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmReport
            Dim rpt As New rptDate

            rpt.SetDatabaseLogon("sa", "201015")

            rpt.RecordSelectionFormula = "{Heater_registration_Two.H_Shift_Line}='2'"

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
        ' Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        'Try
        '    Dim sql As String = ""
        '    sql += " SELECT  Model_Name, Model_control FROM  Heater_ModelName "
        '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        '    Dim ds As New DataSet
        '    ds.Tables.Clear()
        '    da.Fill(ds, "Heater_ModelName")
        '    btnPCode.DataSource = ds.Tables(0)
        '    '  cmb_Pcode.ValueMember = "fLCDSetID"
        '    btnPCode.DisplayMember = "Heater_ModelName"
        '    btnPCode.Sorted = True
        '    _Refresh1()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Function _Refresh0119() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM Heater_FinishGood_Production "

            sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += " and C_Line_Shift ='" & cbl.Text & "'"
            sql += "   and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            '         sql += " and H_Model_Name ='" & btnPCode.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh019919() As Boolean
        Try
            'Dim sql As String = ""
            'sql += " SELECT count(H_Heater_Code) FROM TH_v_new "

            ''   sql += " where Model_Name ='" & btnPCode.Text & "'"
            'sql += " where H_Line_Name ='" & cbl.Text & "'"
            'sql += "   and H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            ''         sql += " and H_Model_Name ='" & btnPCode.Text & "'"
            ''sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "TH_v_new")
            'ds.Tables("TH_v_new").Columns(0).ColumnName = " الكمية "
            'dg6.DataSource = ds.Tables("TH_v_new")
            'Return True
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM Heater_FinishGood_Production "

            ' sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += " where C_Line_Shift ='" & cbl.Text & "'"
            sql += "   and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            '         sql += " and H_Model_Name ='" & btnPCode.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("Heater_FinishGood_Production")
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
        If txttotime.Text = "" And txtfromTime.Text = "" Then
            _Refresh001()
            _Refresh111()
        Else
            _Refresh0000()
            _Refresh10011()
        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If btnPCode.Text = "" Then
            _Refresh1719()
            _Refresh019919()
        Else
            _Refresh0119()
            _Refresh119()
        End If


        ' _Refresh111()
    End Sub

    'Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
    '    _Refresh1()
    '    _Refresh511()
    'End Sub

    Private Sub btnsearchModel_Click_1(sender As Object, e As EventArgs)
        _Refresh11()
        _Refresh011()

    End Sub

    Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg9.CellContentClick
        btnPCode.Text = dg9.Item(0, dg9.CurrentRow.Index).Value
    End Sub
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " select C_Line_Shift,CModelName,count(CBarcode)"
            sql += " FROM Heater_FinishGood_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " GROUP BY C_Line_Shift,CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " الخط"
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = "الموديل"
            ds.Tables("Heater_FinishGood_Production").Columns(2).ColumnName = " الكميه"
            dg9.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs) Handles cbl.Leave

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh155()
    End Sub

    Private Sub dg6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg6.CellContentClick

    End Sub

    Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
        _Refresh1()


    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  CDate, Ctime, CBarcode, CModelName, C_Line_Shift, CSapUser FROM Heater_FinishGood_Production"
            sql += " where CBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("Heater_FinishGood_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("Heater_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("Heater_FinishGood_Production").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("Heater_FinishGood_Production").Columns(5).ColumnName = "رقم ساب المسئول"
            dg.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub dtpFROMDATE_ValueChanged(sender As Object, e As EventArgs) Handles dtpFROMDATE.ValueChanged

    End Sub

    Private Sub txtFATSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub

    Private Sub btnReport_Click_1(sender As Object, e As EventArgs) Handles btnReport.Click
        Try
            Dim frm As New frmReport
            Dim rpt As New rptDate

            rpt.SetDatabaseLogon("sa", "a-123456")

            ' rpt.RecordSelectionFormula = "{DailyP.fLCDPline}='2'"

            '  rpt.RecordSelectionFormula = "  {DESIGNER.fcurrent} ='" & btnPCode.Text & "'"
            'rpt.RecordSelectionFormula += " and  {yearlyp.fPDate}>= # " & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "#"
            'rpt.RecordSelectionFormula += " and {yearlyp.fPDate}<= # " & Format(dtpTODATE.Value, "yyyy-MM-dd") & "#"



            'frm.crv.ReportSource = rpt
            'frm.Show()
            'Me.Hide()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub dg_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnPCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles btnPCode.SelectedIndexChanged

    End Sub
End Class