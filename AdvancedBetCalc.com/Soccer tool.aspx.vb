Imports System.Numerics

Public Class Soccer_tool
    Inherits System.Web.UI.Page

    Dim HELPLanguage, GSMExponentE, gsmtemp1setA, gsmtemp1setB, gsmprivBGame, gsmprivAGame, gsmprivBPoints, gsmprivAPoints, gsmprivBser, gsmprivAser, gsmTmp0060, gsmTmp0061, gsmTmp0062, gsmTmp0063, gsmTmp0064, gsmTmp0075, gsmTmp0066, gsmTmp0076, gsmTmp0006, gsmTmp0016, gsmTmp0026, gsmTmp0036, gsmTmp0046, gsmTmp0057, gsmTmp0066b, gsmTmp0067, gsmTmpA160, gsmTmpA161, gsmTmpA162, gsmTmpA163, gsmTmpA164, gsmTmpA166, gsmTmpA175, gsmTmpA176, gsmTmpA106, gsmTmpA116, gsmTmpA126, gsmTmpA136, gsmTmpA146, gsmTmpA166b, gsmTmpA157, gsmTmpA167, gsmTmpB160, gsmTmpB161, gsmTmpB162, gsmTmpB163, gsmTmpB164, gsmTmpB166, gsmTmpB175, gsmTmpB176, gsmTmpB106, gsmTmpB116, gsmTmpB126, gsmTmpB136, gsmTmpB146, gsmTmpB166b, gsmTmpB157, gsmTmpB167 As Decimal
    Dim GsmRazilkaSetovaA, GsmRazilkaSetovaB, brojacokretajatenisa008, brojacokretajatenisa005, brojacokretaja, domuk1, domuk2, domuk3, domuk4, domuk5, factorymXkomb1, factorymXkomb2, factorymXkomb3, factorymXkomb4, factorymXkomb5, factorymXkomb6, factorymXkomb7, factorymXkomb8, factorymXkomb9, factorymXkomb10, factorymXkomb11, factorymXkomb12, factorymXkomb13, factorymXkomb14, factorymXkomb15, factorymXkomb16, factorymXkomb17, factorymXkomb18, factorymXkomb19, factorymXkomb20, tonumberofcombY, factorYkomb As Decimal
    Dim ExOdds, PoN2, PoN1, TmpHndcp, maxProbPoena, maxSumaPoena, BrojPoena1, BrojPoena2, DoMene, DoMeneTemp, bip1brojilo, bip2brojilo, zbrojiodds, Poeni1MZbrajalo, Poeni2MZbrajalo, ManjiBrojPoena, Kombinacija As Decimal
    Dim potthetamnozitelj, thetamnozitelj, PoissB1, PoissB2, PoissB3, PoissB4, PoissB5, PoissA1, PoissA2, PoissA3, PoissA4, PoissA5, PoissSumL5Y, PoissSumL5X, PoissL5Y1, PoissL5Y2, PoissL5Y3, PoissL5Y4, PoissL5Y5, PoissL5X1, PoissL5X2, PoissL5X3, PoissL5X4, PoissL5X5, PoissonTempAm, PoisL5Kom As Decimal
    Dim Newline, TmpOddsKfc As String
    Dim Odds(40602) As BigInteger
    Dim exitodds(40602)
    Dim tm10, tm12 As String
    Dim kkkk(20) As String
    Dim rrrr(20) As String
    Dim oddsconvFracB, oddsconvFracN, oddsconvTemp, exchwn1, exchwn2, exchBs, PrebrojKelly, factxminus0, factyminus0, factxminus1, factyminus1, factxminus2, factyminus2, factxminus3, factyminus3, factxminus4, factyminus4, factxminus5, factyminus5, factxminus6, factyminus6, factxminus7, factyminus7, factxminus8, factyminus8, factxminus9, factyminus9, factxminus10, factyminus10, BrojiloxxfACTa, BrojiloxxfACTb, factBrojiloAminus0, factBrojiloBminus0, factBrojiloAminus1, factBrojiloBminus1, factBrojiloAminus2, factBrojiloBminus2, factBrojiloAminus3, factBrojiloBminus3, factBrojiloAminus4, factBrojiloBminus4, factBrojiloAminus5, factBrojiloBminus5, factBrojiloAminus6, factBrojiloBminus6, factBrojiloAminus7, factBrojiloBminus7, factBrojiloAminus8, factBrojiloBminus8, factBrojiloAminus9, factBrojiloBminus9, factBrojiloAminus10, factBrojiloBminus10, Manjebrojilo, POISONFACTORSUM, MUKSlozenost, MukMjera1, MukMjera2, MukMjera3, MukMjera4, MukMjera5, MUKR5, MUKq, MUKs5(1), MUKs4(1), MUKs3(1), MUKs2(1), MUKs1(1), MUKmaxU5, MUKmaxU4, MUKmaxU3, MUKmaxU2, MUKmaxU1, MUKmaxB, MUKB, MUKY, MUKy1, MUKy2, MUKy3, MUKy4, MUKlimit1, MUKlimit2, MUKlimit3, MUKlimit4, MUKlimit5, sssx, uuux, rrrx, pppx, vvvx, tttx, xxfACTa, xxfACTb, QQQx, brojilo15, brojilo16, tempsuma2, KellyStake1, KellyStake2, KellyStake3, KellyStake4, KellyStake5, KellyStake6, KellyStake7, KellyStake8, KellyStake9, KellyStake10, KellyStake11, KellyStake12, KellyStake13, KellyStake14, KellyStake15, KellyStake16, KellyStake17, KellyStake18, KellyStake19, KellyStake20, tempsuma, brsysY, temp1, temp2, temp3, acc, jpm, tgb, jku, qwqw, hht, eet, nnn, mmm, jj1, jj2, jj3, jj4, jj5, jj6, jj7, jj8, jj9, jj10, jj11, jj12, jj13, jj14, jj15, jj16, jj17, jj18, jj19, jj20, k, ulog, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, ca, cb, cd, ce, cf, cg, ch, ci, cj, ck, cl, cm, cn, co, cp, cq, cr, cs, ct, cu, x, y, b, brkom, d, el, f, g, h, i, j, l, m, n, o, p, q, r, s, t, u, v, w, z As Decimal
    Private _session As String
    Dim sumasvihS, hrV, hrN, PRVI01, PRVI01ILIDRUGI, PRVI01IDRUGI, PRVI01ILIDRUGIILITRECI, PRVI01ILIDRUGIILITRECIILICETVRTI, PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI, PIDILIDIP01, PRVI02, PRVI02ILIDRUGI, PRVI02IDRUGI, PRVI02ILIDRUGIILITRECI, PRVI02ILIDRUGIILITRECIILICETVRTI, PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI, PIDILIDIP02, PRVI03, PRVI03ILIDRUGI, PRVI03IDRUGI, PRVI03ILIDRUGIILITRECI, PRVI03ILIDRUGIILITRECIILICETVRTI, PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI, PIDILIDIP03, hrsumK, hrbrojilo3, hrFCT1, hrFCT2, hrFCT3, hrFCT4, hrFCT5, hrFCT6, hrFCT7, hrFCT8, tempbroj, znam1, znam2, znam3, znam4, znam5, znam6, znam7, znam8, PRVI04, PRVI04ILIDRUGI, PRVI04ILIDRUGIILITRECI, PRVI05, PRVI05ILIDRUGI, PRVI05ILIDRUGIILITRECI, PRVI06, PRVI06ILIDRUGI, PRVI06ILIDRUGIILITRECI, PRVI07, PRVI07ILIDRUGI, PRVI07ILIDRUGIILITRECI, PRVI08, PRVI08ILIDRUGI, PRVI08ILIDRUGIILITRECI, PRVI09, PRVI09ILIDRUGI, PRVI09ILIDRUGIILITRECI, PRVI10, PRVI10ILIDRUGI, PRVI10ILIDRUGIILITRECI, PRVI11, PRVI11ILIDRUGI, PRVI11ILIDRUGIILITRECI, PRVI12, PRVI12ILIDRUGI, PRVI12ILIDRUGIILITRECI, PRVI04ILIDRUGIILITRECIILICETVRTI, PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI05ILIDRUGIILITRECIILICETVRTI, PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI06ILIDRUGIILITRECIILICETVRTI, PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI07ILIDRUGIILITRECIILICETVRTI, PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI08ILIDRUGIILITRECIILICETVRTI, PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI09ILIDRUGIILITRECIILICETVRTI, PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI, wn1, wn2, Bs, SB20, SB21, SB02, SB12, xxM1, xxM2, S2, S3, S11, S12, S21, S22, tm1, tm2, tm3, tm4, tm5, tm6, tm7, tm8, tm9, tm11, tmb, bu1, bu2, bu3, bu4, bu5, bu6, bu7, bu8, bu9, bu10, bu11, bu12, bu13, bu14, bu15, bu16, bu17, bu18, bu19, bu20, vfv, ddd, MAxBanka, BestY, tt, MaxBank1, MaxBank2, MaxBank3, MaxBank4, MaxBank5, MaxBank6, MaxBank7, MaxBank8, MaxBank9, MaxBank10, MaxBank11, MaxBank12, MaxBank13, MaxBank14, MaxBank15, MaxBank16, MaxBank17, MaxBank18, MaxBank19, MaxBank20, BestU1, BestU2, BestU3, BestU4, BestU5, BestU6, BestU7, BestU8, BestU9, BestU10, BestU11, BestU12, BestU13, BestU14, BestU15, BestU16, BestU17, BestU18, BestU19, BestU20, gg, a, c, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20 As Decimal
    Dim GSMtempLSumA, GSMtempLKfcA, GSMtempL60, GSMtempL61, GSMtempL62, GSMtempL63, GSMtempL64, GSMtempL75, GSMtempL76, SwitchisON, SanseAgsm, SanseBgsm, GSMSrvB, GSMS06, GSMS16, GSMS26, GSMS36, GSMS46, GSMS57, GSMS67, GSMS55, GSMS66, GSMS60, GSMS61, GSMS62, GSMS63, GSMS64, GSMS75, GSMS76, GSMSanseA, GSMSanseB, GSMSxy, GSMX, GSMY, GSMW, GSMZ, GSMA, GSMB, GSMC, GSMD As Decimal
    Dim GSMTieBrA, GSMTieBrB, GSMS00, GSMS10, GSMS01, GSMS11, GSMS20, GSMS02, GSMS21, GSMS12, GSMS22, GSMS30, GSMS03, GSMS31, GSMS13, GSMS32, GSMS23, GSMS33, GSMS40, GSMS04, GSMS41, GSMS14, GSMS42, GSMS24, GSMS43, GSMS34, GSMS44, GSMS50, GSMS05, GSMS51, GSMS15, GSMS52, GSMS25, GSMS53, GSMS35, GSMS54, GSMS45 As Decimal
    Dim GSMSet(10), GSMnoz(7)
    Dim ChoosenHomeWin, ChoosenHomeLose, ChoosenHomeDraw, ChoosenAwayWin, ChoosenAwayLose, ChoosenAwayDraw, ChoosenHomeWin2, ChoosenHomeLose2, ChoosenHomeDraw2, ChoosenAwayWin2, ChoosenAwayLose2, ChoosenAwayDraw2 As Decimal
    Private Sub CalcPoisson_Load(sender As Object, e As EventArgs) Handles CalcPoisson.Load
        PoissonTempAm = 0
    End Sub

    ' Pocetak Bivariate poisson __________________________________________________________________________________________
    Public Sub CalcPoisson_Click(sender As System.Object, e As System.EventArgs) Handles CalcPoisson.Click

        If ThetaPoisson.Text < -1 Then ThetaPoisson.Text = -1 Else If ThetaPoisson.Text > 1 Then ThetaPoisson.Text = 1
        ThetaPoisson.Text = FormatNumber(ThetaPoisson.Text, 4)

        TemporaryHome.text = Home.Text
        TemporaryAway.text = Away.Text

        Home.Text = Home.Text * 1 - ThetaPoisson.Text * 1
        Away.Text = Away.Text * 1 - ThetaPoisson.Text * 1


        Dim sumaHplusA As Decimal
        sumaHplusA = Home.Text
        sumaHplusA = sumaHplusA + Away.Text

        Newline = System.Environment.NewLine
        ScoreTextBox.Text = ("")

        If Home.Text > Away.Text Then DoMeneTemp = Home.Text Else DoMeneTemp = Away.Text
        If DoMeneTemp < 5 Then DoMene = 10 Else If DoMeneTemp < 25 Then DoMene = Int(DoMeneTemp * 2) Else If DoMeneTemp < 35 Then DoMene = Int(DoMeneTemp * 1.5) Else If DoMeneTemp < 70 Then DoMene = Int(DoMeneTemp * 1.33) Else If DoMeneTemp < 120 Then DoMene = 150 Else DoMene = 180
        If DoMeneTemp < 50 Then thetamnozitelj = 10000 Else thetamnozitelj = 10
        If DoMeneTemp < 50 Then potthetamnozitelj = 4 Else potthetamnozitelj = 1

        If UpitBp_05.Text > Int(UpitBp_05.Text) Then UpitBp_05.Text = FormatNumber(Int(UpitBp_05.Text) + 0.5, 2)
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
        Suma1.Text = 1000000000000 / zbrojkontrola

        Call RecalculatePoisson()

        Home.Text = FormatNumber(Home.Text * 1 + ThetaPoisson.Text * 1, 3)
        Away.Text = FormatNumber(Away.Text * 1 + ThetaPoisson.Text * 1, 3)
    End Sub

    Private Sub RecalculatePoisson()

        '___Pribraja sanse radi izracuna kfc.-a: +/- ; Tip1X2 ; </>

        TmpHndcp = Hndcp.Text
        Dim UpitoPoenima1_10 = BigInteger.Parse("1")
        Dim UpitoPoenimaX_10 = BigInteger.Parse("1")
        Dim UpitoPoenima2_10 = BigInteger.Parse("1")

        Dim UpitoPoenima1_05 = BigInteger.Parse("1")
        Dim UpitoPoenimaX_05 = BigInteger.Parse("1")
        Dim UpitoPoenima2_05 = BigInteger.Parse("1")

        Dim UpitoPoenima1_15 = BigInteger.Parse("1")
        Dim UpitoPoenimaX_15 = BigInteger.Parse("1")
        Dim UpitoPoenima2_15 = BigInteger.Parse("1")

        Dim OddGoalsVar = BigInteger.Parse("1")
        Dim HomeZeroGoalsVar = BigInteger.Parse("1")
        Dim AwayZeroGoalsVar = BigInteger.Parse("1")


        Dim UpitoHndcp1 = BigInteger.Parse("1")
        Dim UpitoHndcpX = BigInteger.Parse("1")
        Dim UpitoHndcp2 = BigInteger.Parse("1")
        Dim KFCTIP1 = BigInteger.Parse("1")
        Dim KFCTIP2 = BigInteger.Parse("1")
        Dim KFCTIPX = BigInteger.Parse("1")
        Dim AltPoN1 = BigInteger.Parse("1")
        Dim AltPoN2 = BigInteger.Parse("1")
        Dim AltPoNX = BigInteger.Parse("1")

        UpitoPoenima1_05 = 0
        UpitoPoenimaX_05 = 0
        UpitoPoenima2_05 = 0
        UpitoPoenima1_10 = 0
        UpitoPoenimaX_10 = 0
        UpitoPoenima2_10 = 0
        UpitoPoenima1_15 = 0
        UpitoPoenimaX_15 = 0
        UpitoPoenima2_15 = 0

        OddGoalsVar = 0
        HomeZeroGoalsVar = 0
        AwayZeroGoalsVar = 0

        UpitoHndcp1 = 0
        UpitoHndcpX = 0
        UpitoHndcp2 = 0
        KFCTIP1 = 0
        KFCTIP2 = 0
        KFCTIPX = 0
        AltPoN1 = 0
        AltPoN2 = 0
        AltPoNX = 0

        For wm = 0 To ((DoMene + 1) ^ 2) - 1
            PoN2 = Int(wm / (DoMene + 1))
            PoN1 = Int(((wm / (DoMene + 1) - PoN2) * DoMene + 0.999))
            If PoN1 > PoN2 Then AltPoN1 = AltPoN1 + Odds(wm + (DoMene + 1))
            If PoN1 < PoN2 Then AltPoN2 = AltPoN2 + Odds(wm + (DoMene + 1))
            If PoN1 = PoN2 Then AltPoNX = AltPoNX + Odds(wm + (DoMene + 1))
            'Racuna koeficijente (pribraja segmente po rezultatima..)

            'Racuna sanse za Upit o vise/manje poena.
            If (PoN1 + PoN2) < UpitBp_05.Text Then UpitoPoenima1_05 = UpitoPoenima1_05 + Odds(wm + (DoMene + 1))
            If (PoN1 + PoN2) = UpitBp_05.Text Then UpitoPoenimaX_05 = UpitoPoenimaX_05 + Odds(wm + (DoMene + 1))
            If (PoN1 + PoN2) > UpitBp_05.Text Then UpitoPoenima2_05 = UpitoPoenima2_05 + Odds(wm + (DoMene + 1))

            If (PoN1 + PoN2) < UpitBp_10.Text Then UpitoPoenima1_10 = UpitoPoenima1_10 + Odds(wm + (DoMene + 1))
            If (PoN1 + PoN2) = UpitBp_10.Text Then UpitoPoenimaX_10 = UpitoPoenimaX_10 + Odds(wm + (DoMene + 1))
            If (PoN1 + PoN2) > UpitBp_10.Text Then UpitoPoenima2_10 = UpitoPoenima2_10 + Odds(wm + (DoMene + 1))

            If (PoN1 + PoN2) < UpitBp_15.Text Then UpitoPoenima1_15 = UpitoPoenima1_15 + Odds(wm + (DoMene + 1))
            If (PoN1 + PoN2) = UpitBp_15.Text Then UpitoPoenimaX_15 = UpitoPoenimaX_15 + Odds(wm + (DoMene + 1))
            If (PoN1 + PoN2) > UpitBp_15.Text Then UpitoPoenima2_15 = UpitoPoenima2_15 + Odds(wm + (DoMene + 1))


            'Racuna sanse za Upit o Handicap-u poena.
            If PoN1 + TmpHndcp > PoN2 Then UpitoHndcp1 = UpitoHndcp1 + Odds(wm + (DoMene + 1))
            If PoN1 + TmpHndcp = PoN2 Then UpitoHndcpX = UpitoHndcpX + Odds(wm + (DoMene + 1))
            If PoN1 + TmpHndcp < PoN2 Then UpitoHndcp2 = UpitoHndcp2 + Odds(wm + (DoMene + 1))


            'Racuna jeli paran ili neparan br.golova.
            If (PoN1 + PoN2) / 2 = Int((PoN1 + PoN2) / 2) Then OddGoalsVar = OddGoalsVar + Odds(wm + (DoMene + 1))


            'Racuna nula zabijenih golova Home/Away. HomeZeroGoals
            If PoN1 = 0 Then HomeZeroGoalsVar = HomeZeroGoalsVar + Odds(wm + (DoMene + 1))
            If PoN2 = 0 Then AwayZeroGoalsVar = AwayZeroGoalsVar + Odds(wm + (DoMene + 1))


            TmpOddsKfc = FormatNumber(Convert.ToString(Odds(wm + (DoMene + 1))) / 10000000, 4)
            If FormatNumber(Convert.ToString(Odds(wm + (DoMene + 1))) / 10000000, 4) < 0.01 Then ExOdds = 10001 Else ExOdds = FormatNumber(100 / FormatNumber(Convert.ToString(Odds(wm + (DoMene + 1))) / 10000000, 4), 2)
            If CheckBoxListem.Checked = True Then ScoreTextBox.Text = ScoreTextBox.Text & PoN1 & "     -     " & PoN2 & "         " & TmpOddsKfc & " " & "%    -     " & ExOdds & Newline

        Next wm

        TIP1.Text = FormatNumber(1000000000000 / Convert.ToString(AltPoN1) / suma1.Text, 2)
        TIP2.Text = FormatNumber(1000000000000 / Convert.ToString(AltPoN2) / suma1.Text, 2)
        TIPX.Text = FormatNumber(1000000000000 / Convert.ToString(AltPoNX) / suma1.Text, 2)

        If UpitoPoenima1_05 = 0 Then OdgovorBP1_05.Text = ("-") Else OdgovorBP1_05.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenima1_05), 2)
        If UpitoPoenimaX_05 = 0 Then OdgovorBPX_05.Text = ("-") Else OdgovorBPX_05.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenimaX_05), 2)
        If UpitoPoenima2_05 = 0 Then OdgovorBP2_05.Text = ("-") Else OdgovorBP2_05.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenima2_05), 2)

        If UpitoPoenima1_10 = 0 Then OdgovorBP1_10.Text = ("-") Else OdgovorBP1_10.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenima1_10), 2)
        If UpitoPoenimaX_10 = 0 Then OdgovorBPX_10.Text = ("-") Else OdgovorBPX_10.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenimaX_10), 2)
        If UpitoPoenima2_10 = 0 Then OdgovorBP2_10.Text = ("-") Else OdgovorBP2_10.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenima2_10), 2)

        If UpitoPoenima1_15 = 0 Then OdgovorBP1_15.Text = ("-") Else OdgovorBP1_15.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenima1_15), 2)
        If UpitoPoenimaX_15 = 0 Then OdgovorBPX_15.Text = ("-") Else OdgovorBPX_15.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenimaX_15), 2)
        If UpitoPoenima2_15 = 0 Then OdgovorBP2_15.Text = ("-") Else OdgovorBP2_15.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoPoenima2_15), 2)


        If UpitoHndcp1 = 0 Then Hndcp1.Text = ("-") Else Hndcp1.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoHndcp1), 2)
        If UpitoHndcpX = 0 Then HndcpX.Text = ("-") Else HndcpX.Text = FormatNumber(1000000000000 / suma1.Text / Convert.ToString(UpitoHndcpX), 2)
        If UpitoHndcp2 = 0 Then Hndcp2.Text = ("-") Else Hndcp2.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(UpitoHndcp2), 2)

        OddGoals.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(OddGoalsVar), 2)
        EvenGoals.Text = FormatNumber(1 / (1 - 1 / OddGoals.Text), 2)

        HomeZeroGoals.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(HomeZeroGoalsVar), 2)
        AwayZeroGoals.Text = FormatNumber(1000000000000 / Suma1.Text / Convert.ToString(AwayZeroGoalsVar), 2)



        '_______Koji poeni imaju max Sanse_________
        maxSumaPoena = 0
        For exitbrojilo = 1 To ((DoMene + 1) ^ 2)
            'Racuna broj poena, za koji su najvece sanse.
            exitodds(exitbrojilo) = Convert.ToString(Odds(DoMene + exitbrojilo)) / 1000000000000
            If exitodds(exitbrojilo) > maxSumaPoena Then maxSumaPoena = exitodds(exitbrojilo) Else maxSumaPoena = maxSumaPoena
            If maxSumaPoena = exitodds(exitbrojilo) Then maxProbPoena = exitbrojilo Else maxProbPoena = maxProbPoena
        Next exitbrojilo
        expectPoeni1.Text = FormatNumber((maxProbPoena / (DoMene + 1) - Int(maxProbPoena / (DoMene + 1))) * (DoMene + 1) - 1, 0)
        expectPoeniX.Text = Int(maxProbPoena / (DoMene + 1))
        sumaPoeni12.Text = FormatNumber((maxProbPoena / (DoMene + 1) - Int(maxProbPoena / (DoMene + 1))) * (DoMene + 1) - 1, 0) + Int(maxProbPoena / (DoMene + 1))

        ' Ovdje krece Holo...

        If HoloHomeFrom.Text = 1 Then ChoosenHomeWin = HW1.Text
        If HoloHomeFrom.Text = 2 Then ChoosenHomeWin = HW2.Text
        If HoloHomeFrom.Text = 3 Then ChoosenHomeWin = HW3.Text
        If HoloHomeFrom.Text = 4 Then ChoosenHomeWin = HW4.Text
        If HoloHomeFrom.Text = 5 Then ChoosenHomeWin = HW5.Text
        If HoloHomeFrom.Text = 6 Then ChoosenHomeWin = HW6.Text
        If HoloHomeFrom.Text = 7 Then ChoosenHomeWin = HW7.Text
        If HoloHomeFrom.Text = 8 Then ChoosenHomeWin = HW8.Text
        If HoloHomeFrom.Text = 9 Then ChoosenHomeWin = HW9.Text
        If HoloHomeFrom.Text = 10 Then ChoosenHomeWin = HW10.Text
        If HoloHomeFrom.Text = 11 Then ChoosenHomeWin = HW11.Text
        If HoloHomeFrom.Text = 12 Then ChoosenHomeWin = HW12.Text
        If HoloHomeFrom.Text = 13 Then ChoosenHomeWin = HW13.Text
        If HoloHomeFrom.Text = 14 Then ChoosenHomeWin = HW14.Text
        If HoloHomeFrom.Text = 15 Then ChoosenHomeWin = HW15.Text
        If HoloHomeFrom.Text = 16 Then ChoosenHomeWin = HW16.Text
        If HoloHomeFrom.Text = 17 Then ChoosenHomeWin = HW17.Text
        If HoloHomeFrom.Text = 18 Then ChoosenHomeWin = HW18.Text
        If HoloHomeFrom.Text = 19 Then ChoosenHomeWin = HW19.Text
        If HoloHomeFrom.Text = 20 Then ChoosenHomeWin = HW20.Text

        If HoloHomeFrom.Text = 1 Then ChoosenHomeLose = HL1.Text
        If HoloHomeFrom.Text = 2 Then ChoosenHomeLose = HL2.Text
        If HoloHomeFrom.Text = 3 Then ChoosenHomeLose = HL3.Text
        If HoloHomeFrom.Text = 4 Then ChoosenHomeLose = HL4.Text
        If HoloHomeFrom.Text = 5 Then ChoosenHomeLose = HL5.Text
        If HoloHomeFrom.Text = 6 Then ChoosenHomeLose = HL6.Text
        If HoloHomeFrom.Text = 7 Then ChoosenHomeLose = HL7.Text
        If HoloHomeFrom.Text = 8 Then ChoosenHomeLose = HL8.Text
        If HoloHomeFrom.Text = 9 Then ChoosenHomeLose = HL9.Text
        If HoloHomeFrom.Text = 10 Then ChoosenHomeLose = HL10.Text
        If HoloHomeFrom.Text = 11 Then ChoosenHomeLose = HL11.Text
        If HoloHomeFrom.Text = 12 Then ChoosenHomeLose = HL12.Text
        If HoloHomeFrom.Text = 13 Then ChoosenHomeLose = HL13.Text
        If HoloHomeFrom.Text = 14 Then ChoosenHomeLose = HL14.Text
        If HoloHomeFrom.Text = 15 Then ChoosenHomeLose = HL15.Text
        If HoloHomeFrom.Text = 16 Then ChoosenHomeLose = HL16.Text
        If HoloHomeFrom.Text = 17 Then ChoosenHomeLose = HL17.Text
        If HoloHomeFrom.Text = 18 Then ChoosenHomeLose = HL18.Text
        If HoloHomeFrom.Text = 19 Then ChoosenHomeLose = HL19.Text
        If HoloHomeFrom.Text = 20 Then ChoosenHomeLose = HL20.Text

        If HoloHomeFrom.Text = 1 Then ChoosenHomeDraw = HX1.Text
        If HoloHomeFrom.Text = 2 Then ChoosenHomeDraw = HX2.Text
        If HoloHomeFrom.Text = 3 Then ChoosenHomeDraw = HX3.Text
        If HoloHomeFrom.Text = 4 Then ChoosenHomeDraw = HX4.Text
        If HoloHomeFrom.Text = 5 Then ChoosenHomeDraw = HX5.Text
        If HoloHomeFrom.Text = 6 Then ChoosenHomeDraw = HX6.Text
        If HoloHomeFrom.Text = 7 Then ChoosenHomeDraw = HX7.Text
        If HoloHomeFrom.Text = 8 Then ChoosenHomeDraw = HX8.Text
        If HoloHomeFrom.Text = 9 Then ChoosenHomeDraw = HX9.Text
        If HoloHomeFrom.Text = 10 Then ChoosenHomeDraw = HX10.Text
        If HoloHomeFrom.Text = 11 Then ChoosenHomeDraw = HX11.Text
        If HoloHomeFrom.Text = 12 Then ChoosenHomeDraw = HX12.Text
        If HoloHomeFrom.Text = 13 Then ChoosenHomeDraw = HX13.Text
        If HoloHomeFrom.Text = 14 Then ChoosenHomeDraw = HX14.Text
        If HoloHomeFrom.Text = 15 Then ChoosenHomeDraw = HX15.Text
        If HoloHomeFrom.Text = 16 Then ChoosenHomeDraw = HX16.Text
        If HoloHomeFrom.Text = 17 Then ChoosenHomeDraw = HX17.Text
        If HoloHomeFrom.Text = 18 Then ChoosenHomeDraw = HX18.Text
        If HoloHomeFrom.Text = 19 Then ChoosenHomeDraw = HX19.Text
        If HoloHomeFrom.Text = 20 Then ChoosenHomeDraw = HX20.Text

        If HoloAwayFrom.Text = 1 Then ChoosenAwayWin = AW1.Text
        If HoloAwayFrom.Text = 2 Then ChoosenAwayWin = AW2.Text
        If HoloAwayFrom.Text = 3 Then ChoosenAwayWin = AW3.Text
        If HoloAwayFrom.Text = 4 Then ChoosenAwayWin = AW4.Text
        If HoloAwayFrom.Text = 5 Then ChoosenAwayWin = AW5.Text
        If HoloAwayFrom.Text = 6 Then ChoosenAwayWin = AW6.Text
        If HoloAwayFrom.Text = 7 Then ChoosenAwayWin = AW7.Text
        If HoloAwayFrom.Text = 8 Then ChoosenAwayWin = AW8.Text
        If HoloAwayFrom.Text = 9 Then ChoosenAwayWin = AW9.Text
        If HoloAwayFrom.Text = 10 Then ChoosenAwayWin = AW10.Text
        If HoloAwayFrom.Text = 11 Then ChoosenAwayWin = AW11.Text
        If HoloAwayFrom.Text = 12 Then ChoosenAwayWin = AW12.Text
        If HoloAwayFrom.Text = 13 Then ChoosenAwayWin = AW13.Text
        If HoloAwayFrom.Text = 14 Then ChoosenAwayWin = AW14.Text
        If HoloAwayFrom.Text = 15 Then ChoosenAwayWin = AW15.Text
        If HoloAwayFrom.Text = 16 Then ChoosenAwayWin = AW16.Text
        If HoloAwayFrom.Text = 17 Then ChoosenAwayWin = AW17.Text
        If HoloAwayFrom.Text = 18 Then ChoosenAwayWin = AW18.Text
        If HoloAwayFrom.Text = 19 Then ChoosenAwayWin = AW19.Text
        If HoloAwayFrom.Text = 20 Then ChoosenAwayWin = AW20.Text

        If HoloAwayFrom.Text = 1 Then ChoosenAwayLose = AL1.Text
        If HoloAwayFrom.Text = 2 Then ChoosenAwayLose = AL2.Text
        If HoloAwayFrom.Text = 3 Then ChoosenAwayLose = AL3.Text
        If HoloAwayFrom.Text = 4 Then ChoosenAwayLose = AL4.Text
        If HoloAwayFrom.Text = 5 Then ChoosenAwayLose = AL5.Text
        If HoloAwayFrom.Text = 6 Then ChoosenAwayLose = AL6.Text
        If HoloAwayFrom.Text = 7 Then ChoosenAwayLose = AL7.Text
        If HoloAwayFrom.Text = 8 Then ChoosenAwayLose = AL8.Text
        If HoloAwayFrom.Text = 9 Then ChoosenAwayLose = AL9.Text
        If HoloAwayFrom.Text = 10 Then ChoosenAwayLose = AL10.Text
        If HoloAwayFrom.Text = 11 Then ChoosenAwayLose = AL11.Text
        If HoloAwayFrom.Text = 12 Then ChoosenAwayLose = AL12.Text
        If HoloAwayFrom.Text = 13 Then ChoosenAwayLose = AL13.Text
        If HoloAwayFrom.Text = 14 Then ChoosenAwayLose = AL14.Text
        If HoloAwayFrom.Text = 15 Then ChoosenAwayLose = AL15.Text
        If HoloAwayFrom.Text = 16 Then ChoosenAwayLose = AL16.Text
        If HoloAwayFrom.Text = 17 Then ChoosenAwayLose = AL17.Text
        If HoloAwayFrom.Text = 18 Then ChoosenAwayLose = AL18.Text
        If HoloAwayFrom.Text = 19 Then ChoosenAwayLose = AL19.Text
        If HoloAwayFrom.Text = 20 Then ChoosenAwayLose = AL20.Text

        If HoloAwayFrom.Text = 1 Then ChoosenAwayDraw = AX1.Text
        If HoloAwayFrom.Text = 2 Then ChoosenAwayDraw = AX2.Text
        If HoloAwayFrom.Text = 3 Then ChoosenAwayDraw = AX3.Text
        If HoloAwayFrom.Text = 4 Then ChoosenAwayDraw = AX4.Text
        If HoloAwayFrom.Text = 5 Then ChoosenAwayDraw = AX5.Text
        If HoloAwayFrom.Text = 6 Then ChoosenAwayDraw = AX6.Text
        If HoloAwayFrom.Text = 7 Then ChoosenAwayDraw = AX7.Text
        If HoloAwayFrom.Text = 8 Then ChoosenAwayDraw = AX8.Text
        If HoloAwayFrom.Text = 9 Then ChoosenAwayDraw = AX9.Text
        If HoloAwayFrom.Text = 10 Then ChoosenAwayDraw = AX10.Text
        If HoloAwayFrom.Text = 11 Then ChoosenAwayDraw = AX11.Text
        If HoloAwayFrom.Text = 12 Then ChoosenAwayDraw = AX12.Text
        If HoloAwayFrom.Text = 13 Then ChoosenAwayDraw = AX13.Text
        If HoloAwayFrom.Text = 14 Then ChoosenAwayDraw = AX14.Text
        If HoloAwayFrom.Text = 15 Then ChoosenAwayDraw = AX15.Text
        If HoloAwayFrom.Text = 16 Then ChoosenAwayDraw = AX16.Text
        If HoloAwayFrom.Text = 17 Then ChoosenAwayDraw = AX17.Text
        If HoloAwayFrom.Text = 18 Then ChoosenAwayDraw = AX18.Text
        If HoloAwayFrom.Text = 19 Then ChoosenAwayDraw = AX19.Text
        If HoloAwayFrom.Text = 20 Then ChoosenAwayDraw = AX20.Text

        If HoloHomeTo.Text = 1 Then ChoosenHomeWin2 = HW1.Text
        If HoloHomeTo.Text = 2 Then ChoosenHomeWin2 = HW2.Text
        If HoloHomeTo.Text = 3 Then ChoosenHomeWin2 = HW3.Text
        If HoloHomeTo.Text = 4 Then ChoosenHomeWin2 = HW4.Text
        If HoloHomeTo.Text = 5 Then ChoosenHomeWin2 = HW5.Text
        If HoloHomeTo.Text = 6 Then ChoosenHomeWin2 = HW6.Text
        If HoloHomeTo.Text = 7 Then ChoosenHomeWin2 = HW7.Text
        If HoloHomeTo.Text = 8 Then ChoosenHomeWin2 = HW8.Text
        If HoloHomeTo.Text = 9 Then ChoosenHomeWin2 = HW9.Text
        If HoloHomeTo.Text = 10 Then ChoosenHomeWin2 = HW10.Text
        If HoloHomeTo.Text = 11 Then ChoosenHomeWin2 = HW11.Text
        If HoloHomeTo.Text = 12 Then ChoosenHomeWin2 = HW12.Text
        If HoloHomeTo.Text = 13 Then ChoosenHomeWin2 = HW13.Text
        If HoloHomeTo.Text = 14 Then ChoosenHomeWin2 = HW14.Text
        If HoloHomeTo.Text = 15 Then ChoosenHomeWin2 = HW15.Text
        If HoloHomeTo.Text = 16 Then ChoosenHomeWin2 = HW16.Text
        If HoloHomeTo.Text = 17 Then ChoosenHomeWin2 = HW17.Text
        If HoloHomeTo.Text = 18 Then ChoosenHomeWin2 = HW18.Text
        If HoloHomeTo.Text = 19 Then ChoosenHomeWin2 = HW19.Text
        If HoloHomeTo.Text = 20 Then ChoosenHomeWin2 = HW20.Text

        If HoloHomeTo.Text = 1 Then ChoosenHomeLose2 = HL1.Text
        If HoloHomeTo.Text = 2 Then ChoosenHomeLose2 = HL2.Text
        If HoloHomeTo.Text = 3 Then ChoosenHomeLose2 = HL3.Text
        If HoloHomeTo.Text = 4 Then ChoosenHomeLose2 = HL4.Text
        If HoloHomeTo.Text = 5 Then ChoosenHomeLose2 = HL5.Text
        If HoloHomeTo.Text = 6 Then ChoosenHomeLose2 = HL6.Text
        If HoloHomeTo.Text = 7 Then ChoosenHomeLose2 = HL7.Text
        If HoloHomeTo.Text = 8 Then ChoosenHomeLose2 = HL8.Text
        If HoloHomeTo.Text = 9 Then ChoosenHomeLose2 = HL9.Text
        If HoloHomeTo.Text = 10 Then ChoosenHomeLose2 = HL10.Text
        If HoloHomeTo.Text = 11 Then ChoosenHomeLose2 = HL11.Text
        If HoloHomeTo.Text = 12 Then ChoosenHomeLose2 = HL12.Text
        If HoloHomeTo.Text = 13 Then ChoosenHomeLose2 = HL13.Text
        If HoloHomeTo.Text = 14 Then ChoosenHomeLose2 = HL14.Text
        If HoloHomeTo.Text = 15 Then ChoosenHomeLose2 = HL15.Text
        If HoloHomeTo.Text = 16 Then ChoosenHomeLose2 = HL16.Text
        If HoloHomeTo.Text = 17 Then ChoosenHomeLose2 = HL17.Text
        If HoloHomeTo.Text = 18 Then ChoosenHomeLose2 = HL18.Text
        If HoloHomeTo.Text = 19 Then ChoosenHomeLose2 = HL19.Text
        If HoloHomeTo.Text = 20 Then ChoosenHomeLose2 = HL20.Text

        If HoloHomeTo.Text = 1 Then ChoosenHomeDraw2 = HX1.Text
        If HoloHomeTo.Text = 2 Then ChoosenHomeDraw2 = HX2.Text
        If HoloHomeTo.Text = 3 Then ChoosenHomeDraw2 = HX3.Text
        If HoloHomeTo.Text = 4 Then ChoosenHomeDraw2 = HX4.Text
        If HoloHomeTo.Text = 5 Then ChoosenHomeDraw2 = HX5.Text
        If HoloHomeTo.Text = 6 Then ChoosenHomeDraw2 = HX6.Text
        If HoloHomeTo.Text = 7 Then ChoosenHomeDraw2 = HX7.Text
        If HoloHomeTo.Text = 8 Then ChoosenHomeDraw2 = HX8.Text
        If HoloHomeTo.Text = 9 Then ChoosenHomeDraw2 = HX9.Text
        If HoloHomeTo.Text = 10 Then ChoosenHomeDraw2 = HX10.Text
        If HoloHomeTo.Text = 11 Then ChoosenHomeDraw2 = HX11.Text
        If HoloHomeTo.Text = 12 Then ChoosenHomeDraw2 = HX12.Text
        If HoloHomeTo.Text = 13 Then ChoosenHomeDraw2 = HX13.Text
        If HoloHomeTo.Text = 14 Then ChoosenHomeDraw2 = HX14.Text
        If HoloHomeTo.Text = 15 Then ChoosenHomeDraw2 = HX15.Text
        If HoloHomeTo.Text = 16 Then ChoosenHomeDraw2 = HX16.Text
        If HoloHomeTo.Text = 17 Then ChoosenHomeDraw2 = HX17.Text
        If HoloHomeTo.Text = 18 Then ChoosenHomeDraw2 = HX18.Text
        If HoloHomeTo.Text = 19 Then ChoosenHomeDraw2 = HX19.Text
        If HoloHomeTo.Text = 20 Then ChoosenHomeDraw2 = HX20.Text

        If HoloAwayTo.Text = 1 Then ChoosenAwayWin2 = AW1.Text
        If HoloAwayTo.Text = 2 Then ChoosenAwayWin2 = AW2.Text
        If HoloAwayTo.Text = 3 Then ChoosenAwayWin2 = AW3.Text
        If HoloAwayTo.Text = 4 Then ChoosenAwayWin2 = AW4.Text
        If HoloAwayTo.Text = 5 Then ChoosenAwayWin2 = AW5.Text
        If HoloAwayTo.Text = 6 Then ChoosenAwayWin2 = AW6.Text
        If HoloAwayTo.Text = 7 Then ChoosenAwayWin2 = AW7.Text
        If HoloAwayTo.Text = 8 Then ChoosenAwayWin2 = AW8.Text
        If HoloAwayTo.Text = 9 Then ChoosenAwayWin2 = AW9.Text
        If HoloAwayTo.Text = 10 Then ChoosenAwayWin2 = AW10.Text
        If HoloAwayTo.Text = 11 Then ChoosenAwayWin2 = AW11.Text
        If HoloAwayTo.Text = 12 Then ChoosenAwayWin2 = AW12.Text
        If HoloAwayTo.Text = 13 Then ChoosenAwayWin2 = AW13.Text
        If HoloAwayTo.Text = 14 Then ChoosenAwayWin2 = AW14.Text
        If HoloAwayTo.Text = 15 Then ChoosenAwayWin2 = AW15.Text
        If HoloAwayTo.Text = 16 Then ChoosenAwayWin2 = AW16.Text
        If HoloAwayTo.Text = 17 Then ChoosenAwayWin2 = AW17.Text
        If HoloAwayTo.Text = 18 Then ChoosenAwayWin2 = AW18.Text
        If HoloAwayTo.Text = 19 Then ChoosenAwayWin2 = AW19.Text
        If HoloAwayTo.Text = 20 Then ChoosenAwayWin2 = AW20.Text

        If HoloAwayTo.Text = 1 Then ChoosenAwayLose2 = AL1.Text
        If HoloAwayTo.Text = 2 Then ChoosenAwayLose2 = AL2.Text
        If HoloAwayTo.Text = 3 Then ChoosenAwayLose2 = AL3.Text
        If HoloAwayTo.Text = 4 Then ChoosenAwayLose2 = AL4.Text
        If HoloAwayTo.Text = 5 Then ChoosenAwayLose2 = AL5.Text
        If HoloAwayTo.Text = 6 Then ChoosenAwayLose2 = AL6.Text
        If HoloAwayTo.Text = 7 Then ChoosenAwayLose2 = AL7.Text
        If HoloAwayTo.Text = 8 Then ChoosenAwayLose2 = AL8.Text
        If HoloAwayTo.Text = 9 Then ChoosenAwayLose2 = AL9.Text
        If HoloAwayTo.Text = 10 Then ChoosenAwayLose2 = AL10.Text
        If HoloAwayTo.Text = 11 Then ChoosenAwayLose2 = AL11.Text
        If HoloAwayTo.Text = 12 Then ChoosenAwayLose2 = AL12.Text
        If HoloAwayTo.Text = 13 Then ChoosenAwayLose2 = AL13.Text
        If HoloAwayTo.Text = 14 Then ChoosenAwayLose2 = AL14.Text
        If HoloAwayTo.Text = 15 Then ChoosenAwayLose2 = AL15.Text
        If HoloAwayTo.Text = 16 Then ChoosenAwayLose2 = AL16.Text
        If HoloAwayTo.Text = 17 Then ChoosenAwayLose2 = AL17.Text
        If HoloAwayTo.Text = 18 Then ChoosenAwayLose2 = AL18.Text
        If HoloAwayTo.Text = 19 Then ChoosenAwayLose2 = AL19.Text
        If HoloAwayTo.Text = 20 Then ChoosenAwayLose2 = AL20.Text

        If HoloAwayTo.Text = 1 Then ChoosenAwayDraw2 = AX1.Text
        If HoloAwayTo.Text = 2 Then ChoosenAwayDraw2 = AX2.Text
        If HoloAwayTo.Text = 3 Then ChoosenAwayDraw2 = AX3.Text
        If HoloAwayTo.Text = 4 Then ChoosenAwayDraw2 = AX4.Text
        If HoloAwayTo.Text = 5 Then ChoosenAwayDraw2 = AX5.Text
        If HoloAwayTo.Text = 6 Then ChoosenAwayDraw2 = AX6.Text
        If HoloAwayTo.Text = 7 Then ChoosenAwayDraw2 = AX7.Text
        If HoloAwayTo.Text = 8 Then ChoosenAwayDraw2 = AX8.Text
        If HoloAwayTo.Text = 9 Then ChoosenAwayDraw2 = AX9.Text
        If HoloAwayTo.Text = 10 Then ChoosenAwayDraw2 = AX10.Text
        If HoloAwayTo.Text = 11 Then ChoosenAwayDraw2 = AX11.Text
        If HoloAwayTo.Text = 12 Then ChoosenAwayDraw2 = AX12.Text
        If HoloAwayTo.Text = 13 Then ChoosenAwayDraw2 = AX13.Text
        If HoloAwayTo.Text = 14 Then ChoosenAwayDraw2 = AX14.Text
        If HoloAwayTo.Text = 15 Then ChoosenAwayDraw2 = AX15.Text
        If HoloAwayTo.Text = 16 Then ChoosenAwayDraw2 = AX16.Text
        If HoloAwayTo.Text = 17 Then ChoosenAwayDraw2 = AX17.Text
        If HoloAwayTo.Text = 18 Then ChoosenAwayDraw2 = AX18.Text
        If HoloAwayTo.Text = 19 Then ChoosenAwayDraw2 = AX19.Text
        If HoloAwayTo.Text = 20 Then ChoosenAwayDraw2 = AX20.Text

        HoloTIP1a.Text = FormatNumber(1 / ((ChoosenHomeWin * ChoosenAwayLose2) / (ChoosenHomeWin * ChoosenAwayLose2 + ChoosenHomeDraw * ChoosenAwayDraw2 + ChoosenHomeLose * ChoosenAwayWin2)), 2)
        HoloTIPXa.Text = FormatNumber(1 / ((ChoosenHomeDraw * ChoosenAwayDraw2) / (ChoosenHomeWin * ChoosenAwayLose2 + ChoosenHomeDraw * ChoosenAwayDraw2 + ChoosenHomeLose * ChoosenAwayWin2)), 2)
        HoloTIP2a.Text = FormatNumber(1 / ((ChoosenHomeLose * ChoosenAwayWin2) / (ChoosenHomeWin * ChoosenAwayLose2 + ChoosenHomeDraw * ChoosenAwayDraw2 + ChoosenHomeLose * ChoosenAwayWin2)), 2)

        HoloTIP1b.Text = FormatNumber(1 / ((ChoosenHomeWin2 * ChoosenAwayLose) / (ChoosenHomeWin2 * ChoosenAwayLose + ChoosenHomeDraw2 * ChoosenAwayDraw + ChoosenHomeLose2 * ChoosenAwayWin)), 2)
        HoloTIPXb.Text = FormatNumber(1 / ((ChoosenHomeDraw2 * ChoosenAwayDraw) / (ChoosenHomeWin2 * ChoosenAwayLose + ChoosenHomeDraw2 * ChoosenAwayDraw + ChoosenHomeLose2 * ChoosenAwayWin)), 2)
        HoloTIP2b.Text = FormatNumber(1 / ((ChoosenHomeLose2 * ChoosenAwayWin) / (ChoosenHomeWin2 * ChoosenAwayLose + ChoosenHomeDraw2 * ChoosenAwayDraw + ChoosenHomeLose2 * ChoosenAwayWin)), 2)

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