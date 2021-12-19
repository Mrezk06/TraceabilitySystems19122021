
Imports TEVPBarcode.sher
Public Class frmCookerAddNewInformation


    '  Public Class frmAddingNewInformation
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.C_Name_Problems "
            sql += "( R_SN, R_Name_Problem)"
            sql += " VALUES (" & txtCodeProblem.Text & ",'" & txtCodeNameProblem.Text & "')"



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
            sql = "	DELETE FROM [barcode].[dbo].[C_Name_Problems]"
            sql += " where R_SN =" & txtCodeProblem.Text & ""

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
            sql = " UPDATE  C_Name_Problems set"
            sql += " R_Name_Problem = '" & txtCodeNameProblem.Text & "'"
            'sql += " fpanelID = '" & txtpanelid.Text & "',"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where R_SN = " & txtCodeProblem.Text & ""
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT R_SN, R_Name_Problem FROM C_Name_Problems"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Name_Problems")
            ds.Tables("C_Name_Problems").Columns(0).ColumnName = "Code"
            ds.Tables("C_Name_Problems").Columns(1).ColumnName = "Problem Name"
            ' ds.Tables("LCDTVModels").Columns(2).ColumnName = "fpanelID"
            ' ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("C_Name_Problems")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Sub frmAddingNewInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Del_Rec()
        _Refresh1()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        _Refresh1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Update1A()
        _Refresh1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add1_New()
        _Refresh1()
        txtCodeProblem.Text = ""
        txtCodeNameProblem.Text = ""

    End Sub
    Private Function Add1_New1() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.C_Reson_Problems "
            sql += "( R_SN,R_Name_Problem)"

            sql += " VALUES (" & txtResonProblem.Text & ",'" & txtNameResonProblem.Text & "')"



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
            sql = "	DELETE FROM [barcode].[dbo].[C_Reson_Problems]"
            sql += " where R_SN =" & txtResonProblem.Text & ""

            Dim cmd As New SqlClient.SqlCommand(sql, cn)

            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As Exception

        End Try
    End Function
    Private Function Update11A() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  C_Reson_Problems set"
            sql += " R_Name_Problem = '" & txtNameResonProblem.Text & "'"
            'sql += " fpanelID = '" & txtpanelid.Text & "',"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where R_SN = " & txtResonProblem.Text & ""
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT R_SN, R_Name_Problem FROM C_Reson_Problems"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Reson_Problems")
            ds.Tables("C_Reson_Problems").Columns(0).ColumnName = "Code"
            ds.Tables("C_Reson_Problems").Columns(1).ColumnName = "reason Name"
            ' ds.Tables("LCDTVModels").Columns(2).ColumnName = "fpanelID"
            ' ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("C_Reson_Problems")

            Return True

        Catch ex As Exception

        End Try
    End Function

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        _Refresh11()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Del_Rec1()
        _Refresh11()
        txtNameResonProblem.Text = ""
        txtResonProblem.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Update11A()
        _Refresh11()
        txtNameResonProblem.Text = ""
        txtResonProblem.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Add1_New1()
        _Refresh11()
        txtNameResonProblem.Text = ""
        txtResonProblem.Text = ""
    End Sub
    Private Function Add1_New12() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.C_Name_Laber1 "
            sql += "( R_Sap, R_Name_Laber, R_Line,R_ID)"
            sql += " VALUES (" & txtsap.Text & ",'" & txtName.Text & "','" & txtSV.Text & "'," & txtid.Text & ")"
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
            sql = "	DELETE FROM [barcode].[dbo].[C_Name_Laber1]"
            sql += " where R_Sap =" & txtsap.Text & ""

            Dim cmd As New SqlClient.SqlCommand(sql, cn)

            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As Exception

        End Try
    End Function
    Private Function Update11A2() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  C_Name_Laber1 set"
            sql += " R_Name_Laber = '" & txtName.Text & "',"
            sql += " R_Line = '" & txtSV.Text & "'"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where R_Sap = " & txtsap.Text & ""
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh112() As Boolean
        Try

            Dim sql1 As String = "SELECT R_Sap, R_Name_Laber, R_Line,R_ID FROM C_Name_Laber1"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Name_Laber1")
            ds.Tables("C_Name_Laber1").Columns(0).ColumnName = "code"
            ds.Tables("C_Name_Laber1").Columns(1).ColumnName = " Name"
            ds.Tables("C_Name_Laber1").Columns(2).ColumnName = "Line"
            ds.Tables("C_Name_Laber1").Columns(3).ColumnName = "sap"
            dg.DataSource = ds.Tables("C_Name_Laber1")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        _Refresh112()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Del_Rec12()
        _Refresh112()
        txtsap.Text = ""
        txtid.Text = ""
        txtName.Text = ""
        txtSV.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Update11A2()
        _Refresh112()
        txtsap.Text = ""
        txtid.Text = ""
        txtName.Text = ""
        txtSV.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Add1_New12()
        _Refresh112()

        txtsap.Text = ""
        txtid.Text = ""
        txtName.Text = ""
        txtSV.Text = ""
    End Sub
End Class