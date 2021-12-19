Public Class frmMainTransport_Traffic

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim frm As New frmDailyTransport_traffic
        frm.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim frm As New frmDailyMaintenance_and_garage
        frm.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim frm As New frmCar_Oil
        frm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim frm As New frmDailySVShipping
        frm.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim frm As New frmQueryTransport_Traffic
        frm.Show()
    End Sub
End Class