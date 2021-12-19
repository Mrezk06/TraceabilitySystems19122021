Imports System.ComponentModel
Imports TEVPBarcode.sher
Public Class NotesForProblems
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        cmb_Pcode3.Enabled = False
        _Refresh1pp()
        _Refreshdddddd()

    End Sub
    Private Function _Refresh1pp() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_3"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fNameL ='" & cmb_Pcode3.Text & "'"

            sql += " and qultyinorout = 'Note' "
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

            sql += " and qultyinorout = 'Note' "
            '  sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_3")
            ds.Tables("View_3").Columns(0).ColumnName = "الكمية"

            DataGridView1.DataSource = ds.Tables("View_3")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtDelete_TextChanged(sender As Object, e As EventArgs) Handles txtDelete.TextChanged

    End Sub

    Private Sub txtDelete_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDelete.KeyDown

    End Sub


    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnSEARCH_Click(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        Dim frm As New QueryforQulity
        frm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If txtDelete.Text.Length < 14 Then Exit Sub
            If txtDelete.Text.Length > 14 Then Exit Sub
            Dim dsMax As New DataSet
            Dim Sql1 = "SELECT fLCDBarcode  FROM  OutputQ where fLCDBarcode='" & txtDelete.Text & "'"
            Sql1 += " and qultyinorout='Note'"

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
            sql += "(fLCDBarcode, fLCDPyear, fLCDPweek, fLCDSetID, fLCDCountry, fLCDPline, fLCDSN, fLCDPID, fNameL,NotesQ,qultyinorout)"
            sql += "VALUES     ('"
            sql += txtDelete.Text & "',"
            For i As Integer = 0 To Barcode_Part.Length - 1
                sql += "'" & Barcode_Part(i) & "',"

            Next
            sql += "'" & cmb_Pcode3.Text & "',"
            sql += "'" & txtNotes.Text & "',"
            sql += "'Note')"

            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

            lbl_Msg.ForeColor = Color.GreenYellow
            lbl_Msg.Text = "تم تسجيل الملاحظه "

            txtDelete.Focus()
            txtDelete.SelectAll()
            _Refresh1pp()
            _Refreshdddddd()


            'End If
        Catch ex As Exception

        End Try
        txtDelete.Text = ""
    End Sub

    Private Sub NotesForProblems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class