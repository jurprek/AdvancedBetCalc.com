Public Class Systems_Table
    Inherits System.Web.UI.Page
    Dim NmKfaktorijelabin, Kfaktorijelabin, Nfaktorijelabin, IzlazKomb, NfactKmbn, KfactKmbn, tmb, bu1, bu2, bu3, bu4, bu5, bu6, bu7, bu8, bu9, bu10, bu11, bu12, bu13, bu14, bu15, bu16, bu17, bu18, bu19, bu20, vfv, ddd, MAxBanka, BestY, tt, MaxBank1, MaxBank2, MaxBank3, MaxBank4, MaxBank5, MaxBank6, MaxBank7, MaxBank8, MaxBank9, MaxBank10, MaxBank11, MaxBank12, MaxBank13, MaxBank14, MaxBank15, MaxBank16, MaxBank17, MaxBank18, MaxBank19, MaxBank20, BestU1, BestU2, BestU3, BestU4, BestU5, BestU6, BestU7, BestU8, BestU9, BestU10, BestU11, BestU12, BestU13, BestU14, BestU15, BestU16, BestU17, BestU18, BestU19, BestU20, gg, a, c, q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20 As Decimal

    Protected Sub ImageButtonUK_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonUK.Click
        TextBoxHelpUK.Visible = True
        TextBoxHelpHR.Visible = False
    End Sub

    Protected Sub ImageButtonHR_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButtonHR.Click
        TextBoxHelpUK.Visible = False
        TextBoxHelpHR.Visible = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' ovaj dio povlaci vrijednost sysY.text iz systemcalculator.aspx...
        Dim strY As String = ""
        strY = Session("myVariable1")
        If sysoutofY.Text = ("") Then sysoutofY.Text = strY Else sysoutofY.Text = sysoutofY.Text

        Dim strAvrgChanc As String = ""
        strAvrgChanc = Session("myVariable2")
        If avrgsanse.Text = ("") Then avrgsanse.Text = strAvrgChanc Else avrgsanse.Text = avrgsanse.Text

        Dim strAvrgKoefic As String = ""
        strAvrgKoefic = Session("myVariable3")
        If AvrgKfc.Text = ("") Then AvrgKfc.Text = strAvrgKoefic Else AvrgKfc.Text = AvrgKfc.Text

    End Sub
    Protected Sub ReClcBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReClcBtn.Click

        Cmbnt_1.Text = ""
        Cmbnt_2.Text = ""
        Cmbnt_3.Text = ""
        Cmbnt_4.Text = ""
        Cmbnt_5.Text = ""
        Cmbnt_6.Text = ""
        Cmbnt_7.Text = ""
        Cmbnt_8.Text = ""
        Cmbnt_9.Text = ""
        Cmbnt_10.Text = ""
        Cmbnt_11.Text = ""
        Cmbnt_12.Text = ""
        Cmbnt_13.Text = ""
        Cmbnt_14.Text = ""
        Cmbnt_15.Text = ""
        Cmbnt_16.Text = ""
        Cmbnt_17.Text = ""
        Cmbnt_18.Text = ""
        Cmbnt_19.Text = ""
        Cmbnt_20.Text = ""

        Call Callme()

        If sysoutofY.Text >= 1 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 1
            Call FaktorijeleKomb()
            Cmbnt_1.Text = IzlazKomb
        Else Cmbnt_1.Text = ""
        End If

        If sysoutofY.Text >= 2 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 2
            Call FaktorijeleKomb()
            Cmbnt_2.Text = IzlazKomb
        Else Cmbnt_2.Text = ""
        End If

        If sysoutofY.Text >= 3 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 3
            Call FaktorijeleKomb()
            Cmbnt_3.Text = IzlazKomb
        Else Cmbnt_3.Text = ""
        End If

        If sysoutofY.Text >= 4 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 4
            Call FaktorijeleKomb()
            Cmbnt_4.Text = IzlazKomb
        Else Cmbnt_4.Text = ""
        End If

        If sysoutofY.Text >= 5 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 5
            Call FaktorijeleKomb()
            Cmbnt_5.Text = IzlazKomb
        Else Cmbnt_5.Text = ""
        End If

        If sysoutofY.Text >= 6 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 6
            Call FaktorijeleKomb()
            Cmbnt_6.Text = IzlazKomb
        Else Cmbnt_6.Text = ""
        End If

        If sysoutofY.Text >= 7 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 7
            Call FaktorijeleKomb()
            Cmbnt_7.Text = IzlazKomb
        Else Cmbnt_7.Text = ""
        End If

        If sysoutofY.Text >= 8 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 8
            Call FaktorijeleKomb()
            Cmbnt_8.Text = IzlazKomb
        Else Cmbnt_8.Text = ""
        End If

        If sysoutofY.Text >= 9 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 9
            Call FaktorijeleKomb()
            Cmbnt_9.Text = IzlazKomb
        Else Cmbnt_9.Text = ""
        End If

        If sysoutofY.Text >= 10 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 10
            Call FaktorijeleKomb()
            Cmbnt_10.Text = IzlazKomb
        Else Cmbnt_10.Text = ""
        End If

        If sysoutofY.Text >= 11 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 11
            Call FaktorijeleKomb()
            Cmbnt_11.Text = IzlazKomb
        Else Cmbnt_11.Text = ""
        End If

        If sysoutofY.Text >= 12 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 12
            Call FaktorijeleKomb()
            Cmbnt_12.Text = IzlazKomb
        Else Cmbnt_12.Text = ""
        End If

        If sysoutofY.Text >= 13 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 13
            Call FaktorijeleKomb()
            Cmbnt_13.Text = IzlazKomb
        Else Cmbnt_13.Text = ""
        End If

        If sysoutofY.Text >= 14 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 14
            Call FaktorijeleKomb()
            Cmbnt_14.Text = IzlazKomb
        Else Cmbnt_14.Text = ""
        End If

        If sysoutofY.Text >= 15 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 15
            Call FaktorijeleKomb()
            Cmbnt_15.Text = IzlazKomb
        Else Cmbnt_15.Text = ""
        End If

        If sysoutofY.Text >= 16 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 16
            Call FaktorijeleKomb()
            Cmbnt_16.Text = IzlazKomb
        Else Cmbnt_16.Text = ""
        End If

        If sysoutofY.Text >= 17 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 17
            Call FaktorijeleKomb()
            Cmbnt_17.Text = IzlazKomb
        Else Cmbnt_17.Text = ""
        End If

        If sysoutofY.Text >= 18 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 18
            Call FaktorijeleKomb()
            Cmbnt_18.Text = IzlazKomb
        Else Cmbnt_18.Text = ""
        End If

        If sysoutofY.Text >= 19 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 19
            Call FaktorijeleKomb()
            Cmbnt_19.Text = IzlazKomb
        Else Cmbnt_19.Text = ""
        End If

        If sysoutofY.Text >= 20 Then
            Nfaktorijelabin = 1
            Kfaktorijelabin = 1
            NmKfaktorijelabin = 1
            NfactKmbn = sysoutofY.Text
            KfactKmbn = 20
            Call FaktorijeleKomb()
            Cmbnt_20.Text = IzlazKomb
        Else Cmbnt_20.Text = ""
        End If

    End Sub

    Public Sub FaktorijeleKomb()

        For izbrojifact = 1 To NfactKmbn
            Nfaktorijelabin = Nfaktorijelabin * izbrojifact
        Next izbrojifact

        For izbrojifact = 1 To NfactKmbn - KfactKmbn
            Kfaktorijelabin = Kfaktorijelabin * izbrojifact
        Next izbrojifact

        For izbrojifact = 1 To KfactKmbn
            NmKfaktorijelabin = NmKfaktorijelabin * izbrojifact
        Next izbrojifact

        IzlazKomb = Nfaktorijelabin / Kfaktorijelabin / NmKfaktorijelabin

    End Sub


    Private Sub Callme()

        Advancedtxt.Visible = False
        LabelMaxba.Visible = False
        LabelInvBnk.Visible = False
        Recomendedsys.Visible = False
        recomendedsys2.Visible = False
        RecomendedU.Visible = False
        recomendedu2.Visible = False
        rcmdsys.Visible = False
        rcmdinv.Visible = False
        graf1bad.Visible = False
        graf1avrg.Visible = False
        graf1extrem.Visible = False
        graf2bad.Visible = False
        graf2avrg.Visible = False
        graf2extrem.Visible = False
        showy.Visible = False
        TmBnk1.Visible = False
        TMaxBnk1.Visible = False

        MaxBa1.Visible = False
        MaxBa2.Visible = False
        MaxBa3.Visible = False
        MaxBa4.Visible = False
        MaxBa5.Visible = False
        MaxBa6.Visible = False
        MaxBa7.Visible = False
        MaxBa8.Visible = False
        MaxBa9.Visible = False
        MaxBa10.Visible = False
        MaxBa11.Visible = False
        MaxBa12.Visible = False
        MaxBa13.Visible = False
        MaxBa14.Visible = False
        MaxBa15.Visible = False
        MaxBa16.Visible = False
        MaxBa17.Visible = False
        MaxBa18.Visible = False
        MaxBa19.Visible = False
        MaxBa20.Visible = False
        BestUlog1.Visible = False
        BestUlog2.Visible = False
        BestUlog3.Visible = False
        BestUlog4.Visible = False
        BestUlog5.Visible = False
        BestUlog6.Visible = False
        BestUlog7.Visible = False
        BestUlog8.Visible = False
        BestUlog9.Visible = False
        BestUlog10.Visible = False
        BestUlog11.Visible = False
        BestUlog12.Visible = False
        BestUlog13.Visible = False
        BestUlog14.Visible = False
        BestUlog15.Visible = False
        BestUlog16.Visible = False
        BestUlog17.Visible = False
        BestUlog18.Visible = False
        BestUlog19.Visible = False
        BestUlog20.Visible = False


        AdvancedBtn.Visible = True
        If sysoutofY.Text = ("") Then sysoutofY.Text = ("00")
        LabelY.Text = sysoutofY.Text
        a = 1
        c = sysoutofY.Text
        Dim Yfact As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        Yfact = Format(a, "Fixed")

        r1kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r1kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r2kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r3kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r4kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r5kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r6kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r7kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r8kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r9kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r10kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r11kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r12kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r13kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r14kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r15kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r16kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r17kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r18kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r19kr20.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr1.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr2.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr3.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr4.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr5.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr6.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr7.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr8.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr9.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr10.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr11.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr12.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr13.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr14.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr15.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr16.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr17.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr18.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr19.ForeColor = Drawing.Color.DarkSlateBlue
        r20kr20.ForeColor = Drawing.Color.DarkSlateBlue
ch0:
        a = 1
        c = pog0.Text
        Dim BP0 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP0 = Format(a, "Fixed")
ch1:
        a = 1
        c = pog1.Text
        Dim BP1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP1 = Format(a, "Fixed")
ch2:
        a = 1
        c = pog2.Text
        Dim BP2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP2 = Format(a, "Fixed")
ch3:
        a = 1
        c = pog3.Text
        Dim BP3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP3 = Format(a, "Fixed")
ch4:
        a = 1
        c = pog4.Text
        Dim BP4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP4 = Format(a, "Fixed")
ch5:
        a = 1
        c = pog5.Text
        Dim BP5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP5 = Format(a, "Fixed")
ch6:
        a = 1
        c = pog6.Text
        Dim BP6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP6 = Format(a, "Fixed")
ch7:
        a = 1
        c = pog7.Text
        Dim BP7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP7 = Format(a, "Fixed")
ch8:
        a = 1
        c = pog8.Text
        Dim BP8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP8 = Format(a, "Fixed")
ch9:
        a = 1
        c = pog9.Text
        Dim BP9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP9 = Format(a, "Fixed")
ch10:
        a = 1
        c = pog10.Text
        Dim BP10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP10 = Format(a, "Fixed")
ch11:
        a = 1
        c = pog11.Text
        Dim BP11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP11 = Format(a, "Fixed")
ch12:
        a = 1
        c = pog12.Text
        Dim BP12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP12 = Format(a, "Fixed")
ch13:
        a = 1
        c = pog13.Text
        Dim BP13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP13 = Format(a, "Fixed")
ch14:
        a = 1
        c = pog14.Text
        Dim BP14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP14 = Format(a, "Fixed")
ch15:
        a = 1
        c = pog15.Text
        Dim BP15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP15 = Format(a, "Fixed")
ch16:
        a = 1
        c = pog16.Text
        Dim BP16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP16 = Format(a, "Fixed")
ch17:
        a = 1
        c = pog17.Text
        Dim BP17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP17 = Format(a, "Fixed")
ch18:
        a = 1
        c = pog18.Text
        Dim BP18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP18 = Format(a, "Fixed")
ch19:
        a = 1
        c = pog19.Text
        Dim BP19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP19 = Format(a, "Fixed")
ch20:
        a = 1
        c = pog20.Text
        Dim BP20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        BP20 = Format(a, "Fixed")


ybp0:
        a = 1
        c = sysoutofY.Text - pog0.Text
        Dim ybp0 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp0 = Format(a, "Fixed")
ybp1:
        a = 1
        c = sysoutofY.Text - pog1.Text
        Dim ybp1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp1 = Format(a, "Fixed")
ybp2:
        a = 1
        c = sysoutofY.Text - pog2.Text
        Dim ybp2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp2 = Format(a, "Fixed")
ybp3:
        a = 1
        c = sysoutofY.Text - pog3.Text
        Dim ybp3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp3 = Format(a, "Fixed")
ybp4:
        a = 1
        c = sysoutofY.Text - pog4.Text
        Dim ybp4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp4 = Format(a, "Fixed")
ybp5:
        a = 1
        c = sysoutofY.Text - pog5.Text
        Dim ybp5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp5 = Format(a, "Fixed")
ybp6:
        a = 1
        c = sysoutofY.Text - pog6.Text
        Dim ybp6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp6 = Format(a, "Fixed")
ybp7:
        a = 1
        c = sysoutofY.Text - pog7.Text
        Dim ybp7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp7 = Format(a, "Fixed")
ybp8:
        a = 1
        c = sysoutofY.Text - pog8.Text
        Dim ybp8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp8 = Format(a, "Fixed")
ybp9:
        a = 1
        c = sysoutofY.Text - pog9.Text
        Dim ybp9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp9 = Format(a, "Fixed")
ybp10:
        a = 1
        c = sysoutofY.Text - pog10.Text
        Dim ybp10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp10 = Format(a, "Fixed")
ybp11:
        a = 1
        c = sysoutofY.Text - pog11.Text
        Dim ybp11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp11 = Format(a, "Fixed")
ybp12:
        a = 1
        c = sysoutofY.Text - pog12.Text
        Dim ybp12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp12 = Format(a, "Fixed")
ybp13:
        a = 1
        c = sysoutofY.Text - pog13.Text
        Dim ybp13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp13 = Format(a, "Fixed")
ybp14:
        a = 1
        c = sysoutofY.Text - pog14.Text
        Dim ybp14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp14 = Format(a, "Fixed")
ybp15:
        a = 1
        c = sysoutofY.Text - pog15.Text
        Dim ybp15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp15 = Format(a, "Fixed")
ybp16:
        a = 1
        c = sysoutofY.Text - pog16.Text
        Dim ybp16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp16 = Format(a, "Fixed")
ybp17:
        a = 1
        c = sysoutofY.Text - pog17.Text
        Dim ybp17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp17 = Format(a, "Fixed")
ybp18:
        a = 1
        c = sysoutofY.Text - pog18.Text
        Dim ybp18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp18 = Format(a, "Fixed")
ybp19:
        a = 1
        c = sysoutofY.Text - pog19.Text
        Dim ybp19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp19 = Format(a, "Fixed")
ybp20:
        a = 1
        c = sysoutofY.Text - pog20.Text
        Dim ybp20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ybp20 = Format(a, "Fixed")


ymx1:
        a = 1
        c = sysoutofY.Text - x1.Text
        Dim ymx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx1 = Format(a, "Fixed")
ymx2:
        a = 1
        c = sysoutofY.Text - x2.Text
        Dim ymx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx2 = Format(a, "Fixed")
ymx3:
        a = 1
        c = sysoutofY.Text - x3.Text
        Dim ymx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx3 = Format(a, "Fixed")
ymx4:
        a = 1
        c = sysoutofY.Text - x4.Text
        Dim ymx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx4 = Format(a, "Fixed")
ymx5:
        a = 1
        c = sysoutofY.Text - x5.Text
        Dim ymx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx5 = Format(a, "Fixed")
ymx6:
        a = 1
        c = sysoutofY.Text - x6.Text
        Dim ymx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx6 = Format(a, "Fixed")
ymx7:
        a = 1
        c = sysoutofY.Text - x7.Text
        Dim ymx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx7 = Format(a, "Fixed")
ymx8:
        a = 1
        c = sysoutofY.Text - x8.Text
        Dim ymx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx8 = Format(a, "Fixed")
ymx9:
        a = 1
        c = sysoutofY.Text - x9.Text
        Dim ymx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx9 = Format(a, "Fixed")
ymx10:
        a = 1
        c = sysoutofY.Text - x10.Text
        Dim ymx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx10 = Format(a, "Fixed")
ymx11:
        a = 1
        c = sysoutofY.Text - x11.Text
        Dim ymx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx11 = Format(a, "Fixed")
ymx12:
        a = 1
        c = sysoutofY.Text - x12.Text
        Dim ymx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx12 = Format(a, "Fixed")
ymx13:
        a = 1
        c = sysoutofY.Text - x13.Text
        Dim ymx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx13 = Format(a, "Fixed")
ymx14:
        a = 1
        c = sysoutofY.Text - x14.Text
        Dim ymx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx14 = Format(a, "Fixed")
ymx15:
        a = 1
        c = sysoutofY.Text - x15.Text
        Dim ymx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx15 = Format(a, "Fixed")
ymx16:
        a = 1
        c = sysoutofY.Text - x16.Text
        Dim ymx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx16 = Format(a, "Fixed")
ymx17:
        a = 1
        c = sysoutofY.Text - x17.Text
        Dim ymx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx17 = Format(a, "Fixed")
ymx18:
        a = 1
        c = sysoutofY.Text - x18.Text
        Dim ymx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx18 = Format(a, "Fixed")
ymx19:
        a = 1
        c = sysoutofY.Text - x19.Text
        Dim ymx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx19 = Format(a, "Fixed")
ymx20:
        a = 1
        c = sysoutofY.Text - x20.Text
        Dim ymx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        ymx20 = Format(a, "Fixed")


BP0mx1:
        a = 1
        c = pog0.Text - x1.Text
        Dim bp0mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx1 = Format(a, "Fixed")
BP0mx2:
        a = 1
        c = pog0.Text - x2.Text
        Dim bp0mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx2 = Format(a, "Fixed")
BP0mx3:
        a = 1
        c = pog0.Text - x3.Text
        Dim bp0mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx3 = Format(a, "Fixed")
BP0mx4:
        a = 1
        c = pog0.Text - x4.Text
        Dim bp0mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx4 = Format(a, "Fixed")
BP0mx5:
        a = 1
        c = pog0.Text - x5.Text
        Dim bp0mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx5 = Format(a, "Fixed")
BP0mx6:
        a = 1
        c = pog0.Text - x6.Text
        Dim bp0mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx6 = Format(a, "Fixed")
BP0mx7:
        a = 1
        c = pog0.Text - x7.Text
        Dim bp0mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx7 = Format(a, "Fixed")
BP0mx8:
        a = 1
        c = pog0.Text - x8.Text
        Dim bp0mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx8 = Format(a, "Fixed")
BP0mx9:
        a = 1
        c = pog0.Text - x9.Text
        Dim bp0mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx9 = Format(a, "Fixed")
BP0mx10:
        a = 1
        c = pog0.Text - x10.Text
        Dim bp0mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx10 = Format(a, "Fixed")
BP0mx11:
        a = 1
        c = pog0.Text - x11.Text
        Dim bp0mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx11 = Format(a, "Fixed")
BP0mx12:
        a = 1
        c = pog0.Text - x12.Text
        Dim bp0mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx12 = Format(a, "Fixed")
BP0mx13:
        a = 1
        c = pog0.Text - x13.Text
        Dim bp0mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx13 = Format(a, "Fixed")
BP0mx14:
        a = 1
        c = pog0.Text - x14.Text
        Dim bp0mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx14 = Format(a, "Fixed")
BP0mx15:
        a = 1
        c = pog0.Text - x15.Text
        Dim bp0mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx15 = Format(a, "Fixed")
BP0mx16:
        a = 1
        c = pog0.Text - x16.Text
        Dim bp0mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx16 = Format(a, "Fixed")
BP0mx17:
        a = 1
        c = pog0.Text - x17.Text
        Dim bp0mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx17 = Format(a, "Fixed")
BP0mx18:
        a = 1
        c = pog0.Text - x18.Text
        Dim bp0mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx18 = Format(a, "Fixed")
BP0mx19:
        a = 1
        c = pog0.Text - x19.Text
        Dim bp0mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx19 = Format(a, "Fixed")
BP0mx20:
        a = 1
        c = pog0.Text - x20.Text
        Dim bp0mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp0mx20 = Format(a, "Fixed")
BP1mx1:
        a = 1
        c = pog1.Text - x1.Text
        Dim bp1mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx1 = Format(a, "Fixed")
BP1mx2:
        a = 1
        c = pog1.Text - x2.Text
        Dim bp1mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx2 = Format(a, "Fixed")
BP1mx3:
        a = 1
        c = pog1.Text - x3.Text
        Dim bp1mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx3 = Format(a, "Fixed")
BP1mx4:
        a = 1
        c = pog1.Text - x4.Text
        Dim bp1mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx4 = Format(a, "Fixed")
BP1mx5:
        a = 1
        c = pog1.Text - x5.Text
        Dim bp1mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx5 = Format(a, "Fixed")
BP1mx6:
        a = 1
        c = pog1.Text - x6.Text
        Dim bp1mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx6 = Format(a, "Fixed")
BP1mx7:
        a = 1
        c = pog1.Text - x7.Text
        Dim bp1mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx7 = Format(a, "Fixed")
BP1mx8:
        a = 1
        c = pog1.Text - x8.Text
        Dim bp1mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx8 = Format(a, "Fixed")
BP1mx9:
        a = 1
        c = pog1.Text - x9.Text
        Dim bp1mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx9 = Format(a, "Fixed")
BP1mx10:
        a = 1
        c = pog1.Text - x10.Text
        Dim bp1mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx10 = Format(a, "Fixed")
BP1mx11:
        a = 1
        c = pog1.Text - x11.Text
        Dim bp1mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx11 = Format(a, "Fixed")
BP1mx12:
        a = 1
        c = pog1.Text - x12.Text
        Dim bp1mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx12 = Format(a, "Fixed")
BP1mx13:
        a = 1
        c = pog1.Text - x13.Text
        Dim bp1mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx13 = Format(a, "Fixed")
BP1mx14:
        a = 1
        c = pog1.Text - x14.Text
        Dim bp1mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx14 = Format(a, "Fixed")
BP1mx15:
        a = 1
        c = pog1.Text - x15.Text
        Dim bp1mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx15 = Format(a, "Fixed")
BP1mx16:
        a = 1
        c = pog1.Text - x16.Text
        Dim bp1mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx16 = Format(a, "Fixed")
BP1mx17:
        a = 1
        c = pog1.Text - x17.Text
        Dim bp1mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx17 = Format(a, "Fixed")
BP1mx18:
        a = 1
        c = pog1.Text - x18.Text
        Dim bp1mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx18 = Format(a, "Fixed")
BP1mx19:
        a = 1
        c = pog1.Text - x19.Text
        Dim bp1mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx19 = Format(a, "Fixed")
BP1mx20:
        a = 1
        c = pog1.Text - x20.Text
        Dim bp1mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp1mx20 = Format(a, "Fixed")
BP2mx1:
        a = 1
        c = pog2.Text - x1.Text
        Dim bp2mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx1 = Format(a, "Fixed")
BP2mx2:
        a = 1
        c = pog2.Text - x2.Text
        Dim bp2mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx2 = Format(a, "Fixed")
BP2mx3:
        a = 1
        c = pog1.Text - x3.Text
        Dim bp2mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx3 = Format(a, "Fixed")
BP2mx4:
        a = 1
        c = pog2.Text - x4.Text
        Dim bp2mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx4 = Format(a, "Fixed")
BP2mx5:
        a = 1
        c = pog2.Text - x5.Text
        Dim bp2mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx5 = Format(a, "Fixed")
BP2mx6:
        a = 1
        c = pog2.Text - x6.Text
        Dim bp2mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx6 = Format(a, "Fixed")
BP2mx7:
        a = 1
        c = pog2.Text - x7.Text
        Dim bp2mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx7 = Format(a, "Fixed")
BP2mx8:
        a = 1
        c = pog2.Text - x8.Text
        Dim bp2mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx8 = Format(a, "Fixed")
BP2mx9:
        a = 1
        c = pog2.Text - x9.Text
        Dim bp2mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx9 = Format(a, "Fixed")
BP2mx10:
        a = 1
        c = pog2.Text - x10.Text
        Dim bp2mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx10 = Format(a, "Fixed")
BP2mx11:
        a = 1
        c = pog2.Text - x11.Text
        Dim bp2mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx11 = Format(a, "Fixed")
BP2mx12:
        a = 1
        c = pog2.Text - x12.Text
        Dim bp2mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx12 = Format(a, "Fixed")
BP2mx13:
        a = 1
        c = pog2.Text - x13.Text
        Dim bp2mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx13 = Format(a, "Fixed")
BP2mx14:
        a = 1
        c = pog2.Text - x14.Text
        Dim bp2mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx14 = Format(a, "Fixed")
BP2mx15:
        a = 1
        c = pog2.Text - x15.Text
        Dim bp2mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx15 = Format(a, "Fixed")
BP2mx16:
        a = 1
        c = pog2.Text - x16.Text
        Dim bp2mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx16 = Format(a, "Fixed")
BP2mx17:
        a = 1
        c = pog2.Text - x17.Text
        Dim bp2mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx17 = Format(a, "Fixed")
BP2mx18:
        a = 1
        c = pog2.Text - x18.Text
        Dim bp2mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx18 = Format(a, "Fixed")
BP2mx19:
        a = 1
        c = pog2.Text - x19.Text
        Dim bp2mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx19 = Format(a, "Fixed")
BP2mx20:
        a = 1
        c = pog2.Text - x20.Text
        Dim bp2mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp2mx20 = Format(a, "Fixed")
BP3mx1:
        a = 1
        c = pog3.Text - x1.Text
        Dim bp3mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx1 = Format(a, "Fixed")
BP3mx2:
        a = 1
        c = pog3.Text - x2.Text
        Dim bp3mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx2 = Format(a, "Fixed")
BP3mx3:
        a = 1
        c = pog3.Text - x3.Text
        Dim bp3mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx3 = Format(a, "Fixed")
BP3mx4:
        a = 1
        c = pog3.Text - x4.Text
        Dim bp3mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx4 = Format(a, "Fixed")
BP3mx5:
        a = 1
        c = pog3.Text - x5.Text
        Dim bp3mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx5 = Format(a, "Fixed")
BP3mx6:
        a = 1
        c = pog3.Text - x6.Text
        Dim bp3mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx6 = Format(a, "Fixed")
BP3mx7:
        a = 1
        c = pog3.Text - x7.Text
        Dim bp3mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx7 = Format(a, "Fixed")
BP3mx8:
        a = 1
        c = pog3.Text - x8.Text
        Dim bp3mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx8 = Format(a, "Fixed")
BP3mx9:
        a = 1
        c = pog3.Text - x9.Text
        Dim bp3mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx9 = Format(a, "Fixed")
BP3mx10:
        a = 1
        c = pog3.Text - x10.Text
        Dim bp3mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx10 = Format(a, "Fixed")
BP3mx11:
        a = 1
        c = pog3.Text - x11.Text
        Dim bp3mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx11 = Format(a, "Fixed")
BP3mx12:
        a = 1
        c = pog3.Text - x12.Text
        Dim bp3mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx12 = Format(a, "Fixed")
BP3mx13:
        a = 1
        c = pog3.Text - x13.Text
        Dim bp3mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx13 = Format(a, "Fixed")
BP3mx14:
        a = 1
        c = pog3.Text - x14.Text
        Dim bp3mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx14 = Format(a, "Fixed")
BP3mx15:
        a = 1
        c = pog3.Text - x15.Text
        Dim bp3mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx15 = Format(a, "Fixed")
BP3mx16:
        a = 1
        c = pog3.Text - x16.Text
        Dim bp3mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx16 = Format(a, "Fixed")
BP3mx17:
        a = 1
        c = pog3.Text - x17.Text
        Dim bp3mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx17 = Format(a, "Fixed")
BP3mx18:
        a = 1
        c = pog3.Text - x18.Text
        Dim bp3mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx18 = Format(a, "Fixed")
BP3mx19:
        a = 1
        c = pog3.Text - x19.Text
        Dim bp3mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx19 = Format(a, "Fixed")
BP3mx20:
        a = 1
        c = pog3.Text - x20.Text
        Dim bp3mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp3mx20 = Format(a, "Fixed")
BP4mx1:
        a = 1
        c = pog4.Text - x1.Text
        Dim bp4mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx1 = Format(a, "Fixed")
BP4mx2:
        a = 1
        c = pog4.Text - x2.Text
        Dim bp4mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx2 = Format(a, "Fixed")
BP4mx3:
        a = 1
        c = pog4.Text - x3.Text
        Dim bp4mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx3 = Format(a, "Fixed")
BP4mx4:
        a = 1
        c = pog4.Text - x4.Text
        Dim bp4mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx4 = Format(a, "Fixed")
BP4mx5:
        a = 1
        c = pog4.Text - x5.Text
        Dim bp4mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx5 = Format(a, "Fixed")
BP4mx6:
        a = 1
        c = pog4.Text - x6.Text
        Dim bp4mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx6 = Format(a, "Fixed")
BP4mx7:
        a = 1
        c = pog4.Text - x7.Text
        Dim bp4mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx7 = Format(a, "Fixed")
BP4mx8:
        a = 1
        c = pog4.Text - x8.Text
        Dim bp4mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx8 = Format(a, "Fixed")
BP4mx9:
        a = 1
        c = pog4.Text - x9.Text
        Dim bp4mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx9 = Format(a, "Fixed")
BP4mx10:
        a = 1
        c = pog4.Text - x10.Text
        Dim bp4mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx10 = Format(a, "Fixed")
BP4mx11:
        a = 1
        c = pog4.Text - x11.Text
        Dim bp4mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx11 = Format(a, "Fixed")
BP4mx12:
        a = 1
        c = pog4.Text - x12.Text
        Dim bp4mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx12 = Format(a, "Fixed")
BP4mx13:
        a = 1
        c = pog4.Text - x13.Text
        Dim bp4mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx13 = Format(a, "Fixed")
BP4mx14:
        a = 1
        c = pog4.Text - x14.Text
        Dim bp4mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx14 = Format(a, "Fixed")
BP4mx15:
        a = 1
        c = pog4.Text - x15.Text
        Dim bp4mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx15 = Format(a, "Fixed")
BP4mx16:
        a = 1
        c = pog4.Text - x16.Text
        Dim bp4mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx16 = Format(a, "Fixed")
BP4mx17:
        a = 1
        c = pog4.Text - x17.Text
        Dim bp4mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx17 = Format(a, "Fixed")
BP4mx18:
        a = 1
        c = pog4.Text - x18.Text
        Dim bp4mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx18 = Format(a, "Fixed")
BP4mx19:
        a = 1
        c = pog4.Text - x19.Text
        Dim bp4mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx19 = Format(a, "Fixed")
BP4mx20:
        a = 1
        c = pog4.Text - x20.Text
        Dim bp4mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp4mx20 = Format(a, "Fixed")
BP5mx1:
        a = 1
        c = pog5.Text - x1.Text
        Dim bp5mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx1 = Format(a, "Fixed")
BP5mx2:
        a = 1
        c = pog5.Text - x2.Text
        Dim bp5mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx2 = Format(a, "Fixed")
BP5mx3:
        a = 1
        c = pog5.Text - x3.Text
        Dim bp5mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx3 = Format(a, "Fixed")
BP5mx4:
        a = 1
        c = pog5.Text - x4.Text
        Dim bp5mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx4 = Format(a, "Fixed")
BP5mx5:
        a = 1
        c = pog5.Text - x5.Text
        Dim bp5mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx5 = Format(a, "Fixed")
BP5mx6:
        a = 1
        c = pog5.Text - x6.Text
        Dim bp5mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx6 = Format(a, "Fixed")
BP5mx7:
        a = 1
        c = pog5.Text - x7.Text
        Dim bp5mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx7 = Format(a, "Fixed")
BP5mx8:
        a = 1
        c = pog5.Text - x8.Text
        Dim bp5mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx8 = Format(a, "Fixed")
BP5mx9:
        a = 1
        c = pog5.Text - x9.Text
        Dim bp5mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx9 = Format(a, "Fixed")
BP5mx10:
        a = 1
        c = pog5.Text - x10.Text
        Dim bp5mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx10 = Format(a, "Fixed")
BP5mx11:
        a = 1
        c = pog5.Text - x11.Text
        Dim bp5mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx11 = Format(a, "Fixed")
BP5mx12:
        a = 1
        c = pog5.Text - x12.Text
        Dim bp5mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx12 = Format(a, "Fixed")
BP5mx13:
        a = 1
        c = pog5.Text - x13.Text
        Dim bp5mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx13 = Format(a, "Fixed")
BP5mx14:
        a = 1
        c = pog5.Text - x14.Text
        Dim bp5mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx14 = Format(a, "Fixed")
BP5mx15:
        a = 1
        c = pog5.Text - x15.Text
        Dim bp5mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx15 = Format(a, "Fixed")
BP5mx16:
        a = 1
        c = pog5.Text - x16.Text
        Dim bp5mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx16 = Format(a, "Fixed")
BP5mx17:
        a = 1
        c = pog5.Text - x17.Text
        Dim bp5mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx17 = Format(a, "Fixed")
BP5mx18:
        a = 1
        c = pog5.Text - x18.Text
        Dim bp5mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx18 = Format(a, "Fixed")
BP5mx19:
        a = 1
        c = pog5.Text - x19.Text
        Dim bp5mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx19 = Format(a, "Fixed")
BP5mx20:
        a = 1
        c = pog5.Text - x20.Text
        Dim bp5mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp5mx20 = Format(a, "Fixed")
BP6mx1:
        a = 1
        c = pog6.Text - x1.Text
        Dim bp6mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx1 = Format(a, "Fixed")
BP6mx2:
        a = 1
        c = pog6.Text - x2.Text
        Dim bp6mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx2 = Format(a, "Fixed")
BP6mx3:
        a = 1
        c = pog6.Text - x3.Text
        Dim bp6mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx3 = Format(a, "Fixed")
BP6mx4:
        a = 1
        c = pog6.Text - x4.Text
        Dim bp6mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx4 = Format(a, "Fixed")
BP6mx5:
        a = 1
        c = pog6.Text - x5.Text
        Dim bp6mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx5 = Format(a, "Fixed")
BP6mx6:
        a = 1
        c = pog6.Text - x6.Text
        Dim bp6mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx6 = Format(a, "Fixed")
BP6mx7:
        a = 1
        c = pog6.Text - x7.Text
        Dim bp6mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx7 = Format(a, "Fixed")
BP6mx8:
        a = 1
        c = pog6.Text - x8.Text
        Dim bp6mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx8 = Format(a, "Fixed")
BP6mx9:
        a = 1
        c = pog6.Text - x9.Text
        Dim bp6mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx9 = Format(a, "Fixed")
BP6mx10:
        a = 1
        c = pog6.Text - x10.Text
        Dim bp6mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx10 = Format(a, "Fixed")
BP6mx11:
        a = 1
        c = pog6.Text - x11.Text
        Dim bp6mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx11 = Format(a, "Fixed")
BP6mx12:
        a = 1
        c = pog6.Text - x12.Text
        Dim bp6mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx12 = Format(a, "Fixed")
BP6mx13:
        a = 1
        c = pog6.Text - x13.Text
        Dim bp6mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx13 = Format(a, "Fixed")
BP6mx14:
        a = 1
        c = pog6.Text - x14.Text
        Dim bp6mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx14 = Format(a, "Fixed")
BP6mx15:
        a = 1
        c = pog6.Text - x15.Text
        Dim bp6mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx15 = Format(a, "Fixed")
BP6mx16:
        a = 1
        c = pog6.Text - x16.Text
        Dim bp6mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx16 = Format(a, "Fixed")
BP6mx17:
        a = 1
        c = pog6.Text - x17.Text
        Dim bp6mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx17 = Format(a, "Fixed")
BP6mx18:
        a = 1
        c = pog6.Text - x18.Text
        Dim bp6mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx18 = Format(a, "Fixed")
BP6mx19:
        a = 1
        c = pog6.Text - x19.Text
        Dim bp6mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx19 = Format(a, "Fixed")
BP6mx20:
        a = 1
        c = pog6.Text - x20.Text
        Dim bp6mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp6mx20 = Format(a, "Fixed")
BP7mx1:
        a = 1
        c = pog7.Text - x1.Text
        Dim bp7mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx1 = Format(a, "Fixed")
BP7mx2:
        a = 1
        c = pog7.Text - x2.Text
        Dim bp7mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx2 = Format(a, "Fixed")
BP7mx3:
        a = 1
        c = pog7.Text - x3.Text
        Dim bp7mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx3 = Format(a, "Fixed")
BP7mx4:
        a = 1
        c = pog7.Text - x4.Text
        Dim bp7mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx4 = Format(a, "Fixed")
BP7mx5:
        a = 1
        c = pog7.Text - x5.Text
        Dim bp7mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx5 = Format(a, "Fixed")
BP7mx6:
        a = 1
        c = pog7.Text - x6.Text
        Dim bp7mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx6 = Format(a, "Fixed")
BP7mx7:
        a = 1
        c = pog7.Text - x7.Text
        Dim bp7mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx7 = Format(a, "Fixed")
BP7mx8:
        a = 1
        c = pog7.Text - x8.Text
        Dim bp7mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx8 = Format(a, "Fixed")
BP7mx9:
        a = 1
        c = pog7.Text - x9.Text
        Dim bp7mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx9 = Format(a, "Fixed")
BP7mx10:
        a = 1
        c = pog7.Text - x10.Text
        Dim bp7mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx10 = Format(a, "Fixed")
BP7mx11:
        a = 1
        c = pog7.Text - x11.Text
        Dim bp7mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx11 = Format(a, "Fixed")
BP7mx12:
        a = 1
        c = pog7.Text - x12.Text
        Dim bp7mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx12 = Format(a, "Fixed")
BP7mx13:
        a = 1
        c = pog7.Text - x13.Text
        Dim bp7mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx13 = Format(a, "Fixed")
BP7mx14:
        a = 1
        c = pog7.Text - x14.Text
        Dim bp7mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx14 = Format(a, "Fixed")
BP7mx15:
        a = 1
        c = pog7.Text - x15.Text
        Dim bp7mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx15 = Format(a, "Fixed")
BP7mx16:
        a = 1
        c = pog7.Text - x16.Text
        Dim bp7mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx16 = Format(a, "Fixed")
BP7mx17:
        a = 1
        c = pog7.Text - x17.Text
        Dim bp7mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx17 = Format(a, "Fixed")
BP7mx18:
        a = 1
        c = pog7.Text - x18.Text
        Dim bp7mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx18 = Format(a, "Fixed")
BP7mx19:
        a = 1
        c = pog7.Text - x19.Text
        Dim bp7mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx19 = Format(a, "Fixed")
BP7mx20:
        a = 1
        c = pog7.Text - x20.Text
        Dim bp7mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp7mx20 = Format(a, "Fixed")
BP8mx1:
        a = 1
        c = pog8.Text - x1.Text
        Dim bp8mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx1 = Format(a, "Fixed")
BP8mx2:
        a = 1
        c = pog8.Text - x2.Text
        Dim bp8mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx2 = Format(a, "Fixed")
BP8mx3:
        a = 1
        c = pog8.Text - x3.Text
        Dim bp8mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx3 = Format(a, "Fixed")
BP8mx4:
        a = 1
        c = pog8.Text - x4.Text
        Dim bp8mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx4 = Format(a, "Fixed")
BP8mx5:
        a = 1
        c = pog8.Text - x5.Text
        Dim bp8mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx5 = Format(a, "Fixed")
BP8mx6:
        a = 1
        c = pog8.Text - x6.Text
        Dim bp8mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx6 = Format(a, "Fixed")
BP8mx7:
        a = 1
        c = pog8.Text - x7.Text
        Dim bp8mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx7 = Format(a, "Fixed")
BP8mx8:
        a = 1
        c = pog8.Text - x8.Text
        Dim bp8mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx8 = Format(a, "Fixed")
BP8mx9:
        a = 1
        c = pog8.Text - x9.Text
        Dim bp8mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx9 = Format(a, "Fixed")
BP8mx10:
        a = 1
        c = pog8.Text - x10.Text
        Dim bp8mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx10 = Format(a, "Fixed")
BP8mx11:
        a = 1
        c = pog8.Text - x11.Text
        Dim bp8mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx11 = Format(a, "Fixed")
BP8mx12:
        a = 1
        c = pog8.Text - x12.Text
        Dim bp8mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx12 = Format(a, "Fixed")
BP8mx13:
        a = 1
        c = pog8.Text - x13.Text
        Dim bp8mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx13 = Format(a, "Fixed")
BP8mx14:
        a = 1
        c = pog8.Text - x14.Text
        Dim bp8mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx14 = Format(a, "Fixed")
BP8mx15:
        a = 1
        c = pog8.Text - x15.Text
        Dim bp8mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx15 = Format(a, "Fixed")
BP8mx16:
        a = 1
        c = pog8.Text - x16.Text
        Dim bp8mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx16 = Format(a, "Fixed")
BP8mx17:
        a = 1
        c = pog8.Text - x17.Text
        Dim bp8mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx17 = Format(a, "Fixed")
BP8mx18:
        a = 1
        c = pog8.Text - x18.Text
        Dim bp8mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx18 = Format(a, "Fixed")
BP8mx19:
        a = 1
        c = pog8.Text - x19.Text
        Dim bp8mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx19 = Format(a, "Fixed")
BP8mx20:
        a = 1
        c = pog8.Text - x20.Text
        Dim bp8mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp8mx20 = Format(a, "Fixed")
BP9mx1:
        a = 1
        c = pog9.Text - x1.Text
        Dim bp9mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx1 = Format(a, "Fixed")
BP9mx2:
        a = 1
        c = pog9.Text - x2.Text
        Dim bp9mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx2 = Format(a, "Fixed")
BP9mx3:
        a = 1
        c = pog9.Text - x3.Text
        Dim bp9mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx3 = Format(a, "Fixed")
BP9mx4:
        a = 1
        c = pog9.Text - x4.Text
        Dim bp9mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx4 = Format(a, "Fixed")
BP9mx5:
        a = 1
        c = pog9.Text - x5.Text
        Dim bp9mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx5 = Format(a, "Fixed")
BP9mx6:
        a = 1
        c = pog9.Text - x6.Text
        Dim bp9mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx6 = Format(a, "Fixed")
BP9mx7:
        a = 1
        c = pog9.Text - x7.Text
        Dim bp9mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx7 = Format(a, "Fixed")
BP9mx8:
        a = 1
        c = pog9.Text - x8.Text
        Dim bp9mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx8 = Format(a, "Fixed")
BP9mx9:
        a = 1
        c = pog9.Text - x9.Text
        Dim bp9mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx9 = Format(a, "Fixed")
BP9mx10:
        a = 1
        c = pog9.Text - x10.Text
        Dim bp9mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx10 = Format(a, "Fixed")
BP9mx11:
        a = 1
        c = pog9.Text - x11.Text
        Dim bp9mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx11 = Format(a, "Fixed")
BP9mx12:
        a = 1
        c = pog9.Text - x12.Text
        Dim bp9mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx12 = Format(a, "Fixed")
BP9mx13:
        a = 1
        c = pog9.Text - x13.Text
        Dim bp9mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx13 = Format(a, "Fixed")
BP9mx14:
        a = 1
        c = pog9.Text - x14.Text
        Dim bp9mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx14 = Format(a, "Fixed")
BP9mx15:
        a = 1
        c = pog9.Text - x15.Text
        Dim bp9mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx15 = Format(a, "Fixed")
BP9mx16:
        a = 1
        c = pog9.Text - x16.Text
        Dim bp9mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx16 = Format(a, "Fixed")
BP9mx17:
        a = 1
        c = pog9.Text - x17.Text
        Dim bp9mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx17 = Format(a, "Fixed")
BP9mx18:
        a = 1
        c = pog9.Text - x18.Text
        Dim bp9mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx18 = Format(a, "Fixed")
BP9mx19:
        a = 1
        c = pog9.Text - x19.Text
        Dim bp9mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx19 = Format(a, "Fixed")
BP9mx20:
        a = 1
        c = pog9.Text - x20.Text
        Dim bp9mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp9mx20 = Format(a, "Fixed")
BP10mx1:
        a = 1
        c = pog10.Text - x1.Text
        Dim bp10mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx1 = Format(a, "Fixed")
BP10mx2:
        a = 1
        c = pog10.Text - x2.Text
        Dim bp10mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx2 = Format(a, "Fixed")
BP10mx3:
        a = 1
        c = pog10.Text - x3.Text
        Dim bp10mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx3 = Format(a, "Fixed")
BP10mx4:
        a = 1
        c = pog10.Text - x4.Text
        Dim bp10mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx4 = Format(a, "Fixed")
BP10mx5:
        a = 1
        c = pog10.Text - x5.Text
        Dim bp10mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx5 = Format(a, "Fixed")
BP10mx6:
        a = 1
        c = pog10.Text - x6.Text
        Dim bp10mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx6 = Format(a, "Fixed")
BP10mx7:
        a = 1
        c = pog10.Text - x7.Text
        Dim bp10mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx7 = Format(a, "Fixed")
BP10mx8:
        a = 1
        c = pog10.Text - x8.Text
        Dim bp10mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx8 = Format(a, "Fixed")
BP10mx9:
        a = 1
        c = pog10.Text - x9.Text
        Dim bp10mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx9 = Format(a, "Fixed")
BP10mx10:
        a = 1
        c = pog10.Text - x10.Text
        Dim bp10mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx10 = Format(a, "Fixed")
BP10mx11:
        a = 1
        c = pog10.Text - x11.Text
        Dim bp10mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx11 = Format(a, "Fixed")
BP10mx12:
        a = 1
        c = pog10.Text - x12.Text
        Dim bp10mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx12 = Format(a, "Fixed")
BP10mx13:
        a = 1
        c = pog10.Text - x13.Text
        Dim bp10mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx13 = Format(a, "Fixed")
BP10mx14:
        a = 1
        c = pog10.Text - x14.Text
        Dim bp10mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx14 = Format(a, "Fixed")
BP10mx15:
        a = 1
        c = pog10.Text - x15.Text
        Dim bp10mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx15 = Format(a, "Fixed")
BP10mx16:
        a = 1
        c = pog10.Text - x16.Text
        Dim bp10mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx16 = Format(a, "Fixed")
BP10mx17:
        a = 1
        c = pog10.Text - x17.Text
        Dim bp10mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx17 = Format(a, "Fixed")
BP10mx18:
        a = 1
        c = pog10.Text - x18.Text
        Dim bp10mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx18 = Format(a, "Fixed")
BP10mx19:
        a = 1
        c = pog10.Text - x19.Text
        Dim bp10mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx19 = Format(a, "Fixed")
BP10mx20:
        a = 1
        c = pog10.Text - x20.Text
        Dim bp10mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp10mx20 = Format(a, "Fixed")
BP11mx1:
        a = 1
        c = pog11.Text - x1.Text
        Dim bp11mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx1 = Format(a, "Fixed")
BP11mx2:
        a = 1
        c = pog11.Text - x2.Text
        Dim bp11mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx2 = Format(a, "Fixed")
BP11mx3:
        a = 1
        c = pog11.Text - x3.Text
        Dim bp11mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx3 = Format(a, "Fixed")
BP11mx4:
        a = 1
        c = pog11.Text - x4.Text
        Dim bp11mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx4 = Format(a, "Fixed")
BP11mx5:
        a = 1
        c = pog11.Text - x5.Text
        Dim bp11mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx5 = Format(a, "Fixed")
BP11mx6:
        a = 1
        c = pog11.Text - x6.Text
        Dim bp11mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx6 = Format(a, "Fixed")
BP11mx7:
        a = 1
        c = pog11.Text - x7.Text
        Dim bp11mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx7 = Format(a, "Fixed")
BP11mx8:
        a = 1
        c = pog11.Text - x8.Text
        Dim bp11mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx8 = Format(a, "Fixed")
BP11mx9:
        a = 1
        c = pog11.Text - x9.Text
        Dim bp11mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx9 = Format(a, "Fixed")
BP11mx10:
        a = 1
        c = pog11.Text - x10.Text
        Dim bp11mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx10 = Format(a, "Fixed")
BP11mx11:
        a = 1
        c = pog11.Text - x11.Text
        Dim bp11mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx11 = Format(a, "Fixed")
BP11mx12:
        a = 1
        c = pog11.Text - x12.Text
        Dim bp11mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx12 = Format(a, "Fixed")
BP11mx13:
        a = 1
        c = pog11.Text - x13.Text
        Dim bp11mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx13 = Format(a, "Fixed")
BP11mx14:
        a = 1
        c = pog11.Text - x14.Text
        Dim bp11mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx14 = Format(a, "Fixed")
BP11mx15:
        a = 1
        c = pog11.Text - x15.Text
        Dim bp11mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx15 = Format(a, "Fixed")
BP11mx16:
        a = 1
        c = pog11.Text - x16.Text
        Dim bp11mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx16 = Format(a, "Fixed")
BP11mx17:
        a = 1
        c = pog11.Text - x17.Text
        Dim bp11mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx17 = Format(a, "Fixed")
BP11mx18:
        a = 1
        c = pog11.Text - x18.Text
        Dim bp11mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx18 = Format(a, "Fixed")
BP11mx19:
        a = 1
        c = pog11.Text - x19.Text
        Dim bp11mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx19 = Format(a, "Fixed")
BP11mx20:
        a = 1
        c = pog11.Text - x20.Text
        Dim bp11mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp11mx20 = Format(a, "Fixed")
BP12mx1:
        a = 1
        c = pog12.Text - x1.Text
        Dim bp12mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx1 = Format(a, "Fixed")
BP12mx2:
        a = 1
        c = pog12.Text - x2.Text
        Dim bp12mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx2 = Format(a, "Fixed")
BP12mx3:
        a = 1
        c = pog12.Text - x3.Text
        Dim bp12mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx3 = Format(a, "Fixed")
BP12mx4:
        a = 1
        c = pog12.Text - x4.Text
        Dim bp12mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx4 = Format(a, "Fixed")
BP12mx5:
        a = 1
        c = pog12.Text - x5.Text
        Dim bp12mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx5 = Format(a, "Fixed")
BP12mx6:
        a = 1
        c = pog12.Text - x6.Text
        Dim bp12mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx6 = Format(a, "Fixed")
BP12mx7:
        a = 1
        c = pog12.Text - x7.Text
        Dim bp12mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx7 = Format(a, "Fixed")
BP12mx8:
        a = 1
        c = pog12.Text - x8.Text
        Dim bp12mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx8 = Format(a, "Fixed")
BP12mx9:
        a = 1
        c = pog12.Text - x9.Text
        Dim bp12mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx9 = Format(a, "Fixed")
BP12mx10:
        a = 1
        c = pog12.Text - x10.Text
        Dim bp12mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx10 = Format(a, "Fixed")
BP12mx11:
        a = 1
        c = pog12.Text - x11.Text
        Dim bp12mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx11 = Format(a, "Fixed")
BP12mx12:
        a = 1
        c = pog12.Text - x12.Text
        Dim bp12mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx12 = Format(a, "Fixed")
BP12mx13:
        a = 1
        c = pog12.Text - x13.Text
        Dim bp12mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx13 = Format(a, "Fixed")
BP12mx14:
        a = 1
        c = pog12.Text - x14.Text
        Dim bp12mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx14 = Format(a, "Fixed")
BP12mx15:
        a = 1
        c = pog12.Text - x15.Text
        Dim bp12mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx15 = Format(a, "Fixed")
BP12mx16:
        a = 1
        c = pog12.Text - x16.Text
        Dim bp12mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx16 = Format(a, "Fixed")
BP12mx17:
        a = 1
        c = pog12.Text - x17.Text
        Dim bp12mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx17 = Format(a, "Fixed")
BP12mx18:
        a = 1
        c = pog12.Text - x18.Text
        Dim bp12mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx18 = Format(a, "Fixed")
BP12mx19:
        a = 1
        c = pog12.Text - x19.Text
        Dim bp12mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx19 = Format(a, "Fixed")
BP12mx20:
        a = 1
        c = pog12.Text - x20.Text
        Dim bp12mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp12mx20 = Format(a, "Fixed")
BP13mx1:
        a = 1
        c = pog13.Text - x1.Text
        Dim bp13mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx1 = Format(a, "Fixed")
BP13mx2:
        a = 1
        c = pog13.Text - x2.Text
        Dim bp13mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx2 = Format(a, "Fixed")
BP13mx3:
        a = 1
        c = pog13.Text - x3.Text
        Dim bp13mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx3 = Format(a, "Fixed")
BP13mx4:
        a = 1
        c = pog13.Text - x4.Text
        Dim bp13mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx4 = Format(a, "Fixed")
BP13mx5:
        a = 1
        c = pog13.Text - x5.Text
        Dim bp13mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx5 = Format(a, "Fixed")
BP13mx6:
        a = 1
        c = pog13.Text - x6.Text
        Dim bp13mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx6 = Format(a, "Fixed")
BP13mx7:
        a = 1
        c = pog13.Text - x7.Text
        Dim bp13mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx7 = Format(a, "Fixed")
BP13mx8:
        a = 1
        c = pog13.Text - x8.Text
        Dim bp13mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx8 = Format(a, "Fixed")
BP13mx9:
        a = 1
        c = pog13.Text - x9.Text
        Dim bp13mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx9 = Format(a, "Fixed")
BP13mx10:
        a = 1
        c = pog13.Text - x10.Text
        Dim bp13mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx10 = Format(a, "Fixed")
BP13mx11:
        a = 1
        c = pog13.Text - x11.Text
        Dim bp13mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx11 = Format(a, "Fixed")
BP13mx12:
        a = 1
        c = pog13.Text - x12.Text
        Dim bp13mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx12 = Format(a, "Fixed")
BP13mx13:
        a = 1
        c = pog13.Text - x13.Text
        Dim bp13mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx13 = Format(a, "Fixed")
BP13mx14:
        a = 1
        c = pog13.Text - x14.Text
        Dim bp13mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx14 = Format(a, "Fixed")
BP13mx15:
        a = 1
        c = pog13.Text - x15.Text
        Dim bp13mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx15 = Format(a, "Fixed")
BP13mx16:
        a = 1
        c = pog13.Text - x16.Text
        Dim bp13mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx16 = Format(a, "Fixed")
BP13mx17:
        a = 1
        c = pog13.Text - x17.Text
        Dim bp13mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx17 = Format(a, "Fixed")
BP13mx18:
        a = 1
        c = pog13.Text - x18.Text
        Dim bp13mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx18 = Format(a, "Fixed")
BP13mx19:
        a = 1
        c = pog13.Text - x19.Text
        Dim bp13mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx19 = Format(a, "Fixed")
BP13mx20:
        a = 1
        c = pog13.Text - x20.Text
        Dim bp13mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp13mx20 = Format(a, "Fixed")
BP14mx1:
        a = 1
        c = pog14.Text - x1.Text
        Dim bp14mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx1 = Format(a, "Fixed")
BP14mx2:
        a = 1
        c = pog14.Text - x2.Text
        Dim bp14mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx2 = Format(a, "Fixed")
BP14mx3:
        a = 1
        c = pog14.Text - x3.Text
        Dim bp14mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx3 = Format(a, "Fixed")
BP14mx4:
        a = 1
        c = pog14.Text - x4.Text
        Dim bp14mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx4 = Format(a, "Fixed")
BP14mx5:
        a = 1
        c = pog14.Text - x5.Text
        Dim bp14mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx5 = Format(a, "Fixed")
BP14mx6:
        a = 1
        c = pog14.Text - x6.Text
        Dim bp14mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx6 = Format(a, "Fixed")
BP14mx7:
        a = 1
        c = pog14.Text - x7.Text
        Dim bp14mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx7 = Format(a, "Fixed")
BP14mx8:
        a = 1
        c = pog14.Text - x8.Text
        Dim bp14mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx8 = Format(a, "Fixed")
BP14mx9:
        a = 1
        c = pog14.Text - x9.Text
        Dim bp14mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx9 = Format(a, "Fixed")
BP14mx10:
        a = 1
        c = pog14.Text - x10.Text
        Dim bp14mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx10 = Format(a, "Fixed")
BP14mx11:
        a = 1
        c = pog14.Text - x11.Text
        Dim bp14mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx11 = Format(a, "Fixed")
BP14mx12:
        a = 1
        c = pog14.Text - x12.Text
        Dim bp14mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx12 = Format(a, "Fixed")
BP14mx13:
        a = 1
        c = pog14.Text - x13.Text
        Dim bp14mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx13 = Format(a, "Fixed")
BP14mx14:
        a = 1
        c = pog14.Text - x14.Text
        Dim bp14mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx14 = Format(a, "Fixed")
BP14mx15:
        a = 1
        c = pog14.Text - x15.Text
        Dim bp14mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx15 = Format(a, "Fixed")
BP14mx16:
        a = 1
        c = pog14.Text - x16.Text
        Dim bp14mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx16 = Format(a, "Fixed")
BP14mx17:
        a = 1
        c = pog14.Text - x17.Text
        Dim bp14mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx17 = Format(a, "Fixed")
BP14mx18:
        a = 1
        c = pog14.Text - x18.Text
        Dim bp14mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx18 = Format(a, "Fixed")
BP14mx19:
        a = 1
        c = pog14.Text - x19.Text
        Dim bp14mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx19 = Format(a, "Fixed")
BP14mx20:
        a = 1
        c = pog14.Text - x20.Text
        Dim bp14mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp14mx20 = Format(a, "Fixed")
BP15mx1:
        a = 1
        c = pog15.Text - x1.Text
        Dim bp15mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx1 = Format(a, "Fixed")
BP15mx2:
        a = 1
        c = pog15.Text - x2.Text
        Dim bp15mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx2 = Format(a, "Fixed")
BP15mx3:
        a = 1
        c = pog15.Text - x3.Text
        Dim bp15mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx3 = Format(a, "Fixed")
BP15mx4:
        a = 1
        c = pog15.Text - x4.Text
        Dim bp15mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx4 = Format(a, "Fixed")
BP15mx5:
        a = 1
        c = pog15.Text - x5.Text
        Dim bp15mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx5 = Format(a, "Fixed")
BP15mx6:
        a = 1
        c = pog15.Text - x6.Text
        Dim bp15mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx6 = Format(a, "Fixed")
BP15mx7:
        a = 1
        c = pog15.Text - x7.Text
        Dim bp15mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx7 = Format(a, "Fixed")
BP15mx8:
        a = 1
        c = pog15.Text - x8.Text
        Dim bp15mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx8 = Format(a, "Fixed")
BP15mx9:
        a = 1
        c = pog15.Text - x9.Text
        Dim bp15mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx9 = Format(a, "Fixed")
BP15mx10:
        a = 1
        c = pog15.Text - x10.Text
        Dim bp15mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx10 = Format(a, "Fixed")
BP15mx11:
        a = 1
        c = pog15.Text - x11.Text
        Dim bp15mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx11 = Format(a, "Fixed")
BP15mx12:
        a = 1
        c = pog15.Text - x12.Text
        Dim bp15mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx12 = Format(a, "Fixed")
BP15mx13:
        a = 1
        c = pog15.Text - x13.Text
        Dim bp15mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx13 = Format(a, "Fixed")
BP15mx14:
        a = 1
        c = pog15.Text - x14.Text
        Dim bp15mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx14 = Format(a, "Fixed")
BP15mx15:
        a = 1
        c = pog15.Text - x15.Text
        Dim bp15mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx15 = Format(a, "Fixed")
BP15mx16:
        a = 1
        c = pog15.Text - x16.Text
        Dim bp15mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx16 = Format(a, "Fixed")
BP15mx17:
        a = 1
        c = pog15.Text - x17.Text
        Dim bp15mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx17 = Format(a, "Fixed")
BP15mx18:
        a = 1
        c = pog15.Text - x18.Text
        Dim bp15mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx18 = Format(a, "Fixed")
BP15mx19:
        a = 1
        c = pog15.Text - x19.Text
        Dim bp15mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx19 = Format(a, "Fixed")
BP15mx20:
        a = 1
        c = pog15.Text - x20.Text
        Dim bp15mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp15mx20 = Format(a, "Fixed")
BP16mx1:
        a = 1
        c = pog16.Text - x1.Text
        Dim bp16mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx1 = Format(a, "Fixed")
BP16mx2:
        a = 1
        c = pog16.Text - x2.Text
        Dim bp16mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx2 = Format(a, "Fixed")
BP16mx3:
        a = 1
        c = pog16.Text - x3.Text
        Dim bp16mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx3 = Format(a, "Fixed")
BP16mx4:
        a = 1
        c = pog16.Text - x4.Text
        Dim bp16mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx4 = Format(a, "Fixed")
BP16mx5:
        a = 1
        c = pog16.Text - x5.Text
        Dim bp16mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx5 = Format(a, "Fixed")
BP16mx6:
        a = 1
        c = pog16.Text - x6.Text
        Dim bp16mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx6 = Format(a, "Fixed")
BP16mx7:
        a = 1
        c = pog16.Text - x7.Text
        Dim bp16mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx7 = Format(a, "Fixed")
BP16mx8:
        a = 1
        c = pog16.Text - x8.Text
        Dim bp16mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx8 = Format(a, "Fixed")
BP16mx9:
        a = 1
        c = pog16.Text - x9.Text
        Dim bp16mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx9 = Format(a, "Fixed")
BP16mx10:
        a = 1
        c = pog16.Text - x10.Text
        Dim bp16mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx10 = Format(a, "Fixed")
BP16mx11:
        a = 1
        c = pog16.Text - x11.Text
        Dim bp16mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx11 = Format(a, "Fixed")
BP16mx12:
        a = 1
        c = pog16.Text - x12.Text
        Dim bp16mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx12 = Format(a, "Fixed")
BP16mx13:
        a = 1
        c = pog16.Text - x13.Text
        Dim bp16mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx13 = Format(a, "Fixed")
BP16mx14:
        a = 1
        c = pog16.Text - x14.Text
        Dim bp16mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx14 = Format(a, "Fixed")
BP16mx15:
        a = 1
        c = pog16.Text - x15.Text
        Dim bp16mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx15 = Format(a, "Fixed")
BP16mx16:
        a = 1
        c = pog16.Text - x16.Text
        Dim bp16mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx16 = Format(a, "Fixed")
BP16mx17:
        a = 1
        c = pog16.Text - x17.Text
        Dim bp16mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx17 = Format(a, "Fixed")
BP16mx18:
        a = 1
        c = pog16.Text - x18.Text
        Dim bp16mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx18 = Format(a, "Fixed")
BP16mx19:
        a = 1
        c = pog16.Text - x19.Text
        Dim bp16mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx19 = Format(a, "Fixed")
BP16mx20:
        a = 1
        c = pog16.Text - x20.Text
        Dim bp16mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp16mx20 = Format(a, "Fixed")
BP17mx1:
        a = 1
        c = pog17.Text - x1.Text
        Dim bp17mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx1 = Format(a, "Fixed")
BP17mx2:
        a = 1
        c = pog17.Text - x2.Text
        Dim bp17mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx2 = Format(a, "Fixed")
BP17mx3:
        a = 1
        c = pog17.Text - x3.Text
        Dim bp17mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx3 = Format(a, "Fixed")
BP17mx4:
        a = 1
        c = pog17.Text - x4.Text
        Dim bp17mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx4 = Format(a, "Fixed")
BP17mx5:
        a = 1
        c = pog17.Text - x5.Text
        Dim bp17mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx5 = Format(a, "Fixed")
BP17mx6:
        a = 1
        c = pog17.Text - x6.Text
        Dim bp17mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx6 = Format(a, "Fixed")
BP17mx7:
        a = 1
        c = pog17.Text - x7.Text
        Dim bp17mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx7 = Format(a, "Fixed")
BP17mx8:
        a = 1
        c = pog17.Text - x8.Text
        Dim bp17mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx8 = Format(a, "Fixed")
BP17mx9:
        a = 1
        c = pog17.Text - x9.Text
        Dim bp17mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx9 = Format(a, "Fixed")
BP17mx10:
        a = 1
        c = pog17.Text - x10.Text
        Dim bp17mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx10 = Format(a, "Fixed")
BP17mx11:
        a = 1
        c = pog17.Text - x11.Text
        Dim bp17mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx11 = Format(a, "Fixed")
BP17mx12:
        a = 1
        c = pog17.Text - x12.Text
        Dim bp17mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx12 = Format(a, "Fixed")
BP17mx13:
        a = 1
        c = pog17.Text - x13.Text
        Dim bp17mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx13 = Format(a, "Fixed")
BP17mx14:
        a = 1
        c = pog17.Text - x14.Text
        Dim bp17mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx14 = Format(a, "Fixed")
BP17mx15:
        a = 1
        c = pog17.Text - x15.Text
        Dim bp17mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx15 = Format(a, "Fixed")
BP17mx16:
        a = 1
        c = pog17.Text - x16.Text
        Dim bp17mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx16 = Format(a, "Fixed")
BP17mx17:
        a = 1
        c = pog17.Text - x17.Text
        Dim bp17mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx17 = Format(a, "Fixed")
BP17mx18:
        a = 1
        c = pog17.Text - x18.Text
        Dim bp17mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx18 = Format(a, "Fixed")
BP17mx19:
        a = 1
        c = pog17.Text - x19.Text
        Dim bp17mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx19 = Format(a, "Fixed")
BP17mx20:
        a = 1
        c = pog17.Text - x20.Text
        Dim bp17mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp17mx20 = Format(a, "Fixed")
BP18mx1:
        a = 1
        c = pog18.Text - x1.Text
        Dim bp18mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx1 = Format(a, "Fixed")
BP18mx2:
        a = 1
        c = pog18.Text - x2.Text
        Dim bp18mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx2 = Format(a, "Fixed")
BP18mx3:
        a = 1
        c = pog18.Text - x3.Text
        Dim bp18mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx3 = Format(a, "Fixed")
BP18mx4:
        a = 1
        c = pog18.Text - x4.Text
        Dim bp18mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx4 = Format(a, "Fixed")
BP18mx5:
        a = 1
        c = pog18.Text - x5.Text
        Dim bp18mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx5 = Format(a, "Fixed")
BP18mx6:
        a = 1
        c = pog18.Text - x6.Text
        Dim bp18mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx6 = Format(a, "Fixed")
BP18mx7:
        a = 1
        c = pog18.Text - x7.Text
        Dim bp18mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx7 = Format(a, "Fixed")
BP18mx8:
        a = 1
        c = pog18.Text - x8.Text
        Dim bp18mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx8 = Format(a, "Fixed")
BP18mx9:
        a = 1
        c = pog18.Text - x9.Text
        Dim bp18mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx9 = Format(a, "Fixed")
BP18mx10:
        a = 1
        c = pog18.Text - x10.Text
        Dim bp18mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx10 = Format(a, "Fixed")
BP18mx11:
        a = 1
        c = pog18.Text - x11.Text
        Dim bp18mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx11 = Format(a, "Fixed")
BP18mx12:
        a = 1
        c = pog18.Text - x12.Text
        Dim bp18mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx12 = Format(a, "Fixed")
BP18mx13:
        a = 1
        c = pog18.Text - x13.Text
        Dim bp18mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx13 = Format(a, "Fixed")
BP18mx14:
        a = 1
        c = pog18.Text - x14.Text
        Dim bp18mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx14 = Format(a, "Fixed")
BP18mx15:
        a = 1
        c = pog18.Text - x15.Text
        Dim bp18mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx15 = Format(a, "Fixed")
BP18mx16:
        a = 1
        c = pog18.Text - x16.Text
        Dim bp18mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx16 = Format(a, "Fixed")
BP18mx17:
        a = 1
        c = pog18.Text - x17.Text
        Dim bp18mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx17 = Format(a, "Fixed")
BP18mx18:
        a = 1
        c = pog18.Text - x18.Text
        Dim bp18mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx18 = Format(a, "Fixed")
BP18mx19:
        a = 1
        c = pog18.Text - x19.Text
        Dim bp18mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx19 = Format(a, "Fixed")
BP18mx20:
        a = 1
        c = pog18.Text - x20.Text
        Dim bp18mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp18mx20 = Format(a, "Fixed")
BP19mx1:
        a = 1
        c = pog19.Text - x1.Text
        Dim bp19mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx1 = Format(a, "Fixed")
BP19mx2:
        a = 1
        c = pog19.Text - x2.Text
        Dim bp19mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx2 = Format(a, "Fixed")
BP19mx3:
        a = 1
        c = pog19.Text - x3.Text
        Dim bp19mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx3 = Format(a, "Fixed")
BP19mx4:
        a = 1
        c = pog19.Text - x4.Text
        Dim bp19mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx4 = Format(a, "Fixed")
BP19mx5:
        a = 1
        c = pog19.Text - x5.Text
        Dim bp19mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx5 = Format(a, "Fixed")
BP19mx6:
        a = 1
        c = pog19.Text - x6.Text
        Dim bp19mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx6 = Format(a, "Fixed")
BP19mx7:
        a = 1
        c = pog19.Text - x7.Text
        Dim bp19mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx7 = Format(a, "Fixed")
BP19mx8:
        a = 1
        c = pog19.Text - x8.Text
        Dim bp19mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx8 = Format(a, "Fixed")
BP19mx9:
        a = 1
        c = pog19.Text - x9.Text
        Dim bp19mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx9 = Format(a, "Fixed")
BP19mx10:
        a = 1
        c = pog19.Text - x10.Text
        Dim bp19mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx10 = Format(a, "Fixed")
BP19mx11:
        a = 1
        c = pog19.Text - x11.Text
        Dim bp19mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx11 = Format(a, "Fixed")
BP19mx12:
        a = 1
        c = pog19.Text - x12.Text
        Dim bp19mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx12 = Format(a, "Fixed")
BP19mx13:
        a = 1
        c = pog19.Text - x13.Text
        Dim bp19mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx13 = Format(a, "Fixed")
BP19mx14:
        a = 1
        c = pog19.Text - x14.Text
        Dim bp19mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx14 = Format(a, "Fixed")
BP19mx15:
        a = 1
        c = pog19.Text - x15.Text
        Dim bp19mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx15 = Format(a, "Fixed")
BP19mx16:
        a = 1
        c = pog19.Text - x16.Text
        Dim bp19mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx16 = Format(a, "Fixed")
BP19mx17:
        a = 1
        c = pog19.Text - x17.Text
        Dim bp19mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx17 = Format(a, "Fixed")
BP19mx18:
        a = 1
        c = pog19.Text - x18.Text
        Dim bp19mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx18 = Format(a, "Fixed")
BP19mx19:
        a = 1
        c = pog19.Text - x19.Text
        Dim bp19mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx19 = Format(a, "Fixed")
BP19mx20:
        a = 1
        c = pog19.Text - x20.Text
        Dim bp19mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp19mx20 = Format(a, "Fixed")
BP20mx1:
        a = 1
        c = pog20.Text - x1.Text
        Dim bp20mx1 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx1 = Format(a, "Fixed")
BP20mx2:
        a = 1
        c = pog20.Text - x2.Text
        Dim bp20mx2 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx2 = Format(a, "Fixed")
BP20mx3:
        a = 1
        c = pog20.Text - x3.Text
        Dim bp20mx3 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx3 = Format(a, "Fixed")
BP20mx4:
        a = 1
        c = pog20.Text - x4.Text
        Dim bp20mx4 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx4 = Format(a, "Fixed")
BP20mx5:
        a = 1
        c = pog20.Text - x5.Text
        Dim bp20mx5 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx5 = Format(a, "Fixed")
BP20mx6:
        a = 1
        c = pog20.Text - x6.Text
        Dim bp20mx6 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx6 = Format(a, "Fixed")
BP20mx7:
        a = 1
        c = pog20.Text - x7.Text
        Dim bp20mx7 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx7 = Format(a, "Fixed")
BP20mx8:
        a = 1
        c = pog20.Text - x8.Text
        Dim bp20mx8 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx8 = Format(a, "Fixed")
BP20mx9:
        a = 1
        c = pog20.Text - x9.Text
        Dim bp20mx9 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx9 = Format(a, "Fixed")
BP20mx10:
        a = 1
        c = pog20.Text - x10.Text
        Dim bp20mx10 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx10 = Format(a, "Fixed")
BP20mx11:
        a = 1
        c = pog20.Text - x11.Text
        Dim bp20mx11 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx11 = Format(a, "Fixed")
BP20mx12:
        a = 1
        c = pog20.Text - x12.Text
        Dim bp20mx12 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx12 = Format(a, "Fixed")
BP20mx13:
        a = 1
        c = pog20.Text - x13.Text
        Dim bp20mx13 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx13 = Format(a, "Fixed")
BP20mx14:
        a = 1
        c = pog20.Text - x14.Text
        Dim bp20mx14 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx14 = Format(a, "Fixed")
BP20mx15:
        a = 1
        c = pog20.Text - x15.Text
        Dim bp20mx15 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx15 = Format(a, "Fixed")
BP20mx16:
        a = 1
        c = pog20.Text - x16.Text
        Dim bp20mx16 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx16 = Format(a, "Fixed")
BP20mx17:
        a = 1
        c = pog20.Text - x17.Text
        Dim bp20mx17 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx17 = Format(a, "Fixed")
BP20mx18:
        a = 1
        c = pog20.Text - x18.Text
        Dim bp20mx18 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx18 = Format(a, "Fixed")
BP20mx19:
        a = 1
        c = pog20.Text - x19.Text
        Dim bp20mx19 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx19 = Format(a, "Fixed")
BP20mx20:
        a = 1
        c = pog20.Text - x20.Text
        Dim bp20mx20 As Double = 0
        For b = c To 1 Step -1
            a = a * b
        Next b
        bp20mx20 = Format(a, "Fixed")




sanse:

        If sysoutofY.Text = 0 Then sysoutofY.Text = ("00")
        If sysoutofY.Text = 1 Then sysoutofY.Text = ("01")
        If sysoutofY.Text = 2 Then sysoutofY.Text = ("02")
        If sysoutofY.Text = 3 Then sysoutofY.Text = ("03")
        If sysoutofY.Text = 4 Then sysoutofY.Text = ("04")
        If sysoutofY.Text = 5 Then sysoutofY.Text = ("05")
        If sysoutofY.Text = 6 Then sysoutofY.Text = ("06")
        If sysoutofY.Text = 7 Then sysoutofY.Text = ("07")
        If sysoutofY.Text = 8 Then sysoutofY.Text = ("08")
        If sysoutofY.Text = 9 Then sysoutofY.Text = ("09")
        If sysoutofY.Text > 20 Then sysoutofY.Text = 20

        If sysoutofY.Text < 0 Then ch0.Text = ("") Else ch0.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 0 * BP0 * ybp0 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 0))), 4)
        If sysoutofY.Text < 1 Then ch1.Text = ("") Else ch1.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 1 * BP1 * ybp1 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 1))), 4)
        If sysoutofY.Text < 2 Then ch2.Text = ("") Else ch2.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 2 * BP2 * ybp2 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 2))), 4)
        If sysoutofY.Text < 3 Then ch3.Text = ("") Else ch3.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 3 * BP3 * ybp3 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 3))), 4)
        If sysoutofY.Text < 4 Then ch4.Text = ("") Else ch4.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 4 * BP4 * ybp4 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 4))), 4)
        If sysoutofY.Text < 5 Then ch5.Text = ("") Else ch5.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 5 * BP5 * ybp5 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 5))), 4)
        If sysoutofY.Text < 6 Then ch6.Text = ("") Else ch6.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 6 * BP6 * ybp6 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 6))), 4)
        If sysoutofY.Text < 7 Then ch7.Text = ("") Else ch7.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 7 * BP7 * ybp7 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 7))), 4)
        If sysoutofY.Text < 8 Then ch8.Text = ("") Else ch8.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 8 * BP8 * ybp8 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 8))), 4)
        If sysoutofY.Text < 9 Then ch9.Text = ("") Else ch9.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 9 * BP9 * ybp9 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 9))), 4)
        If sysoutofY.Text < 10 Then ch10.Text = ("") Else ch10.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 10 * BP10 * ybp10 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 10))), 4)
        If sysoutofY.Text < 11 Then ch11.Text = ("") Else ch11.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 11 * BP11 * ybp11 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 11))), 4)
        If sysoutofY.Text < 12 Then ch12.Text = ("") Else ch12.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 12 * BP12 * ybp12 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 12))), 4)
        If sysoutofY.Text < 13 Then ch13.Text = ("") Else ch13.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 13 * BP13 * ybp13 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 13))), 4)
        If sysoutofY.Text < 14 Then ch14.Text = ("") Else ch14.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 14 * BP14 * ybp14 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 14))), 4)
        If sysoutofY.Text < 15 Then ch15.Text = ("") Else ch15.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 15 * BP15 * ybp15 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 15))), 4)
        If sysoutofY.Text < 16 Then ch16.Text = ("") Else ch16.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 16 * BP16 * ybp16 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 16))), 4)
        If sysoutofY.Text < 17 Then ch17.Text = ("") Else ch17.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 17 * BP17 * ybp17 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 17))), 4)
        If sysoutofY.Text < 18 Then ch18.Text = ("") Else ch18.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 18 * BP18 * ybp18 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 18))), 4)
        If sysoutofY.Text < 19 Then ch19.Text = ("") Else ch19.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 19 * BP19 * ybp19 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 19))), 4)
        If sysoutofY.Text < 20 Then ch20.Text = ("") Else ch20.Text = FormatNumber(100 * (Yfact / (1 / (avrgsanse.Text / 100) ^ 20 * BP20 * ybp20 * (1 / (1 - (avrgsanse.Text / 100))) ^ (sysoutofY.Text - 20))), 4)


        If x1.Text > sysoutofY.Text Then r1kr0.Text = ("") Else If x1.Text > pog0.Text Then r1kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r1kr0.Text = ("") Else r1kr0.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP0 * ymx1 / (Yfact * bp0mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr1.Text = ("") Else If x1.Text > pog1.Text Then r1kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r1kr1.Text = ("") Else r1kr1.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP1 * ymx1 / (Yfact * bp1mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr2.Text = ("") Else If x1.Text > pog2.Text Then r1kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r1kr2.Text = ("") Else r1kr2.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP2 * ymx1 / (Yfact * bp2mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr3.Text = ("") Else If x1.Text > pog3.Text Then r1kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r1kr3.Text = ("") Else r1kr3.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP3 * ymx1 / (Yfact * bp3mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr4.Text = ("") Else If x1.Text > pog4.Text Then r1kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r1kr4.Text = ("") Else r1kr4.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP4 * ymx1 / (Yfact * bp4mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr5.Text = ("") Else If x1.Text > pog5.Text Then r1kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r1kr5.Text = ("") Else r1kr5.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP5 * ymx1 / (Yfact * bp5mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr6.Text = ("") Else If x1.Text > pog6.Text Then r1kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r1kr6.Text = ("") Else r1kr6.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP6 * ymx1 / (Yfact * bp6mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr7.Text = ("") Else If x1.Text > pog7.Text Then r1kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r1kr7.Text = ("") Else r1kr7.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP7 * ymx1 / (Yfact * bp7mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr8.Text = ("") Else If x1.Text > pog8.Text Then r1kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r1kr8.Text = ("") Else r1kr8.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP8 * ymx1 / (Yfact * bp8mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr9.Text = ("") Else If x1.Text > pog9.Text Then r1kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r1kr9.Text = ("") Else r1kr9.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP9 * ymx1 / (Yfact * bp9mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr10.Text = ("") Else If x1.Text > pog10.Text Then r1kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r1kr10.Text = ("") Else r1kr10.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP10 * ymx1 / (Yfact * bp10mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr11.Text = ("") Else If x1.Text > pog11.Text Then r1kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r1kr11.Text = ("") Else r1kr11.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP11 * ymx1 / (Yfact * bp11mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr12.Text = ("") Else If x1.Text > pog12.Text Then r1kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r1kr12.Text = ("") Else r1kr12.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP12 * ymx1 / (Yfact * bp12mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr13.Text = ("") Else If x1.Text > pog13.Text Then r1kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r1kr13.Text = ("") Else r1kr13.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP13 * ymx1 / (Yfact * bp13mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr14.Text = ("") Else If x1.Text > pog14.Text Then r1kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r1kr14.Text = ("") Else r1kr14.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP14 * ymx1 / (Yfact * bp14mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr15.Text = ("") Else If x1.Text > pog15.Text Then r1kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r1kr15.Text = ("") Else r1kr15.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP15 * ymx1 / (Yfact * bp15mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr16.Text = ("") Else If x1.Text > pog16.Text Then r1kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r1kr16.Text = ("") Else r1kr16.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP16 * ymx1 / (Yfact * bp16mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr17.Text = ("") Else If x1.Text > pog17.Text Then r1kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r1kr17.Text = ("") Else r1kr17.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP17 * ymx1 / (Yfact * bp17mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr18.Text = ("") Else If x1.Text > pog18.Text Then r1kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r1kr18.Text = ("") Else r1kr18.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP18 * ymx1 / (Yfact * bp18mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr19.Text = ("") Else If x1.Text > pog19.Text Then r1kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r1kr19.Text = ("") Else r1kr19.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP19 * ymx1 / (Yfact * bp19mx1), 2)
        If x1.Text > sysoutofY.Text Then r1kr20.Text = ("") Else If x1.Text > pog20.Text Then r1kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r1kr20.Text = ("") Else r1kr20.Text = FormatNumber(AvrgKfc.Text ^ x1.Text * BP20 * ymx1 / (Yfact * bp20mx1), 2)

        If x2.Text > sysoutofY.Text Then r2kr0.Text = ("") Else If x2.Text > pog0.Text Then r2kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r2kr0.Text = ("") Else r2kr0.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP0 * ymx2 / (Yfact * bp0mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr1.Text = ("") Else If x2.Text > pog1.Text Then r2kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r2kr1.Text = ("") Else r2kr1.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP1 * ymx2 / (Yfact * bp1mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr2.Text = ("") Else If x2.Text > pog2.Text Then r2kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r2kr2.Text = ("") Else r2kr2.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP2 * ymx2 / (Yfact * bp2mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr3.Text = ("") Else If x2.Text > pog3.Text Then r2kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r2kr3.Text = ("") Else r2kr3.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP3 * ymx2 / (Yfact * bp3mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr4.Text = ("") Else If x2.Text > pog4.Text Then r2kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r2kr4.Text = ("") Else r2kr4.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP4 * ymx2 / (Yfact * bp4mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr5.Text = ("") Else If x2.Text > pog5.Text Then r2kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r2kr5.Text = ("") Else r2kr5.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP5 * ymx2 / (Yfact * bp5mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr6.Text = ("") Else If x2.Text > pog6.Text Then r2kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r2kr6.Text = ("") Else r2kr6.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP6 * ymx2 / (Yfact * bp6mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr7.Text = ("") Else If x2.Text > pog7.Text Then r2kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r2kr7.Text = ("") Else r2kr7.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP7 * ymx2 / (Yfact * bp7mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr8.Text = ("") Else If x2.Text > pog8.Text Then r2kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r2kr8.Text = ("") Else r2kr8.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP8 * ymx2 / (Yfact * bp8mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr9.Text = ("") Else If x2.Text > pog9.Text Then r2kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r2kr9.Text = ("") Else r2kr9.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP9 * ymx2 / (Yfact * bp9mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr10.Text = ("") Else If x2.Text > pog10.Text Then r2kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r2kr10.Text = ("") Else r2kr10.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP10 * ymx2 / (Yfact * bp10mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr11.Text = ("") Else If x2.Text > pog11.Text Then r2kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r2kr11.Text = ("") Else r2kr11.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP11 * ymx2 / (Yfact * bp11mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr12.Text = ("") Else If x2.Text > pog12.Text Then r2kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r2kr12.Text = ("") Else r2kr12.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP12 * ymx2 / (Yfact * bp12mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr13.Text = ("") Else If x2.Text > pog13.Text Then r2kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r2kr13.Text = ("") Else r2kr13.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP13 * ymx2 / (Yfact * bp13mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr14.Text = ("") Else If x2.Text > pog14.Text Then r2kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r2kr14.Text = ("") Else r2kr14.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP14 * ymx2 / (Yfact * bp14mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr15.Text = ("") Else If x2.Text > pog15.Text Then r2kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r2kr15.Text = ("") Else r2kr15.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP15 * ymx2 / (Yfact * bp15mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr16.Text = ("") Else If x2.Text > pog16.Text Then r2kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r2kr16.Text = ("") Else r2kr16.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP16 * ymx2 / (Yfact * bp16mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr17.Text = ("") Else If x2.Text > pog17.Text Then r2kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r2kr17.Text = ("") Else r2kr17.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP17 * ymx2 / (Yfact * bp17mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr18.Text = ("") Else If x2.Text > pog18.Text Then r2kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r2kr18.Text = ("") Else r2kr18.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP18 * ymx2 / (Yfact * bp18mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr19.Text = ("") Else If x2.Text > pog19.Text Then r2kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r2kr19.Text = ("") Else r2kr19.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP19 * ymx2 / (Yfact * bp19mx2), 2)
        If x2.Text > sysoutofY.Text Then r2kr20.Text = ("") Else If x2.Text > pog20.Text Then r2kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r2kr20.Text = ("") Else r2kr20.Text = FormatNumber(AvrgKfc.Text ^ x2.Text * BP20 * ymx2 / (Yfact * bp20mx2), 2)

        If x3.Text > sysoutofY.Text Then r3kr0.Text = ("") Else If x3.Text > pog0.Text Then r3kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r3kr0.Text = ("") Else r3kr0.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP0 * ymx3 / (Yfact * bp0mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr1.Text = ("") Else If x3.Text > pog1.Text Then r3kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r3kr1.Text = ("") Else r3kr1.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP1 * ymx3 / (Yfact * bp1mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr2.Text = ("") Else If x3.Text > pog2.Text Then r3kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r3kr2.Text = ("") Else r3kr2.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP2 * ymx3 / (Yfact * bp2mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr3.Text = ("") Else If x3.Text > pog3.Text Then r3kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r3kr3.Text = ("") Else r3kr3.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP3 * ymx3 / (Yfact * bp3mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr4.Text = ("") Else If x3.Text > pog4.Text Then r3kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r3kr4.Text = ("") Else r3kr4.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP4 * ymx3 / (Yfact * bp4mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr5.Text = ("") Else If x3.Text > pog5.Text Then r3kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r3kr5.Text = ("") Else r3kr5.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP5 * ymx3 / (Yfact * bp5mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr6.Text = ("") Else If x3.Text > pog6.Text Then r3kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r3kr6.Text = ("") Else r3kr6.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP6 * ymx3 / (Yfact * bp6mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr7.Text = ("") Else If x3.Text > pog7.Text Then r3kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r3kr7.Text = ("") Else r3kr7.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP7 * ymx3 / (Yfact * bp7mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr8.Text = ("") Else If x3.Text > pog8.Text Then r3kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r3kr8.Text = ("") Else r3kr8.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP8 * ymx3 / (Yfact * bp8mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr9.Text = ("") Else If x3.Text > pog9.Text Then r3kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r3kr9.Text = ("") Else r3kr9.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP9 * ymx3 / (Yfact * bp9mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr10.Text = ("") Else If x3.Text > pog10.Text Then r3kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r3kr10.Text = ("") Else r3kr10.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP10 * ymx3 / (Yfact * bp10mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr11.Text = ("") Else If x3.Text > pog11.Text Then r3kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r3kr11.Text = ("") Else r3kr11.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP11 * ymx3 / (Yfact * bp11mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr12.Text = ("") Else If x3.Text > pog12.Text Then r3kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r3kr12.Text = ("") Else r3kr12.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP12 * ymx3 / (Yfact * bp12mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr13.Text = ("") Else If x3.Text > pog13.Text Then r3kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r3kr13.Text = ("") Else r3kr13.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP13 * ymx3 / (Yfact * bp13mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr14.Text = ("") Else If x3.Text > pog14.Text Then r3kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r3kr14.Text = ("") Else r3kr14.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP14 * ymx3 / (Yfact * bp14mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr15.Text = ("") Else If x3.Text > pog15.Text Then r3kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r3kr15.Text = ("") Else r3kr15.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP15 * ymx3 / (Yfact * bp15mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr16.Text = ("") Else If x3.Text > pog16.Text Then r3kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r3kr16.Text = ("") Else r3kr16.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP16 * ymx3 / (Yfact * bp16mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr17.Text = ("") Else If x3.Text > pog17.Text Then r3kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r3kr17.Text = ("") Else r3kr17.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP17 * ymx3 / (Yfact * bp17mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr18.Text = ("") Else If x3.Text > pog18.Text Then r3kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r3kr18.Text = ("") Else r3kr18.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP18 * ymx3 / (Yfact * bp18mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr19.Text = ("") Else If x3.Text > pog19.Text Then r3kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r3kr19.Text = ("") Else r3kr19.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP19 * ymx3 / (Yfact * bp19mx3), 2)
        If x3.Text > sysoutofY.Text Then r3kr20.Text = ("") Else If x3.Text > pog20.Text Then r3kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r3kr20.Text = ("") Else r3kr20.Text = FormatNumber(AvrgKfc.Text ^ x3.Text * BP20 * ymx3 / (Yfact * bp20mx3), 2)

        If x4.Text > sysoutofY.Text Then r4kr0.Text = ("") Else If x4.Text > pog0.Text Then r4kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r4kr0.Text = ("") Else r4kr0.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP0 * ymx4 / (Yfact * bp0mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr1.Text = ("") Else If x4.Text > pog1.Text Then r4kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r4kr1.Text = ("") Else r4kr1.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP1 * ymx4 / (Yfact * bp1mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr2.Text = ("") Else If x4.Text > pog2.Text Then r4kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r4kr2.Text = ("") Else r4kr2.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP2 * ymx4 / (Yfact * bp2mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr3.Text = ("") Else If x4.Text > pog3.Text Then r4kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r4kr3.Text = ("") Else r4kr3.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP3 * ymx4 / (Yfact * bp3mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr4.Text = ("") Else If x4.Text > pog4.Text Then r4kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r4kr4.Text = ("") Else r4kr4.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP4 * ymx4 / (Yfact * bp4mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr5.Text = ("") Else If x4.Text > pog5.Text Then r4kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r4kr5.Text = ("") Else r4kr5.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP5 * ymx4 / (Yfact * bp5mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr6.Text = ("") Else If x4.Text > pog6.Text Then r4kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r4kr6.Text = ("") Else r4kr6.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP6 * ymx4 / (Yfact * bp6mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr7.Text = ("") Else If x4.Text > pog7.Text Then r4kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r4kr7.Text = ("") Else r4kr7.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP7 * ymx4 / (Yfact * bp7mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr8.Text = ("") Else If x4.Text > pog8.Text Then r4kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r4kr8.Text = ("") Else r4kr8.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP8 * ymx4 / (Yfact * bp8mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr9.Text = ("") Else If x4.Text > pog9.Text Then r4kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r4kr9.Text = ("") Else r4kr9.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP9 * ymx4 / (Yfact * bp9mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr10.Text = ("") Else If x4.Text > pog10.Text Then r4kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r4kr10.Text = ("") Else r4kr10.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP10 * ymx4 / (Yfact * bp10mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr11.Text = ("") Else If x4.Text > pog11.Text Then r4kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r4kr11.Text = ("") Else r4kr11.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP11 * ymx4 / (Yfact * bp11mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr12.Text = ("") Else If x4.Text > pog12.Text Then r4kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r4kr12.Text = ("") Else r4kr12.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP12 * ymx4 / (Yfact * bp12mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr13.Text = ("") Else If x4.Text > pog13.Text Then r4kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r4kr13.Text = ("") Else r4kr13.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP13 * ymx4 / (Yfact * bp13mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr14.Text = ("") Else If x4.Text > pog14.Text Then r4kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r4kr14.Text = ("") Else r4kr14.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP14 * ymx4 / (Yfact * bp14mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr15.Text = ("") Else If x4.Text > pog15.Text Then r4kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r4kr15.Text = ("") Else r4kr15.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP15 * ymx4 / (Yfact * bp15mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr16.Text = ("") Else If x4.Text > pog16.Text Then r4kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r4kr16.Text = ("") Else r4kr16.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP16 * ymx4 / (Yfact * bp16mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr17.Text = ("") Else If x4.Text > pog17.Text Then r4kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r4kr17.Text = ("") Else r4kr17.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP17 * ymx4 / (Yfact * bp17mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr18.Text = ("") Else If x4.Text > pog18.Text Then r4kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r4kr18.Text = ("") Else r4kr18.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP18 * ymx4 / (Yfact * bp18mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr19.Text = ("") Else If x4.Text > pog19.Text Then r4kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r4kr19.Text = ("") Else r4kr19.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP19 * ymx4 / (Yfact * bp19mx4), 2)
        If x4.Text > sysoutofY.Text Then r4kr20.Text = ("") Else If x4.Text > pog20.Text Then r4kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r4kr20.Text = ("") Else r4kr20.Text = FormatNumber(AvrgKfc.Text ^ x4.Text * BP20 * ymx4 / (Yfact * bp20mx4), 2)

        If x5.Text > sysoutofY.Text Then r5kr0.Text = ("") Else If x5.Text > pog0.Text Then r5kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r5kr0.Text = ("") Else r5kr0.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP0 * ymx5 / (Yfact * bp0mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr1.Text = ("") Else If x5.Text > pog1.Text Then r5kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r5kr1.Text = ("") Else r5kr1.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP1 * ymx5 / (Yfact * bp1mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr2.Text = ("") Else If x5.Text > pog2.Text Then r5kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r5kr2.Text = ("") Else r5kr2.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP2 * ymx5 / (Yfact * bp2mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr3.Text = ("") Else If x5.Text > pog3.Text Then r5kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r5kr3.Text = ("") Else r5kr3.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP3 * ymx5 / (Yfact * bp3mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr4.Text = ("") Else If x5.Text > pog4.Text Then r5kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r5kr4.Text = ("") Else r5kr4.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP4 * ymx5 / (Yfact * bp4mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr5.Text = ("") Else If x5.Text > pog5.Text Then r5kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r5kr5.Text = ("") Else r5kr5.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP5 * ymx5 / (Yfact * bp5mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr6.Text = ("") Else If x5.Text > pog6.Text Then r5kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r5kr6.Text = ("") Else r5kr6.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP6 * ymx5 / (Yfact * bp6mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr7.Text = ("") Else If x5.Text > pog7.Text Then r5kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r5kr7.Text = ("") Else r5kr7.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP7 * ymx5 / (Yfact * bp7mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr8.Text = ("") Else If x5.Text > pog8.Text Then r5kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r5kr8.Text = ("") Else r5kr8.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP8 * ymx5 / (Yfact * bp8mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr9.Text = ("") Else If x5.Text > pog9.Text Then r5kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r5kr9.Text = ("") Else r5kr9.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP9 * ymx5 / (Yfact * bp9mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr10.Text = ("") Else If x5.Text > pog10.Text Then r5kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r5kr10.Text = ("") Else r5kr10.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP10 * ymx5 / (Yfact * bp10mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr11.Text = ("") Else If x5.Text > pog11.Text Then r5kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r5kr11.Text = ("") Else r5kr11.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP11 * ymx5 / (Yfact * bp11mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr12.Text = ("") Else If x5.Text > pog12.Text Then r5kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r5kr12.Text = ("") Else r5kr12.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP12 * ymx5 / (Yfact * bp12mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr13.Text = ("") Else If x5.Text > pog13.Text Then r5kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r5kr13.Text = ("") Else r5kr13.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP13 * ymx5 / (Yfact * bp13mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr14.Text = ("") Else If x5.Text > pog14.Text Then r5kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r5kr14.Text = ("") Else r5kr14.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP14 * ymx5 / (Yfact * bp14mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr15.Text = ("") Else If x5.Text > pog15.Text Then r5kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r5kr15.Text = ("") Else r5kr15.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP15 * ymx5 / (Yfact * bp15mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr16.Text = ("") Else If x5.Text > pog16.Text Then r5kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r5kr16.Text = ("") Else r5kr16.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP16 * ymx5 / (Yfact * bp16mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr17.Text = ("") Else If x5.Text > pog17.Text Then r5kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r5kr17.Text = ("") Else r5kr17.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP17 * ymx5 / (Yfact * bp17mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr18.Text = ("") Else If x5.Text > pog18.Text Then r5kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r5kr18.Text = ("") Else r5kr18.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP18 * ymx5 / (Yfact * bp18mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr19.Text = ("") Else If x5.Text > pog19.Text Then r5kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r5kr19.Text = ("") Else r5kr19.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP19 * ymx5 / (Yfact * bp19mx5), 2)
        If x5.Text > sysoutofY.Text Then r5kr20.Text = ("") Else If x5.Text > pog20.Text Then r5kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r5kr20.Text = ("") Else r5kr20.Text = FormatNumber(AvrgKfc.Text ^ x5.Text * BP20 * ymx5 / (Yfact * bp20mx5), 2)

        If x6.Text > sysoutofY.Text Then r6kr0.Text = ("") Else If x6.Text > pog0.Text Then r6kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r6kr0.Text = ("") Else r6kr0.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP0 * ymx6 / (Yfact * bp0mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr1.Text = ("") Else If x6.Text > pog1.Text Then r6kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r6kr1.Text = ("") Else r6kr1.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP1 * ymx6 / (Yfact * bp1mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr2.Text = ("") Else If x6.Text > pog2.Text Then r6kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r6kr2.Text = ("") Else r6kr2.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP2 * ymx6 / (Yfact * bp2mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr3.Text = ("") Else If x6.Text > pog3.Text Then r6kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r6kr3.Text = ("") Else r6kr3.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP3 * ymx6 / (Yfact * bp3mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr4.Text = ("") Else If x6.Text > pog4.Text Then r6kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r6kr4.Text = ("") Else r6kr4.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP4 * ymx6 / (Yfact * bp4mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr5.Text = ("") Else If x6.Text > pog5.Text Then r6kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r6kr5.Text = ("") Else r6kr5.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP5 * ymx6 / (Yfact * bp5mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr6.Text = ("") Else If x6.Text > pog6.Text Then r6kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r6kr6.Text = ("") Else r6kr6.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP6 * ymx6 / (Yfact * bp6mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr7.Text = ("") Else If x6.Text > pog7.Text Then r6kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r6kr7.Text = ("") Else r6kr7.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP7 * ymx6 / (Yfact * bp7mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr8.Text = ("") Else If x6.Text > pog8.Text Then r6kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r6kr8.Text = ("") Else r6kr8.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP8 * ymx6 / (Yfact * bp8mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr9.Text = ("") Else If x6.Text > pog9.Text Then r6kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r6kr9.Text = ("") Else r6kr9.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP9 * ymx6 / (Yfact * bp9mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr10.Text = ("") Else If x6.Text > pog10.Text Then r6kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r6kr10.Text = ("") Else r6kr10.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP10 * ymx6 / (Yfact * bp10mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr11.Text = ("") Else If x6.Text > pog11.Text Then r6kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r6kr11.Text = ("") Else r6kr11.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP11 * ymx6 / (Yfact * bp11mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr12.Text = ("") Else If x6.Text > pog12.Text Then r6kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r6kr12.Text = ("") Else r6kr12.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP12 * ymx6 / (Yfact * bp12mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr13.Text = ("") Else If x6.Text > pog13.Text Then r6kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r6kr13.Text = ("") Else r6kr13.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP13 * ymx6 / (Yfact * bp13mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr14.Text = ("") Else If x6.Text > pog14.Text Then r6kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r6kr14.Text = ("") Else r6kr14.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP14 * ymx6 / (Yfact * bp14mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr15.Text = ("") Else If x6.Text > pog15.Text Then r6kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r6kr15.Text = ("") Else r6kr15.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP15 * ymx6 / (Yfact * bp15mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr16.Text = ("") Else If x6.Text > pog16.Text Then r6kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r6kr16.Text = ("") Else r6kr16.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP16 * ymx6 / (Yfact * bp16mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr17.Text = ("") Else If x6.Text > pog17.Text Then r6kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r6kr17.Text = ("") Else r6kr17.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP17 * ymx6 / (Yfact * bp17mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr18.Text = ("") Else If x6.Text > pog18.Text Then r6kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r6kr18.Text = ("") Else r6kr18.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP18 * ymx6 / (Yfact * bp18mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr19.Text = ("") Else If x6.Text > pog19.Text Then r6kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r6kr19.Text = ("") Else r6kr19.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP19 * ymx6 / (Yfact * bp19mx6), 2)
        If x6.Text > sysoutofY.Text Then r6kr20.Text = ("") Else If x6.Text > pog20.Text Then r6kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r6kr20.Text = ("") Else r6kr20.Text = FormatNumber(AvrgKfc.Text ^ x6.Text * BP20 * ymx6 / (Yfact * bp20mx6), 2)

        If x7.Text > sysoutofY.Text Then r7kr0.Text = ("") Else If x7.Text > pog0.Text Then r7kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r7kr0.Text = ("") Else r7kr0.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP0 * ymx7 / (Yfact * bp0mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr1.Text = ("") Else If x7.Text > pog1.Text Then r7kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r7kr1.Text = ("") Else r7kr1.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP1 * ymx7 / (Yfact * bp1mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr2.Text = ("") Else If x7.Text > pog2.Text Then r7kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r7kr2.Text = ("") Else r7kr2.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP2 * ymx7 / (Yfact * bp2mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr3.Text = ("") Else If x7.Text > pog3.Text Then r7kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r7kr3.Text = ("") Else r7kr3.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP3 * ymx7 / (Yfact * bp3mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr4.Text = ("") Else If x7.Text > pog4.Text Then r7kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r7kr4.Text = ("") Else r7kr4.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP4 * ymx7 / (Yfact * bp4mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr5.Text = ("") Else If x7.Text > pog5.Text Then r7kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r7kr5.Text = ("") Else r7kr5.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP5 * ymx7 / (Yfact * bp5mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr6.Text = ("") Else If x7.Text > pog6.Text Then r7kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r7kr6.Text = ("") Else r7kr6.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP6 * ymx7 / (Yfact * bp6mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr7.Text = ("") Else If x7.Text > pog7.Text Then r7kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r7kr7.Text = ("") Else r7kr7.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP7 * ymx7 / (Yfact * bp7mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr8.Text = ("") Else If x7.Text > pog8.Text Then r7kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r7kr8.Text = ("") Else r7kr8.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP8 * ymx7 / (Yfact * bp8mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr9.Text = ("") Else If x7.Text > pog9.Text Then r7kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r7kr9.Text = ("") Else r7kr9.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP9 * ymx7 / (Yfact * bp9mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr10.Text = ("") Else If x7.Text > pog10.Text Then r7kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r7kr10.Text = ("") Else r7kr10.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP10 * ymx7 / (Yfact * bp10mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr11.Text = ("") Else If x7.Text > pog11.Text Then r7kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r7kr11.Text = ("") Else r7kr11.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP11 * ymx7 / (Yfact * bp11mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr12.Text = ("") Else If x7.Text > pog12.Text Then r7kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r7kr12.Text = ("") Else r7kr12.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP12 * ymx7 / (Yfact * bp12mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr13.Text = ("") Else If x7.Text > pog13.Text Then r7kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r7kr13.Text = ("") Else r7kr13.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP13 * ymx7 / (Yfact * bp13mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr14.Text = ("") Else If x7.Text > pog14.Text Then r7kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r7kr14.Text = ("") Else r7kr14.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP14 * ymx7 / (Yfact * bp14mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr15.Text = ("") Else If x7.Text > pog15.Text Then r7kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r7kr15.Text = ("") Else r7kr15.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP15 * ymx7 / (Yfact * bp15mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr16.Text = ("") Else If x7.Text > pog16.Text Then r7kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r7kr16.Text = ("") Else r7kr16.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP16 * ymx7 / (Yfact * bp16mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr17.Text = ("") Else If x7.Text > pog17.Text Then r7kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r7kr17.Text = ("") Else r7kr17.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP17 * ymx7 / (Yfact * bp17mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr18.Text = ("") Else If x7.Text > pog18.Text Then r7kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r7kr18.Text = ("") Else r7kr18.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP18 * ymx7 / (Yfact * bp18mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr19.Text = ("") Else If x7.Text > pog19.Text Then r7kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r7kr19.Text = ("") Else r7kr19.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP19 * ymx7 / (Yfact * bp19mx7), 2)
        If x7.Text > sysoutofY.Text Then r7kr20.Text = ("") Else If x7.Text > pog20.Text Then r7kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r7kr20.Text = ("") Else r7kr20.Text = FormatNumber(AvrgKfc.Text ^ x7.Text * BP20 * ymx7 / (Yfact * bp20mx7), 2)

        If x8.Text > sysoutofY.Text Then r8kr0.Text = ("") Else If x8.Text > pog0.Text Then r8kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r8kr0.Text = ("") Else r8kr0.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP0 * ymx8 / (Yfact * bp0mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr1.Text = ("") Else If x8.Text > pog1.Text Then r8kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r8kr1.Text = ("") Else r8kr1.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP1 * ymx8 / (Yfact * bp1mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr2.Text = ("") Else If x8.Text > pog2.Text Then r8kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r8kr2.Text = ("") Else r8kr2.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP2 * ymx8 / (Yfact * bp2mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr3.Text = ("") Else If x8.Text > pog3.Text Then r8kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r8kr3.Text = ("") Else r8kr3.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP3 * ymx8 / (Yfact * bp3mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr4.Text = ("") Else If x8.Text > pog4.Text Then r8kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r8kr4.Text = ("") Else r8kr4.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP4 * ymx8 / (Yfact * bp4mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr5.Text = ("") Else If x8.Text > pog5.Text Then r8kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r8kr5.Text = ("") Else r8kr5.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP5 * ymx8 / (Yfact * bp5mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr6.Text = ("") Else If x8.Text > pog6.Text Then r8kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r8kr6.Text = ("") Else r8kr6.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP6 * ymx8 / (Yfact * bp6mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr7.Text = ("") Else If x8.Text > pog7.Text Then r8kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r8kr7.Text = ("") Else r8kr7.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP7 * ymx8 / (Yfact * bp7mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr8.Text = ("") Else If x8.Text > pog8.Text Then r8kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r8kr8.Text = ("") Else r8kr8.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP8 * ymx8 / (Yfact * bp8mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr9.Text = ("") Else If x8.Text > pog9.Text Then r8kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r8kr9.Text = ("") Else r8kr9.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP9 * ymx8 / (Yfact * bp9mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr10.Text = ("") Else If x8.Text > pog10.Text Then r8kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r8kr10.Text = ("") Else r8kr10.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP10 * ymx8 / (Yfact * bp10mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr11.Text = ("") Else If x8.Text > pog11.Text Then r8kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r8kr11.Text = ("") Else r8kr11.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP11 * ymx8 / (Yfact * bp11mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr12.Text = ("") Else If x8.Text > pog12.Text Then r8kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r8kr12.Text = ("") Else r8kr12.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP12 * ymx8 / (Yfact * bp12mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr13.Text = ("") Else If x8.Text > pog13.Text Then r8kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r8kr13.Text = ("") Else r8kr13.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP13 * ymx8 / (Yfact * bp13mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr14.Text = ("") Else If x8.Text > pog14.Text Then r8kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r8kr14.Text = ("") Else r8kr14.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP14 * ymx8 / (Yfact * bp14mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr15.Text = ("") Else If x8.Text > pog15.Text Then r8kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r8kr15.Text = ("") Else r8kr15.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP15 * ymx8 / (Yfact * bp15mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr16.Text = ("") Else If x8.Text > pog16.Text Then r8kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r8kr16.Text = ("") Else r8kr16.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP16 * ymx8 / (Yfact * bp16mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr17.Text = ("") Else If x8.Text > pog17.Text Then r8kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r8kr17.Text = ("") Else r8kr17.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP17 * ymx8 / (Yfact * bp17mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr18.Text = ("") Else If x8.Text > pog18.Text Then r8kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r8kr18.Text = ("") Else r8kr18.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP18 * ymx8 / (Yfact * bp18mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr19.Text = ("") Else If x8.Text > pog19.Text Then r8kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r8kr19.Text = ("") Else r8kr19.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP19 * ymx8 / (Yfact * bp19mx8), 2)
        If x8.Text > sysoutofY.Text Then r8kr20.Text = ("") Else If x8.Text > pog20.Text Then r8kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r8kr20.Text = ("") Else r8kr20.Text = FormatNumber(AvrgKfc.Text ^ x8.Text * BP20 * ymx8 / (Yfact * bp20mx8), 2)

        If x9.Text > sysoutofY.Text Then r9kr0.Text = ("") Else If x9.Text > pog0.Text Then r9kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r9kr0.Text = ("") Else r9kr0.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP0 * ymx9 / (Yfact * bp0mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr1.Text = ("") Else If x9.Text > pog1.Text Then r9kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r9kr1.Text = ("") Else r9kr1.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP1 * ymx9 / (Yfact * bp1mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr2.Text = ("") Else If x9.Text > pog2.Text Then r9kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r9kr2.Text = ("") Else r9kr2.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP2 * ymx9 / (Yfact * bp2mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr3.Text = ("") Else If x9.Text > pog3.Text Then r9kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r9kr3.Text = ("") Else r9kr3.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP3 * ymx9 / (Yfact * bp3mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr4.Text = ("") Else If x9.Text > pog4.Text Then r9kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r9kr4.Text = ("") Else r9kr4.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP4 * ymx9 / (Yfact * bp4mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr5.Text = ("") Else If x9.Text > pog5.Text Then r9kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r9kr5.Text = ("") Else r9kr5.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP5 * ymx9 / (Yfact * bp5mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr6.Text = ("") Else If x9.Text > pog6.Text Then r9kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r9kr6.Text = ("") Else r9kr6.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP6 * ymx9 / (Yfact * bp6mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr7.Text = ("") Else If x9.Text > pog7.Text Then r9kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r9kr7.Text = ("") Else r9kr7.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP7 * ymx9 / (Yfact * bp7mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr8.Text = ("") Else If x9.Text > pog8.Text Then r9kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r9kr8.Text = ("") Else r9kr8.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP8 * ymx9 / (Yfact * bp8mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr9.Text = ("") Else If x9.Text > pog9.Text Then r9kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r9kr9.Text = ("") Else r9kr9.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP9 * ymx9 / (Yfact * bp9mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr10.Text = ("") Else If x9.Text > pog10.Text Then r9kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r9kr10.Text = ("") Else r9kr10.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP10 * ymx9 / (Yfact * bp10mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr11.Text = ("") Else If x9.Text > pog11.Text Then r9kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r9kr11.Text = ("") Else r9kr11.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP11 * ymx9 / (Yfact * bp11mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr12.Text = ("") Else If x9.Text > pog12.Text Then r9kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r9kr12.Text = ("") Else r9kr12.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP12 * ymx9 / (Yfact * bp12mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr13.Text = ("") Else If x9.Text > pog13.Text Then r9kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r9kr13.Text = ("") Else r9kr13.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP13 * ymx9 / (Yfact * bp13mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr14.Text = ("") Else If x9.Text > pog14.Text Then r9kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r9kr14.Text = ("") Else r9kr14.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP14 * ymx9 / (Yfact * bp14mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr15.Text = ("") Else If x9.Text > pog15.Text Then r9kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r9kr15.Text = ("") Else r9kr15.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP15 * ymx9 / (Yfact * bp15mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr16.Text = ("") Else If x9.Text > pog16.Text Then r9kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r9kr16.Text = ("") Else r9kr16.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP16 * ymx9 / (Yfact * bp16mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr17.Text = ("") Else If x9.Text > pog17.Text Then r9kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r9kr17.Text = ("") Else r9kr17.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP17 * ymx9 / (Yfact * bp17mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr18.Text = ("") Else If x9.Text > pog18.Text Then r9kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r9kr18.Text = ("") Else r9kr18.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP18 * ymx9 / (Yfact * bp18mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr19.Text = ("") Else If x9.Text > pog19.Text Then r9kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r9kr19.Text = ("") Else r9kr19.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP19 * ymx9 / (Yfact * bp19mx9), 2)
        If x9.Text > sysoutofY.Text Then r9kr20.Text = ("") Else If x9.Text > pog20.Text Then r9kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r9kr20.Text = ("") Else r9kr20.Text = FormatNumber(AvrgKfc.Text ^ x9.Text * BP20 * ymx9 / (Yfact * bp20mx9), 2)

        If x10.Text > sysoutofY.Text Then r10kr0.Text = ("") Else If x10.Text > pog0.Text Then r10kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r10kr0.Text = ("") Else r10kr0.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP0 * ymx10 / (Yfact * bp0mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr1.Text = ("") Else If x10.Text > pog1.Text Then r10kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r10kr1.Text = ("") Else r10kr1.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP1 * ymx10 / (Yfact * bp1mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr2.Text = ("") Else If x10.Text > pog2.Text Then r10kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r10kr2.Text = ("") Else r10kr2.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP2 * ymx10 / (Yfact * bp2mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr3.Text = ("") Else If x10.Text > pog3.Text Then r10kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r10kr3.Text = ("") Else r10kr3.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP3 * ymx10 / (Yfact * bp3mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr4.Text = ("") Else If x10.Text > pog4.Text Then r10kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r10kr4.Text = ("") Else r10kr4.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP4 * ymx10 / (Yfact * bp4mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr5.Text = ("") Else If x10.Text > pog5.Text Then r10kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r10kr5.Text = ("") Else r10kr5.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP5 * ymx10 / (Yfact * bp5mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr6.Text = ("") Else If x10.Text > pog6.Text Then r10kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r10kr6.Text = ("") Else r10kr6.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP6 * ymx10 / (Yfact * bp6mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr7.Text = ("") Else If x10.Text > pog7.Text Then r10kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r10kr7.Text = ("") Else r10kr7.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP7 * ymx10 / (Yfact * bp7mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr8.Text = ("") Else If x10.Text > pog8.Text Then r10kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r10kr8.Text = ("") Else r10kr8.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP8 * ymx10 / (Yfact * bp8mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr9.Text = ("") Else If x10.Text > pog9.Text Then r10kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r10kr9.Text = ("") Else r10kr9.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP9 * ymx10 / (Yfact * bp9mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr10.Text = ("") Else If x10.Text > pog10.Text Then r10kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r10kr10.Text = ("") Else r10kr10.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP10 * ymx10 / (Yfact * bp10mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr11.Text = ("") Else If x10.Text > pog11.Text Then r10kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r10kr11.Text = ("") Else r10kr11.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP11 * ymx10 / (Yfact * bp11mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr12.Text = ("") Else If x10.Text > pog12.Text Then r10kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r10kr12.Text = ("") Else r10kr12.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP12 * ymx10 / (Yfact * bp12mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr13.Text = ("") Else If x10.Text > pog13.Text Then r10kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r10kr13.Text = ("") Else r10kr13.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP13 * ymx10 / (Yfact * bp13mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr14.Text = ("") Else If x10.Text > pog14.Text Then r10kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r10kr14.Text = ("") Else r10kr14.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP14 * ymx10 / (Yfact * bp14mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr15.Text = ("") Else If x10.Text > pog15.Text Then r10kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r10kr15.Text = ("") Else r10kr15.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP15 * ymx10 / (Yfact * bp15mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr16.Text = ("") Else If x10.Text > pog16.Text Then r10kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r10kr16.Text = ("") Else r10kr16.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP16 * ymx10 / (Yfact * bp16mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr17.Text = ("") Else If x10.Text > pog17.Text Then r10kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r10kr17.Text = ("") Else r10kr17.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP17 * ymx10 / (Yfact * bp17mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr18.Text = ("") Else If x10.Text > pog18.Text Then r10kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r10kr18.Text = ("") Else r10kr18.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP18 * ymx10 / (Yfact * bp18mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr19.Text = ("") Else If x10.Text > pog19.Text Then r10kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r10kr19.Text = ("") Else r10kr19.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP19 * ymx10 / (Yfact * bp19mx10), 2)
        If x10.Text > sysoutofY.Text Then r10kr20.Text = ("") Else If x10.Text > pog20.Text Then r10kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r10kr20.Text = ("") Else r10kr20.Text = FormatNumber(AvrgKfc.Text ^ x10.Text * BP20 * ymx10 / (Yfact * bp20mx10), 2)

        If x11.Text > sysoutofY.Text Then r11kr0.Text = ("") Else If x11.Text > pog0.Text Then r11kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r11kr0.Text = ("") Else r11kr0.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP0 * ymx11 / (Yfact * bp0mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr1.Text = ("") Else If x11.Text > pog1.Text Then r11kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r11kr1.Text = ("") Else r11kr1.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP1 * ymx11 / (Yfact * bp1mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr2.Text = ("") Else If x11.Text > pog2.Text Then r11kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r11kr2.Text = ("") Else r11kr2.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP2 * ymx11 / (Yfact * bp2mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr3.Text = ("") Else If x11.Text > pog3.Text Then r11kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r11kr3.Text = ("") Else r11kr3.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP3 * ymx11 / (Yfact * bp3mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr4.Text = ("") Else If x11.Text > pog4.Text Then r11kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r11kr4.Text = ("") Else r11kr4.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP4 * ymx11 / (Yfact * bp4mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr5.Text = ("") Else If x11.Text > pog5.Text Then r11kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r11kr5.Text = ("") Else r11kr5.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP5 * ymx11 / (Yfact * bp5mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr6.Text = ("") Else If x11.Text > pog6.Text Then r11kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r11kr6.Text = ("") Else r11kr6.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP6 * ymx11 / (Yfact * bp6mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr7.Text = ("") Else If x11.Text > pog7.Text Then r11kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r11kr7.Text = ("") Else r11kr7.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP7 * ymx11 / (Yfact * bp7mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr8.Text = ("") Else If x11.Text > pog8.Text Then r11kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r11kr8.Text = ("") Else r11kr8.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP8 * ymx11 / (Yfact * bp8mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr9.Text = ("") Else If x11.Text > pog9.Text Then r11kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r11kr9.Text = ("") Else r11kr9.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP9 * ymx11 / (Yfact * bp9mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr10.Text = ("") Else If x11.Text > pog10.Text Then r11kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r11kr10.Text = ("") Else r11kr10.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP10 * ymx11 / (Yfact * bp10mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr11.Text = ("") Else If x11.Text > pog11.Text Then r11kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r11kr11.Text = ("") Else r11kr11.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP11 * ymx11 / (Yfact * bp11mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr12.Text = ("") Else If x11.Text > pog12.Text Then r11kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r11kr12.Text = ("") Else r11kr12.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP12 * ymx11 / (Yfact * bp12mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr13.Text = ("") Else If x11.Text > pog13.Text Then r11kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r11kr13.Text = ("") Else r11kr13.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP13 * ymx11 / (Yfact * bp13mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr14.Text = ("") Else If x11.Text > pog14.Text Then r11kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r11kr14.Text = ("") Else r11kr14.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP14 * ymx11 / (Yfact * bp14mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr15.Text = ("") Else If x11.Text > pog15.Text Then r11kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r11kr15.Text = ("") Else r11kr15.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP15 * ymx11 / (Yfact * bp15mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr16.Text = ("") Else If x11.Text > pog16.Text Then r11kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r11kr16.Text = ("") Else r11kr16.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP16 * ymx11 / (Yfact * bp16mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr17.Text = ("") Else If x11.Text > pog17.Text Then r11kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r11kr17.Text = ("") Else r11kr17.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP17 * ymx11 / (Yfact * bp17mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr18.Text = ("") Else If x11.Text > pog18.Text Then r11kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r11kr18.Text = ("") Else r11kr18.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP18 * ymx11 / (Yfact * bp18mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr19.Text = ("") Else If x11.Text > pog19.Text Then r11kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r11kr19.Text = ("") Else r11kr19.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP19 * ymx11 / (Yfact * bp19mx11), 2)
        If x11.Text > sysoutofY.Text Then r11kr20.Text = ("") Else If x11.Text > pog20.Text Then r11kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r11kr20.Text = ("") Else r11kr20.Text = FormatNumber(AvrgKfc.Text ^ x11.Text * BP20 * ymx11 / (Yfact * bp20mx11), 2)

        If x12.Text > sysoutofY.Text Then r12kr0.Text = ("") Else If x12.Text > pog0.Text Then r12kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r12kr0.Text = ("") Else r12kr0.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP0 * ymx12 / (Yfact * bp0mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr1.Text = ("") Else If x12.Text > pog1.Text Then r12kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r12kr1.Text = ("") Else r12kr1.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP1 * ymx12 / (Yfact * bp1mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr2.Text = ("") Else If x12.Text > pog2.Text Then r12kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r12kr2.Text = ("") Else r12kr2.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP2 * ymx12 / (Yfact * bp2mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr3.Text = ("") Else If x12.Text > pog3.Text Then r12kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r12kr3.Text = ("") Else r12kr3.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP3 * ymx12 / (Yfact * bp3mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr4.Text = ("") Else If x12.Text > pog4.Text Then r12kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r12kr4.Text = ("") Else r12kr4.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP4 * ymx12 / (Yfact * bp4mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr5.Text = ("") Else If x12.Text > pog5.Text Then r12kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r12kr5.Text = ("") Else r12kr5.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP5 * ymx12 / (Yfact * bp5mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr6.Text = ("") Else If x12.Text > pog6.Text Then r12kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r12kr6.Text = ("") Else r12kr6.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP6 * ymx12 / (Yfact * bp6mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr7.Text = ("") Else If x12.Text > pog7.Text Then r12kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r12kr7.Text = ("") Else r12kr7.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP7 * ymx12 / (Yfact * bp7mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr8.Text = ("") Else If x12.Text > pog8.Text Then r12kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r12kr8.Text = ("") Else r12kr8.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP8 * ymx12 / (Yfact * bp8mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr9.Text = ("") Else If x12.Text > pog9.Text Then r12kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r12kr9.Text = ("") Else r12kr9.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP9 * ymx12 / (Yfact * bp9mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr10.Text = ("") Else If x12.Text > pog10.Text Then r12kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r12kr10.Text = ("") Else r12kr10.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP10 * ymx12 / (Yfact * bp10mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr11.Text = ("") Else If x12.Text > pog11.Text Then r12kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r12kr11.Text = ("") Else r12kr11.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP11 * ymx12 / (Yfact * bp11mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr12.Text = ("") Else If x12.Text > pog12.Text Then r12kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r12kr12.Text = ("") Else r12kr12.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP12 * ymx12 / (Yfact * bp12mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr13.Text = ("") Else If x12.Text > pog13.Text Then r12kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r12kr13.Text = ("") Else r12kr13.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP13 * ymx12 / (Yfact * bp13mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr14.Text = ("") Else If x12.Text > pog14.Text Then r12kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r12kr14.Text = ("") Else r12kr14.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP14 * ymx12 / (Yfact * bp14mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr15.Text = ("") Else If x12.Text > pog15.Text Then r12kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r12kr15.Text = ("") Else r12kr15.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP15 * ymx12 / (Yfact * bp15mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr16.Text = ("") Else If x12.Text > pog16.Text Then r12kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r12kr16.Text = ("") Else r12kr16.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP16 * ymx12 / (Yfact * bp16mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr17.Text = ("") Else If x12.Text > pog17.Text Then r12kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r12kr17.Text = ("") Else r12kr17.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP17 * ymx12 / (Yfact * bp17mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr18.Text = ("") Else If x12.Text > pog18.Text Then r12kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r12kr18.Text = ("") Else r12kr18.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP18 * ymx12 / (Yfact * bp18mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr19.Text = ("") Else If x12.Text > pog19.Text Then r12kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r12kr19.Text = ("") Else r12kr19.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP19 * ymx12 / (Yfact * bp19mx12), 2)
        If x12.Text > sysoutofY.Text Then r12kr20.Text = ("") Else If x12.Text > pog20.Text Then r12kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r12kr20.Text = ("") Else r12kr20.Text = FormatNumber(AvrgKfc.Text ^ x12.Text * BP20 * ymx12 / (Yfact * bp20mx12), 2)

        If x13.Text > sysoutofY.Text Then r13kr0.Text = ("") Else If x13.Text > pog0.Text Then r13kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r13kr0.Text = ("") Else r13kr0.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP0 * ymx13 / (Yfact * bp0mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr1.Text = ("") Else If x13.Text > pog1.Text Then r13kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r13kr1.Text = ("") Else r13kr1.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP1 * ymx13 / (Yfact * bp1mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr2.Text = ("") Else If x13.Text > pog2.Text Then r13kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r13kr2.Text = ("") Else r13kr2.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP2 * ymx13 / (Yfact * bp2mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr3.Text = ("") Else If x13.Text > pog3.Text Then r13kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r13kr3.Text = ("") Else r13kr3.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP3 * ymx13 / (Yfact * bp3mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr4.Text = ("") Else If x13.Text > pog4.Text Then r13kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r13kr4.Text = ("") Else r13kr4.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP4 * ymx13 / (Yfact * bp4mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr5.Text = ("") Else If x13.Text > pog5.Text Then r13kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r13kr5.Text = ("") Else r13kr5.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP5 * ymx13 / (Yfact * bp5mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr6.Text = ("") Else If x13.Text > pog6.Text Then r13kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r13kr6.Text = ("") Else r13kr6.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP6 * ymx13 / (Yfact * bp6mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr7.Text = ("") Else If x13.Text > pog7.Text Then r13kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r13kr7.Text = ("") Else r13kr7.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP7 * ymx13 / (Yfact * bp7mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr8.Text = ("") Else If x13.Text > pog8.Text Then r13kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r13kr8.Text = ("") Else r13kr8.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP8 * ymx13 / (Yfact * bp8mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr9.Text = ("") Else If x13.Text > pog9.Text Then r13kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r13kr9.Text = ("") Else r13kr9.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP9 * ymx13 / (Yfact * bp9mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr10.Text = ("") Else If x13.Text > pog10.Text Then r13kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r13kr10.Text = ("") Else r13kr10.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP10 * ymx13 / (Yfact * bp10mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr11.Text = ("") Else If x13.Text > pog11.Text Then r13kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r13kr11.Text = ("") Else r13kr11.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP11 * ymx13 / (Yfact * bp11mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr12.Text = ("") Else If x13.Text > pog12.Text Then r13kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r13kr12.Text = ("") Else r13kr12.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP12 * ymx13 / (Yfact * bp12mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr13.Text = ("") Else If x13.Text > pog13.Text Then r13kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r13kr13.Text = ("") Else r13kr13.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP13 * ymx13 / (Yfact * bp13mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr14.Text = ("") Else If x13.Text > pog14.Text Then r13kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r13kr14.Text = ("") Else r13kr14.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP14 * ymx13 / (Yfact * bp14mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr15.Text = ("") Else If x13.Text > pog15.Text Then r13kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r13kr15.Text = ("") Else r13kr15.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP15 * ymx13 / (Yfact * bp15mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr16.Text = ("") Else If x13.Text > pog16.Text Then r13kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r13kr16.Text = ("") Else r13kr16.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP16 * ymx13 / (Yfact * bp16mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr17.Text = ("") Else If x13.Text > pog17.Text Then r13kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r13kr17.Text = ("") Else r13kr17.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP17 * ymx13 / (Yfact * bp17mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr18.Text = ("") Else If x13.Text > pog18.Text Then r13kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r13kr18.Text = ("") Else r13kr18.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP18 * ymx13 / (Yfact * bp18mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr19.Text = ("") Else If x13.Text > pog19.Text Then r13kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r13kr19.Text = ("") Else r13kr19.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP19 * ymx13 / (Yfact * bp19mx13), 2)
        If x13.Text > sysoutofY.Text Then r13kr20.Text = ("") Else If x13.Text > pog20.Text Then r13kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r13kr20.Text = ("") Else r13kr20.Text = FormatNumber(AvrgKfc.Text ^ x13.Text * BP20 * ymx13 / (Yfact * bp20mx13), 2)

        If x14.Text > sysoutofY.Text Then r14kr0.Text = ("") Else If x14.Text > pog0.Text Then r14kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r14kr0.Text = ("") Else r14kr0.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP0 * ymx14 / (Yfact * bp0mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr1.Text = ("") Else If x14.Text > pog1.Text Then r14kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r14kr1.Text = ("") Else r14kr1.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP1 * ymx14 / (Yfact * bp1mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr2.Text = ("") Else If x14.Text > pog2.Text Then r14kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r14kr2.Text = ("") Else r14kr2.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP2 * ymx14 / (Yfact * bp2mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr3.Text = ("") Else If x14.Text > pog3.Text Then r14kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r14kr3.Text = ("") Else r14kr3.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP3 * ymx14 / (Yfact * bp3mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr4.Text = ("") Else If x14.Text > pog4.Text Then r14kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r14kr4.Text = ("") Else r14kr4.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP4 * ymx14 / (Yfact * bp4mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr5.Text = ("") Else If x14.Text > pog5.Text Then r14kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r14kr5.Text = ("") Else r14kr5.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP5 * ymx14 / (Yfact * bp5mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr6.Text = ("") Else If x14.Text > pog6.Text Then r14kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r14kr6.Text = ("") Else r14kr6.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP6 * ymx14 / (Yfact * bp6mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr7.Text = ("") Else If x14.Text > pog7.Text Then r14kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r14kr7.Text = ("") Else r14kr7.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP7 * ymx14 / (Yfact * bp7mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr8.Text = ("") Else If x14.Text > pog8.Text Then r14kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r14kr8.Text = ("") Else r14kr8.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP8 * ymx14 / (Yfact * bp8mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr9.Text = ("") Else If x14.Text > pog9.Text Then r14kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r14kr9.Text = ("") Else r14kr9.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP9 * ymx14 / (Yfact * bp9mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr10.Text = ("") Else If x14.Text > pog10.Text Then r14kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r14kr10.Text = ("") Else r14kr10.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP10 * ymx14 / (Yfact * bp10mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr11.Text = ("") Else If x14.Text > pog11.Text Then r14kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r14kr11.Text = ("") Else r14kr11.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP11 * ymx14 / (Yfact * bp11mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr12.Text = ("") Else If x14.Text > pog12.Text Then r14kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r14kr12.Text = ("") Else r14kr12.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP12 * ymx14 / (Yfact * bp12mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr13.Text = ("") Else If x14.Text > pog13.Text Then r14kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r14kr13.Text = ("") Else r14kr13.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP13 * ymx14 / (Yfact * bp13mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr14.Text = ("") Else If x14.Text > pog14.Text Then r14kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r14kr14.Text = ("") Else r14kr14.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP14 * ymx14 / (Yfact * bp14mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr15.Text = ("") Else If x14.Text > pog15.Text Then r14kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r14kr15.Text = ("") Else r14kr15.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP15 * ymx14 / (Yfact * bp15mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr16.Text = ("") Else If x14.Text > pog16.Text Then r14kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r14kr16.Text = ("") Else r14kr16.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP16 * ymx14 / (Yfact * bp16mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr17.Text = ("") Else If x14.Text > pog17.Text Then r14kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r14kr17.Text = ("") Else r14kr17.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP17 * ymx14 / (Yfact * bp17mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr18.Text = ("") Else If x14.Text > pog18.Text Then r14kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r14kr18.Text = ("") Else r14kr18.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP18 * ymx14 / (Yfact * bp18mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr19.Text = ("") Else If x14.Text > pog19.Text Then r14kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r14kr19.Text = ("") Else r14kr19.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP19 * ymx14 / (Yfact * bp19mx14), 2)
        If x14.Text > sysoutofY.Text Then r14kr20.Text = ("") Else If x14.Text > pog20.Text Then r14kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r14kr20.Text = ("") Else r14kr20.Text = FormatNumber(AvrgKfc.Text ^ x14.Text * BP20 * ymx14 / (Yfact * bp20mx14), 2)

        If x15.Text > sysoutofY.Text Then r15kr0.Text = ("") Else If x15.Text > pog0.Text Then r15kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r15kr0.Text = ("") Else r15kr0.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP0 * ymx15 / (Yfact * bp0mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr1.Text = ("") Else If x15.Text > pog1.Text Then r15kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r15kr1.Text = ("") Else r15kr1.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP1 * ymx15 / (Yfact * bp1mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr2.Text = ("") Else If x15.Text > pog2.Text Then r15kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r15kr2.Text = ("") Else r15kr2.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP2 * ymx15 / (Yfact * bp2mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr3.Text = ("") Else If x15.Text > pog3.Text Then r15kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r15kr3.Text = ("") Else r15kr3.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP3 * ymx15 / (Yfact * bp3mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr4.Text = ("") Else If x15.Text > pog4.Text Then r15kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r15kr4.Text = ("") Else r15kr4.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP4 * ymx15 / (Yfact * bp4mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr5.Text = ("") Else If x15.Text > pog5.Text Then r15kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r15kr5.Text = ("") Else r15kr5.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP5 * ymx15 / (Yfact * bp5mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr6.Text = ("") Else If x15.Text > pog6.Text Then r15kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r15kr6.Text = ("") Else r15kr6.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP6 * ymx15 / (Yfact * bp6mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr7.Text = ("") Else If x15.Text > pog7.Text Then r15kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r15kr7.Text = ("") Else r15kr7.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP7 * ymx15 / (Yfact * bp7mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr8.Text = ("") Else If x15.Text > pog8.Text Then r15kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r15kr8.Text = ("") Else r15kr8.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP8 * ymx15 / (Yfact * bp8mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr9.Text = ("") Else If x15.Text > pog9.Text Then r15kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r15kr9.Text = ("") Else r15kr9.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP9 * ymx15 / (Yfact * bp9mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr10.Text = ("") Else If x15.Text > pog10.Text Then r15kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r15kr10.Text = ("") Else r15kr10.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP10 * ymx15 / (Yfact * bp10mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr11.Text = ("") Else If x15.Text > pog11.Text Then r15kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r15kr11.Text = ("") Else r15kr11.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP11 * ymx15 / (Yfact * bp11mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr12.Text = ("") Else If x15.Text > pog12.Text Then r15kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r15kr12.Text = ("") Else r15kr12.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP12 * ymx15 / (Yfact * bp12mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr13.Text = ("") Else If x15.Text > pog13.Text Then r15kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r15kr13.Text = ("") Else r15kr13.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP13 * ymx15 / (Yfact * bp13mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr14.Text = ("") Else If x15.Text > pog14.Text Then r15kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r15kr14.Text = ("") Else r15kr14.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP14 * ymx15 / (Yfact * bp14mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr15.Text = ("") Else If x15.Text > pog15.Text Then r15kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r15kr15.Text = ("") Else r15kr15.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP15 * ymx15 / (Yfact * bp15mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr16.Text = ("") Else If x15.Text > pog16.Text Then r15kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r15kr16.Text = ("") Else r15kr16.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP16 * ymx15 / (Yfact * bp16mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr17.Text = ("") Else If x15.Text > pog17.Text Then r15kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r15kr17.Text = ("") Else r15kr17.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP17 * ymx15 / (Yfact * bp17mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr18.Text = ("") Else If x15.Text > pog18.Text Then r15kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r15kr18.Text = ("") Else r15kr18.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP18 * ymx15 / (Yfact * bp18mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr19.Text = ("") Else If x15.Text > pog19.Text Then r15kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r15kr19.Text = ("") Else r15kr19.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP19 * ymx15 / (Yfact * bp19mx15), 2)
        If x15.Text > sysoutofY.Text Then r15kr20.Text = ("") Else If x15.Text > pog20.Text Then r15kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r15kr20.Text = ("") Else r15kr20.Text = FormatNumber(AvrgKfc.Text ^ x15.Text * BP20 * ymx15 / (Yfact * bp20mx15), 2)

        If x16.Text > sysoutofY.Text Then r16kr0.Text = ("") Else If x16.Text > pog0.Text Then r16kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r16kr0.Text = ("") Else r16kr0.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP0 * ymx16 / (Yfact * bp0mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr1.Text = ("") Else If x16.Text > pog1.Text Then r16kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r16kr1.Text = ("") Else r16kr1.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP1 * ymx16 / (Yfact * bp1mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr2.Text = ("") Else If x16.Text > pog2.Text Then r16kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r16kr2.Text = ("") Else r16kr2.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP2 * ymx16 / (Yfact * bp2mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr3.Text = ("") Else If x16.Text > pog3.Text Then r16kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r16kr3.Text = ("") Else r16kr3.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP3 * ymx16 / (Yfact * bp3mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr4.Text = ("") Else If x16.Text > pog4.Text Then r16kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r16kr4.Text = ("") Else r16kr4.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP4 * ymx16 / (Yfact * bp4mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr5.Text = ("") Else If x16.Text > pog5.Text Then r16kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r16kr5.Text = ("") Else r16kr5.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP5 * ymx16 / (Yfact * bp5mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr6.Text = ("") Else If x16.Text > pog6.Text Then r16kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r16kr6.Text = ("") Else r16kr6.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP6 * ymx16 / (Yfact * bp6mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr7.Text = ("") Else If x16.Text > pog7.Text Then r16kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r16kr7.Text = ("") Else r16kr7.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP7 * ymx16 / (Yfact * bp7mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr8.Text = ("") Else If x16.Text > pog8.Text Then r16kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r16kr8.Text = ("") Else r16kr8.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP8 * ymx16 / (Yfact * bp8mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr9.Text = ("") Else If x16.Text > pog9.Text Then r16kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r16kr9.Text = ("") Else r16kr9.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP9 * ymx16 / (Yfact * bp9mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr10.Text = ("") Else If x16.Text > pog10.Text Then r16kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r16kr10.Text = ("") Else r16kr10.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP10 * ymx16 / (Yfact * bp10mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr11.Text = ("") Else If x16.Text > pog11.Text Then r16kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r16kr11.Text = ("") Else r16kr11.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP11 * ymx16 / (Yfact * bp11mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr12.Text = ("") Else If x16.Text > pog12.Text Then r16kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r16kr12.Text = ("") Else r16kr12.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP12 * ymx16 / (Yfact * bp12mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr13.Text = ("") Else If x16.Text > pog13.Text Then r16kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r16kr13.Text = ("") Else r16kr13.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP13 * ymx16 / (Yfact * bp13mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr14.Text = ("") Else If x16.Text > pog14.Text Then r16kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r16kr14.Text = ("") Else r16kr14.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP14 * ymx16 / (Yfact * bp14mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr15.Text = ("") Else If x16.Text > pog15.Text Then r16kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r16kr15.Text = ("") Else r16kr15.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP15 * ymx16 / (Yfact * bp15mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr16.Text = ("") Else If x16.Text > pog16.Text Then r16kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r16kr16.Text = ("") Else r16kr16.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP16 * ymx16 / (Yfact * bp16mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr17.Text = ("") Else If x16.Text > pog17.Text Then r16kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r16kr17.Text = ("") Else r16kr17.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP17 * ymx16 / (Yfact * bp17mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr18.Text = ("") Else If x16.Text > pog18.Text Then r16kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r16kr18.Text = ("") Else r16kr18.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP18 * ymx16 / (Yfact * bp18mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr19.Text = ("") Else If x16.Text > pog19.Text Then r16kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r16kr19.Text = ("") Else r16kr19.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP19 * ymx16 / (Yfact * bp19mx16), 2)
        If x16.Text > sysoutofY.Text Then r16kr20.Text = ("") Else If x16.Text > pog20.Text Then r16kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r16kr20.Text = ("") Else r16kr20.Text = FormatNumber(AvrgKfc.Text ^ x16.Text * BP20 * ymx16 / (Yfact * bp20mx16), 2)

        If x17.Text > sysoutofY.Text Then r17kr0.Text = ("") Else If x17.Text > pog0.Text Then r17kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r17kr0.Text = ("") Else r17kr0.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP0 * ymx17 / (Yfact * bp0mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr1.Text = ("") Else If x17.Text > pog1.Text Then r17kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r17kr1.Text = ("") Else r17kr1.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP1 * ymx17 / (Yfact * bp1mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr2.Text = ("") Else If x17.Text > pog2.Text Then r17kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r17kr2.Text = ("") Else r17kr2.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP2 * ymx17 / (Yfact * bp2mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr3.Text = ("") Else If x17.Text > pog3.Text Then r17kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r17kr3.Text = ("") Else r17kr3.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP3 * ymx17 / (Yfact * bp3mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr4.Text = ("") Else If x17.Text > pog4.Text Then r17kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r17kr4.Text = ("") Else r17kr4.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP4 * ymx17 / (Yfact * bp4mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr5.Text = ("") Else If x17.Text > pog5.Text Then r17kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r17kr5.Text = ("") Else r17kr5.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP5 * ymx17 / (Yfact * bp5mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr6.Text = ("") Else If x17.Text > pog6.Text Then r17kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r17kr6.Text = ("") Else r17kr6.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP6 * ymx17 / (Yfact * bp6mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr7.Text = ("") Else If x17.Text > pog7.Text Then r17kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r17kr7.Text = ("") Else r17kr7.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP7 * ymx17 / (Yfact * bp7mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr8.Text = ("") Else If x17.Text > pog8.Text Then r17kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r17kr8.Text = ("") Else r17kr8.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP8 * ymx17 / (Yfact * bp8mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr9.Text = ("") Else If x17.Text > pog9.Text Then r17kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r17kr9.Text = ("") Else r17kr9.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP9 * ymx17 / (Yfact * bp9mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr10.Text = ("") Else If x17.Text > pog10.Text Then r17kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r17kr10.Text = ("") Else r17kr10.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP10 * ymx17 / (Yfact * bp10mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr11.Text = ("") Else If x17.Text > pog11.Text Then r17kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r17kr11.Text = ("") Else r17kr11.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP11 * ymx17 / (Yfact * bp11mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr12.Text = ("") Else If x17.Text > pog12.Text Then r17kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r17kr12.Text = ("") Else r17kr12.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP12 * ymx17 / (Yfact * bp12mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr13.Text = ("") Else If x17.Text > pog13.Text Then r17kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r17kr13.Text = ("") Else r17kr13.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP13 * ymx17 / (Yfact * bp13mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr14.Text = ("") Else If x17.Text > pog14.Text Then r17kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r17kr14.Text = ("") Else r17kr14.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP14 * ymx17 / (Yfact * bp14mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr15.Text = ("") Else If x17.Text > pog15.Text Then r17kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r17kr15.Text = ("") Else r17kr15.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP15 * ymx17 / (Yfact * bp15mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr16.Text = ("") Else If x17.Text > pog16.Text Then r17kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r17kr16.Text = ("") Else r17kr16.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP16 * ymx17 / (Yfact * bp16mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr17.Text = ("") Else If x17.Text > pog17.Text Then r17kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r17kr17.Text = ("") Else r17kr17.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP17 * ymx17 / (Yfact * bp17mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr18.Text = ("") Else If x17.Text > pog18.Text Then r17kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r17kr18.Text = ("") Else r17kr18.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP18 * ymx17 / (Yfact * bp18mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr19.Text = ("") Else If x17.Text > pog19.Text Then r17kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r17kr19.Text = ("") Else r17kr19.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP19 * ymx17 / (Yfact * bp19mx17), 2)
        If x17.Text > sysoutofY.Text Then r17kr20.Text = ("") Else If x17.Text > pog20.Text Then r17kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r17kr20.Text = ("") Else r17kr20.Text = FormatNumber(AvrgKfc.Text ^ x17.Text * BP20 * ymx17 / (Yfact * bp20mx17), 2)

        If x18.Text > sysoutofY.Text Then r18kr0.Text = ("") Else If x18.Text > pog0.Text Then r18kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r18kr0.Text = ("") Else r18kr0.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP0 * ymx18 / (Yfact * bp0mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr1.Text = ("") Else If x18.Text > pog1.Text Then r18kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r18kr1.Text = ("") Else r18kr1.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP1 * ymx18 / (Yfact * bp1mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr2.Text = ("") Else If x18.Text > pog2.Text Then r18kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r18kr2.Text = ("") Else r18kr2.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP2 * ymx18 / (Yfact * bp2mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr3.Text = ("") Else If x18.Text > pog3.Text Then r18kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r18kr3.Text = ("") Else r18kr3.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP3 * ymx18 / (Yfact * bp3mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr4.Text = ("") Else If x18.Text > pog4.Text Then r18kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r18kr4.Text = ("") Else r18kr4.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP4 * ymx18 / (Yfact * bp4mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr5.Text = ("") Else If x18.Text > pog5.Text Then r18kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r18kr5.Text = ("") Else r18kr5.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP5 * ymx18 / (Yfact * bp5mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr6.Text = ("") Else If x18.Text > pog6.Text Then r18kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r18kr6.Text = ("") Else r18kr6.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP6 * ymx18 / (Yfact * bp6mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr7.Text = ("") Else If x18.Text > pog7.Text Then r18kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r18kr7.Text = ("") Else r18kr7.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP7 * ymx18 / (Yfact * bp7mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr8.Text = ("") Else If x18.Text > pog8.Text Then r18kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r18kr8.Text = ("") Else r18kr8.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP8 * ymx18 / (Yfact * bp8mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr9.Text = ("") Else If x18.Text > pog9.Text Then r18kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r18kr9.Text = ("") Else r18kr9.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP9 * ymx18 / (Yfact * bp9mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr10.Text = ("") Else If x18.Text > pog10.Text Then r18kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r18kr10.Text = ("") Else r18kr10.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP10 * ymx18 / (Yfact * bp10mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr11.Text = ("") Else If x18.Text > pog11.Text Then r18kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r18kr11.Text = ("") Else r18kr11.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP11 * ymx18 / (Yfact * bp11mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr12.Text = ("") Else If x18.Text > pog12.Text Then r18kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r18kr12.Text = ("") Else r18kr12.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP12 * ymx18 / (Yfact * bp12mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr13.Text = ("") Else If x18.Text > pog13.Text Then r18kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r18kr13.Text = ("") Else r18kr13.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP13 * ymx18 / (Yfact * bp13mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr14.Text = ("") Else If x18.Text > pog14.Text Then r18kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r18kr14.Text = ("") Else r18kr14.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP14 * ymx18 / (Yfact * bp14mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr15.Text = ("") Else If x18.Text > pog15.Text Then r18kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r18kr15.Text = ("") Else r18kr15.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP15 * ymx18 / (Yfact * bp15mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr16.Text = ("") Else If x18.Text > pog16.Text Then r18kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r18kr16.Text = ("") Else r18kr16.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP16 * ymx18 / (Yfact * bp16mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr17.Text = ("") Else If x18.Text > pog17.Text Then r18kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r18kr17.Text = ("") Else r18kr17.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP17 * ymx18 / (Yfact * bp17mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr18.Text = ("") Else If x18.Text > pog18.Text Then r18kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r18kr18.Text = ("") Else r18kr18.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP18 * ymx18 / (Yfact * bp18mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr19.Text = ("") Else If x18.Text > pog19.Text Then r18kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r18kr19.Text = ("") Else r18kr19.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP19 * ymx18 / (Yfact * bp19mx18), 2)
        If x18.Text > sysoutofY.Text Then r18kr20.Text = ("") Else If x18.Text > pog20.Text Then r18kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r18kr20.Text = ("") Else r18kr20.Text = FormatNumber(AvrgKfc.Text ^ x18.Text * BP20 * ymx18 / (Yfact * bp20mx18), 2)

        If x19.Text > sysoutofY.Text Then r19kr0.Text = ("") Else If x19.Text > pog0.Text Then r19kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r19kr0.Text = ("") Else r19kr0.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP0 * ymx19 / (Yfact * bp0mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr1.Text = ("") Else If x19.Text > pog1.Text Then r19kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r19kr1.Text = ("") Else r19kr1.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP1 * ymx19 / (Yfact * bp1mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr2.Text = ("") Else If x19.Text > pog2.Text Then r19kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r19kr2.Text = ("") Else r19kr2.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP2 * ymx19 / (Yfact * bp2mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr3.Text = ("") Else If x19.Text > pog3.Text Then r19kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r19kr3.Text = ("") Else r19kr3.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP3 * ymx19 / (Yfact * bp3mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr4.Text = ("") Else If x19.Text > pog4.Text Then r19kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r19kr4.Text = ("") Else r19kr4.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP4 * ymx19 / (Yfact * bp4mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr5.Text = ("") Else If x19.Text > pog5.Text Then r19kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r19kr5.Text = ("") Else r19kr5.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP5 * ymx19 / (Yfact * bp5mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr6.Text = ("") Else If x19.Text > pog6.Text Then r19kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r19kr6.Text = ("") Else r19kr6.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP6 * ymx19 / (Yfact * bp6mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr7.Text = ("") Else If x19.Text > pog7.Text Then r19kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r19kr7.Text = ("") Else r19kr7.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP7 * ymx19 / (Yfact * bp7mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr8.Text = ("") Else If x19.Text > pog8.Text Then r19kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r19kr8.Text = ("") Else r19kr8.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP8 * ymx19 / (Yfact * bp8mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr9.Text = ("") Else If x19.Text > pog9.Text Then r19kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r19kr9.Text = ("") Else r19kr9.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP9 * ymx19 / (Yfact * bp9mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr10.Text = ("") Else If x19.Text > pog10.Text Then r19kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r19kr10.Text = ("") Else r19kr10.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP10 * ymx19 / (Yfact * bp10mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr11.Text = ("") Else If x19.Text > pog11.Text Then r19kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r19kr11.Text = ("") Else r19kr11.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP11 * ymx19 / (Yfact * bp11mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr12.Text = ("") Else If x19.Text > pog12.Text Then r19kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r19kr12.Text = ("") Else r19kr12.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP12 * ymx19 / (Yfact * bp12mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr13.Text = ("") Else If x19.Text > pog13.Text Then r19kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r19kr13.Text = ("") Else r19kr13.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP13 * ymx19 / (Yfact * bp13mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr14.Text = ("") Else If x19.Text > pog14.Text Then r19kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r19kr14.Text = ("") Else r19kr14.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP14 * ymx19 / (Yfact * bp14mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr15.Text = ("") Else If x19.Text > pog15.Text Then r19kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r19kr15.Text = ("") Else r19kr15.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP15 * ymx19 / (Yfact * bp15mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr16.Text = ("") Else If x19.Text > pog16.Text Then r19kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r19kr16.Text = ("") Else r19kr16.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP16 * ymx19 / (Yfact * bp16mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr17.Text = ("") Else If x19.Text > pog17.Text Then r19kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r19kr17.Text = ("") Else r19kr17.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP17 * ymx19 / (Yfact * bp17mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr18.Text = ("") Else If x19.Text > pog18.Text Then r19kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r19kr18.Text = ("") Else r19kr18.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP18 * ymx19 / (Yfact * bp18mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr19.Text = ("") Else If x19.Text > pog19.Text Then r19kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r19kr19.Text = ("") Else r19kr19.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP19 * ymx19 / (Yfact * bp19mx19), 2)
        If x19.Text > sysoutofY.Text Then r19kr20.Text = ("") Else If x19.Text > pog20.Text Then r19kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r19kr20.Text = ("") Else r19kr20.Text = FormatNumber(AvrgKfc.Text ^ x19.Text * BP20 * ymx19 / (Yfact * bp20mx19), 2)

        If x20.Text > sysoutofY.Text Then r20kr0.Text = ("") Else If x20.Text > pog0.Text Then r20kr0.Text = 0 Else If pog0.Text > sysoutofY.Text Then r20kr0.Text = ("") Else r20kr0.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP0 * ymx20 / (Yfact * bp0mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr1.Text = ("") Else If x20.Text > pog1.Text Then r20kr1.Text = 0 Else If pog1.Text > sysoutofY.Text Then r20kr1.Text = ("") Else r20kr1.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP1 * ymx20 / (Yfact * bp1mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr2.Text = ("") Else If x20.Text > pog2.Text Then r20kr2.Text = 0 Else If pog2.Text > sysoutofY.Text Then r20kr2.Text = ("") Else r20kr2.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP2 * ymx20 / (Yfact * bp2mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr3.Text = ("") Else If x20.Text > pog3.Text Then r20kr3.Text = 0 Else If pog3.Text > sysoutofY.Text Then r20kr3.Text = ("") Else r20kr3.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP3 * ymx20 / (Yfact * bp3mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr4.Text = ("") Else If x20.Text > pog4.Text Then r20kr4.Text = 0 Else If pog4.Text > sysoutofY.Text Then r20kr4.Text = ("") Else r20kr4.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP4 * ymx20 / (Yfact * bp4mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr5.Text = ("") Else If x20.Text > pog5.Text Then r20kr5.Text = 0 Else If pog5.Text > sysoutofY.Text Then r20kr5.Text = ("") Else r20kr5.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP5 * ymx20 / (Yfact * bp5mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr6.Text = ("") Else If x20.Text > pog6.Text Then r20kr6.Text = 0 Else If pog6.Text > sysoutofY.Text Then r20kr6.Text = ("") Else r20kr6.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP6 * ymx20 / (Yfact * bp6mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr7.Text = ("") Else If x20.Text > pog7.Text Then r20kr7.Text = 0 Else If pog7.Text > sysoutofY.Text Then r20kr7.Text = ("") Else r20kr7.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP7 * ymx20 / (Yfact * bp7mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr8.Text = ("") Else If x20.Text > pog8.Text Then r20kr8.Text = 0 Else If pog8.Text > sysoutofY.Text Then r20kr8.Text = ("") Else r20kr8.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP8 * ymx20 / (Yfact * bp8mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr9.Text = ("") Else If x20.Text > pog9.Text Then r20kr9.Text = 0 Else If pog9.Text > sysoutofY.Text Then r20kr9.Text = ("") Else r20kr9.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP9 * ymx20 / (Yfact * bp9mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr10.Text = ("") Else If x20.Text > pog10.Text Then r20kr10.Text = 0 Else If pog10.Text > sysoutofY.Text Then r20kr10.Text = ("") Else r20kr10.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP10 * ymx20 / (Yfact * bp10mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr11.Text = ("") Else If x20.Text > pog11.Text Then r20kr11.Text = 0 Else If pog11.Text > sysoutofY.Text Then r20kr11.Text = ("") Else r20kr11.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP11 * ymx20 / (Yfact * bp11mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr12.Text = ("") Else If x20.Text > pog12.Text Then r20kr12.Text = 0 Else If pog12.Text > sysoutofY.Text Then r20kr12.Text = ("") Else r20kr12.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP12 * ymx20 / (Yfact * bp12mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr13.Text = ("") Else If x20.Text > pog13.Text Then r20kr13.Text = 0 Else If pog13.Text > sysoutofY.Text Then r20kr13.Text = ("") Else r20kr13.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP13 * ymx20 / (Yfact * bp13mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr14.Text = ("") Else If x20.Text > pog14.Text Then r20kr14.Text = 0 Else If pog14.Text > sysoutofY.Text Then r20kr14.Text = ("") Else r20kr14.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP14 * ymx20 / (Yfact * bp14mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr15.Text = ("") Else If x20.Text > pog15.Text Then r20kr15.Text = 0 Else If pog15.Text > sysoutofY.Text Then r20kr15.Text = ("") Else r20kr15.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP15 * ymx20 / (Yfact * bp15mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr16.Text = ("") Else If x20.Text > pog16.Text Then r20kr16.Text = 0 Else If pog16.Text > sysoutofY.Text Then r20kr16.Text = ("") Else r20kr16.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP16 * ymx20 / (Yfact * bp16mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr17.Text = ("") Else If x20.Text > pog17.Text Then r20kr17.Text = 0 Else If pog17.Text > sysoutofY.Text Then r20kr17.Text = ("") Else r20kr17.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP17 * ymx20 / (Yfact * bp17mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr18.Text = ("") Else If x20.Text > pog18.Text Then r20kr18.Text = 0 Else If pog18.Text > sysoutofY.Text Then r20kr18.Text = ("") Else r20kr18.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP18 * ymx20 / (Yfact * bp18mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr19.Text = ("") Else If x20.Text > pog19.Text Then r20kr19.Text = 0 Else If pog19.Text > sysoutofY.Text Then r20kr19.Text = ("") Else r20kr19.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP19 * ymx20 / (Yfact * bp19mx20), 2)
        If x20.Text > sysoutofY.Text Then r20kr20.Text = ("") Else If x20.Text > pog20.Text Then r20kr20.Text = 0 Else If pog20.Text > sysoutofY.Text Then r20kr20.Text = ("") Else r20kr20.Text = FormatNumber(AvrgKfc.Text ^ x20.Text * BP20 * ymx20 / (Yfact * bp20mx20), 2)


q1:     q1 = 0
        If r1kr1.Text = ("") Then GoTo Q2 Else If q1 > r1kr1.Text Then q1 = q1 Else q1 = r1kr1.Text
        If r2kr1.Text = ("") Then GoTo Q2 Else If q1 > r2kr1.Text Then q1 = q1 Else q1 = r2kr1.Text
        If r3kr1.Text = ("") Then GoTo Q2 Else If q1 > r3kr1.Text Then q1 = q1 Else q1 = r3kr1.Text
        If r4kr1.Text = ("") Then GoTo Q2 Else If q1 > r4kr1.Text Then q1 = q1 Else q1 = r4kr1.Text
        If r5kr1.Text = ("") Then GoTo Q2 Else If q1 > r5kr1.Text Then q1 = q1 Else q1 = r5kr1.Text
        If r6kr1.Text = ("") Then GoTo Q2 Else If q1 > r6kr1.Text Then q1 = q1 Else q1 = r6kr1.Text
        If r7kr1.Text = ("") Then GoTo Q2 Else If q1 > r7kr1.Text Then q1 = q1 Else q1 = r7kr1.Text
        If r8kr1.Text = ("") Then GoTo Q2 Else If q1 > r8kr1.Text Then q1 = q1 Else q1 = r8kr1.Text
        If r9kr1.Text = ("") Then GoTo Q2 Else If q1 > r9kr1.Text Then q1 = q1 Else q1 = r9kr1.Text
        If r10kr1.Text = ("") Then GoTo Q2 Else If q1 > r10kr1.Text Then q1 = q1 Else q1 = r10kr1.Text
        If r11kr1.Text = ("") Then GoTo Q2 Else If q1 > r11kr1.Text Then q1 = q1 Else q1 = r11kr1.Text
        If r12kr1.Text = ("") Then GoTo Q2 Else If q1 > r12kr1.Text Then q1 = q1 Else q1 = r12kr1.Text
        If r13kr1.Text = ("") Then GoTo Q2 Else If q1 > r13kr1.Text Then q1 = q1 Else q1 = r13kr1.Text
        If r14kr1.Text = ("") Then GoTo Q2 Else If q1 > r14kr1.Text Then q1 = q1 Else q1 = r14kr1.Text
        If r15kr1.Text = ("") Then GoTo Q2 Else If q1 > r15kr1.Text Then q1 = q1 Else q1 = r15kr1.Text
        If r16kr1.Text = ("") Then GoTo Q2 Else If q1 > r16kr1.Text Then q1 = q1 Else q1 = r16kr1.Text
        If r17kr1.Text = ("") Then GoTo Q2 Else If q1 > r17kr1.Text Then q1 = q1 Else q1 = r17kr1.Text
        If r18kr1.Text = ("") Then GoTo Q2 Else If q1 > r18kr1.Text Then q1 = q1 Else q1 = r18kr1.Text
        If r19kr1.Text = ("") Then GoTo Q2 Else If q1 > r19kr1.Text Then q1 = q1 Else q1 = r19kr1.Text
        If r20kr1.Text = ("") Then GoTo Q2 Else If q1 > r20kr1.Text Then q1 = q1 Else q1 = r20kr1.Text
Q2:     If r1kr1.Text = ("") Then GoTo Q2a Else If r1kr1.Text = q1 Then r1kr1.ForeColor = Drawing.Color.Red
        If r2kr1.Text = ("") Then GoTo Q2a Else If r2kr1.Text = q1 Then r2kr1.ForeColor = Drawing.Color.Red
        If r3kr1.Text = ("") Then GoTo Q2a Else If r3kr1.Text = q1 Then r3kr1.ForeColor = Drawing.Color.Red
        If r4kr1.Text = ("") Then GoTo Q2a Else If r4kr1.Text = q1 Then r4kr1.ForeColor = Drawing.Color.Red
        If r5kr1.Text = ("") Then GoTo Q2a Else If r5kr1.Text = q1 Then r5kr1.ForeColor = Drawing.Color.Red
        If r6kr1.Text = ("") Then GoTo Q2a Else If r6kr1.Text = q1 Then r6kr1.ForeColor = Drawing.Color.Red
        If r7kr1.Text = ("") Then GoTo Q2a Else If r7kr1.Text = q1 Then r7kr1.ForeColor = Drawing.Color.Red
        If r8kr1.Text = ("") Then GoTo Q2a Else If r8kr1.Text = q1 Then r8kr1.ForeColor = Drawing.Color.Red
        If r9kr1.Text = ("") Then GoTo Q2a Else If r9kr1.Text = q1 Then r9kr1.ForeColor = Drawing.Color.Red
        If r10kr1.Text = ("") Then GoTo Q2a Else If r10kr1.Text = q1 Then r10kr1.ForeColor = Drawing.Color.Red
        If r11kr1.Text = ("") Then GoTo Q2a Else If r11kr1.Text = q1 Then r11kr1.ForeColor = Drawing.Color.Red
        If r12kr1.Text = ("") Then GoTo Q2a Else If r12kr1.Text = q1 Then r12kr1.ForeColor = Drawing.Color.Red
        If r13kr1.Text = ("") Then GoTo Q2a Else If r13kr1.Text = q1 Then r13kr1.ForeColor = Drawing.Color.Red
        If r14kr1.Text = ("") Then GoTo Q2a Else If r14kr1.Text = q1 Then r14kr1.ForeColor = Drawing.Color.Red
        If r15kr1.Text = ("") Then GoTo Q2a Else If r15kr1.Text = q1 Then r15kr1.ForeColor = Drawing.Color.Red
        If r16kr1.Text = ("") Then GoTo Q2a Else If r16kr1.Text = q1 Then r16kr1.ForeColor = Drawing.Color.Red
        If r17kr1.Text = ("") Then GoTo Q2a Else If r17kr1.Text = q1 Then r17kr1.ForeColor = Drawing.Color.Red
        If r18kr1.Text = ("") Then GoTo Q2a Else If r18kr1.Text = q1 Then r18kr1.ForeColor = Drawing.Color.Red
        If r19kr1.Text = ("") Then GoTo Q2a Else If r19kr1.Text = q1 Then r19kr1.ForeColor = Drawing.Color.Red
        If r20kr1.Text = ("") Then GoTo Q2a Else If r20kr1.Text = q1 Then r20kr1.ForeColor = Drawing.Color.Red
Q2a:    q2 = 0
        If r1kr2.Text = ("") Then GoTo Q3 Else If q2 > r1kr2.Text Then q2 = q2 Else q2 = r1kr2.Text
        If r2kr2.Text = ("") Then GoTo Q3 Else If q2 > r2kr2.Text Then q2 = q2 Else q2 = r2kr2.Text
        If r3kr2.Text = ("") Then GoTo Q3 Else If q2 > r3kr2.Text Then q2 = q2 Else q2 = r3kr2.Text
        If r4kr2.Text = ("") Then GoTo Q3 Else If q2 > r4kr2.Text Then q2 = q2 Else q2 = r4kr2.Text
        If r5kr2.Text = ("") Then GoTo Q3 Else If q2 > r5kr2.Text Then q2 = q2 Else q2 = r5kr2.Text
        If r6kr2.Text = ("") Then GoTo Q3 Else If q2 > r6kr2.Text Then q2 = q2 Else q2 = r6kr2.Text
        If r7kr2.Text = ("") Then GoTo Q3 Else If q2 > r7kr2.Text Then q2 = q2 Else q2 = r7kr2.Text
        If r8kr2.Text = ("") Then GoTo Q3 Else If q2 > r8kr2.Text Then q2 = q2 Else q2 = r8kr2.Text
        If r9kr2.Text = ("") Then GoTo Q3 Else If q2 > r9kr2.Text Then q2 = q2 Else q2 = r9kr2.Text
        If r10kr2.Text = ("") Then GoTo Q3 Else If q2 > r10kr2.Text Then q2 = q2 Else q2 = r10kr2.Text
        If r11kr2.Text = ("") Then GoTo Q3 Else If q2 > r11kr2.Text Then q2 = q2 Else q2 = r11kr2.Text
        If r12kr2.Text = ("") Then GoTo Q3 Else If q2 > r12kr2.Text Then q2 = q2 Else q2 = r12kr2.Text
        If r13kr2.Text = ("") Then GoTo Q3 Else If q2 > r13kr2.Text Then q2 = q2 Else q2 = r13kr2.Text
        If r14kr2.Text = ("") Then GoTo Q3 Else If q2 > r14kr2.Text Then q2 = q2 Else q2 = r14kr2.Text
        If r15kr2.Text = ("") Then GoTo Q3 Else If q2 > r15kr2.Text Then q2 = q2 Else q2 = r15kr2.Text
        If r16kr2.Text = ("") Then GoTo Q3 Else If q2 > r16kr2.Text Then q2 = q2 Else q2 = r16kr2.Text
        If r17kr2.Text = ("") Then GoTo Q3 Else If q2 > r17kr2.Text Then q2 = q2 Else q2 = r17kr2.Text
        If r18kr2.Text = ("") Then GoTo Q3 Else If q2 > r18kr2.Text Then q2 = q2 Else q2 = r18kr2.Text
        If r19kr2.Text = ("") Then GoTo Q3 Else If q2 > r19kr2.Text Then q2 = q2 Else q2 = r19kr2.Text
        If r20kr2.Text = ("") Then GoTo Q3 Else If q2 > r20kr2.Text Then q2 = q2 Else q2 = r20kr2.Text
Q3:     If r1kr2.Text = ("") Then GoTo Q3a Else If r1kr2.Text = q2 Then r1kr2.ForeColor = Drawing.Color.Red
        If r2kr2.Text = ("") Then GoTo Q3a Else If r2kr2.Text = q2 Then r2kr2.ForeColor = Drawing.Color.Red
        If r3kr2.Text = ("") Then GoTo Q3a Else If r3kr2.Text = q2 Then r3kr2.ForeColor = Drawing.Color.Red
        If r4kr2.Text = ("") Then GoTo Q3a Else If r4kr2.Text = q2 Then r4kr2.ForeColor = Drawing.Color.Red
        If r5kr2.Text = ("") Then GoTo Q3a Else If r5kr2.Text = q2 Then r5kr2.ForeColor = Drawing.Color.Red
        If r6kr2.Text = ("") Then GoTo Q3a Else If r6kr2.Text = q2 Then r6kr2.ForeColor = Drawing.Color.Red
        If r7kr2.Text = ("") Then GoTo Q3a Else If r7kr2.Text = q2 Then r7kr2.ForeColor = Drawing.Color.Red
        If r8kr2.Text = ("") Then GoTo Q3a Else If r8kr2.Text = q2 Then r8kr2.ForeColor = Drawing.Color.Red
        If r9kr2.Text = ("") Then GoTo Q3a Else If r9kr2.Text = q2 Then r9kr2.ForeColor = Drawing.Color.Red
        If r10kr2.Text = ("") Then GoTo Q3a Else If r10kr2.Text = q2 Then r10kr2.ForeColor = Drawing.Color.Red
        If r11kr2.Text = ("") Then GoTo Q3a Else If r11kr2.Text = q2 Then r11kr2.ForeColor = Drawing.Color.Red
        If r13kr2.Text = ("") Then GoTo Q3a Else If r12kr2.Text = q2 Then r12kr2.ForeColor = Drawing.Color.Red
        If r14kr2.Text = ("") Then GoTo Q3a Else If r13kr2.Text = q2 Then r13kr2.ForeColor = Drawing.Color.Red
        If r15kr2.Text = ("") Then GoTo Q3a Else If r14kr2.Text = q2 Then r14kr2.ForeColor = Drawing.Color.Red
        If r16kr2.Text = ("") Then GoTo Q3a Else If r15kr2.Text = q2 Then r15kr2.ForeColor = Drawing.Color.Red
        If r17kr2.Text = ("") Then GoTo Q3a Else If r16kr2.Text = q2 Then r16kr2.ForeColor = Drawing.Color.Red
        If r18kr2.Text = ("") Then GoTo Q3a Else If r17kr2.Text = q2 Then r17kr2.ForeColor = Drawing.Color.Red
        If r19kr2.Text = ("") Then GoTo Q3a Else If r18kr2.Text = q2 Then r18kr2.ForeColor = Drawing.Color.Red
        If r20kr2.Text = ("") Then GoTo Q3a Else If r19kr2.Text = q2 Then r19kr2.ForeColor = Drawing.Color.Red
Q3a:    q3 = 0
        If r1kr3.Text = ("") Then GoTo Q4 Else If q3 > r1kr3.Text Then q3 = q3 Else q3 = r1kr3.Text
        If r2kr3.Text = ("") Then GoTo Q4 Else If q3 > r2kr3.Text Then q3 = q3 Else q3 = r2kr3.Text
        If r3kr3.Text = ("") Then GoTo Q4 Else If q3 > r3kr3.Text Then q3 = q3 Else q3 = r3kr3.Text
        If r4kr3.Text = ("") Then GoTo Q4 Else If q3 > r4kr3.Text Then q3 = q3 Else q3 = r4kr3.Text
        If r5kr3.Text = ("") Then GoTo Q4 Else If q3 > r5kr3.Text Then q3 = q3 Else q3 = r5kr3.Text
        If r6kr3.Text = ("") Then GoTo Q4 Else If q3 > r6kr3.Text Then q3 = q3 Else q3 = r6kr3.Text
        If r7kr3.Text = ("") Then GoTo Q4 Else If q3 > r7kr3.Text Then q3 = q3 Else q3 = r7kr3.Text
        If r8kr3.Text = ("") Then GoTo Q4 Else If q3 > r8kr3.Text Then q3 = q3 Else q3 = r8kr3.Text
        If r9kr3.Text = ("") Then GoTo Q4 Else If q3 > r9kr3.Text Then q3 = q3 Else q3 = r9kr3.Text
        If r10kr3.Text = ("") Then GoTo Q4 Else If q3 > r10kr3.Text Then q3 = q3 Else q3 = r10kr3.Text
        If r11kr3.Text = ("") Then GoTo Q4 Else If q3 > r11kr3.Text Then q3 = q3 Else q3 = r11kr3.Text
        If r12kr3.Text = ("") Then GoTo Q4 Else If q3 > r12kr3.Text Then q3 = q3 Else q3 = r12kr3.Text
        If r13kr3.Text = ("") Then GoTo Q4 Else If q3 > r13kr3.Text Then q3 = q3 Else q3 = r13kr3.Text
        If r14kr3.Text = ("") Then GoTo Q4 Else If q3 > r14kr3.Text Then q3 = q3 Else q3 = r14kr3.Text
        If r15kr3.Text = ("") Then GoTo Q4 Else If q3 > r15kr3.Text Then q3 = q3 Else q3 = r15kr3.Text
        If r16kr3.Text = ("") Then GoTo Q4 Else If q3 > r16kr3.Text Then q3 = q3 Else q3 = r16kr3.Text
        If r17kr3.Text = ("") Then GoTo Q4 Else If q3 > r17kr3.Text Then q3 = q3 Else q3 = r17kr3.Text
        If r18kr3.Text = ("") Then GoTo Q4 Else If q3 > r18kr3.Text Then q3 = q3 Else q3 = r18kr3.Text
        If r19kr3.Text = ("") Then GoTo Q4 Else If q3 > r19kr3.Text Then q3 = q3 Else q3 = r19kr3.Text
        If r20kr3.Text = ("") Then GoTo Q4 Else If q3 > r20kr3.Text Then q3 = q3 Else q3 = r20kr3.Text
Q4:     If r1kr3.Text = ("") Then GoTo Q4a Else If r1kr3.Text = q3 Then r1kr3.ForeColor = Drawing.Color.Red
        If r2kr3.Text = ("") Then GoTo Q4a Else If r2kr3.Text = q3 Then r2kr3.ForeColor = Drawing.Color.Red
        If r3kr3.Text = ("") Then GoTo Q4a Else If r3kr3.Text = q3 Then r3kr3.ForeColor = Drawing.Color.Red
        If r4kr3.Text = ("") Then GoTo Q4a Else If r4kr3.Text = q3 Then r4kr3.ForeColor = Drawing.Color.Red
        If r5kr3.Text = ("") Then GoTo Q4a Else If r5kr3.Text = q3 Then r5kr3.ForeColor = Drawing.Color.Red
        If r6kr3.Text = ("") Then GoTo Q4a Else If r6kr3.Text = q3 Then r6kr3.ForeColor = Drawing.Color.Red
        If r7kr3.Text = ("") Then GoTo Q4a Else If r7kr3.Text = q3 Then r7kr3.ForeColor = Drawing.Color.Red
        If r8kr3.Text = ("") Then GoTo Q4a Else If r8kr3.Text = q3 Then r8kr3.ForeColor = Drawing.Color.Red
        If r9kr3.Text = ("") Then GoTo Q4a Else If r9kr3.Text = q3 Then r9kr3.ForeColor = Drawing.Color.Red
        If r10kr3.Text = ("") Then GoTo Q4a Else If r10kr3.Text = q3 Then r10kr3.ForeColor = Drawing.Color.Red
        If r11kr3.Text = ("") Then GoTo Q4a Else If r11kr3.Text = q3 Then r11kr3.ForeColor = Drawing.Color.Red
        If r12kr3.Text = ("") Then GoTo Q4a Else If r12kr3.Text = q3 Then r12kr3.ForeColor = Drawing.Color.Red
        If r13kr3.Text = ("") Then GoTo Q4a Else If r13kr3.Text = q3 Then r13kr3.ForeColor = Drawing.Color.Red
        If r14kr3.Text = ("") Then GoTo Q4a Else If r14kr3.Text = q3 Then r14kr3.ForeColor = Drawing.Color.Red
        If r15kr3.Text = ("") Then GoTo Q4a Else If r15kr3.Text = q3 Then r15kr3.ForeColor = Drawing.Color.Red
        If r16kr3.Text = ("") Then GoTo Q4a Else If r16kr3.Text = q3 Then r16kr3.ForeColor = Drawing.Color.Red
        If r17kr3.Text = ("") Then GoTo Q4a Else If r17kr3.Text = q3 Then r17kr3.ForeColor = Drawing.Color.Red
        If r18kr3.Text = ("") Then GoTo Q4a Else If r18kr3.Text = q3 Then r18kr3.ForeColor = Drawing.Color.Red
        If r19kr3.Text = ("") Then GoTo Q4a Else If r19kr3.Text = q3 Then r19kr3.ForeColor = Drawing.Color.Red
        If r20kr3.Text = ("") Then GoTo Q4a Else If r20kr3.Text = q3 Then r20kr3.ForeColor = Drawing.Color.Red
Q4a:    q4 = 0
        If r1kr4.Text = ("") Then GoTo Q5 Else If q4 > r1kr4.Text Then q4 = q4 Else q4 = r1kr4.Text
        If r2kr4.Text = ("") Then GoTo Q5 Else If q4 > r2kr4.Text Then q4 = q4 Else q4 = r2kr4.Text
        If r3kr4.Text = ("") Then GoTo Q5 Else If q4 > r3kr4.Text Then q4 = q4 Else q4 = r3kr4.Text
        If r4kr4.Text = ("") Then GoTo Q5 Else If q4 > r4kr4.Text Then q4 = q4 Else q4 = r4kr4.Text
        If r5kr4.Text = ("") Then GoTo Q5 Else If q4 > r5kr4.Text Then q4 = q4 Else q4 = r5kr4.Text
        If r6kr4.Text = ("") Then GoTo Q5 Else If q4 > r6kr4.Text Then q4 = q4 Else q4 = r6kr4.Text
        If r7kr4.Text = ("") Then GoTo Q5 Else If q4 > r7kr4.Text Then q4 = q4 Else q4 = r7kr4.Text
        If r8kr4.Text = ("") Then GoTo Q5 Else If q4 > r8kr4.Text Then q4 = q4 Else q4 = r8kr4.Text
        If r9kr4.Text = ("") Then GoTo Q5 Else If q4 > r9kr4.Text Then q4 = q4 Else q4 = r9kr4.Text
        If r10kr4.Text = ("") Then GoTo Q5 Else If q4 > r10kr4.Text Then q4 = q4 Else q4 = r10kr4.Text
        If r11kr4.Text = ("") Then GoTo Q5 Else If q4 > r11kr4.Text Then q4 = q4 Else q4 = r11kr4.Text
        If r12kr4.Text = ("") Then GoTo Q5 Else If q4 > r12kr4.Text Then q4 = q4 Else q4 = r12kr4.Text
        If r13kr4.Text = ("") Then GoTo Q5 Else If q4 > r13kr4.Text Then q4 = q4 Else q4 = r13kr4.Text
        If r14kr4.Text = ("") Then GoTo Q5 Else If q4 > r14kr4.Text Then q4 = q4 Else q4 = r14kr4.Text
        If r15kr4.Text = ("") Then GoTo Q5 Else If q4 > r15kr4.Text Then q4 = q4 Else q4 = r15kr4.Text
        If r16kr4.Text = ("") Then GoTo Q5 Else If q4 > r16kr4.Text Then q4 = q4 Else q4 = r16kr4.Text
        If r17kr4.Text = ("") Then GoTo Q5 Else If q4 > r17kr4.Text Then q4 = q4 Else q4 = r17kr4.Text
        If r18kr4.Text = ("") Then GoTo Q5 Else If q4 > r18kr4.Text Then q4 = q4 Else q4 = r18kr4.Text
        If r19kr4.Text = ("") Then GoTo Q5 Else If q4 > r19kr4.Text Then q4 = q4 Else q4 = r19kr4.Text
        If r20kr4.Text = ("") Then GoTo Q5 Else If q4 > r20kr4.Text Then q4 = q4 Else q4 = r20kr4.Text
Q5:     If r1kr4.Text = ("") Then GoTo Q5a Else If r1kr4.Text = q4 Then r1kr4.ForeColor = Drawing.Color.Red
        If r2kr4.Text = ("") Then GoTo Q5a Else If r2kr4.Text = q4 Then r2kr4.ForeColor = Drawing.Color.Red
        If r3kr4.Text = ("") Then GoTo Q5a Else If r3kr4.Text = q4 Then r3kr4.ForeColor = Drawing.Color.Red
        If r4kr4.Text = ("") Then GoTo Q5a Else If r4kr4.Text = q4 Then r4kr4.ForeColor = Drawing.Color.Red
        If r5kr4.Text = ("") Then GoTo Q5a Else If r5kr4.Text = q4 Then r5kr4.ForeColor = Drawing.Color.Red
        If r6kr4.Text = ("") Then GoTo Q5a Else If r6kr4.Text = q4 Then r6kr4.ForeColor = Drawing.Color.Red
        If r7kr4.Text = ("") Then GoTo Q5a Else If r7kr4.Text = q4 Then r7kr4.ForeColor = Drawing.Color.Red
        If r8kr4.Text = ("") Then GoTo Q5a Else If r8kr4.Text = q4 Then r8kr4.ForeColor = Drawing.Color.Red
        If r9kr4.Text = ("") Then GoTo Q5a Else If r9kr4.Text = q4 Then r9kr4.ForeColor = Drawing.Color.Red
        If r10kr4.Text = ("") Then GoTo Q5a Else If r10kr4.Text = q4 Then r10kr4.ForeColor = Drawing.Color.Red
        If r11kr4.Text = ("") Then GoTo Q5a Else If r11kr4.Text = q4 Then r11kr4.ForeColor = Drawing.Color.Red
        If r12kr4.Text = ("") Then GoTo Q5a Else If r12kr4.Text = q4 Then r12kr4.ForeColor = Drawing.Color.Red
        If r13kr4.Text = ("") Then GoTo Q5a Else If r13kr4.Text = q4 Then r13kr4.ForeColor = Drawing.Color.Red
        If r14kr4.Text = ("") Then GoTo Q5a Else If r14kr4.Text = q4 Then r14kr4.ForeColor = Drawing.Color.Red
        If r15kr4.Text = ("") Then GoTo Q5a Else If r15kr4.Text = q4 Then r15kr4.ForeColor = Drawing.Color.Red
        If r16kr4.Text = ("") Then GoTo Q5a Else If r16kr4.Text = q4 Then r16kr4.ForeColor = Drawing.Color.Red
        If r17kr4.Text = ("") Then GoTo Q5a Else If r17kr4.Text = q4 Then r17kr4.ForeColor = Drawing.Color.Red
        If r18kr4.Text = ("") Then GoTo Q5a Else If r18kr4.Text = q4 Then r18kr4.ForeColor = Drawing.Color.Red
        If r19kr4.Text = ("") Then GoTo Q5a Else If r19kr4.Text = q4 Then r19kr4.ForeColor = Drawing.Color.Red
        If r20kr4.Text = ("") Then GoTo Q5a Else If r20kr4.Text = q4 Then r20kr4.ForeColor = Drawing.Color.Red
Q5a:    q5 = 0
        If r1kr5.Text = ("") Then GoTo Q6 Else If q5 > r1kr5.Text Then q5 = q5 Else q5 = r1kr5.Text
        If r2kr5.Text = ("") Then GoTo Q6 Else If q5 > r2kr5.Text Then q5 = q5 Else q5 = r2kr5.Text
        If r3kr5.Text = ("") Then GoTo Q6 Else If q5 > r3kr5.Text Then q5 = q5 Else q5 = r3kr5.Text
        If r4kr5.Text = ("") Then GoTo Q6 Else If q5 > r4kr5.Text Then q5 = q5 Else q5 = r4kr5.Text
        If r5kr5.Text = ("") Then GoTo Q6 Else If q5 > r5kr5.Text Then q5 = q5 Else q5 = r5kr5.Text
        If r6kr5.Text = ("") Then GoTo Q6 Else If q5 > r6kr5.Text Then q5 = q5 Else q5 = r6kr5.Text
        If r7kr5.Text = ("") Then GoTo Q6 Else If q5 > r7kr5.Text Then q5 = q5 Else q5 = r7kr5.Text
        If r8kr5.Text = ("") Then GoTo Q6 Else If q5 > r8kr5.Text Then q5 = q5 Else q5 = r8kr5.Text
        If r9kr5.Text = ("") Then GoTo Q6 Else If q5 > r9kr5.Text Then q5 = q5 Else q5 = r9kr5.Text
        If r10kr5.Text = ("") Then GoTo Q6 Else If q5 > r10kr5.Text Then q5 = q5 Else q5 = r10kr5.Text
        If r11kr5.Text = ("") Then GoTo Q6 Else If q5 > r11kr5.Text Then q5 = q5 Else q5 = r11kr5.Text
        If r12kr5.Text = ("") Then GoTo Q6 Else If q5 > r12kr5.Text Then q5 = q5 Else q5 = r12kr5.Text
        If r13kr5.Text = ("") Then GoTo Q6 Else If q5 > r13kr5.Text Then q5 = q5 Else q5 = r13kr5.Text
        If r14kr5.Text = ("") Then GoTo Q6 Else If q5 > r14kr5.Text Then q5 = q5 Else q5 = r14kr5.Text
        If r15kr5.Text = ("") Then GoTo Q6 Else If q5 > r15kr5.Text Then q5 = q5 Else q5 = r15kr5.Text
        If r16kr5.Text = ("") Then GoTo Q6 Else If q5 > r16kr5.Text Then q5 = q5 Else q5 = r16kr5.Text
        If r17kr5.Text = ("") Then GoTo Q6 Else If q5 > r17kr5.Text Then q5 = q5 Else q5 = r17kr5.Text
        If r18kr5.Text = ("") Then GoTo Q6 Else If q5 > r18kr5.Text Then q5 = q5 Else q5 = r18kr5.Text
        If r19kr5.Text = ("") Then GoTo Q6 Else If q5 > r19kr5.Text Then q5 = q5 Else q5 = r19kr5.Text
        If r20kr5.Text = ("") Then GoTo Q6 Else If q5 > r20kr5.Text Then q5 = q5 Else q5 = r20kr5.Text
Q6:     If r1kr5.Text = ("") Then GoTo Q6a Else If r1kr5.Text = q5 Then r1kr5.ForeColor = Drawing.Color.Red
        If r2kr5.Text = ("") Then GoTo Q6a Else If r2kr5.Text = q5 Then r2kr5.ForeColor = Drawing.Color.Red
        If r3kr5.Text = ("") Then GoTo Q6a Else If r3kr5.Text = q5 Then r3kr5.ForeColor = Drawing.Color.Red
        If r4kr5.Text = ("") Then GoTo Q6a Else If r4kr5.Text = q5 Then r4kr5.ForeColor = Drawing.Color.Red
        If r5kr5.Text = ("") Then GoTo Q6a Else If r5kr5.Text = q5 Then r5kr5.ForeColor = Drawing.Color.Red
        If r6kr5.Text = ("") Then GoTo Q6a Else If r6kr5.Text = q5 Then r6kr5.ForeColor = Drawing.Color.Red
        If r7kr5.Text = ("") Then GoTo Q6a Else If r7kr5.Text = q5 Then r7kr5.ForeColor = Drawing.Color.Red
        If r8kr5.Text = ("") Then GoTo Q6a Else If r8kr5.Text = q5 Then r8kr5.ForeColor = Drawing.Color.Red
        If r9kr5.Text = ("") Then GoTo Q6a Else If r9kr5.Text = q5 Then r9kr5.ForeColor = Drawing.Color.Red
        If r10kr5.Text = ("") Then GoTo Q6a Else If r10kr5.Text = q5 Then r10kr5.ForeColor = Drawing.Color.Red
        If r11kr5.Text = ("") Then GoTo Q6a Else If r11kr5.Text = q5 Then r11kr5.ForeColor = Drawing.Color.Red
        If r12kr5.Text = ("") Then GoTo Q6a Else If r12kr5.Text = q5 Then r12kr5.ForeColor = Drawing.Color.Red
        If r13kr5.Text = ("") Then GoTo Q6a Else If r13kr5.Text = q5 Then r13kr5.ForeColor = Drawing.Color.Red
        If r14kr5.Text = ("") Then GoTo Q6a Else If r14kr5.Text = q5 Then r14kr5.ForeColor = Drawing.Color.Red
        If r15kr5.Text = ("") Then GoTo Q6a Else If r15kr5.Text = q5 Then r15kr5.ForeColor = Drawing.Color.Red
        If r16kr5.Text = ("") Then GoTo Q6a Else If r16kr5.Text = q5 Then r16kr5.ForeColor = Drawing.Color.Red
        If r17kr5.Text = ("") Then GoTo Q6a Else If r17kr5.Text = q5 Then r17kr5.ForeColor = Drawing.Color.Red
        If r18kr5.Text = ("") Then GoTo Q6a Else If r18kr5.Text = q5 Then r18kr5.ForeColor = Drawing.Color.Red
        If r19kr5.Text = ("") Then GoTo Q6a Else If r19kr5.Text = q5 Then r19kr5.ForeColor = Drawing.Color.Red
        If r20kr5.Text = ("") Then GoTo Q6a Else If r20kr5.Text = q5 Then r20kr5.ForeColor = Drawing.Color.Red
Q6a:    q6 = 0
        If r1kr6.Text = ("") Then GoTo Q7 Else If q6 > r1kr6.Text Then q6 = q6 Else q6 = r1kr6.Text
        If r2kr6.Text = ("") Then GoTo Q7 Else If q6 > r2kr6.Text Then q6 = q6 Else q6 = r2kr6.Text
        If r3kr6.Text = ("") Then GoTo Q7 Else If q6 > r3kr6.Text Then q6 = q6 Else q6 = r3kr6.Text
        If r4kr6.Text = ("") Then GoTo Q7 Else If q6 > r4kr6.Text Then q6 = q6 Else q6 = r4kr6.Text
        If r5kr6.Text = ("") Then GoTo Q7 Else If q6 > r5kr6.Text Then q6 = q6 Else q6 = r5kr6.Text
        If r6kr6.Text = ("") Then GoTo Q7 Else If q6 > r6kr6.Text Then q6 = q6 Else q6 = r6kr6.Text
        If r7kr6.Text = ("") Then GoTo Q7 Else If q6 > r7kr6.Text Then q6 = q6 Else q6 = r7kr6.Text
        If r8kr6.Text = ("") Then GoTo Q7 Else If q6 > r8kr6.Text Then q6 = q6 Else q6 = r8kr6.Text
        If r9kr6.Text = ("") Then GoTo Q7 Else If q6 > r9kr6.Text Then q6 = q6 Else q6 = r9kr6.Text
        If r10kr6.Text = ("") Then GoTo Q7 Else If q6 > r10kr6.Text Then q6 = q6 Else q6 = r10kr6.Text
        If r11kr6.Text = ("") Then GoTo Q7 Else If q6 > r11kr6.Text Then q6 = q6 Else q6 = r11kr6.Text
        If r12kr6.Text = ("") Then GoTo Q7 Else If q6 > r12kr6.Text Then q6 = q6 Else q6 = r12kr6.Text
        If r13kr6.Text = ("") Then GoTo Q7 Else If q6 > r13kr6.Text Then q6 = q6 Else q6 = r13kr6.Text
        If r14kr6.Text = ("") Then GoTo Q7 Else If q6 > r14kr6.Text Then q6 = q6 Else q6 = r14kr6.Text
        If r15kr6.Text = ("") Then GoTo Q7 Else If q6 > r15kr6.Text Then q6 = q6 Else q6 = r15kr6.Text
        If r16kr6.Text = ("") Then GoTo Q7 Else If q6 > r16kr6.Text Then q6 = q6 Else q6 = r16kr6.Text
        If r17kr6.Text = ("") Then GoTo Q7 Else If q6 > r17kr6.Text Then q6 = q6 Else q6 = r17kr6.Text
        If r18kr6.Text = ("") Then GoTo Q7 Else If q6 > r18kr6.Text Then q6 = q6 Else q6 = r18kr6.Text
        If r19kr6.Text = ("") Then GoTo Q7 Else If q6 > r19kr6.Text Then q6 = q6 Else q6 = r19kr6.Text
        If r20kr6.Text = ("") Then GoTo Q7 Else If q6 > r20kr6.Text Then q6 = q6 Else q6 = r20kr6.Text
Q7:     If r1kr6.Text = ("") Then GoTo Q7a Else If r1kr6.Text = q6 Then r1kr6.ForeColor = Drawing.Color.Red
        If r2kr6.Text = ("") Then GoTo Q7a Else If r2kr6.Text = q6 Then r2kr6.ForeColor = Drawing.Color.Red
        If r3kr6.Text = ("") Then GoTo Q7a Else If r3kr6.Text = q6 Then r3kr6.ForeColor = Drawing.Color.Red
        If r4kr6.Text = ("") Then GoTo Q7a Else If r4kr6.Text = q6 Then r4kr6.ForeColor = Drawing.Color.Red
        If r5kr6.Text = ("") Then GoTo Q7a Else If r5kr6.Text = q6 Then r5kr6.ForeColor = Drawing.Color.Red
        If r6kr6.Text = ("") Then GoTo Q7a Else If r6kr6.Text = q6 Then r6kr6.ForeColor = Drawing.Color.Red
        If r7kr6.Text = ("") Then GoTo Q7a Else If r7kr6.Text = q6 Then r7kr6.ForeColor = Drawing.Color.Red
        If r8kr6.Text = ("") Then GoTo Q7a Else If r8kr6.Text = q6 Then r8kr6.ForeColor = Drawing.Color.Red
        If r9kr6.Text = ("") Then GoTo Q7a Else If r9kr6.Text = q6 Then r9kr6.ForeColor = Drawing.Color.Red
        If r10kr6.Text = ("") Then GoTo Q7a Else If r10kr6.Text = q6 Then r10kr6.ForeColor = Drawing.Color.Red
        If r11kr6.Text = ("") Then GoTo Q7a Else If r11kr6.Text = q6 Then r11kr6.ForeColor = Drawing.Color.Red
        If r12kr6.Text = ("") Then GoTo Q7a Else If r12kr6.Text = q6 Then r12kr6.ForeColor = Drawing.Color.Red
        If r13kr6.Text = ("") Then GoTo Q7a Else If r13kr6.Text = q6 Then r13kr6.ForeColor = Drawing.Color.Red
        If r14kr6.Text = ("") Then GoTo Q7a Else If r14kr6.Text = q6 Then r14kr6.ForeColor = Drawing.Color.Red
        If r15kr6.Text = ("") Then GoTo Q7a Else If r15kr6.Text = q6 Then r15kr6.ForeColor = Drawing.Color.Red
        If r16kr6.Text = ("") Then GoTo Q7a Else If r16kr6.Text = q6 Then r16kr6.ForeColor = Drawing.Color.Red
        If r17kr6.Text = ("") Then GoTo Q7a Else If r17kr6.Text = q6 Then r17kr6.ForeColor = Drawing.Color.Red
        If r18kr6.Text = ("") Then GoTo Q7a Else If r18kr6.Text = q6 Then r18kr6.ForeColor = Drawing.Color.Red
        If r19kr6.Text = ("") Then GoTo Q7a Else If r19kr6.Text = q6 Then r19kr6.ForeColor = Drawing.Color.Red
        If r20kr6.Text = ("") Then GoTo Q7a Else If r20kr6.Text = q6 Then r20kr6.ForeColor = Drawing.Color.Red
Q7a:    q7 = 0
        If r1kr7.Text = ("") Then GoTo Q8 Else If q7 > r1kr7.Text Then q7 = q7 Else q7 = r1kr7.Text
        If r2kr7.Text = ("") Then GoTo Q8 Else If q7 > r2kr7.Text Then q7 = q7 Else q7 = r2kr7.Text
        If r3kr7.Text = ("") Then GoTo Q8 Else If q7 > r3kr7.Text Then q7 = q7 Else q7 = r3kr7.Text
        If r4kr7.Text = ("") Then GoTo Q8 Else If q7 > r4kr7.Text Then q7 = q7 Else q7 = r4kr7.Text
        If r5kr7.Text = ("") Then GoTo Q8 Else If q7 > r5kr7.Text Then q7 = q7 Else q7 = r5kr7.Text
        If r6kr7.Text = ("") Then GoTo Q8 Else If q7 > r6kr7.Text Then q7 = q7 Else q7 = r6kr7.Text
        If r7kr7.Text = ("") Then GoTo Q8 Else If q7 > r7kr7.Text Then q7 = q7 Else q7 = r7kr7.Text
        If r8kr7.Text = ("") Then GoTo Q8 Else If q7 > r8kr7.Text Then q7 = q7 Else q7 = r8kr7.Text
        If r9kr7.Text = ("") Then GoTo Q8 Else If q7 > r9kr7.Text Then q7 = q7 Else q7 = r9kr7.Text
        If r10kr7.Text = ("") Then GoTo Q8 Else If q7 > r10kr7.Text Then q7 = q7 Else q7 = r10kr7.Text
        If r11kr7.Text = ("") Then GoTo Q8 Else If q7 > r11kr7.Text Then q7 = q7 Else q7 = r11kr7.Text
        If r12kr7.Text = ("") Then GoTo Q8 Else If q7 > r12kr7.Text Then q7 = q7 Else q7 = r12kr7.Text
        If r13kr7.Text = ("") Then GoTo Q8 Else If q7 > r13kr7.Text Then q7 = q7 Else q7 = r13kr7.Text
        If r14kr7.Text = ("") Then GoTo Q8 Else If q7 > r14kr7.Text Then q7 = q7 Else q7 = r14kr7.Text
        If r15kr7.Text = ("") Then GoTo Q8 Else If q7 > r15kr7.Text Then q7 = q7 Else q7 = r15kr7.Text
        If r16kr7.Text = ("") Then GoTo Q8 Else If q7 > r16kr7.Text Then q7 = q7 Else q7 = r16kr7.Text
        If r17kr7.Text = ("") Then GoTo Q8 Else If q7 > r17kr7.Text Then q7 = q7 Else q7 = r17kr7.Text
        If r18kr7.Text = ("") Then GoTo Q8 Else If q7 > r18kr7.Text Then q7 = q7 Else q7 = r18kr7.Text
        If r19kr7.Text = ("") Then GoTo Q8 Else If q7 > r19kr7.Text Then q7 = q7 Else q7 = r19kr7.Text
        If r20kr7.Text = ("") Then GoTo Q8 Else If q7 > r20kr7.Text Then q7 = q7 Else q7 = r20kr7.Text
Q8:     If r1kr7.Text = ("") Then GoTo Q8a Else If r1kr7.Text = q7 Then r1kr7.ForeColor = Drawing.Color.Red
        If r2kr7.Text = ("") Then GoTo Q8a Else If r2kr7.Text = q7 Then r2kr7.ForeColor = Drawing.Color.Red
        If r3kr7.Text = ("") Then GoTo Q8a Else If r3kr7.Text = q7 Then r3kr7.ForeColor = Drawing.Color.Red
        If r4kr7.Text = ("") Then GoTo Q8a Else If r4kr7.Text = q7 Then r4kr7.ForeColor = Drawing.Color.Red
        If r5kr7.Text = ("") Then GoTo Q8a Else If r5kr7.Text = q7 Then r5kr7.ForeColor = Drawing.Color.Red
        If r6kr7.Text = ("") Then GoTo Q8a Else If r6kr7.Text = q7 Then r6kr7.ForeColor = Drawing.Color.Red
        If r7kr7.Text = ("") Then GoTo Q8a Else If r7kr7.Text = q7 Then r7kr7.ForeColor = Drawing.Color.Red
        If r8kr7.Text = ("") Then GoTo Q8a Else If r8kr7.Text = q7 Then r8kr7.ForeColor = Drawing.Color.Red
        If r9kr7.Text = ("") Then GoTo Q8a Else If r9kr7.Text = q7 Then r9kr7.ForeColor = Drawing.Color.Red
        If r10kr7.Text = ("") Then GoTo Q8a Else If r10kr7.Text = q7 Then r10kr7.ForeColor = Drawing.Color.Red
        If r11kr7.Text = ("") Then GoTo Q8a Else If r11kr7.Text = q7 Then r11kr7.ForeColor = Drawing.Color.Red
        If r12kr7.Text = ("") Then GoTo Q8a Else If r12kr7.Text = q7 Then r12kr7.ForeColor = Drawing.Color.Red
        If r13kr7.Text = ("") Then GoTo Q8a Else If r13kr7.Text = q7 Then r13kr7.ForeColor = Drawing.Color.Red
        If r14kr7.Text = ("") Then GoTo Q8a Else If r14kr7.Text = q7 Then r14kr7.ForeColor = Drawing.Color.Red
        If r15kr7.Text = ("") Then GoTo Q8a Else If r15kr7.Text = q7 Then r15kr7.ForeColor = Drawing.Color.Red
        If r16kr7.Text = ("") Then GoTo Q8a Else If r16kr7.Text = q7 Then r16kr7.ForeColor = Drawing.Color.Red
        If r17kr7.Text = ("") Then GoTo Q8a Else If r17kr7.Text = q7 Then r17kr7.ForeColor = Drawing.Color.Red
        If r18kr7.Text = ("") Then GoTo Q8a Else If r18kr7.Text = q7 Then r18kr7.ForeColor = Drawing.Color.Red
        If r19kr7.Text = ("") Then GoTo Q8a Else If r19kr7.Text = q7 Then r19kr7.ForeColor = Drawing.Color.Red
        If r20kr7.Text = ("") Then GoTo Q8a Else If r20kr7.Text = q7 Then r20kr7.ForeColor = Drawing.Color.Red
Q8a:    q8 = 0
        If r1kr8.Text = ("") Then GoTo Q9 Else If q8 > r1kr8.Text Then q8 = q8 Else q8 = r1kr8.Text
        If r2kr8.Text = ("") Then GoTo Q9 Else If q8 > r2kr8.Text Then q8 = q8 Else q8 = r2kr8.Text
        If r3kr8.Text = ("") Then GoTo Q9 Else If q8 > r3kr8.Text Then q8 = q8 Else q8 = r3kr8.Text
        If r4kr8.Text = ("") Then GoTo Q9 Else If q8 > r4kr8.Text Then q8 = q8 Else q8 = r4kr8.Text
        If r5kr8.Text = ("") Then GoTo Q9 Else If q8 > r5kr8.Text Then q8 = q8 Else q8 = r5kr8.Text
        If r6kr8.Text = ("") Then GoTo Q9 Else If q8 > r6kr8.Text Then q8 = q8 Else q8 = r6kr8.Text
        If r7kr8.Text = ("") Then GoTo Q9 Else If q8 > r7kr8.Text Then q8 = q8 Else q8 = r7kr8.Text
        If r8kr8.Text = ("") Then GoTo Q9 Else If q8 > r8kr8.Text Then q8 = q8 Else q8 = r8kr8.Text
        If r9kr8.Text = ("") Then GoTo Q9 Else If q8 > r9kr8.Text Then q8 = q8 Else q8 = r9kr8.Text
        If r10kr8.Text = ("") Then GoTo Q9 Else If q8 > r10kr8.Text Then q8 = q8 Else q8 = r10kr8.Text
        If r11kr8.Text = ("") Then GoTo Q9 Else If q8 > r11kr8.Text Then q8 = q8 Else q8 = r11kr8.Text
        If r12kr8.Text = ("") Then GoTo Q9 Else If q8 > r12kr8.Text Then q8 = q8 Else q8 = r12kr8.Text
        If r13kr8.Text = ("") Then GoTo Q9 Else If q8 > r13kr8.Text Then q8 = q8 Else q8 = r13kr8.Text
        If r14kr8.Text = ("") Then GoTo Q9 Else If q8 > r14kr8.Text Then q8 = q8 Else q8 = r14kr8.Text
        If r15kr8.Text = ("") Then GoTo Q9 Else If q8 > r15kr8.Text Then q8 = q8 Else q8 = r15kr8.Text
        If r16kr8.Text = ("") Then GoTo Q9 Else If q8 > r16kr8.Text Then q8 = q8 Else q8 = r16kr8.Text
        If r17kr8.Text = ("") Then GoTo Q9 Else If q8 > r17kr8.Text Then q8 = q8 Else q8 = r17kr8.Text
        If r18kr8.Text = ("") Then GoTo Q9 Else If q8 > r18kr8.Text Then q8 = q8 Else q8 = r18kr8.Text
        If r19kr8.Text = ("") Then GoTo Q9 Else If q8 > r19kr8.Text Then q8 = q8 Else q8 = r19kr8.Text
        If r20kr8.Text = ("") Then GoTo Q9 Else If q8 > r20kr8.Text Then q8 = q8 Else q8 = r20kr8.Text
Q9:     If r1kr8.Text = ("") Then GoTo Q9a Else If r1kr8.Text = q8 Then r1kr8.ForeColor = Drawing.Color.Red
        If r2kr8.Text = ("") Then GoTo Q9a Else If r2kr8.Text = q8 Then r2kr8.ForeColor = Drawing.Color.Red
        If r3kr8.Text = ("") Then GoTo Q9a Else If r3kr8.Text = q8 Then r3kr8.ForeColor = Drawing.Color.Red
        If r4kr8.Text = ("") Then GoTo Q9a Else If r4kr8.Text = q8 Then r4kr8.ForeColor = Drawing.Color.Red
        If r5kr8.Text = ("") Then GoTo Q9a Else If r5kr8.Text = q8 Then r5kr8.ForeColor = Drawing.Color.Red
        If r6kr8.Text = ("") Then GoTo Q9a Else If r6kr8.Text = q8 Then r6kr8.ForeColor = Drawing.Color.Red
        If r7kr8.Text = ("") Then GoTo Q9a Else If r7kr8.Text = q8 Then r7kr8.ForeColor = Drawing.Color.Red
        If r8kr8.Text = ("") Then GoTo Q9a Else If r8kr8.Text = q8 Then r8kr8.ForeColor = Drawing.Color.Red
        If r9kr8.Text = ("") Then GoTo Q9a Else If r9kr8.Text = q8 Then r9kr8.ForeColor = Drawing.Color.Red
        If r10kr8.Text = ("") Then GoTo Q9a Else If r10kr8.Text = q8 Then r10kr8.ForeColor = Drawing.Color.Red
        If r11kr8.Text = ("") Then GoTo Q9a Else If r11kr8.Text = q8 Then r11kr8.ForeColor = Drawing.Color.Red
        If r12kr8.Text = ("") Then GoTo Q9a Else If r12kr8.Text = q8 Then r12kr8.ForeColor = Drawing.Color.Red
        If r13kr8.Text = ("") Then GoTo Q9a Else If r13kr8.Text = q8 Then r13kr8.ForeColor = Drawing.Color.Red
        If r14kr8.Text = ("") Then GoTo Q9a Else If r14kr8.Text = q8 Then r14kr8.ForeColor = Drawing.Color.Red
        If r15kr8.Text = ("") Then GoTo Q9a Else If r15kr8.Text = q8 Then r15kr8.ForeColor = Drawing.Color.Red
        If r16kr8.Text = ("") Then GoTo Q9a Else If r16kr8.Text = q8 Then r16kr8.ForeColor = Drawing.Color.Red
        If r17kr8.Text = ("") Then GoTo Q9a Else If r17kr8.Text = q8 Then r17kr8.ForeColor = Drawing.Color.Red
        If r18kr8.Text = ("") Then GoTo Q9a Else If r18kr8.Text = q8 Then r18kr8.ForeColor = Drawing.Color.Red
        If r19kr8.Text = ("") Then GoTo Q9a Else If r19kr8.Text = q8 Then r19kr8.ForeColor = Drawing.Color.Red
        If r20kr8.Text = ("") Then GoTo Q9a Else If r20kr8.Text = q8 Then r20kr8.ForeColor = Drawing.Color.Red
Q9a:    q9 = 0
        If r1kr9.Text = ("") Then GoTo Q10 Else If q9 > r1kr9.Text Then q9 = q9 Else q9 = r1kr9.Text
        If r2kr9.Text = ("") Then GoTo Q10 Else If q9 > r2kr9.Text Then q9 = q9 Else q9 = r2kr9.Text
        If r3kr9.Text = ("") Then GoTo Q10 Else If q9 > r3kr9.Text Then q9 = q9 Else q9 = r3kr9.Text
        If r4kr9.Text = ("") Then GoTo Q10 Else If q9 > r4kr9.Text Then q9 = q9 Else q9 = r4kr9.Text
        If r5kr9.Text = ("") Then GoTo Q10 Else If q9 > r5kr9.Text Then q9 = q9 Else q9 = r5kr9.Text
        If r6kr9.Text = ("") Then GoTo Q10 Else If q9 > r6kr9.Text Then q9 = q9 Else q9 = r6kr9.Text
        If r7kr9.Text = ("") Then GoTo Q10 Else If q9 > r7kr9.Text Then q9 = q9 Else q9 = r7kr9.Text
        If r8kr9.Text = ("") Then GoTo Q10 Else If q9 > r8kr9.Text Then q9 = q9 Else q9 = r8kr9.Text
        If r9kr9.Text = ("") Then GoTo Q10 Else If q9 > r9kr9.Text Then q9 = q9 Else q9 = r9kr9.Text
        If r10kr9.Text = ("") Then GoTo Q10 Else If q9 > r10kr9.Text Then q9 = q9 Else q9 = r10kr9.Text
        If r11kr9.Text = ("") Then GoTo Q10 Else If q9 > r11kr9.Text Then q9 = q9 Else q9 = r11kr9.Text
        If r12kr9.Text = ("") Then GoTo Q10 Else If q9 > r12kr9.Text Then q9 = q9 Else q9 = r12kr9.Text
        If r13kr9.Text = ("") Then GoTo Q10 Else If q9 > r13kr9.Text Then q9 = q9 Else q9 = r13kr9.Text
        If r14kr9.Text = ("") Then GoTo Q10 Else If q9 > r14kr9.Text Then q9 = q9 Else q9 = r14kr9.Text
        If r15kr9.Text = ("") Then GoTo Q10 Else If q9 > r15kr9.Text Then q9 = q9 Else q9 = r15kr9.Text
        If r16kr9.Text = ("") Then GoTo Q10 Else If q9 > r16kr9.Text Then q9 = q9 Else q9 = r16kr9.Text
        If r17kr9.Text = ("") Then GoTo Q10 Else If q9 > r17kr9.Text Then q9 = q9 Else q9 = r17kr9.Text
        If r18kr9.Text = ("") Then GoTo Q10 Else If q9 > r18kr9.Text Then q9 = q9 Else q9 = r18kr9.Text
        If r19kr9.Text = ("") Then GoTo Q10 Else If q9 > r19kr9.Text Then q9 = q9 Else q9 = r19kr9.Text
        If r20kr9.Text = ("") Then GoTo Q10 Else If q9 > r20kr9.Text Then q9 = q9 Else q9 = r20kr9.Text
Q10:    If r1kr9.Text = ("") Then GoTo Q10a Else If r1kr9.Text = q9 Then r1kr9.ForeColor = Drawing.Color.Red
        If r2kr9.Text = ("") Then GoTo Q10a Else If r2kr9.Text = q9 Then r2kr9.ForeColor = Drawing.Color.Red
        If r3kr9.Text = ("") Then GoTo Q10a Else If r3kr9.Text = q9 Then r3kr9.ForeColor = Drawing.Color.Red
        If r4kr9.Text = ("") Then GoTo Q10a Else If r4kr9.Text = q9 Then r4kr9.ForeColor = Drawing.Color.Red
        If r5kr9.Text = ("") Then GoTo Q10a Else If r5kr9.Text = q9 Then r5kr9.ForeColor = Drawing.Color.Red
        If r6kr9.Text = ("") Then GoTo Q10a Else If r6kr9.Text = q9 Then r6kr9.ForeColor = Drawing.Color.Red
        If r7kr9.Text = ("") Then GoTo Q10a Else If r7kr9.Text = q9 Then r7kr9.ForeColor = Drawing.Color.Red
        If r8kr9.Text = ("") Then GoTo Q10a Else If r8kr9.Text = q9 Then r8kr9.ForeColor = Drawing.Color.Red
        If r9kr9.Text = ("") Then GoTo Q10a Else If r9kr9.Text = q9 Then r9kr9.ForeColor = Drawing.Color.Red
        If r10kr9.Text = ("") Then GoTo Q10a Else If r10kr9.Text = q9 Then r10kr9.ForeColor = Drawing.Color.Red
        If r11kr9.Text = ("") Then GoTo Q10a Else If r11kr9.Text = q9 Then r11kr9.ForeColor = Drawing.Color.Red
        If r12kr9.Text = ("") Then GoTo Q10a Else If r12kr9.Text = q9 Then r12kr9.ForeColor = Drawing.Color.Red
        If r13kr9.Text = ("") Then GoTo Q10a Else If r13kr9.Text = q9 Then r13kr9.ForeColor = Drawing.Color.Red
        If r14kr9.Text = ("") Then GoTo Q10a Else If r14kr9.Text = q9 Then r14kr9.ForeColor = Drawing.Color.Red
        If r15kr9.Text = ("") Then GoTo Q10a Else If r15kr9.Text = q9 Then r15kr9.ForeColor = Drawing.Color.Red
        If r16kr9.Text = ("") Then GoTo Q10a Else If r16kr9.Text = q9 Then r16kr9.ForeColor = Drawing.Color.Red
        If r17kr9.Text = ("") Then GoTo Q10a Else If r17kr9.Text = q9 Then r17kr9.ForeColor = Drawing.Color.Red
        If r18kr9.Text = ("") Then GoTo Q10a Else If r18kr9.Text = q9 Then r18kr9.ForeColor = Drawing.Color.Red
        If r19kr9.Text = ("") Then GoTo Q10a Else If r19kr9.Text = q9 Then r19kr9.ForeColor = Drawing.Color.Red
        If r20kr9.Text = ("") Then GoTo Q10a Else If r20kr9.Text = q9 Then r20kr9.ForeColor = Drawing.Color.Red
Q10a:   q10 = 0
        If r1kr10.Text = ("") Then GoTo Q11 Else If q10 > r1kr10.Text Then q10 = q10 Else q10 = r1kr10.Text
        If r2kr10.Text = ("") Then GoTo Q11 Else If q10 > r2kr10.Text Then q10 = q10 Else q10 = r2kr10.Text
        If r3kr10.Text = ("") Then GoTo Q11 Else If q10 > r3kr10.Text Then q10 = q10 Else q10 = r3kr10.Text
        If r4kr10.Text = ("") Then GoTo Q11 Else If q10 > r4kr10.Text Then q10 = q10 Else q10 = r4kr10.Text
        If r5kr10.Text = ("") Then GoTo Q11 Else If q10 > r5kr10.Text Then q10 = q10 Else q10 = r5kr10.Text
        If r6kr10.Text = ("") Then GoTo Q11 Else If q10 > r6kr10.Text Then q10 = q10 Else q10 = r6kr10.Text
        If r7kr10.Text = ("") Then GoTo Q11 Else If q10 > r7kr10.Text Then q10 = q10 Else q10 = r7kr10.Text
        If r8kr10.Text = ("") Then GoTo Q11 Else If q10 > r8kr10.Text Then q10 = q10 Else q10 = r8kr10.Text
        If r9kr10.Text = ("") Then GoTo Q11 Else If q10 > r9kr10.Text Then q10 = q10 Else q10 = r9kr10.Text
        If r10kr10.Text = ("") Then GoTo Q11 Else If q10 > r10kr10.Text Then q10 = q10 Else q10 = r10kr10.Text
        If r11kr10.Text = ("") Then GoTo Q11 Else If q10 > r11kr10.Text Then q10 = q10 Else q10 = r11kr10.Text
        If r12kr10.Text = ("") Then GoTo Q11 Else If q10 > r12kr10.Text Then q10 = q10 Else q10 = r12kr10.Text
        If r13kr10.Text = ("") Then GoTo Q11 Else If q10 > r13kr10.Text Then q10 = q10 Else q10 = r13kr10.Text
        If r14kr10.Text = ("") Then GoTo Q11 Else If q10 > r14kr10.Text Then q10 = q10 Else q10 = r14kr10.Text
        If r15kr10.Text = ("") Then GoTo Q11 Else If q10 > r15kr10.Text Then q10 = q10 Else q10 = r15kr10.Text
        If r16kr10.Text = ("") Then GoTo Q11 Else If q10 > r16kr10.Text Then q10 = q10 Else q10 = r16kr10.Text
        If r17kr10.Text = ("") Then GoTo Q11 Else If q10 > r17kr10.Text Then q10 = q10 Else q10 = r17kr10.Text
        If r18kr10.Text = ("") Then GoTo Q11 Else If q10 > r18kr10.Text Then q10 = q10 Else q10 = r18kr10.Text
        If r19kr10.Text = ("") Then GoTo Q11 Else If q10 > r19kr10.Text Then q10 = q10 Else q10 = r19kr10.Text
        If r20kr10.Text = ("") Then GoTo Q11 Else If q10 > r20kr10.Text Then q10 = q10 Else q10 = r20kr10.Text
Q11:    If r1kr10.Text = ("") Then GoTo Q11a Else If r1kr10.Text = q10 Then r1kr10.ForeColor = Drawing.Color.Red
        If r2kr10.Text = ("") Then GoTo Q11a Else If r2kr10.Text = q10 Then r2kr10.ForeColor = Drawing.Color.Red
        If r3kr10.Text = ("") Then GoTo Q11a Else If r3kr10.Text = q10 Then r3kr10.ForeColor = Drawing.Color.Red
        If r4kr10.Text = ("") Then GoTo Q11a Else If r4kr10.Text = q10 Then r4kr10.ForeColor = Drawing.Color.Red
        If r5kr10.Text = ("") Then GoTo Q11a Else If r5kr10.Text = q10 Then r5kr10.ForeColor = Drawing.Color.Red
        If r6kr10.Text = ("") Then GoTo Q11a Else If r6kr10.Text = q10 Then r6kr10.ForeColor = Drawing.Color.Red
        If r7kr10.Text = ("") Then GoTo Q11a Else If r7kr10.Text = q10 Then r7kr10.ForeColor = Drawing.Color.Red
        If r8kr10.Text = ("") Then GoTo Q11a Else If r8kr10.Text = q10 Then r8kr10.ForeColor = Drawing.Color.Red
        If r9kr10.Text = ("") Then GoTo Q11a Else If r9kr10.Text = q10 Then r9kr10.ForeColor = Drawing.Color.Red
        If r10kr10.Text = ("") Then GoTo Q11a Else If r10kr10.Text = q10 Then r10kr10.ForeColor = Drawing.Color.Red
        If r11kr10.Text = ("") Then GoTo Q11a Else If r11kr10.Text = q10 Then r11kr10.ForeColor = Drawing.Color.Red
        If r12kr10.Text = ("") Then GoTo Q11a Else If r12kr10.Text = q10 Then r12kr10.ForeColor = Drawing.Color.Red
        If r13kr10.Text = ("") Then GoTo Q11a Else If r13kr10.Text = q10 Then r13kr10.ForeColor = Drawing.Color.Red
        If r14kr10.Text = ("") Then GoTo Q11a Else If r14kr10.Text = q10 Then r14kr10.ForeColor = Drawing.Color.Red
        If r15kr10.Text = ("") Then GoTo Q11a Else If r15kr10.Text = q10 Then r15kr10.ForeColor = Drawing.Color.Red
        If r16kr10.Text = ("") Then GoTo Q11a Else If r16kr10.Text = q10 Then r16kr10.ForeColor = Drawing.Color.Red
        If r17kr10.Text = ("") Then GoTo Q11a Else If r17kr10.Text = q10 Then r17kr10.ForeColor = Drawing.Color.Red
        If r18kr10.Text = ("") Then GoTo Q11a Else If r18kr10.Text = q10 Then r18kr10.ForeColor = Drawing.Color.Red
        If r19kr10.Text = ("") Then GoTo Q11a Else If r19kr10.Text = q10 Then r19kr10.ForeColor = Drawing.Color.Red
        If r20kr10.Text = ("") Then GoTo Q11a Else If r20kr10.Text = q10 Then r20kr10.ForeColor = Drawing.Color.Red
Q11a:   q11 = 0
        If r1kr11.Text = ("") Then GoTo Q12 Else If q11 > r1kr11.Text Then q11 = q11 Else q11 = r1kr11.Text
        If r2kr11.Text = ("") Then GoTo Q12 Else If q11 > r2kr11.Text Then q11 = q11 Else q11 = r2kr11.Text
        If r3kr11.Text = ("") Then GoTo Q12 Else If q11 > r3kr11.Text Then q11 = q11 Else q11 = r3kr11.Text
        If r4kr11.Text = ("") Then GoTo Q12 Else If q11 > r4kr11.Text Then q11 = q11 Else q11 = r4kr11.Text
        If r5kr11.Text = ("") Then GoTo Q12 Else If q11 > r5kr11.Text Then q11 = q11 Else q11 = r5kr11.Text
        If r6kr11.Text = ("") Then GoTo Q12 Else If q11 > r6kr11.Text Then q11 = q11 Else q11 = r6kr11.Text
        If r7kr11.Text = ("") Then GoTo Q12 Else If q11 > r7kr11.Text Then q11 = q11 Else q11 = r7kr11.Text
        If r8kr11.Text = ("") Then GoTo Q12 Else If q11 > r8kr11.Text Then q11 = q11 Else q11 = r8kr11.Text
        If r9kr11.Text = ("") Then GoTo Q12 Else If q11 > r9kr11.Text Then q11 = q11 Else q11 = r9kr11.Text
        If r10kr11.Text = ("") Then GoTo Q12 Else If q11 > r10kr11.Text Then q11 = q11 Else q11 = r10kr11.Text
        If r11kr11.Text = ("") Then GoTo Q12 Else If q11 > r11kr11.Text Then q11 = q11 Else q11 = r11kr11.Text
        If r12kr11.Text = ("") Then GoTo Q12 Else If q11 > r12kr11.Text Then q11 = q11 Else q11 = r12kr11.Text
        If r13kr11.Text = ("") Then GoTo Q12 Else If q11 > r13kr11.Text Then q11 = q11 Else q11 = r13kr11.Text
        If r14kr11.Text = ("") Then GoTo Q12 Else If q11 > r14kr11.Text Then q11 = q11 Else q11 = r14kr11.Text
        If r15kr11.Text = ("") Then GoTo Q12 Else If q11 > r15kr11.Text Then q11 = q11 Else q11 = r15kr11.Text
        If r16kr11.Text = ("") Then GoTo Q12 Else If q11 > r16kr11.Text Then q11 = q11 Else q11 = r16kr11.Text
        If r17kr11.Text = ("") Then GoTo Q12 Else If q11 > r17kr11.Text Then q11 = q11 Else q11 = r17kr11.Text
        If r18kr11.Text = ("") Then GoTo Q12 Else If q11 > r18kr11.Text Then q11 = q11 Else q11 = r18kr11.Text
        If r19kr11.Text = ("") Then GoTo Q12 Else If q11 > r19kr11.Text Then q11 = q11 Else q11 = r19kr11.Text
        If r20kr11.Text = ("") Then GoTo Q12 Else If q11 > r20kr11.Text Then q11 = q11 Else q11 = r20kr11.Text
Q12:    If r1kr11.Text = ("") Then GoTo Q12a Else If r1kr11.Text = q11 Then r1kr11.ForeColor = Drawing.Color.Red
        If r2kr11.Text = ("") Then GoTo Q12a Else If r2kr11.Text = q11 Then r2kr11.ForeColor = Drawing.Color.Red
        If r3kr11.Text = ("") Then GoTo Q12a Else If r3kr11.Text = q11 Then r3kr11.ForeColor = Drawing.Color.Red
        If r4kr11.Text = ("") Then GoTo Q12a Else If r4kr11.Text = q11 Then r4kr11.ForeColor = Drawing.Color.Red
        If r5kr11.Text = ("") Then GoTo Q12a Else If r5kr11.Text = q11 Then r5kr11.ForeColor = Drawing.Color.Red
        If r6kr11.Text = ("") Then GoTo Q12a Else If r6kr11.Text = q11 Then r6kr11.ForeColor = Drawing.Color.Red
        If r7kr11.Text = ("") Then GoTo Q12a Else If r7kr11.Text = q11 Then r7kr11.ForeColor = Drawing.Color.Red
        If r8kr11.Text = ("") Then GoTo Q12a Else If r8kr11.Text = q11 Then r8kr11.ForeColor = Drawing.Color.Red
        If r9kr11.Text = ("") Then GoTo Q12a Else If r9kr11.Text = q11 Then r9kr11.ForeColor = Drawing.Color.Red
        If r10kr11.Text = ("") Then GoTo Q12a Else If r10kr11.Text = q11 Then r10kr11.ForeColor = Drawing.Color.Red
        If r11kr11.Text = ("") Then GoTo Q12a Else If r11kr11.Text = q11 Then r11kr11.ForeColor = Drawing.Color.Red
        If r12kr11.Text = ("") Then GoTo Q12a Else If r12kr11.Text = q11 Then r12kr11.ForeColor = Drawing.Color.Red
        If r13kr11.Text = ("") Then GoTo Q12a Else If r13kr11.Text = q11 Then r13kr11.ForeColor = Drawing.Color.Red
        If r14kr11.Text = ("") Then GoTo Q12a Else If r14kr11.Text = q11 Then r14kr11.ForeColor = Drawing.Color.Red
        If r15kr11.Text = ("") Then GoTo Q12a Else If r15kr11.Text = q11 Then r15kr11.ForeColor = Drawing.Color.Red
        If r16kr11.Text = ("") Then GoTo Q12a Else If r16kr11.Text = q11 Then r16kr11.ForeColor = Drawing.Color.Red
        If r17kr11.Text = ("") Then GoTo Q12a Else If r17kr11.Text = q11 Then r17kr11.ForeColor = Drawing.Color.Red
        If r18kr11.Text = ("") Then GoTo Q12a Else If r18kr11.Text = q11 Then r18kr11.ForeColor = Drawing.Color.Red
        If r19kr11.Text = ("") Then GoTo Q12a Else If r19kr11.Text = q11 Then r19kr11.ForeColor = Drawing.Color.Red
        If r20kr11.Text = ("") Then GoTo Q12a Else If r20kr11.Text = q11 Then r20kr11.ForeColor = Drawing.Color.Red
Q12a:   q12 = 0
        If r1kr12.Text = ("") Then GoTo Q13 Else If q12 > r1kr12.Text Then q12 = q12 Else q12 = r1kr12.Text
        If r2kr12.Text = ("") Then GoTo Q13 Else If q12 > r2kr12.Text Then q12 = q12 Else q12 = r2kr12.Text
        If r3kr12.Text = ("") Then GoTo Q13 Else If q12 > r3kr12.Text Then q12 = q12 Else q12 = r3kr12.Text
        If r4kr12.Text = ("") Then GoTo Q13 Else If q12 > r4kr12.Text Then q12 = q12 Else q12 = r4kr12.Text
        If r5kr12.Text = ("") Then GoTo Q13 Else If q12 > r5kr12.Text Then q12 = q12 Else q12 = r5kr12.Text
        If r6kr12.Text = ("") Then GoTo Q13 Else If q12 > r6kr12.Text Then q12 = q12 Else q12 = r6kr12.Text
        If r7kr12.Text = ("") Then GoTo Q13 Else If q12 > r7kr12.Text Then q12 = q12 Else q12 = r7kr12.Text
        If r8kr12.Text = ("") Then GoTo Q13 Else If q12 > r8kr12.Text Then q12 = q12 Else q12 = r8kr12.Text
        If r9kr12.Text = ("") Then GoTo Q13 Else If q12 > r9kr12.Text Then q12 = q12 Else q12 = r9kr12.Text
        If r10kr12.Text = ("") Then GoTo Q13 Else If q12 > r10kr12.Text Then q12 = q12 Else q12 = r10kr12.Text
        If r11kr12.Text = ("") Then GoTo Q13 Else If q12 > r11kr12.Text Then q12 = q12 Else q12 = r11kr12.Text
        If r12kr12.Text = ("") Then GoTo Q13 Else If q12 > r12kr12.Text Then q12 = q12 Else q12 = r12kr12.Text
        If r13kr12.Text = ("") Then GoTo Q13 Else If q12 > r13kr12.Text Then q12 = q12 Else q12 = r13kr12.Text
        If r14kr12.Text = ("") Then GoTo Q13 Else If q12 > r14kr12.Text Then q12 = q12 Else q12 = r14kr12.Text
        If r15kr12.Text = ("") Then GoTo Q13 Else If q12 > r15kr12.Text Then q12 = q12 Else q12 = r15kr12.Text
        If r16kr12.Text = ("") Then GoTo Q13 Else If q12 > r16kr12.Text Then q12 = q12 Else q12 = r16kr12.Text
        If r17kr12.Text = ("") Then GoTo Q13 Else If q12 > r17kr12.Text Then q12 = q12 Else q12 = r17kr12.Text
        If r18kr12.Text = ("") Then GoTo Q13 Else If q12 > r18kr12.Text Then q12 = q12 Else q12 = r18kr12.Text
        If r19kr12.Text = ("") Then GoTo Q13 Else If q12 > r19kr12.Text Then q12 = q12 Else q12 = r19kr12.Text
        If r20kr12.Text = ("") Then GoTo Q13 Else If q12 > r20kr12.Text Then q12 = q12 Else q12 = r20kr12.Text
Q13:    If r1kr12.Text = ("") Then GoTo Q13a Else If r1kr12.Text = q12 Then r1kr12.ForeColor = Drawing.Color.Red
        If r2kr12.Text = ("") Then GoTo Q13a Else If r2kr12.Text = q12 Then r2kr12.ForeColor = Drawing.Color.Red
        If r3kr12.Text = ("") Then GoTo Q13a Else If r3kr12.Text = q12 Then r3kr12.ForeColor = Drawing.Color.Red
        If r4kr12.Text = ("") Then GoTo Q13a Else If r4kr12.Text = q12 Then r4kr12.ForeColor = Drawing.Color.Red
        If r5kr12.Text = ("") Then GoTo Q13a Else If r5kr12.Text = q12 Then r5kr12.ForeColor = Drawing.Color.Red
        If r6kr12.Text = ("") Then GoTo Q13a Else If r6kr12.Text = q12 Then r6kr12.ForeColor = Drawing.Color.Red
        If r7kr12.Text = ("") Then GoTo Q13a Else If r7kr12.Text = q12 Then r7kr12.ForeColor = Drawing.Color.Red
        If r8kr12.Text = ("") Then GoTo Q13a Else If r8kr12.Text = q12 Then r8kr12.ForeColor = Drawing.Color.Red
        If r9kr12.Text = ("") Then GoTo Q13a Else If r9kr12.Text = q12 Then r9kr12.ForeColor = Drawing.Color.Red
        If r10kr12.Text = ("") Then GoTo Q13a Else If r10kr12.Text = q12 Then r10kr12.ForeColor = Drawing.Color.Red
        If r11kr12.Text = ("") Then GoTo Q13a Else If r11kr12.Text = q12 Then r11kr12.ForeColor = Drawing.Color.Red
        If r12kr12.Text = ("") Then GoTo Q13a Else If r12kr12.Text = q12 Then r12kr12.ForeColor = Drawing.Color.Red
        If r13kr12.Text = ("") Then GoTo Q13a Else If r13kr12.Text = q12 Then r13kr12.ForeColor = Drawing.Color.Red
        If r14kr12.Text = ("") Then GoTo Q13a Else If r14kr12.Text = q12 Then r14kr12.ForeColor = Drawing.Color.Red
        If r15kr12.Text = ("") Then GoTo Q13a Else If r15kr12.Text = q12 Then r15kr12.ForeColor = Drawing.Color.Red
        If r16kr12.Text = ("") Then GoTo Q13a Else If r16kr12.Text = q12 Then r16kr12.ForeColor = Drawing.Color.Red
        If r17kr12.Text = ("") Then GoTo Q13a Else If r17kr12.Text = q12 Then r17kr12.ForeColor = Drawing.Color.Red
        If r18kr12.Text = ("") Then GoTo Q13a Else If r18kr12.Text = q12 Then r18kr12.ForeColor = Drawing.Color.Red
        If r19kr12.Text = ("") Then GoTo Q13a Else If r19kr12.Text = q12 Then r19kr12.ForeColor = Drawing.Color.Red
        If r20kr12.Text = ("") Then GoTo Q13a Else If r20kr12.Text = q12 Then r20kr12.ForeColor = Drawing.Color.Red
Q13a:   q13 = 0
        If r1kr13.Text = ("") Then GoTo Q14 Else If q13 > r1kr13.Text Then q13 = q13 Else q13 = r1kr13.Text
        If r2kr13.Text = ("") Then GoTo Q14 Else If q13 > r2kr13.Text Then q13 = q13 Else q13 = r2kr13.Text
        If r3kr13.Text = ("") Then GoTo Q14 Else If q13 > r3kr13.Text Then q13 = q13 Else q13 = r3kr13.Text
        If r4kr13.Text = ("") Then GoTo Q14 Else If q13 > r4kr13.Text Then q13 = q13 Else q13 = r4kr13.Text
        If r5kr13.Text = ("") Then GoTo Q14 Else If q13 > r5kr13.Text Then q13 = q13 Else q13 = r5kr13.Text
        If r6kr13.Text = ("") Then GoTo Q14 Else If q13 > r6kr13.Text Then q13 = q13 Else q13 = r6kr13.Text
        If r7kr13.Text = ("") Then GoTo Q14 Else If q13 > r7kr13.Text Then q13 = q13 Else q13 = r7kr13.Text
        If r8kr13.Text = ("") Then GoTo Q14 Else If q13 > r8kr13.Text Then q13 = q13 Else q13 = r8kr13.Text
        If r9kr13.Text = ("") Then GoTo Q14 Else If q13 > r9kr13.Text Then q13 = q13 Else q13 = r9kr13.Text
        If r10kr13.Text = ("") Then GoTo Q14 Else If q13 > r10kr13.Text Then q13 = q13 Else q13 = r10kr13.Text
        If r11kr13.Text = ("") Then GoTo Q14 Else If q13 > r11kr13.Text Then q13 = q13 Else q13 = r11kr13.Text
        If r12kr13.Text = ("") Then GoTo Q14 Else If q13 > r12kr13.Text Then q13 = q13 Else q13 = r12kr13.Text
        If r13kr13.Text = ("") Then GoTo Q14 Else If q13 > r13kr13.Text Then q13 = q13 Else q13 = r13kr13.Text
        If r14kr13.Text = ("") Then GoTo Q14 Else If q13 > r14kr13.Text Then q13 = q13 Else q13 = r14kr13.Text
        If r15kr13.Text = ("") Then GoTo Q14 Else If q13 > r15kr13.Text Then q13 = q13 Else q13 = r15kr13.Text
        If r16kr13.Text = ("") Then GoTo Q14 Else If q13 > r16kr13.Text Then q13 = q13 Else q13 = r16kr13.Text
        If r17kr13.Text = ("") Then GoTo Q14 Else If q13 > r17kr13.Text Then q13 = q13 Else q13 = r17kr13.Text
        If r18kr13.Text = ("") Then GoTo Q14 Else If q13 > r18kr13.Text Then q13 = q13 Else q13 = r18kr13.Text
        If r19kr13.Text = ("") Then GoTo Q14 Else If q13 > r19kr13.Text Then q13 = q13 Else q13 = r19kr13.Text
        If r20kr13.Text = ("") Then GoTo Q14 Else If q13 > r20kr13.Text Then q13 = q13 Else q13 = r20kr13.Text
Q14:    If r1kr13.Text = ("") Then GoTo Q14a Else If r1kr13.Text = q13 Then r1kr13.ForeColor = Drawing.Color.Red
        If r2kr13.Text = ("") Then GoTo Q14a Else If r2kr13.Text = q13 Then r2kr13.ForeColor = Drawing.Color.Red
        If r3kr13.Text = ("") Then GoTo Q14a Else If r3kr13.Text = q13 Then r3kr13.ForeColor = Drawing.Color.Red
        If r4kr13.Text = ("") Then GoTo Q14a Else If r4kr13.Text = q13 Then r4kr13.ForeColor = Drawing.Color.Red
        If r5kr13.Text = ("") Then GoTo Q14a Else If r5kr13.Text = q13 Then r5kr13.ForeColor = Drawing.Color.Red
        If r6kr13.Text = ("") Then GoTo Q14a Else If r6kr13.Text = q13 Then r6kr13.ForeColor = Drawing.Color.Red
        If r7kr13.Text = ("") Then GoTo Q14a Else If r7kr13.Text = q13 Then r7kr13.ForeColor = Drawing.Color.Red
        If r8kr13.Text = ("") Then GoTo Q14a Else If r8kr13.Text = q13 Then r8kr13.ForeColor = Drawing.Color.Red
        If r9kr13.Text = ("") Then GoTo Q14a Else If r9kr13.Text = q13 Then r9kr13.ForeColor = Drawing.Color.Red
        If r10kr13.Text = ("") Then GoTo Q14a Else If r10kr13.Text = q13 Then r10kr13.ForeColor = Drawing.Color.Red
        If r11kr13.Text = ("") Then GoTo Q14a Else If r11kr13.Text = q13 Then r11kr13.ForeColor = Drawing.Color.Red
        If r12kr13.Text = ("") Then GoTo Q14a Else If r12kr13.Text = q13 Then r12kr13.ForeColor = Drawing.Color.Red
        If r13kr13.Text = ("") Then GoTo Q14a Else If r13kr13.Text = q13 Then r13kr13.ForeColor = Drawing.Color.Red
        If r14kr13.Text = ("") Then GoTo Q14a Else If r14kr13.Text = q13 Then r14kr13.ForeColor = Drawing.Color.Red
        If r15kr13.Text = ("") Then GoTo Q14a Else If r15kr13.Text = q13 Then r15kr13.ForeColor = Drawing.Color.Red
        If r16kr13.Text = ("") Then GoTo Q14a Else If r16kr13.Text = q13 Then r16kr13.ForeColor = Drawing.Color.Red
        If r17kr13.Text = ("") Then GoTo Q14a Else If r17kr13.Text = q13 Then r17kr13.ForeColor = Drawing.Color.Red
        If r18kr13.Text = ("") Then GoTo Q14a Else If r18kr13.Text = q13 Then r18kr13.ForeColor = Drawing.Color.Red
        If r19kr13.Text = ("") Then GoTo Q14a Else If r19kr13.Text = q13 Then r19kr13.ForeColor = Drawing.Color.Red
        If r20kr13.Text = ("") Then GoTo Q14a Else If r20kr13.Text = q13 Then r20kr13.ForeColor = Drawing.Color.Red
Q14a:   q14 = 0
        If r1kr14.Text = ("") Then GoTo Q15 Else If q14 > r1kr14.Text Then q14 = q14 Else q14 = r1kr14.Text
        If r2kr14.Text = ("") Then GoTo Q15 Else If q14 > r2kr14.Text Then q14 = q14 Else q14 = r2kr14.Text
        If r3kr14.Text = ("") Then GoTo Q15 Else If q14 > r3kr14.Text Then q14 = q14 Else q14 = r3kr14.Text
        If r4kr14.Text = ("") Then GoTo Q15 Else If q14 > r4kr14.Text Then q14 = q14 Else q14 = r4kr14.Text
        If r5kr14.Text = ("") Then GoTo Q15 Else If q14 > r5kr14.Text Then q14 = q14 Else q14 = r5kr14.Text
        If r6kr14.Text = ("") Then GoTo Q15 Else If q14 > r6kr14.Text Then q14 = q14 Else q14 = r6kr14.Text
        If r7kr14.Text = ("") Then GoTo Q15 Else If q14 > r7kr14.Text Then q14 = q14 Else q14 = r7kr14.Text
        If r8kr14.Text = ("") Then GoTo Q15 Else If q14 > r8kr14.Text Then q14 = q14 Else q14 = r8kr14.Text
        If r9kr14.Text = ("") Then GoTo Q15 Else If q14 > r9kr14.Text Then q14 = q14 Else q14 = r9kr14.Text
        If r10kr14.Text = ("") Then GoTo Q15 Else If q14 > r10kr14.Text Then q14 = q14 Else q14 = r10kr14.Text
        If r11kr14.Text = ("") Then GoTo Q15 Else If q14 > r11kr14.Text Then q14 = q14 Else q14 = r11kr14.Text
        If r12kr14.Text = ("") Then GoTo Q15 Else If q14 > r12kr14.Text Then q14 = q14 Else q14 = r12kr14.Text
        If r13kr14.Text = ("") Then GoTo Q15 Else If q14 > r13kr14.Text Then q14 = q14 Else q14 = r13kr14.Text
        If r14kr14.Text = ("") Then GoTo Q15 Else If q14 > r14kr14.Text Then q14 = q14 Else q14 = r14kr14.Text
        If r15kr14.Text = ("") Then GoTo Q15 Else If q14 > r15kr14.Text Then q14 = q14 Else q14 = r15kr14.Text
        If r16kr14.Text = ("") Then GoTo Q15 Else If q14 > r16kr14.Text Then q14 = q14 Else q14 = r16kr14.Text
        If r17kr14.Text = ("") Then GoTo Q15 Else If q14 > r17kr14.Text Then q14 = q14 Else q14 = r17kr14.Text
        If r18kr14.Text = ("") Then GoTo Q15 Else If q14 > r18kr14.Text Then q14 = q14 Else q14 = r18kr14.Text
        If r19kr14.Text = ("") Then GoTo Q15 Else If q14 > r19kr14.Text Then q14 = q14 Else q14 = r19kr14.Text
        If r20kr14.Text = ("") Then GoTo Q15 Else If q14 > r20kr14.Text Then q14 = q14 Else q14 = r20kr14.Text
Q15:    If r1kr14.Text = ("") Then GoTo Q15a Else If r1kr14.Text = q14 Then r1kr14.ForeColor = Drawing.Color.Red
        If r2kr14.Text = ("") Then GoTo Q15a Else If r2kr14.Text = q14 Then r2kr14.ForeColor = Drawing.Color.Red
        If r3kr14.Text = ("") Then GoTo Q15a Else If r3kr14.Text = q14 Then r3kr14.ForeColor = Drawing.Color.Red
        If r4kr14.Text = ("") Then GoTo Q15a Else If r4kr14.Text = q14 Then r4kr14.ForeColor = Drawing.Color.Red
        If r5kr14.Text = ("") Then GoTo Q15a Else If r5kr14.Text = q14 Then r5kr14.ForeColor = Drawing.Color.Red
        If r6kr14.Text = ("") Then GoTo Q15a Else If r6kr14.Text = q14 Then r6kr14.ForeColor = Drawing.Color.Red
        If r7kr14.Text = ("") Then GoTo Q15a Else If r7kr14.Text = q14 Then r7kr14.ForeColor = Drawing.Color.Red
        If r8kr14.Text = ("") Then GoTo Q15a Else If r8kr14.Text = q14 Then r8kr14.ForeColor = Drawing.Color.Red
        If r9kr14.Text = ("") Then GoTo Q15a Else If r9kr14.Text = q14 Then r9kr14.ForeColor = Drawing.Color.Red
        If r10kr14.Text = ("") Then GoTo Q15a Else If r10kr14.Text = q14 Then r10kr14.ForeColor = Drawing.Color.Red
        If r11kr14.Text = ("") Then GoTo Q15a Else If r11kr14.Text = q14 Then r11kr14.ForeColor = Drawing.Color.Red
        If r12kr14.Text = ("") Then GoTo Q15a Else If r12kr14.Text = q14 Then r12kr14.ForeColor = Drawing.Color.Red
        If r13kr14.Text = ("") Then GoTo Q15a Else If r13kr14.Text = q14 Then r13kr14.ForeColor = Drawing.Color.Red
        If r14kr14.Text = ("") Then GoTo Q15a Else If r14kr14.Text = q14 Then r14kr14.ForeColor = Drawing.Color.Red
        If r15kr14.Text = ("") Then GoTo Q15a Else If r15kr14.Text = q14 Then r15kr14.ForeColor = Drawing.Color.Red
        If r16kr14.Text = ("") Then GoTo Q15a Else If r16kr14.Text = q14 Then r16kr14.ForeColor = Drawing.Color.Red
        If r17kr14.Text = ("") Then GoTo Q15a Else If r17kr14.Text = q14 Then r17kr14.ForeColor = Drawing.Color.Red
        If r18kr14.Text = ("") Then GoTo Q15a Else If r18kr14.Text = q14 Then r18kr14.ForeColor = Drawing.Color.Red
        If r19kr14.Text = ("") Then GoTo Q15a Else If r19kr14.Text = q14 Then r19kr14.ForeColor = Drawing.Color.Red
        If r20kr14.Text = ("") Then GoTo Q15a Else If r20kr14.Text = q14 Then r20kr14.ForeColor = Drawing.Color.Red
Q15a:   q15 = 0
        If r1kr15.Text = ("") Then GoTo Q16 Else If q15 > r1kr15.Text Then q15 = q15 Else q15 = r1kr15.Text
        If r2kr15.Text = ("") Then GoTo Q16 Else If q15 > r2kr15.Text Then q15 = q15 Else q15 = r2kr15.Text
        If r3kr15.Text = ("") Then GoTo Q16 Else If q15 > r3kr15.Text Then q15 = q15 Else q15 = r3kr15.Text
        If r4kr15.Text = ("") Then GoTo Q16 Else If q15 > r4kr15.Text Then q15 = q15 Else q15 = r4kr15.Text
        If r5kr15.Text = ("") Then GoTo Q16 Else If q15 > r5kr15.Text Then q15 = q15 Else q15 = r5kr15.Text
        If r6kr15.Text = ("") Then GoTo Q16 Else If q15 > r6kr15.Text Then q15 = q15 Else q15 = r6kr15.Text
        If r7kr15.Text = ("") Then GoTo Q16 Else If q15 > r7kr15.Text Then q15 = q15 Else q15 = r7kr15.Text
        If r8kr15.Text = ("") Then GoTo Q16 Else If q15 > r8kr15.Text Then q15 = q15 Else q15 = r8kr15.Text
        If r9kr15.Text = ("") Then GoTo Q16 Else If q15 > r9kr15.Text Then q15 = q15 Else q15 = r9kr15.Text
        If r10kr15.Text = ("") Then GoTo Q16 Else If q15 > r10kr15.Text Then q15 = q15 Else q15 = r10kr15.Text
        If r11kr15.Text = ("") Then GoTo Q16 Else If q15 > r11kr15.Text Then q15 = q15 Else q15 = r11kr15.Text
        If r12kr15.Text = ("") Then GoTo Q16 Else If q15 > r12kr15.Text Then q15 = q15 Else q15 = r12kr15.Text
        If r13kr15.Text = ("") Then GoTo Q16 Else If q15 > r13kr15.Text Then q15 = q15 Else q15 = r13kr15.Text
        If r14kr15.Text = ("") Then GoTo Q16 Else If q15 > r14kr15.Text Then q15 = q15 Else q15 = r14kr15.Text
        If r15kr15.Text = ("") Then GoTo Q16 Else If q15 > r15kr15.Text Then q15 = q15 Else q15 = r15kr15.Text
        If r16kr15.Text = ("") Then GoTo Q16 Else If q15 > r16kr15.Text Then q15 = q15 Else q15 = r16kr15.Text
        If r17kr15.Text = ("") Then GoTo Q16 Else If q15 > r17kr15.Text Then q15 = q15 Else q15 = r17kr15.Text
        If r18kr15.Text = ("") Then GoTo Q16 Else If q15 > r18kr15.Text Then q15 = q15 Else q15 = r18kr15.Text
        If r19kr15.Text = ("") Then GoTo Q16 Else If q15 > r19kr15.Text Then q15 = q15 Else q15 = r19kr15.Text
        If r20kr15.Text = ("") Then GoTo Q16 Else If q15 > r20kr15.Text Then q15 = q15 Else q15 = r20kr15.Text
Q16:    If r1kr15.Text = ("") Then GoTo Q16a Else If r1kr15.Text = q15 Then r1kr15.ForeColor = Drawing.Color.Red
        If r2kr15.Text = ("") Then GoTo Q16a Else If r2kr15.Text = q15 Then r2kr15.ForeColor = Drawing.Color.Red
        If r3kr15.Text = ("") Then GoTo Q16a Else If r3kr15.Text = q15 Then r3kr15.ForeColor = Drawing.Color.Red
        If r4kr15.Text = ("") Then GoTo Q16a Else If r4kr15.Text = q15 Then r4kr15.ForeColor = Drawing.Color.Red
        If r5kr15.Text = ("") Then GoTo Q16a Else If r5kr15.Text = q15 Then r5kr15.ForeColor = Drawing.Color.Red
        If r6kr15.Text = ("") Then GoTo Q16a Else If r6kr15.Text = q15 Then r6kr15.ForeColor = Drawing.Color.Red
        If r7kr15.Text = ("") Then GoTo Q16a Else If r7kr15.Text = q15 Then r7kr15.ForeColor = Drawing.Color.Red
        If r8kr15.Text = ("") Then GoTo Q16a Else If r8kr15.Text = q15 Then r8kr15.ForeColor = Drawing.Color.Red
        If r9kr15.Text = ("") Then GoTo Q16a Else If r9kr15.Text = q15 Then r9kr15.ForeColor = Drawing.Color.Red
        If r10kr15.Text = ("") Then GoTo Q16a Else If r10kr15.Text = q15 Then r10kr15.ForeColor = Drawing.Color.Red
        If r11kr15.Text = ("") Then GoTo Q16a Else If r11kr15.Text = q15 Then r11kr15.ForeColor = Drawing.Color.Red
        If r12kr15.Text = ("") Then GoTo Q16a Else If r12kr15.Text = q15 Then r12kr15.ForeColor = Drawing.Color.Red
        If r13kr15.Text = ("") Then GoTo Q16a Else If r13kr15.Text = q15 Then r13kr15.ForeColor = Drawing.Color.Red
        If r14kr15.Text = ("") Then GoTo Q16a Else If r14kr15.Text = q15 Then r14kr15.ForeColor = Drawing.Color.Red
        If r15kr15.Text = ("") Then GoTo Q16a Else If r15kr15.Text = q15 Then r15kr15.ForeColor = Drawing.Color.Red
        If r16kr15.Text = ("") Then GoTo Q16a Else If r16kr15.Text = q15 Then r16kr15.ForeColor = Drawing.Color.Red
        If r17kr15.Text = ("") Then GoTo Q16a Else If r17kr15.Text = q15 Then r17kr15.ForeColor = Drawing.Color.Red
        If r18kr15.Text = ("") Then GoTo Q16a Else If r18kr15.Text = q15 Then r18kr15.ForeColor = Drawing.Color.Red
        If r19kr15.Text = ("") Then GoTo Q16a Else If r19kr15.Text = q15 Then r19kr15.ForeColor = Drawing.Color.Red
        If r20kr15.Text = ("") Then GoTo Q16a Else If r20kr15.Text = q15 Then r20kr15.ForeColor = Drawing.Color.Red
Q16a:   q16 = 0
        If r1kr16.Text = ("") Then GoTo Q17 Else If q16 > r1kr16.Text Then q16 = q16 Else q16 = r1kr16.Text
        If r2kr16.Text = ("") Then GoTo Q17 Else If q16 > r2kr16.Text Then q16 = q16 Else q16 = r2kr16.Text
        If r3kr16.Text = ("") Then GoTo Q17 Else If q16 > r3kr16.Text Then q16 = q16 Else q16 = r3kr16.Text
        If r4kr16.Text = ("") Then GoTo Q17 Else If q16 > r4kr16.Text Then q16 = q16 Else q16 = r4kr16.Text
        If r5kr16.Text = ("") Then GoTo Q17 Else If q16 > r5kr16.Text Then q16 = q16 Else q16 = r5kr16.Text
        If r6kr16.Text = ("") Then GoTo Q17 Else If q16 > r6kr16.Text Then q16 = q16 Else q16 = r6kr16.Text
        If r7kr16.Text = ("") Then GoTo Q17 Else If q16 > r7kr16.Text Then q16 = q16 Else q16 = r7kr16.Text
        If r8kr16.Text = ("") Then GoTo Q17 Else If q16 > r8kr16.Text Then q16 = q16 Else q16 = r8kr16.Text
        If r9kr16.Text = ("") Then GoTo Q17 Else If q16 > r9kr16.Text Then q16 = q16 Else q16 = r9kr16.Text
        If r10kr16.Text = ("") Then GoTo Q17 Else If q16 > r10kr16.Text Then q16 = q16 Else q16 = r10kr16.Text
        If r11kr16.Text = ("") Then GoTo Q17 Else If q16 > r11kr16.Text Then q16 = q16 Else q16 = r11kr16.Text
        If r12kr16.Text = ("") Then GoTo Q17 Else If q16 > r12kr16.Text Then q16 = q16 Else q16 = r12kr16.Text
        If r13kr16.Text = ("") Then GoTo Q17 Else If q16 > r13kr16.Text Then q16 = q16 Else q16 = r13kr16.Text
        If r14kr16.Text = ("") Then GoTo Q17 Else If q16 > r14kr16.Text Then q16 = q16 Else q16 = r14kr16.Text
        If r15kr16.Text = ("") Then GoTo Q17 Else If q16 > r15kr16.Text Then q16 = q16 Else q16 = r15kr16.Text
        If r16kr16.Text = ("") Then GoTo Q17 Else If q16 > r16kr16.Text Then q16 = q16 Else q16 = r16kr16.Text
        If r17kr16.Text = ("") Then GoTo Q17 Else If q16 > r17kr16.Text Then q16 = q16 Else q16 = r17kr16.Text
        If r18kr16.Text = ("") Then GoTo Q17 Else If q16 > r18kr16.Text Then q16 = q16 Else q16 = r18kr16.Text
        If r19kr16.Text = ("") Then GoTo Q17 Else If q16 > r19kr16.Text Then q16 = q16 Else q16 = r19kr16.Text
        If r20kr16.Text = ("") Then GoTo Q17 Else If q16 > r20kr16.Text Then q16 = q16 Else q16 = r20kr16.Text
Q17:    If r1kr16.Text = ("") Then GoTo Q17a Else If r1kr16.Text = q16 Then r1kr16.ForeColor = Drawing.Color.Red
        If r2kr16.Text = ("") Then GoTo Q17a Else If r2kr16.Text = q16 Then r2kr16.ForeColor = Drawing.Color.Red
        If r3kr16.Text = ("") Then GoTo Q17a Else If r3kr16.Text = q16 Then r3kr16.ForeColor = Drawing.Color.Red
        If r4kr16.Text = ("") Then GoTo Q17a Else If r4kr16.Text = q16 Then r4kr16.ForeColor = Drawing.Color.Red
        If r5kr16.Text = ("") Then GoTo Q17a Else If r5kr16.Text = q16 Then r5kr16.ForeColor = Drawing.Color.Red
        If r6kr16.Text = ("") Then GoTo Q17a Else If r6kr16.Text = q16 Then r6kr16.ForeColor = Drawing.Color.Red
        If r7kr16.Text = ("") Then GoTo Q17a Else If r7kr16.Text = q16 Then r7kr16.ForeColor = Drawing.Color.Red
        If r8kr16.Text = ("") Then GoTo Q17a Else If r8kr16.Text = q16 Then r8kr16.ForeColor = Drawing.Color.Red
        If r9kr16.Text = ("") Then GoTo Q17a Else If r9kr16.Text = q16 Then r9kr16.ForeColor = Drawing.Color.Red
        If r10kr16.Text = ("") Then GoTo Q17a Else If r10kr16.Text = q16 Then r10kr16.ForeColor = Drawing.Color.Red
        If r11kr16.Text = ("") Then GoTo Q17a Else If r11kr16.Text = q16 Then r11kr16.ForeColor = Drawing.Color.Red
        If r12kr16.Text = ("") Then GoTo Q17a Else If r12kr16.Text = q16 Then r12kr16.ForeColor = Drawing.Color.Red
        If r13kr16.Text = ("") Then GoTo Q17a Else If r13kr16.Text = q16 Then r13kr16.ForeColor = Drawing.Color.Red
        If r14kr16.Text = ("") Then GoTo Q17a Else If r14kr16.Text = q16 Then r14kr16.ForeColor = Drawing.Color.Red
        If r15kr16.Text = ("") Then GoTo Q17a Else If r15kr16.Text = q16 Then r15kr16.ForeColor = Drawing.Color.Red
        If r16kr16.Text = ("") Then GoTo Q17a Else If r16kr16.Text = q16 Then r16kr16.ForeColor = Drawing.Color.Red
        If r17kr16.Text = ("") Then GoTo Q17a Else If r17kr16.Text = q16 Then r17kr16.ForeColor = Drawing.Color.Red
        If r18kr16.Text = ("") Then GoTo Q17a Else If r18kr16.Text = q16 Then r18kr16.ForeColor = Drawing.Color.Red
        If r19kr16.Text = ("") Then GoTo Q17a Else If r19kr16.Text = q16 Then r19kr16.ForeColor = Drawing.Color.Red
        If r20kr16.Text = ("") Then GoTo Q17a Else If r20kr16.Text = q16 Then r20kr16.ForeColor = Drawing.Color.Red
Q17a:   q17 = 0
        If r1kr17.Text = ("") Then GoTo Q18 Else If q17 > r1kr17.Text Then q17 = q17 Else q17 = r1kr17.Text
        If r2kr17.Text = ("") Then GoTo Q18 Else If q17 > r2kr17.Text Then q17 = q17 Else q17 = r2kr17.Text
        If r3kr17.Text = ("") Then GoTo Q18 Else If q17 > r3kr17.Text Then q17 = q17 Else q17 = r3kr17.Text
        If r4kr17.Text = ("") Then GoTo Q18 Else If q17 > r4kr17.Text Then q17 = q17 Else q17 = r4kr17.Text
        If r5kr17.Text = ("") Then GoTo Q18 Else If q17 > r5kr17.Text Then q17 = q17 Else q17 = r5kr17.Text
        If r6kr17.Text = ("") Then GoTo Q18 Else If q17 > r6kr17.Text Then q17 = q17 Else q17 = r6kr17.Text
        If r7kr17.Text = ("") Then GoTo Q18 Else If q17 > r7kr17.Text Then q17 = q17 Else q17 = r7kr17.Text
        If r8kr17.Text = ("") Then GoTo Q18 Else If q17 > r8kr17.Text Then q17 = q17 Else q17 = r8kr17.Text
        If r9kr17.Text = ("") Then GoTo Q18 Else If q17 > r9kr17.Text Then q17 = q17 Else q17 = r9kr17.Text
        If r10kr17.Text = ("") Then GoTo Q18 Else If q17 > r10kr17.Text Then q17 = q17 Else q17 = r10kr17.Text
        If r11kr17.Text = ("") Then GoTo Q18 Else If q17 > r11kr17.Text Then q17 = q17 Else q17 = r11kr17.Text
        If r12kr17.Text = ("") Then GoTo Q18 Else If q17 > r12kr17.Text Then q17 = q17 Else q17 = r12kr17.Text
        If r13kr17.Text = ("") Then GoTo Q18 Else If q17 > r13kr17.Text Then q17 = q17 Else q17 = r13kr17.Text
        If r14kr17.Text = ("") Then GoTo Q18 Else If q17 > r14kr17.Text Then q17 = q17 Else q17 = r14kr17.Text
        If r15kr17.Text = ("") Then GoTo Q18 Else If q17 > r15kr17.Text Then q17 = q17 Else q17 = r15kr17.Text
        If r16kr17.Text = ("") Then GoTo Q18 Else If q17 > r16kr17.Text Then q17 = q17 Else q17 = r16kr17.Text
        If r17kr17.Text = ("") Then GoTo Q18 Else If q17 > r17kr17.Text Then q17 = q17 Else q17 = r17kr17.Text
        If r18kr17.Text = ("") Then GoTo Q18 Else If q17 > r18kr17.Text Then q17 = q17 Else q17 = r18kr17.Text
        If r19kr17.Text = ("") Then GoTo Q18 Else If q17 > r19kr17.Text Then q17 = q17 Else q17 = r19kr17.Text
        If r20kr17.Text = ("") Then GoTo Q18 Else If q17 > r20kr17.Text Then q17 = q17 Else q17 = r20kr17.Text
Q18:    If r1kr17.Text = ("") Then GoTo Q18a Else If r1kr17.Text = q17 Then r1kr17.ForeColor = Drawing.Color.Red
        If r2kr17.Text = ("") Then GoTo Q18a Else If r2kr17.Text = q17 Then r2kr17.ForeColor = Drawing.Color.Red
        If r3kr17.Text = ("") Then GoTo Q18a Else If r3kr17.Text = q17 Then r3kr17.ForeColor = Drawing.Color.Red
        If r4kr17.Text = ("") Then GoTo Q18a Else If r4kr17.Text = q17 Then r4kr17.ForeColor = Drawing.Color.Red
        If r5kr17.Text = ("") Then GoTo Q18a Else If r5kr17.Text = q17 Then r5kr17.ForeColor = Drawing.Color.Red
        If r6kr17.Text = ("") Then GoTo Q18a Else If r6kr17.Text = q17 Then r6kr17.ForeColor = Drawing.Color.Red
        If r7kr17.Text = ("") Then GoTo Q18a Else If r7kr17.Text = q17 Then r7kr17.ForeColor = Drawing.Color.Red
        If r8kr17.Text = ("") Then GoTo Q18a Else If r8kr17.Text = q17 Then r8kr17.ForeColor = Drawing.Color.Red
        If r9kr17.Text = ("") Then GoTo Q18a Else If r9kr17.Text = q17 Then r9kr17.ForeColor = Drawing.Color.Red
        If r10kr17.Text = ("") Then GoTo Q18a Else If r10kr17.Text = q17 Then r10kr17.ForeColor = Drawing.Color.Red
        If r11kr17.Text = ("") Then GoTo Q18a Else If r11kr17.Text = q17 Then r11kr17.ForeColor = Drawing.Color.Red
        If r12kr17.Text = ("") Then GoTo Q18a Else If r12kr17.Text = q17 Then r12kr17.ForeColor = Drawing.Color.Red
        If r13kr17.Text = ("") Then GoTo Q18a Else If r13kr17.Text = q17 Then r13kr17.ForeColor = Drawing.Color.Red
        If r14kr17.Text = ("") Then GoTo Q18a Else If r14kr17.Text = q17 Then r14kr17.ForeColor = Drawing.Color.Red
        If r15kr17.Text = ("") Then GoTo Q18a Else If r15kr17.Text = q17 Then r15kr17.ForeColor = Drawing.Color.Red
        If r16kr17.Text = ("") Then GoTo Q18a Else If r16kr17.Text = q17 Then r16kr17.ForeColor = Drawing.Color.Red
        If r17kr17.Text = ("") Then GoTo Q18a Else If r17kr17.Text = q17 Then r17kr17.ForeColor = Drawing.Color.Red
        If r18kr17.Text = ("") Then GoTo Q18a Else If r18kr17.Text = q17 Then r18kr17.ForeColor = Drawing.Color.Red
        If r19kr17.Text = ("") Then GoTo Q18a Else If r19kr17.Text = q17 Then r19kr17.ForeColor = Drawing.Color.Red
        If r20kr17.Text = ("") Then GoTo Q18a Else If r20kr17.Text = q17 Then r20kr17.ForeColor = Drawing.Color.Red
Q18a:   q18 = 0
        If r1kr18.Text = ("") Then GoTo Q19 Else If q18 > r1kr18.Text Then q18 = q18 Else q18 = r1kr18.Text
        If r2kr18.Text = ("") Then GoTo Q19 Else If q18 > r2kr18.Text Then q18 = q18 Else q18 = r2kr18.Text
        If r3kr18.Text = ("") Then GoTo Q19 Else If q18 > r3kr18.Text Then q18 = q18 Else q18 = r3kr18.Text
        If r4kr18.Text = ("") Then GoTo Q19 Else If q18 > r4kr18.Text Then q18 = q18 Else q18 = r4kr18.Text
        If r5kr18.Text = ("") Then GoTo Q19 Else If q18 > r5kr18.Text Then q18 = q18 Else q18 = r5kr18.Text
        If r6kr18.Text = ("") Then GoTo Q19 Else If q18 > r6kr18.Text Then q18 = q18 Else q18 = r6kr18.Text
        If r7kr18.Text = ("") Then GoTo Q19 Else If q18 > r7kr18.Text Then q18 = q18 Else q18 = r7kr18.Text
        If r8kr18.Text = ("") Then GoTo Q19 Else If q18 > r8kr18.Text Then q18 = q18 Else q18 = r8kr18.Text
        If r9kr18.Text = ("") Then GoTo Q19 Else If q18 > r9kr18.Text Then q18 = q18 Else q18 = r9kr18.Text
        If r10kr18.Text = ("") Then GoTo Q19 Else If q18 > r10kr18.Text Then q18 = q18 Else q18 = r10kr18.Text
        If r11kr18.Text = ("") Then GoTo Q19 Else If q18 > r11kr18.Text Then q18 = q18 Else q18 = r11kr18.Text
        If r12kr18.Text = ("") Then GoTo Q19 Else If q18 > r12kr18.Text Then q18 = q18 Else q18 = r12kr18.Text
        If r13kr18.Text = ("") Then GoTo Q19 Else If q18 > r13kr18.Text Then q18 = q18 Else q18 = r13kr18.Text
        If r14kr18.Text = ("") Then GoTo Q19 Else If q18 > r14kr18.Text Then q18 = q18 Else q18 = r14kr18.Text
        If r15kr18.Text = ("") Then GoTo Q19 Else If q18 > r15kr18.Text Then q18 = q18 Else q18 = r15kr18.Text
        If r16kr18.Text = ("") Then GoTo Q19 Else If q18 > r16kr18.Text Then q18 = q18 Else q18 = r16kr18.Text
        If r17kr18.Text = ("") Then GoTo Q19 Else If q18 > r17kr18.Text Then q18 = q18 Else q18 = r17kr18.Text
        If r18kr18.Text = ("") Then GoTo Q19 Else If q18 > r18kr18.Text Then q18 = q18 Else q18 = r18kr18.Text
        If r19kr18.Text = ("") Then GoTo Q19 Else If q18 > r19kr18.Text Then q18 = q18 Else q18 = r19kr18.Text
        If r20kr18.Text = ("") Then GoTo Q19 Else If q18 > r20kr18.Text Then q18 = q18 Else q18 = r20kr18.Text
Q19:    If r1kr18.Text = ("") Then GoTo Q19a Else If r1kr18.Text = q18 Then r1kr18.ForeColor = Drawing.Color.Red
        If r2kr18.Text = ("") Then GoTo Q19a Else If r2kr18.Text = q18 Then r2kr18.ForeColor = Drawing.Color.Red
        If r3kr18.Text = ("") Then GoTo Q19a Else If r3kr18.Text = q18 Then r3kr18.ForeColor = Drawing.Color.Red
        If r4kr18.Text = ("") Then GoTo Q19a Else If r4kr18.Text = q18 Then r4kr18.ForeColor = Drawing.Color.Red
        If r5kr18.Text = ("") Then GoTo Q19a Else If r5kr18.Text = q18 Then r5kr18.ForeColor = Drawing.Color.Red
        If r6kr18.Text = ("") Then GoTo Q19a Else If r6kr18.Text = q18 Then r6kr18.ForeColor = Drawing.Color.Red
        If r7kr18.Text = ("") Then GoTo Q19a Else If r7kr18.Text = q18 Then r7kr18.ForeColor = Drawing.Color.Red
        If r8kr18.Text = ("") Then GoTo Q19a Else If r8kr18.Text = q18 Then r8kr18.ForeColor = Drawing.Color.Red
        If r9kr18.Text = ("") Then GoTo Q19a Else If r9kr18.Text = q18 Then r9kr18.ForeColor = Drawing.Color.Red
        If r10kr18.Text = ("") Then GoTo Q19a Else If r10kr18.Text = q18 Then r10kr18.ForeColor = Drawing.Color.Red
        If r11kr18.Text = ("") Then GoTo Q19a Else If r11kr18.Text = q18 Then r11kr18.ForeColor = Drawing.Color.Red
        If r12kr18.Text = ("") Then GoTo Q19a Else If r12kr18.Text = q18 Then r12kr18.ForeColor = Drawing.Color.Red
        If r13kr18.Text = ("") Then GoTo Q19a Else If r13kr18.Text = q18 Then r13kr18.ForeColor = Drawing.Color.Red
        If r14kr18.Text = ("") Then GoTo Q19a Else If r14kr18.Text = q18 Then r14kr18.ForeColor = Drawing.Color.Red
        If r15kr18.Text = ("") Then GoTo Q19a Else If r15kr18.Text = q18 Then r15kr18.ForeColor = Drawing.Color.Red
        If r16kr18.Text = ("") Then GoTo Q19a Else If r16kr18.Text = q18 Then r16kr18.ForeColor = Drawing.Color.Red
        If r17kr18.Text = ("") Then GoTo Q19a Else If r17kr18.Text = q18 Then r17kr18.ForeColor = Drawing.Color.Red
        If r18kr18.Text = ("") Then GoTo Q19a Else If r18kr18.Text = q18 Then r18kr18.ForeColor = Drawing.Color.Red
        If r19kr18.Text = ("") Then GoTo Q19a Else If r19kr18.Text = q18 Then r19kr18.ForeColor = Drawing.Color.Red
        If r20kr18.Text = ("") Then GoTo Q19a Else If r20kr18.Text = q18 Then r20kr18.ForeColor = Drawing.Color.Red
Q19a:   q19 = 0
        If r1kr19.Text = ("") Then GoTo Q20 Else If q19 > r1kr19.Text Then q19 = q19 Else q19 = r1kr19.Text
        If r2kr19.Text = ("") Then GoTo Q20 Else If q19 > r2kr19.Text Then q19 = q19 Else q19 = r2kr19.Text
        If r3kr19.Text = ("") Then GoTo Q20 Else If q19 > r3kr19.Text Then q19 = q19 Else q19 = r3kr19.Text
        If r4kr19.Text = ("") Then GoTo Q20 Else If q19 > r4kr19.Text Then q19 = q19 Else q19 = r4kr19.Text
        If r5kr19.Text = ("") Then GoTo Q20 Else If q19 > r5kr19.Text Then q19 = q19 Else q19 = r5kr19.Text
        If r6kr19.Text = ("") Then GoTo Q20 Else If q19 > r6kr19.Text Then q19 = q19 Else q19 = r6kr19.Text
        If r7kr19.Text = ("") Then GoTo Q20 Else If q19 > r7kr19.Text Then q19 = q19 Else q19 = r7kr19.Text
        If r8kr19.Text = ("") Then GoTo Q20 Else If q19 > r8kr19.Text Then q19 = q19 Else q19 = r8kr19.Text
        If r9kr19.Text = ("") Then GoTo Q20 Else If q19 > r9kr19.Text Then q19 = q19 Else q19 = r9kr19.Text
        If r10kr19.Text = ("") Then GoTo Q20 Else If q19 > r10kr19.Text Then q19 = q19 Else q19 = r10kr19.Text
        If r11kr19.Text = ("") Then GoTo Q20 Else If q19 > r11kr19.Text Then q19 = q19 Else q19 = r11kr19.Text
        If r12kr19.Text = ("") Then GoTo Q20 Else If q19 > r12kr19.Text Then q19 = q19 Else q19 = r12kr19.Text
        If r13kr19.Text = ("") Then GoTo Q20 Else If q19 > r13kr19.Text Then q19 = q19 Else q19 = r13kr19.Text
        If r14kr19.Text = ("") Then GoTo Q20 Else If q19 > r14kr19.Text Then q19 = q19 Else q19 = r14kr19.Text
        If r15kr19.Text = ("") Then GoTo Q20 Else If q19 > r15kr19.Text Then q19 = q19 Else q19 = r15kr19.Text
        If r16kr19.Text = ("") Then GoTo Q20 Else If q19 > r16kr19.Text Then q19 = q19 Else q19 = r16kr19.Text
        If r17kr19.Text = ("") Then GoTo Q20 Else If q19 > r17kr19.Text Then q19 = q19 Else q19 = r17kr19.Text
        If r18kr19.Text = ("") Then GoTo Q20 Else If q19 > r18kr19.Text Then q19 = q19 Else q19 = r18kr19.Text
        If r19kr19.Text = ("") Then GoTo Q20 Else If q19 > r19kr19.Text Then q19 = q19 Else q19 = r19kr19.Text
        If r20kr19.Text = ("") Then GoTo Q20 Else If q19 > r20kr19.Text Then q19 = q19 Else q19 = r20kr19.Text
Q20:    If r1kr19.Text = ("") Then GoTo Q20a Else If r1kr19.Text = q19 Then r1kr19.ForeColor = Drawing.Color.Red
        If r2kr19.Text = ("") Then GoTo Q20a Else If r2kr19.Text = q19 Then r2kr19.ForeColor = Drawing.Color.Red
        If r3kr19.Text = ("") Then GoTo Q20a Else If r3kr19.Text = q19 Then r3kr19.ForeColor = Drawing.Color.Red
        If r4kr19.Text = ("") Then GoTo Q20a Else If r4kr19.Text = q19 Then r4kr19.ForeColor = Drawing.Color.Red
        If r5kr19.Text = ("") Then GoTo Q20a Else If r5kr19.Text = q19 Then r5kr19.ForeColor = Drawing.Color.Red
        If r6kr19.Text = ("") Then GoTo Q20a Else If r6kr19.Text = q19 Then r6kr19.ForeColor = Drawing.Color.Red
        If r7kr19.Text = ("") Then GoTo Q20a Else If r7kr19.Text = q19 Then r7kr19.ForeColor = Drawing.Color.Red
        If r8kr19.Text = ("") Then GoTo Q20a Else If r8kr19.Text = q19 Then r8kr19.ForeColor = Drawing.Color.Red
        If r9kr19.Text = ("") Then GoTo Q20a Else If r9kr19.Text = q19 Then r9kr19.ForeColor = Drawing.Color.Red
        If r10kr19.Text = ("") Then GoTo Q20a Else If r10kr19.Text = q19 Then r10kr19.ForeColor = Drawing.Color.Red
        If r11kr19.Text = ("") Then GoTo Q20a Else If r11kr19.Text = q19 Then r11kr19.ForeColor = Drawing.Color.Red
        If r12kr19.Text = ("") Then GoTo Q20a Else If r12kr19.Text = q19 Then r12kr19.ForeColor = Drawing.Color.Red
        If r13kr19.Text = ("") Then GoTo Q20a Else If r13kr19.Text = q19 Then r13kr19.ForeColor = Drawing.Color.Red
        If r14kr19.Text = ("") Then GoTo Q20a Else If r14kr19.Text = q19 Then r14kr19.ForeColor = Drawing.Color.Red
        If r15kr19.Text = ("") Then GoTo Q20a Else If r15kr19.Text = q19 Then r15kr19.ForeColor = Drawing.Color.Red
        If r16kr19.Text = ("") Then GoTo Q20a Else If r16kr19.Text = q19 Then r16kr19.ForeColor = Drawing.Color.Red
        If r17kr19.Text = ("") Then GoTo Q20a Else If r17kr19.Text = q19 Then r17kr19.ForeColor = Drawing.Color.Red
        If r18kr19.Text = ("") Then GoTo Q20a Else If r18kr19.Text = q19 Then r18kr19.ForeColor = Drawing.Color.Red
        If r19kr19.Text = ("") Then GoTo Q20a Else If r19kr19.Text = q19 Then r19kr19.ForeColor = Drawing.Color.Red
        If r20kr19.Text = ("") Then GoTo Q20a Else If r20kr19.Text = q19 Then r20kr19.ForeColor = Drawing.Color.Red
Q20a:   q20 = 0
        If r1kr20.Text = ("") Then GoTo Q21 Else If q20 > r1kr20.Text Then q20 = q20 Else q20 = r1kr20.Text
        If r2kr20.Text = ("") Then GoTo Q21 Else If q20 > r2kr20.Text Then q20 = q20 Else q20 = r2kr20.Text
        If r3kr20.Text = ("") Then GoTo Q21 Else If q20 > r3kr20.Text Then q20 = q20 Else q20 = r3kr20.Text
        If r4kr20.Text = ("") Then GoTo Q21 Else If q20 > r4kr20.Text Then q20 = q20 Else q20 = r4kr20.Text
        If r5kr20.Text = ("") Then GoTo Q21 Else If q20 > r5kr20.Text Then q20 = q20 Else q20 = r5kr20.Text
        If r6kr20.Text = ("") Then GoTo Q21 Else If q20 > r6kr20.Text Then q20 = q20 Else q20 = r6kr20.Text
        If r7kr20.Text = ("") Then GoTo Q21 Else If q20 > r7kr20.Text Then q20 = q20 Else q20 = r7kr20.Text
        If r8kr20.Text = ("") Then GoTo Q21 Else If q20 > r8kr20.Text Then q20 = q20 Else q20 = r8kr20.Text
        If r9kr20.Text = ("") Then GoTo Q21 Else If q20 > r9kr20.Text Then q20 = q20 Else q20 = r9kr20.Text
        If r10kr20.Text = ("") Then GoTo Q21 Else If q20 > r10kr20.Text Then q20 = q20 Else q20 = r10kr20.Text
        If r11kr20.Text = ("") Then GoTo Q21 Else If q20 > r11kr20.Text Then q20 = q20 Else q20 = r11kr20.Text
        If r12kr20.Text = ("") Then GoTo Q21 Else If q20 > r12kr20.Text Then q20 = q20 Else q20 = r12kr20.Text
        If r13kr20.Text = ("") Then GoTo Q21 Else If q20 > r13kr20.Text Then q20 = q20 Else q20 = r13kr20.Text
        If r14kr20.Text = ("") Then GoTo Q21 Else If q20 > r14kr20.Text Then q20 = q20 Else q20 = r14kr20.Text
        If r15kr20.Text = ("") Then GoTo Q21 Else If q20 > r15kr20.Text Then q20 = q20 Else q20 = r15kr20.Text
        If r16kr20.Text = ("") Then GoTo Q21 Else If q20 > r16kr20.Text Then q20 = q20 Else q20 = r16kr20.Text
        If r17kr20.Text = ("") Then GoTo Q21 Else If q20 > r17kr20.Text Then q20 = q20 Else q20 = r17kr20.Text
        If r18kr20.Text = ("") Then GoTo Q21 Else If q20 > r18kr20.Text Then q20 = q20 Else q20 = r18kr20.Text
        If r19kr20.Text = ("") Then GoTo Q21 Else If q20 > r19kr20.Text Then q20 = q20 Else q20 = r19kr20.Text
        If r20kr20.Text = ("") Then GoTo Q21 Else If q20 > r20kr20.Text Then q20 = q20 Else q20 = r20kr20.Text
Q21:    If r1kr20.Text = ("") Then GoTo Q21a Else If r1kr20.Text = q20 Then r1kr20.ForeColor = Drawing.Color.Red
        If r2kr20.Text = ("") Then GoTo Q21a Else If r2kr20.Text = q20 Then r2kr20.ForeColor = Drawing.Color.Red
        If r3kr20.Text = ("") Then GoTo Q21a Else If r3kr20.Text = q20 Then r3kr20.ForeColor = Drawing.Color.Red
        If r4kr20.Text = ("") Then GoTo Q21a Else If r4kr20.Text = q20 Then r4kr20.ForeColor = Drawing.Color.Red
        If r5kr20.Text = ("") Then GoTo Q21a Else If r5kr20.Text = q20 Then r5kr20.ForeColor = Drawing.Color.Red
        If r6kr20.Text = ("") Then GoTo Q21a Else If r6kr20.Text = q20 Then r6kr20.ForeColor = Drawing.Color.Red
        If r7kr20.Text = ("") Then GoTo Q21a Else If r7kr20.Text = q20 Then r7kr20.ForeColor = Drawing.Color.Red
        If r8kr20.Text = ("") Then GoTo Q21a Else If r8kr20.Text = q20 Then r8kr20.ForeColor = Drawing.Color.Red
        If r9kr20.Text = ("") Then GoTo Q21a Else If r9kr20.Text = q20 Then r9kr20.ForeColor = Drawing.Color.Red
        If r10kr20.Text = ("") Then GoTo Q21a Else If r10kr20.Text = q20 Then r10kr20.ForeColor = Drawing.Color.Red
        If r11kr20.Text = ("") Then GoTo Q21a Else If r11kr20.Text = q20 Then r11kr20.ForeColor = Drawing.Color.Red
        If r12kr20.Text = ("") Then GoTo Q21a Else If r12kr20.Text = q20 Then r12kr20.ForeColor = Drawing.Color.Red
        If r13kr20.Text = ("") Then GoTo Q21a Else If r13kr20.Text = q20 Then r13kr20.ForeColor = Drawing.Color.Red
        If r14kr20.Text = ("") Then GoTo Q21a Else If r14kr20.Text = q20 Then r14kr20.ForeColor = Drawing.Color.Red
        If r15kr20.Text = ("") Then GoTo Q21a Else If r15kr20.Text = q20 Then r15kr20.ForeColor = Drawing.Color.Red
        If r16kr20.Text = ("") Then GoTo Q21a Else If r16kr20.Text = q20 Then r16kr20.ForeColor = Drawing.Color.Red
        If r17kr20.Text = ("") Then GoTo Q21a Else If r17kr20.Text = q20 Then r17kr20.ForeColor = Drawing.Color.Red
        If r18kr20.Text = ("") Then GoTo Q21a Else If r18kr20.Text = q20 Then r18kr20.ForeColor = Drawing.Color.Red
        If r19kr20.Text = ("") Then GoTo Q21a Else If r19kr20.Text = q20 Then r19kr20.ForeColor = Drawing.Color.Red
        If r20kr20.Text = ("") Then GoTo Q21a Else If r20kr20.Text = q20 Then r20kr20.ForeColor = Drawing.Color.Red
Q21a:
    End Sub

    Private Sub Derivacije()

        Dim MaxBank(20)
        Dim BestU(20)
        BestY = 0
        tt = sysoutofY.Text
        Dim ch(21)

        ch(0) = ch0.Text
        ch(1) = ch1.Text
        ch(2) = ch2.Text
        ch(3) = ch3.Text
        ch(4) = ch4.Text
        ch(5) = ch5.Text
        ch(6) = ch6.Text
        ch(7) = ch7.Text
        ch(8) = ch8.Text
        ch(9) = ch9.Text
        ch(10) = ch10.Text
        ch(11) = ch11.Text
        ch(12) = ch12.Text
        ch(13) = ch13.Text
        ch(14) = ch14.Text
        ch(15) = ch15.Text
        ch(16) = ch16.Text
        ch(17) = ch17.Text
        ch(18) = ch18.Text
        ch(19) = ch19.Text
        ch(20) = ch20.Text

        Dim KK1(21)

        KK1(0) = r1kr0.Text
        KK1(1) = r1kr1.Text
        KK1(2) = r1kr2.Text
        KK1(3) = r1kr3.Text
        KK1(4) = r1kr4.Text
        KK1(5) = r1kr5.Text
        KK1(6) = r1kr6.Text
        KK1(7) = r1kr7.Text
        KK1(8) = r1kr8.Text
        KK1(9) = r1kr9.Text
        KK1(10) = r1kr10.Text
        KK1(11) = r1kr11.Text
        KK1(12) = r1kr12.Text
        KK1(13) = r1kr13.Text
        KK1(14) = r1kr14.Text
        KK1(15) = r1kr15.Text
        KK1(16) = r1kr16.Text
        KK1(17) = r1kr17.Text
        KK1(18) = r1kr18.Text
        KK1(19) = r1kr19.Text
        KK1(20) = r1kr20.Text

        Dim KK2(21)

        KK2(0) = r2kr0.Text
        KK2(1) = r2kr1.Text
        KK2(2) = r2kr2.Text
        KK2(3) = r2kr3.Text
        KK2(4) = r2kr4.Text
        KK2(5) = r2kr5.Text
        KK2(6) = r2kr6.Text
        KK2(7) = r2kr7.Text
        KK2(8) = r2kr8.Text
        KK2(9) = r2kr9.Text
        KK2(10) = r2kr10.Text
        KK2(11) = r2kr11.Text
        KK2(12) = r2kr12.Text
        KK2(13) = r2kr13.Text
        KK2(14) = r2kr14.Text
        KK2(15) = r2kr15.Text
        KK2(16) = r2kr16.Text
        KK2(17) = r2kr17.Text
        KK2(18) = r2kr18.Text
        KK2(19) = r2kr19.Text
        KK2(20) = r2kr20.Text

        Dim KK3(21)

        KK3(0) = r3kr0.Text
        KK3(1) = r3kr1.Text
        KK3(2) = r3kr2.Text
        KK3(3) = r3kr3.Text
        KK3(4) = r3kr4.Text
        KK3(5) = r3kr5.Text
        KK3(6) = r3kr6.Text
        KK3(7) = r3kr7.Text
        KK3(8) = r3kr8.Text
        KK3(9) = r3kr9.Text
        KK3(10) = r3kr10.Text
        KK3(11) = r3kr11.Text
        KK3(12) = r3kr12.Text
        KK3(13) = r3kr13.Text
        KK3(14) = r3kr14.Text
        KK3(15) = r3kr15.Text
        KK3(16) = r3kr16.Text
        KK3(17) = r3kr17.Text
        KK3(18) = r3kr18.Text
        KK3(19) = r3kr19.Text
        KK3(20) = r3kr20.Text

        Dim KK4(21)

        KK4(0) = r4kr0.Text
        KK4(1) = r4kr1.Text
        KK4(2) = r4kr2.Text
        KK4(3) = r4kr3.Text
        KK4(4) = r4kr4.Text
        KK4(5) = r4kr5.Text
        KK4(6) = r4kr6.Text
        KK4(7) = r4kr7.Text
        KK4(8) = r4kr8.Text
        KK4(9) = r4kr9.Text
        KK4(10) = r4kr10.Text
        KK4(11) = r4kr11.Text
        KK4(12) = r4kr12.Text
        KK4(13) = r4kr13.Text
        KK4(14) = r4kr14.Text
        KK4(15) = r4kr15.Text
        KK4(16) = r4kr16.Text
        KK4(17) = r4kr17.Text
        KK4(18) = r4kr18.Text
        KK4(19) = r4kr19.Text
        KK4(20) = r4kr20.Text

        Dim KK5(21)

        KK5(0) = r5kr0.Text
        KK5(1) = r5kr1.Text
        KK5(2) = r5kr2.Text
        KK5(3) = r5kr3.Text
        KK5(4) = r5kr4.Text
        KK5(5) = r5kr5.Text
        KK5(6) = r5kr6.Text
        KK5(7) = r5kr7.Text
        KK5(8) = r5kr8.Text
        KK5(9) = r5kr9.Text
        KK5(10) = r5kr10.Text
        KK5(11) = r5kr11.Text
        KK5(12) = r5kr12.Text
        KK5(13) = r5kr13.Text
        KK5(14) = r5kr14.Text
        KK5(15) = r5kr15.Text
        KK5(16) = r5kr16.Text
        KK5(17) = r5kr17.Text
        KK5(18) = r5kr18.Text
        KK5(19) = r5kr19.Text
        KK5(20) = r5kr20.Text

        Dim KK6(21)

        KK6(0) = r6kr0.Text
        KK6(1) = r6kr1.Text
        KK6(2) = r6kr2.Text
        KK6(3) = r6kr3.Text
        KK6(4) = r6kr4.Text
        KK6(5) = r6kr5.Text
        KK6(6) = r6kr6.Text
        KK6(7) = r6kr7.Text
        KK6(8) = r6kr8.Text
        KK6(9) = r6kr9.Text
        KK6(10) = r6kr10.Text
        KK6(11) = r6kr11.Text
        KK6(12) = r6kr12.Text
        KK6(13) = r6kr13.Text
        KK6(14) = r6kr14.Text
        KK6(15) = r6kr15.Text
        KK6(16) = r6kr16.Text
        KK6(17) = r6kr17.Text
        KK6(18) = r6kr18.Text
        KK6(19) = r6kr19.Text
        KK6(20) = r6kr20.Text

        Dim KK7(21)

        KK7(0) = r7kr0.Text
        KK7(1) = r7kr1.Text
        KK7(2) = r7kr2.Text
        KK7(3) = r7kr3.Text
        KK7(4) = r7kr4.Text
        KK7(5) = r7kr5.Text
        KK7(6) = r7kr6.Text
        KK7(7) = r7kr7.Text
        KK7(8) = r7kr8.Text
        KK7(9) = r7kr9.Text
        KK7(10) = r7kr10.Text
        KK7(11) = r7kr11.Text
        KK7(12) = r7kr12.Text
        KK7(13) = r7kr13.Text
        KK7(14) = r7kr14.Text
        KK7(15) = r7kr15.Text
        KK7(16) = r7kr16.Text
        KK7(17) = r7kr17.Text
        KK7(18) = r7kr18.Text
        KK7(19) = r7kr19.Text
        KK7(20) = r7kr20.Text

        Dim KK8(21)

        KK8(0) = r8kr0.Text
        KK8(1) = r8kr1.Text
        KK8(2) = r8kr2.Text
        KK8(3) = r8kr3.Text
        KK8(4) = r8kr4.Text
        KK8(5) = r8kr5.Text
        KK8(6) = r8kr6.Text
        KK8(7) = r8kr7.Text
        KK8(8) = r8kr8.Text
        KK8(9) = r8kr9.Text
        KK8(10) = r8kr10.Text
        KK8(11) = r8kr11.Text
        KK8(12) = r8kr12.Text
        KK8(13) = r8kr13.Text
        KK8(14) = r8kr14.Text
        KK8(15) = r8kr15.Text
        KK8(16) = r8kr16.Text
        KK8(17) = r8kr17.Text
        KK8(18) = r8kr18.Text
        KK8(19) = r8kr19.Text
        KK8(20) = r8kr20.Text

        Dim KK9(21)

        KK9(0) = r9kr0.Text
        KK9(1) = r9kr1.Text
        KK9(2) = r9kr2.Text
        KK9(3) = r9kr3.Text
        KK9(4) = r9kr4.Text
        KK9(5) = r9kr5.Text
        KK9(6) = r9kr6.Text
        KK9(7) = r9kr7.Text
        KK9(8) = r9kr8.Text
        KK9(9) = r9kr9.Text
        KK9(10) = r9kr10.Text
        KK9(11) = r9kr11.Text
        KK9(12) = r9kr12.Text
        KK9(13) = r9kr13.Text
        KK9(14) = r9kr14.Text
        KK9(15) = r9kr15.Text
        KK9(16) = r9kr16.Text
        KK9(17) = r9kr17.Text
        KK9(18) = r9kr18.Text
        KK9(19) = r9kr19.Text
        KK9(20) = r9kr20.Text

        Dim KK10(21)

        KK10(0) = r10kr0.Text
        KK10(1) = r10kr1.Text
        KK10(2) = r10kr2.Text
        KK10(3) = r10kr3.Text
        KK10(4) = r10kr4.Text
        KK10(5) = r10kr5.Text
        KK10(6) = r10kr6.Text
        KK10(7) = r10kr7.Text
        KK10(8) = r10kr8.Text
        KK10(9) = r10kr9.Text
        KK10(10) = r10kr10.Text
        KK10(11) = r10kr11.Text
        KK10(12) = r10kr12.Text
        KK10(13) = r10kr13.Text
        KK10(14) = r10kr14.Text
        KK10(15) = r10kr15.Text
        KK10(16) = r10kr16.Text
        KK10(17) = r10kr17.Text
        KK10(18) = r10kr18.Text
        KK10(19) = r10kr19.Text
        KK10(20) = r10kr20.Text

        Dim KK11(21)

        KK11(0) = r11kr0.Text
        KK11(1) = r11kr1.Text
        KK11(2) = r11kr2.Text
        KK11(3) = r11kr3.Text
        KK11(4) = r11kr4.Text
        KK11(5) = r11kr5.Text
        KK11(6) = r11kr6.Text
        KK11(7) = r11kr7.Text
        KK11(8) = r11kr8.Text
        KK11(9) = r11kr9.Text
        KK11(10) = r11kr10.Text
        KK11(11) = r11kr11.Text
        KK11(12) = r11kr12.Text
        KK11(13) = r11kr13.Text
        KK11(14) = r11kr14.Text
        KK11(15) = r11kr15.Text
        KK11(16) = r11kr16.Text
        KK11(17) = r11kr17.Text
        KK11(18) = r11kr18.Text
        KK11(19) = r11kr19.Text
        KK11(20) = r11kr20.Text

        Dim KK12(21)

        KK12(0) = r12kr0.Text
        KK12(1) = r12kr1.Text
        KK12(2) = r12kr2.Text
        KK12(3) = r12kr3.Text
        KK12(4) = r12kr4.Text
        KK12(5) = r12kr5.Text
        KK12(6) = r12kr6.Text
        KK12(7) = r12kr7.Text
        KK12(8) = r12kr8.Text
        KK12(9) = r12kr9.Text
        KK12(10) = r12kr10.Text
        KK12(11) = r12kr11.Text
        KK12(12) = r12kr12.Text
        KK12(13) = r12kr13.Text
        KK12(14) = r12kr14.Text
        KK12(15) = r12kr15.Text
        KK12(16) = r12kr16.Text
        KK12(17) = r12kr17.Text
        KK12(18) = r12kr18.Text
        KK12(19) = r12kr19.Text
        KK12(20) = r12kr20.Text

        Dim KK13(21)

        KK13(0) = r13kr0.Text
        KK13(1) = r13kr1.Text
        KK13(2) = r13kr2.Text
        KK13(3) = r13kr3.Text
        KK13(4) = r13kr4.Text
        KK13(5) = r13kr5.Text
        KK13(6) = r13kr6.Text
        KK13(7) = r13kr7.Text
        KK13(8) = r13kr8.Text
        KK13(9) = r13kr9.Text
        KK13(10) = r13kr10.Text
        KK13(11) = r13kr11.Text
        KK13(12) = r13kr12.Text
        KK13(13) = r13kr13.Text
        KK13(14) = r13kr14.Text
        KK13(15) = r13kr15.Text
        KK13(16) = r13kr16.Text
        KK13(17) = r13kr17.Text
        KK13(18) = r13kr18.Text
        KK13(19) = r13kr19.Text
        KK13(20) = r13kr20.Text

        Dim KK14(21)

        KK14(0) = r14kr0.Text
        KK14(1) = r14kr1.Text
        KK14(2) = r14kr2.Text
        KK14(3) = r14kr3.Text
        KK14(4) = r14kr4.Text
        KK14(5) = r14kr5.Text
        KK14(6) = r14kr6.Text
        KK14(7) = r14kr7.Text
        KK14(8) = r14kr8.Text
        KK14(9) = r14kr9.Text
        KK14(10) = r14kr10.Text
        KK14(11) = r14kr11.Text
        KK14(12) = r14kr12.Text
        KK14(13) = r14kr13.Text
        KK14(14) = r14kr14.Text
        KK14(15) = r14kr15.Text
        KK14(16) = r14kr16.Text
        KK14(17) = r14kr17.Text
        KK14(18) = r14kr18.Text
        KK14(19) = r14kr19.Text
        KK14(20) = r14kr20.Text

        Dim KK15(21)

        KK15(0) = r15kr0.Text
        KK15(1) = r15kr1.Text
        KK15(2) = r15kr2.Text
        KK15(3) = r15kr3.Text
        KK15(4) = r15kr4.Text
        KK15(5) = r15kr5.Text
        KK15(6) = r15kr6.Text
        KK15(7) = r15kr7.Text
        KK15(8) = r15kr8.Text
        KK15(9) = r15kr9.Text
        KK15(10) = r15kr10.Text
        KK15(11) = r15kr11.Text
        KK15(12) = r15kr12.Text
        KK15(13) = r15kr13.Text
        KK15(14) = r15kr14.Text
        KK15(15) = r15kr15.Text
        KK15(16) = r15kr16.Text
        KK15(17) = r15kr17.Text
        KK15(18) = r15kr18.Text
        KK15(19) = r15kr19.Text
        KK15(20) = r15kr20.Text

        Dim KK16(21)

        KK16(0) = r16kr0.Text
        KK16(1) = r16kr1.Text
        KK16(2) = r16kr2.Text
        KK16(3) = r16kr3.Text
        KK16(4) = r16kr4.Text
        KK16(5) = r16kr5.Text
        KK16(6) = r16kr6.Text
        KK16(7) = r16kr7.Text
        KK16(8) = r16kr8.Text
        KK16(9) = r16kr9.Text
        KK16(10) = r16kr10.Text
        KK16(11) = r16kr11.Text
        KK16(12) = r16kr12.Text
        KK16(13) = r16kr13.Text
        KK16(14) = r16kr14.Text
        KK16(15) = r16kr15.Text
        KK16(16) = r16kr16.Text
        KK16(17) = r16kr17.Text
        KK16(18) = r16kr18.Text
        KK16(19) = r16kr19.Text
        KK16(20) = r16kr20.Text

        Dim KK17(21)

        KK17(0) = r17kr0.Text
        KK17(1) = r17kr1.Text
        KK17(2) = r17kr2.Text
        KK17(3) = r17kr3.Text
        KK17(4) = r17kr4.Text
        KK17(5) = r17kr5.Text
        KK17(6) = r17kr6.Text
        KK17(7) = r17kr7.Text
        KK17(8) = r17kr8.Text
        KK17(9) = r17kr9.Text
        KK17(10) = r17kr10.Text
        KK17(11) = r17kr11.Text
        KK17(12) = r17kr12.Text
        KK17(13) = r17kr13.Text
        KK17(14) = r17kr14.Text
        KK17(15) = r17kr15.Text
        KK17(16) = r17kr16.Text
        KK17(17) = r17kr17.Text
        KK17(18) = r17kr18.Text
        KK17(19) = r17kr19.Text
        KK17(20) = r17kr20.Text

        Dim KK18(21)

        KK18(0) = r18kr0.Text
        KK18(1) = r18kr1.Text
        KK18(2) = r18kr2.Text
        KK18(3) = r18kr3.Text
        KK18(4) = r18kr4.Text
        KK18(5) = r18kr5.Text
        KK18(6) = r18kr6.Text
        KK18(7) = r18kr7.Text
        KK18(8) = r18kr8.Text
        KK18(9) = r18kr9.Text
        KK18(10) = r18kr10.Text
        KK18(11) = r18kr11.Text
        KK18(12) = r18kr12.Text
        KK18(13) = r18kr13.Text
        KK18(14) = r18kr14.Text
        KK18(15) = r18kr15.Text
        KK18(16) = r18kr16.Text
        KK18(17) = r18kr17.Text
        KK18(18) = r18kr18.Text
        KK18(19) = r18kr19.Text
        KK18(20) = r18kr20.Text

        Dim KK19(21)

        KK19(0) = r19kr0.Text
        KK19(1) = r19kr1.Text
        KK19(2) = r19kr2.Text
        KK19(3) = r19kr3.Text
        KK19(4) = r19kr4.Text
        KK19(5) = r19kr5.Text
        KK19(6) = r19kr6.Text
        KK19(7) = r19kr7.Text
        KK19(8) = r19kr8.Text
        KK19(9) = r19kr9.Text
        KK19(10) = r19kr10.Text
        KK19(11) = r19kr11.Text
        KK19(12) = r19kr12.Text
        KK19(13) = r19kr13.Text
        KK19(14) = r19kr14.Text
        KK19(15) = r19kr15.Text
        KK19(16) = r19kr16.Text
        KK19(17) = r19kr17.Text
        KK19(18) = r19kr18.Text
        KK19(19) = r19kr19.Text
        KK19(20) = r19kr20.Text

        Dim KK20(21)

        KK20(0) = r20kr0.Text
        KK20(1) = r20kr1.Text
        KK20(2) = r20kr2.Text
        KK20(3) = r20kr3.Text
        KK20(4) = r20kr4.Text
        KK20(5) = r20kr5.Text
        KK20(6) = r20kr6.Text
        KK20(7) = r20kr7.Text
        KK20(8) = r20kr8.Text
        KK20(9) = r20kr9.Text
        KK20(10) = r20kr10.Text
        KK20(11) = r20kr11.Text
        KK20(12) = r20kr12.Text
        KK20(13) = r20kr13.Text
        KK20(14) = r20kr14.Text
        KK20(15) = r20kr15.Text
        KK20(16) = r20kr16.Text
        KK20(17) = r20kr17.Text
        KK20(18) = r20kr18.Text
        KK20(19) = r20kr19.Text
        KK20(20) = r20kr20.Text

        If sysoutofY.Text = ("20") Then GoTo d20
        If sysoutofY.Text = ("19") Then GoTo d19
        If sysoutofY.Text = ("18") Then GoTo d18
        If sysoutofY.Text = ("17") Then GoTo d17
        If sysoutofY.Text = ("16") Then GoTo d16
        If sysoutofY.Text = ("15") Then GoTo d15
        If sysoutofY.Text = ("14") Then GoTo d14
        If sysoutofY.Text = ("13") Then GoTo d13
        If sysoutofY.Text = ("12") Then GoTo d12
        If sysoutofY.Text = ("11") Then GoTo d11
        If sysoutofY.Text = ("10") Then GoTo d10
        If sysoutofY.Text = ("09") Then GoTo d9
        If sysoutofY.Text = ("08") Then GoTo d8
        If sysoutofY.Text = ("07") Then GoTo d7
        If sysoutofY.Text = ("06") Then GoTo d6
        If sysoutofY.Text = ("05") Then GoTo d5
        If sysoutofY.Text = ("04") Then GoTo d4
        If sysoutofY.Text = ("03") Then GoTo d3
        If sysoutofY.Text = ("02") Then GoTo d2
        If sysoutofY.Text = ("01") Then GoTo d1

d20:    MaxBank20 = 0
        BestU20 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK20(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank20 > gg Then MaxBank20 = MaxBank20 Else MaxBank20 = gg
            If MaxBank20 > gg Then BestU20 = BestU20 Else BestU20 = ulozi

        Next ulozi

d19:    MaxBank19 = 0
        BestU19 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK19(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank19 > gg Then MaxBank19 = MaxBank19 Else MaxBank19 = gg
            If MaxBank19 > gg Then BestU19 = BestU19 Else BestU19 = ulozi

        Next ulozi

d18:    MaxBank18 = 0
        BestU18 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK18(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank18 > gg Then MaxBank18 = MaxBank18 Else MaxBank18 = gg
            If MaxBank18 > gg Then BestU18 = BestU18 Else BestU18 = ulozi

        Next ulozi

d17:    MaxBank17 = 0
        BestU17 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK17(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank17 > gg Then MaxBank17 = MaxBank17 Else MaxBank17 = gg
            If MaxBank17 > gg Then BestU17 = BestU17 Else BestU17 = ulozi

        Next ulozi

d16:    MaxBank16 = 0
        BestU16 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK16(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank16 > gg Then MaxBank16 = MaxBank16 Else MaxBank16 = gg
            If MaxBank16 > gg Then BestU16 = BestU16 Else BestU16 = ulozi

        Next ulozi

d15:    MaxBank15 = 0
        BestU15 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK15(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank15 > gg Then MaxBank15 = MaxBank15 Else MaxBank15 = gg
            If MaxBank15 > gg Then BestU15 = BestU15 Else BestU15 = ulozi

        Next ulozi

d14:    MaxBank14 = 0
        BestU14 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK14(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank14 > gg Then MaxBank14 = MaxBank14 Else MaxBank14 = gg
            If MaxBank14 > gg Then BestU14 = BestU14 Else BestU14 = ulozi

        Next ulozi

d13:    MaxBank13 = 0
        BestU13 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK13(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank13 > gg Then MaxBank13 = MaxBank13 Else MaxBank13 = gg
            If MaxBank13 > gg Then BestU13 = BestU13 Else BestU13 = ulozi

        Next ulozi

d12:    MaxBank12 = 0
        BestU12 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK12(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank12 > gg Then MaxBank12 = MaxBank12 Else MaxBank12 = gg
            If MaxBank12 > gg Then BestU12 = BestU12 Else BestU12 = ulozi

        Next ulozi

d11:    MaxBank11 = 0
        BestU11 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK11(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank11 > gg Then MaxBank11 = MaxBank11 Else MaxBank11 = gg
            If MaxBank11 > gg Then BestU11 = BestU11 Else BestU11 = ulozi

        Next ulozi

d10:    MaxBank10 = 0
        BestU10 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK10(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank10 > gg Then MaxBank10 = MaxBank10 Else MaxBank10 = gg
            If MaxBank10 > gg Then BestU10 = BestU10 Else BestU10 = ulozi

        Next ulozi

d9:     MaxBank9 = 0
        BestU9 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK9(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank9 > gg Then MaxBank9 = MaxBank9 Else MaxBank9 = gg
            If MaxBank9 > gg Then BestU9 = BestU9 Else BestU9 = ulozi

        Next ulozi

d8:     MaxBank8 = 0
        BestU8 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK8(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank8 > gg Then MaxBank8 = MaxBank8 Else MaxBank8 = gg
            If MaxBank8 > gg Then BestU8 = BestU8 Else BestU8 = ulozi

        Next ulozi

d7:     MaxBank7 = 0
        BestU7 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK7(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank7 > gg Then MaxBank7 = MaxBank7 Else MaxBank7 = gg
            If MaxBank7 > gg Then BestU7 = BestU7 Else BestU7 = ulozi

        Next ulozi

d6:     MaxBank6 = 0
        BestU6 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK6(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank6 > gg Then MaxBank6 = MaxBank6 Else MaxBank6 = gg
            If MaxBank6 > gg Then BestU6 = BestU6 Else BestU6 = ulozi

        Next ulozi

d5:     MaxBank5 = 0
        BestU5 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK5(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank5 > gg Then MaxBank5 = MaxBank5 Else MaxBank5 = gg
            If MaxBank5 > gg Then BestU5 = BestU5 Else BestU5 = ulozi

        Next ulozi

d4:     MaxBank4 = 0
        BestU4 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK4(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank4 > gg Then MaxBank4 = MaxBank4 Else MaxBank4 = gg
            If MaxBank4 > gg Then BestU4 = BestU4 Else BestU4 = ulozi

        Next ulozi

d3:     MaxBank3 = 0
        BestU3 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK3(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank3 > gg Then MaxBank3 = MaxBank3 Else MaxBank3 = gg
            If MaxBank3 > gg Then BestU3 = BestU3 Else BestU3 = ulozi

        Next ulozi

d2:     MaxBank2 = 0
        BestU2 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK2(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank2 > gg Then MaxBank2 = MaxBank2 Else MaxBank2 = gg
            If MaxBank2 > gg Then BestU2 = BestU2 Else BestU2 = ulozi

        Next ulozi

d1:     MaxBank1 = 0
        BestU1 = 0

        For ulozi = 0 To 1 Step 0.001
            gg = 1

            For ll = 0 To tt

                BestY = (1 + ulozi * (KK1(ll) - 1)) ^ (ch(ll) / 100)
                gg = gg * BestY

            Next ll

            If MaxBank1 > gg Then MaxBank1 = MaxBank1 Else MaxBank1 = gg
            If MaxBank1 > gg Then BestU1 = BestU1 Else BestU1 = ulozi

        Next ulozi
d0:

    End Sub

    Protected Sub AdvancedBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AdvancedBtn.Click

        Call Derivacije()
        ddd = 0
        If MaxBank1 = 0 Then MaxBa1.Text = ("") Else MaxBa1.Text = FormatNumber(MaxBank1, 3)
        If MaxBank2 = 0 Then MaxBa2.Text = ("") Else MaxBa2.Text = FormatNumber(MaxBank2, 3)
        If MaxBank3 = 0 Then MaxBa3.Text = ("") Else MaxBa3.Text = FormatNumber(MaxBank3, 3)
        If MaxBank4 = 0 Then MaxBa4.Text = ("") Else MaxBa4.Text = FormatNumber(MaxBank4, 3)
        If MaxBank5 = 0 Then MaxBa5.Text = ("") Else MaxBa5.Text = FormatNumber(MaxBank5, 3)
        If MaxBank6 = 0 Then MaxBa6.Text = ("") Else MaxBa6.Text = FormatNumber(MaxBank6, 3)
        If MaxBank7 = 0 Then MaxBa7.Text = ("") Else MaxBa7.Text = FormatNumber(MaxBank7, 3)
        If MaxBank8 = 0 Then MaxBa8.Text = ("") Else MaxBa8.Text = FormatNumber(MaxBank8, 3)
        If MaxBank9 = 0 Then MaxBa9.Text = ("") Else MaxBa9.Text = FormatNumber(MaxBank9, 3)
        If MaxBank10 = 0 Then MaxBa10.Text = ("") Else MaxBa10.Text = FormatNumber(MaxBank10, 3)
        If MaxBank11 = 0 Then MaxBa11.Text = ("") Else MaxBa11.Text = FormatNumber(MaxBank11, 3)
        If MaxBank12 = 0 Then MaxBa12.Text = ("") Else MaxBa12.Text = FormatNumber(MaxBank12, 3)
        If MaxBank13 = 0 Then MaxBa13.Text = ("") Else MaxBa13.Text = FormatNumber(MaxBank13, 3)
        If MaxBank14 = 0 Then MaxBa14.Text = ("") Else MaxBa14.Text = FormatNumber(MaxBank14, 3)
        If MaxBank15 = 0 Then MaxBa15.Text = ("") Else MaxBa15.Text = FormatNumber(MaxBank15, 3)
        If MaxBank16 = 0 Then MaxBa16.Text = ("") Else MaxBa16.Text = FormatNumber(MaxBank16, 3)
        If MaxBank17 = 0 Then MaxBa17.Text = ("") Else MaxBa17.Text = FormatNumber(MaxBank17, 3)
        If MaxBank18 = 0 Then MaxBa18.Text = ("") Else MaxBa18.Text = FormatNumber(MaxBank18, 3)
        If MaxBank19 = 0 Then MaxBa19.Text = ("") Else MaxBa19.Text = FormatNumber(MaxBank19, 3)
        If MaxBank20 = 0 Then MaxBa20.Text = ("") Else MaxBa20.Text = FormatNumber(MaxBank20, 3)

        If BestU1 = 0 Then BestUlog1.Text = ("") Else BestUlog1.Text = FormatNumber(BestU1, 2)
        If BestU2 = 0 Then BestUlog2.Text = ("") Else BestUlog2.Text = FormatNumber(BestU2, 2)
        If BestU3 = 0 Then BestUlog3.Text = ("") Else BestUlog3.Text = FormatNumber(BestU3, 2)
        If BestU4 = 0 Then BestUlog4.Text = ("") Else BestUlog4.Text = FormatNumber(BestU4, 2)
        If BestU5 = 0 Then BestUlog5.Text = ("") Else BestUlog5.Text = FormatNumber(BestU5, 2)
        If BestU6 = 0 Then BestUlog6.Text = ("") Else BestUlog6.Text = FormatNumber(BestU6, 2)
        If BestU7 = 0 Then BestUlog7.Text = ("") Else BestUlog7.Text = FormatNumber(BestU7, 2)
        If BestU8 = 0 Then BestUlog8.Text = ("") Else BestUlog8.Text = FormatNumber(BestU8, 2)
        If BestU9 = 0 Then BestUlog9.Text = ("") Else BestUlog9.Text = FormatNumber(BestU9, 2)
        If BestU10 = 0 Then BestUlog10.Text = ("") Else BestUlog10.Text = FormatNumber(BestU10, 2)
        If BestU11 = 0 Then BestUlog11.Text = ("") Else BestUlog11.Text = FormatNumber(BestU11, 2)
        If BestU12 = 0 Then BestUlog12.Text = ("") Else BestUlog12.Text = FormatNumber(BestU12, 2)
        If BestU13 = 0 Then BestUlog13.Text = ("") Else BestUlog13.Text = FormatNumber(BestU13, 2)
        If BestU14 = 0 Then BestUlog14.Text = ("") Else BestUlog14.Text = FormatNumber(BestU14, 2)
        If BestU15 = 0 Then BestUlog15.Text = ("") Else BestUlog15.Text = FormatNumber(BestU15, 2)
        If BestU16 = 0 Then BestUlog16.Text = ("") Else BestUlog16.Text = FormatNumber(BestU16, 2)
        If BestU17 = 0 Then BestUlog17.Text = ("") Else BestUlog17.Text = FormatNumber(BestU17, 2)
        If BestU18 = 0 Then BestUlog18.Text = ("") Else BestUlog18.Text = FormatNumber(BestU18, 2)
        If BestU19 = 0 Then BestUlog19.Text = ("") Else BestUlog19.Text = FormatNumber(BestU19, 2)
        If BestU20 = 0 Then BestUlog20.Text = ("") Else BestUlog20.Text = FormatNumber(BestU20, 2)

        If MaxBank20 > MaxBank19 Then ddd = MaxBank20 Else ddd = MaxBank19
        If MaxBank18 > ddd Then ddd = MaxBank18 Else ddd = ddd
        If MaxBank17 > ddd Then ddd = MaxBank17 Else ddd = ddd
        If MaxBank16 > ddd Then ddd = MaxBank16 Else ddd = ddd
        If MaxBank15 > ddd Then ddd = MaxBank15 Else ddd = ddd
        If MaxBank14 > ddd Then ddd = MaxBank14 Else ddd = ddd
        If MaxBank13 > ddd Then ddd = MaxBank13 Else ddd = ddd
        If MaxBank12 > ddd Then ddd = MaxBank12 Else ddd = ddd
        If MaxBank11 > ddd Then ddd = MaxBank11 Else ddd = ddd
        If MaxBank10 > ddd Then ddd = MaxBank10 Else ddd = ddd
        If MaxBank9 > ddd Then ddd = MaxBank9 Else ddd = ddd
        If MaxBank8 > ddd Then ddd = MaxBank8 Else ddd = ddd
        If MaxBank7 > ddd Then ddd = MaxBank7 Else ddd = ddd
        If MaxBank6 > ddd Then ddd = MaxBank6 Else ddd = ddd
        If MaxBank5 > ddd Then ddd = MaxBank5 Else ddd = ddd
        If MaxBank4 > ddd Then ddd = MaxBank4 Else ddd = ddd
        If MaxBank3 > ddd Then ddd = MaxBank3 Else ddd = ddd
        If MaxBank2 > ddd Then ddd = MaxBank2 Else ddd = ddd
        If MaxBank1 > ddd Then ddd = MaxBank1 Else ddd = ddd

        If MaxBank20 = ddd Then vfv = 20 Else vfv = vfv
        If MaxBank19 = ddd Then vfv = 19 Else vfv = vfv
        If MaxBank18 = ddd Then vfv = 18 Else vfv = vfv
        If MaxBank17 = ddd Then vfv = 17 Else vfv = vfv
        If MaxBank16 = ddd Then vfv = 16 Else vfv = vfv
        If MaxBank15 = ddd Then vfv = 15 Else vfv = vfv
        If MaxBank14 = ddd Then vfv = 14 Else vfv = vfv
        If MaxBank13 = ddd Then vfv = 13 Else vfv = vfv
        If MaxBank12 = ddd Then vfv = 12 Else vfv = vfv
        If MaxBank11 = ddd Then vfv = 11 Else vfv = vfv
        If MaxBank10 = ddd Then vfv = 10 Else vfv = vfv
        If MaxBank9 = ddd Then vfv = 9 Else vfv = vfv
        If MaxBank8 = ddd Then vfv = 8 Else vfv = vfv
        If MaxBank7 = ddd Then vfv = 7 Else vfv = vfv
        If MaxBank6 = ddd Then vfv = 6 Else vfv = vfv
        If MaxBank5 = ddd Then vfv = 5 Else vfv = vfv
        If MaxBank4 = ddd Then vfv = 4 Else vfv = vfv
        If MaxBank3 = ddd Then vfv = 3 Else vfv = vfv
        If MaxBank2 = ddd Then vfv = 2 Else vfv = vfv
        If MaxBank1 = ddd Then vfv = 1 Else vfv = vfv

        rcmdsys.Text = vfv

        If vfv = 20 Then rcmdinv.Text = FormatNumber(BestU20, 4) * 100
        If vfv = 19 Then rcmdinv.Text = FormatNumber(BestU19, 4) * 100
        If vfv = 18 Then rcmdinv.Text = FormatNumber(BestU18, 4) * 100
        If vfv = 17 Then rcmdinv.Text = FormatNumber(BestU17, 4) * 100
        If vfv = 16 Then rcmdinv.Text = FormatNumber(BestU16, 4) * 100
        If vfv = 15 Then rcmdinv.Text = FormatNumber(BestU15, 4) * 100
        If vfv = 14 Then rcmdinv.Text = FormatNumber(BestU14, 4) * 100
        If vfv = 13 Then rcmdinv.Text = FormatNumber(BestU13, 4) * 100
        If vfv = 12 Then rcmdinv.Text = FormatNumber(BestU12, 4) * 100
        If vfv = 11 Then rcmdinv.Text = FormatNumber(BestU11, 4) * 100
        If vfv = 10 Then rcmdinv.Text = FormatNumber(BestU10, 4) * 100
        If vfv = 9 Then rcmdinv.Text = FormatNumber(BestU9, 4) * 100
        If vfv = 8 Then rcmdinv.Text = FormatNumber(BestU8, 4) * 100
        If vfv = 7 Then rcmdinv.Text = FormatNumber(BestU7, 4) * 100
        If vfv = 6 Then rcmdinv.Text = FormatNumber(BestU6, 4) * 100
        If vfv = 5 Then rcmdinv.Text = FormatNumber(BestU5, 4) * 100
        If vfv = 4 Then rcmdinv.Text = FormatNumber(BestU4, 4) * 100
        If vfv = 3 Then rcmdinv.Text = FormatNumber(BestU3, 4) * 100
        If vfv = 2 Then rcmdinv.Text = FormatNumber(BestU2, 4) * 100
        If vfv = 1 Then rcmdinv.Text = FormatNumber(BestU1, 4) * 100
        If MaxBank1 <= 1.0 Then rcmdinv.Text = ("0.00")



        AdvancedBtn.Visible = False
        MaxBa1.Visible = True
        MaxBa2.Visible = True
        MaxBa3.Visible = True
        MaxBa4.Visible = True
        MaxBa5.Visible = True
        MaxBa6.Visible = True
        MaxBa7.Visible = True
        MaxBa8.Visible = True
        MaxBa9.Visible = True
        MaxBa10.Visible = True
        MaxBa11.Visible = True
        MaxBa12.Visible = True
        MaxBa13.Visible = True
        MaxBa14.Visible = True
        MaxBa15.Visible = True
        MaxBa16.Visible = True
        MaxBa17.Visible = True
        MaxBa18.Visible = True
        MaxBa19.Visible = True
        MaxBa20.Visible = True
        BestUlog1.Visible = True
        BestUlog2.Visible = True
        BestUlog3.Visible = True
        BestUlog4.Visible = True
        BestUlog5.Visible = True
        BestUlog6.Visible = True
        BestUlog7.Visible = True
        BestUlog8.Visible = True
        BestUlog9.Visible = True
        BestUlog10.Visible = True
        BestUlog11.Visible = True
        BestUlog12.Visible = True
        BestUlog13.Visible = True
        BestUlog14.Visible = True
        BestUlog15.Visible = True
        BestUlog16.Visible = True
        BestUlog17.Visible = True
        BestUlog18.Visible = True
        BestUlog19.Visible = True
        BestUlog20.Visible = True

        tmb = FormatNumber(((AvrgKfc.Text * avrgsanse.Text / 100) ^ (avrgsanse.Text / 100) * (1 - (AvrgKfc.Text * avrgsanse.Text / 100 - 1) / (AvrgKfc.Text - 1)) ^ (1 - avrgsanse.Text / 100)) ^ sysoutofY.Text, 4)
        TmBnk1.Text = FormatNumber(ddd.ToString(), 3)

        showy.Text = sysoutofY.Text
        LabelMaxba.Visible = True
        LabelInvBnk.Visible = True
        Advancedtxt.Visible = True
        Recomendedsys.Visible = True
        recomendedsys2.Visible = True
        RecomendedU.Visible = True
        recomendedu2.Visible = True
        rcmdsys.Visible = True
        rcmdinv.Visible = True
        showy.Visible = True
        TmBnk1.Visible = True
        TMaxBnk1.Visible = True

        If rcmdsys.Text < 2 Then graf2bad.Visible = True Else If rcmdsys.Text / tt > 0.7 Then graf2extrem.Visible = True Else graf2avrg.Visible = True
        If rcmdinv.Text < 10 Then graf1bad.Visible = True Else If rcmdinv.Text > 75 Then graf1extrem.Visible = True Else graf1avrg.Visible = True


    End Sub
End Class