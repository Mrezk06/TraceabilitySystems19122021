Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class History

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub txtPCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub
    Private Function _Refresh001() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count( fLCDSN) FROM yearlyp "



            sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"


            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")

            ds.Tables("yearlyp").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh511() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count( fLCDSN) FROM yearlyp "


            sql += " where fLCDBarcode ='" & txtFATSERIAL.Text & "'"
            


            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")

            ds.Tables("yearlyp").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh011() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count( fLCDSN) FROM yearlyp "


            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"


            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")

            ds.Tables("yearlyp").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh111() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM yearlyp "



            sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"


            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")

            ds.Tables("yearlyp").Columns(0).ColumnName = " Date "
            ds.Tables("yearlyp").Columns(1).ColumnName = " time "
            ds.Tables("yearlyp").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("yearlyp").Columns(3).ColumnName = "LCD Model Name"
            ds.Tables("yearlyp").Columns(4).ColumnName = "line"
            ds.Tables("yearlyp").Columns(5).ColumnName = "LCD SN"
            ds.Tables("yearlyp").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh11() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM yearlyp "

            sql += " where fLCDModelName ='" & btnPCode.Text & "'"

            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"


            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")


            ds.Tables("yearlyp").Columns(0).ColumnName = " Date "
            ds.Tables("yearlyp").Columns(1).ColumnName = " time "
            ds.Tables("yearlyp").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("yearlyp").Columns(3).ColumnName = "LCD Model Name"
            ds.Tables("yearlyp").Columns(4).ColumnName = "line"
            ds.Tables("yearlyp").Columns(5).ColumnName = "LCD SN"
            ds.Tables("yearlyp").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql As String = ""

            sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM yearlyp "

            sql += " where fLCDBarcode ='" & txtFATSERIAL.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")

            ds.Tables("yearlyp").Columns(0).ColumnName = " Date "
            ds.Tables("yearlyp").Columns(1).ColumnName = " time "
            ds.Tables("yearlyp").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("yearlyp").Columns(3).ColumnName = "LCD Model Name"
            ds.Tables("yearlyp").Columns(4).ColumnName = "line"
            ds.Tables("yearlyp").Columns(5).ColumnName = "LCD SN"
            ds.Tables("yearlyp").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnsearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch1.Click
        _Refresh1()
        _Refresh511()

    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        _Refresh111()
        _Refresh001()

    End Sub

    Private Sub btnsearchModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchModel.Click
        _Refresh11()
        _Refresh011()
    End Sub
    Private Function _Refresh119() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM  yearlyp "

            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += " and fLCDPline ='" & cbl.Text & "'"
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"


            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")


            ds.Tables("yearlyp").Columns(0).ColumnName = " Date "
            ds.Tables("yearlyp").Columns(1).ColumnName = " time "
            ds.Tables("yearlyp").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("yearlyp").Columns(3).ColumnName = "LCD Model Name"
            ds.Tables("yearlyp").Columns(4).ColumnName = "line"
            ds.Tables("yearlyp").Columns(5).ColumnName = "LCD SN"
            ds.Tables("yearlyp").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
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
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM   LCDTVModels "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")

            btnPCode.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            btnPCode.DisplayMember = "fLCDModelName"
            btnPCode.Sorted = True

            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
    Private Function _Refresh0119() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count( fLCDSN) FROM  yearlyp "


            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += " and fLCDPline ='" & cbl.Text & "'"
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"


            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")

            ds.Tables("yearlyp").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _Refresh0119()
        _Refresh119()
    End Sub
End Class

