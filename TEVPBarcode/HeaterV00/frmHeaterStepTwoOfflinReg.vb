Imports TEVPBarcode.sher
Public Class frmHeaterStepTwoOfflinReg

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New frmHeaterStepTwoOfflinQuery
        frm.Show()
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT H_Model_Name, count(H_Heater_Code) AS tot"
            sql += " FROM Heater_registration_Two1 "
            sql += " WHERE H_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and H_Shift_Line='" & txtshift.Text & "'"
            sql += " GROUP BY H_Model_Name "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_registration_Two1")
            ds.Tables("Heater_registration_Two1").Columns(0).ColumnName = " الموديل "
            ds.Tables("Heater_registration_Two1").Columns(1).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("Heater_registration_Two1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh133(ByVal Sireal As String) As Boolean
        Try
            Dim dsMax1 As New DataSet
            Dim Sql1 = "SELECT  isnull(count(H_PCB_C),0) FROM Heater_registration_Two1 where "
            Sql1 += "  H_PCB_C ='" & Sireal & "'"
            Sql1 += " or H_PCB_P ='" & Sireal & "'"
            ' Sql1 += " or power ='" & Sireal & "'"
            ' Sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
            dsMax1.Tables.Clear()
            da1.Fill(dsMax1)
            If dsMax1.Tables(0).Rows(0).Item(0) > 0 Then
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "This component is Used in other Heater "
                TxtheaterTwo.SelectAll()
                TxtheaterTwo.Focus()


                Return True
            Else
                Return False
            End If


        Catch ex As Exception
        End Try
    End Function
    Private Sub frmHeaterStepTwoOfflinReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        txtBarcodeOne.Enabled = False
        TxtheaterTwo.Enabled = False
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
            cmb_Pcode.DisplayMember = "Model_Name"
            cmb_Pcode.Sorted = True
            _Refresh1()
        Catch ex As Exception
        End Try
    End Sub
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
                txtshift.Enabled = True
                GroupBox2.Visible = True
                Button2.Visible = False
                txtParts1.Visible = False
                Label10.Visible = False
                txtshift.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
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
                _Refresh1()
                _Refresh11()
                _Refresh315()
                cmb_Pcode.Enabled = False
                txtshift.Enabled = False
                txtshift.Visible = False
                Label8.Visible = False
                txtParts1.Visible = False
                Label10.Visible = False
                txtBarcodeOne.Enabled = True
                TxtheaterTwo.Enabled = True
                txtBarcodeOne.Focus()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = " SELECT component_Name, component_Control,CONVERT(bit,0) as Found FROM Heater_component "
            sql1 += " where Model_Name ='" & cmb_Pcode.Text & "'"

            sql1 += " and step_visual = 'ST2' "
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_component")
            'ds.Tables("Matrel").Columns(0).ColumnName = "الكود "
            'ds.Tables("Material").Columns(0).ColumnName = "V_Code"
            ds.Tables("Heater_component").Columns(0).ColumnName = "Name"
            ds.Tables("Heater_component").Columns(1).ColumnName = "part"
            dg1.DataSource = ds.Tables("Heater_component")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        cmb_Pcode.Focus()
    End Sub
    Dim s As Integer
    Dim i As Integer
    Private Sub TxtheaterTwo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtheaterTwo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim S_Part_IS_Found As Boolean
                Dim Barcode_Part As String
                If _Refresh133(TxtheaterTwo.Text) = True Then Exit Sub
                For ii As Integer = 0 To dg1.Rows.Count - 1
                    Dim S_Part As String = dg1.Item(1, ii).Value
                    If dg1.Item(2, ii).Value = False Then
                        If TxtheaterTwo.Text.Contains(S_Part) Then
                            S_Part_IS_Found = True
                            lbl_Msg.Text = "OK"
                            lbl_Msg.ForeColor = Color.Yellow
                            dg1.Rows(ii).DefaultCellStyle.BackColor = Color.YellowGreen
                            dg1.Item(2, ii).Value = True
                            TxtheaterTwo.SelectAll()
                            Dim Sql As String = ""
                            Sql += "update  Heater_registration_Two1 set " & dg1.Item(0, ii).Value & "='" & TxtheaterTwo.Text & "'"
                            Sql += " where H_Heater_Code='" & txtBarcodeOne.Text & "'"
                            Sql += " and H_Model_Name='" & cmb_Pcode.Text & "'"
                            Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                            If cn.State = ConnectionState.Closed Then cn.Open()
                            cmd.ExecuteNonQuery()
                            cn.Close()
                            _Refresh1()
                            If ii = dg1.Rows.Count - 1 Then GoTo 10
                            Exit Sub
                        End If
                    End If
                Next
10:
                For x As Integer = 0 To dg1.Rows.Count - 1
                    If dg1.Item(2, x).Value = 0 Then Exit For
                    txtBarcodeOne.Text = ""
                    TxtheaterTwo.Text = ""
                    txtBarcodeOne.Enabled = True
                    txtBarcodeOne.Focus()
                    _Refresh1()
                    _Refresh11()
                Next

                If S_Part_IS_Found = False Then
                    lbl_Msg.Text = "Not Found"
                    lbl_Msg.ForeColor = Color.Tomato
                    TxtheaterTwo.SelectAll()
                    TxtheaterTwo.Focus()

                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtheaterTwo_TextChanged(sender As Object, e As EventArgs) Handles TxtheaterTwo.TextChanged

    End Sub



    Private Sub txtBarcodeOne_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcodeOne.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 7)
                Barcode_Part(1) = txtBarcodeOne.Text.Substring(7, 2)
                Barcode_Part(2) = txtBarcodeOne.Text.Substring(9, 9)
                'Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
                'Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                'Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
                'Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)

                If txtBarcodeOne.Text.Length < 18 Then Exit Sub
                Dim dsMax1 As New DataSet
                Dim Sql1 = "SELECT H_Heater_Code FROM Heater_registration_Two1 where H_Model_Name = '" & cmb_Pcode.Text & "'"
                Sql1 += " and H_Heater_Code ='" & txtBarcodeOne.Text & "'"
                ' Sql += " and fNameL='" & ComboBox2.Text & "'"
                Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
                dsMax1.Tables.Clear()
                da1.Fill(dsMax1)
                If dsMax1.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This Serial is already used"
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                    Exit Sub
                End If
            End If
            ''''''''''''''''''''''''''''''''''
        Catch ex As Exception

        End Try
        Try

            'If e.KeyCode = Keys.Enter Then
            '    If txtBarcodeOne.Text.Length < 18 Then Exit Sub
            '    Dim dsMax As New DataSet
            '    Dim Sql = "Select fLCDBarcode from DailyP where fLCDBarcode='" & txtFATSERIAL.Text & "'"
            '    Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            '    dsMax.Tables.Clear()
            '    da.Fill(dsMax)
            '    If dsMax.Tables(0).Rows.Count > 0 Then
            '        lbl_Msg.ForeColor = Color.Red
            '        lbl_Msg.Text = "This Serial is already used"
            '        txtFATSERIAL.Focus()
            '        txtFATSERIAL.SelectAll()
            '        Exit Sub
            '    End If
            If e.KeyCode = Keys.Enter Then
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 7)
                Barcode_Part(1) = txtBarcodeOne.Text.Substring(7, 2)
                Barcode_Part(2) = txtBarcodeOne.Text.Substring(9, 9) '''''''''''''

                ''''''''''''''''''''''''''''''''''
                If Barcode_Part(1) <> cmb_Pcode.SelectedValue Then
                    lbl_Msg.Text = "BIN Code Structure wrong "
                    lbl_Msg.ForeColor = Color.Yellow
                    txtBarcodeOne.Focus()
                    txtBarcodeOne.SelectAll()
                Else

                    ' insert the barcode  in database
                    Dim sql2 As String = ""
                    sql2 = "INSERT INTO Heater_registration_Two1"
                    sql2 += "(H_Heater_Code, H_Model_Name, H_PCB_P, H_PCB_C,H_Name_Laber,H_Shift_Line)"
                    sql2 += "VALUES     ('"
                    sql2 += txtBarcodeOne.Text & "',"
                    'For i As Integer = 0 To Barcode_Part.Length - 1
                    '    Sql2 += "'" & Barcode_Part(i) & "',"
                    'Next
                    ' _Refresh133()
                    sql2 += "'" & cmb_Pcode.Text & "',"

                    sql2 += "'" & TxtheaterTwo.Text & "',"
                    sql2 += "'" & TxtheaterTwo.Text & "',"
                    sql2 += "" & txtParts1.Text & ","
                    sql2 += "'" & txtshift.Text & "')"
                    Dim cmd As New SqlClient.SqlCommand(sql2, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "Ok"
                    txtBarcodeOne.Enabled = False
                    TxtheaterTwo.Enabled = True
                    TxtheaterTwo.Focus()
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBarcodeOne_TextChanged(sender As Object, e As EventArgs) Handles txtBarcodeOne.TextChanged
        'Try
        '    _Refresh1()
        '    txtBarcodeOne.Text = ""
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString
            'Panel.Text = cmb_Pcode.SelectedValue
            'Label2.Text = cmb_Pcode.Text
            txtBarcodeOne.Enabled = True
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        ' insert the barcode  in database
        Dim sql As String
        sql = "DELETE FROM Heater_registration_Two1"
        sql += " where H_Heater_Code = '" & txtBarcodeOne.Text & "'"
        sql += " and H_Model_Name = '" & cmb_Pcode.Text & "'"
        sql += " and H_date >= Convert(nvarchar(10), GETDATE(), 121)"
        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        lbl_Msg.ForeColor = Color.GreenYellow
        lbl_Msg.Text = "Delete Model"
        txtBarcodeOne.Focus()
        txtBarcodeOne.SelectAll()
        txtBarcodeOne.Text = ""
        TxtheaterTwo.Text = ""
        txtBarcodeOne.Enabled = True
        txtBarcodeOne.Focus()
    End Sub
End Class