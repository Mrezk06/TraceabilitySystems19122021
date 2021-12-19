Public Class frmmefpntr

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub frmmefpntr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.Visible = False
    End Sub
End Class