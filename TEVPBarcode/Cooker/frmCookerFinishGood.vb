Imports TEVPBarcode.sher

Public Class frmCookerFinishGood


    'Public Class frmSony





    Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length = 18 Then


                    Dim dsMax As New DataSet
                    Dim Sql = "SELECT CBarcode  FROM  C_FinishGood_Production "
                    Sql += " where CBarcode='" & txtFATSERIAL.Text & "'"
                    Sql += " and CModelName='" & cmb_Pcode.Text & "'"
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
                    Dim dsMax2 As New DataSet
                    Dim Sql2 = "Select CBarcode from C_Output_Production where CBarcode='" & txtFATSERIAL.Text & "'"
                    Dim da2 As New SqlClient.SqlDataAdapter(Sql2, cn)
                    dsMax2.Tables.Clear()
                    da2.Fill(dsMax2)
                    If dsMax2.Tables(0).Rows.Count < 1 Then
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "البوتاجاز لم يسجل فى خرج الانتاج"
                        Console.Beep()
                        txtFATSERIAL.Focus()
                        txtFATSERIAL.SelectAll()
                        Exit Sub
                    End If
                    Dim Barcode_Part2(3) As String
                    Barcode_Part2(0) = txtFATSERIAL.Text.Substring(0, 8)
                    Barcode_Part2(1) = txtFATSERIAL.Text.Substring(8, 1)
                    Barcode_Part2(2) = txtFATSERIAL.Text.Substring(9, 7)
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "Done"

                    txteancode.Focus()
                    txtFATSERIAL.Enabled = False
                    'txtFATSERIAL.SelectAll()
                    _Refresh1()
                    _Refresh13()
                Else
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This serial is wrong"
                    txtFATSERIAL.SelectAll()
                    txtFATSERIAL.Focus()

                End If



                '            End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFATSERIAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFATSERIAL.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If


        End If

        ' If e.KeyCode = Keys.Enter Then
        '  If txtFATSERIAL.Text.Length <> 16 Then Exit Sub
        'If txtFATSERIAL.Text.Length > 14 Then Exit Sub
        'Dim dsMax As New DataSet
        'Dim Sql = "SELECT fLCDBarcode  FROM  Output"
        'Sql += " where fLCDBarcode='" & txtFATSERIAL.Text & "'"
        'Sql += " and fModel='" & cmb_Pcode.Text & "'"
        'Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        'dsMax.Tables.Clear()
        'da.Fill(dsMax)
        'If dsMax.Tables(0).Rows.Count < 1 Then
        '    lbl_Msg.ForeColor = Color.Red
        '    lbl_Msg.Text = "This Serial is Not  used in Test Atq 3"
        '    txtFATSERIAL.Focus()
        '    txtFATSERIAL.SelectAll()
        '    Exit Sub
        'End If
        ' End If


    End Sub


    Private Sub txtFATSERIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        txtFATSERIAL.Enabled = True
        cmb_Pcode.Enabled = True
        txtDelete.Enabled = True
        cmb_Pcode3.Enabled = False



        'Dim dsMax As New DataSet
        'Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & Label7.Text & "'"
        'Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        'dsMax.Tables.Clear()
        'da.Fill(dsMax)
        'If dsMax.Tables(0).Rows.Count < 1 Then
        '    'lbl_Msg.ForeColor = Color.Red
        '    MsgBox(" Sap Number Wrong ")
        '    txtS_Laber.Focus()
        '    txtS_Laber.SelectAll()
        '    Exit Sub
        'Else
        _Refresh315()
            dd.Visible = True
            df.Visible = False
            'lbl_Msg.ForeColor = Color.Green
            'MsgBox(" تق")
            'cmb_Pcode.Enabled = True
            '' txtline.Enabled = False
            'txtshift.Enabled = True
            'GroupBox2.Visible = True
            ''txtshift.Visible = False
            'Button2.Visible = False
            'txtParts1.Visible = False
            'Label10.Visible = False
            cmb_Pcode.Focus()
        'Me.BackColor = Color.YellowGreen

        '    End If

        _Refresh1()
        _Refresh13()
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & Label7.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "Name responsible"

            dgv.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and C_Line_Shift ='" & cmb_Pcode3.Text & "'"
            sql += "and NewFactory Like '%" & sss & "%'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " Model Name"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Dim sss As String = "C"
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and C_Line_Shift ='" & cmb_Pcode3.Text & "'"
            sql += "and NewFactory Like '%" & sss & "%'"
            'sql += " and fLCDPline = '4' "
            ' sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "S U M "

            dg5.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Public Property StringPassc3 As String
    Private Sub frmOutp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label7.Text = StringPassc3
        cmb_Pcode3.Focus()

        dd.Visible = False
        df.Visible = True
        txtFATSERIAL.Enabled = False
        cmb_Pcode.Enabled = False
        txtDelete.Enabled = False
        '   Me.SkinEngine1.SkinFile = "Skins/RealOne.ssk"
        _Refresh1()
        _Refresh13()
        Try
            Dim sql As String = ""
            sql += " SELECT  CEanCode, CModelName FROM   CModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "CEanCode"
            cmb_Pcode.DisplayMember = "CModelName"
            cmb_Pcode.Sorted = True
        Catch ex As Exception
        End Try

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Close()
    'End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtFATSERIAL.Focus()
        txtFATSERIAL.SelectAll()
    End Sub

    Private Sub cmb_Pcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Pcode.KeyDown

    End Sub

    Private Sub cmb_Pcode_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_Pcode.MouseDown

    End Sub
    Private Sub cmb_Pcode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString
            ' Label2.Text = cmb_Pcode.Text

        Catch ex As Exception
        End Try
    End Sub

    Private Sub lbl_Pcode_Value_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Pcode_Value.Click

    End Sub
    Private Function Del_Rec() As Boolean
        Try
            Dim sql As String

            sql = "DELETE FROM [barcode].[dbo].[C_FinishGood_Production]"
            sql += " where CBarcode = '" & txtDelete.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = " okay, deleted serial"
                txtDelete.Focus()
                txtDelete.SelectAll()
                _Refresh1()
            End If
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtDelete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDelete.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
            
                Dim sql As String
                sql = "DELETE FROM C_FinishGood_Production"
                sql += " where CBarcode = '" & txtDelete.Text & "'"
                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "okay, deleted serial"
                txtDelete.Focus()
                txtDelete.SelectAll()
                _Refresh1()
                _Refresh13()
            End If
            'End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDelete_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDelete.LocationChanged


    End Sub

    Private Sub txtDelete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelete.TextChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Dim frm1 As New frmcookerFinishGoodQuery
        frm1.Show()
    End Sub

    Private Sub dg2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg2.CellContentClick

    End Sub

    Private Sub dg2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg2.Click
        Try
            cmb_Pcode.Text = dg2.Item(0, dg2.CurrentRow.Index).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtParts1_Leave(sender As Object, e As EventArgs) Handles txtS_Laber.Leave
        If txtS_Laber.Text.Length < 8 Or txtS_Laber.Text.Length > 8 Then
            MsgBox(" Sap Number Wrong ")
            txtS_Laber.Focus()
            txtS_Laber.SelectAll()
        End If
        Exit Sub
    End Sub

    Private Sub txtParts1_TextChanged(sender As Object, e As EventArgs) Handles txtS_Laber.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txteancode_KeyDown(sender As Object, e As KeyEventArgs) Handles txteancode.KeyDown
        Try
            If txtFATSERIAL.Text.Length = 18 Then

                If e.KeyCode = Keys.Enter Then
                    Dim Barcode_Part2(3) As String
                    Barcode_Part2(0) = txtFATSERIAL.Text.Substring(0, 8)
                    Barcode_Part2(1) = txtFATSERIAL.Text.Substring(8, 1)
                    Barcode_Part2(2) = txtFATSERIAL.Text.Substring(9, 9)

                    Dim dsMax As New DataSet
                    Dim Sql = "SELECT CModelName,CEanCode  FROM  CModels "
                    Sql += " where CModelName='" & cmb_Pcode.Text & "'"
                    '   Sql += " and fLCDSetID='" & Barcode_Part2(0) & "'"
                    Sql += " and CEanCode='" & txteancode.Text & "'"
                    Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                    dsMax.Tables.Clear()
                    da.Fill(dsMax)
                    If dsMax.Tables(0).Rows.Count < 1 Then
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "This Ean code is Wrong"
                        txteancode.Focus()
                        txteancode.SelectAll()
                        Exit Sub
                    End If
                    Dim Barcode_Part7(3) As String
                    Barcode_Part7(0) = txtFATSERIAL.Text.Substring(0, 5)
                    Barcode_Part7(1) = txtFATSERIAL.Text.Substring(5, 2)
                    Barcode_Part7(2) = txtFATSERIAL.Text.Substring(7, 2)
                    Barcode_Part7(3) = txtFATSERIAL.Text.Substring(9, 9)

                    Sql = " INSERT INTO C_FinishGood_Production "
                    Sql += "(CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode,C_Line,NewFactory)"
                    Sql += " VALUES ('" & txtFATSERIAL.Text & "','" & cmb_Pcode.Text & "','" & cmb_Pcode3.Text & "','" & Label7.Text & "','" & txteancode.Text & "','" & Barcode_Part7(1) & "','C')"

                    Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()

                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "Done"


                    txteancode.Text = ""
                    txtFATSERIAL.Enabled = True
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()

                    _Refresh1()
                    _Refresh13()
                End If

                'ElseIf txtFATSERIAL.Text.Length = 14 Then

                '    If e.KeyCode = Keys.Enter Then

                '        Dim Barcode_Part(6) As String
                '        Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
                '        Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 2)
                '        Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
                '        Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
                '        Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                '        Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
                '        Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)

                '        Dim dsMax As New DataSet
                '        Dim Sql = "SELECT fLCDSetID,fLCDModelName,FEAN_CODE  FROM  LCDTVModels "
                '        Sql += " where fLCDModelName='" & cmb_Pcode.Text & "'"
                '        Sql += " and fLCDSetID='" & Barcode_Part(1) & "'"
                '        Sql += " and FEAN_CODE='" & txteancode.Text & "'"
                '        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                '        dsMax.Tables.Clear()
                '        da.Fill(dsMax)
                '        If dsMax.Tables(0).Rows.Count < 1 Then
                '            lbl_Msg.ForeColor = Color.Red
                '            lbl_Msg.Text = "This Ean code is Wrong"
                '            txteancode.Focus()
                '            txteancode.SelectAll()
                '            Exit Sub
                '        End If

                '        Sql = "INSERT INTO Output"
                '        Sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID, fNameL,fSap_L,fModel,FEAN_CODE)"
                '        Sql += "VALUES     ('"
                '        Sql += txtFATSERIAL.Text & "',"
                '        For i As Integer = 0 To Barcode_Part.Length - 1
                '            Sql += "'" & Barcode_Part(i) & "',"

                '        Next
                '        Sql += "'" & cmb_Pcode3.Text & "',"
                '        Sql += "'" & txtS_Laber.Text & "',"
                '        Sql += "'" & cmb_Pcode.Text & "','" & txteancode.Text & "')"

                '        Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                '        If cn.State = ConnectionState.Closed Then cn.Open()
                '        cmd.ExecuteNonQuery()
                '        cn.Close()

                '        lbl_Msg.ForeColor = Color.GreenYellow
                '        lbl_Msg.Text = "Done"


                '        txteancode.Text = ""
                '        txtFATSERIAL.Enabled = True
                '        txtFATSERIAL.Focus()
                '        txtFATSERIAL.SelectAll()
                '        _Refresh1()
                '        _Refresh13()
                '    End If


            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub txteancode_TextChanged(sender As Object, e As EventArgs) Handles txteancode.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtFATSERIAL.Text = ""
        txteancode.Text = ""
        txtFATSERIAL.Enabled = True
        txteancode.Enabled = False
        txtFATSERIAL.Focus()
    End Sub
End Class