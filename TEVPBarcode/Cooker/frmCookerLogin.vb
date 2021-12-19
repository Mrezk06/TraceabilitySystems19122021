


Imports System.Data.SqlClient
    Imports TEVPBarcode.sher


    Imports System.IO
    Imports System.Text
    Imports System.Data

    Imports System.Configuration
    Imports System.Security.Cryptography
Public Class frmCookerLogin
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            Try
                Dim sql As String = ""
                sql += " select SapUser from Login "
                sql += "where Username='" & UsernameTextBox.Text & "' and Password='" & Encrypt(PasswordTextBox.Text) & "'  and UserType='" & txttype.SelectedItem & "' and FactoryCode='Cooker1'"
                Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
                ds.Tables.Clear()
                da.Fill(ds, "Login")
                cmb_Pcode.DataSource = ds.Tables(0)
                cmb_Pcode.DisplayMember = "SapUser"
                cmb_Pcode.Sorted = True
            Catch ex As Exception
            End Try

            Dim cmd As SqlCommand = New SqlCommand("select Username, Password, UserType from Login where Username='" & UsernameTextBox.Text & "' and Password='" & Encrypt(PasswordTextBox.Text) & "'  and UserType='" & txttype.SelectedItem & "' and FactoryCode='Cooker1'", cn)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)


            If (dt.Rows.Count > 0) Then
                MessageBox.Show("You are Logined as" + dt.Rows(0)(2))
                If (txttype.SelectedIndex = 0) Then
                    Dim frm As New frmcookerMainManu
                    frm.Show()
                    Me.Hide()
                ElseIf (txttype.SelectedIndex = 1) Then
                    Dim OBJ As New frmCOOKEROutPutLine
                    OBJ.StringPassc1 = cmb_Pcode.Text
                    OBJ.Show()
                    Me.Hide()

                ElseIf (txttype.SelectedIndex = 2) Then
                    Dim OBJ As New frmMicroWave
                    OBJ.StringPassc2 = cmb_Pcode.Text
                    OBJ.Show()
                    Me.Hide()
                ElseIf (txttype.SelectedIndex = 3) Then
                    Dim frm As New frmpressier

                    frm.Show()
                    Me.Hide()
                ElseIf (txttype.SelectedIndex = 4) Then
                    Dim frm As New frmpaint

                    frm.Show()
                    Me.Hide()
                ElseIf (txttype.SelectedIndex = 5) Then
                    Dim frm As New frmPWH

                    frm.Show()
                    Me.Hide()
                ElseIf (txttype.SelectedIndex = 6) Then
                    'Dim frm As New frmCookerQuality
                    'frm.Show()
                    'Me.Hide()

                    Dim OBJ As New frmCookerQuality
                    OBJ.StringPassc6 = cmb_Pcode.Text
                    OBJ.Show()
                    Me.Hide()

                ElseIf (txttype.SelectedIndex = 7) Then

                    Dim OBJ As New frmCookerRepair
                    OBJ.StringPassc4 = cmb_Pcode.Text
                    OBJ.Show()
                    Me.Hide()

                ElseIf (txttype.SelectedIndex = 8) Then
                    'Dim frm As New frmCookerFinishGood

                    'frm.Show()
                    'Me.Hide()
                    Dim OBJ As New frmCookerFinishGood
                    OBJ.StringPassc3 = cmb_Pcode.Text
                    OBJ.Show()
                    Me.Hide()

                ElseIf (txttype.SelectedIndex = 9) Then
                    Dim frm As New frmCookerTimeStudy

                    frm.Show()
                    Me.Hide()
                ElseIf (txttype.SelectedIndex = 10) Then
                    Dim frm As New frmCookerDashBoard

                    frm.Show()
                    Me.Hide()

                ElseIf (txttype.SelectedIndex = 11) Then
                    Dim frm As New frmATQ_QueryNew

                    frm.Show()
                    Me.Hide()

                ElseIf (txttype.SelectedIndex = 12) Then

                    Dim OBJ As New frmcookerscdule
                    OBJ.StringPassc9 = cmb_Pcode.Text
                    OBJ.Show()
                    Me.Hide()
                ElseIf (txttype.SelectedIndex = 13) Then

                    Dim OBJ As New frmMicrowaveFinishGood
                    OBJ.StringPassc10 = cmb_Pcode.Text
                    OBJ.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("You cannot enter")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmRefrigeratorLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            'Dim fileReader1 As String
            'fileReader1 = My.Computer.FileSystem.ReadAllText("Skins/test12.txt")
            '' fileReader1 = My.Computer.FileSystem.ReadAllText("D:\Debug\test12.txt")
            'cn.ConnectionString = fileReader1.ToString
            cn.ConnectionString = "Data Source=10.33.2.230;Initial Catalog=barcode;Persist Security Info=True;User ID=db;Password=P@ssw0rd"


            GroupBox1.BackColor = Color.FromArgb(120, 0, 0, 0)
            '   Panel2.BackColor = Color.FromArgb(120, 0, 0, 0)

            'Label1.BackColor = Color.Transparent
            ' Label3.BackColor = Color.Transparent
            'Label2.BackColor = Color.Transparent
            'Label4.BackColor = Color.Transparent
            'Label5.BackColor = Color.Transparent

            '  Label5.ForeColor = Color.White
            ' Label1.ForeColor = Color.White
            '  Label3.ForeColor = Color.White
            ' Label3.ForeColor = Color.White
            'Label4.ForeColor = Color.White

            ' Button1.FlatStyle = FlatStyle.Flat
            'Button_Minimize.FlatStyle = FlatStyle.Flat
            'Button_Close.FlatAppearance.BorderSize = 0
            'Button_Minimize.FlatAppearance.BorderSize = 0

            UsernameTextBox.BackColor = Color.Gray
            PasswordTextBox.BackColor = Color.Gray
            txttype.BackColor = Color.Gray

            UsernameTextBox.ForeColor = Color.Yellow
            PasswordTextBox.ForeColor = Color.Yellow
            txttype.ForeColor = Color.Yellow

            OK.FlatStyle = FlatStyle.Flat
            OK.BackColor = Color.FromArgb(39, 174, 96)
            OK.ForeColor = Color.White
            OK.FlatAppearance.BorderColor = Color.White

        Catch ex As Exception
        End Try
        UsernameTextBox.Focus()
        UsernameTextBox.SelectAll()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class