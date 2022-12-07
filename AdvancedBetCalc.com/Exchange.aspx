<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Exchange.aspx.vb" Inherits="AdvancedBetCalc.com.Exchange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 83%;
            margin-top: 0px;
        }
        .style3
        {
            width: 80px;
        }
        .style6
        {
            width: 60px;
        }
        .style8
        {
            width: 110px;
        }
        .style7
        {
            width: 130px;
        }
        .style5
        {
            width: 100px;
        }
        .style69
        {
            width: 160px;
        }
        .auto-style1 {
            width: 40px;
        }
        .auto-style3 {
            width: 100%;
            margin-top: 0px;
        }
        .auto-style4 {
            width: 804px;
        }
        .auto-style6 {
            width: 804px;
            height: 100px;
        }
        .auto-style7 {
            width: 804px;
            height: 44px;
        }
        .auto-style8 {
            height: 11px;
        }
        .auto-style10 {
            height: 11px;
            width: 187px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <br />
        <table class="auto-style3">
            <tr>
                <td class="auto-style1" rowspan="4">
                    &nbsp;</td>
                <td class="auto-style8">
                    </td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
                <td class="auto-style8">
                    <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
                    </td>
                <td class="auto-style8">
                    <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <table align="center" cellpadding="0" cellspacing="0" class="auto-style3">
                        <tr>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="25px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style3" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style6" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="60px">
                                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Money"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="My"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Final"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#121212" class="style8" colspan="1" rowspan="1">
                                <asp:Label ID="Label8" runat="server" BackColor="#121212" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="Yellow" Text="Rake ="></asp:Label>
                            </td>
                            <td align="center" bgcolor="#121212" class="style7" colspan="1" rowspan="1">
                                <asp:TextBox ID="rake" runat="server" BackColor="#121212" BorderStyle="None" 
                                    Font-Bold="True" Font-Names="Arial" Font-Size="Smaller" ForeColor="Yellow" 
                                    MaxLength="6" Width="30px">5.00</asp:TextBox>
                                <asp:Label ID="Label16" runat="server" BackColor="#121212" BorderStyle="None" 
                                    Font-Bold="True" Font-Names="Arial" Font-Size="Smaller" ForeColor="Yellow" 
                                    Text="%"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Becker´s"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="My"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="25px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style3" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style6" colspan="1" rowspan="1">
                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Tip"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="60px">
                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Ratio"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Liability"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Win"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" class="style8" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style7" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Stake"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="White" Text="Liability"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                        </tr>
                        <tr bgcolor="White">
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="25px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style3" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style6" colspan="1" rowspan="1">
                                <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="#333333" Text="1"></asp:Label>
                            </td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="60px">
                                <asp:TextBox ID="Ratio1" runat="server" BorderStyle="None" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="#003399" MaxLength="6" 
                                    Width="35px">50.00</asp:TextBox>
                                <asp:Label ID="Label17" runat="server" BackColor="White" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="#003366" Text="%"></asp:Label>
                            </td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                <asp:TextBox ID="Ulog1" runat="server" BorderStyle="None" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="#003399" MaxLength="8" 
                                    Width="60px">100.00</asp:TextBox>
                            </td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                <asp:TextBox ID="Win1" runat="server" BorderStyle="None" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="#009900" ReadOnly="True" 
                                    Width="60px">80.95</asp:TextBox>
                            </td>
                            <td align="center" bgcolor="#99CCFF" class="style8" colspan="1" rowspan="1">
                                <asp:TextBox ID="Backodds" runat="server" BackColor="#99CCFF" 
                                    BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="Smaller" 
                                    ForeColor="#003399" MaxLength="6" Width="30px">1.85</asp:TextBox>
                            </td>
                            <td align="center" bgcolor="#FF9999" class="style7" colspan="1" rowspan="1">
                                <asp:TextBox ID="Layodds" runat="server" BackColor="#FF9999" BorderStyle="None" 
                                    Font-Bold="True" Font-Names="Arial" Font-Size="Smaller" ForeColor="#003399" 
                                    MaxLength="6" Width="30px">1.78</asp:TextBox>
                            </td>
                            <td align="center" colspan="1" rowspan="1" width="75px">
                                <asp:TextBox ID="BckrStake" runat="server" BorderStyle="None" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="#003399" MaxLength="8" 
                                    Width="60px">0.00</asp:TextBox>
                            </td>
                            <td align="center" colspan="1" rowspan="1" width="75px">
                                <asp:TextBox ID="MyLiability" runat="server" BorderStyle="None" 
                                    Font-Bold="True" Font-Names="Arial" Font-Size="Smaller" ForeColor="#003399" 
                                    ReadOnly="True" Width="60px">0.00</asp:TextBox>
                            </td>
                            <td align="center" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="25px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style3" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style6" colspan="1" rowspan="1">
                                <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="#333333" Text="2"></asp:Label>
                            </td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="60px">
                                <asp:TextBox ID="Ratio2" runat="server" BorderStyle="None" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="#999999" ReadOnly="True" 
                                    Width="35px">50.00</asp:TextBox>
                                <asp:Label ID="Label18" runat="server" BackColor="White" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="#999999" Text="%"></asp:Label>
                            </td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                <asp:TextBox ID="Win2" runat="server" BorderStyle="None" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="Red" ReadOnly="True" 
                                    Width="60px">-100.00</asp:TextBox>
                            </td>
                            <td align="center" bgcolor="#99CCFF" class="style8" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#FF9999" class="style7" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="25px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style3" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style6" colspan="1" rowspan="1">
                                <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Names="Arial" 
                                    Font-Size="Smaller" ForeColor="#333333" Text="(X)"></asp:Label>
                            </td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="60px">
                                <asp:Button ID="RatioButton" runat="server" BackColor="#333333" 
                                    Font-Bold="True" Font-Names="Arial" Font-Size="Smaller" ForeColor="White" 
                                    Height="16px" Text="Rationalize" Width="74px" />
                            </td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                <asp:TextBox ID="Win3" runat="server" BorderStyle="None" Font-Bold="True" 
                                    Font-Names="Arial" Font-Size="Smaller" ForeColor="Red" ReadOnly="True" 
                                    Width="60px">-100.00</asp:TextBox>
                            </td>
                            <td align="center" bgcolor="#99CCFF" class="style8" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#FF9999" class="style7" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="25px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style3" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style6" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="60px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style8" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" class="style7" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                <asp:Button ID="BeckersButton" runat="server" BackColor="#FF9900" 
                                    Font-Bold="True" Font-Names="Arial" Font-Size="Smaller" ForeColor="Black" 
                                    Height="16px" Text="GO" Width="60px" />
                            </td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="White" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="25px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style3" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style6" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="60px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style8" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" class="style7" colspan="1" rowspan="1">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                            <td align="center" bgcolor="#333333" colspan="1" rowspan="1" width="75px">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
                <td rowspan="3" colspan="14">
                    <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="275px" TextMode="MultiLine" Width="329px">Exchange calc:

Help with trading odds on bet exchange platforms.

When we decide to close position then this tool can be of a great assistance...,
whether we were trading or we were simply backing our favourite and then circumstances were changed and we decided to back an opposite team (to win small either way, or to get out of a bead bet..).

We can choose to input counter bet manually (then we go via &quot;Go&quot; button) or to ask calculator to divide winnings by ratio (Ratio button, of course).
</asp:TextBox>
                    <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="315px" TextMode="MultiLine" Width="329px" Visible="False">Exchange kalkulator pomaže kod trgovanja koeficijentima na burzama poput BetFair-a i sl.

Kod „povlačenja iz oklade“ tj. zatvaranja pozicije, ovaj pomoćni alat je od velike koristi. Može na brzinu izračunati koji iznos treba uložiti na novodobiveni koeficijent da bi dobitak ili gubitak bili raspoređeni u omjeru koji želite, ili jednostavno pokazuje raspodjelu dobiti i gubitka koju želite vidjeti uz proizvoljno odabrani iznos unesen u „Backer`s Stake“  tj. „kontra okladu“ - klikom na Go gumb.

Npr. uloženo je $100.00 na kfc. 1.85, ali sada se isti događaj trguje po 1.78. Želi se zaraditi jednako bez obzira na ishod, pa se „Money Ratio“ postavlja na 50%. Klikom na „Rationalize“ kalkulator izračunava potrebne „Backer`s Stake“ i „My Liability“ iznose.

</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
    </p>
</asp:Content>
