<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Win Calc.aspx.vb" Inherits="AdvancedBetCalc.com.SystemCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .style1
    {
        width: 100%;
        margin-left: 0px;
            height: 35px;
        }
        .style34
    {
            width: 60px;
        }
        .style28
    {
            width: 305px;
        }
        .style69
        {
            width: 170px;
        }
        .style70
        {
            width: 25px;
        }
        .style71
        {
            width: 50px;
        }
        .auto-style1 {
            width: 791px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 85%;
            margin-left: 0px;
            height: 35px;
        }
        .auto-style4 {
            width: 196px;
        }
        .auto-style5 {
            width: 107px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table class="style57">
            <tr>
                <td class="style69" rowspan="10">
                    &nbsp;</td>
                <td class="auto-style1" rowspan="10">
                    <table bgcolor="White" class="auto-style3" 
            style="border-style: none; font-size: small; ">
            <tr>
                <td align="center" bgcolor="Black" class="style27" colspan="2" 
                    style="border-style: none;">
                    <asp:DynamicHyperLink ID="DynamicHyperLink1" runat="server" ForeColor="White" 
                        NavigateUrl="http://www.youtube.com/watch?v=7IO99UGCPKc" 
                        ToolTip="Click to see instructions on youtube.com" Font-Underline="False">www.AdvancedBetCalc.com</asp:DynamicHyperLink>
                </td>
                <td align="center" bgcolor="Black" class="style25" colspan="2" 
                    style="border-style: none">
                    <asp:Label ID="Label14" runat="server" ForeColor="White" Text="(odds)"></asp:Label>
                </td>
                <td align="center" bgcolor="Black" class="style31" colspan="3" 
                    style="border-style: none">
                    <asp:Label ID="Label15" runat="server" Font-Names="Arial" Font-Size="Small" 
                        ForeColor="White" Text="Winnings for number of missed pairs"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="Black" class="style27" colspan="2" style="border-style: none;">
                    <asp:Label ID="Label2" runat="server" Font-Names="Arial" ForeColor="White" 
                        Text="System X/Y"></asp:Label>
                    &nbsp;&nbsp;
                </td>
                <td align="center" bgcolor="Black" class="style25" colspan="2" 
                    style="border-style: none">
                    <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Coeffic."></asp:Label>
                </td>
                <td align="center" bgcolor="Black" class="style34" style="border-style: none;">
                    <asp:Label ID="MINlabel" runat="server" Font-Names="Arial" ForeColor="White" 
                        Text="min" ToolTip="minimum that you will win if you miss some"></asp:Label>
                </td>
                <td align="center" bgcolor="Black" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="Black" class="style34" style="border-style: none;">
                    <asp:Label ID="MINlabel0" runat="server" Font-Names="Arial" ForeColor="White" 
                        Text="max" ToolTip="maximum that you will win if you miss some"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:TextBox ID="sysX" runat="server" Height="19px" MaxLength="2" TabIndex="1" 
                        ToolTip="X = number of pairs in group" Width="33px">01</asp:TextBox>
                    <asp:Label ID="Label3" runat="server" ForeColor="#000099" Height="16px" 
                        Text="   /" Width="8px"></asp:Label>
                    <asp:TextBox ID="sysY" runat="server" Height="19px" MaxLength="2" 
                        style="margin-top: 0px" TabIndex="2" ToolTip="Y = total number of pairs" 
                        Width="32px">02</asp:TextBox>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr1" runat="server" Font-Size="Smaller" ForeColor="#000099" 
                        Text=" 1."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K1" runat="server" MaxLength="5" TabIndex="4" Width="33px">2.05</asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m1" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min1" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066" ToolTip="minimum that you will win if miss just one"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max1" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099" ToolTip="maximum that you will win if miss just one"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;<asp:DropDownList ID="DDown1" runat="server" BackColor="Black" 
                        ForeColor="Lime" ToolTip="Choose odds format">
                        <asp:ListItem Selected="True" Value="1">Decimal</asp:ListItem>
                        <asp:ListItem Value="2">Fractions</asp:ListItem>
                        <asp:ListItem Value="3">American</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr2" runat="server" Font-Size="Smaller" ForeColor="#000099" 
                        Text=" 2."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K2" runat="server" MaxLength="5" TabIndex="5" Width="33px">1.92</asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m2" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min2" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066" ToolTip="minimum that you will win if miss two"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max2" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099" ToolTip="maximum that you will win if miss two"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Label ID="Label4" runat="server" ForeColor="#000099" Text="Invest : "></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Font-Size="Smaller" 
                        ForeColor="#000099" Height="16px" TabIndex="3" 
                        ToolTip="Total amount of money you are investing" Width="59px">100.00</asp:TextBox>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr3" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text=" 3."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K3" runat="server" MaxLength="5" TabIndex="6" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m3" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min3" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max3" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Button ID="ClcBtn" runat="server" BackColor="#314357" Font-Bold="True" 
                        ForeColor="White" Height="21px" TabIndex="24" Text="Calculate" Width="75px" />
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr4" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text=" 4."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K4" runat="server" MaxLength="5" TabIndex="7" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m4" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min4" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max4" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="PayOut :  " 
                        Visible="False"></asp:Label>
                    <asp:Label ID="suma" runat="server" ForeColor="Red" ToolTip="exact amount won"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr5" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text=" 5."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K5" runat="server" MaxLength="5" TabIndex="8" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m5" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min5" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max5" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right" bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Image ID="Imagearrow" runat="server" Height="16px" 
                        ImageUrl="~/Slike/arrowred.JPG" Visible="False" Width="55px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr6" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text=" 6."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K6" runat="server" MaxLength="5" TabIndex="9" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m6" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min6" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max6" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Label ID="Label7" runat="server" Font-Size="Small" ForeColor="#336699" 
                        Text="Avrg.Coeff.(hit odds) :" Visible="False"></asp:Label>
                    <asp:Label ID="Avrgkfc" runat="server" ForeColor="#000099"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr7" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text=" 7."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K7" runat="server" MaxLength="5" TabIndex="10" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m7" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min7" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max7" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Label ID="Label8" runat="server" Font-Size="Small" ForeColor="#336699" 
                        Text="Avrg.Chances ( % ):" Visible="False"></asp:Label>
                    <asp:Label ID="Avrgchances" runat="server" ForeColor="#000099"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr8" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text=" 8."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K8" runat="server" MaxLength="5" TabIndex="11" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m8" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min8" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max8" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Label ID="Label6" runat="server" Font-Size="Small" ForeColor="#336699" 
                        Text="Num.of Combinat.: " Visible="False"></asp:Label>
                    <asp:Label ID="brkomb" runat="server" ForeColor="#336699"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr9" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text=" 9."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K9" runat="server" MaxLength="5" TabIndex="12" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m9" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min9" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max9" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Label ID="Label9" runat="server" Font-Size="Small" ForeColor="#336699" 
                        Text="Hit:" Visible="False"></asp:Label>
                    <asp:Label ID="hit" runat="server" ForeColor="#008A45"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr10" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="10."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K10" runat="server" MaxLength="5" TabIndex="13" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m10" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min10" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max10" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    <asp:Label ID="Label10" runat="server" Font-Size="Small" ForeColor="#336699" 
                        Text="Missed: " Visible="False"></asp:Label>
                    <asp:Label ID="missed" runat="server" ForeColor="#9B0000"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr11" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="11."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K11" runat="server" MaxLength="5" TabIndex="14" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m11" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min11" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max11" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;</td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr12" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="12."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K12" runat="server" MaxLength="5" TabIndex="15" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m12" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min12" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max12" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;</td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr13" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="13."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K13" runat="server" MaxLength="5" TabIndex="16" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m13" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min13" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max13" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image1" runat="server" Height="17px" ImageUrl="~/Slike/warning.JPG" 
                        Visible="False" Width="19px" />
                    &nbsp;<asp:Label ID="Label11" runat="server" Font-Names="Arial" Font-Size="Smaller" 
                        ForeColor="Black" Text="WARNING !" Visible="False"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr14" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="14."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K14" runat="server" MaxLength="5" TabIndex="17" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m14" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min14" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max14" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label13" runat="server" Font-Names="Arial" Font-Size="Smaller" 
                        ForeColor="Black" Text="   By leaving this page" Visible="False"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr15" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="15."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K15" runat="server" MaxLength="5" TabIndex="18" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m15" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min15" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max15" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label12" runat="server" Font-Names="Arial" Font-Size="Smaller" 
                        ForeColor="Black" Text="ALL DATA WILL BE LOST !!!" Visible="False"></asp:Label>
                </td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr16" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="16."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K16" runat="server" MaxLength="5" TabIndex="19" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m16" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min16" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max16" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;</td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr17" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="17."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K17" runat="server" MaxLength="5" TabIndex="20" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m17" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min17" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max17" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;</td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr18" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="18."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K18" runat="server" MaxLength="5" TabIndex="21" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m18" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min18" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max18" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;</td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr19" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="19."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K19" runat="server" MaxLength="5" TabIndex="22" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m19" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min19" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max19" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
            <tr>
                <td bgcolor="White" class="style28" style="border-style: none;">
                    &nbsp;</td>
                <td align="right" bgcolor="White" class="style70" style="border-style: none">
                    <asp:Label ID="redbr20" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC" 
                        Text="20."></asp:Label>
                </td>
                <td bgcolor="White" class="style71" style="border-style: none">
                    <asp:TextBox ID="K20" runat="server" MaxLength="5" TabIndex="23" Width="33px"></asp:TextBox>
                </td>
                <td bgcolor="White" style="border-style: none">
                    <asp:Label ID="m20" runat="server" Font-Bold="True" Font-Size="Medium" 
                        ForeColor="#FF3300" Text="-" Visible="False"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="min20" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#660066"></asp:Label>
                </td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    &nbsp;</td>
                <td align="center" bgcolor="White" class="style34" style="border-style: none;">
                    <asp:Label ID="max20" runat="server" Font-Names="Arial" Font-Size="XX-Small" 
                        ForeColor="#000099"></asp:Label>
                </td>
            </tr>
        </table>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="auto-style4">
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
                <td class="style30" colspan="8">
                    <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" CssClass="auto-style2" Font-Names="Arial" ForeColor="White" Height="371px" TextMode="MultiLine" Width="405px">Win calculator:

Calculate winnings on a system ticket.

You can see how much will you win for every combination of win/lose on a system ticket.

If you have entered all the odds, calculator will show minimums and maximums for every combination of win/lose. They are shown under &quot;Winnings for number of missed pairs /min./max&quot;, number of row tells us how many missed games are o na ticket (and has nothing to do with odds from the same row).

If you already know what you have missed then just input zeros in their odds place (0.00), now &quot;-&quot; shows beside that games odds and exact winnings are shown under &quot;PayOut&quot;.
</asp:TextBox>
                    <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" CssClass="auto-style2" Font-Names="Arial" ForeColor="White" Height="371px" TextMode="MultiLine" Width="405px" Visible="False">Služi za provjeru dobitka na listiću.
Pomoću ovog kalkulatora možete vidjeti koliki će dobitak listića bit za neki broj pogodaka/promašaja.

Ako ste unesli sve koeficijente, sistem i ulog, tada vam kalkulator izračunava moguće „min.“ i „max.“ dobitke za određeni broj pogodaka/promašaja, tako što ih upisuje u stupce od jednog do onog koliko ste ih odigrali. Dakle, „min.“ i „max.“ u redu pojedinog koeficijenta nema veze s koeficijentom u tom retku, nego sa rednim brojem retka tj. ako promatramo redak br.2 tada se „min.“ i „max.“ odnose na dva promašaja. Znači, „min.“ je minimalni dobitak za dva promašaja (ako promašite najveća dva koeficijenta sa listića), a „max.“ je iznos dobitka koji dobijate za dva promašaja (ako promašite najmanja dva keficijenta na listicu).
Za promašene tipove upisujete koeficijent nula (0), a za odgođene ili poništene utakmice kfc. 1.00, pod „PayOut“ je ispisan točan iznos dobitka listića.
</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style30" colspan="8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style30" colspan="8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style30" colspan="8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style30" colspan="8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style30" colspan="8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style30" colspan="8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style30" colspan="8">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style30" colspan="8">
                    &nbsp;</td>
            </tr>
        </table>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</asp:Content>
