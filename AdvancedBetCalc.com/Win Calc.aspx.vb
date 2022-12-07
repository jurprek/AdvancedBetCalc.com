Public Class SystemCalculator
    Inherits System.Web.UI.Page
    Dim kkkk(20) As String
    Dim rrrr(20) As String
    Dim acc, jpm, tgb, jku, qwqw, hht, eet, nnn, mmm, jj1, jj2, jj3, jj4, jj5, jj6, jj7, jj8, jj9, jj10, jj11, jj12, jj13, jj14, jj15, jj16, jj17, jj18, jj19, jj20, k, ulog, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, ca, cb, cd, ce, cf, cg, ch, ci, cj, ck, cl, cm, cn, co, cp, cq, cr, cs, ct, cu, x, y, a, b, brkom, d, el, f, g, h, i, j, l, m, n, o, p, q, r, s, t, u, v, w, z As Decimal
    Protected Sub ImageButtonUK_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonUK.Click
        TextBoxHelpUK.Visible = True
        TextBoxHelpHR.Visible = False
    End Sub

    Protected Sub ImageButtonHR_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonHR.Click
        TextBoxHelpUK.Visible = False
        TextBoxHelpHR.Visible = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'ovo je tu da dopusti drugim stranicama.aspx da povuku vrijednost sysY.text, avrgchances.text i avrgkfc.text...
        If sysY.Text = ("") Then Session("myVariable1") = 2 Else Session("myVariable1") = sysY.Text
        Session("myVariable2") = 50.03
        Session("myVariable3") = 2.04



    End Sub

    Protected Sub ClcBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClcBtn.Click

        Dim k(25)





        '---------------------------------------------------------------------------------------------------------------

        'k(1) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 1 Then GoTo pocetak
STARTDECIMAL1:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC1 Else If DDown1.Text = 3 Then GoTo AMER1 Else k(1) = K1.Text
        GoTo KRAJDECIMAL1
FRAC1:
        Dim aacount1 As String
        Dim ammm1 As Decimal
        Dim value1a As String = K1.Text
        Dim value1b As String = value1a.Replace("/", ".")
        Dim value1c As String = Int(value1b)
        aacount1 = value1a.Length - 1
        ammm1 = aacount1
        aacount1 = value1c.Length
        If ammm1 - aacount1 = 1 Then k(1) = Int(value1b) / ((value1b - Int(value1b)) * 10) + 1 Else If ammm1 - aacount1 = 2 Then k(1) = Int(value1b) / ((value1b - Int(value1b)) * 100) + 1 Else k(1) = Int(value1b) / ((value1b - Int(value1b)) * 1000) + 1
        GoTo KRAJDECIMAL1
AMER1:
        If K1.Text > 0 Then k(1) = K1.Text / 100 + 1 Else k(1) = (-100 + K1.Text) / K1.Text
KRAJDECIMAL1:
        K1.Text = Format(k(1), "fixed")

        'k(2) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 2 Then GoTo pocetak
STARTDECIMAL2:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC2 Else If DDown1.Text = 3 Then GoTo AMER2 Else k(2) = K2.Text
        GoTo KRAJDECIMAL2
FRAC2:
        Dim aacount2 As String
        Dim ammm2 As Decimal
        Dim value2a As String = K2.Text
        Dim value2b As String = value2a.Replace("/", ".")
        Dim value2c As String = Int(value2b)
        aacount2 = value2a.Length - 1
        ammm2 = aacount2
        aacount2 = value2c.Length
        If ammm2 - aacount2 = 1 Then k(2) = Int(value2b) / ((value2b - Int(value2b)) * 10) + 1 Else If ammm2 - aacount2 = 2 Then k(2) = Int(value2b) / ((value2b - Int(value2b)) * 100) + 1 Else k(2) = Int(value2b) / ((value2b - Int(value2b)) * 1000) + 1
        GoTo KRAJDECIMAL2
AMER2:
        If K2.Text > 0 Then k(2) = K2.Text / 100 + 1 Else k(2) = (-100 + K2.Text) / K2.Text
KRAJDECIMAL2:
        K2.Text = Format(k(2), "fixed")

        'k(3) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 3 Then GoTo pocetak
STARTDECIMAL3:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC3 Else If DDown1.Text = 3 Then GoTo AMER3 Else k(3) = K3.Text
        GoTo KRAJDECIMAL3
FRAC3:
        Dim aacount3 As String
        Dim ammm3 As Decimal
        Dim value3a As String = K3.Text
        Dim value3b As String = value3a.Replace("/", ".")
        Dim value3c As String = Int(value3b)
        aacount3 = value3a.Length - 1
        ammm3 = aacount3
        aacount3 = value3c.Length
        If ammm3 - aacount3 = 1 Then k(3) = Int(value3b) / ((value3b - Int(value3b)) * 10) + 1 Else If ammm3 - aacount3 = 2 Then k(3) = Int(value3b) / ((value3b - Int(value3b)) * 100) + 1 Else k(3) = Int(value3b) / ((value3b - Int(value3b)) * 1000) + 1
        GoTo KRAJDECIMAL3
AMER3:
        If K3.Text > 0 Then k(3) = K3.Text / 100 + 1 Else k(3) = (-100 + K3.Text) / K3.Text
KRAJDECIMAL3:
        K3.Text = Format(k(3), "fixed")

        'k(4) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 4 Then GoTo pocetak
STARTDECIMAL4:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC4 Else If DDown1.Text = 3 Then GoTo AMER4 Else k(4) = K4.Text
        GoTo KRAJDECIMAL4
FRAC4:
        Dim aacount4 As String
        Dim ammm4 As Decimal
        Dim value4a As String = K4.Text
        Dim value4b As String = value4a.Replace("/", ".")
        Dim value4c As String = Int(value4b)
        aacount4 = value4a.Length - 1
        ammm4 = aacount4
        aacount4 = value4c.Length
        If ammm4 - aacount4 = 1 Then k(4) = Int(value4b) / ((value4b - Int(value4b)) * 10) + 1 Else If ammm4 - aacount4 = 2 Then k(4) = Int(value4b) / ((value4b - Int(value4b)) * 100) + 1 Else k(4) = Int(value4b) / ((value4b - Int(value4b)) * 1000) + 1
        GoTo KRAJDECIMAL4
AMER4:
        If K4.Text > 0 Then k(4) = K4.Text / 100 + 1 Else k(4) = (-100 + K4.Text) / K4.Text
KRAJDECIMAL4:
        K4.Text = Format(k(4), "fixed")

        'K(5) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 5 Then GoTo pocetak
STARTDECIMAL5:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC5 Else If DDown1.Text = 3 Then GoTo AMER5 Else k(5) = K5.Text
        GoTo KRAJDECIMAL5
FRAC5:
        Dim aacount5 As String
        Dim ammm5 As Decimal
        Dim value5a As String = K5.Text
        Dim value5b As String = value5a.Replace("/", ".")
        Dim value5c As String = Int(value5b)
        aacount5 = value5a.Length - 1
        ammm5 = aacount5
        aacount5 = value5c.Length
        If ammm5 - aacount5 = 1 Then k(5) = Int(value5b) / ((value5b - Int(value5b)) * 10) + 1 Else If ammm5 - aacount5 = 2 Then k(5) = Int(value5b) / ((value5b - Int(value5b)) * 100) + 1 Else k(5) = Int(value5b) / ((value5b - Int(value5b)) * 1000) + 1
        GoTo KRAJDECIMAL5
AMER5:
        If K5.Text > 0 Then k(5) = K5.Text / 100 + 1 Else k(5) = (-100 + K5.Text) / K5.Text
KRAJDECIMAL5:
        K5.Text = Format(k(5), "fixed")

        'K(6) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 6 Then GoTo pocetak
STARTDECIMAL6:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC6 Else If DDown1.Text = 3 Then GoTo AMER6 Else k(6) = K6.Text
        GoTo KRAJDECIMAL6
FRAC6:
        Dim aacount6 As String
        Dim ammm6 As Decimal
        Dim value6a As String = K6.Text
        Dim value6b As String = value6a.Replace("/", ".")
        Dim value6c As String = Int(value6b)
        aacount6 = value6a.Length - 1
        ammm6 = aacount6
        aacount6 = value6c.Length
        If ammm6 - aacount6 = 1 Then k(6) = Int(value6b) / ((value6b - Int(value6b)) * 10) + 1 Else If ammm6 - aacount6 = 2 Then k(6) = Int(value6b) / ((value6b - Int(value6b)) * 100) + 1 Else k(6) = Int(value6b) / ((value6b - Int(value6b)) * 1000) + 1
        GoTo KRAJDECIMAL6
AMER6:
        If K6.Text > 0 Then k(6) = K6.Text / 100 + 1 Else k(6) = (-100 + K6.Text) / K6.Text
KRAJDECIMAL6:
        K6.Text = Format(k(6), "fixed")

        'K(7) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 7 Then GoTo pocetak
STARTDECIMAL7:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC7 Else If DDown1.Text = 3 Then GoTo AMER7 Else k(7) = K7.Text
        GoTo KRAJDECIMAL7
