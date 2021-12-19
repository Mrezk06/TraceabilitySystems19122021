Imports TEVPBarcode.sher
Imports System.Data.SqlClient

Public Class frmDBT
    Private Function dd()
        Dim sDateFrom As String = Nothing
        Dim dFrom As DateTime
        Dim dTo As DateTime
        Dim sDateTo As String = lblTime.Text 'Current Time

        Using cn


            Dim command As SqlCommand = New SqlCommand("select top 1 fPtime from Output;", cn)
            cn.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                Do While reader.Read()
                    sDateFrom = reader.GetValue(0)
                Loop
            End If
        End Using

        sDateFrom = DateTime.TryParse(sDateFrom, dFrom)
        sDateTo = DateTime.TryParse(sDateTo, dTo)
        Dim TS As TimeSpan = dFrom - dTo
        Dim hour As Integer = TS.Hours
        Dim mins As Integer = TS.Minutes
        Dim secs As Integer = TS.Seconds
        Dim timeDiff As String = ((hour.ToString("00") & ":") + mins.ToString("00") & ":") + secs.ToString("00")
        txttotal.Text = timeDiff

    End Function
    Private Sub frmDBT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dd()

    End Sub
 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dd()
    End Sub
End Class