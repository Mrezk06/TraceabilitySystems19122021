Imports TEVPBarcode.sher
Public Class Heater_out_put



    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT Model_Name ,count(Model_Name)"
            sql += " FROM MVData2  "
            sql += " WHERE H_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and H_Shift_Line='" & txtshift.Text & "'"
            '    sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " GROUP BY Model_Name "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "MVData2")
            ds.Tables("MVData2").Columns(0).ColumnName = "الموديل "
            ds.Tables("MVData2").Columns(1).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("MVData2")
            Return True

        Catch ex As Exception

        End Try

    End Function

    Private Function _Refresh1777() As Boolean
        Try
            'Dim ffff As String
            Dim sql As String = ""
            sql += " SELECT count(H_Model_Name) AS tot"
            sql += " FROM Heater_registration_Three "
            sql += " WHERE H_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and H_Shift_Line=" & txtshift.Text & ""
            '    sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " GROUP BY H_Model_Name "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_ModelName")

            cmb_Pcode.DataSource = ds.Tables(0)
            ' cmb_Pcode.ValueMember = "Model_control"
            ' cmb_Pcode.ValueMember = "model_S_Power"
            cmb_Pcode.DisplayMember = "tot"
            cmb_Pcode.Sorted = True

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Sub txtFATSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged

    End Sub

    Private Sub txtFATSERIAL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                ' If txtFATSERIAL.Text.Length < 17 Then Exit Sub
                'Dim dsMax1 As New DataSet
                'Dim Sql = "Select H_Heater_Code from Heater_registration_Two where H_Heater_Code='" & txtBarcodeOne.Text & "'"
                ''   Sql1 += " and model_S_Power ='" & txtPARTSSERIAL.Text & "'"
                '' Sql += " and fNameL='" & ComboBox2.Text & "'"
                'Dim da1 As New SqlClient.SqlDataAdapter(Sql, cn)
                'dsMax1.Tables.Clear()
                'da1.Fill(dsMax1)
                'If dsMax1.Tables(0).Rows.Count < 1 Then
                '    lbl_Msg.ForeColor = Color.Red
                '    lbl_Msg.Text = "هذا الباركود لم يتم تسجيله فى الخطوة السابقة"
                '    txtBarcodeOne.Focus()
                '    txtBarcodeOne.SelectAll()
                '    Exit Sub
                'End If


                If e.KeyCode = Keys.Enter Then

                    ' Dim Sql As String
                    Dim dsMax As New DataSet
                    Dim Sql1 = "Select H_Heater_Code from Heater_registration_Three where H_Heater_Code='" & txtBarcodeOne.Text & "'"
                    Dim da As New SqlClient.SqlDataAdapter(Sql1, cn)
                    dsMax.Tables.Clear()
                    da.Fill(dsMax)
                    If dsMax.Tables(0).Rows.Count > 0 Then
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "الباركود تم تسجيله من قبل"
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                        Exit Sub

                    End If
                    '        If txtBarcodeOne.Text.Length = 17 Then
                    '            Dim Barcode_Part(6) As String
                    '            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                    '            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 8)
                    '            Barcode_Part(2) = txtBarcodeOne.Text.Substring(13, 4)
                    '            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)
                    '            'Barcode_Part(4) = txtBarcodeOne.Text.Substring(7, 1)
                    '            'Barcode_Part(5) = txtBarcodeOne.Text.Substring(8, 4)
                    '            'Barcode_Part(6) = txtBarcodeOne.Text.Substring(12, 2)

                    '            Dim dsMax10 As New DataSet
                    '            Dim Sql10 = " SELECT  Model_control FROM Heater_ModelName  where  Model_control ='" & Barcode_Part(2) & "'"
                    '            Dim da10 As New SqlClient.SqlDataAdapter(Sql10, cn)
                    '            dsMax10.Tables.Clear()
                    '            da10.Fill(dsMax10)
                    '            If dsMax10.Tables(0).Rows.Count < 1 Then
                    '                lbl_Msg.Text = "باركود الضمان غير تابع لأى الموديل "
                    '                lbl_Msg.ForeColor = Color.Yellow
                    '                txtBarcodeOne.Focus()
                    '                txtBarcodeOne.SelectAll()
                    '            Else


                    '                lbl_Msg.ForeColor = Color.GreenYellow
                    '                lbl_Msg.Text = "تم تسجيل باركود الضمان"
                    '                'Label10.Text = cmb_Pcode.SelectedValue
                    '                txtBarcodeOne.Enabled = False
                    '                TxtheaterTwo.Enabled = True
                    '                TxtheaterTwo.Focus()
                    '                _Refresh1()
                    '            End If

                    '        ElseIf txtBarcodeOne.Text.Length = 18 Then

                    '            'Dim dsMax3 As New DataSet
                    '            'Dim Sql00 = "Select H_Heater_Code from Heater_registration_Three where H_Heater_Code='" & txtBarcodeOne.Text & "'"
                    '            'Dim da3 As New SqlClient.SqlDataAdapter(Sql00, cn)
                    '            'dsMax3.Tables.Clear()
                    '            'da3.Fill(dsMax3)
                    '            'If dsMax3.Tables(0).Rows.Count > 0 Then
                    '            '    lbl_Msg.ForeColor = Color.Red
                    '            '    lbl_Msg.Text = "الباركود تم تسجيله من قبل"
                    '            '    txtBarcodeOne.Focus()
                    '            '    txtBarcodeOne.SelectAll()
                    '            '    Exit Sub

                    '            'End If

                    '            Dim Barcode_Part1(6) As String
                    '            Barcode_Part1(0) = txtBarcodeOne.Text.Substring(0, 5)
                    '            Barcode_Part1(1) = txtBarcodeOne.Text.Substring(5, 8)
                    '            Barcode_Part1(2) = txtBarcodeOne.Text.Substring(13, 5)
                    '            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)
                    '            'Barcode_Part(4) = txtBarcodeOne.Text.Substring(7, 1)
                    '            'Barcode_Part(5) = txtBarcodeOne.Text.Substring(8, 4)
                    '            'Barcode_Part(6) = txtBarcodeOne.Text.Substring(12, 2)
                    '            Dim dsMax13 As New DataSet
                    '            Dim Sql13 = " SELECT  Model_control FROM Heater_ModelName  where  Model_control ='" & Barcode_Part1(2) & "'"
                    '            Dim da13 As New SqlClient.SqlDataAdapter(Sql13, cn)
                    '            dsMax13.Tables.Clear()
                    '            da13.Fill(dsMax1)
                    '            If dsMax13.Tables(0).Rows.Count < 1 Then
                    '                lbl_Msg.Text = "باركود الضمان غير تابع لأى الموديل "
                    '                lbl_Msg.ForeColor = Color.Yellow
                    '                txtBarcodeOne.Focus()
                    '                txtBarcodeOne.SelectAll()
                    '            Else


                    '                lbl_Msg.ForeColor = Color.GreenYellow
                    '                lbl_Msg.Text = "تم تسجيل باركود الضمان"
                    '                'Label10.Text = cmb_Pcode.SelectedValue
                    '                txtBarcodeOne.Enabled = False
                    '                TxtheaterTwo.Enabled = True
                    '                TxtheaterTwo.Focus()
                    '                _Refresh1()
                    '            End If
                    '        End If
                    '    End If
                    'End If
                    '
                    If e.KeyCode = Keys.Enter Then
                        If txtBarcodeOne.Text.Length = 17 Then
                            Dim Barcode_Part(6) As String
                            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 8)
                            Barcode_Part(2) = txtBarcodeOne.Text.Substring(13, 4)
                            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)
                            Dim dsMax18 As New DataSet
                            Dim Sql18 = " SELECT  Model_control FROM Heater_ModelName  where  Model_control ='" & Barcode_Part(2) & "'"
                            Dim da18 As New SqlClient.SqlDataAdapter(Sql18, cn)
                            dsMax18.Tables.Clear()
                            da18.Fill(dsMax18)
                            If dsMax18.Tables(0).Rows.Count < 1 Then
                                lbl_Msg.Text = "باركود الضمان غير تابع لأى الموديل "
                                lbl_Msg.ForeColor = Color.Yellow
                                txtBarcodeOne.Focus()
                                txtBarcodeOne.SelectAll()
                            Else


                                lbl_Msg.ForeColor = Color.GreenYellow
                                lbl_Msg.Text = "تم تسجيل باركود الضمان"
                                'Label10.Text = cmb_Pcode.SelectedValue
                                txtBarcodeOne.Enabled = False
                                TxtheaterTwo.Enabled = True
                                TxtheaterTwo.Focus()
                                _Refresh1()
                            End If

                        ElseIf txtBarcodeOne.Text.Length = 18 Then


                            Dim Barcode_Part(6) As String
                            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 8)
                            Barcode_Part(2) = txtBarcodeOne.Text.Substring(13, 5)
                            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)
                            'Barcode_Part(4) = txtBarcodeOne.Text.Substring(7, 1)
                            'Barcode_Part(5) = txtBarcodeOne.Text.Substring(8, 4)
                            Dim dsMax11 As New DataSet
                            Dim Sql11 = " SELECT  Model_control FROM Heater_ModelName  where  Model_control ='" & Barcode_Part(2) & "'"
                            Dim da11 As New SqlClient.SqlDataAdapter(Sql11, cn)
                            dsMax11.Tables.Clear()
                            da11.Fill(dsMax11)
                            If dsMax11.Tables(0).Rows.Count < 1 Then
                                lbl_Msg.Text = "باركود الضمان غير تابع لهذا الموديل "
                                lbl_Msg.ForeColor = Color.Yellow
                                txtBarcodeOne.Focus()
                                txtBarcodeOne.SelectAll()

                            Else


                                lbl_Msg.ForeColor = Color.GreenYellow
                                lbl_Msg.Text = "تم تسجيل باركود الضمان"
                                'Label10.Text = cmb_Pcode.SelectedValue
                                txtBarcodeOne.Enabled = False
                                TxtheaterTwo.Enabled = True
                                TxtheaterTwo.Focus()
                                _Refresh1()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue
            '   Label10.Text = cmb_Pcode.SelectedValue
            '   Label2.Text = cmb_Pcode.Text

            ' txtFATSERIAL.Enabled = True
            ' _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPARTSSERIAL_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPARTSSERIAL_KeyDown(sender As Object, e As KeyEventArgs)


    End Sub
    'Private Function _Refresh11() As Boolean
    '    Try

    '        Dim sql1 As String = " SELECT Model_Name,component_Name, component_Control,CONVERT(bit,0) as Found FROM Heater_component "
    '        'Dim sql1 As String = " SELECT fCompCode, fCompName ,CONVERT(bit,0) as Found   FROM [barcode].[dbo].[Material] "
    '        sql1 += " where Model_Name ='" & cmb_Pcode.Text & "'"

    '        sql1 += " and step_visual = 'Heater3' "
    '        Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Heater_component")
    '        'ds.Tables("Matrel").Columns(0).ColumnName = "الكود "
    '        ds.Tables("Heater_component").Columns(0).ColumnName = "Model"
    '        ds.Tables("Heater_component").Columns(1).ColumnName = "Name"
    '        ds.Tables("Heater_component").Columns(2).ColumnName = "part"
    '        dg1.DataSource = ds.Tables("Heater_component")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "اسم المسئول  "

            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmb_Pcode.Text = "" Or txtshift.Text = "" Or txtParts1.Text = "" Then

            MsgBox("من فضلك تأكد من ادخال الخط والموديل ")

            Exit Sub
        Else
            Try
                _Refresh315()
                '    _Refresh11()
                cmb_Pcode.Enabled = False
                ' txtline.Enabled = False
                txtshift.Enabled = False
                txtshift.Visible = False
                Label8.Visible = False
                txtParts1.Visible = False
                Label10.Visible = False
                btnStart.Visible = False
                txtBarcodeOne.Enabled = True
                TxtheaterTwo.Enabled = True
                TxtheaterThree.Enabled = True
                txtPARTSSERIAL.Enabled = True
                txtBarcodeOne.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        txtBarcodeOne.Text = ""
        txtPARTSSERIAL.Text = ""
        TxtheaterThree.Text = ""
        TxtheaterTwo.Text = ""
        txtBarcodeOne.Enabled = True
        txtPARTSSERIAL.Enabled = True
        TxtheaterThree.Enabled = True
        TxtheaterTwo.Enabled = True
        ' txtBarcodeThree.Enabled = True

        txtBarcodeOne.Focus()
    End Sub

    Private Sub txtPARTSSERIAL_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbl_Pcode_Value_Click(sender As Object, e As EventArgs) Handles lbl_Pcode_Value.Click

    End Sub

    Private Sub TxtheaterTwo_TextChanged(sender As Object, e As EventArgs) Handles TxtheaterTwo.TextChanged

    End Sub

    Private Sub TxtheaterTwo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtheaterTwo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtBarcodeOne.Text = TxtheaterTwo.Text Then
                lbl_Msg.ForeColor = Color.Green
                lbl_Msg.Text = "تم تسجيل باركود الكرتونة"
                If txtBarcodeOne.Text.Length = 17 Then
                    Dim Barcode_Part(6) As String
                    Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                    Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 8)
                    Barcode_Part(2) = txtBarcodeOne.Text.Substring(13, 4)
                    ff2.Text = Barcode_Part(2)
                ElseIf txtBarcodeOne.Text.Length = 18 Then
                    Dim Barcode_Part(6) As String
                    Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                    Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 8)
                    Barcode_Part(2) = txtBarcodeOne.Text.Substring(13, 5)
                    ff2.Text = Barcode_Part(2)
                End If

                TxtheaterTwo.Enabled = False
                txtPARTSSERIAL.Focus()
            Else
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "باركود الكرتونة غير مطابق لباركود الضمان"
                TxtheaterTwo.Focus()
                TxtheaterTwo.SelectAll()

            End If
        End If
    End Sub

    Private Sub TxtheaterThree_TextChanged(sender As Object, e As EventArgs) Handles TxtheaterThree.TextChanged

    End Sub

    Private Sub TxtheaterThree_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtheaterThree.KeyDown

    End Sub

    Private Sub cmb_Pcode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Pcode.KeyDown

    End Sub

    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        ' txtline.Enabled = True
        ' txtshift.Enabled = True
        cmb_Pcode.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtParts1.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap "
        Sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
        Sql += " and Heater_sap_stu='Active'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count < 1 Then
            lbl_Msg.ForeColor = Color.Red
            lbl_Msg.Text = "غير مصرح لك بالدخول "
            txtParts1.Focus()
            txtParts1.SelectAll()
            Exit Sub
        Else
            _Refresh315()
            lbl_Msg.ForeColor = Color.Green
            lbl_Msg.Text = "مرحبا بك فى برنامج مصنع الغسالة لمتابعة الانتاج"
            cmb_Pcode.Enabled = True
            ' txtline.Enabled = False
            txtshift.Enabled = True
            'txtshift.Visible = False
            Button2.Visible = False
            txtParts1.Visible = False
            Label10.Visible = False
            txtshift.Focus()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New Heater_Step_Two_Query
        frm.Show()

    End Sub

    Private Sub txtshift_Leave(sender As Object, e As EventArgs) Handles txtshift.Leave

    End Sub

    Private Sub txtshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtshift.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtPARTSSERIAL1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPARTSSERIAL.KeyDown
        Try


            If e.KeyCode = Keys.Enter Then
                '   If TxtheaterTwo.Text.Length = 18 Then

                Dim dsMax199 As New DataSet
                Dim Sql110 = "SELECT  Model_Name, Model_control,model_S_Power FROM Heater_ModelName where Model_control = '" & ff2.Text & "'"
                Sql110 += " and model_S_Power ='" & txtPARTSSERIAL.Text & "'"
                Dim da1 As New SqlClient.SqlDataAdapter(Sql110, cn)
                dsMax199.Tables.Clear()
                da1.Fill(dsMax199)
                If dsMax199.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الايان كود غير مطابق للموديل"
                    Console.Beep()
                    txtPARTSSERIAL.Focus()
                    txtPARTSSERIAL.SelectAll()
                    Exit Sub
                Else
                    Dim sql6 As String
                    sql6 = "INSERT INTO Heater_registration_Three"
                    sql6 += "( H_Model_Name,H_Heater_Code,H_component,H_Shift_Line,H_Name_Laber,H_Line_Name)"
                    sql6 += "VALUES     ('" & ff2.Text & "','" & txtBarcodeOne.Text & "','" & txtPARTSSERIAL.Text & "','" & txtshift.Text & "','" & txtParts1.Text & "','EWH1')"
                    Dim cmd As New SqlClient.SqlCommand(sql6, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل الغسالة بنجاح"
                    txtBarcodeOne.Enabled = True
                    TxtheaterTwo.Enabled = True
                    txtBarcodeOne.Text = ""
                    TxtheaterTwo.Text = ""
                    txtPARTSSERIAL.Text = ""
                    ff2.Text = ""
                    txtBarcodeOne.Focus()
                    _Refresh1()
                End If
            End If
            _Refresh1()
        Catch ex As Exception
        End Try
        _Refresh1()
    End Sub

    Private Sub txtPARTSSERIAL1_TextChanged(sender As Object, e As EventArgs) Handles txtPARTSSERIAL.TextChanged

    End Sub

    Private Sub Heater_out_put_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        txtBarcodeOne.Enabled = False
        TxtheaterTwo.Enabled = False
        TxtheaterThree.Enabled = False
        txtPARTSSERIAL.Enabled = False
        txtshift.Enabled = False
        cmb_Pcode.Enabled = False
        Try
            Dim sql As String = ""
            sql += "SELECT Model_Name, Model_control FROM Heater_ModelName"
            ' sql += " where fLine_Name ='EWH1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_ModelName")

            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "Model_control"
            ' cmb_Pcode.ValueMember = "model_S_Power"
            cmb_Pcode.DisplayMember = "Model_Name"
            cmb_Pcode.Sorted = True

            ' _Refresh1()
        Catch ex As Exception

        End Try
    End Sub
End Class