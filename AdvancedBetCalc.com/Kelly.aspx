<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Kelly.aspx.vb" Inherits="AdvancedBetCalc.com.Kelly" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
    {
        width: 71%;
    }
        .style7
        {
        width: 135px;
    }
        .style70
    {
        width: 260px;
    }
    .style71
    {
        width: 554px;
    }
    .style72
    {
        width: 130px;
    }
        .auto-style1 {
            width: 555px;
        }
        .auto-style2 {
            width: 50px;
        }
        .auto-style3 {
            width: 555px;
            height: 24px;
        }
        .auto-style4 {
            width: 419px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<br />
<table class="style57">
    <tr>
        <td class="auto-style2" rowspan="9">
            &nbsp;</td>
        <td class="auto-style1" rowspan="2">
            &nbsp;</td>
        <td class="auto-style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
        </td>
        <td>
            <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
        </td>
    </tr>
    <tr>
        <td class="style71" rowspan="8" colspan="6">
            <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="289px" TextMode="MultiLine" Width="506px">Kelly s criterion:

Kelly&#39;s criterion is used when we want to see how much to wager on a event where offered odds are bigger than they should be considering chances that this exact occurrence will happen.

E.g. in coin tossing game with 50%-50% chances for either outcome bookie makes us an offer for bet with 2.10 odds. That is obviously great opportunity for us, but how much money (more precisely, what percentage of our capital) to wager on, so that in a long term we get maximum profit?

Although many people see Kelly methode as too aggressive, it is mathematically correct one if we have inputted correct data,
and there is where the problem lies: we can almost never be really sure what the true chances in sports betting are, but nevertheless, Kelly calculator points us in right direction and tells us &quot;how valuable&quot; the opportunity in front of us really is.
</asp:TextBox>
            <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="289px" TextMode="MultiLine" Width="506px" Visible="False">„Kelly`s criterion“ je matematička metoda izračunavanja optimalne visine uloga za neku okladu kod koje je koeficijent veći od pripadajućih mu šansi.

Npr. kada bi u igri bacanja novčića na ulog od $1.00 dobivali dobitak od $2.10 tada bi igrajući za mali postotak svojeg budžeta ubrzo shvatili da polako, ali sigurno zarađujete. Očito da je koeficijent od 2.10 prevelik za šanse od 50% (koje odgovaraju koeficijentu 2.00 po formuli 1/50%=2.00).
Kako iskoristiti tu situaciju? Rješenje je da treba igrati za malo veću svotu. Ali, ako uložite previše, prijeti vam bankrot. Zato, ako znate šanse i koeficijent, najpametnije je koristiti Kellyjev kalkulator koji izračunava najisplativiji iznos uloga dugoročno.
Za višestruke istovremene oklade AdvancedBetCalc razvio je „MultiKelly kalkulator“.
</asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            <table class="style57" 
                style="border-style: none; border-color: #000080; background-color: #F0F2FF">
                <tr>
                    <td bgcolor="Black" class="style8" colspan="2" 
                        style="font-size: small; color: #FFFFFF;">
                        Kelly`s calculator&nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Multi Kelly.aspx">Go to &quot;multi Kelly&quot;</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td bgcolor="White" class="style70" style="font-size: small">
                        <asp:Label ID="Label1" runat="server" ForeColor="#000099" 
                            Text="Bookies Odds"></asp:Label>
                    </td>
                    <td bgcolor="White" class="style7" style="font-size: small;">
                        <asp:TextBox ID="bookieskfc" runat="server" Width="33px">1.85</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td bgcolor="White" class="style70" style="font-size: small">
                        <asp:Label ID="Label2" runat="server" ForeColor="#000099" 
                            Text="Fair odds should be"></asp:Label>
                    </td>
                    <td bgcolor="White" class="style7" style="font-size: small;">
                        <asp:TextBox ID="fairkfc" runat="server" Width="33px">1.73</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td bgcolor="White" class="style70" style="font-size: small">
                        <asp:Label ID="Label3" runat="server" ForeColor="#000099" Text="My Bank"></asp:Label>
                    </td>
                    <td bgcolor="White" class="style7" style="font-size: small;">
                        <asp:TextBox ID="bank" runat="server" MaxLength="7" Width="70px">100.00</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td bgcolor="White" class="style70" style="font-size: small">
                        <asp:Label ID="Label4" runat="server" ForeColor="#000099" 
                            Text="Recomended Invest (using Kellys method) : "></asp:Label>
                    </td>
                    <td bgcolor="White" class="style7" style="font-size: small;">
                        <asp:Label ID="Kelly006" runat="server" Font-Size="Small" ForeColor="#000099"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td bgcolor="White" class="style70" style="font-size: small">
                        <asp:Button ID="Button1" runat="server" BackColor="#003366" Font-Bold="True" 
                            Font-Names="Arial" ForeColor="White" Text="Calculate" />
                    </td>
                    <td bgcolor="White" class="style7" style="font-size: small;">
                        <asp:Label ID="Label5" runat="server" Font-Size="Small" ForeColor="#000099" 
                            Text="(odds are too small)" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            </td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>
