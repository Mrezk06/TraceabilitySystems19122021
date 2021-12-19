Public Class frmMain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SkinEngine1.SkinFile = "Skins/XPOrange.ssk"
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Close()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New LED_BAR_barcode_structure
        frm.Show()
        ' Me.Hide()
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Dim frm As New frmLCM1
        frm.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Dim frm As New scanningFat1
        frm.Show()
        ''Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim frm As New frmFat
        frm.Show()
        ' Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim frm As New LED_BAR_barcode_structure
        frm.Show()
        ' Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim frm As New frmLCM1
        frm.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim frm As New frmAddData
        frm.Show()
        ' Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim frm As New QueryFat1
        frm.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim frm As New ShowTarget
        frm.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim frm As New frmMainForOutPut
        frm.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim FRM As New Qulity_in_Or_out
        FRM.Show()

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim frm As New frmAbout
        frm.Show()
        ' Me.Hide()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim frm As New frmMainRepair
        frm.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmtestforquallity
        frm.Show()

    End Sub

    Private Sub InspectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InspectionToolStripMenuItem.Click
        Dim frm As New frmtestforquallity
        frm.Show()
    End Sub

    Private Sub SFATSTAION1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SFATSTAION1ToolStripMenuItem.Click
        Dim frm As New scanningFat1
        frm.Show()
    End Sub

    Private Sub SFATSTAION2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SFATSTAION2ToolStripMenuItem.Click
        Dim frm As New frmFat
        frm.Show()
        ' Me.Hide()
    End Sub

    Private Sub SLCMSTAION1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLCMSTAION1ToolStripMenuItem.Click
        Dim frm As New LED_BAR_barcode_structure
        frm.Show()
        ' Me.Hide()
    End Sub

    Private Sub SLCMSTAION2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SLCMSTAION2ToolStripMenuItem.Click
        Dim frm As New frmLCM1
        frm.Show()
    End Sub

    Private Sub ADDNEWMODELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWMODELToolStripMenuItem.Click

    End Sub

    Private Sub SOUTPUTSTAIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SOUTPUTSTAIONToolStripMenuItem.Click
        Dim frm As New frmMainForOutPut
        frm.Show()
    End Sub

    Private Sub REPAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPAIRToolStripMenuItem.Click
       
    End Sub

    Private Sub QUALITYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QUALITYToolStripMenuItem.Click
        Dim FRM As New Qulity_in_Or_out
        FRM.Show()
    End Sub

    Private Sub SHOWTARGETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHOWTARGETToolStripMenuItem.Click
        Dim frm As New ShowTarget
        frm.Show()
    End Sub

    Private Sub CONTACTUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTACTUSToolStripMenuItem.Click
        Dim frm As New frmAbout
        frm.Show()
    End Sub

    Private Sub FATREPAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FATREPAIRToolStripMenuItem.Click
        Dim frm As New frmLCMRepair
        frm.Show()
    End Sub

    Private Sub QUARYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QUARYToolStripMenuItem.Click
        Dim frm As New frmQueryRepair
        frm.Show()
    End Sub

    Private Sub FATREPAIRToolStripMenuItem_DoubleClick(sender As Object, e As EventArgs) Handles FATREPAIRToolStripMenuItem.DoubleClick

    End Sub

    Private Sub REPAIRToolStripMenuItem_DoubleClick(sender As Object, e As EventArgs) Handles REPAIRToolStripMenuItem.DoubleClick
        Dim frm As New frmMainRepair
        frm.Show()
    End Sub

    Private Sub ADDDataFORREPAIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDDataFORREPAIRToolStripMenuItem.Click
        Dim frm As New frmAddingNewInformation
        frm.Show()
    End Sub

    Private Sub RunRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunRateToolStripMenuItem.Click
        Dim frm As New frmRunRate
        frm.Show()

    End Sub

    Private Sub QueryRunRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueryRunRateToolStripMenuItem.Click
        Dim frm As New frmQueryRunRate
        frm.Show()
    End Sub

    Private Sub NewInspectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewInspectionToolStripMenuItem.Click
        Dim frm As New FrmNEWtESTrEQ
        frm.Show()
    End Sub

    Private Sub FollowSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FollowSVToolStripMenuItem.Click
        Dim frm As New frmfollowupsv
        frm.Show()
    End Sub

    Private Sub QueryFollowSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QueryFollowSVToolStripMenuItem.Click
        Dim frm As New frmqueryfollowUPsv
        frm.Show()
    End Sub

    Private Sub NewDashBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewDashBoardToolStripMenuItem.Click
        Dim frm As New newshowforData
        frm.Show()
    End Sub

    Private Sub ADDNEWMODELToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ADDNEWMODELToolStripMenuItem1.Click
        Dim frm As New frmAddData
        frm.Show()
        ' Me.Hide()
    End Sub

    Private Sub ADDNEWUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDNEWUserToolStripMenuItem.Click
        Dim frm As New frmRefrigeratorCreateUser
        frm.Show()
        ' Me.Hide()
    End Sub
End Class