Public Class frmMainWashingMachine
    Private Sub StepOneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepOneToolStripMenuItem.Click

    End Sub

    Private Sub StepOneRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepOneRegToolStripMenuItem.Click

    End Sub

    Private Sub StepTwoRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepTwoRegToolStripMenuItem.Click
        Dim frm As New Heater_Registration__step_three
        frm.show()

    End Sub

    Private Sub StepTwoQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepTwoQueryToolStripMenuItem.Click
        Dim frm As New Heater_Step_Three_Query
        frm.Show()
    End Sub

    Private Sub StepThreeRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepThreeRegToolStripMenuItem.Click
        Dim frm As New Heater_Registration__step_two
        frm.Show()
    End Sub

    Private Sub StepThreeQueryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepThreeQueryToolStripMenuItem.Click
        Dim frm As New Heater_Step_Two_Query
        frm.Show()
    End Sub

    Private Sub DashBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashBoardToolStripMenuItem.Click
        Dim frm As New frmWMDashBoard
        frm.Show()

    End Sub

    Private Sub FinishGoodRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinishGoodRegToolStripMenuItem.Click
        Dim frm As New frmWashingMachineStepOutput
        frm.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As New Heater_add_new_model
        frm.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub StepOneRegToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StepOneRegToolStripMenuItem1.Click
        Dim frm As New frmWashingMachineStepInput
        frm.Show()
    End Sub

    Private Sub StepOneQueryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StepOneQueryToolStripMenuItem1.Click
        Dim frm As New frmWashingMachineStepInputQuery
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim frm As New frmRefrigeratorCreateUser
        frm.Show()

    End Sub

    Private Sub frmMainWashingMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Me.SkinEngine1.SkinFile = "Skins/EmeraldColor1.ssk"

        Catch ex As Exception

        End Try


    End Sub

    Private Sub QualityRegToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QualityRegToolStripMenuItem.Click

    End Sub
End Class