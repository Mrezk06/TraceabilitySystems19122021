Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmFollowUpLaber

    Private Sub txtcodeUse_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodeUse.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtsv.Focus()

        End If
    End Sub

    Private Sub txtcodeUse_TextChanged(sender As Object, e As EventArgs) Handles txtcodeUse.TextChanged

    End Sub

    Private Sub txtsv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsv.KeyDown
        If e.KeyCode = Keys.Enter Then

            '  df.Text = txtsv.Text


            txtlinandshift.Focus()

        End If
    End Sub

    Private Sub txtsv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsv.SelectedIndexChanged

    End Sub

    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & txtcodeUse.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "  المسئول "

            dgtc.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtlinandshift_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinandshift.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcodeUse.Text = "" Or txtsv.Text = "" Or txtlinandshift.Text = "" Then
                MsgBox("من فضلك اكمل البيانات ")

            Else


                If txtcodeUse.Text.Length < 8 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtcodeUse.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count < 1 Then
                    '  lbl_Msg.ForeColor = Color.Red
                    MsgBox("This name is not allowed to work on Follow Line ")
                    txtcodeUse.Focus()
                    txtcodeUse.SelectAll()
                    Exit Sub
                Else
                    _Refresh315()
                    '  df.Visible = True
                    GroupBox5.Visible = True
                    txtcodeUse.Enabled = False
                    '  lbl_Msg.ForeColor = Color.Green
                    'lbl_Msg.Text = " welcome This name allowed to work on barcode Line "
                    'cmb_Pcode.Enabled = True
                    '' txtline.Enabled = False
                    'txtshift.Enabled = True
                    'GroupBox2.Visible = True
                    ''txtshift.Visible = False
                    'Button2.Visible = False
                    'txtParts1.Visible = False
                    'Label10.Visible = False
                    txttypeFollow.Focus()
                    'Me.BackColor = Color.YellowGreen

                End If
            End If
        End If
    End Sub
    Private Sub txtlinandshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtlinandshift.SelectedIndexChanged

      
    End Sub

    Private Sub txttypeFollow_KeyDown(sender As Object, e As KeyEventArgs) Handles txttypeFollow.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' df.Text = txtsv.Text


            txtProcess.Focus()

        End If
    End Sub

    Private Sub txttypeFollow_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txttypeFollow.SelectedIndexChanged
       
    End Sub

    Private Sub txtProcess_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProcess.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' df.Text = txtsv.Text


            txtnote.Focus()

        End If
    End Sub

    Private Sub txtProcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProcess.SelectedIndexChanged

    End Sub

    Private Sub txtnote_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnote.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' df.Text = txtsv.Text


            txtSapLaber.Focus()

        End If
    End Sub

    Private Sub txtnote_TextChanged(sender As Object, e As EventArgs) Handles txtnote.TextChanged

    End Sub

    Private Sub txtSapLaber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSapLaber.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txttypeFollow.Text = "" Or txtProcess.Text = "" Or txtSapLaber.Text = "" Or txtcodeUse.Text = "" Or txtsv.Text = "" Or txtlinandshift.Text = "" Then
                MsgBox("من فضلك تأكد من أكتمال أدخال البيانات")
            Else
                Dim sql As String
                sql = "INSERT INTO FollowUpLaber"

                sql += "(fTypeFollow, fTypeProcess, fNote, fSapLaber, fSV, fLineAndShift, fUserRes)"
                sql += " VALUES ('" & txttypeFollow.Text & "','" & txtProcess.Text & "','" & txtnote.Text & "'," & txtSapLaber.Text & ",'" & txtsv.Text & "','" & txtlinandshift.Text & "','" & txtcodeUse.Text & "')"

                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                _Refresh3()
                txttypeFollow.Text = ""
                txtProcess.Text = ""
                txtnote.Text = ""
                txtSapLaber.Text = ""
                txttypeFollow.Focus()

            End If
        End If
    End Sub

    Private Sub txtSapLaber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSapLaber.SelectedIndexChanged
        
    End Sub
    Private Function _Refresh3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fTypeFollow, fTypeProcess, fNote, fSapLaber, fSV, fLineAndShift, fUserRes FROM FollowUpLaber "
            ' sql += " FROM Output"
            sql += " where fLineAndShift='" & txtlinandshift.Text & "'"
            sql += " and fSV='" & txtsv.Text & "'"
            sql += " and fDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "FollowUpLaber")
            ds.Tables("FollowUpLaber").Columns(0).ColumnName = "التاريخ"
            ds.Tables("FollowUpLaber").Columns(1).ColumnName = "الوقت"
            ds.Tables("FollowUpLaber").Columns(2).ColumnName = "نوع المتابعه"
            ds.Tables("FollowUpLaber").Columns(3).ColumnName = "نوع الحركة"
            ds.Tables("FollowUpLaber").Columns(4).ColumnName = "الملاحظات"
            ds.Tables("FollowUpLaber").Columns(5).ColumnName = "ساب الفنى"
            ds.Tables("FollowUpLaber").Columns(6).ColumnName = "اسم المشرف"
            ds.Tables("FollowUpLaber").Columns(7).ColumnName = "الخط والورديه"
            ds.Tables("FollowUpLaber").Columns(8).ColumnName = "كود المتابع"
            dgd.DataSource = ds.Tables("FollowUpLaber")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub frmFollowUpLaber_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class