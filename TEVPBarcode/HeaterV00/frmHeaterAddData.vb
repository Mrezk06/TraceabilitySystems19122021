Imports TEVPBarcode.sher
Public Class frmHeaterAddData

    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT Model_Name, component_Name, component_Control, step_visual FROM Heater_component"
            sql1 += "   where Model_Name ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_component")
            ds.Tables("Heater_component").Columns(0).ColumnName = " Model Name"
            ds.Tables("Heater_component").Columns(1).ColumnName = " component Code"
            ds.Tables("Heater_component").Columns(2).ColumnName = "part Control"
            ds.Tables("Heater_component").Columns(3).ColumnName = " Area"
            dg1.DataSource = ds.Tables("Heater_component")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql1 As String = "SELECT  Model_Name, Model_control, model_S_Power, fLine_Name, model_tank_C, model_pcb, Model_sap FROM Heater_ModelName"
            sql1 += "   where Model_Name ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_ModelName")
            ds.Tables("Heater_ModelName").Columns(0).ColumnName = "Model Name"
            ds.Tables("Heater_ModelName").Columns(1).ColumnName = "Model_control"
            ds.Tables("Heater_ModelName").Columns(2).ColumnName = "EAN Code"
            ds.Tables("Heater_ModelName").Columns(3).ColumnName = "Line"
            ds.Tables("Heater_ModelName").Columns(4).ColumnName = "Tank Control"
            ds.Tables("Heater_ModelName").Columns(5).ColumnName = "PCBC Control"
            ds.Tables("Heater_ModelName").Columns(6).ColumnName = "Heater Control"
            dg.DataSource = ds.Tables("Heater_ModelName")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO Heater_ModelName "
            sql += "(Model_Name, Model_control, model_S_Power, fLine_Name, model_tank_C, model_pcb, Model_sap)"
            sql += " VALUES ('" & txtModel.Text & "','" & TxtSet.Text & "','" & txtpanelid.Text & "','" & txtLine.Text & "','" & txtTankID.Text & "','" & txtpbid.Text & "','" & txtHeaterID.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    'Private Function Add1_Newk() As Boolean
    '    Try
    '        Dim sql As String
    '        sql = "	INSERT INTO barcode.dbo.LCDTVModels1 "
    '        sql += "(fLCDSetID,fLCDModelName,fpanelID,fpanelIDLCM)"
    '        sql += " VALUES ('" & TxtSet.Text & "','" & txtModel.Text & "','" & txtpanelid.Text & "','" & txtpanelIDLCM.Text & "')"



    '        Dim cmd As New SqlClient.SqlCommand(sql, cn)
    '        If cn.State = ConnectionState.Closed Then cn.Open()
    '        cmd.ExecuteNonQuery()

    '        cn.Close()


    '    Catch ex As Exception

    '    End Try
    'End Function

    Private Sub btnAddSetID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSetID.Click


        If txtModel.Text = "" Or TxtSet.Text = "" Or txtpanelid.Text = "" Or txtTankID.Text = "" Or txtHeaterID.Text = "" Or txtpbid.Text = "" Then
            MsgBox("please Entry All Data")
            txtModel.Focus()
        Else
            Dim dsMax As New DataSet
            Dim Sql = "SELECT Model_Name  FROM  Heater_ModelName "
            Sql += " where Model_Name ='" & txtModel.Text & "'"
            Sql += " and Model_control ='" & TxtSet.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count < 0 Then
                '  lbl_Msg.ForeColor = Color.Red
                MsgBox("This Model is already used")
                txtModel.Enabled = True
                TxtSet.Enabled = True
                txtpanelid.Enabled = True

                txtModel.Focus()
                txtModel.SelectAll()
                Exit Sub
            End If


            Add1_New()
            'Add1_Newk()
            _Refresh1()

            GroupBox1.Enabled = False
            GroupBox5.Enabled = True
            TxtVCode.Focus()
        End If
    End Sub
    Private Function Clear_Txts() As Boolean
        Try
            ' txtName.Text = ""
            TxtVCode.Text = ""
            txtPart.Text = ""

            TxtVCode.Focus()

        Catch ex As Exception

        End Try
    End Function
    Private Sub frmAddData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/PageColor2.ssk"

    End Sub
    Private Function Add11_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO Heater_component "
            sql += "(Model_Name, component_Name, component_Control, step_visual)"
            sql += " VALUES ('" & txtModel.Text & "','" & TxtVCode.Text & "' ,'" & txtPart.Text & "','" & txtArea.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtModel.Text = "" Or TxtVCode.Text = "" Or txtArea.Text = "" Then
            MsgBox("Please Check Your Textbox ")
            txtModel.Focus()
        Else
            Dim dsMax As New DataSet
            Dim Sql = "SELECT Model_Name  FROM  Heater_component "
            Sql += " where Model_Name='" & txtModel.Text & "'"
            Sql += " and component_Name='" & TxtVCode.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count > 0 Then
                '  lbl_Msg.ForeColor = Color.Red
                MsgBox("This comonent is already used")
                TxtVCode.Enabled = True
                txtArea.Enabled = True
                txtPart.Enabled = True
                '  txtName.Enabled = True

                TxtVCode.Focus()
                TxtVCode.SelectAll()
                Exit Sub
            End If


            Add11_New()
            _Refresh11()
            Clear_Txts()
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Function Del_RecM() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM Heater_component"
            sql += " where Model_Name ='" & txtModel.Text & "'"

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
            sql = "	DELETE FROM Heater_ModelName"
            sql += " where Model_Name ='" & txtModel.Text & "'"

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
            sql = "	DELETE FROM Heater_ModelName"
            sql += " where Model_Name ='" & txtModel.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Del_Rec()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Enabled = True
        GroupBox5.Enabled = False

        Del_Rec1()
        Del_Rec()
        Del_RecM()
        _Refresh1()
        _Refresh11()
        txtModel.Text = ""
        TxtSet.Text = ""
        txtpanelid.Text = ""
        'txtModel.Text = ""
        'TxtSet.Text = ""
        'txtpanelid.Text = ""
        txtpbid.Text = ""
        ' TxtVCode.Text = ""
        txtHeaterID.Text = ""
        txtTankID.Text = ""
        txtLine.Text = ""
        txtPart.Text = ""
        txtArea.Text = ""
        TxtVCode.Text = ""
        '  txtName.Text = ""
        'txtPart.Text = ""
        'txtArea.Text = ""
        txtModel.Focus()


    End Sub
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  Heater_ModelName set"
            'sql += " Model_Name = '" & txtModel.Text & "',"
            sql += " model_S_Power = '" & txtpanelid.Text & "',"
            sql += " fLine_Name = '" & txtLine.Text & "',"
            sql += " model_tank_C = '" & txtTankID.Text & "',"
            sql += " model_pcb = '" & txtpbid.Text & "',"
            sql += " Model_sap = '" & txtHeaterID.Text & "'"
            sql += " where Model_control = '" & TxtSet.Text & "'"
            sql += " and Model_Name = '" & txtModel.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    
    Private Function UpdateM() As Boolean
        Try
            Dim sql As String
            '  Model_Name, component_Name, component_Control, step_visual, Component_Sap
            sql = " UPDATE  Heater_component set"
            sql += " Model_Name = '" & txtModel.Text & "',"
            sql += " component_Name = '" & TxtVCode.Text & "',"
            sql += " step_visual = '" & txtArea.Text & "',"
            sql += " component_Control = '" & txtPart.Text & "'"
            sql += " where Model_Name = '" & txtModel.Text & "'"
            sql += "AND  component_Name = '" & TxtVCode.Text & "'"
            '  sql += " and fCompCode = '" & TxtVCode.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        GroupBox1.Enabled = True
        GroupBox5.Enabled = False
        txtModel.Text = ""
        TxtSet.Text = ""
        txtpanelid.Text = ""
        txtpbid.Text = ""
        TxtVCode.Text = ""
        txtHeaterID.Text = ""
        txtTankID.Text = ""
        txtLine.Text = ""
        txtPart.Text = ""
        txtArea.Text = ""

        txtModel.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        _Refresh1()
        _Refresh11()
        GroupBox1.Enabled = True
        GroupBox5.Enabled = True

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        txtModel.Text = dg.Item(0, dg.CurrentRow.Index).Value
        TxtSet.Text = dg.Item(1, dg.CurrentRow.Index).Value
        txtpanelid.Text = dg.Item(2, dg.CurrentRow.Index).Value


        txtLine.Text = dg.Item(3, dg.CurrentRow.Index).Value
        'txtTankID.Text = dg.Item(4, dg.CurrentRow.Index).Value
        'txtHeaterID.Text = dg.Item(5, dg.CurrentRow.Index).Value
        'txtpbid.Text = dg.Item(6, dg.CurrentRow.Index).Value
        '     txtpanelIDLCM.Text = dg.Item(3, dg.CurrentRow.Index).Value
        GroupBox1.Enabled = True
        GroupBox5.Enabled = False
 

        txtTankID.Focus()

    End Sub

    Private Sub dg1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellContentClick
        'Model_Name, component_Name, component_Control, step_visual, Component_Sap
        ' txtName.Text = dg1.Item(2, dg1.CurrentRow.Index).Value
        TxtVCode.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
        txtPart.Text = dg1.Item(2, dg1.CurrentRow.Index).Value
        txtArea.Text = dg1.Item(3, dg1.CurrentRow.Index).Value
    
        GroupBox1.Enabled = False
        GroupBox5.Enabled = True
        TxtVCode.Focus()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' Update12A()
        Update1A()
        _Refresh1()
        _Refresh11()
        txtModel.Enabled = True
        TxtSet.Enabled = True
        txtpanelid.Enabled = True
        'GroupBox1.Enabled = False
        GroupBox5.Enabled = True

        'txtpanelIDLCM.Text = ""
        TxtVCode.Text = ""
        '  txtName.Text = ""
        txtPart.Text = ""
        txtArea.Text = ""
        TxtVCode.Focus()


    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        UpdateM()

        _Refresh1()
        _Refresh11()
        'txtModel.Text = ""
        'TxtSet.Text = ""
        'txtpanelid.Text = ""
        'txtpanelIDLCM.Text = ""
        TxtVCode.Enabled = True
        txtArea.Enabled = True
        ' txtName.Enabled = True
        TxtVCode.Text = ""
        'txtName.Text = ""
        txtPart.Text = ""
        txtArea.Text = ""
        TxtVCode.Focus()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Dim frm As New frmaddmodelandlebar
        'frm.Show()

    End Sub
End Class