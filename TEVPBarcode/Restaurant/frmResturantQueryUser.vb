Imports TEVPBarcode.sher
Imports System.IO.Directory
'References that we need
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
'Imports System.IO.Directory
'Imports Microsoft.Office.Interop.Excel 'Before you add this reference to your project,
' you need to install Microsoft Office and find last version of this file.
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Microsoft.Reporting.WinForms

Public Class frmResturantQueryUser
    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub
    Private Sub frmResturantQueryUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'barcodeDataSet.Resturantalldata' table. You can move, or remove it, as needed.
        'Me.ResturantalldataTableAdapter.Fill(Me.barcodeDataSet1.Resturantalldata)

        'Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer1.RefreshReport()
    End Sub

    'Private Function _Refr2() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT RDateDay, RMMName, RMPrice, RSap, RName, Expr1 FROM Resturantalldata"
    '        sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"

    '        sql += " and RSap=" & txtuser.Text & ""
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Resturantalldata")
    '        ds.Tables("Resturantalldata").Columns(0).ColumnName = "Date "
    '        ds.Tables("Resturantalldata").Columns(1).ColumnName = "The name of the meal"
    '        ds.Tables("Resturantalldata").Columns(2).ColumnName = "price "
    '        ds.Tables("Resturantalldata").Columns(3).ColumnName = "Sap Num"
    '        ds.Tables("Resturantalldata").Columns(4).ColumnName = "The name of the restaurant"
    '        ds.Tables("Resturantalldata").Columns(5).ColumnName = "Name"

    '        dg9.DataSource = ds.Tables("Resturantalldata")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refr00() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT sum(RMPrice) FROM Resturantalldata"
            sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and RSap=" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Resturantalldata")
            ds.Tables("Resturantalldata").Columns(0).ColumnName = "Total price"
            dgff.DataSource = ds.Tables("Resturantalldata")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr000() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT sum(RMPrice)/count(RDateDay) FROM Resturantalldata"
            sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and RSap=" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Resturantalldata")
            ds.Tables("Resturantalldata").Columns(0).ColumnName = "avg price"
            gf.DataSource = ds.Tables("Resturantalldata")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim dataAdapter As New SqlClient.SqlDataAdapter()
        'Dim dataSet As New DataSet
        'Dim command As New SqlClient.SqlCommand
        'Dim datatableMain As New System.Data.DataTable()
        'Dim connection As New SqlClient.SqlConnection

        ''Assign your connection string to connection object
        'connection.ConnectionString = "Data Source=10.12.112.233;Initial Catalog=follow_up_theStores;Persist Security Info=True;User ID=sa;Password=a-123456"
        'command.Connection = connection
        'command.CommandType = CommandType.Text
        ''You can use any command select
        'command.CommandText = "SELECT RDateDay, RMMName, RMPrice, RSap, RName, Expr1 [barcode].[dbo].[Resturantalldata]"
        ''command.CommandText = "SELECT C_date,C_time,C_Material_code,C_Material_Name,C_QTY ,C_Unit,C_bell_code,C_User FROM [follow_up_theStores].[dbo].[salahnew2] where C_bell_code ='" & txtinvnum.Text & "'"
        'dataAdapter.SelectCommand = command
        'Dim f As FolderBrowserDialog = New FolderBrowserDialog
        'Try
        '    If f.ShowDialog() = DialogResult.OK Then
        '        'This section help you if your language is not English.
        '        System.Threading.Thread.CurrentThread.CurrentCulture =
        '        System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        '        Dim oExcel As Excel.Application
        '        Dim oBook As Excel.Workbook
        '        Dim oSheet As Excel.Worksheet
        '        oExcel = CreateObject("Excel.Application")
        '        oBook = oExcel.Workbooks.Add(Type.Missing)
        '        oSheet = oBook.Worksheets(1)

        '        Dim dc As System.Data.DataColumn
        '        Dim dr As System.Data.DataRow
        '        Dim colIndex As Integer = 0
        '        Dim rowIndex As Integer = 0

        '        'Fill data to datatable
        '        connection.Open()
        '        dataAdapter.Fill(datatableMain)
        '        connection.Close()


        '        'Export the Columns to excel file
        '        For Each dc In datatableMain.Columns
        '            colIndex = colIndex + 1
        '            oSheet.Cells(1, colIndex) = dc.ColumnName
        '        Next

        '        'Export the rows to excel file
        '        For Each dr In datatableMain.Rows
        '            rowIndex = rowIndex + 1
        '            colIndex = 0
        '            For Each dc In datatableMain.Columns
        '                colIndex = colIndex + 1
        '                oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
        '            Next
        '        Next

        '        'Set final path
        '        Dim fileName As String = "\ExportedAuthors" + ".xls"
        '        Dim finalPath = f.SelectedPath + fileName
        '        txtPath.Text = finalPath
        '        oSheet.Columns.AutoFit()
        '        'Save file in final path
        '        oBook.SaveAs(finalPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
        '        Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
        '        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

        '        'Release the objects
        '        ReleaseObject(oSheet)
        '        oBook.Close(False, Type.Missing, Type.Missing)
        '        ReleaseObject(oBook)
        '        oExcel.Quit()
        '        ReleaseObject(oExcel)
        '        'Some time Office application does not quit after automation: 
        '        'so i am calling GC.Collect method.
        '        GC.Collect()

        '        MessageBox.Show("Export done successfully!")

        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        'End Try

    End Sub


    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub
    Private Function _Refr2() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  RMMName, COUNT(RMMName) AS QTY FROM Restaurant_request_User"
            sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " GROUP BY RMFID, RMMID, RMMName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_request_User")
            ds.Tables("Restaurant_request_User").Columns(0).ColumnName = "اسم الوجبه  "
            ds.Tables("Restaurant_request_User").Columns(1).ColumnName = "الكمية"
            dgb.DataSource = ds.Tables("Restaurant_request_User")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr21() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT   COUNT(RMMName) AS QTY FROM Restaurant_request_User"
            sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            '  sql += " GROUP BY RMFID, RMMID, RMMName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_request_User")
            '   ds.Tables("Restaurant_request_User").Columns(0).ColumnName = "اسم الوجبه  "
            ds.Tables("Restaurant_request_User").Columns(0).ColumnName = "الكمية"
            dgx.DataSource = ds.Tables("Restaurant_request_User")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refr21()
        _Refr2()

        Try
            Dim dt As New DataTable
            cn.Open()
            Using sql As New SqlCommand("SELECT RDateDay, RMMName, RMPrice, RSap, RName, Expr1 FROM Resturantalldata where  RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'", cn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = sql
                da.Fill(dt)
            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "E:\rezk\Debug\frmrptUserquq.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            _Refr0001()
            _Refr001()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try
            Dim dt As New DataTable
            cn.Open()
            '       Using sql As New SqlCommand("SELECT RDateDay, RMMName, RMPrice, RSap, RName, Expr1 FROM Resturantalldata  WHERE RDateDay between '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "', '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'
            'sql+= (and RSap='" & txtuser.Text & "'", cn))

            Using sql As New SqlCommand("SELECT RDateDay, RMMName, RMPrice, RSap, RName, Expr1 FROM Resturantalldata where RSap='" & txtuser.Text & "'and RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'", cn)
                'sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
                'sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
                'sql += " and RSap='" & txtuser.Text & "'", cn)
                Dim da As New SqlDataAdapter
                da.SelectCommand = sql

                da.Fill(dt)

            End Using
            With Me.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "E:\rezk\Debug\frmrptUserquq.rdlc"
                .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            End With
            Me.ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()
            _Refr000()
            _Refr00()
        Catch ex As Exception
        End Try
    End Sub
    Private Function _Refr001() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT sum(RMPrice) FROM Resturantalldata"
            sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            ' sql += " and RSap=" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Resturantalldata")
            ds.Tables("Resturantalldata").Columns(0).ColumnName = "Total price"
            dgff.DataSource = ds.Tables("Resturantalldata")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr0001() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT sum(RMPrice)/count(RDateDay) FROM Resturantalldata"
            sql += "   WHERE RDateDay>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and RDateDay<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            '      sql += " and RSap=" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Resturantalldata")
            ds.Tables("Resturantalldata").Columns(0).ColumnName = "avg price"
            gf.DataSource = ds.Tables("Resturantalldata")
            Return True
        Catch ex As Exception
        End Try
    End Function
End Class