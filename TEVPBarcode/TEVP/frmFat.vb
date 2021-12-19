
Imports TEVPBarcode.sher
Public Class frmFat


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If cmb_Pcode.Text = "" Or txtshift.Text = "" Then

            MsgBox("please Check Line Or Model or shift")

            Exit Sub
        Else
            Try
                _Refresh11()
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

    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = " SELECT fCompCode, fCompName ,CONVERT(bit,0) as Found   FROM Material "
            sql1 += " where fModelName ='" & cmb_Pcode.Text & "'"
            sql1 += " and fArea = 'Fat2' "
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)

            Dim ds As New DataSet

            da.Fill(ds, "Material")

            'ds.Tables("Matrel").Columns(0).ColumnName = "الكود "
            ds.Tables("Material").Columns(0).ColumnName = "V_Code"
            ds.Tables("Material").Columns(1).ColumnName = "Name"


            dg1.DataSource = ds.Tables("Material")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Try
            Dim frm1 As New Target
            frm1.Show()
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
            sql += " FROM yearlyp "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLineandsh='" & txtshift.Text & "'"
            '    sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "yearlyp")
            ds.Tables("yearlyp").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Sub scanningFat1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM  LCDTVModels "

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

    Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown
        Try
            Dim Barcode_Part(6) As String
            Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
            Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 2)
            Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
            Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
            Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
            Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
            Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)
            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length < 14 Then Exit Sub
                Dim dsMax1 As New DataSet
                Dim Sql1 = "SELECT fpanelID FROM LCDTVModels where fLCDModelName = '" & cmb_Pcode.Text & "'"
                Sql1 += " and fpanelID ='" & Barcode_Part(6) & "'"
                ' Sql += " and fNameL='" & ComboBox2.Text & "'"
                Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
                dsMax1.Tables.Clear()
                da1.Fill(dsMax1)
                If dsMax1.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This panel ID is not Used in this model "
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                    Exit Sub
                End If
            End If
            ''''''''''''''''''''''''''''''''''
        Catch ex As Exception

        End Try
        Try
            'If e.KeyCode = Keys.Enter Then
            '    If txtFATSERIAL.Text.Length < 14 Then Exit Sub
            '    Dim dsMax1 As New DataSet
            '    Dim Sql1 = "SELECT [fLCDBarcode]FROM [DailyP] where fLCDBarcode = '" & txtFATSERIAL.Text & "'"
            '    Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
            '    dsMax1.Tables.Clear()
            '    da1.Fill(dsMax1)
            '    If dsMax1.Tables(0).Rows.Count < 1 Then
            '        lbl_Msg.ForeColor = Color.Red
            '        lbl_Msg.Text = "This series is not recorded in the first step "
            '        txtFATSERIAL.Focus()
            '        txtFATSERIAL.SelectAll()
            '        Exit Sub
            '    End If
            'End If
            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length < 14 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "Select fLCDBarcode from yearlyp where fLCDBarcode='" & txtFATSERIAL.Text & "'"
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
                Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
                Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 2)
                Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
                Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
                Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
                Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)
                If Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
                    lbl_Msg.Text = "BIN Code Structure wrong "
                    lbl_Msg.ForeColor = Color.Yellow
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                Else
                    'If txtFATSERIAL.Text.Length < 14 Then Exit Sub
                    'Dim dsMax1 As New DataSet
                    'Dim Sql1 = "SELECT [fLCDBarcode]FROM [barcode].[dbo].[DailyP] where fLCDBarcode = '" & txtFATSERIAL.Text & "'"
                    'Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
                    'dsMax.Tables.Clear()
                    'da.Fill(dsMax)
                    'If dsMax.Tables(0).Rows.Count > 0 Then
                    '    lbl_Msg.ForeColor = Color.Red
                    '    lbl_Msg.Text = "هذا السيريال لم  يتم تسجيله من قبل الدخل "
                    '    txtFATSERIAL.Focus()
                    '    txtFATSERIAL.SelectAll()
                    '    Exit Sub
                    'End If

                    'Dim Barcode_Part1(6) As String
                    'Barcode_Part1(0) = txtFATSERIAL.Text.Substring(0, 1)
                    'Barcode_Part1(1) = txtFATSERIAL.Text.Substring(1, 2)
                    'Barcode_Part1(2) = txtFATSERIAL.Text.Substring(3, 3)
                    'Barcode_Part1(3) = txtFATSERIAL.Text.Substring(6, 1)
                    'Barcode_Part1(4) = txtFATSERIAL.Text.Substring(7, 1)
                    'Barcode_Part1(5) = txtFATSERIAL.Text.Substring(8, 4)
                    'Barcode_Part1(6) = txtFATSERIAL.Text.Substring(12, 2)
                    ''            Next
                    ''            Sql += "'" & cmb_Pcode.Text & "')"


                    '            Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                    '            If cn.State = ConnectionState.Closed Then cn.Open()
                    '            cmd.ExecuteNonQuery()
                    '            cn.Close()

                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "ok"

                    txtFATSERIAL.Enabled = False
                    txtPARTSSERIAL.Enabled = True
                    txtPARTSSERIAL.Focus()
                    _Refresh1()
                End If
            End If
            ' End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFATSERIAL_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtFATSERIAL.PreviewKeyDown

    End Sub

    Private Sub txtFATSERIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFATSERIAL.TextChanged
        Try
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString
            Label2.Text = cmb_Pcode.Text
            txtFATSERIAL.Enabled = True
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtPARTSSERIAL_KeyDown1(ByVal sender As Object, ByVal e As KeyEventArgs)


    End Sub
    Private Sub GroupBox5_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox5.Enter

    End Sub
    Dim s As Integer
    Dim i As Integer
    'Private Sub txtPARTSSERIAL_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtPARTSSERIAL.KeyDown
    '    Try
    '        i = dg1.RowCount - 1

    '        If e.KeyCode = Keys.Enter Then

    '            For x1 = 0 To i
    '                If txtPARTSSERIAL.Text = txtFATSERIAL.Text Then
    '                    dg1.Item(2, x1).Value = True
    '                    dg1.Rows(x1).DefaultCellStyle.BackColor = Color.GreenYellow
    '                    lbl_Msg.Text = "ok"
    '                    lbl_Msg.ForeColor = Color.GreenYellow
    '                    TextBox1.Focus()
    '                    txtPARTSSERIAL.SelectAll()
    '                    s += 1
    '                    If s = dg1.RowCount Then
    '                        txtPARTSSERIAL.Text = ""
    '                        'TextBox1.Text = ""
    '                        txtPARTSSERIAL.Enabled = False
    '                        TextBox1.Enabled = False
    '                        If e.KeyCode = Keys.Enter Then
    '                            If txtFATSERIAL.Text.Length < 14 Then Exit Sub

    '                            Dim dsMax As New DataSet
    '                            Dim Sql = "Select fLCDBarcode from yearlyp where fLCDBarcode='" & txtFATSERIAL.Text & "'"
    '                            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
    '                            dsMax.Tables.Clear()
    '                            da.Fill(dsMax)
    '                            If dsMax.Tables(0).Rows.Count > 0 Then
    '                                lbl_Msg.ForeColor = Color.Red
    '                                lbl_Msg.Text = "This Serial is already used"
    '                                txtFATSERIAL.Focus()
    '                                txtFATSERIAL.SelectAll()
    '                                Exit Sub

    '                            End If

    '                            Dim Barcode_Part(6) As String
    '                            Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
    '                            Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 2)
    '                            Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
    '                            Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
    '                            Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
    '                            Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
    '                            Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)

    '                            If Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
    '                                lbl_Msg.Text = "BIN Code Structure wrong"
    '                                lbl_Msg.ForeColor = Color.Yellow
    '                                txtFATSERIAL.Focus()
    '                                txtFATSERIAL.SelectAll()

    '                            Else

    '                                Sql = "INSERT INTO yearlyp"
    '                                Sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID,fLCDModelName,fLineandsh)"
    '                                Sql += "VALUES     ('"
    '                                Sql += txtFATSERIAL.Text & "',"
    '                                For i As Integer = 0 To Barcode_Part.Length - 1
    '                                    Sql += "'" & Barcode_Part(i) & "',"

    '                                Next
    '                                Sql += "'" & cmb_Pcode.Text & "',"
    '                                Sql += "'" & txtshift.Text & "')"


    '                                Dim cmd As New SqlClient.SqlCommand(Sql, cn)
    '                                If cn.State = ConnectionState.Closed Then cn.Open()
    '                                cmd.ExecuteNonQuery()
    '                                cn.Close()

    '                                lbl_Msg.ForeColor = Color.GreenYellow
    '                                lbl_Msg.Text = "Done"

    '                                txtFATSERIAL.Enabled = False
    '                                'txtPARTSSERIAL.Enabled = False
    '                                txtPARTSSERIAL.Enabled = True
    '                                txtPARTSSERIAL.Focus()
    '                                _Refresh1()
    '                            End If

    '                        End If
    '                        txtFATSERIAL.Text = ""
    '                        txtFATSERIAL.Enabled = True
    '                        txtFATSERIAL.Focus()
    '                        For x2 = 0 To i
    '                            dg1.Item(2, x2).Value = False
    '                            dg1.Rows(x2).DefaultCellStyle.BackColor = Color.Tomato
    '                        Next
    '                        s = 0
    '                    End If

    '                    Exit Sub
    '                End If
    '            Next

    '            lbl_Msg.Text = "Not matching"
    '            lbl_Msg.ForeColor = Color.Red
    '            txtPARTSSERIAL.Focus()
    '            txtPARTSSERIAL.SelectAll()
    '        End If


    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub txtPARTSSERIAL_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        txtFATSERIAL.Text = ""
        txtPARTSSERIAL.Text = ""
        txtfinsh.Text = ""
        txtFATSERIAL.Enabled = True
        txtFATSERIAL.Focus()
    End Sub

    Private Sub btnBACKTOTOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBACKTOTOP.Click
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

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub txtPARTSSERIAL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPARTSSERIAL.KeyDown

        'i = dg1.RowCount - 1

        If e.KeyCode = Keys.Enter Then

            'For x1 = 0 To i

            If txtPARTSSERIAL.Text = txtFATSERIAL.Text Then
                '  dg1.Item(2, x1).Value = True
                '  dg1.Rows(x1).DefaultCellStyle.BackColor = Color.GreenYellow
                lbl_Msg.Text = "OK"
                lbl_Msg.ForeColor = Color.GreenYellow
                txtPARTSSERIAL.Enabled = False
                txtfinsh.Focus()
                txtfinsh.SelectAll()
                '    s += 1
            Else

                '    dg1.Rows(x1).DefaultCellStyle.BackColor = Color.GreenYellow
                lbl_Msg.Text = "not match"
                lbl_Msg.ForeColor = Color.GreenYellow
                txtPARTSSERIAL.Focus()
                txtPARTSSERIAL.SelectAll()

            End If

            '     ' if
        End If
    End Sub

    Private Sub txtPARTSSERIAL_TextChanged_1(sender As Object, e As EventArgs) Handles txtPARTSSERIAL.TextChanged

    End Sub

    Private Sub txtshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtshift.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
      
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub txtfinsh_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfinsh.KeyDown
        Try
            '   i = dg1.RowCount - 1


            If txtfinsh.Text.Length < 14 Then Exit Sub
            If txtfinsh.Text = txtPARTSSERIAL.Text Then
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
                Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 2)
                Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
                Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
                Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
                Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)

                If e.KeyCode = Keys.Enter Then

                    Dim Sql As String
                    Sql = "INSERT INTO yearlyp"
                    Sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID,fLCDModelName,fShift,fLineandsh)"
                    Sql += "VALUES     ('"
                    Sql += txtFATSERIAL.Text & "',"
                    For i As Integer = 0 To Barcode_Part.Length - 1
                        Sql += "'" & Barcode_Part(i) & "',"

                    Next
                    Sql += "'" & cmb_Pcode.Text & "',"
                    Sql += "" & txtParts1.Text & ","
                    Sql += "'" & txtshift.Text & "')"


                    Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()

                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "ok"

                    '   txtFATSERIAL.Enabled = False
                    'txtPARTSSERIAL.Enabled = False
                    'txtfinsh.Enabled = True
                    'txtfinsh.Focus()
                    _Refresh1()



                    txtFATSERIAL.Text = ""
                    txtfinsh.Text = ""
                    txtPARTSSERIAL.Text = ""
                    txtFATSERIAL.Enabled = True
                    txtfinsh.Enabled = True
                    txtPARTSSERIAL.Enabled = True
                    txtFATSERIAL.Focus()


                    'For x2 = 0 To i
                    '    dg1.Item(2, x2).Value = False
                    '    dg1.Rows(x2).DefaultCellStyle.BackColor = Color.Tomato
                    'Next
                    's = 0
                    '            End If

                    '  Exit Sub
                    ' End If
                    '    Next
                Else
                    lbl_Msg.Text = "Not matching"
                    lbl_Msg.ForeColor = Color.Red
                    txtfinsh.Focus()
                    txtfinsh.SelectAll()
                    Exit Sub
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    'Private Function txtparts2() As Object
    '    Throw New NotImplementedException
    'End Function

    Private Sub txtfinsh_TextChanged(sender As Object, e As EventArgs) Handles txtfinsh.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'If txtParts1.Text.Length < 8 Then Exit Sub

        'Dim dsMax As New DataSet
        'Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtParts1.Text & "'"
        'Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        'dsMax.Tables.Clear()
        'da.Fill(dsMax)
        'If dsMax.Tables(0).Rows.Count < 1 Then
        '    lbl_Msg.ForeColor = Color.Red
        '    lbl_Msg.Text = "This name is not allowed to work on barcode Line "
        '    txtParts1.Focus()
        '    txtParts1.SelectAll()
        '    Exit Sub
        'Else
        '    _Refresh315()
        '    lbl_Msg.ForeColor = Color.Green
        '    lbl_Msg.Text = "welcome This name allowed to work on barcode Line"
        '    cmb_Pcode.Enabled = True
        '    '' txtline.Enabled = False
        '    txtshift.Enabled = True
        '    'GroupBox2.Visible = True
        '    ''txtshift.Visible = False
        '    Button2.Visible = False
        '    txtParts1.Visible = False
        '    Label10.Visible = False
        '    txtshift.Focus()
        '    'Me.BackColor = Color.YellowGreen

        'End If
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

    Private Sub txtParts1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtParts1.KeyDown
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
    End Sub

    Private Sub txtParts1_TextChanged(sender As Object, e As EventArgs) Handles txtParts1.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class