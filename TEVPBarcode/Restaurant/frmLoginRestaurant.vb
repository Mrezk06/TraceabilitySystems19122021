Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class frmLoginRestaurant

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub
    Dim Cru_Count As Int64
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.SkinEngine1.SkinFile = "Skins/SteelBlack.ssk"
        UsernameTextBox.Focus()
        Try
            'Dim fileReader1 As String
            ''fileReader1 = My.Computer.FileSystem.ReadAllText("D:\Debug\test12.txt")
            ''  fileReader1 = My.Computer.FileSystem.ReadAllText("C:\test12.txt")
            'fileReader1 = My.Computer.FileSystem.ReadAllText("Skins/test12.txt")
            'cn.ConnectionString = fileReader1.ToString

            cn.ConnectionString = "Data Source=EGQ01WLMREZK06\S2014;Initial Catalog=barcode;Persist Security Info=True;User ID=sa;Password=a-123456"

            Cru_Count = 10
            If Cru_Count > 10 Then
                Me.Dispose()

            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try


            'If UsernameTextBox.Text = "allPoint" And PasswordTextBox.Text = "1111" Then
            '    Dim frm As New Heater_Registration__step_four
            '    frm.Show()
            '    Me.Hide()
            'ElseIf UsernameTextBox.Text = "Point_1" And PasswordTextBox.Text = "0000" Then
            '    Dim frm As New Heater_Registration__step_one
            '    frm.Show()
            '    Me.Hide()
            'ElseIf UsernameTextBox.Text = "Point_2" And PasswordTextBox.Text = "2222" Then
            '    Dim frm As New Heater_Registration__step_three
            '    frm.Show()
            '    Me.Hide()
            '    'ElseIf UsernameTextBox.Text = "k" And PasswordTextBox.Text = "0" Then
            '    '    Dim frm As New newshowforData
            '    '    frm.Show()
            '    '    Me.Hide()

            'ElseIf UsernameTextBox.Text = "Point_3" And PasswordTextBox.Text = "3333" Then
            '    Dim frm As New Heater_Registration__step_two
            '    frm.Show()
            '    Me.Hide()
            'ElseIf UsernameTextBox.Text = "q" And PasswordTextBox.Text = "1" Then
            '    Dim frm As New Heater_Step_Two_Query
            '    frm.Show()
            '    Me.Hide()
            'ElseIf UsernameTextBox.Text = "a" And PasswordTextBox.Text = "1" Then
            '    Dim frm As New Heater_add_new_model
            '    frm.Show()
            '    Me.Hide()

            'ElseIf UsernameTextBox.Text = "hadmin" And PasswordTextBox.Text = "201015" Then
            '    Dim frm As New Heater_main
            '    frm.Show()
            '    Me.Hide()



            'If UsernameTextBox.Text = "QulityR" And PasswordTextBox.Text = "1111" Then
            '    Dim frm As New Qulity_in_Or_out
            '    frm.Show()
            '    Me.Hide()
            If UsernameTextBox.Text = "Request" And PasswordTextBox.Text = "1" Then
                Dim frm As New frmChosemenu
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "Receipt" And PasswordTextBox.Text = "2" Then
                Dim frm As New frmRestaurantReceipt
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
                Dim frm As New frmRestaurantMain
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "addnewInformation" And PasswordTextBox.Text = "3" Then
                Dim frm As New frmNCANDNM
                frm.Show()
                Me.Hide()
                '    'ElseIf UsernameTextBox.Text = "out" And PasswordTextBox.Text = "0000" Then
                '    '    Dim frm As New frmOutp
                '    '    frm.Show()
                '    '    Me.Hide()
                'ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
                '    Dim frm As New frmMain
                '    frm.Show()
                '    Me.Hide()
                'ElseIf UsernameTextBox.Text = "ll3" And PasswordTextBox.Text = "3333" Then
                '    Dim frm As New LED_BAR_barcode_structure
                '    frm.Show()
                '    Me.Hide()
                'ElseIf UsernameTextBox.Text = "ll4" And PasswordTextBox.Text = "4444" Then
                '    Dim frm As New frmLCM1
                '    frm.Show()
                '    Me.Hide()
            Else
                MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
'End Class