FRAC7:
        Dim aacount7 As String
        Dim ammm7 As Decimal
        Dim value7a As String = K7.Text
        Dim value7b As String = value7a.Replace("/", ".")
        Dim value7c As String = Int(value7b)
        aacount7 = value7a.Length - 1
        ammm7 = aacount7
        aacount7 = value7c.Length
        If ammm7 - aacount7 = 1 Then k(7) = Int(value7b) / ((value7b - Int(value7b)) * 10) + 1 Else If ammm7 - aacount7 = 2 Then k(7) = Int(value7b) / ((value7b - Int(value7b)) * 100) + 1 Else k(7) = Int(value7b) / ((value7b - Int(value7b)) * 1000) + 1
        GoTo KRAJDECIMAL7
AMER7:
        If K7.Text > 0 Then k(7) = K7.Text / 100 + 1 Else k(7) = (-100 + K7.Text) / K7.Text
KRAJDECIMAL7:
        K7.Text = Format(k(7), "fixed")
  
        'K(8) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 8 Then GoTo pocetak
STARTDECIMAL8:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC8 Else If DDown1.Text = 3 Then GoTo AMER8 Else k(8) = K8.Text
        GoTo KRAJDECIMAL8
FRAC8:
        Dim aacount8 As String
        Dim ammm8 As Decimal
        Dim value8a As String = K8.Text
        Dim value8b As String = value8a.Replace("/", ".")
        Dim value8c As String = Int(value8b)
        aacount8 = value8a.Length - 1
        ammm8 = aacount8
        aacount8 = value8c.Length
        If ammm8 - aacount8 = 1 Then k(8) = Int(value8b) / ((value8b - Int(value8b)) * 10) + 1 Else If ammm8 - aacount8 = 2 Then k(8) = Int(value8b) / ((value8b - Int(value8b)) * 100) + 1 Else k(8) = Int(value8b) / ((value8b - Int(value8b)) * 1000) + 1
        GoTo KRAJDECIMAL8
AMER8:
        If K8.Text > 0 Then k(8) = K8.Text / 100 + 1 Else k(8) = (-100 + K8.Text) / K8.Text
KRAJDECIMAL8:
        K8.Text = Format(k(8), "fixed")
  
        'K(9) postaje decimalni broj (sa zarezom) umjesto razlomka/americana sa do 5 znakova ukupno
        If sysY.Text < 9 Then GoTo pocetak
STARTDECIMAL9:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC9 Else If DDown1.Text = 3 Then GoTo AMER9 Else k(9) = K9.Text
        GoTo KRAJDECIMAL9
FRAC9:
        Dim aacount9 As String
        Dim ammm9 As Decimal
        Dim value9a As String = K9.Text
        Dim value9b As String = value9a.Replace("/", ".")
        Dim value9c As String = Int(value9b)
        aacount9 = value9a.Length - 1
        ammm9 = aacount9
        aacount9 = value9c.Length
        If ammm9 - aacount9 = 1 Then k(9) = Int(value9b) / ((value9b - Int(value9b)) * 10) + 1 Else If ammm9 - aacount9 = 2 Then k(9) = Int(value9b) / ((value9b - Int(value9b)) * 100) + 1 Else k(9) = Int(value9b) / ((value9b - Int(value9b)) * 1000) + 1
        GoTo KRAJDECIMAL9
AMER9:
        If K9.Text > 0 Then k(9) = K9.Text / 100 + 1 Else k(9) = (-100 + K9.Text) / K9.Text
KRAJDECIMAL9:
        K9.Text = Format(k(9), "fixed")

        'k(10) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 10 Then GoTo pocetak
STARTDECIMAL10:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC10 Else If DDown1.Text = 3 Then GoTo AMER10 Else k(10) = K10.Text
        GoTo KRAJDECIMAL10
FRAC10:
        Dim aacount10 As String
        Dim ammm10 As Decimal
        Dim value10a As String = K10.Text
        Dim value10b As String = value10a.Replace("/", ".")
        Dim value10c As String = Int(value10b)
        aacount10 = value10a.Length - 1
        ammm10 = aacount10
        aacount10 = value10c.Length
        If ammm10 - aacount10 = 1 Then k(10) = Int(value10b) / ((value10b - Int(value10b)) * 10) + 1 Else If ammm10 - aacount10 = 2 Then k(10) = Int(value10b) / ((value10b - Int(value10b)) * 100) + 1 Else k(10) = Int(value10b) / ((value10b - Int(value10b)) * 1000) + 1
        GoTo KRAJDECIMAL10
AMER10:
        If K10.Text > 0 Then k(10) = K10.Text / 100 + 1 Else k(10) = (-100 + K10.Text) / K10.Text
KRAJDECIMAL10:
        K10.Text = Format(k(10), "fixed")

        'k(11) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 11 Then GoTo pocetak
STARTDECIMAL11:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC11 Else If DDown1.Text = 3 Then GoTo AMER11 Else k(11) = K11.Text
        GoTo KRAJDECIMAL11
FRAC11:
        Dim aacount11 As String
        Dim ammm11 As Decimal
        Dim value11a As String = K11.Text
        Dim value11b As String = value11a.Replace("/", ".")
        Dim value11c As String = Int(value11b)
        aacount11 = value11a.Length - 1
        ammm11 = aacount11
        aacount11 = value11c.Length
        If ammm11 - aacount11 = 1 Then k(11) = Int(value11b) / ((value11b - Int(value11b)) * 10) + 1 Else If ammm11 - aacount11 = 2 Then k(11) = Int(value11b) / ((value11b - Int(value11b)) * 100) + 1 Else k(11) = Int(value11b) / ((value11b - Int(value11b)) * 1000) + 1
        GoTo KRAJDECIMAL11
AMER11:
        If K11.Text > 0 Then k(11) = K11.Text / 100 + 1 Else k(11) = (-100 + K11.Text) / K11.Text
KRAJDECIMAL11:
        K11.Text = Format(k(11), "fixed")

        'k(12) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 12 Then GoTo pocetak
STARTDECIMAL12:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC12 Else If DDown1.Text = 3 Then GoTo AMER12 Else k(12) = K12.Text
        GoTo KRAJDECIMAL12
FRAC12:
        Dim aacount12 As String
        Dim ammm12 As Decimal
        Dim value12a As String = K12.Text
        Dim value12b As String = value12a.Replace("/", ".")
        Dim value12c As String = Int(value12b)
        aacount12 = value12a.Length - 1
        ammm12 = aacount12
        aacount12 = value12c.Length
        If ammm12 - aacount12 = 1 Then k(12) = Int(value12b) / ((value12b - Int(value12b)) * 10) + 1 Else If ammm12 - aacount12 = 2 Then k(12) = Int(value12b) / ((value12b - Int(value12b)) * 100) + 1 Else k(12) = Int(value12b) / ((value12b - Int(value12b)) * 1000) + 1
        GoTo KRAJDECIMAL12
AMER12:
        If K12.Text > 0 Then k(12) = K12.Text / 100 + 1 Else k(12) = (-100 + K12.Text) / K12.Text
KRAJDECIMAL12:
        K12.Text = Format(k(12), "fixed")

        'k(13) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 13 Then GoTo pocetak
STARTDECIMAL13:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC13 Else If DDown1.Text = 3 Then GoTo AMER13 Else k(13) = K13.Text
        GoTo KRAJDECIMAL13
FRAC13:
        Dim aacount13 As String
        Dim ammm13 As Decimal
        Dim value13a As String = K13.Text
        Dim value13b As String = value13a.Replace("/", ".")
        Dim value13c As String = Int(value13b)
        aacount13 = value13a.Length - 1
        ammm13 = aacount13
        aacount13 = value13c.Length
        If ammm13 - aacount13 = 1 Then k(13) = Int(value13b) / ((value13b - Int(value13b)) * 10) + 1 Else If ammm13 - aacount13 = 2 Then k(13) = Int(value13b) / ((value13b - Int(value13b)) * 100) + 1 Else k(13) = Int(value13b) / ((value13b - Int(value13b)) * 1000) + 1
        GoTo KRAJDECIMAL13
AMER13:
        If K13.Text > 0 Then k(13) = K13.Text / 100 + 1 Else k(13) = (-100 + K13.Text) / K13.Text
KRAJDECIMAL13:
        K13.Text = Format(k(13), "fixed")

        'k(14) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 14 Then GoTo pocetak
STARTDECIMAL14:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC14 Else If DDown1.Text = 3 Then GoTo AMER14 Else k(14) = K14.Text
        GoTo KRAJDECIMAL14
FRAC14:
        Dim aacount14 As String
        Dim ammm14 As Decimal
        Dim value14a As String = K14.Text
        Dim value14b As String = value14a.Replace("/", ".")
        Dim value14c As String = Int(value14b)
        aacount14 = value14a.Length - 1
        ammm14 = aacount14
        aacount14 = value14c.Length
        If ammm14 - aacount14 = 1 Then k(14) = Int(value14b) / ((value14b - Int(value14b)) * 10) + 1 Else If ammm14 - aacount14 = 2 Then k(14) = Int(value14b) / ((value14b - Int(value14b)) * 100) + 1 Else k(14) = Int(value14b) / ((value14b - Int(value14b)) * 1000) + 1
        GoTo KRAJDECIMAL14
