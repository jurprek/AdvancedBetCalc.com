<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Spread Calc.aspx.vb" Inherits="AdvancedBetCalc.com.Spread_Calc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style69
        {
            width: 280px;
        }
        .style70
        {
            width: 127px;
        }
        .style71
        {
            width: 75px;
        }
        .style73
        {
            width: 5px;
        }
        .style74
        {
            width: 70px;
            text-align: right;
        }
        .style75
        {
            width: 70px;
        }
        .auto-style1 {
            width: 200px;
        }
        .auto-style2 {
            width: 141px;
        }
        .auto-style3 {
            width: 144px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table class="style57" 
            style="border-style: none; border-width: 0px; padding: 0px; border-spacing: 0px">
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: #F9DFAE; text-align: right;">
                    <asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Names="Arial" 
                        Font-Size="10pt" ForeColor="Black" Text="Spread"></asp:Label>
                </td>
                <td class="style71" style="background-color: #F9DFAE">
&nbsp;
                    <asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Names="Arial" 
                        Font-Size="10pt" ForeColor="Black" Text="calculator"></asp:Label>
                </td>
                <td class="style75" style="background-color: #F9DFAE">
                    &nbsp;</td>
                <td class="style73" style="background-color: #F9DFAE">
                    &nbsp;</td>
                <td style="background-color: transparent" class="auto-style2">
                    &nbsp;</td>
                <td style="background-color: transparent">
                    &nbsp;</td>
                <td style="background-color: transparent">
                    &nbsp;</td>
                <td style="background-color: transparent">
                    &nbsp;</td>
                <td style="background-color: transparent">
                    &nbsp;</td>
                <td style="background-color: transparent">
                    &nbsp;</td>
                <td style="background-color: transparent" class="auto-style3">
                    &nbsp;</td>
                <td style="background-color: transparent">
                    &nbsp;</td>
                <td style="background-color: transparent">
                    <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
                </td>
                <td style="background-color: transparent">
                    <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: OldLAce">
&nbsp;
                    <asp:Label ID="Label24" runat="server" Font-Names="Arial" Font-Size="10pt" 
                        ForeColor="Black" Text="Invest per point ="></asp:Label>
                </td>
                <td class="style71" style="background-color: OldLAce">
                    <asp:TextBox ID="MiscINVEST" runat="server" Font-Names="Arial" Font-Size="10pt" 
                        Height="20px" MaxLength="8" style="text-align: center" Width="62px">10.00</asp:TextBox>
                </td>
                <td class="style75" style="background-color: OldLAce">
                    &nbsp;</td>
                <td class="style73" style="background-color: OldLAce">
                    &nbsp;</td>
                <td style="background-color: transparent" rowspan="8" colspan="10">
                    <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="211px" TextMode="MultiLine" Width="405px">Spread calculator:

More and more popular way of betting deserves  its own calculator.

E.g. we can now wager that there will be more than 2.6 points (Buy price) in a game, and bet a $10.00 for every point over 2.6. That means if game ends with 3.0 points we get $10.00 x (3.0 - 2.6) = $4.00... or we can bet that there will be less than 2.4 points (Sell price) in which case we would have lost $6.00...
</asp:TextBox>
                    <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="211px" TextMode="MultiLine" Width="405px" Visible="False">Ovaj kalkulator odnosi se na vrstu klađenja koja se sve više popularizira, kod koje se možete okladiti na npr. broj koševa u utakmici veći ili manji od neke granične vrijednosti tako što ćete za svaki koš više ili manje od ponuđene granice dobiti ili izgubiti dogovoreni iznos po košu.  
Npr. vi mislite da će košarkaš na utakmici zabiti u prosijeku više od 2.6 koša po četvrtini (Buy price), i na svaki poen ulažete $10. Ako na kraju utakmice košarkaš ima prosijek od točno 3.0 poena (dakle  zabio je 12 koševa u utakmici) vi dobivate (3.0-2.6=0.4)x$10.00 = $4.00 tj. imate zaradu od $4. U primjeru se također vidi i da je onaj tko se kladio na manje od 2.4 poena (Sell price) izgubio $6.00.
</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: OldLAce">
&nbsp;
                    <asp:Label ID="Label25" runat="server" Font-Names="Arial" Font-Size="10pt" 
                        ForeColor="Black" Text="Sell price ="></asp:Label>
                </td>
                <td class="style71" style="background-color: OldLAce">
                    <asp:TextBox ID="MiscSELL" runat="server" Font-Names="Arial" Font-Size="10pt" 
                        Height="20px" MaxLength="8" style="text-align: center" Width="62px">2.40</asp:TextBox>
                </td>
                <td class="style74" style="background-color: OldLAce">
                    <asp:Label ID="MiscIFUNDER" runat="server" Font-Bold="True" Font-Names="Arial" 
                        Font-Size="9pt" ForeColor="#660066" Text="- 6.00"></asp:Label>
                </td>
                <td class="style73" style="background-color: OldLAce">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: OldLAce">
&nbsp;
                    <asp:Label ID="Label26" runat="server" Font-Names="Arial" Font-Size="10pt" 
                        ForeColor="Black" Text="Buy price ="></asp:Label>
                </td>
                <td class="style71" style="background-color: OldLAce">
                    <asp:TextBox ID="MiscBUY" runat="server" Font-Names="Arial" Font-Size="10pt" 
                        Height="20px" MaxLength="8" style="text-align: center" Width="62px">2.60</asp:TextBox>
                </td>
                <td class="style74" style="background-color: OldLAce">
                    <asp:Label ID="MiscIFOVER" runat="server" Font-Bold="True" Font-Names="Arial" 
                        Font-Size="9pt" ForeColor="#660066" Text="4.00"></asp:Label>
                </td>
                <td class="style73" style="background-color: OldLAce">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: OldLAce">
&nbsp;
                    <asp:Label ID="Label27" runat="server" Font-Names="Arial" Font-Size="10pt" 
                        ForeColor="Black" Text="Closing price = "></asp:Label>
                </td>
                <td class="style71" style="background-color: OldLAce">
                    <asp:TextBox ID="MiscWasPoints" runat="server" Font-Names="Arial" 
                        Font-Size="10pt" Height="20px" MaxLength="8" style="text-align: center" 
                        Width="62px">3.00</asp:TextBox>
                </td>
                <td class="style75" style="background-color: OldLAce; text-align: right;">
                    <asp:Button ID="SpreadBtn" runat="server" BackColor="#003366" 
                        Font-Names="Arial" Font-Size="8pt" ForeColor="White" Height="23px" 
                        Text="Calculate" Width="55px" />
                </td>
                <td class="style73" style="background-color: OldLAce">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: OldLAce">
                    &nbsp;</td>
                <td class="style71" style="background-color: OldLAce">
                    &nbsp;</td>
                <td class="style75" style="background-color: OldLAce">
                    &nbsp;</td>
                <td class="style73" style="background-color: OldLAce">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style71" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style75" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style73" style="background-color: transparent">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style71" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style75" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style73" style="background-color: transparent">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="style70" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style71" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style75" style="background-color: transparent">
                    &nbsp;</td>
                <td class="style73" style="background-color: transparent">
                    &nbsp;</td>
            </tr>
        </table>
    </p>
</asp:Content>
