Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmHeaterRepairReg
    Private Sub frmLCMRepair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox7.Enabled = False
        Try
            Dim sql As String = ""
            sql += " SELECT  Model_control,Model_Name FROM Heater_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_ModelName")
            txtmodel.DataSource = ds.Tables(0)
            txtmodel.ValueMember = "Model_control"
            txtmodel.DisplayMember = "Model_Name"
            txtmodel.Sorted = True
        Catch ex As Exception
        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT R_ID,R_Name FROM Heater_Problem "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_Problem")
            txtIDproblem.DataSource = ds.Tables(0)
            txtIDproblem.ValueMember = "R_Name"
            txtIDproblem.DisplayMember = "R_ID"
            txtIDproblem.Sorted = True
        Catch ex As Exception
        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT  R_ID,R_Name FROM Heater_Problem_Reson "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_Problem_Reson")
            txtresonProblem.DataSource = ds.Tables(0)
            txtresonProblem.ValueMember = "R_Name"
            txtresonProblem.DisplayMember = "R_ID"
            txtresonProblem.Sorted = True
        Catch ex As Exception
        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT R_Sap, R_Name_Laber FROM R_Name_Laber1 "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "R_Name_Laber1")
            txtLaberProblem.DataSource = ds.Tables(0)
            txtLaberProblem.ValueMember = "R_Name_Laber"
            txtLaberProblem.DisplayMember = "R_Sap"
            txtLaberProblem.Sorted = True
        Catch ex As Exception
        End Try
    End Sub
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "INSERT INTO Heater_Repair"
            sql += "(R_BarcodeP1, R_BarcodeP2, R_ModelName, H_Shift_Line, R_Note, R_Sap_L, R_Sap_R,R_ID_Problem,R_ID_Problem_Reson,H_Line_Name)"
            sql += " VALUES ('" & txtbarcode.Text & "','" & TextBox1.Text & "','" & txtmodel.Text & "','" & txtlinandshift.Text & "','" & TextBox2.Text & "','" & txtLaberProblem.Text & "','" & txtcodeUse.Text & "','" & txtIDproblem.Text & "','" & txtresonProblem.Text & "','" & txttypeProblem.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtcodeUse.Text = "" Or txtlinandshift.Text = "" Then
                MsgBox("من فضلك اكمل البيانات ")
            Else
                If txtcodeUse.Text.Length < 8 Then Exit Sub
                Dim dsMax As New DataSet
                Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap where Heater_Sap_Laber='" & txtcodeUse.Text & "'"
                Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
                dsMax.Tables.Clear()
                da.Fill(dsMax)
                If dsMax.Tables(0).Rows.Count < 1 Then
                    MsgBox("This name is not allowed to work on barcode Line ")
                    txtcodeUse.Focus()
                    txtcodeUse.SelectAll()
                    Exit Sub
                Else
                    _Refresh315()
                    df.Visible = True
                    GroupBox1.Visible = False
                    GroupBox7.Enabled = True
                    txtbarcode.Focus()
                End If
            End If
            txtmodel.Enabled = True
        Catch ex As Exception
        End Try
    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            sql += " where Heater_Sap_Laber='" & txtcodeUse.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = "فنى الصيانة المسئول "
            dgtc.DataSource = ds.Tables("Heater_Name_Sap")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_ModelName,count( R_ModelName)FROM  Heater_Repair "
            sql += " where H_Shift_Line='" & txtlinandshift.Text & "'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Repair")
            ds.Tables("Heater_Repair").Columns(0).ColumnName = "الموديل"
            ds.Tables("Heater_Repair").Columns(1).ColumnName = "الكمية"
            dgqty.DataSource = ds.Tables("Heater_Repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3v() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT H_Line_Name,count( R_BarcodeP1) FROM  Heater_Repair "
            sql += " where H_Shift_Line='" & txtlinandshift.Text & "'"
            sql += " and H_Line_Name='Vendor'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by H_Line_Name"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Repair")
            ds.Tables("Heater_Repair").Columns(0).ColumnName = "نوع العيب"
            ds.Tables("Heater_Repair").Columns(1).ColumnName = "الكمية"
            dgpr.DataSource = ds.Tables("Heater_Repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshdgd() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_Name,count( R_Name) FROM Heater_Repair_data"
            sql += " where H_Shift_Line='" & txtlinandshift.Text & "'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_Name"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Repair_data")
            ds.Tables("Heater_Repair_data").Columns(0).ColumnName = "اسم المشكلة"
            ds.Tables("Heater_Repair_data").Columns(1).ColumnName = "الكمية"
            dgd.DataSource = ds.Tables("Heater_Repair_data")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3p() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT H_Line_Name,count( R_BarcodeP1) FROM  Heater_Repair "
            sql += " where H_Shift_Line='" & txtlinandshift.Text & "'"
            sql += " and H_Line_Name='Process'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by H_Line_Name"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Repair")
            ds.Tables("Heater_Repair").Columns(0).ColumnName = "نوع العيب"
            ds.Tables("Heater_Repair").Columns(1).ColumnName = "الكمية"
            dgve.DataSource = ds.Tables("Heater_Repair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmodel.SelectedIndexChanged
        lbl_Pcode_Value.Text = txtmodel.SelectedValue.ToString
    End Sub
    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtbarcode.Text.Length <> 18 Then
                    MsgBox("باركود الجهاز خطأ")
                Else
                    txtbarcode.Enabled = False
                    txtIDproblem.Enabled = True
                    txtIDproblem.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
     
            Add1_New()
            _Refresh3()
            _Refresh3v()
            _Refreshdgd()
            _Refresh3p()


            txtLaberProblem.Text = ""
            txtbarcode.Text = ""
            TextBox1.Text = ""
            txtIDproblem.Text = ""
            txtresonProblem.Text = ""
            txttypeProblem.Text = ""
            txtLaberProblem.Text = ""
            txtstat.Text = ""

            txtLaberProblem.Enabled = False
            txtbarcode.Enabled = False
            TextBox1.Enabled = False
            txtIDproblem.Enabled = False
            txtresonProblem.Enabled = False
            txttypeProblem.Enabled = False
            txtLaberProblem.Enabled = False
            txtbarcode.Enabled = True
            txtbarcode.Focus()

    End Sub
    Private Sub dgqty_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgqty.CellClick
        txtmodel.Text = dgqty.Item(0, dgqty.CurrentRow.Index).Value
    End Sub
    Private Sub txtIDproblem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIDproblem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If txtIDproblem.Text = "" Then
                    MsgBox("الرجاء ادخال كود المشكلة")
                    txtIDproblem.SelectAll()
                    txtIDproblem.Focus()
                Else
                    Dim sql As String = ""
                    sql += "SELECT R_Name FROM  Heater_Problem "
                    sql += " where R_ID=" & txtIDproblem.Text & ""
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "Heater_Problem")
                    CB1.DataSource = ds.Tables(0)
                    CB1.DisplayMember = "R_Name"
                    CB1.Sorted = True
                End If
            Catch ex As Exception
            End Try
            txtIDproblem.Enabled = False
            txtresonProblem.Enabled = True
            txtresonProblem.Focus()
        End If
    End Sub
    Private Sub txtIDproblem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtIDproblem.SelectedIndexChanged
        CodeProblem.Text = txtIDproblem.SelectedValue.ToString
    End Sub

    Private Sub txtresonProblem_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtresonProblem_SelectedIndexChanged(sender As Object, e As EventArgs)
        resonProblem.Text = txtresonProblem.SelectedValue.ToString
    End Sub

    Private Sub txttypeProblem_KeyDown(sender As Object, e As KeyEventArgs) Handles txttypeProblem.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txttypeProblem.Text = "" Then
                MsgBox("الرجاء ادخال نوع العيب ")
                txttypeProblem.Focus()
            Else
                txttypeProblem.Enabled = False
                txtLaberProblem.Enabled = True
                txtLaberProblem.Focus()
            End If
        End If
    End Sub
    Private Sub txtLaberProblem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLaberProblem.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtmodel.Text = "" Or txtbarcode.Text = "" Or txtIDproblem.Text = "" Or txtresonProblem.Text = "" Or txttypeProblem.Text = "" Then
                txtLaberProblem.Enabled = True
                txtbarcode.Enabled = True
                TextBox1.Enabled = True
                txtIDproblem.Enabled = True
                txtresonProblem.Enabled = True
                txttypeProblem.Enabled = True
                txtLaberProblem.Enabled = True
                txtbarcode.Enabled = True
                MsgBox("الرجاء اعادة ادخال بيانات الجهاز حيث يوجد خطأ فى تسجيل هذه البيانات ")
                txtmodel.Focus()
            Else
                Try
                    Dim sql1 As String = ""
                    sql1 += "SELECT R_Name_Laber FROM  Heater_Labor_Repair "
                    sql1 += " where R_Sap=" & txtLaberProblem.Text & ""
                    Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "Heater_Labor_Repair")
                    DD.DataSource = ds.Tables(0)
                    DD.DisplayMember = "R_Name_Laber"
                    DD.Sorted = True
                Catch ex As Exception
                End Try
                Dim sql As String
                sql = "INSERT INTO Heater_Repair"
                sql += "(R_BarcodeP1, R_BarcodeP2, R_ModelName, H_Shift_Line, R_Note, R_Sap_L, R_Sap_R,R_ID_Problem,R_ID_Problem_Reson,H_Line_Name)"
                sql += " VALUES ('" & txtbarcode.Text & "','" & TextBox1.Text & "','" & txtmodel.Text & "','" & txtlinandshift.Text & "','" & TextBox2.Text & "','" & txtLaberProblem.Text & "','" & txtcodeUse.Text & "','" & txtIDproblem.Text & "','" & txtresonProblem.Text & "','" & txttypeProblem.Text & "')"
                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                _Refreshdgd()
                _Refresh3()
                _Refresh3v()
                _Refresh3p()

                txtLaberProblem.Text = ""
                txtbarcode.Text = ""
                TextBox1.Text = ""
                txtIDproblem.Text = ""
                txtresonProblem.Text = ""
                txttypeProblem.Text = ""
                txtLaberProblem.Text = ""
                txtstat.Text = ""
                txtLaberProblem.Enabled = False
                txtbarcode.Enabled = False
                TextBox1.Enabled = False
                txtIDproblem.Enabled = False
                txtresonProblem.Enabled = False
                txttypeProblem.Enabled = False
                txtLaberProblem.Enabled = False
                txtbarcode.Enabled = True
                txtbarcode.Focus()
            End If
        End If
    End Sub

    Private Sub txtLaberProblem_Leave(sender As Object, e As EventArgs) Handles txtLaberProblem.Leave
        txtLaberProblem.Text = ""
        txtbarcode.Text = ""
        TextBox1.Text = ""
        txtIDproblem.Text = ""
        txtresonProblem.Text = ""
        txttypeProblem.Text = ""
        txtLaberProblem.Text = ""
        txtbarcode.Focus()
    End Sub
    Private Sub txtLaberProblem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtLaberProblem.SelectedIndexChanged
        DD.Text = txtLaberProblem.SelectedValue.ToString
    End Sub
    Private Sub txtlinandshift_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinandshift.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcodeUse.Text = "" Or txtlinandshift.Text = "" Then
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
                    MsgBox("This name is not allowed to work on barcode Line ")
                    txtcodeUse.Focus()
                    txtcodeUse.SelectAll()
                    Exit Sub
                Else
                    _Refresh315()
                    df.Visible = True
                    GroupBox1.Visible = False
                    GroupBox7.Enabled = True
                    txtbarcode.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtstat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtstat.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
               
                ' End If
                If txtstat.Text = "Change" Then
                    txtstat.Enabled = False
                    TextBox1.Enabled = True
                    TextBox1.Focus()
                ElseIf txtstat.Text = "A" Then
                    txtstat.Enabled = False
                    txtbarcode.Enabled = False
                    txttypeProblem.Focus()
                ElseIf txtstat.Text = "B" Then
                    txtstat.Enabled = False
                    txtbarcode.Enabled = False
                    txttypeProblem.Focus()
                Else
                    txttypeProblem.Enabled = True
                    txttypeProblem.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtstat_TextChanged(sender As Object, e As EventArgs) Handles txtstat.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then

                If TextBox1.Text.Length <> 18 Then



                ElseIf TextBox1.Text = "" Then
                    MsgBox("الرجاء ادخال باركود المكون الجديد")
                    TextBox1.Focus()
                    TextBox1.SelectAll()
                Else


                    Dim Barcode_Part(6) As String
                    Barcode_Part(0) = txtbarcode.Text.Substring(0, 7)
                    Barcode_Part(1) = txtbarcode.Text.Substring(7, 2)
                    Barcode_Part(2) = txtbarcode.Text.Substring(9, 7)
                    Barcode_Part(3) = txtbarcode.Text.Substring(16, 1)
                    Barcode_Part(4) = txtbarcode.Text.Substring(17, 1)
                    'Dim Barcode_Part(6) As String
                    Dim Barcode_Part2(6) As String
                    Barcode_Part2(0) = TextBox1.Text.Substring(0, 7)
                    Barcode_Part2(1) = TextBox1.Text.Substring(7, 2)
                    Barcode_Part2(2) = TextBox1.Text.Substring(9, 7)
                    Barcode_Part2(3) = TextBox1.Text.Substring(16, 1)
                    Barcode_Part2(4) = TextBox1.Text.Substring(17, 1)
                    If Barcode_Part(3) <> Barcode_Part2(3) Then
                        MsgBox("الجزء الذى يتم تغيره غير مطابق للجزء الجديد")
                        TextBox1.Focus()
                        TextBox1.SelectAll()
                    Else
                        TextBox1.Enabled = False
                        txttypeProblem.Enabled = True
                        txttypeProblem.Focus()
                        ' _Refresh1()
                    End If
                End If
            End If
            
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub txtIDproblem_Validated(sender As Object, e As EventArgs) Handles txtIDproblem.Validated

    End Sub

    Private Sub txtresonProblem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtresonProblem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If txtresonProblem.Text = "" Then
                    MsgBox("الرجاء ادخال كود سبب المشكلة ")
                    txtresonProblem.Enabled = True
                    txtresonProblem.Focus()

                Else
                    txtresonProblem.Enabled = False
                    txtstat.Enabled = True
                    txtstat.Focus()
                    Dim sql As String = ""
                    sql += "SELECT R_Name FROM  Heater_Problem_Reson "
                    sql += " where R_ID=" & txtresonProblem.Text & ""
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "Heater_Problem_Reson")
                    CB2.DataSource = ds.Tables(0)
                    CB2.DisplayMember = "R_Name"
                    CB2.Sorted = True
                    txtresonProblem.Enabled = False
                    txtstat.Enabled = True
                    txtstat.Focus()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtresonProblem_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txtresonProblem.SelectedIndexChanged
        Try
            resonProblem.Text = txtresonProblem.SelectedValue.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class