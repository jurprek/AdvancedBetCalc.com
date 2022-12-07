Imports System.Numerics

Public Class BvPoisson
    Inherits System.Web.UI.Page

    Dim PoN2, PoN1, TmpHndcp, maxProbPoena, maxSumaPoena, BrojPoena1, BrojPoena2, DoMene, DoMeneTemp, bip1brojilo, bip2brojilo, zbrojiodds, Poeni1MZbrajalo, Poeni2MZbrajalo, ManjiBrojPoena, Kombinacija As Decimal

    Protected Sub ThetaPoisson_TextChanged(sender As Object, e As EventArgs) Handles ThetaPoisson.TextChanged

    End Sub

    Dim brojilorecalca, potthetamnozitelj, thetamnozitelj, PoissB1, PoissB2, PoissB3, PoissB4, PoissB5, PoissA1, PoissA2, PoissA3, PoissA4, PoissA5, PoissSumL5Y, PoissSumL5X, PoissL5Y1, PoissL5Y2, PoissL5Y3, PoissL5Y4, PoissL5Y5, PoissL5X1, PoissL5X2, PoissL5X3, PoissL5X4, PoissL5X5, PoissonTempAm, PoisL5Kom As Decimal
    Dim Newline, TmpOddsKfc As String
    Dim Odds(40602) As BigInteger
    Dim exitodds(40602)


    Public Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles CalcPoisson.Click

        If Home.Text > Away.Text Then DoMeneTemp = Home.Text Else DoMeneTemp = Away.Text
        If DoMeneTemp < 5 Then DoMene = 10 Else If DoMeneTemp < 25 Then DoMene = Int(DoMeneTemp * 2) Else If DoMeneTemp < 35 Then DoMene = Int(DoMeneTemp * 1.5) Else If DoMeneTemp < 70 Then DoMene = Int(DoMeneTemp * 1.3300000000000001) Else If DoMeneTemp < 120 Then DoMene = 150 Else DoMene = 180
        If DoMeneTemp < 50 Then thetamnozitelj = 10000 Else thetamnozitelj = 10
        If DoMeneTemp < 50 Then potthetamnozitelj = 4 Else potthetamnozitelj = 1
        zajebDoMene.Text = DoMene

        If upitBP.Text > Int(upitBP.Text) Then upitBP.Text = FormatNumber(Int(upitBP.Text) + 0.5, 2)
        If Hndcp.Text > Int(Hndcp.Text) Then Hndcp.Text = FormatNumber(Int(Hndcp.Text) + 0.5, 2)

        Dim ZbrajaloFBI = BigInteger.Parse("1")
        Dim ZbrajaloBI = BigInteger.Parse("1")
        Dim ThetaPoissonBI = BigInteger.Parse("1")
        Dim ThetaPoissonBItemp = BigInteger.Parse("1")
        Dim Poeni1BI = BigInteger.Parse("1")
        Dim Poeni2BI = BigInteger.Parse("1")
        Dim Poeni1MZbrajaloBI = BigInteger.Parse("1")
        Dim Poeni2MZbrajaloBI = BigInteger.Parse("1")
        Dim HomeBIP = BigInteger.Parse("1")
        Dim AwayBIP = BigInteger.Parse("1")

        Dim brojiloP1mZBI = BigInteger.Parse("1")
        Dim brojiloP2mZBI = BigInteger.Parse("1")
        Dim tmprHomeBI = BigInteger.Parse("1")
        Dim tmprAwayBI = BigInteger.Parse("1")

        Dim HomeBI = BigInteger.Parse("1")
        Dim AwayBI = BigInteger.Parse("1")
        ThetaPoissonBI = ThetaPoisson.Text * 1000000000000000000
        ThetaPoissonBItemp = ThetaPoisson.Text * 1000000000000000000
        HomeBI = Home.Text * thetamnozitelj
        AwayBI = Away.Text * thetamnozitelj

        Poeni1MZbrajalo = 1
        Poeni2MZbrajalo = 1
        BrojPoena1 = 0
        BrojPoena2 = 0

        Kombinacija = DoMene + 1

        For nuliranjeOddsa = 0 To 40602
            Odds(nuliranjeOddsa) = 0
        Next nuliranjeOddsa

        Dim MathExpHome As String                                              '  MathExpHomeBI 
        MathExpHome = Convert.ToString(Math.Exp(-Home.Text))
        MathExpHome = MathExpHome * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000
        Dim MathExpHomeBI = BigInteger.Parse("1")
        MathExpHomeBI = MathExpHome

        Dim MathExpAway As String                                              '  MathExpAwayBI 
        MathExpAway = Convert.ToString(Math.Exp(-Away.Text))
        MathExpAway = MathExpAway * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000 * 1000000000000000000
        Dim MathExpAwayBI = BigInteger.Parse("1")
        MathExpAwayBI = MathExpAway

        Dim MathExpThetaPoisson As String                                      '  MathExpThetaPoissonBI 
        MathExpThetaPoisson = Convert.ToString(Math.Exp(-ThetaPoisson.Text))
        MathExpThetaPoisson = MathExpThetaPoisson * 1000000000000000000 * 1000000000000000000
        Dim MathExpThetaPoissonBI = BigInteger.Parse("1")
        MathExpThetaPoissonBI = MathExpThetaPoisson

        For Poeni2 = 0 To DoMene 'prebrojava Poene Domacina
            Poeni2BI = Poeni2
            For Poeni1 = 0 To DoMene 'prebrojava Poene Gosta
                Poeni1BI = Poeni1

                If Poeni1 < Poeni2 Then ManjiBrojPoena = Poeni1 Else ManjiBrojPoena = Poeni2 'pronalazi manji broj poena izmedu domacih igostujucih..

                For Zbrajalo = 0 To DoMene 'brojilo koje zbraja sve segmente BiVariatePoissona (za sad samo "nulti" stupac od njih dvjesto)
                    ZbrajaloBI = Zbrajalo
                    If Zbrajalo = 0 Then ZbrajaloFBI = 1 Else ZbrajaloFBI = ZbrajaloFBI * ZbrajaloBI 'faktorijele od 0! do 10!

                    If Zbrajalo = 0 Then ThetaPoissonBItemp = ThetaPoisson.Text * 1000000000000000000
                    If Zbrajalo = 0 Then ThetaPoissonBI = 1000000000000000000 Else If Zbrajalo = 1 Then ThetaPoissonBI = ThetaPoissonBItemp Else ThetaPoissonBI = ThetaPoissonBI * ThetaPoissonBItemp / 1000000000000000000 '(ThetaPoissonBI) ^ Zbrajalo 

                    If ManjiBrojPoena < Zbrajalo Then GoTo NextZbrajalo

                    For brojiloP1mZ = 0 To (Poeni1 - Zbrajalo) 'faktorijele (Poeni1-zbrajalo)
                        brojiloP1mZBI = brojiloP1mZ
                        If brojiloP1mZ = 0 Then Poeni1MZbrajaloBI = 1 Else Poeni1MZbrajaloBI = Poeni1MZbrajaloBI * brojiloP1mZBI
                    Next brojiloP1mZ

                    For brojiloP2mZ = 0 To (Poeni2 - Zbrajalo) 'faktorijele (Poeni2-zbrajalo)
                        brojiloP2mZBI = brojiloP2mZ
                        If brojiloP2mZ = 0 Then Poeni2MZbrajaloBI = 1 Else Poeni2MZbrajaloBI = Poeni2MZbrajaloBI * brojiloP2mZBI
                    Next brojiloP2mZ

                    tmprHomeBI = BigInteger.Pow(HomeBI, (Poeni1 - Zbrajalo))
                    tmprHomeBI = tmprHomeBI
                    tmprAwayBI = BigInteger.Pow(AwayBI, (Poeni2 - Zbrajalo))
                    tmprAwayBI = tmprAwayBI

                    '                                                                                                                           Bivariate Poisson jednadzba:                                                                                                                   
