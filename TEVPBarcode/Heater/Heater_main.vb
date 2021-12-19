Imports TEVPBarcode.sher
Public Class Heater_main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Heater_Registration__step_one
        frm.Show()
        Button2.BackColor = Color.Black
    End Sub

    Private Sub Heater_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/OneOrange.ssk"
        'Me.BackgroundImage = Image.FromFile("E:\Heater App\TEVPBarcode v.2\TEVPBarcode\image\obj\x86\Debug\low.jpg")
        'Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackColor = Color.Azure
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Heater_Registration__step_three
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New Heater_Registration__step_two
        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New Heater_add_new_model
        frm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm As New Heater_Step_One_Query
        frm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New Heater_Step_Two_Query
        frm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim frm As New Heater_Step_Three_Query
        frm.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Function _Refresh001() As Boolean
        Try

            Button2.BackColor = Color.Yellow


        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh0011() As Boolean
        Try

            Button2.BackColor = Color.Yellow

        Catch ex As Exception

        End Try



    End Function
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frm As New frmaboutheater
        frm.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim frm As New Heater_Registration__step_four
        frm.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh001()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        _Refresh0011()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim frm As New Heater_out_put
        frm.Show()

    End Sub
End Class