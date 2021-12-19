Imports System.Collections.ObjectModel
Imports System.Windows.Forms.DataVisualization.Charting
Imports TEVPBarcode.sher
Imports System.Data.SqlClient
'Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmCarWQty
    Private Function Add1_New1() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.C_BoxDesc "
            sql += "( f_Name)"
            sql += " VALUES ('" & txtNameResonProblem.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec1() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[C_BoxDesc]"
            sql += " where f_ID =" & txtResonProblem.Text & ""
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update1A1() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  C_BoxDesc set"
            sql += " f_Name = '" & txtNameResonProblem.Text & "'"
            'sql += " fpanelID = '" & txtpanelid.Text & "',"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where f_ID = " & txtResonProblem.Text & ""
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT f_ID,f_Name FROM C_BoxDesc"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_BoxDesc")
            ds.Tables("C_BoxDesc").Columns(0).ColumnName = "ID"
            '    ds.Tables("C_BoxDesc").Columns(1).ColumnName = " Code"
            ds.Tables("C_BoxDesc").Columns(1).ColumnName = "Name"
            ' ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("C_BoxDesc")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Sub frmCarWQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += " SELECT  f_Code, f_Name FROM   C_Part_Desc "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "C_Part_Desc")

            txtpart.DataSource = ds.Tables(0)
            txtpart.ValueMember = "f_Code"
            txtpart.DisplayMember = "f_Name"
            txtpart.Sorted = True

            ' _Refresh1()
        Catch ex As Exception

        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT  f_ID, f_Name FROM   C_BoxDesc "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "C_BoxDesc")

            txtbox.DataSource = ds.Tables(0)
            txtbox.ValueMember = "f_ID"
            txtbox.DisplayMember = "f_Name"
            txtbox.Sorted = True

            ' _Refresh1()
        Catch ex As Exception

        End Try
    End Sub
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.C_Part_Desc "
            sql += "( f_Name, f_Code)"
            sql += " VALUES ('" & txtName.Text & "','" & txtsap.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[C_Part_Desc]"
            sql += " where f_Code ='" & txtsap.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  C_Part_Desc set"
            sql += " f_Name = '" & txtName.Text & "'"
            'sql += " fpanelID = '" & txtpanelid.Text & "',"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where f_Code = '" & txtsap.Text & "'"
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT f_ID,f_Code,f_Name FROM C_Part_Desc"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Part_Desc")
            ds.Tables("C_Part_Desc").Columns(0).ColumnName = "ID"
            ds.Tables("C_Part_Desc").Columns(1).ColumnName = " Code"
            ds.Tables("C_Part_Desc").Columns(2).ColumnName = "Name"
            ' ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("C_Part_Desc")

            Return True

        Catch ex As Exception

        End Try
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        _Refresh1()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Del_Rec()
        _Refresh1()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Update1A()

        _Refresh1()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Add1_New()

        _Refresh1()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        _Refresh11()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Del_Rec1()

        _Refresh11()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Update1A1()

        _Refresh11()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Add1_New1()

        _Refresh11()
    End Sub

    Private Sub txtpart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtpart.SelectedIndexChanged
        Try
            lblpart.Text = txtpart.SelectedValue.ToString
            '  Label2.Text = cmb_Pcode.Text
            '  txtFATSERIAL.Enabled = True
            '  _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtbox.SelectedIndexChanged
        Try
            lblbox.Text = txtbox.SelectedValue.ToString
            '  Label2.Text = cmb_Pcode.Text
            '  txtFATSERIAL.Enabled = True
            '  _Refresh1()
        Catch ex As Exception

        End Try
    End Sub
    Private Function Add1_New2() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.C_BoxWithPart "
            sql += "( f_B_ID, f_Code,f_QTY)"
            sql += " VALUES (" & lblbox.Text & ",'" & lblpart.Text & "'," & txtqty.Text & ")"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec2() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[C_BoxWithPart]"
            sql += " where f_B_ID =" & lblbox.Text & ""
            sql += " and f_Code ='" & lblpart.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update1A2() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  C_BoxWithPart set"
            sql += " f_QTY = " & txtqty.Text & ""
            'sql += " fpanelID = '" & txtpanelid.Text & "',"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where f_Code = '" & lblpart.Text & "'"
            sql += " and f_B_ID = " & lblbox.Text & ""
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh12() As Boolean
        Try

            Dim sql1 As String = "SELECT f_Name,Expr1,f_Code,f_QTY FROM BoxWithPart"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "BoxWithPart")
            ds.Tables("BoxWithPart").Columns(0).ColumnName = "Box_Name"
            ds.Tables("BoxWithPart").Columns(1).ColumnName = " Part_Name"
            ds.Tables("BoxWithPart").Columns(2).ColumnName = "Part_Code"
            ds.Tables("BoxWithPart").Columns(3).ColumnName = "QTY"
            dg.DataSource = ds.Tables("BoxWithPart")

            Return True

        Catch ex As Exception

        End Try
    End Function

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        _Refresh12()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Del_Rec2()
        _Refresh12()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Update1A2()
        _Refresh12()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add1_New2()
        _Refresh12()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        Try
            txtResonProblem.Text = dg.Item(0, dg.CurrentRow.Index).Value
        Catch ex As Exception

        End Try

    End Sub
End Class