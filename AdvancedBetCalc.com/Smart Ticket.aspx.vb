Public Class SmartTicket
    Inherits System.Web.UI.Page

    Dim a, brkfcova, sumakfcova, avrgKoefic, dev, odstupanje, minkfc, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16, D17, D18, D19, D20, nextticket As Decimal
    Dim sumKfcTick(20)
    Dim brParTick(20)
    Dim script As String = "window.open('Systems Table.aspx');"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub group_Click(sender As Object, e As EventArgs) Handles group.Click

        Dim kfc(20) As Decimal

        If kfc1.Text = ("") Then kfc(1) = 99999 Else kfc(1) = FormatNumber(kfc1.Text, 2)
        If kfc2.Text = ("") Then kfc(2) = 99999 Else kfc(2) = FormatNumber(kfc2.Text, 2)
        If kfc3.Text = ("") Then kfc(3) = 99999 Else kfc(3) = FormatNumber(kfc3.Text, 2)
        If kfc4.Text = ("") Then kfc(4) = 99999 Else kfc(4) = FormatNumber(kfc4.Text, 2)
        If kfc5.Text = ("") Then kfc(5) = 99999 Else kfc(5) = FormatNumber(kfc5.Text, 2)
        If kfc6.Text = ("") Then kfc(6) = 99999 Else kfc(6) = FormatNumber(kfc6.Text, 2)
        If kfc7.Text = ("") Then kfc(7) = 99999 Else kfc(7) = FormatNumber(kfc7.Text, 2)
        If kfc8.Text = ("") Then kfc(8) = 99999 Else kfc(8) = FormatNumber(kfc8.Text, 2)
        If kfc9.Text = ("") Then kfc(9) = 99999 Else kfc(9) = FormatNumber(kfc9.Text, 2)
        If kfc10.Text = ("") Then kfc(10) = 99999 Else kfc(10) = FormatNumber(kfc10.Text, 2)
        If kfc11.Text = ("") Then kfc(11) = 99999 Else kfc(11) = FormatNumber(kfc11.Text, 2)
        If kfc12.Text = ("") Then kfc(12) = 99999 Else kfc(12) = FormatNumber(kfc12.Text, 2)
        If kfc13.Text = ("") Then kfc(13) = 99999 Else kfc(13) = FormatNumber(kfc13.Text, 2)
        If kfc14.Text = ("") Then kfc(14) = 99999 Else kfc(14) = FormatNumber(kfc14.Text, 2)
        If kfc15.Text = ("") Then kfc(15) = 99999 Else kfc(15) = FormatNumber(kfc15.Text, 2)
        If kfc16.Text = ("") Then kfc(16) = 99999 Else kfc(16) = FormatNumber(kfc16.Text, 2)
        If kfc17.Text = ("") Then kfc(17) = 99999 Else kfc(17) = FormatNumber(kfc17.Text, 2)
        If kfc18.Text = ("") Then kfc(18) = 99999 Else kfc(18) = FormatNumber(kfc18.Text, 2)
        If kfc19.Text = ("") Then kfc(19) = 99999 Else kfc(19) = FormatNumber(kfc19.Text, 2)
        If kfc20.Text = ("") Then kfc(20) = 99999 Else kfc(20) = FormatNumber(kfc20.Text, 2)

        Array.Sort(kfc)

        brkfcova = 0
        sumakfcova = 0
        For brojilo1 = 1 To 20
            If kfc(brojilo1) < 99999 Then brkfcova = brkfcova + 1 Else brkfcova = brkfcova
            If kfc(brojilo1) < 99999 Then sumakfcova = sumakfcova + kfc(brojilo1) Else sumakfcova = sumakfcova
        Next
        If brkfcova = 0 Then GoTo skrozkraj
        'avrgKoefic = FormatNumber(sumakfcova / brkfcova, 2)
        'avrgKfc.Text = avrgKoefic

        dev = 0.20000000000000001

        minkfc = kfc(1)

        Dim T(20)
        T(1) = 1

        If kfc(2) / minkfc > (1 + dev + kfc(2) / 35) Then T(2) = T(1) + 1 Else T(2) = T(1)
        If kfc(2) / minkfc > (1 + dev + kfc(2) / 35) Then minkfc = kfc(2) Else minkfc = minkfc
        If kfc(3) / minkfc > (1 + dev + kfc(3) / 35) Then T(3) = T(2) + 1 Else T(3) = T(2)
        If kfc(3) / minkfc > (1 + dev + kfc(3) / 35) Then minkfc = kfc(3) Else minkfc = minkfc
        If kfc(4) / minkfc > (1 + dev + kfc(4) / 35) Then T(4) = T(3) + 1 Else T(4) = T(3)
        If kfc(4) / minkfc > (1 + dev + kfc(4) / 35) Then minkfc = kfc(4) Else minkfc = minkfc
        If kfc(5) / minkfc > (1 + dev + kfc(5) / 35) Then T(5) = T(4) + 1 Else T(5) = T(4)
        If kfc(5) / minkfc > (1 + dev + kfc(5) / 35) Then minkfc = kfc(5) Else minkfc = minkfc
        If kfc(6) / minkfc > (1 + dev + kfc(6) / 35) Then T(6) = T(5) + 1 Else T(6) = T(5)
        If kfc(6) / minkfc > (1 + dev + kfc(6) / 35) Then minkfc = kfc(6) Else minkfc = minkfc
        If kfc(7) / minkfc > (1 + dev + kfc(7) / 35) Then T(7) = T(6) + 1 Else T(7) = T(6)
        If kfc(7) / minkfc > (1 + dev + kfc(7) / 35) Then minkfc = kfc(7) Else minkfc = minkfc
        If kfc(8) / minkfc > (1 + dev + kfc(8) / 35) Then T(8) = T(7) + 1 Else T(8) = T(7)
        If kfc(8) / minkfc > (1 + dev + kfc(8) / 35) Then minkfc = kfc(8) Else minkfc = minkfc
        If kfc(9) / minkfc > (1 + dev + kfc(9) / 35) Then T(9) = T(8) + 1 Else T(9) = T(8)
        If kfc(9) / minkfc > (1 + dev + kfc(9) / 35) Then minkfc = kfc(9) Else minkfc = minkfc
        If kfc(10) / minkfc > (1 + dev + kfc(10) / 35) Then T(10) = T(9) + 1 Else T(10) = T(9)
        If kfc(10) / minkfc > (1 + dev + kfc(10) / 35) Then minkfc = kfc(10) Else minkfc = minkfc
        If kfc(11) / minkfc > (1 + dev + kfc(11) / 35) Then T(11) = T(10) + 1 Else T(11) = T(10)
        If kfc(11) / minkfc > (1 + dev + kfc(11) / 35) Then minkfc = kfc(11) Else minkfc = minkfc
        If kfc(12) / minkfc > (1 + dev + kfc(12) / 35) Then T(12) = T(11) + 1 Else T(12) = T(11)
        If kfc(12) / minkfc > (1 + dev + kfc(12) / 35) Then minkfc = kfc(12) Else minkfc = minkfc
        If kfc(13) / minkfc > (1 + dev + kfc(13) / 35) Then T(13) = T(12) + 1 Else T(13) = T(12)
        If kfc(13) / minkfc > (1 + dev + kfc(13) / 35) Then minkfc = kfc(13) Else minkfc = minkfc
        If kfc(14) / minkfc > (1 + dev + kfc(14) / 35) Then T(14) = T(13) + 1 Else T(14) = T(13)
        If kfc(14) / minkfc > (1 + dev + kfc(14) / 35) Then minkfc = kfc(14) Else minkfc = minkfc
        If kfc(15) / minkfc > (1 + dev + kfc(15) / 35) Then T(15) = T(14) + 1 Else T(15) = T(14)
        If kfc(15) / minkfc > (1 + dev + kfc(15) / 35) Then minkfc = kfc(15) Else minkfc = minkfc
        If kfc(16) / minkfc > (1 + dev + kfc(16) / 35) Then T(16) = T(15) + 1 Else T(16) = T(15)
        If kfc(16) / minkfc > (1 + dev + kfc(16) / 35) Then minkfc = kfc(16) Else minkfc = minkfc
        If kfc(17) / minkfc > (1 + dev + kfc(17) / 35) Then T(17) = T(16) + 1 Else T(17) = T(16)
        If kfc(17) / minkfc > (1 + dev + kfc(17) / 35) Then minkfc = kfc(17) Else minkfc = minkfc
        If kfc(18) / minkfc > (1 + dev + kfc(18) / 35) Then T(18) = T(17) + 1 Else T(18) = T(17)
        If kfc(18) / minkfc > (1 + dev + kfc(18) / 35) Then minkfc = kfc(18) Else minkfc = minkfc
        If kfc(19) / minkfc > (1 + dev + kfc(19) / 35) Then T(19) = T(18) + 1 Else T(19) = T(18)
        If kfc(19) / minkfc > (1 + dev + kfc(19) / 35) Then minkfc = kfc(19) Else minkfc = minkfc
        If kfc(20) / minkfc > (1 + dev + kfc(20) / 35) Then T(20) = T(19) + 1 Else T(20) = T(19)
        If kfc(20) / minkfc > (1 + dev + kfc(20) / 35) Then minkfc = kfc(20) Else minkfc = minkfc

        If T(2) <> T(1) Then T(2) = T(2) Else If kfc(2) - kfc(1) < kfc(3) - kfc(2) Then T(2) = T(1) Else T(2) = T(3)
        If T(3) <> T(2) Then T(3) = T(3) Else If kfc(3) - kfc(2) < kfc(4) - kfc(3) Then T(3) = T(2) Else T(3) = T(4)
        If T(4) <> T(3) Then T(4) = T(4) Else If kfc(4) - kfc(3) < kfc(5) - kfc(4) Then T(4) = T(3) Else T(4) = T(5)
        If T(5) <> T(4) Then T(5) = T(5) Else If kfc(5) - kfc(4) < kfc(6) - kfc(5) Then T(5) = T(4) Else T(5) = T(6)
        If T(6) <> T(5) Then T(6) = T(6) Else If kfc(6) - kfc(5) < kfc(7) - kfc(6) Then T(6) = T(5) Else T(6) = T(7)
        If T(7) <> T(6) Then T(7) = T(7) Else If kfc(7) - kfc(6) < kfc(8) - kfc(7) Then T(7) = T(6) Else T(7) = T(8)
        If T(8) <> T(7) Then T(8) = T(8) Else If kfc(8) - kfc(7) < kfc(9) - kfc(8) Then T(8) = T(7) Else T(8) = T(9)
        If T(9) <> T(8) Then T(9) = T(9) Else If kfc(9) - kfc(8) < kfc(10) - kfc(9) Then T(9) = T(8) Else T(9) = T(10)
        If T(10) <> T(9) Then T(10) = T(10) Else If kfc(10) - kfc(9) < kfc(11) - kfc(10) Then T(10) = T(9) Else T(10) = T(11)
        If T(11) <> T(10) Then T(11) = T(11) Else If kfc(11) - kfc(10) < kfc(12) - kfc(11) Then T(11) = T(10) Else T(11) = T(12)
        If T(12) <> T(11) Then T(12) = T(12) Else If kfc(12) - kfc(11) < kfc(13) - kfc(12) Then T(12) = T(11) Else T(12) = T(13)
        If T(13) <> T(12) Then T(13) = T(13) Else If kfc(13) - kfc(12) < kfc(14) - kfc(13) Then T(13) = T(12) Else T(13) = T(14)
        If T(14) <> T(13) Then T(14) = T(14) Else If kfc(14) - kfc(13) < kfc(15) - kfc(14) Then T(14) = T(13) Else T(14) = T(15)
        If T(15) <> T(14) Then T(15) = T(15) Else If kfc(15) - kfc(14) < kfc(16) - kfc(15) Then T(15) = T(14) Else T(15) = T(16)
        If T(16) <> T(15) Then T(16) = T(16) Else If kfc(16) - kfc(15) < kfc(17) - kfc(16) Then T(16) = T(15) Else T(16) = T(17)
        If T(17) <> T(16) Then T(17) = T(17) Else If kfc(17) - kfc(16) < kfc(18) - kfc(17) Then T(17) = T(16) Else T(17) = T(18)
        If T(18) <> T(17) Then T(18) = T(18) Else If kfc(18) - kfc(17) < kfc(19) - kfc(18) Then T(18) = T(17) Else T(18) = T(19)
        If T(19) <> T(18) Then T(19) = T(19) Else If kfc(19) - kfc(18) < kfc(20) - kfc(19) Then T(19) = T(18) Else T(19) = T(20)
        If T(20) <> T(19) Then T(20) = T(20) Else If kfc(20) - kfc(19) < 0.5 Then T(20) = T(19) Else T(20) = T(20)


        If T(1) / 2 = Int(T(1) / 2) Then Panel1.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel1.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(2) / 2 = Int(T(2) / 2) Then Panel2.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel2.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(3) / 2 = Int(T(3) / 2) Then Panel3.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel3.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(4) / 2 = Int(T(4) / 2) Then Panel4.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel4.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(5) / 2 = Int(T(5) / 2) Then Panel5.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel5.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(6) / 2 = Int(T(6) / 2) Then Panel6.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel6.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(7) / 2 = Int(T(7) / 2) Then Panel7.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel7.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(8) / 2 = Int(T(8) / 2) Then Panel8.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel8.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(9) / 2 = Int(T(9) / 2) Then Panel9.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel9.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(10) / 2 = Int(T(10) / 2) Then Panel10.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel10.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(11) / 2 = Int(T(11) / 2) Then Panel11.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel11.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(12) / 2 = Int(T(12) / 2) Then Panel12.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel12.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(13) / 2 = Int(T(13) / 2) Then Panel13.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel13.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(14) / 2 = Int(T(14) / 2) Then Panel14.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel14.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(15) / 2 = Int(T(15) / 2) Then Panel15.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel15.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(16) / 2 = Int(T(16) / 2) Then Panel16.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel16.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(17) / 2 = Int(T(17) / 2) Then Panel17.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel17.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(18) / 2 = Int(T(18) / 2) Then Panel18.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel18.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(19) / 2 = Int(T(19) / 2) Then Panel19.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel19.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(20) / 2 = Int(T(20) / 2) Then Panel20.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel20.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(1) / 2 = Int(T(1) / 2) Then Panel21.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel21.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(2) / 2 = Int(T(2) / 2) Then Panel22.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel22.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(3) / 2 = Int(T(3) / 2) Then Panel23.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel23.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(4) / 2 = Int(T(4) / 2) Then Panel24.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel24.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(5) / 2 = Int(T(5) / 2) Then Panel25.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel25.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(6) / 2 = Int(T(6) / 2) Then Panel26.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel26.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(7) / 2 = Int(T(7) / 2) Then Panel27.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel27.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(8) / 2 = Int(T(8) / 2) Then Panel28.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel28.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(9) / 2 = Int(T(9) / 2) Then Panel29.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel29.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(10) / 2 = Int(T(10) / 2) Then Panel30.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel30.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(11) / 2 = Int(T(11) / 2) Then Panel31.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel31.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(12) / 2 = Int(T(12) / 2) Then Panel32.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel32.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(13) / 2 = Int(T(13) / 2) Then Panel33.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel33.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(14) / 2 = Int(T(14) / 2) Then Panel34.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel34.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(15) / 2 = Int(T(15) / 2) Then Panel35.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel35.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(16) / 2 = Int(T(16) / 2) Then Panel36.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel36.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(17) / 2 = Int(T(17) / 2) Then Panel37.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel37.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(18) / 2 = Int(T(18) / 2) Then Panel38.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel38.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(19) / 2 = Int(T(19) / 2) Then Panel39.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel39.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(20) / 2 = Int(T(20) / 2) Then Panel40.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel40.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(1) / 2 = Int(T(1) / 2) Then Panel41.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel41.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(2) / 2 = Int(T(2) / 2) Then Panel42.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel42.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(3) / 2 = Int(T(3) / 2) Then Panel43.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel43.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(4) / 2 = Int(T(4) / 2) Then Panel44.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel44.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(5) / 2 = Int(T(5) / 2) Then Panel45.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel45.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(6) / 2 = Int(T(6) / 2) Then Panel46.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel46.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(7) / 2 = Int(T(7) / 2) Then Panel47.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel47.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(8) / 2 = Int(T(8) / 2) Then Panel48.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel48.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(9) / 2 = Int(T(9) / 2) Then Panel49.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel49.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(10) / 2 = Int(T(10) / 2) Then Panel50.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel50.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(11) / 2 = Int(T(11) / 2) Then Panel51.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel51.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(12) / 2 = Int(T(12) / 2) Then Panel52.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel52.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(13) / 2 = Int(T(13) / 2) Then Panel53.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel53.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(14) / 2 = Int(T(14) / 2) Then Panel54.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel54.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(15) / 2 = Int(T(15) / 2) Then Panel55.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel55.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(16) / 2 = Int(T(16) / 2) Then Panel56.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel56.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(17) / 2 = Int(T(17) / 2) Then Panel57.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel57.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(18) / 2 = Int(T(18) / 2) Then Panel58.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel58.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(19) / 2 = Int(T(19) / 2) Then Panel59.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel59.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(20) / 2 = Int(T(20) / 2) Then Panel60.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel60.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(1) / 2 = Int(T(1) / 2) Then Panel61.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel61.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(2) / 2 = Int(T(2) / 2) Then Panel62.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel62.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(3) / 2 = Int(T(3) / 2) Then Panel63.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel63.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(4) / 2 = Int(T(4) / 2) Then Panel64.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel64.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(5) / 2 = Int(T(5) / 2) Then Panel65.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel65.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(6) / 2 = Int(T(6) / 2) Then Panel66.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel66.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(7) / 2 = Int(T(7) / 2) Then Panel67.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel67.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(8) / 2 = Int(T(8) / 2) Then Panel68.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel68.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(9) / 2 = Int(T(9) / 2) Then Panel69.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel69.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(10) / 2 = Int(T(10) / 2) Then Panel70.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel70.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(11) / 2 = Int(T(11) / 2) Then Panel71.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel71.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(12) / 2 = Int(T(12) / 2) Then Panel72.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel72.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(13) / 2 = Int(T(13) / 2) Then Panel73.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel73.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(14) / 2 = Int(T(14) / 2) Then Panel74.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel74.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(15) / 2 = Int(T(15) / 2) Then Panel75.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel75.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(16) / 2 = Int(T(16) / 2) Then Panel76.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel76.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(17) / 2 = Int(T(17) / 2) Then Panel77.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel77.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(18) / 2 = Int(T(18) / 2) Then Panel78.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel78.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(19) / 2 = Int(T(19) / 2) Then Panel79.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel79.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(20) / 2 = Int(T(20) / 2) Then Panel80.BackColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Panel80.BackColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(1) / 2 = Int(T(1) / 2) Then Labelkfc41.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc41.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(2) / 2 = Int(T(2) / 2) Then Labelkfc42.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc42.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(3) / 2 = Int(T(3) / 2) Then Labelkfc43.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc43.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(4) / 2 = Int(T(4) / 2) Then Labelkfc44.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc44.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(5) / 2 = Int(T(5) / 2) Then Labelkfc45.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc45.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(6) / 2 = Int(T(6) / 2) Then Labelkfc46.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc46.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(7) / 2 = Int(T(7) / 2) Then Labelkfc47.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc47.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(8) / 2 = Int(T(8) / 2) Then Labelkfc48.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc48.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(9) / 2 = Int(T(9) / 2) Then Labelkfc49.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc49.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(10) / 2 = Int(T(10) / 2) Then Labelkfc50.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc50.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(11) / 2 = Int(T(11) / 2) Then Labelkfc51.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc51.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(12) / 2 = Int(T(12) / 2) Then Labelkfc52.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc52.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(13) / 2 = Int(T(13) / 2) Then Labelkfc53.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc53.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(14) / 2 = Int(T(14) / 2) Then Labelkfc54.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc54.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(15) / 2 = Int(T(15) / 2) Then Labelkfc55.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc55.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(16) / 2 = Int(T(16) / 2) Then Labelkfc56.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc56.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(17) / 2 = Int(T(17) / 2) Then Labelkfc57.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc57.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(18) / 2 = Int(T(18) / 2) Then Labelkfc58.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc58.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(19) / 2 = Int(T(19) / 2) Then Labelkfc59.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc59.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")
        If T(20) / 2 = Int(T(20) / 2) Then Labelkfc60.ForeColor = Drawing.ColorTranslator.FromHtml("#E6ECF0") Else Labelkfc60.ForeColor = Drawing.ColorTranslator.FromHtml("#F1FAF4")

        Labelkfc21.Text = T(1)
        Labelkfc22.Text = T(2)
        Labelkfc23.Text = T(3)
        Labelkfc24.Text = T(4)
        Labelkfc25.Text = T(5)
        Labelkfc26.Text = T(6)
        Labelkfc27.Text = T(7)
        Labelkfc28.Text = T(8)
        Labelkfc29.Text = T(9)
        Labelkfc30.Text = T(10)
        Labelkfc31.Text = T(11)
        Labelkfc32.Text = T(12)
        Labelkfc33.Text = T(13)
        Labelkfc34.Text = T(14)
        Labelkfc35.Text = T(15)
        Labelkfc36.Text = T(16)
        Labelkfc37.Text = T(17)
        Labelkfc38.Text = T(18)
        Labelkfc39.Text = T(19)
        Labelkfc40.Text = T(20)

        If kfc(1) < 99999 Then Labelkfc1.Text = kfc(1) Else Labelkfc1.Text = ("")
        If kfc(1) < 99999 Then Labelkfc21.Text = Labelkfc21.Text Else Labelkfc21.Text = ("")
        If kfc(2) < 99999 Then Labelkfc2.Text = kfc(2) Else Labelkfc2.Text = ("")
        If kfc(2) < 99999 Then Labelkfc22.Text = Labelkfc22.Text Else Labelkfc22.Text = ("")
        If kfc(3) < 99999 Then Labelkfc3.Text = kfc(3) Else Labelkfc3.Text = ("")
        If kfc(3) < 99999 Then Labelkfc23.Text = Labelkfc23.Text Else Labelkfc23.Text = ("")
        If kfc(4) < 99999 Then Labelkfc4.Text = kfc(4) Else Labelkfc4.Text = ("")
        If kfc(4) < 99999 Then Labelkfc24.Text = Labelkfc24.Text Else Labelkfc24.Text = ("")
        If kfc(5) < 99999 Then Labelkfc5.Text = kfc(5) Else Labelkfc5.Text = ("")
        If kfc(5) < 99999 Then Labelkfc25.Text = Labelkfc25.Text Else Labelkfc25.Text = ("")
        If kfc(6) < 99999 Then Labelkfc6.Text = kfc(6) Else Labelkfc6.Text = ("")
        If kfc(6) < 99999 Then Labelkfc26.Text = Labelkfc26.Text Else Labelkfc26.Text = ("")
        If kfc(7) < 99999 Then Labelkfc7.Text = kfc(7) Else Labelkfc7.Text = ("")
        If kfc(7) < 99999 Then Labelkfc27.Text = Labelkfc27.Text Else Labelkfc27.Text = ("")
        If kfc(8) < 99999 Then Labelkfc8.Text = kfc(8) Else Labelkfc8.Text = ("")
        If kfc(8) < 99999 Then Labelkfc28.Text = Labelkfc28.Text Else Labelkfc28.Text = ("")
        If kfc(9) < 99999 Then Labelkfc9.Text = kfc(9) Else Labelkfc9.Text = ("")
        If kfc(9) < 99999 Then Labelkfc29.Text = Labelkfc29.Text Else Labelkfc29.Text = ("")
        If kfc(10) < 99999 Then Labelkfc10.Text = kfc(10) Else Labelkfc10.Text = ("")
        If kfc(10) < 99999 Then Labelkfc30.Text = Labelkfc30.Text Else Labelkfc30.Text = ("")
        If kfc(11) < 99999 Then Labelkfc11.Text = kfc(11) Else Labelkfc11.Text = ("")
        If kfc(11) < 99999 Then Labelkfc31.Text = Labelkfc31.Text Else Labelkfc31.Text = ("")
        If kfc(12) < 99999 Then Labelkfc12.Text = kfc(12) Else Labelkfc12.Text = ("")
        If kfc(12) < 99999 Then Labelkfc32.Text = Labelkfc32.Text Else Labelkfc32.Text = ("")
        If kfc(13) < 99999 Then Labelkfc13.Text = kfc(13) Else Labelkfc13.Text = ("")
        If kfc(13) < 99999 Then Labelkfc33.Text = Labelkfc33.Text Else Labelkfc33.Text = ("")
        If kfc(14) < 99999 Then Labelkfc14.Text = kfc(14) Else Labelkfc14.Text = ("")
        If kfc(14) < 99999 Then Labelkfc34.Text = Labelkfc34.Text Else Labelkfc34.Text = ("")
        If kfc(15) < 99999 Then Labelkfc15.Text = kfc(15) Else Labelkfc15.Text = ("")
        If kfc(15) < 99999 Then Labelkfc35.Text = Labelkfc35.Text Else Labelkfc35.Text = ("")
        If kfc(16) < 99999 Then Labelkfc16.Text = kfc(16) Else Labelkfc16.Text = ("")
        If kfc(16) < 99999 Then Labelkfc36.Text = Labelkfc36.Text Else Labelkfc36.Text = ("")
        If kfc(17) < 99999 Then Labelkfc17.Text = kfc(17) Else Labelkfc17.Text = ("")
        If kfc(17) < 99999 Then Labelkfc37.Text = Labelkfc37.Text Else Labelkfc37.Text = ("")
        If kfc(18) < 99999 Then Labelkfc18.Text = kfc(18) Else Labelkfc18.Text = ("")
        If kfc(18) < 99999 Then Labelkfc38.Text = Labelkfc38.Text Else Labelkfc38.Text = ("")
        If kfc(19) < 99999 Then Labelkfc19.Text = kfc(19) Else Labelkfc19.Text = ("")
        If kfc(19) < 99999 Then Labelkfc39.Text = Labelkfc39.Text Else Labelkfc39.Text = ("")
        If kfc(20) < 99999 Then Labelkfc20.Text = kfc(20) Else Labelkfc20.Text = ("")
        If kfc(20) < 99999 Then Labelkfc40.Text = Labelkfc40.Text Else Labelkfc40.Text = ("")


        If Labelkfc1.Text = ("") Then Panel1.BackColor = Drawing.Color.White
        If Labelkfc1.Text = ("") Then Panel21.BackColor = Drawing.Color.White
        If Labelkfc1.Text = ("") Then Panel41.BackColor = Drawing.Color.White
        If Labelkfc1.Text = ("") Then Panel61.BackColor = Drawing.Color.White
        If Labelkfc2.Text = ("") Then Panel2.BackColor = Drawing.Color.White
        If Labelkfc2.Text = ("") Then Panel22.BackColor = Drawing.Color.White
        If Labelkfc2.Text = ("") Then Panel42.BackColor = Drawing.Color.White
        If Labelkfc2.Text = ("") Then Panel62.BackColor = Drawing.Color.White
        If Labelkfc3.Text = ("") Then Panel3.BackColor = Drawing.Color.White
        If Labelkfc3.Text = ("") Then Panel23.BackColor = Drawing.Color.White
        If Labelkfc3.Text = ("") Then Panel43.BackColor = Drawing.Color.White
        If Labelkfc3.Text = ("") Then Panel63.BackColor = Drawing.Color.White
        If Labelkfc4.Text = ("") Then Panel4.BackColor = Drawing.Color.White
        If Labelkfc4.Text = ("") Then Panel24.BackColor = Drawing.Color.White
        If Labelkfc4.Text = ("") Then Panel44.BackColor = Drawing.Color.White
        If Labelkfc4.Text = ("") Then Panel64.BackColor = Drawing.Color.White
        If Labelkfc5.Text = ("") Then Panel5.BackColor = Drawing.Color.White
        If Labelkfc5.Text = ("") Then Panel25.BackColor = Drawing.Color.White
        If Labelkfc5.Text = ("") Then Panel45.BackColor = Drawing.Color.White
        If Labelkfc5.Text = ("") Then Panel65.BackColor = Drawing.Color.White
        If Labelkfc6.Text = ("") Then Panel6.BackColor = Drawing.Color.White
        If Labelkfc6.Text = ("") Then Panel26.BackColor = Drawing.Color.White
        If Labelkfc6.Text = ("") Then Panel46.BackColor = Drawing.Color.White
        If Labelkfc6.Text = ("") Then Panel66.BackColor = Drawing.Color.White
        If Labelkfc7.Text = ("") Then Panel7.BackColor = Drawing.Color.White
        If Labelkfc7.Text = ("") Then Panel27.BackColor = Drawing.Color.White
        If Labelkfc7.Text = ("") Then Panel47.BackColor = Drawing.Color.White
        If Labelkfc7.Text = ("") Then Panel67.BackColor = Drawing.Color.White
        If Labelkfc8.Text = ("") Then Panel8.BackColor = Drawing.Color.White
        If Labelkfc8.Text = ("") Then Panel28.BackColor = Drawing.Color.White
        If Labelkfc8.Text = ("") Then Panel48.BackColor = Drawing.Color.White
        If Labelkfc8.Text = ("") Then Panel68.BackColor = Drawing.Color.White
        If Labelkfc9.Text = ("") Then Panel9.BackColor = Drawing.Color.White
        If Labelkfc9.Text = ("") Then Panel29.BackColor = Drawing.Color.White
        If Labelkfc9.Text = ("") Then Panel49.BackColor = Drawing.Color.White
        If Labelkfc9.Text = ("") Then Panel69.BackColor = Drawing.Color.White
        If Labelkfc10.Text = ("") Then Panel10.BackColor = Drawing.Color.White
        If Labelkfc10.Text = ("") Then Panel30.BackColor = Drawing.Color.White
        If Labelkfc10.Text = ("") Then Panel50.BackColor = Drawing.Color.White
        If Labelkfc10.Text = ("") Then Panel70.BackColor = Drawing.Color.White
        If Labelkfc11.Text = ("") Then Panel11.BackColor = Drawing.Color.White
        If Labelkfc11.Text = ("") Then Panel31.BackColor = Drawing.Color.White
        If Labelkfc11.Text = ("") Then Panel51.BackColor = Drawing.Color.White
        If Labelkfc11.Text = ("") Then Panel71.BackColor = Drawing.Color.White
        If Labelkfc12.Text = ("") Then Panel12.BackColor = Drawing.Color.White
        If Labelkfc12.Text = ("") Then Panel32.BackColor = Drawing.Color.White
        If Labelkfc12.Text = ("") Then Panel52.BackColor = Drawing.Color.White
        If Labelkfc12.Text = ("") Then Panel72.BackColor = Drawing.Color.White
        If Labelkfc13.Text = ("") Then Panel13.BackColor = Drawing.Color.White
        If Labelkfc13.Text = ("") Then Panel33.BackColor = Drawing.Color.White
        If Labelkfc13.Text = ("") Then Panel53.BackColor = Drawing.Color.White
        If Labelkfc13.Text = ("") Then Panel73.BackColor = Drawing.Color.White
        If Labelkfc14.Text = ("") Then Panel14.BackColor = Drawing.Color.White
        If Labelkfc14.Text = ("") Then Panel34.BackColor = Drawing.Color.White
        If Labelkfc14.Text = ("") Then Panel54.BackColor = Drawing.Color.White
        If Labelkfc14.Text = ("") Then Panel74.BackColor = Drawing.Color.White
        If Labelkfc15.Text = ("") Then Panel15.BackColor = Drawing.Color.White
        If Labelkfc15.Text = ("") Then Panel35.BackColor = Drawing.Color.White
        If Labelkfc15.Text = ("") Then Panel55.BackColor = Drawing.Color.White
        If Labelkfc15.Text = ("") Then Panel75.BackColor = Drawing.Color.White
        If Labelkfc16.Text = ("") Then Panel16.BackColor = Drawing.Color.White
        If Labelkfc16.Text = ("") Then Panel36.BackColor = Drawing.Color.White
        If Labelkfc16.Text = ("") Then Panel56.BackColor = Drawing.Color.White
        If Labelkfc16.Text = ("") Then Panel76.BackColor = Drawing.Color.White
        If Labelkfc17.Text = ("") Then Panel17.BackColor = Drawing.Color.White
        If Labelkfc17.Text = ("") Then Panel37.BackColor = Drawing.Color.White
        If Labelkfc17.Text = ("") Then Panel57.BackColor = Drawing.Color.White
        If Labelkfc17.Text = ("") Then Panel77.BackColor = Drawing.Color.White
        If Labelkfc18.Text = ("") Then Panel18.BackColor = Drawing.Color.White
        If Labelkfc18.Text = ("") Then Panel38.BackColor = Drawing.Color.White
        If Labelkfc18.Text = ("") Then Panel58.BackColor = Drawing.Color.White
        If Labelkfc18.Text = ("") Then Panel78.BackColor = Drawing.Color.White
        If Labelkfc19.Text = ("") Then Panel19.BackColor = Drawing.Color.White
        If Labelkfc19.Text = ("") Then Panel39.BackColor = Drawing.Color.White
        If Labelkfc19.Text = ("") Then Panel59.BackColor = Drawing.Color.White
        If Labelkfc19.Text = ("") Then Panel79.BackColor = Drawing.Color.White
        If Labelkfc20.Text = ("") Then Panel20.BackColor = Drawing.Color.White
        If Labelkfc20.Text = ("") Then Panel40.BackColor = Drawing.Color.White
        If Labelkfc20.Text = ("") Then Panel60.BackColor = Drawing.Color.White
        If Labelkfc20.Text = ("") Then Panel80.BackColor = Drawing.Color.White

        'brojilo za sumu koeficijenata na pojedinom Ticketu
        For brojilo3 = 1 To 20
            sumKfcTick(brojilo3) = 0
            brParTick(brojilo3) = 0
        Next
        'ovo nulira broj parova i sumu koeficijenata

        'a ovo ih prebrojava i zbraja
        For brojilo2 = 1 To brkfcova
            If T(brojilo2) = 1 Then brParTick(1) = brParTick(1) + 1 Else brParTick(1) = brParTick(1)
            If T(brojilo2) = 1 Then sumKfcTick(1) = sumKfcTick(1) + kfc(brojilo2)
            If T(brojilo2) = 2 Then brParTick(2) = brParTick(2) + 1 Else brParTick(2) = brParTick(2)
            If T(brojilo2) = 2 Then sumKfcTick(2) = sumKfcTick(2) + kfc(brojilo2)
            If T(brojilo2) = 3 Then brParTick(3) = brParTick(3) + 1 Else brParTick(3) = brParTick(3)
            If T(brojilo2) = 3 Then sumKfcTick(3) = sumKfcTick(3) + kfc(brojilo2)
            If T(brojilo2) = 4 Then brParTick(4) = brParTick(4) + 1 Else brParTick(4) = brParTick(4)
            If T(brojilo2) = 4 Then sumKfcTick(4) = sumKfcTick(4) + kfc(brojilo2)
            If T(brojilo2) = 5 Then brParTick(5) = brParTick(5) + 1 Else brParTick(5) = brParTick(5)
            If T(brojilo2) = 5 Then sumKfcTick(5) = sumKfcTick(5) + kfc(brojilo2)
            If T(brojilo2) = 6 Then brParTick(6) = brParTick(6) + 1 Else brParTick(6) = brParTick(6)
            If T(brojilo2) = 6 Then sumKfcTick(6) = sumKfcTick(6) + kfc(brojilo2)
            If T(brojilo2) = 7 Then brParTick(7) = brParTick(7) + 1 Else brParTick(7) = brParTick(7)
            If T(brojilo2) = 7 Then sumKfcTick(7) = sumKfcTick(7) + kfc(brojilo2)
            If T(brojilo2) = 8 Then brParTick(8) = brParTick(8) + 1 Else brParTick(8) = brParTick(8)
            If T(brojilo2) = 8 Then sumKfcTick(8) = sumKfcTick(8) + kfc(brojilo2)
            If T(brojilo2) = 9 Then brParTick(9) = brParTick(9) + 1 Else brParTick(9) = brParTick(9)
            If T(brojilo2) = 9 Then sumKfcTick(9) = sumKfcTick(9) + kfc(brojilo2)
            If T(brojilo2) = 10 Then brParTick(10) = brParTick(10) + 1 Else brParTick(10) = brParTick(10)
            If T(brojilo2) = 10 Then sumKfcTick(10) = sumKfcTick(10) + kfc(brojilo2)
            If T(brojilo2) = 11 Then brParTick(11) = brParTick(11) + 1 Else brParTick(11) = brParTick(11)
            If T(brojilo2) = 11 Then sumKfcTick(11) = sumKfcTick(11) + kfc(brojilo2)
            If T(brojilo2) = 12 Then brParTick(12) = brParTick(12) + 1 Else brParTick(12) = brParTick(12)
            If T(brojilo2) = 12 Then sumKfcTick(12) = sumKfcTick(12) + kfc(brojilo2)
            If T(brojilo2) = 13 Then brParTick(13) = brParTick(13) + 1 Else brParTick(13) = brParTick(13)
            If T(brojilo2) = 13 Then sumKfcTick(13) = sumKfcTick(13) + kfc(brojilo2)
            If T(brojilo2) = 14 Then brParTick(14) = brParTick(14) + 1 Else brParTick(14) = brParTick(14)
            If T(brojilo2) = 14 Then sumKfcTick(14) = sumKfcTick(14) + kfc(brojilo2)
            If T(brojilo2) = 15 Then brParTick(15) = brParTick(15) + 1 Else brParTick(15) = brParTick(15)
            If T(brojilo2) = 15 Then sumKfcTick(15) = sumKfcTick(15) + kfc(brojilo2)
            If T(brojilo2) = 16 Then brParTick(16) = brParTick(16) + 1 Else brParTick(16) = brParTick(16)
            If T(brojilo2) = 16 Then sumKfcTick(16) = sumKfcTick(16) + kfc(brojilo2)
            If T(brojilo2) = 17 Then brParTick(17) = brParTick(17) + 1 Else brParTick(17) = brParTick(17)
            If T(brojilo2) = 17 Then sumKfcTick(17) = sumKfcTick(17) + kfc(brojilo2)
            If T(brojilo2) = 18 Then brParTick(18) = brParTick(18) + 1 Else brParTick(18) = brParTick(18)
            If T(brojilo2) = 18 Then sumKfcTick(18) = sumKfcTick(18) + kfc(brojilo2)
            If T(brojilo2) = 19 Then brParTick(19) = brParTick(19) + 1 Else brParTick(19) = brParTick(19)
            If T(brojilo2) = 19 Then sumKfcTick(19) = sumKfcTick(19) + kfc(brojilo2)
            If T(brojilo2) = 20 Then brParTick(20) = brParTick(20) + 1 Else brParTick(20) = brParTick(20)
            If T(brojilo2) = 20 Then sumKfcTick(20) = sumKfcTick(20) + kfc(brojilo2)
        Next

        'ovo nulira prosijek..
        Dim avrgKfcTick(20)
        For brojilo5 = 1 To 20
            avrgKfcTick(brojilo5) = 0
        Next

        'a ovo vadi prosijek..
        For brojilo4 = 1 To brkfcova
            avrgKfcTick(brojilo4) = FormatNumber(sumKfcTick(brojilo4) / brParTick(brojilo4), 2)
        Next

        nextticket = 1

        If T(2) = T(1) Then Labelkfc41.Text = ("") Else Labelkfc41.Text = avrgKfcTick(nextticket)
        If T(2) = T(1) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(3) = T(2) Then Labelkfc42.Text = ("") Else Labelkfc42.Text = avrgKfcTick(nextticket)
        If T(3) = T(2) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(4) = T(3) Then Labelkfc43.Text = ("") Else Labelkfc43.Text = avrgKfcTick(nextticket)
        If T(4) = T(3) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(5) = T(4) Then Labelkfc44.Text = ("") Else Labelkfc44.Text = avrgKfcTick(nextticket)
        If T(5) = T(4) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(6) = T(5) Then Labelkfc45.Text = ("") Else Labelkfc45.Text = avrgKfcTick(nextticket)
        If T(6) = T(5) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(7) = T(6) Then Labelkfc46.Text = ("") Else Labelkfc46.Text = avrgKfcTick(nextticket)
        If T(7) = T(6) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(8) = T(7) Then Labelkfc47.Text = ("") Else Labelkfc47.Text = avrgKfcTick(nextticket)
        If T(8) = T(7) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(9) = T(8) Then Labelkfc48.Text = ("") Else Labelkfc48.Text = avrgKfcTick(nextticket)
        If T(9) = T(8) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(10) = T(9) Then Labelkfc49.Text = ("") Else Labelkfc49.Text = avrgKfcTick(nextticket)
        If T(10) = T(9) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(11) = T(10) Then Labelkfc50.Text = ("") Else Labelkfc50.Text = avrgKfcTick(nextticket)
        If T(11) = T(10) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(12) = T(11) Then Labelkfc51.Text = ("") Else Labelkfc51.Text = avrgKfcTick(nextticket)
        If T(12) = T(11) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(13) = T(12) Then Labelkfc52.Text = ("") Else Labelkfc52.Text = avrgKfcTick(nextticket)
        If T(13) = T(12) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(14) = T(13) Then Labelkfc53.Text = ("") Else Labelkfc53.Text = avrgKfcTick(nextticket)
        If T(14) = T(13) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(15) = T(14) Then Labelkfc54.Text = ("") Else Labelkfc54.Text = avrgKfcTick(nextticket)
        If T(15) = T(14) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(16) = T(15) Then Labelkfc55.Text = ("") Else Labelkfc55.Text = avrgKfcTick(nextticket)
        If T(16) = T(15) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(17) = T(16) Then Labelkfc56.Text = ("") Else Labelkfc56.Text = avrgKfcTick(nextticket)
        If T(17) = T(16) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(18) = T(17) Then Labelkfc57.Text = ("") Else Labelkfc57.Text = avrgKfcTick(nextticket)
        If T(18) = T(17) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(19) = T(18) Then Labelkfc58.Text = ("") Else Labelkfc58.Text = avrgKfcTick(nextticket)
        If T(19) = T(18) Then nextticket = nextticket Else nextticket = nextticket + 1
        If T(20) = T(19) Then Labelkfc59.Text = ("") Else Labelkfc59.Text = avrgKfcTick(nextticket)
        If T(20) = T(19) Then nextticket = nextticket Else nextticket = nextticket + 1
        If kfc20.Text = ("") Then Labelkfc60.Text = ("") Else Labelkfc60.Text = avrgKfcTick(nextticket)
        '-----------------------------------------------

        If Labelkfc41.Text = ("") Then Ticket1.Visible = False Else Ticket1.Visible = True
        If Labelkfc42.Text = ("") Then Ticket2.Visible = False Else Ticket2.Visible = True
        If Labelkfc43.Text = ("") Then Ticket3.Visible = False Else Ticket3.Visible = True
        If Labelkfc44.Text = ("") Then Ticket4.Visible = False Else Ticket4.Visible = True
        If Labelkfc45.Text = ("") Then Ticket5.Visible = False Else Ticket5.Visible = True
        If Labelkfc46.Text = ("") Then Ticket6.Visible = False Else Ticket6.Visible = True
        If Labelkfc47.Text = ("") Then Ticket7.Visible = False Else Ticket7.Visible = True
        If Labelkfc48.Text = ("") Then Ticket8.Visible = False Else Ticket8.Visible = True
        If Labelkfc49.Text = ("") Then Ticket9.Visible = False Else Ticket9.Visible = True
        If Labelkfc50.Text = ("") Then Ticket10.Visible = False Else Ticket10.Visible = True
        If Labelkfc51.Text = ("") Then Ticket11.Visible = False Else Ticket11.Visible = True
        If Labelkfc52.Text = ("") Then Ticket12.Visible = False Else Ticket12.Visible = True
        If Labelkfc53.Text = ("") Then Ticket13.Visible = False Else Ticket13.Visible = True
        If Labelkfc54.Text = ("") Then Ticket14.Visible = False Else Ticket14.Visible = True
        If Labelkfc55.Text = ("") Then Ticket15.Visible = False Else Ticket15.Visible = True
        If Labelkfc56.Text = ("") Then Ticket16.Visible = False Else Ticket16.Visible = True
        If Labelkfc57.Text = ("") Then Ticket17.Visible = False Else Ticket17.Visible = True
        If Labelkfc58.Text = ("") Then Ticket18.Visible = False Else Ticket18.Visible = True
        If Labelkfc59.Text = ("") Then Ticket19.Visible = False Else Ticket19.Visible = True
        If Labelkfc60.Text = ("") Then Ticket20.Visible = False Else Ticket20.Visible = True

        If Ticket1.Visible = True Then Labelkfc61.Text = brParTick(Labelkfc21.Text) Else Labelkfc61.Text = ("")
        If Ticket2.Visible = True Then Labelkfc62.Text = brParTick(Labelkfc22.Text) Else Labelkfc62.Text = ("")
        If Ticket3.Visible = True Then Labelkfc63.Text = brParTick(Labelkfc23.Text) Else Labelkfc63.Text = ("")
        If Ticket4.Visible = True Then Labelkfc64.Text = brParTick(Labelkfc24.Text) Else Labelkfc64.Text = ("")
        If Ticket5.Visible = True Then Labelkfc65.Text = brParTick(Labelkfc25.Text) Else Labelkfc65.Text = ("")
        If Ticket6.Visible = True Then Labelkfc66.Text = brParTick(Labelkfc26.Text) Else Labelkfc66.Text = ("")
        If Ticket7.Visible = True Then Labelkfc67.Text = brParTick(Labelkfc27.Text) Else Labelkfc67.Text = ("")
        If Ticket8.Visible = True Then Labelkfc68.Text = brParTick(Labelkfc28.Text) Else Labelkfc68.Text = ("")
        If Ticket9.Visible = True Then Labelkfc69.Text = brParTick(Labelkfc29.Text) Else Labelkfc69.Text = ("")
        If Ticket10.Visible = True Then Labelkfc70.Text = brParTick(Labelkfc30.Text) Else Labelkfc70.Text = ("")
        If Ticket11.Visible = True Then Labelkfc71.Text = brParTick(Labelkfc31.Text) Else Labelkfc71.Text = ("")
        If Ticket12.Visible = True Then Labelkfc72.Text = brParTick(Labelkfc32.Text) Else Labelkfc72.Text = ("")
        If Ticket13.Visible = True Then Labelkfc73.Text = brParTick(Labelkfc33.Text) Else Labelkfc73.Text = ("")
        If Ticket14.Visible = True Then Labelkfc74.Text = brParTick(Labelkfc34.Text) Else Labelkfc74.Text = ("")
        If Ticket15.Visible = True Then Labelkfc75.Text = brParTick(Labelkfc35.Text) Else Labelkfc75.Text = ("")
        If Ticket16.Visible = True Then Labelkfc76.Text = brParTick(Labelkfc36.Text) Else Labelkfc76.Text = ("")
        If Ticket17.Visible = True Then Labelkfc77.Text = brParTick(Labelkfc37.Text) Else Labelkfc77.Text = ("")
        If Ticket18.Visible = True Then Labelkfc78.Text = brParTick(Labelkfc38.Text) Else Labelkfc78.Text = ("")
        If Ticket19.Visible = True Then Labelkfc79.Text = brParTick(Labelkfc39.Text) Else Labelkfc79.Text = ("")
        If Ticket20.Visible = True Then Labelkfc80.Text = brParTick(Labelkfc40.Text) Else Labelkfc80.Text = ("")


