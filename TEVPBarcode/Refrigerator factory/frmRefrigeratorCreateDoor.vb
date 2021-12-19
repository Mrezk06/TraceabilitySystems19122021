Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class frmRefrigeratorCreateDoor
    Public Property StringPass2 As String
    Private Sub frmRefrigeratorCreateDoor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Visible = False
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Timer1.Enabled = True
        GroupBox3.Enabled = False
        GroupBox7.Visible = True

        Label3.Text = StringPass2
        txtshift.Focus()
        txtshift.SelectAll()

    End Sub

    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += "select R_ModelName, R_ColorName,count( R_Barcode)"
            sql += " FROM Refrigerator_InputView  "
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line='" & txtshift.Text & "'"
            sql += " and R_FactoryCode ='C'"
            sql += " group by R_ModelName, R_ColorName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_InputView")
            ds.Tables("Refrigerator_InputView").Columns(0).ColumnName = "الموديل "
            ds.Tables("Refrigerator_InputView").Columns(1).ColumnName = " اللون"
            ds.Tables("Refrigerator_InputView").Columns(2).ColumnName = " الكمية"
            dg2.DataSource = ds.Tables("Refrigerator_InputView")
            dg2.AllowUserToAddRows = False
            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Function _Refresh1t() As Boolean
        Try
            Dim sql As String = ""
            sql += "select count( R_FactoryCode)"
            sql += " FROM Refrigerator_DoorRegQuery  "
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line='" & txtshift.Text & "'"
            sql += " and R_FactoryCode ='C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorRegQuery")
            ds.Tables("Refrigerator_DoorRegQuery").Columns(0).ColumnName = " الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_DoorRegQuery")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += "select R_ModelName,R_ColorName,count(R_FactoryCode)"
            sql += " FROM Refrigerator_DoorRegQuery  "
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line='" & txtshift.Text & "'"
            sql += " and R_FactoryCode ='C'"
            sql += " group by R_ModelName, R_ColorName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorRegQuery")
            ds.Tables("Refrigerator_DoorRegQuery").Columns(0).ColumnName = "الموديل "
            ds.Tables("Refrigerator_DoorRegQuery").Columns(1).ColumnName = " اللون"
            ds.Tables("Refrigerator_DoorRegQuery").Columns(2).ColumnName = " الكمية"
            dg.DataSource = ds.Tables("Refrigerator_DoorRegQuery")
            dg.AllowUserToAddRows = False
            Return True

        Catch ex As Exception

        End Try

    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT Heater_Name_Laber FROM Heater_Name_Sap"
            sql += " where Heater_Sap_Laber='" & Label3.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Heater_Name_Sap")
            ds.Tables("Heater_Name_Sap").Columns(0).ColumnName = " الفنى المسئول"
            DGN.DataSource = ds.Tables("Heater_Name_Sap")
            DGN.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtshift.Text = "" Then Exit Sub
        _Refresh315()
        lbl_Msg.ForeColor = Color.Green
        lbl_Msg.Text = "مرحبا بك فى برنامج مصنع الثلاجة لمتابعة الانتاج"
        ' txtline.Enabled = False
        txtshift.Visible = False
        'txtshift.Visible = False
        Button2.Visible = False
        txtParts1.Visible = False
        GroupBox5.Visible = True
        GroupBox5.Enabled = True
        Label8.Visible = False
        Label2.Visible = False
        txtParts1.Visible = False

        GroupBox7.Visible = False
        GroupBox1.Enabled = True
        GroupBox3.Enabled = True
        txtdoor1.SelectAll()

        txtdoor1.Focus()


    End Sub

    Private Sub txtdoor1_TextChanged(sender As Object, e As EventArgs) Handles txtdoor1.TextChanged

    End Sub

    Private Sub txtdoor1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdoor1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'Dim Barcode_Part(17) As String
                'Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                'Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
                'Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
                'Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
                'Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
                'Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
                'Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 1)
                'Barcode_Part(7) = txtBarcodeOne.Text.Substring(15, 1)
                'Barcode_Part(8) = txtBarcodeOne.Text.Substring(16, 1)
                'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)

                Dim dsMaxz As New DataSet
                Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode FROM Refrigerator_Models  where   R_Door1 ='" & txtdoor1.Text & "' "
                Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                dsMaxz.Tables.Clear()
                daz.Fill(dsMaxz)
                If dsMaxz.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.Text = "باركود باب الثلاجة غير تابع لهذا الموديل "
                    lbl_Msg.ForeColor = Color.Yellow
                    txtdoor1.Focus()
                    txtdoor1.SelectAll()

                Else
                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل باركود الباب الصغير بنجاح"
                    ' txtBarcodeOne.Enabled = False
                    txtdoor1.Enabled = False
                    txtdoor2.Enabled = True
                    txtdoor2.Focus()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtdoor2_TextChanged(sender As Object, e As EventArgs) Handles txtdoor2.TextChanged

    End Sub

    Private Sub txtdoor2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdoor2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'Dim Barcode_Part(17) As String
                'Barcode_Part(0) = txtBarcodeOne.Text.Substring(0, 5)
                'Barcode_Part(1) = txtBarcodeOne.Text.Substring(5, 1)
                'Barcode_Part(2) = txtBarcodeOne.Text.Substring(6, 2)
                'Barcode_Part(3) = txtBarcodeOne.Text.Substring(8, 1)
                'Barcode_Part(4) = txtBarcodeOne.Text.Substring(9, 3)
                'Barcode_Part(5) = txtBarcodeOne.Text.Substring(12, 2)
                'Barcode_Part(6) = txtBarcodeOne.Text.Substring(14, 1)
                'Barcode_Part(7) = txtBarcodeOne.Text.Substring(15, 1)
                'Barcode_Part(8) = txtBarcodeOne.Text.Substring(16, 1)
                'Barcode_Part(3) = txtBarcodeOne.Text.Substring(6, 1)

                Dim dsMaxz As New DataSet
                Dim Sqlz = " SELECT  R_ModelControl,R_ColorCode FROM Refrigerator_Models  where  R_Door2 ='" & txtdoor2.Text & "' "
                Dim daz As New SqlClient.SqlDataAdapter(Sqlz, cn)
                dsMaxz.Tables.Clear()
                daz.Fill(dsMaxz)
                If dsMaxz.Tables(0).Rows.Count < 1 Then
                    lbl_Msg.Text = "باركود باب الثلاجة غير تابع لهذا الموديل "
                    lbl_Msg.ForeColor = Color.Yellow
                    txtdoor2.Focus()
                    txtdoor2.SelectAll()

                Else



                    Dim sqlb As String
                    sqlb = "INSERT INTO Refrigerator_DoorReg"
                    sqlb += "(   R_FactoryCode, R_Door1, R_Door2, R_SapUser, R_Line)"
                    sqlb += "VALUES    ('C','" & txtdoor1.Text & "','" & txtdoor2.Text & "'," & Label3.Text & ",'" & txtshift.Text & "')"
                    Dim cmdb As New SqlClient.SqlCommand(sqlb, cn)
                    If cn.State = ConnectionState.Closed Then cn.Open()
                    cmdb.ExecuteNonQuery()
                    cn.Close()

                    lbl_Msg.ForeColor = Color.GreenYellow
                    lbl_Msg.Text = "تم تسجيل باركود الباب الصغير بنجاح"
                    ' txtBarcodeOne.Enabled = False
                    txtdoor1.Text = ""
                    txtdoor2.Text = ""
                    txtdoor1.Enabled = True
                    txtdoor2.Enabled = False

                    txtdoor1.Focus()
                    _Refresh1()
                    _Refresh11()
                    _Refresh1t()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
End Class