Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class LoginOutP

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub
    Dim Cru_Count As Int64
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UsernameTextBox.Focus()
        'Me.SkinEngine1.SkinFile = "Skins/RealOne.ssk"
        UsernameTextBox.Focus()
        Try
            'Dim fileReader1 As String
            '' Data Source=MOHAMED;Initial Catalog=barcode;Persist Security Info=True;User ID=sa;Password=a-123456
            '' fileReader1 = My.Computer.FileSystem.ReadAllText("D:\Debug\test12.txt")
            'fileReader1 = My.Computer.FileSystem.ReadAllText("Skins/test12.txt")
            'cn.ConnectionString = fileReader1.ToString

            cn.ConnectionString = "Data Source=EUCSSQL02\TRACEABILITY;Initial Catalog=TRACEABILITY_QUESNA;Persist Security Info=True;User ID=TRACEABILITY;Password=Tr@$e@b!l!ty1964"

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

            If UsernameTextBox.Text = "Receiving" Then
                Dim frm As New frmFinishGoodWH
                frm.Show()
                Me.Hide()
                'ElseIf UsernameTextBox.Text = "Query" And PasswordTextBox.Text = "2222" Then
                '    Dim frm As New QueryforQulity
                '    frm.Show()
                '    Me.Hide()
                'ElseIf UsernameTextBox.Text = "Notes" And PasswordTextBox.Text = "3333" Then
                '    Dim frm As New NotesForProblems
                '    frm.Show()
                '    Me.Hide()

                'ElseIf UsernameTextBox.Text = "FinishGoodRMFG" And PasswordTextBox.Text = "1111" Then
                '    Dim frm As New frmSony
                '    frm.Show()
                '    Me.Hide()
                'ElseIf UsernameTextBox.Text = "FinishGoodQMFG" And PasswordTextBox.Text = "2222" Then
                '    Dim frm As New frmQOutp
                '    frm.Show()
                '    Me.Hide()
            ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "asd1010" Then
                Dim frm As New frmMainForOutPut
                frm.Show()
                Me.Hide()
                'ElseIf UsernameTextBox.Text = "model_and_lebar" And PasswordTextBox.Text = "2010" Then
                '    Dim frm As New frmaddmodelandlebar
                '    frm.Show()
                '    Me.Hide()
                'ElseIf UsernameTextBox.Text = "View_data" And PasswordTextBox.Text = "0000" Then
                '    Dim frm As New frmshowdataforfinishgood
                '    frm.Show()
                '    Me.Hide()
                'ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
                '    Dim frm As New frmMainForOutPut
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
                MsgBox("Please check your username or password wrong ")
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
'End Class