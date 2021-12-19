Imports TEVPBarcode.sher
Public Class frmMicroWave


    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            sql += " where Heater_Sap_Laber='" & Label2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = " الفنى المسئول"
            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName,count (CModelName) AS tot"
            sql += " FROM C_Output_Production "
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and H_Line_Name='EWH1'"
            sql += " and C_Line_Shift ='" & txtshift.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " الموديل "
            ds.Tables("C_Output_Production").Columns(1).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("C_Output_Production")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Public Property StringPassc2 As String
    Private Sub Heater_Registration__step_four_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        txtBarcodeOne.Enabled = False
        TxtheaterTwo.Enabled = False
        TxtheaterThree.Enabled = False
        txtPARTSSERIAL.Enabled = False
        GroupBox2.Visible = False
        txtshift.Enabled = False
        cmb_Pcode.Enabled = False
        Label2.Visible = False
        Try
            Dim strSearchText As String = "MW"
            Dim sql As String = ""
            sql += "SELECT CModelName,CMC FROM CModels"
            ' sql += " where CBlo ='MW02'"
            sql += "  WHERE CBlo Like '%" + strSearchText + "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "CMC"
            cmb_Pcode.DisplayMember = "CModelName"
            cmb_Pcode.Sorted = True
            _Refresh1()
        Catch ex As Exception

        End Try
        Label2.Text = StringPassc2
        _Refresh315()
        lbl_Msg.ForeColor = Color.Green
        lbl_Msg.Text = "مرحبا بك فى برنامج مصنع السخان لمتابعة الانتاج "
        cmb_Pcode.Enabled = True
        ' txtline.Enabled = False
        txtshift.Enabled = True
        GroupBox2.Visible = True
        cmb_Pcode.Focus()
    End Sub

    Private Sub txtParts1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        _Refresh315()
                lbl_Msg.ForeColor = Color.Green
                lbl_Msg.Text = "مرحبا بك فى برنامج مصنع السخان لمتابعة الانتاج "
                cmb_Pcode.Enabled = True
                ' txtline.Enabled = False
                txtshift.Enabled = True
                GroupBox2.Visible = True

        txtshift.Focus()

    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New frmCookerOutPutQuery
        frm.Show()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmb_Pcode.Text = "" Or txtshift.Text = "" Then

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

                txtBarcodeOne.Enabled = True
                TxtheaterTwo.Enabled = True
                TxtheaterThree.Enabled = True
                txtPARTSSERIAL.Enabled = True

                txtBarcodeOne.Focus()

            Catch ex As Exception

            End Try
        End If
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

    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        ' txtline.Enabled = True
        ' txtshift.Enabled = True
        cmb_Pcode.Focus()
    End Sub

    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then

                If txtBarcodeOne.Text.Length < 17 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "Select H_Heater_Code from Heater_registration_Three where H_Heater_Code='" & txtBarcodeOne.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الباركود تم تسجيله من قبل "
                    Console.Beep()
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                    Exit Sub
                End If
            End If
        Catch ex As Exception

        End Try

        Try

            Dim Barcode_Part(6) As String
            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 7)
            Barcode_Part(2) = txtBarcodeOne.Text.Substring(12, 5)
            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)
            'Barcode_Part(4) = txtBarcodeOne.Text.Substring(7, 1)
            'Barcode_Part(5) = txtBarcodeOne.Text.Substring(8, 4)
            'Barcode_Part(6) = txtBarcodeOne.Text.Substring(12, 2)
            If e.KeyCode = Keys.Enter Then
                If Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
                    lbl_Msg.Text = "الباركود غير تابع لهذا الموديل"
                    lbl_Msg.ForeColor = Color.Yellow
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                Else


                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل الباركود الاول "
                    Console.Beep()
                    'Label10.Text = cmb_Pcode.SelectedValue
                    txtBarcodeOne.Enabled = False
                    TxtheaterTwo.Enabled = True
                    TxtheaterTwo.Focus()

                    _Refresh1()
                End If
            End If
            '  End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtheaterTwo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If txtBarcodeOne.Text = TxtheaterTwo.Text Then
                lbl_Msg.ForeColor = Color.Green
                lbl_Msg.Text = "تم تسجيل الباركود الثانى "
                TxtheaterTwo.Enabled = False
                TxtheaterThree.Focus()
            Else
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "الباركود غير مطابق "
                Console.Beep()
                TxtheaterTwo.Focus()
                TxtheaterTwo.SelectAll()

            End If
        End If
    End Sub

    Private Sub TxtheaterTwo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtheaterThree_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If txtBarcodeOne.Text = TxtheaterThree.Text Then
                lbl_Msg.ForeColor = Color.Green
                lbl_Msg.Text = "تم تسجيل الباركود الثالث "
                TxtheaterThree.Enabled = False
                txtPARTSSERIAL.Focus()
            Else
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "الباركود غير مطابق "
                Console.Beep()
                TxtheaterThree.Focus()
                TxtheaterThree.SelectAll()

            End If
        End If
    End Sub

    Private Sub TxtheaterThree_TextChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub txtPARTSSERIAL_KeyDown(sender As Object, e As KeyEventArgs)

    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            ' If txtFATSERIAL.Text.Length < 17 Then Exit Sub
    '            Dim Barcode_Part(6) As String
    '            Barcode_Part(0) = txtPARTSSERIAL.Text.Substring(0, 7)
    '            Barcode_Part(1) = txtPARTSSERIAL.Text.Substring(7, 5)
    '            ' Barcode_Part(2) = txtBarcodeOne.Text.Substring(12, 5)
    '            Dim dsMax1 As New DataSet
    '            Dim Sql1 = "SELECT  Model_Name, Model_control,model_S_Power FROM Heater_ModelName where Model_Name = '" & cmb_Pcode.Text & "'"
    '            Sql1 += " and model_S_Power ='" & txtPARTSSERIAL.Text & "'"
    '            ' Sql += " and fNameL='" & ComboBox2.Text & "'"
    '            Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
    '            dsMax1.Tables.Clear()
    '            da1.Fill(dsMax1)
    '            If dsMax1.Tables(0).Rows.Count < 1 Then
    '                lbl_Msg.ForeColor = Color.Red
    '                lbl_Msg.Text = "الباركود غير مطابق للموديل"
    '                Console.Beep()
    '                txtPARTSSERIAL.Focus()
    '                txtPARTSSERIAL.SelectAll()
    '                Exit Sub
    '            Else
    '                '  End If

    '                Dim sql As String
    '                sql = "INSERT INTO Heater_registration_Three"
    '                sql += "( H_Model_Name,H_Heater_Code,H_component,H_Shift_Line,H_Name_Laber,H_Line_Name)"
    '                sql += "VALUES     ('" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','" & txtPARTSSERIAL.Text & "','" & txtshift.Text & "','" & Label2.Text & "','EWH1')"

    '                Dim cmd As New SqlClient.SqlCommand(sql, cn)
    '                If cn.State = ConnectionState.Closed Then cn.Open()
    '                cmd.ExecuteNonQuery()
    '                cn.Close()
    '                lbl_Msg.ForeColor = Color.GreenYellow
    '                lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "

    '                'txtFATSERIAL.Enabled = False

    '                txtBarcodeOne.Enabled = True
    '                TxtheaterTwo.Enabled = True
    '                TxtheaterThree.Enabled = True

    '                'txtParts1.Enabled = True
    '                txtBarcodeOne.Text = ""
    '                TxtheaterTwo.Text = ""
    '                TxtheaterThree.Text = ""

    '                txtPARTSSERIAL.Text = ""
    '                txtBarcodeOne.Focus()
    '            End If
    '        End If



    '    Catch ex As Exception

    '    End Try
    '    _Refresh1()
    'End Sub

    Private Sub txtPARTSSERIAL_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue
            '   Label10.Text = cmb_Pcode.SelectedValue
            '   Label2.Text = cmb_Pcode.Text

            ' txtFATSERIAL.Enabled = True
            ' _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtBarcodeOne_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                If txtBarcodeOne.Text.Length < 17 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "Select CBarcode from C_Output_Production where CBarcode='" & txtBarcodeOne.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الباركود تم تسجيله من قبل "
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
                Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 7)
                Barcode_Part(2) = txtBarcodeOne.Text.Substring(12, 5)
                'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)
                'Barcode_Part(4) = txtBarcodeOne.Text.Substring(7, 1)
                'Barcode_Part(5) = txtBarcodeOne.Text.Substring(8, 4)
                'Barcode_Part(6) = txtBarcodeOne.Text.Substring(12, 2)
                'End If
                If e.KeyCode = Keys.Enter Then


                    If Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
                        lbl_Msg.Text = "الباركود غير تابع لهذا الموديل"
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                    Else


                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل باركود المنتج  "
                        'Label10.Text = cmb_Pcode.SelectedValue
                        txtBarcodeOne.Enabled = False
                        TxtheaterTwo.Enabled = True
                        TxtheaterTwo.Focus()

                        _Refresh1()
                    End If
                    '   End If
                End If

                'If e.KeyCode = Keys.Enter Then

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBarcodeOne_TextChanged_1(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged

    End Sub

    Private Sub TxtheaterTwo_KeyDown1(sender As Object, e As KeyEventArgs) Handles TxtheaterTwo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtBarcodeOne.Text = TxtheaterTwo.Text Then
                lbl_Msg.ForeColor = Color.Green
                lbl_Msg.Text = "تم تسجيل باركود شهادة الضمان "
                TxtheaterTwo.Enabled = False
                TxtheaterThree.Focus()
            Else
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "الباركود غير مطابق "
                Console.Beep()
                TxtheaterTwo.Focus()
                TxtheaterTwo.SelectAll()

            End If
        End If
    End Sub

    Private Sub TxtheaterTwo_TextChanged_1(sender As Object, e As EventArgs) Handles TxtheaterTwo.TextChanged

    End Sub

    Private Sub TxtheaterThree_KeyDown1(sender As Object, e As KeyEventArgs) Handles TxtheaterThree.KeyDown



        If e.KeyCode = Keys.Enter Then
            If txtBarcodeOne.Text = TxtheaterThree.Text Then
                lbl_Msg.ForeColor = Color.Green
                lbl_Msg.Text = "تم تسجيل باركود الكرتونه"

                If TxtheaterThree.Text.Length = 17 Then
                    Dim Barcode_Part(6) As String
                    Barcode_Part(0) = TxtheaterThree.Text.Substring(0, 5)
                    Barcode_Part(1) = TxtheaterThree.Text.Substring(5, 8)
                    Barcode_Part(2) = TxtheaterThree.Text.Substring(13, 4)
                    ff2.Text = Barcode_Part(2)
                ElseIf TxtheaterThree.Text.Length = 18 Then
                    Dim Barcode_Part(6) As String
                    Barcode_Part(0) = TxtheaterThree.Text.Substring(0, 5)
                    Barcode_Part(1) = TxtheaterThree.Text.Substring(5, 8)
                    Barcode_Part(2) = TxtheaterThree.Text.Substring(13, 5)
                    ff2.Text = Barcode_Part(2)
                End If

                TxtheaterThree.Enabled = False
                txtPARTSSERIAL.Focus()
            Else
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "الباركود غير مطابق "
                Console.Beep()
                TxtheaterThree.Focus()
                TxtheaterThree.SelectAll()

            End If
        End If


        'If e.KeyCode = Keys.Enter Then
        '    If txtBarcodeOne.Text = TxtheaterThree.Text Then
        '        lbl_Msg.ForeColor = Color.Green
        '        lbl_Msg.Text = "تم تسجيل الباركود الاول "
        '        TxtheaterThree.Enabled = False
        '        TextBox1.Focus()
        '    Else
        '        lbl_Msg.ForeColor = Color.Red
        '        lbl_Msg.Text = "الباركود غير مطابق "
        '        Console.Beep()
        '        TxtheaterThree.Focus()
        '        TxtheaterThree.SelectAll()

        '    End If
        'End If
    End Sub

    Private Sub TxtheaterThree_Leave(sender As Object, e As EventArgs) Handles TxtheaterThree.Leave

    End Sub

    Private Sub TxtheaterThree_TextChanged_1(sender As Object, e As EventArgs) Handles TxtheaterThree.TextChanged

    End Sub

    Private Sub TextBox1_HandleCreated(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub



    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPARTSSERIAL_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtPARTSSERIAL.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtPARTSSERIAL.Text.Length < 11 Then Exit Sub
                'Dim Barcode_Part(6) As String
                'Barcode_Part(0) = txtPARTSSERIAL.Text.Substring(0, 7)
                'Barcode_Part(1) = txtPARTSSERIAL.Text.Substring(7, 5)
                'Barcode_Part(2) = txtPARTSSERIAL.Text.Substring(12, 5)
                Dim dsMax1 As New DataSet
                Dim Sql1 = "SELECT  CModelName, CEanCode, CMC FROM CModels where CModelName = '" & cmb_Pcode.Text & "'"
                Sql1 += " and CEanCode ='" & txtPARTSSERIAL.Text & "'"
                ' Sql += " and fNameL='" & ComboBox2.Text & "'"
                Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
                dsMax1.Tables.Clear()
                da1.Fill(dsMax1)
                If dsMax1.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الايان كود غير مطابق للموديل"
                    Console.Beep()
                    txtPARTSSERIAL.Focus()
                    txtPARTSSERIAL.SelectAll()
                    Exit Sub
                Else
                    '  End If

                    Dim sql As String
                    sql = "INSERT INTO C_Output_Production"
                    sql += "(CBarcode, CEAN_Code, CModelName, C_Line_Shift, CSapUser)"
                    sql += "VALUES     ('" & txtBarcodeOne.Text & "','" & txtPARTSSERIAL.Text & "','" & cmb_Pcode.Text & "','" & txtshift.Text & "','" & Label2.Text & "')"

                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "

                    'txtFATSERIAL.Enabled = False

                    txtBarcodeOne.Enabled = True
                    TxtheaterTwo.Enabled = True
                    TxtheaterThree.Enabled = True

                    'txtParts1.Enabled = True
                    txtBarcodeOne.Text = ""
                    TxtheaterTwo.Text = ""
                    TxtheaterThree.Text = ""

                    txtPARTSSERIAL.Text = ""
                    ff2.Text = ""
                    txtBarcodeOne.Focus()
                End If
            End If



        Catch ex As Exception

        End Try
        _Refresh1()
    End Sub

    Private Sub txtPARTSSERIAL_LostFocus(sender As Object, e As EventArgs) Handles txtPARTSSERIAL.LostFocus

    End Sub

    Private Sub txtPARTSSERIAL_TextChanged_1(sender As Object, e As EventArgs) Handles txtPARTSSERIAL.TextChanged

    End Sub

    Private Sub cmb_Pcode_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    'Private Sub cmb_Pcode_SelectedIndexChanged_1(sender As Object, e As EventArgs)


    'End Sub

    Private Sub txtshift_KeyDown(sender As Object, e As KeyEventArgs) Handles txtshift.KeyDown
        'If cmb_Pcode.Text = "" Or txtshift.Text = "" Or txtParts1.Text = "" Then

        '    MsgBox("لابد من التأكد من أدخال الورديه والموديل بصوره صحيحه ")

        '    Exit Sub
        'Else
        '    Try
        '        _Refresh315()
        '        '    _Refresh11()
        '        cmb_Pcode.Enabled = False
        '        ' txtline.Enabled = False
        '        txtshift.Enabled = False
        '        txtshift.Visible = False
        '        Label8.Visible = False
        '        txtParts1.Visible = False
        '        Label10.Visible = False
        '        txtBarcodeOne.Enabled = True
        '        TxtheaterTwo.Enabled = True
        '        TxtheaterThree.Enabled = True
        '        txtPARTSSERIAL.Enabled = True
        '        TextBox1.Enabled = True
        '        TextBox2.Enabled = True
        '        txtBarcodeOne.Focus()

        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Private Sub txtshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtshift.SelectedIndexChanged

    End Sub

    Private Sub txtParts1_KeyDown(sender As Object, e As KeyEventArgs)
        'Try
        '    If txtParts1.Text.Length < 8 Then Exit Sub

        '    Dim dsMax As New DataSet
        '    Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtParts1.Text & "'"
        '    Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        '    dsMax.Tables.Clear()
        '    da.Fill(dsMax)
        '    If dsMax.Tables(0).Rows.Count < 1 Then
        '        lbl_Msg.ForeColor = Color.Red
        '        lbl_Msg.Text = "هذا الاسم غير  مصرح له العمل على خطوة الباركود "
        '        Console.Beep()
        '        txtParts1.Focus()
        '        txtParts1.SelectAll()
        '        Exit Sub
        '    Else
        '        _Refresh315()
        '        lbl_Msg.ForeColor = Color.Green
        '        lbl_Msg.Text = "مرحبا بك فى برنامج مصنع السخان لمتابعة الانتاج "
        '        cmb_Pcode.Enabled = True
        '        ' txtline.Enabled = False
        '        txtshift.Enabled = True
        '        GroupBox2.Visible = True
        '        'txtshift.Visible = False
        '        Button2.Visible = False
        '        txtParts1.Visible = False
        '        Label10.Visible = False
        '        txtshift.Focus()
        '        'Me.BackColor = Color.YellowGreen

        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cmb_Pcode_KeyDown1(sender As Object, e As KeyEventArgs) Handles cmb_Pcode.KeyDown

    End Sub

    'Private Sub txtParts1_TextChanged_1(sender As Object, e As EventArgs) Handles txtParts1.TextChanged

    'End Sub

    'Private Sub cmb_Pcode_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged

    'End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            Dim tf As String

            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString


        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmb_Pcode_TextChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.TextChanged

        ' lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue
    End Sub
End Class