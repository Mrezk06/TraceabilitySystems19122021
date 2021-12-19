Imports TEVPBarcode.sher
Public Class frmcookerscdule
    Public Property StringPassc9 As String
    Private Sub frmcookerscdule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = StringPassc9
        Label13.Visible = False
        Try
            Dim sql As String = ""
            sql += " SELECT  CModelName FROM CModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")
            txxtmodel.DataSource = ds.Tables(0)

            txxtmodel.DisplayMember = "CModelName"
            txxtmodel.Sorted = True
        Catch ex As Exception
        End Try
        Try
            Dim sql As String = ""
            sql += "SELECT f_Name FROM C_Part_Desc"
            '  sql += " where fLine_Name ='EWH1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "C_Part_Desc")

            txtPN.DataSource = ds.Tables(0)
            '   txtPN.ValueMember = "f_Code"
            ' cmb_Pcode.ValueMember = "model_S_Power"
            txtPN.DisplayMember = "f_Name"
            txtPN.Sorted = True

            '  _Refresh1()
        Catch ex As Exception

        End Try

    End Sub
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE  CPlanmonthly set"
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
            sql = "DELETE FROM [barcode].[dbo].[CPlanmonthly]"
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
            sql = "INSERT INTO barcode.dbo.CPlanmonthly "
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
            Dim sql1 As String = "SELECT CDate,Ctime,CStartDate,CMonthName,CQty FROM   barcode.dbo.CPlanmonthly"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "CPlanmonthly")
            ds.Tables("CPlanmonthly").Columns(0).ColumnName = "date"
            ds.Tables("CPlanmonthly").Columns(1).ColumnName = "Time"
            ds.Tables("CPlanmonthly").Columns(2).ColumnName = "Start Plan"
            ds.Tables("CPlanmonthly").Columns(3).ColumnName = "Name Month"
            ds.Tables("CPlanmonthly").Columns(4).ColumnName = " Qty"
            dg.DataSource = ds.Tables("CPlanmonthly")
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
            sql = "UPDATE  CPlanDaliy set"
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
            sql = "DELETE FROM [barcode].[dbo].[CPlanDaliy]"
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
            sql = "INSERT INTO barcode.dbo.CPlanDaliy "
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
            Dim sql1 As String = "SELECT CDate,Ctime,CStartDate,CModelName,CQty,CLineAndShift FROM   barcode.dbo.CPlanDaliy"
            sql1 += " WHERE CStartDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "CPlanDaliy")
            ds.Tables("CPlanDaliy").Columns(0).ColumnName = "date"
            ds.Tables("CPlanDaliy").Columns(1).ColumnName = "Time"
            ds.Tables("CPlanDaliy").Columns(2).ColumnName = "Start Plan"
            ds.Tables("CPlanDaliy").Columns(3).ColumnName = "Model Name "
            ds.Tables("CPlanDaliy").Columns(4).ColumnName = " Qty"
            ds.Tables("CPlanDaliy").Columns(5).ColumnName = "Line And shift"
            dg1.DataSource = ds.Tables("CPlanDaliy")
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

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Add1_Newkd2()
        _Refresh11d2()

    End Sub

    Private Function Add1_Newkd2() As Boolean
        Try
            Dim sql As String
            sql = "INSERT INTO barcode.dbo.CPlanDaliypressure "
            sql += "(CStartDate, CPartName, CQty, CpressureID,CPO,CUserID)"
            sql += " VALUES ('" & Format(PTPP.Value, "yyyy-MM-dd") & "','" & txtPN.Text & "'," & txtPQ.Text & ",'" & txtPress.Text & "','" & txtPO.Text & "','" & Label13.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh11d2() As Boolean
        Try
            Dim sql1 As String = "SELECT CStartDate, CPartName, CQty, CpressureID,CPO FROM   barcode.dbo.CPlanDaliypressure"
            sql1 += " WHERE CStartDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += " and CPO = '" & txtPO.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "CPlanDaliypressure")
            ds.Tables("CPlanDaliypressure").Columns(0).ColumnName = "Start Plan"
            ds.Tables("CPlanDaliypressure").Columns(1).ColumnName = "Part Name "
            ds.Tables("CPlanDaliypressure").Columns(2).ColumnName = " Qty"
            ds.Tables("CPlanDaliypressure").Columns(3).ColumnName = "Presser Code"
            ds.Tables("CPlanDaliypressure").Columns(4).ColumnName = "P / O"
            dg1.DataSource = ds.Tables("CPlanDaliypressure")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function Del_RecMd2() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[CPlanDaliypressure]"
            sql += " where CStartDate ='" & Format(PTPP.Value, "yyyy-MM-dd") & "'"
            '  sql += "  where CStartDate ='" & Format(txtstartmonth.Value, "yyyy-MM-dd") & "'"
            sql += " and CPartName = '" & txtPN.Text & "'"
            sql += " and CpressureID = '" & txtPress.Text & "'"
            sql += " and CPO = '" & txtPO.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)

            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As Exception

        End Try
    End Function
    '   sql += " CUserID = " & Label13.Text & ""
    Private Function Update1Ad2() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  CPlanDaliypressure set"
            '   sql += " CModelName = '" & txtmonthname.Text & "',"
            sql += " CQty = " & txtPQ.Text & ","
            sql += " CUserID = " & Label13.Text & ""
            sql += " where CStartDate ='" & Format(PTPP.Value, "yyyy-MM-dd") & "'"
            '  sql += "  where CStartDate ='" & Format(txtstartmonth.Value, "yyyy-MM-dd") & "'"
            sql += " and CPartName = '" & txtPN.Text & "'"
            sql += " and CpressureID = '" & txtPress.Text & "'"
            sql += " and CPO = '" & txtPO.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Update1Ad2()
        _Refresh11d2()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Del_RecMd2()
        _Refresh11d2()
    End Sub
End Class