NextZbrajalo:       If ManjiBrojPoena < Zbrajalo Then Odds(Zbrajalo) = Odds(Kombinacija) Else Odds(Zbrajalo) = Odds(Kombinacija) + (MathExpThetaPoissonBI * ThetaPoissonBI * MathExpHomeBI * tmprHomeBI * MathExpAwayBI * tmprAwayBI / (10 ^ (potthetamnozitelj * (Poeni1 - Zbrajalo))) / (10 ^ (potthetamnozitelj * (Poeni2 - Zbrajalo))) / 1000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000000 / 1000000000000000 / (ZbrajaloFBI * Poeni1MZbrajaloBI * Poeni2MZbrajaloBI)) 'Bivariate Poisson jednadzba
                    '                                 Math.Exp(-ThetaPoisson.Text) * (ThetaPoisson.Text) ^ 0        / 1         * Math.Exp(-Home.Text) * Home.Text ^ (2      -        0) * Math.Exp(-Away.Text) * Away.Text ^ (2      -        0) / (2               *               2)
                    Odds(Kombinacija) = Odds(Zbrajalo)

                Next Zbrajalo

nextKomb:       Kombinacija = Kombinacija + 1

                For nuliranjeOddsa = 0 To DoMene 'nulira zbrajalo nakon svakog ciklusa
                    Odds(nuliranjeOddsa) = 0
                Next nuliranjeOddsa

            Next Poeni1
        Next Poeni2
        '_____________________________________

        Dim zbrojkontrola As String
        zbrojkontrola = 0
        For kontrolbrojilo = (DoMene + 1) To ((DoMene + 1) ^ 2 + DoMene)
            Dim kontrola As String
            kontrola = Convert.ToString(Odds(kontrolbrojilo))
            zbrojkontrola = kontrola / 1 + zbrojkontrola
        Next kontrolbrojilo
        suma1.Text = 1000000000000 / zbrojkontrola

