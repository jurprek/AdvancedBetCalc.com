Public Class HrcRc
    Inherits System.Web.UI.Page

    Dim sumasvihS, V, N, PRVI01, PRVI01ILIDRUGI, PRVI01IDRUGI, PRVI01ILIDRUGIILITRECI, PRVI01ILIDRUGIILITRECIILICETVRTI, PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI, PIDILIDIP01, PRVI02, PRVI02ILIDRUGI, PRVI02IDRUGI, PRVI02ILIDRUGIILITRECI, PRVI02ILIDRUGIILITRECIILICETVRTI, PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI, PIDILIDIP02, PRVI03, PRVI03ILIDRUGI, PRVI03IDRUGI, PRVI03ILIDRUGIILITRECI, PRVI03ILIDRUGIILITRECIILICETVRTI, PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI, PIDILIDIP03, sumK, brojilo3, FCT1, FCT2, FCT3, FCT4, FCT5, FCT6, FCT7, FCT8, tempbroj, znam1, znam2, znam3, znam4, znam5, znam6, znam7, znam8, PRVI04, PRVI04ILIDRUGI, PRVI04ILIDRUGIILITRECI, PRVI05, PRVI05ILIDRUGI, PRVI05ILIDRUGIILITRECI, PRVI06, PRVI06ILIDRUGI, PRVI06ILIDRUGIILITRECI, PRVI07, PRVI07ILIDRUGI, PRVI07ILIDRUGIILITRECI, PRVI08, PRVI08ILIDRUGI, PRVI08ILIDRUGIILITRECI, PRVI09, PRVI09ILIDRUGI, PRVI09ILIDRUGIILITRECI, PRVI10, PRVI10ILIDRUGI, PRVI10ILIDRUGIILITRECI, PRVI11, PRVI11ILIDRUGI, PRVI11ILIDRUGIILITRECI, PRVI12, PRVI12ILIDRUGI, PRVI12ILIDRUGIILITRECI, PRVI04ILIDRUGIILITRECIILICETVRTI, PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI05ILIDRUGIILITRECIILICETVRTI, PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI06ILIDRUGIILITRECIILICETVRTI, PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI07ILIDRUGIILITRECIILICETVRTI, PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI08ILIDRUGIILITRECIILICETVRTI, PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI, PRVI09ILIDRUGIILITRECIILICETVRTI, PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI As Decimal

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        V = 0
        sumK = 0
        brojilo3 = 0
        N = 0
        PRVI01 = 0
        PRVI01ILIDRUGI = 0
        PRVI01IDRUGI = 0
        PRVI01ILIDRUGIILITRECI = 0
        PRVI01ILIDRUGIILITRECIILICETVRTI = 0
        PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI = 0
        PIDILIDIP01 = 0
        PRVI02 = 0
        PRVI02ILIDRUGI = 0
        PRVI02IDRUGI = 0
        PRVI02ILIDRUGIILITRECI = 0
        PRVI02ILIDRUGIILITRECIILICETVRTI = 0
        PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI = 0
        PIDILIDIP02 = 0
        PRVI03 = 0
        PRVI03ILIDRUGI = 0
        PRVI03IDRUGI = 0
        PRVI03ILIDRUGIILITRECI = 0
        PRVI03ILIDRUGIILITRECIILICETVRTI = 0
        PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI = 0
        PIDILIDIP03 = 0
        PRVI04 = 0
        PRVI05 = 0
        PRVI06 = 0
        PRVI07 = 0
        PRVI08 = 0
        PRVI09 = 0
        PRVI04ILIDRUGI = 0
        PRVI05ILIDRUGI = 0
        PRVI06ILIDRUGI = 0
        PRVI07ILIDRUGI = 0
        PRVI08ILIDRUGI = 0
        PRVI09ILIDRUGI = 0
        PRVI04ILIDRUGIILITRECI = 0
        PRVI05ILIDRUGIILITRECI = 0
        PRVI06ILIDRUGIILITRECI = 0
        PRVI07ILIDRUGIILITRECI = 0
        PRVI08ILIDRUGIILITRECI = 0
        PRVI09ILIDRUGIILITRECI = 0
        PRVI04ILIDRUGIILITRECIILICETVRTI = 0
        PRVI05ILIDRUGIILITRECIILICETVRTI = 0
        PRVI06ILIDRUGIILITRECIILICETVRTI = 0
        PRVI07ILIDRUGIILITRECIILICETVRTI = 0
        PRVI08ILIDRUGIILITRECIILICETVRTI = 0
        PRVI09ILIDRUGIILITRECIILICETVRTI = 0
        PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI = 0
        PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI = 0
        PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI = 0
        PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI = 0
        PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI = 0
        PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI = 0

        P1OR2OR3or4or5lace1.Text = ("")
        P1OR2OR3or4or5lace2.Text = ("")
        P1OR2OR3or4or5lace3.Text = ("")
        P1OR2OR3or4or5lace4.Text = ("")
        P1OR2OR3or4or5lace5.Text = ("")
        P1OR2OR3or4or5lace6.Text = ("")
        P1OR2OR3or4or5lace7.Text = ("")
        P1OR2OR3or4or5lace8.Text = ("")
        P1OR2OR3or4or5lace9.Text = ("")
        P1OR2or3or4lace1.Text = ("")
        P1OR2or3or4lace2.Text = ("")
        P1OR2or3or4lace3.Text = ("")
        P1OR2or3or4lace4.Text = ("")
        P1OR2or3or4lace5.Text = ("")
        P1OR2or3or4lace6.Text = ("")
        P1OR2or3or4lace7.Text = ("")
        P1OR2or3or4lace8.Text = ("")
        P1OR2or3or4lace9.Text = ("")
        P1OR2OR3lace1.Text = ("")
        P1OR2OR3lace2.Text = ("")
        P1OR2OR3lace3.Text = ("")
        P1OR2OR3lace4.Text = ("")
        P1OR2OR3lace5.Text = ("")
        P1OR2OR3lace6.Text = ("")
        P1OR2OR3lace7.Text = ("")
        P1OR2OR3lace8.Text = ("")
        P1OR2OR3lace9.Text = ("")
        P1OR2lace1.Text = ("")
        P1OR2lace2.Text = ("")
        P1OR2lace3.Text = ("")
        P1OR2lace4.Text = ("")
        P1OR2lace5.Text = ("")
        P1OR2lace6.Text = ("")
        P1OR2lace7.Text = ("")
        P1OR2lace8.Text = ("")
        P1OR2lace9.Text = ("")
        P01lace1.Text = ("")
        P01lace2.Text = ("")
        P01lace3.Text = ("")
        P01lace4.Text = ("")
        P01lace5.Text = ("")
        P01lace6.Text = ("")
        P01lace7.Text = ("")
        P01lace8.Text = ("")
        P01lace9.Text = ("")
        P1and2or2and1lace01.Text = ("")
        P1and2or2and1lace2.Text = ("")
        P1and2or2and1lace3.Text = ("")
        P1and2lace1.Text = ("")
        P1and2lace2.Text = ("")
        P1and2lace3.Text = ("")

        Dim s(22)

        If Kfc1.Text = ("") Then s(1) = 0 Else s(1) = 1 / Kfc1.Text
        If Kfc2.Text = ("") Then s(2) = 0 Else s(2) = 1 / Kfc2.Text
        If Kfc3.Text = ("") Then s(3) = 0 Else s(3) = 1 / Kfc3.Text
        If Kfc4.Text = ("") Then s(4) = 0 Else s(4) = 1 / Kfc4.Text
        If Kfc5.Text = ("") Then s(5) = 0 Else s(5) = 1 / Kfc5.Text
        If Kfc6.Text = ("") Then s(6) = 0 Else s(6) = 1 / Kfc6.Text
        If Kfc7.Text = ("") Then s(7) = 0 Else s(7) = 1 / Kfc7.Text
        If Kfc8.Text = ("") Then s(8) = 0 Else s(8) = 1 / Kfc8.Text
        If Kfc9.Text = ("") Then s(9) = 0 Else s(9) = 1 / Kfc9.Text
        If Kfc10.Text = ("") Then s(10) = 0 Else s(10) = 1 / Kfc10.Text
        If Kfc11.Text = ("") Then s(11) = 0 Else s(11) = 1 / Kfc11.Text
        If Kfc12.Text = ("") Then s(12) = 0 Else s(12) = 1 / Kfc12.Text
        If Kfc13.Text = ("") Then s(13) = 0 Else s(13) = 1 / Kfc13.Text
        If Kfc14.Text = ("") Then s(14) = 0 Else s(14) = 1 / Kfc14.Text
        If Kfc15.Text = ("") Then s(15) = 0 Else s(15) = 1 / Kfc15.Text
        If Kfc16.Text = ("") Then s(16) = 0 Else s(16) = 1 / Kfc16.Text
        If Kfc17.Text = ("") Then s(17) = 0 Else s(17) = 1 / Kfc17.Text
        If Kfc18.Text = ("") Then s(18) = 0 Else s(18) = 1 / Kfc18.Text
        If Kfc19.Text = ("") Then s(19) = 0 Else s(19) = 1 / Kfc19.Text
        If Kfc20.Text = ("") Then s(20) = 0 Else s(20) = 1 / Kfc20.Text
        If Kfc21.Text = ("") Then s(21) = 0 Else s(21) = 1 / Kfc21.Text
        If Kfc22.Text = ("") Then s(22) = 0 Else s(22) = 1 / Kfc22.Text

        For brojilo4 = 1 To 22
            If s(brojilo4) > 0 Then N = N + 1
        Next brojilo4

        Labelconsolidate2.Text = N
        If N > 9 Then Labelconsolidate1.Visible = True Else Labelconsolidate1.Visible = False
        If N > 9 Then Labelconsolidate2.Visible = True Else Labelconsolidate2.Visible = False
        If N > 9 Then Labelconsolidate3.Visible = True Else Labelconsolidate3.Visible = False

        sumasvihS = s(1) + s(2) + s(3) + s(4) + s(5) + s(6) + s(7) + s(8) + s(9) + s(10) + s(11) + s(12) + s(13) + s(14) + s(15) + s(16) + s(17) + s(18) + s(19) + s(20)
        Label1.Text = FormatNumber(1 - sumasvihS, 2)

        If Kfc1.Text = ("") Then s(1) = 0 Else s(1) = sumasvihS / Kfc1.Text
        If Kfc2.Text = ("") Then s(2) = 0 Else s(2) = sumasvihS / Kfc2.Text
        If Kfc3.Text = ("") Then s(3) = 0 Else s(3) = sumasvihS / Kfc3.Text
        If Kfc4.Text = ("") Then s(4) = 0 Else s(4) = sumasvihS / Kfc4.Text
        If Kfc5.Text = ("") Then s(5) = 0 Else s(5) = sumasvihS / Kfc5.Text
        If Kfc6.Text = ("") Then s(6) = 0 Else s(6) = sumasvihS / Kfc6.Text
        If Kfc7.Text = ("") Then s(7) = 0 Else s(7) = sumasvihS / Kfc7.Text
        If Kfc8.Text = ("") Then s(8) = 0 Else s(8) = sumasvihS / Kfc8.Text
        If Kfc9.Text = ("") Then s(9) = 0 Else s(9) = sumasvihS / Kfc9.Text
        If Kfc10.Text = ("") Then s(10) = 0 Else s(10) = sumasvihS / Kfc10.Text
        If Kfc11.Text = ("") Then s(11) = 0 Else s(11) = sumasvihS / Kfc11.Text
        If Kfc12.Text = ("") Then s(12) = 0 Else s(12) = sumasvihS / Kfc12.Text
        If Kfc13.Text = ("") Then s(13) = 0 Else s(13) = sumasvihS / Kfc13.Text
        If Kfc14.Text = ("") Then s(14) = 0 Else s(14) = sumasvihS / Kfc14.Text
        If Kfc15.Text = ("") Then s(15) = 0 Else s(15) = sumasvihS / Kfc15.Text
        If Kfc16.Text = ("") Then s(16) = 0 Else s(16) = sumasvihS / Kfc16.Text
        If Kfc17.Text = ("") Then s(17) = 0 Else s(17) = sumasvihS / Kfc17.Text
        If Kfc18.Text = ("") Then s(18) = 0 Else s(18) = sumasvihS / Kfc18.Text
        If Kfc19.Text = ("") Then s(19) = 0 Else s(19) = sumasvihS / Kfc19.Text
        If Kfc20.Text = ("") Then s(20) = 0 Else s(20) = sumasvihS / Kfc20.Text
        If Kfc21.Text = ("") Then s(21) = 0 Else s(21) = sumasvihS / Kfc21.Text
        If Kfc22.Text = ("") Then s(22) = 0 Else s(22) = sumasvihS / Kfc22.Text

        If N >= 9 Then s(9) = (s(9) + s(10) + s(11) + s(12) + s(13) + s(14) + s(15) + s(16) + s(17) + s(18) + s(19) + s(20) + s(21) + s(22)) Else s(9) = s(9)


        If Kfc10.Text <> ("") Then Kfc10.Text = ("")
        If Kfc11.Text <> ("") Then Kfc11.Text = ("")
        If Kfc12.Text <> ("") Then Kfc12.Text = ("")
        If Kfc13.Text <> ("") Then Kfc13.Text = ("")
        If Kfc14.Text <> ("") Then Kfc14.Text = ("")
        If Kfc15.Text <> ("") Then Kfc15.Text = ("")
        If Kfc16.Text <> ("") Then Kfc16.Text = ("")
        If Kfc17.Text <> ("") Then Kfc17.Text = ("")
        If Kfc18.Text <> ("") Then Kfc18.Text = ("")
        If Kfc19.Text <> ("") Then Kfc19.Text = ("")
        If Kfc20.Text <> ("") Then Kfc20.Text = ("")
        If Kfc21.Text <> ("") Then Kfc21.Text = ("")
        If Kfc22.Text <> ("") Then Kfc22.Text = ("")

        For brojilo0 = 1 To 9
            sumK = s(brojilo0) + sumK
        Next brojilo0

        If N < 3 Then GoTo kraj
        If N > 9 Then Kfc9.ForeColor = Drawing.Color.DarkGoldenrod Else Kfc9.ForeColor = Drawing.Color.Black
        If N >= 9 Then N = 9 Else N = N


        For a = 1 To N

            For b = 1 To N
                If b = a Then GoTo nextb

                If N = 2 Then

                    V = s(a) * s(b) / (sumK * (sumK - s(a)))
                    If a = 1 Then PRVI01 = PRVI01 + V
                    If a = 1 Or b = 1 Then PRVI01ILIDRUGI = PRVI01ILIDRUGI + V
                    PRVI01ILIDRUGIILITRECI = 0.001
                    If (a = 1 And b = 2) Then PRVI01IDRUGI = PRVI01IDRUGI + V
                    If (a = 1 And b = 2) Or (a = 2 And b = 1) Then PIDILIDIP01 = PIDILIDIP01 + V
                    GoTo nextb
                End If

                For c = 1 To N
                    If c = a Then GoTo Nextc
                    If c = b Then GoTo Nextc

                    If N = 3 Then

                        V = s(a) * s(b) * s(c) / (sumK * (sumK - s(a)) * (sumK - s(a) - s(b)))
                        If a = 1 Then PRVI01 = PRVI01 + V
                        If a = 1 Or b = 1 Then PRVI01ILIDRUGI = PRVI01ILIDRUGI + V
                        If a = 1 Or b = 1 Or c = 1 Then PRVI01ILIDRUGIILITRECI = PRVI01ILIDRUGIILITRECI + V
                        If a = 2 Then PRVI02 = PRVI02 + V
                        If a = 2 Or b = 2 Then PRVI02ILIDRUGI = PRVI02ILIDRUGI + V
                        If a = 2 Or b = 2 Or c = 2 Then PRVI02ILIDRUGIILITRECI = PRVI02ILIDRUGIILITRECI + V
                        If a = 3 Then PRVI03 = PRVI03 + V
                        If a = 3 Or b = 3 Then PRVI03ILIDRUGI = PRVI03ILIDRUGI + V
                        If a = 3 Or b = 3 Or c = 3 Then PRVI03ILIDRUGIILITRECI = PRVI03ILIDRUGIILITRECI + V
                        If a = 4 Then PRVI04 = PRVI04 + V
                        If a = 4 Or b = 4 Then PRVI04ILIDRUGI = PRVI04ILIDRUGI + V
                        If a = 4 Or b = 4 Or c = 4 Then PRVI04ILIDRUGIILITRECI = PRVI04ILIDRUGIILITRECI + V
                        If a = 5 Then PRVI05 = PRVI05 + V
                        If a = 5 Or b = 5 Then PRVI05ILIDRUGI = PRVI05ILIDRUGI + V
                        If a = 5 Or b = 5 Or c = 5 Then PRVI05ILIDRUGIILITRECI = PRVI05ILIDRUGIILITRECI + V
                        If a = 6 Then PRVI06 = PRVI06 + V
                        If a = 6 Or b = 6 Then PRVI06ILIDRUGI = PRVI06ILIDRUGI + V
                        If a = 6 Or b = 6 Or c = 6 Then PRVI06ILIDRUGIILITRECI = PRVI06ILIDRUGIILITRECI + V
                        If a = 7 Then PRVI07 = PRVI07 + V
                        If a = 7 Or b = 7 Then PRVI07ILIDRUGI = PRVI07ILIDRUGI + V
                        If a = 7 Or b = 7 Or c = 7 Then PRVI07ILIDRUGIILITRECI = PRVI07ILIDRUGIILITRECI + V
                        If a = 8 Then PRVI08 = PRVI08 + V
                        If a = 8 Or b = 8 Then PRVI08ILIDRUGI = PRVI08ILIDRUGI + V
                        If a = 8 Or b = 8 Or c = 8 Then PRVI08ILIDRUGIILITRECI = PRVI08ILIDRUGIILITRECI + V
                        If a = 9 Then PRVI09 = PRVI09 + V
                        If a = 9 Or b = 9 Then PRVI09ILIDRUGI = PRVI09ILIDRUGI + V
                        If a = 9 Or b = 9 Or c = 9 Then PRVI09ILIDRUGIILITRECI = PRVI09ILIDRUGIILITRECI + V

                        If (a = 1 And b = 2) Then PRVI01IDRUGI = PRVI01IDRUGI + V
                        If (a = 1 And b = 2) Or (a = 2 And b = 1) Then PIDILIDIP01 = PIDILIDIP01 + V
                        If (a = 2 And b = 3) Then PRVI02IDRUGI = PRVI02IDRUGI + V
                        If (a = 2 And b = 3) Or (a = 3 And b = 2) Then PIDILIDIP02 = PIDILIDIP02 + V
                        If (a = 1 And b = 3) Then PRVI03IDRUGI = PRVI03IDRUGI + V
                        If (a = 1 And b = 3) Or (a = 3 And b = 1) Then PIDILIDIP03 = PIDILIDIP03 + V
                        GoTo nextc
                    End If

                    For d = 1 To N
                        If d = a Then GoTo Nextd
                        If d = b Then GoTo Nextd
                        If d = c Then GoTo Nextd

                        If N = 4 Then

                            V = s(a) * s(b) * s(c) * s(d) / (sumK * (sumK - s(a)) * (sumK - s(a) - s(b)) * (sumK - s(a) - s(b) - s(c)))
                            If a = 1 Then PRVI01 = PRVI01 + V
                            If a = 1 Or b = 1 Then PRVI01ILIDRUGI = PRVI01ILIDRUGI + V
                            If a = 1 Or b = 1 Or c = 1 Then PRVI01ILIDRUGIILITRECI = PRVI01ILIDRUGIILITRECI + V
                            If a = 1 Or b = 1 Or c = 1 Or d = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTI = PRVI01ILIDRUGIILITRECIILICETVRTI + V
                            If a = 2 Then PRVI02 = PRVI02 + V
                            If a = 2 Or b = 2 Then PRVI02ILIDRUGI = PRVI02ILIDRUGI + V
                            If a = 2 Or b = 2 Or c = 2 Then PRVI02ILIDRUGIILITRECI = PRVI02ILIDRUGIILITRECI + V
                            If a = 2 Or b = 2 Or c = 2 Or d = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTI = PRVI02ILIDRUGIILITRECIILICETVRTI + V
                            If a = 3 Then PRVI03 = PRVI03 + V
                            If a = 3 Or b = 3 Then PRVI03ILIDRUGI = PRVI03ILIDRUGI + V
                            If a = 3 Or b = 3 Or c = 3 Then PRVI03ILIDRUGIILITRECI = PRVI03ILIDRUGIILITRECI + V
                            If a = 3 Or b = 3 Or c = 3 Or d = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTI = PRVI03ILIDRUGIILITRECIILICETVRTI + V
                            If a = 4 Then PRVI04 = PRVI04 + V
                            If a = 4 Or b = 4 Then PRVI04ILIDRUGI = PRVI04ILIDRUGI + V
                            If a = 4 Or b = 4 Or c = 4 Then PRVI04ILIDRUGIILITRECI = PRVI04ILIDRUGIILITRECI + V
                            If a = 4 Or b = 4 Or c = 4 Or d = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTI = PRVI04ILIDRUGIILITRECIILICETVRTI + V
                            If a = 5 Then PRVI05 = PRVI05 + V
                            If a = 5 Or b = 5 Then PRVI05ILIDRUGI = PRVI05ILIDRUGI + V
                            If a = 5 Or b = 5 Or c = 5 Then PRVI05ILIDRUGIILITRECI = PRVI05ILIDRUGIILITRECI + V
                            If a = 5 Or b = 5 Or c = 5 Or d = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTI = PRVI05ILIDRUGIILITRECIILICETVRTI + V
                            If a = 6 Then PRVI06 = PRVI06 + V
                            If a = 6 Or b = 6 Then PRVI06ILIDRUGI = PRVI06ILIDRUGI + V
                            If a = 6 Or b = 6 Or c = 6 Then PRVI06ILIDRUGIILITRECI = PRVI06ILIDRUGIILITRECI + V
                            If a = 6 Or b = 6 Or c = 6 Or d = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTI = PRVI06ILIDRUGIILITRECIILICETVRTI + V
                            If a = 7 Then PRVI07 = PRVI07 + V
                            If a = 7 Or b = 7 Then PRVI07ILIDRUGI = PRVI07ILIDRUGI + V
                            If a = 7 Or b = 7 Or c = 7 Then PRVI07ILIDRUGIILITRECI = PRVI07ILIDRUGIILITRECI + V
                            If a = 7 Or b = 7 Or c = 7 Or d = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTI = PRVI07ILIDRUGIILITRECIILICETVRTI + V
                            If a = 8 Then PRVI08 = PRVI08 + V
                            If a = 8 Or b = 8 Then PRVI08ILIDRUGI = PRVI08ILIDRUGI + V
                            If a = 8 Or b = 8 Or c = 8 Then PRVI08ILIDRUGIILITRECI = PRVI08ILIDRUGIILITRECI + V
                            If a = 8 Or b = 8 Or c = 8 Or d = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTI = PRVI08ILIDRUGIILITRECIILICETVRTI + V
                            If a = 9 Then PRVI09 = PRVI09 + V
                            If a = 9 Or b = 9 Then PRVI09ILIDRUGI = PRVI09ILIDRUGI + V
                            If a = 9 Or b = 9 Or c = 9 Then PRVI09ILIDRUGIILITRECI = PRVI09ILIDRUGIILITRECI + V
                            If a = 9 Or b = 9 Or c = 9 Or d = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTI = PRVI09ILIDRUGIILITRECIILICETVRTI + V

                            If (a = 1 And b = 2) Then PRVI01IDRUGI = PRVI01IDRUGI + V
                            If (a = 1 And b = 2) Or (a = 2 And b = 1) Then PIDILIDIP01 = PIDILIDIP01 + V
                            If (a = 2 And b = 3) Then PRVI02IDRUGI = PRVI02IDRUGI + V
                            If (a = 2 And b = 3) Or (a = 3 And b = 2) Then PIDILIDIP02 = PIDILIDIP02 + V
                            If (a = 1 And b = 3) Then PRVI03IDRUGI = PRVI03IDRUGI + V
                            If (a = 1 And b = 3) Or (a = 3 And b = 1) Then PIDILIDIP03 = PIDILIDIP03 + V
                            GoTo nextd
                        End If

                        For f = 1 To N
                            If f = a Then GoTo Nextf
                            If f = b Then GoTo Nextf
                            If f = c Then GoTo Nextf
                            If f = d Then GoTo Nextf

                            If N = 5 Then

                                V = s(a) * s(b) * s(c) * s(d) * s(f) / (sumK * (sumK - s(a)) * (sumK - s(a) - s(b)) * (sumK - s(a) - s(b) - s(c)) * (sumK - s(a) - s(b) - s(c) - s(d)))
                                If a = 1 Then PRVI01 = PRVI01 + V
                                If a = 1 Or b = 1 Then PRVI01ILIDRUGI = PRVI01ILIDRUGI + V
                                If a = 1 Or b = 1 Or c = 1 Then PRVI01ILIDRUGIILITRECI = PRVI01ILIDRUGIILITRECI + V
                                If a = 1 Or b = 1 Or c = 1 Or d = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTI = PRVI01ILIDRUGIILITRECIILICETVRTI + V
                                If a = 1 Or b = 1 Or c = 1 Or d = 1 Or f = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                If a = 2 Then PRVI02 = PRVI02 + V
                                If a = 2 Or b = 2 Then PRVI02ILIDRUGI = PRVI02ILIDRUGI + V
                                If a = 2 Or b = 2 Or c = 2 Then PRVI02ILIDRUGIILITRECI = PRVI02ILIDRUGIILITRECI + V
                                If a = 2 Or b = 2 Or c = 2 Or d = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTI = PRVI02ILIDRUGIILITRECIILICETVRTI + V
                                If a = 2 Or b = 2 Or c = 2 Or d = 2 Or f = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                If a = 3 Then PRVI03 = PRVI03 + V
                                If a = 3 Or b = 3 Then PRVI03ILIDRUGI = PRVI03ILIDRUGI + V
                                If a = 3 Or b = 3 Or c = 3 Then PRVI03ILIDRUGIILITRECI = PRVI03ILIDRUGIILITRECI + V
                                If a = 3 Or b = 3 Or c = 3 Or d = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTI = PRVI03ILIDRUGIILITRECIILICETVRTI + V
                                If a = 3 Or b = 3 Or c = 3 Or d = 3 Or f = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                If a = 4 Then PRVI04 = PRVI04 + V
                                If a = 4 Or b = 4 Then PRVI04ILIDRUGI = PRVI04ILIDRUGI + V
                                If a = 4 Or b = 4 Or c = 4 Then PRVI04ILIDRUGIILITRECI = PRVI04ILIDRUGIILITRECI + V
                                If a = 4 Or b = 4 Or c = 4 Or d = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTI = PRVI04ILIDRUGIILITRECIILICETVRTI + V
                                If a = 4 Or b = 4 Or c = 4 Or d = 4 Or f = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                If a = 5 Then PRVI05 = PRVI05 + V
                                If a = 5 Or b = 5 Then PRVI05ILIDRUGI = PRVI05ILIDRUGI + V
                                If a = 5 Or b = 5 Or c = 5 Then PRVI05ILIDRUGIILITRECI = PRVI05ILIDRUGIILITRECI + V
                                If a = 5 Or b = 5 Or c = 5 Or d = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTI = PRVI05ILIDRUGIILITRECIILICETVRTI + V
                                If a = 5 Or b = 5 Or c = 5 Or d = 5 Or f = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                If a = 6 Then PRVI06 = PRVI06 + V
                                If a = 6 Or b = 6 Then PRVI06ILIDRUGI = PRVI06ILIDRUGI + V
                                If a = 6 Or b = 6 Or c = 6 Then PRVI06ILIDRUGIILITRECI = PRVI06ILIDRUGIILITRECI + V
                                If a = 6 Or b = 6 Or c = 6 Or d = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTI = PRVI06ILIDRUGIILITRECIILICETVRTI + V
                                If a = 6 Or b = 6 Or c = 6 Or d = 6 Or f = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                If a = 7 Then PRVI07 = PRVI07 + V
                                If a = 7 Or b = 7 Then PRVI07ILIDRUGI = PRVI07ILIDRUGI + V
                                If a = 7 Or b = 7 Or c = 7 Then PRVI07ILIDRUGIILITRECI = PRVI07ILIDRUGIILITRECI + V
                                If a = 7 Or b = 7 Or c = 7 Or d = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTI = PRVI07ILIDRUGIILITRECIILICETVRTI + V
                                If a = 7 Or b = 7 Or c = 7 Or d = 7 Or f = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                If a = 8 Then PRVI08 = PRVI08 + V
                                If a = 8 Or b = 8 Then PRVI08ILIDRUGI = PRVI08ILIDRUGI + V
                                If a = 8 Or b = 8 Or c = 8 Then PRVI08ILIDRUGIILITRECI = PRVI08ILIDRUGIILITRECI + V
                                If a = 8 Or b = 8 Or c = 8 Or d = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTI = PRVI08ILIDRUGIILITRECIILICETVRTI + V
                                If a = 8 Or b = 8 Or c = 8 Or d = 8 Or f = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                If a = 9 Then PRVI09 = PRVI09 + V
                                If a = 9 Or b = 9 Then PRVI09ILIDRUGI = PRVI09ILIDRUGI + V
                                If a = 9 Or b = 9 Or c = 9 Then PRVI09ILIDRUGIILITRECI = PRVI09ILIDRUGIILITRECI + V
                                If a = 9 Or b = 9 Or c = 9 Or d = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTI = PRVI09ILIDRUGIILITRECIILICETVRTI + V
                                If a = 9 Or b = 9 Or c = 9 Or d = 9 Or f = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI + V

                                If (a = 1 And b = 2) Then PRVI01IDRUGI = PRVI01IDRUGI + V
                                If (a = 1 And b = 2) Or (a = 2 And b = 1) Then PIDILIDIP01 = PIDILIDIP01 + V
                                If (a = 2 And b = 3) Then PRVI02IDRUGI = PRVI02IDRUGI + V
                                If (a = 2 And b = 3) Or (a = 3 And b = 2) Then PIDILIDIP02 = PIDILIDIP02 + V
                                If (a = 1 And b = 3) Then PRVI03IDRUGI = PRVI03IDRUGI + V
                                If (a = 1 And b = 3) Or (a = 3 And b = 1) Then PIDILIDIP03 = PIDILIDIP03 + V
                                GoTo nextf
                            End If

                            For g = 1 To N
                                If g = a Then GoTo Nextg
                                If g = b Then GoTo Nextg
                                If g = c Then GoTo Nextg
                                If g = d Then GoTo Nextg
                                If g = f Then GoTo Nextg

                                If N = 6 Then

                                    V = s(a) * s(b) * s(c) * s(d) * s(f) * s(g) / (sumK * (sumK - s(a)) * (sumK - s(a) - s(b)) * (sumK - s(a) - s(b) - s(c)) * (sumK - s(a) - s(b) - s(c) - s(d)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f)))
                                    If a = 1 Then PRVI01 = PRVI01 + V
                                    If a = 1 Or b = 1 Then PRVI01ILIDRUGI = PRVI01ILIDRUGI + V
                                    If a = 1 Or b = 1 Or c = 1 Then PRVI01ILIDRUGIILITRECI = PRVI01ILIDRUGIILITRECI + V
                                    If a = 1 Or b = 1 Or c = 1 Or d = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTI = PRVI01ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 1 Or b = 1 Or c = 1 Or d = 1 Or f = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                    If a = 2 Then PRVI02 = PRVI02 + V
                                    If a = 2 Or b = 2 Then PRVI02ILIDRUGI = PRVI02ILIDRUGI + V
                                    If a = 2 Or b = 2 Or c = 2 Then PRVI02ILIDRUGIILITRECI = PRVI02ILIDRUGIILITRECI + V
                                    If a = 2 Or b = 2 Or c = 2 Or d = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTI = PRVI02ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 2 Or b = 2 Or c = 2 Or d = 2 Or f = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                    If a = 3 Then PRVI03 = PRVI03 + V
                                    If a = 3 Or b = 3 Then PRVI03ILIDRUGI = PRVI03ILIDRUGI + V
                                    If a = 3 Or b = 3 Or c = 3 Then PRVI03ILIDRUGIILITRECI = PRVI03ILIDRUGIILITRECI + V
                                    If a = 3 Or b = 3 Or c = 3 Or d = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTI = PRVI03ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 3 Or b = 3 Or c = 3 Or d = 3 Or f = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                    If a = 4 Then PRVI04 = PRVI04 + V
                                    If a = 4 Or b = 4 Then PRVI04ILIDRUGI = PRVI04ILIDRUGI + V
                                    If a = 4 Or b = 4 Or c = 4 Then PRVI04ILIDRUGIILITRECI = PRVI04ILIDRUGIILITRECI + V
                                    If a = 4 Or b = 4 Or c = 4 Or d = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTI = PRVI04ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 4 Or b = 4 Or c = 4 Or d = 4 Or f = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                    If a = 5 Then PRVI05 = PRVI05 + V
                                    If a = 5 Or b = 5 Then PRVI05ILIDRUGI = PRVI05ILIDRUGI + V
                                    If a = 5 Or b = 5 Or c = 5 Then PRVI05ILIDRUGIILITRECI = PRVI05ILIDRUGIILITRECI + V
                                    If a = 5 Or b = 5 Or c = 5 Or d = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTI = PRVI05ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 5 Or b = 5 Or c = 5 Or d = 5 Or f = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                    If a = 6 Then PRVI06 = PRVI06 + V
                                    If a = 6 Or b = 6 Then PRVI06ILIDRUGI = PRVI06ILIDRUGI + V
                                    If a = 6 Or b = 6 Or c = 6 Then PRVI06ILIDRUGIILITRECI = PRVI06ILIDRUGIILITRECI + V
                                    If a = 6 Or b = 6 Or c = 6 Or d = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTI = PRVI06ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 6 Or b = 6 Or c = 6 Or d = 6 Or f = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                    If a = 7 Then PRVI07 = PRVI07 + V
                                    If a = 7 Or b = 7 Then PRVI07ILIDRUGI = PRVI07ILIDRUGI + V
                                    If a = 7 Or b = 7 Or c = 7 Then PRVI07ILIDRUGIILITRECI = PRVI07ILIDRUGIILITRECI + V
                                    If a = 7 Or b = 7 Or c = 7 Or d = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTI = PRVI07ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 7 Or b = 7 Or c = 7 Or d = 7 Or f = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                    If a = 8 Then PRVI08 = PRVI08 + V
                                    If a = 8 Or b = 8 Then PRVI08ILIDRUGI = PRVI08ILIDRUGI + V
                                    If a = 8 Or b = 8 Or c = 8 Then PRVI08ILIDRUGIILITRECI = PRVI08ILIDRUGIILITRECI + V
                                    If a = 8 Or b = 8 Or c = 8 Or d = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTI = PRVI08ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 8 Or b = 8 Or c = 8 Or d = 8 Or f = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                    If a = 9 Then PRVI09 = PRVI09 + V
                                    If a = 9 Or b = 9 Then PRVI09ILIDRUGI = PRVI09ILIDRUGI + V
                                    If a = 9 Or b = 9 Or c = 9 Then PRVI09ILIDRUGIILITRECI = PRVI09ILIDRUGIILITRECI + V
                                    If a = 9 Or b = 9 Or c = 9 Or d = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTI = PRVI09ILIDRUGIILITRECIILICETVRTI + V
                                    If a = 9 Or b = 9 Or c = 9 Or d = 9 Or f = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI + V


                                    If (a = 1 And b = 2) Then PRVI01IDRUGI = PRVI01IDRUGI + V
                                    If (a = 1 And b = 2) Or (a = 2 And b = 1) Then PIDILIDIP01 = PIDILIDIP01 + V
                                    If (a = 2 And b = 3) Then PRVI02IDRUGI = PRVI02IDRUGI + V
                                    If (a = 2 And b = 3) Or (a = 3 And b = 2) Then PIDILIDIP02 = PIDILIDIP02 + V
                                    If (a = 1 And b = 3) Then PRVI03IDRUGI = PRVI03IDRUGI + V
                                    If (a = 1 And b = 3) Or (a = 3 And b = 1) Then PIDILIDIP03 = PIDILIDIP03 + V
                                    GoTo nextg
                                End If

                                For h = 1 To N
                                    If h = a Then GoTo Nexth
                                    If h = b Then GoTo Nexth
                                    If h = c Then GoTo Nexth
                                    If h = d Then GoTo Nexth
                                    If h = f Then GoTo Nexth
                                    If h = g Then GoTo Nexth

                                    If N = 7 Then

                                        V = s(a) * s(b) * s(c) * s(d) * s(f) * s(g) * s(h) / (sumK * (sumK - s(a)) * (sumK - s(a) - s(b)) * (sumK - s(a) - s(b) - s(c)) * (sumK - s(a) - s(b) - s(c) - s(d)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f) - s(g)))
                                        If a = 1 Then PRVI01 = PRVI01 + V
                                        If a = 1 Or b = 1 Then PRVI01ILIDRUGI = PRVI01ILIDRUGI + V
                                        If a = 1 Or b = 1 Or c = 1 Then PRVI01ILIDRUGIILITRECI = PRVI01ILIDRUGIILITRECI + V
                                        If a = 1 Or b = 1 Or c = 1 Or d = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTI = PRVI01ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 1 Or b = 1 Or c = 1 Or d = 1 Or f = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                        If a = 2 Then PRVI02 = PRVI02 + V
                                        If a = 2 Or b = 2 Then PRVI02ILIDRUGI = PRVI02ILIDRUGI + V
                                        If a = 2 Or b = 2 Or c = 2 Then PRVI02ILIDRUGIILITRECI = PRVI02ILIDRUGIILITRECI + V
                                        If a = 2 Or b = 2 Or c = 2 Or d = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTI = PRVI02ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 2 Or b = 2 Or c = 2 Or d = 2 Or f = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                        If a = 3 Then PRVI03 = PRVI03 + V
                                        If a = 3 Or b = 3 Then PRVI03ILIDRUGI = PRVI03ILIDRUGI + V
                                        If a = 3 Or b = 3 Or c = 3 Then PRVI03ILIDRUGIILITRECI = PRVI03ILIDRUGIILITRECI + V
                                        If a = 3 Or b = 3 Or c = 3 Or d = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTI = PRVI03ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 3 Or b = 3 Or c = 3 Or d = 3 Or f = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                        If a = 4 Then PRVI04 = PRVI04 + V
                                        If a = 4 Or b = 4 Then PRVI04ILIDRUGI = PRVI04ILIDRUGI + V
                                        If a = 4 Or b = 4 Or c = 4 Then PRVI04ILIDRUGIILITRECI = PRVI04ILIDRUGIILITRECI + V
                                        If a = 4 Or b = 4 Or c = 4 Or d = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTI = PRVI04ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 4 Or b = 4 Or c = 4 Or d = 4 Or f = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                        If a = 5 Then PRVI05 = PRVI05 + V
                                        If a = 5 Or b = 5 Then PRVI05ILIDRUGI = PRVI05ILIDRUGI + V
                                        If a = 5 Or b = 5 Or c = 5 Then PRVI05ILIDRUGIILITRECI = PRVI05ILIDRUGIILITRECI + V
                                        If a = 5 Or b = 5 Or c = 5 Or d = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTI = PRVI05ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 5 Or b = 5 Or c = 5 Or d = 5 Or f = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                        If a = 6 Then PRVI06 = PRVI06 + V
                                        If a = 6 Or b = 6 Then PRVI06ILIDRUGI = PRVI06ILIDRUGI + V
                                        If a = 6 Or b = 6 Or c = 6 Then PRVI06ILIDRUGIILITRECI = PRVI06ILIDRUGIILITRECI + V
                                        If a = 6 Or b = 6 Or c = 6 Or d = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTI = PRVI06ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 6 Or b = 6 Or c = 6 Or d = 6 Or f = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                        If a = 7 Then PRVI07 = PRVI07 + V
                                        If a = 7 Or b = 7 Then PRVI07ILIDRUGI = PRVI07ILIDRUGI + V
                                        If a = 7 Or b = 7 Or c = 7 Then PRVI07ILIDRUGIILITRECI = PRVI07ILIDRUGIILITRECI + V
                                        If a = 7 Or b = 7 Or c = 7 Or d = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTI = PRVI07ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 7 Or b = 7 Or c = 7 Or d = 7 Or f = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                        If a = 8 Then PRVI08 = PRVI08 + V
                                        If a = 8 Or b = 8 Then PRVI08ILIDRUGI = PRVI08ILIDRUGI + V
                                        If a = 8 Or b = 8 Or c = 8 Then PRVI08ILIDRUGIILITRECI = PRVI08ILIDRUGIILITRECI + V
                                        If a = 8 Or b = 8 Or c = 8 Or d = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTI = PRVI08ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 8 Or b = 8 Or c = 8 Or d = 8 Or f = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                        If a = 9 Then PRVI09 = PRVI09 + V
                                        If a = 9 Or b = 9 Then PRVI09ILIDRUGI = PRVI09ILIDRUGI + V
                                        If a = 9 Or b = 9 Or c = 9 Then PRVI09ILIDRUGIILITRECI = PRVI09ILIDRUGIILITRECI + V
                                        If a = 9 Or b = 9 Or c = 9 Or d = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTI = PRVI09ILIDRUGIILITRECIILICETVRTI + V
                                        If a = 9 Or b = 9 Or c = 9 Or d = 9 Or f = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI + V

                                        If (a = 1 And b = 2) Then PRVI01IDRUGI = PRVI01IDRUGI + V
                                        If (a = 1 And b = 2) Or (a = 2 And b = 1) Then PIDILIDIP01 = PIDILIDIP01 + V
                                        If (a = 2 And b = 3) Then PRVI02IDRUGI = PRVI02IDRUGI + V
                                        If (a = 2 And b = 3) Or (a = 3 And b = 2) Then PIDILIDIP02 = PIDILIDIP02 + V
                                        If (a = 1 And b = 3) Then PRVI03IDRUGI = PRVI03IDRUGI + V
                                        If (a = 1 And b = 3) Or (a = 3 And b = 1) Then PIDILIDIP03 = PIDILIDIP03 + V
                                        GoTo nexth
                                    End If

                                    For i = 1 To N
                                        If i = a Then GoTo Nexti
                                        If i = b Then GoTo Nexti
                                        If i = c Then GoTo Nexti
                                        If i = d Then GoTo Nexti
                                        If i = f Then GoTo Nexti
                                        If i = g Then GoTo Nexti
                                        If i = h Then GoTo Nexti

                                        If N = 8 Then

                                            V = s(a) * s(b) * s(c) * s(d) * s(f) * s(g) * s(h) * s(i) / (sumK * (sumK - s(a)) * (sumK - s(a) - s(b)) * (sumK - s(a) - s(b) - s(c)) * (sumK - s(a) - s(b) - s(c) - s(d)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f) - s(g)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f) - s(g) - s(h)))
                                            If a = 1 Then PRVI01 = PRVI01 + V
                                            If a = 1 Or b = 1 Then PRVI01ILIDRUGI = PRVI01ILIDRUGI + V
                                            If a = 1 Or b = 1 Or c = 1 Then PRVI01ILIDRUGIILITRECI = PRVI01ILIDRUGIILITRECI + V
                                            If a = 1 Or b = 1 Or c = 1 Or d = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTI = PRVI01ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 1 Or b = 1 Or c = 1 Or d = 1 Or f = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                            If a = 2 Then PRVI02 = PRVI02 + V
                                            If a = 2 Or b = 2 Then PRVI02ILIDRUGI = PRVI02ILIDRUGI + V
                                            If a = 2 Or b = 2 Or c = 2 Then PRVI02ILIDRUGIILITRECI = PRVI02ILIDRUGIILITRECI + V
                                            If a = 2 Or b = 2 Or c = 2 Or d = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTI = PRVI02ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 2 Or b = 2 Or c = 2 Or d = 2 Or f = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                            If a = 3 Then PRVI03 = PRVI03 + V
                                            If a = 3 Or b = 3 Then PRVI03ILIDRUGI = PRVI03ILIDRUGI + V
                                            If a = 3 Or b = 3 Or c = 3 Then PRVI03ILIDRUGIILITRECI = PRVI03ILIDRUGIILITRECI + V
                                            If a = 3 Or b = 3 Or c = 3 Or d = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTI = PRVI03ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 3 Or b = 3 Or c = 3 Or d = 3 Or f = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                            If a = 4 Then PRVI04 = PRVI04 + V
                                            If a = 4 Or b = 4 Then PRVI04ILIDRUGI = PRVI04ILIDRUGI + V
                                            If a = 4 Or b = 4 Or c = 4 Then PRVI04ILIDRUGIILITRECI = PRVI04ILIDRUGIILITRECI + V
                                            If a = 4 Or b = 4 Or c = 4 Or d = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTI = PRVI04ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 4 Or b = 4 Or c = 4 Or d = 4 Or f = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                            If a = 5 Then PRVI05 = PRVI05 + V
                                            If a = 5 Or b = 5 Then PRVI05ILIDRUGI = PRVI05ILIDRUGI + V
                                            If a = 5 Or b = 5 Or c = 5 Then PRVI05ILIDRUGIILITRECI = PRVI05ILIDRUGIILITRECI + V
                                            If a = 5 Or b = 5 Or c = 5 Or d = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTI = PRVI05ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 5 Or b = 5 Or c = 5 Or d = 5 Or f = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                            If a = 6 Then PRVI06 = PRVI06 + V
                                            If a = 6 Or b = 6 Then PRVI06ILIDRUGI = PRVI06ILIDRUGI + V
                                            If a = 6 Or b = 6 Or c = 6 Then PRVI06ILIDRUGIILITRECI = PRVI06ILIDRUGIILITRECI + V
                                            If a = 6 Or b = 6 Or c = 6 Or d = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTI = PRVI06ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 6 Or b = 6 Or c = 6 Or d = 6 Or f = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                            If a = 7 Then PRVI07 = PRVI07 + V
                                            If a = 7 Or b = 7 Then PRVI07ILIDRUGI = PRVI07ILIDRUGI + V
                                            If a = 7 Or b = 7 Or c = 7 Then PRVI07ILIDRUGIILITRECI = PRVI07ILIDRUGIILITRECI + V
                                            If a = 7 Or b = 7 Or c = 7 Or d = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTI = PRVI07ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 7 Or b = 7 Or c = 7 Or d = 7 Or f = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                            If a = 8 Then PRVI08 = PRVI08 + V
                                            If a = 8 Or b = 8 Then PRVI08ILIDRUGI = PRVI08ILIDRUGI + V
                                            If a = 8 Or b = 8 Or c = 8 Then PRVI08ILIDRUGIILITRECI = PRVI08ILIDRUGIILITRECI + V
                                            If a = 8 Or b = 8 Or c = 8 Or d = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTI = PRVI08ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 8 Or b = 8 Or c = 8 Or d = 8 Or f = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                            If a = 9 Then PRVI09 = PRVI09 + V
                                            If a = 9 Or b = 9 Then PRVI09ILIDRUGI = PRVI09ILIDRUGI + V
                                            If a = 9 Or b = 9 Or c = 9 Then PRVI09ILIDRUGIILITRECI = PRVI09ILIDRUGIILITRECI + V
                                            If a = 9 Or b = 9 Or c = 9 Or d = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTI = PRVI09ILIDRUGIILITRECIILICETVRTI + V
                                            If a = 9 Or b = 9 Or c = 9 Or d = 9 Or f = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI + V

                                            If (a = 1 And b = 2) Then PRVI01IDRUGI = PRVI01IDRUGI + V
                                            If (a = 1 And b = 2) Or (a = 2 And b = 1) Then PIDILIDIP01 = PIDILIDIP01 + V
                                            If (a = 2 And b = 3) Then PRVI02IDRUGI = PRVI02IDRUGI + V
                                            If (a = 2 And b = 3) Or (a = 3 And b = 2) Then PIDILIDIP02 = PIDILIDIP02 + V
                                            If (a = 1 And b = 3) Then PRVI03IDRUGI = PRVI03IDRUGI + V
                                            If (a = 1 And b = 3) Or (a = 3 And b = 1) Then PIDILIDIP03 = PIDILIDIP03 + V
                                            GoTo nexti
                                        End If

                                        For j = 1 To N
                                            If j = a Then GoTo Nextj
                                            If j = b Then GoTo Nextj
                                            If j = c Then GoTo Nextj
                                            If j = d Then GoTo Nextj
                                            If j = f Then GoTo Nextj
                                            If j = g Then GoTo Nextj
                                            If j = h Then GoTo Nextj
                                            If j = i Then GoTo Nextj

                                            If N = 9 Then

                                                V = s(a) * s(b) * s(c) * s(d) * s(f) * s(g) * s(h) * s(i) * s(j) / (sumK * (sumK - s(a)) * (sumK - s(a) - s(b)) * (sumK - s(a) - s(b) - s(c)) * (sumK - s(a) - s(b) - s(c) - s(d)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f) - s(g)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f) - s(g) - s(h)) * (sumK - s(a) - s(b) - s(c) - s(d) - s(f) - s(g) - s(h) - s(i)))
                                                If a = 1 Then PRVI01 = PRVI01 + V
                                                If a = 1 Or b = 1 Then PRVI01ILIDRUGI = PRVI01ILIDRUGI + V
                                                If a = 1 Or b = 1 Or c = 1 Then PRVI01ILIDRUGIILITRECI = PRVI01ILIDRUGIILITRECI + V
                                                If a = 1 Or b = 1 Or c = 1 Or d = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTI = PRVI01ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 1 Or b = 1 Or c = 1 Or d = 1 Or f = 1 Then PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                                If a = 2 Then PRVI02 = PRVI02 + V
                                                If a = 2 Or b = 2 Then PRVI02ILIDRUGI = PRVI02ILIDRUGI + V
                                                If a = 2 Or b = 2 Or c = 2 Then PRVI02ILIDRUGIILITRECI = PRVI02ILIDRUGIILITRECI + V
                                                If a = 2 Or b = 2 Or c = 2 Or d = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTI = PRVI02ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 2 Or b = 2 Or c = 2 Or d = 2 Or f = 2 Then PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                                If a = 3 Then PRVI03 = PRVI03 + V
                                                If a = 3 Or b = 3 Then PRVI03ILIDRUGI = PRVI03ILIDRUGI + V
                                                If a = 3 Or b = 3 Or c = 3 Then PRVI03ILIDRUGIILITRECI = PRVI03ILIDRUGIILITRECI + V
                                                If a = 3 Or b = 3 Or c = 3 Or d = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTI = PRVI03ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 3 Or b = 3 Or c = 3 Or d = 3 Or f = 3 Then PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                                If a = 4 Then PRVI04 = PRVI04 + V
                                                If a = 4 Or b = 4 Then PRVI04ILIDRUGI = PRVI04ILIDRUGI + V
                                                If a = 4 Or b = 4 Or c = 4 Then PRVI04ILIDRUGIILITRECI = PRVI04ILIDRUGIILITRECI + V
                                                If a = 4 Or b = 4 Or c = 4 Or d = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTI = PRVI04ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 4 Or b = 4 Or c = 4 Or d = 4 Or f = 4 Then PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                                If a = 5 Then PRVI05 = PRVI05 + V
                                                If a = 5 Or b = 5 Then PRVI05ILIDRUGI = PRVI05ILIDRUGI + V
                                                If a = 5 Or b = 5 Or c = 5 Then PRVI05ILIDRUGIILITRECI = PRVI05ILIDRUGIILITRECI + V
                                                If a = 5 Or b = 5 Or c = 5 Or d = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTI = PRVI05ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 5 Or b = 5 Or c = 5 Or d = 5 Or f = 5 Then PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                                If a = 6 Then PRVI06 = PRVI06 + V
                                                If a = 6 Or b = 6 Then PRVI06ILIDRUGI = PRVI06ILIDRUGI + V
                                                If a = 6 Or b = 6 Or c = 6 Then PRVI06ILIDRUGIILITRECI = PRVI06ILIDRUGIILITRECI + V
                                                If a = 6 Or b = 6 Or c = 6 Or d = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTI = PRVI06ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 6 Or b = 6 Or c = 6 Or d = 6 Or f = 6 Then PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                                If a = 7 Then PRVI07 = PRVI07 + V
                                                If a = 7 Or b = 7 Then PRVI07ILIDRUGI = PRVI07ILIDRUGI + V
                                                If a = 7 Or b = 7 Or c = 7 Then PRVI07ILIDRUGIILITRECI = PRVI07ILIDRUGIILITRECI + V
                                                If a = 7 Or b = 7 Or c = 7 Or d = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTI = PRVI07ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 7 Or b = 7 Or c = 7 Or d = 7 Or f = 7 Then PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                                If a = 8 Then PRVI08 = PRVI08 + V
                                                If a = 8 Or b = 8 Then PRVI08ILIDRUGI = PRVI08ILIDRUGI + V
                                                If a = 8 Or b = 8 Or c = 8 Then PRVI08ILIDRUGIILITRECI = PRVI08ILIDRUGIILITRECI + V
                                                If a = 8 Or b = 8 Or c = 8 Or d = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTI = PRVI08ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 8 Or b = 8 Or c = 8 Or d = 8 Or f = 8 Then PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI + V
                                                If a = 9 Then PRVI09 = PRVI09 + V
                                                If a = 9 Or b = 9 Then PRVI09ILIDRUGI = PRVI09ILIDRUGI + V
                                                If a = 9 Or b = 9 Or c = 9 Then PRVI09ILIDRUGIILITRECI = PRVI09ILIDRUGIILITRECI + V
                                                If a = 9 Or b = 9 Or c = 9 Or d = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTI = PRVI09ILIDRUGIILITRECIILICETVRTI + V
                                                If a = 9 Or b = 9 Or c = 9 Or d = 9 Or f = 9 Then PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI = PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI + V

                                                If (a = 1 And b = 2) Then PRVI01IDRUGI = PRVI01IDRUGI + V
                                                If (a = 1 And b = 2) Or (a = 2 And b = 1) Then PIDILIDIP01 = PIDILIDIP01 + V
                                                If (a = 2 And b = 3) Then PRVI02IDRUGI = PRVI02IDRUGI + V
                                                If (a = 2 And b = 3) Or (a = 3 And b = 2) Then PIDILIDIP02 = PIDILIDIP02 + V
                                                If (a = 1 And b = 3) Then PRVI03IDRUGI = PRVI03IDRUGI + V
                                                If (a = 1 And b = 3) Or (a = 3 And b = 1) Then PIDILIDIP03 = PIDILIDIP03 + V
                                                GoTo nextj
                                            End If