AMER14:
        If K14.Text > 0 Then k(14) = K14.Text / 100 + 1 Else k(14) = (-100 + K14.Text) / K14.Text
KRAJDECIMAL14:
        K14.Text = Format(k(14), "fixed")

        'K(15) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 15 Then GoTo pocetak
STARTDECIMAL15:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC15 Else If DDown1.Text = 3 Then GoTo AMER15 Else k(15) = K15.Text
        GoTo KRAJDECIMAL15
FRAC15:
        Dim aacount15 As String
        Dim ammm15 As Decimal
        Dim value15a As String = K15.Text
        Dim value15b As String = value15a.Replace("/", ".")
        Dim value15c As String = Int(value15b)
        aacount15 = value15a.Length - 1
        ammm15 = aacount15
        aacount15 = value15c.Length
        If ammm15 - aacount15 = 1 Then k(15) = Int(value15b) / ((value15b - Int(value15b)) * 10) + 1 Else If ammm15 - aacount15 = 2 Then k(15) = Int(value15b) / ((value15b - Int(value15b)) * 100) + 1 Else k(15) = Int(value15b) / ((value15b - Int(value15b)) * 1000) + 1
        GoTo KRAJDECIMAL15
AMER15:
        If K15.Text > 0 Then k(15) = K15.Text / 100 + 1 Else k(15) = (-100 + K15.Text) / K15.Text
KRAJDECIMAL15:
        K15.Text = Format(k(15), "fixed")

        'K(16) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 16 Then GoTo pocetak
STARTDECIMAL16:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC16 Else If DDown1.Text = 3 Then GoTo AMER16 Else k(16) = K16.Text
        GoTo KRAJDECIMAL16
FRAC16:
        Dim aacount16 As String
        Dim ammm16 As Decimal
        Dim value16a As String = K16.Text
        Dim value16b As String = value16a.Replace("/", ".")
        Dim value16c As String = Int(value16b)
        aacount16 = value16a.Length - 1
        ammm16 = aacount16
        aacount16 = value16c.Length
        If ammm16 - aacount16 = 1 Then k(16) = Int(value16b) / ((value16b - Int(value16b)) * 10) + 1 Else If ammm16 - aacount16 = 2 Then k(16) = Int(value16b) / ((value16b - Int(value16b)) * 100) + 1 Else k(16) = Int(value16b) / ((value16b - Int(value16b)) * 1000) + 1
        GoTo KRAJDECIMAL16
AMER16:
        If K16.Text > 0 Then k(16) = K16.Text / 100 + 1 Else k(16) = (-100 + K16.Text) / K16.Text
KRAJDECIMAL16:
        K16.Text = Format(k(16), "fixed")

        'K(17) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 17 Then GoTo pocetak
STARTDECIMAL17:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC17 Else If DDown1.Text = 3 Then GoTo AMER17 Else k(17) = K17.Text
        GoTo KRAJDECIMAL17
FRAC17:
        Dim aacount17 As String
        Dim ammm17 As Decimal
        Dim value17a As String = K17.Text
        Dim value17b As String = value17a.Replace("/", ".")
        Dim value17c As String = Int(value17b)
        aacount17 = value17a.Length - 1
        ammm17 = aacount17
        aacount17 = value17c.Length
        If ammm17 - aacount17 = 1 Then k(17) = Int(value17b) / ((value17b - Int(value17b)) * 10) + 1 Else If ammm17 - aacount17 = 2 Then k(17) = Int(value17b) / ((value17b - Int(value17b)) * 100) + 1 Else k(17) = Int(value17b) / ((value17b - Int(value17b)) * 1000) + 1
        GoTo KRAJDECIMAL17
AMER17:
        If K17.Text > 0 Then k(17) = K17.Text / 100 + 1 Else k(17) = (-100 + K17.Text) / K17.Text
KRAJDECIMAL17:
        K17.Text = Format(k(17), "fixed")

        'K(18) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 18 Then GoTo pocetak
STARTDECIMAL18:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC18 Else If DDown1.Text = 3 Then GoTo AMER18 Else k(18) = K18.Text
        GoTo KRAJDECIMAL18
FRAC18:
        Dim aacount18 As String
        Dim ammm18 As Decimal
        Dim value18a As String = K18.Text
        Dim value18b As String = value18a.Replace("/", ".")
        Dim value18c As String = Int(value18b)
        aacount18 = value18a.Length - 1
        ammm18 = aacount18
        aacount18 = value18c.Length
        If ammm18 - aacount18 = 1 Then k(18) = Int(value18b) / ((value18b - Int(value18b)) * 10) + 1 Else If ammm18 - aacount18 = 2 Then k(18) = Int(value18b) / ((value18b - Int(value18b)) * 100) + 1 Else k(18) = Int(value18b) / ((value18b - Int(value18b)) * 1000) + 1
        GoTo KRAJDECIMAL18
AMER18:
        If K18.Text > 0 Then k(18) = K18.Text / 100 + 1 Else k(18) = (-100 + K18.Text) / K18.Text
KRAJDECIMAL18:
        K18.Text = Format(k(18), "fixed")
 
        'K(19) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 19 Then GoTo pocetak
STARTDECIMAL19:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC19 Else If DDown1.Text = 3 Then GoTo AMER19 Else k(19) = K19.Text
        GoTo KRAJDECIMAL19
FRAC19:
        Dim aacount19 As String
        Dim ammm19 As Decimal
        Dim value19a As String = K19.Text
        Dim value19b As String = value19a.Replace("/", ".")
        Dim value19c As String = Int(value19b)
        aacount19 = value19a.Length - 1
        ammm19 = aacount19
        aacount19 = value19c.Length
        If ammm19 - aacount19 = 1 Then k(19) = Int(value19b) / ((value19b - Int(value19b)) * 10) + 1 Else If ammm19 - aacount19 = 2 Then k(19) = Int(value19b) / ((value19b - Int(value19b)) * 100) + 1 Else k(19) = Int(value19b) / ((value19b - Int(value19b)) * 1000) + 1
        GoTo KRAJDECIMAL19
AMER19:
        If K19.Text > 0 Then k(19) = K19.Text / 100 + 1 Else k(19) = (-100 + K19.Text) / K19.Text
KRAJDECIMAL19:
        K19.Text = Format(k(19), "fixed")
 
        'k(20) postaje decimalni broj (sa zarezom) umjesto razlomka/amer1icana sa do 5 znakova ukupno
        If sysY.Text < 20 Then GoTo pocetak
STARTDECIMAL20:

        If DDown1.Text = 1 Then GoTo DECI
        If DDown1.Text = 2 Then GoTo FRAC20 Else If DDown1.Text = 3 Then GoTo AMER20 Else k(20) = K20.Text
        GoTo KRAJDECIMAL20
FRAC20:
        Dim aacount20 As String
        Dim ammm20 As Decimal
        Dim value20a As String = K20.Text
        Dim value20b As String = value20a.Replace("/", ".")
        Dim value20c As String = Int(value20b)
        aacount20 = value20a.Length - 1
        ammm20 = aacount20
        aacount20 = value20c.Length
        If ammm20 - aacount20 = 1 Then k(20) = Int(value20b) / ((value20b - Int(value20b)) * 20) + 1 Else If ammm20 - aacount20 = 2 Then k(20) = Int(value20b) / ((value20b - Int(value20b)) * 200) + 1 Else k(20) = Int(value20b) / ((value20b - Int(value20b)) * 2000) + 1
        GoTo KRAJDECIMAL20
AMER20:
        If K20.Text > 0 Then k(20) = K20.Text / 100 + 1 Else k(20) = (-100 + K20.Text) / K20.Text
KRAJDECIMAL20:
        K20.Text = Format(k(20), "fixed")
