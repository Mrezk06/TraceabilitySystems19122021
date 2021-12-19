Imports System.Data.SqlClient

Imports TEVPBarcode.sher
Public Class newshowforData
    

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Used_Time = DateDiff(DateInterval.Minute, end_date, Strt_Time)
            end_date = DateTime.Now
        Catch ex As Exception
        End Try
        lbl_Pcode_Value.Text = txtcurrentCout.Text
        lblline.Text = txtLine.Text
    End Sub
    Dim end_date As Date
    Dim _Rate As Integer
    Dim Strt_Time As Date
    Dim Used_Time As Integer

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            Label1.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            btnStart.Visible = False
            Label2.Visible = False
            Label4.Visible = False
            Label11.Visible = False
            txtLine.Visible = False
            txtModelName.Visible = False
            txt_Count_Target.Visible = False
            Label5.Text = txtModelName.Text
            Timer3.Enabled = True
            Timer2.Enabled = True
            Timer4.Enabled = True
            Strt_Time = DateTime.Now
        Catch ex As Exception
        End Try
    End Sub
    Sub EndBreakClick(sender As Object, e As EventArgs)
        ''  EndTime = DateTime.n
        'EndTime.Text = DateTime.Now.ToString()

        'DateDiff(DateInterval.Minute, EndTime, Strt_Time)

    End Sub
    Private Sub newshowforData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPBlue.ssk"
        'Me.BackColor = Color.Green
        Dim sql As String = ""
        sql += " SELECT  fLCDSetID, fLCDModelName FROM   LCDTVModels "
        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        Dim ds As New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "LCDTVModels")
        txtModelName.DataSource = ds.Tables(0)
        ' txtModelName.ValueMember = "fLCDSetID"
        txtModelName.DisplayMember = "fLCDModelName"
        '  txtModelName.Sorted = True
        Timer2.Enabled = True
        Timer1.Enabled = True
        ' Label9.Visible = False
        Label10.Visible = False   ' Timer3.Enabled = True
        Label5.Text = txtModelName.Text
        Label1.Visible = False
        Label7.Visible = False
        Label8.Visible = False

    End Sub

    Private Sub txtcurrentCout_ValueChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        _Refresh()
        _Refresh3150()
    End Sub
    Private Function _Refresh3150() As Boolean

        Try
            Dim sql As String = ""
            sql += " SELECT  count(fLCDModelName) AS tot"
            sql += " FROM DailyP"
            sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and fLCDModelName='" & txtModelName.Text & "'"
            sql += " and fLineandsh='" & txtLine.Text & "'"
            '  sql += " and fLCDPline ='" & txtline.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "DailyP")

            txtcurrentCout.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            txtcurrentCout.DisplayMember = "tot"
            txtcurrentCout.Sorted = True


        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh() As Boolean

        Try
            Dim sql As String = ""
            sql += " SELECT  fQtyTarget"
            sql += " FROM tabelGoal"
            ' sql += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " WHERE fModelName='" & txtModelName.Text & "'"
            'sql += " and fShift='" & txtLine.Text & "'"
            '  sql += " and fLCDPline ='" & txtline.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            'sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "tabelGoal")

            txt_Count_Target.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            txt_Count_Target.DisplayMember = "fQtyTarget"
            txt_Count_Target.Sorted = True


        Catch ex As Exception

        End Try
    End Function
    Private Sub txtModelName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtModelName.SelectedIndexChanged

    End Sub

    Private Sub txtModelName_MouseLeave(sender As Object, e As EventArgs) Handles txtModelName.MouseLeave

    End Sub

    Private Sub txtModelName_Leave(sender As Object, e As EventArgs) Handles txtModelName.Leave

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub txt_Count_Target_ValueChanged(sender As Object, e As EventArgs)

    End Sub
    Private Function _Refresh315() As Boolean
        Try
            Used_Time = DateDiff(DateInterval.Minute, Strt_Time, end_date)
            Label9.Text = ((lbl_Pcode_Value.Text) - (Label6.Text))
            If Label6.Text < lbl_Pcode_Value.Text Then
                Me.BackColor = Color.Yellow
            ElseIf lbl_Pcode_Value.Text = Label6.Text Then
                Me.BackColor = Color.Green
            Else
                Me.BackColor = Color.Red
            End If
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        end_date = DateTime.Now
        Dim xx As Integer
        xx = (txt_Count_Target.Text * Used_Time)
        Label6.Text = xx
        _Refresh315()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label10.Visible = False
        btnStart.Visible = True
        Label2.Visible = True
        Label4.Visible = True
        txtModelName.Visible = True
        txt_Count_Target.Visible = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        _Refresh315()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtLine.SelectedIndexChanged

    End Sub

    Private Sub EndTime_TextChanged(sender As Object, e As EventArgs) Handles EndTime.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub lbl_Pcode_Value_Click(sender As Object, e As EventArgs) Handles lbl_Pcode_Value.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Mlbl_Click(sender As Object, e As EventArgs) Handles Mlbl.Click

    End Sub

    Private Sub lblline_Click(sender As Object, e As EventArgs) Handles lblline.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtcurrentCout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcurrentCout.SelectedIndexChanged

    End Sub

    Private Sub txt_Count_Target_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_Count_Target.SelectedIndexChanged

    End Sub
End Class