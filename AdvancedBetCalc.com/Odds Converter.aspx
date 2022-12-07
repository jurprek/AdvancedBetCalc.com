<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Odds Converter.aspx.vb" Inherits="AdvancedBetCalc.com.Odds_Converter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style69
        {
            width: 320px;
        }
        .style70
        {
            width: 134px;
        }
        .style71
        {
            width: 76px;
        }
        .style72
        {
            width: 29px;
        }
        .auto-style1 {
            width: 250px;
        }
        .auto-style2 {
            width: 104px;
        }
        .auto-style3 {
            width: 270px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="style57" 
        style="border-style: none; border-width: 0px; padding: 0px; border-spacing: 0px; margin: 0px">
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70">
                &nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="style72">
                &nbsp;</td>
            <td class="auto-style3">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: #F9DFAE; text-align: right;">
                <asp:TextBox ID="oddsconvTempbox" runat="server" BackColor="#999999" 
                    Visible="False" Width="32px"></asp:TextBox>
                <asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="9pt" ForeColor="Black" Text="ODDS "></asp:Label>
            </td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: #F9DFAE">
&nbsp;
                <asp:Label ID="Label33" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="9pt" ForeColor="Black" Text="CONVERTER"></asp:Label>
            </td>
            <td class="style72" style="background-color: #F9DFAE">
                &nbsp;</td>
            <td rowspan="10" colspan="10">
                <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="134px" TextMode="MultiLine" Width="273px">Odds converter:

As many different bookies are offering different formats of odds, we offer a little help in a form of this calculator...</asp:TextBox>
                <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="161px" TextMode="MultiLine" Width="273px" Visible="False">Često u klađenju nailazimo na različite formate koeficijenata. Ovaj pretvornik je tu da bi vam olakšao snalaženje kada uspoređujete ponude raznih kladionica koje ne nude vama preferirani zapis,ili kada čitate strane forume čiji korisnici koriste vama nepoznate formate koeficijenata.
</asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
&nbsp;
                <asp:Label ID="Label24" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Implied Probability  ="></asp:Label>
            </td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                <asp:TextBox ID="ODDSImplied" runat="server" Font-Names="Arial" Font-Size="9pt" 
                    MaxLength="7" style="text-align: center" Width="53px">54.0541</asp:TextBox>
                <asp:Label ID="Label32" runat="server" Font-Names="Arial" Font-Size="9pt" 
                    ForeColor="Black" Text="%"></asp:Label>
            </td>
            <td class="style72" style="background-color: OldLace">
                <asp:Button ID="ButtonOddsCon1" runat="server" BackColor="#0066CC" 
                    Font-Names="Arial" Font-Size="7pt" ForeColor="White" Height="21px" Text="GO" 
                    Width="27px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                &nbsp;
                <asp:Label ID="Label25" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Decimal  (Europe) ="></asp:Label>
                &nbsp;</td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                <asp:TextBox ID="ODDSDecimal" runat="server" Font-Names="Arial" Font-Size="9pt" 
                    MaxLength="6" style="text-align: center" Width="53px">1.8500</asp:TextBox>
&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style72" style="background-color: OldLace">
                <asp:Button ID="ButtonOddsCon2" runat="server" BackColor="#0066CC" 
                    Font-Names="Arial" Font-Size="7pt" ForeColor="White" Height="21px" Text="GO" 
                    Width="27px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                &nbsp;
                <asp:Label ID="Label26" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Moneyline (US) ="></asp:Label>
                &nbsp;</td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                <asp:TextBox ID="ODDSMoneyline" runat="server" Font-Names="Arial" 
                    Font-Size="9pt" MaxLength="7" style="text-align: center" Width="53px">- 117.65</asp:TextBox>
&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style72" style="background-color: OldLace">
                <asp:Button ID="ButtonOddsCon3" runat="server" BackColor="#0066CC" 
                    Font-Names="Arial" Font-Size="7pt" ForeColor="White" Height="21px" Text="GO" 
                    Width="27px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                &nbsp;
                <asp:Label ID="Label27" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Fractions (UK)  ="></asp:Label>
                &nbsp;</td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                <asp:TextBox ID="ODDSFractions" runat="server" Font-Names="Arial" 
                    Font-Size="9pt" MaxLength="7" style="text-align: center" Width="53px">17/20</asp:TextBox>
&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style72" style="background-color: OldLace">
                <asp:Button ID="ButtonOddsCon4" runat="server" BackColor="#0066CC" 
                    Font-Names="Arial" Font-Size="7pt" ForeColor="White" Height="21px" Text="GO" 
                    Width="27px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                &nbsp;
                <asp:Label ID="Label28" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Hong Kong  ="></asp:Label>
                &nbsp;</td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                <asp:TextBox ID="ODDSHongKong" runat="server" Font-Names="Arial" 
                    Font-Size="9pt" MaxLength="6" style="text-align: center" Width="53px">0.8500</asp:TextBox>
&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style72" style="background-color: OldLace">
                <asp:Button ID="ButtonOddsCon5" runat="server" BackColor="#0066CC" 
                    Font-Names="Arial" Font-Size="7pt" ForeColor="White" Height="21px" Text="GO" 
                    Width="27px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                &nbsp;
                <asp:Label ID="Label29" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Indonesian  ="></asp:Label>
                &nbsp;</td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                <asp:TextBox ID="ODDSIndonesian" runat="server" Font-Names="Arial" 
                    Font-Size="9pt" MaxLength="7" style="text-align: center" Width="53px">- 1.1765</asp:TextBox>
&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style72" style="background-color: OldLace">
                <asp:Button ID="ButtonOddsCon6" runat="server" BackColor="#0066CC" 
                    Font-Names="Arial" Font-Size="7pt" ForeColor="White" Height="21px" Text="GO" 
                    Width="27px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                &nbsp;
                <asp:Label ID="Label30" runat="server" Font-Names="Arial" Font-Size="10pt" 
                    ForeColor="Black" Text="Malay  ="></asp:Label>
                &nbsp;</td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                <asp:TextBox ID="ODDSMalay" runat="server" Font-Names="Arial" Font-Size="9pt" 
                    MaxLength="6" style="text-align: center" Width="53px">0.8500</asp:TextBox>
&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style72" style="background-color: OldLace">
                <asp:Button ID="ButtonOddsCon7" runat="server" BackColor="#0066CC" 
                    Font-Names="Arial" Font-Size="7pt" ForeColor="White" Height="21px" Text="GO" 
                    Width="27px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                &nbsp;</td>
            <td class="auto-style2" 
                style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px; background-color: OldLace">
                &nbsp;</td>
            <td class="style72" style="background-color: OldLace">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                &nbsp;</td>
            <td class="style70" 
                style="background-color: transparent">
                &nbsp;</td>
            <td class="auto-style2" 
                style="background-color: transparent">
                &nbsp;</td>
            <td class="style72" style="background-color: transparent">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
