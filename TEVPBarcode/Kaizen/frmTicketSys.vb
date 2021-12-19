Imports TEVPBarcode.sher

Public Class frmTicketSys

    Private Sub frmTicketSys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Refresh1()

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Add11_New()

        Dim crn As String = comRC.Text
        comFN.Text = ""
        comD.Text = ""
        comS.Text = ""
        txtRS.Text = ""
        comYHD.Text = ""
        txtTC.Text = ""
        txtDR.Text = ""
        MsgBox("تم تسجيل العمليه بنجاح وهذا هو رقم الطلب  :MHI" + crn)
        _Refresh1()
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  (max(fRCode)+1) as dd FROM barcode.dbo.fKaizenMainT "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "fKaizenMainT")
            comRC.DataSource = ds.Tables(0)
            ' comRC.ValueMember = "fRCode"
            comRC.DisplayMember = "dd"
            comRC.Sorted = True



            'Dim sql1 As String = "SELECT  max(fRCode) FROM barcode.dbo.fKaizenMainT"
            ''  sql1 += "   where Model_Name ='" & txtModel.Text & "'"
            'Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "fKaizenMainT")
            'ds.Tables("fKaizenMainT").Columns(0).ColumnName = comRC.DisplayMember

            'comRC.DataSource = ds.Tables("fKaizenMainT")

            Return True

        Catch ex As Exception

        End Try
    End Function


   
    Private Function Add11_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.fKaizenMainT "
            sql += "( fRCode,ffactoryName,fDepartment,fsection,fRService,fHDesin,fTelphonNumber,fDescrpationReq )"
            sql += " VALUES ('" & comRC.Text & "','" & comFN.Text & "','" & comD.Text & "','" & comS.Text & "','" & txtRS.Text & "','" & comYHD.Text & "','" & txtTC.Text & "','" & txtDR.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub
End Class