DECI:
pocetak:
        DDown1.Text = ("Decimal")
        DDown1.Text = 1

        '------------------------------------------------------------------------------------------------

        acc = 1
        kkkk(0) = 1
        If K1.Text = ("") Then kkkk(1) = 0 Else kkkk(1) = K1.Text
        If K2.Text = ("") Then kkkk(2) = 0 Else kkkk(2) = K2.Text
        If K3.Text = ("") Then kkkk(3) = 0 Else kkkk(3) = K3.Text
        If K4.Text = ("") Then kkkk(4) = 0 Else kkkk(4) = K4.Text
        If K5.Text = ("") Then kkkk(5) = 0 Else kkkk(5) = K5.Text
        If K6.Text = ("") Then kkkk(6) = 0 Else kkkk(6) = K6.Text
        If K7.Text = ("") Then kkkk(7) = 0 Else kkkk(7) = K7.Text
        If K8.Text = ("") Then kkkk(8) = 0 Else kkkk(8) = K8.Text
        If K9.Text = ("") Then kkkk(9) = 0 Else kkkk(9) = K9.Text
        If K10.Text = ("") Then kkkk(10) = 0 Else kkkk(10) = K10.Text
        If K11.Text = ("") Then kkkk(11) = 0 Else kkkk(11) = K11.Text
        If K12.Text = ("") Then kkkk(12) = 0 Else kkkk(12) = K12.Text
        If K13.Text = ("") Then kkkk(13) = 0 Else kkkk(13) = K13.Text
        If K14.Text = ("") Then kkkk(14) = 0 Else kkkk(14) = K14.Text
        If K15.Text = ("") Then kkkk(15) = 0 Else kkkk(15) = K15.Text
        If K16.Text = ("") Then kkkk(16) = 0 Else kkkk(16) = K16.Text
        If K17.Text = ("") Then kkkk(17) = 0 Else kkkk(17) = K17.Text
        If K18.Text = ("") Then kkkk(18) = 0 Else kkkk(18) = K18.Text
        If K19.Text = ("") Then kkkk(19) = 0 Else kkkk(19) = K19.Text
        If K20.Text = ("") Then kkkk(20) = 0 Else kkkk(20) = K20.Text


        'ovo je tu sort...
        Array.Sort(kkkk)

        'ovo je tu zamjena mjesta tako da ide od najveceg prema najmanjima...
        For tgv = 20 To 11 Step -1

            tgb = -(tgv - 21)
            jku = kkkk(tgv)
            kkkk(tgv) = kkkk(tgb)
            kkkk(tgb) = jku

        Next tgv

        For brjjl = 1 To 20

            rrrr(brjjl) = kkkk(brjjl)

        Next brjjl




        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Image1.Visible = True
        Imagearrow.Visible = True

        y = sysY.Text
        If y < 2 Then min2.Visible = False Else min2.Visible = True
        If y < 3 Then min3.Visible = False Else min3.Visible = True
        If y < 4 Then min4.Visible = False Else min4.Visible = True
        If y < 5 Then min5.Visible = False Else min5.Visible = True
        If y < 6 Then min6.Visible = False Else min6.Visible = True
        If y < 7 Then min7.Visible = False Else min7.Visible = True
        If y < 8 Then min8.Visible = False Else min8.Visible = True
        If y < 9 Then min9.Visible = False Else min9.Visible = True
        If y < 10 Then min10.Visible = False Else min10.Visible = True
        If y < 11 Then min11.Visible = False Else min11.Visible = True
        If y < 12 Then min12.Visible = False Else min12.Visible = True
        If y < 13 Then min13.Visible = False Else min13.Visible = True
        If y < 14 Then min14.Visible = False Else min14.Visible = True
        If y < 15 Then min15.Visible = False Else min15.Visible = True
        If y < 16 Then min16.Visible = False Else min16.Visible = True
        If y < 17 Then min17.Visible = False Else min17.Visible = True
        If y < 18 Then min18.Visible = False Else min18.Visible = True
        If y < 19 Then min19.Visible = False Else min19.Visible = True
        If y < 20 Then min20.Visible = False Else min20.Visible = True
        If y < 2 Then max2.Visible = False Else max2.Visible = True
        If y < 3 Then max3.Visible = False Else max3.Visible = True
        If y < 4 Then max4.Visible = False Else max4.Visible = True
        If y < 5 Then max5.Visible = False Else max5.Visible = True
        If y < 6 Then max6.Visible = False Else max6.Visible = True
        If y < 7 Then max7.Visible = False Else max7.Visible = True
        If y < 8 Then max8.Visible = False Else max8.Visible = True
        If y < 9 Then max9.Visible = False Else max9.Visible = True
        If y < 10 Then max10.Visible = False Else max10.Visible = True
        If y < 11 Then max11.Visible = False Else max11.Visible = True
        If y < 12 Then max12.Visible = False Else max12.Visible = True
        If y < 13 Then max13.Visible = False Else max13.Visible = True
        If y < 14 Then max14.Visible = False Else max14.Visible = True
        If y < 15 Then max15.Visible = False Else max15.Visible = True
        If y < 16 Then max16.Visible = False Else max16.Visible = True
        If y < 17 Then max17.Visible = False Else max17.Visible = True
        If y < 18 Then max18.Visible = False Else max18.Visible = True
        If y < 19 Then max19.Visible = False Else max19.Visible = True
        If y < 20 Then max20.Visible = False Else max20.Visible = True



        redbr1.ForeColor = Drawing.Color.Gray
        redbr2.ForeColor = Drawing.Color.Gray
        redbr3.ForeColor = Drawing.Color.Gray
        redbr4.ForeColor = Drawing.Color.Gray
        redbr5.ForeColor = Drawing.Color.Gray
        redbr6.ForeColor = Drawing.Color.Gray
        redbr7.ForeColor = Drawing.Color.Gray
        redbr8.ForeColor = Drawing.Color.Gray
        redbr9.ForeColor = Drawing.Color.Gray
        redbr10.ForeColor = Drawing.Color.Gray
        redbr11.ForeColor = Drawing.Color.Gray
        redbr12.ForeColor = Drawing.Color.Gray
        redbr13.ForeColor = Drawing.Color.Gray
        redbr14.ForeColor = Drawing.Color.Gray
        redbr15.ForeColor = Drawing.Color.Gray
        redbr16.ForeColor = Drawing.Color.Gray
        redbr17.ForeColor = Drawing.Color.Gray
        redbr18.ForeColor = Drawing.Color.Gray
        redbr19.ForeColor = Drawing.Color.Gray
        redbr20.ForeColor = Drawing.Color.Gray

        If sysY.Text < 1 Then redbr1.ForeColor = Drawing.Color.Gray Else redbr1.ForeColor = Drawing.Color.DarkBlue
        If redbr1.ForeColor <> Drawing.Color.DarkBlue Then K1.Text = ("")
        If sysY.Text < 2 Then redbr2.ForeColor = Drawing.Color.Gray Else redbr2.ForeColor = Drawing.Color.DarkBlue
        If redbr2.ForeColor <> Drawing.Color.DarkBlue Then K2.Text = ("")
        If sysY.Text < 3 Then redbr3.ForeColor = Drawing.Color.Gray Else redbr3.ForeColor = Drawing.Color.DarkBlue
        If redbr3.ForeColor <> Drawing.Color.DarkBlue Then K3.Text = ("")
        If sysY.Text < 4 Then redbr4.ForeColor = Drawing.Color.Gray Else redbr4.ForeColor = Drawing.Color.DarkBlue
        If redbr4.ForeColor <> Drawing.Color.DarkBlue Then K4.Text = ("")
        If sysY.Text < 5 Then redbr5.ForeColor = Drawing.Color.Gray Else redbr5.ForeColor = Drawing.Color.DarkBlue
        If redbr5.ForeColor <> Drawing.Color.DarkBlue Then K5.Text = ("")
        If sysY.Text < 6 Then redbr6.ForeColor = Drawing.Color.Gray Else redbr6.ForeColor = Drawing.Color.DarkBlue
        If redbr6.ForeColor <> Drawing.Color.DarkBlue Then K6.Text = ("")
        If sysY.Text < 7 Then redbr7.ForeColor = Drawing.Color.Gray Else redbr7.ForeColor = Drawing.Color.DarkBlue
        If redbr7.ForeColor <> Drawing.Color.DarkBlue Then K7.Text = ("")
        If sysY.Text < 8 Then redbr8.ForeColor = Drawing.Color.Gray Else redbr8.ForeColor = Drawing.Color.DarkBlue
        If redbr8.ForeColor <> Drawing.Color.DarkBlue Then K8.Text = ("")
        If sysY.Text < 9 Then redbr9.ForeColor = Drawing.Color.Gray Else redbr9.ForeColor = Drawing.Color.DarkBlue
        If redbr9.ForeColor <> Drawing.Color.DarkBlue Then K9.Text = ("")
        If sysY.Text < 10 Then redbr10.ForeColor = Drawing.Color.Gray Else redbr10.ForeColor = Drawing.Color.DarkBlue
        If redbr10.ForeColor <> Drawing.Color.DarkBlue Then K10.Text = ("")
        If sysY.Text < 11 Then redbr11.ForeColor = Drawing.Color.Gray Else redbr11.ForeColor = Drawing.Color.DarkBlue
        If redbr11.ForeColor <> Drawing.Color.DarkBlue Then K11.Text = ("")
        If sysY.Text < 12 Then redbr12.ForeColor = Drawing.Color.Gray Else redbr12.ForeColor = Drawing.Color.DarkBlue
        If redbr12.ForeColor <> Drawing.Color.DarkBlue Then K12.Text = ("")
        If sysY.Text < 13 Then redbr13.ForeColor = Drawing.Color.Gray Else redbr13.ForeColor = Drawing.Color.DarkBlue
        If redbr13.ForeColor <> Drawing.Color.DarkBlue Then K13.Text = ("")
        If sysY.Text < 14 Then redbr14.ForeColor = Drawing.Color.Gray Else redbr14.ForeColor = Drawing.Color.DarkBlue
        If redbr14.ForeColor <> Drawing.Color.DarkBlue Then K14.Text = ("")
        If sysY.Text < 15 Then redbr15.ForeColor = Drawing.Color.Gray Else redbr15.ForeColor = Drawing.Color.DarkBlue
        If redbr15.ForeColor <> Drawing.Color.DarkBlue Then K15.Text = ("")
        If sysY.Text < 16 Then redbr16.ForeColor = Drawing.Color.Gray Else redbr16.ForeColor = Drawing.Color.DarkBlue
        If redbr16.ForeColor <> Drawing.Color.DarkBlue Then K16.Text = ("")
        If sysY.Text < 17 Then redbr17.ForeColor = Drawing.Color.Gray Else redbr17.ForeColor = Drawing.Color.DarkBlue
        If redbr17.ForeColor <> Drawing.Color.DarkBlue Then K17.Text = ("")
        If sysY.Text < 18 Then redbr18.ForeColor = Drawing.Color.Gray Else redbr18.ForeColor = Drawing.Color.DarkBlue
        If redbr18.ForeColor <> Drawing.Color.DarkBlue Then K18.Text = ("")
        If sysY.Text < 19 Then redbr19.ForeColor = Drawing.Color.Gray Else redbr19.ForeColor = Drawing.Color.DarkBlue
        If redbr19.ForeColor <> Drawing.Color.DarkBlue Then K19.Text = ("")
        If sysY.Text < 20 Then redbr20.ForeColor = Drawing.Color.Gray Else redbr20.ForeColor = Drawing.Color.DarkBlue
        If redbr20.ForeColor <> Drawing.Color.DarkBlue Then K20.Text = ("")

        If sysX.Text = 1 Then sysX.Text = ("01")
        If sysX.Text = 2 Then sysX.Text = ("02")
        If sysX.Text = 3 Then sysX.Text = ("03")
        If sysX.Text = 4 Then sysX.Text = ("04")
        If sysX.Text = 5 Then sysX.Text = ("05")
        If sysX.Text = 6 Then sysX.Text = ("06")
        If sysX.Text = 7 Then sysX.Text = ("07")
        If sysX.Text = 8 Then sysX.Text = ("08")
        If sysX.Text = 9 Then sysX.Text = ("09")
        If sysY.Text = 1 Then sysY.Text = ("01")
        If sysY.Text = 2 Then sysY.Text = ("02")
        If sysY.Text = 3 Then sysY.Text = ("03")
        If sysY.Text = 4 Then sysY.Text = ("04")
        If sysY.Text = 5 Then sysY.Text = ("05")
        If sysY.Text = 6 Then sysY.Text = ("06")
        If sysY.Text = 7 Then sysY.Text = ("07")
        If sysY.Text = 8 Then sysY.Text = ("08")
        If sysY.Text = 9 Then sysY.Text = ("09")

        Dim result As Double = 0
        Dim reskom As Double = 0


        a = 0
        brkom = 0


        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0



        k(0) = 1
        If sysY.Text > 0 Then If K1.Text = ("") Then K1.Text = ("0")
        If sysY.Text > 1 Then If K2.Text = ("") Then K2.Text = ("0")
        If sysY.Text > 2 Then If K3.Text = ("") Then K3.Text = ("0")
        If sysY.Text > 3 Then If K4.Text = ("") Then K4.Text = ("0")
        If sysY.Text > 4 Then If K5.Text = ("") Then K5.Text = ("0")
        If sysY.Text > 5 Then If K6.Text = ("") Then K6.Text = ("0")
        If sysY.Text > 6 Then If K7.Text = ("") Then K7.Text = ("0")
        If sysY.Text > 7 Then If K8.Text = ("") Then K8.Text = ("0")
        If sysY.Text > 8 Then If K9.Text = ("") Then K9.Text = ("0")
        If sysY.Text > 9 Then If K10.Text = ("") Then K10.Text = ("0")
        If sysY.Text > 10 Then If K11.Text = ("") Then K11.Text = ("0")
        If sysY.Text > 11 Then If K12.Text = ("") Then K12.Text = ("0")
        If sysY.Text > 12 Then If K13.Text = ("") Then K13.Text = ("0")
        If sysY.Text > 13 Then If K14.Text = ("") Then K14.Text = ("0")
        If sysY.Text > 14 Then If K15.Text = ("") Then K15.Text = ("0")
        If sysY.Text > 15 Then If K16.Text = ("") Then K16.Text = ("0")
        If sysY.Text > 16 Then If K17.Text = ("") Then K17.Text = ("0")
        If sysY.Text > 17 Then If K18.Text = ("") Then K18.Text = ("0")
        If sysY.Text > 18 Then If K19.Text = ("") Then K19.Text = ("0")
        If sysY.Text > 19 Then If K20.Text = ("") Then K20.Text = ("0")

        If sysY.Text > 0 Then If K1.Text = ("0") Then m1.Visible = True Else m1.Visible = False Else m1.Visible = False
        If sysY.Text > 1 Then If K2.Text = ("0") Then m2.Visible = True Else m2.Visible = False Else m2.Visible = False
        If sysY.Text > 2 Then If K3.Text = ("0") Then m3.Visible = True Else m3.Visible = False Else m3.Visible = False
        If sysY.Text > 3 Then If K4.Text = ("0") Then m4.Visible = True Else m4.Visible = False Else m4.Visible = False
        If sysY.Text > 4 Then If K5.Text = ("0") Then m5.Visible = True Else m5.Visible = False Else m5.Visible = False
        If sysY.Text > 5 Then If K6.Text = ("0") Then m6.Visible = True Else m6.Visible = False Else m6.Visible = False
        If sysY.Text > 6 Then If K7.Text = ("0") Then m7.Visible = True Else m7.Visible = False Else m7.Visible = False
        If sysY.Text > 7 Then If K8.Text = ("0") Then m8.Visible = True Else m8.Visible = False Else m8.Visible = False
        If sysY.Text > 8 Then If K9.Text = ("0") Then m9.Visible = True Else m9.Visible = False Else m9.Visible = False
        If sysY.Text > 9 Then If K10.Text = ("0") Then m10.Visible = True Else m10.Visible = False Else m10.Visible = False
        If sysY.Text > 10 Then If K11.Text = ("0") Then m11.Visible = True Else m11.Visible = False Else m11.Visible = False
        If sysY.Text > 11 Then If K12.Text = ("0") Then m12.Visible = True Else m12.Visible = False Else m12.Visible = False
        If sysY.Text > 12 Then If K13.Text = ("0") Then m13.Visible = True Else m13.Visible = False Else m13.Visible = False
        If sysY.Text > 13 Then If K14.Text = ("0") Then m14.Visible = True Else m14.Visible = False Else m14.Visible = False
        If sysY.Text > 14 Then If K15.Text = ("0") Then m15.Visible = True Else m15.Visible = False Else m15.Visible = False
        If sysY.Text > 15 Then If K16.Text = ("0") Then m16.Visible = True Else m16.Visible = False Else m16.Visible = False
        If sysY.Text > 16 Then If K17.Text = ("0") Then m17.Visible = True Else m17.Visible = False Else m17.Visible = False
        If sysY.Text > 17 Then If K18.Text = ("0") Then m18.Visible = True Else m18.Visible = False Else m18.Visible = False
        If sysY.Text > 18 Then If K19.Text = ("0") Then m19.Visible = True Else m19.Visible = False Else m19.Visible = False
        If sysY.Text > 19 Then If K20.Text = ("0") Then m20.Visible = True Else m20.Visible = False Else m20.Visible = False
        If K1.Text = ("") Then k(1) = 0 Else k(1) = K1.Text
        If K2.Text = ("") Then k(2) = 0 Else k(2) = K2.Text
        If K3.Text = ("") Then k(3) = 0 Else k(3) = K3.Text
        If K4.Text = ("") Then k(4) = 0 Else k(4) = K4.Text
        If K5.Text = ("") Then k(5) = 0 Else k(5) = K5.Text
        If K6.Text = ("") Then k(6) = 0 Else k(6) = K6.Text
        If K7.Text = ("") Then k(7) = 0 Else k(7) = K7.Text
        If K8.Text = ("") Then k(8) = 0 Else k(8) = K8.Text
        If K9.Text = ("") Then k(9) = 0 Else k(9) = K9.Text
        If K10.Text = ("") Then k(10) = 0 Else k(10) = K10.Text
        If K11.Text = ("") Then k(11) = 0 Else k(11) = K11.Text
        If K12.Text = ("") Then k(12) = 0 Else k(12) = K12.Text
        If K13.Text = ("") Then k(13) = 0 Else k(13) = K13.Text
        If K14.Text = ("") Then k(14) = 0 Else k(14) = K14.Text
        If K15.Text = ("") Then k(15) = 0 Else k(15) = K15.Text
        If K16.Text = ("") Then k(16) = 0 Else k(16) = K16.Text
        If K17.Text = ("") Then k(17) = 0 Else k(17) = K17.Text
        If K18.Text = ("") Then k(18) = 0 Else k(18) = K18.Text
        If K19.Text = ("") Then k(19) = 0 Else k(19) = K19.Text
        If K20.Text = ("") Then k(20) = 0 Else k(20) = K20.Text

        'ovo bi trebao biti uvjet da stopira min-max promjenu nakon unesenog promasaja...
        jpm = 1
        Dim fcv(20)
        For tgf = 1 To y
            If k(tgf) = 0 Then fcv(tgf) = 0 Else fcv(tgf) = k(tgf)
            jpm = jpm * fcv(tgf)
        Next tgf

        If acc * jpm = 0 Then min1.Visible = False Else min1.Visible = True
        If acc * jpm = 0 Then min2.Visible = False Else min2.Visible = True
        If acc * jpm = 0 Then min3.Visible = False Else min3.Visible = True
        If acc * jpm = 0 Then min4.Visible = False Else min4.Visible = True
        If acc * jpm = 0 Then min5.Visible = False Else min5.Visible = True
        If acc * jpm = 0 Then min6.Visible = False Else min6.Visible = True
        If acc * jpm = 0 Then min7.Visible = False Else min7.Visible = True
        If acc * jpm = 0 Then min8.Visible = False Else min8.Visible = True
        If acc * jpm = 0 Then min9.Visible = False Else min9.Visible = True
        If acc * jpm = 0 Then min10.Visible = False Else min10.Visible = True
        If acc * jpm = 0 Then min11.Visible = False Else min11.Visible = True
        If acc * jpm = 0 Then min12.Visible = False Else min12.Visible = True
        If acc * jpm = 0 Then min13.Visible = False Else min13.Visible = True
        If acc * jpm = 0 Then min14.Visible = False Else min14.Visible = True
        If acc * jpm = 0 Then min15.Visible = False Else min15.Visible = True
        If acc * jpm = 0 Then min16.Visible = False Else min16.Visible = True
        If acc * jpm = 0 Then min17.Visible = False Else min17.Visible = True
        If acc * jpm = 0 Then min18.Visible = False Else min18.Visible = True
        If acc * jpm = 0 Then min19.Visible = False Else min19.Visible = True
        If acc * jpm = 0 Then min20.Visible = False Else min20.Visible = True
        If acc * jpm = 0 Then max1.Visible = False Else max1.Visible = True
        If acc * jpm = 0 Then max2.Visible = False Else max2.Visible = True
        If acc * jpm = 0 Then max3.Visible = False Else max3.Visible = True
        If acc * jpm = 0 Then max4.Visible = False Else max4.Visible = True
        If acc * jpm = 0 Then max5.Visible = False Else max5.Visible = True
        If acc * jpm = 0 Then max6.Visible = False Else max6.Visible = True
        If acc * jpm = 0 Then max7.Visible = False Else max7.Visible = True
        If acc * jpm = 0 Then max8.Visible = False Else max8.Visible = True
        If acc * jpm = 0 Then max9.Visible = False Else max9.Visible = True
        If acc * jpm = 0 Then max10.Visible = False Else max10.Visible = True
        If acc * jpm = 0 Then max11.Visible = False Else max11.Visible = True
        If acc * jpm = 0 Then max12.Visible = False Else max12.Visible = True
        If acc * jpm = 0 Then max13.Visible = False Else max13.Visible = True
        If acc * jpm = 0 Then max14.Visible = False Else max14.Visible = True
        If acc * jpm = 0 Then max15.Visible = False Else max15.Visible = True
        If acc * jpm = 0 Then max16.Visible = False Else max16.Visible = True
        If acc * jpm = 0 Then max17.Visible = False Else max17.Visible = True
        If acc * jpm = 0 Then max18.Visible = False Else max18.Visible = True
        If acc * jpm = 0 Then max19.Visible = False Else max19.Visible = True
        If acc * jpm = 0 Then max20.Visible = False Else max20.Visible = True


        acc = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        jj1 = k(1)
        jj2 = k(2)
        jj3 = k(3)
        jj4 = k(4)
        jj5 = k(5)
        jj6 = k(6)
        jj7 = k(7)
        jj8 = k(8)
        jj9 = k(9)
        jj10 = k(10)
        jj11 = k(11)
        jj12 = k(12)
        jj13 = k(13)
        jj14 = k(14)
        jj15 = k(15)
        jj16 = k(16)
        jj17 = k(17)
        jj18 = k(18)
        jj19 = k(19)
        jj20 = k(20)

        eet = 0
        For ert = 1 To y

            If k(ert) = ("0") Then eet = eet + 1

        Next ert


        nnn = FormatNumber((jj1 + jj2 + jj3 + jj4 + jj5 + jj6 + jj7 + jj8 + jj9 + jj10 + jj11 + jj12 + jj13 + jj14 + jj15 + jj16 + jj17 + jj18 + jj19 + jj20) / (y - eet), 2)
        mmm = FormatNumber(100 / nnn, 2)
        hht = y - eet

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998



