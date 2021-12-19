Imports TEVPBarcode.sher
Public Class frmGuidance

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDSetID, fLCDModelName FROM LCDTVModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "LCDTVModels")
            ds.Tables("LCDTVModels").Columns(0).ColumnName = " LCD Set ID "
            ds.Tables("LCDTVModels").Columns(1).ColumnName = " LCD Model Name "
            dg.DataSource = ds.Tables("LCDTVModels")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT  fLCDSetID, fLCDModelName FROM  LCDTVModels "

            sql += " where fLCDModelName ='" & txtPCode.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "LCDTVModels")


            ds.Tables("LCDTVModels").Columns(0).ColumnName = " LCD Set ID "
            ds.Tables("LCDTVModels").Columns(1).ColumnName = " LCD Model Name "

          
            dg1.DataSource = ds.Tables("LCDTVModels")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEARCH.Click
        _Refresh11()
    End Sub

    Private Sub frmGuidance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        _Refresh1()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class