Imports TEVPBarcode.sher
Public Class frmSHA_OutputQuery
    Private Sub Heater_Step_Three_Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        Try
            Dim sql As String = ""
            sql += "SELECT CModelName FROM SHA_Models"
            '  sql += " where fLine_Name ='EWH1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "SHA_Models")
            btnPCode.DataSource = ds.Tables(0)
            ' cmb_Pcode.ValueMember = "CSetID"
            '    btnPCode.ValueMember = "CSetIDAndLine"
            btnPCode.DisplayMember = "CModelName"
            btnPCode.Sorted = True
            _Refresh1()
        Catch ex As Exception
        End Try
        btnPCode.Text = ""
        btnPCode.Focus()
        btnPCode.SelectAll()

        Timer1.Enabled = True
        btnPCode.Text = ""
    End Sub
    Private Function _Refresh001() As Boolean
        Try


            Dim sql As String = ""

            'sql += " SELECT count(H_Heater_Code) FROM  barcode.dbo.Heater_registration_Two "
            'sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "Heater_registration_Two")
            'ds.Tables("Heater_registration_Two").Columns(0).ColumnName = " الكمية "
            'dg6.DataSource = ds.Tables("Heater_registration_Two")
            'Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  SHA_Output_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("SHA_Output_Production")
            dg6.AllowUserToAddRows = False
            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  SHA_Output_Production "
            sql += " where CBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("SHA_Output_Production")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""

            sql += " SELECT count(CBarcode) FROM  SHA_Output_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("SHA_Output_Production")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try




            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  SHA_Output_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("SHA_Output_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("SHA_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("SHA_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("SHA_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("SHA_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ds.Tables("SHA_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            dg.DataSource = ds.Tables("SHA_Output_Production")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  SHA_Output_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("SHA_Output_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("SHA_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("SHA_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("SHA_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("SHA_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ds.Tables("SHA_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            dg.DataSource = ds.Tables("SHA_Output_Production")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  SHA_Output_Production "
            sql += " where CBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("SHA_Output_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("SHA_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("SHA_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("SHA_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("SHA_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ds.Tables("SHA_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            dg.DataSource = ds.Tables("SHA_Output_Production")
            dg.AllowUserToAddRows = False
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
    '        sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM  barcode.dbo.DailyP "
    '        sql += " where fLCDModelName ='" & btnPCode.Text & "'"
    '        sql += " and fLCDPline ='" & cbl.Text & "'"
    '        sql += "   and fPDate= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and fPtime>='" & txttotime.Text & "'"
    '        sql += "   and fPtime<= '" & txtfromTime.Text & "'"
    '        'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "DailyP")
    '        ds.Tables("DailyP").Columns(0).ColumnName = " Date "
    '        ds.Tables("DailyP").Columns(1).ColumnName = " time "
    '        ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
    '        ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
    '        ds.Tables("DailyP").Columns(4).ColumnName = "line"
    '        ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
    '        ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
    '        dg.DataSource = ds.Tables("DailyP")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh119() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  SHA_Output_Production "
            sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += " and C_Line_Shift ='" & cbl.Text & "'"
            sql += " and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and Ctime>='" & txttotime.Text & "'"
            sql += "  and Ctime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("SHA_Output_Production").Columns(1).ColumnName = " الوقت "

            ds.Tables("SHA_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("SHA_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("SHA_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("SHA_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ' ds.Tables("TW_V_new").Columns(5).ColumnName = "اسم المسئول"
            ds.Tables("SHA_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            '  ds.Tables("Heater_registration_Two").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("SHA_Output_Production")
            dg.AllowUserToAddRows = False
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
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        'Try
        '    Dim sql As String = ""
        '    sql += " SELECT  Model_Name, Model_control FROM   Heater_ModelName "
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
            'Dim sql As String = ""
            'sql += " SELECT count(H_Heater_Code) FROM TW_V_new "
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  SHA_Output_Production "
            sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += " and C_Line_Shift ='" & cbl.Text & "'"
            sql += " and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and Ctime>='" & txttotime.Text & "'"
            sql += "  and Ctime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("SHA_Output_Production")
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

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSEARCH_Click_1(sender As Object, e As EventArgs) Handles btnSEARCH.Click

        If txttotime.Text = "" And txtfromTime.Text = "" Then
            _Refresh11()
            _Refresh011()
        Else

            _Refresh001()
            _Refresh111()
        End If



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

    Private Sub btnsearchModel_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        btnPCode.Text = dg9.Item(1, dg9.CurrentRow.Index).Value
    End Sub

    Private Function _Refresh155() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT C_Line_Shift,CModelName, count(CModelName) AS tot"
            sql += " FROM SHA_Output_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and H_Shift_Line ='" & cbl.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY CModelName,C_Line_Shift "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = "الخط"
            ds.Tables("SHA_Output_Production").Columns(1).ColumnName = "الموديل"
            ds.Tables("SHA_Output_Production").Columns(2).ColumnName = " الكمية"
            dg9.DataSource = ds.Tables("SHA_Output_Production")
            dg9.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs) Handles cbl.Leave
        _Refresh155()
    End Sub

    Private Sub btnPCode_Leave(sender As Object, e As EventArgs) Handles btnPCode.Leave

    End Sub

    Private Sub btnPCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles btnPCode.SelectedIndexChanged

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        '   btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
    End Sub

    Private Sub dg_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        '  btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
        ' txtS_Laber.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        'btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh155()
    End Sub

    Private Sub txtFATSERIAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFATSERIAL.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFATSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub

    Private Sub btnReport_Click_1(sender As Object, e As EventArgs) Handles btnReport.Click

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            '   OpenFileDialog1.OpenFile()

            '  Dim fileInfoText As String
            TextBox1.Text = SaveFileDialog1.FileName
            'Dim fi As New FileInfo(file)
            'Return fi.Directory.ToString
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


        For i = 1 To dg.RowCount - 1
            For j = 1 To dg.ColumnCount - 1
                For k As Integer = 1 To dg.Columns.Count
                    xlWorkSheet.Cells(1, k) = dg.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 1, j + 1) = dg(j, i).Value.ToString()
                Next
            Next
        Next
        'OpenFileDialog1.OpenFile()
        'TextBox1.Text = OpenFileDialog1.FileName 'Path of selected file  
        '   xlWorkSheet.SaveAs("E:\vbexcel.xlsx")
        xlWorkSheet.SaveAs(TextBox1.Text)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file in " + TextBox1.Text)
    End Sub
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
End Class