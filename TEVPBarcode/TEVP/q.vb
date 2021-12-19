Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class q
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [View_1] "
            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_1")
            ds.Tables("View_1").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dg.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate, fPtime, fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName FROM  LCM "
            'sql += " where fLCDBarcode ='" & txtFATSERIAL.Text & "'"
            sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM")
            ds.Tables("LCM").Columns(0).ColumnName = " Date "
            ds.Tables("LCM").Columns(1).ColumnName = " time "
            ds.Tables("LCM").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("LCM").Columns(3).ColumnName = " fBIN_Code "
            ds.Tables("LCM").Columns(4).ColumnName = "fSerial_No"
            ds.Tables("LCM").Columns(5).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("LCM")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate, fPtime, fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName ,fLine FROM LCM "
            sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            sql += " and fLine =" & cbl.Text & ""

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM")
            ds.Tables("LCM").Columns(0).ColumnName = " Date "
            ds.Tables("LCM").Columns(1).ColumnName = " time "
            ds.Tables("LCM").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("LCM").Columns(3).ColumnName = " fBIN_Code "
            ds.Tables("LCM").Columns(4).ColumnName = "fSerial_No"
            ds.Tables("LCM").Columns(5).ColumnName = "LCD Model Name"
            ds.Tables("LCM").Columns(6).ColumnName = " Line"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("LCM")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnsearchModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchModel.Click
        _Refresh1()
        Dim sql As String = ""
        sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM  [View_1] "
        sql += " where fLCDModelName ='" & btnPCode.Text & "'"
        sql += " and fLine =" & cbl.Text & ""
        sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
        sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
        sql += " group by fLCDModelName"
        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        Dim ds As New DataSet
        da.Fill(ds, "View_1")
        ds.Tables("View_1").Columns(0).ColumnName = " LCD Model Name"
        ds.Tables("View_1").Columns(1).ColumnName = " Qty"
        dg6.DataSource = ds.Tables("View_1")
        '_Refresh011()
    End Sub
    Private Function _Refresh() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate, fPtime, fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName FROM  LCM "
            sql += " where fLCDBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM")
            ds.Tables("LCM").Columns(0).ColumnName = " Date "
            ds.Tables("LCM").Columns(1).ColumnName = " time "
            ds.Tables("LCM").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("LCM").Columns(3).ColumnName = " fBIN_Code "
            ds.Tables("LCM").Columns(4).ColumnName = "fSerial_No"
            ds.Tables("LCM").Columns(5).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("LCM")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate, fPtime, fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName FROM  LCM "
            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += " and fLine =" & cbl.Text & ""
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM")
            ds.Tables("LCM").Columns(0).ColumnName = " Date "
            ds.Tables("LCM").Columns(1).ColumnName = " time "
            ds.Tables("LCM").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("LCM").Columns(3).ColumnName = " fBIN_Code "
            ds.Tables("LCM").Columns(4).ColumnName = "fSerial_No"
            ds.Tables("LCM").Columns(5).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("LCM")

            'Dim sql As String = ""
            'sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [barcode].[dbo].[View_1] "
            'sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            'sql += " and fLine =" & cbl.Text & ""
            'sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            'sql += " group by fLCDModelName"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "View_1")
            'ds.Tables("View_1").Columns(0).ColumnName = " LCD Model Name"
            'ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            'dg6.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh001() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [View_1] "
            sql += " where fLine =" & cbl.Text & ""
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_1")
            ds.Tables("View_1").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dg6.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh10() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate, fPtime, fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName FROM  LCM "
            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM")
            ds.Tables("LCM").Columns(0).ColumnName = " Date "
            ds.Tables("LCM").Columns(1).ColumnName = " time "
            ds.Tables("LCM").Columns(2).ColumnName = " LCD Barcode"
            ds.Tables("LCM").Columns(3).ColumnName = " fBIN_Code "
            ds.Tables("LCM").Columns(4).ColumnName = "fSerial_No"
            ds.Tables("LCM").Columns(5).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("LCM")
            'Dim sql As String = ""
            'sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [barcode].[dbo].[View_1] "
            'sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            'sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            'sql += " group by fLCDModelName"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "View_1")
            'ds.Tables("View_1").Columns(0).ColumnName = " LCD Model Name"
            'ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            'dg6.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnsearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch1.Click
        _Refresh()
    End Sub
    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        _Refresh011()
        _Refresh1()
    End Sub
    Private Sub q_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            _Refresh10()


            Dim sql As String = ""
            sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [View_1] "
            sql += " where LCDModelName =" & btnPCode.Text & ""
            sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtpTODATE.Value, "yyyy-MM-dd") & "'"
            sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_1")
            ds.Tables("View_1").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dg6.DataSource = ds.Tables("View_1")

        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        _Refresh001()
        _Refresh511()
    End Sub
End Class