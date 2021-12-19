Imports TEVPBarcode.sher
Public Class FRMTESTONLINE
    Private Sub FRMTESTONLINE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += "SELECT CModelName FROM CModels"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")
            cmb_Pcode.DataSource = ds.Tables(0)
            cmb_Pcode.DisplayMember = "CModelName"
            cmb_Pcode.Sorted = True
        Catch ex As Exception
        End Try
        txtParts1.Focus()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If cmb_Pcode.Text = "" Or txtline1.Text = "" Or ComboBox2.Text = "" Or txtParts1.Text = "" Then
                MsgBox("الرجاء مراجعة ادخال البيانات بشكل صحيح")
            Else
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
                    MsgBox("مرحبا بك فى برنامج مصنع البتوجاز لمتابعة الانتاج ")
                    GB2.Enabled = False
                    GB1.Enabled = True
                    _Refresh315()
                    txtBarcodeOne.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtParts1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtParts1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_Pcode.Focus()
        End If
    End Sub
    Private Sub txtParts1_TextChanged(sender As Object, e As EventArgs) Handles txtParts1.TextChanged

    End Sub
    Private Sub cmb_Pcode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Pcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtline1.Focus()
        End If
    End Sub
    Private Sub cmb_Pcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Pcode.SelectedIndexChanged

    End Sub
    Private Sub txtline1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtline1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox2.Focus()
        End If
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
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
    Private Sub txtline1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtline1.SelectedIndexChanged

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class