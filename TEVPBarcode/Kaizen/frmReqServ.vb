Imports TEVPBarcode.sher

Public Class frmReqServ

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub frmReqServ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function _Refresh11017() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fRCode,ffactoryName,fDepartment,fsection,fRService,fHDesin,fTelphonNumber,fDescrpationReq  FROM fKaizenMainT"
            'sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            'sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += "   where ffactoryName ='" & comFN.Text & "'"
            sql1 += "   and fDepartment ='" & comD.Text & "'"
            ' sql1 += "   and fRCode =" & txtRC.Text & ""
            '  sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "fKaizenMainT")
            ds.Tables("fKaizenMainT").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("fKaizenMainT").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("fKaizenMainT").Columns(2).ColumnName = "كود الخدمة"
            ds.Tables("fKaizenMainT").Columns(3).ColumnName = "اسم المصنع"
            ds.Tables("fKaizenMainT").Columns(4).ColumnName = " اسم الادارة"
            ds.Tables("fKaizenMainT").Columns(5).ColumnName = " اسم القسم"
            ds.Tables("fKaizenMainT").Columns(6).ColumnName = " اسم طالب الخدمة "
            ds.Tables("fKaizenMainT").Columns(7).ColumnName = " يوجد تصميم ام لا "
            ds.Tables("fKaizenMainT").Columns(8).ColumnName = " رقم التليفون للتواصل"
            ds.Tables("fKaizenMainT").Columns(9).ColumnName = " وصف الطلب "

            DG2.DataSource = ds.Tables("fKaizenMainT")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh1117() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fRCode,ffactoryName,fDepartment,fsection,fRService,fHDesin,fTelphonNumber,fDescrpationReq  FROM fKaizenMainT"
            'sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            'sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += "   where ffactoryName ='" & comFN.Text & "'"
            sql1 += "   and fDepartment ='" & comD.Text & "'"
            sql1 += "   and fRCode =" & txtRC.Text & ""
            '  sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "fKaizenMainT")
            ds.Tables("fKaizenMainT").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("fKaizenMainT").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("fKaizenMainT").Columns(2).ColumnName = "كود الخدمة"
            ds.Tables("fKaizenMainT").Columns(3).ColumnName = "اسم المصنع"
            ds.Tables("fKaizenMainT").Columns(4).ColumnName = " اسم الادارة"
            ds.Tables("fKaizenMainT").Columns(5).ColumnName = " اسم القسم"
            ds.Tables("fKaizenMainT").Columns(6).ColumnName = " اسم طالب الخدمة "
            ds.Tables("fKaizenMainT").Columns(7).ColumnName = " يوجد تصميم ام لا "
            ds.Tables("fKaizenMainT").Columns(8).ColumnName = " رقم التليفون للتواصل"
            ds.Tables("fKaizenMainT").Columns(9).ColumnName = " وصف الطلب "

            DG2.DataSource = ds.Tables("fKaizenMainT")

            Return True

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

            DG1.DataSource = ds.Tables("fKaizenMainT")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtRC.Text = "" Then

            _Refresh11017()
        Else
            _Refresh1117()
            _Refresh1227()
        End If


     
    End Sub
End Class