
Imports TEVPBarcode.sher
Public Class frmDailyMaintenance_and_garage

    Private Sub txtcarNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcarNum.SelectedIndexChanged
        Try
            llbl_carText.Text = txtcarNum.SelectedValue.ToString
            ' Label2.Text = cmb_Pcode.Text
            'txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmDailyMaintenance_and_garage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT TM_NUM_CAR,TM_TEXT_CAR FROM   TM_Car "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "TM_Car")
            txtcarNum.DataSource = ds.Tables(0)
            txtcarNum.ValueMember = "TM_TEXT_CAR"
            txtcarNum.DisplayMember = "TM_NUM_CAR"
            txtcarNum.Sorted = True
        Catch ex As Exception

        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT TM_SAP_EMP,TM_NAME_EMP FROM TM_Responsible "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "TM_Responsible")
            txtDriverName.DataSource = ds.Tables(0)
            txtDriverName.ValueMember = "TM_SAP_EMP"
            txtDriverName.DisplayMember = "TM_NAME_EMP"
            txtDriverName.Sorted = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtuser.Text.Length < 8 Then Exit Sub
            Dim dsMax As New DataSet
            Dim Sql = "SELECT  TM_NAME_EMP FROM  TM_Responsible "
            Sql += " where TM_SAP_EMP=" & txtuser.Text & ""
            ' Sql += " and Heater_sap_stu='Active'"
            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count < 1 Then

                ' MsgBox.ForeColor = Color.Red
                MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")


                ' Console.Beep()
                txtuser.Focus()
                txtuser.SelectAll()
                Exit Sub
            Else
                '  _Refresh315()
                'lbl_Msg.ForeColor = Color.Green
                'lbl_Msg.Text = "مرحبا بك فى برنامج مصنع السخان لمتابعة الانتاج "
                'cmb_Pcode.Enabled = True
                '' txtline.Enabled = False
                'txtshift.Enabled = True
                'GroupBox2.Visible = True
                ''txtshift.Visible = False
                'Button2.Visible = False
                'txtParts1.Visible = False
                'Label10.Visible = False
                'txtshift.Focus()
                'Me.BackColor = Color.YellowGreen
                GroupBox2.Enabled = True
                ' GroupBox1.Enabled = True
                GroupBox5.Enabled = False
                '  _Refresh1()
                txtcarNum.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Private Function Update1() As Boolean
    '    Try
    '        Dim sql As String
    '        sql = "UPDATE TM_DailyMaintenance_and_garage Set"
    '        sql += " TM_NUM_CAR =" & txtcarNum.Text & ","
    '        sql += " TM_TEXT_CAR = '" & llbl_carText.Text & "',"
    '        sql += " TM_Dmamouriy = '" & Format(DTP.Value, "yyyy-MM-dd") & "',"
    '        sql += " TM_DITRCTION = '" & txtDirctionName.Text & "'"
    '        sql += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
    '        sql += " and TM_SAPR =" & txtuser.Text & ""
    '        sql += " and TM_Ordernum = " & txtCounter.Text & ""
    '        Dim cmd As New SqlClient.SqlCommand(sql, cn)
    '        If cn.State = ConnectionState.Closed Then cn.Open()
    '        cmd.ExecuteNonQuery()
    '        cn.Close()
    '    Catch ex As Exception
    '    End Try
    'End Function

    Private Function Add116_New() As Boolean
        Try
            Dim sql As String
            sql = " INSERT INTO dbo.TM_DailyMaintenance_and_garage"
            sql += "(TM_SAPR,TM_SAPD, TM_NUM_CAR, TM_TEXT_CAR, TM_COUNTER, TM_STATUS, TM_NOTES, TM_Dmamouriy)"
            sql += " VALUES (" & txtuser.Text & "," & lbl_driverNum.Text & "," & txtcarNum.Text & ",'" & llbl_carText.Text & "'," & txtCounter.Text & ",'" & txtStatus.Text & "','" & txtNote.Text & "','" & Format(DTP.Value, "yyyy-MM-dd") & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = "SELECT TM_DATE, TM_TIME, TM_SAPD, TM_NUM_CAR, TM_TEXT_CAR, TM_COUNTER, TM_STATUS, TM_NOTES, TM_SAPR, TM_Dmamouriy FROM  TM_DailyMaintenance_and_garage "
            sql1 += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql1 += " and TM_SAPR =" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_DailyMaintenance_and_garage")
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(0).ColumnName = "تاريخ التسجيل"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(2).ColumnName = " ساب السائق"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(3).ColumnName = " رقم السياره"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(4).ColumnName = "حروف السياره"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(5).ColumnName = "العداد"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(6).ColumnName = " حالة السيارة"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(7).ColumnName = " الملاحظات"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(8).ColumnName = " ساب مسئول البيانات"
            ds.Tables("TM_DailyMaintenance_and_garage").Columns(9).ColumnName = "تاريخ التوريد"
            dg1.DataSource = ds.Tables("TM_DailyMaintenance_and_garage")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lbl_driverNum.Text = "" Or llbl_carText.Text = "" Then
            MsgBox("plz check your data ")
        Else

            Add116_New()
            _Refresh11()
            txtcarNum.Text = ""
            txtCounter.Text = ""

            txtcarNum.Focus()
        End If

    End Sub

    Private Sub txtDriverName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDriverName.SelectedIndexChanged
        Try
            lbl_driverNum.Text = txtDriverName.SelectedValue.ToString
            ' Label2.Text = cmb_Pcode.Text
            'txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql As String
        sql = "DELETE FROM TM_DailyMaintenance_and_garage"
        sql += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
        sql += " and TM_SAPR =" & txtuser.Text & ""
        sql += " and TM_NUM_CAR = " & txtcarNum.Text & ""
        sql += " and TM_TEXT_CAR = '" & llbl_carText.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        '   _Refresh11()
_Refresh11
        txtcarNum.Text = ""
        txtCounter.Text = ""

        txtcarNum.Focus()
    End Sub
End Class