endcalc:
        Call RecalculatePoisson()
        TextBoxMsg3.Visible = True

    End Sub

    Public Sub RecalculatePoisson()

        '___Pribraja sanse radi izracuna kfc.-a: +/- ; Tip1X2 ; </>

        TmpHndcp = Hndcp.Text
        Dim UpitoPoenima1 = BigInteger.Parse("1")
        Dim UpitoPoenimaX = BigInteger.Parse("1")
        Dim UpitoPoenima2 = BigInteger.Parse("1")
        Dim UpitoHndcp1 = BigInteger.Parse("1")
        Dim UpitoHndcpX = BigInteger.Parse("1")
        Dim UpitoHndcp2 = BigInteger.Parse("1")
        Dim KFCTIP1 = BigInteger.Parse("1")
        Dim KFCTIP2 = BigInteger.Parse("1")
        Dim KFCTIPX = BigInteger.Parse("1")
        Dim AltPoN1 = BigInteger.Parse("1")
        Dim AltPoN2 = BigInteger.Parse("1")
        Dim AltPoNX = BigInteger.Parse("1")

        UpitoPoenima1 = 0
        UpitoPoenimaX = 0
        UpitoPoenima2 = 0
        UpitoHndcp1 = 0
        UpitoHndcpX = 0
        UpitoHndcp2 = 0
        KFCTIP1 = 0
        KFCTIP2 = 0
        KFCTIPX = 0
        AltPoN1 = 0
        AltPoN2 = 0
        AltPoNX = 0

        brojilorecalca = (brojrclc.Text * 10 + 10) / 10
        brojrclc.Text = brojilorecalca
        If brojilorecalca > 1.5 Then GoTo skipKFCTIP

        For wm = 0 To ((DoMene + 1) ^ 2) - 1
            PoN2 = Int(wm / (DoMene + 1))
            PoN1 = Int(((wm / (DoMene + 1) - PoN2) * DoMene + 0.999))

            If PoN1 < PoN2 Then AltPoN2 = AltPoN2 + Odds(wm + (DoMene + 1))
            If PoN1 = PoN2 Then AltPoNX = AltPoNX + Odds(wm + (DoMene + 1))
            'Racuna koeficijente (pribraja segmente po rezultatima..)
        Next wm

        TIP2.Text = FormatNumber(1000000000000 / Convert.ToString(AltPoN2) / suma1.Text, 2)
        TIPX.Text = FormatNumber(1000000000000 / Convert.ToString(AltPoNX) / suma1.Text, 2)
        TIP1.Text = FormatNumber((TIP2.Text * TIPX.Text / ((TIP2.Text * 10 + TIPX.Text * 10) / 10)) / ((TIP2.Text * TIPX.Text / ((TIP2.Text * 10 + TIPX.Text * 10) / 10)) - 1), 2)

