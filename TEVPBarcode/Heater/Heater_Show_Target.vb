Imports TEVPBarcode.sher
Public Class Heater_Show_Target
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Heater_Step_One_Query
        frm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Heater_Step_Two_Query
        frm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New Heater_Step_Three_Query
        frm.Show()
    End Sub

    Private Sub Heater_Show_Target_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/OneOrange.ssk"
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class