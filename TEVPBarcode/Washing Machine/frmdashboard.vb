
Public Class frmdashboard

    'Dim watch As Object
    '  Dim stopwatch As New Stopwatch

    '  Private Property watch As Object

    Private Sub frmdashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
            Timer1.Enabled = False

        Catch ex As Exception

        End Try

        '' Label1.Text = String.Format("{0}:{1}:{2}", watch.Elapsed.Hours.ToString("00"), watch.Elapsed.Minutes.ToString("00"), watch.Elapsed.Seconds.ToString("00"))
    End Sub



    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '    '    Dim x As New String
        '    Timer1.Start()

        '    Label1.Text = Timer1.Container.ToString
        'End Sub

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''  Timer1.Enabled = True
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub
    'Private Sub timer1_timer()
    '    Label3.Caption = Val(Label3.Caption) + Val(1)
    '    If Label3.Caption = 60 Then
    '        Label2.Caption = Val(Label2.Caption) + Val(1)
    '        Label3.Caption = 0
    '    ElseIf Label2.Caption = 60 Then
    '        Label1.Caption = Val(Label1.Caption) + Val(1)
    '        Label2.Caption = 0
    '    End If
    'End Sub

    Public Function GetTime(Time As Integer) As String
        Dim Hrs As Integer  'number of hours   '
        Dim Min As Integer  'number of Minutes '
        Dim Sec As Integer  'number of Sec     '

        'Seconds'
        Sec = Time Mod 60

        'Minutes'
        Min = ((Time - Sec) / 60) Mod 60

        'Hours'
        Hrs = ((Time - (Sec + (Min * 60))) / 3600) Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        '  Dim x As New Decimal
        '   x = Timer1.GetLifetimeService()
        'Label1.Text = Date.Now.ToString("ss")
        ' Label1.Text = GetTime(90)
        ' x = Label1.Text




    End Sub
End Class