1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)

                                                                                        If x = 1 Then b = k(d)
                                                                                        If x = 2 Then b = k(d) * k(el)
                                                                                        If x = 3 Then b = k(d) * k(el) * k(f)
                                                                                        If x = 4 Then b = k(d) * k(el) * k(f) * k(g)
                                                                                        If x = 5 Then b = k(d) * k(el) * k(f) * k(g) * k(h)
                                                                                        If x = 6 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i)
                                                                                        If x = 7 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j)
                                                                                        If x = 8 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l)
                                                                                        If x = 9 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m)
                                                                                        If x = 10 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n)
                                                                                        If x = 11 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o)
                                                                                        If x = 12 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p)
                                                                                        If x = 13 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p) * k(q)
                                                                                        If x = 14 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p) * k(q) * k(r)
                                                                                        If x = 15 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p) * k(q) * k(r) * k(s)
                                                                                        If x = 16 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p) * k(q) * k(r) * k(s) * k(t)
                                                                                        If x = 17 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p) * k(q) * k(r) * k(s) * k(t) * k(u)
                                                                                        If x = 18 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p) * k(q) * k(r) * k(s) * k(t) * k(u) * k(v)
                                                                                        If x = 19 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p) * k(q) * k(r) * k(s) * k(t) * k(u) * k(v) * k(z)
                                                                                        If x = 20 Then b = k(d) * k(el) * k(f) * k(g) * k(h) * k(i) * k(j) * k(l) * k(m) * k(n) * k(o) * k(p) * k(q) * k(r) * k(s) * k(t) * k(u) * k(v) * k(z) * k(w)

                                                                                        a = a + b

                                                                                        brkom = brkom + 1


                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:
        If brkom = 0 Then result = 0 Else 
        result = Format(a / brkom * ulog, "0.00")
        reskom = brkom
        suma.Text = result.ToString("#,##0.00")
        brkomb.Text = reskom.ToString()
        Avrgkfc.Text = nnn.ToString()
        Avrgchances.Text = mmm.ToString()
        missed.Text = eet.ToString()
        If eet > 0 Then acc = 0 Else acc = 1
        hit.Text = hht.ToString()
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        suma.Text = result.ToString("#,##0.00")
        brkomb.Text = reskom.ToString()

