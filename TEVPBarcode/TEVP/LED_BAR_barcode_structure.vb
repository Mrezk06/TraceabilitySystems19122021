Imports TEVPBarcode.sher
Public Class LED_BAR_barcode_structure
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Close()
    'End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Try
            _Refresh11()
            _Refresh121()
            cmb_Pcode.Enabled = False

        Catch ex As Exception
        End Try
    End Sub
    Private Function _Refresh110() As Boolean
        Try
            Dim sql1 As String = "SELECT  COUNT ( fSerial_No)FROM LCM"
            sql1 += " where fBIN_Code ='" & Label8.Text & "'"
            sql1 += " and fLCDModelName ='" & cmb_Pcode.Text & "'"
            sql1 += " and fLCDBarcode ='" & txtFATSERIAL.Text & "'"
            sql1 += " and fLine ='4'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCM")
            'ds.Tables("Matrel").Columns(0).ColumnName = "الكود "
            ds.Tables("LCM").Columns(0).ColumnName = "Serial_No"
            dg5.DataSource = ds.Tables("LCM")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = " SELECT fCompCode, fCompName,part ,CONVERT(bit,2) as Found FROM Material "
            sql1 += " where fModelName ='" & cmb_Pcode.Text & "'"
            sql1 += " and fArea = 'LCM1' "
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
    Private Function _Refresh121() As Boolean
        Try
            Dim sql1 As String = " SELECT count (fCompCode) FROM Material "
            sql1 += " where fModelName ='" & cmb_Pcode.Text & "'"
            sql1 += " and fArea = 'LCM1' "
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Material")
            'ds.Tables("Matrel").Columns(0).ColumnName = "الكود "
            ds.Tables("Material").Columns(0).ColumnName = "Count LED"
            ggg.DataSource = ds.Tables("Material")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Try
            Dim frm1 As New q
            frm1.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnCHModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCHModel.Click
        Try
            cmb_Pcode.Enabled = True
            Dim frm1 As New frmGuidance
            frm1.Show()
        Catch ex As Exception
        End Try
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  [fLCDModelName]as LCDModelName,count ([Expr1])as qty  FROM [View_1] "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLine ='4'"
            sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_1")
            ds.Tables("View_1").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("View_1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown

        _Refresh110()
        Try
            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length < 11 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "SELECT  fLCDBarcode FROM  LCM where fLCDBarcode='" & txtFATSERIAL.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This Serial is already used"
                    Console.Beep()
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                    Exit Sub
                End If
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 9)
                Barcode_Part(1) = txtFATSERIAL.Text.Substring(9, 2)
                'Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
                'Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
                'Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                'Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 1)
                'Barcode_Part(6) = txtFATSERIAL.Text.Substring(9, 2)
                If Barcode_Part(1) <> cmb_Pcode.SelectedValue Then
                    lbl_Msg.Text = "The serial does not match the specified form"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Yellow
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                Else
                    lbl_Msg.Text = "OK"
                    lbl_Msg.ForeColor = Color.GreenYellow
                    txtFATSERIAL.Enabled = False
                    txtPARTSSERIAL.Enabled = True
                    txtPARTSSERIAL.Focus()
                    _Refresh1()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub scanningFat1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
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
            _Refresh110()
            _Refresh1()
        Catch ex As Exception
        End Try
    End Sub
    '*********************************************************************
    Private Sub txtFATSERIAL_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPARTSSERIAL.KeyDown

        _Refresh110()
        _Refresh1()
        Try
            Dim Barcode_Part As String
            If e.KeyCode = Keys.Enter Then
                Barcode_Part = txtPARTSSERIAL.Text.Substring(0, 18)
                For i As Integer = 0 To dg1.RowCount - 1
                    If Barcode_Part = dg1.Item(2, i).Value Then
                        dg1.Item(3, i).Value = True
                        dg1.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
                        Exit Sub
                    End If
                    If txtPARTSSERIAL.Text.Length < 18 Then Exit Sub
                    Dim dsMax As New DataSet
                    Dim Sql2 = "SELECT fSerial_No FROM LCM where fSerial_No='" & txtPARTSSERIAL.Text & "'"
                    Dim da As New SqlClient.SqlDataAdapter(Sql2, cn)
                    dsMax.Tables.Clear()
                    da.Fill(dsMax)
                    If dsMax.Tables(0).Rows.Count > 0 Then
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "This Serial is already used"
                        Console.Beep()
                        txtPARTSSERIAL.Focus()
                        txtPARTSSERIAL.SelectAll()
                        Exit Sub
                    End If
                    Dim sql As String
                    Dim Barcode_Part1(7) As String
                    Barcode_Part1(0) = txtPARTSSERIAL.Text.Substring(0, 1)
                    Barcode_Part1(1) = txtPARTSSERIAL.Text.Substring(1, 4)
                    Barcode_Part1(2) = txtPARTSSERIAL.Text.Substring(5, 1)
                    Barcode_Part1(3) = txtPARTSSERIAL.Text.Substring(6, 1)
                    Barcode_Part1(4) = txtPARTSSERIAL.Text.Substring(7, 1)
                    Barcode_Part1(5) = txtPARTSSERIAL.Text.Substring(8, 5)
                    Barcode_Part1(6) = txtPARTSSERIAL.Text.Substring(13, 3)
                    Barcode_Part1(7) = txtPARTSSERIAL.Text.Substring(16, 2)
                    If Barcode_Part1(6) <> dg1.Item(2, i).Value Then
                        lbl_Msg.Text = "Led Bar ID & Version wrong"
                        Console.Beep()
                        lbl_Msg.ForeColor = Color.Yellow
                        txtPARTSSERIAL.Focus()
                        txtPARTSSERIAL.SelectAll()
                    Else
                        ' insert the barcode  in database
                        sql = "INSERT INTO  LCM"
                        sql += "(fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName,fLine)"
                        sql += "VALUES     ('"
                        sql += txtFATSERIAL.Text & "',"
                        sql += "'" & Barcode_Part1(1) & "','" & txtPARTSSERIAL.Text & "',"
                        sql += "'" & cmb_Pcode.Text & "',"
                        sql += "'4')"
                        Dim cmd As New SqlClient.SqlCommand(sql, cn)
                        If cn.State = ConnectionState.Closed Then cn.Open()
                        cmd.ExecuteNonQuery()
                        cn.Close()
                        lbl_Msg.Text = "OK"
                        lbl_Msg.ForeColor = Color.GreenYellow
                        Label8.Text = Barcode_Part1(1)
                        txtPARTSSERIAL.Enabled = False
                        TextBox1.Focus()
                        TextBox1.SelectAll()
                        s += 1
                        If s = dg1.RowCount Then
                            txtPARTSSERIAL.Enabled = False
                            TextBox1.Enabled = True
                            TextBox1.Focus()
                            For x2 = 0 To i
                                dg1.Item(3, x2).Value = False
                                dg1.Rows(x2).DefaultCellStyle.BackColor = Color.Tomato
                            Next
                            s = 0
                        End If
                        Exit Sub
                    End If
                Next
                lbl_Msg.Text = "Not matching"
                Console.Beep()
                lbl_Msg.ForeColor = Color.Red
                txtPARTSSERIAL.Focus()
                txtPARTSSERIAL.SelectAll()
            End If
        Catch ex As Exception
        End Try
        _Refresh110()
        _Refresh1()
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
    Private Sub GroupBox5_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox5.Enter
    End Sub
    Dim s As Integer
    Dim i As Integer
    Dim s_Count As Integer
    Private Sub txtPARTSSERIAL_KeyDown1(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TextBox1.KeyDown
        Console.Beep()
        _Refresh110()
        Try
            If e.KeyCode <> Keys.Enter Then Exit Sub
            Dim Barcode_Part As String
            If TextBox1.Text.Length < 18 Then Exit Sub
            Dim Barcode_Part1(7) As String
            Barcode_Part1(0) = TextBox1.Text.Substring(0, 1)
            Barcode_Part1(1) = TextBox1.Text.Substring(1, 4)
            Barcode_Part1(2) = TextBox1.Text.Substring(5, 1)
            Barcode_Part1(3) = TextBox1.Text.Substring(6, 1)
            Barcode_Part1(4) = TextBox1.Text.Substring(7, 1)
            Barcode_Part1(5) = TextBox1.Text.Substring(8, 5)
            Barcode_Part1(6) = TextBox1.Text.Substring(13, 3)
            Barcode_Part1(7) = TextBox1.Text.Substring(16, 2)
            If Barcode_Part1(1) <> Label8.Text Then
                lbl_Msg.Text = "BIN Code Structure wrong "
                Console.Beep()
                lbl_Msg.ForeColor = Color.Yellow
                TextBox1.Focus()
                TextBox1.SelectAll()
                Exit Sub
            End If
            For i As Integer = 0 To dg1.RowCount - 1
                If Barcode_Part1(6) <> dg1.Item(2, i).Value Then
                    lbl_Msg.Text = " Led Bar ID & Version wrong"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Yellow
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                    Exit Sub
                End If
                Dim dsMax As New DataSet
                Dim Sql2 = "SELECT fSerial_No FROM LCM where fSerial_No='" & TextBox1.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql2, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This Serial is already used "
                    Console.Beep()
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                    Exit Sub
                End If
                If TextBox1.Text.Substring(1, 4) <> Label8.Text Then
                    lbl_Msg.Text = "BIN Code Structure wrong "
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Yellow
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                    Exit Sub
                End If
                Dim sql As String
                ' insert the barcode  in database
                sql = "INSERT INTO  LCM"
                sql += "(fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName,fLine)"
                sql += "VALUES     ('"
                sql += txtFATSERIAL.Text & "',"
                sql += "'" & Barcode_Part1(1) & "','" & TextBox1.Text & "',"
                sql += "'" & cmb_Pcode.Text & "',"
                sql += "'4')"
                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.Text = "OK"
                    s = s + 1
                    lbl_Msg.ForeColor = Color.GreenYellow
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                    If s = dg1.RowCount Then
                        txtPARTSSERIAL.Enabled = True
                        TextBox1.Enabled = True
                        txtFATSERIAL.Enabled = True
                        txtPARTSSERIAL.Text = ""
                        TextBox1.Text = ""
                        txtFATSERIAL.Text = ""
                        txtFATSERIAL.Focus()
                        For x2 = 0 To i
                            dg1.Item(3, x2).Value = False
                            dg1.Rows(x2).DefaultCellStyle.BackColor = Color.Tomato
                        Next
                        s = 0
                    End If
                    Exit Sub
                End If
            Next
            _Refresh110()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub
    Private Sub lbl_Pcode_Value_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Pcode_Value.Click
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
    End Sub
    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Del_Rec()
        txtFATSERIAL.Text = ""
        txtPARTSSERIAL.Text = ""
        TextBox1.Text = ""
        txtFATSERIAL.Enabled = True
        txtPARTSSERIAL.Enabled = True
        TextBox1.Enabled = True
        txtFATSERIAL.Focus()
    End Sub
    Private Sub btnBACKTOTOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBACKTOTOP.Click
        cmb_Pcode.Enabled = True
        txtFATSERIAL.Text = ""
        txtPARTSSERIAL.Text = ""
        TextBox1.Text = ""
        Label8.Text = ""
        cmb_Pcode.Focus()
    End Sub
    Private Function Del_Rec() As Boolean
        Try
            Dim sql As String
            sql = "DELETE FROM [LCM]"
            sql += " where fLCDBarcode = '" & txtFATSERIAL.Text & " '"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtPARTSSERIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPARTSSERIAL.TextChanged

    End Sub
    Private Sub TextBox1_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles TextBox1.Layout
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    End Sub
    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
    End Sub

    Private Sub txtFATSERIAL_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles txtFATSERIAL.HelpRequested

    End Sub
End Class