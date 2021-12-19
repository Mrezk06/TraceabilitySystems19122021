Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Imports Microsoft.Office.Interop.Excel.ApplicationClass
Public Class RefrigeratorOutPutQuery


    Private Function _Refresh001() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_Barcode) FROM Refrigerator_OutputView "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_OutputView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM Refrigerator_OutputView "
            sql += " where R_Barcode ='" & txtFATSERIAL.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_OutputView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_Barcode) FROM Refrigerator_OutputView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " and R_Date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Time>='" & txttotime.Text & "'"
            sql += " and R_Time <= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_OutputView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT R_Date, R_Time, R_Barcode, R_ModelName, R_ProductionType, R_ColorName, R_ModelControl,R_FactoryCode,R_EanCode,R_SapUser, R_Line FROM  Refrigerator_OutputView "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            'sql += "   and fPtime>='" & txttotime.Text & "'"
            'sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            ''sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_OutputView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_OutputView").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_OutputView").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_OutputView").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_OutputView").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_OutputView").Columns(6).ColumnName = "كود الموديل"

            'ds.Tables("Refrigerator_OutputView").Columns(7).ColumnName = "الباب الصغير "
            'ds.Tables("Refrigerator_OutputView").Columns(8).ColumnName = "الباب الكبير"
            ds.Tables("Refrigerator_OutputView").Columns(7).ColumnName = "كود المصنع"

            ds.Tables("Refrigerator_OutputView").Columns(9).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_OutputView").Columns(10).ColumnName = "الوردية"

            dg.DataSource = ds.Tables("Refrigerator_OutputView")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh11() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT R_Date, R_Time, R_Barcode, R_ModelName, R_ProductionType, R_ColorName, R_ModelControl, R_FactoryCode,R_EanCode,R_SapUser, R_Line FROM Refrigerator_OutputView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_OutputView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_OutputView").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_OutputView").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_OutputView").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_OutputView").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_OutputView").Columns(6).ColumnName = "كود الموديل"

            ds.Tables("Refrigerator_OutputView").Columns(7).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_OutputView").Columns(8).ColumnName = "استيكر الطاقة"
            ds.Tables("Refrigerator_OutputView").Columns(9).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_OutputView").Columns(10).ColumnName = "الوردية"

            dg.DataSource = ds.Tables("Refrigerator_OutputView")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            '    Dim sql As String = ""
            '    sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty,fShift FROM  barcode.dbo.DailyP "
            '    sql += " where fLCDBarcode ='" & txtFATSERIAL.Text & "'"
            '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            '    Dim ds As New DataSet
            '    da.Fill(ds, "DailyP")
            '    ds.Tables("DailyP").Columns(0).ColumnName = " Date "
            '    ds.Tables("DailyP").Columns(1).ColumnName = " time "
            '    ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            '    ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            '    ds.Tables("DailyP").Columns(4).ColumnName = "line Barcode"
            '    ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            '    ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            '    ds.Tables("DailyP").Columns(7).ColumnName = "Line"
            'dg.DataSource = ds.Tables("DailyP")



            Dim sql As String = ""

            sql += " SELECT R_Date, R_Time, R_Barcode, R_ModelName, R_ProductionType, R_ColorName, R_ModelControl,R_FactoryCode,R_EanCode,R_SapUser, R_Line FROM Refrigerator_OutputView "
            sql += " where R_Barcode ='" & txtFATSERIAL.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_OutputView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_OutputView").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_OutputView").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_OutputView").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_OutputView").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_OutputView").Columns(6).ColumnName = "كود الموديل"
            ds.Tables("Refrigerator_OutputView").Columns(7).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_OutputView").Columns(8).ColumnName = "استيكر الطاقة"
            ds.Tables("Refrigerator_OutputView").Columns(9).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_OutputView").Columns(10).ColumnName = "الوردية"
            dg.DataSource = ds.Tables("Refrigerator_OutputView")
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
    Private Function _Refresh119() As Boolean
        Try
            '    Dim sql As String = ""
            '    sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM  barcode.dbo.DailyP "
            '    sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            '    sql += " and fLineandsh ='" & cbl.Text & "'"
            '    sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            '    sql += "   and fPDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            '    sql += "   and fPtime>='" & txttotime.Text & "'"
            '    sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            '    'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            '    Dim ds As New DataSet
            '    da.Fill(ds, "DailyP")
            '    ds.Tables("DailyP").Columns(0).ColumnName = " Date "
            '    ds.Tables("DailyP").Columns(1).ColumnName = " time "
            '    ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            '    ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            '    ds.Tables("DailyP").Columns(4).ColumnName = "line"
            '    ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            '    ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            'dg.DataSource = ds.Tables("DailyP")



            Dim sql As String = ""

            sql += " SELECT R_Date, R_Time, R_Barcode, R_ModelName, R_ProductionType, R_ColorName, R_ModelControl,R_FactoryCode,R_EanCode,R_SapUser, R_Line FROM Refrigerator_OutputView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            '            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += " and R_Line ='" & cbl.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_OutputView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_OutputView").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_OutputView").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_OutputView").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_OutputView").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_OutputView").Columns(6).ColumnName = "كود الموديل"
            ds.Tables("Refrigerator_OutputView").Columns(7).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_OutputView").Columns(8).ColumnName = "استيكر الطاقة"
            ds.Tables("Refrigerator_OutputView").Columns(9).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_OutputView").Columns(10).ColumnName = "الوردية"
            dg.DataSource = ds.Tables("Refrigerator_OutputView")
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
            sql += " SELECT  R_ModelControl, R_ModelName FROM   Refrigerator_Models "
            sql += " where R_FactoryCode ='B'"
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
        btnPCode.Text = ""
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Function _Refresh0119() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM Refrigerator_OutputView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_Line ='" & cbl.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "الكمية"
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("Refrigerator_OutputView")
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
            sql += " SELECT R_ModelName, count(R_ModelName) AS tot"
            sql += " FROM Refrigerator_OutputView"
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line ='" & cbl.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            sql += " GROUP BY R_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_OutputView").Columns(1).ColumnName = "الكمية"
            dg9.DataSource = ds.Tables("Refrigerator_OutputView")
            dg9.AllowUserToAddRows = False
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
            sql += "SELECT R_ModelName, count(R_ModelName) AS tot,R_Line "
            sql += " FROM Refrigerator_OutputView"
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_FactoryCode='Refrigerator_B'"
            sql += " GROUP BY R_ModelName,R_Line "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_OutputView").Columns(1).ColumnName = "الكمية"
            ds.Tables("Refrigerator_OutputView").Columns(2).ColumnName = "الوردية"
            dg9.DataSource = ds.Tables("Refrigerator_OutputView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh199()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

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


        For i = 1 To dg.RowCount - 2
            For j = 1 To dg.ColumnCount - 1
                For k As Integer = 1 To dg.Columns.Count
                    xlWorkSheet.Cells(1, k) = dg.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dg(j, i).Value.ToString()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh11NG()
        _Refresh0119NG()
    End Sub

    Private Function _Refresh11NG() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_Date, R_Time, R_Barcode,R_ModelName, R_ProductionType, R_ColorName, R_ModelControl,R_FactoryCode,R_EanCode,R_SapUser, R_Line,R_Carton,R_STATUS  FROM  Refrigerator_OutputViewNG "
            ' sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputViewNG")
            ds.Tables("Refrigerator_OutputViewNG").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_OutputViewNG").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_OutputViewNG").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_OutputViewNG").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_OutputViewNG").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_OutputViewNG").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_OutputViewNG").Columns(6).ColumnName = "كود الموديل"
            ds.Tables("Refrigerator_OutputViewNG").Columns(7).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_OutputViewNG").Columns(8).ColumnName = "استيكر الطاقة"
            ds.Tables("Refrigerator_OutputViewNG").Columns(9).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_OutputViewNG").Columns(10).ColumnName = "الوردية"
            ds.Tables("Refrigerator_OutputViewNG").Columns(11).ColumnName = "الكرتونه"
            ds.Tables("Refrigerator_OutputViewNG").Columns(12).ColumnName = "سبب الخطاء"
            dg.DataSource = ds.Tables("Refrigerator_OutputViewNG")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh0119NG() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM  Refrigerator_OutputViewNG "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"

            sql += " and R_FactoryCode='Refrigerator_B'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputViewNG")
            ds.Tables("Refrigerator_OutputViewNG").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_OutputViewNG")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
End Class


