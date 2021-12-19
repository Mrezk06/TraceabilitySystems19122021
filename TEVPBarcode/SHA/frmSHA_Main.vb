Public Class frmSHA_Main
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim frm As New frmSHA_Output
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim frm As New frmSHA_Repair
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim frm As New frmSHA_AddModel
        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim frm As New frmRefrigeratorCreateUser
        frm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim frm As New frmSHA_DashBoard
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmSHA_AddScdule
        frm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New frmSHA_AddingNewInformation
        frm.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frm As New frmSHA_OutputQuery
        frm.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim frm As New frmSHA_RepairQuery
        frm.Show()
    End Sub

    Private Sub frmSHA_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim frm As New frmSHA_Input
        frm.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim frm As New frmSHA_InputQuery
        frm.Show()
    End Sub
End Class