Imports TEVPBarcode.sher
Public Class mainWashingMachine

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Heater_Registration__step_one
        frm.Show()
        Button2.BackColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Heater_Registration__step_three
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New Heater_Registration__step_two
        frm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm As New Heater_Step_One_Query
        frm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim frm As New Heater_Step_Three_Query
        frm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New Heater_Step_Two_Query
        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New Heater_add_new_model
        frm.Show()
    End Sub

    Private Sub mainWashingMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frm As New frmaboutheater
        frm.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub
End Class