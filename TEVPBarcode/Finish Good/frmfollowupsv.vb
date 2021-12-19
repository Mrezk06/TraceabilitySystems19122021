Imports TEVPBarcode.sher

Public Class frmfollowupsv

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'txtFATSERIAL.Enabled = True
        'cmb_Pcode.Enabled = True
        'txtDelete.Enabled = True


        If txtS_Laber.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtS_Laber.Text & "'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count < 1 Then
            'lbl_Msg.ForeColor = Color.Red
            MsgBox(" Sap Number Wrong ")
            txtS_Laber.Focus()
            txtS_Laber.SelectAll()
            Exit Sub
        Else
            _Refresh315()
            'dd.Visible = True
            'df.Visible = False
            df.Enabled = False
            dx.Enabled = True

            'lbl_Msg.ForeColor = Color.Green
            'MsgBox(" تق")
            'cmb_Pcode.Enabled = True
            '' txtline.Enabled = False
            'txtshift.Enabled = True
            'GroupBox2.Visible = True
            ''txtshift.Visible = False
            'Button2.Visible = False
            'txtParts1.Visible = False
            'Label10.Visible = False
            txtsvn.Focus()
            'Me.BackColor = Color.YellowGreen

        End If

        '_Refresh1()
        '_Refresh13()
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & txtS_Laber.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "Name responsible"

            dgv.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub frmfollowupsv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dx.Enabled = False
        txtS_Laber.Focus()


        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM   LCDTVModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.ValueMember = "fLCDSetID"
            cmb_Pcode.DisplayMember = "fLCDModelName"
            cmb_Pcode.Sorted = True
        Catch ex As Exception
        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT  f_id,f_name FROM   followup_SVN "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "followup_SVN")
            txtsvn.DataSource = ds.Tables(0)
            txtsvn.ValueMember = "f_id"
            txtsvn.DisplayMember = "f_name"
            txtsvn.Sorted = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString
            ' Label2.Text = cmb_Pcode.Text

        Catch ex As Exception
        End Try
    End Sub
    Private Function Update11A2() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  followupSV set"
            sql += " fQTYA = " & txtqtya.Text & ","
            sql += " fQTYD = " & txtqtyd.Text & ""
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " WHERE fPDate >= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += " and fLineAndShift ='" & cmb_Pcode3.Text & "'"
            sql += " and fModelName ='" & cmb_Pcode.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO followupSV "
            sql += "(fDate, fSVNAME, fSVNUM, fModelName, fLineAndShift, fSap_L, fQTYA, fQTYD)"
            sql += " VALUES ('" & Format(dtbfrom.Value, "yyyy-MM-dd") & "','" & txtsvn.Text & "','" & txtsvnum.Text & "','" & cmb_Pcode.Text & "','" & cmb_Pcode3.Text & "','" & txtS_Laber.Text & "'," & txtqtya.Text & "," & txtqtyd.Text & ")"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql1 As String = "SELECT  fDate, fSVNAME, fSVNUM, fModelName, fLineAndShift, fSap_L, fQTYA, fQTYD FROM followupSV"
            sql1 += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "followupSV")
            ds.Tables("followupSV").Columns(0).ColumnName = "date"
            ds.Tables("followupSV").Columns(1).ColumnName = "S.V Name"
            ds.Tables("followupSV").Columns(2).ColumnName = "S.V ID"
            ds.Tables("followupSV").Columns(3).ColumnName = "Model name"
            ds.Tables("followupSV").Columns(4).ColumnName = "LCD Set ID"
            ds.Tables("followupSV").Columns(5).ColumnName = "LCD Model Name"
            ds.Tables("followupSV").Columns(6).ColumnName = "fpanelID"
            ds.Tables("followupSV").Columns(7).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("followupSV")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh1()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Del_Rec()
        _Refresh1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Update11A2()
        _Refresh1()
    End Sub

    Private Sub btnAddSetID_Click(sender As Object, e As EventArgs) Handles btnAddSetID.Click
        Add1_New()
        _Refresh1()

    End Sub
    Private Function Del_Rec() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM followupSV"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLineAndShift ='" & cmb_Pcode3.Text & "'"
            sql += " and fModelName ='" & cmb_Pcode.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtsvn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsvn.SelectedIndexChanged
        Try
            txtsvnum.Text = txtsvn.SelectedValue.ToString
  
        Catch ex As Exception
        End Try
    End Sub
End Class