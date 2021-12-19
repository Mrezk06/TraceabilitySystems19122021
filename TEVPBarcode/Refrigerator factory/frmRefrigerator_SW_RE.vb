Imports TEVPBarcode.sher

Public Class frmRefrigerator_SW_RE



    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New RefrigeratorDoorQuery
        frm.Show()
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_ModelName,R_ColorName, count(R_Barcode) AS tot"
            sql += " FROM Refrigerator_DoorFollowView "
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line='" & txtshift.Text & "'"
            sql += " GROUP BY R_ModelName,R_ColorName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = " الموديل "

            ds.Tables("Refrigerator_DoorFollowView").Columns(1).ColumnName = "اللون"
            ds.Tables("Refrigerator_DoorFollowView").Columns(2).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg2.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Function _Refresh133(ByVal Sireal As String) As Boolean
    '    Try
    '        Dim dsMax1 As New DataSet
    '        Dim Sql1 = "SELECT  isnull(count(H_PCB_C),0) FROM Heater_registration_Two1 where "
    '        Sql1 += "  H_PCB_C ='" & Sireal & "'"
    '        Sql1 += " or H_PCB_P ='" & Sireal & "'"
    '        ' Sql1 += " or power ='" & Sireal & "'"
    '        ' Sql += " and fNameL='" & ComboBox2.Text & "'"
    '        Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
    '        dsMax1.Tables.Clear()
    '        da1.Fill(dsMax1)
    '        If dsMax1.Tables(0).Rows(0).Item(0) > 0 Then
    '            lbl_Msg.ForeColor = Color.Red
    '            lbl_Msg.Text = "This component is Used in other Heater "
    '            txtDoorMin.SelectAll()
    '            txtDoorMin.Focus()


    '            Return True
    '        Else
    '            Return False
    '        End If


    '    Catch ex As Exception
    '    End Try
    'End Function
    Public Property StringPass3 As String
    Private Sub frmHeaterStepTwoOfflinReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        txtBarcodeOne.Enabled = False
        TextBox1.Enabled = False
        GroupBox2.Visible = False
        txtDoorBig.Enabled = False
        txtStaker.Enabled = False
        txtshift.Enabled = False
        cmb_Pcode.Enabled = False

        lbl_Msg.ForeColor = Color.Green
        lbl_Msg.Text = "مرحبا بك فى برنامج مصنع الثلاجة لمتابعة الانتاج"
        cmb_Pcode.Enabled = True
        ' txtline.Enabled = False
        txtshift.Enabled = True
        'txtshift.Visible = False
        Button2.Visible = False
        txtParts1.Visible = False
        GroupBox2.Visible = True
        Label10.Visible = False
        '  Label9.Visible = False
        txtshift.Focus()
        Label6.Text = StringPass3
        _Refresh315()
    End Sub
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
    'Private Function _Refresh11() As Boolean
    '    Try

    '        Dim sql1 As String = " SELECT component_Name, component_Control,CONVERT(bit,0) as Found FROM Heater_component "
    '        sql1 += " where Model_Name ='" & cmb_Pcode.Text & "'"

    '        sql1 += " and step_visual = 'ST2' "
    '        Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Heater_component")
    '        'ds.Tables("Matrel").Columns(0).ColumnName = "الكود "
    '        'ds.Tables("Material").Columns(0).ColumnName = "V_Code"
    '        ds.Tables("Heater_component").Columns(0).ColumnName = "Name"
    '        ds.Tables("Heater_component").Columns(1).ColumnName = "part"
    '        dg1.DataSource = ds.Tables("Heater_component")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    'Dim s As Integer
    'Dim i As Integer

    Private Sub TxtheaterTwo_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged
        'Try
        '    _Refresh1()
        '    txtBarcodeOne.Text = ""
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        ' End If
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtshift.Text = "" Then

            MsgBox("  من فضلك تأكد من ادخال الخط  ")

            Exit Sub
        Else
            Try
                _Refresh315()

                txtshift.Enabled = False



                ''          btnStart.Visible = False
                txtBarcodeOne.Enabled = True

                txtBarcodeOne.Focus()
                txtBarcodeOne.SelectAll()


            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtDoorMin_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub txtDoorBig_TextChanged(sender As Object, e As EventArgs) Handles txtDoorBig.TextChanged

    End Sub

    Private Sub txtDoorBig_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDoorBig.KeyDown
        Try
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
                Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode,R_Door2 FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & " and  R_Door2 ='" & txtDoorBig.Text & "' "
                Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                dsMaxz.Tables.Clear()
                daz.Fill(dsMaxz)
                If dsMaxz.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.Text = "باركود الباب الكبير الخاص بالثلاجة غير تابع لهذا الموديل "
                    lbl_Msg.ForeColor = Color.Red
                    txtDoorBig.Focus()
                    txtDoorBig.SelectAll()

                Else

                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل باركود الباب الكبير بنجاح"
                    txtBarcodeOne.Enabled = False
                    TextBox1.Enabled = False
                    txtDoorBig.Enabled = False
                    txtStaker.Enabled = True
                    txtStaker.Focus()
                End If
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub txtStaker_TextChanged(sender As Object, e As EventArgs) Handles txtStaker.TextChanged

    End Sub

    Private Sub txtStaker_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStaker.KeyDown
        '  Try
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
                Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode,R_Door2 FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & " and  R_Staker ='" & txtStaker.Text & "' "
                Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                dsMaxz.Tables.Clear()
                daz.Fill(dsMaxz)
                If dsMaxz.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.Text = "باركود استيكر الطاقه الخاص بالثلاجة غير تابع لهذا الموديل "
                    lbl_Msg.ForeColor = Color.Yellow
                txtStaker.Focus()
                txtStaker.SelectAll()

            Else
                    Dim sqlb As String
                sqlb = "INSERT INTO Refrigerator_FollowUpDoor"
                sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','" & Barcode_Part(8) & "','" & TextBox1.Text & "','" & txtDoorBig.Text & "','" & txtStaker.Text & "'," & Label6.Text & ",'" & txtshift.Text & "')"
                Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmdb.ExecuteNonQuery()
                    cn.Close()

                    lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "تم تسجيل باركود الثلاجة بنجاح"
                txtBarcodeOne.Enabled = True
                TextBox1.Enabled = False
                txtDoorBig.Enabled = False
                    txtStaker.Enabled = False

                    txtBarcodeOne.Text = ""
                TextBox1.Text = ""
                txtDoorBig.Text = ""
                    txtStaker.Text = ""
                    txtBarcodeOne.Focus()
                End If
            End If
        _Refresh1()
        '  End Try
    End Sub

    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim dsMax As New DataSet
                Dim Sql = "Select R_Barcode from Refrigerator_FollowUpDoor where R_Barcode='" & txtBarcodeOne.Text & "'"
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
                _Refresh1()

                If txtBarcodeOne.Text.Length = 17 Then
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
                    Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & ""
                    Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                    dsMaxz.Tables.Clear()
                    daz.Fill(dsMaxz)
                    If dsMaxz.Tables(0).Rows.Count < 1 Then
                        lbl_Msg.Text = "باركود الثلاجة غير تابع لأى الموديل "
                        lbl_Msg.ForeColor = Color.Yellow
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                    Else


                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل الثلاجه  بنجاح"
                        txtBarcodeOne.Enabled = False
                        TextBox1.Enabled = True
                        TextBox1.Focus()
                        _Refresh1()
                    End If

                    If Barcode_Part(6) = 1 Then
                        LBLColor.BackColor = Color.White
                        LBLColor.ForeColor = Color.Black
                        LBLColor.Text = "أبيض "

                    ElseIf Barcode_Part(6) = 2 Then
                        LBLColor.BackColor = Color.Silver
                        LBLColor.ForeColor = Color.Black
                        LBLColor.Text = "سلفر"
                    ElseIf Barcode_Part(6) = 3 Then
                        LBLColor.BackColor = Color.Moccasin
                        LBLColor.ForeColor = Color.Black
                        LBLColor.Text = "شمباين"
                    ElseIf Barcode_Part(6) = 4 Then
                        LBLColor.BackColor = Color.Black
                        LBLColor.ForeColor = Color.White
                        LBLColor.Text = "اسود "
                    ElseIf Barcode_Part(6) = 5 Then
                        LBLColor.BackColor = Color.SandyBrown
                        LBLColor.ForeColor = Color.Black
                        LBLColor.Text = "اسانلس"
                    ElseIf Barcode_Part(6) = 6 Then
                        LBLColor.BackColor = Color.Red
                        LBLColor.ForeColor = Color.Black

                        LBLColor.Text = "احمر "
                    ElseIf Barcode_Part(6) = 7 Then
                        LBLColor.BackColor = Color.Beige
                        LBLColor.ForeColor = Color.Black
                        LBLColor.Text = "بيج"
                    Else

                        LBLColor.ForeColor = System.Drawing.Color.Black

                    End If

                Else
                    LBLColor.ForeColor = Color.Gainsboro
                    LBLColor.Text = "هذا الباركود غير تابع لمصنع الثلاجة"
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
                Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & " and  R_Door1 ='" & TextBox1.Text & "' "
                Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                dsMaxz.Tables.Clear()
                daz.Fill(dsMaxz)
                If dsMaxz.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.Text = "باركود باب الثلاجة غير تابع لهذا الموديل "
                    lbl_Msg.ForeColor = Color.Yellow
                    TextBox1.Focus()
                    TextBox1.SelectAll()

                Else
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل باركود الباب الصغير بنجاح"
                    txtBarcodeOne.Enabled = False
                    TextBox1.Enabled = False
                    txtDoorBig.Enabled = True
                    txtDoorBig.Focus()
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        txtBarcodeOne.Enabled = True
        TextBox1.Enabled = False
        txtDoorBig.Enabled = False
        txtStaker.Enabled = False

        txtBarcodeOne.Text = ""
        TextBox1.Text = ""
        txtDoorBig.Text = ""
        txtStaker.Text = ""
        txtBarcodeOne.Focus()
    End Sub
End Class