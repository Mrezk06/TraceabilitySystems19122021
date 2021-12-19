Imports TEVPBarcode.sher
Imports System.Data.SqlClient.SqlException
Public Class frmQueryRunRate
    Private Function _Refresh111() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeFrom,fTimeTo,fNote,fTimeStop FROM TRunRat"
            sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fLine ='" & txtlinandshift.Text & "'"
            sql1 += "   and fModel ='" & txtModel.Text & "'"
            '  sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TRunRat")
            ds.Tables("TRunRat").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TRunRat").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TRunRat").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TRunRat").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TRunRat").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TRunRat").Columns(5).ColumnName = " الموديل"
            ds.Tables("TRunRat").Columns(6).ColumnName = "الوقت من "
            ds.Tables("TRunRat").Columns(7).ColumnName = "الوقت الى "
            ds.Tables("TRunRat").Columns(8).ColumnName = " الملاحظات"
            ds.Tables("TRunRat").Columns(9).ColumnName = " الكمية المنتجه"
            dg.DataSource = ds.Tables("TRunRat")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh1112() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeFrom,fTimeTo,fNote,fTimeStop FROM TRunRat"
            sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fLine ='" & txtlinandshift.Text & "'"
            ' sql1 += "   and fModel ='" & txtModel.Text & "'"
            '  sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TRunRat")
            ds.Tables("TRunRat").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TRunRat").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TRunRat").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TRunRat").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TRunRat").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TRunRat").Columns(5).ColumnName = " الموديل"
            ds.Tables("TRunRat").Columns(6).ColumnName = "الوقت من "
            ds.Tables("TRunRat").Columns(7).ColumnName = "الوقت الى "
            ds.Tables("TRunRat").Columns(8).ColumnName = " الملاحظات"
            ds.Tables("TRunRat").Columns(9).ColumnName = " الكمية المنتجه"

            dg.DataSource = ds.Tables("TRunRat")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh1113() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeFrom,fTimeTo,fNote,fTimeStop FROM TRunRat"
            sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            'sql1 += "   and fLine ='" & txtlinandshift.Text & "'"
            sql1 += "   and fModel ='" & txtModel.Text & "'"
            '  sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TRunRat")
            ds.Tables("TRunRat").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TRunRat").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TRunRat").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TRunRat").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TRunRat").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TRunRat").Columns(5).ColumnName = " الموديل"
            ds.Tables("TRunRat").Columns(6).ColumnName = "الوقت من "
            ds.Tables("TRunRat").Columns(7).ColumnName = "الوقت الى "
            ds.Tables("TRunRat").Columns(8).ColumnName = " الملاحظات"
            ds.Tables("TRunRat").Columns(9).ColumnName = " الكمية المنتجه"

            dg.DataSource = ds.Tables("TRunRat")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh1114() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeFrom,fTimeTo,fNote,fTimeStop FROM TRunRat"
            sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            'sql1 += "   and fLine ='" & txtlinandshift.Text & "'"
            'sql1 += "   and fModel ='" & txtModel.Text & "'"
            '  sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TRunRat")
            ds.Tables("TRunRat").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TRunRat").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TRunRat").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TRunRat").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TRunRat").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TRunRat").Columns(5).ColumnName = " الموديل"
            ds.Tables("TRunRat").Columns(6).ColumnName = "الوقت من "
            ds.Tables("TRunRat").Columns(7).ColumnName = "الوقت الى "
            ds.Tables("TRunRat").Columns(8).ColumnName = " الملاحظات"
            ds.Tables("TRunRat").Columns(9).ColumnName = " الكمية المنتجه"

            dg.DataSource = ds.Tables("TRunRat")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh1117() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeFrom,fTimeTo,fNote,fTimeStop FROM TRunRat"
            'sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            'sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += "   where fLine ='" & txtlinandshift.Text & "'"
            sql1 += "   and fModel ='" & txtModel.Text & "'"
            '  sql1 += " and fPDate >= Convert(nvarchar(10), GETDATE(), 121)"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TRunRat")
            ds.Tables("TRunRat").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TRunRat").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TRunRat").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TRunRat").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TRunRat").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TRunRat").Columns(5).ColumnName = " الموديل"
            ds.Tables("TRunRat").Columns(6).ColumnName = "الوقت من "
            ds.Tables("TRunRat").Columns(7).ColumnName = "الوقت الى "
            ds.Tables("TRunRat").Columns(8).ColumnName = " الملاحظات"
            ds.Tables("TRunRat").Columns(9).ColumnName = " الكمية المنتجه"

            dg.DataSource = ds.Tables("TRunRat")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Sub frmQueryRunRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
        Try
            Dim sql As String = ""
            sql += " SELECT fLCDModelName FROM   LCDTVModels "

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            ds.Tables.Clear()
            da.Fill(ds, "LCDTVModels")

            txtModel.DataSource = ds.Tables(0)
            ' txtModel.ValueMember = "fLCDSetID"
            txtModel.DisplayMember = "fLCDModelName"
            txtModel.Sorted = True

            ' _Refresh1()
        Catch ex As Exception

        End Try
        txtModel.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtlinandshift.Text = "" And txtModel.Text = "" Then
            _Refresh11()
        ElseIf txtlinandshift.Text = "" Then
            _Refresh112()
        ElseIf txtModel.Text = "" Then
            _Refresh113()
        Else
            _Refresh114()
        End If
    End Sub
    Private Function _Refresh11() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeUSER,fNote,fTimeStop FROM TStopline"
            sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TStopline")
            ds.Tables("TStopline").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TStopline").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TStopline").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TStopline").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TStopline").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TStopline").Columns(5).ColumnName = " الموديل"
            ds.Tables("TStopline").Columns(6).ColumnName = " وقت التوقف"
            ds.Tables("TStopline").Columns(7).ColumnName = " سبب التوقف"
            ds.Tables("TStopline").Columns(8).ColumnName = " مدة التوقف/ د"
            dgd.DataSource = ds.Tables("TStopline")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh112() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeUSER,fNote,fTimeStop FROM TStopline"
            sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += " and fModel ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TStopline")
            ds.Tables("TStopline").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TStopline").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TStopline").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TStopline").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TStopline").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TStopline").Columns(5).ColumnName = " الموديل"
            ds.Tables("TStopline").Columns(6).ColumnName = " وقت التوقف"
            ds.Tables("TStopline").Columns(7).ColumnName = " سبب التوقف"
            ds.Tables("TStopline").Columns(8).ColumnName = " مدة التوقف/ د"
            dgd.DataSource = ds.Tables("TStopline")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh113() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeUSER,fNote,fTimeStop FROM TStopline"
            sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += " and fLine ='" & txtlinandshift.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TStopline")
            ds.Tables("TStopline").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TStopline").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TStopline").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TStopline").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TStopline").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TStopline").Columns(5).ColumnName = " الموديل"
            ds.Tables("TStopline").Columns(6).ColumnName = " وقت التوقف"
            ds.Tables("TStopline").Columns(7).ColumnName = " سبب التوقف"
            ds.Tables("TStopline").Columns(8).ColumnName = " مدة التوقف/ د"
            dgd.DataSource = ds.Tables("TStopline")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh114() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeUSER,fNote,fTimeStop FROM TStopline"
            sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += " and fLine ='" & txtlinandshift.Text & "'"
            sql1 += " and fModel ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TStopline")
            ds.Tables("TStopline").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TStopline").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TStopline").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TStopline").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TStopline").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TStopline").Columns(5).ColumnName = " الموديل"
            ds.Tables("TStopline").Columns(6).ColumnName = " وقت التوقف"
            ds.Tables("TStopline").Columns(7).ColumnName = " سبب التوقف"
            ds.Tables("TStopline").Columns(8).ColumnName = " مدة التوقف/ د"
            dgd.DataSource = ds.Tables("TStopline")

            Return True

        Catch ex As Exception

        End Try
    End Function
    Private Function _Refresh115() As Boolean
        Try

            Dim sql1 As String = "SELECT fPDate,fPtime,fSap,fSv,fLine,fModel,fTimeUSER,fNote,fTimeStop FROM TStopline"
            'sql1 += "   where fPDate>= '" & Format(ftimefrom.Value, "yyyy-MM-dd") & "'"
            'sql1 += "   and fPDate<= '" & Format(ftimeto.Value, "yyyy-MM-dd") & "'"
            sql1 += " where fLine ='" & txtlinandshift.Text & "'"
            sql1 += " and fModel ='" & txtModel.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql1, cn)
            Dim ds As New DataSet
            da.Fill(ds, "TStopline")
            ds.Tables("TStopline").Columns(0).ColumnName = " تاريخ التسجيل"
            ds.Tables("TStopline").Columns(1).ColumnName = " وقت التسجيل"
            ds.Tables("TStopline").Columns(2).ColumnName = "ساب الفنى"
            ds.Tables("TStopline").Columns(3).ColumnName = "اسم المشرف"
            ds.Tables("TStopline").Columns(4).ColumnName = " الخط والوردية"
            ds.Tables("TStopline").Columns(5).ColumnName = " الموديل"
            ds.Tables("TStopline").Columns(6).ColumnName = " وقت التوقف"
            ds.Tables("TStopline").Columns(7).ColumnName = " سبب التوقف"
            ds.Tables("TStopline").Columns(8).ColumnName = " مدة التوقف/ د"
            dgd.DataSource = ds.Tables("TStopline")

            Return True

        Catch ex As Exception

        End Try
    End Function

    Private Sub Button1_DoubleClick(sender As Object, e As EventArgs) Handles Button1.DoubleClick
        _Refresh115()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtlinandshift.Text = "" And txtModel.Text = "" Then
            _Refresh1114()
        ElseIf txtlinandshift.Text = "" Then
            _Refresh1113()
        ElseIf txtModel.Text = "" Then
            _Refresh1112()
        Else
            _Refresh111()
        End If
    End Sub

    Private Sub Button2_DoubleClick(sender As Object, e As EventArgs) Handles Button2.DoubleClick
        _Refresh1117()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        txtModel.Text = dg.Item(5, dg.CurrentRow.Index).Value
    End Sub

    Private Sub dgd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgd.CellContentClick
        txtModel.Text = dgd.Item(5, dgd.CurrentRow.Index).Value
    End Sub
End Class