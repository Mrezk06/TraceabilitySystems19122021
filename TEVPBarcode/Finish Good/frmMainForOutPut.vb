Public Class frmMainForOutPut

    Private Sub frmMainForOutPut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/MidsummerColor2.ssk"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm As New frmQOutp
        frm.Show()

    End Sub

    'Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
    '    Dim frm As New frmAbout
    '    frm.Show()
    '    ' Me.Hide()
    'End Sub

    'Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
    '    Dim frm As New frmOutp
    '    frm.Show()
    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmAbout
        frm.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New frmSony
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New frmshowdataforfinishgood

        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New frmaddmodelandlebar

        frm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        Dim frm As New NotesForProblems
        frm.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim frm As New QueryforQulity
        frm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        Dim frm As New Qulity_in_Or_out
        frm.Show()

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm As New frmFinishGoodWH
        frm.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)
        Dim frm As New frmSony
        frm.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Dim frm As New frmQFinishGoodWH1
        frm.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim frm As New frmFinishGoodWH22
        frm.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Dim frm As New frmQFinishGoodWH2
        frm.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim frm As New frmFinishGoodWH3
        frm.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Dim frm1 As New frmQFinishGoodWH3
        frm1.Show()
    End Sub
End Class