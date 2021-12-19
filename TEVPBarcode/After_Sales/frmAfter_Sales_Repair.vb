Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmAfter_Sales_Repair
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "INSERT INTO AfterSales_MainRepair"

            sql += "(R_Barcode_Old,R_Barcode_New,R_SN_Sap_User,R_SN_Problem,R_SN_ResonProblem,R_Type_Problem,R_SN_ResonToReturn,R_Areat,R_factory,R_InspactionResult,R_ModelName)"
            sql += " VALUES ('" & txtbarcodeOld.Text & "','" & txtbarcodeNew.Text & "'," & Label13.Text & "," & txtproblem.Text & "," & txtresonProblem.Text & "," & txtTypeProblem1.Text & "," & txtResonToReturn.Text & ",'1','Cooker','" & txtResultInspaction.Text & "','" & txtmodel.Text & "')"

            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()

        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            ' sql += " FROM Output"
            sql += " where Heater_Sap_Laber='" & Label13.Text & "'"
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
            sql += "SELECT R_ModelName,count(R_ModelName) FROM  AfterSales_MainRepair "
            ' sql += " FROM Output"
            sql += " where R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " group by R_ModelName"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_MainRepair")
            ds.Tables("AfterSales_MainRepair").Columns(0).ColumnName = "الموديل"
            ' ds.Tables("R_MainRepair").Columns(1).ColumnName = "Type_Problem"
            ds.Tables("AfterSales_MainRepair").Columns(1).ColumnName = "الكمية"
            dgqty.DataSource = ds.Tables("AfterSales_MainRepair")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15T() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count(R_ModelName)"
            sql += " FROM AfterSales_MainRepair"
            sql += " where R_date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_MainRepair")
            ds.Tables("AfterSales_MainRepair").Columns(0).ColumnName = "Monthly QTY"
            dgn.DataSource = ds.Tables("AfterSales_MainRepair")
            dgn.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Function
    Private Function _RefreshDDDnnv() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            sql += " WHERE R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += " and Expr2 <> R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dgpr.DataSource = ds.Tables("AfterSales_View1")
            dgpr.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _RefreshDDDnn1v() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_ModelName) FROM  barcode.dbo.AfterSales_View1 "
            sql += " WHERE R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            sql += " and Expr2 = R_SN_ResonToReturn"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_View1")
            ds.Tables("AfterSales_View1").Columns(0).ColumnName = "الكمية"
            dgve.DataSource = ds.Tables("AfterSales_View1")
            dgve.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13tt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (R_ModelName)as qty"
            sql += " FROM AfterSales_MainRepair"
            sql += " WHERE R_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_factory='Cooker'"
            sql += " and R_Areat='1'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_MainRepair")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("AfterSales_MainRepair").Columns(0).ColumnName = "Daily QTY "
            dgd.DataSource = ds.Tables("AfterSales_MainRepair")
            dgd.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Function _Refresh3v() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT R_Type_Problem,count( R_Barcode1)FROM  C_MainRepair "
    '        ' sql += " FROM Output"
    '        sql += " where R_Line='" & txtlinandshift.Text & "'"
    '        sql += " and R_Type_Problem='Vendor'"
    '        sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
    '        sql += " group by R_Type_Problem"

    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "C_MainRepair")
    '        ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
    '        ds.Tables("C_MainRepair").Columns(0).ColumnName = "نوع العيب"
    '        ds.Tables("C_MainRepair").Columns(1).ColumnName = "الكمية"
    '        dgve.DataSource = ds.Tables("C_MainRepair")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    'Private Function _Refreshdgd() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT R_Name_Problem,count( R_Barcode1) FROM Crepair1"
    '        ' sql += " FROM Output"
    '        sql += " where R_Line='" & txtlinandshift.Text & "'"
    '        '  sql += " and R_Type_Problem='PROCESS'"
    '        sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
    '        sql += " group by R_Name_Problem"

    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Crepair1")
    '        ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
    '        ds.Tables("Crepair1").Columns(0).ColumnName = "اسم المشكلة"
    '        ds.Tables("Crepair1").Columns(1).ColumnName = "الكمية"
    '        dgd.DataSource = ds.Tables("Crepair1")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    'Private Function _Refresh3p() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += "SELECT R_Type_Problem,count( R_Barcode1)FROM  C_MainRepair "
    '        ' sql += " FROM Output"
    '        sql += " where R_Line='" & txtlinandshift.Text & "'"
    '        sql += " and R_Type_Problem='Process'"
    '        sql += " and R_date >= Convert(nvarchar(10), GETDATE(), 121)"
    '        sql += " group by R_Type_Problem"

    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "C_MainRepair")
    '        ' ds.Tables("R_MainRepair").Columns(0).ColumnName = "ModelName"
    '        ds.Tables("C_MainRepair").Columns(0).ColumnName = "نوع العيب"
    '        ds.Tables("C_MainRepair").Columns(1).ColumnName = "الكمية"
    '        dgpr.DataSource = ds.Tables("C_MainRepair")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Public Property StringPassc4 As String
    Private Sub frmAfter_Sales_Repair_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = StringPassc4
        '  GroupBox7.Enabled = False
        _Refresh315()

        Try
            Dim sql11 As String = ""
            sql11 += " SELECT R_SN_ID,R_SN_Problem FROM AfterSales_Problem "
            sql11 += " where R_Areat='1'"
            sql11 += " and R_factory='Cooker'"
            Dim da11 As New SqlClient.SqlDataAdapter(sql11, cn)
            Dim ds11 As New DataSet
            ds11.Tables.Clear()
            da11.Fill(ds11, "AfterSales_Problem")
            CB1.DataSource = ds11.Tables(0)
            CB1.ValueMember = "R_SN_ID"
            CB1.DisplayMember = "R_SN_Problem"
            CB1.Sorted = True
            '  _Refresh1()
        Catch ex As Exception
        End Try
        Try
            Dim sql11 As String = ""
            sql11 += " SELECT R_SN_ID,R_SN_ResonProblem FROM AfterSales_ResonProblem "
            sql11 += " where R_Areat='1'"
            sql11 += " and R_factory='Cooker'"
            Dim da11 As New SqlClient.SqlDataAdapter(sql11, cn)
            Dim ds11 As New DataSet
            ds11.Tables.Clear()
            da11.Fill(ds11, "AfterSales_ResonProblem")
            CB2.DataSource = ds11.Tables(0)
            CB2.ValueMember = "R_SN_ID"
            CB2.DisplayMember = "R_SN_ResonProblem"
            CB2.Sorted = True
            '  _Refresh1()
        Catch ex As Exception
        End Try
        'Try
        '    Dim sql11 As String = ""
        '    sql11 += " SELECT R_SN_ID,R_SN_ResonProblem FROM AfterSales_ResonToReturn "
        '    sql11 += " where R_Areat='1'"
        '    sql11 += " and R_factory='Cooker'"
        '    Dim da11 As New SqlClient.SqlDataAdapter(sql11, cn)
        '    Dim ds11 As New DataSet
        '    ds11.Tables.Clear()
        '    da11.Fill(ds11, "AfterSales_ResonToReturn")
        '    txttypeProblem.DataSource = ds11.Tables(0)
        '    txttypeProblem.ValueMember = "R_SN_ID"
        '    txttypeProblem.DisplayMember = "R_SN_ResonProblem"
        '    txttypeProblem.Sorted = True
        '    '  _Refresh1()
        'Catch ex As Exception

        '  End Try

        Try
            Dim sql11 As String = ""
            sql11 += " SELECT R_SN_ID,R_SN_Problem FROM AfterSales_Problem "
            sql11 += " where R_Areat='1'"
            sql11 += " and R_factory='Cooker'"
            Dim da11 As New SqlClient.SqlDataAdapter(sql11, cn)
            Dim ds11 As New DataSet
            ds11.Tables.Clear()
            da11.Fill(ds11, "AfterSales_Problem")
            txttypeProblem.DataSource = ds11.Tables(0)
            txttypeProblem.ValueMember = "R_SN_ID"
            txttypeProblem.DisplayMember = "R_SN_Problem"
            txttypeProblem.Sorted = True
            '  _Refresh1()
        Catch ex As Exception
        End Try
        Try
            Dim sql11 As String = ""
            sql11 += " SELECT R_SN_ID,R_SN_ResonProblem FROM AfterSales_TypeProblem "
            sql11 += " where R_Areat='1'"
            sql11 += " and R_factory='Cooker'"
            Dim da11 As New SqlClient.SqlDataAdapter(sql11, cn)
            Dim ds11 As New DataSet
            ds11.Tables.Clear()
            da11.Fill(ds11, "AfterSales_TypeProblem")
            CB4.DataSource = ds11.Tables(0)
            CB4.ValueMember = "R_SN_ID"
            CB4.DisplayMember = "R_SN_ResonProblem"
            CB4.Sorted = True
            '  _Refresh1()
        Catch ex As Exception

        End Try
        CB1.Enabled = False
        txtresonProblem.Enabled = False
        txttypeProblem.Enabled = False
        txtproblem.Enabled = False
        txtresonProblem.Enabled = False
        txtResultInspaction.Enabled = False
        txttypeProblem.Enabled = False
        CB4.Enabled = False
        txtbarcodeOld.Enabled = False
        txtbarcodeNew.Enabled = False
        CB2.Enabled = False
        CB4.Enabled = False
        txtbarcodeOld.Enabled = True
        txtbarcodeOld.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtproblem.Text = "" Or txtTypeProblem1.Text = "" Or txtresonProblem.Text = "" Or txtResultInspaction.Text = "" Or txttypeProblem.Text = "" Or CB4.Text = "" Or txtbarcodeOld.Text = "" Or txtbarcodeNew.Text = "" Or CB2.Text = "" Or CB1.Text = "" Or CB4.Text = "" Then
                MsgBox("الرجاء التأكد من صحة ادخال البيانات ")
            Else

                Add1_New()
                _Refresh3()
                _Refresh13tt()
                _Refresh15T()
                _RefreshDDDnn1v()
                _RefreshDDDnnv()
                CB1.Text = ""
                txtresonProblem.Text = ""
                txtmodel.Text = ""
                txttypeProblem.Text = ""
                txtResonToReturn.Text = ""
                txtproblem.Text = ""
                txtresonProblem.Text = ""
                txtTypeProblem1.Text = ""
                txtResultInspaction.Text = ""
                txttypeProblem.Text = ""
                CB4.Text = ""
                txtbarcodeOld.Text = ""
                txtbarcodeNew.Text = ""
                CB2.Text = ""
                CB4.Text = ""

                txtbarcodeOld.Enabled = True
                txtbarcodeOld.Focus()
                txtbarcodeOld.SelectAll()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged
        Try
            txtproblem.Text = CB1.SelectedValue.ToString
            '  Label2.Text = cmb_Pcode.Text
            ' txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CB2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB2.SelectedIndexChanged
        Try
            txtresonProblem.Text = CB2.SelectedValue.ToString
            '  Label2.Text = cmb_Pcode.Text
            ' txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txttypeProblem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txttypeProblem.SelectedIndexChanged
        Try
            txtResonToReturn.Text = txttypeProblem.SelectedValue.ToString
            '  Label2.Text = cmb_Pcode.Text
            ' txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CB4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB4.SelectedIndexChanged
        Try
            txtTypeProblem1.Text = CB4.SelectedValue.ToString
            '  Label2.Text = cmb_Pcode.Text
            ' txtFATSERIAL.Enabled = True
            '_Refresh1()
        Catch ex As Exception

        End Try
    End Sub

    ' Private Sub txtbarcodeOld_TextChanged(sender As Object, e As EventArgs) Handles txtbarcodeOld.KeyDown
    Private Sub txtbarcodeOld_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcodeOld.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtbarcodeOld.TextLength = 18 Then

                    Try
                        Dim sql As String = ""
                        sql += "SELECT CModelName FROM C_Output_Production "
                        ' sql += " FROM Output"
                        sql += " where CBarcode='" & txtbarcodeOld.Text & "'"
                        'sql += " and fpanelID='" & Barcode_Part(6) & "'"
                        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                        Dim ds As New DataSet
                        da.Fill(ds, "C_Output_Production")
                        txtmodel.DataSource = ds.Tables(0)
                        ' txtresonProblem.ValueMember = "R_Name_Problem"
                        txtmodel.DisplayMember = "CModelName"
                        txtmodel.Sorted = True
                    Catch ex As Exception
                    End Try

                    txtbarcodeOld.Enabled = False
                    txtbarcodeNew.Enabled = True
                    txtbarcodeNew.Focus()
                    txtbarcodeNew.SelectAll()
                Else
                    MsgBox("this Barcode Is Wrong ?")
                    txtbarcodeOld.SelectAll()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtbarcodeOld_TextChanged_1(sender As Object, e As EventArgs) Handles txtbarcodeOld.TextChanged

    End Sub
    Private Sub txtbarcodeNew_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcodeNew.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtbarcodeNew.TextLength = 18 Then



                    txtbarcodeNew.Enabled = False
                    CB1.Enabled = True
                    CB1.Focus()
                    CB1.SelectAll()
                Else
                    MsgBox("this Barcode Is Wrong ?")
                    txtbarcodeNew.SelectAll()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    '   Private Sub CB2_SelectedKeyDown(sender As Object, e As EventArgs) Handles CB2.KeyDown
    ' Private Sub CB2_SelectedKeyDown(sender As Object, e As KeyEventArgs) Handles CB2.KeyDown
    Private Sub CB2_KeyDown(sender As Object, e As KeyEventArgs) Handles CB2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                txttypeProblem.Enabled = True
                CB2.Enabled = False
                txttypeProblem.Focus()
                txttypeProblem.SelectAll()
            End If
        Catch ex As Exception

        End Try
    End Sub
    '   Private Sub CB4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB4.SelectedIndexChanged
    ' Private Sub CB4_SelectedKeyDown(sender As Object, e As KeyEventArgs) Handles CB4.KeyDown
    Private Sub CB4_KeyDown(sender As Object, e As KeyEventArgs) Handles CB4.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then

                CB4.Enabled = False
                txtResultInspaction.Enabled = True
                txtResultInspaction.Focus()
                txtResultInspaction.SelectAll()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbarcodeNew_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub CB1_SelectedKeyDown(sender As Object, e As KeyEventArgs) Handles CB1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                CB1.Enabled = False
                CB2.Enabled = True
                CB2.Focus()
                CB2.SelectAll()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txttypeProblem_SelectedKeyDown(sender As Object, e As KeyEventArgs) Handles txttypeProblem.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txttypeProblem.Enabled = False
                CB4.Enabled = True
                CB4.Focus()
                CB4.SelectAll()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CB1.Text = ""
        txtresonProblem.Text = ""
        txtmodel.Text = ""
        txttypeProblem.Text = ""
        txtResonToReturn.Text = ""
        txtproblem.Text = ""
        txtresonProblem.Text = ""
        txtTypeProblem1.Text = ""
        txtResultInspaction.Text = ""
        txttypeProblem.Text = ""
        CB4.Text = ""
        txtbarcodeOld.Text = ""
        txtbarcodeNew.Text = ""
        CB2.Text = ""
        CB4.Text = ""
        txtbarcodeOld.Enabled = True
        txtbarcodeOld.Focus()
        txtbarcodeOld.SelectAll()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmAfter_Sales_Repair_Query
        frm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Del_Rec1()
        _Refresh3()
        _Refresh13tt()
        _Refresh15T()
        txtbarcodeOld.Text = ""
        txtbarcodeNew.Text = ""
        txtbarcodeOld.Enabled = True
        txtbarcodeNew.Enabled = False
        txtbarcodeOld.Focus()
        txtbarcodeOld.SelectAll()
    End Sub
    Private Function Del_Rec1() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM AfterSales_MainRepair"
            sql += " where R_Barcode_Old ='" & txtbarcodeOld.Text & "'"
            sql += " and R_Barcode_New ='" & txtbarcodeNew.Text & "'"
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
End Class