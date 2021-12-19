Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports TEVPBarcode.sher
Public Class frmcookerFinishGoodQuery

    '  Public Class frmQOutp
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh01() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            '  sql += " and C_Line_Shift='" & ComboBox13.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1dd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and NewFactory='" & ComboBox1.Text & "'"
            '    sql += " and C_Line_Shift='" & ComboBox13.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1LLLdd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            '  sql += " and NewFactory='" & ComboBox1.Text & "'"
            '    sql += " and C_Line_Shift='" & ComboBox13.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            '  sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh130() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            '  sql += " and CModelName='" & cmb_Pcode.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            '  sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13LLtt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ''  sql += " and NewFactory='" & ComboBox1.Text & "'"
            'sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            '  sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh13tt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and NewFactory='" & ComboBox1.Text & "'"
            'sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            ' sql += " and fNameL='" & ComboBox2.Text & "'"
            '  sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ' ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub frmQOutp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '   Me.SkinEngine1.SkinFile = "Skins/MidsummerColor3.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT  CModelName FROM CModels "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "CModels")
            cmb_Pcode.DataSource = ds.Tables(0)

            cmb_Pcode.DisplayMember = "CModelName"
            cmb_Pcode.Sorted = True
        Catch ex As Exception
        End Try
        cmb_Pcode.Text = ""
    End Sub
    Private Function _Refresh25() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT CDate,Ctime,CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode"
            sql += " FROM  C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " التاريخ"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الوقت"
            ds.Tables("C_FinishGood_Production").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("C_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(4).ColumnName = " الورديه والخط"
            ds.Tables("C_FinishGood_Production").Columns(5).ColumnName = "المستخدم "
            ds.Tables("C_FinishGood_Production").Columns(6).ColumnName = "الايان كود  "
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (CModelName)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Scerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scerch.Click
        If ComboBox13.Text = "" And ComboBox2.Text = "" And cmb_Pcode.Text = "" And ComboBox1.Text = "" Then
            _Refresh13LLtt()
            _Refresh1LLLdd()
            _Refresh315LLL1pps()
        ElseIf ComboBox13.Text = "" And ComboBox2.Text = "" And cmb_Pcode.Text = "" Then
            _Refresh13tt()
            _Refresh1dd()
            _Refresh3151pps()
        ElseIf ComboBox13.Text = "" And ComboBox2.Text = "" Then
            _Refreshm3()
            _Refreshm2()
            _Refreshm1()
        ElseIf ComboBox13.Text = "" Then
            _Refresh13()
            _Refresh1()
            _Refresh315s()
        Else
            _Refresh130()
            _Refresh01()
            _Refresh3151s()
        End If
    End Sub
    Private Function _Refreshn3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT CDate,Ctime,CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode"
            sql += " FROM  C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " التاريخ"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الوقت"
            ds.Tables("C_FinishGood_Production").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("C_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(4).ColumnName = " الورديه والخط"
            ds.Tables("C_FinishGood_Production").Columns(5).ColumnName = "المستخدم "
            ds.Tables("C_FinishGood_Production").Columns(6).ColumnName = "الايان كود  "
            dgs.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshn2() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  CModelName,COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshn1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315s() As Boolean
        Try
                Dim sql As String = ""
            sql += "SELECT CDate,Ctime,CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode"
            sql += " FROM  C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " التاريخ"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الوقت"
            ds.Tables("C_FinishGood_Production").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("C_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(4).ColumnName = " الورديه والخط"
            ds.Tables("C_FinishGood_Production").Columns(5).ColumnName = "المستخدم "
            ds.Tables("C_FinishGood_Production").Columns(6).ColumnName = "الايان كود  "
            dgs.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3151s() As Boolean
        Try
               Dim sql As String = ""
            sql += "SELECT CDate,Ctime,CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode"
            sql += " FROM  C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and CModelName='" & cmb_Pcode.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " التاريخ"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الوقت"
            ds.Tables("C_FinishGood_Production").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("C_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(4).ColumnName = " الورديه والخط"
            ds.Tables("C_FinishGood_Production").Columns(5).ColumnName = "المستخدم "
            ds.Tables("C_FinishGood_Production").Columns(6).ColumnName = "الايان كود  "
            dgs.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3151pps() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT CDate,Ctime,CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode"
            sql += " FROM  C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and NewFactory='" & ComboBox1.Text & "'"
            '  sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " التاريخ"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الوقت"
            ds.Tables("C_FinishGood_Production").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("C_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(4).ColumnName = " الورديه والخط"
            ds.Tables("C_FinishGood_Production").Columns(5).ColumnName = "المستخدم "
            ds.Tables("C_FinishGood_Production").Columns(6).ColumnName = "الايان كود  "
            dgs.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315LLL1pps() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT CDate,Ctime,CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode"
            sql += " FROM  C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ''    sql += " and NewFactory='" & ComboBox1.Text & "'"
            '  sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " التاريخ"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الوقت"
            ds.Tables("C_FinishGood_Production").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("C_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(4).ColumnName = " الورديه والخط"
            ds.Tables("C_FinishGood_Production").Columns(5).ColumnName = "المستخدم "
            ds.Tables("C_FinishGood_Production").Columns(6).ColumnName = "الايان كود  "
            dgs.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Function _Refresh45() As Boolean
        Try
            Dim sql As String = ""
            '   Dim sql As String = ""
            sql += " SELECT  CModelName,COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            '   sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh44() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            '   sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الكمية "
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
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
            sql += " SELECT  COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            '  sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh4104() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            '  sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
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
            sql += " SELECT  CModelName,COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += " WHERE C_Line_Shift='" & ComboBox2.Text & "'"
            '  sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh404() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            ' sql += " WHERE fLCDPline='" & ComboBox13.Text & "'"
            sql += " WHERE C_Line_Shift='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox13.Text = "" And ComboBox2.Text = "" Then
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
            sql += "SELECT CDate,Ctime,CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode"
            sql += " FROM  C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            ' sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " التاريخ"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الوقت"
            ds.Tables("C_FinishGood_Production").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("C_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(4).ColumnName = " الورديه والخط"
            ds.Tables("C_FinishGood_Production").Columns(5).ColumnName = "المستخدم "
            ds.Tables("C_FinishGood_Production").Columns(6).ColumnName = "الايان كود  "
            dgs.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshm2() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshm1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and CModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الكمية "
            dg3.DataSource = ds.Tables("C_FinishGood_Production")

            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
    Private Function _Refresh990() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += " where CBarcode='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الكميه "
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
                Dim sql As String = ""
            sql += "SELECT CDate,Ctime,CBarcode,CModelName,C_Line_Shift,CSapUser,C_EanCode"
            sql += " FROM  C_FinishGood_Production"
            'sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            ' sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " WHERE CBarcode='" & txtlcdbarcode.Text & "'"
            ' sql += " and C_Line_Shift='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " التاريخ"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الوقت"
            ds.Tables("C_FinishGood_Production").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("C_FinishGood_Production").Columns(3).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(4).ColumnName = " الورديه والخط"
            ds.Tables("C_FinishGood_Production").Columns(5).ColumnName = "المستخدم "
            ds.Tables("C_FinishGood_Production").Columns(6).ColumnName = "الايان كود  "
            dgs.DataSource = ds.Tables("C_FinishGood_Production")
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
            sql += " SELECT CModelName , count (CBarcode)as qty"
            sql += " FROM C_FinishGood_Production"
            sql += " where CBarcode='" & txtlcdbarcode.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
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

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
    Private Function _Refreshnuu() As Boolean
        Try
            '    If e.KeyCode = Keys.Enter Then 20L022A10011470250
            'Dim Barcode_Part2(3) As String
            'Barcode_Part2(0) = ComboBox13.Text.Substring(0, 5)
            'Barcode_Part2(1) = ComboBox13.Text.Substring(5, 2)
            'Barcode_Part2(2) = ComboBox13.Text.Substring(7, 2)
            'Barcode_Part2(3) = ComboBox13.Text.Substring(9, 9)

            Dim sql As String = ""
            sql += " SELECT  CModelName,COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and NewFactory='" & cmb_Pcode.Text & "'"
            '   sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and C_Line='" & ComboBox13.Text & "'"
            sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = " الموديل"
            ds.Tables("C_FinishGood_Production").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
            'End If
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshuu() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (CModelName)  FROM barcode.dbo.C_FinishGood_Production"
            sql += "   WHERE CDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and CDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            '   sql += " and CModelName='" & cmb_Pcode.Text & "'"
            '   sql += " and NewFactory='" & ComboBox13.Text & "'"
            sql += " and C_Line='" & ComboBox13.Text & "'"
            ' sql += " GROUP BY CModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_FinishGood_Production")
            ds.Tables("C_FinishGood_Production").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("C_FinishGood_Production")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub txtlcdbarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlcdbarcode.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtlcdbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtlcdbarcode.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        _Refreshuu()
        _Refreshnuu()
    End Sub
End Class