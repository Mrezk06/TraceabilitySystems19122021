
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

Public Class frmDailySVShipping
    Private Function Update1() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE TM_DailySVShipping Set"
            sql += " TM_NUM_CAR =" & txtcarNum.Text & ","
            sql += " TM_TEXT_CAR = '" & llbl_carText.Text & "',"
            sql += " TM_Dmamouriy = '" & Format(DTP.Value, "yyyy-MM-dd") & "',"
            sql += " TM_DITRCTION = '" & txtDirctionName.Text & "'"
            sql += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and TM_SAPR =" & txtuser.Text & ""
            sql += " and TM_Ordernum = " & txtCounter.Text & ""
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Function Add116_New() As Boolean
        Try
            Dim sql As String
            sql = " INSERT INTO dbo.TM_DailySVShipping"
            sql += "(TM_NUM_CAR, TM_TEXT_CAR,  TM_Ordernum, TM_DITRCTION,TM_SAPR, TM_Dmamouriy)"
            sql += " VALUES (" & txtcarNum.Text & ",'" & llbl_carText.Text & "'," & txtCounter.Text & ",'" & txtDirctionName.Text & "'," & txtuser.Text & ",'" & Format(DTP.Value, "yyyy-MM-dd") & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = "SELECT TM_DATE, TM_TIME, TM_NUM_CAR, TM_TEXT_CAR,  TM_Ordernum, TM_DITRCTION,TM_SAPR, TM_Dmamouriy FROM  TM_DailySVShipping "
            sql1 += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " and fShift=" & txtshift.Text & ""
            sql1 += " and TM_SAPR =" & txtuser.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TM_DailySVShipping")
            ds.Tables("TM_DailySVShipping").Columns(0).ColumnName = "تاريخ التسجيل"
            ds.Tables("TM_DailySVShipping").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TM_DailySVShipping").Columns(2).ColumnName = " رقم السياره"
            ds.Tables("TM_DailySVShipping").Columns(3).ColumnName = "حروف السياره"
            ds.Tables("TM_DailySVShipping").Columns(4).ColumnName = "رقم الفاتورة"
            ds.Tables("TM_DailySVShipping").Columns(5).ColumnName = " الاتجاه"
            ds.Tables("TM_DailySVShipping").Columns(6).ColumnName = " ساب مسئول البيانات"
            ds.Tables("TM_DailySVShipping").Columns(7).ColumnName = "تاريخ التوريد"
            dg1.DataSource = ds.Tables("TM_DailySVShipping")
            Return True
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

    Private Sub frmDailySVShipping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BarcodeDataSet.TM_DailySVShipping' table. You can move, or remove it, as needed.
        Me.TM_DailySVShippingTableAdapter.Fill(Me.BarcodeDataSet.TM_DailySVShipping)
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT TM_NUM_CAR,TM_TEXT_CAR FROM   TM_Car "
            sql += "  where  TM_NUM_CAR like '%" & txtcarNum.Text & "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "TM_Car")
            txtcarNum.DataSource = ds.Tables(0)
            txtcarNum.ValueMember = "TM_TEXT_CAR"
            txtcarNum.DisplayMember = "TM_NUM_CAR"
            txtcarNum.Sorted = True
        Catch ex As Exception
            txtcarNum.Text = ""
        End Try


        Try
            Dim sql As String = ""
            sql += " SELECT TM_REG_ID,TM_REG_Name FROM TM_Regons "
            sql += "  where  TM_REG_Name like '%" & txtDirctionName.Text & "%'"
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add116_New()
        _Refresh11()
        txtCounter.Text = ""
        txtCounter.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Update1()
        _Refresh11()
        txtCounter.Text = ""
        txtCounter.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql As String
        sql = "DELETE FROM TM_DailySVShipping"
        sql += " WHERE TM_DATE >= Convert(nvarchar(10), GETDATE(), 121)"
        sql += " and TM_SAPR =" & txtuser.Text & ""
        sql += " and TM_Ordernum = " & txtCounter.Text & ""
        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        '   lbl_Msg.ForeColor = Color.GreenYellow
        ' lbl_Msg.Text = "Delete Model"

        _Refresh11()
        ' txtFATSERIAL.SelectAll()
        '_Refresh315()
        txtCounter.Text = ""
        txtcarNum.Text = ""
        txtDirctionName.Text = ""
        txtcarNum.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim DataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = ("F:\\TEVP_data_center.xlsx")
            '    MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=Excel 8.0;")
            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.14.0;Data Source=" + path + ";Extended Properties='Excel 14.0;'")
            '  MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=Excel 8.0;")

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
            For Each dre As DataGridViewRow In dg.Rows
                Dim sql As String
                sql = " INSERT INTO dbo.TM_DailySVShipping"
                sql += "(TM_SAPR, TM_NUM_CAR, TM_TEXT_CAR, TM_Ordernum, TM_DITRCTION)"
                sql += " VALUES (" & dre.Cells(0).Value & "," & dre.Cells(1).Value & ",'" & dre.Cells(2).Value & "'," & dre.Cells(3).Value & ",'" & dre.Cells(4).Value & "')"
                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
            Next
        Catch ex As Exception

        End Try

        MsgBox("ok my dear")
    End Sub
End Class