Imports TEVPBarcode.sher
Public Class frmSHA_Input


    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & Label12.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = " الفنى المسئول"
            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            DGN.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName,count (CModelName) AS tot"
            sql += " FROM SHA_Input_Production "
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"

            sql += " and C_Line_Shift ='" & txtline1.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Input_Production")
            ds.Tables("SHA_Input_Production").Columns(0).ColumnName = " الموديل "
            ds.Tables("SHA_Input_Production").Columns(1).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("SHA_Input_Production")
            dg2.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Public Property StringPassc1 As String
    Private Sub frmSHA_Output_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBarcodeOne.Enabled = False
        Label12.Text = StringPassc1
        _Refresh315()
        lbl_Msg.ForeColor = Color.Green
        lbl_Msg.Text = "مرحبا بك فى برنامج مصنع المنتجات الصغيرة لمتابعة الانتاج "
        txtline1.Enabled = True
        GroupBox2.Visible = True
        txtline1.Focus()
        txtline1.SelectAll()
    End Sub

    Private Sub txtBarcodeOne_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        ' Try
        If e.KeyCode = Keys.Enter Then
            Try


                If txtBarcodeOne.Text.Length = 19 Then

                    Dim dsMax As New DataSet
                    Dim Sql = "Select CBarcode from SHA_Input_Production where CBarcode='" & txtBarcodeOne.Text & "'"
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


                    ' If txtFATSERIAL.Text.Length < 17 Then Exit Sub
                    Dim Barcode_Part(3) As String
                    Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 13)
                    Barcode_Part(1) = txtBarcodeOne.Text.Substring(13, 4)
                    Barcode_Part(2) = txtBarcodeOne.Text.Substring(17, 2)
                    If lbl_Pcode_Value.Text = Barcode_Part(1) Then

                        'Dim sql2 As String
                        'sql2 = "INSERT INTO SHA_Input_Production"
                        'sql2 += "(CModelName,CBarcode, C_Line_Shift, CSapUser)"
                        'sql2 += "VALUES     ('" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','" & txtline1.Text & "','" & Label12.Text & "')"

                        'Dim cmd2 As New SqlClient.SqlCommand(sql2, cn)
                        'If cn.State = ConnectionState.Closed Then cn.Open()
                        'cmd2.ExecuteNonQuery()
                        'cn.Close()
                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "
                        txtBarcodeOne.Enabled = False
                        txtCarton.Enabled = True
                        'txtBarcodeOne.Text = ""
                        txtCarton.Focus()
                        txtCarton.SelectAll()
                        _Refresh1()

                    Else
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "الباركود غير مطابق للموديل"
                        Console.Beep()
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                        Exit Sub

                    End If

                ElseIf txtBarcodeOne.Text.Length = 20 Then
                    Dim dsMax As New DataSet
                    Dim Sql = "Select CBarcode from SHA_Input_Production where CBarcode='" & txtBarcodeOne.Text & "'"
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


                    ' If txtFATSERIAL.Text.Length < 17 Then Exit Sub
                    Dim Barcode_Part(3) As String
                    Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 13)
                    Barcode_Part(1) = txtBarcodeOne.Text.Substring(13, 5)
                    Barcode_Part(2) = txtBarcodeOne.Text.Substring(18, 2)

                    If lbl_Pcode_Value.Text = Barcode_Part(1) Then

                        'Dim sql2 As String
                        'sql2 = "INSERT INTO SHA_Input_Production"
                        'sql2 += "(CModelName,CBarcode, C_Line_Shift, CSapUser)"
                        'sql2 += "VALUES     ('" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','" & txtline1.Text & "','" & Label12.Text & "')"

                        'Dim cmd2 As New SqlClient.SqlCommand(sql2, cn)
                        'If cn.State = ConnectionState.Closed Then cn.Open()
                        'cmd2.ExecuteNonQuery()
                        'cn.Close()
                        'lbl_Msg.ForeColor = Color.GreenYellow
                        'lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "
                        'txtBarcodeOne.Enabled = True
                        'txtBarcodeOne.Text = ""
                        'txtBarcodeOne.Focus()
                        'txtBarcodeOne.SelectAll()
                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "
                        txtBarcodeOne.Enabled = False
                        txtCarton.Enabled = True
                        'txtBarcodeOne.Text = ""
                        txtCarton.Focus()
                        txtCarton.SelectAll()

                        _Refresh1()

                    Else
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "الباركود غير مطابق للموديل"
                        Console.Beep()
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                        Exit Sub

                    End If

                ElseIf txtBarcodeOne.Text.Length = 21 Then
                    Dim dsMax As New DataSet
                    Dim Sql = "Select CBarcode from SHA_Input_Production where CBarcode='" & txtBarcodeOne.Text & "'"
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


                    ' If txtFATSERIAL.Text.Length < 17 Then Exit Sub
                    Dim Barcode_Part(3) As String
                    Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 13)
                    Barcode_Part(1) = txtBarcodeOne.Text.Substring(13, 6)
                    Barcode_Part(2) = txtBarcodeOne.Text.Substring(19, 2)

                    If lbl_Pcode_Value.Text = Barcode_Part(1) Then

                        'Dim sql2 As String
                        'sql2 = "INSERT INTO SHA_Input_Production"
                        'sql2 += "(CModelName,CBarcode, C_Line_Shift, CSapUser)"
                        'sql2 += "VALUES     ('" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','" & txtline1.Text & "','" & Label12.Text & "')"

                        'Dim cmd2 As New SqlClient.SqlCommand(sql2, cn)
                        'If cn.State = ConnectionState.Closed Then cn.Open()
                        'cmd2.ExecuteNonQuery()
                        'cn.Close()
                        'lbl_Msg.ForeColor = Color.GreenYellow
                        'lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "
                        'txtBarcodeOne.Enabled = True
                        'txtBarcodeOne.Text = ""
                        'txtBarcodeOne.Focus()
                        'txtBarcodeOne.SelectAll()
                        '_Refresh1()
                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "
                        txtBarcodeOne.Enabled = False
                        txtCarton.Enabled = True
                        'txtBarcodeOne.Text = ""
                        txtCarton.Focus()
                        txtCarton.SelectAll()
                        _Refresh1()

                    Else
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "الباركود غير مطابق للموديل"
                        Console.Beep()
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                        Exit Sub

                    End If
                Else

                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الباركود لايتبع الموديل  "
                    Console.Beep()
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()

                End If
                '   End If

            Catch ex As Exception

            End Try
            ' End If
        End If
    End Sub

    Private Sub txtBarcodeOne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBarcodeOne.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

        '     End If
    End Sub



    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If cmb_Pcode.Text = "" Or txtline1.Text = "" Then

            MsgBox("لابد من التأكد من أدخال الورديه والموديل بصوره صحيحه ")

            Exit Sub
        Else
            Try
                _Refresh315()
                '    _Refresh11()
                cmb_Pcode.Enabled = False
                ' txtline.Enabled = False
                txtline1.Enabled = False
                txtline1.Visible = False
                Label8.Visible = False

                txtBarcodeOne.Enabled = True

                txtBarcodeOne.Focus()
                txtBarcodeOne.SelectAll()
                Dim tf As String

                lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString


            Catch ex As Exception

            End Try
        End If

        'If cmb_Pcode.Text = "" Or txtline1.Text = "" Then

        '    MsgBox("لابد من التأكد من أدخال الورديه والموديل بصوره صحيحه ")

        '    Exit Sub
        'Else
        '    Try
        '        _Refresh315()
        '        '    _Refresh11()
        '        cmb_Pcode.Enabled = False
        '        ' txtline.Enabled = False
        '        txtline1.Enabled = False
        '        txtline1.Visible = False
        '        Label8.Visible = False

        '        txtBarcodeOne.Text = ""
        '        txtCarton.Text = ""
        '        txtEanCode.Text = ""
        '        txtBarcodeOne.Enabled = True
        '        txtCarton.Enabled = False
        '        txtEanCode.Enabled = False
        '        txtBarcodeOne.Focus()
        '        txtBarcodeOne.SelectAll()

        '        Dim tf As String

        '            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString



        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New frmSHA_InputQuery
        frm.Show()
    End Sub

    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        cmb_Pcode.Focus()
        cmb_Pcode.SelectAll()

    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            Dim tf As String

            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString


        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub txtCarton_TextChanged(sender As Object, e As EventArgs) Handles txtCarton.TextChanged

    End Sub

    Private Sub txtCarton_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCarton.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtBarcodeOne.Text = txtCarton.Text Then
                lbl_Msg.ForeColor = Color.Green
                lbl_Msg.Text = "تم تسجيل باركود الكرتونة"
                txtCarton.Enabled = False
                txtEanCode.Enabled = True
                txtEanCode.Focus()
                txtEanCode.SelectAll()

            Else
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "باركود الكرتونة غير مطابق لباركود الضمان"
                txtCarton.Focus()
                txtCarton.SelectAll()
            End If
        End If
    End Sub

    Private Sub txtEanCode_TextChanged(sender As Object, e As EventArgs) Handles txtEanCode.TextChanged

    End Sub

    Private Sub txtEanCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEanCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            '   If TxtheaterTwo.Text.Length = 18 Then

            Dim dsMax199 As New DataSet
            Dim Sql110 = "SELECT CSetID,CModelName,CSetIDAndLine,CEanCode,CUserID,Cline FROM SHA_Models where CSetID = '" & lbl_Pcode_Value.Text & "'"
            Sql110 += " and CEanCode ='" & txtEanCode.Text & "'"
            Dim da1 As New SqlClient.SqlDataAdapter(Sql110, cn)
            dsMax199.Tables.Clear()
            da1.Fill(dsMax199)
            If dsMax199.Tables(0).Rows.Count < 1 Then
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "الايان كود غير مطابق للموديل"
                Console.Beep()
                txtEanCode.Focus()
                txtEanCode.SelectAll()
                Exit Sub
            Else
                Dim sql2 As String
                sql2 = "INSERT INTO SHA_Input_Production"
                sql2 += "(CModelName,CBarcode, C_Line_Shift, CSapUser,CEAN_Code)"
                sql2 += "VALUES     ('" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','" & txtline1.Text & "','" & Label12.Text & "','" & txtEanCode.Text & "')"

                Dim cmd2 As New SqlClient.SqlCommand(sql2, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd2.ExecuteNonQuery()
                cn.Close()
                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "
                txtBarcodeOne.Enabled = True
                txtBarcodeOne.Text = ""
                txtCarton.Text = ""
                txtEanCode.Text = ""
                txtCarton.Enabled = False
                txtEanCode.Enabled = False
                txtBarcodeOne.Focus()
                txtBarcodeOne.SelectAll()
                _Refresh1()
            End If
        End If
        _Refresh1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtBarcodeOne.Text = ""
        txtCarton.Text = ""
        txtEanCode.Text = ""
        txtBarcodeOne.Enabled = True
        txtCarton.Enabled = False
        txtEanCode.Enabled = False
        txtBarcodeOne.Focus()
        txtBarcodeOne.SelectAll()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtline1.Text = "" Then
            MsgBox("please Entry Your Line")
        Else

            If txtline1.Text.Length = 17 Then
                Dim Barcode_Part(2) As String
                Barcode_Part(0) = txtline1.Text.Substring(0, 12)
                Barcode_Part(2) = txtline1.Text.Substring(12, 5)

                Try
                    Dim sql As String = ""
                    sql += "SELECT CModelName,CSetID FROM SHA_Models"
                    sql += " where ProductName ='" & Barcode_Part(0) & "'"
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    ds.Tables.Clear()
                    da.Fill(ds, "SHA_Models")
                    cmb_Pcode.DataSource = ds.Tables(0)
                    ' cmb_Pcode.ValueMember = "CSetID"
                    cmb_Pcode.ValueMember = "CSetID"
                    cmb_Pcode.DisplayMember = "CModelName"
                    cmb_Pcode.Sorted = True
                    _Refresh1()
                Catch ex As Exception
                End Try


                Label1.Visible = True
                cmb_Pcode.Visible = True
                cmb_Pcode.Text = True
                btnStart.Visible = True
                txtline1.Visible = False
                Button2.Visible = False

                cmb_Pcode.Focus()
                cmb_Pcode.SelectAll()
            ElseIf txtline1.Text.Length = 10 Then
                Dim Barcode_Part(2) As String
                Barcode_Part(0) = txtline1.Text.Substring(0, 6)
                Barcode_Part(2) = txtline1.Text.Substring(6, 4)

                Try
                    Dim sql As String = ""
                    sql += "SELECT CModelName,CSetID FROM SHA_Models"
                    sql += " where ProductName ='" & Barcode_Part(0) & "'"
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    ds.Tables.Clear()
                    da.Fill(ds, "SHA_Models")
                    cmb_Pcode.DataSource = ds.Tables(0)
                    ' cmb_Pcode.ValueMember = "CSetID"
                    cmb_Pcode.ValueMember = "CSetID"
                    cmb_Pcode.DisplayMember = "CModelName"
                    cmb_Pcode.Sorted = True
                    _Refresh1()
                Catch ex As Exception
                End Try


                Label1.Visible = True
                cmb_Pcode.Visible = True
                cmb_Pcode.Text = True
                btnStart.Visible = True
                txtline1.Visible = False
                Button2.Visible = False

                cmb_Pcode.Focus()
                cmb_Pcode.SelectAll()
            ElseIf txtline1.Text.Length = 9 Then
                Dim Barcode_Part(2) As String
                Barcode_Part(0) = txtline1.Text.Substring(0, 5)
                Barcode_Part(2) = txtline1.Text.Substring(5, 4)

                Try
                    Dim sql As String = ""
                    sql += "SELECT CModelName,CSetID FROM SHA_Models"
                    sql += " where ProductName ='" & Barcode_Part(0) & "'"
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    ds.Tables.Clear()
                    da.Fill(ds, "SHA_Models")
                    cmb_Pcode.DataSource = ds.Tables(0)
                    ' cmb_Pcode.ValueMember = "CSetID"
                    cmb_Pcode.ValueMember = "CSetID"
                    cmb_Pcode.DisplayMember = "CModelName"
                    cmb_Pcode.Sorted = True
                    _Refresh1()
                Catch ex As Exception
                End Try


                Label1.Visible = True
                cmb_Pcode.Visible = True
                cmb_Pcode.Text = True
                btnStart.Visible = True
                txtline1.Visible = False
                Button2.Visible = False

                cmb_Pcode.Focus()
                cmb_Pcode.SelectAll()



            ElseIf txtline1.Text.Length = 8 Then
                Dim Barcode_Part(2) As String
                Barcode_Part(0) = txtline1.Text.Substring(0, 4)
                Barcode_Part(2) = txtline1.Text.Substring(4, 4)

                Try
                    Dim sql As String = ""
                    sql += "SELECT CModelName,CSetID FROM SHA_Models"
                    sql += " where ProductName ='" & Barcode_Part(0) & "'"
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    ds.Tables.Clear()
                    da.Fill(ds, "SHA_Models")
                    cmb_Pcode.DataSource = ds.Tables(0)
                    ' cmb_Pcode.ValueMember = "CSetID"
                    cmb_Pcode.ValueMember = "CSetID"
                    cmb_Pcode.DisplayMember = "CModelName"
                    cmb_Pcode.Sorted = True
                    _Refresh1()
                Catch ex As Exception
                End Try


                Label1.Visible = True
                cmb_Pcode.Visible = True
                cmb_Pcode.Text = True
                btnStart.Visible = True
                txtline1.Visible = False
                Button2.Visible = False

                cmb_Pcode.Focus()
                cmb_Pcode.SelectAll()


            Else
                MsgBox("this line is wrong")
                txtline1.Focus()
                txtline1.SelectAll()

            End If

            'Try
            '    Dim sql As String = ""
            '    sql += "SELECT CModelName,CSetID FROM SHA_Models"
            '    '  sql += " where fLine_Name ='EWH1'"
            '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            '    Dim ds As New DataSet
            '    ds.Tables.Clear()
            '    da.Fill(ds, "SHA_Models")
            '    cmb_Pcode.DataSource = ds.Tables(0)
            '    ' cmb_Pcode.ValueMember = "CSetID"
            '    cmb_Pcode.ValueMember = "CSetID"
            '    cmb_Pcode.DisplayMember = "CModelName"
            '    cmb_Pcode.Sorted = True
            '    _Refresh1()
            'Catch ex As Exception
            'End Try

            'cmb_Pcode.Focus()
            'cmb_Pcode.SelectAll()
            '   cmb_Pcode.Text = ""
            Dim dd As String = txtline1.Text.Length
        End If
    End Sub
End Class