Imports TEVPBarcode.sher
Public Class FrmHeaterStepTwoReg

    ' Public Class FrmHeaterStepOneReg

    Private Sub FrmHeaterStepOneReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        txtBarcodeOne.Enabled = False
        TextBox1.Enabled = False
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
            '  sql += " where fLine_Name ='EWH1'"
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
            sql += " SELECT H_ModelName,H_NameBoard, count(H_BoardBarcode) AS tot"
            sql += " FROM Heater_BoardReg "
            sql += " WHERE H_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and H_LineAndShift='" & txtshift.Text & "'"
            '    sql += " and fLCDPline ='" & txtshift.Text & "'"
            sql += " GROUP BY H_ModelName,H_NameBoard "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_BoardReg")
            ds.Tables("Heater_BoardReg").Columns(0).ColumnName = " الموديل "
            ds.Tables("Heater_BoardReg").Columns(1).ColumnName = " اسم اللوحة"
            ds.Tables("Heater_BoardReg").Columns(2).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("Heater_BoardReg")

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
                txtBarcodeOne.Enabled = False
                TextBox1.Enabled = True
                ' TxtheaterTwo.Enabled = True
                'TxtheaterThree.Enabled = True
                'txtPARTSSERIAL.Enabled = True
                'TextBox1.Enabled = True
                'TextBox2.Enabled = True
                TextBox1.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtBarcodeOne_Invalidated(sender As Object, e As InvalidateEventArgs) Handles txtBarcodeOne.Invalidated

    End Sub

    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                If txtBarcodeOne.Text.Length < 18 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "Select H_BoardBarcode from Heater_BoardReg where H_ModelName='" & cmb_Pcode.Text & "' and H_BoardBarcode='" & txtBarcodeOne.Text & "'"
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
          
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 7)
                Barcode_Part(1) = txtBarcodeOne.Text.Substring(7, 2)
                Barcode_Part(2) = txtBarcodeOne.Text.Substring(9, 9)

                If e.KeyCode = Keys.Enter Then


                    If Barcode_Part(1) <> cmb_Pcode.SelectedValue Then
                        lbl_Msg.Text = "باركود اللوحةغير تابع لهذا الموديل"
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                    Else

                        '
                        '    If e.KeyCode = Keys.Enter Then
                        Dim Barcode_Part1(6) As String
                        Barcode_Part1(0) = txtBarcodeOne.Text.Substring(0, 7)
                        Barcode_Part1(1) = txtBarcodeOne.Text.Substring(7, 2)
                        Barcode_Part1(2) = txtBarcodeOne.Text.Substring(9, 7)
                        Barcode_Part1(3) = txtBarcodeOne.Text.Substring(16, 1)
                        Barcode_Part1(4) = txtBarcodeOne.Text.Substring(17, 1)
                        ff2.Text = Barcode_Part1(3)

                        'Dim Barcode_Part2(6) As String
                        'Barcode_Part2(0) = txtBarcodeOne.Text.Substring(0, 7)
                        'Barcode_Part2(1) = txtBarcodeOne.Text.Substring(7, 2)
                        'Barcode_Part2(2) = txtBarcodeOne.Text.Substring(9, 7)
                        'Barcode_Part2(3) = txtBarcodeOne.Text.Substring(16, 1)
                        'Barcode_Part2(4) = txtBarcodeOne.Text.Substring(17, 1)
                        'ff2.Text = Barcode_Part2(3)


                        If ff2.Text = "C" And ff3.Text = Barcode_Part1(3) Then

                            Dim sql1 As String
                            sql1 = "INSERT INTO Heater_BoardReg"
                            sql1 += "(H_BoardBarcodePlastic,H_ModelName,H_BoardBarcode, H_NameBoard, H_LineAndShift, H_Sap)"
                            sql1 += "VALUES     ('" & TextBox1.Text & "','" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','Control','" & txtshift.Text & "','" & txtParts1.Text & "')"

                            Dim cmd As New SqlClient.SqlCommand(sql1, cn)
                            If cn.State = ConnectionState.Closed Then cn.Open()
                            cmd.ExecuteNonQuery()
                            cn.Close()

                            lbl_Msg.ForeColor = Color.GreenYellow
                            Console.Beep()
                            lbl_Msg.Text = "تم تسجيل باركود لوحة التحكم بنجاح  "
                            'Label10.Text = cmb_Pcode.SelectedValue
                            txtBarcodeOne.Enabled = False
                            TextBox1.Enabled = True
                            txtBarcodeOne.Text = ""
                            TextBox1.Text = ""
                            '  TxtheaterTwo.Text = ""
                            TextBox1.Focus()
                            ' TxtheaterTwo.SelectAll()
                            _Refresh1()

                        ElseIf ff2.Text = "P" And ff3.Text = Barcode_Part1(3) Then

                            Dim sql1 As String
                            sql1 = "INSERT INTO Heater_BoardReg"
                            sql1 += "(H_BoardBarcodePlastic,H_ModelName,H_BoardBarcode, H_NameBoard, H_LineAndShift, H_Sap)"
                            sql1 += "VALUES     ('" & TextBox1.Text & "','" & cmb_Pcode.Text & "','" & txtBarcodeOne.Text & "','power','" & txtshift.Text & "','" & txtParts1.Text & "')"

                            Dim cmd As New SqlClient.SqlCommand(sql1, cn)
                            If cn.State = ConnectionState.Closed Then cn.Open()
                            cmd.ExecuteNonQuery()
                            cn.Close()

                            lbl_Msg.ForeColor = Color.GreenYellow
                            Console.Beep()
                            lbl_Msg.Text = "تم تسجيل باركود لوحة الباور بنجاح  "
                            'Label10.Text = cmb_Pcode.SelectedValue
                            txtBarcodeOne.Enabled = False
                            TextBox1.Enabled = True
                            txtBarcodeOne.Text = ""
                            TextBox1.Text = ""
                            '  TxtheaterTwo.Text = ""
                            TextBox1.Focus()
                            ' TxtheaterTwo.SelectAll()
                            _Refresh1()

                        Else
                            lbl_Msg.ForeColor = Color.Red
                            Console.Beep()
                            lbl_Msg.Text = " هذا الباركود خطأ "
                            'Label10.Text = cmb_Pcode.SelectedValue
                            '  txtBarcodeOne.Enabled = True
                            ' TxtheaterTwo.Enabled = True
                            ' txtBarcodeOne.Text = ""
                            '  TxtheaterTwo.Text = ""
                            txtBarcodeOne.Focus()
                            txtBarcodeOne.SelectAll()
                        End If



                    End If
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
        TextBox1.Text = ""
        txtBarcodeOne.Enabled = False
        TextBox1.Enabled = True
        ' TxtheaterTwo.Enabled = True
        TextBox1.Focus()
    End Sub

    

    Private Sub TxtheaterTwo_TextChanged(sender As Object, e As EventArgs)

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
        Dim frm As New frmHeaterStepTwoOfflinQuery
        frm.Show()

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If TextBox1.Text.Length < 18 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "Select H_BoardBarcodePlastic from Heater_BoardReg where H_ModelName='" & cmb_Pcode.Text & "' and H_BoardBarcodePlastic='" & TextBox1.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "باركود الجزء البلاستك تم تسجيله من قبل "
                    Console.Beep()
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                    Exit Sub
                End If
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = TextBox1.Text.Substring(0, 7)
                Barcode_Part(1) = TextBox1.Text.Substring(7, 2)
                Barcode_Part(2) = TextBox1.Text.Substring(9, 9)

                If e.KeyCode = Keys.Enter Then
                    If Barcode_Part(1) <> cmb_Pcode.SelectedValue Then
                        lbl_Msg.Text = "باركود الجزء البلاستك غير تابع لهذا الموديل"
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        TextBox1.Focus()
                        TextBox1.SelectAll()
                    Else
                        Dim Barcode_Part1(6) As String
                        Barcode_Part1(0) = TextBox1.Text.Substring(0, 7)
                        Barcode_Part1(1) = TextBox1.Text.Substring(7, 2)
                        Barcode_Part1(2) = TextBox1.Text.Substring(9, 7)
                        Barcode_Part1(3) = TextBox1.Text.Substring(16, 1)
                        Barcode_Part1(4) = TextBox1.Text.Substring(17, 1)
                        ff3.Text = Barcode_Part1(3)

                        lbl_Msg.ForeColor = Color.GreenYellow
                        Console.Beep()
                        lbl_Msg.Text = "تم تسجيل باركود الجزء البلاستك بنجاح  "
                        'Label10.Text = cmb_Pcode.SelectedValue
                        TextBox1.Enabled = False
                        txtBarcodeOne.Enabled = True
                        ' TxtheaterTwo.Enabled = True
                        txtBarcodeOne.Focus()
                        '  TxtheaterTwo.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class