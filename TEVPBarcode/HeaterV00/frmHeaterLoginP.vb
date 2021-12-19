


Imports System.Data.SqlClient
    Imports TEVPBarcode.sher


    Imports System.IO
    Imports System.Text
    Imports System.Data

    Imports System.Configuration
    Imports System.Security.Cryptography
Public Class frmHeaterLoginP
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        'Try


        '    If UsernameTextBox.Text = "Refrigerator_Input" And PasswordTextBox.Text = "1" Then
        '        Dim frm As New frmRefrigerator_Body_Completed
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "Refrigerator_Door" And PasswordTextBox.Text = "2" Then
        '        Dim frm As New frmRefrigerator_SW_RE
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
        '        Dim frm As New frmMainQulity
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "Refrigerator_Create_Door" And PasswordTextBox.Text = "3" Then
        '        Dim frm As New frmRefrigeratorCreateDoor
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "Refrigerator_AddModel" And PasswordTextBox.Text = "4" Then
        '        Dim frm As New frmRefrigeratorAddNewModel
        '        frm.Show()
        '        Me.Hide()
        '        '    'ElseIf UsernameTextBox.Text = "out" And PasswordTextBox.Text = "0000" Then
        '        '    '    Dim frm As New frmOutp
        '        '    '    frm.Show()
        '        '    '    Me.Hide()
        '        'ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
        '        '    Dim frm As New frmMain
        '        '    frm.Show()
        '        '    Me.Hide()
        '        'ElseIf UsernameTextBox.Text = "ll3" And PasswordTextBox.Text = "3333" Then
        '        '    Dim frm As New LED_BAR_barcode_structure
        '        '    frm.Show()
        '        '    Me.Hide()
        '        'ElseIf UsernameTextBox.Text = "ll4" And PasswordTextBox.Text = "4444" Then
        '        '    Dim frm As New frmLCM1
        '        '    frm.Show()
        '        '    Me.Hide()
        '    Else
        '        MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
        '    End If
        'Catch ex As Exception

        'End Try

        Dim cmd As SqlCommand = New SqlCommand("select Username, Password, UserType from Login where Username='" & UsernameTextBox.Text & "' and Password='" & Encrypt(PasswordTextBox.Text) & "'  and UserType='" & txttype.SelectedItem & "' and FactoryCode='Heater1'", cn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("You are Logined as" + dt.Rows(0)(2))
            If (txttype.SelectedIndex = 0) Then
                Dim frm As New FrmHeaterMainV00
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 1) Then
                Dim frm As New FrmHeaterStepOneReg
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 2) Then
                Dim frm As New FrmHeaterStepTwoReg
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 3) Then
                Dim frm As New frmHeaterStepTwoOfflinReg
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 4) Then
                Dim frm As New FrmHeaterStepThreeReg
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 5) Then
                Dim frm As New Heater_Registration__step_one
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 6) Then
                Dim frm As New frmHeaterFinishGoodMFG
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 7) Then
                Dim frm As New frmHeaterRepairReg
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 8) Then
                Dim frm As New frmHeaterAddData
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 9) Then
                Dim frm As New frmHeaterDashBoard
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 10) Then
                Dim frm As New frmHeaterScdule
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 11) Then
                Dim frm As New frmRefrigeratorCreateUser
                frm.Show()
                Me.Hide()

            Else
                MessageBox.Show("You cannot enter")
            End If
        End If
    End Sub

    Private Sub frmRefrigeratorLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.SkinEngine1.SkinFile = "Skins/SteelBlack.ssk"
        UsernameTextBox.Focus()
        Try
            'Dim fileReader1 As String
            ''fileReader1 = My.Computer.FileSystem.ReadAllText("D:\Debug\test12.txt")
            ''  fileReader1 = My.Computer.FileSystem.ReadAllText("C:\test12.txt")
            'fileReader1 = My.Computer.FileSystem.ReadAllText("Skins/test12.txt")
            'cn.ConnectionString = fileReader1.ToString

            cn.ConnectionString = "Data Source=EUCSSQL02\TRACEABILITY;Initial Catalog=TRACEABILITY_QUESNA;Persist Security Info=True;User ID=TRACEABILITY;Password=Tr@$e@b!l!ty1964"

            'Cru_Count = 10
            'If Cru_Count > 10 Then
            '    Me.Dispose()

            'End If

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
End Class