Imports TEVPBarcode.sher
Public Class frmAddDataLEDBAR

    Private Sub frmAddDataLEDBAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Refresh11()

    End Sub

    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = "SELECT    fLCDModelName, fpanelID,fLCDSetID, fpanelIDLCM FROM LCDTVModelsLED"
            '      sql1 += "   where fModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCDTVModelsLED")
            ds.Tables("LCDTVModelsLED").Columns(0).ColumnName = " Model Name"
            ds.Tables("LCDTVModelsLED").Columns(1).ColumnName = " component Name"
            ds.Tables("LCDTVModelsLED").Columns(2).ColumnName = "Control R"
            ds.Tables("LCDTVModelsLED").Columns(3).ColumnName = "Control L"
            ' ds.Tables("LCDTVModelsLED").Columns(4).ColumnName = " Area"
            dg1.DataSource = ds.Tables("LCDTVModelsLED")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh112() As Boolean
        Try
            Dim sql1 As String = "SELECT    fLCDModelName, fpanelID,fLCDSetID, fpanelIDLCM FROM LCDTVModelsLED"
            sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCDTVModelsLED")
            ds.Tables("LCDTVModelsLED").Columns(0).ColumnName = " Model Name"
            ds.Tables("LCDTVModelsLED").Columns(1).ColumnName = " component Name"
            ds.Tables("LCDTVModelsLED").Columns(2).ColumnName = "Control R"
            ds.Tables("LCDTVModelsLED").Columns(3).ColumnName = "Control L"
            ' ds.Tables("LCDTVModelsLED").Columns(4).ColumnName = " Area"
            dg1.DataSource = ds.Tables("LCDTVModelsLED")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function Update12A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  LCDTVModelsLED set"
            sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "',"
            sql += " fLCDSetID = '" & txtpanelid.Text & "'"
            sql += " where fpanelID = '" & TxtSet.Text & "'"
            sql += " and fLCDModelName = '" & txtModel.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnAddSetID_Click(sender As Object, e As EventArgs) Handles btnAddSetID.Click
        If txtModel.Text = "" Or TxtSet.Text = "" Or txtpanelid.Text = "" Or txtpanelIDLCM.Text = "" Then
            MsgBox("please Entry All Data")
        Else
            Dim dsMax As New DataSet
            Dim Sql = "SELECT fLCDModelName  FROM  LCDTVModelsLED "
            Sql += " where fLCDModelName ='" & txtModel.Text & "'"
            Sql += " and fLCDSetID ='" & txtpanelid.Text & "'"
            Sql += " and fpanelIDLCM ='" & txtpanelIDLCM.Text & "'"
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


            Add11_New()

            _Refresh11()

            txtModel.Text = ""
            txtpanelid.Text = ""
            txtpanelIDLCM.Text = ""
            TxtSet.Text = ""
            txtModel.Focus()
        End If
    End Sub
    Private Function Add11_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO LCDTVModelsLED "
            sql += "(fLCDSetID, fLCDModelName, fpanelID, fpanelIDLCM)"
            sql += " VALUES ('" & txtpanelid.Text & "','" & txtModel.Text & "','" & TxtSet.Text & "','" & txtpanelIDLCM.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _Refresh112()
        txtModel.Text = ""
        txtpanelid.Text = ""
        txtpanelIDLCM.Text = ""
        TxtSet.Text = ""
        txtModel.Focus()
    End Sub
    Private Function Del_Rec() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM LCDTVModelsLED"
            sql += " where fLCDModelName ='" & txtModel.Text & "'"
            sql += " and fLCDSetID ='" & txtpanelid.Text & "'"
            sql += " and fpanelIDLCM ='" & txtpanelIDLCM.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)

            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As Exception

        End Try
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Del_Rec()
        _Refresh11()
        txtModel.Text = ""
        txtpanelid.Text = ""
        txtpanelIDLCM.Text = ""
        TxtSet.Text = ""
        txtModel.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Update12A()
        _Refresh11()

    End Sub

    Private Sub dg1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellContentClick
        txtModel.Text = dg1.Item(0, dg1.CurrentRow.Index).Value
        TxtSet.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
        txtpanelid.Text = dg1.Item(2, dg1.CurrentRow.Index).Value
        txtpanelIDLCM.Text = dg1.Item(3, dg1.CurrentRow.Index).Value
        'GroupBox1.Enabled = True
        'GroupBox5.Enabled = False
        'txtModel.Enabled = False
        'TxtSet.Enabled = False
        'txtpanelid.Enabled = False

        txtModel.Focus()
    End Sub
End Class