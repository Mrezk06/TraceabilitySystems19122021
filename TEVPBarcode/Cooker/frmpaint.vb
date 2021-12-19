'Imports System.Collections.ObjectModel
'Imports System.Windows.Forms.DataVisualization.Charting
Imports TEVPBarcode.sher
Imports System.Data.SqlClient
'Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmpaint
    Private Function _Refreshpmt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum( f_Qty)"
            sql += " FROM barcode.dbo.C_part_paint"
            sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and f_Prosess='" & txtpresier.Text & "'"
            'sql += " and f_Code='" & lblpart.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_paint")
            ds.Tables("C_part_paint").Columns(0).ColumnName = "QTY"
            d1.DataSource = ds.Tables("C_part_paint")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshpdt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum( f_Qty)"
            sql += " FROM barcode.dbo.C_part_paint"
            sql += " where f_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and f_Prosess='" & txtpresier.Text & "'"
            'sql += " and f_Code='" & lblpart.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_paint")
            ds.Tables("C_part_paint").Columns(0).ColumnName = "QTY"
            d2.DataSource = ds.Tables("C_part_paint")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
                GroupBox10.Enabled = False

                GroupBox11.Enabled = True
                txtpo.Focus()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Function _Refreshpm() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum( f_Qty)"
            sql += " FROM barcode.dbo.C_part_paint"
            sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_paint")
            ds.Tables("C_part_paint").Columns(0).ColumnName = "QTY"
            DGTM.DataSource = ds.Tables("C_part_paint")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshRm() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_repair"
            sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_dept='PAINT'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_repair")
            ds.Tables("C_part_repair").Columns(0).ColumnName = "QTY"
            DGAM.DataSource = ds.Tables("C_part_repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDm() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_defects"
            sql += " where f_Date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_dept='PAINT'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_defects")
            ds.Tables("C_part_defects").Columns(0).ColumnName = "QTY"
            DGDM.DataSource = ds.Tables("C_part_defects")
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
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_dept='PAINT'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_defects")
            ds.Tables("C_part_defects").Columns(0).ColumnName = "QTY"
            DGDd.DataSource = ds.Tables("C_part_defects")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshRd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum(f_Qty)"
            sql += " FROM barcode.dbo.C_part_repair"
            sql += " where f_Date >=Convert(nvarchar(10), GETDATE(), 121)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            sql += " and f_dept='PAINT'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_repair")
            ds.Tables("C_part_repair").Columns(0).ColumnName = "QTY"
            DGRV.DataSource = ds.Tables("C_part_repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshpd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT sum( f_Qty)"
            sql += " FROM barcode.dbo.C_part_paint"
            sql += " where f_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and f_Prosess='" & txtpresier.Text & "'"
            sql += " and f_Code='" & lblpart.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_part_paint")
            ds.Tables("C_part_paint").Columns(0).ColumnName = "QTY"
            pd.DataSource = ds.Tables("C_part_paint")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmpaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ' _Refresh1()
        Catch ex As Exception

        End Try
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
        '    lblds.Text = txtco.Text
        _Refreshpd()
        _Refreshpm()
        _RefreshRd()
        _RefreshRm()
        _RefreshDd()
        _RefreshDm()
        _Refreshpdt()
        _Refreshpmt()
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
            ' lblds.Text = txtco.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtNum.SelectedIndexChanged

    End Sub

    Private Sub txtstatus_KeyDown(sender As Object, e As KeyEventArgs) Handles txtstatus.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtstatus.Text = "ok" Then
                    Dim sql As String
                    sql = " INSERT INTO C_part_paint "
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
                    _RefreshRd()
                    _RefreshRm()
                    _RefreshDd()
                    _RefreshDm()
                    _Refreshpdt()
                    _Refreshpmt()
                    '   End If
                ElseIf txtstatus.Text = "NG" Then

                    Dim sql As String
                    sql = " INSERT INTO C_part_defects "
                    sql += "(f_Code, f_PO, f_Prosess, f_Qty, f_User, f_Note,f_dept)"
                    sql += " VALUES ('" & lblpart.Text & "','" & txtpo.Text & "','" & txtpresier.Text & "','1'," & txtParts1.Text & ",'" & txtNote.Text & "','PAINT')"
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
                    _RefreshRd()
                    _RefreshRm()
                    _RefreshDd()
                    _RefreshDm()
                    _Refreshpdt()
                    _Refreshpmt()
                ElseIf txtstatus.Text = "RE" Then
                    Dim sql As String
                    sql = " INSERT INTO C_part_repair "
                    sql += "(f_Code, f_PO, f_Prosess, f_Qty, f_User, f_Note,f_dept)"
                    sql += " VALUES ('" & lblpart.Text & "','" & txtpo.Text & "','" & txtpresier.Text & "','1'," & txtParts1.Text & ",'" & txtNote.Text & "','PAINT')"
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
                    _RefreshRd()
                    _RefreshRm()
                    _RefreshDd()
                    _RefreshDm()


                    txtstatus.Focus()
                    txtstatus.SelectAll()
                    _Refreshpd()
                    _Refreshpm()
                    _RefreshRd()
                    _RefreshRm()
                    _RefreshDd()
                    _RefreshDm()
                    _Refreshpdt()
                    _Refreshpmt()
                ElseIf txtstatus.Text = "NOTE" Then
                    gb.Visible = True
                    txtstatus.Text = ""
                    txtNote.Focus()

                    _Refreshpd()
                    _Refreshpm()
                    _RefreshRd()
                    _RefreshRm()
                    _RefreshDd()
                    _RefreshDm()
                    _Refreshpdt()
                    _Refreshpmt()
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

    Private Sub txtstatus_TextChanged(sender As Object, e As EventArgs) Handles txtstatus.TextChanged

    End Sub

    Private Sub txtco_KeyDown(sender As Object, e As KeyEventArgs) Handles txtco.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' If txtstatus.Text = "ok" Then
            Dim sql As String
            sql = " INSERT INTO C_part_paint "
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
            _RefreshRd()
            _RefreshRm()
            _RefreshDd()
            _RefreshDm()
            _Refreshpdt()
            _Refreshpmt()
            ' Try


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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox11.Enabled = True
        txtpo.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox10.Enabled = True
        txtParts1.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
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
                'Me.BackColor = Color.YellowGreen
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox13_Enter(sender As Object, e As EventArgs) Handles GroupBox13.Enter

    End Sub
End Class