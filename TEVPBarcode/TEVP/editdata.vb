Imports TEVPBarcode.sher
Public Class editdata
    Private Sub editdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    'Private Function _Refresh11() As Boolean
    '    Try

    '        Dim sql1 As String = "SELECT fModelName, fCompCode, fCompName, fArea FROM   barcode.dbo.Material"
    '        'sql1 += "   where fModelName ='" & txtModel.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "Material")
    '        ds.Tables("Material").Columns(0).ColumnName = " Model Name"
    '        ds.Tables("Material").Columns(1).ColumnName = " component Code"
    '        ds.Tables("Material").Columns(2).ColumnName = "component Name"
    '        ds.Tables("Material").Columns(3).ColumnName = " Area"


    '        dg1.DataSource = ds.Tables("Material")

    '        Return True

    '    Catch ex As Exception

    '    End Try
    'End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' _Refresh1()
    End Sub
    'Private Function _Refresh1() As Boolean
    '    Try

    '        Dim sql1 As String = "SELECT [fLCDSetID],[fLCDModelName],[fpanelID],[fpanelIDLCM]FROM [barcode].[dbo].[LCDTVModels]"
    '        ' sql1 += "   where fLCDModelName ='" & txtModel.Text & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "LCDTVModels")
    '        ds.Tables("LCDTVModels").Columns(0).ColumnName = "LCD Set ID"
    '        ds.Tables("LCDTVModels").Columns(1).ColumnName = "LCD Model Name"
    '        ds.Tables("LCDTVModels").Columns(2).ColumnName = "fpanelID"
    '        ds.Tables("LCDTVModels").Columns(3).ColumnName = "fpanelIDLCM"
    '        dg1.DataSource = ds.Tables("LCDTVModels")

    '        Return True

    '    Catch ex As Exception

    '    End Try
    'End Function

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    _Refresh11()
    'End Sub
    Private Function _Refreshkkkkkk() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT  fLCDModelName,count(fLCDModelName)as Qty FROM yearlyp "

            'sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            'sql += " and fLineandsh ='" & cbl.Text & "'"
            sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(DPTODate.Value, "yyyy-MM-dd") & "'"
            sql += "Group by fLCDModelName"
            'sql += "   and fPtime<= '" & txtfromTime.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")


            ds.Tables("yearlyp").Columns(0).ColumnName = " LCD Model Name "
            ds.Tables("yearlyp").Columns(1).ColumnName = " Qty "
            'ds.Tables("yearlyp").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("yearlyp").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("yearlyp").Columns(4).ColumnName = "line"
            'ds.Tables("yearlyp").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("yearlyp").Columns(6).ColumnName = "Qty"
            dg1.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh001() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count( fLCDSN) FROM  yearlyp "



            sql += "   where fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(DPTODate.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPtime>='" & txttotime.Text & "'"
            'sql += "   and fPtime<= '" & txtfromTime.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds, "yearlyp")

            ds.Tables("yearlyp").Columns(0).ColumnName = " summation "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("yearlyp")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub dg1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    'Private Function Update1A() As Boolean
    '    Try
    '        Dim sql As String
    '        sql = " UPDATE  LCDTVModels set"
    '        sql += "[fLCDSetID]  ,[fLCDModelName],[fpanelID],[fpanelIDLCM]"

    '        sql += " where fid "
    '        'sql += " and part_number = '" & txtpartnumberm.Text & "'"
    '        Dim cmd As New SqlClient.SqlCommand(sql, cn)
    '        If cn.State = ConnectionState.Closed Then cn.Open()
    '        cmd.ExecuteNonQuery()
    '        cn.Close()
    '    Catch ex As Exception
    '    End Try
    'End Function



    Private Sub dg1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        Try
            '  Update1A()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh001()
        _Refreshkkkkkk()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh001()
        _Refreshkkkkkk()
    End Sub
End Class