
Imports TEVPBarcode.sher
Public Class frmCookerDashBoard
    Private Sub frmCookerDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Function _Refresh15T() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  CQty"
            sql += " FROM CPlanmonthly"
            sql += " where CStartDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "CPlanmonthly")
            ds.Tables("CPlanmonthly").Columns(0).ColumnName = "Target"
            DGTM.DataSource = ds.Tables("CPlanmonthly")
            DGTM.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Function


    Private Function _Refresh15R() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count([R_Barcode1])"
            sql += " FROM C_MainRepair"
            sql += " where R_date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_MainRepair")
            ds.Tables("C_MainRepair").Columns(0).ColumnName = "Repair QTY"
            dgr.DataSource = ds.Tables("C_MainRepair")
            dgr.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15Q() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count([fLCDBarcode])"
            sql += " FROM Cquality_IM"
            sql += " where fPDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Cquality_IM")
            ds.Tables("Cquality_IM").Columns(0).ColumnName = "Quality QTY"
            dgq.DataSource = ds.Tables("Cquality_IM")
            dgq.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15A() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count(CBarcode) "
            sql += " FROM C_Output_Production"
            sql += " where CDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ds.Tables("C_Output_Production").Columns(0).ColumnName = "Actually"
            DGAM.DataSource = ds.Tables("C_Output_Production")
            DGAM.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15D() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  Expr1 "
            sql += " FROM DiffMonthlyCooker2222"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DiffMonthlyCooker2222")
            ds.Tables("DiffMonthlyCooker2222").Columns(0).ColumnName = "Difference"
            DGDM.DataSource = ds.Tables("DiffMonthlyCooker2222")
            DGDM.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh15T()
        _Refresh15A()
        _Refresh15D()
        _Refresh155()
        _Refresh15Q()
        _Refresh15R()
        _Refresh13t00mmmmmmm()
        _Refresh13t0121t()
        _Refresh13tt()
        _Refresh13ttmmmmmmmmmmmm()
        '_Refresh13ttmmmmmmmmmmmm()
        _Refresh13tt222()
        _Refresh13tt22201()
    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
    Private Function _Refresh13ttmmmmmmmmmmmm() As Boolean
        Try
            ' Dim sss As String = "CL"
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            'sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " where CDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            '  sql += " and C_Line_Shift LIKE '%" & sss & "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " QTY"
            dg4.DataSource = ds.Tables("C_FinishGood_Production")
            dg4.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13t00mmmmmmm() As Boolean
        Try
            ' Dim sss As String = "CL"
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            'sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " where CDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            sql += " and C_Line_Shift LIKE '%" & sss1 & "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " QTY"
            dghjk.DataSource = ds.Tables("C_FinishGood_Production")
            dghjk.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13tt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"

            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '    sql += " and C_Line_Shift LIKE '%" & sss & "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " QTY "
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            dg3.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13t0121t() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            'sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            'sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " WHERE CDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and C_Line_Shift LIKE '%" & sss1 & "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " QTY "
            dgfgf.DataSource = ds.Tables("C_FinishGood_Production")
            dgfgf.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Dim sss As String = "C"
    Dim sss1 As String = "M"
    Private Function _Refresh13tt222() As Boolean
        Try

            Dim sql As String = ""
            sql += " SELECT COUNT(CBarcode) AS Qty FROM  C_Output_Production"
            sql += " WHERE (CDate >= CONVERT(nvarchar(10), GETDATE(), 121))"
            sql += " and C_Line_Shift LIKE '%" & sss & "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " QTY "
            dg5.DataSource = ds.Tables("C_Output_Production")
            dg5.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13tt22201() As Boolean
        Try
            Dim sss As String = "ML"
            Dim sql As String = ""
            sql += " SELECT COUNT(CBarcode) AS Qty FROM  C_Output_Production"
            sql += " WHERE (CDate >= CONVERT(nvarchar(10), GETDATE(), 121))"
            sql += " and C_Line_Shift LIKE '%" & sss & "%'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Output_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_Output_Production").Columns(0).ColumnName = " QTY "
            DGM.DataSource = ds.Tables("C_Output_Production")
            DGM.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName,CQty,qty,qtyd,CLineAndShift"
            sql += " FROM Diff_Targ_AcualCooker"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Diff_Targ_AcualCooker")
            ds.Tables("Diff_Targ_AcualCooker").Columns(0).ColumnName = "Model Name"
            ds.Tables("Diff_Targ_AcualCooker").Columns(1).ColumnName = "QTy Target"
            ds.Tables("Diff_Targ_AcualCooker").Columns(2).ColumnName = "QTy Actually"
            ds.Tables("Diff_Targ_AcualCooker").Columns(3).ColumnName = "QTy Difference"
            ds.Tables("Diff_Targ_AcualCooker").Columns(4).ColumnName = " Line"
            dgdd.DataSource = ds.Tables("Diff_Targ_AcualCooker")
            dgdd.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub dgdd_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgdd.CellFormatting
        'Compare the value of second Column i.e. Column with Index 1.
        If e.ColumnIndex = 3 AndAlso e.Value IsNot Nothing Then

            Dim quantity As Int32 = Convert.ToInt32(e.Value)
            If quantity < 0 Then
                dgdd.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red

            Else
                dgdd.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Green
            End If
        End If
    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub
End Class