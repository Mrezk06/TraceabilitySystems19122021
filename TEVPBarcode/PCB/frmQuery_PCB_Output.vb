Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class frmQuery_PCB_Output





    ' Public Class QueryFat1
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtPCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function _Refresh001() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count(fLCDSetID) FROM PCBOut "

            sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPtime>='" & txttotime.Text & "'"
            'sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("PCBOut")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh511() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count( fLCDBarcode) FROM PCBOut "


            sql += " where fLCDBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( fLCDBarcode) FROM PCBOut "
            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += "   and fPDate= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPtime>='" & txttotime.Text & "'"
            sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT fPDate, fPtime, fLCDBarcode, fLCDModelName,fLine_and_shift, fSap FROM PCBOut "
            sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPtime>='" & txttotime.Text & "'"
            'sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            ''sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " Date "
            ds.Tables("PCBOut").Columns(1).ColumnName = " time "
            ds.Tables("PCBOut").Columns(2).ColumnName = "  Barcode"
            ds.Tables("PCBOut").Columns(3).ColumnName = " Model Name"
            ds.Tables("PCBOut").Columns(4).ColumnName = "line"
            ds.Tables("PCBOut").Columns(5).ColumnName = "Sap"
            dg.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh11() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT fPDate, fPtime, fLCDBarcode, fLCDModelName,fLine_and_shift, fSap FROM PCBOut "
            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += "   and fPDate= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPtime>='" & txttotime.Text & "'"
            sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " Date "
            ds.Tables("PCBOut").Columns(1).ColumnName = " time "
            ds.Tables("PCBOut").Columns(2).ColumnName = "  Barcode"
            ds.Tables("PCBOut").Columns(3).ColumnName = " Model Name"
            ds.Tables("PCBOut").Columns(4).ColumnName = "line"
            ds.Tables("PCBOut").Columns(5).ColumnName = "Sap"
            dg.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName,fLine_and_shift, fSap FROM PCBOut "
            sql += " where fLCDBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " Date "
            ds.Tables("PCBOut").Columns(1).ColumnName = " time "
            ds.Tables("PCBOut").Columns(2).ColumnName = "  Barcode"
            ds.Tables("PCBOut").Columns(3).ColumnName = " Model Name"
            ds.Tables("PCBOut").Columns(4).ColumnName = "line"
            ds.Tables("PCBOut").Columns(5).ColumnName = "Sap"
            dg.DataSource = ds.Tables("PCBOut")
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
            sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName,fLine_and_shift, fSap FROM PCBOut "
            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += " and fLine_and_shift ='" & cbl.Text & "'"
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPtime>='" & txttotime.Text & "'"
            sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " Date "
            ds.Tables("PCBOut").Columns(1).ColumnName = " time "
            ds.Tables("PCBOut").Columns(2).ColumnName = "  Barcode"
            ds.Tables("PCBOut").Columns(3).ColumnName = " Model Name"
            ds.Tables("PCBOut").Columns(4).ColumnName = "line"
            ds.Tables("PCBOut").Columns(5).ColumnName = "Sap"
            '  ds.Tables("PCBIN").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("PCBOut")
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
    ' Timer1.Enabled = True
    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Timer1.Enabled = True
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM  LCDTVModelsPCB "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModelsPCB")
            btnPCode.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            btnPCode.DisplayMember = "fLCDModelName"
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
            sql += " SELECT count(fLCDSetID) FROM PCBOut "
            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += " and fLine_and_shift ='" & cbl.Text & "'"
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPtime>='" & txttotime.Text & "'"
            sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("PCBOut")
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


    Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        btnPCode.Text = dg9.Item(0, dg9.CurrentRow.Index).Value
    End Sub
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM PCBOut"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLine_and_shift ='" & cbl.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("PCBOut").Columns(1).ColumnName = " Qty"
            dg9.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub cbl_MouseLeave(sender As Object, e As EventArgs) Handles cbl.MouseLeave

    End Sub

    Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs) Handles cbl.Leave
        _Refresh155()
    End Sub
    Private Function _Refresh199() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot,fLine_and_shift "
            sql += " FROM PCBOut"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline ='" & cbl.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLine_and_shift "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " Model Name"
            ds.Tables("PCBOut").Columns(1).ColumnName = " Qty"
            ds.Tables("PCBOut").Columns(2).ColumnName = "line"
            dg9.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh199()
    End Sub
End Class

