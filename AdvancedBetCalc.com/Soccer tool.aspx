<%@ Page Title="AdvancedBetCalc.com - Soccer" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Soccer tool.aspx.vb" Inherits="AdvancedBetCalc.com.Soccer_tool" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
            width: 399px;
        }
        .auto-style9 {
            width: 399px;
        }
        .auto-style10 {
            width: 399px;
            text-align: left;
        }
        .auto-style11 {
            height: 82px;
        }
        .auto-style12 {
            width: 399px;
            height: 82px;
        }
    .auto-style13 {
        height: 20px;
    }
    .auto-style14 {
        height: 20px;
        width: 399px;
    }
        .auto-style17 {
            height: 4px;
        }
        .auto-style18 {
            height: 4px;
            width: 399px;
        }
        .auto-style21 {
            height: 2px;
        }
        .auto-style22 {
            height: 2px;
            width: 399px;
        }
        .auto-style23 {
            height: 1px;
        }
        .auto-style24 {
            width: 399px;
            height: 1px;
        }
        .auto-style25 {
            height: 5px;
        }
        .auto-style26 {
            height: 5px;
            width: 399px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table class="style57" style="background-color: Transparent; background-image: url('Slike/bg-blurred.jpg');">
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7"></td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6">
                <asp:CheckBox ID="CheckBoxListem" runat="server" Text="List exact score chances &amp; odds" Checked="True" />
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="Suma1" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Yellow" style="text-align:center" Width="30px" Visible="False">1</asp:TextBox>
                <asp:TextBox ID="expectPoeni1" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Yellow" style="text-align:center" Width="30px" Visible="False">?1</asp:TextBox>
                <asp:TextBox ID="TemporaryHome" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Yellow" style="text-align:center" Width="30px" Visible="False"></asp:TextBox>
                </td>
            <td class="auto-style6">
                <asp:TextBox ID="TemporaryAway" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Yellow" style="text-align:center" Width="30px" Visible="False"></asp:TextBox>
                <asp:TextBox ID="expectPoeniX" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Yellow" style="text-align:center" Width="30px" Visible="False">?X</asp:TextBox>
                <asp:TextBox ID="sumaPoeni12" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Yellow" style="text-align:center" Width="30px" Visible="False">?12</asp:TextBox>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        </table>
    <p>
    </p>
    <table class="style57" style="background-color: Transparent; background-image: url('Slike/bg-blurred.jpg');">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style10" style="border-style: inset">
                <asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="White" Text="Home"></asp:Label>
                <asp:TextBox ID="Home" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="White" style="text-align:center" Width="50px" MaxLength="6" ToolTip="(Home average scores) x (Away average receives) x (Home scoring league average)">1.850</asp:TextBox>
                &nbsp;<asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="White" Text="-"></asp:Label>
&nbsp;<asp:TextBox ID="Away" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="White" style="text-align:center" Width="50px" MaxLength="6" ToolTip="(Away average scores) x (Home average receives) x (Away scoring league average)">0.750</asp:TextBox>
                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="White" Text="Away"></asp:Label>
&nbsp;&nbsp;&nbsp;<asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#CCCCFF" Text="Theta"></asp:Label>
                <asp:TextBox ID="ThetaPoisson" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#CCCCFF" style="text-align:center" Width="60px" MaxLength="8" ToolTip="Covariance, when it is set to zero then calculation goes by &quot;normal&quot; Poisson, otherwise it uses bivariate version.                                 Range from -1 to 1.">-0.00</asp:TextBox>
                &nbsp;&nbsp;
                <asp:Button ID="CalcPoisson" runat="server" Font-Names="Arial" Font-Size="9pt" Height="20px" Text="Calculate" BackColor="#0066FF" Font-Bold="False" ForeColor="White" Width="67px" />
                &nbsp;
                </td>
            <td>
                <asp:TextBox ID="HW1" runat="server" Width="30px" ReadOnly="True" Visible="False">0.76</asp:TextBox>
                <asp:TextBox ID="HX1" runat="server" Width="30px" ReadOnly="True" Visible="False">0.20</asp:TextBox>
                <asp:TextBox ID="HL1" runat="server" Width="30px" ReadOnly="True" Visible="False">0.04</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW1" runat="server" Width="30px" ReadOnly="True" Visible="False">0.64</asp:TextBox>
                <asp:TextBox ID="AX1" runat="server" Width="30px" ReadOnly="True" Visible="False">0.23</asp:TextBox>
                <asp:TextBox ID="AL1" runat="server" Width="30px" ReadOnly="True" Visible="False">0.13</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td rowspan="13">
                <asp:TextBox ID="ScoreTextBox" runat="server" Height="550px" ReadOnly="True" TextMode="MultiLine" Width="248px" BackColor="Transparent" Font-Names="Arial" Font-Size="8pt" ForeColor="#CCFFFF"></asp:TextBox>
            </td>
            <td colspan="2" rowspan="3"></td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style14" style="border-style: none">
                </td>
            <td class="auto-style13">
            </td>
            <td class="auto-style13">
            </td>
            <td class="auto-style13"></td>
            <td class="auto-style13"></td>
            <td class="auto-style13"></td>
        </tr>
        <tr>
            <td class="auto-style11"></td>
            <td class="auto-style12" style="border-style: inset inset none inset">
                <asp:Label ID="Label46" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FF99FF" Text="Range of expected place at the end of the season:" ToolTip="Holo-matrix method. Sets odds boundaries (based on Eng.Premier seasons avg. from 2005.-2014.)."></asp:Label>
                <br />
                <asp:Label ID="Label33" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FF99FF" Text="Home best"></asp:Label>
                <asp:Label ID="Label35" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Transparent" Text="___"></asp:Label>
                <asp:Label ID="Label34" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FF99FF" Text="Away best"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label51" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Silver" Text="This is control part. It uses &quot;Holo-matrix&quot; method." BackColor="#333333" ToolTip="Will be explained in the Theory section."></asp:Label>
                <br />
                <asp:TextBox ID="HoloHomeFrom" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="50px" MaxLength="2" ToolTip="From place">3</asp:TextBox>
                &nbsp;<asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" Text="vs"></asp:Label>
&nbsp;<asp:TextBox ID="HoloAwayFrom" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="50px" MaxLength="2" ToolTip="From place">8</asp:TextBox>
                &nbsp;&nbsp;
                <asp:Label ID="Label50" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Silver" Text="Odds calculated by using (Bv)Poisson distribution" BackColor="#333333"></asp:Label>
                <br />
                <asp:TextBox ID="HoloHomeTo" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="50px" MaxLength="2" ToolTip="To place">5</asp:TextBox>
                &nbsp;<asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Transparent" Text="vs"></asp:Label>
&nbsp;<asp:TextBox ID="HoloAwayTo" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="50px" MaxLength="2" ToolTip="To place">13</asp:TextBox>
                &nbsp;&nbsp;
                <asp:Label ID="Label49" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Silver" Text="should be inside this boundaries." BackColor="#333333"></asp:Label>
                <br />
                <asp:Label ID="Label37" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FF99FF" Text="Home worst"></asp:Label>
                <asp:Label ID="Label38" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Transparent" Text="__"></asp:Label>
                <asp:Label ID="Label40" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FF99FF" Text="Away worst"></asp:Label>
                </td>
            <td class="auto-style11">
                <asp:TextBox ID="HW2" runat="server" Width="30px" ReadOnly="True" Visible="False">0.68</asp:TextBox>
                <asp:TextBox ID="HX2" runat="server" Width="30px" ReadOnly="True" Visible="False">0.25</asp:TextBox>
                <asp:TextBox ID="HL2" runat="server" Width="30px" ReadOnly="True" Visible="False">0.07</asp:TextBox>
            </td>
            <td class="auto-style11">
                <asp:TextBox ID="AW2" runat="server" Width="30px" ReadOnly="True" Visible="False">0.58</asp:TextBox>
                <asp:TextBox ID="AX2" runat="server" Width="30px" ReadOnly="True" Visible="False">0.25</asp:TextBox>
                <asp:TextBox ID="AL2" runat="server" Width="30px" ReadOnly="True" Visible="False">0.18</asp:TextBox>
            </td>
            <td class="auto-style11"></td>
            <td class="auto-style11"></td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9" style="border-style: none inset inset inset">
                <br />
                <asp:Label ID="Label41" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FF99FF" Text="Odds range based on -end of season place- expectancy:"></asp:Label>
                <br />
                <asp:Label ID="Label42" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FF99FF" Text="From :"></asp:Label>
                <asp:TextBox ID="HoloTIP1a" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="40px" ToolTip="Home wins" ReadOnly="True">-</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="HoloTIPXa" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="40px" ToolTip="Draw" ReadOnly="True">-</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="HoloTIP2a" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="40px" ToolTip="Away wins" ReadOnly="True">-</asp:TextBox>
                <br />
                <asp:Label ID="Label43" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FF99FF" Text="To :"></asp:Label>
                <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="Transparent" Text="..."></asp:Label>
                <asp:TextBox ID="HoloTIP1b" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="40px" ToolTip="Home wins" ReadOnly="True">-</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="HoloTIPXb" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="40px" ToolTip="Draw" ReadOnly="True">-</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="HoloTIP2b" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FF99FF" style="text-align:center" Width="40px" ToolTip="Away wins" ReadOnly="True">-</asp:TextBox>
                </td>
            <td>
                <asp:TextBox ID="HW3" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.62</asp:TextBox>
                <asp:TextBox ID="HX3" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.27</asp:TextBox>
                <asp:TextBox ID="HL3" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.11</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW3" runat="server" Width="30px" ReadOnly="True" Visible="False">0.53</asp:TextBox>
                <asp:TextBox ID="AX3" runat="server" Width="30px" ReadOnly="True" Visible="False">0.25</asp:TextBox>
                <asp:TextBox ID="AL3" runat="server" Width="30px" ReadOnly="True" Visible="False">0.22</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9" style="border-style: inset">
                <br />
                <asp:Label ID="Label45" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="White" Text="Odds based on (Biv.)Poisson values:"></asp:Label>
                <br />
                <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="12pt" ForeColor="White" Text="Home"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label30" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="12pt" ForeColor="White" Text="Draw"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label29" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="12pt" ForeColor="White" Text="Away"></asp:Label>
                <br />
                <asp:TextBox ID="TIP1" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="12pt" ForeColor="White" style="text-align:center" Width="50px" ToolTip="Home wins" ReadOnly="True">1</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="TIPX" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="12pt" ForeColor="White" style="text-align:center" Width="50px" ToolTip="Draw" ReadOnly="True">X</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="TIP2" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="True" Font-Names="Arial" Font-Size="12pt" ForeColor="White" style="text-align:center" Width="45px" ToolTip="Away wins" ReadOnly="True">2</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="HW4" runat="server" Width="30px" ReadOnly="True" Visible="False">0.56</asp:TextBox>
                <asp:TextBox ID="HX4" runat="server" Width="30px" ReadOnly="True" Visible="False">0.30</asp:TextBox>
                <asp:TextBox ID="HL4" runat="server" Width="30px" ReadOnly="True" Visible="False">0.14</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW4" runat="server" Width="30px" ReadOnly="True" Visible="False">0.48</asp:TextBox>
                <asp:TextBox ID="AX4" runat="server" Width="30px" ReadOnly="True" Visible="False">0.26</asp:TextBox>
                <asp:TextBox ID="AL4" runat="server" Width="30px" ReadOnly="True" Visible="False">0.26</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
            <td>
                <asp:TextBox ID="HW5" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.51</asp:TextBox>
                <asp:TextBox ID="HX5" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.31</asp:TextBox>
                <asp:TextBox ID="HL5" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.17</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW5" runat="server" Width="30px" ReadOnly="True" Visible="False">0.44</asp:TextBox>
                <asp:TextBox ID="AX5" runat="server" Width="30px" ReadOnly="True" Visible="False">0.26</asp:TextBox>
                <asp:TextBox ID="AL5" runat="server" Width="30px" ReadOnly="True" Visible="False">0.30</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9" style="border-style: inset inset none inset">
                <asp:Label ID="Label47" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FFFF99" Text="Under / Over - number of goals:"></asp:Label>
                <br />
                <asp:TextBox ID="UpitBp_05" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Under/Over goals">0.5</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="OdgovorBP1_05" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Under" ReadOnly="True">-</asp:TextBox>
                &nbsp;<asp:TextBox ID="OdgovorBPX_05" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Exact" ReadOnly="True">-</asp:TextBox>
                &nbsp;<asp:TextBox ID="OdgovorBP2_05" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Over" ReadOnly="True">-</asp:TextBox>
                </td>
            <td>
                <asp:TextBox ID="HW6" runat="server" Width="30px" ReadOnly="True" Visible="False">0.47</asp:TextBox>
                <asp:TextBox ID="HX6" runat="server" Width="30px" ReadOnly="True" Visible="False">0.33</asp:TextBox>
                <asp:TextBox ID="HL6" runat="server" Width="30px" ReadOnly="True" Visible="False">0.20</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW6" runat="server" Width="30px" ReadOnly="True" Visible="False">0.41</asp:TextBox>
                <asp:TextBox ID="AX6" runat="server" Width="30px" ReadOnly="True" Visible="False">0.26</asp:TextBox>
                <asp:TextBox ID="AL6" runat="server" Width="30px" ReadOnly="True" Visible="False">0.33</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7" style="border-style: none inset none inset">
                <asp:TextBox ID="UpitBp_10" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Under/Over goals">2.0</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="OdgovorBP1_10" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Under" ReadOnly="True">-</asp:TextBox>
                &nbsp;<asp:TextBox ID="OdgovorBPX_10" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Exact" ReadOnly="True">-</asp:TextBox>
                &nbsp;<asp:TextBox ID="OdgovorBP2_10" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Over" ReadOnly="True">-</asp:TextBox>
                </td>
            <td class="auto-style6">
                <asp:TextBox ID="HW7" runat="server" Width="30px" ReadOnly="True" Visible="False">0.44</asp:TextBox>
                <asp:TextBox ID="HX7" runat="server" Width="30px" ReadOnly="True" Visible="False">0.34</asp:TextBox>
                <asp:TextBox ID="HL7" runat="server" Width="30px" ReadOnly="True" Visible="False">0.22</asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="AW7" runat="server" Width="30px" ReadOnly="True" Visible="False">0.37</asp:TextBox>
                <asp:TextBox ID="AX7" runat="server" Width="30px" ReadOnly="True" Visible="False">0.27</asp:TextBox>
                <asp:TextBox ID="AL7" runat="server" Width="30px" ReadOnly="True" Visible="False">0.36</asp:TextBox>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7" style="border-style: none inset inset inset">
                <asp:TextBox ID="UpitBp_15" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Under/Over goals">2.5</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="OdgovorBP1_15" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Under" ReadOnly="True">-</asp:TextBox>
                &nbsp;<asp:TextBox ID="OdgovorBPX_15" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Exact" ReadOnly="True">-</asp:TextBox>
                &nbsp;<asp:TextBox ID="OdgovorBP2_15" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFFF99" style="text-align:center" Width="40px" ToolTip="Over" ReadOnly="True">-</asp:TextBox>
                </td>
            <td class="auto-style6">
                <asp:TextBox ID="HW8" runat="server" Width="30px" ReadOnly="True" Visible="False">0.41</asp:TextBox>
                <asp:TextBox ID="HX8" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL8" runat="server" Width="30px" ReadOnly="True" Visible="False">0.24</asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="AW8" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.34</asp:TextBox>
                <asp:TextBox ID="AX8" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.27</asp:TextBox>
                <asp:TextBox ID="AL8" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.39</asp:TextBox>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9" style="border-style: inset">
                <asp:Label ID="Label48" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#FFCCFF" Text="Handicap odds:"></asp:Label>
                <br />
                <asp:TextBox ID="Hndcp" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="Groove" Font-Bold="True" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFCCFF" style="text-align:center" Width="40px" ToolTip="Home handicap  -/+">-1.5</asp:TextBox>
                &nbsp;&nbsp;<asp:TextBox ID="Hndcp1" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFCCFF" style="text-align:center" Width="40px" ReadOnly="True" ToolTip="Home wins (when handicap included)">-</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="HndcpX" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFCCFF" style="text-align:center" Width="40px" ReadOnly="True" ToolTip="Draw (when handicap included)">-</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="Hndcp2" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#FFCCFF" style="text-align:center" Width="40px" ReadOnly="True" ToolTip="Away wins (when handicap included)">-</asp:TextBox>
                </td>
            <td>
                <asp:TextBox ID="HW9" runat="server" Width="30px" ReadOnly="True" Visible="False">0.38</asp:TextBox>
                <asp:TextBox ID="HX9" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL9" runat="server" Width="30px" ReadOnly="True" Visible="False">0.26</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW9" runat="server" Width="30px" ReadOnly="True" Visible="False">0.32</asp:TextBox>
                <asp:TextBox ID="AX9" runat="server" Width="30px" ReadOnly="True" Visible="False">0.27</asp:TextBox>
                <asp:TextBox ID="AL9" runat="server" Width="30px" ReadOnly="True" Visible="False">0.41</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
            <td>
                <asp:TextBox ID="HW10" runat="server" Width="30px" ReadOnly="True" Visible="False">0.36</asp:TextBox>
                <asp:TextBox ID="HX10" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL10" runat="server" Width="30px" ReadOnly="True" Visible="False">0.28</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW10" runat="server" Width="30px" ReadOnly="True" Visible="False">0.30</asp:TextBox>
                <asp:TextBox ID="AX10" runat="server" Width="30px" ReadOnly="True" Visible="False">0.27</asp:TextBox>
                <asp:TextBox ID="AL10" runat="server" Width="30px" ReadOnly="True" Visible="False">0.43</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9" style="border-style: inset">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label52" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#CCFF66" Text="Odd"></asp:Label>
                &nbsp;&nbsp;
                <asp:Label ID="Label53" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#CCFF66" Text="/"></asp:Label>
                &nbsp;&nbsp;
                <asp:Label ID="Label54" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#CCFF66" Text="Even"></asp:Label>
                <br />
                &nbsp;&nbsp;<asp:TextBox ID="OddGoals" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#CCFF66" style="text-align:center" Width="45px" ReadOnly="True" ToolTip="Home wins (when handicap included)">-</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="EvenGoals" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#CCFF66" style="text-align:center" Width="45px" ReadOnly="True" ToolTip="Draw (when handicap included)">-</asp:TextBox>
                &nbsp;
                </td>
            <td>
                <asp:TextBox ID="HW11" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HX11" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL11" runat="server" Width="30px" ReadOnly="True" Visible="False">0.30</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW11" runat="server" Width="30px" ReadOnly="True" Visible="False">0.28</asp:TextBox>
                <asp:TextBox ID="AX11" runat="server" Width="30px" ReadOnly="True" Visible="False">0.27</asp:TextBox>
                <asp:TextBox ID="AL11" runat="server" Width="30px" ReadOnly="True" Visible="False">0.45</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9" style="border-style: inset">
                &nbsp;
                <asp:Label ID="Label55" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="#CCCCFF" Text="Scores no goal: Home / Away"></asp:Label>
                &nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="HomeZeroGoals" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#CCCCFF" style="text-align:center" Width="35px" ReadOnly="True" ToolTip="Home wins (when handicap included)">-</asp:TextBox>
                <asp:TextBox ID="AwayZeroGoals" runat="server" BackColor="Transparent" BorderColor="White" BorderStyle="None" Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="#CCCCFF" style="text-align:center" Width="35px" ReadOnly="True" ToolTip="Draw (when handicap included)">-</asp:TextBox>
                &nbsp;
                </td>
            <td>
                <asp:TextBox ID="HW12" runat="server" Width="30px" ReadOnly="True" Visible="False">0.33</asp:TextBox>
                <asp:TextBox ID="HX12" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL12" runat="server" Width="30px" ReadOnly="True" Visible="False">0.32</asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="AW12" runat="server" Width="30px" ReadOnly="True" Visible="False">0.26</asp:TextBox>
                <asp:TextBox ID="AX12" runat="server" Width="30px" ReadOnly="True" Visible="False">0.26</asp:TextBox>
                <asp:TextBox ID="AL12" runat="server" Width="30px" ReadOnly="True" Visible="False">0.48</asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21"></td>
            <td class="auto-style22">
                </td>
            <td class="auto-style21">
                <asp:TextBox ID="HW13" runat="server" Width="30px" ReadOnly="True" Visible="False">0.31</asp:TextBox>
                <asp:TextBox ID="HX13" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL13" runat="server" Width="30px" ReadOnly="True" Visible="False">0.34</asp:TextBox>
            </td>
            <td class="auto-style21">
                <asp:TextBox ID="AW13" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.25</asp:TextBox>
                <asp:TextBox ID="AX13" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.26</asp:TextBox>
                <asp:TextBox ID="AL13" runat="server" Width="30px" BackColor="White" ReadOnly="True" Visible="False">0.49</asp:TextBox>
            </td>
            <td class="auto-style21"></td>
            <td rowspan="4">
                &nbsp;</td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style21"></td>
            <td class="auto-style22">
                </td>
            <td class="auto-style21">
                <asp:TextBox ID="HW14" runat="server" Width="30px" ReadOnly="True" Visible="False">0.29</asp:TextBox>
                <asp:TextBox ID="HX14" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL14" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
            </td>
            <td class="auto-style21">
                <asp:TextBox ID="AW14" runat="server" Width="30px" ReadOnly="True" Visible="False">0.23</asp:TextBox>
                <asp:TextBox ID="AX14" runat="server" Width="30px" ReadOnly="True" Visible="False">0.26</asp:TextBox>
                <asp:TextBox ID="AL14" runat="server" Width="30px" ReadOnly="True" Visible="False">0.51</asp:TextBox>
            </td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style17"></td>
            <td class="auto-style18"></td>
            <td class="auto-style17">
                <asp:TextBox ID="HW15" runat="server" Width="30px" ReadOnly="True" Visible="False">0.28</asp:TextBox>
                <asp:TextBox ID="HX15" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL15" runat="server" Width="30px" ReadOnly="True" Visible="False">0.37</asp:TextBox>
            </td>
            <td class="auto-style17">
                <asp:TextBox ID="AW15" runat="server" Width="30px" ReadOnly="True" Visible="False">0.22</asp:TextBox>
                <asp:TextBox ID="AX15" runat="server" Width="30px" ReadOnly="True" Visible="False">0.25</asp:TextBox>
                <asp:TextBox ID="AL15" runat="server" Width="30px" ReadOnly="True" Visible="False">0.53</asp:TextBox>
            </td>
            <td class="auto-style17"></td>
            <td class="auto-style17"></td>
            <td class="auto-style17"></td>
            <td class="auto-style17"></td>
            <td class="auto-style17"></td>
        </tr>
        <tr>
            <td class="auto-style23"></td>
            <td class="auto-style24"></td>
            <td class="auto-style23">
                <asp:TextBox ID="HW16" runat="server" Width="30px" ReadOnly="True" Visible="False">0.25</asp:TextBox>
                <asp:TextBox ID="HX16" runat="server" Width="30px" ReadOnly="True" Visible="False">0.36</asp:TextBox>
                <asp:TextBox ID="HL16" runat="server" Width="30px" ReadOnly="True" Visible="False">0.39</asp:TextBox>
            </td>
            <td class="auto-style23">
                <asp:TextBox ID="AW16" runat="server" Width="30px" ReadOnly="True" Visible="False">0.21</asp:TextBox>
                <asp:TextBox ID="AX16" runat="server" Width="30px" ReadOnly="True" Visible="False">0.24</asp:TextBox>
                <asp:TextBox ID="AL16" runat="server" Width="30px" ReadOnly="True" Visible="False">0.54</asp:TextBox>
            </td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style21"></td>
            <td class="auto-style22"></td>
            <td class="auto-style21">
                <asp:TextBox ID="HW17" runat="server" Width="30px" ReadOnly="True" Visible="False">0.24</asp:TextBox>
                <asp:TextBox ID="HX17" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL17" runat="server" Width="30px" ReadOnly="True" Visible="False">0.42</asp:TextBox>
            </td>
            <td class="auto-style21">
                <asp:TextBox ID="AW17" runat="server" Width="30px" ReadOnly="True" Visible="False">0.20</asp:TextBox>
                <asp:TextBox ID="AX17" runat="server" Width="30px" ReadOnly="True" Visible="False">0.24</asp:TextBox>
                <asp:TextBox ID="AL17" runat="server" Width="30px" ReadOnly="True" Visible="False">0.56</asp:TextBox>
            </td>
            <td class="auto-style21"></td>
            <td rowspan="4">
                &nbsp;</td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style25"></td>
            <td class="auto-style26"></td>
            <td class="auto-style25">
                <asp:TextBox ID="HW18" runat="server" Width="30px" ReadOnly="True" Visible="False">0.21</asp:TextBox>
                <asp:TextBox ID="HX18" runat="server" Width="30px" ReadOnly="True" Visible="False">0.35</asp:TextBox>
                <asp:TextBox ID="HL18" runat="server" Width="30px" ReadOnly="True" Visible="False">0.44</asp:TextBox>
            </td>
            <td class="auto-style25">
                <asp:TextBox ID="AW18" runat="server" Width="30px" ReadOnly="True" Visible="False">0.19</asp:TextBox>
                <asp:TextBox ID="AX18" runat="server" Width="30px" ReadOnly="True" Visible="False">0.23</asp:TextBox>
                <asp:TextBox ID="AL18" runat="server" Width="30px" ReadOnly="True" Visible="False">0.58</asp:TextBox>
            </td>
            <td class="auto-style25"></td>
            <td class="auto-style25"></td>
            <td class="auto-style25"></td>
            <td class="auto-style25"></td>
            <td class="auto-style25"></td>
        </tr>
        <tr>
            <td class="auto-style21"></td>
            <td class="auto-style22"></td>
            <td class="auto-style21">
                <asp:TextBox ID="HW19" runat="server" Width="30px" ReadOnly="True" Visible="False">0.17</asp:TextBox>
                <asp:TextBox ID="HX19" runat="server" Width="30px" ReadOnly="True" Visible="False">0.36</asp:TextBox>
                <asp:TextBox ID="HL19" runat="server" Width="30px" ReadOnly="True" Visible="False">0.47</asp:TextBox>
            </td>
            <td class="auto-style21">
                <asp:TextBox ID="AW19" runat="server" Width="30px" ReadOnly="True" Visible="False">0.18</asp:TextBox>
                <asp:TextBox ID="AX19" runat="server" Width="30px" ReadOnly="True" Visible="False">0.22</asp:TextBox>
                <asp:TextBox ID="AL19" runat="server" Width="30px" ReadOnly="True" Visible="False">0.60</asp:TextBox>
            </td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
        </tr>
        <tr>
            <td class="auto-style23"></td>
            <td class="auto-style24"></td>
            <td class="auto-style23">
                <asp:TextBox ID="HW20" runat="server" Width="30px" ReadOnly="True" Visible="False">0.13</asp:TextBox>
                <asp:TextBox ID="HX20" runat="server" Width="30px" ReadOnly="True" Visible="False">0.37</asp:TextBox>
                <asp:TextBox ID="HL20" runat="server" Width="30px" ReadOnly="True" Visible="False">0.49</asp:TextBox>
            </td>
            <td class="auto-style23">
                <asp:TextBox ID="AW20" runat="server" Width="30px" ReadOnly="True" Visible="False">0.16</asp:TextBox>
                <asp:TextBox ID="AX20" runat="server" Width="30px" ReadOnly="True" Visible="False">0.22</asp:TextBox>
                <asp:TextBox ID="AL20" runat="server" Width="30px" ReadOnly="True" Visible="False">0.62</asp:TextBox>
            </td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td class="auto-style23"></td>
            <td class="auto-style24"></td>
            <td class="auto-style23">
            </td>
            <td class="auto-style23">
            </td>
            <td class="auto-style23"></td>
            <td class="auto-style23">
            </td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
                <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="5">
                <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="148px" TextMode="MultiLine" Width="655px">Soccer tool</asp:TextBox>
                <br />
                <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="326px" TextMode="MultiLine" Width="655px" Visible="False">Dragi prijatelji, predstavljam vam još jedan koristan alat za izračunavanje koeficijenata u nogometu.
Potrebno je unijeti početne vrijednosti po formuli:
(Domaćin prosječno zabija) x (Gost prosječno prima) x (Prosjek lige zabijanja svih domaćina) za Domaćina, te
(Gost prosječno zabija) x (Domaćin prosječno prima) x (Prosijek lige zabijanja svih gostiju) za Goste.

To su očekivane vrijednosti po kojima kalkulator radi raspis vjerojatnosti (koristeći Poisson ili bivarijatni Poisson ovisno o tome jeste li ostavili vrijednost kovarijance nula ili ste unesli njenu vrijednost različitu od nule u rasponu od -1 do 1).

Nadalje, od vas se traži da unesete procjenu na kojem će mjestu na ljestvici lige sezonu završiti Domaćin i Gost.
Taj podatak nam koristi u metodi koja projicira vjerojatnosti, koristeći matricu čija projekcija rezultira onim brojem pobjeda/nerješenih/poraza, koja odgovara onom broju pobjeda/nerješenih/poraza koji su timovi u deset godišnjem prosijeku ostvarivali u engleskoj prvoj ligi (Premier League).
Naravno da je nezahvalno pretpostavljati na kojem će mjestu završiti ekipa, pa tako možete raspon unesti kao &quot;od 1. do 20. mjesta&quot;, naravno tada će minimalni i maksimalni koeficijenti biti &quot;široko&quot; postavljeni.

Ukoliko &quot;Poisson-ovi&quot; koeficijenti izlaze izvan granica &quot;Holo-metode&quot; trebamo biti vrlo oprezni jer je očito riječ o statističkom odstupanju.</asp:TextBox>
                </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21"></td>
            <td class="auto-style22"></td>
            <td class="auto-style21">
            </td>
            <td class="auto-style21">
            </td>
            <td class="auto-style21"></td>
            <td class="auto-style21">
            </td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
            <td class="auto-style21"></td>
        </tr>
    </table>
</asp:Content>
