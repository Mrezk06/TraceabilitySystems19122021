Imports TEVPBarcode.sher
Public Class frmRefrigerator_Body_Completed
    Public Property StringPass1 As String
    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub frmRefrigerator_Body_Completed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        cmb_Pcode.Enabled = False
        ' txtline.Enabled = False
        txtshift.Enabled = False
        txtBarcodeOne1.Enabled = False

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
        Label2.Text = StringPass1

        _Refresh315()
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
        txtshift.SelectAll()

    End Sub

    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += "select R_ModelName, R_ColorName,count( R_Barcode)"
            sql += " FROM Refrigerator_InputView  "
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line='" & txtshift.Text & "'"
            sql += " and R_FactoryCode ='C'"
            sql += " group by R_ModelName, R_ColorName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = "الموديل "
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = " اللون"
            ds.Tables("Refrigerator_InputView").Columns(2).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("Refrigerator_InputView")
            dg2.AllowUserToAddRows = False
            Return True

        Catch ex As Exception

        End Try

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If txtParts1.Text.Length < 8 Then Exit Sub

        'Dim dsMax As New DataSet
        'Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap "
        'Sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
        'Sql += " and Heater_sap_stu='Active'"
        'Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        'dsMax.Tables.Clear()
        'da.Fill(dsMax)
        'If dsMax.Tables(0).Rows.Count < 1 Then
        '    lbl_Msg.ForeColor = Color.Red
        '    lbl_Msg.Text = "غير مصرح لك بالدخول"
        '    txtParts1.Focus()
        '    txtParts1.SelectAll()
        '    Exit Sub
        'Else

        'End If
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & Label2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "أسم المسئول "

            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            DGN.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtshift.Text = "" Then

            MsgBox("من فضلك تأكد من ادخال الخط والموديل ")

            Exit Sub
        Else
            Try
                _Refresh315()

                txtshift.Enabled = False
                txtshift.Visible = False
                Label8.Visible = False
                txtParts1.Visible = False

                btnStart.Visible = False
                txtBarcodeOne1.Enabled = True

                txtBarcodeOne1.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtBarcodeOne1_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne1.TextChanged

    End Sub

    Private Sub txtBarcodeOne1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim dsMax As New DataSet
                Dim Sql = "Select R_Barcode from Refrigerator_Input where R_Barcode='" & txtBarcodeOne1.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الباركود تم تسجيله من قبل"
                    txtBarcodeOne1.Focus()
                    txtBarcodeOne1.SelectAll()
                    Exit Sub
                End If
                _Refresh1()

                If txtBarcodeOne1.Text.Length = 17 Then
                    Dim Barcode_Part(17) As String
                    Barcode_Part(0) = txtBarcodeOne1.Text.Substring(0, 5)
                    Barcode_Part(1) = txtBarcodeOne1.Text.Substring(5, 1)
                    Barcode_Part(2) = txtBarcodeOne1.Text.Substring(6, 2)
                    Barcode_Part(3) = txtBarcodeOne1.Text.Substring(8, 1)
                    Barcode_Part(4) = txtBarcodeOne1.Text.Substring(9, 3)
                    Barcode_Part(5) = txtBarcodeOne1.Text.Substring(12, 2)
                    Barcode_Part(6) = txtBarcodeOne1.Text.Substring(14, 1)
                    Barcode_Part(7) = txtBarcodeOne1.Text.Substring(15, 1)
                    Barcode_Part(8) = txtBarcodeOne1.Text.Substring(16, 1)
                    'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)

                    Dim dsMaxz As New DataSet
                    Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode FROM Refrigerator_Models  where  R_ModelControl ='" & Barcode_Part(5) & "' And R_ColorCode =" & Barcode_Part(6) & ""
                    Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                    dsMaxz.Tables.Clear()
                    daz.Fill(dsMaxz)
                    If dsMaxz.Tables(0).Rows.Count < 1 Then
                        lbl_Msg.Text = "باركود الثلاجة غير تابع لأى الموديل "
                        lbl_Msg.ForeColor = Color.Yellow
                        txtBarcodeOne1.Focus()
                        txtBarcodeOne1.SelectAll()
                    Else
                        Dim sqlb As String
                        sqlb = "INSERT INTO Refrigerator_Input"
                        sqlb += "(  R_Barcode, R_ProductionType, R_Order_Num, R_1st_Class, R_Serail, R_ModelControl, R_ColorCode, R_FactoryCode, R_Line, R_SapUser)"
                        sqlb += "VALUES    ('" & txtBarcodeOne1.Text & "','" & Barcode_Part(1) & "','" & Barcode_Part(2) & "','" & Barcode_Part(3) & "','" & Barcode_Part(4) & "','" & Barcode_Part(5) & "','" & Barcode_Part(6) & "','" & Barcode_Part(8) & "','" & txtshift.Text & "','" & Label2.Text & "')"
                        Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                        If cn.State = ConnectionState.Closed Then cn.Open()
                        cmdb.ExecuteNonQuery()
                        cn.Close()
                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل الثلاجه  بنجاح"
                        txtBarcodeOne1.Text = ""
                        txtBarcodeOne1.Focus()
                        _Refresh1()


                        '' _Refresh1()
                    End If
                Else
                    lbl_Msg.Text = "هذا الباركود غير تابع لمصنع الثلاجة"
                End If


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New frmRefrigerator_Body_CompletedQuery
        frm.Show()

    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged

    End Sub
End Class