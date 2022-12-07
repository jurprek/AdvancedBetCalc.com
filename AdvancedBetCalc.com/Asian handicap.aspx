<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Asian handicap.aspx.vb" Inherits="AdvancedBetCalc.com.Asian_handicap1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style70
        {
            text-align: right;
            width: 111px;
        }
        .style71
        {
            width: 111px;
        }
        .style72
        {
            width: 260px;
        }
        .style74
        {
            width: 260px;
            height: 30px;
        }
        .style75
        {
            text-align: right;
            width: 111px;
            height: 30px;
        }
        .style76
        {
            width: 105px;
            height: 30px;
        }
        .style78
        {
            width: 73px;
        }
        .style79
        {
            height: 30px;
            width: 73px;
        }
        .style80
        {
            width: 75px;
        }
        .style81
        {
            height: 30px;
            width: 75px;
        }
        .style82
        {
            width: 105px;
        }
        .auto-style1 {
            width: 30px;
        }
        .auto-style2 {
            width: 60px;
        }
        .auto-style3 {
            width: 60px;
            height: 30px;
        }
        .auto-style4 {
            width: 165px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table class="style57" 
        style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
        <tr>
            <td class="auto-style2">
                </td>
            <td class="style71" 
                style="background-color: #F9DFAE; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; text-align: right;">
                <asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Text="Asian"></asp:Label>
            </td>
            <td class="style82" 
                style="background-color: #F9DFAE; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
&nbsp;
                <asp:Label ID="Label33" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Text="Handicap"></asp:Label>
            </td>
            <td class="style78" 
                style="background-color: #F9DFAE; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                </td>
            <td class="style80" 
                style="background-color: #F9DFAE; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                </td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                </td>
            <td bgcolor="Transparent" style="background-color: transparent" rowspan="24">
                <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" Font-Names="Arial" ForeColor="White" Height="550px" TextMode="MultiLine" Width="513px" BorderStyle="None">Asian handicap:

Calculate winnings when betting on asian handicap (AH).

Choose Home or Guest to bet on, enter odds - and type of a bet (e.g. AH-0.75), input bet amount and click &quot;Calculate&quot;.

Under &quot;PayOut&quot; you can see total winnings, and under &quot;Profit&quot; - of course - profit for that wager when game ends with result that you have entered under &quot;Final score&quot;.

In our example (AH-0.75) bet consisted of two parts, and our wager was equally divided among them: 

Home AH(-1.00) for half money invested =
Home wins with two or more points advantage (in case of one point advantage we get money back and in case of draw or if Away wins - we lose money)    &amp;

Home AH(-0.50) for half money invested =
Home wins simply when ever home team wins, the point difference doesn t matter.. (in case of draw or if Away wins - we lose money).

In our example game ended with 2:1 score, so if we have wagered $100.00 that means that $50.00 went on AH(-1.00) and came back as void of $50.00, and the other half of $50.00 went on AH(-0.50) and came back as win of total $100.00 (because odds were 2.00).

So final result is:
&quot;Bet&quot;= Home AH(-0.75),
&quot;Odds&quot;= 2.00,
&quot;Invested&quot;= $100.00,
&quot;Final score&quot;= 2:1,
&quot;PayOut&quot;= $150.00,
&quot;Profit&quot;= $50.00.

</asp:TextBox>
                <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" Font-Names="Arial" ForeColor="White" Height="550px" TextMode="MultiLine" Width="513px" BorderStyle="None" Visible="False">Asian handicap kalkulator računa dobitke kod hendikep klađenja.

Odaberite na koga se kladite (domaćina ili gosta), unesite koeficijent koji dobivate od kladionice, tip oklade, npr. AH(-0.75) i visinu novčane svote koju ulažete.  Kliknite „Calculate“.

„Payout“ pokazuje vaš ukupni dobitak, a „Profit“ zaradu za rezultat utakmice koji ste unijeli pod „Final score“. Desno vidite od čega se oklada sastojala. 

U danom primjeru AH(-0.75) sastoji se od dvije oklade na koje se ravnomjerno dijeli ukupni ulog, dakle od oklade na AH(-1.00), (tj. da se pobjeda domaćina sa samo jednim pogotkom prednosti računa kao povrat uloga) i oklade na AH(-0.50), (tj. da se nerješeni rezultat računa kao promašena oklada). 

Utakmica iz primjera je zavrsila 2:1 i dana oklada je polučila sljedeći uspjeh:
Za prvu polovicu ostvaren je povrat, a za drugu polovicu oklada je dobivena tj. polovica novca investiranog na taj dio oklade vraća se uvećana za koeficijent ukupne oklade tj. 2.00 na tip AH(-0.75).
</asp:TextBox>
            </td>
            <td bgcolor="Transparent" style="background-color: transparent">
                <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
            </td>
            <td bgcolor="Transparent" style="background-color: transparent">
                <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
            </td>
            <td class="style75" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; text-align: right;">
                <asp:Label ID="Label24" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Your pick :"></asp:Label>
            </td>
            <td class="style76" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
&nbsp;
                <asp:DropDownList ID="OCAHCLCTeams" runat="server" BackColor="White" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Height="21px" 
                    Width="95px">
                    <asp:ListItem Selected="True">Home Team</asp:ListItem>
                    <asp:ListItem>Away Team</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style79" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
            </td>
            <td class="style81" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
            </td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:Label ID="Label25" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="(Decimal) Odds  ="></asp:Label>
            </td>
            <td class="style82" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
&nbsp;
                <asp:TextBox ID="OCAHCLCOdds" runat="server" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="#660033" Height="20px" MaxLength="5" 
                    style="text-align: center" Width="48px">2.00</asp:TextBox>
            </td>
            <td class="style78" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:Label ID="Label26" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Handicap  ="></asp:Label>
            </td>
            <td class="style82" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
&nbsp;
                <asp:DropDownList ID="OCAHCLCAHbox" runat="server" BackColor="White" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Maroon" 
                    Height="21px" Width="62px">
                    <asp:ListItem>-4.00</asp:ListItem>
                    <asp:ListItem>-3.75</asp:ListItem>
                    <asp:ListItem>-3.50</asp:ListItem>
                    <asp:ListItem>-3.25</asp:ListItem>
                    <asp:ListItem>-3.00</asp:ListItem>
                    <asp:ListItem>-2.75</asp:ListItem>
                    <asp:ListItem>-2.50</asp:ListItem>
                    <asp:ListItem>-2.25</asp:ListItem>
                    <asp:ListItem>-2.00</asp:ListItem>
                    <asp:ListItem>-1.75</asp:ListItem>
                    <asp:ListItem>-1.50</asp:ListItem>
                    <asp:ListItem>-1.25</asp:ListItem>
                    <asp:ListItem>-1.00</asp:ListItem>
                    <asp:ListItem Selected="True">-0.75</asp:ListItem>
                    <asp:ListItem>-0.50</asp:ListItem>
                    <asp:ListItem>-0.25</asp:ListItem>
                    <asp:ListItem>0.00</asp:ListItem>
                    <asp:ListItem>0.25</asp:ListItem>
                    <asp:ListItem>0.50</asp:ListItem>
                    <asp:ListItem>0.75</asp:ListItem>
                    <asp:ListItem>1.00</asp:ListItem>
                    <asp:ListItem>1.25</asp:ListItem>
                    <asp:ListItem>1.50</asp:ListItem>
                    <asp:ListItem>1.75</asp:ListItem>
                    <asp:ListItem>2.00</asp:ListItem>
                    <asp:ListItem>2.25</asp:ListItem>
                    <asp:ListItem>2.50</asp:ListItem>
                    <asp:ListItem>2.75</asp:ListItem>
                    <asp:ListItem>3.00</asp:ListItem>
                    <asp:ListItem>3.25</asp:ListItem>
                    <asp:ListItem Value="3.50">3.50</asp:ListItem>
                    <asp:ListItem Value="3.75"></asp:ListItem>
                    <asp:ListItem Value="4.00">4.00</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style78" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:TextBox ID="OCAHCLCAHa" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="Maroon" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">- 0.50</asp:TextBox>
            </td>
            <td class="style80" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:TextBox ID="OCAHCLCAHb" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="Maroon" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">- 1.00</asp:TextBox>
            </td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:Label ID="Label27" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Invest  ="></asp:Label>
            </td>
            <td class="style82" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
&nbsp;
                <asp:TextBox ID="OCAHCLCInvest" runat="server" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Height="20px" MaxLength="9" 
                    style="text-align: right" Width="62px">100.00</asp:TextBox>
            </td>
            <td class="style78" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:TextBox ID="OCAHCLCInva" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="#666666" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">50.00</asp:TextBox>
            </td>
            <td class="style80" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:TextBox ID="OCAHCLCInvb" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="#666666" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">50.00</asp:TextBox>
            </td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:Label ID="Label28" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="PayOut"></asp:Label>
            </td>
            <td class="style82" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
&nbsp;
                <asp:TextBox ID="OCAHCLCPayOut" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="#003366" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">150.00</asp:TextBox>
            </td>
            <td class="style78" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:TextBox ID="OCAHCLCPayOa" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="#666666" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">100.00</asp:TextBox>
            </td>
            <td class="style80" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:TextBox ID="OCAHCLCPayOb" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="#666666" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">50.00</asp:TextBox>
            </td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:Label ID="Label29" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Profit  ="></asp:Label>
            </td>
            <td class="style82" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
&nbsp;
                <asp:TextBox ID="OCAHCLCProfit" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">50.00</asp:TextBox>
            </td>
            <td class="style78" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:TextBox ID="OCAHCLCProfa" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="#666666" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">50.00</asp:TextBox>
            </td>
            <td class="style80" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:TextBox ID="OCAHCLCProfb" runat="server" BackColor="OldLace" 
                    BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="#666666" Height="20px" MaxLength="9" ReadOnly="True" 
                    style="text-align: right" Width="62px">0.00</asp:TextBox>
            </td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                <asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Text="Final Score :"></asp:Label>
            </td>
            <td class="style82" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
&nbsp;
                <asp:TextBox ID="OCAHCLCGola" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="#003300" Height="20px" 
                    MaxLength="2" style="text-align: center" Width="25px">2</asp:TextBox>
&nbsp;<asp:Label ID="Label31" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text=":"></asp:Label>
&nbsp;<asp:TextBox ID="OCAHCLCGolb" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="#003300" Height="20px" 
                    MaxLength="2" style="text-align: center" Width="25px">1</asp:TextBox>
            </td>
            <td class="style78" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; text-align: right;">
                <asp:Button ID="AHclcBTN" runat="server" BackColor="#003366" Font-Names="Arial" 
                    Font-Size="9pt" ForeColor="White" Height="22px" Text="Calculate" 
                    Width="65px" />
            </td>
            <td class="style80" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: OldLace; border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style82" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style78" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td class="style80" 
                style="background-color: transparent; ">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style1">
                &nbsp;</td>
            <td bgcolor="Transparent" style="background-color: transparent" class="auto-style4" colspan="2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
