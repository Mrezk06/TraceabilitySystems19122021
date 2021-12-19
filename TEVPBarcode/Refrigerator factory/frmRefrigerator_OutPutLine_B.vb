
Imports System.Data.SqlClient
Imports System.IO
Imports TEVPBarcode.sher

Public Class frmRefrigerator_OutPutLine_B
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (R_Barcode)as qty"
            sql += " FROM Refrigerator_OutputNG"
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line ='" & txtshift.Text & "'"
            'sql += " and fLCDPline = '4' "
            ' sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputNG")
            ds.Tables("Refrigerator_OutputNG").Columns(0).ColumnName = "عدد الاخطاء "
            DataGridView1.DataSource = ds.Tables("Refrigerator_OutputNG")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Public Property StringPass As String
    '  DateTimePicker1.value = Format(time.Now)
    Private Sub frmRefrigerator_outPutLine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '     Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        Dim timno As String = DateTime.Now.ToString("HH:mm tt")
        Try
            Dim sql As String = ""
            sql += "SELECT F_ShiftCode FROM  Refrigerator_Shift "
            sql += "WHERE ('" & timno & "' BETWEEN F_TimeFrom AND F_TimeTo)"
            '   sql += "WHERE (" & timno & " BETWEEN F_TimeFrom AND F_TimeTo)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Refrigerator_Shift")
            txtshift.DataSource = ds.Tables(0)
            '   txtshift.ValueMember = "CEanCode"
            txtshift.DisplayMember = "F_ShiftCode"
            txtshift.Sorted = True
            If txtshift.Text = "" Then
                txtshift.Text = "C"
            End If
        Catch ex As Exception
        End Try
        Label6.Text = StringPass

        _Refresh315()
        lbl_Msg.ForeColor = Color.Green
        lbl_Msg.Text = "مرحبا بك فى برنامج مصنع الثلاجة لمتابعة الانتاج"
        txtBarcodeOne.Enabled = False
        TextBox1.Enabled = False
        txtEanCode.Enabled = False
        Button2.Visible = False
        txtParts1.Visible = False
        GroupBox2.Visible = True
        Label10.Visible = False
        txtBarcodeOne.Enabled = True
        txtBarcodeOne.Focus()
        txtBarcodeOne.SelectAll()

    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT R_ModelName,R_ColorName,count(R_Barcode),R_ProductionType"
            sql += " FROM Refrigerator_OutputView "
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line='" & txtshift.Text & "'"
            sql += " and R_FactoryCode='Refrigerator_B'"
            sql += " GROUP BY R_ModelName,R_ColorName,R_ProductionType "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_OutputView")
            ds.Tables("Refrigerator_OutputView").Columns(0).ColumnName = " الموديل "
            ds.Tables("Refrigerator_OutputView").Columns(1).ColumnName = "اللون"
            ds.Tables("Refrigerator_OutputView").Columns(2).ColumnName = "الكمية"
            ds.Tables("Refrigerator_OutputView").Columns(3).ColumnName = "نوع الانتاج"
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
                Dim Barcode_Part(17) As String
                Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
                Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
                Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
                Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
                Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
                Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 2)
                Barcode_Part(7) = txtBarcodeOne.Text.Substring(16, 1)

                Dim dsMax As New DataSet
                Dim Sql = "Select R_Barcode from Refrigerator_Output where R_Barcode='" & txtBarcodeOne.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.White
                    lbl_Msg.BackColor = Color.Red
                    lbl_Msg.Text = "الباركود تم تسجيله من قبل"

                    Dim sqlb As String
                    sqlb = "INSERT INTO Refrigerator_OutputNG"
                    sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line, R_Carton,R_STATUS)"
                    '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                    sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_B','" & txtEanCode.Text & "','" & txtParts1.Text & "','" & txtshift.Text & "','" & TextBox1.Text & "','الباركود تم تسجيله من قبل')"
                    Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmdb.ExecuteNonQuery()
                    cn.Close()
                    _Refresh13()
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                    Beep()
                    Exit Sub
                End If
                _Refresh1()

                If txtBarcodeOne.Text.Length = 17 Then

                    ff2.Text = Barcode_Part(5)
                    Dim dsMaxz As New DataSet
                    Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & ""
                    Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                    dsMaxz.Tables.Clear()
                    daz.Fill(dsMaxz)
                    If dsMaxz.Tables(0).Rows.Count < 1 Then
                        lbl_Msg.Text = "باركود الثلاجة غير تابع لأى الموديل "
                        lbl_Msg.ForeColor = Color.White
                        lbl_Msg.BackColor = Color.Red
                        Dim sqlb As String
                        sqlb = "INSERT INTO Refrigerator_OutputNG"
                        sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line, R_Carton,R_STATUS)"
                        '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                        sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_B','" & txtEanCode.Text & "','" & txtParts1.Text & "','" & txtshift.Text & "','" & TextBox1.Text & "','باركود الثلاجة غير تابع لأى الموديل ')"
                        Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                        If cn.State = ConnectionState.Closed Then cn.Open()
                        cmdb.ExecuteNonQuery()
                        cn.Close()
                        _Refresh13()
                        txtBarcodeOne.Focus()
                        txtBarcodeOne.SelectAll()
                        Beep()

                    Else
                        Try
                            'Dim command1 As New SqlCommand("Select R_ImagaeSourse as Image from Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & "", cn)
                            'Dim adapter As New SqlDataAdapter(command1)
                            'Dim table As New DataTable()
                            'adapter.Fill(table)
                            'DataGridView1.AllowUserToAddRows = False
                            'DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                            ''DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            'DataGridView1.RowTemplate.Height = 130
                            'Dim pic1 As New DataGridViewImageColumn
                            'DataGridView1.DataSource = table
                            'pic1 = DataGridView1.Columns(0)
                            'pic1.ImageLayout = DataGridViewImageCellLayout.Normal
                            Using cmduu As SqlCommand = New SqlCommand("Select R_ImagaeSourse as Image from Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & "", cn)
                                '    cmd.Parameters.AddWithValue("@R_ImagaeSourse", PictureBox1.Image)
                                cn.Open()
                                Dim bytes As Byte() = CType(cmduu.ExecuteScalar(), Byte())
                                cn.Close()
                                PictureBox1.Image = Image.FromStream(New MemoryStream(bytes))
                            End Using
                        Catch ex As Exception
                        End Try
                        lbl_Msg.ForeColor = Color.Black
                        lbl_Msg.BackColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل الثلاجه  بنجاح"
                        txtBarcodeOne.Enabled = False
                        TextBox1.Enabled = True
                        TextBox1.Focus()
                        TextBox1.SelectAll()
                        _Refresh1()
                    End If
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
                    lbl_Msg.ForeColor = Color.Black
                    lbl_Msg.BackColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل باركود الكرتونة بنجاح"
                    txtBarcodeOne.Enabled = False
                    TextBox1.Enabled = False
                    txtDoorBig.Enabled = False
                    txtEanCode.Enabled = True


                    txtEanCode.Focus()
                    txtEanCode.SelectAll()
                Else
                    lbl_Msg.ForeColor = Color.White
                    lbl_Msg.BackColor = Color.Red
                    lbl_Msg.Text = "باركود الكارتونة غير مطابق باركود الثلاجة"
                    txtBarcodeOne.Enabled = False
                    txtDoorBig.Enabled = True
                    Dim Barcode_Part(17) As String
                    Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                    Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
                    Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
                    Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
                    Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
                    Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
                    Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 2)
                    Barcode_Part(7) = txtBarcodeOne.Text.Substring(16, 1)
                    Dim sqlb As String
                    sqlb = "INSERT INTO Refrigerator_OutputNG"
                    sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line, R_Carton,R_STATUS)"
                    '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                    sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_B','" & txtEanCode.Text & "','" & txtParts1.Text & "','" & txtshift.Text & "','" & TextBox1.Text & "','باركود الكارتونة غير مطابق باركود الثلاجة')"
                    Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmdb.ExecuteNonQuery()
                    cn.Close()

                    txtDoorBig.Focus()
                    Beep()
                    _Refresh13()
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
            Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 2)
            '    Barcode_Part(7) = txtBarcodeOne.Text.Substring(15, 1)
            Barcode_Part(7) = txtBarcodeOne.Text.Substring(16, 1)
            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)

            Dim dsMaxz As New DataSet
            Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode,R_EanCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & " and  R_EanCode ='" & txtEanCode.Text & "' "
            Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
            dsMaxz.Tables.Clear()
            daz.Fill(dsMaxz)
            If dsMaxz.Tables(0).Rows.Count < 1 Then
                lbl_Msg.Text = "باركود استيكر الطاقه الخاص بالثلاجة غير تابع لهذا الموديل "
                lbl_Msg.ForeColor = Color.White
                lbl_Msg.BackColor = Color.Red


                Dim sqlb As String
                sqlb = "INSERT INTO Refrigerator_OutputNG"
                sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line, R_Carton,R_STATUS)"
                '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_B','" & txtEanCode.Text & "','" & txtParts1.Text & "','" & txtshift.Text & "','" & TextBox1.Text & "','باركود استيكر الطاقه الخاص بالثلاجة غير تابع لهذا الموديل')"
                Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmdb.ExecuteNonQuery()
                cn.Close()
                txtEanCode.Focus()
                txtEanCode.SelectAll()
                Beep()
                _Refresh13()
            Else
                Dim sqlb As String
                sqlb = "INSERT INTO Refrigerator_Output"
                sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line, R_Carton)"
                '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_B','" & txtEanCode.Text & "'," & txtParts1.Text & ",'" & txtshift.Text & "','" & TextBox1.Text & "')"
                Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmdb.ExecuteNonQuery()
                cn.Close()

                lbl_Msg.ForeColor = Color.Black
                lbl_Msg.BackColor = Color.GreenYellow
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
        '  Try


        If e.KeyCode = Keys.Enter Then
            Dim Barcode_Part(8) As String
            Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
            Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
            Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
            Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
            Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
            Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
            Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 2)
            '   Barcode_Part(7) = txtBarcodeOne.Text.Substring(15, 1)
            Barcode_Part(7) = txtBarcodeOne.Text.Substring(16, 1)
            'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)

            Dim dsMaxz As New DataSet
            Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode,R_EanCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & " and  R_EanCode ='" & txtEanCode.Text & "' "
            Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
            dsMaxz.Tables.Clear()
            daz.Fill(dsMaxz)
            If dsMaxz.Tables(0).Rows.Count < 1 Then
                lbl_Msg.Text = "باركود استيكر اللون الخاص بالثلاجة غير تابع لهذا الموديل "
                lbl_Msg.ForeColor = Color.White
                lbl_Msg.BackColor = Color.Red

                Dim sqlb As String
                sqlb = "INSERT INTO Refrigerator_OutputNG"
                sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line, R_Carton,R_STATUS)"
                '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_B','" & txtEanCode.Text & "','" & txtParts1.Text & "','" & txtshift.Text & "','" & TextBox1.Text & "','باركود استيكر اللون الخاص بالثلاجة غير تابع لهذا الموديل ')"
                Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmdb.ExecuteNonQuery()
                cn.Close()
                txtEanCode.Focus()
                txtEanCode.SelectAll()
                Beep()
                _Refresh13()
            Else
                Dim sqlb As String
                sqlb = "INSERT INTO Refrigerator_Output"
                sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line,R_Carton)"
                '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_B','" & txtEanCode.Text & "','" & Label6.Text & "','" & txtshift.Text & "','" & TextBox1.Text & "')"
                Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmdb.ExecuteNonQuery()
                cn.Close()

                lbl_Msg.ForeColor = Color.Black
                lbl_Msg.BackColor = Color.GreenYellow
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
        'Catch ex As Exception

        'End Try
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


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        Try


            If e.KeyCode = Keys.Enter Then
                If txtBarcodeOne.Text.Length = 17 Then

                    Dim dsMax As New DataSet
                    Dim Sql = " SELECT  R_ModelControl,R_ColorCode,R_Carton FROM Refrigerator_Models  where  R_ModelControl ='" & ff2.Text & "'  And  R_Carton ='" & TextBox1.Text & "'"
                    Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                    dsMax.Tables.Clear()
                    da.Fill(dsMax)
                    If dsMax.Tables(0).Rows.Count <= 0 Then
                        lbl_Msg.ForeColor = Color.White
                        lbl_Msg.BackColor = Color.Red
                        lbl_Msg.Text = "باركود الكرتونه غير تابع لهذا الموديل"

                        Dim Barcode_Part(17) As String
                        Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                        Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
                        Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
                        Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
                        Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
                        Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
                        Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 2)
                        '    Barcode_Part(7) = txtBarcodeOne.Text.Substring(15, 1)
                        Barcode_Part(7) = txtBarcodeOne.Text.Substring(16, 1)
                        'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)
                        Dim sqlb As String
                        sqlb = "INSERT INTO Refrigerator_OutputNG"
                        sqlb += "(R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_EanCode, R_SapUser, R_Line, R_Carton,R_STATUS)"
                        '  sqlb += "( R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Door1, R_Door2, R_Staker, R_SapUser, R_Line)"
                        sqlb += "VALUES    ('" & txtBarcodeOne.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','Refrigerator_B','" & txtEanCode.Text & "','" & txtParts1.Text & "','" & txtshift.Text & "','" & TextBox1.Text & "','باركود الكرتونه غير تابع لهذا الموديل ')"
                        Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                        If cn.State = ConnectionState.Closed Then cn.Open()
                        cmdb.ExecuteNonQuery()
                        cn.Close()
                        TextBox1.Focus()
                        TextBox1.SelectAll()
                        Beep()
                        _Refresh13()
                        Exit Sub

                    Else
                        lbl_Msg.ForeColor = Color.Black
                        lbl_Msg.BackColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل باركود الكرتونة بنجاح"
                        txtBarcodeOne.Enabled = False
                        TextBox1.Enabled = False
                        txtEanCode.Enabled = True
                        txtEanCode.Focus()
                    End If


                End If

            End If
        Catch ex As Exception

        End Try
        'Try
        '    If e.KeyCode = Keys.Enter Then
        '        Dim Barcode_Part(6) As String
        '        Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
        '        Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
        '        Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
        '        Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
        '        Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
        '        Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
        '        Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 2)
        '        Barcode_Part(7) = txtBarcodeOne.Text.Substring(16, 1)
        '        Dim dsMaxz As New DataSet
        '        Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode,R_Carton FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & " And  R_Carton ='" & TextBox1.Text & "'"
        '        Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
        '        dsMaxz.Tables.Clear()
        '        daz.Fill(dsMaxz)

        '        If dsMaxz.Tables(0).Rows.Count < 1 Then
        '            lbl_Msg.Text = "باركود الكرتونه غير تابع لهذا الموديل "
        '            lbl_Msg.ForeColor = Color.Yellow
        '            TextBox1.Focus()
        '            TextBox1.SelectAll()
        '            Beep()
        '        Else
        '            lbl_Msg.ForeColor = Color.GreenYellow
        '            lbl_Msg.Text = "تم تسجيل الكرتونه بنجاح"
        '            txtBarcodeOne.Enabled = False
        '            TextBox1.Enabled = False
        '            txtEanCode.Enabled = True
        '            txtEanCode.Focus()
        '            txtEanCode.SelectAll()
        '            _Refresh1()
        '        End If
        '    End If

        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)

        If (e.RowIndex < 0 Or e.ColumnIndex < 0) Then Return

        If DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).ValueType = GetType(Byte()) Then
            CType(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex),
              DataGridViewImageCell).ImageLayout = DataGridViewImageCellLayout.Zoom
        End If

    End Sub

    Private Sub dgdd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class