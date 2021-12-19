Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class LoginTEVP



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
            'fileReader1 = My.Computer.FileSystem.ReadAllText("Skins/test12.txt")
            '' fileReader1 = My.Computer.FileSystem.ReadAllText("D:\test12.txt")
            'cn.ConnectionString = fileReader1.ToString

            cn.ConnectionString = "Data Source=10.12.112.233;Initial Catalog=barcode;Persist Security Info=True;User ID=sa;Password=a-123456"

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
            'ElseIf UsernameTextBox.Text = "LED_Packing" And PasswordTextBox.Text = "0000" Then
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

        



            If UsernameTextBox.Text = "fl1" And PasswordTextBox.Text = "1111" Then
                Dim frm As New scanningFat1
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "f" And PasswordTextBox.Text = "1" Then
                Dim frm As New frmMainRepair
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "Kaizen" And PasswordTextBox.Text = "1" Then
                Dim frm As New frmLogenKaizen
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "LED_Packing" And PasswordTextBox.Text = "0000" Then
                Dim frm As New frmLEDBAR_Packing
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "FinishGood" And PasswordTextBox.Text = "1" Then
                Dim frm As New LoginOutP
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "qt" And PasswordTextBox.Text = "1" Then
                Dim frm As New LoginQulity
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "FollowUpLaberUSER" And PasswordTextBox.Text = "m-987654" Then
                Dim frm As New frmFollowUpLaber
                frm.Show()
                Me.Hide()

            ElseIf UsernameTextBox.Text = "QulityUSER" And PasswordTextBox.Text = "1" Then
                Dim frm As New Qulity_in_Or_out
                frm.Show()
                Me.Hide()
                'ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
                '    Dim frm As New frmMain
                '    frm.Show()
                '    Me.Hide()
            ElseIf UsernameTextBox.Text = "RepairUSER" And PasswordTextBox.Text = "1111" Then
                Dim frm As New frmLCMRepair

                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "AdminRepair" And PasswordTextBox.Text = "201015" Then
                Dim frm As New frmMainRepair

                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "fl2" And PasswordTextBox.Text = "2222" Then
                Dim frm As New frmFat
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "o" And PasswordTextBox.Text = "0" Then
                Dim frm As New newshowforData
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "ShowTarget" And PasswordTextBox.Text = "1" Then
                Dim frm As New ShowTarget
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "PCB_Input" And PasswordTextBox.Text = "1" Then
                Dim frm As New frmPCBInput
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "PCB_Output" And PasswordTextBox.Text = "1" Then
                Dim frm As New frmPCBOutput
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "Add_Data" And PasswordTextBox.Text = "201015" Then
                Dim frm As New frmAddData
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "RunRate" And PasswordTextBox.Text = "0000" Then
                Dim frm As New frmRunRate

                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "QUALITY_Assurance" And PasswordTextBox.Text = "201015" Then
                Dim frm As New FrmNEWtESTrEQ
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "ll3" And PasswordTextBox.Text = "3333" Then
                Dim frm As New LED_BAR_barcode_structure
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "ll4" And PasswordTextBox.Text = "4444" Then
                Dim frm As New frmLCM1
                frm.Show()
                Me.Hide()
            Else
                MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        'Try
        '    If UsernameTextBox.Text = "fl1" And PasswordTextBox.Text = "1111" Then
        '        Dim frm As New scanningFat1
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "fl2" And PasswordTextBox.Text = "2222" Then
        '        Dim frm As New frmFat
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "o" And PasswordTextBox.Text = "0" Then
        '        Dim frm As New newshowforData
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "p" And PasswordTextBox.Text = "1" Then
        '        Dim frm As New ShowTarget
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "a" And PasswordTextBox.Text = "1" Then
        '        Dim frm As New frmAddData
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
        '        Dim frm As New frmMain
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "ll3" And PasswordTextBox.Text = "3333" Then
        '        Dim frm As New LED_BAR_barcode_structure
        '        frm.Show()
        '        Me.Hide()
        '    ElseIf UsernameTextBox.Text = "ll4" And PasswordTextBox.Text = "4444" Then
        '        Dim frm As New frmLCM1
        '        frm.Show()
        '        Me.Hide()
        '    Else
        '        MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    'End Sub


    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub UsernameTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.SelectedIndexChanged

    End Sub
End Class
'End Class