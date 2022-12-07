<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Probability collisions.aspx.vb" Inherits="AdvancedBetCalc.com.Probability_collisions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 68px;
    }
    .auto-style2 {
        width: 70px;
    }
    .auto-style3 {
        width: 67px;
    }
    .auto-style4 {
        width: 68px;
        height: 30px;
    }
    .auto-style5 {
        width: 70px;
        height: 30px;
            text-align: center;
        }
    .auto-style6 {
        width: 67px;
        height: 30px;
    }
    .auto-style7 {
        height: 30px;
    }
    .auto-style9 {
        height: 30px;
        width: 73px;
    }
    .auto-style10 {
        width: 73px;
    }
    .auto-style11 {
            width: 58px;
            text-align: center;
        }
    .auto-style12 {
        width: 58px;
        height: 30px;
            text-align: center;
        }
        .auto-style14 {
            width: 130px;
            height: 30px;
        }
        .auto-style15 {
            width: 130px;
        }
        .auto-style16 {
            width: 63px;
        }
        .auto-style17 {
            width: 63px;
            height: 30px;
        }
        .auto-style18 {
            width: 68px;
            height: 26px;
            text-align: right;
        }
        .auto-style19 {
            width: 70px;
            height: 26px;
            text-align: center;
        }
        .auto-style20 {
            width: 67px;
            height: 26px;
            text-align: center;
        }
        .auto-style21 {
            width: 73px;
            height: 26px;
            text-align: center;
        }
        .auto-style22 {
            width: 130px;
            height: 26px;
        }
        .auto-style23 {
            width: 63px;
            height: 26px;
            text-align: right;
        }
        .auto-style24 {
            width: 58px;
            height: 26px;
            text-align: center;
        }
        .auto-style25 {
            height: 26px;
        }
        .auto-style26 {
            width: 68px;
            text-align: right;
        }
        .auto-style27 {
            width: 73px;
            text-align: center;
        }
        .auto-style28 {
            width: 67px;
            text-align: center;
        }
        .auto-style29 {
            width: 70px;
            text-align: center;
        }
        .auto-style31 {
            height: 26px;
            width: 82px;
            text-align: center;
        }
        .auto-style32 {
            height: 30px;
            width: 82px;
            text-align: center;
        }
        .auto-style33 {
            width: 82px;
            text-align: center;
        }
        .auto-style34 {
            width: 63px;
            text-align: right;
        }
        .auto-style35 {
            width: 37px;
        }
        .auto-style36 {
            width: 38px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="style57" cellspacing="0">
    <tr>
        <td class="auto-style26" style="background-color: #FFFF5E; border-spacing: 0px;">
            <asp:Label ID="Label33" runat="server" ForeColor="#000066" Text="&gt;&gt;&gt;&gt;" Font-Bold="False" Font-Italic="False" Font-Names="Arial" ToolTip="e.g. Two tennis players confront, they have won against common opponents as you input... what are their chances to win or lose?"></asp:Label>
        </td>
        <td class="auto-style29" style="background-color: #FFFF5E; border-spacing: 0px;">
            <asp:Label ID="Label26" runat="server" ForeColor="#000066" Text="Winning%" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ToolTip="e.g. Two tennis players confront, they have won against common opponents as you input... what are their chances to win or lose?"></asp:Label>
        </td>
        <td class="auto-style28" style="background-color: #FFFF5E; border-spacing: 0px;">
            <asp:Label ID="Label27" runat="server" ForeColor="Black" Text="Losing%"></asp:Label>
        </td>
        <td class="auto-style27" style="background-color: #FFFF5E; border-spacing: 0px;">
            <asp:Label ID="Label28" runat="server" ForeColor="Black" Text="%ToWin"></asp:Label>
        </td>
        <td class="auto-style15">&nbsp;</td>
        <td class="auto-style34" style="background-color: #FFFF5E; border-spacing: 0px;">
            <asp:Label ID="Label34" runat="server" ForeColor="#000066" Text="&gt;&gt;&gt;&gt;" Font-Bold="False" Font-Italic="False" Font-Names="Arial" ToolTip="e.g. Two tennis players confront, they have won against common opponents as you input... what are their chances to win or lose?"></asp:Label>
        </td>
        <td class="auto-style11" style="background-color: #FFFF5E; border-spacing: 0px;">
            <asp:Label ID="Label32" runat="server" ForeColor="#000066" Text="&quot;Dice&quot;" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ToolTip="e.g. If Player 1 is throwing a Dice (with outcomes from 1 to 6) and Player 2 is tossing a Coin (with outcomes 1 &amp; 2) ...  what are the odds that Player 1 or 2 will get bigger number than the other one?"></asp:Label>
        </td>
        <td class="auto-style33" style="background-color: #FFFF5E; border-spacing: 0px;">&nbsp;</td>
        <td colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style26" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:Label ID="Label24" runat="server" ForeColor="Black" Text="Player 1"></asp:Label>
        </td>
        <td class="auto-style29" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="P1W" runat="server" Width="59px">75.25</asp:TextBox>
        </td>
        <td class="auto-style28" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="P1L" runat="server" ReadOnly="True" Width="59px">24.75</asp:TextBox>
        </td>
        <td class="auto-style27" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="ToWinP1" runat="server" ReadOnly="True" Width="59px">54.52</asp:TextBox>
        </td>
        <td class="auto-style15">
            &nbsp;</td>
        <td class="auto-style34" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:Label ID="Label30" runat="server" ForeColor="Black" Text="Player 1"></asp:Label>
        </td>
        <td class="auto-style11" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="P1HC" runat="server" Width="28px">6</asp:TextBox>
        </td>
        <td class="auto-style33" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="ToWinP1HC" runat="server" ReadOnly="True" Width="59px">75.00</asp:TextBox>
        </td>
        <td colspan="5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style18" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:Label ID="Label25" runat="server" ForeColor="Black" Text="Player 2"></asp:Label>
        </td>
        <td class="auto-style19" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="P2W" runat="server" Width="59px">68.45</asp:TextBox>
        </td>
        <td class="auto-style20" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="P2L" runat="server" ReadOnly="True" Width="59px">31.55</asp:TextBox>
        </td>
        <td class="auto-style21" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="ToWinP2" runat="server" ReadOnly="True" Width="59px">45.48</asp:TextBox>
        </td>
        <td class="auto-style22">
        </td>
        <td class="auto-style23" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:Label ID="Label31" runat="server" ForeColor="Black" Text="Player 2"></asp:Label>
        </td>
        <td class="auto-style24" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="P2HC" runat="server" Width="28px">2</asp:TextBox>
        </td>
        <td class="auto-style31" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="ToWinP2HC" runat="server" ReadOnly="True" Width="59px">8.33</asp:TextBox>
        </td>
        <td class="auto-style25" colspan="5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:Button ID="Button1" OnClientClick="if (validate_form() == false) return(false);" runat="server" Font-Size="8pt" Height="18px" Text="Calculate" BackColor="#3399FF" ForeColor="White" />
        </td>
        <td class="auto-style5" style="background-color: #FFFF99; border-spacing: 0px;"></td>
        <td class="auto-style6" style="background-color: #FFFF99; border-spacing: 0px;"></td>
        <td class="auto-style9" style="background-color: #FFFF99; border-spacing: 0px;"></td>
        <td class="auto-style14">
            &nbsp;</td>
        <td class="auto-style17" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:Button ID="Button2" runat="server" Font-Size="8pt" Height="18px" Text="Calculate" BackColor="#3399FF" ForeColor="White" />
        </td>
        <td class="auto-style12" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:Label ID="Label29" runat="server" ForeColor="Black" Text="%Draw :"></asp:Label>
        </td>
        <td class="auto-style32" style="background-color: #FFFF99; border-spacing: 0px;">
            <asp:TextBox ID="ToDrawHC" runat="server" ReadOnly="True" Width="59px">16.67</asp:TextBox>
        </td>
        <td class="auto-style7" colspan="5">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style15">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style33">&nbsp;</td>
        <td colspan="5">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style10">&nbsp;</td>
        <td class="auto-style15">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td class="auto-style11">&nbsp;</td>
        <td class="auto-style33">&nbsp;</td>
        <td class="auto-style35">
                <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
                </td>
        <td class="auto-style36">
                <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
            </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
                <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="281px" TextMode="MultiLine" Width="647px">Collisions...
</asp:TextBox>
                <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="316px" TextMode="MultiLine" Width="647px">Srazovi vjerojatnosti

Na raspolaganju su vam dva kalkulatora.

Prvi se odnosi na situaciju kada imamo npr. dva tenisača koji su protiv zajedničkih protivnika imali određen uspjeh, ali se međusobno još nisu susreli. Recimo da je prvi pobjedio u 70% slučajeva, a drugi isto tako 70%, što bismo zaključili? Vjerojatno su podjednako dobri (ako je statistički uzorak bio relativno dovoljan). Procjenili bi im šanse u međusobnom susretu na 50% : 50%. Ali ako su imali različite statistike, npr. 75% i 60% tada je sve malo kompliciranije. Ovaj kalkulator to računa za vas. Jedino što unosite su „Winning%“ za igrača 1 i 2.

Drugi kalkulator računa situacije poput one kad imate npr. kockicu sa poljima od 1 do 6 i npr. novčić sa vrijednostima „Pismo“=1 i „Glava“=2. Ako bacite kockicu i novčić za očekivati je da će kockica okrenuti veći broj od novčića, ali svako malo dogodi se „2“ na novčiću i „1“ na kockici - pa novčić pobjeđuje.
Ovaj kalkulator računa takve „srazove“ za bilokoje vrijednosti „kockica“ i „novčića“, tj. koje su šanse da će pobjediti prvi ili drugi ili da će biti nerješeno... Ako vam treba pomoć u shvaćanju „čemu ovo uopće služi“ - zamislite da imate situaciju u kojoj jedna ekipa ide dalje u slučaju nekih pet opcija naspram druge koja prolazi samo u slučaju dvaju scenarija. Koje su tada realne šanse za prolazak koje? 
</asp:TextBox>
                <br />
</asp:Content>
