Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmEditNameLaber

    Private Sub frmEditNameLaber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  FollowTest set"
            sql += " fResbonceProblem = '" & txtcodelaber.Text & "'"
            'sql += " fpanelID = '" & txtpanelid.Text & "',"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where fBarcode = '" & txtbarcode.Text & "'"
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3p() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fTime, fModel, fBarcode, R_Name_Problem,fSV FROM Vtest "
            ' sql += " FROM Output"
            '  sql += " where fLineAndShift='" & txtlinandshift.Text & "'"
            sql += " where fNameLaberTester='" & txtsap.Text & "'"
            sql += "   and fDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Vtest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            '  ds.Tables("Vtest").Columns(0).ColumnName = "التاريخ"
            ds.Tables("Vtest").Columns(0).ColumnName = "الوقت"
            ds.Tables("Vtest").Columns(1).ColumnName = " الموديل"
            ds.Tables("Vtest").Columns(2).ColumnName = " باركود الجهاز"
            ds.Tables("Vtest").Columns(3).ColumnName = "اسم المشكلة"
            ' ds.Tables("Vtest").Columns(0).ColumnName = " اسم صاحب المشكلة"
            'ds.Tables("Vtest").Columns(4).ColumnName = "الخط"
            ds.Tables("Vtest").Columns(4).ColumnName = "المشرف"
            'ds.Tables("Vtest").Columns(7).ColumnName = "الكمية"

            dgd.DataSource = ds.Tables("Vtest")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh3p()
    End Sub

    Private Sub dgd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgd.CellContentClick
        txtbarcode.Text = dgd.Item(2, dgd.CurrentRow.Index).Value
        txtsv.Text = dgd.Item(4, dgd.CurrentRow.Index).Value
    End Sub

    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtcodelaber.Focus()

        End If
    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub txtcodelaber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodelaber.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sql As String = ""
                sql += "SELECT R_Name_Laber FROM  R_Name_Laber1 "
                sql += " where R_Sap=" & txtcodelaber.Text & ""
                sql += " and R_Line='" & txtsv.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
                da.Fill(ds, "R_Name_Laber1")
                CB1.DataSource = ds.Tables(0)
                CB1.DisplayMember = "R_Name_Laber"
                CB1.Sorted = True

  
            Catch ex As Exception

            End Try

            Update1A()

            txtbarcode.Text = ""
            txtcodelaber.Text = ""
            txtbarcode.Focus()

        End If

    End Sub

    Private Sub txtcodelaber_TextChanged(sender As Object, e As EventArgs) Handles txtcodelaber.TextChanged

    End Sub

    Private Sub txtsap_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsap.KeyDown
        _Refresh3p()

    End Sub

    Private Sub txtsap_TextChanged(sender As Object, e As EventArgs) Handles txtsap.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class