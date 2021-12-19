Imports TEVPBarcode.sher
Public Class frmATPM

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtParts1.Text.Length < 8 Then Exit Sub

            Dim dsMax As New DataSet
            Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap "
            Sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            '   Sql += " and Heater_sap_stu='Active'"
            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count < 1 Then
                ' lbl_Msg.ForeColor = Color.Red
                MsgBox(" غير  مصرح بالدخول ")
                Console.Beep()
                txtParts1.Focus()
                txtParts1.SelectAll()
                Exit Sub
            Else
                _Refresh315()
                'lbl_Msg.ForeColor = Color.Green
                MsgBox("مرحبا بك فى برنامج مصنع البتوجاز لمتابعة الانتاج ")
                'cmb_Pcode.Enabled = True
                '' txtline.Enabled = False
                'txtline1.Enabled = True
                GroupBox3.Enabled = True
                GroupBox1.Enabled = True
                GroupBox2.Visible = True
                Button1.Visible = False
                txtParts1.Visible = False
                Label10.Visible = False
                txtMN.Focus()
                'Me.BackColor = Color.YellowGreen
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = " الفنى المسئول"

            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmATPM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtParts1.Focus()

        GroupBox3.Enabled = False
        GroupBox1.Enabled = False
        Try
            Dim sql As String = ""
            sql += "SELECT CModelName FROM CModels"
            '  sql += " where fLine_Name ='EWH1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")

            txtMN.DataSource = ds.Tables(0)
            ' cmb_Pcode.ValueMember = "CSetID"
            ' cmb_Pcode.ValueMember = "model_S_Power"
            txtMN.DisplayMember = "CModelName"
            txtMN.Sorted = True

            '  _Refresh1()
        Catch ex As Exception

        End Try
        Try
            Dim sql As String = ""
            sql += "SELECT f_Name,f_Code FROM C_Part_Desc"
            '  sql += " where fLine_Name ='EWH1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "C_Part_Desc")

            txtPN.DataSource = ds.Tables(0)
            txtPN.ValueMember = "f_Code"
            ' cmb_Pcode.ValueMember = "model_S_Power"
            txtPN.DisplayMember = "f_Name"
            txtPN.Sorted = True

            '  _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtPN.SelectedIndexChanged
        Try
            ' Dim tf As String

            lbl_Pcode_Value.Text = txtPN.SelectedValue.ToString


        Catch ex As Exception

        End Try
    End Sub
    Private Function Add1_New12() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.C_PPHT "
            sql += "( P_PN, P_QTY, P_PWID, P_UID,P_PO)"
            sql += " VALUES ('" & txtPN.Text & "'," & txtPQ.Text & ",'" & txtPress.Text & "'," & txtParts1.Text & ",'" & txtPO.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec12() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[C_PPHT]"
            sql += " where P_PN ='" & txtPN.Text & "'"
            sql += " and P_PWID ='" & txtPress.Text & "'"
            sql += " and P_PO ='" & txtPO.Text & "'"

            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update11A2() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  C_PPHT set"
            sql += " P_QTY = " & txtPQ.Text & ","
            sql += " P_UID = " & txtParts1.Text & ""
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where P_PN ='" & txtPN.Text & "'"
            sql += " and P_PWID ='" & txtPress.Text & "'"
            sql += " and P_PO ='" & txtPO.Text & "'"
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh112() As Boolean
        Try

            Dim sql1 As String = "SELECT    P_date, P_PN, P_QTY, P_PWID, P_UID,P_PO FROM C_PPHT"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'" sql += " and P_PO ='" & txtPO.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_PPHT")
            ds.Tables("C_PPHT").Columns(0).ColumnName = "date"
            ds.Tables("C_PPHT").Columns(1).ColumnName = "part Name"
            ds.Tables("C_PPHT").Columns(2).ColumnName = "Qty"
            ds.Tables("C_PPHT").Columns(3).ColumnName = "Pressier "
            ds.Tables("C_PPHT").Columns(4).ColumnName = "User ID"
            ds.Tables("C_PPHT").Columns(5).ColumnName = "P / O"
            dg.DataSource = ds.Tables("C_PPHT")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Del_Rec12()
        _Refresh112()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Update11A2()
        _Refresh112()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Add1_New12()
        _Refresh112()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Add1_New122()
        _Refresh1122()
    End Sub
    Private Function Add1_New122() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.C_MPHT "
            sql += "(  M_MN, M_Line, M_QTY, M_UID )"
            sql += " VALUES ('" & txtMN.Text & "','" & txtLine.Text & "'," & txtMQ.Text & "," & txtParts1.Text & ")"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec122() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[C_MPHT]"
            sql += " where M_MN ='" & txtMN.Text & "'"
            sql += " and M_Line ='" & txtLine.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update11A22() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  C_MPHT set"
            sql += " M_QTY = " & txtMQ.Text & ","
            sql += " M_UID = " & txtParts1.Text & ""
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where M_MN ='" & txtMN.Text & "'"
            sql += " and M_Line ='" & txtLine.Text & "'"
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1122() As Boolean
        Try

            Dim sql1 As String = "SELECT    M_Date, M_MN, M_Line, M_QTY, M_UID FROM C_MPHT"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_MPHT")
            ds.Tables("C_MPHT").Columns(0).ColumnName = "date"
            ds.Tables("C_MPHT").Columns(1).ColumnName = "Model Name"
            ds.Tables("C_MPHT").Columns(2).ColumnName = "Line"
            ds.Tables("C_MPHT").Columns(3).ColumnName = "Qty "
            ds.Tables("C_MPHT").Columns(4).ColumnName = "User ID"
            dg.DataSource = ds.Tables("C_MPHT")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Del_Rec122()
        _Refresh1122()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Update11A22()
        _Refresh1122()
    End Sub
End Class