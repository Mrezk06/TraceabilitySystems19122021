Imports TEVPBarcode.sher
Public Class frmQueryNewtest

    Private Sub frmQueryNewtest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Function _Refreshee15() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU"
            'sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " where fLCDBarcode='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU").Columns(5).ColumnName = "States"
            ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU").Columns(5).ColumnName = "States"
            ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315t() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode ) FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh3151d() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU").Columns(5).ColumnName = "States"
            ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315t1d() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode ) FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Function _Refresh3151d1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU").Columns(5).ColumnName = "States"
            ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315t1d1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode ) FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ComboBox1.Text = "" And cmb_Pcode.Text = "" And txtstat.Text = "" Then
            _Refresh315()
            _Refresh315t()
        ElseIf txtstat.Text = "" And ComboBox1.Text = "" Then
            _Refresh3151d()
            _Refresh315t1d()

        ElseIf ComboBox1.Text = "" And cmb_Pcode.Text = "" Then
            _Refr2()
            _Refr1()
        ElseIf ComboBox1.Text = "" Then
            _Refr21()
            _Refr11()
        ElseIf txtstat.Text = "" Then
            _Refresh3151d1()
            _Refresh315t1d1()
        Else
            _Refresh315t1d12()
            ' _Refresh315t1d12()
            _Refresh3151d12()

        End If

    End Sub
    Private Function _Refresh3151d12() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU").Columns(5).ColumnName = "States"
            ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315t1d12() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode ) FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr2() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
          
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU").Columns(5).ColumnName = "States"
            ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fLCDBarcode ) FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
       
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refr21() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            ' sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU").Columns(5).ColumnName = "States"
            ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr11() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fLCDBarcode ) FROM QAFU"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            '   sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnModel_Click(sender As Object, e As EventArgs) Handles btnModel.Click
        _Refreshee15()
    End Sub
End Class