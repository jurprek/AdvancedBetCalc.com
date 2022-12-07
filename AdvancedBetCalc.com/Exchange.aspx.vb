Public Class Exchange
    Inherits System.Web.UI.Page

    Dim wn1, wn2, Bs As Decimal

    Protected Sub ImageButtonUK_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonUK.Click
        TextBoxHelpUK.Visible = True
        TextBoxHelpHR.Visible = False
    End Sub

    Protected Sub ImageButtonHR_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonHR.Click
        TextBoxHelpUK.Visible = False
        TextBoxHelpHR.Visible = True
    End Sub

    Protected Sub RatioButton_Click(sender As Object, e As EventArgs) Handles RatioButton.Click
        If Ulog1.Text = ("error") Then Ulog1.Text = 0
        If Ulog1.Text = ("") Then Ulog1.Text = 0
        If BckrStake.Text = ("error") Then BckrStake.Text = 0
        If BckrStake.Text < 0 Then BckrStake.Text = 0
        If BckrStake.Text = ("") Then BckrStake.Text = 0
        If Ulog1.Text < 0 Then Ulog1.Text = 0
        If Ulog1.Text = 0 Then GoTo Ulog0
        If Ratio1.Text = ("-") Then Ratio1.Text = 50 Else Ratio1.Text = Ratio1.Text
        If Ratio1.Text >= 100 Then Ratio2.Text = 0
        If Ratio1.Text >= 100 Then Ratio1.Text = 100
        If Ratio1.Text <= 0 Then Ratio2.Text = 100
        If Ratio1.Text <= 0 Then Ratio1.Text = 0
        Ratio1.ForeColor = Drawing.ColorTranslator.FromHtml("#003399")
        If Ratio1.Text >= 100 Then Ratio2.Text = 0.000001 Else Ratio2.Text = FormatNumber(100 - Ratio1.Text, 2)
        If Backodds.Text = Layodds.Text Then Layodds.Text = Layodds.Text + 0.0001 Else Layodds.Text = Layodds.Text
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then BckrStake.Text = ("error") Else Bs = Ulog1.Text * (Backodds.Text - 1 + Ratio1.Text / Ratio2.Text) / (Layodds.Text - 1 + Ratio1.Text / Ratio2.Text)
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then BckrStake.Text = ("error") Else BckrStake.Text = FormatNumber(Bs, 2)
        If Backodds.Text * Layodds.Text = 0 Then BckrStake.Text = ("error") Else BckrStake.Text = FormatNumber(Bs, 2)
        If Backodds.Text * Layodds.Text = 0 Then Ulog1.Text = ("error") Else Ulog1.Text = Ulog1.Text
        If Backodds.Text * Layodds.Text = 0 Then MyLiability.Text = ("error") Else MyLiability.Text = FormatNumber((Layodds.Text - 1) * BckrStake.Text, 2)
        If Backodds.Text * Layodds.Text = 0 Then Win1.Text = ("error") Else Win1.Text = Win1.Text
        If Backodds.Text * Layodds.Text = 0 Then Win2.Text = ("error") Else Win2.Text = Win2.Text
        If Backodds.Text * Layodds.Text = 0 Then Win3.Text = ("error") Else Win3.Text = Win3.Text
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then GoTo end1

        wn1 = Ulog1.Text * (Backodds.Text - 1) - MyLiability.Text
        If wn1 > 0 Then wn1 = wn1 / (1 + rake.Text / 100) Else wn1 = wn1
        wn2 = BckrStake.Text - Ulog1.Text
        If wn2 > 0 Then wn2 = wn2 / (1 + rake.Text / 100) Else wn2 = wn2
        Win1.Text = FormatNumber(wn1, 2)
        Win2.Text = FormatNumber(wn2, 2)
        Win3.Text = Win2.Text
        Ratio1.Text = FormatNumber(Ratio1.Text, 2)
        Ratio2.Text = FormatNumber(Ratio2.Text, 2)

