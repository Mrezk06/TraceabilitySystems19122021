Imports System.IO
Imports TEVPBarcode.sher

Public Class frmRefrigerator_outPutLine

    Public Property StringPass As String

    Private Sub frmRefrigerator_outPutLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"

        Label6.Text = StringPass

        _Refresh315()
        lbl_Msg.ForeColor = Color.Green
        lbl_Msg.Text = "مرحبا بك فى برنامج مصنع الثلاجة لمتابعة الانتاج"
        cmb_Pcode.Enabled = True
        txtshift.Enabled = True
        Button2.Visible = False
        txtParts1.Visible = False
        GroupBox2.Visible = True
        Label10.Visible = False
        txtshift.Focus()
        txtshift.SelectAll()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtParts1.Text.Length < 8 Then Exit Sub


    End Sub


    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_ModelName,R_ColorName, count(R_Barcode) AS tot"
            sql += " FROM Refrigerator_OutputView "
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line='" & txtshift.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_C'"
            sql += " GROUP BY R_ModelName,R_ColorName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = " الموديل "

            ds.Tables("Refrigerator_OutputView").Columns(1).ColumnName = "اللون"
            ds.Tables("Refrigerator_OutputView").Columns(2).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("Refrigerator_OutputView")
            dg2.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            sql += " where Heater_Sap_Laber='" & Label6.Text & "'"
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

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtshift.Text = "" Then
            MsgBox("من فضلك تأكد من ادخال الوردية  ")
            Beep()
            Exit Sub
        Else
            Try
                _Refresh315()
                txtshift.Enabled = False
                txtParts1.Visible = False
                txtBarcodeOne.Enabled = True
                txtBarcodeOne.Focus()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged

    End Sub

    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim dsMax As New DataSet
                Dim Sql = "Select R_Barcode from Refrigerator_Output where R_Barcode='" & txtBarcodeOne.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الباركود تم تسجيله من قبل"
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                    Beep()
                    Exit Sub
                End If
                _Refresh1()



                If txtBarcodeOne.Text.Length = 17 Then
                    Dim Barcode_Part(17) As String
                    Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                    Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
                    Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
                    Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
                    Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
                    Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
                    Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 2)
                    '     Barcode_Part(7) = txtBarcodeOne.Text.Substring(15, 1)
                    Barcode_Part(7) = txtBarcodeOne.Text.Substring(16, 1)
                    'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)

                    Dim dsMaxz As New DataSet
                    Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & ""
                    Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                    dsMaxz.Tables.Clear()
                    daz.Fill(dsMaxz)
                    If dsMaxz.Tables(0).Rows.Count < 1 Then
                        lbl_Msg.Text = "باركود الثلاجة غير تابع لأى الموديل "
                        lbl_Msg.ForeColor = Color.Yellow
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                        Beep()
                    Else
                        Try
                            '  Dim sqlf As String = ""
                            Dim sqlf As String = " SELECT  R_ImagaePath FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & ""
                            Dim daf As New SqlClient.SqlDataAdapter(sqlf, cn)
                            Dim dsf As New DataSet
                            dsf.Tables.Clear()
                            daf.Fill(dsf, "Refrigerator_Models")
                            Label16.DataSource = dsf.Tables(0)
                            '  cmb_Pcode.ValueMember = "fLCDSetID"
                            Label16.DisplayMember = "R_ImagaePath"
                            Label16.Sorted = True
                            _Refresh1()
                        Catch ex As Exception

                        End Try

                        'Dim id As String = "22137471"
                        Dim folder As String = "C:\Users\mrezk06\Desktop\Ean Code\"
                        Dim filename As String = Path.Combine(Label16.Text)
                        Dim filename2 As String = System.IO.Path.Combine(folder + filename)
                        Try
                            Using fs As New System.IO.FileStream(filename2, IO.FileMode.Open)
                                PictureBox1.Image = New Bitmap(Image.FromStream(fs))
                            End Using
                        Catch ex As Exception
                            Dim msg As String = "Filename: " & filename2 &
                        Environment.NewLine & Environment.NewLine &
                        "Exception: " & ex.ToString
                            MessageBox.Show(msg, "Error Opening Image File")
                        End Try

                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل الثلاجه  بنجاح"
                        txtBarcodeOne.Enabled = False
                        TextBox1.Enabled = True
                        TextBox1.Focus()
                        _Refresh1()
                    End If

                    '    If Barcode_Part(6) = 1 Then
                    '        LBLColor.BackColor = Color.White
                    '        LBLColor.ForeColor = Color.Black
                    '        LBLColor.Text = "أبيض "

                    '    ElseIf Barcode_Part(6) = 2 Then
                    '        LBLColor.BackColor = Color.Silver
                    '        LBLColor.ForeColor = Color.Black
                    '        LBLColor.Text = "سلفر"
                    '    ElseIf Barcode_Part(6) = 3 Then
                    '        LBLColor.BackColor = Color.Moccasin
                    '        LBLColor.ForeColor = Color.Black
                    '        LBLColor.Text = "شمباين"
                    '    ElseIf Barcode_Part(6) = 4 Then
                    '        LBLColor.BackColor = Color.Black
                    '        LBLColor.ForeColor = Color.White
                    '        LBLColor.Text = "اسود "
                    '    ElseIf Barcode_Part(6) = 5 Then
                    '        LBLColor.BackColor = Color.SandyBrown
                    '        LBLColor.ForeColor = Color.Black
                    '        LBLColor.Text = "اسانلس"
                    '    ElseIf Barcode_Part(6) = 6 Then
                    '        LBLColor.BackColor = Color.Red
                    '        LBLColor.ForeColor = Color.Black

                    '        LBLColor.Text = "احمر "
                    '    ElseIf Barcode_Part(6) = 7 Then
                    '        LBLColor.BackColor = Color.Beige
                    '        LBLColor.ForeColor = Color.Black
                    '        LBLColor.Text = "بيج"

                    '    Else

                    '        LBLColor.ForeColor = System.Drawing.Color.Black

                    '    End If

                    'Else
                    '    LBLColor.ForeColor = Color.Gainsboro
                    '    LBLColor.Text = "هذا الباركود غير تابع لمصنع الثلاجة"
                    '    Beep()
                End If


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Try


            If e.KeyCode = Keys.Enter Then


                If TextBox1.Text = txtBarcodeOne.Text Then
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل باركود الكرتونة بنجاح"
                    txtBarcodeOne.Enabled = False
                    TextBox1.Enabled = False
                    txtEanCode.Enabled = True
                    txtEanCode.Focus()
                Else
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "باركود الكارتونة غير مطابق باركود الثلاجة"
                    txtBarcodeOne.Enabled = False
                    TextBox1.Enabled = True
                    '     txtDoorBig.Enabled = True
                    TextBox1.SelectAll()
                    TextBox1.Focus()
                    Beep()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDoorBig_TextChanged(sender As Object, e As EventArgs) Handles txtDoorBig.TextChanged

    End Sub

    Private Sub txtDoorBig_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDoorBig.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                If txtDoorBig.Text = TextBox1.Text Then
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل باركود الكرتونة بنجاح"
                    txtBarcodeOne.Enabled = False
                    TextBox1.Enabled = False
                    txtDoorBig.Enabled = False
                    txtEanCode.Enabled = True

                    txtEanCode.Focus()
                    txtEanCode.SelectAll()
                Else
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "باركود الكارتونة غير مطابق باركود الثلاجة"
                    txtBarcodeOne.Enabled = False
                    txtDoorBig.Enabled = True
                    '     txtDoorBig.Enabled = True

                    txtDoorBig.Focus()
                    Beep()
                    txtDoorBig.SelectAll()
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtStaker_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtStaker_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Dim Barcode_Part(17) As String
            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
            Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
            Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
            Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
            Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
            Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 1)
            Barcode_Part(7) = txtBarcodeOne.Text.Substring(15, 1)
            Barcode_Part(8) = txtBarcodeOne.Text.Substring(16, 1)
            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)

            Dim dsMaxz As New DataSet
            Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode,R_EanCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & " and  R_EanCode ='" & txtEanCode.Text & "' "
            Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
            dsMaxz.Tables.Clear()
            daz.Fill(dsMaxz)
            If dsMaxz.Tables(0).Rows.Count < 1 Then
                lbl_Msg.Text = "باركود استيكر الطاقه الخاص بالثلاجة غير تابع لهذا الموديل "
                lbl_Msg.ForeColor = Color.Yellow
                txtEanCode.Focus()
                txtEanCode.SelectAll()
                Beep()

            Else
                Dim sqlb As String
                sqlb = "INSERT INTO Refrigerator_Output"
                sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line)"
                '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_C','" & txtEanCode.Text & "'," & txtParts1.Text & ",'" & txtshift.Text & "')"
                Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmdb.ExecuteNonQuery()
                cn.Close()

                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "تم تسجيل باركود الثلاجة بنجاح"
                txtBarcodeOne.Enabled = True
                TextBox1.Enabled = False
                txtDoorBig.Enabled = False
                txtEanCode.Enabled = False

                txtBarcodeOne.Text = ""
                TextBox1.Text = ""
                txtDoorBig.Text = ""
                txtEanCode.Text = ""
                txtBarcodeOne.Focus()

                _Refresh1()
            End If
        End If

    End Sub

    Private Sub txtEanCode_TextChanged(sender As Object, e As EventArgs) Handles txtEanCode.TextChanged

    End Sub

    Private Sub txtEanCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEanCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Barcode_Part(8) As String
            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
            Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
            Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
            Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
            Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
            Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 1)
            Barcode_Part(7) = txtBarcodeOne.Text.Substring(15, 1)
            Barcode_Part(8) = txtBarcodeOne.Text.Substring(16, 1)
            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)

            Dim dsMaxz As New DataSet
            Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode,R_EanCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & " and  R_EanCode ='" & txtEanCode.Text & "' "
            Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
            dsMaxz.Tables.Clear()
            daz.Fill(dsMaxz)
            If dsMaxz.Tables(0).Rows.Count < 1 Then
                lbl_Msg.Text = "باركود استيكر الطاقه الخاص بالثلاجة غير تابع لهذا الموديل "
                lbl_Msg.ForeColor = Color.Yellow
                txtEanCode.Focus()
                txtEanCode.SelectAll()
                Beep()

            Else
                Dim sqlb As String
                sqlb = "INSERT INTO Refrigerator_Output"
                sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line)"
                '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_C','" & txtEanCode.Text & "'," & Label6.Text & ",'" & txtshift.Text & "')"
                Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmdb.ExecuteNonQuery()
                cn.Close()

                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "تم تسجيل باركود الثلاجة بنجاح"
                txtBarcodeOne.Enabled = True
                TextBox1.Enabled = False
                txtDoorBig.Enabled = False
                txtEanCode.Enabled = False

                txtBarcodeOne.Text = ""
                TextBox1.Text = ""
                txtDoorBig.Text = ""
                txtEanCode.Text = ""
                txtBarcodeOne.Focus()

                _Refresh1()
            End If
        End If

    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        txtBarcodeOne.Enabled = True
        TextBox1.Enabled = False
        txtDoorBig.Enabled = False
        txtEanCode.Enabled = False

        txtBarcodeOne.Text = ""
        TextBox1.Text = ""
        txtDoorBig.Text = ""
        txtEanCode.Text = ""
        txtBarcodeOne.Focus()
    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New RefrigeratorOutPutQuery
        frm.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class