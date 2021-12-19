Imports TEVPBarcode.sher
Public Class Heater_add_new_model
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Close()
    End Sub
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO Heater_ModelName "
            sql += "(Model_Name, Model_control, model_S_Power,fLine_Name)"
            sql += " VALUES ('" & txtModel.Text & "','" & TxtSet.Text & "','" & txtsteker_power.Text & "','" & txtArea.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function Add11_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO Heater_component "
            sql += "( Model_Name, component_Name, component_Control, step_visual )"
            sql += " VALUES ('" & txtModel.Text & "','" & txtName.Text & "','" & txtPart.Text & "','" & txtArea.Text & "')"
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
            sql = "	INSERT INTO Heater_Name_Sap "
            sql += "(Heater_Name_Laber,Heater_Sap_Laber,Heater_sap_stu)"
            sql += " VALUES ('" & TxtN_Laber.Text & "','" & txtS_Laber.Text & "','" & txtstu.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            'sql += " Heater_sap_stu = '" & txtstu.Text & "'"
            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT  Model_Name, Model_control, model_S_Power,fLine_Name FROM Heater_ModelName"
            '  sql1 += "   where Model_Name ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_ModelName")
            ds.Tables("Heater_ModelName").Columns(0).ColumnName = "Model_Name"
            ds.Tables("Heater_ModelName").Columns(1).ColumnName = "Model_control"
            ds.Tables("Heater_ModelName").Columns(2).ColumnName = "model_S_Power"
            ds.Tables("Heater_ModelName").Columns(3).ColumnName = "Line_Name"
            dg.DataSource = ds.Tables("Heater_ModelName")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT Model_Name, component_Name, component_Control, step_visual FROM Heater_component"
            sql1 += "   where Model_Name ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_component")
            ds.Tables("Heater_component").Columns(0).ColumnName = "Model_Name"
            ds.Tables("Heater_component").Columns(1).ColumnName = "component_Name"
            ds.Tables("Heater_component").Columns(2).ColumnName = "component_Control"
            ds.Tables("Heater_component").Columns(3).ColumnName = "step_visual"
            dg1.DataSource = ds.Tables("Heater_component")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Sub Heater_add_new_model_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
    End Sub

    Private Sub btnAddSetID_Click(sender As Object, e As EventArgs) Handles btnAddSetID.Click
        Add1_New()
        _Refresh1()
        ' txtModel.Text = ""
        txtsteker_power.Text = ""
        TxtSet.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add11_New()
        _Refresh11()

        txtName.Text = ""
        txtPart.Text = ""
        txtArea.Text = ""
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber,Heater_Sap_Laber,Heater_sap_stu FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            ' sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "Name Laber "
            ds.Tables("Heater_Name_Sap").Columns(1).ColumnName = "Sap Laber "
            ds.Tables("Heater_Name_Sap").Columns(2).ColumnName = " Status"
            dg1.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtS_Laber.Text.Length < 8 Then
            MsgBox("الرجاء التحقق من ساب الموظف لبد ان يكون مكون من 8 أرقام  ")
            txtS_Laber.Focus()
            txtS_Laber.SelectAll()



        Else
            'Dim dsMax As New DataSet
            'Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtParts1.Text & "'"
            'Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            'dsMax.Tables.Clear()
            'da.Fill(dsMax)
            'If dsMax.Tables(0).Rows.Count < 1 Then
            '    ' lbl_Msg.ForeColor = Color.Red
            '    MessageBox = "هذا الاسم غير  مصرح له العمل على الباركود "
            '    txtParts1.Focus()
            '    txtParts1.SelectAll()
            '    Exit Sub

            '    _Refresh315()
            '    lbl_Msg.ForeColor = Color.Green
            '    lbl_Msg.Text = "مرحبا بك فى برنامج مصنع السخان لمتابعة الجوده "
            '    cmb_Pcode.Enabled = True
            '    ' txtline.Enabled = False
            '    txtshift.Enabled = True
            '    'txtshift.Visible = False
            '    Button2.Visible = False
            Add116_New()
            _Refresh315()
            txtS_Laber.Text = ""
            TxtN_Laber.Text = ""

            txtstu.Text = ""
            '    Label10.Visible = False
            '    txtshift.Focus()
        End If

    End Sub
    Private Function Update1() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE Heater_ModelName Set"
            sql += " Model_Name ='" & txtModel.Text & "',"
            sql += " Model_control = '" & TxtSet.Text & "',"
            sql += " model_S_Power = '" & txtsteker_power.Text & "',"
            sql += " fLine_Name = '" & txtArea.Text & "'"
            sql += " where Model_Name = '" & txtModel.Text & "'"
            ' sql += " and  Model_control = '" & TxtSet.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update12() As Boolean
        Try
            Dim sql As String
            sql = "UPDATE Heater_Name_Sap Set"
            sql += " Heater_Name_Laber ='" & TxtN_Laber.Text & "',"
            sql += " Heater_Sap_Laber = '" & txtS_Laber.Text & "',"
            sql += " Heater_sap_stu = '" & txtstu.Text & "'"
            'sql += " fLine_Name = '" & txtArea.Text & "'"
            sql += " where Heater_Sap_Laber = '" & txtS_Laber.Text & "'"
            ' sql += " and  Model_control = '" & TxtSet.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        _Refresh1()
        _Refresh315()
    End Sub

    Private Sub txtS_Laber_Leave(sender As Object, e As EventArgs) Handles txtS_Laber.Leave
        If txtS_Laber.Text.Length < 8 Or txtS_Laber.Text.Length > 8 Then
            MsgBox(" رقم الساب غير صحيح   ")
            txtS_Laber.Focus()
            txtS_Laber.SelectAll()
        End If
        Exit Sub

        'Dim dsMax As New DataSet
        'Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtS_Laber.Text & "'"
        'Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        'dsMax.Tables.Clear()
        'da.Fill(dsMax)
        'If dsMax.Tables(0).Rows.Count = 1 Then
        '    '  lbl_Msg.ForeColor = Color.Red
        '    MsgBox(" من فضلك تأكدمن صحة أدخال البيانات حيث تم تسجيلها من قبل  ")
        '    txtS_Laber.Focus()
        '    txtS_Laber.SelectAll()
        '    Exit Sub
        'Else
        '    TxtN_Laber.Focus()
        'End If
    End Sub

    Private Sub txtS_Laber_TextChanged(sender As Object, e As EventArgs) Handles txtS_Laber.TextChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Update1()
        _Refresh1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Update12()

        _Refresh315()

        txtS_Laber.Text = ""
        TxtN_Laber.Text = ""
        txtstu.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sql As String
        sql = "DELETE FROM Heater_Name_Sap"
        sql += " where Heater_Sap_Laber = '" & txtS_Laber.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        '   lbl_Msg.ForeColor = Color.GreenYellow
        ' lbl_Msg.Text = "Delete Model"
        txtS_Laber.Focus()
        ' txtFATSERIAL.SelectAll()
        _Refresh315()
        txtS_Laber.Text = ""
        TxtN_Laber.Text = ""
        'txtFATSERIAL.Enabled = True
        'txtFATSERIAL.Focus()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sql As String
        sql = "DELETE FROM Heater_ModelName"
        sql += " where Model_Name = '" & txtModel.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(sql, cn)
        If cn.State = ConnectionState.Closed Then cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        '   lbl_Msg.ForeColor = Color.GreenYellow
        ' lbl_Msg.Text = "Delete Model"
        txtS_Laber.Focus()
        _Refresh1()
        ' txtFATSERIAL.SelectAll()
        '_Refresh315()
        txtModel.Text = ""
        TxtSet.Text = ""
        txtsteker_power.Text = ""
        txtArea.Text = ""

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
     
    End Sub

    Private Sub dg1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellContentClick
        TxtN_Laber.Text = dg1.Item(0, dg1.CurrentRow.Index).Value
        txtS_Laber.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
    End Sub

    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        txtModel.Text = dg.Item(0, dg.CurrentRow.Index).Value
        TxtSet.Text = dg.Item(1, dg.CurrentRow.Index).Value
        txtsteker_power.Text = dg.Item(2, dg.CurrentRow.Index).Value
        'txtArea.Text = dg.Item(3, dg.CurrentRow.Index).Value
    End Sub
End Class