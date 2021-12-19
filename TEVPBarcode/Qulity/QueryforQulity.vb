Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports TEVPBarcode.sher

    Public Class QueryforQulity
    'Private Function _Refresh1() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT fPDate, fPtime, fLCDBarcode, fLCDPline, fNameL, qultyinorout,NotesQ FROM OutputQ"
    '        sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
    '        sql += " GROUP BY fLCDModelName "
    '        ' sql += " where fLCDBarcode='" & txtlcdbarcode.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "OutputQ")
    '        ds.Tables("OutputQ").Columns(0).ColumnName = "Data "
    '        ds.Tables("OutputQ").Columns(1).ColumnName = "Time"
    '        ds.Tables("OutputQ").Columns(2).ColumnName = "LCD Barcode"
    '        ds.Tables("OutputQ").Columns(3).ColumnName = "fLCDPline"
    '        ds.Tables("OutputQ").Columns(4).ColumnName = "sheeft_Num"
    '        ds.Tables("OutputQ").Columns(5).ColumnName = "qulty_in_or_out "
    '        ds.Tables("OutputQ").Columns(6).ColumnName = "NotesQ"
    '        DG1.DataSource = ds.Tables("OutputQ")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fPtime,fPDate, fLCDBarcode, fLCDSetID, fLCDModelName, fLCDPline, qultyinorout, fNameL,NotesQ FROM View_3"
            'sql += " FROM View_3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            '   sql += " GROUP BY fLCDModelName "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = " الوقت"
            ds.Tables("View_3").Columns(1).ColumnName = " التاريخ"
            ds.Tables("View_3").Columns(2).ColumnName = " الباركود"
            ds.Tables("View_3").Columns(3).ColumnName = " كود المنتج"
            ds.Tables("View_3").Columns(4).ColumnName = " الموديل"
            ds.Tables("View_3").Columns(5).ColumnName = " الخط على الباركود"
            ds.Tables("View_3").Columns(6).ColumnName = "حالة العمليه"
            ds.Tables("View_3").Columns(7).ColumnName = " الخط والورديه"
            ds.Tables("View_3").Columns(8).ColumnName = " وصف الملاحظه"
            DG1.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13() As Boolean
            Try
                Dim sql As String = ""
                sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
                sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
                Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_3")
            Return True
            Catch ex As Exception
            End Try
        End Function
        Private Sub frmQOutp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDModelName FROM   LCDTVModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")
            cmb_Pcode.DataSource = ds.Tables(0)

            cmb_Pcode.DisplayMember = "fLCDModelName"
            cmb_Pcode.Sorted = True
        Catch ex As Exception
        End Try
        cmb_Pcode.Text = ""
        End Sub
        Private Function _Refresh25() As Boolean
        
        Try
            Dim sql As String = ""
            sql += " SELECT fPtime,fPDate, fLCDBarcode, fLCDSetID, fLCDModelName, fLCDPline, qultyinorout, fNameL,NotesQ FROM View_3"
            'sql += " FROM View_3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fNameL='" & ComboBox1.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = " الوقت"
            ds.Tables("View_3").Columns(1).ColumnName = " التاريخ"
            ds.Tables("View_3").Columns(2).ColumnName = " الباركود"
            ds.Tables("View_3").Columns(3).ColumnName = " كود المنتج"
            ds.Tables("View_3").Columns(4).ColumnName = " الموديل"
            ds.Tables("View_3").Columns(5).ColumnName = " الخط على الباركود"
            ds.Tables("View_3").Columns(6).ColumnName = "حالة العمليه"
            ds.Tables("View_3").Columns(7).ColumnName = " الخط والورديه"
            ds.Tables("View_3").Columns(8).ColumnName = " وصف الملاحظه"
            DG1.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh2500() As Boolean

        Try
            Dim sql As String = ""
            sql += " SELECT fPtime,fPDate, fLCDBarcode, fLCDSetID, fLCDModelName, fLCDPline, qultyinorout, fNameL,NotesQ FROM View_3"
            'sql += " FROM View_3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and qultyinorout='" & txtstat.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = " الوقت"
            ds.Tables("View_3").Columns(1).ColumnName = " التاريخ"
            ds.Tables("View_3").Columns(2).ColumnName = " الباركود"
            ds.Tables("View_3").Columns(3).ColumnName = " كود المنتج"
            ds.Tables("View_3").Columns(4).ColumnName = " الموديل"
            ds.Tables("View_3").Columns(5).ColumnName = " الخط على الباركود"
            ds.Tables("View_3").Columns(6).ColumnName = "حالة العمليه"
            ds.Tables("View_3").Columns(7).ColumnName = " الخط والورديه"
            ds.Tables("View_3").Columns(8).ColumnName = " وصف الملاحظه"
            DG1.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
        Private Function _Refresh15() As Boolean
            Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fNameL='" & ComboBox1.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_3")
            Return True
            Catch ex As Exception
            End Try
    End Function
    Private Function _Refresh1500() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and qultyinorout='" & txtstat.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Scerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
        Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

        End Sub
    'Private Function _Refresh45() As Boolean
    '    Try
    '    Dim sql As String = ""
    '    sql += " SELECT  fLCDModelName,COUNT(fLCDModelName)  FROM View_3"
    '    sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
    '    sql += "and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
    '    sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
    '    '  sql += " and fLCDPline='" & ComboBox1.Text & "'"
    '    sql += " and fNameL='" & ComboBox1.Text & "'"
    '    sql += " GROUP BY fLCDModelName "
    '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '    Dim ds As New DataSet
    '    da.Fill(ds, "View_3")
    '    ds.Tables("View_3").Columns(0).ColumnName = " LCD_Model_Name"
    '    ds.Tables("View_3").Columns(1).ColumnName = " Qty"
    '    DG1.DataSource = ds.Tables("View_3")
    '    Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh44() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  COUNT (fLCDModelName)as qty  FROM View_3"
            sql += "WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += "and fLCDModelName='" & cmb_Pcode.Text & "'"
            'sql += "and fLCDPline='" & ComboBox1.Text & "'"
            sql += "and fNameL='" & ComboBox1.Text & "'"
            ' sql += "GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية "
            dg3.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    Close()
    'End Sub
        Private Function _Refresh405() As Boolean

        Try
            Dim sql As String = ""
            sql += " SELECT fPtime,fPDate, fLCDBarcode, fLCDSetID, fLCDModelName, fLCDPline, qultyinorout, fNameL FROM View_3"
            '  sql += " FROM View_3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fNameL='" & ComboBox1.Text & "'"

            ' sql += " GROUP BY fLCDModelName "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = " الوقت"
            ds.Tables("View_3").Columns(1).ColumnName = " التاريخ"
            ds.Tables("View_3").Columns(2).ColumnName = " الباركود"
            ds.Tables("View_3").Columns(3).ColumnName = " كود المنتج"
            ds.Tables("View_3").Columns(4).ColumnName = " الموديل"
            ds.Tables("View_3").Columns(5).ColumnName = " الخط على الباركود"
            ds.Tables("View_3").Columns(6).ColumnName = "حالة العمليه"
            ds.Tables("View_3").Columns(7).ColumnName = " الخط والورديه"


            'ds.Tables("View_3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
        End Function
        Private Function _Refresh4104() As Boolean
            Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (fLCDModelName) FROM  View_3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += " and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            '  sql += " and fNameL='" & ComboBox2.Text & "'"
            ' sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_3")
            Return True
            Catch ex As Exception
            End Try
        End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
    Private Function _Refresh4105() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDModelName,COUNT (fLCDModelName) FROM View_3"
            sql += " WHERE fLCDPline='" & ComboBox1.Text & "'"
            '   sql += " and fNameL='" & ComboBox2.Text & "'"
            ' sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("View_3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh404() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (fLCDModelName)  FROM View_3"
            sql += " WHERE fLCDPline='" & ComboBox1.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            ' sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
     
        If ComboBox1.Text = "" And cmb_Pcode.Text = "" And txtstat.Text = "" Then
            _Refresh13()
            _Refresh1()
        ElseIf txtstat.Text = "" Then
            _Refresh25()
            _Refresh15()
        ElseIf cmb_Pcode.Text = "" And ComboBox1.Text = "" Then
            _Refresh2500()
            _Refresh1500()
            'Else
            '    '_Refresh45()
            '    '_Refresh44()

        End If


    End Sub
        Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '_Refresh4104()
        '_Refresh4105()
        End Sub
        Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

        End Sub
        Private Function _Refresh315() As Boolean
            Try
            Dim sql As String = ""
            sql += " SELECT fPtime,fPDate, fLCDBarcode, fLCDSetID, fLCDModelName, fLCDPline, qultyinorout, fNameL,NotesQ FROM View_3"
            '  sql += " FROM View_3"
      
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " where fLCDBarcode='" & txtlcdbarcode.Text & "'"

            ' sql += " GROUP BY fLCDModelName "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = " الوقت"
            ds.Tables("View_3").Columns(1).ColumnName = " التاريخ"
            ds.Tables("View_3").Columns(2).ColumnName = " الباركود"
            ds.Tables("View_3").Columns(3).ColumnName = " كود المنتج"
            ds.Tables("View_3").Columns(4).ColumnName = " الموديل"
            ds.Tables("View_3").Columns(5).ColumnName = " الخط على الباركود"
            ds.Tables("View_3").Columns(6).ColumnName = "حالة العمليه"
            ds.Tables("View_3").Columns(7).ColumnName = " الخط والورديه"
            ds.Tables("View_3").Columns(8).ColumnName = " وصف الملاحظه"
            DG1.DataSource = ds.Tables("View_3")
            Return True
            Catch ex As Exception
            End Try
        End Function
        Private Sub btnModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModel.Click
            _Refresh315()
        End Sub

        Private Sub cmb_Pcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Pcode.SelectedIndexChanged

        End Sub

        Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
            Try
            'Dim frm As New frmReport
            'Dim rpt As New FINISHGOOD
            'rpt.SetDatabaseLogon("sa", "201015")
            'rpt.RecordSelectionFormula = "{View_2.fLCDPline}='" & ComboBox2.Text & "'"
            ''rpt.RecordSelectionFormula += " and {View_2.fPDate}>=#" & Format(dtbfrom.Value, "yyyy-MM-dd") & "#"
            ''rpt.RecordSelectionFormula += " and {View_2.fPDate}<=#" & Format(dtbto.Value, "yyyy-MM-dd") & "#"
            'frm.crv.ReportSource = rpt
            'frm.Show()
            'Me.Hide()

            'Dim frm As New frmReport
            'Dim cryRpt As New ReportDocument
            'Dim crtableLogoninfos As New TableLogOnInfos
            'Dim crtableLogoninfo As New TableLogOnInfo
            'Dim crConnectionInfo As New ConnectionInfo
            'Dim CrTables As Tables
            'Dim CrTable As Table
            'cryRpt.Load("D:\Projects\desktop\Heater App\TEVPBarcode v.2\TEVPBarcode\Finish Good\output.rpt") 'مسار التقرير اللي انت عاوز تعرضه
            'With crConnectionInfo
            '    .ServerName = "10.12.112.233" 'اكتب اسم السيكول هنا
            '    .DatabaseName = "barcode" 'اسم قاعدة البيانات
            '    .UserID = "sa"
            '    .Password = "a-123456"
            'End With

            'CrTables = cryRpt.Database.Tables
            'For Each CrTable In CrTables
            '    crtableLogoninfo = CrTable.LogOnInfo
            '    crtableLogoninfo.ConnectionInfo = crConnectionInfo
            '    CrTable.ApplyLogOnInfo(crtableLogoninfo)
            'Next
            '' cryRpt.RecordSelectionFormula = "{ActualKpi.fManagement}='Procurment'"
            'frm.crv.ReportSource = cryRpt

            'frm.crv.Refresh()
            'frm.Show()
        Catch ex As Exception

            End Try
        End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DG1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG1.CellContentClick
        cmb_Pcode.Text = DG1.Item(4, DG1.CurrentRow.Index).Value
    End Sub
End Class