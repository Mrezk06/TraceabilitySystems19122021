Imports TEVPBarcode.sher
Imports System.Data.SqlClient
Public Class frmPWH

    Private Sub frmPWH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += " SELECT  f_Code, f_Name FROM   C_Part_Desc "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "C_Part_Desc")

            txtpart.DataSource = ds.Tables(0)
            txtpart.ValueMember = "f_Code"
            txtpart.DisplayMember = "f_Name"
            txtpart.Sorted = True

            ' _Refresh1()
        Catch ex As Exception

        End Try
    End Sub

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
                '  lbl_Msg.ForeColor = Color.Red
                MsgBox(" غير  مصرح بالدخول ")
                Console.Beep()
                txtParts1.Focus()
                txtParts1.SelectAll()
                Exit Sub
            Else
                '  _Refresh315()
                ' lbl_Msg.ForeColor = Color.Green
                ' MsgBox("مرحبا بك فى برنامج مصنع البتوجاز لمتابعة الانتاج ")
                GroupBox10.Enabled = False
                ' txtline.Enabled = False
                GroupBox11.Enabled = True
                'GroupBox2.Visible = True
                ''txtshift.Visible = False
                'Button2.Visible = False
                'txtParts1.Visible = False
                'Label10.Visible = False
                txtpo.Focus()
                _RefreshDm()
                _RefreshDd()
                _RefreshDp()
                'Me.BackColor = Color.YellowGreen
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtpart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtpart.SelectedIndexChanged
        Try
            lblpart.Text = txtpart.SelectedValue.ToString
            '  Label2.Text = cmb_Pcode.Text
            '  txtFATSERIAL.Enabled = True
            '  _Refresh1()
        Catch ex As Exception

        End Try
    End Sub
    Private Function _RefreshDp() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT f_Code,sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_WHP"
            sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " group by f_Code"
            '    sql += " and f_Code='" & lblpart.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_WHP")
            ds.Tables("C_part_WHP").Columns(0).ColumnName = "Part code"
            ds.Tables("C_part_WHP").Columns(1).ColumnName = "QTY"
            dgwp.DataSource = ds.Tables("C_part_WHP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDm() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_WHP"
            sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_WHP")
            ds.Tables("C_part_WHP").Columns(0).ColumnName = "QTY"
            DGDM.DataSource = ds.Tables("C_part_WHP")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_WHP"
            sql += " where f_Date >=Convert(nvarchar(10), GETDATE(), 121)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_WHP")
            ds.Tables("C_part_WHP").Columns(0).ColumnName = "QTY"
            DGDd.DataSource = ds.Tables("C_part_WHP")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            ' If e.KeyCode = Keys.Enter Then
            ' If txtstatus.Text = "ok" Then
            Dim sql As String
            sql = " INSERT INTO C_part_WHP "
            sql += "(f_Code, f_PO, f_User, f_Qty)"
            sql += " VALUES ('" & lblpart.Text & "','" & txtpo.Text & "'," & txtParts1.Text & "," & txtqty.Text & ")"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            Label4.ForeColor = Color.GreenYellow
            Label4.Text = "Done"
            txtqty.Text = ""
            '  txtFATSERIAL.Enabled = True
            txtqty.Focus()
            txtqty.SelectAll()
            '_Refreshpd()
            '_Refreshpm()
            '_RefreshRd()
            '_RefreshRm()
            _RefreshDd()
            _RefreshDm()
            '   End If

            _RefreshDm()
            _RefreshDd()
            _RefreshDp()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged

    End Sub
End Class