
Imports TEVPBarcode.sher
Public Class frmAfterSales_AddNewInformation
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        _Refresh112()
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql1 As String = "SELECT R_SN_ID,R_SN_Problem,R_Areat,R_factory FROM AfterSales_Problem"
            sql1 += "   where R_factory ='Cooker'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_Problem")
            ds.Tables("AfterSales_Problem").Columns(0).ColumnName = "Code"
            ds.Tables("AfterSales_Problem").Columns(1).ColumnName = "Problem Name"
            ds.Tables("AfterSales_Problem").Columns(2).ColumnName = "Area"
            ds.Tables("AfterSales_Problem").Columns(3).ColumnName = "Factory"
            dg.DataSource = ds.Tables("AfterSales_Problem")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO AfterSales_Problem "
            sql += "(R_SN_ID,R_SN_Problem,R_Areat,R_factory)"
            sql += " VALUES (" & TextBox1.Text & ",'" & TextBox2.Text & "','1','Cooker')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [AfterSales_Problem]"
            sql += " where R_SN =" & TextBox1.Text & ""
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update1A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  AfterSales_Problem set"
            sql += " R_SN_Problem = '" & TextBox2.Text & "'"
            sql += " where R_SN =" & TextBox1.Text & ""
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        _Refresh1()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Add1_New()
        _Refresh1()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Update1A()
        _Refresh1()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Del_Rec()
        _Refresh1()
    End Sub
    Private Function _Refresh11() As Boolean
        Try
            Dim sql1 As String = "SELECT R_SN_ID,R_SN_ResonProblem,R_Areat,R_factory FROM AfterSales_ResonProblem"
            sql1 += "   where R_factory ='Cooker'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_ResonProblem")
            ds.Tables("AfterSales_ResonProblem").Columns(0).ColumnName = "Code"
            ds.Tables("AfterSales_ResonProblem").Columns(1).ColumnName = "Problem Name"
            ds.Tables("AfterSales_ResonProblem").Columns(2).ColumnName = "Area"
            ds.Tables("AfterSales_ResonProblem").Columns(3).ColumnName = "Factory"
            dg.DataSource = ds.Tables("AfterSales_ResonProblem")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_New1() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO AfterSales_ResonProblem "
            sql += "(R_SN_ID,R_SN_ResonProblem,R_Areat,R_factory)"
            sql += " VALUES (" & txtResonProblem.Text & ",'" & txtNameResonProblem.Text & "','1','Cooker')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec1() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM AfterSales_ResonProblem"
            sql += " where R_SN_ID =" & txtResonProblem.Text & ""
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update1A1() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  AfterSales_ResonProblem set"
            sql += " R_SN_ResonProblem = '" & txtNameResonProblem.Text & "'"
            sql += " where R_SN_ID =" & txtResonProblem.Text & ""
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Update1A1()
        _Refresh11()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Del_Rec1()
        _Refresh11()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Add1_New1()
        _Refresh11()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        _Refresh11()
    End Sub

    Private Function _Refresh112() As Boolean
        Try
            Dim sql1 As String = "SELECT R_SN_ID,R_SN_ResonProblem,R_Areat,R_factory FROM AfterSales_ResonToReturn"
            sql1 += "   where R_factory ='Cooker'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_ResonToReturn")
            ds.Tables("AfterSales_ResonToReturn").Columns(0).ColumnName = "Code"
            ds.Tables("AfterSales_ResonToReturn").Columns(1).ColumnName = "Problem Name"
            ds.Tables("AfterSales_ResonToReturn").Columns(2).ColumnName = "Area"
            ds.Tables("AfterSales_ResonToReturn").Columns(3).ColumnName = "Factory"
            dg.DataSource = ds.Tables("AfterSales_ResonToReturn")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_New12() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO AfterSales_ResonToReturn "
            sql += "(R_SN_ID,R_SN_ResonProblem,R_Areat,R_factory)"
            sql += " VALUES (" & txtCodeProblem.Text & ",'" & txtCodeNameProblem.Text & "','1','Cooker')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec12() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM AfterSales_ResonToReturn"
            sql += " where R_SN_ID =" & txtCodeProblem.Text & ""
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update1A12() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  AfterSales_ResonToReturn set"
            sql += " R_SN_ResonProblem = '" & txtCodeNameProblem.Text & "'"
            sql += " where R_SN_ID =" & txtCodeProblem.Text & ""
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Update1A12()
        _Refresh112()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Del_Rec12()
        _Refresh112()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add1_New12()
        _Refresh112()
    End Sub
    Private Function _Refresh1123() As Boolean
        Try
            Dim sql1 As String = "SELECT R_SN_ID,R_SN_ResonProblem,R_Areat,R_factory FROM AfterSales_TypeProblem"
            sql1 += "   where R_factory ='Cooker'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "AfterSales_TypeProblem")
            ds.Tables("AfterSales_TypeProblem").Columns(0).ColumnName = "Code"
            ds.Tables("AfterSales_TypeProblem").Columns(1).ColumnName = "Problem Name"
            ds.Tables("AfterSales_TypeProblem").Columns(2).ColumnName = "Area"
            ds.Tables("AfterSales_TypeProblem").Columns(3).ColumnName = "Factory"
            dg.DataSource = ds.Tables("AfterSales_TypeProblem")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function Add1_New123() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO AfterSales_TypeProblem "
            sql += "(R_SN_ID,R_SN_ResonProblem,R_Areat,R_factory)"
            sql += " VALUES (" & TextBox3.Text & ",'" & TextBox4.Text & "','1','Cooker')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec123() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM AfterSales_TypeProblem"
            sql += " where R_SN_ID =" & TextBox3.Text & ""
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update1A123() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  AfterSales_TypeProblem set"
            sql += " R_SN_ResonProblem = '" & TextBox4.Text & "'"
            sql += " where R_SN_ID =" & TextBox3.Text & ""
            sql += " and R_Areat ='1'"
            sql += " and R_factory ='Cooker'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Public Property StringPassc5 As String
    Private Sub frmAfterSales_AddNewInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        _Refresh1123()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Del_Rec123()
        _Refresh1123()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Update1A123()
        _Refresh1123()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Add1_New123()
        _Refresh1123()
    End Sub
End Class