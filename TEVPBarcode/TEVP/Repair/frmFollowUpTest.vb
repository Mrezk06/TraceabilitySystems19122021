Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmFollowUpTest

    Private Sub frmFollowUpTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox3.Enabled = False

    End Sub

    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        Try


            If e.KeyCode = Keys.Enter Then
                If txtbarcode.Text.Length <> 14 Then
                    MsgBox("باركود الجهاز خطأ")
                Else

                    Dim Barcode_Part(6) As String
                    Barcode_Part(0) = txtbarcode.Text.Substring(0, 1)
                    Barcode_Part(1) = txtbarcode.Text.Substring(1, 2)
                    Barcode_Part(2) = txtbarcode.Text.Substring(3, 3)
                    Barcode_Part(3) = txtbarcode.Text.Substring(6, 1)
                    Barcode_Part(4) = txtbarcode.Text.Substring(7, 1)
                    Barcode_Part(5) = txtbarcode.Text.Substring(8, 4)
                    Barcode_Part(6) = txtbarcode.Text.Substring(12, 2)

                    'If Barcode_Part(2) <> txtmodel.SelectedValue Then

                    '    '   txtbarcode.BackColor = Color.Red
                    '    MsgBox("BIN Code Structure wrong")
                    '    'MsgBox.ForeColor = Color.Yellow

                    '    txtbarcode.Focus()
                    '    txtbarcode.SelectAll()

                    'Else
                    txtproCode.Focus()
                    '        End If
                    Dim sql As String = ""
                    sql += "SELECT fLCDModelName FROM  LCDTVModels "
                    ' sql += " FROM Output"
                    sql += " where fLCDSetID='" & Barcode_Part(2) & "'"
                    sql += " and fpanelID='" & Barcode_Part(6) & "'"
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "LCDTVModels")

                    txtmodel.DataSource = ds.Tables(0)
                    '  txtresonProblem.ValueMember = "R_Name_Problem"
                    txtmodel.DisplayMember = "fLCDModelName"
                    txtmodel.Sorted = True


                End If
                '    End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub txtproCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sql As String = ""
                sql += "SELECT R_Name_Problem FROM  R_Name_Problemstest "
                sql += " where R_SN=" & txtproCode.Text & ""
                Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
                da.Fill(ds, "R_Name_Problemstest")
                CB1.DataSource = ds.Tables(0)
                CB1.DisplayMember = "R_Name_Problem"
                CB1.Sorted = True

            Catch ex As Exception

            End Try


            
            If e.KeyCode = Keys.Enter Then
                If txtmodel.Text = "" Or txtsv.Text = "" Or txtcodeUse.Text = "" Or txtbarcode.Text = "" Or txtproCode.Text = "" Then
                    MsgBox("الرجاء اعادة ادخال بيانات الجهاز حيث يوجد خطأ فى تسجيل هذه البيانات ")
                    txtbarcode.Text = ""
                    txtproCode.Text = ""
                    txtbarcode.Focus()

                Else

                    Dim sql As String
                    sql = "INSERT INTO FollowTest"

                    sql += "( fModel, fBarcode, fNameProblem, fNameLaberTester, fLineAndShift, fSV)"
                    sql += " VALUES ('" & txtmodel.Text & "','" & txtbarcode.Text & "','" & txtproCode.Text & "','" & txtcodeUse.Text & "','" & txtlinandshift.Text & "','" & txtsv.Text & "')"

                    Dim cmd As New SqlClient.SqlCommand(sql, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    _Refresh3p()

                    txtbarcode.Text = ""
                    txtproCode.Text = ""
                    txtbarcode.Focus()


                End If
            End If

        End If
    End Sub
    Private Function _Refresh3p() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fDate, fTime, fModel, fBarcode, R_Name_Problem, fLineAndShift, fSV FROM Vtest "
            ' sql += " FROM Output"
            sql += " where fLineAndShift='" & txtlinandshift.Text & "'"
            sql += " and fNameLaberTester='" & txtcodeUse.Text & "'"
            'sql += " and R_Type_Problem='Process'"
            sql += " and fDate >= Convert(nvarchar(10), GETDATE(), 121)"
            ' sql += " group by R_Type_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Vtest")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("Vtest").Columns(0).ColumnName = "التاريخ"
            ds.Tables("Vtest").Columns(1).ColumnName = "الوقت"
            ds.Tables("Vtest").Columns(2).ColumnName = " الموديل"
            ds.Tables("Vtest").Columns(3).ColumnName = " باركود الجهاز"
            ds.Tables("Vtest").Columns(4).ColumnName = "اسم المشكلة"
            ' ds.Tables("Vtest").Columns(0).ColumnName = " اسم صاحب المشكلة"
            ds.Tables("Vtest").Columns(5).ColumnName = "الخط"
            ds.Tables("Vtest").Columns(6).ColumnName = "المشرف"
            'ds.Tables("Vtest").Columns(7).ColumnName = "الكمية"

            dgd.DataSource = ds.Tables("Vtest")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtproCode_TextChanged(sender As Object, e As EventArgs) Handles txtproCode.TextChanged

    End Sub

    Private Sub txtlinandshift_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinandshift.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcodeUse.Text = "" Or txtsv.Text = "" Or txtlinandshift.Text = "" Then
                MsgBox("من فضلك اكمل البيانات ")

            Else


                If txtcodeUse.Text.Length < 8 Then Exit Sub

                Dim dsMax As New DataSet
                Dim Sql = "SELECT  R_Name_Laber FROM R_Name_Laber1 where R_ID='" & txtcodeUse.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count < 1 Then
                    '  lbl_Msg.ForeColor = Color.Red
                    MsgBox("This name is not allowed to work on barcode Line ")
                    txtcodeUse.Focus()
                    txtcodeUse.SelectAll()
                    Exit Sub
                Else
                    _Refresh315()
                    ' df.Visible = True
                    txtlinandshift.Enabled = False
                    txtsv.Enabled = False
                    txtbarcode.Focus()

                    GroupBox3.Enabled = True
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
                    txtbarcode.Focus()
                    'Me.BackColor = Color.YellowGreen

                End If
            End If
        End If

    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  R_Name_Laber FROM R_Name_Laber1 where R_ID='" & txtcodeUse.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "R_Name_Laber1")
            ds.Tables("R_Name_Laber1").Columns(0).ColumnName = "مسئول الفحص  "

            dgtc.DataSource = ds.Tables("R_Name_Laber1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtlinandshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtlinandshift.SelectedIndexChanged

    End Sub

    Private Sub txtcodeUse_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodeUse.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtsv.Focus()

        End If
    End Sub

    Private Sub txtcodeUse_Leave(sender As Object, e As EventArgs) Handles txtcodeUse.Leave
        ' If e.KeyCode = Keys.Enter Then
        'If txtcodeUse.Text = "" Or txtsv.Text = "" Or txtlinandshift.Text = "" Then
        '    MsgBox("من فضلك اكمل البيانات ")

        'Else


        If txtcodeUse.Text.Length < 8 Then Exit Sub

        Dim dsMax As New DataSet
        Dim Sql = "SELECT  R_Name_Laber FROM R_Name_Laber1 where R_ID='" & txtcodeUse.Text & "'"
        Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
        dsMax.Tables.Clear()
        da.Fill(dsMax)
        If dsMax.Tables(0).Rows.Count < 1 Then
            '  lbl_Msg.ForeColor = Color.Red
            MsgBox("This name is not allowed to work on barcode Line ")
            txtcodeUse.Focus()
            txtcodeUse.SelectAll()
            Exit Sub
        Else
            _Refresh315()
            ' df.Visible = True
            'txtlinandshift.Enabled = False
            'txtsv.Enabled = False
            txtsv.Focus()

            ' GroupBox3.Enabled = True
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
            '   txtbarcode.Focus()
            'Me.BackColor = Color.YellowGreen

        End If
        '   End If
        ' End If

    End Sub

    Private Sub txtcodeUse_TextChanged(sender As Object, e As EventArgs) Handles txtcodeUse.TextChanged
      
    End Sub

    Private Sub txtsv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsv.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtlinandshift.Focus()

        End If
    End Sub

    Private Sub txtsv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsv.SelectedIndexChanged

    End Sub

    Private Sub txtmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmodel.SelectedIndexChanged

    End Sub

    Private Sub txtproCode_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtproCode.Validating

    End Sub
End Class