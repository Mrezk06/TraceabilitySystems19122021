Imports TEVPBarcode.sher
Public Class frmCookerOutPutQuery



    Private Sub Heater_Step_Three_Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        Try
            Dim sql As String = ""
            sql += "SELECT CModelName FROM CModels"
            '  sql += " where fLine_Name ='EWH1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")

            btnPCode.DataSource = ds.Tables(0)
            ' cmb_Pcode.ValueMember = "CSetID"
            ' cmb_Pcode.ValueMember = "model_S_Power"
            btnPCode.DisplayMember = "CModelName"
            btnPCode.Sorted = True

            _Refresh1()
        Catch ex As Exception

        End Try
        Timer1.Enabled = True
        btnPCode.Text = ""


        For I = 0 To dg9.Rows.Count - 1
            If dg9.Rows(I).Cells(0).Value = "ML_A_1" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_A_2" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_A_3" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_A_4" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_A_5" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If

            If dg9.Rows(I).Cells(0).Value = "ML_B_1" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_B_2" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_B_3" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_B_4" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_B_5" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If


            If dg9.Rows(I).Cells(0).Value = "ML_C_1" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_C_2" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_C_3" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_C_4" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_C_5" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
        Next

    End Sub
    Private Function _Refresh001() As Boolean
        Try


            Dim sql As String = ""

            'sql += " SELECT count(H_Heater_Code) FROM  barcode.dbo.Heater_registration_Two "
            'sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "Heater_registration_Two")
            'ds.Tables("Heater_registration_Two").Columns(0).ColumnName = " الكمية "
            'dg6.DataSource = ds.Tables("Heater_registration_Two")
            'Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  C_Output_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("C_Output_Production")
            dg6.AllowUserToAddRows = False
            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  C_Output_Production "
            sql += " where CBarcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("C_Output_Production")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""

            sql += " SELECT count(CBarcode) FROM  C_Output_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("C_Output_Production")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try


            

            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  C_Output_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and Ctime>='" & txttotime.Text & "'"
            sql += "   and Ctime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("C_Output_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("C_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("C_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("C_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("C_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ds.Tables("C_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            dg.DataSource = ds.Tables("C_Output_Production")
            dg.AllowUserToAddRows = False
            Return True


            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  C_Output_Production "
            sql += "   where CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("C_Output_Production").Columns(1).ColumnName = " الوقت "
            ds.Tables("C_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("C_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("C_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("C_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ds.Tables("C_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            dg.DataSource = ds.Tables("C_Output_Production")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  C_Output_Production "
            sql += " where CBarcode ='" & txtFATSERIAL.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("C_Output_Production").Columns(1).ColumnName = " الوقت "

            ds.Tables("C_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("C_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("C_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("C_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ' ds.Tables("TW_V_new").Columns(5).ColumnName = "اسم المسئول"
            ds.Tables("C_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            '  ds.Tables("Heater_registration_Two").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("C_Output_Production")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try



    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnsearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Refresh1()
        _Refresh511()

    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Refresh111()
        _Refresh001()

    End Sub

    Private Sub btnsearchModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _Refresh11()
        _Refresh011()
    End Sub
    'Private Function _Refresh119() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM  barcode.dbo.DailyP "
    '        sql += " where fLCDModelName ='" & btnPCode.Text & "'"
    '        sql += " and fLCDPline ='" & cbl.Text & "'"
    '        sql += "   and fPDate= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and fPtime>='" & txttotime.Text & "'"
    '        sql += "   and fPtime<= '" & txtfromTime.Text & "'"
    '        'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "DailyP")
    '        ds.Tables("DailyP").Columns(0).ColumnName = " Date "
    '        ds.Tables("DailyP").Columns(1).ColumnName = " time "
    '        ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
    '        ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
    '        ds.Tables("DailyP").Columns(4).ColumnName = "line"
    '        ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
    '        ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
    '        dg.DataSource = ds.Tables("DailyP")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh119() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  C_Output_Production "
            sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += " and C_Line_Shift ='" & cbl.Text & "'"
            sql += " and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and Ctime>='" & txttotime.Text & "'"
            sql += "  and Ctime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("C_Output_Production").Columns(1).ColumnName = " الوقت "

            ds.Tables("C_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("C_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("C_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("C_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ' ds.Tables("TW_V_new").Columns(5).ColumnName = "اسم المسئول"
            ds.Tables("C_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            '  ds.Tables("Heater_registration_Two").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("C_Output_Production")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmReport
            Dim rpt As New rptDate

            rpt.SetDatabaseLogon("sa", "201015")

            rpt.RecordSelectionFormula = "{Heater_registration_Two.H_Shift_Line}='2'"

            '  rpt.RecordSelectionFormula = "  {DESIGNER.fcurrent} ='" & btnPCode.Text & "'"
            'rpt.RecordSelectionFormula += " and  {yearlyp.fPDate}>= # " & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "#"
            'rpt.RecordSelectionFormula += " and {yearlyp.fPDate}<= # " & Format(dtpTODATE.Value, "yyyy-MM-dd") & "#"



            'frm.crv.ReportSource = rpt
            'frm.Show()
            'Me.Hide()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        'Try
        '    Dim sql As String = ""
        '    sql += " SELECT  Model_Name, Model_control FROM   Heater_ModelName "
        '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        '    Dim ds As New DataSet
        '    ds.Tables.Clear()
        '    da.Fill(ds, "Heater_ModelName")
        '    btnPCode.DataSource = ds.Tables(0)
        '    '  cmb_Pcode.ValueMember = "fLCDSetID"
        '    btnPCode.DisplayMember = "Heater_ModelName"
        '    btnPCode.Sorted = True
        '    _Refresh1()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Function _Refresh0119() As Boolean
        Try
            'Dim sql As String = ""
            'sql += " SELECT count(H_Heater_Code) FROM TW_V_new "
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  C_Output_Production "
            sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += " and C_Line_Shift ='" & cbl.Text & "'"
            sql += " and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and Ctime>='" & txttotime.Text & "'"
            sql += "  and Ctime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " الكمية "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("C_Output_Production")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh01GG() As Boolean
        Try
            'Dim sql As String = ""
            'sql += " SELECT count(H_Heater_Code) FROM TW_V_new "
            Dim sql As String = ""
            sql += " SELECT count(CBarcode) FROM  C_Output_Production "

            sql += " where C_Line_Shift LIKE '%" & cbl.Text & "%'"
            sql += " and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and Ctime>='" & txttotime.Text & "'"
            sql += "  and Ctime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " الكمية "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("C_Output_Production")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        _Refresh0119()
        _Refresh119()
    End Sub

    Private Sub cbl_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSEARCH_Click_1(sender As Object, e As EventArgs) Handles btnSEARCH.Click

        If txttotime.Text = "" And txtfromTime.Text = "" Then
            _Refresh11()
            _Refresh011()
        Else

            _Refresh001()
            _Refresh111()
        End If



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        _Refresh0119()
        _Refresh119()
        ' _Refresh111()
    End Sub

    Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
        _Refresh1()
        _Refresh511()
    End Sub

    Private Sub btnsearchModel_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        btnPCode.Text = dg9.Item(1, dg9.CurrentRow.Index).Value
    End Sub

    Private Function _Refresh155() As Boolean
        Try
          

            Dim sql As String = ""
            sql += " SELECT C_Line_Shift,CModelName, count(CModelName) AS tot"
            sql += " FROM C_Output_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and H_Shift_Line ='" & cbl.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY CModelName,C_Line_Shift "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = "الخط"
            ds.Tables("C_Output_Production").Columns(1).ColumnName = "الموديل"
            ds.Tables("C_Output_Production").Columns(2).ColumnName = " الكمية"
            dg9.DataSource = ds.Tables("C_Output_Production")
            dg9.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs) Handles cbl.Leave
        _Refresh155()
    End Sub

    Private Sub btnPCode_Leave(sender As Object, e As EventArgs) Handles btnPCode.Leave

    End Sub

    Private Sub btnPCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles btnPCode.SelectedIndexChanged

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        '   btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
    End Sub

    Private Sub dg_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        '  btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
        ' txtS_Laber.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        'btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh155()

        'For I = 0 To dg9.Rows.Count - 1
        '    If dg9.Rows(I).Cells(0).Value = "ML_A_1" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_A_2" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_A_3" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_A_4" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_A_5" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If

        '    If dg9.Rows(I).Cells(0).Value = "ML_B_1" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_B_2" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_B_3" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_B_4" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_B_5" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If


        '    If dg9.Rows(I).Cells(0).Value = "ML_C_1" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_C_2" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_C_3" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_C_4" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        '    If dg9.Rows(I).Cells(0).Value = "ML_C_5" Then
        '        dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
        '    End If
        'Next
    End Sub

    Private Sub txtFATSERIAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFATSERIAL.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFATSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh01GG()
        _Refresh11fff()
    End Sub

    Private Function _Refresh11fff() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT CDate,Ctime,CBarcode,CEAN_Code,CModelName,C_Line_Shift,CSapUser FROM  C_Output_Production "
            '' sql += " where CModelName ='" & btnPCode.Text & "'"
            sql += " where C_Line_Shift Like'%" & cbl.Text & "%'"
            sql += " and CDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and CDate<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and Ctime>='" & txttotime.Text & "'"
            sql += "  and Ctime<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " التاريخ "
            ds.Tables("C_Output_Production").Columns(1).ColumnName = " الوقت "

            ds.Tables("C_Output_Production").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("C_Output_Production").Columns(3).ColumnName = " الايان كود"
            ds.Tables("C_Output_Production").Columns(4).ColumnName = " الموديل"
            ds.Tables("C_Output_Production").Columns(5).ColumnName = "الخط والورديه"
            ' ds.Tables("TW_V_new").Columns(5).ColumnName = "اسم المسئول"
            ds.Tables("C_Output_Production").Columns(6).ColumnName = " رقم ساب المسئول "
            '  ds.Tables("Heater_registration_Two").Columns(6).ColumnName = "Qty"
            dg.DataSource = ds.Tables("C_Output_Production")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    '' Private Sub dg9_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg9.CellContentClick
    Private Sub dg9_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dg9.CellFormatting

        For I = 0 To dg9.Rows.Count - 1
            If dg9.Rows(I).Cells(0).Value = "ML_A_1" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_A_2" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_A_3" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_A_4" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_A_5" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If

            If dg9.Rows(I).Cells(0).Value = "ML_B_1" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_B_2" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_B_3" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_B_4" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_B_5" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If


            If dg9.Rows(I).Cells(0).Value = "ML_C_1" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_C_2" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_C_3" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_C_4" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
            If dg9.Rows(I).Cells(0).Value = "ML_C_5" Then
                dg9.Rows(I).DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub dg9_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg9.CellContentClick

    End Sub
End Class