skipKFCTIP:
        DoMene = zajebDoMene.Text
        For wm = 0 To ((DoMene + 1) ^ 2) - 1
            PoN2 = Int(wm / (DoMene + 1))
            PoN1 = Int(((wm / (DoMene + 1) - PoN2) * DoMene + 0.999))
            'Racuna sanse za Upit o vise/manje poena.
            If (PoN1 + PoN2) < upitBP.Text Then UpitoPoenima1 = UpitoPoenima1 + Odds(wm + (DoMene + 1))
            If (PoN1 + PoN2) = upitBP.Text Then UpitoPoenimaX = UpitoPoenimaX + Odds(wm + (DoMene + 1))
            If (PoN1 + PoN2) > upitBP.Text Then UpitoPoenima2 = UpitoPoenima2 + Odds(wm + (DoMene + 1))

            'Racuna sanse za Upit o Handicap-u poena.
            If PoN1 + TmpHndcp > PoN2 Then UpitoHndcp1 = UpitoHndcp1 + Odds(wm + (DoMene + 1))
            If PoN1 + TmpHndcp = PoN2 Then UpitoHndcpX = UpitoHndcpX + Odds(wm + (DoMene + 1))
            If PoN1 + TmpHndcp < PoN2 Then UpitoHndcp2 = UpitoHndcp2 + Odds(wm + (DoMene + 1))

        Next wm

        If UpitoPoenima1 = 0 Then OdgovorBP1.Text = ("-") Else OdgovorBP1.Text = FormatNumber(1000000000000 / suma1.Text / Convert.ToString(UpitoPoenima1), 2)
        If UpitoPoenimaX = 0 Then OdgovorBPX.Text = ("-") Else OdgovorBPX.Text = FormatNumber(1000000000000 / suma1.Text / Convert.ToString(UpitoPoenimaX), 2)
        If UpitoPoenima2 = 0 Then OdgovorBP2.Text = ("-") Else OdgovorBP2.Text = FormatNumber(1000000000000 / suma1.Text / Convert.ToString(UpitoPoenima2), 2)

        If UpitoHndcp1 = 0 Then Hndcp1.Text = ("-") Else Hndcp1.Text = FormatNumber(1000000000000 / suma1.Text / Convert.ToString(UpitoHndcp1), 2)
        If UpitoHndcpX = 0 Then HndcpX.Text = ("-") Else HndcpX.Text = FormatNumber(1000000000000 / suma1.Text / Convert.ToString(UpitoHndcpX), 2)
        If UpitoHndcp2 = 0 Then Hndcp2.Text = ("-") Else Hndcp2.Text = FormatNumber(1000000000000 / suma1.Text / Convert.ToString(UpitoHndcp2), 2)

        '_______Koji poeni imaju max Sanse_________
        ' maxSumaPoena = 0
        ' For exitbrojilo = 1 To ((DoMene + 1) ^ 2)
        ' Racuna broj poena, za koji su najvece sanse.
        '   exitodds(exitbrojilo) = Convert.ToString(Odds(DoMene + exitbrojilo)) / 1000000000000
        '    If exitodds(exitbrojilo) > maxSumaPoena Then maxSumaPoena = exitodds(exitbrojilo) Else maxSumaPoena = maxSumaPoena
        '    If maxSumaPoena = exitodds(exitbrojilo) Then maxProbPoena = exitbrojilo Else maxProbPoena = maxProbPoena
        ' Next exitbrojilo
        ' expectPoeni1.Text = FormatNumber((maxProbPoena / (DoMene + 1) - Int(maxProbPoena / (DoMene + 1))) * (DoMene + 1) - 1, 0)
        ' expectPoeni2.Text = Int(maxProbPoena / (DoMene + 1))
        ' sumaPoeni12.Text = FormatNumber((maxProbPoena / (DoMene + 1) - Int(maxProbPoena / (DoMene + 1))) * (DoMene + 1) - 1, 0) + Int(maxProbPoena / (DoMene + 1))

    End Sub

    Public Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click

        If AVH1.Text = ("") Then GoTo end32
        If AVA1.Text = ("") Then GoTo end32
        If AVH2.Text = ("") Then GoTo end32
        If AVA2.Text = ("") Then GoTo end32
        If LA1.Text = ("") Then GoTo end32
        If LA2.Text = ("") Then GoTo end32

        If LA1.Text * AVA2.Text <= 0 Then GoTo end32
        If LA2.Text * AVH2.Text <= 0 Then GoTo end32
        If AVH1.Text <= 0 Then GoTo end32
        If AVA1.Text <= 0 Then GoTo end32

        Home.Text = FormatNumber(AVH1.Text / LA1.Text * AVA2.Text, 2)
        Away.Text = FormatNumber(AVA1.Text / LA2.Text * AVH2.Text, 2)
        warning.Visible = False
        PoissonCovar1.Visible = True
        PoissonCovar2.Visible = True
        PoissonCovar3.Visible = True
        PoissonCovar4.Visible = True
        PoissonCovar5.Visible = True
        PoissonCovar6.Visible = True
        Button53Apply.Visible = True
        GoTo end33

