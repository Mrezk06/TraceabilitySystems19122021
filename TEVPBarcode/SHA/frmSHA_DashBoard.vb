
Imports TEVPBarcode.sher
Public Class frmSHA_DashBoard
    Private Sub frmSHA_DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Function _Refresh15T() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  CQty"
            sql += " FROM SHA_Planmonthly"
            sql += " where CStartDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Planmonthly")
            ds.Tables("SHA_Planmonthly").Columns(0).ColumnName = "Target"
            DGTM.DataSource = ds.Tables("SHA_Planmonthly")
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
            sql += " FROM SHA_MainRepair"
            sql += " where R_date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_MainRepair")
            ds.Tables("SHA_MainRepair").Columns(0).ColumnName = "Repair QTY"
            dgr.DataSource = ds.Tables("SHA_MainRepair")
            dgr.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15A() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count(CBarcode) "
            sql += " FROM SHA_Output_Production"
            sql += " where CDate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = "Actually"
            DGAM.DataSource = ds.Tables("SHA_Output_Production")
            DGAM.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh15D() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  Qty "
            sql += " FROM SHA_Diff_Month"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Diff_Month")
            ds.Tables("SHA_Diff_Month").Columns(0).ColumnName = "Difference"
            DGDM.DataSource = ds.Tables("SHA_Diff_Month")
            DGDM.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13tt222() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT COUNT(CBarcode) AS Qty FROM  SHA_Output_Production"
            sql += " WHERE (CDate >= CONVERT(nvarchar(10), GETDATE(), 121))"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_Output_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("SHA_Output_Production").Columns(0).ColumnName = "Daily QTY "
            dg5.DataSource = ds.Tables("SHA_Output_Production")
            dg5.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " select CModelName, CQty, qty, qty - CQty AS cqty, CLineAndShift"
            sql += " FROM SHA_DiFF_Target_AC"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "SHA_DiFF_Target_AC")
            ds.Tables("SHA_DiFF_Target_AC").Columns(0).ColumnName = "Model Name"
            ds.Tables("SHA_DiFF_Target_AC").Columns(1).ColumnName = "QTy Target"
            ds.Tables("SHA_DiFF_Target_AC").Columns(2).ColumnName = "QTy Actually"
            ds.Tables("SHA_DiFF_Target_AC").Columns(3).ColumnName = "QTy Difference"
            ds.Tables("SHA_DiFF_Target_AC").Columns(4).ColumnName = " Line"
            dgdd.DataSource = ds.Tables("SHA_DiFF_Target_AC")
            dgdd.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub dgdd_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgdd.CellFormatting

        If e.ColumnIndex = 3 AndAlso e.Value IsNot Nothing Then

            Dim quantity As Int32 = Convert.ToInt32(e.Value)
            If quantity < 0 Then
                dgdd.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red

            Else
                dgdd.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Green
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh15T()
        _Refresh15A()
        _Refresh15D()
        _Refresh155()

        _Refresh15R()

        _Refresh13tt222()
    End Sub
End Class