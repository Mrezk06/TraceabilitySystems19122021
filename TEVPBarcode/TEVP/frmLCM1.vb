Imports TEVPBarcode.sher
Public Class frmLCM1



    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            _Refresh11()
            ' cmb_Pcode.Enabled = False
            txtshift.Enabled = False
            cmb_Pcode.Enabled = False
            Label8.Visible = False
            txtshift.Visible = False
            txtFATSERIAL.Focus()
        Catch ex As Exception

        End Try


    End Sub

    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = " SELECT fCompCode, fCompName,part ,CONVERT(bit,0) as Found FROM Material "
            sql1 += " where fModelName ='" & cmb_Pcode.Text & "'"
            sql1 += " and fArea = 'LCM2' "
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Material")
            'ds.Tables("Matrel").Columns(0).ColumnName = "الكود "
            ds.Tables("Material").Columns(0).ColumnName = "V_Code"
            ds.Tables("Material").Columns(1).ColumnName = "Name"
            ds.Tables("Material").Columns(2).ColumnName = "part"
            dg1.DataSource = ds.Tables("Material")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Try
            Dim frm1 As New History
            frm1.Show()
            '  Me.Hide()
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub btnCHModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCHModel.Click
    '    Try
    '        cmb_Pcode.Enabled = True
    '        Dim frm1 As New frmGuidance
    '        frm1.Show()
    '        '  Me.Hide()
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM LCM2"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLine = '4' "
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM2")
            ds.Tables("LCM2").Columns(0).ColumnName = " Model Name"
            ds.Tables("LCM2").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("LCM2")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh133() As Boolean
        Try
            Dim dsMax1 As New DataSet
            Dim Sql1 = "SELECT  main, power, model FROM DailyP where fLCDBarcode = '" & txtFATSERIAL.Text & "'"
            Sql1 += " and main ='" & txtPARTSSERIAL.Text & "'"
            Sql1 += " and model ='" & txtPARTSSERIAL.Text & "'"
            Sql1 += " and power ='" & txtPARTSSERIAL.Text & "'"
            ' Sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
            dsMax1.Tables.Clear()
            da1.Fill(dsMax1)
            If dsMax1.Tables(0).Rows.Count < 1 Then
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "This component is Used in other model "
                txtPARTSSERIAL.Focus()
                txtPARTSSERIAL.SelectAll()
                Exit Function
            End If
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub scanningFat1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        txtshift.Enabled = False
        cmb_Pcode.Enabled = False
        cmb_Pcode.Visible = False
        Label8.Visible = False
        txtshift.Visible = False
        Label1.Visible = False
        btnStart.Visible = False
        Try
            Dim sql As String = ""
            sql += " SELECT  fpanelIDLCM, fLCDModelName FROM   LCDTVModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "fpanelIDLCM"
            cmb_Pcode.DisplayMember = "fLCDModelName"
            cmb_Pcode.Sorted = True

            _Refresh1()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtFATSERIAL_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFATSERIAL.HandleDestroyed

    End Sub

    Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown
        'Try
        '    If e.KeyCode = Keys.Enter Then
        '        If txtFATSERIAL.Text.Length < 11 Then Exit Sub
        '        Dim dsMax As New DataSet
        '        Dim Sql = "SELECT  fLCDBarcode FROM  LCM where fLCDBarcode='" & txtFATSERIAL.Text & "'"
        '        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        '        dsMax.Tables.Clear()
        '        da.Fill(dsMax)
        '        If dsMax.Tables(0).Rows.Count < 1 Then
        '            lbl_Msg.ForeColor = Color.Red
        '            lbl_Msg.Text = "This Serial is not used in one step"
        '            Console.Beep()
        '            txtFATSERIAL.Focus()
        '            txtFATSERIAL.SelectAll()
        '            Exit Sub
        '        End If
        '    End If
        '    ''''''''''''''''''''''''''''''''''
        'Catch ex As Exception

        'End Try
        Try

            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length < 11 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "Select fLCDBarcode FROM  LCM2 where fLCDBarcode='" & txtFATSERIAL.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This Serial is already used"
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                    Exit Sub
                End If
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 9)
                Barcode_Part(1) = txtFATSERIAL.Text.Substring(9, 2)

                If Barcode_Part(1) <> cmb_Pcode.SelectedValue Then
                    lbl_Msg.Text = "BIN Code Structure wrong "
                    lbl_Msg.ForeColor = Color.Yellow
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                Else

                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "Ok"
                    txtFATSERIAL.Enabled = False
                    txtPARTSSERIAL.Enabled = True
                    txtPARTSSERIAL.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtFATSERIAL_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFATSERIAL.PreviewKeyDown

    End Sub

    Private Sub txtFATSERIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFATSERIAL.TextChanged
        Try
            _Refresh1()
            txtPARTSSERIAL.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString
            'Panel.Text = cmb_Pcode.SelectedValue
            Label2.Text = cmb_Pcode.Text
            txtFATSERIAL.Enabled = True
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
    Dim s As Integer
    Dim i As Integer
    Private Function _Refresh133(ByVal Sireal As String) As Boolean
        Try
            Dim dsMax1 As New DataSet
            Dim Sql1 = "SELECT  isnull(count(fSerial_No),0) FROM LCM2 where "
            Sql1 += "  fSerial_No ='" & Sireal & "'"
            'Sql1 += " or model ='" & Sireal & "'"
            'Sql1 += " or power ='" & Sireal & "'"
            ' Sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
            dsMax1.Tables.Clear()
            da1.Fill(dsMax1)
            If dsMax1.Tables(0).Rows(0).Item(0) > 0 Then
                lbl_Msg.ForeColor = Color.Red
                lbl_Msg.Text = "This component is Used in other model "

                Return True
            Else
                Return False
            End If


        Catch ex As Exception
        End Try
    End Function
    Private Sub txtPARTSSERIAL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPARTSSERIAL.KeyDown

        Try
            'i = dg1.RowCount - 1
            Dim S_Part_IS_Found As Boolean
            Dim Barcode_Part As String
            If e.KeyCode = Keys.Enter Then
                If _Refresh133(txtPARTSSERIAL.Text) = True Then Exit Sub

                'Dim xx As Integer = Int(txtPARTSSERIAL.Text.Length / 2)
                For ii As Integer = 0 To dg1.Rows.Count - 1
                    Dim S_Part As String = dg1.Item(2, ii).Value

                    If dg1.Item(3, ii).Value = False Then

                        If txtPARTSSERIAL.Text.Contains(S_Part) Then
                            S_Part_IS_Found = True
                            lbl_Msg.Text = "OK"
                            lbl_Msg.ForeColor = Color.Yellow
                            dg1.Rows(ii).DefaultCellStyle.BackColor = Color.YellowGreen
                            dg1.Item(3, ii).Value = True
                            txtPARTSSERIAL.SelectAll()
                            Dim Sql As String = ""
                            Sql = "INSERT INTO LCM2"
                            Sql += "(fLCDBarcode, fSerial_No, fLCDModelName, fLine,fUser_Code)"
                            Sql += "VALUES     ('"
                            Sql += txtFATSERIAL.Text & "',"

                            Sql += "'" & txtPARTSSERIAL.Text & "',"
                            Sql += "'" & cmb_Pcode.Text & "',"
                            Sql += "'" & txtshift.Text & "','" & txtParts1.Text & "')"
                            Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                            If cn.State = ConnectionState.Closed Then cn.Open()
                            cmd.ExecuteNonQuery()
                            cn.Close()

                            If ii = dg1.Rows.Count - 1 Then GoTo 10

                            Exit Sub
                        End If
                    End If
                Next
10:
                For x As Integer = 0 To dg1.Rows.Count - 1
                    If dg1.Item(3, x).Value = 0 Then Exit For

                    'If ii = dg1.Rows.Count - 1 Then
                    _Refresh11()
                    txtFATSERIAL.Text = ""
                    txtFATSERIAL.Enabled = True
                    txtFATSERIAL.Focus()
                    'End If
                Next

                If S_Part_IS_Found = False Then
                    lbl_Msg.Text = "Not Found"
                    lbl_Msg.ForeColor = Color.Tomato
                    txtPARTSSERIAL.SelectAll()
                End If

            End If


        Catch ex As Exception

        End Try
        _Refresh1()
    End Sub

    Private Sub txtPARTSSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtPARTSSERIAL.TextChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub lbl_Pcode_Value_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Pcode_Value.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        ' insert the barcode  in database
        Dim sql As String
        sql = "DELETE FROM LCM2"
        sql += " where fLCDBarcode = '" & txtFATSERIAL.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        lbl_Msg.ForeColor = Color.GreenYellow
        lbl_Msg.Text = "Delete Model"
        txtFATSERIAL.Focus()
        txtFATSERIAL.SelectAll()
        txtFATSERIAL.Text = ""
        txtPARTSSERIAL.Text = ""
        txtFATSERIAL.Enabled = True
        txtFATSERIAL.Focus()
    End Sub

    Private Sub btnBACKTOTOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        cmb_Pcode.Focus()
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
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "  The Responsible"

            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtParts1.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtParts1.Text & "'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count < 1 Then
            lbl_Msg.ForeColor = Color.Red
            lbl_Msg.Text = "This name is not allowed to work on barcode Line "
            txtParts1.Focus()
            txtParts1.SelectAll()
            Exit Sub
        Else
            _Refresh315()
            lbl_Msg.ForeColor = Color.Green
            lbl_Msg.Text = " welcome This name allowed to work on barcode Line "
            cmb_Pcode.Visible = True
            Label8.Visible = True
            txtshift.Visible = True
            cmb_Pcode.Enabled = True
            txtshift.Enabled = True

            Label1.Visible = True
            btnStart.Visible = True
            GroupBox2.Visible = True
            'txtshift.Visible = False
            Button2.Visible = False
            txtParts1.Visible = False
            Label10.Visible = False
            txtshift.Focus()
            'Me.BackColor = Color.YellowGreen

        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class