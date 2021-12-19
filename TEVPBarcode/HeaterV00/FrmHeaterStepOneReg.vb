Imports TEVPBarcode.sher
Public Class FrmHeaterStepOneReg

    Private Sub FrmHeaterStepOneReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        txtBarcodeOne.Enabled = False
        TxtheaterTwo.Enabled = False
        'TxtheaterThree.Enabled = False
        'txtPARTSSERIAL.Enabled = False
        'TextBox1.Enabled = False
        'TextBox2.Enabled = False
        GroupBox2.Visible = False



        txtshift.Enabled = False
        cmb_Pcode.Enabled = False
        Try
            Dim sql As String = ""
            sql += "SELECT Model_Name, Model_sap FROM Heater_ModelName"
            'sql += " where fLine_Name ='A1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_ModelName")

            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "Model_sap"
            '  cmb_Pcode.ValueMember = "model_tank_C"
            cmb_Pcode.DisplayMember = "Model_Name"
            cmb_Pcode.Sorted = True


            'Try
            'Dim sql As String = ""
            'sql += "SELECT Model_Name, Model_control FROM Heater_ModelName"
            'sql += " where fLine_Name ='EWH1'"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'ds.Tables.Clear()
            'da.Fill(ds, "Heater_ModelName")

            'cmb_Pcode.DataSource = ds.Tables(0)
            'cmb_Pcode.ValueMember = "Model_control"
            'cmb_Pcode.DisplayMember = "Model_Name"
            'cmb_Pcode.Sorted = True

            _Refresh1()
        Catch ex As Exception

        End Try
        ' _Refresh1()
        'Catch ex As Exception

        'End Try
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT H_Model_Name, count(H_Heater_Code) AS tot"
            sql += " FROM Heater_registration_one1 "
            sql += " WHERE H_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and H_Shift_Line='" & txtshift.Text & "'"
            '    sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " GROUP BY H_Model_Name "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_registration_one1")
            ds.Tables("Heater_registration_one1").Columns(0).ColumnName = " الموديل "
            ds.Tables("Heater_registration_one1").Columns(1).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("Heater_registration_one1")

            Return True

        Catch ex As Exception

        End Try

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
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
                lbl_Msg.Text = " غير  مصرح بالدخول "
                Console.Beep()
                txtParts1.Focus()
                txtParts1.SelectAll()
                Exit Sub
            Else
                _Refresh315()
                lbl_Msg.ForeColor = Color.Green
                lbl_Msg.Text = "مرحبا بك فى برنامج مصنع السخان لمتابعة الانتاج "
                cmb_Pcode.Enabled = True
                ' txtline.Enabled = False
                txtshift.Enabled = True
                GroupBox2.Visible = True
                'txtshift.Visible = False
                Button2.Visible = False
                txtParts1.Visible = False
                Label10.Visible = False
                txtshift.Focus()
                'Me.BackColor = Color.YellowGreen

            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = " الفنى المسئول"

            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmb_Pcode.Text = "" Or txtshift.Text = "" Or txtParts1.Text = "" Then

            MsgBox("لابد من التأكد من أدخال الورديه والموديل بصوره صحيحه ")

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
                txtBarcodeOne.Enabled = True
                TxtheaterTwo.Enabled = True
                'TxtheaterThree.Enabled = True
                'txtPARTSSERIAL.Enabled = True
                'TextBox1.Enabled = True
                'TextBox2.Enabled = True
                txtBarcodeOne.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                If txtBarcodeOne.Text.Length < 18 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "Select H_Heater_Code from Heater_registration_one1 where H_Heater_Code='" & txtBarcodeOne.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "باركود السخان تم تسجيله من قبل "
                    Console.Beep()
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                    Exit Sub

                End If
            End If
        Catch ex As Exception

        End Try

        Try
            If e.KeyCode = Keys.Enter Then
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 7)
                Barcode_Part(1) = txtBarcodeOne.Text.Substring(7, 2)
                Barcode_Part(2) = txtBarcodeOne.Text.Substring(9, 9)

                If e.KeyCode = Keys.Enter Then


                    If Barcode_Part(1) <> cmb_Pcode.SelectedValue Then
                        lbl_Msg.Text = "باركود السخان غير تابع لهذا الموديل"
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                    Else


                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل باركود السخان بنجاح   "
                        'Label10.Text = cmb_Pcode.SelectedValue
                        txtBarcodeOne.Enabled = False
                        TxtheaterTwo.Enabled = True
                        TxtheaterTwo.Focus()

                        _Refresh1()
                    End If
                    '   End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged

    End Sub

    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        cmb_Pcode.Focus()
    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        txtBarcodeOne.Text = ""
        txtBarcodeOne.Enabled = True
        TxtheaterTwo.Enabled = True
        txtBarcodeOne.Focus()
    End Sub

    Private Sub TxtheaterTwo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtheaterTwo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                If TxtheaterTwo.Text.Length < 18 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "Select H_Tank from Heater_registration_one1 where H_Tank='" & TxtheaterTwo.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "باركود التانك تم تسجيله من قبل "
                    Console.Beep()
                    TxtheaterTwo.Focus()
                    TxtheaterTwo.SelectAll()
                    Exit Sub

                End If
            End If
        Catch ex As Exception

        End Try

        Try
            If e.KeyCode = Keys.Enter Then
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = TxtheaterTwo.Text.Substring(0, 7)
                Barcode_Part(1) = TxtheaterTwo.Text.Substring(7, 2)
                Barcode_Part(2) = TxtheaterTwo.Text.Substring(9, 9)

                If e.KeyCode = Keys.Enter Then


                    Dim dsMax As New DataSet
                    Dim Sql = "Select model_tank_C from Heater_ModelName where Model_Name='" & cmb_Pcode.Text & "' and model_tank_C='" & Barcode_Part(1) & "'"
                    Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                    dsMax.Tables.Clear()
                    da.Fill(dsMax)
                    If dsMax.Tables(0).Rows.Count <> 1 Then
                        lbl_Msg.Text = " باركود التانك غير تابع لهذا الموديل"
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        TxtheaterTwo.Focus()
                        TxtheaterTwo.SelectAll()
                    Else
                        Dim sql1 As String
                        sql1 = "INSERT INTO Heater_registration_one1"
                        sql1 += "(H_Model_Name, H_Heater_Code, H_Tank, H_Shift_Line, H_sap)"
                        sql1 += "VALUES     ('" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','" & TxtheaterTwo.Text & "','" & txtshift.Text & "','" & txtParts1.Text & "')"

                        Dim cmd As New SqlClient.SqlCommand(sql1, cn)
                        If cn.State = ConnectionState.Closed Then cn.Open()
                        cmd.ExecuteNonQuery()
                        cn.Close()

                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل باركود التانك بنجاح  "
                        'Label10.Text = cmb_Pcode.SelectedValue
                        txtBarcodeOne.Enabled = True
                        TxtheaterTwo.Enabled = True
                        txtBarcodeOne.Text = ""
                        TxtheaterTwo.Text = ""
                        txtBarcodeOne.Focus()
                        ' TxtheaterTwo.SelectAll()
                        _Refresh1()
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtheaterTwo_TextChanged(sender As Object, e As EventArgs) Handles TxtheaterTwo.TextChanged

    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            Dim tf As String

            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue(1).ToString
            ' Ta.Text = cmb_Pcode.SelectedValue(2).ToString

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New frmHeaterStepOneQuery
        frm.Show()

    End Sub
End Class