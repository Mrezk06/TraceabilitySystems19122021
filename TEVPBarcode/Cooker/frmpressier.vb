Imports TEVPBarcode.sher
Imports System.Data.SqlClient
Imports System.IO.Ports

Public Class frmpressier
    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Function _Refreshpm() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum( f_Qty)"
            sql += " FROM barcode.dbo.C_part_production"
            sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_PO = '" & txtpo.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_production")
            ds.Tables("C_part_production").Columns(0).ColumnName = "QTY"
            DGTM.DataSource = ds.Tables("C_part_production")
            Return True
        Catch ex As Exception
        End Try
    End Function

    'Private Function _RefreshRm() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += " SELECT sum(f_Qty)"
    '        sql += " FROM barcode.dbo.C_part_repair"
    '        sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
    '        sql += " and f_Prosess='" & txtpresier.Text & "'"
    '        sql += " and f_Code='" & lblpart.Text & "'"
    '        sql += " and f_dept='PRE'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "C_part_repair")
    '        ds.Tables("C_part_repair").Columns(0).ColumnName = "QTY"
    '        DGAM.DataSource = ds.Tables("C_part_repair")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _RefreshDm() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_defects"
            '  sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            sql += " where f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_PO='" & txtpo.Text & "'"
            sql += " and f_dept='PRE'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_defects")
            ds.Tables("C_part_defects").Columns(0).ColumnName = "QTY"
            DGDM.DataSource = ds.Tables("C_part_defects")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDm22() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_defects"
            '  sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            sql += " where f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_PO='" & txtpo.Text & "'"
            sql += " and f_dept='PRE'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_defects")
            ds.Tables("C_part_defects").Columns(0).ColumnName = "QTY"
            dgs.DataSource = ds.Tables("C_part_defects")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_defects"
            sql += " where f_Date >=Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_PO='" & txtpo.Text & "'"
            sql += " and f_dept='PRE'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_defects")
            ds.Tables("C_part_defects").Columns(0).ColumnName = "QTY"
            DGDd.DataSource = ds.Tables("C_part_defects")
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Function _RefreshRd() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += " SELECT sum(f_Qty)"
    '        sql += " FROM barcode.dbo.C_part_repair"
    '        sql += " where f_Date >=Convert(nvarchar(10), GETDATE(), 121)"
    '        sql += " and f_Prosess='" & txtpresier.Text & "'"
    '        sql += " and f_Code='" & lblpart.Text & "'"
    '        sql += " and f_dept='PRE'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "C_part_repair")
    '        ds.Tables("C_part_repair").Columns(0).ColumnName = "QTY"
    '        DGRV.DataSource = ds.Tables("C_part_repair")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refreshpd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum( f_Qty)"
            sql += " FROM barcode.dbo.C_part_production"
            sql += " where f_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_PO = '" & txtpo.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_production")
            ds.Tables("C_part_production").Columns(0).ColumnName = "QTY"
            pd.DataSource = ds.Tables("C_part_production")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Dim dd As New Integer


    Private Sub frmpressier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Catch ex As Exception
        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT  f_ID, f_Name FROM   C_BoxDesc "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "C_BoxDesc")
            txtbox.DataSource = ds.Tables(0)
            txtbox.ValueMember = "f_ID"
            txtbox.DisplayMember = "f_Name"
            txtbox.Sorted = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtParts1.Text.Length < 8 Then Exit Sub
            Dim dsMax As New DataSet
            Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap "
            Sql += " where Heater_Sap_Laber='" & txtParts1.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count < 1 Then
                MsgBox(" غير  مصرح بالدخول ")
                Console.Beep()
                txtParts1.Focus()
                txtParts1.SelectAll()
                Exit Sub
            Else
                GroupBox10.Enabled = False
                GroupBox11.Enabled = True
                txtpo.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox10.Enabled = True
        txtParts1.Focus()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox11.Enabled = True
        txtpo.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtpo.Text = "" Or txtpart.Text = "" Or txtbox.Text = "" Then
            MsgBox("من فضلك ادخل البيانات بطريقه صحيحه")
            txtpo.Focus()
        Else
            txtstatus.Focus()
            GroupBox12.Enabled = True
            GroupBox11.Enabled = False

            Try
                Dim sql As String = ""
                sql += " SELECT  f_QTY FROM [barcode].[dbo].[C_BoxWithPart] "
                sql += " where f_Code ='" & lblpart.Text & "'"
                sql += " and f_B_ID =" & lblbox.Text & ""
                Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
                ds.Tables.Clear()
                da.Fill(ds, "BoxWithPart")

                txtco.DataSource = ds.Tables(0)
                '  txtpart.ValueMember = "f_Code"
                txtco.DisplayMember = "f_QTY"
                txtco.Sorted = True

                '   Label4.Text = txtco.Text
                ' _Refresh1()
            Catch ex As Exception

            End Try

        End If
        lblds.Text = txtco.Text
        _Refreshpd()
        _Refreshpm()
        _Refresh11d20()
        '    _RefreshRd()
        '    _RefreshRm()
        _RefreshDd()
        _RefreshDm()
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

    Private Sub txtbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtbox.SelectedIndexChanged
        Try
            lblbox.Text = txtbox.SelectedValue.ToString
            '  Label2.Text = cmb_Pcode.Text
            '  txtFATSERIAL.Enabled = True
            '  _Refresh1()
            lblds.Text = txtco.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Leave(sender As Object, e As EventArgs) Handles Button2.Leave
        'Try
        '    txtco.Text = Label4.Text
        'Catch ex As Exception

        'End Try
    End Sub
    Private Function _Refresh11d20() As Boolean
        Try
            Dim sql1 As String = "SELECT  CQty FROM   barcode.dbo.CPlanDaliypressure"
            sql1 += " WHERE CpressureID='" & txtpresier.Text & "'"
            sql1 += " and CPartName='" & txtpart.Text & "'"
            sql1 += " and CPO = '" & txtpo.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "CPlanDaliypressure")
            ds.Tables("CPlanDaliypressure").Columns(0).ColumnName = "Qty"
            dff.DataSource = ds.Tables("CPlanDaliypressure")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub lblds_Click(sender As Object, e As EventArgs) Handles lblds.Click

    End Sub

    Private Sub txtstatus_KeyDown(sender As Object, e As KeyEventArgs) Handles txtstatus.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtstatus.Text = "ok" Then
                    Dim sql As String
                    sql = " INSERT INTO C_part_production "
                    sql += "(f_Code, f_PO, f_Qty, f_User, f_Prosess,f_Note)"
                    sql += " VALUES ('" & lblpart.Text & "','" & txtpo.Text & "'," & txtco.Text & "," & txtParts1.Text & ",'" & txtpresier.Text & "','" & txtNote.Text & "')"
                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    Label4.ForeColor = Color.GreenYellow
                    Label4.Text = "Done"
                    txtNote.Text = ""
                    '  txtFATSERIAL.Enabled = True
                    txtstatus.Focus()
                    txtstatus.SelectAll()
                    _Refreshpd()
                    _Refreshpm()
                    _Refresh11d20()
                    '_RefreshRd()
                    '               _RefreshRm()
                    _RefreshDd()
                    _RefreshDm()
                    '   End If
                ElseIf txtstatus.Text = "NG" Then

                    Dim sql As String
                    sql = " INSERT INTO C_part_defects "
                    sql += "(f_Code, f_PO, f_Prosess, f_Qty, f_User, f_Note,f_dept)"
                    sql += " VALUES ('" & lblpart.Text & "','" & txtpo.Text & "','" & txtpresier.Text & "','1'," & txtParts1.Text & ",'" & txtNote.Text & "','PRE')"
                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    Label4.ForeColor = Color.GreenYellow
                    Label4.Text = "Done"
                    txtNote.Text = ""
                    '  txtFATSERIAL.Enabled = True
                    txtstatus.Focus()
                    txtstatus.SelectAll()
                    _Refreshpd()
                    _Refreshpm()
                    _RefreshDm22()
                    ' _RefreshRd()
                    _Refresh11d20()
                    '              _RefreshRm()
                    _RefreshDd()
                    _RefreshDm()
                ElseIf txtstatus.Text = "RE" Then
                    Dim sql As String
                    sql = " INSERT INTO C_part_repair "
                    sql += "(f_Code, f_PO, f_Prosess, f_Qty, f_User, f_Note,f_dept)"
                    sql += " VALUES ('" & lblpart.Text & "','" & txtpo.Text & "','" & txtpresier.Text & "','1'," & txtParts1.Text & ",'" & txtNote.Text & "','PRE')"
                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    Label4.ForeColor = Color.GreenYellow
                    Label4.Text = "Done"
                    txtNote.Text = ""
                    txtstatus.Focus()
                    txtstatus.SelectAll()
                    _Refreshpd()
                    _Refreshpm()
                    _Refresh11d20()
                    _RefreshDd()
                    _RefreshDm()
                    txtstatus.Focus()
                    txtstatus.SelectAll()
                    _Refreshpd()
                    _Refreshpm()
                    _RefreshDd()
                    _RefreshDm()
                ElseIf txtstatus.Text = "NOTE" Then
                    gb.Visible = True
                    txtstatus.Text = ""
                    txtNote.Focus()
                    _Refreshpd()
                    _Refreshpm()
                    _RefreshDd()
                    _RefreshDm()
                ElseIf txtstatus.Text = "New" Then
                    GroupBox11.Enabled = True
                    txtco.Focus()
                    txtstatus.Text = ""
                Else
                    Label4.ForeColor = Color.Red
                    Label4.Text = "NG"
                    MsgBox("من فضلك تاكد من صحة ادخال البيانات ")
                    txtstatus.Focus()
                    txtstatus.SelectAll()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtstatus_KeyUp(sender As Object, e As KeyEventArgs) Handles txtstatus.KeyUp
        GroupBox11.Enabled = False
    End Sub

    Private Sub txtstatus_TextChanged(sender As Object, e As EventArgs) Handles txtstatus.TextChanged

    End Sub

    Private Sub txtNote_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNote.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txtstatus.Focus()
                gb.Visible = False

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote.TextChanged

    End Sub

    Private Sub txtco_KeyDown(sender As Object, e As KeyEventArgs) Handles txtco.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' If txtstatus.Text = "ok" Then
            Dim sql As String
            sql = " INSERT INTO C_part_production "
            sql += "(f_Code, f_PO, f_Qty, f_User, f_Prosess,f_Note)"
            sql += " VALUES ('" & lblpart.Text & "','" & txtpo.Text & "'," & txtco.Text & "," & txtParts1.Text & ",'" & txtpresier.Text & "','" & txtNote.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            Label4.ForeColor = Color.GreenYellow
            Label4.Text = "Done"
            txtNote.Text = ""

            GroupBox11.Enabled = True
            txtstatus.Focus()
            txtstatus.SelectAll()
            _Refreshpd()
            _Refreshpm()
            ' _RefreshRd()
            '   _RefreshRm()
            _RefreshDd()
            _RefreshDm()
            ' Try

            _Refresh11d20()
            '   Label4.Text = txtco.Text
            ' _Refresh1()

        End If
        'End If

    End Sub

    Private Sub txtco_Leave(sender As Object, e As EventArgs) Handles txtco.Leave
        Try
            Dim sql2 As String = ""
            sql2 += " SELECT  f_QTY FROM [barcode].[dbo].[C_BoxWithPart] "
            sql2 += " where f_Code ='" & lblpart.Text & "'"
            sql2 += " and f_B_ID =" & lblbox.Text & ""
            Dim da As New SqlClient.SqlDataAdapter(sql2, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "BoxWithPart")

            txtco.DataSource = ds.Tables(0)
            '  txtpart.ValueMember = "f_Code"
            txtco.DisplayMember = "f_QTY"
            txtco.Sorted = True
            ' GroupBox11.Enabled = False

        Catch ex As Exception

        End Try
        GroupBox11.Enabled = False
    End Sub

    Private Sub txtco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtco.SelectedIndexChanged

    End Sub

    Private Sub txtNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtNum.SelectedIndexChanged

    End Sub

    Private Sub gb_Enter(sender As Object, e As EventArgs) Handles gb.Enter

    End Sub
End Class