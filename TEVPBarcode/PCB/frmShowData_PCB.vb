Imports TEVPBarcode.sher
Public Class frmShowData_PCB

    Private Sub frmShowData_PCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPBlue.ssk"
        Timer1.Enabled = True
    End Sub
    Private Function _Refresho1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM PCBOut"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and fLCDPline ='" & txtline.Text & 
            'ELA_L1()
            ' ELA_L2()
            sql += " and fLine_and_shift ='ELA_L1'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = "Model Name"
            ds.Tables("PCBOut").Columns(1).ColumnName = " Qty"
            dgo1.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresho2() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM PCBOut"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " and fLine_and_shift ='ELA_L2'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBOut")
            ds.Tables("PCBOut").Columns(0).ColumnName = "Model Name"
            ds.Tables("PCBOut").Columns(1).ColumnName = " Qty"
            dgo2.DataSource = ds.Tables("PCBOut")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshn1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM PCBIN"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " and fLine_and_shift ='ELA_L1'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBIN")
            ds.Tables("PCBIN").Columns(0).ColumnName = "Model Name"
            ds.Tables("PCBIN").Columns(1).ColumnName = " Qty"
            dgn1.DataSource = ds.Tables("PCBIN")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshn2() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName, count(fLCDModelName) AS tot"
            sql += " FROM PCBIN"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and fLCDPline ='" & txtline.Text & "'"
            sql += " and fLine_and_shift ='ELA_L2'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "PCBIN")
            ds.Tables("PCBIN").Columns(0).ColumnName = "Model Name"
            ds.Tables("PCBIN").Columns(1).ColumnName = " Qty"
            dgn2.DataSource = ds.Tables("PCBIN")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresho1()
        _Refresho2()
        _Refreshn2()
        _Refreshn1()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class