end32:
        warning.Visible = True
end33:
        CalcPoisson.Visible = False
        RecalcPoisson.Visible = False

        If (Home.Text * Away.Text) ^ 0.5 > 15 Then TextBoxMsg1.Visible = True Else TextBoxMsg1.Visible = False
        brojrclc.Text = 0
        TextBoxMsg3.Visible = False

    End Sub

    Private Sub Button53Apply_Click(sender As System.Object, e As System.EventArgs) Handles Button53Apply.Click

        PoissonTempAm = 0

        PoissonCovar1.Visible = False
        PoissonCovar2.Visible = False
        PoissonCovar3.Visible = False
        PoissonCovar4.Visible = False
        PoissonCovar5.Visible = False
        PoissonCovar6.Visible = False
        Button53Apply.Visible = False
        CalcPoisson.Visible = True
        RecalcPoisson.Visible = False
        TIP1.Text = "-"
        TIPX.Text = "-"
        TIP2.Text = "-"
        OdgovorBP1.Text = "-"
        OdgovorBPX.Text = "-"
        OdgovorBP2.Text = "-"
        Hndcp1.Text = "-"
        HndcpX.Text = "-"
        Hndcp2.Text = "-"

        Call PoissonTheta()
        upitBP.Text = FormatNumber(Int(Home.Text / 2 + Away.Text / 2) * 2 + 0.5, 1)
        Hndcp.Text = FormatNumber(Int(-Home.Text * 1 + Away.Text * 1) + 0.5, 1)
    End Sub

    Private Sub RecalcPoisson_Click(sender As System.Object, e As System.EventArgs) Handles RecalcPoisson.Click
        Call RecalculatePoisson()
    End Sub

    Public Sub PoissonTheta()

        PoisL5Kom = 0

        If Poisson5LastX1.Text = ("") Then PoisL5Kom = PoisL5Kom Else PoisL5Kom = PoisL5Kom + 1
        If Poisson5LastX2.Text = ("") Then PoisL5Kom = PoisL5Kom Else PoisL5Kom = PoisL5Kom + 1
        If Poisson5LastX3.Text = ("") Then PoisL5Kom = PoisL5Kom Else PoisL5Kom = PoisL5Kom + 1
        If Poisson5LastX4.Text = ("") Then PoisL5Kom = PoisL5Kom Else PoisL5Kom = PoisL5Kom + 1
        If Poisson5LastX5.Text = ("") Then PoisL5Kom = PoisL5Kom Else PoisL5Kom = PoisL5Kom + 1

        If PoisL5Kom = 0 Then GoTo endTheta

        If Poisson5LastX1.Text = ("") Then PoissL5X1 = 0 Else PoissL5X1 = Poisson5LastX1.Text
        If Poisson5LastX2.Text = ("") Then PoissL5X2 = 0 Else PoissL5X2 = Poisson5LastX2.Text
        If Poisson5LastX3.Text = ("") Then PoissL5X3 = 0 Else PoissL5X3 = Poisson5LastX3.Text
        If Poisson5LastX4.Text = ("") Then PoissL5X4 = 0 Else PoissL5X4 = Poisson5LastX4.Text
        If Poisson5LastX5.Text = ("") Then PoissL5X5 = 0 Else PoissL5X5 = Poisson5LastX5.Text

        If Poisson5LastY1.Text = ("") Then PoissL5Y1 = 0 Else PoissL5Y1 = Poisson5LastY1.Text
        If Poisson5LastY2.Text = ("") Then PoissL5Y2 = 0 Else PoissL5Y2 = Poisson5LastY2.Text
        If Poisson5LastY3.Text = ("") Then PoissL5Y3 = 0 Else PoissL5Y3 = Poisson5LastY3.Text
        If Poisson5LastY4.Text = ("") Then PoissL5Y4 = 0 Else PoissL5Y4 = Poisson5LastY4.Text
        If Poisson5LastY5.Text = ("") Then PoissL5Y5 = 0 Else PoissL5Y5 = Poisson5LastY5.Text

        PoissSumL5X = (PoissL5X1 + PoissL5X2 + PoissL5X3 + PoissL5X4 + PoissL5X5) / PoisL5Kom
        PoissSumL5Y = (PoissL5Y1 + PoissL5Y2 + PoissL5Y3 + PoissL5Y4 + PoissL5Y5) / PoisL5Kom

        If Poisson5LastX1.Text = ("") Then PoissA1 = 0 Else PoissA1 = Poisson5LastX1.Text - PoissSumL5X + 0.01
        If Poisson5LastX2.Text = ("") Then PoissA2 = 0 Else PoissA2 = Poisson5LastX2.Text - PoissSumL5X
        If Poisson5LastX3.Text = ("") Then PoissA3 = 0 Else PoissA3 = Poisson5LastX3.Text - PoissSumL5X
        If Poisson5LastX4.Text = ("") Then PoissA4 = 0 Else PoissA4 = Poisson5LastX4.Text - PoissSumL5X
        If Poisson5LastX5.Text = ("") Then PoissA5 = 0 Else PoissA5 = Poisson5LastX5.Text - PoissSumL5X

        If Poisson5LastY1.Text = ("") Then PoissB1 = 0 Else PoissB1 = Poisson5LastY1.Text - PoissSumL5Y + 0.01
        If Poisson5LastY2.Text = ("") Then PoissB2 = 0 Else PoissB2 = Poisson5LastY2.Text - PoissSumL5Y
        If Poisson5LastY3.Text = ("") Then PoissB3 = 0 Else PoissB3 = Poisson5LastY3.Text - PoissSumL5Y
        If Poisson5LastY4.Text = ("") Then PoissB4 = 0 Else PoissB4 = Poisson5LastY4.Text - PoissSumL5Y
        If Poisson5LastY5.Text = ("") Then PoissB5 = 0 Else PoissB5 = Poisson5LastY5.Text - PoissSumL5Y

        If (PoissA1 * PoissB1 + PoissA2 * PoissB2 + PoissA3 * PoissB3 + PoissA4 * PoissB4 + PoissA5 * PoissB5) = 0 Then ThetaPoisson.Text = ThetaPoisson.Text Else ThetaPoisson.Text = FormatNumber((PoissA1 * PoissB1 + PoissA2 * PoissB2 + PoissA3 * PoissB3 + PoissA4 * PoissB4 + PoissA5 * PoissB5) / ((PoissA1 ^ 2 + PoissA2 ^ 2 + PoissA3 ^ 2 + PoissA4 ^ 2 + PoissA5 ^ 2) * (PoissB1 ^ 2 + PoissB2 ^ 2 + PoissB3 ^ 2 + PoissB4 ^ 2 + PoissB5 ^ 2)) ^ (1 / 2), 4)

        BvPSumDifXY.Text = PoissSumL5X - PoissSumL5Y
        BvPSumAvG.Text = PoissSumL5X + PoissSumL5Y
        BvPAvgPoenaY.Text = (BvPSumAvG.Text * 10 - BvPSumDifXY.Text * 10) / 20
        BvPAvgPoenaX.Text = (BvPSumAvG.Text * 10 - BvPAvgPoenaY.Text * 10) / 10

        Dim TemporarTheta As Decimal = ThetaPoisson.Text
        Home1.Text = FormatNumber((BvPAvgPoenaX.Text * Math.Abs(TemporarTheta) + Home.Text * (1 - Math.Abs(TemporarTheta))) / 2 + (BvPAvgPoenaX.Text * 0.5 + Home.Text * 0.5) / 2, 2)
        Away1.Text = FormatNumber((BvPAvgPoenaY.Text * Math.Abs(TemporarTheta) + Away.Text * (1 - Math.Abs(TemporarTheta))) / 2 + (BvPAvgPoenaY.Text * 0.5 + Away.Text * 0.5) / 2, 2)

endTheta:
        If PoisL5Kom = 0 Then Home1.Text = Home.Text - ThetaPoisson.Text
        If PoisL5Kom = 0 Then Away1.Text = Away.Text - ThetaPoisson.Text

        Home.Text = Home1.Text
        Away.Text = Away1.Text

    End Sub

    Protected Sub nullPoisson0_Click(sender As Object, e As EventArgs) Handles nullPoisson0.Click
        Poisson5LastX1.Text = ""
        Poisson5LastX2.Text = ""
        Poisson5LastX3.Text = ""
        Poisson5LastX4.Text = ""
        Poisson5LastX5.Text = ""
        Poisson5LastY1.Text = ""
        Poisson5LastY2.Text = ""
        Poisson5LastY3.Text = ""
        Poisson5LastY4.Text = ""
        Poisson5LastY5.Text = ""
        ThetaPoisson.Text = 0
    End Sub

End Class