999:

        'ovo je tu da dopusti drugim stranicama.aspx da povuku vrijednost sysY.text, avrgchances.text i avrgkfc.text...
        Session("myVariable1") = sysY.Text
        Session("myVariable2") = mmm
        Session("myVariable3") = nnn


        If jpm = 0 Then GoTo 1000
        Call minimum1()
        Call maximum1()
1000:
        DDown1.Text = ("Decimal")
    End Sub

    Private Sub minimum1()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od jednog promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min1.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub

    Private Sub maximum1()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od jednog promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(y) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max1.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:

        If y < 2 Then GoTo 1000 Else 
        Call minimum2()
        Call maximum2()
1000:

    End Sub


    Private Sub minimum2()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od dva promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(1) = 0
        kkkk(2) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min2.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub


    Private Sub maximum2()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od dva promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(y) = 0
        kkkk(y - 1) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max2.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 3 Then GoTo 1000 Else 
        Call minimum3()
        Call maximum3()
1000:
    End Sub



    Private Sub minimum3()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od tri promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min3.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum3()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od tri promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max3.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 4 Then GoTo 1000 Else 
        Call minimum4()
        Call maximum4()
1000:

    End Sub


    Private Sub minimum4()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od cetri promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min4.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum4()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od cetri promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max4.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 5 Then GoTo 1000 Else 
        Call minimum5()
        Call maximum5()
1000:

    End Sub



    Private Sub minimum5()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od pet promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min5.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum5()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od pet promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max5.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:

        If y < 6 Then GoTo 1000 Else 
        Call minimum6()
        Call maximum6()
1000:
    End Sub


    Private Sub minimum6()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od sest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min6.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum6()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od sest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max6.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 7 Then GoTo 1000 Else 
        Call minimum7()
        Call maximum7()
1000:

    End Sub


    Private Sub minimum7()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od sedam promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min7.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum7()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od sedam promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max7.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 8 Then GoTo 1000 Else 
        Call minimum8()
        Call maximum8()
