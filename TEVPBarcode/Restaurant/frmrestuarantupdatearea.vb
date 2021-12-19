Imports TEVPBarcode.sher
Imports System.IO.Directory
Imports Microsoft.Office.Interop.Excel
Public Class frmrestuarantupdatearea

    Private Sub frmrestuarantupdatearea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += " SELECT  RID,RName FROM Restaurant_Name_area "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Restaurant_Name_area")
            ComboBox3.DataSource = ds.Tables(0)
            ComboBox3.ValueMember = "RID"

            ComboBox3.DisplayMember = "RName"
            ComboBox3.Sorted = True
            '   _Refresh1()
        Catch ex As Exception

        End Try
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox6.Enabled = False

    End Sub
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT RDateDay,RMFID,RMMID,RMMName,RSap,RID,RName FROM Restaurant_View"
            sql1 += " WHERE RDateDay >= DATEADD(HOUR, +48, GETDATE())"
            sql1 += " and RSap ='" & TextBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_View")
            ds.Tables("Restaurant_View").Columns(0).ColumnName = "اليوم"
            ds.Tables("Restaurant_View").Columns(1).ColumnName = "كود العائلة"
            ds.Tables("Restaurant_View").Columns(2).ColumnName = "كود الواجبة"
            ds.Tables("Restaurant_View").Columns(3).ColumnName = "اسم الواجبه"
            ds.Tables("Restaurant_View").Columns(4).ColumnName = "رقم الساب"
            ds.Tables("Restaurant_View").Columns(5).ColumnName = " كود المطعم"
            ds.Tables("Restaurant_View").Columns(6).ColumnName = " اسم المطعم"
            dg.DataSource = ds.Tables("Restaurant_View")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  Restaurant_request set"
            sql += " RID = " & Label2.Text & ""
            sql += " where RDateDay ='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and RSap ='" & TextBox1.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            Label2.Text = ComboBox3.SelectedValue.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh1()

        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox6.Enabled = True
        GroupBox7.Enabled = False
        ComboBox3.Focus()

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        Try
            TextBox1.Text = dg.Item(4, dg.CurrentRow.Index).Value
            DateTimePicker1.Text = dg.Item(0, dg.CurrentRow.Index).Value
        Catch ex As Exception
        End Try
      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Update1A()
        _Refresh1()
    End Sub
End Class