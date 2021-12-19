
Imports System.IO
Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Imports Microsoft.VisualBasic.FileIO
Imports System.Data
Imports System.Data.Odbc
Imports System.Data.OleDb
Imports System.Configuration

Imports System.Text
'Imports System.

Imports System.Globalization

Public Class frmDailyTransport_traffic

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmDailyTransport_traffic_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        txtuser.Focus()
        GroupBox2.Enabled = False
        ' GroupBox1.Enabled = False


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
            txtMandubName.DataSource = ds.Tables(0)
            txtMandubName.ValueMember = "TM_SAP_EMP"
            txtMandubName.DisplayMember = "TM_NAME_EMP"
            txtMandubName.Sorted = True
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
    Private Function Add116_New() As Boolean
        Try
            Dim sql As String
            sql = " INSERT INTO dbo.TM_Operating_diary"
            sql += "( TM_NUM_CAR, TM_TEXT_CAR, TM_SAP_D, TM_SAP_M, TM_DIR,TM_SAPR, TM_Dmamouriy)"
            sql += " VALUES (" & txtcarNum.Text & ",'" & llbl_carText.Text & "'," & lbl_driverNum.Text & "," & lbl_MandobNum.Text & ",'" & txtDirctionName.Text & "'," & txtuser.Text & ",'" & Format(DTP.Value, "yyyy-MM-dd") & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim sql As String
        sql = "DELETE FROM TM_Operating_diary"
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
        txtMandubName.Text = ""
        lbl_MandobNum.Text = ""
        txtcarNum.Focus()

    End Sub

    Private Sub dg1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellContentClick
        Try


            'txtVCode.Text = dg1.Item(0, dg1.CurrentRow.Index).Value
            'txtqty.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
            'txtcarNum.Text = dg1.Item(3, dg1.CurrentRow.Index).Value
            'txtDriverName.Text = dg1.Item(4, dg1.CurrentRow.Index).Value
            'txtqty.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim DataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = ("F:\\TEVP_data_center.xlsx")
            '    MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=Excel 8.0;")
            ' MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.14.0;Data Source=" + path + ";Extended Properties='Excel 14.0;'")
            MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=Excel 8.0;")

            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
            '  MyCommand.TableMappings.Add("Table", "Net-informations.com")

            DataSet = New System.Data.DataSet
            MyCommand.Fill(DataSet)
            dg1.DataSource = DataSet.Tables(0)
            MyConnection.Close()

            MsgBox("ok my dear")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            For Each dre As DataGridViewRow In dg1.Rows
                Dim sql As String
                sql = " INSERT INTO dbo.W_Master_data"
                sql += "(C_Material_code,C_Material_Name,C_Unit,C_Dpt)"
                sql += " VALUES ('" & dre.Cells(0).Value & "','" & dre.Cells(1).Value & "','" & dre.Cells(2).Value & "','" & dre.Cells(3).Value & "')"
                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
            Next
        Catch ex As Exception

        End Try

        MsgBox("ok my dear")

    End Sub

    Private Sub txtcarNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcarNum.SelectedIndexChanged
        Try
            llbl_carText.Text = txtcarNum.SelectedValue.ToString
            ' Label2.Text = cmb_Pcode.Text
            'txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDirctionName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtDirctionName.SelectedIndexChanged
        Try
            lblDirctionNum.Text = txtDirctionName.SelectedValue.ToString
            ' Label2.Text = cmb_Pcode.Text
            'txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
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

    Private Sub txtMandubName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtMandubName.SelectedIndexChanged
        Try
            lbl_MandobNum.Text = txtMandubName.SelectedValue.ToString
            ' Label2.Text = cmb_Pcode.Text
            'txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add116_New()
        _Refresh11()
    End Sub
    Private Function Update1() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE TM_Operating_diary Set"
        
            sql += " TM_Dmamouriy = '" & Format(DTP.Value, "yyyy-MM-dd") & "',"
            sql += " TM_DIR = '" & txtDirctionName.Text & "',"

            sql += "  TM_SAP_D =" & lbl_driverNum.Text & ","
            sql += "  TM_SAP_M = " & lbl_MandobNum.Text & ""

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
            Dim sql1 As String = "SELECT TM_DATE, TM_TIME, TM_NUM_CAR, TM_TEXT_CAR,TM_NAME_EMP, Expr8, TM_DIR, TM_Dmamouriy FROM  TM_Operating_diary1 "
            sql1 += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql1 += " and TM_SAPR =" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_Operating_diary1")
            ds.Tables("TM_Operating_diary1").Columns(0).ColumnName = "تاريخ التسجيل"
            ds.Tables("TM_Operating_diary1").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TM_Operating_diary1").Columns(2).ColumnName = " رقم السياره"
            ds.Tables("TM_Operating_diary1").Columns(3).ColumnName = "حروف السياره"
            ds.Tables("TM_Operating_diary1").Columns(4).ColumnName = "اسم السائق"
            ds.Tables("TM_Operating_diary1").Columns(5).ColumnName = "اسم المندوب"
            ds.Tables("TM_Operating_diary1").Columns(6).ColumnName = " الاتجاه"
            '  ds.Tables("TM_DailySVShipping").Columns(6).ColumnName = " ساب مسئول البيانات"
            ds.Tables("TM_Operating_diary1").Columns(7).ColumnName = "تاريخ التوريد"
            dg1.DataSource = ds.Tables("TM_Operating_diary1")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Update1()

        _Refresh11()
    End Sub

    Private Sub lbl_driverNum_Click(sender As Object, e As EventArgs) Handles lbl_driverNum.Click

    End Sub
End Class