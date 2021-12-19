Imports TEVPBarcode.sher
Public Class frmLEDBAR_Packing

    Private Sub frmLEDBAR_Packing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM   LCDTVModelsLED "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModelsLED")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "fLCDSetID"
            '  cmb_Pcode.ValueMember = "fpanelID"
            cmb_Pcode.DisplayMember = "fLCDModelName"
            cmb_Pcode.Sorted = True
            '_Refresh110()
            _Refresh1()
        Catch ex As Exception
        End Try
        'Try
        '    Dim sql As String = ""
        '    sql += " SELECT  fpanelID, fLCDModelName FROM   LCDTVModelsLED "

        '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        '    Dim ds As New DataSet
        '    ds.Tables.Clear()
        '    da.Fill(ds, "LCDTVModelsLED")
        '    cmb_Pcode.DataSource = ds.Tables(0)
        '    ' cmb_Pcode.ValueMember = "fLCDSetID"
        '    cmb_Pcode.ValueMember = "fpanelID"
        '    cmb_Pcode.DisplayMember = "fLCDModelName"
        '    cmb_Pcode.Sorted = True
        '    '_Refresh110()
        '    _Refresh1()
        'Catch ex As Exception
        'End Try
        ' Label2.Text = cmb_Pcode.Text
        gb7.Enabled = False
        gb5.Enabled = False
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count(fSerial_No) FROM packing_LEDBAR "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fBIN_Code ='" & Label8.Text & "'"
            sql += " and fLCDModelName ='" & cmb_Pcode.Text & "'"
            sql += " and fLine ='" & txtFATSERIAL.Text & "'"
            sql += " and fpackingnum ='" & txtpackingnum.Text & "'"
            '     sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "packing_LEDBAR")
            ds.Tables("packing_LEDBAR").Columns(0).ColumnName = " QTY/Carton"
            '  ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dgc.DataSource = ds.Tables("packing_LEDBAR")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count(fSerial_No) FROM packing_LEDBAR "
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fBIN_Code ='" & Label8.Text & "'"
            '  sql += " and fLCDModelName ='" & cmb_Pcode.Text & "'"
            sql += " and fLine ='" & txtFATSERIAL.Text & "'"
            'sql += " and fpackingnum ='" & txtpackingnum.Text & "'"
            '     sql += " group by fLCDModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "packing_LEDBAR")
            ds.Tables("packing_LEDBAR").Columns(0).ColumnName = " QTY/Day"
            '  ds.Tables("View_1").Columns(1).ColumnName = " Qty"
            dgd.DataSource = ds.Tables("packing_LEDBAR")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtPARTSSERIAL_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPARTSSERIAL.KeyDown
        Try
            Dim Barcode_Part As String
            If e.KeyCode = Keys.Enter Then
                Barcode_Part = txtPARTSSERIAL.Text.Substring(0, 18)
                If txtPARTSSERIAL.Text.Length < 18 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql2 = "SELECT fLCDBarcode FROM packing_LEDBAR where fLCDBarcode='" & txtPARTSSERIAL.Text & "'"
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

                If Barcode_Part1(6) <> lbl_Pcode_Value.Text Then
                    lbl_Msg.Text = "wrong ID"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Red
                    txtPARTSSERIAL.Focus()
                    txtPARTSSERIAL.SelectAll()
                Else
                    Label8.Text = Barcode_Part1(1)
                    txtPARTSSERIAL.Enabled = False
                    txtpackingnum.Enabled = False
                    TextBox1.Enabled = True
                    TextBox1.Focus()
                    TextBox1.SelectAll()

                    _Refresh1()
                End If
            Exit Sub
            End If
        Catch ex As Exception
        End Try
        _Refresh1()
    End Sub

    Private Sub txtPARTSSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtPARTSSERIAL.TextChanged

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
            'cmb_Pcode.Enabled = True
            '' txtline.Enabled = False
            '  txtshift.Enabled = True
            'GroupBox2.Visible = True
            ''txtshift.Visible = False
         

            gb7.Enabled = True
            gb3.Enabled = False
            'Me.BackColor = Color.YellowGreen
            cmb_Pcode.Focus()
            cmb_Pcode.SelectAll()
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmb_Pcode.Text = "" Or txtFATSERIAL.Text = "" Then

            MsgBox("please Check Line Or Model or shift")

            Exit Sub
        Else
            Try
                ''   _Refresh11()
                cmb_Pcode.Enabled = False
                ' txtline.Enabled = False
                txtFATSERIAL.Enabled = False
                '  txtshift.Visible = False
                '  Label8.Visible = False
                gb5.Enabled = True
                txtPARTSSERIAL.Focus()
                txtPARTSSERIAL.SelectAll()
                'Try
                '    Dim sql As String = ""
                '    sql += " SELECT  fpanelID, fLCDModelName FROM   LCDTVModelsLED "

                '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                '    Dim ds As New DataSet
                '    ds.Tables.Clear()
                '    da.Fill(ds, "LCDTVModelsLED")
                '    cmb_Pcode.DataSource = ds.Tables(0)
                '    ' cmb_Pcode.ValueMember = "fLCDSetID"
                '    cmb_Pcode.ValueMember = "fpanelID"
                '    cmb_Pcode.DisplayMember = "fLCDModelName"
                '    cmb_Pcode.Sorted = True
                '    '_Refresh110()
                '    _Refresh1()
                'Catch ex As Exception
                'End Try
                'Label2.Text = cmb_Pcode.Text
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString

            'Panel.Text = cmb_Pcode.SelectedValue
            ' Label2.Text = cmb_Pcode.Text
            'txtFATSERIAL.Enabled = True
            _Refresh1()
            _Refresh11()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        Dim f As Integer = 1
        txtpackingnum.Text = txtpackingnum.Text + f
        txtPARTSSERIAL.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        txtPARTSSERIAL.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label8.Text = ""
        txtPARTSSERIAL.Focus()


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
      Try
            Dim Barcode_Part As String
            If e.KeyCode = Keys.Enter Then
                Barcode_Part = TextBox1.Text.Substring(0, 18)
                If TextBox1.Text.Length < 18 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql2 = "SELECT fLCDBarcode FROM packing_LEDBAR where fLCDBarcode='" & TextBox1.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql2, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This Serial is already used"
                    Console.Beep()
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                    Exit Sub
                End If
                Dim sql As String
                Dim Barcode_Part1(7) As String
                Barcode_Part1(0) = TextBox1.Text.Substring(0, 1)
                Barcode_Part1(1) = TextBox1.Text.Substring(1, 4)
                Barcode_Part1(2) = TextBox1.Text.Substring(5, 1)
                Barcode_Part1(3) = TextBox1.Text.Substring(6, 1)
                Barcode_Part1(4) = TextBox1.Text.Substring(7, 1)
                Barcode_Part1(5) = TextBox1.Text.Substring(8, 5)
                Barcode_Part1(6) = TextBox1.Text.Substring(13, 3)
                Barcode_Part1(7) = TextBox1.Text.Substring(16, 2)
                If Barcode_Part1(6) <> lbl_Pcode_Value.Text Then
                    lbl_Msg.Text = "wrong ID"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Red
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                ElseIf Barcode_Part1(1) <> Label8.Text Then
                    lbl_Msg.Text = "Bin Code Is wrong"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Red
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                Else
                    sql = "INSERT INTO  packing_LEDBAR"
                    sql += "(fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName,fLine,fpackingnum)"
                    sql += "VALUES     ('"
                    sql += TextBox1.Text & "',"
                    sql += "'" & Barcode_Part1(1) & "','" & txtParts1.Text & "',"
                    sql += "'" & cmb_Pcode.Text & "',"
                    sql += "'" & txtFATSERIAL.Text & "','" & txtpackingnum.Text & "')"
                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.Text = "OK"
                    lbl_Msg.ForeColor = Color.GreenYellow
                    '   If Label8.Text = "" Then
                    'Label8.Text = Barcode_Part1(1)
                    txtPARTSSERIAL.Enabled = False
                    txtpackingnum.Enabled = False
                    TextBox1.Enabled = False
                    TextBox2.Enabled = True
                    TextBox2.Focus()
                    TextBox2.SelectAll()
                    'Else
                    ''  Label8.Text = Barcode_Part1(1)
                    'txtPARTSSERIAL.Enabled = False
                    'txtpackingnum.Enabled = False
                    'TextBox1.Enabled = True
                    'TextBox1.Focus()
                    'TextBox1.SelectAll()
                    '   End If
                    _Refresh1()
                End If
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        _Refresh1()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnBACKTOTOP_Click(sender As Object, e As EventArgs) Handles btnBACKTOTOP.Click
        Try
            cmb_Pcode.Enabled = True
            ' txtline.Enabled = False
            txtFATSERIAL.Enabled = False
            '  txtshift.Visible = False
            '  Label8.Visible = False
            gb5.Enabled = False
            cmb_Pcode.Focus()
            cmb_Pcode.SelectAll()
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Try
            Dim Barcode_Part As String
            If e.KeyCode = Keys.Enter Then
                Barcode_Part = TextBox2.Text.Substring(0, 18)
                If TextBox2.Text.Length < 18 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql2 = "SELECT fLCDBarcode FROM packing_LEDBAR where fLCDBarcode='" & TextBox2.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql2, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This Serial is already used"
                    Console.Beep()
                    TextBox2.Focus()
                    TextBox2.SelectAll()
                    Exit Sub
                End If
                Dim sql As String
                Dim Barcode_Part1(7) As String
                Barcode_Part1(0) = TextBox2.Text.Substring(0, 1)
                Barcode_Part1(1) = TextBox2.Text.Substring(1, 4)
                Barcode_Part1(2) = TextBox2.Text.Substring(5, 1)
                Barcode_Part1(3) = TextBox2.Text.Substring(6, 1)
                Barcode_Part1(4) = TextBox2.Text.Substring(7, 1)
                Barcode_Part1(5) = TextBox2.Text.Substring(8, 5)
                Barcode_Part1(6) = TextBox2.Text.Substring(13, 3)
                Barcode_Part1(7) = TextBox2.Text.Substring(16, 2)

                Dim dsMax1 As New DataSet
                Dim Sql21 = " SELECT   fpanelIDLCM FROM LCDTVModelsLED where fpanelIDLCM='" & Barcode_Part1(6) & "'"
                Dim da1 As New SqlClient.SqlDataAdapter(Sql21, cn)
                dsMax.Tables.Clear()
                da1.Fill(dsMax1)
                If dsMax1.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "This Serial is Wrong"
                    Console.Beep()
                    TextBox2.Focus()
                    TextBox2.SelectAll()
                    Exit Sub
                End If


                'If Barcode_Part1(6) <> lbl_Pcode_Value.Text Then
                '    lbl_Msg.Text = "wrong ID"
                '    Console.Beep()
                '    lbl_Msg.ForeColor = Color.Red
                '    TextBox2.Focus()
                '    TextBox2.SelectAll()
                'Else
                If Barcode_Part1(1) <> Label8.Text Then
                    lbl_Msg.Text = "Bin Code Is wrong"
                    Console.Beep()
                    lbl_Msg.ForeColor = Color.Red
                    TextBox2.Focus()
                    TextBox2.SelectAll()
                Else
                    sql = "INSERT INTO  packing_LEDBAR"
                    sql += "(fLCDBarcode, fBIN_Code, fSerial_No, fLCDModelName,fLine,fpackingnum)"
                    sql += "VALUES     ('"
                    sql += TextBox2.Text & "',"
                    sql += "'" & Barcode_Part1(1) & "','" & txtParts1.Text & "',"
                    sql += "'" & cmb_Pcode.Text & "',"
                    sql += "'" & txtFATSERIAL.Text & "','" & txtpackingnum.Text & "')"
                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    lbl_Msg.Text = "OK"
                    lbl_Msg.ForeColor = Color.GreenYellow
                    '   If Label8.Text = "" Then
                    '   Label8.Text = Barcode_Part1(1)
                    txtPARTSSERIAL.Enabled = False
                    txtpackingnum.Enabled = False
                    TextBox1.Enabled = True
                    TextBox2.Enabled = False
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                    'Else
                    ''  Label8.Text = Barcode_Part1(1)
                    'txtPARTSSERIAL.Enabled = False
                    'txtpackingnum.Enabled = False
                    'TextBox1.Enabled = True
                    'TextBox1.Focus()
                    'TextBox1.SelectAll()
                    '   End If
                    _Refresh1()
                End If
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        _Refresh1()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class