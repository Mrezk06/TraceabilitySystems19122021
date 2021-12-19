Imports TEVPBarcode.sher
Public Class frmCar_Oil
    Private Sub frmCar_Oil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            sql += " SELECT TM_REG_ID,TM_REG_Name FROM TM_Regons "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "TM_Regons")
            txtDirctionName.DataSource = ds.Tables(0)
            txtDirctionName.ValueMember = "TM_REG_ID"
            txtDirctionName.DisplayMember = "TM_REG_Name"
            txtDirctionName.Sorted = True
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
    Private Sub txtcarNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcarNum.SelectedIndexChanged
        Try
            llbl_carText.Text = txtcarNum.SelectedValue.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDriverName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDriverName.SelectedIndexChanged
        Try
            lbl_driverNum.Text = txtDriverName.SelectedValue.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtDirctionName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDirctionName.SelectedIndexChanged
        Try
            lblDirctionNum.Text = txtDirctionName.SelectedValue.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtuser.Text.Length < 8 Then Exit Sub
            Dim dsMax As New DataSet
            Dim Sql = "SELECT  TM_NAME_EMP FROM  TM_Responsible "
            Sql += " where TM_SAP_EMP=" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count < 1 Then
                MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
                txtuser.Focus()
                txtuser.SelectAll()
                Exit Sub
            Else
                GroupBox2.Enabled = True
                GroupBox5.Enabled = False
                txtcarNum.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lbl_driverNum.Text = "" Or llbl_carText.Text = "" Then
            MsgBox("plz Entry all Data")
        Else
            Add116_New()
            _Refresh11()
            txtDirctionName.Text = ""
            lblDirctionNum.Text = ""
            txtcarNum.Text = ""
            llbl_carText.Text = ""
            txtDirctionName.Text = ""
            lbl_driverNum.Text = ""
            txtcarNum.Focus()
        End If
    End Sub
    Private Function Update1() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE TM_Oil_Change Set"
            sql += " TM_DIR = '" & txtDirctionName.Text & "',"
            sql += "  TM_SAPD =" & lbl_driverNum.Text & ","
            sql += "  TM_counterOld =" & txtChangeOil.Text & ","
            sql += "  TM_CounterKeepChange =" & txtCounter.Text & ""
            sql += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and TM_SAPR =" & txtuser.Text & ""
            sql += " and TM_NUM_CAR =" & txtcarNum.Text & ""
            sql += " and TM_TEXT_CAR = '" & llbl_carText.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = "SELECT TM_DATE, TM_TIME, TM_NUM_CAR, TM_TEXT_CAR, TM_SAPD, TM_SAPR, TM_counterOld, TM_CounterKeepChange, TM_Dmamouriy, TM_DIR FROM  TM_Oil_Change "
            sql1 += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += " and TM_SAPR =" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_Oil_Change")
            ds.Tables("TM_Oil_Change").Columns(0).ColumnName = "تاريخ التسجيل"
            ds.Tables("TM_Oil_Change").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TM_Oil_Change").Columns(2).ColumnName = " رقم السياره"
            ds.Tables("TM_Oil_Change").Columns(3).ColumnName = "حروف السياره"
            ds.Tables("TM_Oil_Change").Columns(4).ColumnName = "ساب السائق"
            ds.Tables("TM_Oil_Change").Columns(5).ColumnName = "ساب مسئول البيانات"
            ds.Tables("TM_Oil_Change").Columns(6).ColumnName = " العداد"
            ds.Tables("TM_Oil_Change").Columns(7).ColumnName = " عداد تغيير الزيت"
            ds.Tables("TM_Oil_Change").Columns(8).ColumnName = "تاريخ التوريد"
            ds.Tables("TM_Oil_Change").Columns(9).ColumnName = "الاتجاه"
            dg1.DataSource = ds.Tables("TM_Oil_Change")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function Add116_New() As Boolean
        Try
            Dim sql As String
            sql = " INSERT INTO dbo.TM_Oil_Change"
            sql += "( TM_NUM_CAR, TM_TEXT_CAR, TM_SAPD, TM_SAPR, TM_counterOld, TM_CounterKeepChange, TM_Dmamouriy, TM_DIR)"
            sql += " VALUES (" & txtcarNum.Text & ",'" & llbl_carText.Text & "'," & lbl_driverNum.Text & "," & txtuser.Text & "," & txtChangeOil.Text & "," & txtCounter.Text & ",'" & Format(DTP.Value, "yyyy-MM-dd") & "','" & txtDirctionName.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtcarNum.Text = "" Or llbl_carText.Text = "" Then
            MsgBox("plz Entry all Data")
        Else
            Dim sql As String
            sql = "DELETE FROM TM_Oil_Change"
            sql += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and TM_SAPR =" & txtuser.Text & ""
            sql += " and TM_NUM_CAR = " & txtcarNum.Text & ""
            sql += " and TM_TEXT_CAR = '" & llbl_carText.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            _Refresh11()
            txtDirctionName.Text = ""
            lblDirctionNum.Text = ""
            txtcarNum.Text = ""
            llbl_carText.Text = ""
            txtDirctionName.Text = ""
            lbl_driverNum.Text = ""
            txtcarNum.Focus()
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lbl_driverNum.Text = "" Or llbl_carText.Text = "" Then
            MsgBox("plz Entry all Data")
        Else
            Update1()
            _Refresh11()
            txtDirctionName.Text = ""
            lblDirctionNum.Text = ""
            txtcarNum.Text = ""
            llbl_carText.Text = ""
            txtDirctionName.Text = ""
            lbl_driverNum.Text = ""
            txtcarNum.Focus()
        End If
    End Sub
End Class