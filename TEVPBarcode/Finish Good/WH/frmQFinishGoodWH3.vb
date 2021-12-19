
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports TEVPBarcode.sher
Public Class frmQFinishGoodWH3


    ' Public Class frmQFinishGoodWH2

    'Public Class frmQFinishGoodWH1

    ' Public Class frmQOutp
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fModel , count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "  Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh01() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fModel , count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "  Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1dd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fModel , count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh130() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh13tt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmQOutp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
    End Sub
    Private Function _Refresh25() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fModel, fLCDSetID, fLCDBarcode, fPDate, fLCDPline, fNameL"
            sql += " FROM  OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " LCDSetID"
            ds.Tables("OutputWH3").Columns(2).ColumnName = "LCD Barcode"
            ds.Tables("OutputWH3").Columns(3).ColumnName = " Date"
            ds.Tables("OutputWH3").Columns(4).ColumnName = " LCDPline"
            ds.Tables("OutputWH3").Columns(5).ColumnName = "NameL"

            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Scerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scerch.Click
        If ComboBox1.Text = "" And ComboBox2.Text = "" Then
            _Refresh13tt()
            _Refresh1dd()
            _Refresh3151pps()

        ElseIf ComboBox1.Text = "" Then
            _Refreshn1()
            _Refreshn2()
            _Refreshn3()
        Else
            _Refresh130()
            _Refresh01()
            _Refresh3151s()
        End If

    End Sub
    Private Function _Refreshn3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate,fPtime, fModel, fLCDBarcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '    sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "Data "
            ds.Tables("OutputWH3").Columns(1).ColumnName = "Time"
            ds.Tables("OutputWH3").Columns(2).ColumnName = " Model Name"
            ds.Tables("OutputWH3").Columns(3).ColumnName = " Barcode"
            ds.Tables("OutputWH3").Columns(4).ColumnName = "LCD P year"
            ds.Tables("OutputWH3").Columns(5).ColumnName = "LCD p Week"
            ' ds.Tables("View_4").Columns(5).ColumnName = "LCD Set ID "
            ds.Tables("OutputWH3").Columns(6).ColumnName = "LCD Country"
            ds.Tables("OutputWH3").Columns(7).ColumnName = "LCD P line"
            ds.Tables("OutputWH3").Columns(8).ColumnName = " fLCDPID"
            ds.Tables("OutputWH3").Columns(9).ColumnName = " SN"
            ds.Tables("OutputWH3").Columns(10).ColumnName = "Name shift"
            dgs.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshn2() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fModel , count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            ' sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshn1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            '  sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315s() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT fPDate,fPtime, fModel, fLCDBarcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "Data "
            ds.Tables("OutputWH3").Columns(1).ColumnName = "Time"
            ds.Tables("OutputWH3").Columns(2).ColumnName = " Model Name"
            ds.Tables("OutputWH3").Columns(3).ColumnName = " Barcode"
            ds.Tables("OutputWH3").Columns(4).ColumnName = "LCD P year"
            ds.Tables("OutputWH3").Columns(5).ColumnName = "LCD p Week"
            ' ds.Tables("View_4").Columns(5).ColumnName = "LCD Set ID "
            ds.Tables("OutputWH3").Columns(6).ColumnName = "LCD Country"
            ds.Tables("OutputWH3").Columns(7).ColumnName = "LCD P line"
            ds.Tables("OutputWH3").Columns(8).ColumnName = " fLCDPID"
            ds.Tables("OutputWH3").Columns(9).ColumnName = " SN"
            ds.Tables("OutputWH3").Columns(10).ColumnName = "Name shift"
            dgs.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3151s() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate,fPtime, fModel, fLCDBarcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "Data "
            ds.Tables("OutputWH3").Columns(1).ColumnName = "Time"
            ds.Tables("OutputWH3").Columns(2).ColumnName = " Model Name"
            ds.Tables("OutputWH3").Columns(3).ColumnName = " Barcode"
            ds.Tables("OutputWH3").Columns(4).ColumnName = "LCD P year"
            ds.Tables("OutputWH3").Columns(5).ColumnName = "LCD p Week"
            ' ds.Tables("View_4").Columns(5).ColumnName = "LCD Set ID "
            ds.Tables("OutputWH3").Columns(6).ColumnName = "LCD Country"
            ds.Tables("OutputWH3").Columns(7).ColumnName = "LCD P line"
            ds.Tables("OutputWH3").Columns(8).ColumnName = " fLCDPID"
            ds.Tables("OutputWH3").Columns(9).ColumnName = " SN"
            ds.Tables("OutputWH3").Columns(10).ColumnName = "Name shift"
            dgs.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3151pps() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate,fPtime, fModel, fLCDBarcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "Data "
            ds.Tables("OutputWH3").Columns(1).ColumnName = "Time"
            ds.Tables("OutputWH3").Columns(2).ColumnName = " Model Name"
            ds.Tables("OutputWH3").Columns(3).ColumnName = " Barcode"
            ds.Tables("OutputWH3").Columns(4).ColumnName = "LCD P year"
            ds.Tables("OutputWH3").Columns(5).ColumnName = "LCD p Week"
            ' ds.Tables("View_4").Columns(5).ColumnName = "LCD Set ID "
            ds.Tables("OutputWH3").Columns(6).ColumnName = "LCD Country"
            ds.Tables("OutputWH3").Columns(7).ColumnName = "LCD P line"
            ds.Tables("OutputWH3").Columns(8).ColumnName = " fLCDPID"
            ds.Tables("OutputWH3").Columns(9).ColumnName = " SN"
            ds.Tables("OutputWH3").Columns(10).ColumnName = "Name shift"
            dgs.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Function _Refresh45() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  fModel,COUNT (fModel)  FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "  Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh44() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (fModel)  FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    Close()
    'End Sub
    Private Function _Refresh405() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  fModel,COUNT (fModel)  FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = " LCD Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh4104() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (fModel)  FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    _Refresh25()
    '    _Refresh15()


    'End Sub
    Private Function _Refresh4105() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  fModel,COUNT (fModel)  FROM OutputWH3"
            sql += " WHERE fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "  Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh404() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (fModel)  FROM OutputWH3"
            sql += " WHERE fLCDPline='" & ComboBox1.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" And ComboBox2.Text = "" Then
            _Refreshm3()
            _Refreshm2()
            _Refreshm1()

        Else
            _Refresh13()
            _Refresh1()
            _Refresh315s()
        End If

    End Sub
    Private Function _Refreshm3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate,fPtime, fModel, fLCDBarcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "Data "
            ds.Tables("OutputWH3").Columns(1).ColumnName = "Time"
            ds.Tables("OutputWH3").Columns(2).ColumnName = " Model Name"
            ds.Tables("OutputWH3").Columns(3).ColumnName = " Barcode"
            ds.Tables("OutputWH3").Columns(4).ColumnName = "LCD P year"
            ds.Tables("OutputWH3").Columns(5).ColumnName = "LCD p Week"
            ' ds.Tables("View_4").Columns(5).ColumnName = "LCD Set ID "
            ds.Tables("OutputWH3").Columns(6).ColumnName = "LCD Country"
            ds.Tables("OutputWH3").Columns(7).ColumnName = "LCD P line"
            ds.Tables("OutputWH3").Columns(8).ColumnName = " fLCDPID"
            ds.Tables("OutputWH3").Columns(9).ColumnName = " SN"
            ds.Tables("OutputWH3").Columns(10).ColumnName = "Name shift"
            dgs.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshm2() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fModel , count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = " Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshm1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM OutputWH3"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fModel='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    'Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    '    _Refresh404()
    '    _Refresh405()
    'End Sub
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    _Refresh4104()
    '    _Refresh4105()
    'End Sub
    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Function _Refresh990() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDBarcode)as qty"
            sql += " FROM OutputWH3"
            sql += " where fLCDBarcode='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "S U M "
            dg3.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  fPDate,fPtime, fModel, fLCDBarcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL FROM OutputWH3"
            ' sql += " FROM Output"
            sql += " where fLCDBarcode='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = "Data "
            ds.Tables("OutputWH3").Columns(1).ColumnName = "Time"
            ds.Tables("OutputWH3").Columns(2).ColumnName = " Model Name"
            ds.Tables("OutputWH3").Columns(3).ColumnName = " Barcode"
            ds.Tables("OutputWH3").Columns(4).ColumnName = "LCD P year"
            ds.Tables("OutputWH3").Columns(5).ColumnName = "LCD p Week"
            ' ds.Tables("View_4").Columns(5).ColumnName = "LCD Set ID "
            ds.Tables("OutputWH3").Columns(6).ColumnName = "LCD Country"
            ds.Tables("OutputWH3").Columns(7).ColumnName = "LCD P line"
            ds.Tables("OutputWH3").Columns(8).ColumnName = " fLCDPID"
            ds.Tables("OutputWH3").Columns(9).ColumnName = " SN"
            ds.Tables("OutputWH3").Columns(10).ColumnName = "Name shift"
            dgs.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModel.Click
        _Refresh315()
        _Refresh990()
        _Refresh7701()
    End Sub
    Private Function _Refresh7701() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fModel , count (fModel)as qty"
            sql += " FROM OutputWH3"
            sql += " where fLCDBarcode='" & txtlcdbarcode.Text & "'"
            sql += " GROUP BY fModel "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "OutputWH3")
            ds.Tables("OutputWH3").Columns(0).ColumnName = " Model Name"
            ds.Tables("OutputWH3").Columns(1).ColumnName = " Qty"
            DG1.DataSource = ds.Tables("OutputWH3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub cmb_Pcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Pcode.SelectedIndexChanged

    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            'Dim frm As New frmReport
            'Dim rpt As New FINISHGOOD
            'rpt.SetDatabaseLogon("sa", "201015")
            'rpt.RecordSelectionFormula = "{View_2.fLCDPline}='" & ComboBox1.Text & "'"
            ''rpt.RecordSelectionFormula += " and {Output.fLCDModelName}='" & cmb_Pcode.Text & "'"
            ''rpt.RecordSelectionFormula += " and {Output.fNameL}='" & ComboBox2.Text & "'"
            ''rpt.RecordSelectionFormula += " and {Output.fPDate}>=#" & Format(dtbfrom.Value, "yyyy-MM-dd") & "#"
            ''rpt.RecordSelectionFormula += " and {Output.fPDate}<=#" & Format(dtbto.Value, "yyyy-MM-dd") & "#"
            'frm.crv.ReportSource = rpt
            'frm.Show()
            'Me.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _Refresh13tt()
        _Refresh1dd()
        _Refresh3151pps()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class