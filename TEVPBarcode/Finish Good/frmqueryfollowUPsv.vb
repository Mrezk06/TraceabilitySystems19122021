Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports TEVPBarcode.sher
Public Class frmqueryfollowUPsv

    Private Sub frmqueryfollowUPsv_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Me.SkinEngine1.SkinFile = "Skins/MidsummerColor3.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDModelName FROM   LCDTVModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")
            cmb_Pcode.DataSource = ds.Tables(0)

            cmb_Pcode.DisplayMember = "fLCDModelName"
            cmb_Pcode.Sorted = True
        Catch ex As Exception
        End Try
        cmb_Pcode.Text = ""
    End Sub
    Private Function _Refresh112() As Boolean
        Try
            Dim sql1 As String = "SELECT  fPDate,fPtime,fDate, fSVNAME, fSVNUM, fModelName, fLineAndShift, fSap_L, fQTYA, fQTYD FROM followupSV"
            ' sql1 += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql1 += " and fModelName='" & cmb_Pcode.Text & "'"
            'sql1 += " and fLineAndShift='" & txtline.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "followupSV")
            ds.Tables("followupSV").Columns(0).ColumnName = "date R"
            ds.Tables("followupSV").Columns(1).ColumnName = "Time R"
            ds.Tables("followupSV").Columns(2).ColumnName = "date"
            ds.Tables("followupSV").Columns(3).ColumnName = "S.V Name"
            ds.Tables("followupSV").Columns(4).ColumnName = "S.V ID"
            ds.Tables("followupSV").Columns(5).ColumnName = "Model name"
            ds.Tables("followupSV").Columns(6).ColumnName = "Line And Shift"
            ds.Tables("followupSV").Columns(7).ColumnName = "Sap Num"
            ds.Tables("followupSV").Columns(8).ColumnName = "QTY Actually"
            ds.Tables("followupSV").Columns(9).ColumnName = "QTY difference"
            dgs.DataSource = ds.Tables("followupSV")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh1122() As Boolean
        Try
            Dim sql1 As String = "SELECT  fPDate,fPtime,fDate, fSVNAME, fSVNUM, fModelName, fLineAndShift, fSap_L, fQTYA, fQTYD FROM followupSV"
            ' sql1 += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql1 += " and fModelName='" & cmb_Pcode.Text & "'"
            ' sql1 += " and fLineAndShift='" & txtline.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "followupSV")
            ds.Tables("followupSV").Columns(0).ColumnName = "date R"
            ds.Tables("followupSV").Columns(1).ColumnName = "Time R"
            ds.Tables("followupSV").Columns(2).ColumnName = "date"
            ds.Tables("followupSV").Columns(3).ColumnName = "S.V Name"
            ds.Tables("followupSV").Columns(4).ColumnName = "S.V ID"
            ds.Tables("followupSV").Columns(5).ColumnName = "Model name"
            ds.Tables("followupSV").Columns(6).ColumnName = "Line And Shift"
            ds.Tables("followupSV").Columns(7).ColumnName = "Sap Num"
            ds.Tables("followupSV").Columns(8).ColumnName = "QTY Actually"
            ds.Tables("followupSV").Columns(9).ColumnName = "QTY difference"
            dgs.DataSource = ds.Tables("followupSV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11221() As Boolean
        Try
            Dim sql1 As String = "SELECT  fPDate,fPtime,fDate, fSVNAME, fSVNUM, fModelName, fLineAndShift, fSap_L, fQTYA, fQTYD FROM followupSV"
            ' sql1 += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql1 += " and fModelName='" & cmb_Pcode.Text & "'"
            sql1 += " and fLineAndShift='" & txtline.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "followupSV")
            ds.Tables("followupSV").Columns(0).ColumnName = "date R"
            ds.Tables("followupSV").Columns(1).ColumnName = "Time R"
            ds.Tables("followupSV").Columns(2).ColumnName = "date"
            ds.Tables("followupSV").Columns(3).ColumnName = "S.V Name"
            ds.Tables("followupSV").Columns(4).ColumnName = "S.V ID"
            ds.Tables("followupSV").Columns(5).ColumnName = "Model name"
            ds.Tables("followupSV").Columns(6).ColumnName = "Line And Shift"
            ds.Tables("followupSV").Columns(7).ColumnName = "Sap Num"
            ds.Tables("followupSV").Columns(8).ColumnName = "QTY Actually"
            ds.Tables("followupSV").Columns(9).ColumnName = "QTY difference"
            dgs.DataSource = ds.Tables("followupSV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1126() As Boolean
        Try
            Dim sql1 As String = "SELECT  fPDate,fPtime,fDate, fSVNAME, fSVNUM, fModelName, fLineAndShift, fSap_L, fQTYA, fQTYD FROM followupSV"
            ' sql1 += " WHERE fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            sql1 += "   WHERE fDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql1 += " and fModelName='" & cmb_Pcode.Text & "'"
            sql1 += " and fLineAndShift='" & txtline.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "followupSV")
            ds.Tables("followupSV").Columns(0).ColumnName = "date R"
            ds.Tables("followupSV").Columns(1).ColumnName = "Time R"
            ds.Tables("followupSV").Columns(2).ColumnName = "date"
            ds.Tables("followupSV").Columns(3).ColumnName = "S.V Name"
            ds.Tables("followupSV").Columns(4).ColumnName = "S.V ID"
            ds.Tables("followupSV").Columns(5).ColumnName = "Model name"
            ds.Tables("followupSV").Columns(6).ColumnName = "Line And Shift"
            ds.Tables("followupSV").Columns(7).ColumnName = "Sap Num"
            ds.Tables("followupSV").Columns(8).ColumnName = "QTY Actually"
            ds.Tables("followupSV").Columns(9).ColumnName = "QTY difference"
            dgs.DataSource = ds.Tables("followupSV")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtline.Text = "" And cmb_Pcode.Text = "" Then
            _Refresh112()
        ElseIf txtline.Text = "" Then
            _Refresh1122()
        ElseIf cmb_Pcode.Text = "" Then

            _Refresh11221()

        Else
            _Refresh1126()
        End If
    End Sub

    Private Sub dtbto_ValueChanged(sender As Object, e As EventArgs) Handles dtbto.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class