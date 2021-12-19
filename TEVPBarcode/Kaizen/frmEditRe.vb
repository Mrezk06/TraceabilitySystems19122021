Imports outlook = Microsoft.Office.Interop.Outlook
Imports TEVPBarcode.sher
Public Class frmEditRe
    'Private Sub SendEmail(ByVal Message As String, ByVal EmailAddress As String)
    '    Dim objOutlook As Object
    '    Dim objOutlookMsg As Object
    '    objOutlook = CreateObject("Outlook.Application")
    '    objOutlookMsg = objOutlook.CreateItem(0)
    '    With objOutlookMsg
    '        .To = EmailAddress
    '        .Subject = "Subject"
    '        .Body = Message
    '        .Send()
    '    End With
    '    objOutlookMsg = Nothing
    '    objOutlook = Nothing
    'End Sub
    '    With objOulookMsg
    '    .To = EmailAddress
    '    .Recipients.ResolveAll()
    '    .Subject = "Subject"
    '    ' .BodyFormat = outlook.OlBodyFormat.olFormatPlain 
    '    ' symbolic constant olFormatPlain not known without Outlook project reference!
    '    .BodyFormat = 1    
    '    .Body = Message
    'End With
    Private Sub frmEditRe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function Add11_New() As Boolean
        Try
            Dim sql As String
            sql = "	INSERT INTO barcode.dbo.fKaizenComment "
            sql += "( fRCode,fTelphonNumber,fDescrpationReq,fStatus  )"
            sql += " VALUES ('" & txtRC.Text & "','" & txtTC.Text & "','" & txtDR.Text & "','" & comRC.Text & "')"
            Dim cmd As New SqlClient.SqlCommand(sql, cn)
            If cn.State = ConnectionState.Closed Then cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1227() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fRCode,fTelphonNumber ,fDescrpationReq,fStatus FROM barcode.dbo.fKaizenComment"
            'sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            'sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            ' sql1 += "   where ffactoryName ='" & comFN.Text & "'"
            ' sql1 += "   and fDepartment ='" & comD.Text & "'"
            sql1 += "   where fRCode =" & txtRC.Text & ""
            '  sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "fKaizenMainT")
            ds.Tables("fKaizenMainT").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("fKaizenMainT").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("fKaizenMainT").Columns(2).ColumnName = "كود الخدمة"

            ds.Tables("fKaizenMainT").Columns(3).ColumnName = " رقم التليفون للتواصل"
            ds.Tables("fKaizenMainT").Columns(4).ColumnName = "التعليق على الخدمه"
            ds.Tables("fKaizenMainT").Columns(5).ColumnName = " حالة الخدمة "

            dg.DataSource = ds.Tables("fKaizenMainT")

            Return True

        Catch ex As Exception

        End Try
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add11_New()
        _Refresh1227()

        txtTC.Text = ""
        txtDR.Text = ""
        comRC.Text = ""
        txtRC.Focus()


    End Sub
End Class