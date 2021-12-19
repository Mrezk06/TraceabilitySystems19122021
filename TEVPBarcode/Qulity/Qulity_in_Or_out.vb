Imports System.ComponentModel
Imports TEVPBarcode.sher
Public Class Qulity_in_Or_out




    'Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            If txtFATSERIAL.Text.Length < 14 Then Exit Sub
    '            Dim dsMax As New DataSet
    '            Dim Sql = "SELECT fLCDBarcode  FROM  Output where fLCDBarcode='" & txtFATSERIAL.Text & "'"
    '            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
    '            dsMax.Tables.Clear()
    '            da.Fill(dsMax)
    '            If dsMax.Tables(0).Rows.Count > 0 Then
    '                lbl_Msg.ForeColor = Color.Red
    '                lbl_Msg.Text = "هذا السيريال تم تسجيله من قبل"
    '                txtFATSERIAL.Focus()
    '                txtFATSERIAL.SelectAll()
    '                Exit Sub
    '            End If
    '        End If
    '        Dim Barcode_Part(6) As String
    '        Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
    '        Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 2)
    '        Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
    '        Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
    '        Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
    '        Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
    '        Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)
    '        If Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
    '            lbl_Msg.Text = "السريال مالهوش علاقه بالموديل اللي حضرتك مختره يا كابتن"
    '            lbl_Msg.ForeColor = Color.Yellow
    '            txtFATSERIAL.Focus()
    '            txtFATSERIAL.SelectAll()
    '        Else

    '            ' insert the barcode  in database
    '            Dim sql As String
    '            Sql = "INSERT INTO Output"
    '            Sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID, fNameL)"
    '            Sql += "VALUES     ('"
    '            Sql += txtFATSERIAL.Text & "',"
    '            For i As Integer = 0 To Barcode_Part.Length - 1
    '                Sql += "'" & Barcode_Part(i) & "',"

    '            Next
    '            'Sql += "'" & cmb_Pcode.Text & "',"
    '            'Sql += "'" & txtPARTSSERIAL.Text & "',"
    '            'Sql += "'" & txtPARTSSERIAL.Text & "',"
    '            Sql += "'" & cmb_Pcode.Text & "')"


    '            Dim cmd As New SqlClient.SqlCommand(Sql, cn)
    '            If cn.State = ConnectionState.Closed Then cn.Open()
    '            cmd.ExecuteNonQuery()
    '            cn.Close()
    '            txtFATSERIAL.Focus()
    '            lbl_Msg.ForeColor = Color.GreenYellow
    '            lbl_Msg.Text = "تم ادخال السريال بنجاح"

    '            _Refresh1()
    '            _Refresh13()



    '        End If


    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub txtFATSERIAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFATSERIAL.KeyDown
        Try



            If e.KeyCode = Keys.Enter Then


                If txtFATSERIAL.Text.Length = 16 Then

                    If e.KeyCode = Keys.Enter Then
                        '     If txtFATSERIAL.Text.Length <> 16 Then Exit Sub
                        'If txtFATSERIAL.Text.Length > 14 Then Exit Sub
                        Dim dsMax As New DataSet
                        Dim Sql1 = "SELECT fLCDBarcode,qultyinorout  FROM  OutputQ where fLCDBarcode='" & txtFATSERIAL.Text & "'"
                        Sql1 += " and qultyinorout='in'"

                        Dim da As New SqlClient.SqlDataAdapter(Sql1, cn)
                        dsMax.Tables.Clear()
                        da.Fill(dsMax)
                        If dsMax.Tables(0).Rows.Count > 0 Then
                            lbl_Msg.ForeColor = Color.Red
                            lbl_Msg.Text = "هذا السيريال تم تسجيله من قبل"
                            txtFATSERIAL.Focus()
                            txtFATSERIAL.SelectAll()
                            Exit Sub
                        End If
                        lbl_Msg.ForeColor = Color.Green

                        lbl_Msg.Text = "تم تسجيل الباركود الاول"
                        txtFATSERIAL.Enabled = False
                        txtsap.Focus()
                    End If
                    Dim Barcode_Part2(3) As String
                    Barcode_Part2(0) = txtFATSERIAL.Text.Substring(0, 8)
                    Barcode_Part2(1) = txtFATSERIAL.Text.Substring(8, 1)
                    Barcode_Part2(2) = txtFATSERIAL.Text.Substring(9, 7)
                    'Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
                    'Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
                    'Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                    'Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
                    'Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 4)

                Else

                    If txtFATSERIAL.Text.Length < 14 Then Exit Sub
                    If txtFATSERIAL.Text.Length > 14 Then Exit Sub
                    Dim dsMax As New DataSet
                    Dim Sql1 = "SELECT fLCDBarcode,qultyinorout  FROM  OutputQ where fLCDBarcode='" & txtFATSERIAL.Text & "'"
                    Sql1 += " and qultyinorout='in'"

                    Dim da As New SqlClient.SqlDataAdapter(Sql1, cn)
                    dsMax.Tables.Clear()
                    da.Fill(dsMax)
                    If dsMax.Tables(0).Rows.Count > 0 Then
                        lbl_Msg.ForeColor = Color.Red
                        lbl_Msg.Text = "هذا السيريال تم تسجيله من قبل"
                        txtFATSERIAL.Focus()
                        txtFATSERIAL.SelectAll()
                        Exit Sub
                    End If
                    lbl_Msg.ForeColor = Color.Green

                    lbl_Msg.Text = "تم تسجيل الباركود الاول"
                    txtFATSERIAL.Enabled = False
                    txtsap.Focus()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub txtFATSERIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        txtFATSERIAL.Enabled = True
        txtDelete.Enabled = True
        cmb_Pcode3.Enabled = False
        txtsap.Enabled = True
        _Refresh1()
        _Refresh13()
        _Refresh1pp()
        _Refreshdddddd()
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_3"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fNameL ='" & cmb_Pcode3.Text & "'"

            sql += " and qultyinorout = 'in' "
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_3").Columns(1).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_3"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fNameL ='" & cmb_Pcode3.Text & "'"

            sql += " and qultyinorout = 'in' "
            ' sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية"

            dg5.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1pp() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_3"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fNameL ='" & cmb_Pcode3.Text & "'"

            sql += " and qultyinorout = 'out' "
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_3").Columns(1).ColumnName = " الكمية"
            DataGridView2.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshdddddd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_3"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fNameL ='" & cmb_Pcode3.Text & "'"

            sql += " and qultyinorout = 'out' "
            ' sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية "

            DataGridView1.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmOutp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFATSERIAL.Enabled = False
        txtDelete.Enabled = False
        txtsap.Enabled = False
        'Me.SkinEngine1.SkinFile = "Skins/DiamondPurple.ssk"
        _Refresh1()
        _Refresh13()
        _Refresh1pp()
        _Refreshdddddd()
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
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Close()
    'End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub cmb_Pcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Pcode.KeyDown

    End Sub

    Private Sub cmb_Pcode_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmb_Pcode.MouseDown

    End Sub
    Private Sub cmb_Pcode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged
        Try
            lbl_Pcode_Value.Text = cmb_Pcode.SelectedValue.ToString
            ' Label2.Text = cmb_Pcode.Text

        Catch ex As Exception
        End Try
    End Sub

    Private Sub lbl_Pcode_Value_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Pcode_Value.Click

    End Sub
    'Private Function Del_Rec() As Boolean
    '    Try
    '        'If e.KeyCode = Keys.Enter Then
    '        '      If txtFATSERIAL.Text.Length < 14 Then Exit Sub
    '        '      If txtFATSERIAL.Text.Length > 14 Then Exit Sub
    '        Dim dsMax As New DataSet
    '        Dim Sql = "SELECT fLCDBarcode,qultyinorout  FROM  OutputQ where fLCDBarcode='" & txtDelete.Text & "'"
    '        Sql += "and fLCDBarcode='out'"

    '        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
    '            dsMax.Tables.Clear()
    '            da.Fill(dsMax)
    '            If dsMax.Tables(0).Rows.Count > 0 Then
    '                lbl_Msg.ForeColor = Color.Red
    '                lbl_Msg.Text = "هذا السيريال تم تسجيله من قبل"
    '            txtDelete.Focus()
    '            txtDelete.SelectAll()
    '            'Exit Sub
    '        End If
    '        Dim Barcode_Part(6) As String
    '        Barcode_Part(0) = txtDelete.Text.Substring(0, 1)
    '        Barcode_Part(1) = txtDelete.Text.Substring(1, 2)
    '        Barcode_Part(2) = txtDelete.Text.Substring(3, 3)
    '        Barcode_Part(3) = txtDelete.Text.Substring(6, 1)
    '        Barcode_Part(4) = txtDelete.Text.Substring(7, 1)
    '        Barcode_Part(5) = txtDelete.Text.Substring(8, 4)
    '        Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)
    '        'Dim sql As String

    '        Sql = "INSERT INTO OutputQ"
    '        sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID, fNameL,qultyinorout)"
    '        sql += "VALUES     ('"
    '        sql += txtFATSERIAL.Text & "',"
    '        For i As Integer = 0 To Barcode_Part.Length - 1
    '            sql += "'" & Barcode_Part(i) & "',"

    '        Next
    '        sql += "'" & cmb_Pcode3.Text & "',"
    '        sql += "'in')"
    '        Dim cmd As New SqlClient.SqlCommand(sql, cn)
    '        If cn.State = ConnectionState.Closed Then
    '            cn.Open()
    '            cmd.ExecuteNonQuery()
    '            cn.Close()
    '            lbl_Msg.ForeColor = Color.GreenYellow
    '            lbl_Msg.Text = "تم حذف الجهاز  بنجاح"
    '            txtDelete.Focus()
    '            txtDelete.SelectAll()
    '            _Refresh1()
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Sub txtDelete_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDelete.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtDelete.Text.Length < 14 Then Exit Sub
                If txtDelete.Text.Length > 14 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql1 = "SELECT fLCDBarcode  FROM  OutputQ where fLCDBarcode='" & txtDelete.Text & "'"
                Sql1 += " and qultyinorout='out'"

                Dim da As New SqlClient.SqlDataAdapter(Sql1, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count > 0 Then
                    lbl_Msg.ForeColor = Color.Red
                    lbl_Msg.Text = "هذا السيريال تم تسجيله من قبل"
                    txtDelete.Focus()
                    txtDelete.SelectAll()
                    Exit Sub
                End If
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtDelete.Text.Substring(0, 1)
                Barcode_Part(1) = txtDelete.Text.Substring(1, 2)
                Barcode_Part(2) = txtDelete.Text.Substring(3, 3)
                Barcode_Part(3) = txtDelete.Text.Substring(6, 1)
                Barcode_Part(4) = txtDelete.Text.Substring(7, 1)
                Barcode_Part(5) = txtDelete.Text.Substring(8, 4)
                Barcode_Part(6) = txtDelete.Text.Substring(12, 2)

                Dim sql As String = ""
                sql = "INSERT INTO OutputQ"
                sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID, fNameL,qultyinorout)"
                sql += "VALUES     ('"
                sql += txtDelete.Text & "',"
                For i As Integer = 0 To Barcode_Part.Length - 1
                    sql += "'" & Barcode_Part(i) & "',"

                Next
                sql += "'" & cmb_Pcode3.Text & "',"
                sql += "'out')"

                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "تم رجوع الجهاز من الجوده "
                txtDelete.Text = ""
                txtDelete.Focus()
                txtDelete.SelectAll()
                _Refresh1pp()
                _Refreshdddddd()
            End If

            'End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDelete_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDelete.LocationChanged


    End Sub

    Private Sub txtDelete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelete.TextChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        Dim frm1 As New QueryforQulity
        frm1.Show()
    End Sub

    Private Sub dg2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg2.CellContentClick

    End Sub

    Private Sub dg2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg2.Click
        cmb_Pcode.Text = dg2.Item(0, dg2.CurrentRow.Index).Value
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtDelete_Validating(sender As Object, e As CancelEventArgs) Handles txtDelete.Validating

    End Sub

    Private Sub txtDelete_TextAlignChanged(sender As Object, e As EventArgs) Handles txtDelete.TextAlignChanged

    End Sub

    Private Sub txtDelete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDelete.KeyPress

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub cmb_Pcode3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode3.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New NotesForProblems
        frm.Show()

    End Sub

    Private Sub txtDelete_TabIndexChanged(sender As Object, e As EventArgs) Handles txtDelete.TabIndexChanged

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    'End Sub




    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtsap_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsap.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then
                Dim Barcode_Part(6) As String
                Barcode_Part(0) = txtFATSERIAL.Text.Substring(0, 1)
                Barcode_Part(1) = txtFATSERIAL.Text.Substring(1, 2)
                Barcode_Part(2) = txtFATSERIAL.Text.Substring(3, 3)
                Barcode_Part(3) = txtFATSERIAL.Text.Substring(6, 1)
                Barcode_Part(4) = txtFATSERIAL.Text.Substring(7, 1)
                Barcode_Part(5) = txtFATSERIAL.Text.Substring(8, 4)
                Barcode_Part(6) = txtFATSERIAL.Text.Substring(12, 2)
                'If Barcode_Part(2) <> cmb_Pcode.SelectedValue Then
                '    lbl_Msg.Text = "السريال مالهوش علاقه بالموديل اللي حضرتك مختره يا كابتن"
                '    Console.Beep()
                '    lbl_Msg.ForeColor = Color.Yellow
                '    txtFATSERIAL.Focus()
                '    txtFATSERIAL.SelectAll()
                'Else
                '    ' insert the barcode  in database

                Dim sql As String = ""
                sql = "INSERT INTO OutputQ"
                sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID, fNameL,qultyinorout,fSap)"
                sql += "VALUES     ('"
                sql += txtFATSERIAL.Text & "',"
                For i As Integer = 0 To Barcode_Part.Length - 1
                    sql += "'" & Barcode_Part(i) & "',"

                Next
                sql += "'" & cmb_Pcode3.Text & "',"
                sql += "'in','" & txtsap.Text & "')"

                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

                lbl_Msg.ForeColor = Color.GreenYellow
                lbl_Msg.Text = "تم تسجيل الجهاز بنجاح"
                txtFATSERIAL.Enabled = True
                txtFATSERIAL.Text = ""
                txtsap.Text = ""
                txtFATSERIAL.Focus()

                ' txtFATSERIAL.SelectAll()
                _Refresh1()
                _Refresh13()
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtsap_TextChanged(sender As Object, e As EventArgs) Handles txtsap.TextChanged

    End Sub
End Class