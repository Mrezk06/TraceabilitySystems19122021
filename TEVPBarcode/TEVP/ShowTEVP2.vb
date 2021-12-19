Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class ShowTEVP2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Target
        frm.Show()
    End Sub

    Private Sub ShowTEVP2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackgroundImage = Image.FromFile("F:\Dr Gaballa Photographer\IMG_0008.JPG")

        GroupBox3.Visible = True
        GroupBox7.Visible = True
        GroupBox8.Visible = True
        'Me.SkinEngine1.SkinFile = "Skins/XPBlue.ssk"
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
        Timer5.Enabled = True
        Timer6.Enabled = True
    End Sub
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot "
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql += " and fLineandsh ='" & CB1.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            '  ds.Tables("yearlyp").Columns(2).ColumnName = " Line"
            dg1.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _RefreshTotal() As Boolean
        Try

            Dim sql As String = ""

            sql += "SELECT fQty FROM  PlanforMonth "

            'sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   where fdate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            'sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PlanforMonth")
            ds.Tables("PlanforMonth").Columns(0).ColumnName = " Total_Plan "
        
            dg6.DataSource = ds.Tables("PlanforMonth")

            Return True
        Catch ex As Exception

        End Try

    End Function
    Private Function _RefreshDiff() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fQty- sum(Expr1)as diff   FROM Diff"
            sql += "   where fPDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            sql += " GROUP BY  fdate, fQty, fMonthName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Diff")
            ds.Tables("Diff").Columns(0).ColumnName = " difference_Plan "
            DG11.DataSource = ds.Tables("Diff")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshActu() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fLCDBarcode)FROM  yearlyp"
            sql += "   where fPDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Actually_plan "
            DGA.DataSource = ds.Tables("yearlyp")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1552() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLineandsh ='" & CB3.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            dg3.DataSource = ds.Tables("yearlyp")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1551() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLineandsh ='" & CB2.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("yearlyp")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1554() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql += " and fLineandsh ='" & CB4.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            'ds.Tables("yearlyp").Columns(2).ColumnName = " Line"
            dg4.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh1555() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql += " and fLineandsh ='" & CB5.Text & "'"
            sql += " GROUP BY fLCDModelName,fLineandsh "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            '     ds.Tables("yearlyp").Columns(2).ColumnName = " Line"
            dg5.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    'Private Function _Refresh1556() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
    '        sql += " FROM yearlyp "
    '        sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
    '        ' sql += " and fShift=" & txtshift.Text & ""
    '        sql += " and fLineandsh ='" & CB6.Text & "'"
    '        sql += " GROUP BY fLCDModelName,fLineandsh "
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "yearlyp")
    '        ds.Tables("yearlyp").Columns(0).ColumnName = "Model Name"
    '        ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
    '        ' ds.Tables("yearlyp").Columns(2).ColumnName = " Line"
    '        dg6.DataSource = ds.Tables("yearlyp")

    '        Return True

    '    Catch ex As Exception

    '    End Try

    'End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh155()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        _Refresh1551()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        _Refresh1552()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        _Refresh1554()
        _RefreshTotal()
        _RefreshDiff()
        _RefreshActu()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        _Refresh1555()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        '   _Refresh1556()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CB6_Leave(sender As Object, e As EventArgs)
        'Label16.Text = CB6.Text
    End Sub

    Private Sub CB6_SelectedIndexChanged(sender As Object, e As EventArgs)

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _RefreshTotal()
        _RefreshDiff()
        _RefreshActu()
        GroupBox9.Visible = False
        GroupBox3.Visible = True
        GroupBox7.Visible = True
        GroupBox8.Visible = True
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub
End Class