
Imports System.IO
Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Imports Microsoft.VisualBasic.FileIO
Imports System.Data
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Configuration

Imports System.Text
'Imports System.

Imports System.Globalization

Public Class aquTestTest1

    Dim englishinpot As InputLanguage

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Try
            'Dim path As String = ""
            'Dim path1 As String = "C:\Users\mohamed.rezk\Desktop\Newfolder\Employee.txt"
            'OpenFileDialog1.ShowDialog()
            ''tbFile.Text$ = OpenFileDialog1.FileName
            'path = OpenFileDialog1.FileName
            'path1 = SaveFileDialog1.FileName
            '     IO.File.Copy(tbFile.Text$, TextBox1.Text$)


        Catch ex As Exception

        End Try

        'Dim headers = (From header As DataGridViewColumn In dg2.Columns.Cast(Of DataGridViewColumn)() Select header.HeaderText).ToArray
        'Dim rows = From row As DataGridViewRow In dg2.Rows.Cast(Of DataGridViewRow)() Where Not row.IsNewRow Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        'Dim str As String = ""
        'Using sw As New IO.StreamWriter("C:\Users\mohamed.rezk\Desktop\MT.csv")
        '    sw.WriteLine(String.Join(",", headers))
        '    'sw.WriteLine(String.Join(","))
        '    For Each r In rows
        '        sw.WriteLine(String.Join(",", r))
        '    Next
        '    sw.Close()
        'End Using

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ''Dim m_strConnection As String = "server=Excel-PC\SQLEXPRESS;Initial Catalog=Northwind;Trusted_Connection=True;"

        ''Catch ex As Exception
        ''    MessageBox.Show(ex.ToString())
        ''End Try

        ''Dim objDataset1 As DataSet()
        ''Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Dim da As OdbcDataAdapter
        'Dim OpenFile As New System.Windows.Forms.OpenFileDialog ' Does something w/ the OpenFileDialog
        'Dim strFullPath As String, strFileName As String
        'Dim tbFile As New TextBox
        '' Sets some OpenFileDialog box options
        'OpenFile.Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*" ' Shows only .csv files
        'OpenFile.Title = "Browse to file:" ' Title at the top of the dialog box

        'If OpenFile.ShowDialog() = DialogResult.OK Then ' Makes the open file dialog box show up
        '    strFullPath = OpenFile.FileName ' Assigns variable
        '    strFileName = Path.GetFileName(strFullPath)

        '    If OpenFile.FileNames.Length > 0 Then ' Checks to see if they've picked a file

        '        tbFile.Text = strFullPath ' Puts the filename in the textbox

        '        ' The connection string for reading into data connection form
        '        Dim connStr As String
        '        connStr = "Driver={Microsoft Text Driver (*.txt; *.csv)}; Dbq=" + Path.GetDirectoryName(strFullPath) + "; Extensions=csv,txt "

        '        ' Sets up the data set and gets stuff from .csv file
        '        Dim Conn As New OdbcConnection(connStr)
        '        Dim ds As DataSet
        '        Dim DataAdapter As New OdbcDataAdapter("SELECT * FROM [" + strFileName + "]", Conn)
        '        ds = New DataSet

        '        Try
        '            DataAdapter.Fill(ds, strFileName) ' Fills data grid..
        '            dg2.DataSource = ds.Tables(strFileName) ' ..according to data source

        '            ' Catch and display database errors
        '        Catch ex As OdbcException
        '            Dim odbcError As OdbcError
        '            For Each odbcError In ex.Errors
        '                MessageBox.Show(ex.Message)
        '            Next
        '        End Try

        '        ' Cleanup
        '        OpenFile.Dispose()
        '        Conn.Dispose()
        '        DataAdapter.Dispose()
        '        ds.Dispose()

        '    End If
        'End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        ''Dim cnn As SqlConnection
        ''Dim connectionString As String
        'Dim sql As String

        ''connectionString = "data source=Excel-PC\SQLEXPRESS;" & _
        ''"initial catalog=NORTHWIND;Trusted_Connection=True"
        ''cnn = New SqlConnection()
        'cn.Open()
        'sql = "SELECT * FROM Employee"
        'Dim dscmd As New SqlDataAdapter(sql, cn)
        'Dim ds As New DataSet
        'dscmd.Fill(ds)
        'dg2.DataSource = ds.Tables(0)

        'cn.Close()

    End Sub

    'Private Sub ProductsDataGridView_CellFormatting(ByVal sender As Object,
    '                                            ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) _
    '                                            Handles dg2.CellFormatting

    '    If e.ColumnIndex = dg2.Columns(3).Index _
    '        AndAlso e.Value IsNot Nothing Then
    '        '
    '        If CInt(e.Value) < 10 Then
    '            e.CellStyle.BackColor = Color.OrangeRed
    '            e.CellStyle.ForeColor = Color.LightGoldenrodYellow
    '        End If
    '        '
    '    End If
    '    '
    'End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try

            Dim tblReadCSV As New DataTable()
            tblReadCSV.Columns.Add("P1")
            tblReadCSV.Columns.Add("P2")
            tblReadCSV.Columns.Add("P3")
            tblReadCSV.Columns.Add("P4")
            tblReadCSV.Columns.Add("P5")
            tblReadCSV.Columns.Add("P6")
            tblReadCSV.Columns.Add("P7")
            tblReadCSV.Columns.Add("P8")
            tblReadCSV.Columns.Add("P9")
            tblReadCSV.Columns.Add("P10")
            tblReadCSV.Columns.Add("P11")
            tblReadCSV.Columns.Add("P12")
            tblReadCSV.Columns.Add("P13")
            tblReadCSV.Columns.Add("P14")
            tblReadCSV.Columns.Add("P15")
            tblReadCSV.Columns.Add("P16")
            tblReadCSV.Columns.Add("P17")
            tblReadCSV.Columns.Add("P18")
            tblReadCSV.Columns.Add("P19")
            tblReadCSV.Columns.Add("P20")
            tblReadCSV.Columns.Add("P21")
            tblReadCSV.Columns.Add("P22")
            tblReadCSV.Columns.Add("P23")
            tblReadCSV.Columns.Add("P24")
            tblReadCSV.Columns.Add("P25")
            tblReadCSV.Columns.Add("P26")
            tblReadCSV.Columns.Add("P27")
            tblReadCSV.Columns.Add("P28")
            tblReadCSV.Columns.Add("P29")
            tblReadCSV.Columns.Add("P30")
            tblReadCSV.Columns.Add("P31")
            tblReadCSV.Columns.Add("P32")
            tblReadCSV.Columns.Add("P33")
            tblReadCSV.Columns.Add("P34")
            tblReadCSV.Columns.Add("P35")
            tblReadCSV.Columns.Add("P36")

            tblReadCSV.Columns.Add("P37")
            tblReadCSV.Columns.Add("P38")
            tblReadCSV.Columns.Add("P39")
            tblReadCSV.Columns.Add("P40")
            tblReadCSV.Columns.Add("P41")
            tblReadCSV.Columns.Add("P42")
            tblReadCSV.Columns.Add("P43")
            tblReadCSV.Columns.Add("P44")
            tblReadCSV.Columns.Add("P45")
            tblReadCSV.Columns.Add("P46")
            tblReadCSV.Columns.Add("P47")
            tblReadCSV.Columns.Add("P48")
            tblReadCSV.Columns.Add("P49")
            tblReadCSV.Columns.Add("P50")
            tblReadCSV.Columns.Add("P51")
            tblReadCSV.Columns.Add("P52")
            tblReadCSV.Columns.Add("P53")
            tblReadCSV.Columns.Add("P54")
            tblReadCSV.Columns.Add("P55")
            tblReadCSV.Columns.Add("P56")
            tblReadCSV.Columns.Add("P57")
            tblReadCSV.Columns.Add("P58")
            tblReadCSV.Columns.Add("P59")
            tblReadCSV.Columns.Add("P60")
            tblReadCSV.Columns.Add("P61")
            tblReadCSV.Columns.Add("P62")
            tblReadCSV.Columns.Add("P63")

            tblReadCSV.Columns.Add("P64")
            tblReadCSV.Columns.Add("P65")
            tblReadCSV.Columns.Add("P66")
            tblReadCSV.Columns.Add("P67")
            tblReadCSV.Columns.Add("P68")
            tblReadCSV.Columns.Add("P69")
            tblReadCSV.Columns.Add("P70")
            tblReadCSV.Columns.Add("P71")
            tblReadCSV.Columns.Add("P72")
            tblReadCSV.Columns.Add("P73")
            tblReadCSV.Columns.Add("P74")
            'tblReadCSV.Columns.Add("P75")
            'tblReadCSV.Columns.Add("P76")
            'tblReadCSV.Columns.Add("P77")
            'tblReadCSV.Columns.Add("P78")
            'tblReadCSV.Columns.Add("P79")
            'tblReadCSV.Columns.Add("P80")
            'tblReadCSV.Columns.Add("P81")
            'tblReadCSV.Columns.Add("P82")
            'tblReadCSV.Columns.Add("P83")
            'tblReadCSV.Columns.Add("P84")
            'tblReadCSV.Columns.Add("P85")
            'tblReadCSV.Columns.Add("P86")
            'tblReadCSV.Columns.Add("P87")
            'tblReadCSV.Columns.Add("P34")
            'tblReadCSV.Columns.Add("P35")
            'tblReadCSV.Columns.Add("P36")
            Dim csvParser As New TextFieldParser("E:\Triceability system\ateq\UpLoad.txt")
            csvParser.Delimiters = New String() {","}
            csvParser.TrimWhiteSpace = True
            csvParser.ReadLine()
            While Not (csvParser.EndOfData = True)
                tblReadCSV.Rows.Add(csvParser.ReadFields())
            End While
            'Dim con As New SqlConnection("Server=Excel-PC\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;")
            Dim strSql As String = "Insert into C_Atc_3(P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20, P21, P22, P23, P24, P25, P26, P27, P28, P29, P30, P31, P32, P33, P34, P35, P36, P37, P38, P39, P40, P41, "
            strSql += "   P42, P43, P44, P45, P46, P47, P48, P49, P50, P51, P52, P53, P54, P55, P56, P57, P58, P59, P60, P61, P62, P63, P64, P65, P66, P67, P68, P69, P70, P71, P72, P73, P74) "
            strSql += "values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17,@P18,@P19,@P20,@P21,@P22,@P23,@P24,@P25,@P26,@P27,@P28,@P29,@P30,@P31,@P32,@P33,@P34,@P35,@P36,@P37,@P38,@P39,@P40,@P41, "
            strSql += "@P42,@P43,@P44,@P45,@P46,@P47,@P48,@P49,@P50,@P51,@P52,@P53,@P54,@P55,@P56,@P57,@P58,@P59,@P60,@P61,@P62,@P63,@P64,@P65,@P66,@P67,@P68,@P69,@P70,@P71,@P72,@P73,'A1')"

            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            cmd.Connection = cn

            cmd.Parameters.Add("@P1", SqlDbType.NVarChar, 50, "P1")
            cmd.Parameters.Add("@P2", SqlDbType.NVarChar, 50, "P2")
            cmd.Parameters.Add("@P3", SqlDbType.NVarChar, 50, "P3")
            cmd.Parameters.Add("@P4", SqlDbType.NVarChar, 50, "P4")
            cmd.Parameters.Add("@P5", SqlDbType.NVarChar, 50, "P5")
            cmd.Parameters.Add("@P6", SqlDbType.NVarChar, 50, "P6")
            cmd.Parameters.Add("@P7", SqlDbType.NVarChar, 50, "P7")
            cmd.Parameters.Add("@P8", SqlDbType.NVarChar, 50, "P8")
            cmd.Parameters.Add("@P9", SqlDbType.NVarChar, 50, "P9")
            cmd.Parameters.Add("@P10", SqlDbType.NVarChar, 50, "P10")
            cmd.Parameters.Add("@P11", SqlDbType.NVarChar, 50, "P11")
            cmd.Parameters.Add("@P12", SqlDbType.NVarChar, 50, "P12")
            cmd.Parameters.Add("@P13", SqlDbType.NVarChar, 50, "P13")
            cmd.Parameters.Add("@P14", SqlDbType.NVarChar, 50, "P14")
            cmd.Parameters.Add("@P15", SqlDbType.NVarChar, 50, "P15")
            cmd.Parameters.Add("@P16", SqlDbType.NVarChar, 50, "P16")
            cmd.Parameters.Add("@P17", SqlDbType.NVarChar, 50, "P17")
            cmd.Parameters.Add("@P18", SqlDbType.NVarChar, 50, "P18")
            cmd.Parameters.Add("@P19", SqlDbType.NVarChar, 50, "P19")
            cmd.Parameters.Add("@P20", SqlDbType.NVarChar, 50, "P20")
            cmd.Parameters.Add("@P21", SqlDbType.NVarChar, 50, "P21")
            cmd.Parameters.Add("@P22", SqlDbType.NVarChar, 50, "P22")
            cmd.Parameters.Add("@P23", SqlDbType.NVarChar, 50, "P23")
            cmd.Parameters.Add("@P24", SqlDbType.NVarChar, 50, "P24")
            cmd.Parameters.Add("@P25", SqlDbType.NVarChar, 50, "P25")
            cmd.Parameters.Add("@P26", SqlDbType.NVarChar, 50, "P26")


            cmd.Parameters.Add("@P27", SqlDbType.NVarChar, 50, "P27")
            cmd.Parameters.Add("@P28", SqlDbType.NVarChar, 50, "P28")
            cmd.Parameters.Add("@P29", SqlDbType.NVarChar, 50, "P29")
            cmd.Parameters.Add("@P30", SqlDbType.NVarChar, 50, "P30")
            cmd.Parameters.Add("@P31", SqlDbType.NVarChar, 50, "P31")
            cmd.Parameters.Add("@P32", SqlDbType.NVarChar, 50, "P32")
            cmd.Parameters.Add("@P33", SqlDbType.NVarChar, 50, "P33")
            cmd.Parameters.Add("@P34", SqlDbType.NVarChar, 50, "P34")
            cmd.Parameters.Add("@P35", SqlDbType.NVarChar, 50, "P35")
            cmd.Parameters.Add("@P36", SqlDbType.NVarChar, 50, "P36")
            cmd.Parameters.Add("@P37", SqlDbType.NVarChar, 50, "P37")
            cmd.Parameters.Add("@P38", SqlDbType.NVarChar, 50, "P38")
            cmd.Parameters.Add("@P39", SqlDbType.NVarChar, 50, "P39")
            cmd.Parameters.Add("@P40", SqlDbType.NVarChar, 50, "P40")
            cmd.Parameters.Add("@P41", SqlDbType.NVarChar, 50, "P41")
            cmd.Parameters.Add("@P42", SqlDbType.NVarChar, 50, "P42")
            cmd.Parameters.Add("@P43", SqlDbType.NVarChar, 50, "P43")
            cmd.Parameters.Add("@P44", SqlDbType.NVarChar, 50, "P44")
            cmd.Parameters.Add("@P45", SqlDbType.NVarChar, 50, "P45")
            cmd.Parameters.Add("@P46", SqlDbType.NVarChar, 50, "P46")
            cmd.Parameters.Add("@P47", SqlDbType.NVarChar, 50, "P47")
            cmd.Parameters.Add("@P48", SqlDbType.NVarChar, 50, "P48")
            cmd.Parameters.Add("@P49", SqlDbType.NVarChar, 50, "P49")
            cmd.Parameters.Add("@P50", SqlDbType.NVarChar, 50, "P50")
            cmd.Parameters.Add("@P51", SqlDbType.NVarChar, 50, "P51")
            cmd.Parameters.Add("@P52", SqlDbType.NVarChar, 50, "P52")

            cmd.Parameters.Add("@P53", SqlDbType.NVarChar, 50, "P53")
            cmd.Parameters.Add("@P54", SqlDbType.NVarChar, 50, "P54")
            cmd.Parameters.Add("@P55", SqlDbType.NVarChar, 50, "P55")
            cmd.Parameters.Add("@P56", SqlDbType.NVarChar, 50, "P56")
            cmd.Parameters.Add("@P57", SqlDbType.NVarChar, 50, "P57")
            cmd.Parameters.Add("@P58", SqlDbType.NVarChar, 50, "P58")
            cmd.Parameters.Add("@P59", SqlDbType.NVarChar, 50, "P59")
            cmd.Parameters.Add("@P60", SqlDbType.NVarChar, 50, "P60")
            cmd.Parameters.Add("@P61", SqlDbType.NVarChar, 50, "P61")
            cmd.Parameters.Add("@P62", SqlDbType.NVarChar, 50, "P62")
            cmd.Parameters.Add("@P63", SqlDbType.NVarChar, 50, "P63")
            cmd.Parameters.Add("@P64", SqlDbType.NVarChar, 50, "P64")
            cmd.Parameters.Add("@P65", SqlDbType.NVarChar, 50, "P65")
            cmd.Parameters.Add("@P66", SqlDbType.NVarChar, 50, "P66")
            cmd.Parameters.Add("@P67", SqlDbType.NVarChar, 50, "P67")
            cmd.Parameters.Add("@P68", SqlDbType.NVarChar, 50, "P68")
            cmd.Parameters.Add("@P69", SqlDbType.NVarChar, 50, "P69")
            cmd.Parameters.Add("@P70", SqlDbType.NVarChar, 50, "P70")
            cmd.Parameters.Add("@P71", SqlDbType.NVarChar, 50, "P71")
            cmd.Parameters.Add("@P72", SqlDbType.NVarChar, 50, "P72")
            cmd.Parameters.Add("@P73", SqlDbType.NVarChar, 50, "P73")
            cmd.Parameters.Add("@P74", SqlDbType.NVarChar, 50, "P74")
            'cmd.Parameters.Add("@P75", SqlDbType.NVarChar, 50, "P75")
            'cmd.Parameters.Add("@P76", SqlDbType.NVarChar, 50, "P76")
            'cmd.Parameters.Add("@P77", SqlDbType.NVarChar, 50, "P77")
            'cmd.Parameters.Add("@P78", SqlDbType.NVarChar, 50, "P78")

            Dim dAdapter As New SqlDataAdapter()
            dAdapter.InsertCommand = cmd
            Dim result As Integer = dAdapter.Update(tblReadCSV)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click

        Dim SQLConnectionString As String = "Data Source=Excel-PC\SQLEXPRESS;" & _
                            "Initial Catalog=Northwind;" & _
                            "Trusted_Connection=True"

        ' Open a connection to the AdventureWorks database.
        Using SourceConnection As SqlConnection = _
           New SqlConnection(SQLConnectionString)
            SourceConnection.Open()

            ' Perform an initial count on the destination table.
            Dim CommandRowCount As New SqlCommand( _
            "SELECT COUNT(*) FROM dbo.Orders;", _
                SourceConnection)
            Dim CountStart As Long = _
               System.Convert.ToInt32(CommandRowCount.ExecuteScalar())
            Console.WriteLine("Starting row count = {0}", CountStart)

            ' Get data from the source table as a AccessDataReader.
            'Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
            '    "Data Source=" & "C:\Users\Excel\Desktop\OrdersTest.txt" & ";" & _
            '    "Extended Properties=" & "text;HDR=Yes;FMT=Delimited"","";"

            Dim ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Data Source=" & "C:\Users\Excel\Desktop\" & ";" & _
                "Extended Properties=""Text;HDR=No"""

            Dim TextConnection As New System.Data.OleDb.OleDbConnection(ConnectionString)

            Dim TextCommand As New OleDbCommand("SELECT * FROM OrdersTest#csv", TextConnection)
            TextConnection.Open()
            Dim TextDataReader As OleDbDataReader = TextCommand.ExecuteReader(CommandBehavior.SequentialAccess)

            ' Open the destination connection.              
            Using DestinationConnection As SqlConnection = _
                New SqlConnection(SQLConnectionString)
                DestinationConnection.Open()

                ' Set up the bulk copy object. 
                ' The column positions in the source data reader 
                ' match the column positions in the destination table, 
                ' so there is no need to map columns.
                Using BulkCopy As SqlBulkCopy = _
                  New SqlBulkCopy(DestinationConnection)
                    BulkCopy.DestinationTableName = _
                    "dbo.Orders"

                    Try
                        ' Write from the source to the destination.
                        BulkCopy.WriteToServer(TextDataReader)

                    Catch ex As Exception
                        Console.WriteLine(ex.Message)

                    Finally
                        ' Close the AccessDataReader. The SqlBulkCopy
                        ' object is automatically closed at the end
                        ' of the Using block.
                        TextDataReader.Close()
                    End Try
                End Using

                ' Perform a final count on the destination table
                ' to see how many rows were added.
                Dim CountEnd As Long = _
                    System.Convert.ToInt32(CommandRowCount.ExecuteScalar())

            End Using
        End Using

    End Sub


    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        ' Define the Column Definition                             
        Dim dt As New DataTable()
        dt.Columns.Add("OrderID", GetType(Integer))
        dt.Columns.Add("CustomerID", GetType(String))
        dt.Columns.Add("EmployeeID", GetType(Integer))
        dt.Columns.Add("OrderDate", GetType(Date))
        dt.Columns.Add("RequiredDate", GetType(Date))
        dt.Columns.Add("ShippedDate", GetType(Date))
        dt.Columns.Add("ShipVia", GetType(Integer))
        dt.Columns.Add("Freight", GetType(Decimal))
        dt.Columns.Add("ShipName", GetType(String))
        dt.Columns.Add("ShipAddress", GetType(String))
        dt.Columns.Add("ShipCity", GetType(String))
        dt.Columns.Add("ShipRegion", GetType(String))
        dt.Columns.Add("ShipPostalCode", GetType(String))
        dt.Columns.Add("ShipCountry", GetType(String))
        Using cn
            cn.Open()
            Dim reader As Microsoft.VisualBasic.FileIO.TextFieldParser
            Dim currentRow As String()
            Dim dr As DataRow
            Dim sqlColumnDataType As String
            reader = My.Computer.FileSystem.OpenTextFieldParser("C:\Users\mohamed.rezk\Desktop\OrdersTest.csv")
            reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            reader.Delimiters = New String() {","}
            While Not reader.EndOfData
                Try
                    currentRow = reader.ReadFields()
                    dr = dt.NewRow()
                    For currColumn = 0 To dt.Columns.Count - 1
                        sqlColumnDataType = dt.Columns(currColumn).DataType.Name
                        Select Case sqlColumnDataType
                            Case "String"
                                If String.IsNullOrEmpty(currentRow(currColumn)) Then
                                    dr.Item(currColumn) = ""
                                Else
                                    dr.Item(currColumn) = Convert.ToString(currentRow(currColumn))
                                End If
                            Case "Decimal"
                                If String.IsNullOrEmpty(currentRow(currColumn)) Then
                                    dr.Item(currColumn) = 0
                                Else
                                    dr.Item(currColumn) = Convert.ToDecimal(currentRow(currColumn))
                                End If
                            Case "DateTime"
                                If String.IsNullOrEmpty(currentRow(currColumn)) Then
                                    dr.Item(currColumn) = ""
                                Else
                                    dr.Item(currColumn) = Convert.ToDateTime(currentRow(currColumn))
                                End If
                        End Select
                    Next
                    dt.Rows.Add(dr)
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid." & vbCrLf & "Terminating Read Operation.")
                    reader.Close()
                    reader.Dispose()
                    'Return False
                Finally
                    dr = Nothing
                End Try
            End While
            Using copy As New SqlBulkCopy(cn)
                copy.DestinationTableName = "[dbo].[Orders]"
                copy.WriteToServer(dt)
            End Using
        End Using

    End Sub

    'Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click

    '    'Dim cnn As SqlConnection
    '    'Dim connectionString As String
    '    'Dim sql As String
    '    'connectionString = "data source=Excel-PC\SQLEXPRESS;" & _
    '    '"initial catalog=NORTHWIND;Trusted_Connection=True"
    '    'cnn = New SqlConnection(connectionString)
    '    'cnn.Open()
    '    'GetCsvData("C:\Users\Excel\Desktop\OrdersTest.csv", dbo.Orders)

    'End Sub

    Public Shared Function GetCsvData(ByVal CSVFileName As String, ByRef CSVTable As DataTable) As Boolean
        Dim reader As Microsoft.VisualBasic.FileIO.TextFieldParser
        Dim currentRow As String()
        Dim dr As DataRow
        Dim sqlColumnDataType As String
        reader = My.Computer.FileSystem.OpenTextFieldParser(CSVFileName)
        reader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
        reader.Delimiters = New String() {","}
        While Not reader.EndOfData
            Try
                currentRow = reader.ReadFields()
                dr = CSVTable.NewRow()
                For currColumn = 0 To CSVTable.Columns.Count - 1
                    sqlColumnDataType = CSVTable.Columns(currColumn).DataType.Name
                    Select Case sqlColumnDataType
                        Case "String"
                            If String.IsNullOrEmpty(currentRow(currColumn)) Then
                                dr.Item(currColumn) = ""
                            Else
                                dr.Item(currColumn) = Convert.ToString(currentRow(currColumn))
                            End If
                        Case "Decimal"
                            If String.IsNullOrEmpty(currentRow(currColumn)) Then
                                dr.Item(currColumn) = 0
                            Else
                                dr.Item(currColumn) = Convert.ToDecimal(currentRow(currColumn))
                            End If
                        Case "DateTime"
                            If String.IsNullOrEmpty(currentRow(currColumn)) Then
                                dr.Item(currColumn) = ""
                            Else
                                dr.Item(currColumn) = Convert.ToDateTime(currentRow(currColumn))
                            End If
                    End Select
                Next
                CSVTable.Rows.Add(dr)
            Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message & "is not valid." & vbCrLf & "Terminating Read Operation.")
                reader.Close()
                reader.Dispose()
                Return False
            Finally
                dr = Nothing
            End Try
        End While
        reader.Close()
        reader.Dispose()
        Return True
    End Function

    'Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

    'End Sub
    ''Private Sub InsertingIntoDB()
    '    Dim fileName As String = "D:\PPOS\Sales_report\inventory_255503221452_Cake102.csv"
    '    Using cn
    '        Dim query As String = "INSERT INTO inventory (Inventory_id, item_id, Amount, AvgCost, CreateDate, CreateUser, Real_Qty, UnitID, BranchID) " & "VALUES(@a, @b, @c, @d, @e, @f, @g, @h, @i)"
    '        Using cmd As New SqlCommand(query, cn)
    '            For Each line As String In ReadingFile(fileName)
    '                Dim data As String() = line.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
    '                cmd.Parameters.AddWithValue("@a", Integer.Parse(data(0)))
    '                cmd.Parameters.AddWithValue("@b", Integer.Parse(data(1)))
    '                cmd.Parameters.AddWithValue("@c", Integer.Parse(data(2)))
    '                cmd.Parameters.AddWithValue("@d", Integer.Parse(data(3)))
    '                cmd.Parameters.AddWithValue("@e", Integer.Parse(data(4)))
    '                cmd.Parameters.AddWithValue("@f", data(5))
    '                cmd.Parameters.AddWithValue("@g", Integer.Parse(data(6)))
    '                cmd.Parameters.AddWithValue("@h", Integer.Parse(data(7)))
    '                cmd.Parameters.AddWithValue("@i", data(8))
    '                Try
    '                    cmd.ExecuteNonQuery()
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message)
    '                    Exit Try
    '                End Try
    '            Next
    '        End Using
    '    End Using
    'End Sub
    ''Private Function ReadingFile(path As String) As IEnumerable(Of String)
    '    Using sr As New StreamReader(path)
    '        Dim line As String
    '        While (InlineAssignHelper(line, sr.ReadLine())) IsNot Nothing
    '        yield Return line
    '        End While
    '    End Using
    'End Function


    Private Sub aquTestTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtParts1.Focus()

        InputLanguage.CurrentInputLanguage = englishinpot
        '   Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        'txtBarcodeOne.Enabled = False
        'TxtheaterTwo.Enabled = False
        'TxtheaterThree.Enabled = False
        'txtPARTSSERIAL.Enabled = False
        'TextBox1.Enabled = False
        'TextBox2.Enabled = False
        GroupBox2.Visible = False
        txtline1.Enabled = False
        cmb_Pcode.Enabled = False
        Button10.Visible = False
        TxtheaterTwo.Visible = False
        txtBarcodeOne.Visible = False
        Label4.Visible = False
        TxtheaterThree.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        '  txtBarcodeOne.Focus()
        Try
            Dim sql As String = ""
            sql += "SELECT CModelName FROM CModels"
            '  sql += " where fLine_Name ='EWH1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            ' cmb_Pcode.ValueMember = "CSetID"
            ' cmb_Pcode.ValueMember = "model_S_Power"
            cmb_Pcode.DisplayMember = "CModelName"
            cmb_Pcode.Sorted = True
            _Refresh1()
        Catch ex As Exception
        End Try
        ' _Refresh1()
        'Catch ex As Exception
        cmb_Pcode.Text = ""

        txtParts1.Focus()

    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (S_Serial) AS tot"
            sql += " FROM C_Sin_Test3 "
            sql += " WHERE S_Data_ >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and H_Line_Name='EWH1'"
            sql += " and S_Line_Shift ='" & txtline1.Text & "'"
            sql += " and S_Stutes_Test ='OK'"
            sql += " and S_Model ='" & cmb_Pcode.Text & "'"
            '  sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Sin_Test3")
            '   ds.Tables("C_Output_Production").Columns(0).ColumnName = " الموديل "
            ds.Tables("C_Sin_Test3").Columns(0).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("C_Sin_Test3")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (S_Serial) AS tot"
            sql += " FROM C_Sin_Test3 "
            sql += " WHERE S_Data_ >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and H_Line_Name='EWH1'"
            sql += " and S_Line_Shift ='" & txtline1.Text & "'"
            sql += " and S_Stutes_Test ='NG'"
            sql += " and S_Model ='" & cmb_Pcode.Text & "'"
            '  sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Sin_Test3")
            '   ds.Tables("C_Output_Production").Columns(0).ColumnName = " الموديل "
            ds.Tables("C_Sin_Test3").Columns(0).ColumnName = " الكمية"
            DGH.DataSource = ds.Tables("C_Sin_Test3")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtParts1.Text.Length < 8 Then Exit Sub

            Dim dsMax As New DataSet
            Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap "
            Sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            '   Sql += " and Heater_sap_stu='Active'"
            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count < 1 Then
                lbl_Msg.ForeColor = Color.Red
                '  MsgBox(" غير  مصرح بالدخول ")
                lbl_Msg.Text = " غير  مصرح بالدخول "
                Console.Beep()
                txtParts1.Focus()
                txtParts1.SelectAll()
                Exit Sub
            Else
                _Refresh315()
                lbl_Msg.ForeColor = Color.Green
                'MsgBox("مرحبا بك فى برنامج مصنع البتوجاز لمتابعة الانتاج ")
                lbl_Msg.Text = "مرحبا بك فى برنامج متابعة الانتاج "
                cmb_Pcode.Enabled = True
                ' txtline.Enabled = False
                txtline1.Enabled = True
                GroupBox2.Visible = True
                'txtshift.Visible = False
                Button2.Visible = False
                txtParts1.Visible = False
                Label10.Visible = False
                cmb_Pcode.Focus()
                'Me.BackColor = Color.YellowGreen
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = " الفنى المسئول"

            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub dg2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        ' txtline.Enabled = True
        ' txtshift.Enabled = True
        cmb_Pcode.Focus()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmb_Pcode.Text = "" Or txtline1.Text = "" Or txtParts1.Text = "" Then

            MsgBox("لابد من التأكد من أدخال الورديه والموديل بصوره صحيحه ")

            Exit Sub
        Else
            Try
                _Refresh315()
                '    _Refresh11()
                cmb_Pcode.Enabled = False
                ' txtline.Enabled = False
                txtline1.Enabled = False
                txtline1.Visible = False
                Label8.Visible = False
                txtParts1.Visible = False
                Label10.Visible = False
                txtBarcodeOne.Enabled = True
                TxtheaterTwo.Enabled = True
                TxtheaterThree.Enabled = True
                'txtPARTSSERIAL.Enabled = True
                'TextBox1.Enabled = True
                'TextBox2.Enabled = True
                txtBarcodeOne.Visible = True
                Label4.Visible = True
                txtBarcodeOne.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SaveFileDialog1.ShowDialog()
        '  tbFile.Text = "C:\Users\mohamed.rezk\Desktop\Newfolder\Employee.txt"
        tbFile.Text = SaveFileDialog1.FileName
        FileCopy(TextBox1.Text, tbFile.Text)
        Try

            Dim tblReadCSV As New DataTable()
            tblReadCSV.Columns.Add("P1")
            tblReadCSV.Columns.Add("P2")
            tblReadCSV.Columns.Add("P3")
            tblReadCSV.Columns.Add("P4")
            tblReadCSV.Columns.Add("P5")
            tblReadCSV.Columns.Add("P6")
            tblReadCSV.Columns.Add("P7")
            tblReadCSV.Columns.Add("P8")
            tblReadCSV.Columns.Add("P9")
            tblReadCSV.Columns.Add("P10")
            tblReadCSV.Columns.Add("P11")
            tblReadCSV.Columns.Add("P12")
            tblReadCSV.Columns.Add("P13")
            tblReadCSV.Columns.Add("P14")
            tblReadCSV.Columns.Add("P15")
            tblReadCSV.Columns.Add("P16")
            tblReadCSV.Columns.Add("P17")
            tblReadCSV.Columns.Add("P18")
            tblReadCSV.Columns.Add("P19")
            tblReadCSV.Columns.Add("P20")
            tblReadCSV.Columns.Add("P21")
            tblReadCSV.Columns.Add("P22")
            tblReadCSV.Columns.Add("P23")
            tblReadCSV.Columns.Add("P24")
            tblReadCSV.Columns.Add("P25")
            tblReadCSV.Columns.Add("P26")
            tblReadCSV.Columns.Add("P27")
            tblReadCSV.Columns.Add("P28")
            tblReadCSV.Columns.Add("P29")
            tblReadCSV.Columns.Add("P30")
            tblReadCSV.Columns.Add("P31")
            tblReadCSV.Columns.Add("P32")
            tblReadCSV.Columns.Add("P33")
            tblReadCSV.Columns.Add("P34")
            tblReadCSV.Columns.Add("P35")
            tblReadCSV.Columns.Add("P36")

            tblReadCSV.Columns.Add("P37")
            tblReadCSV.Columns.Add("P38")
            tblReadCSV.Columns.Add("P39")
            tblReadCSV.Columns.Add("P40")
            tblReadCSV.Columns.Add("P41")
            tblReadCSV.Columns.Add("P42")
            tblReadCSV.Columns.Add("P43")
            tblReadCSV.Columns.Add("P44")
            tblReadCSV.Columns.Add("P45")
            tblReadCSV.Columns.Add("P46")
            tblReadCSV.Columns.Add("P47")
            tblReadCSV.Columns.Add("P48")
            tblReadCSV.Columns.Add("P49")
            tblReadCSV.Columns.Add("P50")
            tblReadCSV.Columns.Add("P51")
            tblReadCSV.Columns.Add("P52")
            tblReadCSV.Columns.Add("P53")
            tblReadCSV.Columns.Add("P54")
            tblReadCSV.Columns.Add("P55")
            tblReadCSV.Columns.Add("P56")
            tblReadCSV.Columns.Add("P57")
            tblReadCSV.Columns.Add("P58")
            tblReadCSV.Columns.Add("P59")
            tblReadCSV.Columns.Add("P60")
            tblReadCSV.Columns.Add("P61")
            tblReadCSV.Columns.Add("P62")
            tblReadCSV.Columns.Add("P63")

            tblReadCSV.Columns.Add("P64")
            tblReadCSV.Columns.Add("P65")
            tblReadCSV.Columns.Add("P66")
            tblReadCSV.Columns.Add("P67")
            tblReadCSV.Columns.Add("P68")
            tblReadCSV.Columns.Add("P69")
            tblReadCSV.Columns.Add("P70")
            tblReadCSV.Columns.Add("P71")
            tblReadCSV.Columns.Add("P72")
            tblReadCSV.Columns.Add("P73")
            tblReadCSV.Columns.Add("P74")
            'tblReadCSV.Columns.Add("P75")
            'tblReadCSV.Columns.Add("P76")
            'tblReadCSV.Columns.Add("P77")
            'tblReadCSV.Columns.Add("P78")
            'tblReadCSV.Columns.Add("P79")
            'tblReadCSV.Columns.Add("P80")
            'tblReadCSV.Columns.Add("P81")
            'tblReadCSV.Columns.Add("P82")
            'tblReadCSV.Columns.Add("P83")
            'tblReadCSV.Columns.Add("P84")
            'tblReadCSV.Columns.Add("P85")
            'tblReadCSV.Columns.Add("P86")
            'tblReadCSV.Columns.Add("P87")
            'tblReadCSV.Columns.Add("P34")
            'tblReadCSV.Columns.Add("P35")
            'tblReadCSV.Columns.Add("P36")
            Dim csvParser As New TextFieldParser("E:\Triceability system\ateq\UpLoad.txt")
            csvParser.Delimiters = New String() {","}
            csvParser.TrimWhiteSpace = True
            csvParser.ReadLine()
            While Not (csvParser.EndOfData = True)
                tblReadCSV.Rows.Add(csvParser.ReadFields())
            End While
            'Dim con As New SqlConnection("Server=Excel-PC\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;")
            Dim strSql As String = "Insert into C_Atc_3(P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20, P21, P22, P23, P24, P25, P26, P27, P28, P29, P30, P31, P32, P33, P34, P35, P36, P37, P38, P39, P40, P41, "
            strSql += "   P42, P43, P44, P45, P46, P47, P48, P49, P50, P51, P52, P53, P54, P55, P56, P57, P58, P59, P60, P61, P62, P63, P64, P65, P66, P67, P68, P69, P70, P71, P72, P73, P74) "
            strSql += "values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17,@P18,@P19,@P20,@P21,@P22,@P23,@P24,@P25,@P26,@P27,@P28,@P29,@P30,@P31,@P32,@P33,@P34,@P35,@P36,@P37,@P38,@P39,@P40,@P41, "
            strSql += "@P42,@P43,@P44,@P45,@P46,@P47,@P48,@P49,@P50,@P51,@P52,@P53,@P54,@P55,@P56,@P57,@P58,@P59,@P60,@P61,@P62,@P63,@P64,@P65,@P66,@P67,@P68,@P69,@P70,@P71,@P72,@P73,'CL_A_3')"

            Dim cmd As New SqlCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            cmd.Connection = cn

            cmd.Parameters.Add("@P1", SqlDbType.NVarChar, 50, "P1")
            cmd.Parameters.Add("@P2", SqlDbType.NVarChar, 50, "P2")
            cmd.Parameters.Add("@P3", SqlDbType.NVarChar, 50, "P3")
            cmd.Parameters.Add("@P4", SqlDbType.NVarChar, 50, "P4")
            cmd.Parameters.Add("@P5", SqlDbType.NVarChar, 50, "P5")
            cmd.Parameters.Add("@P6", SqlDbType.NVarChar, 50, "P6")
            cmd.Parameters.Add("@P7", SqlDbType.NVarChar, 50, "P7")
            cmd.Parameters.Add("@P8", SqlDbType.NVarChar, 50, "P8")
            cmd.Parameters.Add("@P9", SqlDbType.NVarChar, 50, "P9")
            cmd.Parameters.Add("@P10", SqlDbType.NVarChar, 50, "P10")
            cmd.Parameters.Add("@P11", SqlDbType.NVarChar, 50, "P11")
            cmd.Parameters.Add("@P12", SqlDbType.NVarChar, 50, "P12")
            cmd.Parameters.Add("@P13", SqlDbType.NVarChar, 50, "P13")
            cmd.Parameters.Add("@P14", SqlDbType.NVarChar, 50, "P14")
            cmd.Parameters.Add("@P15", SqlDbType.NVarChar, 50, "P15")
            cmd.Parameters.Add("@P16", SqlDbType.NVarChar, 50, "P16")
            cmd.Parameters.Add("@P17", SqlDbType.NVarChar, 50, "P17")
            cmd.Parameters.Add("@P18", SqlDbType.NVarChar, 50, "P18")
            cmd.Parameters.Add("@P19", SqlDbType.NVarChar, 50, "P19")
            cmd.Parameters.Add("@P20", SqlDbType.NVarChar, 50, "P20")
            cmd.Parameters.Add("@P21", SqlDbType.NVarChar, 50, "P21")
            cmd.Parameters.Add("@P22", SqlDbType.NVarChar, 50, "P22")
            cmd.Parameters.Add("@P23", SqlDbType.NVarChar, 50, "P23")
            cmd.Parameters.Add("@P24", SqlDbType.NVarChar, 50, "P24")
            cmd.Parameters.Add("@P25", SqlDbType.NVarChar, 50, "P25")
            cmd.Parameters.Add("@P26", SqlDbType.NVarChar, 50, "P26")


            cmd.Parameters.Add("@P27", SqlDbType.NVarChar, 50, "P27")
            cmd.Parameters.Add("@P28", SqlDbType.NVarChar, 50, "P28")
            cmd.Parameters.Add("@P29", SqlDbType.NVarChar, 50, "P29")
            cmd.Parameters.Add("@P30", SqlDbType.NVarChar, 50, "P30")
            cmd.Parameters.Add("@P31", SqlDbType.NVarChar, 50, "P31")
            cmd.Parameters.Add("@P32", SqlDbType.NVarChar, 50, "P32")
            cmd.Parameters.Add("@P33", SqlDbType.NVarChar, 50, "P33")
            cmd.Parameters.Add("@P34", SqlDbType.NVarChar, 50, "P34")
            cmd.Parameters.Add("@P35", SqlDbType.NVarChar, 50, "P35")
            cmd.Parameters.Add("@P36", SqlDbType.NVarChar, 50, "P36")
            cmd.Parameters.Add("@P37", SqlDbType.NVarChar, 50, "P37")
            cmd.Parameters.Add("@P38", SqlDbType.NVarChar, 50, "P38")
            cmd.Parameters.Add("@P39", SqlDbType.NVarChar, 50, "P39")
            cmd.Parameters.Add("@P40", SqlDbType.NVarChar, 50, "P40")
            cmd.Parameters.Add("@P41", SqlDbType.NVarChar, 50, "P41")
            cmd.Parameters.Add("@P42", SqlDbType.NVarChar, 50, "P42")
            cmd.Parameters.Add("@P43", SqlDbType.NVarChar, 50, "P43")
            cmd.Parameters.Add("@P44", SqlDbType.NVarChar, 50, "P44")
            cmd.Parameters.Add("@P45", SqlDbType.NVarChar, 50, "P45")
            cmd.Parameters.Add("@P46", SqlDbType.NVarChar, 50, "P46")
            cmd.Parameters.Add("@P47", SqlDbType.NVarChar, 50, "P47")
            cmd.Parameters.Add("@P48", SqlDbType.NVarChar, 50, "P48")
            cmd.Parameters.Add("@P49", SqlDbType.NVarChar, 50, "P49")
            cmd.Parameters.Add("@P50", SqlDbType.NVarChar, 50, "P50")
            cmd.Parameters.Add("@P51", SqlDbType.NVarChar, 50, "P51")
            cmd.Parameters.Add("@P52", SqlDbType.NVarChar, 50, "P52")

            cmd.Parameters.Add("@P53", SqlDbType.NVarChar, 50, "P53")
            cmd.Parameters.Add("@P54", SqlDbType.NVarChar, 50, "P54")
            cmd.Parameters.Add("@P55", SqlDbType.NVarChar, 50, "P55")
            cmd.Parameters.Add("@P56", SqlDbType.NVarChar, 50, "P56")
            cmd.Parameters.Add("@P57", SqlDbType.NVarChar, 50, "P57")
            cmd.Parameters.Add("@P58", SqlDbType.NVarChar, 50, "P58")
            cmd.Parameters.Add("@P59", SqlDbType.NVarChar, 50, "P59")
            cmd.Parameters.Add("@P60", SqlDbType.NVarChar, 50, "P60")
            cmd.Parameters.Add("@P61", SqlDbType.NVarChar, 50, "P61")
            cmd.Parameters.Add("@P62", SqlDbType.NVarChar, 50, "P62")
            cmd.Parameters.Add("@P63", SqlDbType.NVarChar, 50, "P63")
            cmd.Parameters.Add("@P64", SqlDbType.NVarChar, 50, "P64")
            cmd.Parameters.Add("@P65", SqlDbType.NVarChar, 50, "P65")
            cmd.Parameters.Add("@P66", SqlDbType.NVarChar, 50, "P66")
            cmd.Parameters.Add("@P67", SqlDbType.NVarChar, 50, "P67")
            cmd.Parameters.Add("@P68", SqlDbType.NVarChar, 50, "P68")
            cmd.Parameters.Add("@P69", SqlDbType.NVarChar, 50, "P69")
            cmd.Parameters.Add("@P70", SqlDbType.NVarChar, 50, "P70")
            cmd.Parameters.Add("@P71", SqlDbType.NVarChar, 50, "P71")
            cmd.Parameters.Add("@P72", SqlDbType.NVarChar, 50, "P72")
            cmd.Parameters.Add("@P73", SqlDbType.NVarChar, 50, "P73")
            cmd.Parameters.Add("@P74", SqlDbType.NVarChar, 50, "P74")
            'cmd.Parameters.Add("@P75", SqlDbType.NVarChar, 50, "P75")
            'cmd.Parameters.Add("@P76", SqlDbType.NVarChar, 50, "P76")
            'cmd.Parameters.Add("@P77", SqlDbType.NVarChar, 50, "P77")
            'cmd.Parameters.Add("@P78", SqlDbType.NVarChar, 50, "P78")

            Dim dAdapter As New SqlDataAdapter()
            dAdapter.InsertCommand = cmd
            Dim result As Integer = dAdapter.Update(tblReadCSV)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtBarcodeOne.Text = ""
        TxtheaterTwo.Visible = True
        txtBarcodeOne.Visible = False
        Label4.Visible = False
        TxtheaterThree.Visible = True
        Button10.Visible = True
        Label7.Visible = True
        Label9.Visible = True
        TxtheaterTwo.Focus()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        TxtheaterTwo.Visible = False
        txtBarcodeOne.Visible = True
        Label4.Visible = True
        TxtheaterThree.Visible = False
        Label7.Visible = False
        Label9.Visible = False
        txtBarcodeOne.Focus()

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click

        If TxtheaterTwo.Text.Length = 18 Then


            '     If txtFATSERIAL.Text.Length <> 16 Then Exit Sub
            'If txtFATSERIAL.Text.Length > 14 Then Exit Sub
            Dim dsMax As New DataSet
            Dim Sql = "SELECT S_Serial  FROM  C_Sin_Test3 "
            Sql += " where S_Serial='" & TxtheaterTwo.Text & "'"
            Sql += " and S_Model='" & cmb_Pcode.Text & "'"
            Sql += " and S_Line_Shift='" & txtline1.Text & "'"
            Sql += " and S_Stutes_Test='NG'"
            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count > 0 Then
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "This Serial is already used"
                TxtheaterTwo.Focus()
                TxtheaterTwo.SelectAll()
                Exit Sub
            End If
            Dim Sql1 As String = "INSERT INTO C_Sin_Test3"
            Sql1 += "(S_Serial, S_Line_Shift, S_sap_Labor, S_Stutes_Test, S_Notes,S_Model)"
            Sql1 += " VALUES ('" & TxtheaterTwo.Text & "','" & txtline1.Text & "','" & txtParts1.Text & "','NG','" & TxtheaterThree.Text & "','" & cmb_Pcode.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(Sql1, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            lbl_Msg.ForeColor = Color.GreenYellow
            lbl_Msg.Text = "Done"

            _Refresh1()
            _Refresh11()
            TxtheaterTwo.Visible = False
            txtBarcodeOne.Visible = True
            Label4.Visible = True
            TxtheaterThree.Visible = False
            Label7.Visible = False
            Label9.Visible = False
            Button10.Visible = False
            TxtheaterTwo.Text = ""
            TxtheaterThree.Text = ""
            txtBarcodeOne.Focus()
        Else
            lbl_Msg.ForeColor = Color.Red
            lbl_Msg.Text = "This serial is wrong"
            txtBarcodeOne.SelectAll()
            txtBarcodeOne.Focus()
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtBarcodeOne.Text.Length = 18 Then


                '     If txtFATSERIAL.Text.Length <> 16 Then Exit Sub
                'If txtFATSERIAL.Text.Length > 14 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "SELECT S_Serial  FROM  C_Sin_Test3 "
                Sql += " where S_Serial='" & txtBarcodeOne.Text & "'"
                Sql += " and S_Model='" & cmb_Pcode.Text & "'"
                Sql += " and S_Line_Shift='" & txtline1.Text & "'"
                Sql += " and S_Stutes_Test='OK'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This Serial is already used"
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                    Exit Sub
                End If
                Dim Sql1 As String = "INSERT INTO C_Sin_Test3"
                Sql1 += "(S_Serial, S_Line_Shift, S_sap_Labor, S_Stutes_Test, S_Notes,S_Model)"
                Sql1 += " VALUES ('" & txtBarcodeOne.Text & "','" & txtline1.Text & "','" & txtParts1.Text & "','OK','" & TxtheaterThree.Text & "','" & cmb_Pcode.Text & "')"
                Dim cmd As New SqlClient.SqlCommand(Sql1, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "Done"
                txtBarcodeOne.Focus()
                txtBarcodeOne.SelectAll()
                _Refresh1()
                _Refresh11()
            Else
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "This serial is wrong"
                txtBarcodeOne.SelectAll()
                txtBarcodeOne.Focus()
            End If

        End If
    End Sub

    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged

    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New aquTestTestQuery1Show
        frm.Show()
    End Sub
End Class