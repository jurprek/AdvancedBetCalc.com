Public Class Odds_Converter
    Inherits System.Web.UI.Page

    Dim oddsconvTemp, oddsconvFracB As Decimal

    Private Sub ODDSConverzionDecimal()

        oddsconvTemp = 0
        For oddsconvBrojilo = 1 To 10000 Step 1
            oddsconvTemp = oddsconvTemp + 1
            If (ODDSDecimal.Text - 1) * oddsconvTemp < Int((ODDSDecimal.Text - 1) * oddsconvTemp) + 0.0001 Then If (ODDSDecimal.Text - 1) * oddsconvTemp > Int((ODDSDecimal.Text - 1) * oddsconvTemp) - 0.0001 Then GoTo oddsconv100
        Next oddsconvBrojilo
oddsconv100:
        oddsconvFracB = Int((ODDSDecimal.Text - 1) * oddsconvTemp)
        Dim oddsconvString1 As String = oddsconvFracB.ToString(oddsconvFracB)
        oddsconvTempbox.Text = oddsconvTemp
        ODDSFractions.Text = oddsconvString1 + "/" + oddsconvTempbox.Text

        If ODDSDecimal.Text < 2 Then ODDSMoneyline.Text = FormatNumber(-100 / (ODDSDecimal.Text - 1), 2) Else ODDSMoneyline.Text = FormatNumber((ODDSDecimal.Text - 1) * 100, 2)
        ODDSHongKong.Text = FormatNumber(ODDSDecimal.Text - 1, 4)
        ODDSIndonesian.Text = FormatNumber(ODDSMoneyline.Text / 100, 4)
        If ODDSDecimal.Text < 2 Then ODDSMalay.Text = FormatNumber(ODDSDecimal.Text - 1, 4) Else ODDSMalay.Text = FormatNumber(-1 / (ODDSDecimal.Text - 1), 4)
        ODDSImplied.Text = FormatNumber(100 / ODDSDecimal.Text, 4)

    End Sub

    Private Sub ButtonOddsCon2_click(sender As System.Object, e As System.EventArgs) Handles ButtonOddsCon2.Click

        Call ODDSConverzionDecimal()

    End Sub

    Private Sub ButtonOddsCon3_click(sender As System.Object, e As System.EventArgs) Handles ButtonOddsCon3.Click

        If ODDSMoneyline.Text >= 0 Then ODDSDecimal.Text = FormatNumber((ODDSMoneyline.Text / 100) + 1, 4)
        If ODDSMoneyline.Text < 0 Then ODDSDecimal.Text = FormatNumber((-100 / ODDSMoneyline.Text) + 1, 4)
        Call ODDSConverzionDecimal()

    End Sub

    Private Sub ButtonOddsCon5_click(sender As System.Object, e As System.EventArgs) Handles ButtonOddsCon5.Click

        ODDSDecimal.Text = FormatNumber(ODDSHongKong.Text + 1, 4)
        Call ODDSConverzionDecimal()

    End Sub

    Private Sub ButtonOddsCon6_click(sender As System.Object, e As System.EventArgs) Handles ButtonOddsCon6.Click

        If ODDSIndonesian.Text >= 0 Then ODDSDecimal.Text = FormatNumber(ODDSIndonesian.Text + 1, 4)
        If ODDSIndonesian.Text < 0 Then ODDSDecimal.Text = FormatNumber((-1 / ODDSIndonesian.Text) + 1, 4)
        Call ODDSConverzionDecimal()

    End Sub

    Private Sub ButtonOddsCon7_click(sender As System.Object, e As System.EventArgs) Handles ButtonOddsCon7.Click

        If ODDSMalay.Text >= 0 Then ODDSDecimal.Text = FormatNumber(ODDSMalay.Text + 1, 4)
        If ODDSMalay.Text < 0 Then ODDSDecimal.Text = FormatNumber((-1 / ODDSMalay.Text) + 1, 4)
        Call ODDSConverzionDecimal()

    End Sub

    Private Sub ButtonOddsCon1_click(sender As System.Object, e As System.EventArgs) Handles ButtonOddsCon1.Click

        ODDSDecimal.Text = FormatNumber(100 / ODDSImplied.Text, 4)
        Call ODDSConverzionDecimal()

    End Sub

    Protected Sub ImageButtonUK_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonUK.Click
        TextBoxHelpUK.Visible = True
        TextBoxHelpHR.Visible = False
    End Sub

    Protected Sub ImageButtonHR_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonHR.Click
        TextBoxHelpUK.Visible = False
        TextBoxHelpHR.Visible = True
    End Sub

    Private Sub ButtonOddsCon4_click(sender As System.Object, e As System.EventArgs) Handles ButtonOddsCon4.Click

FRAC2:
        Dim valueNazivnik As String = ODDSFractions.Text
        Dim ukbrznam As String = valueNazivnik.Length - 1
        valueNazivnik = valueNazivnik.Replace("/", ".")
        Dim valueBrojnik As String = Int(valueNazivnik)
        Dim brznamBrojnika As String = valueBrojnik.Length
        valueNazivnik = valueNazivnik - valueBrojnik
        ODDSDecimal.Text = valueBrojnik / (valueNazivnik * 10 ^ (ukbrznam - brznamBrojnika)) + 1
        ODDSDecimal.Text = FormatNumber(ODDSDecimal.Text, 4)
        Call ODDSConverzionDecimal()

    End Sub
End Class