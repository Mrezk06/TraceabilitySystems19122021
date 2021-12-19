Imports TEVPBarcode.sher
Public Class frmAddData

    '  Private Property txtpanelid As Object

    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT fModelName, fCompCode, fCompName,part, fArea FROM  Material"
            sql1 += "   where fModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Material")
            ds.Tables("Material").Columns(0).ColumnName = " Model Name"
            ds.Tables("Material").Columns(1).ColumnName = " component Code"
            ds.Tables("Material").Columns(2).ColumnName = "component Name"
            ds.Tables("Material").Columns(3).ColumnName = "part Control"
            ds.Tables("Material").Columns(4).ColumnName = " Area"


            dg1.DataSource = ds.Tables("Material")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT [fLCDSetID],[fLCDModelName],[fpanelID],[fpanelIDLCM] FROM [LCDTVModels]"
            sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCDTVModels")
            ds.Tables("LCDTVModels").Columns(0).ColumnName = "LCD Set ID"
            ds.Tables("LCDTVModels").Columns(1).ColumnName = "LCD Model Name"
            ds.Tables("LCDTVModels").Columns(2).ColumnName = "fpanelID"
            ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("LCDTVModels")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO LCDTVModels "
            sql += "(fLCDSetID,fLCDModelName,fpanelID,fpanelIDLCM)"
            sql += " VALUES ('" & TxtSet.Text & "','" & txtModel.Text & "','" & txtpanelid.Text & "','" & txtpanelIDLCM.Text & "')"



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
            sql = "	INSERT INTO LCDTVModels1 "
            sql += "(fLCDSetID,fLCDModelName,fpanelID,fpanelIDLCM)"
            sql += " VALUES ('" & TxtSet.Text & "','" & txtModel.Text & "','" & txtpanelid.Text & "','" & txtpanelIDLCM.Text & "')"



            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function

    Private Sub btnAddSetID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSetID.Click


        If txtModel.Text = "" Or TxtSet.Text = "" Or txtpanelid.Text = "" Or txtpanelIDLCM.Text = "" Then
            MsgBox("please Entry All Data")
        Else
            Dim dsMax As New DataSet
            Dim Sql = "SELECT fLCDModelName  FROM  LCDTVModels "
            Sql += " where fLCDModelName ='" & txtModel.Text & "'"
            Sql += " and fpanelID ='" & txtpanelid.Text & "'"

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

            Dim dsMax1 As New DataSet
            Dim Sql1 = "SELECT fLCDModelName  FROM  LCDTVModels1 "
            Sql += " where fLCDModelName='" & txtModel.Text & "'"
            Sql += " and fpanelID ='" & txtpanelid.Text & "'"

            Dim da1 As New SqlClient.SqlDataAdapter(Sql1, cn)
            dsMax.Tables.Clear()
            da1.Fill(dsMax1)
            If dsMax1.Tables(0).Rows.Count < 0 Then
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
            Add1_Newk()
            _Refresh1()

            GroupBox1.Enabled = False
            GroupBox5.Enabled = True
            TxtVCode.Focus()
        End If
    End Sub
    Private Function Clear_Txts() As Boolean
        Try
            txtName.Text = ""
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
            sql = "	INSERT INTO Material "
            sql += "(fModelName,fCompCode ,fCompName,fArea,part)"
            sql += " VALUES ('" & txtModel.Text & "','" & TxtVCode.Text & "','" & txtName.Text & "','" & txtArea.Text & "','" & txtPart.Text & "')"



            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtModel.Text = "" Or TxtVCode.Text = "" Or txtName.Text = "" Or txtArea.Text = "" Then
            MsgBox("Please Check Your Textbox ")
        Else
            Dim dsMax As New DataSet
            Dim Sql = "SELECT fModelName  FROM  Material "
            Sql += " where fModelName='" & txtModel.Text & "'"
            Sql += " and fCompCode='" & TxtVCode.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count > 0 Then
                '  lbl_Msg.ForeColor = Color.Red
                MsgBox("This comonent is already used")
                TxtVCode.Enabled = True
                txtArea.Enabled = True
                txtPart.Enabled = True
                txtName.Enabled = True

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
            sql = "	DELETE FROM Material"
            sql += " where fModelName ='" & txtModel.Text & "'"

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
            sql = "	DELETE FROM  LCDTVModels"
            sql += " where fLCDModelName ='" & txtModel.Text & "'"

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
            sql = "	DELETE FROM LCDTVModels1"
            sql += " where fLCDModelName ='" & txtModel.Text & "'"

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
        txtpanelIDLCM.Text = ""
        TxtVCode.Text = ""
        txtName.Text = ""
        txtPart.Text = ""
        txtArea.Text = ""
        txtModel.Focus()

    End Sub
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  LCDTVModels set"
            sql += " fLCDModelName = '" & txtModel.Text & "',"
            sql += " fpanelID = '" & txtpanelid.Text & "',"
            sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where fLCDSetID = '" & TxtSet.Text & "'"
            sql += " and fLCDModelName = '" & txtModel.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update12A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  LCDTVModels1 set"
            sql += " fLCDModelName = '" & txtModel.Text & "',"
            sql += " fpanelID = '" & txtpanelid.Text & "',"
            sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where fLCDSetID = '" & TxtSet.Text & "'"
            sql += " and fLCDModelName = '" & txtModel.Text & "'"
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
            sql = " UPDATE  Material set"
            sql += " fModelName = '" & txtModel.Text & "',"
            sql += " fCompCode = '" & TxtVCode.Text & "',"
            sql += " fCompName = '" & txtName.Text & "',"
            sql += " fArea = '" & txtArea.Text & "',"
            sql += " part = '" & txtPart.Text & "'"
            sql += " where fModelName = '" & txtModel.Text & "'"
            sql += " and fCompCode = '" & TxtVCode.Text & "'"
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
        txtpanelIDLCM.Text = ""
        TxtVCode.Text = ""
        txtName.Text = ""
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
        txtModel.Text = dg.Item(1, dg.CurrentRow.Index).Value
        TxtSet.Text = dg.Item(0, dg.CurrentRow.Index).Value
        txtpanelid.Text = dg.Item(2, dg.CurrentRow.Index).Value
        txtpanelIDLCM.Text = dg.Item(3, dg.CurrentRow.Index).Value
        GroupBox1.Enabled = True
        GroupBox5.Enabled = False
        txtModel.Enabled = False
        TxtSet.Enabled = False
        txtpanelid.Enabled = False

        txtpanelIDLCM.Focus()

    End Sub

    Private Sub dg1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellContentClick
        txtName.Text = dg1.Item(2, dg1.CurrentRow.Index).Value
        TxtVCode.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
        txtPart.Text = dg1.Item(3, dg1.CurrentRow.Index).Value
        txtArea.Text = dg1.Item(4, dg1.CurrentRow.Index).Value
        TxtVCode.Enabled = False
        txtArea.Enabled = False
        txtName.Enabled = False
        GroupBox1.Enabled = False
        GroupBox5.Enabled = True
        txtPart.Focus()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Update12A()
        Update1A()
        _Refresh1()
        _Refresh11()
        txtModel.Enabled = True
        TxtSet.Enabled = True
        txtpanelid.Enabled = True
               GroupBox1.Enabled = False
        GroupBox5.Enabled = True

        'txtpanelIDLCM.Text = ""
        TxtVCode.Text = ""
        txtName.Text = ""
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
        txtName.Enabled = True
        TxtVCode.Text = ""
        txtName.Text = ""
        txtPart.Text = ""
        txtArea.Text = ""
        TxtVCode.Focus()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frm As New frmaddmodelandlebar
        frm.Show()

    End Sub
End Class