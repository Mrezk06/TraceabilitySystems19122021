Imports TEVPBarcode.sher
Public Class frmCookerQualityQuery


    ' Public Class frmQueryNewtest

    Private Sub frmQueryNewtest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    Dim sql As String = ""
        '    sql += " SELECT  fLCDModelName FROM   LCDTVModels "
        '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        '    Dim ds As New DataSet
        '    ds.Tables.Clear()
        '    da.Fill(ds, "LCDTVModels")
        '    cmb_Pcode.DataSource = ds.Tables(0)

        '    cmb_Pcode.DisplayMember = "fLCDModelName"
        '    cmb_Pcode.Sorted = True
        'Catch ex As Exception
        'End Try
        Try
            Dim sql As String = ""
            sql += "SELECT CModelName FROM CModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "CModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.DisplayMember = "CModelName"
            cmb_Pcode.Sorted = True
            _Refresh315()
            cmb_Pcode.Focus()
        Catch ex As Exception

        End Try

        cmb_Pcode.Text = ""
    End Sub
    Private Function _Refreshee15() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU1"
            'sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " where fLCDBarcode='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU1").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU1").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU1").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU1").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU1").Columns(5).ColumnName = "States"
            ds.Tables("QAFU1").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU1").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU1").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU1").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU1").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU1").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU1").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU1").Columns(5).ColumnName = "States"
            ds.Tables("QAFU1").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU1").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU1").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315t() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode ) FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh3151d() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU1").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU1").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU1").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU1").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU1").Columns(5).ColumnName = "States"
            ds.Tables("QAFU1").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU1").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU1").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315t1d() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode ) FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Function _Refresh3151d1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU1").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU1").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU1").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU1").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU1").Columns(5).ColumnName = "States"
            ds.Tables("QAFU1").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU1").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU1").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315t1d1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode ) FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU1")
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
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU1").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU1").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU1").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU1").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU1").Columns(5).ColumnName = "States"
            ds.Tables("QAFU1").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU1").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU1").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315t1d12() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode ) FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr2() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"

            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU1").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU1").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU1").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU1").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU1").Columns(5).ColumnName = "States"
            ds.Tables("QAFU1").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU1").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU1").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr1() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fLCDBarcode ) FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"

            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refr21() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            ' sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU1").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU1").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU1").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU1").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU1").Columns(5).ColumnName = "States"
            ds.Tables("QAFU1").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU1").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU1").Columns(8).ColumnName = "Notes"
            DG1.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refr11() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count(fLCDBarcode ) FROM QAFU1"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            '   sql += " and fLineAndShift='" & ComboBox1.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Sum "

            dg3.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnModel_Click(sender As Object, e As EventArgs) Handles btnModel.Click
        _Refreshee15()
    End Sub

    Private Sub txtlcdbarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlcdbarcode.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtlcdbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtlcdbarcode.TextChanged

    End Sub
End Class