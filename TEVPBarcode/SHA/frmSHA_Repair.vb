Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmSHA_Repair
    Private Sub frmSHA_Repair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox7.Enabled = False
        Label12.Text = StringPassc1
        Try
            Dim sql As String = ""
            sql += " SELECT R_SN ,R_Name_Problem FROM SHA_Name_Problems "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "SHA_Name_Problems")

            txtIDproblem.DataSource = ds.Tables(0)
            txtIDproblem.ValueMember = "R_Name_Problem"
            txtIDproblem.DisplayMember = "R_SN"
            txtIDproblem.Sorted = True

            '  _Refresh1()
        Catch ex As Exception

        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT  R_SN,R_Name_Problem FROM SHA_Reson_Problems "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "SHA_Reson_Problems")
            txtresonProblem.DataSource = ds.Tables(0)
            txtresonProblem.ValueMember = "R_Name_Problem"
            txtresonProblem.DisplayMember = "R_SN"
            txtresonProblem.Sorted = True

            '  _Refresh1()
        Catch ex As Exception

        End Try
        Try
            Dim sql As String = ""
            sql += " SELECT R_Sap, R_Name_Laber FROM SHA_Name_Laber "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "SHA_Name_Laber")
            txtLaberProblem.DataSource = ds.Tables(0)
            txtLaberProblem.ValueMember = "R_Name_Laber"
            txtLaberProblem.DisplayMember = "R_Sap"
            txtLaberProblem.Sorted = True

            '  _Refresh1()
        Catch ex As Exception

        End Try
    End Sub
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "INSERT INTO SHA_MainRepair"
            sql += "(R_SN_Laber_Repair,R_SN_Problem,R_SN_ResonProblem,R_SN_ProblemLaber,R_ModelName,R_Type_Problem,R_Line,R_Barcode1,R_SV)"
            sql += " VALUES (" & Label12.Text & "," & txtIDproblem.Text & "," & txtresonProblem.Text & "," & txtLaberProblem.Text & ",'" & txtmodel.Text & "','" & txttypeProblem.Text & "','" & txtlinandshift.Text & "','" & txtbarcode.Text & "','" & txtsv.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtsv.Text = "" Or txtlinandshift.Text = "" Then
                MsgBox("من فضلك اكمل البيانات ")
            Else

                _Refresh315()
                    df.Visible = True
                    GroupBox1.Visible = False
                    GroupBox7.Enabled = True
                    txtbarcode.Focus()
                End If


        Catch ex As Exception

        End Try

    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & Label12.Text & "'"
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
            sql += "SELECT R_ModelName,count( R_ModelName)FROM  SHA_MainRepair "
            ' sql += " FROM Output"
            sql += " where R_Line='" & txtlinandshift.Text & "'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_MainRepair")
            ds.Tables("SHA_MainRepair").Columns(0).ColumnName = "الموديل"
            ' ds.Tables("R_MainRepair").Columns(1).ColumnName = "Type_Problem"
            ds.Tables("SHA_MainRepair").Columns(1).ColumnName = "الكمية"
            dgqty.DataSource = ds.Tables("SHA_MainRepair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3v() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_Type_Problem,count( R_Barcode1)FROM  SHA_MainRepair "
            ' sql += " FROM Output"
            sql += " where R_Line='" & txtlinandshift.Text & "'"
            sql += " and R_Type_Problem='Vendor'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_Type_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_MainRepair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("SHA_MainRepair").Columns(0).ColumnName = "نوع العيب"
            ds.Tables("SHA_MainRepair").Columns(1).ColumnName = "الكمية"
            dgve.DataSource = ds.Tables("SHA_MainRepair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshdgd() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_Name_Problem,count( R_Barcode1) FROM SHA_Repair1"
            sql += " where R_Line='" & txtlinandshift.Text & "'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_Name_Problem"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Repair1")
            ds.Tables("SHA_Repair1").Columns(0).ColumnName = "اسم المشكلة"
            ds.Tables("SHA_Repair1").Columns(1).ColumnName = "الكمية"
            dgd.DataSource = ds.Tables("SHA_Repair1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3p() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT R_Type_Problem,count( R_Barcode1)FROM  SHA_MainRepair "
            ' sql += " FROM Output"
            sql += " where R_Line='" & txtlinandshift.Text & "'"
            sql += " and R_Type_Problem='Process'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_Type_Problem"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_MainRepair")
            ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
            ds.Tables("SHA_MainRepair").Columns(0).ColumnName = "نوع العيب"
            ds.Tables("SHA_MainRepair").Columns(1).ColumnName = "الكمية"
            dgpr.DataSource = ds.Tables("SHA_MainRepair")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtmodel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmodel.KeyDown

    End Sub
    Private Sub txtmodel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtmodel.SelectedIndexChanged
        lbl_Pcode_Value.Text = txtmodel.SelectedValue.ToString
        ' Label2.Text = txtmodel.Text

    End Sub

    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                If txtbarcode.Text.Length = 19 Then
                    Dim Barcode_Part(3) As String
                    Barcode_Part(0) = txtbarcode.Text.Substring(0, 13)
                    Barcode_Part(1) = txtbarcode.Text.Substring(13, 4)
                    Barcode_Part(2) = txtbarcode.Text.Substring(17, 2)
                    txtIDproblem.Focus()
                    Dim sql As String = ""
                    sql += "SELECT CModelName FROM  SHA_Models "
                    sql += " where CSetID='" & Barcode_Part(1) & "'"
                    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "SHA_Models")
                    txtmodel.DataSource = ds.Tables(0)
                    txtmodel.DisplayMember = "CModelName"
                    txtmodel.Sorted = True
                    Exit Sub
                ElseIf txtbarcode.Text.Length = 20 Then
                    Dim Barcode_Part1(3) As String
                    Barcode_Part1(0) = txtbarcode.Text.Substring(0, 13)
                    Barcode_Part1(1) = txtbarcode.Text.Substring(13, 5)
                    Barcode_Part1(2) = txtbarcode.Text.Substring(18, 2)

                    txtIDproblem.Focus()
                    Dim sql1 As String = ""
                    sql1 += "SELECT CModelName FROM  SHA_Models "
                    sql1 += " where CSetID='" & Barcode_Part1(1) & "'"
                    Dim da1 As New SqlClient.SqlDataAdapter(sql1, cn)
                    Dim ds1 As New DataSet
                    da1.Fill(ds1, "SHA_Models")
                    txtmodel.DataSource = ds1.Tables(0)
                    txtmodel.DisplayMember = "CModelName"
                    txtmodel.Sorted = True
                    Exit Sub
                ElseIf txtbarcode.Text.Length = 21 Then
                    Dim Barcode_Part(3) As String
                    Barcode_Part(0) = txtbarcode.Text.Substring(0, 13)
                    Barcode_Part(1) = txtbarcode.Text.Substring(13, 6)
                    Barcode_Part(2) = txtbarcode.Text.Substring(19, 2)
                    txtIDproblem.Focus()
                    Dim sql1 As String = ""
                    sql1 += "SELECT CModelName FROM  SHA_Models "
                    sql1 += " where CSetID='" & Barcode_Part(1) & "'"
                    Dim da1 As New SqlClient.SqlDataAdapter(sql1, cn)
                    Dim ds1 As New DataSet
                    da1.Fill(ds1, "SHA_Models")
                    txtmodel.DataSource = ds1.Tables(0)
                    txtmodel.DisplayMember = "CModelName"
                    txtmodel.Sorted = True
                Else

                    MsgBox("This series is wrong")
                End If
                '   End If

            Catch ex As Exception

            End Try
            ' End If
        End If
    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub txtsv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsv.KeyDown
        If e.KeyCode = Keys.Enter Then

            df.Text = txtsv.Text


            txtlinandshift.Focus()

        End If
    End Sub

    Private Sub txtsv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtsv.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtbarcode.Text = "" Or txtIDproblem.Text = "" Or txtresonProblem.Text = "" Or txttypeProblem.Text = "" Or txtLaberProblem.Text = "" Then
            MsgBox("الرجاء التأكد من صحة ادخال البيانات ")
        Else

            Add1_New()
            _Refresh3()
            _Refresh3v()
            _Refreshdgd()

            _Refresh3p()
            txtbarcode.Text = ""
            txtIDproblem.Text = ""
            txtresonProblem.Text = ""
            txttypeProblem.Text = ""
            txtLaberProblem.Text = ""
            txtbarcode.Focus()

        End If
    End Sub

    Private Sub dgqty_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgqty.CellClick
        txtmodel.Text = dgqty.Item(0, dgqty.CurrentRow.Index).Value
    End Sub

    Private Sub dgqty_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgqty.CellContentClick

    End Sub

    Private Sub txtIDproblem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIDproblem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sql As String = ""
                sql += "SELECT R_Name_Problem FROM  SHA_Name_Problems "
                sql += " where R_SN=" & txtIDproblem.Text & ""
                Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
                da.Fill(ds, "SHA_Name_Problems")
                CB1.DataSource = ds.Tables(0)
                CB1.DisplayMember = "R_Name_Problem"
                CB1.Sorted = True

            Catch ex As Exception

            End Try


            '    If e.KeyCode = Keys.Enter Then
            txtresonProblem.Focus()
        End If
    End Sub

    Private Sub txtIDproblem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtIDproblem.SelectedIndexChanged
        CodeProblem.Text = txtIDproblem.SelectedValue.ToString
        ' Label2.Text = txtmodel.Text
    End Sub

    Private Sub txtresonProblem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtresonProblem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sql As String = ""
                sql += "SELECT R_Name_Problem FROM  SHA_Reson_Problems "
                sql += " where R_SN=" & txtresonProblem.Text & ""
                Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
                da.Fill(ds, "SHA_Reson_Problems")
                CB2.DataSource = ds.Tables(0)
                CB2.DisplayMember = "R_Name_Problem"
                CB2.Sorted = True

            Catch ex As Exception

            End Try


            'txtmodel.Sorted = True
            '    If e.KeyCode = Keys.Enter Then
            txttypeProblem.Focus()
        End If

    End Sub

    Private Sub txtresonProblem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtresonProblem.SelectedIndexChanged
        resonProblem.Text = txtresonProblem.SelectedValue.ToString
        ' Label2.Text = txtmodel.Text
    End Sub

    Private Sub txttypeProblem_KeyDown(sender As Object, e As KeyEventArgs) Handles txttypeProblem.KeyDown
        'txtmodel.Sorted = True
        If e.KeyCode = Keys.Enter Then
            txtLaberProblem.Focus()
        End If

    End Sub

    Private Sub txttypeProblem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txttypeProblem.SelectedIndexChanged

    End Sub

    Private Sub txtLaberProblem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLaberProblem.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txtmodel.Text = "" Then
                MsgBox("الرجاء اعادة ادخال بيانات الجهاز حيث يوجد خطأ فى تسجيل هذه البيانات ")
                txtbarcode.Text = ""
                txtIDproblem.Text = ""
                txtresonProblem.Text = ""
                txttypeProblem.Text = ""
                txtLaberProblem.Text = ""
                txtbarcode.Focus()

            Else


                Try
                    Dim sql1 As String = ""
                    sql1 += "SELECT R_Name_Laber FROM  SHA_Name_Laber "
                    sql1 += " where R_Sap=" & txtLaberProblem.Text & ""
                    sql1 += " and R_Line='" & txtsv.Text & "'"
                    Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
                    Dim ds As New DataSet
                    da.Fill(ds, "SHA_Name_Laber")
                    DD.DataSource = ds.Tables(0)
                    DD.DisplayMember = "R_Name_Laber"
                    DD.Sorted = True

                Catch ex As Exception

                End Try
                '  DD.Text = txtLaberProblem.SelectedValue.ToString
                Dim sql As String
                sql = "INSERT INTO SHA_MainRepair"

                sql += "(R_SN_Laber_Repair,R_SN_Problem,R_SN_ResonProblem,R_SN_ProblemLaber,R_ModelName,R_Type_Problem,R_Line,R_Barcode1,R_SV)"
                sql += " VALUES (" & Label12.Text & "," & txtIDproblem.Text & "," & txtresonProblem.Text & "," & txtLaberProblem.Text & ",'" & txtmodel.Text & "','" & txttypeProblem.Text & "','" & txtlinandshift.Text & "','" & txtbarcode.Text & "','" & txtsv.Text & "')"

                Dim cmd As New SqlClient.SqlCommand(sql, cn)
                If cn.State = ConnectionState.Closed Then cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                _Refreshdgd()
                _Refresh3()
                _Refresh3v()
                _Refresh3p()
                '   DD.Text = txtLaberProblem.SelectedValue.ToString

                txtbarcode.Focus()


            End If
        End If
    End Sub

    Private Sub txtLaberProblem_Leave(sender As Object, e As EventArgs) Handles txtLaberProblem.Leave
        ' DD.Text = txtLaberProblem.SelectedValue.ToString
        txtmodel.Text = ""
        txtbarcode.Text = ""
        txtIDproblem.Text = ""
        txtresonProblem.Text = ""
        txttypeProblem.Text = ""
        txtLaberProblem.Text = ""
    End Sub

    Private Sub txtLaberProblem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtLaberProblem.SelectedIndexChanged

        DD.Text = txtLaberProblem.SelectedValue.ToString
        ' Label2.Text = txtmodel.Text
    End Sub

    Private Sub txtcodeUse_KeyDown(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            txtsv.Focus()

        End If
    End Sub
    Public Property StringPassc1 As String
    Private Sub txtcodeUse_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtlinandshift_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlinandshift.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtsv.Text = "" Or txtlinandshift.Text = "" Then
                MsgBox("من فضلك اكمل البيانات ")

            Else
                    _Refresh315()
                    df.Visible = True
                    GroupBox1.Visible = False
                    GroupBox7.Enabled = True

                txtbarcode.Focus()

            End If
            End If

    End Sub

    Private Sub txtlinandshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtlinandshift.SelectedIndexChanged

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub


    Private Sub CB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged

    End Sub

    Private Sub DD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DD.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmSHA_RepairQuery
        frm.Show()

    End Sub
End Class