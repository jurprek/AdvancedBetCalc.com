Public Class Probability_collisions
    Inherits System.Web.UI.Page


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ax, Bx As Decimal
        Ax = Math.Round(P1W.Text * 1000, 0)
        Bx = Math.Round(P2W.Text * 1000, 0)

        If Ax < Bx Then ToWinP1.Text = FormatNumber((Math.Min(Ax, Bx) ^ 2 / (2 * Ax * Bx)) * 100, 2) Else ToWinP1.Text = FormatNumber((1 - Math.Min(Ax, Bx) ^ 2 / (2 * Ax * Bx)) * 100, 2)
        P1L.Text = FormatNumber((1 - Ax / 100000) * 100, 2)
        P2L.Text = FormatNumber((1 - Bx / 100000) * 100, 2)
        ToWinP2.Text = FormatNumber((1 - ToWinP1.Text / 100) * 100, 2)

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ToDrawHC.Text = FormatNumber(Math.Min((P1HC.Text * 1), (P2HC.Text * 1)) / ((P1HC.Text * 1) * (P2HC.Text * 1)) * 100, 2)

        Dim Minimalni As Decimal = 0
        Dim Maksimalni As Decimal = 0

        Minimalni = FormatNumber((Math.Min((P1HC.Text * 1), (P2HC.Text * 1)) * (Math.Min((P1HC.Text * 1), (P2HC.Text * 1)) - 1) / (2 * (P1HC.Text * 1) * (P2HC.Text * 1))) * 100, 2)
        Maksimalni = FormatNumber((1 - Math.Min((P1HC.Text * 1), (P2HC.Text * 1)) * (Math.Min((P1HC.Text * 1), (P2HC.Text * 1)) + 1) / (2 * (P1HC.Text * 1) * (P2HC.Text * 1))) * 100, 2)

        If P1HC.Text * 1 < P2HC.Text * 1 Then ToWinP1HC.Text = Minimalni Else ToWinP2HC.Text = Minimalni
        If P1HC.Text * 1 < P2HC.Text * 1 Then ToWinP2HC.Text = Maksimalni Else ToWinP1HC.Text = Maksimalni

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