Imports TEVPBarcode.sher

Public Class frmOutp

   
    Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown
        Try

            If txtFATSERIAL.Text.Length = 16 Then
                If e.KeyCode = Keys.Enter Then
                    Dim dsMax As New DataSet
                    Dim Sql = "SELECT fLCDBarcode  FROM  Output "
                    Sql += " where fLCDBarcode='" & txtFATSERIAL.Text & "'"
                    Sql += " and fModel='" & cmb_Pcode.Text & "'"
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

                    Dim Barcode_Part2(3) As String
                    Barcode_Part2(0) = txtFATSERIAL.Text.Substring(0, 8)
                    Barcode_Part2(1) = txtFATSERIAL.Text.Substring(8, 1)
                    Barcode_Part2(2) = txtFATSERIAL.Text.Substring(9, 7)
                    If Barcode_Part2(0) <> cmb_Pcode.SelectedValue.ToString Then
                        lbl_Msg.Text = "This serial is wrong"
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        txtFATSERIAL.Focus()
                        txtFATSERIAL.SelectAll()
                        Exit Sub
                    End If

                Else
                    lbl_Msg.Text = "This serial is Okay"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Green

                    txtFATSERIAL.Enabled = False
                    txteancode.Enabled = True
                    txteancode.Focus()

                End If


            ElseIf txtFATSERIAL.Text.Length = 14 Then
                If e.KeyCode = Keys.Enter Then
                    Dim dsMax As New DataSet
                    Dim Sql = "SELECT fLCDBarcode  FROM  Output"
                    Sql += " where fLCDBarcode='" & txtFATSERIAL.Text & "'"
                    Sql += " and fModel='" & cmb_Pcode.Text & "'"
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


                    If Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
                        lbl_Msg.Text = "This serial is wrong"
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        txtFATSERIAL.Focus()
                        txtFATSERIAL.SelectAll()
                        Exit Sub
                    End If


                Else
                    lbl_Msg.Text = "This serial is Okay"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Green
                    txtFATSERIAL.Enabled = False
                    txteancode.Enabled = True
                    txteancode.Focus()

                End If
            End If
            'Else
            'lbl_Msg.Text = "This serial is Wrng"
            'Console.Beep()
            'lbl_Msg.ForeColor = Color.Red
            'txtFATSERIAL.Enabled = True
            'txtFATSERIAL.Focus()
            'End If

        Catch ex As Exception

        End Try
    
    End Sub


    Private Sub txtFATSERIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        txtFATSERIAL.Enabled = True
        cmb_Pcode.Enabled = True
        txtDelete.Enabled = True

      
        If txtS_Laber.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtS_Laber.Text & "'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count < 1 Then
            'lbl_Msg.ForeColor = Color.Red
            MsgBox(" Sap Number Wrong ")
            txtS_Laber.Focus()
            txtS_Laber.SelectAll()
            Exit Sub
        Else
            _Refresh315()
            dd.Visible = True
            df.Visible = False
            cmb_Pcode3.Enabled = False
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

        End If

        _Refresh1()
        _Refresh13()
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & txtS_Laber.Text & "'"
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
            sql += " SELECT fModel , count (fLCDBarcode)as qty"
            sql += " FROM Output"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fNameL ='" & cmb_Pcode3.Text & "'"
            'sql += " and fLCDPline = '4' "
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Output")
            ds.Tables("Output").Columns(0).ColumnName = "  Model Name"
            ds.Tables("Output").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("Output")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDBarcode)as qty"
            sql += " FROM Output"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fNameL ='" & cmb_Pcode3.Text & "'"
            'sql += " and fLCDPline = '4' "
            ' sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Output")
            ds.Tables("Output").Columns(0).ColumnName = "S U M "

            dg5.DataSource = ds.Tables("Output")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmOutp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtS_Laber.Focus()

        dd.Visible = False
        df.Visible = True
        txtFATSERIAL.Enabled = False
        cmb_Pcode.Enabled = False
        txtDelete.Enabled = False
        'Me.SkinEngine1.SkinFile = "Skins/RealOne.ssk"
        _Refresh1()
        _Refresh13()
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM   LCDTVModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "fLCDSetID"
            cmb_Pcode.DisplayMember = "fLCDModelName"
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

            sql = "DELETE FROM Output"
            sql += " where fLCDBarcode = '" & txtDelete.Text & "'"
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
                ' insert the barcode  in database
                sql = "DELETE FROM Output"
                sql += " where fLCDBarcode = '" & txtDelete.Text & "'"
                    Dim cmd As New SqlClient.SqlCommand(Sql, cn)
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
        Dim frm1 As New frmQOutp
        frm1.Show()
    End Sub

    Private Sub dg2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg2.CellContentClick

    End Sub

    Private Sub dg2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg2.Click
        cmb_Pcode.Text = dg2.Item(0, dg2.CurrentRow.Index).Value
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

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub txteancode_KeyDown(sender As Object, e As KeyEventArgs) Handles txteancode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtFATSERIAL.Text.Length = 16 Then

                Dim Barcode_Part2(3) As String
                Barcode_Part2(0) = txtFATSERIAL.Text.Substring(0, 8)
                Barcode_Part2(1) = txtFATSERIAL.Text.Substring(8, 1)
                Barcode_Part2(2) = txtFATSERIAL.Text.Substring(9, 7)

                Dim dsMax As New DataSet
                Dim Sql = "SELECT fLCDSetID,fLCDModelName,FEAN_CODE  FROM  LCDTVModels "
                Sql += " where fLCDModelName='" & cmb_Pcode.Text & "'"
                Sql += " and fLCDSetID='" & Barcode_Part2(0) & "'"
                Sql += " and FEAN_CODE='" & txteancode.Text & "'"
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

          
                '    Sql = "INSERT INTO Output"
                '    Sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID, fNameL,fSap_L)"
                'Sql += "VALUES     ('"txtFATSERIAL.Text & "','" & cmb_Pcode3.Text & "','" & txtS_Laber.Text & "')"

                Sql = " INSERT INTO Output "
                Sql += "(fLCDBarcode,fLCDSetID,fNameL,fLCDSN,fSap_L,fModel,FEAN_CODE)"
                Sql += " VALUES ('" & txtFATSERIAL.Text & "','" & Barcode_Part2(0) & "','" & cmb_Pcode3.Text & "','" & Barcode_Part2(2) & "','" & txtS_Laber.Text & "','" & cmb_Pcode.Text & "','" & txteancode.Text & "')"

                Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "Done"

                txteancode.Text = ""
                txtFATSERIAL.Enabled = True
                txteancode.Enabled = False
                txtFATSERIAL.Focus()


                txtFATSERIAL.SelectAll()
                _Refresh1()
                _Refresh13()

            ElseIf txtFATSERIAL.Text.Length = 14 Then
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
                Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 2)
                Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
                Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
                Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
                Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)

                Dim dsMax As New DataSet
                Dim Sql = "SELECT fLCDSetID,fLCDModelName,FEAN_CODE  FROM  LCDTVModels "
                Sql += " where fLCDModelName='" & cmb_Pcode.Text & "'"
                Sql += " and fLCDSetID='" & Barcode_Part(1) & "'"
                Sql += " and FEAN_CODE='" & txteancode.Text & "'"
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

               

                Dim Sql1 = "INSERT INTO Output"
                Sql1 += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID, fNameL,fSap_L,fModel,FEAN_CODE)"
                Sql1 += "VALUES     ('"
                Sql1 += txtFATSERIAL.Text & "',"
                For i As Integer = 0 To Barcode_Part.Length - 1
                    Sql1 += "'" & Barcode_Part(i) & "',"

                Next
                Sql1 += "'" & cmb_Pcode3.Text & "',"
                Sql1 += "'" & txtS_Laber.Text & "',"
                Sql1 += "'" & cmb_Pcode.Text & "',"
                Sql1 += "'" & txteancode.Text & "')"

                Dim cmd As New SqlClient.SqlCommand(Sql1, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                ' cn.Close()

                cn.Close()

                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "Done"

                txteancode.Text = ""
                txtFATSERIAL.Enabled = True
                txteancode.Enabled = False
                txtFATSERIAL.Focus()


                txtFATSERIAL.SelectAll()
                _Refresh1()
                _Refresh13()
            Else
            End If
        End If
    End Sub

    Private Sub txteancode_TextChanged(sender As Object, e As EventArgs) Handles txteancode.TextChanged
      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtFATSERIAL.Text = ""
        txteancode.Text = ""
        txtFATSERIAL.Enabled = True
        txteancode.Enabled = False
        txtFATSERIAL.Focus()
    End Sub
End Class