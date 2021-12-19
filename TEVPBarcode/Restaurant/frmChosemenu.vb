Imports TEVPBarcode.sher
Imports System.IO.Directory
Imports Microsoft.Office.Interop.Excel
Public Class frmChosemenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' If txtcc.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  RSap FROM Restaurant_request where RSap='" & TextBox1.Text & "'"
        Sql += " and RDateDay ='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count >= 1 Then
            'lbl_Msg.ForeColor = Color.Red
            MsgBox("هذا الاسم غير مصرح ليه استخدام المطعم فى هذا اليوم ")
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox1.Focus()
            ' txtcc.SelectAll()
            Exit Sub
            'ElseIf dsMax.Tables(0).Rows.Count = 0 Then
            '    'lbl_Msg.ForeColor = Color.Red
            '    MsgBox("هذا الاسم غير مصرح ليه استخدام المطعم فى هذا اليوم1 ")
            '    txtcc.Focus()
            '    txtcc.SelectAll()
            '    Exit Sub
        Else

            Add1_New()
            _Refresh1()
            _Refresh009()
        End If
    End Sub

    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_request "
            sql += "(RDateDay,RMFID,RMMID,RSap,RStatus,RID)"
            sql += " VALUES ('" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & lbl_Pcode_Value.Text & "','" & Label1.Text & "','" & TextBox1.Text & "','NO'," & Label2.Text & ")"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_New3() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_request "
            sql += "(RDateDay,RMFID,RMMID,RSap,RStatus,RID)"
            sql += " VALUES ('" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & lbl_Pcode_Value.Text & "','" & Label3.Text & "','" & TextBox1.Text & "','NO'," & Label2.Text & ")"
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
            sql = "	DELETE FROM [barcode].[dbo].[Restaurant_request]"
            sql += " where RDate ='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and RSap ='" & TextBox1.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh009() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT sum([RMPrice]) FROM resturantVPrice"
            ' sql += " FROM Output"
            sql += " where RSap='" & TextBox1.Text & "'"
            sql += " and RDateDay= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "resturantVPrice")
            ds.Tables("resturantVPrice").Columns(0).ColumnName = " الثمن الكلى"
            '  ds.Tables("Restaurant_User").Columns(1).ColumnName = "المسمى الوظيفى  "
            dgf.DataSource = ds.Tables("resturantVPrice")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  Restaurant_request set"
            sql += " RMFID = '" & lbl_Pcode_Value.Text & "',"
            sql += " RMMID = '" & Label1.Text & "'"
            '  sql += " RDateDay ='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " where RDateDay ='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += " and RSap ='" & TextBox1.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT RDateDay,RMFID,RMMID,RMMName,RSap FROM Restaurant_View"
            sql1 += " WHERE RDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += " and RSap ='" & TextBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_View")
            ds.Tables("Restaurant_View").Columns(0).ColumnName = "اليوم"
            ds.Tables("Restaurant_View").Columns(1).ColumnName = "كود العائلة"
            ds.Tables("Restaurant_View").Columns(2).ColumnName = "كود الواجبة"
            ds.Tables("Restaurant_View").Columns(3).ColumnName = "اسم الواجبه"
            ds.Tables("Restaurant_View").Columns(4).ColumnName = "رقم الساب"
            DataGridView2.DataSource = ds.Tables("Restaurant_View")

            Return True

        Catch ex As Exception

        End Try
    End Function

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
            gb2.Enabled = True
            ''GroupBox2.Visible = True
            ' ''txtshift.Visible = False
            'Button2.Visible = False
            'txtParts1.Visible = False
            'Label10.Visible = False
            _Refresh315()
            GroupBox4.Enabled = False
            ComboBox1.Focus()
            'Me.BackColor = Color.YellowGreen
            _Refresh1()
        End If


    End Sub
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

    Private Function _Refresh005() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT RMPrice FROM Restaurant_Meal"
            ' sql += " FROM Output"
            sql += " where RMFID=" & lbl_Pcode_Value.Text & ""
            sql += " and RMMID=" & Label1.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_Meal")
            ds.Tables("Restaurant_Meal").Columns(0).ColumnName = "ثمن الوجبه"
            '  ds.Tables("Restaurant_User").Columns(1).ColumnName = "المسمى الوظيفى  "
            DGDM.DataSource = ds.Tables("Restaurant_Meal")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh006() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT RMPrice FROM Restaurant_Meal"
            ' sql += " FROM Output"
            sql += " where RMFID='" & lbl_Pcode_Value.Text & "'"
            sql += " and RMMID='" & Label3.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_Meal")
            ds.Tables("Restaurant_Meal").Columns(0).ColumnName = "ثمن الوجبه"
            '  ds.Tables("Restaurant_User").Columns(1).ColumnName = "المسمى الوظيفى  "
            DGDM.DataSource = ds.Tables("Restaurant_Meal")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Del_Rec()
        _Refresh1()
        _Refresh009()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Update1A()
        _Refresh1()
        _Refresh009()

    End Sub

    Private Sub frmChosemenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        _Refresh1o()
        '  Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        'Timer1.Enabled = True
        GroupBox2.Enabled = False
        Try
            Dim sql As String = ""
            sql += " SELECT  RMFID,RMFName FROM   Restaurant_menu_family "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Restaurant_menu_family")
            ComboBox1.DataSource = ds.Tables(0)
            ComboBox1.ValueMember = "RMFID"

            ComboBox1.DisplayMember = "RMFName"
            ComboBox1.Sorted = True
            _Refresh1()
        Catch ex As Exception

        End Try
        TextBox1.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Try
            lbl_Pcode_Value.Text = ComboBox1.SelectedValue.ToString
            If ComboBox1.Text = "طلبات خاصة" Then

                GroupBox5.Enabled = False
                GroupBox2.Enabled = True
                _Refresh1o()
                ComboBox4.Focus()
            Else

                'Panel.Text = cmb_Pcode.SelectedValue
                ' Label2.Text = cmb_Pcode.Text
                '   txtFATSERIAL.Enabled = True
                _Refresh11()
                _Refresh1()

            End If

        Catch ex As Exception

        End Try
    End Sub
    'Private Function _Refresh11p() As Boolean

    '    Try

    '        Dim sql As String = ""
    '        sql += " SELECT  RMPrice,RMMName FROM   Restaurant_Meal "
    '        sql += " where RMFID ='" & lbl_Pcode_Value.Text & "'"
    '        ' sql1 += " and RSap ='" & TextBox1.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        ds.Tables.Clear()
    '        da.Fill(ds, "Restaurant_Meal")
    '        ComboBox2.DataSource = ds.Tables(0)
    '        'ComboBox2.ValueMember = "RMMID"
    '        ComboBox2.ValueMember = "RMPrice"
    '        ComboBox2.DisplayMember = "RMMName"
    '        ComboBox2.Sorted = True
    '        _Refresh1()

    '        Return True

    '    Catch ex As Exception

    '    End Try
    'End Function
    Private Function _Refresh11() As Boolean
        Try



            Dim sql As String = ""
            sql += " SELECT  RMMID,RMMName FROM   Restaurant_Meal "
            sql += " where RMFID ='" & lbl_Pcode_Value.Text & "'"
            ' sql1 += " and RSap ='" & TextBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Restaurant_Meal")
            ComboBox2.DataSource = ds.Tables(0)
            ComboBox2.ValueMember = "RMMID"
            '  ComboBox2.ValueMember = "RMPrice"
            ComboBox2.DisplayMember = "RMMName"
            ComboBox2.Sorted = True
            _Refresh1()

            Return True
        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh1o() As Boolean
        Try



            Dim sql As String = ""
            sql += " SELECT  RMMID,RMMName FROM   Restaurant_Meal "
            sql += " where RMFID ='7'"
            ' sql1 += " and RSap ='" & TextBox1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Restaurant_Meal")
            ComboBox4.DataSource = ds.Tables(0)
            ComboBox4.ValueMember = "RMMID"
            '  ComboBox2.ValueMember = "RMPrice"
            ComboBox4.DisplayMember = "RMMName"
            ComboBox4.Sorted = True
            _Refresh1()

            Return True
        Catch ex As Exception

        End Try

    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Label1.Text = ComboBox2.SelectedValue.ToString
            dm1.Text = ComboBox2.Text
         

            _Refresh005()
            _Refresh1()
        Catch ex As Exception

        End Try
        If lbl_Pcode_Value.Text = "4" And Label1.Text = "1" Then
            mypicature.Image = My.Resources._41RM
        ElseIf lbl_Pcode_Value.Text = "4" And Label1.Text = "2" Then
            mypicature.Image = My.Resources._14RM
        ElseIf lbl_Pcode_Value.Text = "4" And Label1.Text = "3" Then
            mypicature.Image = My.Resources._43RM
        ElseIf lbl_Pcode_Value.Text = "4" And Label1.Text = "4" Then
            mypicature.Image = My.Resources._44RM
        ElseIf lbl_Pcode_Value.Text = "4" And Label1.Text = "5" Then
            mypicature.Image = My.Resources._45RM
        ElseIf lbl_Pcode_Value.Text = "4" And Label1.Text = "6" Then
            mypicature.Image = My.Resources._46RM
        ElseIf lbl_Pcode_Value.Text = "4" And Label1.Text = "7" Then
            mypicature.Image = My.Resources._47RM


        ElseIf lbl_Pcode_Value.Text = "1" And Label1.Text = "1" Then
            mypicature.Image = My.Resources._11RM
        ElseIf lbl_Pcode_Value.Text = "1" And Label1.Text = "2" Then
            mypicature.Image = My.Resources._12RM
        ElseIf lbl_Pcode_Value.Text = "1" And Label1.Text = "3" Then
            mypicature.Image = My.Resources._13RM
        ElseIf lbl_Pcode_Value.Text = "1" And Label1.Text = "4" Then
            mypicature.Image = My.Resources._14RM
        ElseIf lbl_Pcode_Value.Text = "1" And Label1.Text = "5" Then
            mypicature.Image = My.Resources._15RM


        ElseIf lbl_Pcode_Value.Text = "5" And Label1.Text = "1" Then
            mypicature.Image = My.Resources._51RM
        ElseIf lbl_Pcode_Value.Text = "5" And Label1.Text = "2" Then
            mypicature.Image = My.Resources._52RM
        ElseIf lbl_Pcode_Value.Text = "5" And Label1.Text = "3" Then
            mypicature.Image = My.Resources._53RM


        ElseIf lbl_Pcode_Value.Text = "7" And Label1.Text = "1" Then
            mypicature.Image = My.Resources._71RM
        ElseIf lbl_Pcode_Value.Text = "7" And Label1.Text = "2" Then
            mypicature.Image = My.Resources._72RM
        ElseIf lbl_Pcode_Value.Text = "7" And Label1.Text = "3" Then
            mypicature.Image = My.Resources._73RM
        ElseIf lbl_Pcode_Value.Text = "7" And Label1.Text = "4" Then
            mypicature.Image = My.Resources._74RM
        ElseIf lbl_Pcode_Value.Text = "7" And Label1.Text = "5" Then
            mypicature.Image = My.Resources._75RM
        ElseIf lbl_Pcode_Value.Text = "7" And Label1.Text = "6" Then
            mypicature.Image = My.Resources._76RM
        ElseIf lbl_Pcode_Value.Text = "7" And Label1.Text = "7" Then
            mypicature.Image = My.Resources._77RM
        ElseIf lbl_Pcode_Value.Text = "7" And Label1.Text = "8" Then
            mypicature.Image = My.Resources._78RM
        End If

        ' End If





    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            Label2.Text = ComboBox3.SelectedValue.ToString
            'Panel.Text = cmb_Pcode.SelectedValue
            ' Label2.Text = cmb_Pcode.Text
            '   txtFATSERIAL.Enabled = True
            _Refresh11()
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            Label3.Text = ComboBox4.SelectedValue.ToString
            dm1.Text = ComboBox4.Text
            _Refresh006()


            If lbl_Pcode_Value.Text = "7" And Label3.Text = "1" Then
                mypicature.Image = My.Resources._71RM
            ElseIf lbl_Pcode_Value.Text = "7" And Label3.Text = "2" Then
                mypicature.Image = My.Resources._72RM
            ElseIf lbl_Pcode_Value.Text = "7" And Label3.Text = "3" Then
                mypicature.Image = My.Resources._73RM
            ElseIf lbl_Pcode_Value.Text = "7" And Label3.Text = "4" Then
                mypicature.Image = My.Resources._74RM
            ElseIf lbl_Pcode_Value.Text = "7" And Label3.Text = "5" Then
                mypicature.Image = My.Resources._75RM
            ElseIf lbl_Pcode_Value.Text = "7" And Label3.Text = "6" Then
                mypicature.Image = My.Resources._76RM
            ElseIf lbl_Pcode_Value.Text = "7" And Label3.Text = "7" Then
                mypicature.Image = My.Resources._77RM
            ElseIf lbl_Pcode_Value.Text = "7" And Label3.Text = "8" Then
                mypicature.Image = My.Resources._78RM
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Add1_New3()
            _Refresh1()
            _Refresh009()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBox5.Enabled = True
        GroupBox2.Enabled = False

        ComboBox1.Focus()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim frm As New frmResturantQueryUser
        frm.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frm As New frmpromassionresturant
        frm.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim frm As New frmrestuarantupdatearea
        frm.Show()
    End Sub
End Class