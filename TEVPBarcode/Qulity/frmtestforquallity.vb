Imports TEVPBarcode.sher
Public Class frmtestforquallity

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtnotesUSB1_TextChanged(sender As Object, e As EventArgs) Handles txtnotesUSB1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Enabled = False
        GroupBox3.Enabled = True
        comstatesHDMI1.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox3.Enabled = False
        GroupBox5.Enabled = True
        comComponent.Focus()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox5.Enabled = False
        GroupBox4.Enabled = True
        comStatesWB.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox4.Enabled = False
        GroupBox6.Enabled = True
        txtSerial.Focus()

    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fNote FROM QAFU"
            ' sql += " FROM Output"
            ' sql += "  Heater_Sap_Laber = fSapL"
            sql += " where fPDate = Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU")
            ds.Tables("QAFU").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU").Columns(5).ColumnName = "States"
            ds.Tables("QAFU").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU").Columns(7).ColumnName = "Notes"
            DG.DataSource = ds.Tables("QAFU")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles txtNotesPQO.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmtestforquallity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/DiamondPurple.ssk"
        GroupBox6.Enabled = False
        _Refresh315()
        'Try
        '    Dim sql As String = ""
        '    sql += " SELECT   fLCDModelName FROM   LCDTVModels "

        '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        '    Dim ds As New DataSet
        '    ds.Tables.Clear()
        '    da.Fill(ds, "LCDTVModels")

        '    comModelName.DataSource = ds.Tables(0)
        '    'comModelName.ValueMember = "fLCDSetID"
        '    comModelName.DisplayMember = "fLCDModelName"
        '    comModelName.Sorted = True

        '    '_Refresh1()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO quality_IM "
            sql += "(fLCDBarcode ,fModel,fLineAndShift ,fStates,fNote,fSapL)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comModelName.Text & "','" & comLineAndShift.Text & "','" & comStatesAllProcess.Text & "','" & txtNotesAllProcess.Text & "','" & txtSapLabor.Text & "')"



            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comComponent.SelectedIndexChanged
        If comComponent.Text = "NG" Then
            txtnotesComponent.Visible = True
            Label40.Visible = True
            txtnotesComponent.Focus()
        End If
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comVideo1.SelectedIndexChanged
        If comVideo1.Text = "NG" Then
            txtnotesVideo1.Visible = True
            Label40.Visible = True
            txtnotesVideo1.Focus()
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comVideo2.SelectedIndexChanged
        If comVideo2.Text = "NG" Then
            txtnotesVideo2.Visible = True
            Label40.Visible = True
            txtnotesVideo2.Focus()
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSatellite.SelectedIndexChanged
        If comSatellite.Text = "NG" Then
            txtnotesSatellite.Visible = True
            Label40.Visible = True
            txtnotesSatellite.Focus()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtnotesSatellite.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles txtnotesVideo2.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtnotesComponent.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles txtnotesVideo1.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub ch2_CheckedChanged(sender As Object, e As EventArgs)
    '    txtnotesUSB2.Visible = True
    '    ch2.Visible = False
    'End Sub

    'Private Sub ch3_CheckedChanged(sender As Object, e As EventArgs)
    '    txtnotesUSB3.Visible = True
    '    ch3.Visible = False
    'End Sub

    Private Sub comStatesUSB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesUSB1.SelectedIndexChanged
        If comStatesUSB1.Text = "NG" Then
            txtnotesUSB1.Visible = True
            Label6.Visible = True
            'ch1.Visible = False
        End If

    End Sub

    Private Sub comStatesUSB2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesUSB2.SelectedIndexChanged
        If comStatesUSB2.Text = "NG" Then
            txtnotesUSB2.Visible = True
            Label6.Visible = True
            'ch1.Visible = False
        End If
    End Sub

    Private Sub comStatesUSB3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesUSB3.SelectedIndexChanged
        If comStatesUSB3.Text = "NG" Then
            txtnotesUSB3.Visible = True
            Label6.Visible = True
            txtnotesUSB3.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtNotesWB.TextChanged

    End Sub

    Private Sub comstatesHDMI1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comstatesHDMI1.SelectedIndexChanged
        If comstatesHDMI1.Text = "NG" Then
            txtnotesHDMI1.Visible = True
            Label7.Visible = True
            txtnotesHDMI1.Focus()


        End If
    End Sub

    Private Sub comstatesHDMI2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comstatesHDMI2.SelectedIndexChanged
        If comstatesHDMI2.Text = "NG" Then
            txtnotesHDMI2.Visible = True
            Label7.Visible = True
            txtnotesHDMI2.Focus()
        End If
    End Sub

    Private Sub comstatesHDMI3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comstatesHDMI3.SelectedIndexChanged
        If comstatesHDMI3.Text = "NG" Then
            txtnotesHDMI3.Visible = True
            Label7.Visible = True
            txtnotesHDMI3.Focus()
        End If
    End Sub

    Private Sub comstatesHDMI4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comstatesHDMI4.SelectedIndexChanged
        If comstatesHDMI4.Text = "NG" Then
            txtnotesHDMI4.Visible = True
            Label7.Visible = True
            txtnotesHDMI4.Focus()
        End If
    End Sub

    Private Sub comstatesPC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comstatesPC.SelectedIndexChanged
        If comstatesPC.Text = "NG" Then
            txtnotesPC.Visible = True
            Label7.Visible = True
            txtnotesPC.Focus()
        End If
    End Sub

    Private Sub comStatesWB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesWB.SelectedIndexChanged
        If comStatesWB.Text = "NG" Then
            txtNotesWB.Visible = True
            Label15.Visible = True
            txtNotesWB.Focus()
        End If
    End Sub

    Private Sub comStatesLV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesLV.SelectedIndexChanged
        If comStatesLV.Text = "NG" Then
            txtNotesLV.Visible = True
            Label15.Visible = True
            txtNotesLV.Focus()
        End If
    End Sub

    Private Sub comStates4K_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStates4K.SelectedIndexChanged
        If comStates4K.Text = "NG" Then
            txtNotes4K.Visible = True
            Label15.Visible = True
            txtNotes4K.Focus()
        End If
    End Sub

    Private Sub comStatesLAN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesLAN.SelectedIndexChanged
        If comStatesLAN.Text = "NG" Then
            txtNotesLAN.Visible = True
            Label15.Visible = True
            txtNotesLAN.Focus()
        End If
    End Sub

    Private Sub comStatesDAnalog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesDAnalog.SelectedIndexChanged
        If comStatesDAnalog.Text = "NG" Then
            txtNotesDAnalog.Visible = True
            Label15.Visible = True
            txtNotesDAnalog.Focus()
        End If
    End Sub

    Private Sub comStatesHandFree_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesHandFree.SelectedIndexChanged
        If comStatesHandFree.Text = "NG" Then
            txtNotesHandFree.Visible = True
            Label15.Visible = True
            txtNotesHandFree.Focus()
        End If
    End Sub

    Private Sub comStatesAccessory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesAccessory.SelectedIndexChanged
        If comStatesAccessory.Text = "NG" Then
            txtNotesAccessory.Visible = True
            Label15.Visible = True
            txtNotesAccessory.Focus()
        End If
    End Sub

    Private Sub comStatesCarton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesCarton.SelectedIndexChanged
        If comStatesCarton.Text = "NG" Then
            txtNotesCarton.Visible = True
            Label15.Visible = True
            txtNotesCarton.Focus()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            If txtSerial.Text = "" Or comModelName.Text = "" Or comLineAndShift.Text = "" Or comStatesAllProcess.Text = "" Or txtSapLabor.Text = "" Then
                MsgBox("Please check your Input Data")
            Else
                Add1_New()
                Add1_NewUSB1()
                Add1_NewUSB2()
                Add1_NewUSB3()

                Add1_NewHDMI1()
                Add1_NewHDMI2()
                Add1_NewHDMI3()
                Add1_NewHDMI4()
                Add1_NewPC()

                Add1_NewSatellite()
                Add1_NewVideo2()
                Add1_NewVideo1()
                Add1_NewCOMP()

                Add1_NewHAndfree()
                Add1_NewDAnlog()
                Add1_NewLAN()
                Add1_NewLV()
                Add1_New4K()
                Add1_NewWP()
                Add1_Newacarton()
                Add1_Newaccessory()
                Add1_NewaPowerQnsumtionSTDBY()
                Add1_NewaPowerQnsumtionON()
                Close()
                Dim frm As New frmtestforquallity
                frm.Show()

            End If
        Catch ex As Exception

        End Try
  
        Try
            '   If comstatesHDMI1.Text = "NG" Or comstatesHDMI1.Text = "OK" Then

            '0 Else
            'Button7.Focus()

            ' End If
        Catch ex As Exception

        End Try
    



    End Sub

    Private Sub txtSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSerial.KeyDown
       
        Try
            If e.KeyCode = Keys.Enter Then
                If txtSerial.Text.Length <> 14 Then
                    MsgBox("باركود الجهاز خطأ")
                Else

                    Dim Barcode_Part(6) As String
                    Barcode_Part(0) = txtSerial.Text.Substring(0, 1)
                    Barcode_Part(1) = txtSerial.Text.Substring(1, 2)
                    Barcode_Part(2) = txtSerial.Text.Substring(3, 3)
                    Barcode_Part(3) = txtSerial.Text.Substring(6, 1)
                    Barcode_Part(4) = txtSerial.Text.Substring(7, 1)
                    Barcode_Part(5) = txtSerial.Text.Substring(8, 4)
                    Barcode_Part(6) = txtSerial.Text.Substring(12, 2)

                    'If Barcode_Part(2) <> txtmodel.SelectedValue Then

                    '    '   txtbarcode.BackColor = Color.Red
                    '    MsgBox("BIN Code Structure wrong")
                    '    'MsgBox.ForeColor = Color.Yellow

                    '    txtbarcode.Focus()
                    '    txtbarcode.SelectAll()

                    'Else
                    txtNotesAllProcess.Focus()
                    '        End If
                    Dim sql As String = ""
                    sql += "SELECT fLCDModelName FROM  LCDTVModels "
                    ' sql += " FROM Output"
                    sql += " where fLCDSetID='" & Barcode_Part(2) & "'"
                    sql += " and fpanelID='" & Barcode_Part(6) & "'"
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "LCDTVModels")

                    comModelName.DataSource = ds.Tables(0)
                    '  txtresonProblem.ValueMember = "R_Name_Problem"
                    comModelName.DisplayMember = "fLCDModelName"
                    comModelName.Sorted = True


                End If
                '    End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSerial_TextChanged(sender As Object, e As EventArgs) Handles txtSerial.TextChanged

    End Sub

    Private Sub comStatesAllProcess_KeyDown(sender As Object, e As KeyEventArgs) Handles comStatesAllProcess.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNotesAllProcess.Focus()
        End If

    End Sub

    Private Sub comStatesAllProcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesAllProcess.SelectedIndexChanged

    End Sub

    Private Sub txtNotesAllProcess_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNotesAllProcess.KeyDown
        If e.KeyCode = Keys.Enter Then
            comLineAndShift.Focus()
        End If

    End Sub

    Private Sub txtNotesAllProcess_TextChanged(sender As Object, e As EventArgs) Handles txtNotesAllProcess.TextChanged

    End Sub

    Private Sub comLineAndShift_KeyDown(sender As Object, e As KeyEventArgs) Handles comLineAndShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSapLabor.Focus()
        End If

    End Sub

    Private Sub comLineAndShift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comLineAndShift.SelectedIndexChanged

    End Sub

    Private Sub txtSapLabor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSapLabor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If comStatesUSB1.Text = "NG" Or comStatesUSB2.Text = "NG" Or comStatesUSB3.Text = "NG" Or comStatesPQO.Text = "NG" Or comStatesPQSB.Text = "NG" Or comstatesHDMI1.Text = "NG" Or comstatesHDMI2.Text = "NG" Or comstatesHDMI3.Text = "NG" Or comstatesHDMI4.Text = "NG" Or comstatesPC.Text = "NG" Or comComponent.Text = "NG" Or comVideo1.Text = "NG" Or comVideo2.Text = "NG" Or comSatellite.Text = "NG" Or comStatesWB.Text = "NG" Or comStatesLV.Text = "NG" Or comStates4K.Text = "NG" Or comStatesLAN.Text = "NG" Or comStatesDAnalog.Text = "NG" Or comStatesHandFree.Text = "NG" Or comStatesAccessory.Text = "NG" Or comStatesCarton.Text = "NG" Then

                comStatesAllProcess.Text = "NG"
            Else
                comStatesAllProcess.Text = "OK"
            End If

            Button7.Focus()
        End If

    End Sub

    Private Sub txtSapLabor_TextChanged(sender As Object, e As EventArgs) Handles txtSapLabor.TextChanged

    End Sub
    Private Function Add1_NewUSB1() As Boolean
        Try
            Dim U1 As String = "USB1"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesUSB1.Text & "','" & txtnotesUSB1.Text & "','" & U1 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewUSB2() As Boolean
        Try
            Dim U2 As String = "USB2"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesUSB2.Text & "','" & txtnotesUSB2.Text & "','" & U2 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewUSB3() As Boolean
        Try
            Dim U3 As String = "USB3"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesUSB3.Text & "','" & txtnotesUSB3.Text & "','" & U3 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewHDMI1() As Boolean
        Try
            Dim v1 As String = "HDMI1"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comstatesHDMI1.Text & "','" & txtnotesHDMI1.Text & "','" & v1 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewHDMI2() As Boolean
        Try
            Dim v2 As String = "HDMI2"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comstatesHDMI2.Text & "','" & txtnotesHDMI2.Text & "','" & v2 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewCOMP() As Boolean
        Try
            Dim c1 As String = "COMPONENT"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comComponent.Text & "','" & txtnotesComponent.Text & "','" & c1 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewVideo1() As Boolean
        Try
            Dim V1 As String = "VIDEO1"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comVideo1.Text & "','" & txtnotesVideo1.Text & "','" & V1 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewVideo2() As Boolean
        Try
            Dim V2 As String = "VIDEO2"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comVideo2.Text & "','" & txtnotesVideo2.Text & "','" & V2 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewSatellite() As Boolean
        Try
            Dim s1 As String = "Satellite"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comSatellite.Text & "','" & txtnotesSatellite.Text & "','" & s1 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewHDMI3() As Boolean
        Try
            Dim v3 As String = "HDMI3"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comstatesHDMI3.Text & "','" & txtnotesHDMI3.Text & "','" & v3 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewHDMI4() As Boolean
        Try
            Dim v4 As String = "HDMI4"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comstatesHDMI4.Text & "','" & txtnotesHDMI4.Text & "','" & v4 & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewPC() As Boolean
        Try
            Dim vvp As String = "PC"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comstatesHDMI4.Text & "','" & txtnotesHDMI4.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewWP() As Boolean
        Try
            Dim vvp As String = "WB"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesWB.Text & "','" & txtNotesWB.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Function Add1_New4K() As Boolean
        Try
            Dim vvp As String = "4K"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStates4K.Text & "','" & txtNotes4K.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewLV() As Boolean
        Try
            Dim vvp As String = "LV"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesLV.Text & "','" & txtNotesLV.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewLAN() As Boolean
        Try
            Dim vvp As String = "LAN"
            Dim sql As String
            sql = "	INSERT INTO  quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesLAN.Text & "','" & txtNotesLAN.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewDAnlog() As Boolean
        Try
            Dim vvp As String = "D.Analog"
            Dim sql As String
            sql = "	INSERT INTO  quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesDAnalog.Text & "','" & txtNotesDAnalog.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_NewHAndfree() As Boolean
        Try
            Dim vvp As String = "Hand.Free"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesHandFree.Text & "','" & txtNotesHandFree.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_Newaccessory() As Boolean
        Try
            Dim vvp As String = "Accessory"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesAccessory.Text & "','" & txtNotesAccessory.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
   
    Private Function Add1_Newacarton() As Boolean
        Try
            Dim vvp As String = "Carton"
            Dim sql As String
            sql = "	INSERT INTO quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesCarton.Text & "','" & txtNotesCarton.Text & "','" & vvp & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Function Add1_NewaPowerQnsumtionON() As Boolean
        Try
            Dim vvp As String = "Power Qnsumtion ON"
            Dim sql As String
            sql = "	INSERT INTO  quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP,fBalanc)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesPQO.Text & "','" & txtNotesPQO.Text & "','" & vvp & "','" & txtValuePQO.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
 
    Private Function Add1_NewaPowerQnsumtionSTDBY() As Boolean
        Try
            Dim vvp As String = "Power Qnsumtion STD BY"
            Dim sql As String
            sql = "	INSERT INTO  quality_ID "
            sql += "(fLCDBarcode,fStates,fNote,fNameP,fBalanc)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comStatesPQSB.Text & "','" & txtNotesPQSB.Text & "','" & vvp & "','" & txtPQSB.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm As New frmQuerytestforquallity
        frm.Show()

    End Sub
End Class