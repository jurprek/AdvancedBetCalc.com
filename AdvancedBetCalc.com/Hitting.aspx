<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Hitting.aspx.vb" Inherits="AdvancedBetCalc.com.Hitting" %>
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
        .style75
        {
            width: 104px;
        }
        .style73
        {
            width: 5px;
        }
        .style74
        {
            width: 104px;
            text-align: left;
        }
        .style76
        {
            width: 51px;
        }
        .auto-style3 {
            width: 38px;
        }
        .auto-style4 {
            width: 7px;
        }
        .auto-style5 {
            width: 178px;
        }
        .auto-style6 {
            width: 54px;
        }
        .auto-style8 {
            width: 170px;
            text-align: left;
        }
        .auto-style9 {
            width: 170px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table class="style57" 
        style="border-style: none; border-width: 0px; padding: 0px; border-spacing: 0px">
        <tr>
            <td class="auto-style3" rowspan="2">
                &nbsp;</td>
            <td class="auto-style5" style="background-color: #F9DFAE; text-align: right;" rowspan="2">
                <asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Text="Expected"></asp:Label>
            </td>
            <td class="auto-style6" style="background-color: #F9DFAE" rowspan="2">
&nbsp;
                <asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Text="hitting"></asp:Label>
            </td>
            <td class="auto-style9" style="background-color: #F9DFAE" rowspan="2">
                &nbsp;</td>
            <td class="style73" style="background-color: #F9DFAE" rowspan="2">
                &nbsp;</td>
            <td style="background-color: transparent" class="auto-style4" rowspan="2">
                &nbsp;</td>
            <td style="background-color: transparent" rowspan="11">
                <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="275px" TextMode="MultiLine" Width="419px">Hitting calc:

Calculate probabilities that somebody is able to pick winners in a presented way.

Can refer to our own picking, so we can check if this last fifteen bets were just a streak of good/bad luck or this is &quot;normal&quot; picking..,
or we can use it to check how probable is that some tipster is picking winners, as he claims that he does, in his statistics...

E.g. he claims that he had picked 198 good picks out of 348 totals with (average) odds 1.76 at bookie for whom we know has 3.50% margin. Calculator sais that there is maximum 23.57% chance of achieving that kind of a success. Sometimes this info can be of some value to us.

</asp:TextBox>
                <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="275px" TextMode="MultiLine" Width="420px" Visible="False">Hitting  kalkulator računa vjerojatnost da će neki tipster ispravno predviđati ishode utakmica.

Primjer:  Koja je vjerojatnost da će netko uspješno pogoditi 198 od 348 utakmica ako je prosječni koeficijent  1.76 koji kladionice nude uz marginu od 3.50%?

Također možemo vidjeti u kojim je granicama realno očekivana uspješnost, da bismo kvlitetnije mogli procijeniti vjerodostojnost tvrdnji ili kvalitetu tipova.
</asp:TextBox>
            </td>
            <td style="background-color: transparent" rowspan="11">
                &nbsp;</td>
            <td style="background-color: transparent" class="style73">
                <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
            </td>
            <td style="background-color: transparent" class="style73">
                <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
            </td>
        </tr>
        <tr>
            <td style="background-color: transparent" class="style73">
                &nbsp;</td>
            <td style="background-color: transparent" class="style73">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5" style="background-color: OldLAce">
&nbsp;
                <asp:Label ID="Label24" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Bookies margine ="></asp:Label>
            </td>
            <td class="auto-style6" style="background-color: OldLAce">
                <asp:TextBox ID="MiscMArgina" runat="server" Font-Names="Arial" 
                    Font-Size="10pt" Height="20px" MaxLength="5" style="text-align: center" 
                    Width="47px">3.50</asp:TextBox>
            </td>
            <td class="auto-style9" style="background-color: OldLAce">
                <asp:Label ID="Label35" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="%"></asp:Label>
            </td>
            <td class="style73" style="background-color: OldLAce">
                &nbsp;</td>
            <td style="background-color: transparent" class="auto-style4">
                &nbsp;</td>
            <td style="background-color: transparent" rowspan="9" class="style73">
                &nbsp;</td>
            <td style="background-color: transparent" rowspan="9" class="style73">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5" style="background-color: OldLAce">
&nbsp;
                <asp:Label ID="Label25" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Average odds ="></asp:Label>
            </td>
            <td class="auto-style6" style="background-color: OldLAce">
                <asp:TextBox ID="MiscOdds" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    Height="20px" MaxLength="5" style="text-align: center" Width="47px">1.76</asp:TextBox>
            </td>
            <td class="auto-style8" style="background-color: OldLAce">
                &nbsp;</td>
            <td class="style73" style="background-color: OldLAce">
                &nbsp;</td>
            <td style="background-color: transparent" class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5" style="background-color: OldLAce">
&nbsp;
                <asp:Label ID="Label26" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Sample size ="></asp:Label>
            </td>
            <td class="auto-style6" style="background-color: OldLAce">
                <asp:TextBox ID="MiscSampSize" runat="server" Font-Names="Arial" 
                    Font-Size="10pt" Height="20px" MaxLength="3" style="text-align: center" 
                    Width="47px">348</asp:TextBox>
            </td>
            <td class="auto-style8" style="background-color: OldLAce">
                <asp:Label ID="Label37" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="(TIPs)"></asp:Label>
            </td>
            <td class="style73" style="background-color: OldLAce">
                &nbsp;</td>
            <td style="background-color: transparent" class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5" style="background-color: OldLAce">
&nbsp;
                <asp:Label ID="Label27" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Success ="></asp:Label>
            </td>
            <td class="auto-style6" style="background-color: OldLAce">
                <asp:TextBox ID="MiscSuc" runat="server" BackColor="#EFFCE7" Font-Names="Arial" 
                    Font-Size="10pt" Height="20px" MaxLength="5" style="text-align: center" 
                    Width="47px" Font-Bold="True" ForeColor="#660066">198</asp:TextBox>
            </td>
            <td class="auto-style9" style="background-color: OldLAce; text-align: left;">
                <asp:Label ID="Label38" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="(HITs)"></asp:Label>
            </td>
            <td class="style73" style="background-color: OldLAce">
                &nbsp;</td>
            <td style="background-color: transparent" class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5" style="background-color: OldLAce">
&nbsp;
                <asp:Label ID="Label32" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Chances for that ="></asp:Label>
            </td>
            <td class="auto-style6" style="background-color: OldLAce">
                <asp:TextBox ID="MiscChForThat" runat="server" BackColor="#CCFFCC" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Maroon" 
                    Height="20px" MaxLength="8" ReadOnly="True" style="text-align: center" 
                    Width="47px" 
                    ToolTip="These are the chances that player will have max. entered successful HITs or less.">-</asp:TextBox>
            </td>
            <td class="auto-style9" style="background-color: OldLAce">
                <asp:Label ID="Label36" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Maroon" Text="%" 
                    ToolTip="It is not very probable that percentage is less than 10%, if it is under 1% then it is very probably hokum."></asp:Label>
            </td>
            <td class="style73" style="background-color: OldLAce">
                &nbsp;</td>
            <td style="background-color: transparent" class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5" style="background-color: OldLAce">
&nbsp;
                <asp:Label ID="Label33" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Expected in range"></asp:Label>
            </td>
            <td class="auto-style6" style="background-color: OldLAce">
                <asp:TextBox ID="MiscExpminp" runat="server" BackColor="White" 
                    Font-Names="Arial" Font-Size="10pt" Height="20px" MaxLength="8" ReadOnly="True" 
                    style="text-align: center" Width="47px">-</asp:TextBox>
            </td>
            <td class="auto-style9" style="background-color: OldLAce">
                <asp:Label ID="Label39" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="-"></asp:Label>
                <asp:TextBox ID="MiscExpmaxp" runat="server" BackColor="White" Font-Names="Arial" 
                    Font-Size="10pt" Height="20px" MaxLength="8" ReadOnly="True" 
                    style="text-align: center" Width="47px">-</asp:TextBox>
                <asp:Label ID="Label41" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="%"></asp:Label>
            </td>
            <td class="style73" style="background-color: OldLAce">
                &nbsp;</td>
            <td style="background-color: transparent" class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style5" style="background-color: OldLAce">
&nbsp;
                <asp:Label ID="Label43" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="of "></asp:Label>
            &nbsp;<asp:TextBox ID="DevijacijaN" runat="server" BackColor="OldLace" Font-Names="Arial" 
                    Font-Size="10pt" Height="20px" MaxLength="1" style="text-align: center" 
                    Width="16px" BorderColor="OldLace" BorderStyle="Ridge" Font-Bold="True" 
                    ForeColor="#000099">3</asp:TextBox>
            &nbsp;<asp:Label ID="Label34" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text=" deviations"></asp:Label>
            </td>
            <td class="auto-style6" style="background-color: OldLAce">
                <asp:TextBox ID="MiscExpminN" runat="server" BackColor="White" 
                    Font-Names="Arial" Font-Size="10pt" Height="20px" MaxLength="8" ReadOnly="True" 
                    style="text-align: center" Width="47px">-</asp:TextBox>
            </td>
            <td class="auto-style9" style="background-color: OldLAce">
                <asp:Label ID="Label40" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="-"></asp:Label>
                <asp:TextBox ID="MiscExpmaxN" runat="server" BackColor="White" Font-Names="Arial" 
                    Font-Size="10pt" Height="20px" MaxLength="8" ReadOnly="True" 
                    style="text-align: center" Width="47px">-</asp:TextBox>
                <asp:Label ID="Label42" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="(HITs)"></asp:Label>
            </td>
            <td class="style73" style="background-color: OldLAce">
                &nbsp;</td>
            <td style="background-color: transparent" class="auto-style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                </td>
            <td class="auto-style5" style="background-color: OldLAce">
                </td>
            <td class="auto-style6" style="background-color: OldLAce">
                </td>
            <td class="auto-style9" style="background-color: OldLAce; text-align: center;">
                <asp:Button ID="MiscEXPECTEDHITTING" runat="server" BackColor="#003366" 
                    Font-Names="Arial" Font-Size="8pt" ForeColor="White" Height="23px" 
                    Text="Calculate" Width="55px" />
            </td>
            <td class="style73" style="background-color: OldLAce">
                </td>
            <td style="background-color: transparent" class="auto-style4">
                </td>
        </tr>
        <tr>
            <td class="auto-style3">
                </td>
            <td class="auto-style5" style="background-color: OldLAce">
                </td>
            <td class="auto-style6" style="background-color: OldLAce">
                </td>
            <td class="auto-style9" style="background-color: OldLAce">
                </td>
            <td class="style73" style="background-color: OldLAce">
                </td>
            <td style="background-color: transparent" class="auto-style4">
                </td>
        </tr>
    </table>
</asp:Content>