1000:

    End Sub


    Private Sub minimum8()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od osam promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min8.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum8()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od osam promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max8.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:

        If y < 9 Then GoTo 1000 Else 
        Call minimum9()
        Call maximum9()
1000:
    End Sub



    Private Sub minimum9()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od devet promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min9.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum9()

        '-----------------------------------------------------------------------------------------------------------------------
        'ovo je tu za max od devet promasaja...

        

        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max9.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 10 Then GoTo 1000 Else 
        Call minimum10()
        Call maximum10()
1000:

    End Sub

    Private Sub minimum10()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od deset promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min10.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum10()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od deset promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max10.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:

        If y < 11 Then GoTo 1000 Else 
        Call minimum11()
        Call maximum11()
1000:
    End Sub


    Private Sub minimum11()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od jedanaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min11.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum11()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od jedanaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max11.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:

        If y < 12 Then GoTo 1000 Else 
        Call minimum12()
        Call maximum12()
1000:
    End Sub


    Private Sub minimum12()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od dvanaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(y - 10) = rrrr(y - 10)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0
        kkkk(12) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min12.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum12()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od dvanaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(12) = rrrr(12)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0
        kkkk(y - 11) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max12.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 13 Then GoTo 1000 Else 
        Call minimum13()
        Call maximum13()
1000:

    End Sub


    Private Sub minimum13()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od trinaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(y - 10) = rrrr(y - 10)
        kkkk(y - 11) = rrrr(y - 11)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0
        kkkk(12) = 0
        kkkk(13) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min13.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum13()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od trinaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(12) = rrrr(12)
        kkkk(13) = rrrr(13)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0
        kkkk(y - 11) = 0
        kkkk(y - 12) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max13.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 14 Then GoTo 1000 Else 
        Call minimum14()
        Call maximum14()
1000:

    End Sub


    Private Sub minimum14()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od cetrnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(y - 10) = rrrr(y - 10)
        kkkk(y - 11) = rrrr(y - 11)
        kkkk(y - 12) = rrrr(y - 12)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0
        kkkk(12) = 0
        kkkk(13) = 0
        kkkk(14) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min14.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum14()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od cetrnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(12) = rrrr(12)
        kkkk(13) = rrrr(13)
        kkkk(14) = rrrr(14)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0
        kkkk(y - 11) = 0
        kkkk(y - 12) = 0
        kkkk(y - 13) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max14.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 15 Then GoTo 1000 Else 
        Call minimum15()
        Call maximum15()
1000:

    End Sub

    Private Sub minimum15()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od petnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(y - 10) = rrrr(y - 10)
        kkkk(y - 11) = rrrr(y - 11)
        kkkk(y - 12) = rrrr(y - 12)
        kkkk(y - 13) = rrrr(y - 13)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0
        kkkk(12) = 0
        kkkk(13) = 0
        kkkk(14) = 0
        kkkk(15) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min15.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum15()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od petnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(12) = rrrr(12)
        kkkk(13) = rrrr(13)
        kkkk(14) = rrrr(14)
        kkkk(15) = rrrr(15)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0
        kkkk(y - 11) = 0
        kkkk(y - 12) = 0
        kkkk(y - 13) = 0
        kkkk(y - 14) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max15.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 16 Then GoTo 1000 Else 
        Call minimum16()
        Call maximum16()
1000:

    End Sub


    Private Sub minimum16()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od sesnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(y - 10) = rrrr(y - 10)
        kkkk(y - 11) = rrrr(y - 11)
        kkkk(y - 12) = rrrr(y - 12)
        kkkk(y - 13) = rrrr(y - 13)
        kkkk(y - 14) = rrrr(y - 14)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0
        kkkk(12) = 0
        kkkk(13) = 0
        kkkk(14) = 0
        kkkk(15) = 0
        kkkk(16) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min16.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum16()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od sesnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(12) = rrrr(12)
        kkkk(13) = rrrr(13)
        kkkk(14) = rrrr(14)
        kkkk(15) = rrrr(15)
        kkkk(16) = rrrr(16)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0
        kkkk(y - 11) = 0
        kkkk(y - 12) = 0
        kkkk(y - 13) = 0
        kkkk(y - 14) = 0
        kkkk(y - 15) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max16.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 17 Then GoTo 1000 Else 
        Call minimum17()
        Call maximum17()
1000:

    End Sub

    Private Sub minimum17()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od sedamnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(y - 10) = rrrr(y - 10)
        kkkk(y - 11) = rrrr(y - 11)
        kkkk(y - 12) = rrrr(y - 12)
        kkkk(y - 13) = rrrr(y - 13)
        kkkk(y - 14) = rrrr(y - 14)
        kkkk(y - 15) = rrrr(y - 15)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0
        kkkk(12) = 0
        kkkk(13) = 0
        kkkk(14) = 0
        kkkk(15) = 0
        kkkk(16) = 0
        kkkk(17) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min17.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum17()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od sedamnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(12) = rrrr(12)
        kkkk(13) = rrrr(13)
        kkkk(14) = rrrr(14)
        kkkk(15) = rrrr(15)
        kkkk(16) = rrrr(16)
        kkkk(17) = rrrr(17)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0
        kkkk(y - 11) = 0
        kkkk(y - 12) = 0
        kkkk(y - 13) = 0
        kkkk(y - 14) = 0
        kkkk(y - 15) = 0
        kkkk(y - 16) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max17.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 18 Then GoTo 1000 Else 
        Call minimum18()
        Call maximum18()
1000:

    End Sub

    Private Sub minimum18()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od osamnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(y - 10) = rrrr(y - 10)
        kkkk(y - 11) = rrrr(y - 11)
        kkkk(y - 12) = rrrr(y - 12)
        kkkk(y - 13) = rrrr(y - 13)
        kkkk(y - 14) = rrrr(y - 14)
        kkkk(y - 15) = rrrr(y - 15)
        kkkk(y - 16) = rrrr(y - 16)
        kkkk(y - 17) = rrrr(y - 17)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0
        kkkk(12) = 0
        kkkk(13) = 0
        kkkk(14) = 0
        kkkk(15) = 0
        kkkk(16) = 0
        kkkk(17) = 0
        kkkk(17) = 0
        kkkk(18) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min18.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:


    End Sub



    Private Sub maximum18()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od osamnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(12) = rrrr(12)
        kkkk(13) = rrrr(13)
        kkkk(14) = rrrr(14)
        kkkk(15) = rrrr(15)
        kkkk(16) = rrrr(16)
        kkkk(17) = rrrr(17)
        kkkk(18) = rrrr(18)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0
        kkkk(y - 11) = 0
        kkkk(y - 12) = 0
        kkkk(y - 13) = 0
        kkkk(y - 14) = 0
        kkkk(y - 15) = 0
        kkkk(y - 16) = 0
        kkkk(y - 17) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max18.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 19 Then GoTo 1000 Else 
        Call minimum19()
        Call maximum19()
