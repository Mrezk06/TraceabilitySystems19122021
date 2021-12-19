Imports TEVPBarcode.sher
Public Class frmHeaterFinishGoodMFG
    Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                If txtDelete.Text.Length = 18 Then Exit Sub
                Dim Barcode_Part2(4) As String
                Barcode_Part2(0) = txtFATSERIAL.Text.Substring(0, 7)
                Barcode_Part2(1) = txtFATSERIAL.Text.Substring(7, 2)
                Barcode_Part2(2) = txtFATSERIAL.Text.Substring(9, 4)
                Barcode_Part2(3) = txtFATSERIAL.Text.Substring(13, 5)
                Dim dsMax As New DataSet
                Dim Sql = "SELECT CBarcode  FROM  Heater_FinishGood_Production "
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

                If Barcode_Part2(3) <> cmb_Pcode.SelectedValue.ToString Then
                    lbl_Msg.Text = "This serial is wrong"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Yellow
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                    Exit Sub
                Else
                    Dim sql8 As String = ""
                    sql8 = " INSERT INTO Heater_FinishGood_Production "
                    sql8 += "(CBarcode, CModelName, C_Line_Shift, CSapUser)"
                    sql8 += " VALUES ('" & txtFATSERIAL.Text & "','" & cmb_Pcode.Text & "','" & cmb_Pcode3.Text & "','" & txtS_Laber.Text & "')"
                    Dim cmd As New SqlClient.SqlCommand(sql8, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.Text = "This serial is Okay"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Green
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                    _Refresh1()
                    _Refresh13()
                End If

        
            End If
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
            cmb_Pcode.Focus()
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
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM Heater_FinishGood_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and C_Line_Shift ='" & cmb_Pcode3.Text & "'"
            'sql += " and fLCDPline = '4' "
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = "  Model Name"
            ds.Tables("Heater_FinishGood_Production").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("Heater_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM Heater_FinishGood_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and C_Line_Shift ='" & cmb_Pcode3.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_FinishGood_Production")
            ds.Tables("Heater_FinishGood_Production").Columns(0).ColumnName = "S U M "
            dg5.DataSource = ds.Tables("Heater_FinishGood_Production")
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
            sql += " SELECT  Model_control,Model_Name FROM Heater_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_ModelName")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "Model_control"
            cmb_Pcode.DisplayMember = "Model_Name"
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

            sql = "DELETE FROM Heater_FinishGood_Production"
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
                If txtDelete.Text.Length < 18 Then Exit Sub

                Dim sql As String

                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtDelete.Text.Substring(0, 7)
                Barcode_Part(1) = txtDelete.Text.Substring(7, 2)
                Barcode_Part(2) = txtDelete.Text.Substring(9, 7)
                Barcode_Part(3) = txtDelete.Text.Substring(16, 1)
                Barcode_Part(4) = txtDelete.Text.Substring(17, 1)
          
                If Barcode_Part(1) <> cmb_Pcode.SelectedValue Then
                    lbl_Msg.Text = "This serial is wrong"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Yellow
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                Else
                    ' insert the barcode  in database
                    sql = "DELETE FROM Heater_FinishGood_Production"
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
        Dim frm1 As New frmHeaterFinishGoodMFGQuery
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

   
    ' End Sub

    Private Sub txteancode_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        txtFATSERIAL.Text = ""
        txtFATSERIAL.Focus()
    End Sub
End Class