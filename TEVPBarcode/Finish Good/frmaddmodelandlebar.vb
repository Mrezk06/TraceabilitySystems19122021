Imports TEVPBarcode.sher
Public Class frmaddmodelandlebar
    Private Sub btnAddSetID_Click(sender As Object, e As EventArgs) Handles btnAddSetID.Click
        Add1_New()
        _Refresh1()
    End Sub
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Del_Rec()
        _Refresh1()
    End Sub
    Private Function Del_Rec() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM LCDTVModels"
            sql += " where fLCDSetID ='" & TxtSet.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtS_Laber.Text.Length < 8 Then
            MsgBox("Please check the SAP employee must be comprised of 8 digits")
            txtS_Laber.Focus()
            txtS_Laber.SelectAll()
        Else
            Add1_New12()
            _Refresh315()
            txtS_Laber.Text = ""
            TxtN_Laber.Text = ""
        End If
    End Sub
    Private Function Add1_New12() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO Heater_Name_Sap "
            sql += "(Heater_Name_Laber,Heater_Sap_Laber)"
            sql += " VALUES ('" & TxtN_Laber.Text & "','" & txtS_Laber.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber,Heater_Sap_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            ' sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "Name Laber "
            ds.Tables("Heater_Name_Sap").Columns(1).ColumnName = "Sap Laber "
            dg.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmaddmodelandlebar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EighteenColor1.ssk"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmshow_plan
        frm.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmAddData
        frm.Show()

    End Sub
End Class