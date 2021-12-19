

Imports System.Data.SqlClient
    Imports TEVPBarcode.sher


    Imports System.IO
    Imports System.Text
    Imports System.Data

    Imports System.Configuration
    Imports System.Security.Cryptography
Public Class frmTVLogin
    Private Sub OK_Click(sender As Object, e As EventArgs)

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

            '' cn.ConnectionString = "Data Source=EUCSSQL02\TRACEABILITY;Initial Catalog=TRACEABILITY_QUESNA;Persist Security Info=True;User ID=TRACEABILITY;Password=Tr@$e@b!l!ty1964"
            ''  cn.ConnectionString = " Data Source =WIN-TEB3U1SG73S;Initial Catalog=barcode;Persist Security Info=True;User ID=sa;Password=a-123456"
            cn.ConnectionString = "Data Source=EUCSSQL02\TRACEABILITY;Initial Catalog=TRACEABILITY_ASUIT;Persist Security Info=True;User ID=TRACEABILITY;Password=Tr@$e@b!l!ty1964"


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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim cmd As SqlCommand = New SqlCommand("select Username, Password, UserType from Login where Username='" & UsernameTextBox.Text & "' and Password='" & Encrypt(PasswordTextBox.Text) & "'  and UserType='" & txttype.SelectedItem & "' and FactoryCode='TV_Asyit'", cn)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show("You are Logined as" + dt.Rows(0)(2))
            If (txttype.SelectedIndex = 0) Then
                Dim frm As New frmMain
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 1) Then
                Dim frm As New LED_BAR_barcode_structure

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 2) Then
                Dim frm As New frmLCM1

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 3) Then
                Dim frm As New scanningFat1

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 4) Then
                Dim frm As New frmFat

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 5) Then
                Dim frm As New frmAddData

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 6) Then
                Dim frm As New ShowTarget

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 7) Then
                Dim frm As New frmRunRate

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 8) Then
                Dim frm As New frmFollowUpTest

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 9) Then
                Dim frm As New frmFollowUpLaber

                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 10) Then
                Dim frm As New frmMainRepair

                frm.Show()
            ElseIf (txttype.SelectedIndex = 11) Then
                Dim frm As New frmLCMRepair

                frm.Show()
            ElseIf (txttype.SelectedIndex = 12) Then
                Dim frm As New frmAddingNewInformation

                frm.Show()
            ElseIf (txttype.SelectedIndex = 13) Then
                Dim frm As New frmMainQulity

                frm.Show()
            ElseIf (txttype.SelectedIndex = 14) Then
                Dim frm As New NotesForProblems

                frm.Show()
            ElseIf (txttype.SelectedIndex = 15) Then
                Dim frm As New Qulity_in_Or_out

                frm.Show()
            ElseIf (txttype.SelectedIndex = 16) Then
                Dim frm As New FrmNEWtESTrEQ

                frm.Show()
            ElseIf (txttype.SelectedIndex = 17) Then
                Dim frm As New frmMainToPCB_LEDBAR

                frm.Show()
            ElseIf (txttype.SelectedIndex = 18) Then
                Dim frm As New frmPCBInput

                frm.Show()
            ElseIf (txttype.SelectedIndex = 19) Then
                Dim frm As New frmPCBOutput

                frm.Show()
            ElseIf (txttype.SelectedIndex = 20) Then
                Dim frm As New frmLEDBAR_Packing

                frm.Show()

                Me.Hide()

            ElseIf (txttype.SelectedIndex = 21) Then
                Dim frm As New frmShowData_PCB

                frm.Show()

                Me.Hide()
            ElseIf (txttype.SelectedIndex = 22) Then
                Dim frm As New frmMainForOutPut

                frm.Show()

                Me.Hide()
            ElseIf (txttype.SelectedIndex = 23) Then
                Dim frm As New frmaddmodelandlebar

                frm.Show()

                Me.Hide()
            ElseIf (txttype.SelectedIndex = 24) Then
                Dim frm As New frmshowdataforfinishgood
                frm.Show()
                Me.Hide()


            ElseIf (txttype.SelectedIndex = 25) Then
                Dim frm As New frmSony
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 26) Then
                Dim frm As New frmFinishGoodWH
                frm.Show()
                Me.Hide()
            ElseIf (txttype.SelectedIndex = 27) Then
                Dim frm As New frmFinishGoodWH22
                frm.Show()
                Me.Hide()

            ElseIf (txttype.SelectedIndex = 28) Then
                Dim frm As New frmFinishGoodWH3
                frm.Show()
                Me.Hide()

            Else
                MessageBox.Show("You cannot enter")
            End If
        End If
    End Sub
End Class