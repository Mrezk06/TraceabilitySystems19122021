Public Class frmAfter_Sales_Main
    Private Sub ADDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDToolStripMenuItem.Click
        Dim frm As New frmAfterSales_AddNewInformation
        frm.Show()
        Me.Hide()

    End Sub

    Private Sub DashBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashBoardToolStripMenuItem.Click
        Dim frm As New frmAfterSales_DashBoard
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub RepairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepairToolStripMenuItem.Click
        Dim frm As New frmAfter_Sales_Repair
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub QueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueryToolStripMenuItem.Click
        Dim frm As New frmAfter_Sales_Repair_Query
        frm.Show()
        Me.Hide()
    End Sub
End Class