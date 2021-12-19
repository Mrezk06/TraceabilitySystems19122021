Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports TEVPBarcode.sher
Public Class frmQOutp
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh01() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            ' sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            ' sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1dd() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh13() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            ' sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh130() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            ' sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh13tt() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            'sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline='" & ComboBox1.Text & "'"
            'sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الكمية "
            dg3.DataSource = ds.Tables("View_2")
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
            sql += "SELECT fLCDModelName, fLCDSetID, fLCDBarcode, fPDate, fLCDPline, fNameL"
            sql += " FROM  View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " كود الموديل"
            ds.Tables("View_2").Columns(2).ColumnName = "باركود الجهاز"
            ds.Tables("View_2").Columns(3).ColumnName = " التاريخ"
            ds.Tables("View_2").Columns(4).ColumnName = " الخط"
            ds.Tables("View_2").Columns(5).ColumnName = "الخط والوردية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh15() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub Scerch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scerch.Click
        If ComboBox13.Text = "" And ComboBox2.Text = "" Then
            _Refresh13tt()
            _Refresh1dd()
            _Refresh3151pps()
        Else
            _Refresh130()
            _Refresh01()
            _Refresh3151s()
        End If
    End Sub
    Private Function _Refreshn3() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  Date, Time, fLCDModelName, Barcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL,Heater_Name_Laber  FROM View_4,Heater_Name_Sap"
            sql += "   WHERE Date>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and Date<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_4")
            ds.Tables("View_4").Columns(0).ColumnName = "التاريخ "
            ds.Tables("View_4").Columns(1).ColumnName = "الوقت"
            ds.Tables("View_4").Columns(2).ColumnName = " الموديل"
            ds.Tables("View_4").Columns(3).ColumnName = " الباركود"
            ds.Tables("View_4").Columns(4).ColumnName = "رمز السنه"
            ds.Tables("View_4").Columns(5).ColumnName = "رمز الاسبوع"
            ds.Tables("View_4").Columns(6).ColumnName = "رمز البلد"
            ds.Tables("View_4").Columns(7).ColumnName = "الخط "
            ds.Tables("View_4").Columns(8).ColumnName = " كود الشاشه"
            ds.Tables("View_4").Columns(9).ColumnName = " كود الجهاز"
            ds.Tables("View_4").Columns(10).ColumnName = "الخط والوردية"
            ds.Tables("View_4").Columns(11).ColumnName = "اسم المسئول"
            dgs.DataSource = ds.Tables("View_4")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshn2() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshn1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315s() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  Date, Time, fLCDModelName, Barcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL,Heater_Name_Laber FROM View_4"
            sql += "   WHERE Date>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and Date<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_4")
            ds.Tables("View_4").Columns(0).ColumnName = "التاريخ "
            ds.Tables("View_4").Columns(1).ColumnName = "الوقت"
            ds.Tables("View_4").Columns(2).ColumnName = " الموديل"
            ds.Tables("View_4").Columns(3).ColumnName = " الباركود"
            ds.Tables("View_4").Columns(4).ColumnName = "رمز السنه"
            ds.Tables("View_4").Columns(5).ColumnName = "رمز الاسبوع"
            ds.Tables("View_4").Columns(6).ColumnName = "رمز البلد"
            ds.Tables("View_4").Columns(7).ColumnName = "الخط "
            ds.Tables("View_4").Columns(8).ColumnName = " كود الشاشه"
            ds.Tables("View_4").Columns(9).ColumnName = " كود الجهاز"
            ds.Tables("View_4").Columns(10).ColumnName = "الخط والوردية"
            ds.Tables("View_4").Columns(11).ColumnName = "اسم المسئول"
            dgs.DataSource = ds.Tables("View_4")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3151s() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  Date, Time, fLCDModelName, Barcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL,Heater_Name_Laber FROM View_4"
            sql += "   WHERE Date>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and Date<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_4")
            ds.Tables("View_4").Columns(0).ColumnName = "التاريخ "
            ds.Tables("View_4").Columns(1).ColumnName = "الوقت"
            ds.Tables("View_4").Columns(2).ColumnName = " الموديل"
            ds.Tables("View_4").Columns(3).ColumnName = " الباركود"
            ds.Tables("View_4").Columns(4).ColumnName = "رمز السنه"
            ds.Tables("View_4").Columns(5).ColumnName = "رمز الاسبوع"
            ds.Tables("View_4").Columns(6).ColumnName = "رمز البلد"
            ds.Tables("View_4").Columns(7).ColumnName = "الخط "
            ds.Tables("View_4").Columns(8).ColumnName = " كود الشاشه"
            ds.Tables("View_4").Columns(9).ColumnName = " كود الجهاز"
            ds.Tables("View_4").Columns(10).ColumnName = "الخط والوردية"
            ds.Tables("View_4").Columns(11).ColumnName = "اسم المسئول"
            dgs.DataSource = ds.Tables("View_4")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh3151pps() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  Date, Time, fLCDModelName, Barcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL,Heater_Name_Laber FROM View_4"
            sql += "   WHERE Date>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and Date<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_4")
            ds.Tables("View_4").Columns(0).ColumnName = "التاريخ "
            ds.Tables("View_4").Columns(1).ColumnName = "الوقت"
            ds.Tables("View_4").Columns(2).ColumnName = " الموديل"
            ds.Tables("View_4").Columns(3).ColumnName = " الباركود"
            ds.Tables("View_4").Columns(4).ColumnName = "رمز السنه"
            ds.Tables("View_4").Columns(5).ColumnName = "رمز الاسبوع"
            ds.Tables("View_4").Columns(6).ColumnName = "رمز البلد"
            ds.Tables("View_4").Columns(7).ColumnName = "الخط "
            ds.Tables("View_4").Columns(8).ColumnName = " كود الشاشه"
            ds.Tables("View_4").Columns(9).ColumnName = " كود الجهاز"
            ds.Tables("View_4").Columns(10).ColumnName = "الخط والوردية"
            ds.Tables("View_4").Columns(11).ColumnName = "اسم المسئول"
            dgs.DataSource = ds.Tables("View_4")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Function _Refresh45() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  fLCDModelName,COUNT (fLCDModelName)  FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh44() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (fLCDModelName)  FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " الكمية "
            dg3.DataSource = ds.Tables("View_2")
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
            sql += " SELECT  fLCDModelName,COUNT (fLCDModelName)  FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh4104() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (fLCDModelName)  FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_2")
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
            sql += " SELECT  fLCDModelName,COUNT (fLCDModelName)  FROM View_2"
            sql += " WHERE fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh404() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  COUNT (fLCDModelName)  FROM View_2"
            sql += " WHERE fLCDPline='" & ComboBox13.Text & "'"
            sql += " and fNameL='" & ComboBox2.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الكمية"
            dg3.DataSource = ds.Tables("View_2")
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
            sql += "SELECT  Date, Time, fLCDModelName, Barcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL,Heater_Name_Laber FROM View_4"
            sql += "   WHERE Date>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and Date<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_4")
            ds.Tables("View_4").Columns(0).ColumnName = "التاريخ "
            ds.Tables("View_4").Columns(1).ColumnName = "الوقت"
            ds.Tables("View_4").Columns(2).ColumnName = " الموديل"
            ds.Tables("View_4").Columns(3).ColumnName = " الباركود"
            ds.Tables("View_4").Columns(4).ColumnName = "رمز السنه"
            ds.Tables("View_4").Columns(5).ColumnName = "رمز الاسبوع"
            ds.Tables("View_4").Columns(6).ColumnName = "رمز البلد"
            ds.Tables("View_4").Columns(7).ColumnName = "الخط "
            ds.Tables("View_4").Columns(8).ColumnName = " كود الشاشه"
            ds.Tables("View_4").Columns(9).ColumnName = " كود الجهاز"
            ds.Tables("View_4").Columns(10).ColumnName = "الخط والوردية"
            ds.Tables("View_4").Columns(11).ColumnName = "اسم المسئول"
            dgs.DataSource = ds.Tables("View_4")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshm2() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName , count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_2").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_2")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refreshm1() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  count (fLCDSetID)as qty"
            sql += " FROM View_2"
            sql += "   WHERE fPDate>= '" & Format(dtbfrom.Value, "yyyy-MM-dd") & "'"
            sql += "   and fPDate<= '" & Format(dtbto.Value, "yyyy-MM-dd") & "'"
            sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_2")
            ds.Tables("View_2").Columns(0).ColumnName = "الكمية "
            dg3.DataSource = ds.Tables("View_2")
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
            sql += " SELECT  count (Barcode)as qty"
            sql += " FROM View_4"
            sql += " where Barcode='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_4")
            ds.Tables("View_4").Columns(0).ColumnName = "الكميه "
            dg3.DataSource = ds.Tables("View_4")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh315() As Boolean
        Try
            Dim sql As String = ""
            sql += "SELECT  Date, Time, fLCDModelName, Barcode, fLCDPyear, fLCDPweek, fLCDCountry, fLCDPline, fLCDPID, fLCDSN, fNameL,Heater_Name_Laber FROM View_4"
            sql += " where Barcode='" & txtlcdbarcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_4")
            ds.Tables("View_4").Columns(0).ColumnName = "التاريخ "
            ds.Tables("View_4").Columns(1).ColumnName = "الوقت"
            ds.Tables("View_4").Columns(2).ColumnName = " الموديل"
            ds.Tables("View_4").Columns(3).ColumnName = " الباركود"
            ds.Tables("View_4").Columns(4).ColumnName = "رمز السنه"
            ds.Tables("View_4").Columns(5).ColumnName = "رمز الاسبوع"

            ds.Tables("View_4").Columns(6).ColumnName = "رمز البلد"
            ds.Tables("View_4").Columns(7).ColumnName = "الخط "
            ds.Tables("View_4").Columns(8).ColumnName = " كود الشاشه"
            ds.Tables("View_4").Columns(9).ColumnName = " كود الجهاز"
            ds.Tables("View_4").Columns(10).ColumnName = "الخط والوردية"
            ds.Tables("View_4").Columns(11).ColumnName = "اسم المسئول"
            dgs.DataSource = ds.Tables("View_4")
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
            sql += " SELECT fLCDModelName , count (fLCDModelName)as qty"
            sql += " FROM View_4"
         sql += " where Barcode='" & txtlcdbarcode.Text & "'"
            sql += " GROUP BY fLCDModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "View_4")
            ds.Tables("View_4").Columns(0).ColumnName = " الموديل"
            ds.Tables("View_4").Columns(1).ColumnName = " الكمية"
            DG1.DataSource = ds.Tables("View_4")
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
End Class