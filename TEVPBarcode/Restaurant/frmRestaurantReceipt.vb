Imports TEVPBarcode.sher

Public Class frmRestaurantReceipt

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmRestaurantReceipt_Load(sender As Object, e As EventArgs)
        Me.BackgroundImage = pb.BackgroundImage
        GroupBox2.BackColor = Color.FromArgb(120, 0, 0, 0)
        pb.BackColor = Color.FromArgb(120, 0, 0, 0)
        GroupBox2.BackColor = Color.Transparent




    End Sub

    Private Sub frmRestaurantReceipt_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub pb_Click(sender As Object, e As EventArgs) Handles pb.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  RName FROM Restaurant_User where RSap='" & TextBox1.Text & "'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count < 1 Then
            'lbl_Msg.ForeColor = Color.Red
            MsgBox("هذا الاسم غير مصرح ليه استخدام المطعم فى هذا اليوم ")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        Else

            '      MsgBox("welcome This name allowed to work on barcode Line")
            'cmb_Pcode.Enabled = True
            ' '' txtline.Enabled = False
            GroupBox2.Enabled = True
            GroupBox7.Enabled = False
            GroupBox3.Enabled = False

            ''GroupBox2.Visible = True
            ' ''txtshift.Visible = False
            'Button2.Visible = False
            'txtParts1.Visible = False
            'Label10.Visible = False
            '_Refresh315()
            _Refresh315()

            txtcc.Focus()
            'Me.BackColor = Color.YellowGreen

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtcc.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  RSap FROM Restaurant_request where RSap='" & txtcc.Text & "'"
        Sql += " and RStatus ='OK'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count >= 1 Then
            'lbl_Msg.ForeColor = Color.Red
            MsgBox("هذا الاسم غير مصرح ليه استخدام المطعم فى هذا اليوم ")
            txtcc.Focus()
            txtcc.SelectAll()
            Exit Sub
            'ElseIf dsMax.Tables(0).Rows.Count = 0 Then
            '    'lbl_Msg.ForeColor = Color.Red
            '    MsgBox("هذا الاسم غير مصرح ليه استخدام المطعم فى هذا اليوم1 ")
            '    txtcc.Focus()
            '    txtcc.SelectAll()
            '    Exit Sub
        Else

            '  If e.KeyCode = Keys.Enter Then
            _Refresh1()
            txtcc.Focus()
            Update1A()
            txtcc.SelectAll()
        End If
    End Sub
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  Restaurant_request set"
            sql += " RStatus = 'OK'"
            ' sql += " RMMID = '" & Label1.Text & "'"
            '  sql += " RDateDay ='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " where RDateDay = Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and RSap ='" & txtcc.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT RDateDay,RMFID,RMMID,RMMName,RSap,RName,RPosation FROM Restaurant_request_User"
            sql1 += " WHERE RDateDay = Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += " and RSap ='" & txtcc.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_request_User")
            ds.Tables("Restaurant_request_User").Columns(0).ColumnName = "اليوم"
            ds.Tables("Restaurant_request_User").Columns(1).ColumnName = "كود العائلة"
            ds.Tables("Restaurant_request_User").Columns(2).ColumnName = "كود الواجبة"
            ds.Tables("Restaurant_request_User").Columns(3).ColumnName = "اسم الواجبه"
            ds.Tables("Restaurant_request_User").Columns(4).ColumnName = "رقم الساب"
            ds.Tables("Restaurant_request_User").Columns(5).ColumnName = " الاسم "
            ds.Tables("Restaurant_request_User").Columns(6).ColumnName = " المسمى الوظيفى"
            dg2.DataSource = ds.Tables("Restaurant_request_User")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT RName,RPosation FROM Restaurant_User"
            ' sql += " FROM Output"
            sql += " where RSap='" & TextBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_User")
            ds.Tables("Restaurant_User").Columns(0).ColumnName = "  الاسم"
            ds.Tables("Restaurant_User").Columns(1).ColumnName = "المسمى الوظيفى  "
            dg.DataSource = ds.Tables("Restaurant_User")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtcc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcc.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtcc.Text.Length < 8 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "SELECT  RSap FROM Restaurant_request where RSap='" & txtcc.Text & "'"
                Sql += " and RID ='" & Label2.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count < 1 Then
                    _Refresh1()
                    Dim frm As New frmmefpntr
                    frm.Show()
                    txtcc.Focus()
                    txtcc.SelectAll()
                    Exit Sub
                End If
            End If

        Catch ex As Exception
        End Try

        Try
            If e.KeyCode = Keys.Enter Then
                If txtcc.Text.Length < 8 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "SELECT  RSap FROM Restaurant_request where RSap='" & txtcc.Text & "'"
                Sql += " and RID ='" & Label2.Text & "'"
                Sql += " and RStatus ='OK'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count >= 1 Then
                    Dim frm As New frmrecipymea0001
                    frm.Show()
                    txtcc.Focus()
                    txtcc.SelectAll()
                    Exit Sub
                Else
                    _Refresh1()
                    txtcc.Focus()
                    Update1A()
                    txtcc.SelectAll()
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtcc_TextChanged(sender As Object, e As EventArgs) Handles txtcc.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            Label2.Text = ComboBox3.SelectedValue.ToString
            'Panel.Text = cmb_Pcode.SelectedValue
            ' Label2.Text = cmb_Pcode.Text
            '   txtFATSERIAL.Enabled = True
            '  _Refresh11()
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    'Private Function dsMax2() As Object
    '    Throw New NotImplementedException
    'End Function

End Class