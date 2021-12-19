Imports TEVPBarcode.sher
Public Class frmHeaterDashBoard
    Private Sub frmCookerDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Function _Refresh15T() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  fQty"
            sql += " FROM Heater_PlanforMonth"
            sql += " where fdate >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_PlanforMonth")
            ds.Tables("Heater_PlanforMonth").Columns(0).ColumnName = "Target"
            DGTM.DataSource = ds.Tables("Heater_PlanforMonth")
            Return True
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Function
    Private Function _Refresh15R() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count(R_BarcodeP1)"
            sql += " FROM Heater_Repair"
            sql += " where R_date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Repair")
            ds.Tables("Heater_Repair").Columns(0).ColumnName = "Repair QTY"
            dgr.DataSource = ds.Tables("Heater_Repair")
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
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15A() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count(H_Heater_Code) "
            sql += " FROM Heater_registration_Three1"
            sql += " where H_date >=DATEADD(m, DATEDIFF(m, 0, GETDATE()), 0)"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_registration_Three1")
            ds.Tables("Heater_registration_Three1").Columns(0).ColumnName = "Actually"
            DGAM.DataSource = ds.Tables("Heater_registration_Three1")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15D() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  diff "
            sql += " FROM DiffMonthlyHeater1"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "DiffMonthlyHeater1")
            ds.Tables("DiffMonthlyHeater1").Columns(0).ColumnName = "Difference"
            DGDM.DataSource = ds.Tables("DiffMonthlyHeater1")
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
    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT H_Model_Name, CQty, qty, Diff, H_Shift_Line"
            sql += " FROM Diff_Targ_AcualHeater"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Diff_Targ_AcualHeater")
            ds.Tables("Diff_Targ_AcualHeater").Columns(0).ColumnName = "Model Name"
            ds.Tables("Diff_Targ_AcualHeater").Columns(1).ColumnName = "QTy Target"
            ds.Tables("Diff_Targ_AcualHeater").Columns(2).ColumnName = "QTy Actually"
            ds.Tables("Diff_Targ_AcualHeater").Columns(3).ColumnName = "QTy Difference"
            ds.Tables("Diff_Targ_AcualHeater").Columns(4).ColumnName = " Line"
            dgdd.DataSource = ds.Tables("Diff_Targ_AcualHeater")
            Return True
        Catch ex As Exception
        End Try
    End Function
End Class