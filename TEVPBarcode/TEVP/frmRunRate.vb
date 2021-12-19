Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmRunRate

    Private Sub txtlinandshift_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinandshift.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcodeUse.Text = "" Or txtlinandshift.Text = "" Then
                MsgBox("من فضلك اكمل البيانات ")

            Else


                If txtcodeUse.Text.Length < 8 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtcodeUse.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count < 1 Then
                    '  lbl_Msg.ForeColor = Color.Red
                    MsgBox("This name is not allowed to work on Follow Line ")
                    txtcodeUse.Focus()
                    txtcodeUse.SelectAll()
                    Exit Sub
                Else
                    _Refresh315()
                    '  df.Visible = True
                    GroupBox5.Visible = True
                    txtcodeUse.Enabled = False
                    '  lbl_Msg.ForeColor = Color.Green
                    'lbl_Msg.Text = " welcome This name allowed to work on barcode Line "
                    'cmb_Pcode.Enabled = True
                    '' txtline.Enabled = False
                    'txtshift.Enabled = True
                    'GroupBox2.Visible = True
                    ''txtshift.Visible = False
                    'Button2.Visible = False
                    'txtParts1.Visible = False
                    'Label10.Visible = False
                    txtModel.Focus()
                    'Me.BackColor = Color.YellowGreen

                End If
            End If
        End If
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & txtcodeUse.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "  المسئول "

            dgtc.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtlinandshift_Leave(sender As Object, e As EventArgs) Handles txtlinandshift.Leave
        ' If e.KeyCode = Keys.Enter Then
        If txtcodeUse.Text = "" Or txtlinandshift.Text = "" Then
            MsgBox("من فضلك اكمل البيانات ")
        Else
            If txtcodeUse.Text.Length < 8 Then Exit Sub
            Dim dsMax As New DataSet
            Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtcodeUse.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count < 1 Then
                MsgBox("This name is not allowed to work on Follow Line ")
                txtcodeUse.Focus()
                txtcodeUse.SelectAll()
                Exit Sub
            Else
                _Refresh315()
                GroupBox5.Visible = True
                txtcodeUse.Enabled = False
                txtModel.Focus()

            End If
        End If
        'End If
    End Sub
    Private Sub txtlinandshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtlinandshift.SelectedIndexChanged

    End Sub
    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeUSER,fNote,fTimeStop FROM TStopline"
            sql1 += "   where fLine ='" & txtlinandshift.Text & "'"
            sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"

            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TStopline")
            ds.Tables("TStopline").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TStopline").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TStopline").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TStopline").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TStopline").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TStopline").Columns(5).ColumnName = " الموديل"
            ds.Tables("TStopline").Columns(6).ColumnName = " وقت التوقف"
            ds.Tables("TStopline").Columns(7).ColumnName = " سبب التوقف"
            ds.Tables("TStopline").Columns(8).ColumnName = " مدة التوقف/ د"
            dgd.DataSource = ds.Tables("TStopline")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeFrom,fTimeTo,fNote,fTimeStop FROM TRunRat"
            sql1 += "   where fLine ='" & txtlinandshift.Text & "'"
            sql1 += "   and fModel ='" & txtModel.Text & "'"
            sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TRunRat")
            ds.Tables("TRunRat").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TRunRat").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TRunRat").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TRunRat").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TRunRat").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TRunRat").Columns(5).ColumnName = " الموديل"
            ds.Tables("TRunRat").Columns(6).ColumnName = "الوقت من "
            ds.Tables("TRunRat").Columns(7).ColumnName = "الوقت الى "
            ds.Tables("TRunRat").Columns(8).ColumnName = " الملاحظات"
            ds.Tables("TRunRat").Columns(9).ColumnName = " الكمية المنتجه"

            dg.DataSource = ds.Tables("TRunRat")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Sub frmRunRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName FROM   LCDTVModels "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")

            txtModel.DataSource = ds.Tables(0)
            ' txtModel.ValueMember = "fLCDSetID"
            txtModel.DisplayMember = "fLCDModelName"
            txtModel.Sorted = True

            ' _Refresh1()
        Catch ex As Exception

        End Try
        GroupBox5.Visible = False
        txtcodeUse.Enabled = True
    End Sub

    Private Sub txtProcess_KeyDown(sender As Object, e As KeyEventArgs)
       
    End Sub

    Private Sub txtProcess_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsv.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtlinandshift.Focus()
         
        End If
        ' End If
    End Sub

    Private Sub txtsv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsv.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txttotime_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtfromTime_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtProcess_KeyDown1(sender As Object, e As KeyEventArgs) Handles txtQtyMStop.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtcodeUse.Text = "" Or txtsv.Text = "" Or txtlinandshift.Text = "" Or txtModel.Text = "" Or txtQtyMStop.Text = "" Then
                    MsgBox("من فضلك تأكد من أكتمال أدخال البيانات")
                Else
                    Dim sql As String
                    sql = "INSERT INTO TStopline"

                    sql += "(fSap,fSv,fLine,fModel,fTimeUSER,fNote,fTimeStop)"
                    ' sql += " VALUES ('" & Format(FTime.Value, "hh:mm") & "','" & txtModel.Text & "','" & txtProcess.Text & "','" & txtnote.Text & "','" & txtlinandshift.Text & "'," & txtcodeUse.Text & ")"
                    sql += " VALUES (" & txtcodeUse.Text & ",'" & txtsv.Text & "','" & txtlinandshift.Text & "','" & txtModel.Text & "','" & Format(FTime.Value, "hh:mm") & "','" & txtnote.Text & "'," & txtQtyMStop.Text & ")"
                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    _Refresh11()
                    txtnote.Text = ""
                    txtQtyMStop.Text = ""
                    ' txtnote.Text = ""
                    'txtModel.Text = ""
                    FTime.Focus()

                End If
            End If
        Catch ex As Exception

        End Try

        'End Sub
    End Sub

    Private Sub txtProcess_TextChanged(sender As Object, e As EventArgs) Handles txtQtyMStop.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'If e.KeyCode = Keys.Enter Then
            If txtcodeUse.Text = "" Or txtsv.Text = "" Or txtlinandshift.Text = "" Or txtModel.Text = "" Or txtQtyMStop.Text = "" Then
                MsgBox("من فضلك تأكد من أكتمال أدخال البيانات")
            Else
                Dim sql As String
                sql = "INSERT INTO TRunRat"

                sql += "(fSap,fSv,fLine,fModel,fTimeUSER,fNote,fTimeStop)"
                ' sql += " VALUES ('" & Format(FTime.Value, "hh:mm") & "','" & txtModel.Text & "','" & txtProcess.Text & "','" & txtnote.Text & "','" & txtlinandshift.Text & "'," & txtcodeUse.Text & ")"
                sql += " VALUES (" & txtcodeUse.Text & ",'" & txtsv.Text & "','" & txtlinandshift.Text & "','" & txtModel.Text & "','" & Format(FTime.Value, "hh:mm") & "','" & txtnote.Text & "'," & txtQtyMStop.Text & ")"
                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                _Refresh11()
                'txtModel.Text = ""
                txtQtyMStop.Text = ""
                txtnote.Text = ""
                'txtModel.Text = ""
                FTime.Focus()

            End If
            'End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'If e.KeyCode = Keys.Enter Then
            If txtcodeUse.Text = "" Or txtsv.Text = "" Or txtlinandshift.Text = "" Or txtModel.Text = "" Or txtqtyrunH.Text = "" Then
                MsgBox("من فضلك تأكد من أكتمال أدخال البيانات")
            Else
                Dim sql As String
                sql = "INSERT INTO TRunRat"

                sql += "(fSap,fSv,fLine,fModel,fTimeFrom,fTimeTo,fNote,fTimeStop)"
                ' sql += " VALUES ('" & Format(FTime.Value, "hh:mm") & "','" & txtModel.Text & "','" & txtProcess.Text & "','" & txtnote.Text & "','" & txtlinandshift.Text & "'," & txtcodeUse.Text & ")"
                sql += " VALUES (" & txtcodeUse.Text & ",'" & txtsv.Text & "','" & txtlinandshift.Text & "','" & txtModel.Text & "','" & Format(ftimefrom.Value, "hh:mm") & "','" & Format(ftimeto.Value, "hh:mm") & "','" & txtnoteRun.Text & "'," & txtqtyrunH.Text & ")"
                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                _Refresh111()
                ' txtModel.Text = ""
                txtQtyMStop.Text = ""
                txtnote.Text = ""
                'txtModel.Text = ""
                ftimefrom.Focus()

            End If
            'End If
        Catch ex As Exception

        End Try

        'End Sub
    End Sub

    Private Sub txtqtyrunH_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqtyrunH.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtcodeUse.Text = "" Or txtsv.Text = "" Or txtlinandshift.Text = "" Or txtModel.Text = "" Or txtqtyrunH.Text = "" Then
                    MsgBox("من فضلك تأكد من أكتمال أدخال البيانات")
                Else
                    Dim sql As String
                    sql = "INSERT INTO TRunRat"

                    sql += "(fSap,fSv,fLine,fModel,fTimeFrom,fTimeTo,fNote,fTimeStop)"
                    ' sql += " VALUES ('" & Format(FTime.Value, "hh:mm") & "','" & txtModel.Text & "','" & txtProcess.Text & "','" & txtnote.Text & "','" & txtlinandshift.Text & "'," & txtcodeUse.Text & ")"
                    sql += " VALUES (" & txtcodeUse.Text & ",'" & txtsv.Text & "','" & txtlinandshift.Text & "','" & txtModel.Text & "','" & Format(ftimefrom.Value, "hh:mm") & "','" & Format(ftimeto.Value, "hh:mm") & "','" & txtnoteRun.Text & "'," & txtqtyrunH.Text & ")"
                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    _Refresh111()
                    ' txtModel.Text = ""
                    txtqtyrunH.Text = ""
                    txtnote.Text = ""
                    'txtModel.Text = ""
                    ftimefrom.Focus()

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtqtyrunH_TextChanged(sender As Object, e As EventArgs) Handles txtqtyrunH.TextChanged

    End Sub

    Private Sub txtcodeUse_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodeUse.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtsv.Focus()

        End If
    End Sub

    Private Sub txtcodeUse_TextChanged(sender As Object, e As EventArgs) Handles txtcodeUse.TextChanged

    End Sub

    Private Sub txtlinandshift_TextChanged(sender As Object, e As EventArgs) Handles txtlinandshift.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class