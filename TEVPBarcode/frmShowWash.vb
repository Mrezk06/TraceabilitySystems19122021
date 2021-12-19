Imports System.Data.SqlClient
Imports TEVPBarcode.sher

Public Class frmShowWash
    Private Function _Refresh1990() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & txtl4.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            '  ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg30.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1550() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql += " and fLineandsh ='" & txtl4.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            '  ds.Tables("yearlyp").Columns(2).ColumnName = " Line"
            dg40.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh110() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM LCM2"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLine = '" & txtl4.Text & "' "
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM2")
            ds.Tables("LCM2").Columns(0).ColumnName = "  Model Name"
            ds.Tables("LCM2").Columns(1).ColumnName = " Qty"
            dg20.DataSource = ds.Tables("LCM2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh100() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [barcode].[dbo].[View_1] "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLine = '" & txtl4.Text & "' "
            sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_1")
            ds.Tables("View_1").Columns(0).ColumnName = " Model Name"
            ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dg10.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
    Private Function _Refresh199() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & CB2.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            '  ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg3.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql += " and fLineandsh ='" & CB2.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            '  ds.Tables("yearlyp").Columns(2).ColumnName = " Line"
            dg4.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM LCM2"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLine = '" & CB2.Text & "' "
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM2")
            ds.Tables("LCM2").Columns(0).ColumnName = "  Model Name"
            ds.Tables("LCM2").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("LCM2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh10() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [barcode].[dbo].[View_1] "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLine = '" & CB2.Text & "' "
            sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_1")
            ds.Tables("View_1").Columns(0).ColumnName = " Model Name"
            ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dg1.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmShowWash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

    End Sub
    Private Function _Refresh1991() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & txtc3.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            '  ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg13.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1551() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql += " and fLineandsh ='" & txtc3.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            '  ds.Tables("yearlyp").Columns(2).ColumnName = " Line"
            dg14.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM LCM2"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLine = '" & txtc3.Text & "' "
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM2")
            ds.Tables("LCM2").Columns(0).ColumnName = "  Model Name"
            ds.Tables("LCM2").Columns(1).ColumnName = " Qty"
            dg12.DataSource = ds.Tables("LCM2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh101() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [barcode].[dbo].[View_1] "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLine = '" & txtc3.Text & "' "
            sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_1")
            ds.Tables("View_1").Columns(0).ColumnName = " Model Name"
            ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dg11.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh10()
        _Refresh1()
        _Refresh155()
        _Refresh199()

        _Refresh100()
        _Refresh110()
        _Refresh1550()
        _Refresh1990()

        _Refresh101()
        _Refresh11()
        _Refresh1551()
        _Refresh1991()


        _Refresh1011()
        _Refresh111()
        _Refresh15511()
        _Refresh19911()
    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub
    Private Function _Refresh19911() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & txtc5.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            '  ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg133.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql += " and fLineandsh ='" & txtc5.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            '  ds.Tables("yearlyp").Columns(2).ColumnName = " Line"
            dg134.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh111() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM LCM2"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLine = '" & txtc5.Text & "' "
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM2")
            ds.Tables("LCM2").Columns(0).ColumnName = "  Model Name"
            ds.Tables("LCM2").Columns(1).ColumnName = " Qty"
            dg132.DataSource = ds.Tables("LCM2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1011() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [barcode].[dbo].[View_1] "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLine = '" & txtc5.Text & "' "
            sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_1")
            ds.Tables("View_1").Columns(0).ColumnName = " Model Name"
            ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dg131.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox15_Enter(sender As Object, e As EventArgs) Handles GroupBox15.Enter

    End Sub

    Private Sub GroupBox13_Enter(sender As Object, e As EventArgs) Handles GroupBox13.Enter

    End Sub
End Class