Imports TEVPBarcode.sher
Public Class frmpromassionresturant

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Length < 8 Then Exit Sub
        Dim dsMax As New DataSet
        Dim Sql = "SELECT  RName FROM Restaurant_User where RSap='" & TextBox1.Text & "'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count < 1 Then
            MsgBox("رقم الساب خطأ ")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        Else
            GroupBox3.Enabled = True
            GroupBox1.Enabled = False

            _Refresh315()
            ComboBox3.Focus()
        End If
    End Sub

    Private Function _Refresh315() As Boolean
        Try
            Dim sql1 As String = "SELECT RMMName,RName FROM Restaurant_request_User"
            sql1 += " WHERE RDateDay = Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += " and RSap ='" & TextBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_request_User")
            ds.Tables("Restaurant_request_User").Columns(0).ColumnName = "اسم الواجبه"
            ds.Tables("Restaurant_request_User").Columns(1).ColumnName = " الاسم "
            dg.DataSource = ds.Tables("Restaurant_request_User")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub frmpromassionresturant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += " SELECT  fID,fname FROM Restaurant_preferment "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Restaurant_preferment")
            ComboBox3.DataSource = ds.Tables(0)
            ComboBox3.ValueMember = "fID"
            ComboBox3.DisplayMember = "fname"
            ComboBox3.Sorted = True
        Catch ex As Exception
        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT  fID,fname FROM Restaurant_preferment_grad "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Restaurant_preferment_grad")
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "fID"
            ComboBox1.DisplayMember = "fname"
            ComboBox1.Sorted = True
        Catch ex As Exception
        End Try
        GroupBox3.Enabled = False
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            Label2.Text = ComboBox3.SelectedValue.ToString
            'Panel.Text = cmb_Pcode.SelectedValue
            ' Label2.Text = cmb_Pcode.Text
            '   txtFATSERIAL.Enabled = True
            '  _Refresh11()
            '   _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Label1.Text = ComboBox1.SelectedValue.ToString
            'Panel.Text = cmb_Pcode.SelectedValue
            ' Label2.Text = cmb_Pcode.Text
            '   txtFATSERIAL.Enabled = True
            '  _Refresh11()
            '   _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("الرجاء ادخال البيانات بطريه صحيحه ")
        Else
            Add1_New12()
            MsgBox("تم انتهاء العمليه شكرا على تعاونكم معانا  ")
            Dim frm As New frmChosemenu
            frm.Show()
            Close()
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Function Add1_New12() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_evaluation "
            sql += "(RSap, RType, RStat, RNote)"
            sql += " VALUES (" & TextBox1.Text & "," & Label2.Text & "," & Label1.Text & ",'" & TextBox2.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
End Class