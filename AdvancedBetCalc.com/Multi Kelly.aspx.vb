Public Class WebForm3
    Inherits System.Web.UI.Page

    Dim P1, Y, C, fY, fa, fYma, m, P2, SumFill, P0, GetOutLAF, stopCounter, stepU, SumOptiU As Decimal

    Protected Sub ImageButtonUK_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonUK.Click
        TextBoxHelpUK.Visible = True
        TextBoxHelpHR.Visible = False
    End Sub

    Protected Sub ImageButtonHR_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonHR.Click
        TextBoxHelpUK.Visible = False
        TextBoxHelpHR.Visible = True
    End Sub

    Dim nmbr As Decimal = 0
    Dim tempP As Decimal = 0
    Dim summing As Decimal = 0

    Dim u(16), k(16), s(16), Suma(65537), Pp(65537), SpointKn(16), tmpU(16), TextInputU(16)
    Dim decNo As Integer = 0
    Dim priv As Integer
    Dim sm, newline As String

    Private Sub BtnInput_Click(sender As System.Object, e As System.EventArgs) Handles BtnInput.Click

        mKmaxBank.Text = 0.00
        MaxIputedB.Text = 0.00

        nmbr = tempRedBr.Text
        tempRedBr.Text = nmbr + 1
        TboxKfc.Text = TboxKfc.Text & nmbr & ".  " & FormatNumber(k1.Text, 4) & "        " & FormatNumber(s1.Text, 4) & "       " & FormatNumber(u1.Text, 4) & "       " & FormatNumber((k1.Text * s1.Text - 1) / (k1.Text * 1 - 1), 4) & Environment.NewLine

        If nmbr = 9 Then BtnInput.Visible = False

        k(nmbr) = k1.Text
        s(nmbr) = s1.Text
        u(nmbr) = u1.Text

        If nmbr = 1 Then tempK1.Text = k(1)
        If nmbr = 2 Then tempK2.Text = k(2)
        If nmbr = 3 Then tempK3.Text = k(3)
        If nmbr = 4 Then tempK4.Text = k(4)
        If nmbr = 5 Then tempK5.Text = k(5)
        If nmbr = 6 Then tempK6.Text = k(6)
        If nmbr = 7 Then tempK7.Text = k(7)
        If nmbr = 8 Then tempK8.Text = k(8)
        If nmbr = 9 Then tempK9.Text = k(9)
        If nmbr = 10 Then tempK10.Text = k(10)
        If nmbr = 11 Then tempK11.Text = k(11)
        If nmbr = 12 Then tempK12.Text = k(12)
        If nmbr = 13 Then tempK13.Text = k(13)
        If nmbr = 14 Then tempK14.Text = k(14)
        If nmbr = 15 Then tempK15.Text = k(15)
        If nmbr = 16 Then tempK16.Text = k(16)
        k(1) = tempK1.Text
        k(2) = tempK2.Text
        k(3) = tempK3.Text
        k(4) = tempK4.Text
        k(5) = tempK5.Text
        k(6) = tempK6.Text
        k(7) = tempK7.Text
        k(8) = tempK8.Text
        k(9) = tempK9.Text
        k(10) = tempK10.Text
        k(11) = tempK11.Text
        k(12) = tempK12.Text
        k(13) = tempK13.Text
        k(14) = tempK14.Text
        k(15) = tempK15.Text
        k(16) = tempK16.Text

        If nmbr = 1 Then tempU1.Text = u(1)
        If nmbr = 2 Then tempU2.Text = u(2)
        If nmbr = 3 Then tempU3.Text = u(3)
        If nmbr = 4 Then tempU4.Text = u(4)
        If nmbr = 5 Then tempU5.Text = u(5)
        If nmbr = 6 Then tempU6.Text = u(6)
        If nmbr = 7 Then tempU7.Text = u(7)
        If nmbr = 8 Then tempU8.Text = u(8)
        If nmbr = 9 Then tempU9.Text = u(9)
        If nmbr = 10 Then tempU10.Text = u(10)
        If nmbr = 11 Then tempU11.Text = u(11)
        If nmbr = 12 Then tempU12.Text = u(12)
        If nmbr = 13 Then tempU13.Text = u(13)
        If nmbr = 14 Then tempU14.Text = u(14)
        If nmbr = 15 Then tempU15.Text = u(15)
        If nmbr = 16 Then tempU16.Text = u(16)
        u(1) = tempU1.Text
        u(2) = tempU2.Text
        u(3) = tempU3.Text
        u(4) = tempU4.Text
        u(5) = tempU5.Text
        u(6) = tempU6.Text
        u(7) = tempU7.Text
        u(8) = tempU8.Text
        u(9) = tempU9.Text
        u(10) = tempU10.Text
        u(11) = tempU11.Text
        u(12) = tempU12.Text
        u(13) = tempU13.Text
        u(14) = tempU14.Text
        u(15) = tempU15.Text
        u(16) = tempU16.Text

        If nmbr = 1 Then tempS1.Text = s(1)
        If nmbr = 2 Then tempS2.Text = s(2)
        If nmbr = 3 Then tempS3.Text = s(3)
        If nmbr = 4 Then tempS4.Text = s(4)
        If nmbr = 5 Then tempS5.Text = s(5)
        If nmbr = 6 Then tempS6.Text = s(6)
        If nmbr = 7 Then tempS7.Text = s(7)
        If nmbr = 8 Then tempS8.Text = s(8)
        If nmbr = 9 Then tempS9.Text = s(9)
        If nmbr = 10 Then tempS10.Text = s(10)
        If nmbr = 11 Then tempS11.Text = s(11)
        If nmbr = 12 Then tempS12.Text = s(12)
        If nmbr = 13 Then tempS13.Text = s(13)
        If nmbr = 14 Then tempS14.Text = s(14)
        If nmbr = 15 Then tempS15.Text = s(15)
        If nmbr = 16 Then tempS16.Text = s(16)
        s(1) = tempS1.Text
        s(2) = tempS2.Text
        s(3) = tempS3.Text
        s(4) = tempS4.Text
        s(5) = tempS5.Text
        s(6) = tempS6.Text
        s(7) = tempS7.Text
        s(8) = tempS8.Text
        s(9) = tempS9.Text
        s(10) = tempS10.Text
        s(11) = tempS11.Text
        s(12) = tempS12.Text
        s(13) = tempS13.Text
        s(14) = tempS14.Text
        s(15) = tempS15.Text
        s(16) = tempS16.Text

        TextInputU(nmbr) = u1.Text

        tempTextInputU1.Text = u(1)
        tempTextInputU2.Text = u(2)
        tempTextInputU3.Text = u(3)
        tempTextInputU4.Text = u(4)
        tempTextInputU5.Text = u(5)
        tempTextInputU6.Text = u(6)
        tempTextInputU7.Text = u(7)
        tempTextInputU8.Text = u(8)
        tempTextInputU9.Text = u(9)
        tempTextInputU10.Text = u(10)
        tempTextInputU11.Text = u(11)
        tempTextInputU12.Text = u(12)
        tempTextInputU13.Text = u(13)
        tempTextInputU14.Text = u(14)
        tempTextInputU15.Text = u(15)
        tempTextInputU16.Text = u(16)


        summing = tempSumU.Text * 1 + u1.Text * 1
        tempSumU.Text = summing
        SumInvest.Text = FormatNumber(summing, 4)
        If summing > 1 Then BtnCalculate.Enabled = False
        If summing > 1 Then SumInvest.Text = ">100.00%"

        If summing > 1 Then BtnInput.Enabled = False

        priv = tempStpCntr.Text
        tempStpCntr.Text = priv + 1

    End Sub

    Private Sub BtnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculate.Click
        BtnCalculate.Visible = False
        BtnInput.Visible = False

        k(1) = tempK1.Text
        k(2) = tempK2.Text
        k(3) = tempK3.Text
        k(4) = tempK4.Text
        k(5) = tempK5.Text
        k(6) = tempK6.Text
        k(7) = tempK7.Text
        k(8) = tempK8.Text
        k(9) = tempK9.Text
        k(10) = tempK10.Text
        k(11) = tempK11.Text
        k(12) = tempK12.Text
        k(13) = tempK13.Text
        k(14) = tempK14.Text
        k(15) = tempK15.Text
        k(16) = tempK16.Text

        u(1) = tempU1.Text
        u(2) = tempU2.Text
        u(3) = tempU3.Text
        u(4) = tempU4.Text
        u(5) = tempU5.Text
        u(6) = tempU6.Text
        u(7) = tempU7.Text
        u(8) = tempU8.Text
        u(9) = tempU9.Text
        u(10) = tempU10.Text
        u(11) = tempU11.Text
        u(12) = tempU12.Text
        u(13) = tempU13.Text
        u(14) = tempU14.Text
        u(15) = tempU15.Text
        u(16) = tempU16.Text

        s(1) = tempS1.Text
        s(2) = tempS2.Text
        s(3) = tempS3.Text
        s(4) = tempS4.Text
        s(5) = tempS5.Text
        s(6) = tempS6.Text
        s(7) = tempS7.Text
        s(8) = tempS8.Text
        s(9) = tempS9.Text
        s(10) = tempS10.Text
        s(11) = tempS11.Text
        s(12) = tempS12.Text
        s(13) = tempS13.Text
        s(14) = tempS14.Text
        s(15) = tempS15.Text
        s(16) = tempS16.Text

        OptimumU.Text = ""
        stepU = 0.001
        tempStepU.Text = stepU
        Y = tempRedBr.Text * 1 - 1
        SumOptiU = 0
        tempSumaOptiU.Text = 0

        Call DiagonalAprox() '---------------------

        If temporTempP.Text < temporarP0.Text Then temporTempP.Text = temporarP0.Text
        If temporP2.Text > temporTempP.Text Then temporP2.Text = temporP2.Text Else temporP2.Text = temporTempP.Text

        mKmaxBank.Text = FormatNumber(temporarP0a.Text, 5)

        temporP2.Text = 0 '----------------------print & clear

        u(1) = pomocniU1.Text
        u(2) = pomocniU2.Text
        u(3) = pomocniU3.Text
        u(4) = pomocniU4.Text
        u(5) = pomocniU5.Text
        u(6) = pomocniU6.Text
        u(7) = pomocniU7.Text
        u(8) = pomocniU8.Text
        u(9) = pomocniU9.Text
        u(10) = pomocniU10.Text
        u(11) = pomocniU11.Text
        u(12) = pomocniU12.Text
        u(13) = pomocniU13.Text
        u(14) = pomocniU14.Text
        u(15) = pomocniU15.Text
        u(16) = pomocniU16.Text


        For apFill = 1 To Y
            If u(apFill) = 0 Then u(apFill) = tempStepU.Text * 1 / 10 Else u(apFill) = u(apFill)
            tempSumaOptiU.Text = u(apFill)
            OptimumU.Text = OptimumU.Text & FormatNumber(u(apFill), 4) & Environment.NewLine
        Next apFill
        SumOptiU = tempSumaOptiU.Text
        SumOpti.Text = FormatNumber(pomocniU1.Text * 1 + pomocniU2.Text * 1 + pomocniU3.Text * 1 + pomocniU4.Text * 1 + pomocniU5.Text * 1 + pomocniU6.Text * 1 + pomocniU7.Text * 1 + pomocniU8.Text * 1 + pomocniU9.Text * 1 + pomocniU10.Text * 1 + pomocniU11.Text * 1 + pomocniU12.Text * 1 + pomocniU13.Text * 1 + pomocniU14.Text * 1 + pomocniU15.Text * 1 + pomocniU16.Text * 1, 4)

        tempU1.Text = u(1)
        tempU2.Text = u(2)
        tempU3.Text = u(3)
        tempU4.Text = u(4)
        tempU5.Text = u(5)
        tempU6.Text = u(6)
        tempU7.Text = u(7)
        tempU8.Text = u(8)
        tempU9.Text = u(9)
        tempU10.Text = u(10)
        tempU11.Text = u(11)
        tempU12.Text = u(12)
        tempU13.Text = u(13)
        tempU14.Text = u(14)
        tempU15.Text = u(15)
        tempU16.Text = u(16)

        temporarP0.Text = 0
        temporarP1.Text = 0
        temporP2.Text = 0
        temporTempP.Text = 0

        tempU1.Text = tempTextInputU1.Text
        tempU2.Text = tempTextInputU2.Text
        tempU3.Text = tempTextInputU3.Text
        tempU4.Text = tempTextInputU4.Text
        tempU5.Text = tempTextInputU5.Text
        tempU6.Text = tempTextInputU6.Text
        tempU7.Text = tempTextInputU7.Text
        tempU8.Text = tempTextInputU8.Text
        tempU9.Text = tempTextInputU9.Text
        tempU10.Text = tempTextInputU10.Text
        tempU11.Text = tempTextInputU11.Text
        tempU12.Text = tempTextInputU12.Text
        tempU13.Text = tempTextInputU13.Text
        tempU14.Text = tempTextInputU14.Text
        tempU15.Text = tempTextInputU15.Text
        tempU16.Text = tempTextInputU16.Text

        Call EquationB()
        MaxIputedB.Text = FormatNumber(temporarP1.Text, 5)

        temporarP0.Text = 0
        temporarP1.Text = 0
        temporP2.Text = 0
        temporTempP.Text = 0

        tempStpCntr.Text = tempRedBr.Text * 1 - 1

    End Sub

    Private Sub DiagonalAprox()
        Y = tempRedBr.Text * 1 - 1

        k(1) = tempK1.Text
        k(2) = tempK2.Text
        k(3) = tempK3.Text
        k(4) = tempK4.Text
        k(5) = tempK5.Text
        k(6) = tempK6.Text
        k(7) = tempK7.Text
        k(8) = tempK8.Text
        k(9) = tempK9.Text
        k(10) = tempK10.Text
        k(11) = tempK11.Text
        k(12) = tempK12.Text
        k(13) = tempK13.Text
        k(14) = tempK14.Text
        k(15) = tempK15.Text
        k(16) = tempK16.Text

        u(1) = tempU1.Text
        u(2) = tempU2.Text
        u(3) = tempU3.Text
        u(4) = tempU4.Text
        u(5) = tempU5.Text
        u(6) = tempU6.Text
        u(7) = tempU7.Text
        u(8) = tempU8.Text
        u(9) = tempU9.Text
        u(10) = tempU10.Text
        u(11) = tempU11.Text
        u(12) = tempU12.Text
        u(13) = tempU13.Text
        u(14) = tempU14.Text
        u(15) = tempU15.Text
        u(16) = tempU16.Text

        s(1) = tempS1.Text
        s(2) = tempS2.Text
        s(3) = tempS3.Text
        s(4) = tempS4.Text
        s(5) = tempS5.Text
        s(6) = tempS6.Text
        s(7) = tempS7.Text
        s(8) = tempS8.Text
        s(9) = tempS9.Text
        s(10) = tempS10.Text
        s(11) = tempS11.Text
        s(12) = tempS12.Text
        s(13) = tempS13.Text
        s(14) = tempS14.Text
        s(15) = tempS15.Text
        s(16) = tempS16.Text
        ' (1.)  
        SumFill = 0

        For apFill = 1 To Y
            SpointKn(apFill) = (k(apFill) * s(apFill) - 1) / (k(apFill) - 1)
            SumFill = SumFill + SpointKn(apFill)
        Next apFill

        If SumFill < 1 Then GoTo GetOutLAFQuick

        ' (2.)
        For LoopApfill = stepU To SumFill Step stepU
            GetOutLAF = 0
            For apFill = 1 To Y
                SpointKn(apFill) = SpointKn(apFill) - stepU
                If SpointKn(apFill) < 0 Then SpointKn(apFill) = 0
                GetOutLAF = GetOutLAF + SpointKn(apFill)
            Next apFill
            If GetOutLAF <= 1 Then GoTo GetOutLAFQuick
        Next LoopApfill

