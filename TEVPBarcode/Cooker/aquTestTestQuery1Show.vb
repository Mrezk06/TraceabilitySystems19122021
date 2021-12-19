Imports TEVPBarcode.sher
Public Class aquTestTestQuery1Show

    ' Public Class aquTestTestQueryShow
    Private Function _Refresh110() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(*)"
            sql += "FROM barcode.dbo.C_Atc_3"
            sql += "   where DT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and DT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Atc_3")
            ds.Tables("C_Atc_3").Columns(0).ColumnName = "QTY"

            dgff.DataSource = ds.Tables("C_Atc_3")
            Return True
        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh1101() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(*)"
            sql += "FROM barcode.dbo.C_Atc_3"
            sql += "   where DT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and DT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and P102 = '" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Atc_3")
            ds.Tables("C_Atc_3").Columns(0).ColumnName = "QTY"

            dgff.DataSource = ds.Tables("C_Atc_3")
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20, P21, P22, P23, P24, P25, P26, P27, P28, P29, P30, P31, P32, P33, P34, P35, P36, P37, P38, P39, P40, "
            sql += " P74,P102, DT"

            sql += " FROM barcode.dbo.C_Atc_3"
            sql += " where DT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and DT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Atc_3")
            ds.Tables("C_Atc_3").Columns(0).ColumnName = "P1"
            ds.Tables("C_Atc_3").Columns(1).ColumnName = "P2"
            ds.Tables("C_Atc_3").Columns(2).ColumnName = "P3"
            ds.Tables("C_Atc_3").Columns(3).ColumnName = "P4"
            ds.Tables("C_Atc_3").Columns(4).ColumnName = "P5"
            ds.Tables("C_Atc_3").Columns(5).ColumnName = "P6"
            ds.Tables("C_Atc_3").Columns(6).ColumnName = "P7"
            ds.Tables("C_Atc_3").Columns(7).ColumnName = "P8"
            ds.Tables("C_Atc_3").Columns(8).ColumnName = "P9"
            ds.Tables("C_Atc_3").Columns(9).ColumnName = "P10"
            ds.Tables("C_Atc_3").Columns(10).ColumnName = "P11"
            ds.Tables("C_Atc_3").Columns(11).ColumnName = "P12"
            ds.Tables("C_Atc_3").Columns(12).ColumnName = "P13"
            ds.Tables("C_Atc_3").Columns(13).ColumnName = "P14"
            ds.Tables("C_Atc_3").Columns(14).ColumnName = "P15"
            ds.Tables("C_Atc_3").Columns(15).ColumnName = "P16"
            ds.Tables("C_Atc_3").Columns(16).ColumnName = "P17"
            ds.Tables("C_Atc_3").Columns(17).ColumnName = "P18"
            ds.Tables("C_Atc_3").Columns(18).ColumnName = "P19"
            ds.Tables("C_Atc_3").Columns(19).ColumnName = "P20"
            ds.Tables("C_Atc_3").Columns(20).ColumnName = "P21"
            ds.Tables("C_Atc_3").Columns(21).ColumnName = "P22"
            ds.Tables("C_Atc_3").Columns(22).ColumnName = "P23"
            ds.Tables("C_Atc_3").Columns(23).ColumnName = "P24"
            ds.Tables("C_Atc_3").Columns(24).ColumnName = "P25"
            ds.Tables("C_Atc_3").Columns(25).ColumnName = "P26"
            ds.Tables("C_Atc_3").Columns(26).ColumnName = "P27"
            ds.Tables("C_Atc_3").Columns(27).ColumnName = "P28"
            ds.Tables("C_Atc_3").Columns(28).ColumnName = "P29"
            ds.Tables("C_Atc_3").Columns(29).ColumnName = "P30"
            ds.Tables("C_Atc_3").Columns(30).ColumnName = "P31"
            ds.Tables("C_Atc_3").Columns(31).ColumnName = "P32"
            ds.Tables("C_Atc_3").Columns(32).ColumnName = "P33"
            ds.Tables("C_Atc_3").Columns(33).ColumnName = "P34"
            ds.Tables("C_Atc_3").Columns(34).ColumnName = "P35"
            ds.Tables("C_Atc_3").Columns(35).ColumnName = "P36"
            ds.Tables("C_Atc_3").Columns(36).ColumnName = "P37"
            ds.Tables("C_Atc_3").Columns(37).ColumnName = "P38"
            ds.Tables("C_Atc_3").Columns(38).ColumnName = "P39"
            ds.Tables("C_Atc_3").Columns(39).ColumnName = "P40"
            ds.Tables("C_Atc_3").Columns(40).ColumnName = "P41"
            ds.Tables("C_Atc_3").Columns(41).ColumnName = "P42"
            ds.Tables("C_Atc_3").Columns(42).ColumnName = "date"
            dg.DataSource = ds.Tables("C_Atc_3")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh131() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20, P21, P22, P23, P24, P25, P26, P27, P28, P29, P30, P31, P32, P33, P34, P35, P36, P37, P38, P39, P40, "
            sql += " P74,P102, DT"

            sql += " FROM barcode.dbo.C_Atc_3"
            sql += " where DT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and DT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and P102 = '" & cmb_Pcode.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "C_Atc_3")
            ds.Tables("C_Atc_3").Columns(0).ColumnName = "P1"
            ds.Tables("C_Atc_3").Columns(1).ColumnName = "P2"
            ds.Tables("C_Atc_3").Columns(2).ColumnName = "P3"
            ds.Tables("C_Atc_3").Columns(3).ColumnName = "P4"
            ds.Tables("C_Atc_3").Columns(4).ColumnName = "P5"
            ds.Tables("C_Atc_3").Columns(5).ColumnName = "P6"
            ds.Tables("C_Atc_3").Columns(6).ColumnName = "P7"
            ds.Tables("C_Atc_3").Columns(7).ColumnName = "P8"
            ds.Tables("C_Atc_3").Columns(8).ColumnName = "P9"
            ds.Tables("C_Atc_3").Columns(9).ColumnName = "P10"
            ds.Tables("C_Atc_3").Columns(10).ColumnName = "P11"
            ds.Tables("C_Atc_3").Columns(11).ColumnName = "P12"
            ds.Tables("C_Atc_3").Columns(12).ColumnName = "P13"
            ds.Tables("C_Atc_3").Columns(13).ColumnName = "P14"
            ds.Tables("C_Atc_3").Columns(14).ColumnName = "P15"
            ds.Tables("C_Atc_3").Columns(15).ColumnName = "P16"
            ds.Tables("C_Atc_3").Columns(16).ColumnName = "P17"
            ds.Tables("C_Atc_3").Columns(17).ColumnName = "P18"
            ds.Tables("C_Atc_3").Columns(18).ColumnName = "P19"
            ds.Tables("C_Atc_3").Columns(19).ColumnName = "P20"
            ds.Tables("C_Atc_3").Columns(20).ColumnName = "P21"
            ds.Tables("C_Atc_3").Columns(21).ColumnName = "P22"
            ds.Tables("C_Atc_3").Columns(22).ColumnName = "P23"
            ds.Tables("C_Atc_3").Columns(23).ColumnName = "P24"
            ds.Tables("C_Atc_3").Columns(24).ColumnName = "P25"
            ds.Tables("C_Atc_3").Columns(25).ColumnName = "P26"
            ds.Tables("C_Atc_3").Columns(26).ColumnName = "P27"
            ds.Tables("C_Atc_3").Columns(27).ColumnName = "P28"
            ds.Tables("C_Atc_3").Columns(28).ColumnName = "P29"
            ds.Tables("C_Atc_3").Columns(29).ColumnName = "P30"
            ds.Tables("C_Atc_3").Columns(30).ColumnName = "P31"
            ds.Tables("C_Atc_3").Columns(31).ColumnName = "P32"
            ds.Tables("C_Atc_3").Columns(32).ColumnName = "P33"
            ds.Tables("C_Atc_3").Columns(33).ColumnName = "P34"
            ds.Tables("C_Atc_3").Columns(34).ColumnName = "P35"
            ds.Tables("C_Atc_3").Columns(35).ColumnName = "P36"
            ds.Tables("C_Atc_3").Columns(36).ColumnName = "P37"
            ds.Tables("C_Atc_3").Columns(37).ColumnName = "P38"
            ds.Tables("C_Atc_3").Columns(38).ColumnName = "P39"
            ds.Tables("C_Atc_3").Columns(39).ColumnName = "P40"
            ds.Tables("C_Atc_3").Columns(40).ColumnName = "P41"
            ds.Tables("C_Atc_3").Columns(41).ColumnName = "P42"
            ds.Tables("C_Atc_3").Columns(42).ColumnName = "date"
            dg.DataSource = ds.Tables("C_Atc_3")
            ' dg.DataSource = ds.Tables("C_Atc_1")
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Sub aquTestTestQueryShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _Refresh11()

        _Refresh110()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New aquTestTestQuery1
        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        _Refresh131()
        _Refresh1101()
    End Sub
End Class