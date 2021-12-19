Public Class frmMainKaizen

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmTicketSys
        frm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Dim frm As New frmTicketSys
        'frm.Show()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Dim frm As New frmReqServ
    '    frm.Show()

    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmEditRe
        frm.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmReqServ
        frm.Show()
    End Sub
End Class