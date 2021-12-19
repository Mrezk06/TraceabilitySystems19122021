Imports TEVPBarcode.sher
Public Class frmNCANDNM


    '  Public Class frmAddingNewInformation
    Private Function Add1_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_Meal "
            sql += "( RMFID,RMMID,RMMName,RMPrice)"
            sql += " VALUES ('" & txtCodeProblem.Text & "','" & TextBox1.Text & "','" & txtCodeNameProblem.Text & "'," & TextBox2.Text & ")"
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
            sql = "	DELETE FROM [barcode].[dbo].[Restaurant_Meal]"
            sql += " where RMFID ='" & txtCodeProblem.Text & "'"
            sql += " and RMMID ='" & TextBox1.Text & "'"
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
            sql = " UPDATE  Restaurant_Meal set"
            sql += " RMMName = '" & txtCodeNameProblem.Text & "',"
            sql += " RMPrice = " & TextBox2.Text & ""
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where RMFID = '" & txtCodeProblem.Text & "'"
            sql += " and RMMID = '" & TextBox1.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try

            Dim sql1 As String = "SELECT RMFID,RMMID,RMMName,RMPrice FROM Restaurant_Meal"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_Meal")
            ds.Tables("Restaurant_Meal").Columns(0).ColumnName = "MF_ID"
            ds.Tables("Restaurant_Meal").Columns(1).ColumnName = "MM_ID"
            ds.Tables("Restaurant_Meal").Columns(2).ColumnName = "MM_Name"
            ds.Tables("Restaurant_Meal").Columns(3).ColumnName = "Price"
            dg.DataSource = ds.Tables("Restaurant_Meal")

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

    End Sub
    Private Function Add1_New1() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_menu_family "
            sql += "(RMFID,RMFName)"

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
            sql = "	DELETE FROM [barcode].[dbo].[Restaurant_menu_family]"
            sql += " where RMFID =" & txtResonProblem.Text & ""

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
            sql = " UPDATE  Restaurant_menu_family set"
            sql += " RMFName = '" & txtNameResonProblem.Text & "'"
            'sql += " fpanelID = '" & txtpanelid.Text & "',"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where RMFID = " & txtResonProblem.Text & ""
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

            Dim sql1 As String = "SELECT RMFID,RMFName FROM Restaurant_menu_family"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_menu_family")
            ds.Tables("Restaurant_menu_family").Columns(0).ColumnName = "Code"
            ds.Tables("Restaurant_menu_family").Columns(1).ColumnName = "reason Name"
            ' ds.Tables("LCDTVModels").Columns(2).ColumnName = "fpanelID"
            ' ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("Restaurant_menu_family")

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
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Update11A()
        _Refresh11()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Add1_New1()
        _Refresh11()
    End Sub
    Private Function Add1_New12() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_User "
            sql += "(RSap,RName,RPosation)"
            sql += " VALUES ('" & txtid.Text & "','" & txtName.Text & "','" & txtSV.Text & "')"
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
            sql = "	DELETE FROM [barcode].[dbo].[Restaurant_User]"
            sql += " where RSap =" & txtid.Text & ""

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
            sql = " UPDATE  Restaurant_User set"
            sql += " RName = '" & txtName.Text & "',"
            sql += " RPosation = '" & txtSV.Text & "'"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where RSap = " & txtid.Text & ""
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

            Dim sql1 As String = "SELECT RSap,RName,RPosation FROM Restaurant_User"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_User")
            ds.Tables("Restaurant_User").Columns(0).ColumnName = "Sap Number"
            ds.Tables("Restaurant_User").Columns(1).ColumnName = " Name"
            ds.Tables("Restaurant_User").Columns(2).ColumnName = "Job Titel"
            '  ds.Tables("Restaurant_User").Columns(3).ColumnName = "sap"
            ' ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("Restaurant_User")

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
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Update11A2()
        _Refresh112()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Add1_New12()
        _Refresh112()
    End Sub
    Private Function _Refresh117() As Boolean
        Try

            Dim sql1 As String = "SELECT RID,RName FROM Restaurant_Name_area"
            ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Restaurant_Name_area")
            ds.Tables("Restaurant_Name_area").Columns(0).ColumnName = "Code"
            ds.Tables("Restaurant_Name_area").Columns(1).ColumnName = " Name"
            ' ds.Tables("LCDTVModels").Columns(2).ColumnName = "fpanelID"
            ' ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
            dg.DataSource = ds.Tables("Restaurant_Name_area")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function Add1_New17() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.Restaurant_Name_area "
            sql += "(RID,RName)"
            sql += " VALUES (" & txtracode.Text & ",'" & txtraname.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Update11A27() As Boolean
        Try
            Dim sql As String
            sql = " UPDATE  Restaurant_Name_area set"
            sql += " RName = '" & txtraname.Text & "'"
            ' sql += " RPosation = '" & txtSV.Text & "'"
            'sql += " fpanelIDLCM = '" & txtpanelIDLCM.Text & "'"
            sql += " where RID = " & txtracode.Text & ""
            'sql += " and part_number = '" & txtpartnumberm.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Del_Rec17() As Boolean
        Try
            Dim sql As String
            sql = "	DELETE FROM [barcode].[dbo].[Restaurant_Name_area]"
            sql += " where RID =" & txtracode.Text & ""

            Dim cmd As New SqlClient.SqlCommand(sql, cn)

            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()

        Catch ex As Exception

        End Try
    End Function
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        _Refresh117()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Add1_New17()
        _Refresh117()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Update11A27()
        _Refresh117()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        Del_Rec17()
        _Refresh117()

    End Sub
End Class