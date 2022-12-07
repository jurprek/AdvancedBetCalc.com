Public Class Asian_handicap1
    Inherits System.Web.UI.Page

    Private Sub AHclcBTN_Click(sender As System.Object, e As System.EventArgs) Handles AHclcBTN.Click

        If OCAHCLCAHbox.Text - Int(OCAHCLCAHbox.Text) = 0 Then OCAHCLCAHa.Text = OCAHCLCAHbox.Text Else If OCAHCLCAHbox.Text - Int(OCAHCLCAHbox.Text) = 0.25 Then OCAHCLCAHa.Text = OCAHCLCAHbox.Text + 0.25 Else If OCAHCLCAHbox.Text - Int(OCAHCLCAHbox.Text) = 0.5 Then OCAHCLCAHa.Text = OCAHCLCAHbox.Text + 0.0 Else If OCAHCLCAHbox.Text - Int(OCAHCLCAHbox.Text) = 0.75 Then OCAHCLCAHa.Text = OCAHCLCAHbox.Text + 0.25 Else If OCAHCLCAHbox.Text + Int(OCAHCLCAHbox.Text) = -0.25 Then OCAHCLCAHa.Text = OCAHCLCAHbox.Text - 0.25 Else If OCAHCLCAHbox.Text + Int(OCAHCLCAHbox.Text) = 0.5 Then OCAHCLCAHa.Text = OCAHCLCAHbox.Text - 0.0 Else If OCAHCLCAHbox.Text + Int(OCAHCLCAHbox.Text) = -0.75 Then OCAHCLCAHa.Text = OCAHCLCAHbox.Text + 0.25
        If OCAHCLCAHbox.Text = 0.25 Then OCAHCLCAHb.Text = 0 Else If OCAHCLCAHbox.Text = -0.25 Then OCAHCLCAHb.Text = -0.5 Else If OCAHCLCAHa.Text - OCAHCLCAHbox.Text = 0 Then OCAHCLCAHb.Text = 0 Else If OCAHCLCAHa.Text < 0 Then OCAHCLCAHb.Text = OCAHCLCAHa.Text - 0.5 Else If OCAHCLCAHa.Text > 0 Then OCAHCLCAHb.Text = OCAHCLCAHa.Text - 0.5 Else If OCAHCLCAHa.Text = 0 Then OCAHCLCAHb.Text = 0
        OCAHCLCAHa.Text = FormatNumber(OCAHCLCAHa.Text, 2)
        OCAHCLCAHb.Text = FormatNumber(OCAHCLCAHb.Text, 2)

        If OCAHCLCAHb.Text = 0 Then OCAHCLCInvb.Text = 0 Else OCAHCLCInvb.Text = FormatNumber(OCAHCLCInvest.Text / 2, 2)
        If OCAHCLCInvb.Text = 0 Then OCAHCLCInva.Text = OCAHCLCInvest.Text Else OCAHCLCInva.Text = FormatNumber(OCAHCLCInvest.Text / 2, 2)

        Dim OCAHCLCbrgolova As Decimal
        If OCAHCLCTeams.Text = ("Home Team") Then OCAHCLCbrgolova = OCAHCLCGola.Text - OCAHCLCGolb.Text Else OCAHCLCbrgolova = OCAHCLCGolb.Text - OCAHCLCGola.Text

        OCAHCLCPayOa.Text = FormatNumber(0, 2)
        If OCAHCLCAHb.Text = 0 Then OCAHCLCPayOb.Text = FormatNumber(0, 2) Else If OCAHCLCAHb.Text + OCAHCLCbrgolova = 0 Then OCAHCLCPayOb.Text = FormatNumber(OCAHCLCInvb.Text, 2) Else If OCAHCLCAHb.Text + OCAHCLCbrgolova > 0 Then OCAHCLCPayOb.Text = FormatNumber(OCAHCLCOdds.Text * OCAHCLCInvb.Text, 2) Else If OCAHCLCAHb.Text + OCAHCLCbrgolova < 0 Then OCAHCLCPayOb.Text = FormatNumber(0, 2)
        If OCAHCLCAHa.Text + OCAHCLCbrgolova = 0 Then OCAHCLCPayOa.Text = FormatNumber(OCAHCLCInva.Text, 2) Else If OCAHCLCAHa.Text + OCAHCLCbrgolova > 0 Then OCAHCLCPayOa.Text = FormatNumber(OCAHCLCOdds.Text * OCAHCLCInva.Text, 2) Else If OCAHCLCAHa.Text + OCAHCLCbrgolova < 0 Then OCAHCLCPayOa.Text = FormatNumber(0, 2)


        Dim OCAHCLCTEMPpayA As Decimal = OCAHCLCPayOa.Text
        Dim OCAHCLCTEMPpayB As Decimal = OCAHCLCPayOb.Text
        Dim OCAHCLCTEMPinvA As Decimal = OCAHCLCInva.Text
        Dim OCAHCLCTEMPinvB As Decimal = OCAHCLCInvb.Text

        OCAHCLCProfa.Text = FormatNumber(OCAHCLCTEMPpayA - OCAHCLCTEMPinvA, 2)
        OCAHCLCProfb.Text = FormatNumber(OCAHCLCTEMPpayB - OCAHCLCTEMPinvB, 2)
        Dim OCAHCLCTEMPprofitA As Decimal = OCAHCLCProfa.Text
        Dim OCAHCLCTEMPprofitB As Decimal = OCAHCLCProfb.Text
        OCAHCLCPayOut.Text = FormatNumber(OCAHCLCTEMPpayA + OCAHCLCTEMPpayB, 2)
        OCAHCLCProfit.Text = FormatNumber(OCAHCLCTEMPprofitA + OCAHCLCTEMPprofitB, 2)

    End Sub

    Protected Sub ImageButtonUK_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonUK.Click
        TextBoxHelpUK.Visible = True
        TextBoxHelpHR.Visible = False
    End Sub

    Protected Sub ImageButtonHR_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonHR.Click
        TextBoxHelpUK.Visible = False
        TextBoxHelpHR.Visible = True
    End Sub

End Class