Public Class FrmHeaterMainV00

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub FinishGoodPrepareAndShippingRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinishGoodPrepareAndShippingRegToolStripMenuItem.Click

    End Sub

    Private Sub StepOneRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepOneRegToolStripMenuItem.Click
        Dim frm As New FrmHeaterStepOneReg
        frm.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub StepOneQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepOneQueryToolStripMenuItem.Click
        Dim frm As New frmHeaterStepOneQuery
        frm.Show()
    End Sub

    Private Sub StepTwoRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepTwoRegToolStripMenuItem.Click
        Dim frm As New frmHeaterStepTwoOfflinReg
        frm.Show()
    End Sub

    Private Sub StepTwoQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepTwoQueryToolStripMenuItem.Click
        Dim frm As New FrmHeaterStepTwoQuery
        frm.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Dim frm As New frmAbout
        frm.Show()
    End Sub

    Private Sub StepThreeRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepThreeRegToolStripMenuItem.Click
        Dim frm As New FrmHeaterStepThreeReg
        frm.Show()
    End Sub

    Private Sub StepThreeQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepThreeQueryToolStripMenuItem.Click
        Dim frm As New FrmHeaterStepThreeQuery
        frm.Show()
    End Sub

    Private Sub FinishGoodRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinishGoodRegToolStripMenuItem.Click
        Dim frm As New frmHeaterFinishGoodMFG
        frm.Show()
    End Sub

    Private Sub FinishGoodQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinishGoodQueryToolStripMenuItem.Click
        Dim frm As New frmHeaterFinishGoodMFGQuery
        frm.Show()
    End Sub

    Private Sub RepairRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairRegToolStripMenuItem.Click
        Dim frm As New frmHeaterRepairReg

        frm.Show()
    End Sub

    Private Sub RepairQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairQueryToolStripMenuItem.Click
        Dim frm As New frmHeaterRepairQuery
        frm.Show()
    End Sub

    Private Sub StepTwoOfflineRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepTwoOfflineRegToolStripMenuItem.Click
        Dim frm As New FrmHeaterStepTwoReg
        frm.Show()

    End Sub

    Private Sub StepTwoQueryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StepTwoQueryToolStripMenuItem1.Click
        Dim frm As New frmHeaterStepTwoOfflinQuery
        frm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FinishGoodWHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinishGoodWHToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        Dim frm As New frmHeaterAddData
        frm.Show()
        Me.Hide()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub DashBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashBoardToolStripMenuItem.Click
        Dim frm As New frmHeaterDashBoard
        frm.Show()

    End Sub

    Private Sub AddHeaterScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddHeaterScheduleToolStripMenuItem.Click
        Dim frm As New frmHeaterScdule
        frm.Show()
    End Sub

    Private Sub StepOneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepOneToolStripMenuItem.Click

    End Sub

    Private Sub AddNewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewUserToolStripMenuItem.Click
        Dim frm As New frmRefrigeratorCreateUser
        frm.Show()
    End Sub
End Class