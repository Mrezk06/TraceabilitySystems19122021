Imports TEVPBarcode.sher
Public Class scanningFat1

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Close()
    'End Sub

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

            Dim sql1 As String = " SELECT fCompCode, fCompName,part ,CONVERT(bit,0) as Found FROM Material "
            sql1 += " where fModelName ='" & cmb_Pcode.Text & "'"

            sql1 += " and fArea = 'Fat1' "
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
            Dim frm1 As New QueryFat1
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
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " and fLineandsh ='" & txtshift.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DailyP")
            ds.Tables("DailyP").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("DailyP").Columns(1).ColumnName = " Qty"
            dg2.DataSource = ds.Tables("DailyP")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh133(ByVal Sireal As String) As Boolean
        Try
            Dim dsMax1 As New DataSet
            Dim Sql1 = "SELECT  isnull(count(main),0) FROM DailyP where "
            Sql1 += "  main ='" & Sireal & "'"
            Sql1 += " or model ='" & Sireal & "'"
            Sql1 += " or power ='" & Sireal & "'"
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
    Private Sub scanningFat1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
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

            _Refresh1()
        Catch ex As Exception

        End Try
        cmb_Pcode.Enabled = False
        '' txtline.Enabled = False
        txtshift.Enabled = False
    End Sub

    Private Sub txtFATSERIAL_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFATSERIAL.HandleDestroyed

    End Sub

    Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown
        'Try

        '    Dim dsMax1 As New DataSet
        '    Dim Sql1 = "SELECT  main, power, model FROM DailyP where fLCDBarcode = '" & txtFATSERIAL.Text & "'"
        '    Sql1 += " and main ='" & txtPARTSSERIAL.Text & "'"
        '    Sql1 += " and model ='" & txtPARTSSERIAL.Text & "'"
        '    Sql1 += " and power ='" & txtPARTSSERIAL.Text & "'"
        '    ' Sql += " and fNameL='" & ComboBox2.Text & "'"
        '    Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
        '        dsMax1.Tables.Clear()
        '        da1.Fill(dsMax1)
        '        If dsMax1.Tables(0).Rows.Count < 1 Then
        '            lbl_Msg.ForeColor = Color.Red
        '        lbl_Msg.Text = "This component is Used in other model "
        '        txtPARTSSERIAL.Focus()
        '        txtPARTSSERIAL.SelectAll()
        '        Exit Sub
        '        End If
        '    ' End If
        '    ''''''''''''''''''''''''''''''''''
        'Catch ex As Exception

        'End Try
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

            If e.KeyCode = Keys.Enter Then
                If txtFATSERIAL.Text.Length < 14 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "Select fLCDBarcode from DailyP where fLCDBarcode='" & txtFATSERIAL.Text & "'"
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
                '''''''''''''''''

                ''''''''''''''''''''''''''''''''''
                If Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
                    lbl_Msg.Text = "BIN Code Structure wrong "
                    lbl_Msg.ForeColor = Color.Yellow
                    txtFATSERIAL.Focus()
                    txtFATSERIAL.SelectAll()
                Else

                    ' insert the barcode  in database
                    Sql = "INSERT INTO DailyP"
                    Sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID,fLCDModelName,main,power,model,fShift,fLineandsh)"
                    Sql += "VALUES     ('"
                    Sql += txtFATSERIAL.Text & "',"
                    For i As Integer = 0 To Barcode_Part.Length - 1
                        Sql += "'" & Barcode_Part(i) & "',"
                    Next
                    ' _Refresh133()
                    Sql += "'" & cmb_Pcode.Text & "',"
                    Sql += "'" & txtPARTSSERIAL.Text & "',"
                    Sql += "'" & txtPARTSSERIAL.Text & "',"
                    Sql += "'" & txtPARTSSERIAL.Text & "',"
                    Sql += "" & txtParts1.Text & ","
                    Sql += "'" & txtshift.Text & "')"
                    Dim cmd As New SqlClient.SqlCommand(Sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
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
                            Sql += "update  DailyP set " & dg1.Item(1, ii).Value & "='" & txtPARTSSERIAL.Text & "'"
                            Sql += " where fLCDBarcode='" & txtFATSERIAL.Text & "'"
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

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub lbl_Pcode_Value_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Pcode_Value.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        ' insert the barcode  in database
        Dim sql As String
        sql = "DELETE FROM [dbo].[DailyP]"
        sql += " where fLCDBarcode = '" & txtFATSERIAL.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(Sql, cn)
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
            lbl_Msg.Text = "welcome This name allowed to work on barcode Line"
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

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

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
            lbl_Msg.Text = "welcome This name allowed to work on barcode Line"
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

    Private Sub txtParts1_Layout(sender As Object, e As LayoutEventArgs) Handles txtParts1.Layout

    End Sub

    Private Sub txtParts1_TextChanged(sender As Object, e As EventArgs) Handles txtParts1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class