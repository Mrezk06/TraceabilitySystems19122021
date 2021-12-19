Imports TEVPBarcode.sher
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SqlClient
'Imports System.Data
Imports System.IO.Directory
Public Class frmWashingMachineStepQuery



    Private Sub Heater_Step_Two_Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"
        Try
            Timer1.Enabled = True

            Dim sql As String = ""
            sql += "SELECT Model_Name FROM Heater_ModelName"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "Heater_ModelName")
            btnPCode.DataSource = ds.Tables(0)
            '  cmb_Pcode.ValueMember = "fLCDSetID"
            btnPCode.DisplayMember = "Model_Name"
            btnPCode.Sorted = True
            _Refresh1()
        Catch ex As Exception

        End Try
    End Sub
    Private Function _Refresh001() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count(H_Heater_Code) FROM WashingMachineStepOutput "
            sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            ''sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WashingMachineStepOutput")
            ds.Tables("WashingMachineStepOutput").Columns(0).ColumnName = "الكمية"
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("WashingMachineStepOutput")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh0000() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count(H_Heater_Code) FROM WashingMachineStepOutput "
            sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime>='" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WashingMachineStepOutput")
            ds.Tables("WashingMachineStepOutput").Columns(0).ColumnName = "الكمية"

            dg6.DataSource = ds.Tables("WashingMachineStepOutput")

            Return True

        Catch ex As Exception

        End Try



    End Function
    Private Function _Refresh511() As Boolean
        Try


            Dim sql As String = ""

            sql += " SELECT count(H_Heater_Code) FROM WashingMachineStepOutput "


            sql += " where H_Heater_Code ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WashingMachineStepOutput")
            ds.Tables("WashingMachineStepOutput").Columns(0).ColumnName = " الكمية "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("WashingMachineStepOutput")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(H_Heater_Code) FROM WashingMachineStepOutput "
            sql += " where H_Model_Name ='" & btnPCode.Text & "'"
            sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime>= '" & Format(txtfromTime.ToString, "hh:mm:ss") & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WashingMachineStepOutput")
            ds.Tables("WashingMachineStepOutput").Columns(0).ColumnName = " الكمية "
            'ds.Tables("DailyP").Columns(1).ColumnName = " time "
            'ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
            'ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
            'ds.Tables("DailyP").Columns(4).ColumnName = "line"
            'ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
            'ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
            dg6.DataSource = ds.Tables("WashingMachineStepOutput")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try


            'Dim sql As String = ""
            'sql += " SELECT  H_date, H_time, H_Model_Name, H_Heater_Code, H_component, H_Shift_Line,H_Name_Laber FROM Heater_registration_Three "
            'sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            ''sql += "   and H_time>='" & txttotime.Text & "'"
            ''sql += "   and H_time<= '" & txtfromTime.Text & "'"
            ''sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "Heater_registration_Three")
            'ds.Tables("Heater_registration_Three").Columns(0).ColumnName = " التاريخ "
            'ds.Tables("Heater_registration_Three").Columns(1).ColumnName = " الوقت "
            'ds.Tables("Heater_registration_Three").Columns(2).ColumnName = " الموديل"
            'ds.Tables("Heater_registration_Three").Columns(3).ColumnName = " باركود السخان"
            'ds.Tables("Heater_registration_Three").Columns(4).ColumnName = "الايان كود"
            'ds.Tables("Heater_registration_Three").Columns(5).ColumnName = " الوردية"
            'ds.Tables("Heater_registration_Three").Columns(6).ColumnName = "رقم ساب المسئول"
            'dg.DataSource = ds.Tables("Heater_registration_Three")

            Dim sql As String = ""
            sql += "SELECT  H_date, H_time, Model_Name, H_Heater_Code, H_component, H_Shift_Line, Heater_Name_Laber, H_Name_Laber FROM WMQueryOutPut "
            sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " التاريخ "
            ds.Tables("WMQueryOutPut").Columns(1).ColumnName = " الوقت "
            ds.Tables("WMQueryOutPut").Columns(2).ColumnName = " الموديل"
            ds.Tables("WMQueryOutPut").Columns(3).ColumnName = " باركود الجهاز"
            ds.Tables("WMQueryOutPut").Columns(4).ColumnName = "الايان كود"
            ds.Tables("WMQueryOutPut").Columns(5).ColumnName = " الخط والوردية"
            ds.Tables("WMQueryOutPut").Columns(6).ColumnName = "أسم المسئول"
            ds.Tables("WMQueryOutPut").Columns(7).ColumnName = "رقم ساب المسئول"

            dg.DataSource = ds.Tables("WMQueryOutPut")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh10011() As Boolean
        Try


            'Dim sql As String = ""
            'sql += " SELECT  H_date, H_time, H_Model_Name, H_Heater_Code, H_component, H_Shift_Line,H_Name_Laber FROM Heater_registration_Three "
            'sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            ''sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "Heater_registration_Three")
            'ds.Tables("Heater_registration_Three").Columns(0).ColumnName = " التاريخ "
            'ds.Tables("Heater_registration_Three").Columns(1).ColumnName = " الوقت "
            'ds.Tables("Heater_registration_Three").Columns(2).ColumnName = " الموديل"
            'ds.Tables("Heater_registration_Three").Columns(3).ColumnName = " باركود السخان"
            'ds.Tables("Heater_registration_Three").Columns(4).ColumnName = "الايان كود"
            'ds.Tables("Heater_registration_Three").Columns(5).ColumnName = " الوردية"
            'ds.Tables("Heater_registration_Three").Columns(6).ColumnName = "رقم ساب المسئول"
            'dg.DataSource = ds.Tables("Heater_registration_Three")



            Dim sql As String = ""
            sql += "SELECT  H_date, H_time, Model_Name, H_Heater_Code, H_component, H_Shift_Line, Heater_Name_Laber, H_Name_Laber FROM WMQueryOutPut "
            sql += "   where H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " التاريخ "
            ds.Tables("WMQueryOutPut").Columns(1).ColumnName = " الوقت "
            ds.Tables("WMQueryOutPut").Columns(2).ColumnName = " الموديل"
            ds.Tables("WMQueryOutPut").Columns(3).ColumnName = " باركود الجهاز"
            ds.Tables("WMQueryOutPut").Columns(4).ColumnName = "الايان كود"
            ds.Tables("WMQueryOutPut").Columns(5).ColumnName = " الخط والوردية"
            ds.Tables("WMQueryOutPut").Columns(6).ColumnName = "أسم المسئول"
            ds.Tables("WMQueryOutPut").Columns(7).ColumnName = "رقم ساب المسئول"

            dg.DataSource = ds.Tables("WMQueryOutPut")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh11() As Boolean
        Try


            'Dim sql As String = ""
            'sql += " SELECT  H_date, H_time, H_Model_Name, H_Heater_Code, H_component, H_Shift_Line,H_Name_Laber FROM Heater_registration_Three "
            'sql += " where H_Model_Name ='" & btnPCode.Text & "'"
            'sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            ''sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "Heater_registration_Three")
            'ds.Tables("Heater_registration_Three").Columns(0).ColumnName = " التاريخ "
            'ds.Tables("Heater_registration_Three").Columns(1).ColumnName = " الوقت "
            'ds.Tables("Heater_registration_Three").Columns(2).ColumnName = " الموديل"
            'ds.Tables("Heater_registration_Three").Columns(3).ColumnName = " باركود الجهاز"
            'ds.Tables("Heater_registration_Three").Columns(4).ColumnName = "الايان كود"
            'ds.Tables("Heater_registration_Three").Columns(5).ColumnName = " الوردية"
            'ds.Tables("Heater_registration_Three").Columns(6).ColumnName = "رقم ساب المسئول"
            'dg.DataSource = ds.Tables("Heater_registration_Three")




            Dim sql As String = ""
            sql += "SELECT  H_date, H_time, Model_Name, H_Heater_Code, H_component, H_Shift_Line, Heater_Name_Laber, H_Name_Laber FROM WMQueryOutPut "
            sql += " where Model_Name ='" & btnPCode.Text & "'"
            sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " التاريخ "
            ds.Tables("WMQueryOutPut").Columns(1).ColumnName = " الوقت "
            ds.Tables("WMQueryOutPut").Columns(2).ColumnName = " الموديل"
            ds.Tables("WMQueryOutPut").Columns(3).ColumnName = " باركود الجهاز"
            ds.Tables("WMQueryOutPut").Columns(4).ColumnName = "الايان كود"
            ds.Tables("WMQueryOutPut").Columns(5).ColumnName = " الخط والوردية"
            ds.Tables("WMQueryOutPut").Columns(6).ColumnName = "أسم المسئول"
            ds.Tables("WMQueryOutPut").Columns(7).ColumnName = "رقم ساب المسئول"

            dg.DataSource = ds.Tables("WMQueryOutPut")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh10() As Boolean
        Try


            'Dim sql As String = ""
            'sql += " SELECT  H_date, H_time, H_Model_Name, H_Heater_Code, H_component, H_Shift_Line,H_Line_Name,H_Name_Laber FROM Heater_registration_Three "
            'sql += " where H_Heater_Code ='" & btnPCode.Text & "'"
            ''sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            ''sql += "   and H_time>='" & txttotime.Text & "'"
            ''sql += "   and H_time<= '" & txtfromTime.Text & "'"
            ''sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            'Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "Heater_registration_Three")
            'ds.Tables("Heater_registration_Three").Columns(0).ColumnName = "التاريخ "
            'ds.Tables("Heater_registration_Three").Columns(1).ColumnName = "الوقت "
            'ds.Tables("Heater_registration_Three").Columns(2).ColumnName = " الموديل"
            'ds.Tables("Heater_registration_Three").Columns(3).ColumnName = " باركود الجهاز"
            'ds.Tables("Heater_registration_Three").Columns(4).ColumnName = "الايان كود"
            'ds.Tables("Heater_registration_Three").Columns(5).ColumnName = " الورديه"
            'ds.Tables("Heater_registration_Three").Columns(6).ColumnName = "الخط"
            'ds.Tables("Heater_registration_Three").Columns(7).ColumnName = "رقم ساب المسئول"
            'dg.DataSource = ds.Tables("Heater_registration_Three")

            Dim sql As String = ""
            sql += "SELECT  H_date, H_time, Model_Name, H_Heater_Code, H_component, H_Shift_Line, Heater_Name_Laber, H_Name_Laber FROM WMQueryOutPut "
            sql += " where H_Heater_Code ='" & btnPCode.Text & "'"
            'sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " التاريخ "
            ds.Tables("WMQueryOutPut").Columns(1).ColumnName = " الوقت "
            ds.Tables("WMQueryOutPut").Columns(2).ColumnName = " الموديل"
            ds.Tables("WMQueryOutPut").Columns(3).ColumnName = " باركود الجهاز"
            ds.Tables("WMQueryOutPut").Columns(4).ColumnName = "الايان كود"
            ds.Tables("WMQueryOutPut").Columns(5).ColumnName = " الخط والوردية"
            ds.Tables("WMQueryOutPut").Columns(6).ColumnName = "أسم المسئول"
            ds.Tables("WMQueryOutPut").Columns(7).ColumnName = "رقم ساب المسئول"

            dg.DataSource = ds.Tables("WMQueryOutPut")
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
    'Private Function _Refresh119() As Boolean
    '    Try
    '        Dim sql As String = ""
    '        sql += " SELECT  fPDate, fPtime, fLCDBarcode, fLCDModelName, fLCDPline, fLCDSN, fQty FROM  barcode.dbo.DailyP "
    '        sql += " where fLCDModelName ='" & btnPCode.Text & "'"
    '        sql += " and fLCDPline ='" & cbl.Text & "'"
    '        sql += "   and fPDate= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
    '        sql += "   and fPtime>='" & txttotime.Text & "'"
    '        sql += "   and fPtime<= '" & txtfromTime.Text & "'"
    '        'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
    '        Dim da As New SqlClient.SqlDataAdapter(sql, cn)
    '        Dim ds As New DataSet
    '        da.Fill(ds, "DailyP")
    '        ds.Tables("DailyP").Columns(0).ColumnName = " Date "
    '        ds.Tables("DailyP").Columns(1).ColumnName = " time "
    '        ds.Tables("DailyP").Columns(2).ColumnName = " LCD Barcode"
    '        ds.Tables("DailyP").Columns(3).ColumnName = "LCD Model Name"
    '        ds.Tables("DailyP").Columns(4).ColumnName = "line"
    '        ds.Tables("DailyP").Columns(5).ColumnName = "LCD SN"
    '        ds.Tables("DailyP").Columns(6).ColumnName = "Qty"
    '        dg.DataSource = ds.Tables("DailyP")
    '        Return True
    '    Catch ex As Exception
    '    End Try
    'End Function
    Private Function _Refresh119() As Boolean
        Try


            Dim sql As String = ""
            sql += "SELECT  H_date, H_time, Model_Name, H_Heater_Code, H_component, H_Shift_Line, Heater_Name_Laber, H_Name_Laber FROM WMQueryOutPut "
            sql += " where Model_Name ='" & btnPCode.Text & "'"
            sql += " and H_Line_Name ='" & cbl.Text & "'"
            sql += "   and H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " التاريخ "
            ds.Tables("WMQueryOutPut").Columns(1).ColumnName = " الوقت "
            ds.Tables("WMQueryOutPut").Columns(2).ColumnName = " الموديل"
            ds.Tables("WMQueryOutPut").Columns(3).ColumnName = " باركود الجهاز"
            ds.Tables("WMQueryOutPut").Columns(4).ColumnName = "الايان كود"
            ds.Tables("WMQueryOutPut").Columns(5).ColumnName = " الخط والوردية"
            ds.Tables("WMQueryOutPut").Columns(6).ColumnName = "أسم المسئول"
            ds.Tables("WMQueryOutPut").Columns(7).ColumnName = "رقم ساب المسئول"

            dg.DataSource = ds.Tables("WMQueryOutPut")
            Return True
        Catch ex As Exception
        End Try



    End Function

    Private Function _Refresh1719() As Boolean
        Try


            Dim sql As String = ""
            sql += "SELECT  H_date, H_time, Model_Name, H_Heater_Code, H_component, H_Shift_Line, Heater_Name_Laber, H_Name_Laber FROM WMQueryOutPut "
            ' sql += " where Model_Name ='" & btnPCode.Text & "'"
            sql += " where H_Line_Name ='" & cbl.Text & "'"
            sql += "   and H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " التاريخ "
            ds.Tables("WMQueryOutPut").Columns(1).ColumnName = " الوقت "
            ds.Tables("WMQueryOutPut").Columns(2).ColumnName = " الموديل"
            ds.Tables("WMQueryOutPut").Columns(3).ColumnName = " باركود الجهاز"
            ds.Tables("WMQueryOutPut").Columns(4).ColumnName = "الايان كود"
            ds.Tables("WMQueryOutPut").Columns(5).ColumnName = " الخط والوردية"
            ds.Tables("WMQueryOutPut").Columns(6).ColumnName = "أسم المسئول"
            ds.Tables("WMQueryOutPut").Columns(7).ColumnName = "رقم ساب المسئول"

            dg.DataSource = ds.Tables("WMQueryOutPut")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmReport
            Dim rpt As New rptDate

            rpt.SetDatabaseLogon("sa", "201015")

            rpt.RecordSelectionFormula = "{Heater_registration_Two.H_Shift_Line}='2'"

            '  rpt.RecordSelectionFormula = "  {DESIGNER.fcurrent} ='" & btnPCode.Text & "'"
            'rpt.RecordSelectionFormula += " and  {yearlyp.fPDate}>= # " & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "#"
            'rpt.RecordSelectionFormula += " and {yearlyp.fPDate}<= # " & Format(dtpTODATE.Value, "yyyy-MM-dd") & "#"



            'frm.crv.ReportSource = rpt
            'frm.Show()
            'Me.Hide()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        'Try
        '    Dim sql As String = ""
        '    sql += " SELECT  Model_Name, Model_control FROM  Heater_ModelName "
        '    Dim da As New SqlClient.SqlDataAdapter(sql, cn)
        '    Dim ds As New DataSet
        '    ds.Tables.Clear()
        '    da.Fill(ds, "Heater_ModelName")
        '    btnPCode.DataSource = ds.Tables(0)
        '    '  cmb_Pcode.ValueMember = "fLCDSetID"
        '    btnPCode.DisplayMember = "Heater_ModelName"
        '    btnPCode.Sorted = True
        '    _Refresh1()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
    Private Function _Refresh0119() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(H_Heater_Code) FROM WMQueryOutPut "

            sql += " where Model_Name ='" & btnPCode.Text & "'"
            sql += " and H_Line_Name ='" & cbl.Text & "'"
            sql += "   and H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            '         sql += " and H_Model_Name ='" & btnPCode.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("WMQueryOutPut")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh019919() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(H_Heater_Code) FROM WMQueryOutPut "

            '   sql += " where Model_Name ='" & btnPCode.Text & "'"
            sql += " where H_Line_Name ='" & cbl.Text & "'"
            sql += "   and H_date>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_date<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and H_time>='" & txttotime.Text & "'"
            sql += "   and H_time<= '" & txtfromTime.Text & "'"
            '         sql += " and H_Model_Name ='" & btnPCode.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("WMQueryOutPut")
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
        If txttotime.Text = "" And txtfromTime.Text = "" Then
            _Refresh001()
            _Refresh111()
        Else
            _Refresh0000()
            _Refresh10011()
        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If btnPCode.Text = "" Then
            _Refresh1719()
            _Refresh019919()
        Else
            _Refresh0119()
            _Refresh119()
        End If


        ' _Refresh111()
    End Sub

    'Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
    '    _Refresh1()
    '    _Refresh511()
    'End Sub

    Private Sub btnsearchModel_Click_1(sender As Object, e As EventArgs)
        _Refresh11()
        _Refresh011()

    End Sub

    Private Sub dg9_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg9.CellContentClick
        btnPCode.Text = dg9.Item(0, dg9.CurrentRow.Index).Value
    End Sub
    Private Function _Refresh155() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT H_Shift_Line,Model_Name, count(Model_Name) AS tot"
            sql += " FROM WMQueryData"
            sql += " WHERE H_date >= Convert(nvarchar(10), GETDATE(), 121)"
            sql += " GROUP BY Model_Name,H_Shift_Line "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryData")
            ds.Tables("WMQueryData").Columns(0).ColumnName = " الخط"
            ds.Tables("WMQueryData").Columns(1).ColumnName = "الموديل"
            ds.Tables("WMQueryData").Columns(2).ColumnName = " الكميه"
            dg9.DataSource = ds.Tables("WMQueryData")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbl.SelectedIndexChanged

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs) Handles cbl.Leave

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh155()
    End Sub

    Private Sub dg6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg6.CellContentClick

    End Sub

    Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
        _Refresh1()


    End Sub
    Private Function _Refresh1() As Boolean
        Try


            Dim sql As String = ""
            sql += "SELECT  H_date, H_time, Model_Name, H_Heater_Code, H_component, H_Shift_Line, Heater_Name_Laber, H_Name_Laber FROM WMQueryOutPut "
            sql += " where H_Heater_Code ='" & txtFATSERIAL.Text & "'"
            'sql += "   and H_date= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            'sql += "   and H_time>='" & txttotime.Text & "'"
            'sql += "   and H_time<= '" & txtfromTime.Text & "'"
            'sql += "   and fPtime<= '" & Format(txttotime.ToString, "hh:mm:ss") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "WMQueryOutPut")
            ds.Tables("WMQueryOutPut").Columns(0).ColumnName = " التاريخ "
            ds.Tables("WMQueryOutPut").Columns(1).ColumnName = " الوقت "
            ds.Tables("WMQueryOutPut").Columns(2).ColumnName = " الموديل"
            ds.Tables("WMQueryOutPut").Columns(3).ColumnName = " باركود الجهاز"
            ds.Tables("WMQueryOutPut").Columns(4).ColumnName = "الايان كود"
            ds.Tables("WMQueryOutPut").Columns(5).ColumnName = " الخط والوردية"
            ds.Tables("WMQueryOutPut").Columns(6).ColumnName = "أسم المسئول"
            ds.Tables("WMQueryOutPut").Columns(7).ColumnName = "رقم ساب المسئول"

            dg.DataSource = ds.Tables("WMQueryOutPut")
            Return True
        Catch ex As Exception
        End Try



    End Function

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub dtpFROMDATE_ValueChanged(sender As Object, e As EventArgs) Handles dtpFROMDATE.ValueChanged

    End Sub

    Private Sub txtFATSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub

    Private Sub btnReport_Click_1(sender As Object, e As EventArgs) Handles btnReport.Click
        Try
            Dim frm As New frmReport
            Dim rpt As New rptDate

            rpt.SetDatabaseLogon("sa", "a-123456")

            ' rpt.RecordSelectionFormula = "{DailyP.fLCDPline}='2'"

            '  rpt.RecordSelectionFormula = "  {DESIGNER.fcurrent} ='" & btnPCode.Text & "'"
            'rpt.RecordSelectionFormula += " and  {yearlyp.fPDate}>= # " & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "#"
            'rpt.RecordSelectionFormula += " and {yearlyp.fPDate}<= # " & Format(dtpTODATE.Value, "yyyy-MM-dd") & "#"



            'frm.crv.ReportSource = rpt
            'frm.Show()
            'Me.Hide()

        Catch ex As Exception

        End Try
    End Sub


    Private Sub dg_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnPCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles btnPCode.SelectedIndexChanged

    End Sub
End Class