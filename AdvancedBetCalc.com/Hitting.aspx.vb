Imports System.Numerics

Public Class Hitting
    Inherits System.Web.UI.Page

    Private Sub MiscEXPECTEDHITTING_Click(sender As System.Object, e As System.EventArgs) Handles MiscEXPECTEDHITTING.Click

        '   S = y! * s^z * (1-s)^(y-z) / ( z! * (y-z)! )  
        '   ide do 27!, treba staviti BIGINTEGER za iznad...
        '   Dim MiscStDev, MiscSumSanse, MiscEXPECTED, FACTMiscBrojiloSizeMINUSBrojiloZ, FACTMiscBrojiloZ, FACTMiscSSize, MiscSanse, MiscSSize As Decimal

        Dim MiscStDev As Decimal
        Dim MiscSumSanse = BigInteger.Parse("1")
        Dim MiscEXPECTED As Decimal
        Dim FACTMiscBrojiloSizeMINUSBrojiloZ = BigInteger.Parse("1")
        Dim FACTMiscBrojiloZ = BigInteger.Parse("1")
        Dim FACTMiscSSize = BigInteger.Parse("1")
        Dim MiscSanse = BigInteger.Parse("1")
        Dim MiscSanseA = BigInteger.Parse("1")
        Dim MiscSanseB = BigInteger.Parse("1")
        Dim MiscSanseC = BigInteger.Parse("1")
        Dim MiscSSize = BigInteger.Parse("1")
        Dim MiscMArginaBI = BigInteger.Parse("1")
        Dim TEMPMisc1 = BigInteger.Parse("1")
        Dim TEMPMisc2 = BigInteger.Parse("1")
        Dim MiscSucBI = BigInteger.Parse("1")
        Dim MiscODDSBi = BigInteger.Parse("1")
        Dim MiscSanseDec As Decimal

        MiscMArgina.Text = MiscMArgina.Text * 100000
        MiscMArginaBI = MiscMArgina.Text
        MiscSSize = MiscSampSize.Text
        FACTMiscSSize = 1
        FACTMiscBrojiloZ = 1
        FACTMiscBrojiloSizeMINUSBrojiloZ = 1
        MiscSanse = 0
        MiscSanseA = 0
        MiscSanseB = 0
        MiscSanseC = 0
        MiscSumSanse = 0
        MiscStDev = 0
        MiscSucBI = MiscSuc.Text
        MiscOdds.Text = MiscOdds.Text * 100
        MiscODDSBi = MiscOdds.Text
        MiscSanseDec = 0

        MiscEXPECTED = (100000 - MiscMArgina.Text / 100) * 100 / MiscOdds.Text

        '  y!
        For MiscFactBrojilo1 = 1 To MiscSSize
            FACTMiscSSize = FACTMiscSSize * MiscFactBrojilo1
        Next MiscFactBrojilo1

        For MiscBrojiloZ = 0 To MiscSSize

            '  z!
            If MiscBrojiloZ = 0 Then FACTMiscBrojiloZ = 1 Else FACTMiscBrojiloZ = FACTMiscBrojiloZ * MiscBrojiloZ

            '  (y-z)!
            For MiscBrojiloSizeMINUSBrojiloZ = 0 To (MiscSSize - MiscBrojiloZ)
                If MiscBrojiloSizeMINUSBrojiloZ = 0 Then FACTMiscBrojiloSizeMINUSBrojiloZ = 1 Else FACTMiscBrojiloSizeMINUSBrojiloZ = FACTMiscBrojiloSizeMINUSBrojiloZ * MiscBrojiloSizeMINUSBrojiloZ
            Next MiscBrojiloSizeMINUSBrojiloZ

            '    (s^z)  *100000^MiscBrojiloZ
            For MiscFAKTOR1 = 0 To MiscBrojiloZ
                If MiscFAKTOR1 = 0 Then TEMPMisc1 = 100000 Else TEMPMisc1 = TEMPMisc1 * ((100000 - MiscMArginaBI / 100) * 100 / MiscODDSBi)
            Next MiscFAKTOR1

            '    (1-s)^(y-z)  *100000^(MiscSSize - MiscBrojiloZ)
            For MiscFAKTOR2 = 0 To (MiscSSize - MiscBrojiloZ)
                If MiscFAKTOR2 = 0 Then TEMPMisc2 = 100000 Else TEMPMisc2 = TEMPMisc2 * (100000 - ((100000 - MiscMArginaBI / 100) * 100 / MiscODDSBi))
            Next MiscFAKTOR2

            MiscSanseA = FACTMiscSSize * TEMPMisc1
            MiscSanseB = TEMPMisc2
            MiscSanseC = (FACTMiscBrojiloZ * FACTMiscBrojiloSizeMINUSBrojiloZ)

            MiscSanse = MiscSanseA * MiscSanseB / MiscSanseC

            If MiscSucBI > MiscBrojiloZ Then MiscSumSanse = MiscSanse + MiscSumSanse Else MiscSumSanse = MiscSumSanse

            For MiscBrojSt1 = 1 To (0 + MiscSampSize.Text)
                MiscSanse = MiscSanse / 100000
            Next MiscBrojSt1
            MiscSanseDec = Convert.ToString(MiscSanse) / 100000 ^ 2

            MiscStDev = MiscStDev + ((MiscSanseDec - 1 / (1 + MiscSampSize.Text)) * (MiscSanseDec - 1 / (1 + MiscSampSize.Text))) / (1 + MiscSampSize.Text)

        Next MiscBrojiloZ
        MiscMArgina.Text = FormatNumber(MiscMArgina.Text / 100000, 2)
        MiscOdds.Text = FormatNumber(MiscOdds.Text / 100, 2)

        For MiscBrojRez = 1 To (1 + MiscSampSize.Text)
            MiscSumSanse = MiscSumSanse / 100000
        Next MiscBrojRez
        MiscChForThat.Text = FormatNumber(100 * (1 - Convert.ToString(MiscSumSanse) / 100000), 2)

        MiscExpminp.Text = MiscStDev

        MiscExpminp.Text = FormatNumber((MiscEXPECTED / 100000 - MiscStDev ^ (1 / 2) * DevijacijaN.Text) * 100, 2)
        MiscExpmaxp.Text = FormatNumber((MiscEXPECTED / 100000 + MiscStDev ^ (1 / 2) * DevijacijaN.Text) * 100, 2)
        If MiscExpminp.Text < 0 Then MiscExpminp.Text = 0
        If MiscExpmaxp.Text > 100 Then MiscExpmaxp.Text = 100
        MiscExpminN.Text = FormatNumber((MiscEXPECTED / 100000 - MiscStDev ^ (1 / 2) * DevijacijaN.Text) * MiscSampSize.Text, 0)
        MiscExpmaxN.Text = FormatNumber((MiscEXPECTED / 100000 + MiscStDev ^ (1 / 2) * DevijacijaN.Text) * MiscSampSize.Text, 0)

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