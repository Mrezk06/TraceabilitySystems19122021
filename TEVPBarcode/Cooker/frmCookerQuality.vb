Imports TEVPBarcode.sher
Public Class frmCookerQuality


    ' Public Class FrmNEWtESTrEQ
    Public Property StringPassc6 As String
    Private Sub FrmNEWtESTrEQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comModelName.Focus()
        Label3.Text = StringPassc6
        Try
            Dim sql As String = ""
            sql += "SELECT CModelName FROM CModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "CModels")
            comModelName.DataSource = ds.Tables(0)
            comModelName.DisplayMember = "CModelName"
            comModelName.Sorted = True
            _Refresh315()

        Catch ex As Exception

        End Try

        comModelName.Text = ""
    End Sub
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.cquality_IM "
            sql += "(fLCDBarcode ,fModel,fLineAndShift ,fStates,fNote,fSapL,fSv,F_SapReg)"
            sql += " VALUES ('" & txtSerial.Text & "','" & comModelName.Text & "','" & comLineAndShift.Text & "','" & comStatesAllProcess.Text & "','" & txtNotesAllProcess.Text & "','" & txtSapLabor.Text & "','" & txtsv.Text & "','" & Label3.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate  ,fPtime ,fLCDBarcode ,fModel,fLineAndShift,fStates ,Heater_Name_Laber ,fSv,fNote FROM QAFU1"
            ' sql += " FROM Output"
            ' sql += "  Heater_Sap_Laber = fSapL"
            sql += " where fPDate = Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "QAFU1")
            ds.Tables("QAFU1").Columns(0).ColumnName = "Date "
            ds.Tables("QAFU1").Columns(1).ColumnName = "Time"
            ds.Tables("QAFU1").Columns(2).ColumnName = "Barcode "
            ds.Tables("QAFU1").Columns(3).ColumnName = "Model"
            ds.Tables("QAFU1").Columns(4).ColumnName = "Line And Shift "
            ds.Tables("QAFU1").Columns(5).ColumnName = "States"
            ds.Tables("QAFU1").Columns(6).ColumnName = "Name_Laber "
            ds.Tables("QAFU1").Columns(7).ColumnName = "S.V"
            ds.Tables("QAFU1").Columns(8).ColumnName = "Notes"
            DG.DataSource = ds.Tables("QAFU1")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Sub txtSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If e.KeyCode = Keys.Enter Then                  
                    If txtSerial.Text.Length = 18 Then
                        Dim Barcode_Part(6) As String
                        Barcode_Part(0) = txtSerial.Text.Substring(0, 1)
                        Barcode_Part(1) = txtSerial.Text.Substring(1, 2)
                        Barcode_Part(2) = txtSerial.Text.Substring(3, 3)
                        Barcode_Part(3) = txtSerial.Text.Substring(6, 1)
                        Barcode_Part(4) = txtSerial.Text.Substring(7, 1)
                        Barcode_Part(5) = txtSerial.Text.Substring(8, 4)
                        Barcode_Part(6) = txtSerial.Text.Substring(12, 6)
                        comLineAndShift.Focus()
                        'Dim sql As String = ""
                        'sql += "SELECT CModelName FROM C_Output_Production where CBarcode='" & txtSerial.Text & "'"
                        'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                        'Dim ds As New DataSet
                        'da.Fill(ds, "C_Output_Production")
                        'comModelName.DataSource = ds.Tables(0)
                        'comModelName.DisplayMember = "CModelName"
                        'comModelName.Sorted = True
                    Else
                        MsgBox("باركود الباتوجاز خطأ")
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtSerial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerial.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSerial_Leave(sender As Object, e As EventArgs) Handles txtSerial.Leave
        ' If e.KeyCode = Keys.Enter Then
        If txtSerial.Text.Length < 14 Then Exit Sub
        Dim dsMax As New DataSet
        Dim Sql1 = "SELECT fLCDBarcode FROM cquality_IM where fLCDBarcode='" & txtSerial.Text & "'"
        Dim da2 As New SqlClient.SqlDataAdapter(Sql1, cn)
        dsMax.Tables.Clear()
        da2.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count > 0 Then
            'lbl_Msg.ForeColor = Color.Red
            'lbl_Msg.Text = "This Serial is already used"
            MsgBox("This Serial is already used")
            txtSerial.Focus()
            txtSerial.SelectAll()
            Exit Sub
        End If
        ' End If
    End Sub

    Private Sub txtSerial_TextChanged(sender As Object, e As EventArgs) Handles txtSerial.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Try
            If txtSerial.Text = "" Or comModelName.Text = "" Or comLineAndShift.Text = "" Or comStatesAllProcess.Text = "" Or txtSapLabor.Text = "" Or txtsv.Text = "" Then
                MsgBox("من فضلك ادخل كل البيانات ")
            Else

                Add1_New()
                _Refresh315()

                txtSerial.Text = ""
                comModelName.Text = ""
                comLineAndShift.Text = ""
                comStatesAllProcess.Text = ""
                txtSapLabor.Text = ""
                txtsv.Text = ""
                txtNotesAllProcess.Text = ""
                comModelName.Focus()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub comLineAndShift_KeyDown(sender As Object, e As KeyEventArgs) Handles comLineAndShift.KeyDown
        If e.KeyCode = Keys.Enter Then
            comStatesAllProcess.Focus()
        End If

    End Sub

    Private Sub comLineAndShift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comLineAndShift.SelectedIndexChanged

    End Sub

    Private Sub comStatesAllProcess_KeyDown(sender As Object, e As KeyEventArgs) Handles comStatesAllProcess.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSapLabor.Focus()
        End If

    End Sub

    Private Sub comStatesAllProcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStatesAllProcess.SelectedIndexChanged

    End Sub

    Private Sub txtSapLabor_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtsv.Focus()
        End If

    End Sub

    Private Sub txtSapLabor_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNotesAllProcess_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

            Try
                If txtSerial.Text = "" Or comModelName.Text = "" Or comLineAndShift.Text = "" Or comStatesAllProcess.Text = "" Or txtSapLabor.Text = "" Or txtsv.Text = "" Then
                    MsgBox("من فضلك ادخل كل البيانات")
                Else

                    Add1_New()
                    _Refresh315()

                    txtSerial.Text = ""
                    comModelName.Text = ""
                    comLineAndShift.Text = ""
                    comStatesAllProcess.Text = ""
                    txtSapLabor.Text = ""
                    txtsv.Text = ""
                    txtNotesAllProcess.Text = ""
                    txtSerial.Focus()

                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtNotesAllProcess_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsv.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNotesAllProcess.Focus()

        End If
    End Sub

    Private Sub txtsv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsv.SelectedIndexChanged

    End Sub


    Private Sub DG_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellContentClick
        txtSerial.Text = DG.Item(2, DG.CurrentRow.Index).Value
        comModelName.Text = DG.Item(3, DG.CurrentRow.Index).Value
        comLineAndShift.Text = DG.Item(4, DG.CurrentRow.Index).Value
        comStatesAllProcess.Text = DG.Item(5, DG.CurrentRow.Index).Value
        txtNotesAllProcess.Text = DG.Item(8, DG.CurrentRow.Index).Value
    End Sub

    Private Function UpdateM() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  cquality_IM set"
            sql += " fLCDBarcode = '" & txtSerial.Text & "',"
            sql += " fStates = '" & comStatesAllProcess.Text & "',"
            sql += " fNote = '" & txtNotesAllProcess.Text & "',"
            sql += " F_SapReg = '" & Label3.Text & "'"
            'sql += " part = '" & txtPart.Text & "'"
            sql += " where fLCDBarcode = '" & txtSerial.Text & "'"
            ' sql += " and fCompCode = '" & TxtVCode.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateM()
        _Refresh315()
        txtSerial.Text = ""
        comModelName.Text = ""
        comLineAndShift.Text = ""
        comStatesAllProcess.Text = ""
        txtSapLabor.Text = ""
        txtsv.Text = ""
        txtNotesAllProcess.Text = ""
        txtSerial.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmCookerQualityQuery
        frm.Show()

    End Sub

    Private Sub txtSapLabor_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtSapLabor.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtsv.Focus()
        End If
    End Sub

    Private Sub txtSapLabor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSapLabor.SelectedIndexChanged

    End Sub
    Private Function Del_Rec1() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[cquality_IM]"
            sql += " where fLCDBarcode ='" & txtSerial.Text & "'"

            Dim cmd As New SqlClient.SqlCommand(sql, cn)

            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As Exception

        End Try
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Del_Rec1()
        _Refresh315()
        txtSerial.Text = ""
        comModelName.Text = ""
        comLineAndShift.Text = ""
        comStatesAllProcess.Text = ""
        txtSapLabor.Text = ""
        txtsv.Text = ""
        txtNotesAllProcess.Text = ""
        txtSerial.Focus()
    End Sub

    Private Sub comModelName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comModelName.SelectedIndexChanged

    End Sub
End Class