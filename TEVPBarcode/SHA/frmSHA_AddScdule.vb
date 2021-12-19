Imports TEVPBarcode.sher
Public Class frmSHA_AddScdule

    'Public Class frmcookerscdule
    Public Property StringPassc9 As String
    Private Sub frmcookerscdule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = StringPassc9
        Label13.Visible = False
        Try
            Dim sql As String = ""
            sql += " SELECT  CModelName FROM SHA_Models "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "SHA_Models")
            txxtmodel.DataSource = ds.Tables(0)

            txxtmodel.DisplayMember = "CModelName"
            txxtmodel.Sorted = True
        Catch ex As Exception
        End Try


    End Sub
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE  SHA_Planmonthly set"
            sql += " CMonthName = '" & txtmonthname.Text & "',"
            sql += " CQty = " & txtmonthqty.Text & ","
            sql += " CUserID = " & Label13.Text & ""
            ' sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += "  where CStartDate ='" & Format(txtstartmonth.Value, "yyyy-MM-dd") & "'"
            '  sql += " and fLCDModelName = '" & txtModel.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_RecM() As Boolean
        Try
            Dim sql As String
            sql = "DELETE FROM [SHA_Planmonthly]"
            sql += " where CStartDate ='" & Format(txtstartmonth.Value, "yyyy-MM-dd") & "'"

            Dim cmd As New SqlClient.SqlCommand(sql, cn)

            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As Exception

        End Try
    End Function
    Private Function Add1_Newk() As Boolean
        Try
            Dim sql As String
            sql = "INSERT INTO SHA_Planmonthly "
            sql += "(CStartDate,CMonthName,CQty,CUserID)"
            sql += " VALUES ('" & Format(txtstartmonth.Value, "yyyy-MM-dd") & "','" & txtmonthname.Text & "'," & txtmonthqty.Text & ",'" & Label13.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    'Public Class frmAddData

    '  Private Property txtpanelid As Object

    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = "SELECT CDate,Ctime,CStartDate,CMonthName,CQty FROM SHA_Planmonthly"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Planmonthly")
            ds.Tables("SHA_Planmonthly").Columns(0).ColumnName = "date"
            ds.Tables("SHA_Planmonthly").Columns(1).ColumnName = "Time"
            ds.Tables("SHA_Planmonthly").Columns(2).ColumnName = "Start Plan"
            ds.Tables("SHA_Planmonthly").Columns(3).ColumnName = "Name Month"
            ds.Tables("SHA_Planmonthly").Columns(4).ColumnName = " Qty"
            dg.DataSource = ds.Tables("SHA_Planmonthly")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Add1_Newk()
        _Refresh11()
        txtmonthname.Text = ""
        txtmonthqty.Text = ""
        txtmonthname.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Update1A()
        _Refresh11()
        txtmonthname.Text = ""
        txtmonthqty.Text = ""
        txtmonthname.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        _Refresh11()
        txtmonthname.Text = ""
        txtmonthqty.Text = ""
        txtmonthname.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Del_RecM()
        _Refresh11()
        txtmonthname.Text = ""
        txtmonthqty.Text = ""
        txtmonthname.Focus()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Function Update1Ad() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE  SHA_PlanDaliy set"
            sql += " CQty = " & txtmonthqty.Text & ","
            sql += " CUserID = " & Label13.Text & ""
            sql += "  where CStartDate ='" & Format(txtstartmonth.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName = '" & txxtmodel.Text & "'"
            sql += " and CLineAndShift = '" & txtline.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_RecMd() As Boolean
        Try
            Dim sql As String
            sql = "DELETE FROM [SHA_PlanDaliy]"
            sql += " where CStartDate ='" & Format(txtstartmonth.Value, "yyyy-MM-dd") & "'"
            '  sql += "  where CStartDate ='" & Format(txtstartmonth.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName = '" & txxtmodel.Text & "'"
            sql += " and CLineAndShift = '" & txtline.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)

            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As Exception

        End Try
    End Function

    Private Function Add1_Newkd() As Boolean
        Try
            Dim sql As String
            sql = "INSERT INTO SHA_PlanDaliy "
            sql += "(CStartDate,CModelName,CQty,CLineAndShift,CUserID)"
            sql += " VALUES ('" & Format(txtstartday.Value, "yyyy-MM-dd") & "','" & txxtmodel.Text & "'," & txtdaliyqty.Text & ",'" & txtline.Text & "','" & Label13.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11d() As Boolean
        Try
            Dim sql1 As String = "SELECT CDate,Ctime,CStartDate,CModelName,CQty,CLineAndShift FROM SHA_PlanDaliy"
            sql1 += " WHERE CStartDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_PlanDaliy")
            ds.Tables("SHA_PlanDaliy").Columns(0).ColumnName = "date"
            ds.Tables("SHA_PlanDaliy").Columns(1).ColumnName = "Time"
            ds.Tables("SHA_PlanDaliy").Columns(2).ColumnName = "Start Plan"
            ds.Tables("SHA_PlanDaliy").Columns(3).ColumnName = "Model Name "
            ds.Tables("SHA_PlanDaliy").Columns(4).ColumnName = " Qty"
            ds.Tables("SHA_PlanDaliy").Columns(5).ColumnName = "Line And shift"
            dg1.DataSource = ds.Tables("SHA_PlanDaliy")
            Return True
        Catch ex As Exception
        End Try
    End Function


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        _Refresh11d()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Add1_Newkd()
        _Refresh11d()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Update1Ad()

        _Refresh11d()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Del_RecMd()
        _Refresh11d()

    End Sub

    Private Sub txtPN_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



End Class
