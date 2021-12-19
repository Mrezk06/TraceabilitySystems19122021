Imports TEVPBarcode.sher
Public Class frmQuerytestforquallity

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub frmQuerytestforquallity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName FROM   LCDTVModels "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")

            txtModel.DataSource = ds.Tables(0)
            'cmb_Pcode.ValueMember = "fLCDSetID"
            txtModel.DisplayMember = "fLCDModelName"
            txtModel.Sorted = True

            '_Refresh1()

        Catch ex As Exception

        End Try
        txtModel.Text = ""
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fNote FROM QAFU"
            ' sql += " FROM Output"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"

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
            ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3151() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode)  FROM QAFU"
            ' sql += " FROM Output"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = " SUM_Pro "
            'ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            'ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            'ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            'ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            'ds.Tables("QAFU").Columns(5).ColumnName = "States"
            'ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            'ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG2.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3152() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fNote FROM QAFU"
            ' sql += " FROM Output"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & txtModel.Text & "'"
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
            ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh31512() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode)  FROM QAFU"
            ' sql += " FROM Output"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & txtModel.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = " SUM_Pro "
            'ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            'ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            'ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            'ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            'ds.Tables("QAFU").Columns(5).ColumnName = "States"
            'ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            'ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG2.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh31523() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fNote FROM QAFU"
            ' sql += " FROM Output"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & txtModel.Text & "'"
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
            ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315123() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode)  FROM QAFU"
            ' sql += " FROM Output"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & txtModel.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = " SUM_Pro "
            'ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            'ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            'ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            'ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            'ds.Tables("QAFU").Columns(5).ColumnName = "States"
            'ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            'ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG2.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315234() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fNote FROM QAFU"
            ' sql += " FROM Output"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & txtModel.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            sql += " and fLineAndShift='" & txtline.Text & "'"
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
            ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3151234() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode)  FROM QAFU"
            ' sql += " FROM Output"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & txtModel.Text & "'"
            sql += " and fStates='" & txtstat.Text & "'"
            sql += " and fLineAndShift='" & txtline.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = " SUM_Pro "
            'ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            'ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            'ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            'ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            'ds.Tables("QAFU").Columns(5).ColumnName = "States"
            'ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            'ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG2.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtModel.Text = "" And txtline.Text = "" And txtstat.Text = "" Then
            _Refresh315()
            _Refresh3151()
        ElseIf txtline.Text = "" And txtstat.Text = "" Then
            _Refresh3152()
            _Refresh31512()
        ElseIf txtline.Text = "" Then
            _Refresh31523()
            _Refresh315123()

        Else
            _Refresh315234()
            _Refresh3151234()

        End If



    End Sub

    Private Sub btnModel_Click(sender As Object, e As EventArgs) Handles btnModel.Click

        If txtlcdbarcode.Text.Length <= 8 Then

            _RefreshSapC()
            _RefreshSapT()

        ElseIf txtlcdbarcode.Text.Length <= 14 Then
            _RefreshSerialT()
            _RefreshSerilC()
            '_Refresh315ldb()
        Else

            MsgBox("please Entry Your Data")

        End If
    End Sub
    Private Function _RefreshSerilC() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate,fPtime ,fLCDBarcode,fModel  ,fLineAndShift,fStates ,fSapL,fNote FROM quality_IM"
            'sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " WHERE fLCDBarcode='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "quality_IM")
            ds.Tables("quality_IM").Columns(0).ColumnName = "Date "
            ds.Tables("quality_IM").Columns(1).ColumnName = "Time"
            ds.Tables("quality_IM").Columns(2).ColumnName = "Barcode "
            ds.Tables("quality_IM").Columns(3).ColumnName = "Model"
            ds.Tables("quality_IM").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("quality_IM").Columns(5).ColumnName = "States"
            ds.Tables("quality_IM").Columns(6).ColumnName = "SAP_Laber "
            ds.Tables("quality_IM").Columns(7).ColumnName = "Notes"
            DG.DataSource = ds.Tables("quality_IM")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshSerialT() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fNameP,fLCDBarcode,fStates,fBalanc,fNote FROM quality_ID"
            sql += " WHERE fLCDBarcode='" & txtlcdbarcode.Text & "'"
            sql += " and fStates<>'---'  "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "quality_ID")
            ds.Tables("quality_ID").Columns(0).ColumnName = "Name Test"
            ds.Tables("quality_ID").Columns(1).ColumnName = "Barcode "
            ds.Tables("quality_ID").Columns(2).ColumnName = "States"
            ds.Tables("quality_ID").Columns(3).ColumnName = "Value "
            ds.Tables("quality_ID").Columns(4).ColumnName = "Note"
            DG1.DataSource = ds.Tables("quality_ID")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshSapT() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate,fPtime ,fLCDBarcode,fModel  ,fLineAndShift,fStates ,fSapL,fNote FROM quality_IM"
            sql += " WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += " and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fSapL='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "quality_IM")
            ds.Tables("quality_IM").Columns(0).ColumnName = "Date "
            ds.Tables("quality_IM").Columns(1).ColumnName = "Time"
            ds.Tables("quality_IM").Columns(2).ColumnName = "Barcode "
            ds.Tables("quality_IM").Columns(3).ColumnName = "Model"
            ds.Tables("quality_IM").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("quality_IM").Columns(5).ColumnName = "States"
            ds.Tables("quality_IM").Columns(6).ColumnName = "SAP_Laber "
            ds.Tables("quality_IM").Columns(7).ColumnName = "Notes"
            DG.DataSource = ds.Tables("quality_IM")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshSapC() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT count (fLCDBarcode)  FROM quality_IM"
            sql += " WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += " and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fSapL='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "quality_IM")
            ds.Tables("quality_IM").Columns(0).ColumnName = " SUM_Pro "
            DG2.DataSource = ds.Tables("quality_IM")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        ' txtlcdbarcode.Text = DG2.Item(2, DG.CurrentRow.Index).Value
    End Sub
    
   
    Private Sub DG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellContentClick

    End Sub
End Class