1000:

    End Sub

    Private Sub minimum19()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za min od devetnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(y) = rrrr(y)
        kkkk(y - 1) = rrrr(y - 1)
        kkkk(y - 2) = rrrr(y - 2)
        kkkk(y - 3) = rrrr(y - 3)
        kkkk(y - 4) = rrrr(y - 4)
        kkkk(y - 5) = rrrr(y - 5)
        kkkk(y - 6) = rrrr(y - 6)
        kkkk(y - 7) = rrrr(y - 7)
        kkkk(y - 8) = rrrr(y - 8)
        kkkk(y - 9) = rrrr(y - 9)
        kkkk(y - 10) = rrrr(y - 10)
        kkkk(y - 11) = rrrr(y - 11)
        kkkk(y - 12) = rrrr(y - 12)
        kkkk(y - 13) = rrrr(y - 13)
        kkkk(y - 14) = rrrr(y - 14)
        kkkk(y - 15) = rrrr(y - 15)
        kkkk(y - 16) = rrrr(y - 16)
        kkkk(y - 17) = rrrr(y - 17)
        kkkk(y - 18) = rrrr(y - 18)
        kkkk(1) = 0
        kkkk(2) = 0
        kkkk(3) = 0
        kkkk(4) = 0
        kkkk(5) = 0
        kkkk(6) = 0
        kkkk(7) = 0
        kkkk(8) = 0
        kkkk(9) = 0
        kkkk(10) = 0
        kkkk(11) = 0
        kkkk(12) = 0
        kkkk(13) = 0
        kkkk(14) = 0
        kkkk(15) = 0
        kkkk(16) = 0
        kkkk(17) = 0
        kkkk(17) = 0
        kkkk(18) = 0
        kkkk(19) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = FormatNumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        min19.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:

    End Sub



    Private Sub maximum19()


        '-----------------------------------------------------------------------------------------------------------------------

        'ovo je tu za max od devetnaest promasaja...


        Dim result As Double = 0
        Dim reskom As Double = 0

        a = 0
        brkom = 0

        d = 0
        el = 0
        f = 0
        g = 0
        h = 0
        i = 0
        j = 0
        l = 0
        m = 0
        n = 0
        o = 0
        p = 0
        q = 0
        r = 0
        s = 0
        t = 0
        u = 0
        v = 0
        w = 0
        z = 0

        x = sysX.Text
        y = sysY.Text
        TextBox1.Text = FormatNumber(TextBox1.Text, 2)
        ulog = TextBox1.Text()

        kkkk(1) = rrrr(1)
        kkkk(2) = rrrr(2)
        kkkk(3) = rrrr(3)
        kkkk(4) = rrrr(4)
        kkkk(5) = rrrr(5)
        kkkk(6) = rrrr(6)
        kkkk(7) = rrrr(7)
        kkkk(8) = rrrr(8)
        kkkk(9) = rrrr(9)
        kkkk(10) = rrrr(10)
        kkkk(11) = rrrr(11)
        kkkk(12) = rrrr(12)
        kkkk(13) = rrrr(13)
        kkkk(14) = rrrr(14)
        kkkk(15) = rrrr(15)
        kkkk(16) = rrrr(16)
        kkkk(17) = rrrr(17)
        kkkk(18) = rrrr(18)
        kkkk(19) = rrrr(19)
        kkkk(y) = 0
        kkkk(y - 1) = 0
        kkkk(y - 2) = 0
        kkkk(y - 3) = 0
        kkkk(y - 4) = 0
        kkkk(y - 5) = 0
        kkkk(y - 6) = 0
        kkkk(y - 7) = 0
        kkkk(y - 8) = 0
        kkkk(y - 9) = 0
        kkkk(y - 10) = 0
        kkkk(y - 11) = 0
        kkkk(y - 12) = 0
        kkkk(y - 13) = 0
        kkkk(y - 14) = 0
        kkkk(y - 15) = 0
        kkkk(y - 16) = 0
        kkkk(y - 17) = 0
        kkkk(y - 18) = 0

        If sysX.Text = "" Then GoTo 998
        If sysX.Text > sysY.Text Then GoTo 998
        If sysX.Text = 0 Then GoTo 998

        If sysY.Text = ("") Then GoTo 998
        If sysY.Text = ("0") Then GoTo 998
        If sysY.Text > 20 Then GoTo 998

        qwqw = 0

1:      If x = 20 Then c1 = y - x + 1 Else c1 = 1
        For cu As Integer = 1 To c1
            w = -(cu + 18 - y)

2:          If x = 19 Then c2 = y - x + 1 Else c2 = cu
            For ct As Integer = 1 To c2
                z = -(ct + 17 - y)

3:              If x = 18 Then c3 = y - x + 1 Else c3 = ct
                For cs As Integer = 1 To c3
                    v = -(cs + 16 - y)

4:                  If x = 17 Then c4 = y - x + 1 Else c4 = cs
                    For cr As Integer = 1 To c4
                        u = -(cr + 15 - y)

5:                      If x = 16 Then c5 = y - x + 1 Else c5 = cr
                        For cq As Integer = 1 To c5
                            t = -(cq + 14 - y)

6:                          If x = 15 Then c6 = y - x + 1 Else c6 = cq
                            For cp As Integer = 1 To c6
                                s = -(cp + 13 - y)

7:                              If x = 14 Then c7 = y - x + 1 Else c7 = cp
                                For co As Integer = 1 To c7
                                    r = -(co + 12 - y)

8:                                  If x = 13 Then c8 = y - x + 1 Else c8 = co
                                    For cn As Integer = 1 To c8
                                        q = -(cn + 11 - y)

9:                                      If x = 12 Then c9 = y - x + 1 Else c9 = cn
                                        For cm As Integer = 1 To c9
                                            p = -(cm + 10 - y)

10:                                         If x = 11 Then c10 = y - x + 1 Else c10 = cm
                                            For cl As Integer = 1 To c10
                                                o = -(cl + 9 - y)

11:                                             If x = 10 Then c11 = y - x + 1 Else c11 = cl
                                                For ck As Integer = 1 To c11
                                                    n = -(ck + 8 - y)

12:                                                 If x = 9 Then c12 = y - x + 1 Else c12 = ck
                                                    For cj As Integer = 1 To c12
                                                        m = -(cj + 7 - y)

13:                                                     If x = 8 Then c13 = y - x + 1 Else c13 = cj
                                                        For ci As Integer = 1 To c13
                                                            l = -(ci + 6 - y)

14:                                                         If x = 7 Then c14 = y - x + 1 Else c14 = ci
                                                            For ch As Integer = 1 To c14
                                                                j = -(ch + 5 - y)

15:                                                             If x = 6 Then c15 = y - x + 1 Else c15 = ch
                                                                For cg As Integer = 1 To c15
                                                                    i = -(cg + 4 - y)

16:                                                                 If x = 5 Then c16 = y - x + 1 Else c16 = cg
                                                                    For cf As Integer = 1 To c16
                                                                        h = -(cf + 3 - y)

17:                                                                     If x = 4 Then c17 = y - x + 1 Else c17 = cf
                                                                        For ce As Integer = 1 To c17
                                                                            g = -(ce + 2 - y)

18:                                                                         If x = 3 Then c18 = y - x + 1 Else c18 = ce
                                                                            For cd As Integer = 1 To c18
                                                                                f = -(cd + 1 - y)

19:                                                                             If x = 2 Then c19 = y - x + 1 Else c19 = cd
                                                                                For cb As Integer = 1 To c19
                                                                                    el = -(cb - y)


20:                                                                                 If x = 1 Then c20 = y - x + 1 Else c20 = cb
                                                                                    For ca As Integer = 1 To c20
                                                                                        d = -(ca - 1 - y)


                                                                                        If x = 1 Then b = kkkk(d)
                                                                                        If x = 2 Then b = kkkk(d) * kkkk(el)
                                                                                        If x = 3 Then b = kkkk(d) * kkkk(el) * kkkk(f)
                                                                                        If x = 4 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g)
                                                                                        If x = 5 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h)
                                                                                        If x = 6 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i)
                                                                                        If x = 7 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j)
                                                                                        If x = 8 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l)
                                                                                        If x = 9 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m)
                                                                                        If x = 10 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n)
                                                                                        If x = 11 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o)
                                                                                        If x = 12 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p)
                                                                                        If x = 13 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q)
                                                                                        If x = 14 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r)
                                                                                        If x = 15 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s)
                                                                                        If x = 16 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t)
                                                                                        If x = 17 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u)
                                                                                        If x = 18 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v)
                                                                                        If x = 19 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z)
                                                                                        If x = 20 Then b = kkkk(d) * kkkk(el) * kkkk(f) * kkkk(g) * kkkk(h) * kkkk(i) * kkkk(j) * kkkk(l) * kkkk(m) * kkkk(n) * kkkk(o) * kkkk(p) * kkkk(q) * kkkk(r) * kkkk(s) * kkkk(t) * kkkk(u) * kkkk(v) * kkkk(z) * kkkk(w)


                                                                                        a = a + b
                                                                                        brkom = brkom + 1
                                                                                        qwqw = qwqw + b
                                                                                    Next ca
                                                                                    If x = 1 Then GoTo 100

                                                                                Next cb
                                                                                If x = 2 Then GoTo 100

                                                                            Next cd
                                                                            If x = 3 Then GoTo 100

                                                                        Next ce
                                                                        If x = 4 Then GoTo 100

                                                                    Next cf
                                                                    If x = 5 Then GoTo 100

                                                                Next cg
                                                                If x = 6 Then GoTo 100

                                                            Next ch
                                                            If x = 7 Then GoTo 100

                                                        Next ci
                                                        If x = 8 Then GoTo 100

                                                    Next cj
                                                    If x = 9 Then GoTo 100

                                                Next ck
                                                If x = 10 Then GoTo 100

                                            Next cl
                                            If x = 11 Then GoTo 100

                                        Next cm
                                        If x = 12 Then GoTo 100

                                    Next cn
                                    If x = 13 Then GoTo 100

                                Next co
                                If x = 14 Then GoTo 100

                            Next cp
                            If x = 15 Then GoTo 100

                        Next cq
                        If x = 16 Then GoTo 100

                    Next cr
                    If x = 17 Then GoTo 100

                Next cs
                If x = 18 Then GoTo 100

            Next ct
            If x = 19 Then GoTo 100

        Next cu

100:    If brkom = 0 Then result = 0 Else 
        result = Formatnumber(qwqw / brkom * ulog, 2)
        reskom = brkom
        max19.Text = result.tostring("#,##0.00")
        a = 0
        brkom = 0
        reskom = 0
        result = 0
        GoTo 999
998:
        a = 0
        brkom = 0
        reskom = 0
        result = 0
999:
        If y < 20 Then GoTo 1000 Else 
        Call minimum20()
        Call maximum20()
1000:


    End Sub

    Private Sub minimum20()

        Dim result As Double = 0
        Result = 0
        min20.Text = result.tostring("#,##0.00")

    End Sub

    Private Sub maximum20()

        Dim result As Double = 0
        result = 0
        max20.Text = result.tostring("#,##0.00")

    End Sub


End Class
