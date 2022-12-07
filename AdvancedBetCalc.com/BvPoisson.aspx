<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="BvPoisson.aspx.vb" Inherits="AdvancedBetCalc.com.BvPoisson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style72
    {
            width: 190px;
            text-align: right;
        }
    .style75
    {
        width: 125px;
        text-align: center;
    }
        .style79
        {
            width: 150px;
        }
        .style81
        {
            width: 190px;
            text-align: right;
            height: 1px;
        }
        .style84
        {
        }
        .style85
        {
            width: 51px;
            text-align: center;
            height: 1px;
        }
        .style86
        {
            width: 50px;
            text-align: center;
            height: 1px;
        }
        .style92
        {
            height: 1px;
            width: 10px;
        }
        .style94
        {
            width: 190px;
            text-align: right;
            height: 26px;
        }
        .style97
        {
            height: 26px;
        }
        .style99
        {
            width: 10px;
            height: 26px;
        }
        .style100
        {
            width: 51px;
            text-align: center;
            height: 26px;
        }
        .style101
        {
            width: 50px;
            text-align: center;
            height: 26px;
        }
        .style102
        {
            width: 150px;
            }
        .style103
        {
            width: 150px;
            height: 1px;
        }
        .style104
        {
            width: 190px;
        }
        .style105
        {
            width: 130px;
            text-align: right;
            height: 25px;
        }
        .style107
        {
            height: 25px;
        }
        .style109
        {
            width: 10px;
            height: 25px;
        }
        .style110
        {
            width: 51px;
            text-align: center;
            height: 25px;
        }
        .style111
        {
            width: 50px;
            text-align: center;
            height: 25px;
        }
        .style112
        {
            width: 190px;
            height: 26px;
        }
        .style113
        {
            width: 140px;
            text-align: left;
            height: 25px;
        }
        .style123
        {
            width: 150px;
            }
        .style124
        {
            width: 130px;
            text-align: right;
            height: 26px;
        }
        .style125
        {
            width: 140px;
            height: 26px;
        }
        .style126
        {
            width: 1px;
        }
        .style127
        {
            height: 1px;
            width: 190px;
        }
        .style129
        {
            width: 140px;
            text-align: left;
            height: 26px;
        }
        .style130
        {
            width: 140px;
            text-align: center;
        }
        .style131
        {
            width: 140px;
            text-align: center;
            height: 26px;
        }
        .style132
        {
            width: 140px;
            text-align: center;
            height: 1px;
        }
        .style133
        {
            height: 1px;
            width: 140px;
        }
        .style134
        {
            width: 140px;
            height: 25px;
        }
        .style135
        {
            width: 130px;
            text-align: center;
        }
        .style136
        {
            width: 130px;
            text-align: center;
            height: 26px;
        }
        .style137
        {
            width: 130px;
            text-align: center;
            height: 1px;
        }
        .style138
        {
            height: 1px;
            width: 130px;
        }
        .style139
        {
            width: 130px;
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <table style="padding: 0px; margin: 0px; border-style: none; border-spacing: 0px;" 
            border="0">
        <tr>
            <td class="style72" bgcolor="Black">
                &nbsp;</td>
            <td bgcolor="Black" class="style135">
                <asp:Label ID="Label27" runat="server" BorderColor="Yellow" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="White" 
                    Text="Avg. PointsScore" BackColor="Black"></asp:Label>
            </td>
            <td bgcolor="Black" class="style130">
                <asp:Label ID="Label28" runat="server" BorderColor="Yellow" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="White" 
                    Text="Avg. PointsReceive" BackColor="Black"></asp:Label>
            </td>
            <td bgcolor="Black">
                &nbsp;</td>
            <td bgcolor="Black" class="style126">
                &nbsp;</td>
            <td bgcolor="Black" class="style48">
                &nbsp;</td>
            <td bgcolor="Black">
                &nbsp;</td>
            <td bgcolor="Black" class="style75" colspan="3" width="150px">
                <asp:Label ID="Label38" runat="server" BackColor="Black" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="White" 
                    Text="POISSON VALUES"></asp:Label>
            </td>
            <td bgcolor="Black">
                &nbsp;</td>
            <td class="style79">
                &nbsp;</td>
        </tr>
        <tr>
            <td bgcolor="White" class="style94">
                &nbsp;<asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Text="Home team when home" 
                    BackColor="White"></asp:Label>
            </td>
            <td bgcolor="White" class="style136">
                <asp:TextBox ID="AVH1" runat="server" BackColor="GreenYellow" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Width="35px" BorderStyle="None">1.45</asp:TextBox>
            </td>
            <td bgcolor="White" class="style131">
                <asp:TextBox ID="AVH2" runat="server" BackColor="GreenYellow" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Width="35px" BorderStyle="None">0.65</asp:TextBox>
            </td>
            <td bgcolor="White" class="style97">
                </td>
            <td bgcolor="White" class="style126">
                </td>
            <td bgcolor="White" class="style99">
                </td>
            <td bgcolor="White" class="style97">
                <asp:TextBox ID="Home1" runat="server" BackColor="GreenYellow" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Visible="False" Width="35px"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style100">
                <asp:Label ID="Label39" runat="server" BackColor="GreenYellow" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="Home"></asp:Label>
            </td>
            <td class="style101" bgcolor="White">
                </td>
            <td bgcolor="White" class="style101">
                <asp:Label ID="Label40" runat="server" BackColor="DarkSeaGreen" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    Text="Away"></asp:Label>
            </td>
            <td bgcolor="White" class="style97">
                <asp:TextBox ID="Away1" runat="server" BackColor="DarkSeaGreen" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" style="text-align: center" Visible="False" Width="35px"></asp:TextBox>
            </td>
            <td class="style102" rowspan="13">
                <asp:TextBox ID="TextBoxMsg3" runat="server" BackColor="#003399" 
                    BorderStyle="None" Font-Names="Arial" Font-Size="8pt" ForeColor="White" 
                    Height="175px" ReadOnly="True" TextMode="MultiLine" 
                    Width="230px" Visible="False"> Always be aware :
 _________________
 if analysis looks &quot;strange&quot;, or outputs &quot;nonsense&quot;
 - skip that game because it is
 &quot;statistically worthless&quot;; on the other hand if
 everything &quot;sits in its place&quot; then that is real
 opportunity to look for value..

 in time you&#39;ll get feeling
 what&#39;s  - nonsense -  and 
 what&#39;s  - true value - ...</asp:TextBox>
                </td>
        </tr>
        <tr>
            <td bgcolor="Black" class="style81">
            </td>
            <td bgcolor="Black" class="style137">
            </td>
            <td bgcolor="Black" class="style132">
            </td>
            <td bgcolor="White" class="style84">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style92">
                </td>
            <td bgcolor="White" class="style84">
            </td>
            <td bgcolor="White" class="style85">
            </td>
            <td class="style86" bgcolor="White">
                </td>
            <td bgcolor="White" class="style86">
            </td>
            <td bgcolor="White" class="style84">
            </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style94">
                <asp:Label ID="Label25" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Text="Away team when away" 
                    BackColor="White"></asp:Label>
            </td>
            <td bgcolor="White" class="style136">
                <asp:TextBox ID="AVA1" runat="server" BackColor="DarkSeaGreen" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Width="35px" BorderStyle="None">1.10</asp:TextBox>
            </td>
            <td bgcolor="White" class="style131">
                <asp:TextBox ID="AVA2" runat="server" BackColor="DarkSeaGreen" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Width="35px" BorderStyle="None">1.15</asp:TextBox>
            </td>
            <td bgcolor="White" class="style97">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style99">
                </td>
            <td bgcolor="White" class="style97">
                </td>
            <td bgcolor="White" class="style100">
                <asp:TextBox ID="Home" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    ReadOnly="True" style="text-align: center" Width="45px" BorderStyle="None" 
                    ToolTip="HOME - Values combined from &quot;Avrg.scorings&quot; &amp; &quot;Last5enc.&quot;"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style101">
                <asp:Label ID="Label41" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="VS"></asp:Label>
            </td>
            <td bgcolor="White" class="style101">
                <asp:TextBox ID="Away" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    ReadOnly="True" style="text-align: center" Width="45px" BorderStyle="None" 
                    ToolTip="AWAY - Values combined from &quot;Avrg.scorings&quot; &amp; &quot;Last5enc.&quot;"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style97">
                </td>
        </tr>
        <tr>
            <td bgcolor="Black" class="style127">
            </td>
            <td bgcolor="Black" class="style138">
            </td>
            <td bgcolor="Black" class="style133">
            </td>
            <td bgcolor="White" class="style84">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style84">
                </td>
            <td bgcolor="White" class="style84">
                </td>
            <td bgcolor="White" class="style84">
            </td>
            <td bgcolor="White" class="style84">
            </td>
            <td bgcolor="White" class="style84">
            </td>
            <td bgcolor="White" class="style84">
                </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style94">
                <asp:Label ID="Label26" runat="server" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="10pt" ForeColor="Black" Text="League Avg. Home" 
                    BackColor="White"></asp:Label>
            </td>
            <td bgcolor="White" class="style136">
                <asp:TextBox ID="LA1" runat="server" BackColor="YellowGreen" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Width="35px" BorderStyle="None">1.25</asp:TextBox>
            </td>
            <td bgcolor="White" class="style131">
                <asp:TextBox ID="LA2" runat="server" BackColor="YellowGreen" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Width="35px" BorderStyle="None">0.90</asp:TextBox>
            </td>
            <td bgcolor="White" class="style97">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style99">
                </td>
            <td bgcolor="White" class="style97">
                </td>
            <td class="style100" bgcolor="White">
                </td>
            <td class="style101" bgcolor="White">
                <asp:Button ID="CalcPoisson" runat="server" BackColor="Yellow" 
                    Font-Names="Arial Narrow" Font-Size="8pt" Height="20px" Text="Calculate" 
                    Visible="False" Width="50px" />
                <asp:Button ID="RecalcPoisson" runat="server" BackColor="Gold" 
                    Font-Names="Arial Narrow" Font-Size="8pt" Height="20px" Text="Calculate" 
                    Visible="False" Width="50px" />
            </td>
            <td class="style101" bgcolor="White">
                </td>
            <td bgcolor="White" class="style97">
                </td>
        </tr>
        <tr>
            <td bgcolor="Black" class="style127">
            </td>
            <td bgcolor="Black" class="style138">
            </td>
            <td bgcolor="Black" class="style133">
            </td>
            <td bgcolor="White" class="style84">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style84">
                </td>
            <td bgcolor="White" class="style84" colspan="5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style104" bgcolor="White" style="text-align: right">
                <asp:Label ID="warning" runat="server" BackColor="Red" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="12pt" ForeColor="White" 
                    Text="Enter value  &gt;0,00  !!  " Visible="False"></asp:Label>
            </td>
            <td class="style105" bgcolor="White">
                </td>
            <td bgcolor="White" style="text-align: right">
                <asp:Button ID="Button52" runat="server" BackColor="Yellow" Height="20px" 
                    Text="Grab values" Width="82px" />
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style84" colspan="5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style104" bgcolor="White" rowspan="10">
                <asp:TextBox ID="TextBoxMsg2" runat="server" BackColor="White" 
                    BorderStyle="None" Font-Names="Arial" Font-Size="8pt" ForeColor="#666666" 
                    Height="250px" ReadOnly="True" TextMode="MultiLine" 
                    Width="190px">1. Insert average scorings of both
    teams and their league.

           - Click &quot;Grab values&quot; -


2. Insert &quot;Last 5 encounters&quot;
 (..last 2, last 3.., or leave empty)

               - Click &quot;Apply&quot; -


3. You can then change 
        number of points,
        &amp; handicap..

            - Click &quot;Calculate&quot; -</asp:TextBox>
            </td>
            <td class="style105" bgcolor="White">
                </td>
            <td class="style134" bgcolor="White">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style84" colspan="5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style105" bgcolor="White">
                <asp:TextBox ID="zajebDoMene" runat="server" BackColor="#999999" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Width="16px" Visible="False">0</asp:TextBox>
                <asp:TextBox ID="brojrclc" runat="server" BackColor="#999999" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Width="16px" Visible="False">0</asp:TextBox>
                </td>
            <td class="style134" bgcolor="White">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td class="style110" bgcolor="#FFECEC">
                </td>
            <td bgcolor="#FFECEC" class="style111">
                <asp:Label ID="Label42" runat="server" BackColor="#FFECEC" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="Match"></asp:Label>
            </td>
            <td class="style111" bgcolor="#FFECEC">
                </td>
            <td bgcolor="White" class="style107">
                </td>
        </tr>
        <tr>
            <td bgcolor="White" style="text-align: right" class="style139">
                <asp:Button ID="nullPoisson0" runat="server" BackColor="Gold" 
                    Font-Names="Arial Narrow" Font-Size="8pt" Height="20px" Text="null" 
                    Width="33px" 
                    ToolTip="sets covariance to &quot;0&quot; &amp; deletes last 5 results." />
            &nbsp;&nbsp;
                <asp:Label ID="Label29" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="Last 5 "></asp:Label>
            </td>
            <td bgcolor="White" class="style134">
                <asp:Label ID="Label31" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text=" encounters"></asp:Label>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="White" class="style110">
                <asp:Label ID="Label43" runat="server" BackColor="GreenYellow" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="1"></asp:Label>
            </td>
            <td bgcolor="White" class="style111">
                <asp:Label ID="Label44" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="X"></asp:Label>
            </td>
            <td bgcolor="White" class="style111">
                <asp:Label ID="Label45" runat="server" BackColor="DarkSeaGreen" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="2"></asp:Label>
            </td>
            <td bgcolor="White" class="style107">
                </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style124">
                <asp:TextBox ID="Poisson5LastX1" runat="server" BackColor="GreenYellow" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None">3</asp:TextBox>
            </td>
            <td bgcolor="White" class="style129">
                &nbsp;
                <asp:TextBox ID="Poisson5LastY1" runat="server" BackColor="DarkSeaGreen" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None">1</asp:TextBox>
            </td>
            <td bgcolor="White" class="style97">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style99">
                </td>
            <td bgcolor="White" class="style97">
                <asp:TextBox ID="suma1" runat="server" BackColor="#339966" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Visible="False" Width="35px"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style100">
                <asp:TextBox ID="TIP1" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    ReadOnly="True" style="text-align: center" Width="35px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style101">
                <asp:TextBox ID="TIPX" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    ReadOnly="True" style="text-align: center" Width="35px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style101">
                <asp:TextBox ID="TIP2" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    ReadOnly="True" style="text-align: center" Width="35px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style97">
                </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style124">
                <asp:TextBox ID="Poisson5LastX2" runat="server" BackColor="GreenYellow" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None">2</asp:TextBox>
            </td>
            <td bgcolor="White" class="style129">
                &nbsp;
                <asp:TextBox ID="Poisson5LastY2" runat="server" BackColor="DarkSeaGreen" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None">0</asp:TextBox>
            </td>
            <td bgcolor="White" class="style97">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style99">
                </td>
            <td bgcolor="White" class="style97">
                </td>
            <td class="style100" bgcolor="White">
                <asp:TextBox ID="expectPoeni1" runat="server" BackColor="#339966" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" style="text-align: center" Visible="False" Width="35px"></asp:TextBox>
            </td>
            <td class="style101" bgcolor="White">
                <asp:TextBox ID="sumaPoeni12" runat="server" BackColor="#339966" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" style="text-align: center" Visible="False" Width="35px"></asp:TextBox>
            </td>
            <td class="style101" bgcolor="White">
                <asp:TextBox ID="expectPoeni2" runat="server" BackColor="#339966" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" style="text-align: center" Visible="False" Width="35px"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style97">
                </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style105">
                <asp:TextBox ID="Poisson5LastX3" runat="server" BackColor="GreenYellow" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None">2</asp:TextBox>
            </td>
            <td bgcolor="White" class="style113">
                &nbsp;
                <asp:TextBox ID="Poisson5LastY3" runat="server" BackColor="DarkSeaGreen" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None">1</asp:TextBox>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td class="style110" bgcolor="White">
                </td>
            <td class="style111" bgcolor="White">
                </td>
            <td class="style111" bgcolor="White">
                </td>
            <td bgcolor="White" class="style107">
                </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style105">
                <asp:TextBox ID="Poisson5LastX4" runat="server" BackColor="GreenYellow" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style113">
                &nbsp;
                <asp:TextBox ID="Poisson5LastY4" runat="server" BackColor="DarkSeaGreen" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td class="style110" bgcolor="#CCFFCC">
                <asp:Label ID="Label47" runat="server" BackColor="#CCFFCC" Font-Bold="False" 
                    Font-Names="Arial" Font-Size="8pt" ForeColor="Black" Text="Points"></asp:Label>
            </td>
            <td bgcolor="#CCFFCC" class="style111">
                <asp:Label ID="Label52" runat="server" BackColor="#CCFFCC" Font-Bold="False" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="&lt; / &gt;"></asp:Label>
            </td>
            <td class="style111" bgcolor="#CCFFCC">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td class="style123" rowspan="4">
                <asp:TextBox ID="TextBoxMsg1" runat="server" BackColor="#003399" 
                    BorderStyle="None" Font-Names="Arial" Font-Size="8pt" ForeColor="White" 
                    Height="100px" ReadOnly="True" TextMode="MultiLine" Visible="False" 
                    Width="220px">  Server time is divided among many users. 
 
  Download 
  AdvancedBetCalc tool for desktop,

  - be the only user on your own computer
  - and speed up calc time..</asp:TextBox>
                </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style105">
                <asp:TextBox ID="Poisson5LastX5" runat="server" BackColor="GreenYellow" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style113">
                &nbsp;
                <asp:TextBox ID="Poisson5LastY5" runat="server" BackColor="DarkSeaGreen" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="3" style="text-align: center" Width="23px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="White" class="style110">
                <asp:Label ID="Label48" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="Under"></asp:Label>
            </td>
            <td bgcolor="White" class="style111">
                <asp:TextBox ID="upitBP" runat="server" BackColor="#CCFFCC" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="8pt" ForeColor="Black" MaxLength="4" 
                    style="text-align: center" Width="40px" BorderStyle="None">2.5</asp:TextBox>
            </td>
            <td bgcolor="White" class="style111">
                <asp:Label ID="Label49" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="Over"></asp:Label>
            </td>
            <td bgcolor="White" class="style107">
                </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style105">
                <asp:Label ID="PoissonCovar1" runat="server" BackColor="White" 
                    Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Gray" 
                    Text="Click on &quot;Apply&quot; " Visible="False" Font-Italic="True"></asp:Label>
            </td>
            <td bgcolor="White" class="style134">
                <asp:Label ID="PoissonCovar2" runat="server" BackColor="White" 
                    Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Gray" 
                    Text="to calculate" Visible="False" Font-Italic="True"></asp:Label>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="White" class="style110">
                <asp:TextBox ID="OdgovorBP1" runat="server" BackColor="White" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" ReadOnly="True" style="text-align: center" Width="35px" 
                    BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style111">
                <asp:TextBox ID="OdgovorBPX" runat="server" BackColor="White" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" ReadOnly="True" style="text-align: center" Width="35px" 
                    BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style111">
                <asp:TextBox ID="OdgovorBP2" runat="server" BackColor="White" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" ReadOnly="True" style="text-align: center" Width="35px" 
                    BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style107">
                </td>
        </tr>
        <tr>
            <td bgcolor="White" class="style105">
                <asp:Label ID="PoissonCovar3" runat="server" BackColor="White" 
                    Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Gray" 
                    Text="covariance and " Visible="False" Font-Italic="True"></asp:Label>
            </td>
            <td bgcolor="White" class="style134">
                <asp:Label ID="PoissonCovar4" runat="server" BackColor="White" 
                    Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Gray" 
                    Text="apply it to" Visible="False" Font-Italic="True"></asp:Label>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td class="style110" bgcolor="White">
                </td>
            <td class="style111" bgcolor="White">
                </td>
            <td class="style111" bgcolor="White">
                </td>
            <td bgcolor="White" class="style107">
                </td>
        </tr>
        <tr>
            <td class="style104" bgcolor="White">
                </td>
            <td bgcolor="White" class="style105">
                <asp:Label ID="PoissonCovar5" runat="server" BackColor="White" 
                    Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Gray" 
                    Text="the Poisson " Visible="False" Font-Italic="True"></asp:Label>
            </td>
            <td bgcolor="White" class="style134">
                <asp:Label ID="PoissonCovar6" runat="server" BackColor="White" 
                    Font-Bold="False" Font-Names="Arial" Font-Size="8pt" ForeColor="Gray" 
                    Text="Values" Visible="False" Font-Italic="True"></asp:Label>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="#CCFFFF" class="style110">
                <asp:Label ID="Label51" runat="server" BackColor="#CCFFFF" Font-Bold="False" 
                    Font-Names="Arial" Font-Size="8pt" ForeColor="Black" Text="Home"></asp:Label>
            </td>
            <td bgcolor="#CCFFFF" class="style111">
                <asp:Label ID="Label50" runat="server" BackColor="#CCFFFF" Font-Bold="False" 
                    Font-Names="Arial" Font-Size="8pt" ForeColor="Black" Text="handicap"></asp:Label>
            </td>
            <td bgcolor="#CCFFFF" class="style111">
                &nbsp;</td>
            <td bgcolor="White" class="style107">
                </td>
            <td class="style123">
                </td>
        </tr>
        <tr>
            <td class="style112" bgcolor="White">
                </td>
            <td class="style124" bgcolor="White">
                <asp:TextBox ID="BvPAvgPoenaX" runat="server" BackColor="GreenYellow" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" style="text-align: center" Visible="False" Width="20px"></asp:TextBox>
                <asp:TextBox ID="BvPAvgPoenaY" runat="server" BackColor="DarkSeaGreen" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" style="text-align: center" Visible="False" Width="20px"></asp:TextBox>
                <asp:TextBox ID="BvPSumDifXY" runat="server" BackColor="#999999" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="10pt" ForeColor="Black" 
                    MaxLength="5" style="text-align: center" Visible="False" Width="20px"></asp:TextBox>
                <asp:TextBox ID="BvPSumAvG" runat="server" BackColor="#999999" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    style="text-align: center" Visible="False" Width="20px"></asp:TextBox>
            </td>
            <td class="style125" bgcolor="White">
                <asp:Button ID="Button53Apply" runat="server" BackColor="Yellow" Height="20px" 
                    Text="Apply" Visible="False" Width="82px" />
            </td>
            <td bgcolor="White" class="style97">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style99">
                </td>
            <td bgcolor="White" class="style97">
                </td>
            <td bgcolor="White" class="style100">
                </td>
            <td bgcolor="White" class="style101">
                <asp:TextBox ID="Hndcp" runat="server" BackColor="#CCFFFF" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="8pt" ForeColor="Black" MaxLength="6" 
                    style="text-align: center" Width="40px" BorderStyle="None">- 0.5</asp:TextBox>
            </td>
            <td bgcolor="White" class="style101">
                </td>
            <td bgcolor="White" class="style97">
                </td>
            <td class="style102">
                </td>
        </tr>
        <tr>
            <td class="style104" bgcolor="White">
                </td>
            <td bgcolor="White" class="style105">
                <asp:Label ID="Label46" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" Text="Theta :"></asp:Label>
            </td>
            <td bgcolor="White" class="style134">
                <asp:TextBox ID="ThetaPoisson" runat="server" BackColor="White" 
                    Font-Bold="False" Font-Names="Arial" Font-Size="9pt" ForeColor="Black" 
                    MaxLength="5" style="text-align: center" Width="45px" BorderStyle="None">0</asp:TextBox>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="Black" class="style126">
                </td>
            <td bgcolor="White" class="style109">
                </td>
            <td bgcolor="White" class="style107">
                </td>
            <td bgcolor="White" class="style110">
                <asp:TextBox ID="Hndcp1" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    ReadOnly="True" style="text-align: center" Width="35px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style111">
                <asp:TextBox ID="HndcpX" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    ReadOnly="True" style="text-align: center" Width="35px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style111">
                <asp:TextBox ID="Hndcp2" runat="server" BackColor="White" Font-Bold="True" 
                    Font-Names="Arial" Font-Size="10pt" ForeColor="Black" MaxLength="5" 
                    ReadOnly="True" style="text-align: center" Width="35px" BorderStyle="None"></asp:TextBox>
            </td>
            <td bgcolor="White" class="style107">
                </td>
            <td class="style123">
                </td>
        </tr>
        <tr>
            <td class="style104">
                </td>
            <td class="style105">
                </td>
            <td class="style134">
                </td>
            <td class="style107">
                </td>
            <td class="style126">
                </td>
            <td class="style109">
                </td>
            <td class="style107">
                </td>
            <td class="style110">
                </td>
            <td class="style111">
                </td>
            <td class="style111">
                </td>
            <td class="style107">
                </td>
            <td class="style123">
                </td>
        </tr>
    </table>
</p>
</asp:Content>
