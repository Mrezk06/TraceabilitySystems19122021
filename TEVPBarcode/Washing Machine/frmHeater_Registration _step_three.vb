Imports TEVPBarcode.sher
Public Class Heater_Registration__step_three
    Private Sub Heater_Registration__step_three_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        cmb_Pcode.Enabled = False
        ' txtline.Enabled = False
        txtshift.Enabled = False
        txtBarcodeOne.Enabled = False
        txtBarcodeTwo.Enabled = False
        txtBarcodeThree.Enabled = False
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
      
        'Try
        '    Dim sql As String = ""
        '    sql += "SELECT Model_Name, model_S_Power FROM   Heater_ModelName "

        '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        '    Dim ds As New DataSet
        '    ds.Tables.Clear()
        '    da.Fill(ds, "Heater_ModelName")

        '    cmb_Pcode.DataSource = ds.Tables(0)
        '    cmb_Pcode.ValueMember = "model_S_Power"
        '    ' cmb_Pcode.ValueMember = "model_S_Power"
        '    cmb_Pcode.DisplayMember = "Model_Name"
        '    cmb_Pcode.Sorted = True

        '    ' _Refresh1()
        'Catch ex As Exception

        'End Try
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
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "أسم المسئول "

            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT Model_Name ,count(Model_Name)"
            sql += " FROM MVData  "
            sql += " WHERE H_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and H_Shift_Line='" & txtshift.Text & "'"
            '    sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " GROUP BY Model_Name "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "MVData")
            ds.Tables("MVData").Columns(0).ColumnName = "الموديل "
            ds.Tables("MVData").Columns(1).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("MVData")

            Return True

        Catch ex As Exception

        End Try

    End Function

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            '  If e.KeyCode = Keys.Enter Then
            '''''''''''''''''''''''''''''    lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue
            '  lbl_Pcode_Value.Text = ComboBox1.SelectedValue
            '   Label10.Text = cmb_Pcode.SelectedValue
            ' Label2.Text = cmb_Pcode.Text

            ' txtFATSERIAL.Enabled = True
            ' _Refresh1()
            'End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If cmb_Pcode.Text = "" Or txtshift.Text = "" Or txtParts1.Text = "" Then

            MsgBox("من فضلك تأكد من ادخال الخط والموديل ")

            Exit Sub
        Else
            Try
                _Refresh315()
                ' _Refresh11()
                cmb_Pcode.Enabled = False
                ' txtline.Enabled = False
                txtshift.Enabled = False
                txtshift.Visible = False
                Label8.Visible = False
                txtParts1.Visible = False
                Label9.Visible = False
                btnStart.Visible = False
                txtBarcodeOne.Enabled = True
                txtBarcodeTwo.Enabled = True
                txtBarcodeThree.Enabled = True
                txtBarcodeOne.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        ' txtline.Enabled = True
        ' txtshift.Enabled = True
        cmb_Pcode.Focus()
    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        'txtFATSERIAL.Focus()
        'txtFATSERIAL.SelectAll()
        txtBarcodeOne.Text = ""
        txtBarcodeTwo.Text = ""
        txtBarcodeThree.Text = ""
        ' txt.Text = ""
        txtBarcodeOne.Enabled = True
        txtBarcodeTwo.Enabled = True
        txtBarcodeThree.Enabled = True

        txtBarcodeOne.Focus()
    End Sub

    Private Sub txtBarcodeTwo_TextChanged(sender As Object, e As EventArgs)
        If txtBarcodeOne.Text = txtBarcodeTwo.Text Then
            lbl_Msg.ForeColor = Color.Green
            lbl_Msg.Text = "تم تسجيل الباركود بنجاح"
            txtBarcodeThree.Focus()
        Else
            lbl_Msg.ForeColor = Color.Red
            lbl_Msg.Text = "هذا الباركود غير متوافق معا الباركود الاخر"
            txtBarcodeTwo.Focus()
            txtBarcodeTwo.SelectAll()

        End If
    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New Heater_Step_Three_Query
        frm.Show()

    End Sub

    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged

    End Sub

    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                ' If txtBarcodeOne.Text.Length < 17 Then Exit Sub
                '      If txtBarcodeOne.Text.Length = 13 Then
                Dim dsMax As New DataSet
                Dim Sql = "Select H_Heater_Code from Heater_registration_Two where H_Heater_Code='" & txtBarcodeOne.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الباركود تم تسجيله من قبل"
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                    Exit Sub

                End If
                If e.KeyCode = Keys.Enter Then
                    If txtBarcodeOne.Text.Length = 17 Then
                        Dim Barcode_Part(6) As String
                        Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                        Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 8)
                        Barcode_Part(2) = txtBarcodeOne.Text.Substring(13, 4)
                        'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)
                        Dim dsMax1 As New DataSet
                        Dim Sql1 = " SELECT  Model_control FROM Heater_ModelName  where  Model_control ='" & Barcode_Part(2) & "'"
                        Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
                        dsMax1.Tables.Clear()
                        da1.Fill(dsMax1)
                        If dsMax1.Tables(0).Rows.Count < 1 Then
                            lbl_Msg.Text = "باركود الضمان غير تابع لأى الموديل "
                            lbl_Msg.ForeColor = Color.Yellow
                            txtBarcodeOne.Focus()
                            txtBarcodeOne.SelectAll()
                        Else


                            lbl_Msg.ForeColor = Color.GreenYellow
                            lbl_Msg.Text = "تم تسجيل باركود الضمان"
                            'Label10.Text = cmb_Pcode.SelectedValue
                            txtBarcodeOne.Enabled = False
                            txtBarcodeTwo.Enabled = True
                            txtBarcodeTwo.Focus()
                            _Refresh1()
                        End If
                        'End If
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
                            lbl_Msg.Text = "باركود الضمان غير تابع لأى الموديل "
                            lbl_Msg.ForeColor = Color.Yellow
                            txtBarcodeOne.Focus()
                            txtBarcodeOne.SelectAll()

                        Else


                            lbl_Msg.ForeColor = Color.GreenYellow
                            lbl_Msg.Text = "تم تسجيل باركود الضمان"
                            'Label10.Text = cmb_Pcode.SelectedValue
                            txtBarcodeOne.Enabled = False
                            txtBarcodeTwo.Enabled = True
                            txtBarcodeTwo.Focus()
                            _Refresh1()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub txtBarcodeThree_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeThree.TextChanged

    End Sub

    Private Sub txtBarcodeThree_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeThree.KeyDown
        If txtBarcodeOne.Text = txtBarcodeThree.Text Then

            Dim sql As String
            sql = "INSERT INTO Heater_registration_Two"
            sql += "( H_Model_Name,H_Heater_Code,H_component,H_Shift_Line,H_Line_Name)"
            sql += "VALUES     ('" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','" & txtParts1.Text & "','" & txtshift.Text & "','EWH1')"

            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            lbl_Msg.ForeColor = Color.GreenYellow
            lbl_Msg.Text = "تم تسجيل الغسالة بنجاح "

            'txtFATSERIAL.Enabled = False

            txtBarcodeOne.Enabled = True
            txtBarcodeTwo.Enabled = True
            txtBarcodeThree.Enabled = True
            '   txtParts1.Enabled = True
            txtBarcodeOne.Text = ""
            txtBarcodeTwo.Text = ""
            txtBarcodeThree.Text = ""
            ' txtParts1.Text = ""
            txtBarcodeOne.Focus()
            _Refresh1()
            '            Exit Sub
        Else
            '  End If




            lbl_Msg.ForeColor = Color.Red
            lbl_Msg.Text = "باركود الغسالة غير مطابق لباركود الضمان"
            txtBarcodeTwo.Focus()
            txtBarcodeTwo.SelectAll()

        End If

    End Sub

    Private Sub txtBarcodeTwo_QueryContinueDrag(sender As Object, e As QueryContinueDragEventArgs) Handles txtBarcodeTwo.QueryContinueDrag

    End Sub

    Private Sub txtBarcodeTwo_TextChanged_1(sender As Object, e As EventArgs) Handles txtBarcodeTwo.TextChanged

    End Sub

    Private Sub txtBarcodeTwo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeTwo.KeyDown
        'If txtBarcodeOne.Text = txtBarcodeTwo.Text Then
        '    lbl_Msg.ForeColor = Color.Green
        If txtBarcodeOne.Text.Length = 18 Then


            Dim Barcode_Part(6) As String
            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 8)
            Barcode_Part(2) = txtBarcodeOne.Text.Substring(13, 5)
            'End If
            If e.KeyCode = Keys.Enter Then
                If txtBarcodeOne.Text = txtBarcodeTwo.Text Then

                    Dim sql As String
                    sql = "INSERT INTO Heater_registration_Two"
                    sql += "( H_Model_Name,H_Heater_Code,H_Shift_Line,H_Name_Laber)"
                    sql += "VALUES     ('" & Barcode_Part(2) & "','" & txtBarcodeOne.Text & "','" & txtshift.Text & "','" & txtParts1.Text & "')"

                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل الغسالة بنجاح"

                    'txtFATSERIAL.Enabled = False

                    txtBarcodeOne.Enabled = True
                    txtBarcodeTwo.Enabled = True
                    '  txtBarcodeThree.Enabled = True
                    '   txtParts1.Enabled = True
                    txtBarcodeOne.Text = ""
                    txtBarcodeTwo.Text = ""
                    '   txtBarcodeThree.Text = ""
                    ' txtParts1.Text = ""
                    txtBarcodeOne.Focus()
                    _Refresh1()
                    '            Exit Sub
                Else
                    '  End If




                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "باركود الغسالة غير مطابق لباركود الضمان"

                    txtBarcodeTwo.Focus()
                    txtBarcodeTwo.SelectAll()

                End If
            End If
        ElseIf txtBarcodeOne.Text.Length = 17 Then


            Dim Barcode_Part(6) As String
            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 8)
            Barcode_Part(2) = txtBarcodeOne.Text.Substring(13, 4)
            'End If
            If e.KeyCode = Keys.Enter Then
                If txtBarcodeOne.Text = txtBarcodeTwo.Text Then

                    Dim sql As String
                    sql = "INSERT INTO Heater_registration_Two"
                    sql += "( H_Model_Name,H_Heater_Code,H_Shift_Line,H_Name_Laber)"
                    sql += "VALUES     ('" & Barcode_Part(2) & "','" & txtBarcodeOne.Text & "','" & txtshift.Text & "','" & txtParts1.Text & "')"

                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل الغسالة بنجاح"

                    'txtFATSERIAL.Enabled = False

                    txtBarcodeOne.Enabled = True
                    txtBarcodeTwo.Enabled = True
                    '  txtBarcodeThree.Enabled = True
                    '   txtParts1.Enabled = True
                    txtBarcodeOne.Text = ""
                    txtBarcodeTwo.Text = ""
                    '   txtBarcodeThree.Text = ""
                    ' txtParts1.Text = ""
                    txtBarcodeOne.Focus()
                    _Refresh1()
                    '            Exit Sub
                Else
                    '  End If




                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "باركود الغسالة غير مطابق لباركود الضمان"

                    txtBarcodeTwo.Focus()
                    txtBarcodeTwo.SelectAll()

                End If
            End If
        End If
    End Sub

    Private Sub txtParts1_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtBarcodeOne_Leave(sender As Object, e As EventArgs) Handles txtBarcodeOne.Leave


    End Sub

    Private Sub txtBarcodeTwo_Leave(sender As Object, e As EventArgs) Handles txtBarcodeTwo.Leave
        '  ComboBox1.Text = lbl_Pcode_Value.Text
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub txtParts1_TextChanged_1(sender As Object, e As EventArgs) Handles txtParts1.TextChanged

    End Sub

    Private Sub txtParts1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtParts1.KeyDown

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
            lbl_Msg.Text = "غير مصرح لك بالدخول"
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
            Label9.Visible = False
            txtshift.Focus()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DGN_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub lbl_Msg_Click(sender As Object, e As EventArgs) Handles lbl_Msg.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtshift_Leave(sender As Object, e As EventArgs) Handles txtshift.Leave
        'Try
        '    Dim sql As String = ""
        '    sql += "SELECT Model_Name, Model_control FROM  Heater_ModelName "
        '    sql += " where fLine_Name ='" & txtshift.Text & "'"
        '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        '    Dim ds As New DataSet
        '    ds.Tables.Clear()
        '    da.Fill(ds, "Heater_ModelName")

        '    cmb_Pcode.DataSource = ds.Tables(0)
        '    cmb_Pcode.ValueMember = "Model_control"
        '    ' cmb_Pcode.ValueMember = "model_S_Power"
        '    cmb_Pcode.DisplayMember = "Model_Name"
        '    cmb_Pcode.Sorted = True

        '    ' _Refresh1()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtshift.SelectedIndexChanged

    End Sub
End Class