Ulog0:
        Ulog1.Text = 100
        If Ulog1.Text = ("error") Then Ulog1.Text = 0
        If BckrStake.Text = ("error") Then BckrStake.Text = 0
        If BckrStake.Text = ("") Then BckrStake.Text = 0
        If BckrStake.Text < 0 Then BckrStake.Text = 0
        If Ratio1.Text = ("-") Then Ratio1.Text = 50 Else Ratio1.Text = Ratio1.Text
        If Ratio1.Text >= 100 Then Ratio2.Text = 0
        If Ratio1.Text >= 100 Then Ratio1.Text = 100
        If Ratio1.Text <= 0 Then Ratio2.Text = 100
        If Ratio1.Text <= 0 Then Ratio1.Text = 0
        Ratio1.ForeColor = Drawing.ColorTranslator.FromHtml("#003399")
        If Ratio1.Text >= 100 Then Ratio2.Text = 0.000001 Else Ratio2.Text = FormatNumber(100 - Ratio1.Text, 2)
        If Backodds.Text = Layodds.Text Then Layodds.Text = Layodds.Text + 0.0001 Else Layodds.Text = Layodds.Text
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then BckrStake.Text = ("error") Else Bs = Ulog1.Text * (Backodds.Text - 1 + Ratio1.Text / Ratio2.Text) / (Layodds.Text - 1 + Ratio1.Text / Ratio2.Text)
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then BckrStake.Text = ("error") Else BckrStake.Text = BckrStake.Text
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then GoTo end1 Else Ulog1.Text = FormatNumber(Ulog1.Text / Bs * BckrStake.Text, 2)
        If Backodds.Text * Layodds.Text = 0 Then BckrStake.Text = ("error") Else BckrStake.Text = BckrStake.Text
        If Backodds.Text * Layodds.Text = 0 Then Ulog1.Text = ("error") Else Ulog1.Text = Ulog1.Text
        If Backodds.Text * Layodds.Text = 0 Then MyLiability.Text = ("error") Else MyLiability.Text = FormatNumber((Layodds.Text - 1) * BckrStake.Text, 2)
        If Backodds.Text * Layodds.Text = 0 Then Win1.Text = ("error") Else Win1.Text = Win1.Text
        If Backodds.Text * Layodds.Text = 0 Then Win2.Text = ("error") Else Win2.Text = Win2.Text
        If Backodds.Text * Layodds.Text = 0 Then Win3.Text = ("error") Else Win3.Text = Win3.Text
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then GoTo end1

        wn1 = Ulog1.Text * (Backodds.Text - 1) - MyLiability.Text
        If wn1 > 0 Then wn1 = wn1 / (1 + rake.Text / 100) Else wn1 = wn1
        wn2 = BckrStake.Text - Ulog1.Text
        If wn2 > 0 Then wn2 = wn2 / (1 + rake.Text / 100) Else wn2 = wn2
        Win1.Text = FormatNumber(wn1, 2)
        Win2.Text = FormatNumber(wn2, 2)
        Win3.Text = Win2.Text
        Ratio1.Text = FormatNumber(Ratio1.Text, 2)
        Ratio2.Text = FormatNumber(Ratio2.Text, 2)

        If Win1.Text < 0 Then Win1.ForeColor = Drawing.Color.Red Else Win1.ForeColor = Drawing.ColorTranslator.FromHtml("#009900")
        If Win2.Text < 0 Then Win2.ForeColor = Drawing.Color.Red Else Win2.ForeColor = Drawing.ColorTranslator.FromHtml("#009900")
        If Win3.Text < 0 Then Win3.ForeColor = Drawing.Color.Red Else Win3.ForeColor = Drawing.ColorTranslator.FromHtml("#009900")

end1:
    End Sub


    Protected Sub BeckersButton_Click(sender As Object, e As EventArgs) Handles BeckersButton.Click
        If BckrStake.Text = ("error") Then BckrStake.Text = 0
        If BckrStake.Text = ("") Then BckrStake.Text = 0
        If BckrStake.Text < 0 Then BckrStake.Text = 0
        If Ulog1.Text = ("error") Then Ulog1.Text = 0
        If Ulog1.Text = ("") Then Ulog1.Text = 0
        If Ulog1.Text < 0 Then Ulog1.Text = 0
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then GoTo end2
        If Backodds.Text = Layodds.Text Then Layodds.Text = Layodds.Text + 0.00000000000099999999999999998 Else Layodds.Text = Layodds.Text
        Ratio1.ForeColor = Drawing.ColorTranslator.FromHtml("#003399")
        If BckrStake.Text = ("error") Then BckrStake.Text = 0 Else BckrStake.Text = BckrStake.Text
        If BckrStake.Text < 0 Then BckrStake.Text = 0
        wn2 = BckrStake.Text - Ulog1.Text
        If wn2 > 0 Then wn2 = wn2 / (1 + rake.Text / 100) Else wn2 = wn2
        Win2.Text = FormatNumber(wn2, 2)
        MyLiability.Text = FormatNumber((Layodds.Text - 1) * BckrStake.Text, 2)
        wn1 = Ulog1.Text * (Backodds.Text - 1) - MyLiability.Text
        If wn1 > 0 Then wn1 = wn1 / (1 + rake.Text / 100) Else wn1 = wn1
        Win1.Text = FormatNumber(wn1, 2)
        Win3.Text = Win2.Text
        Ratio1.Text = FormatNumber(100 * wn1 / (wn1 + wn2), 2)
        Ratio2.Text = FormatNumber(100 - Ratio1.Text, 2)
        If Win1.Text < 0 Then Win1.ForeColor = Drawing.Color.Red Else Win1.ForeColor = Drawing.ColorTranslator.FromHtml("#009900")
        If Win2.Text < 0 Then Win2.ForeColor = Drawing.Color.Red Else Win2.ForeColor = Drawing.ColorTranslator.FromHtml("#009900")
        If Win3.Text < 0 Then Win3.ForeColor = Drawing.Color.Red Else Win3.ForeColor = Drawing.ColorTranslator.FromHtml("#009900")
        Ratio1.ForeColor = Drawing.ColorTranslator.FromHtml("#999999")
        If Backodds.Text <= 0 Or Layodds.Text <= 0 Then BckrStake.Text = ("error") Else BckrStake.Text = FormatNumber(BckrStake.Text, 2)
        Ratio1.Text = ("-")
        Ratio2.Text = ("-")

end2:
    End Sub

End Class
