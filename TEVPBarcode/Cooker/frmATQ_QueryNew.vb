
Imports TEVPBarcode.sher
Public Class frmATQ_QueryNew


    Private Sub Heater_Step_Three_Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"

    End Sub
    Private Function _Refresh001() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT count(Autre) FROM  ATQTET "
            sql += "   where CreatedAT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CreatedAT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and  Line ='" & ComboBox1.Text & "'"
            sql += "   and CreatedON>='" & txttotime.Text & "'"
            sql += "   and CreatedON<= '" & txtfromTime.Text & "'"
            sql += "and Autre<>''"
            ''  sql += "group by  LaDate, Heure, Piece, NumSerie, CodeBarre, Operateur, NbTests,CodeErreur, BonFinal, Name,Autre"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "ATQTET")
            ds.Tables("ATQTET").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("ATQTET")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh511() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT count(Autre) FROM  ATQTET "
            sql += " where Autre ='" & txtFATSERIAL.Text & "'"
            sql += "and Autre<>''"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "ATQTET")
            ds.Tables("ATQTET").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("ATQTET")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh011() As Boolean
        Try
            Dim sql As String = ""

            sql += " SELECT count(Autre) FROM  ATQTET "
            sql += "   where CreatedAT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CreatedAT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and  Line ='" & ComboBox1.Text & "'"
            sql += "and Autre<>''"
            'sql += "group by  LaDate, Heure, Piece, NumSerie, CodeBarre, Operateur, NbTests,CodeErreur, BonFinal, Name,Autre"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "ATQTET")
            ds.Tables("ATQTET").Columns(0).ColumnName = " الكمية "
            dg6.DataSource = ds.Tables("ATQTET")
            dg6.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh111() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT  LaDate, Heure, Piece, NumSerie, CodeBarre, Operateur, NbTests, CodeErreur, BonFinal, Name,Autre,Line FROM  ATQTET "
            sql += "   where CreatedAT >= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CreatedAT <= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CreatedON>='" & txttotime.Text & "'"
            sql += "   and CreatedON<= '" & txtfromTime.Text & "'"
            sql += " and  Line ='" & ComboBox1.Text & "'"
            sql += "and Autre<>''"
            sql += "group by  LaDate, Heure, Piece, NumSerie, CodeBarre, Operateur, NbTests,CodeErreur, BonFinal, Name,Autre,Line"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "ATQTET")

            ds.Tables("ATQTET").Columns(0).ColumnName = "التاريخ من الاتك "
            ds.Tables("ATQTET").Columns(1).ColumnName = " الوقت من الاتك"
            ds.Tables("ATQTET").Columns(2).ColumnName = " القطعه"
            ds.Tables("ATQTET").Columns(3).ColumnName = "رقم المسلسل"
            ds.Tables("ATQTET").Columns(4).ColumnName = "كود بري"
            ds.Tables("ATQTET").Columns(5).ColumnName = "كود المشغل"
            ds.Tables("ATQTET").Columns(6).ColumnName = " كود الاختبار"
            ds.Tables("ATQTET").Columns(7).ColumnName = " كود حالة الاختبار"
            ds.Tables("ATQTET").Columns(8).ColumnName = "كود ناتج الاختبار"
            ds.Tables("ATQTET").Columns(9).ColumnName = "شرح ناتج الاختبار"
            ds.Tables("ATQTET").Columns(10).ColumnName = "باركود الباتوجاز"
            ds.Tables("ATQTET").Columns(11).ColumnName = "كود الخط وجهاز الاختبار"
            dg.DataSource = ds.Tables("ATQTET")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try



    End Function
    Private Function _Refresh11() As Boolean
        Try
            Dim sql As String = ""
            sql += " SELECT  LaDate, Heure, Piece, NumSerie, CodeBarre, Operateur, NbTests, CodeErreur, BonFinal, Name,Autre,Line FROM  ATQTET "
            sql += "   where CreatedAT >= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CreatedAT <= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and  Line ='" & ComboBox1.Text & "'"
            sql += "and Autre<>''"
            sql += "group by  LaDate, Heure, Piece, NumSerie, CodeBarre, Operateur, NbTests,CodeErreur, BonFinal, Name,Autre,Line"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "ATQTET")
            ds.Tables("ATQTET").Columns(0).ColumnName = "التاريخ من الاتك "
            ds.Tables("ATQTET").Columns(1).ColumnName = " الوقت من الاتك"
            ds.Tables("ATQTET").Columns(2).ColumnName = " القطعه"
            ds.Tables("ATQTET").Columns(3).ColumnName = "رقم المسلسل"
            ds.Tables("ATQTET").Columns(4).ColumnName = "كود بري"
            ds.Tables("ATQTET").Columns(5).ColumnName = "كود المشغل"
            ds.Tables("ATQTET").Columns(6).ColumnName = " كود الاختبار"
            ds.Tables("ATQTET").Columns(7).ColumnName = " كود حالة الاختبار"
            ds.Tables("ATQTET").Columns(8).ColumnName = "كود ناتج الاختبار"
            ds.Tables("ATQTET").Columns(9).ColumnName = "شرح ناتج الاختبار"
            ds.Tables("ATQTET").Columns(10).ColumnName = "باركود الباتوجاز"
            ds.Tables("ATQTET").Columns(11).ColumnName = " كود الخط وجهاز الاختبار"
            dg.DataSource = ds.Tables("ATQTET")
            dg.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1() As Boolean
        Try
            Dim sql As String = ""
            sql += "select DISTINCT CreatedAT,count( CreatedON), LaDate, Heure, Piece, NumSerie, CodeBarre, Operateur, NbTests, CodeErreur, BonFinal, Name,Autre FROM  ATQTET "
            sql += " where Autre ='" & txtFATSERIAL.Text & "'"
            sql += " group by CreatedAT, CreatedON, LaDate, Heure, Piece, NumSerie, CodeBarre, Operateur, NbTests, CodeErreur, BonFinal, Name,Autre "
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "ATQTET")
            ds.Tables("ATQTET").Columns(0).ColumnName = " التاريخ "
            ds.Tables("ATQTET").Columns(1).ColumnName = " الوقت "
            ds.Tables("ATQTET").Columns(2).ColumnName = "التاريخ من الاتك "
            ds.Tables("ATQTET").Columns(3).ColumnName = " الوقت من الاتك"
            ds.Tables("ATQTET").Columns(4).ColumnName = " القطعه"
            ds.Tables("ATQTET").Columns(5).ColumnName = "رقم المسلسل"
            ds.Tables("ATQTET").Columns(6).ColumnName = "كود بري"
            ds.Tables("ATQTET").Columns(7).ColumnName = "كود المشغل"
            ds.Tables("ATQTET").Columns(8).ColumnName = " كود الاختبار"
            ds.Tables("ATQTET").Columns(9).ColumnName = " كود حالة الاختبار"
            ds.Tables("ATQTET").Columns(10).ColumnName = "كود ناتج الاختبار"
            ds.Tables("ATQTET").Columns(11).ColumnName = "شرح ناتج الاختبار"
            ds.Tables("ATQTET").Columns(12).ColumnName = "باركود الباتوجاز"
            dg.DataSource = ds.Tables("ATQTET")
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



    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbl_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSEARCH_Click_1(sender As Object, e As EventArgs) Handles btnSEARCH.Click
        'If ComboBox1.Text = "" Then
        If txttotime.Text = "" And txtfromTime.Text = "" Then
                _Refresh11()
                _Refresh1552()
                _Refresh011()

            Else
                _Refresh001()
                _Refresh155()
                _Refresh111()
            End If
        'Else
        '    MsgBox("اختيار الخط والجهاز امر اجبارى وليس اختيارى  الرجاء اختيار الخط والجهاز")
        'End If


    End Sub


    Private Sub btnsearch1_Click_1(sender As Object, e As EventArgs) Handles btnsearch1.Click
        _Refresh1()
        _Refresh511()
        _Refresh1558()
    End Sub

    Private Sub btnsearchModel_Click_1(sender As Object, e As EventArgs)


    End Sub



    Private Function _Refresh155() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT  CreatedAT, CreatedON, LaDate, Heure,CodeBarre, Phase, NumTest, Bon, Valeur1, Unite1, Valeur2, Unite2, Autre"
            sql += " FROM Detail"
            sql += " where CreatedAT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and CreatedAT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"
            sql += " and CreatedON>='" & txttotime.Text & "'"
            sql += " and CreatedON<= '" & txtfromTime.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Detail")
            ds.Tables("Detail").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Detail").Columns(1).ColumnName = " الوقت "
            ds.Tables("Detail").Columns(2).ColumnName = "التاريخ من الاتك "
            ds.Tables("Detail").Columns(3).ColumnName = " الوقت من الاتك"
            ds.Tables("Detail").Columns(4).ColumnName = "كود بري"
            ds.Tables("Detail").Columns(5).ColumnName = "كود المرحلة"
            ds.Tables("Detail").Columns(6).ColumnName = " كود الاختبار"
            ds.Tables("Detail").Columns(7).ColumnName = " نوع الاختبار"
            ds.Tables("Detail").Columns(8).ColumnName = " المتغير الاول"
            ds.Tables("Detail").Columns(9).ColumnName = "الوحدة الاولة"
            ds.Tables("Detail").Columns(10).ColumnName = "المتغير الثانى "
            ds.Tables("Detail").Columns(11).ColumnName = "الوحدة الثانية"

            ds.Tables("Detail").Columns(12).ColumnName = "باركود الباتوجاز"
            dg9.DataSource = ds.Tables("Detail")
            dg9.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Function _Refresh1552() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT  CreatedAT, CreatedON, LaDate, Heure,CodeBarre, Phase, NumTest, Bon, Valeur1, Unite1, Valeur2, Unite2, Autre"
            sql += " FROM Detail"
            sql += "   where CreatedAT>= '" & Format(dtpFROMDATE.Value, "yyyy-MM-dd") & "'"
            sql += "   and CreatedAT<= '" & Format(dtpToDATE.Value, "yyyy-MM-dd") & "'"

            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Detail")
            ds.Tables("Detail").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Detail").Columns(1).ColumnName = " الوقت "
            ds.Tables("Detail").Columns(2).ColumnName = "التاريخ من الاتك "
            ds.Tables("Detail").Columns(3).ColumnName = " الوقت من الاتك"
            ds.Tables("Detail").Columns(4).ColumnName = "كود بري"
            ds.Tables("Detail").Columns(5).ColumnName = "كود المرحلة"
            ds.Tables("Detail").Columns(6).ColumnName = " كود الاختبار"
            ds.Tables("Detail").Columns(7).ColumnName = " نوع الاختبار"
            ds.Tables("Detail").Columns(8).ColumnName = " المتغير الاول"
            ds.Tables("Detail").Columns(9).ColumnName = "الوحدة الاولة"
            ds.Tables("Detail").Columns(10).ColumnName = "المتغير الثانى "
            ds.Tables("Detail").Columns(11).ColumnName = "الوحدة الثانية"

            ds.Tables("Detail").Columns(12).ColumnName = "باركود الباتوجاز"
            dg9.DataSource = ds.Tables("Detail")
            dg9.AllowUserToAddRows = False
            Return True

        Catch ex As Exception
        End Try
    End Function

    Private Function _Refresh1558() As Boolean
        Try


            Dim sql As String = ""
            sql += " SELECT  CreatedAT, CreatedON, LaDate, Heure,CodeBarre, Phase, NumTest, Bon, Valeur1, Unite1, Valeur2, Unite2, Autre"
            sql += " FROM Detail"
            sql += " where Autre ='" & txtFATSERIAL.Text & "'"
            Dim da As New SqlClient.SqlDataAdapter(sql, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Detail")
            ds.Tables("Detail").Columns(0).ColumnName = " التاريخ "
            ds.Tables("Detail").Columns(1).ColumnName = " الوقت "
            ds.Tables("Detail").Columns(2).ColumnName = "التاريخ من الاتك "
            ds.Tables("Detail").Columns(3).ColumnName = " الوقت من الاتك"
            ds.Tables("Detail").Columns(4).ColumnName = "كود بري"
            ds.Tables("Detail").Columns(5).ColumnName = "كود المرحلة"
            ds.Tables("Detail").Columns(6).ColumnName = " كود الاختبار"
            ds.Tables("Detail").Columns(7).ColumnName = " نوع الاختبار"
            ds.Tables("Detail").Columns(8).ColumnName = " المتغير الاول"
            ds.Tables("Detail").Columns(9).ColumnName = "الوحدة الاولة"
            ds.Tables("Detail").Columns(10).ColumnName = "المتغير الثانى "
            ds.Tables("Detail").Columns(11).ColumnName = "الوحدة الثانية"

            ds.Tables("Detail").Columns(12).ColumnName = "باركود الباتوجاز"
            dg9.DataSource = ds.Tables("Detail")
            dg9.AllowUserToAddRows = False
            Return True
        Catch ex As Exception
        End Try
    End Function
    Private Sub cbl_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbl_Leave(sender As Object, e As EventArgs)
        _Refresh155()
    End Sub

    Private Sub btnPCode_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPCode_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        '   btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
    End Sub

    Private Sub dg_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick
        '  btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
        ' txtS_Laber.Text = dg1.Item(1, dg1.CurrentRow.Index).Value
    End Sub
    Private Sub dg9_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dg9.CellFormatting
        'Compare the value of second Column i.e. Column with Index 1.
        If e.ColumnIndex = 12 AndAlso e.Value IsNot Nothing Then

            Dim quantity As String = Convert.ToString(e.Value)
            If quantity.Length < 10 Then
                dg9.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            End If

            'If quantity > 0 AndAlso quantity <= 50 Then
            '    dg.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
            'End If

            'If quantity > 50 AndAlso quantity <= 100 Then
            '    dg.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Orange
            'End If
        End If
    End Sub
    Private Sub dg_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dg.CellFormatting
        'Compare the value of second Column i.e. Column with Index 1.
        If e.ColumnIndex = 12 AndAlso e.Value IsNot Nothing Then

            Dim quantity As String = Convert.ToString(e.Value)
            If quantity.Length < 10 Then
                dg.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
            End If
        End If
    End Sub
    Private Sub dg_Click(sender As Object, e As EventArgs) Handles dg.Click
        'btnPCode.Text = dg.Item(2, dg.CurrentRow.Index).Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        _Refresh155()
    End Sub

    Private Sub txtFATSERIAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFATSERIAL.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "ABCDEFGHIJKLMNOBQRSTUVWXYZ 0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToUpper) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFATSERIAL_TextChanged(sender As Object, e As EventArgs) Handles txtFATSERIAL.TextChanged

    End Sub
End Class