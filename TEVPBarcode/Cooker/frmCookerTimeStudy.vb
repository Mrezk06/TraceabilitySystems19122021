Imports TEVPBarcode.sher
Public Class frmCookerTimeStudy
    '  Public Class MainForm
    Dim stopLoop As Integer = 0
    Dim sW As Stopwatch = New Stopwatch
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'close form
        Me.Close()

    End Sub

    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        If txtcodeUse.Text = "" Or txtFN.Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtVC.Text = "" Then
            MsgBox("please Entry All Data")
        Else
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            '    Me.Size = New Size(570, 250)
            'start the clock
            AxWindowsMediaPlayer1.Visible = True
            g3.Visible = False
            g2.Visible = False

            Dim sec As Integer = Nothing
            Dim hsec As Double
            Dim tsec As Double


            'Reset the loop variable.
            stopLoop = 0

            'Start the stopWatch.
            sW.Start()

            Do
                My.Application.DoEvents()
                'Calculate Time
                sec = CInt(sW.ElapsedMilliseconds \ 1000)
                hsec = CInt(sW.ElapsedMilliseconds \ 10)
                tsec = CInt(sW.ElapsedMilliseconds \ 100)


                'Get the elapsed time in seconds.
                Me.lblSeconds.Text = sec.ToString
                Me.lblHundSeconds.Text = hsec.ToString
                Me.lblTenSeconds.Text = tsec.ToString

                'Continue to loop until the stop button is pushed.
            Loop Until stopLoop = 1


        End If
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()

        stopLoop = 1
        sW.Stop()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim sql As String = ""
            sql += "SELECT CModelName FROM CModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "CModels")
            txtMN.DataSource = ds.Tables(0)
            txtMN.DisplayMember = "CModelName"
            txtMN.Sorted = True
            '   _Refresh315()

        Catch ex As Exception

        End Try

        txtMN.Text = ""
    End Sub

    Private Sub Stopwatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        If txtA.Text = "" Then
            MsgBox("please Entry All Data")
        Else
            stopLoop = 1
            sW.Stop()
            Add11_NewA()
            stopLoop = 0
            sW.Reset()
            stopLoop = 0
            sW.Start()
        End If

    End Sub
    Private Function Add11_NewA() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.TimeStudy "
            sql += "(fUserCode,fFectoryName,fType,fTypeDisc,fNameProcess,fModelName,fTimeBalnce)"
            sql += " VALUES (" & txtcodeUse.Text & ",'" & txtFN.Text & "','" & txtVC.Text & "','" & txtA.Text & "','" & txtPN.Text & "','" & txtMN.Text & "'," & lblSeconds.Text & ")"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function Add11_NewB() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.TimeStudy "
            sql += "(fUserCode,fFectoryName,fType,fTypeDisc,fNameProcess,fModelName,fTimeBalnce)"
            sql += " VALUES (" & txtcodeUse.Text & ",'" & txtFN.Text & "','" & txtVC.Text & "','" & txtB.Text & "','" & txtPN.Text & "','" & txtMN.Text & "'," & lblSeconds.Text & ")"
            '' .Text = "" Or .Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtVC.Text = ""


            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function Add11_NewC() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.TimeStudy "
            sql += "(fUserCode,fFectoryName,fType,fTypeDisc,fNameProcess,fModelName,fTimeBalnce)"
            sql += " VALUES (" & txtcodeUse.Text & ",'" & txtFN.Text & "','" & txtVC.Text & "','" & txtC.Text & "','" & txtPN.Text & "','" & txtMN.Text & "'," & lblSeconds.Text & ")"
            '' .Text = "" Or .Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtVC.Text = ""


            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function Add11_NewD() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.TimeStudy "
            sql += "(fUserCode,fFectoryName,fType,fTypeDisc,fNameProcess,fModelName,fTimeBalnce)"
            sql += " VALUES (" & txtcodeUse.Text & ",'" & txtFN.Text & "','" & txtVC.Text & "','" & txtD.Text & "','" & txtPN.Text & "','" & txtMN.Text & "'," & lblSeconds.Text & ")"
            '' .Text = "" Or .Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtVC.Text = ""


            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function Add11_NewE() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.TimeStudy "
            sql += "(fUserCode,fFectoryName,fType,fTypeDisc,fNameProcess,fModelName,fTimeBalnce)"
            sql += " VALUES (" & txtcodeUse.Text & ",'" & txtFN.Text & "','" & txtVC.Text & "','" & txtE.Text & "','" & txtPN.Text & "','" & txtMN.Text & "'," & lblSeconds.Text & ")"
            '' .Text = "" Or .Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtVC.Text = ""


            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function Add11_NewF() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.TimeStudy "
            sql += "(fUserCode,fFectoryName,fType,fTypeDisc,fNameProcess,fModelName,fTimeBalnce)"
            sql += " VALUES (" & txtcodeUse.Text & ",'" & txtFN.Text & "','" & txtVC.Text & "','" & txtF.Text & "','" & txtPN.Text & "','" & txtMN.Text & "'," & lblSeconds.Text & ")"
            '' .Text = "" Or .Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtVC.Text = ""


            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function Add11_NewG() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.TimeStudy "
            sql += "(fUserCode,fFectoryName,fType,fTypeDisc,fNameProcess,fModelName,fTimeBalnce)"
            sql += " VALUES (" & txtcodeUse.Text & ",'" & txtFN.Text & "','" & txtVC.Text & "','" & txtG.Text & "','" & txtPN.Text & "','" & txtMN.Text & "'," & lblSeconds.Text & ")"
            '' .Text = "" Or .Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtVC.Text = ""


            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Function Add11_NewH() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.TimeStudy "
            sql += "(fUserCode,fFectoryName,fType,fTypeDisc,fNameProcess,fModelName,fTimeBalnce)"
            sql += " VALUES (" & txtcodeUse.Text & ",'" & txtFN.Text & "','" & txtVC.Text & "','" & txtH.Text & "','" & txtPN.Text & "','" & txtMN.Text & "'," & lblSeconds.Text & ")"
            '' .Text = "" Or .Text = "" Or txtMN.Text = "" Or txtPN.Text = "" Or txtVC.Text = ""


            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()

            cn.Close()


        Catch ex As Exception

        End Try
    End Function
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If txtC.Text = "" Then
            MsgBox("please Entry All Data")
        Else

            stopLoop = 1
            sW.Stop()

            Add11_NewC()

            stopLoop = 0
            sW.Reset()
            stopLoop = 0
            sW.Start()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If txtB.Text = "" Then
            MsgBox("please Entry All Data")
        Else

            stopLoop = 1
            sW.Stop()

            Add11_NewB()

            stopLoop = 0
            sW.Reset()
            stopLoop = 0
            sW.Start()
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If txtF.Text = "" Then
            MsgBox("please Entry All Data")
        Else

            stopLoop = 1
            sW.Stop()

            Add11_NewF()

            stopLoop = 0
            sW.Reset()
            stopLoop = 0
            sW.Start()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If txtD.Text = "" Then
            MsgBox("please Entry All Data")
        Else

            stopLoop = 1
            sW.Stop()

            Add11_NewD()

            stopLoop = 0
            sW.Reset()
            stopLoop = 0
            sW.Start()
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If txtH.Text = "" Then
            MsgBox("please Entry All Data")
        Else

            stopLoop = 1
            sW.Stop()

            Add11_NewH()

            stopLoop = 0
            sW.Reset()
            stopLoop = 0
            sW.Start()
        End If

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        If txtG.Text = "" Then
            MsgBox("please Entry All Data")
        Else

            stopLoop = 1
            sW.Stop()

            Add11_NewG()

            stopLoop = 0
            sW.Reset()
            stopLoop = 0
            sW.Start()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Size = New Size(570, 250)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txtE.Text = "" Then
            MsgBox("please Entry All Data")
        Else

            stopLoop = 1
            sW.Stop()

            Add11_NewE()

            stopLoop = 0
            sW.Reset()
            stopLoop = 0
            sW.Start()
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ' AxWindowsMediaPlayer1.Ctlcontrols.playItem()
        Dim frm As New frmCookerTimeStudyQuery
        frm.Show()

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        Dim ddd As String = OpenFileDialog1.FileName

        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        txtVC.Text = ddd
    End Sub

    Private Sub txtcodeUse_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodeUse.KeyDown
        Try
            If txtcodeUse.Text.Length < 8 Then Exit Sub

            Dim dsMax As New DataSet
            Dim Sql = "SELECT  Heater_Name_Laber FROM Heater_Name_Sap "
            Sql += " where Heater_Sap_Laber='" & txtcodeUse.Text & "'"
            '   Sql += " and Heater_sap_stu='Active'"
            Dim da As New SqlClient.SqlDataAdapter(Sql, cn)
            dsMax.Tables.Clear()
            da.Fill(dsMax)
            If dsMax.Tables(0).Rows.Count < 1 Then
                '  lbl_Msg.ForeColor = Color.Red
                MsgBox(" غير  مصرح بالدخول ")
                Console.Beep()
                txtcodeUse.Focus()
                txtcodeUse.SelectAll()
                Exit Sub
            Else
                '  _Refresh315()
                '  lbl_Msg.ForeColor = Color.Green
                ' MsgBox("مرحبا بك فى برنامج مصنع البتوجاز لمتابعة الانتاج ")
               
                txtFN.Focus()
                'Me.BackColor = Color.YellowGreen
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtcodeUse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodeUse.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcodeUse_TextChanged(sender As Object, e As EventArgs) Handles txtcodeUse.TextChanged

    End Sub
End Class