GetOutLAFQuick:
        For apFill = 1 To Y
            u(apFill) = SpointKn(apFill)
        Next apFill

        tempU1.Text = u(1)
        tempU2.Text = u(2)
        tempU3.Text = u(3)
        tempU4.Text = u(4)
        tempU5.Text = u(5)
        tempU6.Text = u(6)
        tempU7.Text = u(7)
        tempU8.Text = u(8)
        tempU9.Text = u(9)
        tempU10.Text = u(10)
        tempU11.Text = u(11)
        tempU12.Text = u(12)
        tempU13.Text = u(13)
        tempU14.Text = u(14)
        tempU15.Text = u(15)
        tempU16.Text = u(16)

DAprox3rd:  ' (3.)
        Y = tempRedBr.Text * 1 - 1

        P1 = temporarP1.Text

        For apFill = 1 To Y
            If u(apFill) < 0 Then u(apFill) = 0 Else u(apFill) = u(apFill) - stepU
        Next apFill

        tempU1.Text = u(1)
        tempU2.Text = u(2)
        tempU3.Text = u(3)
        tempU4.Text = u(4)
        tempU5.Text = u(5)
        tempU6.Text = u(6)
        tempU7.Text = u(7)
        tempU8.Text = u(8)
        tempU9.Text = u(9)
        tempU10.Text = u(10)
        tempU11.Text = u(11)
        tempU12.Text = u(12)
        tempU13.Text = u(13)
        tempU14.Text = u(14)
        tempU15.Text = u(15)
        tempU16.Text = u(16)

        Call EquationB() '-------------------------

        If temporarP0.Text <= P1 Then GoTo DAprox3rd

    End Sub

    Private Sub EquationB()
        Y = tempRedBr.Text * 1 - 1
        tempForProbaj.Text = 0

        k(1) = tempK1.Text
        k(2) = tempK2.Text
        k(3) = tempK3.Text
        k(4) = tempK4.Text
        k(5) = tempK5.Text
        k(6) = tempK6.Text
        k(7) = tempK7.Text
        k(8) = tempK8.Text
        k(9) = tempK9.Text
        k(10) = tempK10.Text
        k(11) = tempK11.Text
        k(12) = tempK12.Text
        k(13) = tempK13.Text
        k(14) = tempK14.Text
        k(15) = tempK15.Text
        k(16) = tempK16.Text

        u(1) = tempU1.Text
        u(2) = tempU2.Text
        u(3) = tempU3.Text
        u(4) = tempU4.Text
        u(5) = tempU5.Text
        u(6) = tempU6.Text
        u(7) = tempU7.Text
        u(8) = tempU8.Text
        u(9) = tempU9.Text
        u(10) = tempU10.Text
        u(11) = tempU11.Text
        u(12) = tempU12.Text
        u(13) = tempU13.Text
        u(14) = tempU14.Text
        u(15) = tempU15.Text
        u(16) = tempU16.Text

        s(1) = tempS1.Text
        s(2) = tempS2.Text
        s(3) = tempS3.Text
        s(4) = tempS4.Text
        s(5) = tempS5.Text
        s(6) = tempS6.Text
        s(7) = tempS7.Text
        s(8) = tempS8.Text
        s(9) = tempS9.Text
        s(10) = tempS10.Text
        s(11) = tempS11.Text
        s(12) = tempS12.Text
        s(13) = tempS13.Text
        s(14) = tempS14.Text
        s(15) = tempS15.Text
        s(16) = tempS16.Text

        temporStop.Text = temporStop.Text * 1 + 1

        P1 = 1
        decNo = tempForProbaj.Text
        For nulS = 0 To 65537
            Suma(nulS) = 0
            Pp(nulS) = 1
        Next nulS '-----------------------end preps; Start equation...

        For a = 0 To Y
            fY = 1
            fa = 1
            fYma = 1

            For FactY = 1 To Y
                fY = fY * FactY
            Next FactY
            For Facta = 1 To a
                fa = fa * Facta
            Next Facta
            For FactYma = 1 To Y - a
                fYma = fYma * FactYma
            Next FactYma

            If fY * fa * fYma = 0 Then C = 1 Else C = fY / fa / fYma

            For d = 1 To C
                sm = Convert.ToString(decNo, 2).PadLeft(Y, "0"c) '"decNo" to bin(2)
                decNo = tempForProbaj.Text * 1 + 1
                tempForProbaj.Text = decNo

                For n = 1 To Y
                    m = sm.ToString().Substring(n - 1, 1)
                    Suma(decNo) = Suma(decNo) * 1 + (u(n) * ((1 - m) * k(n) - 1))
                    Pp(decNo) = Pp(decNo) * Math.Abs(s(n) - m)
                Next n
                If (1 + Suma(decNo)) <= 0 Then P1 = 0 Else P1 = P1 * (1 + Suma(decNo) * 1) ^ Pp(decNo)

            Next d

        Next a

        temporarP1.Text = P1

        If temporarP0a.Text < P1 Then pomocniU1.text = u(1)
        If temporarP0a.Text < P1 Then pomocniU2.Text = u(2)
        If temporarP0a.Text < P1 Then pomocniU3.Text = u(3)
        If temporarP0a.Text < P1 Then pomocniU4.Text = u(4)
        If temporarP0a.Text < P1 Then pomocniU5.Text = u(5)
        If temporarP0a.Text < P1 Then pomocniU6.Text = u(6)
        If temporarP0a.Text < P1 Then pomocniU7.Text = u(7)
        If temporarP0a.Text < P1 Then pomocniU8.Text = u(8)
        If temporarP0a.Text < P1 Then pomocniU9.Text = u(9)
        If temporarP0a.Text < P1 Then pomocniU10.Text = u(10)
        If temporarP0a.Text < P1 Then pomocniU11.Text = u(11)
        If temporarP0a.Text < P1 Then pomocniU12.Text = u(12)
        If temporarP0a.Text < P1 Then pomocniU13.Text = u(13)
        If temporarP0a.Text < P1 Then pomocniU14.Text = u(14)
        If temporarP0a.Text < P1 Then pomocniU15.Text = u(15)
        If temporarP0a.Text < P1 Then pomocniU16.Text = u(16)

        If temporarP0a.Text < P1 Then temporarP0a.Text = P1

        If temporStop.Text * 1 = 2 Then temporarP0.Text = P1

    End Sub
End Class