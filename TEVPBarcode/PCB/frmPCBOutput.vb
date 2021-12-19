Imports TEVPBarcode.sher
Public Class frmPCBOutput

    ''Public Class frmPCBInput

    Private Sub frmPCBInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM   LCDTVModelsPCB "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "fLCDSetID"
            cmb_Pcode.DisplayMember = "fLCDModelName"
            cmb_Pcode.Sorted = True

            _Refresh1()
        Catch ex As Exception

        End Try
        cmb_Pcode.Enabled = False
        '' txtline.Enabled = False
        txtshift.Enabled = False
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM PCBOut"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " and fLine_and_shift ='" & txtshift.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = " Model Name"
            ds.Tables("PCBOut").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmb_Pcode.Text = "" Or txtshift.Text = "" Then

            MsgBox("please Check Line Or Model or shift")

            Exit Sub
        Else
            Try
                ''   _Refresh11()
                cmb_Pcode.Enabled = False
                ' txtline.Enabled = False
                txtshift.Enabled = False
                txtshift.Visible = False
                Label8.Visible = False

                txtFATSERIAL.Focus()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtParts1.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtParts1.Text & "'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count < 1 Then
            lbl_Msg.ForeColor = Color.Red
            lbl_Msg.Text = "This name is not allowed to work on PCB Line "
            txtParts1.Focus()
            txtParts1.SelectAll()
            Exit Sub
        Else
            _Refresh315()
            lbl_Msg.ForeColor = Color.Green
            lbl_Msg.Text = "welcome This name allowed to work on PCB Line"
            cmb_Pcode.Enabled = True
            '' txtline.Enabled = False
            txtshift.Enabled = True
            'GroupBox2.Visible = True
            ''txtshift.Visible = False
            Button2.Visible = False
            txtParts1.Visible = False
            Label10.Visible = False
            txtshift.Focus()
            'Me.BackColor = Color.YellowGreen

        End If
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

    Private Sub txtFATSERIAL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFATSERIAL.KeyDown
        'Try
        '    If e.KeyCode = Keys.Enter Then
        '        Dim Barcode_Part(3) As String
        '              Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
        '        Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 7)
        '        Barcode_Part(2) = txtFATSERIAL.Text.Substring(7, 8)
        '        Barcode_Part(3) = txtFATSERIAL.Text.Substring(8, 17)
        '        If e.KeyCode = Keys.Enter Then
        '            If txtFATSERIAL.Text.Length < 18 Then Exit Sub
        '            Dim dsMax1 As New DataSet
        '            Dim Sql1 = "SELECT fpanelID FROM LCDTVModelsPCB where fLCDModelName = '" & cmb_Pcode.Text & "'"
        '            Sql1 += " and fpanelID ='" & Barcode_Part(6) & "'"
        '            ' Sql += " and fNameL='" & ComboBox2.Text & "'"
        '            Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
        '            dsMax1.Tables.Clear()
        '            da1.Fill(dsMax1)
        '            If dsMax1.Tables(0).Rows.Count < 1 Then
        '                lbl_Msg.ForeColor = Color.Red
        '                lbl_Msg.Text = "This panel ID is not Used in this model "
        '                txtFATSERIAL.Focus()
        '                txtFATSERIAL.SelectAll()
        '                Exit Sub
        '            End If
        '        End If
        '    End If
        '    ''''''''''''''''''''''''''''''''''
        'Catch ex As Exception

        'End Try
        Try
            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length < 18 Then Exit Sub
                Dim dsMax1 As New DataSet
                Dim Sql1 = "SELECT fLCDBarcode FROM PCBIN where fLCDBarcode = '" & txtFATSERIAL.Text & "'"
                Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
                dsMax1.Tables.Clear()
                da1.Fill(dsMax1)
                If dsMax1.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This serial is not recorded in the first step "
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                    Exit Sub
                End If
            End If

            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length < 18 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "Select fLCDBarcode from PCBOut where fLCDBarcode='" & txtFATSERIAL.Text & "'"
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
                Dim Barcode_Part(3) As String
                Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
                Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 6)
                Barcode_Part(2) = txtFATSERIAL.Text.Substring(7, 2)
                Barcode_Part(3) = txtFATSERIAL.Text.Substring(8, 10)
                'Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                'Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
                'Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)
                '''''''''''''''''
                Dim T As String = "E"
                If Barcode_Part(0) <> T.ToString Then
                    lbl_Msg.Text = "This barcode is wrong for another factory"
                    lbl_Msg.ForeColor = Color.Yellow
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                ElseIf Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
                    lbl_Msg.Text = "BIN Code Structure wrong "
                    lbl_Msg.ForeColor = Color.Yellow
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                Else

                    ' insert the barcode  in database
                    Sql = "INSERT INTO PCBOut"
                    Sql += "(fLCDBarcode,fLCDSetID,fLCDModelName,fSap,fLine_and_shift)"
                    Sql += "VALUES     ('"
                    Sql += txtFATSERIAL.Text & "',"
                    Sql += "'" & lbl_Pcode_Value.Text & "',"
                    Sql += "'" & cmb_Pcode.Text & "',"
                    Sql += "" & txtParts1.Text & ","

                    Sql += "'" & txtshift.Text & "')"
                    Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "Ok"
                    txtFATSERIAL.Text = ""
                    'txtPARTSSERIAL.Enabled = True
                    txtFATSERIAL.Focus()

                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtFATSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtFATSERIAL.TextChanged
        Try
            _Refresh1()
            '  txtPARTSSERIAL.Text = ""
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

    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        If txtParts1.Text = "" Then

            lbl_Msg.Text = "الرجاء ادخال رقم الساب واتباع تعليمات التشغيل الصحيحه"
            lbl_Msg.ForeColor = Color.Red

            txtParts1.Focus()

        Else
            cmb_Pcode.Enabled = True
            txtline.Enabled = True
            txtshift.Enabled = True
            cmb_Pcode.Focus()

        End If
    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New frmQuery_PCB_Output
        frm.Show()
        Me.Hide()

    End Sub
End Class