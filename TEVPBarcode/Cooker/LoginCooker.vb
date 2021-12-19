Imports TEVPBarcode.sher
Public Class LoginCooker




    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            'If UsernameTextBox.Text = "allPoint" And PasswordTextBox.Text = "1111" Then
            '    Dim frm As New Heater_Registration__step_four
            '    frm.Show()
            '    Me.Hide()
            If UsernameTextBox.Text = "CookerOutPut" And PasswordTextBox.Text = "0000" Then
                Dim frm As New frmCOOKEROutPutLine
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "CookerOutPutQuery" And PasswordTextBox.Text = "1111" Then
                Dim frm As New frmCookerOutPutQuery
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "MicroWave" And PasswordTextBox.Text = "1" Then
                Dim frm As New frmMicroWave
                frm.Show()
                Me.Hide()

            ElseIf UsernameTextBox.Text = "CookerQuality" And PasswordTextBox.Text = "1111" Then
                Dim frm As New frmCookerQuality
                frm.Show()
                Me.Hide()

            ElseIf UsernameTextBox.Text = "CookerQueryQuality" And PasswordTextBox.Text = "2222" Then
                Dim frm As New frmCookerQualityQuery
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "CookerRepair" And PasswordTextBox.Text = "1111" Then
                Dim frm As New frmCookerRepair
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "CookerFinishGoodQ" And PasswordTextBox.Text = "2" Then
                Dim frm As New frmcookerFinishGoodQuery
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "CookerFinishGood" And PasswordTextBox.Text = "1111" Then
                Dim frm As New frmCookerFinishGood
                frm.Show()
                Me.Hide()
                'ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
                '    Dim frm As New frmcookerMainManu
                '    frm.Show()
                '    Me.Hide()
                'ElseIf UsernameTextBox.Text = "a" And PasswordTextBox.Text = "0" Then
                '    Dim frm As New mainWashingMachine
                '    frm.Show()
                '    Me.Hide()
            ElseIf UsernameTextBox.Text = "CookerDashBoard" And PasswordTextBox.Text = "0" Then
                Dim frm As New frmCookerDashBoard
                frm.Show()
                Me.Hide()


            Else
                MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Dim Cru_Count As Int64
    Private Sub Loginwash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        PasswordTextBox.Focus()
        Try
            'Dim fileReader1 As String
            'fileReader1 = My.Computer.FileSystem.ReadAllText("Skins/test12.txt")
            '' fileReader1 = My.Computer.FileSystem.ReadAllText("D:\Debug\test12.txt")
            'cn.ConnectionString = fileReader1.ToString


            cn.ConnectionString = "Data Source=10.33.2.230;Initial Catalog=barcode;Persist Security Info=True;User ID=db;Password=P@ssw0rd"

        Catch ex As Exception
        End Try
    End Sub
    'Private Function _Refresh001() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += " SELECT count(H_Heater_Code)as tt FROM  barcode.dbo.Heater_registration_Three where tt ='" & Cru_Count.Text & "'"
    '        '  sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        ' sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
    '        'sql += "   and H_time>='" & txttotime.Text & "'"
    '        'sql += "   and H_time<= '" & txtfromTime.Text & "'"
    '        ''sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
    '        'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Heater_registration_Three")
    '        ds.Tables("Heater_registration_Three").Columns(0).ColumnName = "الكمية"
    '        'ds.Tables("DailyP").Columns(1).ColumnName = " time "
    '        'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
    '        'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
    '        'ds.Tables("DailyP").Columns(4).ColumnName = "line"
    '        'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
    '        'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
    '        '  dg6.DataSource = ds.Tables("Heater_registration_Three")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class