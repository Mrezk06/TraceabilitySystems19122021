﻿Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Configuration
Imports System.Security.Cryptography
Public Class frmRefrigeratorLogin
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            Dim sql As String = ""
            sql += " select SapUser from Login "
            sql += "where Username='" & UsernameTextBox.Text & "' and Password='" & Encrypt(PasswordTextBox.Text) & "'  and UserType='" & txttype.SelectedItem & "' and FactoryCode='Refrigerator_C'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Login")

            cmb_Pcode.DataSource = ds.Tables(0)
            ''  cmb_Pcode.ValueMember = "SapUser"
            cmb_Pcode.DisplayMember = "SapUser"
            cmb_Pcode.Sorted = False

        Catch ex As Exception
        End Try

        Dim cmd As SqlCommand = New SqlCommand("select Username, Password, UserType from Login where Username='" & UsernameTextBox.Text & "' and Password='" & Encrypt(PasswordTextBox.Text) & "'  and UserType='" & txttype.SelectedItem & "' and FactoryCode='Refrigerator_C'", cn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        Dim ddd As String
        ddd = cmb_Pcode.Text
        ''  Sapuser = cmb_Pcode.Text

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("You are Logined as" + dt.Rows(0)(2))
            If (txttype.SelectedIndex = 0) Then

                Dim frm As New frmRefrigeratorMain
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 1) Then
                Dim OBJ As New frmRefrigerator_Body_Completed
                OBJ.StringPass1 = DDD
                OBJ.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 2) Then
                Dim OBJ As New frmRefrigeratorCreateDoor
                OBJ.StringPass2 = cmb_Pcode.Text
                OBJ.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 3) Then
                Dim OBJ As New frmRefrigerator_SW_RE
                OBJ.StringPass3 = cmb_Pcode.Text
                OBJ.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 4) Then
                Dim OBJ As New frmRefrigerator_OutPutLine_B
                OBJ.StringPass = ddd
                OBJ.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 5) Then
                Dim OBJ As New frmRefrigeratorCreateUser
                OBJ.StringPass4 = cmb_Pcode.Text
                OBJ.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 6) Then
                Dim OBJ As New frmRefrigeratorAddNewModel
                OBJ.StringPass5 = cmb_Pcode.Text
                OBJ.Show()
                Me.Hide()

            Else
                MessageBox.Show("You cannot enter")
            End If
        End If




    End Sub

    Private Sub frmRefrigeratorLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Me.SkinEngine1.SkinFile = "Skins/SteelBlack.ssk"
        UsernameTextBox.Focus()
        Try
            cn.ConnectionString = "Data Source=EUCSSQL02\TRACEABILITY;Initial Catalog=TRACEABILITY_QUESNA;Persist Security Info=True;User ID=TRACEABILITY;Password=Tr@$e@b!l!ty1964"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        Close()

    End Sub
    Private Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Private Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub UsernameTextBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class