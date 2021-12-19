Imports System.Data.SqlClient
Imports TEVPBarcode.sher

Public Class ShowTEVP
    Private Function _Refresh199() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & CB1.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            '  ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg1.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1991() As Boolean
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
            '   ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg2.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1992() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & CB3.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            'ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg3.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1993() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & CB4.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            ' ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg4.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1994() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & CB5.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            ' ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg5.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1995() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLineandsh ='" & CB6.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            '  ds.Tables("DailyP").Columns(2).ColumnName = "line"
            dg6.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub ShowTEVP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPBlue.ssk"
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
        Timer5.Enabled = True
        Timer6.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh199()






    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        _Refresh1994()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        _Refresh1993()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        _Refresh1992()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        _Refresh1991()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        _Refresh1995()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New QueryFat1
        frm.Show()

    End Sub

    Private Sub CB1_Leave(sender As Object, e As EventArgs) Handles CB1.Leave
        Label12.Text = CB1.Text
    End Sub

    Private Sub CB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged

    End Sub

    Private Sub CB2_Leave(sender As Object, e As EventArgs) Handles CB2.Leave
        Label13.Text = CB2.Text
    End Sub

    Private Sub CB2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB2.SelectedIndexChanged

    End Sub

    Private Sub CB3_Leave(sender As Object, e As EventArgs) Handles CB3.Leave
        Label17.Text = CB3.Text
    End Sub

    Private Sub CB3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB3.SelectedIndexChanged

    End Sub

    Private Sub CB4_Leave(sender As Object, e As EventArgs) Handles CB4.Leave
        Label14.Text = CB4.Text
    End Sub

    Private Sub CB4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB4.SelectedIndexChanged

    End Sub

    Private Sub CB5_Leave(sender As Object, e As EventArgs) Handles CB5.Leave
        Label15.Text = CB5.Text
    End Sub

    Private Sub CB5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB5.SelectedIndexChanged

    End Sub

    Private Sub CB6_Leave(sender As Object, e As EventArgs) Handles CB6.Leave
        Label16.Text = CB6.Text
    End Sub

    Private Sub CB6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB6.SelectedIndexChanged

    End Sub
End Class