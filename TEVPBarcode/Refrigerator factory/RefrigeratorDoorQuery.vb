
Imports System.Data.SqlClient
Imports TEVPBarcode.sher
Public Class RefrigeratorDoorQuery

    Private Function _Refresh001() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(R_Barcode) FROM  Refrigerator_DoorFollowView "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
        Private Function _Refresh511() As Boolean
            Try
            Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM Refrigerator_DoorFollowView "
            sql += " where R_Barcode ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg6.AllowUserToAddRows = False
            Return True
            Catch ex As Exception
            End Try
        End Function
        Private Function _Refresh011() As Boolean
            Try
                Dim sql As String = ""
            sql += " SELECT count(R_Barcode) FROM Refrigerator_DoorFollowView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += " and R_Date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and R_Time>='" & txttotime.Text & "'"
            sql += " and R_Time <= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg6.AllowUserToAddRows = False
            Return True
            Catch ex As Exception
            End Try
        End Function
        Private Function _Refresh111() As Boolean
            Try


                Dim sql As String = ""
            sql += " SELECT R_Date, R_Time, R_Barcode, R_ModelName, R_ProductionType, R_ColorName, R_ModelControl, R_Door1, R_Door2,R_FactoryCode,  R_Staker,R_SapUser, R_Line FROM  Refrigerator_DoorFollowView "
            sql += "   where R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            'sql += "   and fPtime>='" & txttotime.Text & "'"
            'sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            ''sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_DoorFollowView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_DoorFollowView").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_DoorFollowView").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_DoorFollowView").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_DoorFollowView").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_DoorFollowView").Columns(6).ColumnName = "كود الموديل"

            ds.Tables("Refrigerator_DoorFollowView").Columns(7).ColumnName = "الباب الصغير "
            ds.Tables("Refrigerator_DoorFollowView").Columns(8).ColumnName = "الباب الكبير"
            ds.Tables("Refrigerator_DoorFollowView").Columns(9).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_DoorFollowView").Columns(10).ColumnName = "استيكر الطاقة"
            ds.Tables("Refrigerator_DoorFollowView").Columns(11).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_DoorFollowView").Columns(12).ColumnName = "الوردية"

            dg.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg.AllowUserToAddRows = False
            Return True
            Catch ex As Exception
            End Try



        End Function
        Private Function _Refresh11() As Boolean
            Try


                Dim sql As String = ""

            sql += " SELECT R_Date, R_Time, R_Barcode, R_ModelName, R_ProductionType, R_ColorName, R_ModelControl, R_Door1, R_Door2,R_FactoryCode,  R_Staker,R_SapUser, R_Line FROM Refrigerator_DoorFollowView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_DoorFollowView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_DoorFollowView").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_DoorFollowView").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_DoorFollowView").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_DoorFollowView").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_DoorFollowView").Columns(6).ColumnName = "كود الموديل"

            ds.Tables("Refrigerator_DoorFollowView").Columns(7).ColumnName = "الباب الصغير "
            ds.Tables("Refrigerator_DoorFollowView").Columns(8).ColumnName = "الباب الكبير"
            ds.Tables("Refrigerator_DoorFollowView").Columns(9).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_DoorFollowView").Columns(10).ColumnName = "استيكر الطاقة"
            ds.Tables("Refrigerator_DoorFollowView").Columns(11).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_DoorFollowView").Columns(12).ColumnName = "الوردية"

            dg.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg.AllowUserToAddRows = False
            Return True
            Catch ex As Exception
            End Try
        End Function
        Private Function _Refresh1() As Boolean
            Try
            '    Dim sql As String = ""
            '    sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty,fShift FROM  barcode.dbo.DailyP "
            '    sql += " where fLCDBarcode ='" & txtFATSERIAL.Text & "'"
            '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            '    Dim ds As New DataSet
            '    da.Fill(ds, "DailyP")
            '    ds.Tables("DailyP").Columns(0).ColumnName = " Date "
            '    ds.Tables("DailyP").Columns(1).ColumnName = " time "
            '    ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            '    ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            '    ds.Tables("DailyP").Columns(4).ColumnName = "line Barcode"
            '    ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            '    ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            '    ds.Tables("DailyP").Columns(7).ColumnName = "Line"
            'dg.DataSource = ds.Tables("DailyP")



            Dim sql As String = ""

            sql += " SELECT R_Date, R_Time, R_Barcode, R_ModelName, R_ProductionType, R_ColorName, R_ModelControl, R_Door1, R_Door2,R_FactoryCode,  R_Staker,R_SapUser, R_Line FROM Refrigerator_DoorFollowView "
            sql += " where R_Barcode ='" & txtFATSERIAL.Text & "'"

            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_DoorFollowView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_DoorFollowView").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_DoorFollowView").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_DoorFollowView").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_DoorFollowView").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_DoorFollowView").Columns(6).ColumnName = "كود الموديل"
            ds.Tables("Refrigerator_DoorFollowView").Columns(7).ColumnName = "الباب الصغير "
            ds.Tables("Refrigerator_DoorFollowView").Columns(8).ColumnName = "الباب الكبير"
            ds.Tables("Refrigerator_DoorFollowView").Columns(9).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_DoorFollowView").Columns(10).ColumnName = "استيكر الطاقة"
            ds.Tables("Refrigerator_DoorFollowView").Columns(11).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_DoorFollowView").Columns(12).ColumnName = "الوردية"
            dg.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg.AllowUserToAddRows = False
            Return True
            Catch ex As Exception
            End Try
        End Function
        Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub btnsearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            _Refresh1()
            _Refresh511()

        End Sub

        Private Sub btnSEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            _Refresh111()
            _Refresh001()

        End Sub

        Private Sub btnsearchModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            _Refresh11()
            _Refresh011()
        End Sub
        Private Function _Refresh119() As Boolean
            Try
            '    Dim sql As String = ""
            '    sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM  barcode.dbo.DailyP "
            '    sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            '    sql += " and fLineandsh ='" & cbl.Text & "'"
            '    sql += "   and fPDate>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            '    sql += "   and fPDate<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            '    sql += "   and fPtime>='" & txttotime.Text & "'"
            '    sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            '    'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            '    Dim ds As New DataSet
            '    da.Fill(ds, "DailyP")
            '    ds.Tables("DailyP").Columns(0).ColumnName = " Date "
            '    ds.Tables("DailyP").Columns(1).ColumnName = " time "
            '    ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            '    ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            '    ds.Tables("DailyP").Columns(4).ColumnName = "line"
            '    ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            '    ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            'dg.DataSource = ds.Tables("DailyP")



            Dim sql As String = ""

            sql += " SELECT R_Date, R_Time, R_Barcode, R_ModelName, R_ProductionType, R_ColorName, R_ModelControl, R_Door1, R_Door2,R_FactoryCode,  R_Staker,R_SapUser, R_Line FROM  Refrigerator_DoorFollowView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            '            sql += " where fLCDModelName ='" & btnPCode.Text & "'"
            sql += " and R_Line ='" & cbl.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "التاريخ "
            ds.Tables("Refrigerator_DoorFollowView").Columns(1).ColumnName = "الوقت "
            ds.Tables("Refrigerator_DoorFollowView").Columns(2).ColumnName = "الباركود"
            ds.Tables("Refrigerator_DoorFollowView").Columns(3).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_DoorFollowView").Columns(4).ColumnName = "نوع الانتاج"
            ds.Tables("Refrigerator_DoorFollowView").Columns(5).ColumnName = "اللون"
            ds.Tables("Refrigerator_DoorFollowView").Columns(6).ColumnName = "كود الموديل"

            ds.Tables("Refrigerator_DoorFollowView").Columns(7).ColumnName = "الباب الصغير "
            ds.Tables("Refrigerator_DoorFollowView").Columns(8).ColumnName = "الباب الكبير"
            ds.Tables("Refrigerator_DoorFollowView").Columns(9).ColumnName = "كود المصنع"
            ds.Tables("Refrigerator_DoorFollowView").Columns(10).ColumnName = "استيكر الطاقة"
            ds.Tables("Refrigerator_DoorFollowView").Columns(11).ColumnName = "ساب المسئول"
            ds.Tables("Refrigerator_DoorFollowView").Columns(12).ColumnName = "الوردية"
            dg.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
            End Try
        End Function
        Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                Dim frm As New frmReport
                Dim rpt As New rptDate

                rpt.SetDatabaseLogon("sa", "201015")

                rpt.RecordSelectionFormula = "{DailyP.fLCDPline}='2'"

            '  rpt.RecordSelectionFormula = "  {DESIGNER.fcurrent} ='" & btnPCode.Text & "'"
            'rpt.RecordSelectionFormula += " and  {yearlyp.fPDate}>= # " & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "#"
            'rpt.RecordSelectionFormula += " and {yearlyp.fPDate}<= # " & Format(dtpTODATE.Value, "yyyy-MM-dd") & "#"



            'frm.crv.ReportSource = rpt
            'frm.Show()
            ''Me.Hide()

        Catch ex As Exception

            End Try
        End Sub
        ' Timer1.Enabled = True
        Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Timer1.Enabled = True
            Try
                Dim sql As String = ""
            sql += " SELECT  R_ModelControl, R_ModelName FROM   Refrigerator_Models "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
                ds.Tables.Clear()
            da.Fill(ds, "Refrigerator_Models")
            btnPCode.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            btnPCode.DisplayMember = "R_ModelName"
            btnPCode.Sorted = True
                _Refresh1()
            Catch ex As Exception

            End Try
        End Sub

        Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        End Sub
        Private Function _Refresh0119() As Boolean
            Try
                Dim sql As String = ""
            sql += " SELECT count( R_Barcode) FROM Refrigerator_DoorFollowView "
            sql += " where R_ModelName ='" & btnPCode.Text & "'"
            sql += "   and R_Date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Date<= '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'"
            sql += "   and R_Time>='" & txttotime.Text & "'"
            sql += "   and R_Time<= '" & txtfromTime.Text & "'"
            sql += " and R_Line ='" & cbl.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "الكمية"
            dg6.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg6.AllowUserToAddRows = False
            Return True
            Catch ex As Exception
            End Try
        End Function
        Private Sub Button1_Click(sender As Object, e As EventArgs)
            _Refresh0119()
            _Refresh119()
        End Sub

        Private Sub cbl_SelectedIndexChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        End Sub

        Private Sub btnSEARCH_Click_1(sender As Object, e As EventArgs) Handles btnSEARCH.Click
            _Refresh001()
            _Refresh111()
        End Sub

        Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
            _Refresh0119()
            _Refresh119()
            ' _Refresh111()
        End Sub

        Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
            _Refresh1()
            _Refresh511()
        End Sub


        Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
            btnPCode.Text = dg9.Item(0, dg9.CurrentRow.Index).Value
        End Sub
        Private Function _Refresh155() As Boolean
            Try
                Dim sql As String = ""
            sql += " SELECT R_ModelName, count(R_ModelName) AS tot"
            sql += " FROM Refrigerator_DoorFollowView"
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " and R_Line ='" & cbl.Text & "'"
            sql += " GROUP BY R_ModelName "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_DoorFollowView").Columns(1).ColumnName = "الكمية"
            dg9.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg9.AllowUserToAddRows = False
            Return True
            Catch ex As Exception
            End Try
        End Function

        Private Sub cbl_MouseLeave(sender As Object, e As EventArgs) Handles cbl.MouseLeave

        End Sub

        Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

        End Sub

        Private Sub cbl_Leave(sender As Object, e As EventArgs) Handles cbl.Leave
            _Refresh155()
        End Sub
        Private Function _Refresh199() As Boolean
            Try
                Dim sql As String = ""
            sql += "SELECT R_ModelName, count(R_ModelName) AS tot,R_Line "
            sql += " FROM Refrigerator_DoorFollowView"
            sql += " WHERE R_Date >= Convert(nvarchar(10), GETDATE(), 121)"
            '  sql += " and fLCDModelName='" & cmb_Pcode.Text & "'"
            'sql += " and fLCDPline ='" & cbl.Text & "'"
            ' sql += " and fShift =" & txtshift.Text & ""
            sql += " GROUP BY R_ModelName,R_Line "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
                Dim ds As New DataSet
            da.Fill(ds, "Refrigerator_DoorFollowView")
            ds.Tables("Refrigerator_DoorFollowView").Columns(0).ColumnName = "اسم الموديل"
            ds.Tables("Refrigerator_DoorFollowView").Columns(1).ColumnName = "الكمية"
            ds.Tables("Refrigerator_DoorFollowView").Columns(2).ColumnName = "الوردية"
            dg9.DataSource = ds.Tables("Refrigerator_DoorFollowView")
            dg9.AllowUserToAddRows = False
            Return True
            Catch ex As Exception
            End Try
        End Function


        Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
            _Refresh199()
        End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class


