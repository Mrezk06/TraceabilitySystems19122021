Imports TEVPBarcode.sher
Public Class frmMicrowaveFinishGood
    Public Property StringPassc10 As String
    Private Sub frmMicrowaveFinishGood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = StringPassc10
        cmb_Pcode3.Focus()
        dd.Visible = False
        df.Visible = True
        txtFATSERIAL.Enabled = False
        cmb_Pcode.Enabled = False
        txtDelete.Enabled = False
        Try
            Dim strSearchText As String = "M"
            Dim sql As String = ""
            sql += "SELECT CModelName,CMC FROM CModels"
            sql += "  WHERE CBlo Like '%" + strSearchText + "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "CMC"
            cmb_Pcode.DisplayMember = "CModelName"
            cmb_Pcode.Sorted = True
        Catch ex As Exception
        End Try
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
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
    Private Sub txtFATSERIAL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFATSERIAL.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length <= 17 Then
                    Dim dsMax As New DataSet
                    Dim Sql = "SELECT CBarcode  FROM  C_FinishGood_Production "
                    Sql += " where CBarcode='" & txtFATSERIAL.Text & "'"
                    Sql += " and CModelName='" & cmb_Pcode.Text & "'"
                    Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                    dsMax.Tables.Clear()
                    da.Fill(dsMax)
                    If dsMax.Tables(0).Rows.Count > 0 Then
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "تم تسجيل الباركود من قبل "
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
                        lbl_Msg.Text = "الميكروويف لم يتم  تسجيله فى خرج الانتاج"
                        Console.Beep()
                        txtFATSERIAL.Focus()
                        txtFATSERIAL.SelectAll()
                        Exit Sub
                    End If
                    Dim Barcode_Part(6) As String
                    Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 5)
                    Barcode_Part(1) = txtFATSERIAL.Text.Substring(5, 7)
                    Barcode_Part(2) = txtFATSERIAL.Text.Substring(12, 5)
                    If Barcode_Part(2) <> cmb_Pcode.SelectedValue.ToString Then
                        lbl_Msg.Text = "الباركود غير مطابق "
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        txtFATSERIAL.Focus()
                        txtFATSERIAL.SelectAll()
                        Exit Sub
                    Else
                        lbl_Msg.ForeColor = Color.GreenYellow
                        lbl_Msg.Text = "تم تسجيل الميكروويف بنجاح"
                        txteancode.Focus()
                        txtFATSERIAL.Enabled = False
                        txteancode.SelectAll()
                        _Refresh1()
                        _Refresh13()
                    End If
                Else
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "هذا الباركود خطاء"
                    txtFATSERIAL.SelectAll()
                    txtFATSERIAL.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txteancode_TextChanged(sender As Object, e As EventArgs) Handles txteancode.TextChanged

    End Sub

    Private Sub txteancode_KeyDown(sender As Object, e As KeyEventArgs) Handles txteancode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txteancode.Text.Length < 11 Then Exit Sub
                Dim dsMax1 As New DataSet
                Dim Sql1 = "SELECT  CModelName, CEanCode, CMC FROM CModels where CModelName = '" & cmb_Pcode.Text & "'"
                Sql1 += " and CEanCode ='" & txteancode.Text & "'"
                Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
                dsMax1.Tables.Clear()
                da1.Fill(dsMax1)
                If dsMax1.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "الايان كود غير مطابق للموديل"
                    Console.Beep()
                    txteancode.Focus()
                    txteancode.SelectAll()
                    Exit Sub
                Else
                    Dim sql As String
                    sql = "INSERT INTO C_FinishGood_Production"
                    sql += "(CBarcode, C_EanCode, CModelName, C_Line_Shift, CSapUser,ModelControl,NewFactory)"
                    sql += "VALUES     ('" & txtFATSERIAL.Text & "','" & txteancode.Text & "','" & cmb_Pcode.Text & "','" & cmb_Pcode3.Text & "','" & Label2.Text & "','" & lbl_Pcode_Value.Text & "','M')"
                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل الجهاز بنجاح "
                    txtFATSERIAL.Enabled = True
                    txteancode.Enabled = False
                    txtFATSERIAL.Text = ""
                    txteancode.Text = ""
                    _Refresh1()
                    _Refresh13()
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        txtFATSERIAL.Enabled = True
        cmb_Pcode.Enabled = True
        txtDelete.Enabled = True
        cmb_Pcode3.Enabled = False
        _Refresh315()
        dd.Visible = True
        df.Visible = False
        cmb_Pcode.Focus()
        _Refresh1()
        _Refresh13()
    End Sub
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += "and NewFactory Like '%" & sss & "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "S U M "
            dg5.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Dim sss As String = "M"
    Private Function _Refresh1() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
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

    Private Sub txtDelete_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDelete.KeyDown
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
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtFATSERIAL.Focus()
        txtFATSERIAL.SelectAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtFATSERIAL.Text = ""
        txteancode.Text = ""
        txtFATSERIAL.Enabled = True
        txteancode.Enabled = False
        txtFATSERIAL.Focus()
    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm1 As New frmcookerFinishGoodQuery
        frm1.Show()
    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtFATSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub
End Class