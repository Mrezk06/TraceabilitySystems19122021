Imports System.Collections.ObjectModel
Imports System.Windows.Forms.DataVisualization.Charting
Imports TEVPBarcode.sher
Imports System.Data.SqlClient
'Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmCookerTimeStudyQuery

    Private Sub frmCookerTimeStudyQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function _Refr21f() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate,ftime,fUserCode,fFectoryName,fType ,fTypeDisc,fNameProcess,fModelName,fTimeBalnce FROM TimeStudy"
            sql += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fUserCode='" & txtcodeUse.Text & "'"
            sql += " and fFectoryName='" & txtFN.Text & "'"
            sql += " and fNameProcess='" & txtPN.Text & "'"
            sql += " and fModelName='" & txtMN.Text & "'"
            ' sql += " and fFectoryName='" & ComboBox1.Text & "'"
            '  sql += " and fNameProcess='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TimeStudy")
            ds.Tables("TimeStudy").Columns(0).ColumnName = "Date "
            ds.Tables("TimeStudy").Columns(1).ColumnName = "Time"
            ds.Tables("TimeStudy").Columns(2).ColumnName = "User Code "
            ds.Tables("TimeStudy").Columns(3).ColumnName = "Fectory Name"
            ds.Tables("TimeStudy").Columns(4).ColumnName = "Type"
            ds.Tables("TimeStudy").Columns(5).ColumnName = " description Type"
            ds.Tables("TimeStudy").Columns(6).ColumnName = "Name Process "
            ds.Tables("TimeStudy").Columns(7).ColumnName = "Model Name"
            ds.Tables("TimeStudy").Columns(8).ColumnName = "Time Balance"
            dg9.DataSource = ds.Tables("TimeStudy")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refr21fw() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate,ftime,fUserCode,fFectoryName,fType ,fTypeDisc,fNameProcess,fModelName,fTimeBalnce FROM TimeStudy"
            sql += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fUserCode='" & txtcodeUse.Text & "'"
            'sql += " and fFectoryName='" & txtFN.Text & "'"
            'sql += " and fNameProcess='" & txtPN.Text & "'"
            'sql += " and fModelName='" & txtMN.Text & "'"
            ' sql += " and fFectoryName='" & ComboBox1.Text & "'"
            '  sql += " and fNameProcess='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TimeStudy")
            ds.Tables("TimeStudy").Columns(0).ColumnName = "Date "
            ds.Tables("TimeStudy").Columns(1).ColumnName = "Time"
            ds.Tables("TimeStudy").Columns(2).ColumnName = "User Code "
            ds.Tables("TimeStudy").Columns(3).ColumnName = "Fectory Name"
            ds.Tables("TimeStudy").Columns(4).ColumnName = "Type"
            ds.Tables("TimeStudy").Columns(5).ColumnName = " description Type"
            ds.Tables("TimeStudy").Columns(6).ColumnName = "Name Process "
            ds.Tables("TimeStudy").Columns(7).ColumnName = "Model Name"
            ds.Tables("TimeStudy").Columns(8).ColumnName = "Time Balance"
            dg9.DataSource = ds.Tables("TimeStudy")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr211D11x() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate,fUserCode,fFectoryName,fTypeDisc,fNameProcess,fModelName,CountTS_DATA,SumTS_DATA,AVG_DATA,max_DATA,min_DATA FROM timestudyshow1"
            sql += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "timestudyshow1")
            ds.Tables("timestudyshow1").Columns(0).ColumnName = "Date "
            ds.Tables("timestudyshow1").Columns(1).ColumnName = "User Code "
            ds.Tables("timestudyshow1").Columns(2).ColumnName = "Fectory Name"
            ds.Tables("timestudyshow1").Columns(3).ColumnName = "Type"
            ds.Tables("timestudyshow1").Columns(4).ColumnName = "Name Process "
            ds.Tables("timestudyshow1").Columns(5).ColumnName = "Model Name"
            ds.Tables("timestudyshow1").Columns(6).ColumnName = "count read"
            ds.Tables("timestudyshow1").Columns(7).ColumnName = "sum all read"
            ds.Tables("timestudyshow1").Columns(8).ColumnName = "Avg"
            ds.Tables("timestudyshow1").Columns(9).ColumnName = "max"
            ds.Tables("timestudyshow1").Columns(10).ColumnName = "min"
            dg9.DataSource = ds.Tables("timestudyshow1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refr21f()

        Try
            '  _Refr211D()
            Dim sql As String = "select fTypeDisc,AVG_DATA,max_DATA,min_DATA  FROM timestudyshow1"
            sql += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fFectoryName='" & txtFN.Text & "'"
            sql += " and fNameProcess='" & txtPN.Text & "'"
            sql += " and fModelName='" & txtMN.Text & "'"
            '  sql += " and fFectoryName='" & ComboBox1.Text & "'"
            Dim oData As New SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            Dim oCmd As New SqlCommand(sql, cn)
            cn.Open()
            oData.Fill(ds, "timestudyshow1")
            cn.Close()
            Chart1.DataSource = ds.Tables("timestudyshow1")
            Dim Series1 As Series = Chart1.Series("Series1")
            Dim Series2 As Series = Chart1.Series("Series2")
            Dim Series3 As Series = Chart1.Series("Series3")
            Series1.Name = "AVG "
            Series2.Name = "Max"
            Series3.Name = "Min"
            Chart1.Series(Series1.Name).XValueMember = "fTypeDisc"
            Chart1.Series(Series1.Name).YValueMembers = "AVG_DATA"
            Chart1.Series(Series2.Name).YValueMembers = "max_DATA"
            Chart1.Series(Series3.Name).YValueMembers = "min_DATA"
            Chart1.Size = New System.Drawing.Size(472, 300)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd3 As New SqlCommand
            Dim sql As String = "select fFectoryName,AVG_DATA  FROM timestudyshow1"
            sql += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            Dim oData As New SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            Dim oCmd As New SqlCommand(sql, cn)
            cn.Open()
            oData.Fill(ds, "timestudyshow1")
            cn.Close()
            Chart1.DataSource = ds.Tables("timestudyshow1")
            Dim Series1 As Series = Chart1.Series("Series1")
            Series1.Name = "Time Study"
            Chart1.Series(Series1.Name).XValueMember = "fFectoryName"
            Chart1.Series(Series1.Name).YValueMembers = "AVG_DATA"
            Chart1.Size = New System.Drawing.Size(472, 300)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim sql As String = "select fTypeDisc,fTimeBalnce  FROM TimeStudy"
            sql += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            Dim oData As New SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            Dim oCmd As New SqlCommand(sql, cn)
            cn.Open()
            oData.Fill(ds, "TimeStudy")
            cn.Close()
            Chart1.DataSource = ds.Tables("TimeStudy")
            Dim Series1 As Series = Chart1.Series("Series1")
            Series1.Name = "Time Study"
            Chart1.Series(Series1.Name).XValueMember = "fTypeDisc"
            Chart1.Series(Series1.Name).YValueMembers = "fTimeBalnce"
            Chart1.Size = New System.Drawing.Size(472, 300)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' _Refr211D1()
            _Refr21fw()
            Dim sql As String = "select fTypeDisc,AVG_DATA,max_DATA,min_DATA  FROM timestudyshow1"
            sql += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            Dim oData As New SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            Dim oCmd As New SqlCommand(sql, cn)
            cn.Open()
            oData.Fill(ds, "timestudyshow1")
            cn.Close()
            Chart1.DataSource = ds.Tables("timestudyshow1")
            Dim Series1 As Series = Chart1.Series("Series1")
            Dim Series2 As Series = Chart1.Series("Series2")
            Dim Series3 As Series = Chart1.Series("Series3")
            Series1.Name = "AVG "
            Series2.Name = "Max"
            Series3.Name = "Min"
            Chart1.Series(Series1.Name).XValueMember = "fTypeDisc"
            Chart1.Series(Series1.Name).YValueMembers = "AVG_DATA"
            Chart1.Series(Series2.Name).YValueMembers = "max_DATA"
            Chart1.Series(Series3.Name).YValueMembers = "min_DATA"
            Chart1.Size = New System.Drawing.Size(472, 300)
            '472, 300
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            ' _Refr211D1()
            _Refr211D11x()
            Dim sql As String = "select fTypeDisc,AVG_DATA,max_DATA,min_DATA  FROM timestudyshow1"
            sql += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            Dim oData As New SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            Dim oCmd As New SqlCommand(sql, cn)
            cn.Open()
            oData.Fill(ds, "timestudyshow1")
            cn.Close()
            Chart1.DataSource = ds.Tables("timestudyshow1")
            Dim Series1 As Series = Chart1.Series("Series1")
            Dim Series2 As Series = Chart1.Series("Series2")
            Dim Series3 As Series = Chart1.Series("Series3")
            ' Dim Series2 As Series = Chart1.Series("Series2")
            ' Dim Series3 As Series = Chart1.Series("Series3")
            'Dim Series4 As Series = Chart1.Series("Series4")
            'Dim Series5 As Series = Chart1.Series("Series5")
            'Dim Series6 As Series = Chart1.Series("Series6")
            ' Dim Series3 As Series = Chart1.Series("Series3")
            Series1.Name = "AVG "
            Series2.Name = "Max"
            Series3.Name = "Min"
            Chart1.Series(Series1.Name).XValueMember = "fTypeDisc"
            Chart1.Series(Series1.Name).YValueMembers = "AVG_DATA"
            Chart1.Series(Series2.Name).YValueMembers = "max_DATA"
            Chart1.Series(Series3.Name).YValueMembers = "min_DATA"
            Chart1.Size = New System.Drawing.Size(472, 300)
            '472, 300
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcodeUse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodeUse.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcodeUse_TextChanged(sender As Object, e As EventArgs) Handles txtcodeUse.TextChanged

    End Sub
End Class