nextj:                                  Next j
nexti:                              Next i
nexth:                          Next h
nextg:                      Next g
nextf:                  Next f
nextd:              Next d
nextc:          Next c
nextb:      Next b
nexta:  Next a

ostatak:
        If s(9) = 0 Then Kfc9.Text = ("") Else Kfc9.Text = FormatNumber(1 / PRVI09 / sumasvihS, 2)

        P01lace1.Text = FormatNumber(1 / PRVI01, 2)
        P1OR2lace1.Text = FormatNumber(1 / PRVI01ILIDRUGI, 2)
        P1OR2OR3lace1.Text = FormatNumber(1 / PRVI01ILIDRUGIILITRECI, 2)
        If N >= 4 Then P1OR2or3or4lace1.Text = FormatNumber(1 / PRVI01ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace1.Text = ("")
        If N >= 5 Then P1OR2OR3or4or5lace1.Text = FormatNumber(1 / PRVI01ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace1.Text = ("")
        P1and2lace1.Text = FormatNumber(1 / PRVI01IDRUGI, 2)
        P1and2or2and1lace01.Text = FormatNumber(1 / PIDILIDIP01, 2)

        P01lace2.Text = FormatNumber(1 / PRVI02, 2)
        P1OR2lace2.Text = FormatNumber(1 / PRVI02ILIDRUGI, 2)
        P1OR2OR3lace2.Text = FormatNumber(1 / PRVI02ILIDRUGIILITRECI, 2)
        If N >= 4 Then P1OR2or3or4lace2.Text = FormatNumber(1 / PRVI02ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace2.Text = ("")
        If N >= 5 Then P1OR2OR3or4or5lace2.Text = FormatNumber(1 / PRVI02ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace2.Text = ("")
        P1and2lace2.Text = FormatNumber(1 / PRVI02IDRUGI, 2)
        P1and2or2and1lace2.Text = FormatNumber(1 / PIDILIDIP02, 2)

        P01lace3.Text = FormatNumber(1 / PRVI03, 2)
        P1OR2lace3.Text = FormatNumber(1 / PRVI03ILIDRUGI, 2)
        P1OR2OR3lace3.Text = FormatNumber(1 / PRVI03ILIDRUGIILITRECI, 2)
        If N >= 4 Then P1OR2or3or4lace3.Text = FormatNumber(1 / PRVI03ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace3.Text = ("")
        If N >= 5 Then P1OR2OR3or4or5lace3.Text = FormatNumber(1 / PRVI03ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace3.Text = ("")
        P1and2lace3.Text = FormatNumber(1 / PRVI03IDRUGI, 2)
        P1and2or2and1lace3.Text = FormatNumber(1 / PIDILIDIP03, 2)

        If N >= 4 Then P01lace4.Text = FormatNumber(1 / PRVI04, 2) Else P01lace4.Text = ("")
        If N >= 4 Then P1OR2lace4.Text = FormatNumber(1 / PRVI04ILIDRUGI, 2) Else P01lace4.Text = ("")
        If N >= 4 Then P1OR2OR3lace4.Text = FormatNumber(1 / PRVI04ILIDRUGIILITRECI, 2) Else P01lace4.Text = ("")
        If N >= 4 Then P1OR2or3or4lace4.Text = FormatNumber(1 / PRVI04ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace4.Text = ("")
        If N >= 5 Then P1OR2OR3or4or5lace4.Text = FormatNumber(1 / PRVI04ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace4.Text = ("")

        If N >= 5 Then P01lace5.Text = FormatNumber(1 / PRVI05, 2) Else P01lace5.Text = ("")
        If N >= 5 Then P1OR2lace5.Text = FormatNumber(1 / PRVI05ILIDRUGI, 2) Else P01lace5.Text = ("")
        If N >= 5 Then P1OR2OR3lace5.Text = FormatNumber(1 / PRVI05ILIDRUGIILITRECI, 2) Else P01lace5.Text = ("")
        If N >= 5 Then P1OR2or3or4lace5.Text = FormatNumber(1 / PRVI05ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace5.Text = ("")
        If N >= 5 Then P1OR2OR3or4or5lace5.Text = FormatNumber(1 / PRVI05ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace5.Text = ("")

        If N >= 6 Then P01lace6.Text = FormatNumber(1 / PRVI06, 2) Else P01lace6.Text = ("")
        If N >= 6 Then P1OR2lace6.Text = FormatNumber(1 / PRVI06ILIDRUGI, 2) Else P01lace6.Text = ("")
        If N >= 6 Then P1OR2OR3lace6.Text = FormatNumber(1 / PRVI06ILIDRUGIILITRECI, 2) Else P01lace6.Text = ("")
        If N >= 6 Then P1OR2or3or4lace6.Text = FormatNumber(1 / PRVI06ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace6.Text = ("")
        If N >= 6 Then P1OR2OR3or4or5lace6.Text = FormatNumber(1 / PRVI06ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace6.Text = ("")

        If N >= 7 Then P01lace7.Text = FormatNumber(1 / PRVI07, 2) Else P01lace7.Text = ("")
        If N >= 7 Then P1OR2lace7.Text = FormatNumber(1 / PRVI07ILIDRUGI, 2) Else P01lace7.Text = ("")
        If N >= 7 Then P1OR2OR3lace7.Text = FormatNumber(1 / PRVI07ILIDRUGIILITRECI, 2) Else P01lace7.Text = ("")
        If N >= 7 Then P1OR2or3or4lace7.Text = FormatNumber(1 / PRVI07ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace7.Text = ("")
        If N >= 7 Then P1OR2OR3or4or5lace7.Text = FormatNumber(1 / PRVI07ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace7.Text = ("")

        If N >= 8 Then P01lace8.Text = FormatNumber(1 / PRVI08, 2) Else P01lace8.Text = ("")
        If N >= 8 Then P1OR2lace8.Text = FormatNumber(1 / PRVI08ILIDRUGI, 2) Else P01lace8.Text = ("")
        If N >= 8 Then P1OR2OR3lace8.Text = FormatNumber(1 / PRVI08ILIDRUGIILITRECI, 2) Else P01lace8.Text = ("")
        If N >= 8 Then P1OR2or3or4lace8.Text = FormatNumber(1 / PRVI08ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace8.Text = ("")
        If N >= 8 Then P1OR2OR3or4or5lace8.Text = FormatNumber(1 / PRVI08ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace8.Text = ("")

        If N >= 9 Then P01lace9.Text = FormatNumber(1 / PRVI09, 2) Else P01lace9.Text = ("")
        If N >= 9 Then P1OR2lace9.Text = FormatNumber(1 / PRVI09ILIDRUGI, 2) Else P01lace9.Text = ("")
        If N >= 9 Then P1OR2OR3lace9.Text = FormatNumber(1 / PRVI09ILIDRUGIILITRECI, 2) Else P01lace9.Text = ("")
        If N >= 9 Then P1OR2or3or4lace9.Text = FormatNumber(1 / PRVI09ILIDRUGIILITRECIILICETVRTI, 2) Else P1OR2or3or4lace9.Text = ("")
        If N >= 9 Then P1OR2OR3or4or5lace9.Text = FormatNumber(1 / PRVI09ILIDRUGIILITRECIILICETVRTIILIPETI, 2) Else P1OR2OR3or4or5lace9.Text = ("")

kraj:
    End Sub


End Class