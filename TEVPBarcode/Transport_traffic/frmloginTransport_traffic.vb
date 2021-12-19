Imports TEVPBarcode.sher
Public Class frmloginTransport_traffic



    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            'If UsernameTextBox.Text = "allPoint" And PasswordTextBox.Text = "1111" Then
            '    Dim frm As New Heater_Registration__step_four
            '    frm.Show()
            '    Me.Hide()
            If UsernameTextBox.Text = "Point_1" And PasswordTextBox.Text = "0000" Then
                Dim frm As New Heater_Registration__step_one
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "o" And PasswordTextBox.Text = "0" Then
                Dim frm As New newshowforData
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "Point_2" And PasswordTextBox.Text = "1111" Then
                Dim frm As New Heater_Registration__step_three
                frm.Show()
                Me.Hide()

            ElseIf UsernameTextBox.Text = "Point_3" And PasswordTextBox.Text = "2222" Then
                Dim frm As New Heater_Registration__step_two
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "q" And PasswordTextBox.Text = "1" Then
                Dim frm As New Heater_Step_Two_Query
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "a" And PasswordTextBox.Text = "1" Then
                Dim frm As New Heater_add_new_model
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
                Dim frm As New frmMainTransport_Traffic
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "a" And PasswordTextBox.Text = "0" Then
                Dim frm As New mainWashingMachine
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "Time_Study" And PasswordTextBox.Text = "0" Then
                'Dim frm As New frmCookerTimeStudy
                'frm.Show()
                'Me.Hide()

            Else
                MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Dim Cru_Count As Int64
    Private Sub Loginwash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        UsernameTextBox.Focus()
        Try
            'Dim fileReader1 As String
            'fileReader1 = My.Computer.FileSystem.ReadAllText("Skins/test12.txt")
            '' fileReader1 = My.Computer.FileSystem.ReadAllText("D:\Debug\test12.txt")
            'cn.ConnectionString = fileReader1.ToString

            cn.ConnectionString = "Data Source=EGQ01WLMREZK06\S2014;Initial Catalog=barcode;Persist Security Info=True;User ID=sa;Password=a-123456"

            'Dim sql As String = ""
            'sql += " SELECT count(H_Heater_Code)as tt FROM  barcode.dbo.Heater_registration_Two "
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "Heater_registration_Two")
            'txd.DataSource = ds.Tables(0)
            ''     cmb_Pcode.ValueMember = "Model_control"
            '' cmb_Pcode.ValueMember = "model_S_Power"
            'txd.DisplayMember = "tt"
            'txd.Sorted = False
            ''Cru_Count.Sorted = True
            'Cru_Count = CInt(Int(txd.Text))
            'If Cru_Count > 1000000 Then
            '    Me.Dispose()
            'End If
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