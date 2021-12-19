Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class FrmHeaterLoginV00



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub
    Dim Cru_Count As Int64
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '   Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        UsernameTextBox.Focus()
        Try
            'Dim fileReader1 As String
            ''fileReader1 = My.Computer.FileSystem.ReadAllText("D:\Debug\test12.txt")
            'fileReader1 = My.Computer.FileSystem.ReadAllText("Skins/test12.txt")
            ''fileReader1 = My.Computer.FileSystem.ReadAllText("C:\test12.txt")
            'cn.ConnectionString = fileReader1.ToString

            cn.ConnectionString = "Data Source=10.12.112.233;Initial Catalog=barcode;Persist Security Info=True;User ID=sa;Password=a-123456"


            Cru_Count = 10
            If Cru_Count > 10 Then
                Me.Dispose()

            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ''  SqlDataAdapter sda = New SqlDataAdapter("SELECT COUNT(*) FROM tblLogin WHERE username='" + UsernameTextBox.Text + "' AND password='" + PasswordTextBox.Text + "'", cn);
        '/* in above line the program Is selecting the whole data from table And the matching it with the user name And password provided by user. */

        '  DataTable dt = New DataTable(); //this Is creating a virtual table  
        '  sda.Fill(dt);
        '  If (dt.Rows[0][0].ToString() == "1")
        '  {
        '      /* I have made a New page called home page. If the user Is successfully authenticated then the form will be moved to the next form */
        '      this.Hide();
        '      Form1 obj = New Form1();
        '      obj.ShowDialog();
        '  }
        '  Else
        '  MessageBox.Show("Invalid username or password");  
        Try
            If UsernameTextBox.Text = "Point_1" And PasswordTextBox.Text = "1111" Then
                Dim frm As New FrmHeaterStepOneReg
                frm.Show()
                Me.Hide()

            ElseIf UsernameTextBox.Text = "step_four" And PasswordTextBox.Text = "1" Then
                Dim frm As New Heater_Registration__step_four
                frm.Show()
                Me.Hide()

            ElseIf UsernameTextBox.Text = "Point_2" And PasswordTextBox.Text = "2222" Then
                Dim frm As New FrmHeaterStepTwoReg
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "Point_3" And PasswordTextBox.Text = "3333" Then
                Dim frm As New frmHeaterStepTwoOfflinReg
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "Point_4" And PasswordTextBox.Text = "4444" Then
                Dim frm As New FrmHeaterStepThreeReg
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "Repair" And PasswordTextBox.Text = "1" Then
                Dim frm As New frmHeaterRepairReg
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "FG" And PasswordTextBox.Text = "2" Then
                Dim frm As New frmHeaterFinishGoodMFG
                frm.Show()
                Me.Hide()
            ElseIf UsernameTextBox.Text = "a" And PasswordTextBox.Text = "1" Then
                Dim frm As New Heater_add_new_model
                frm.Show()
                Me.Hide()

                'ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
                '    Dim frm As New FrmHeaterMainV00
                '    frm.Show()
                '    Me.Hide()
            Else
                MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub UsernameTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.SelectedIndexChanged

    End Sub

    Private Sub PasswordTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTextBox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then

                If UsernameTextBox.Text = "allPoint" And PasswordTextBox.Text = "1111" Then
                    Dim frm As New Heater_Registration__step_four
                    frm.Show()
                    Me.Hide()
                ElseIf UsernameTextBox.Text = "Point_1" And PasswordTextBox.Text = "0000" Then
                    Dim frm As New Heater_Registration__step_one
                    frm.Show()
                    Me.Hide()
                ElseIf UsernameTextBox.Text = "o" And PasswordTextBox.Text = "0" Then
                    Dim frm As New newshowforData
                    frm.Show()
                    Me.Hide()
                ElseIf UsernameTextBox.Text = "Point_2" And PasswordTextBox.Text = "2222" Then
                    Dim frm As New Heater_Registration__step_three
                    frm.Show()
                    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "k" And PasswordTextBox.Text = "0" Then
                    '    Dim frm As New newshowforData
                    '    frm.Show()
                    '    Me.Hide()

                ElseIf UsernameTextBox.Text = "Point_3" And PasswordTextBox.Text = "3333" Then
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
                    Dim frm As New Heater_main
                    frm.Show()
                    Me.Hide()



                    'ElseIf UsernameTextBox.Text = "fl1" And PasswordTextBox.Text = "1111" Then
                    '    Dim frm As New scanningFat1
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "fl2" And PasswordTextBox.Text = "2222" Then
                    '    Dim frm As New frmFat
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "p" And PasswordTextBox.Text = "1" Then
                    '    Dim frm As New ShowTarget
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "aa" And PasswordTextBox.Text = "11" Then
                    '    Dim frm As New frmAddData
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "out" And PasswordTextBox.Text = "0000" Then
                    '    Dim frm As New frmOutp
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "201015" Then
                    '    Dim frm As New frmMain
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "ll3" And PasswordTextBox.Text = "3333" Then
                    '    Dim frm As New frmFat
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "ll4" And PasswordTextBox.Text = "4444" Then
                    '    Dim frm As New frmMain
                    '    frm.Show()
                    '    Me.Hide()

                    'ElseIf UsernameTextBox.Text = "ll3" And PasswordTextBox.Text = "3333" Then
                    '    Dim frm As New frmFat
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "ll4" And PasswordTextBox.Text = "4444" Then
                    '    Dim frm As New frmMain
                    '    frm.Show()
                    '    Me.Hide()
                    'ElseIf UsernameTextBox.Text = "q" And PasswordTextBox.Text = "1" Then
                    '    Dim frm As New Qulity_in_Or_out
                    '    frm.Show()
                    '    Me.Hide()
                Else
                    MsgBox("من فضلك تأكدمن صحة أدخال البيانات ")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class