skrozkraj:
    End Sub

    Protected Sub Ticket1_Click(sender As Object, e As EventArgs) Handles Ticket1.Click
        If Labelkfc41.Text <> ("") Then Session("myVariable1") = Labelkfc61.Text
        If Labelkfc41.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc41.Text, 2)
        If Labelkfc41.Text <> ("") Then Session("myVariable3") = Labelkfc41.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket2_Click(sender As Object, e As EventArgs) Handles Ticket2.Click
        If Labelkfc42.Text <> ("") Then Session("myVariable1") = Labelkfc62.Text
        If Labelkfc42.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc42.Text, 2)
        If Labelkfc42.Text <> ("") Then Session("myVariable3") = Labelkfc42.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket3_Click(sender As Object, e As EventArgs) Handles Ticket3.Click
        If Labelkfc43.Text <> ("") Then Session("myVariable1") = Labelkfc63.Text
        If Labelkfc43.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc43.Text, 2)
        If Labelkfc43.Text <> ("") Then Session("myVariable3") = Labelkfc43.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket4_Click(sender As Object, e As EventArgs) Handles Ticket4.Click
        If Labelkfc44.Text <> ("") Then Session("myVariable1") = Labelkfc64.Text
        If Labelkfc44.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc44.Text, 2)
        If Labelkfc44.Text <> ("") Then Session("myVariable3") = Labelkfc44.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket5_Click(sender As Object, e As EventArgs) Handles Ticket5.Click
        If Labelkfc45.Text <> ("") Then Session("myVariable1") = Labelkfc65.Text
        If Labelkfc45.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc45.Text, 2)
        If Labelkfc45.Text <> ("") Then Session("myVariable3") = Labelkfc45.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket6_Click(sender As Object, e As EventArgs) Handles Ticket6.Click
        If Labelkfc46.Text <> ("") Then Session("myVariable1") = Labelkfc66.Text
        If Labelkfc46.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc46.Text, 2)
        If Labelkfc46.Text <> ("") Then Session("myVariable3") = Labelkfc46.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket7_Click(sender As Object, e As EventArgs) Handles Ticket7.Click
        If Labelkfc47.Text <> ("") Then Session("myVariable1") = Labelkfc67.Text
        If Labelkfc47.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc47.Text, 2)
        If Labelkfc47.Text <> ("") Then Session("myVariable3") = Labelkfc47.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket8_Click(sender As Object, e As EventArgs) Handles Ticket8.Click
        If Labelkfc48.Text <> ("") Then Session("myVariable1") = Labelkfc68.Text
        If Labelkfc48.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc48.Text, 2)
        If Labelkfc48.Text <> ("") Then Session("myVariable3") = Labelkfc48.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket9_Click(sender As Object, e As EventArgs) Handles Ticket9.Click
        If Labelkfc49.Text <> ("") Then Session("myVariable1") = Labelkfc69.Text
        If Labelkfc49.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc49.Text, 2)
        If Labelkfc49.Text <> ("") Then Session("myVariable3") = Labelkfc49.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket10_Click(sender As Object, e As EventArgs) Handles Ticket10.Click
        If Labelkfc50.Text <> ("") Then Session("myVariable1") = Labelkfc70.Text
        If Labelkfc50.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc50.Text, 2)
        If Labelkfc50.Text <> ("") Then Session("myVariable3") = Labelkfc50.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub


    Protected Sub Ticket11_Click(sender As Object, e As EventArgs) Handles Ticket11.Click
        If Labelkfc51.Text <> ("") Then Session("myVariable1") = Labelkfc71.Text
        If Labelkfc51.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc51.Text, 2)
        If Labelkfc51.Text <> ("") Then Session("myVariable3") = Labelkfc51.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket12_Click(sender As Object, e As EventArgs) Handles Ticket12.Click
        If Labelkfc52.Text <> ("") Then Session("myVariable1") = Labelkfc72.Text
        If Labelkfc52.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc52.Text, 2)
        If Labelkfc52.Text <> ("") Then Session("myVariable3") = Labelkfc52.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket13_Click(sender As Object, e As EventArgs) Handles Ticket13.Click
        If Labelkfc53.Text <> ("") Then Session("myVariable1") = Labelkfc73.Text
        If Labelkfc53.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc53.Text, 2)
        If Labelkfc53.Text <> ("") Then Session("myVariable3") = Labelkfc53.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket14_Click(sender As Object, e As EventArgs) Handles Ticket15.Click
        If Labelkfc54.Text <> ("") Then Session("myVariable1") = Labelkfc74.Text
        If Labelkfc54.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc54.Text, 2)
        If Labelkfc54.Text <> ("") Then Session("myVariable3") = Labelkfc54.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket15_Click(sender As Object, e As EventArgs) Handles Ticket15.Click
        If Labelkfc55.Text <> ("") Then Session("myVariable1") = Labelkfc75.Text
        If Labelkfc55.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc55.Text, 2)
        If Labelkfc55.Text <> ("") Then Session("myVariable3") = Labelkfc55.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket16_Click(sender As Object, e As EventArgs) Handles Ticket16.Click
        If Labelkfc56.Text <> ("") Then Session("myVariable1") = Labelkfc76.Text
        If Labelkfc56.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc56.Text, 2)
        If Labelkfc56.Text <> ("") Then Session("myVariable3") = Labelkfc56.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket17_Click(sender As Object, e As EventArgs) Handles Ticket17.Click
        If Labelkfc57.Text <> ("") Then Session("myVariable1") = Labelkfc77.Text
        If Labelkfc57.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc57.Text, 2)
        If Labelkfc57.Text <> ("") Then Session("myVariable3") = Labelkfc57.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket18_Click(sender As Object, e As EventArgs) Handles Ticket18.Click
        If Labelkfc58.Text <> ("") Then Session("myVariable1") = Labelkfc78.Text
        If Labelkfc58.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc58.Text, 2)
        If Labelkfc58.Text <> ("") Then Session("myVariable3") = Labelkfc58.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket19_Click(sender As Object, e As EventArgs) Handles Ticket19.Click
        If Labelkfc59.Text <> ("") Then Session("myVariable1") = Labelkfc79.Text
        If Labelkfc59.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc59.Text, 2)
        If Labelkfc59.Text <> ("") Then Session("myVariable3") = Labelkfc59.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

    Protected Sub Ticket20_Click(sender As Object, e As EventArgs) Handles Ticket20.Click
        If Labelkfc60.Text <> ("") Then Session("myVariable1") = Labelkfc80.Text
        If Labelkfc60.Text <> ("") Then Session("myVariable2") = FormatNumber(100 / Labelkfc60.Text, 2)
        If Labelkfc60.Text <> ("") Then Session("myVariable3") = Labelkfc60.Text
        ClientScript.RegisterStartupScript(Me.GetType(), "open", script, True)
    End Sub

End Class