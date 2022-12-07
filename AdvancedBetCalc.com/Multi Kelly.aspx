<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Multi Kelly.aspx.vb" Inherits="AdvancedBetCalc.com.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style20 {
            height: 22px;
            width: 200px;
        }
        .auto-style23 {
            height: 19px;
            width: 200px;
        }
        .auto-style24 {
            width: 52px;
            height: 19px;
        }
        .auto-style25 {
            width: 920px;
        }
        .auto-style27 {
            width: 9px;
        }
        .auto-style30 {
            width: 10px;
            height: 19px;
        }
        .auto-style31 {
            width: 9px;
            height: 19px;
        }
        .auto-style32 {
            height: 22px;
            width: 10px;
        }
        .auto-style34 {
            height: 22px;
            width: 9px;
        }
        .auto-style36 {
            height: 22px;
            text-align: left;
        }
        .auto-style43 {
            width: 10px;
            height: 21px;
        }
        .auto-style44 {
            text-align: left;
            height: 21px;
        }
        .auto-style45 {
            width: 52px;
            height: 21px;
        }
        .auto-style46 {
            width: 9px;
            height: 21px;
        }
        .auto-style52 {
            width: 52px;
        }
        .auto-style56 {
            height: 22px;
            width: 52px;
        }
        .auto-style57 {
            height: 22px;
            text-align: left;
            width: 106px;
        }
        .auto-style59 {
            width: 200px;
        }
        .auto-style60 {
            height: 22px;
            text-align: left;
            width: 121px;
        }
        .auto-style61 {
            width: 10px;
            height: 18px;
        }
        .auto-style62 {
            width: 200px;
            height: 18px;
        }
        .auto-style63 {
            width: 52px;
            height: 18px;
        }
        .auto-style64 {
            width: 9px;
            height: 18px;
        }
        .auto-style65 {
            height: 22px;
            text-align: left;
            width: 142px;
        }
        .auto-style66 {
            width: 88px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table cellpadding="0" cellspacing="0" class="auto-style25">
        <tr>
            <td class="style48">&nbsp;</td>
            <td colspan="24">&nbsp;</td>
            <td class="auto-style52">&nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU1" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU1" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK1" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS1" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU1" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td colspan="24">
                <asp:Button ID="BtnCalculate" runat="server" Height="21px" Text="Calculate" Width="96px" BackColor="#0066FF" ForeColor="White" />
                <asp:Button ID="BtnInput" runat="server" BackColor="#009933" Height="21px" Text="Input" Width="96px" ForeColor="White" />
            </td>
            <td class="auto-style52">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="temporarP0a" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU2" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU2" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK2" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS2" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU2" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style43"></td>
            <td class="auto-style44" colspan="20" style="background-color: #CCCCCC">
                <asp:Label ID="Label25" runat="server" ForeColor="#CCCCCC" Text="_____"></asp:Label>
                <asp:TextBox ID="k2" runat="server" MaxLength="6" Width="49px" BackColor="#CCCCCC" BorderStyle="None" Font-Bold="True" ForeColor="Maroon" ReadOnly="True">Odds</asp:TextBox>
                <asp:TextBox ID="k3" runat="server" MaxLength="6" Width="61px" BackColor="#CCCCCC" BorderStyle="None" Font-Bold="True" ForeColor="#000066" ReadOnly="True">Chances</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="k4" runat="server" MaxLength="6" Width="61px" BackColor="#CCCCCC" BorderStyle="None" ForeColor="#6600CC" ReadOnly="True">Invest $</asp:TextBox>
                &nbsp;
                <asp:TextBox ID="k7" runat="server" MaxLength="6" Width="61px" BackColor="#CCCCCC" BorderStyle="None" ForeColor="#666633" ReadOnly="True">Kelly</asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="k6" runat="server" MaxLength="6" Width="120px" BackColor="#CCCCCC" BorderStyle="None" Font-Bold="True" ForeColor="#009900" ReadOnly="True">Optimum Invest $</asp:TextBox>
            </td>
            <td class="auto-style44" colspan="4">
            </td>
            <td class="auto-style45">
            </td>
            <td class="auto-style43"></td>
            <td class="auto-style46">
            </td>
            <td class="auto-style43"></td>
            <td class="auto-style46">
            </td>
            <td class="auto-style46">
            </td>
            <td class="auto-style43">
            </td>
            <td class="auto-style43">
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td class="style31" colspan="20" style="background-color: #CCCCCC">
                <asp:Label ID="Label24" runat="server" ForeColor="#CCCCCC" Text="_."></asp:Label>
&nbsp;&nbsp;
                <asp:TextBox ID="k1" runat="server" MaxLength="6" Width="68px" BackColor="#CCCCCC" BorderStyle="None" Font-Bold="True" ForeColor="#460000">2.0000</asp:TextBox>
                <asp:TextBox ID="s1" runat="server" MaxLength="6" Width="61px" BackColor="#CCCCCC" BorderStyle="None" Font-Bold="True" ForeColor="#00002B">0.5750</asp:TextBox>
                <asp:TextBox ID="u1" runat="server" MaxLength="6" Width="41px" BackColor="#CCCCCC" BorderStyle="None" ForeColor="#2B0055">0.0500</asp:TextBox>
                <asp:TextBox ID="k5" runat="server" MaxLength="6" Width="444px" BackColor="#CCCCCC" BorderStyle="None" ForeColor="#666666" ReadOnly="True">&lt;--- Input data and click green button. Click blue button when done inputting.</asp:TextBox>
            </td>
            <td class="style31" colspan="4">
                &nbsp;</td>
            <td class="auto-style52">
            &nbsp;&nbsp;
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU3" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU3" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK3" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS3" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU3" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td rowspan="8" colspan="16" style="background-color: #FFFFFF">
                <asp:TextBox ID="TboxKfc" runat="server" Height="150px" TextMode="MultiLine" Width="315px" BorderStyle="None" ReadOnly="True" Font-Names="Arial"></asp:TextBox>
                <asp:TextBox ID="OptimumU" runat="server" Height="150px" ReadOnly="True" TextMode="MultiLine" Width="81px" BorderStyle="None" Font-Names="Arial" ForeColor="#009900"></asp:TextBox>
            </td>
            <td rowspan="2" class="auto-style59" style="background-color: #FFFFFF" colspan="4">
                <asp:Label ID="LabelMaxB" runat="server" Text="  Max (optimal )  =" BackColor="White" Font-Names="Arial" Font-Size="9pt" ForeColor="#009900" ToolTip="Average gain if you use optimum invest"></asp:Label>
                <asp:Label ID="Label26" runat="server" ForeColor="White" Text=".."></asp:Label>
                <asp:Label ID="mKmaxBank" runat="server" Text="0.00" BackColor="White" Font-Names="Arial" Font-Size="9pt" ForeColor="#009900"></asp:Label>
                <br />
                <asp:Label ID="LabelMaxB0" runat="server" Text="  Max (manually)= " BackColor="White" Font-Names="Arial" Font-Size="9pt" ForeColor="#6600CC" ToolTip="Average gain if you use manually inputted invest"></asp:Label>
                <asp:Label ID="Label27" runat="server" ForeColor="White" Text="."></asp:Label>
                <asp:Label ID="MaxIputedB" runat="server" Text="0.00" BackColor="White" Font-Names="Arial" Font-Size="9pt" ForeColor="#6600CC"></asp:Label>
            </td>
            <td rowspan="8" colspan="4">
                &nbsp;</td>
            <td class="auto-style52">
                &nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU4" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU4" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK4" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS4" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU4" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td class="auto-style52">
                &nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU5" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU5" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK5" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS5" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU5" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style30"></td>
            <td class="auto-style23" style="background-color: #FFFFFF" colspan="4">
            </td>
            <td class="auto-style24">
                </td>
            <td class="auto-style30"></td>
            <td class="auto-style31">
                <asp:Label ID="pomocniU6" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style30"></td>
            <td class="auto-style31">
                <asp:Label ID="tempTextInputU6" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:Label ID="tempK6" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:Label ID="tempS6" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style30">
                <asp:Label ID="tempU6" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td class="auto-style59" style="background-color: #FFFFFF" colspan="4">
                &nbsp;</td>
            <td class="auto-style52">
                <asp:Label ID="tempRedBr" runat="server" Text="1" Visible="False"></asp:Label>
                &nbsp;<asp:Label ID="tempSumU" runat="server" Text="0" Visible="False"></asp:Label>
                &nbsp;<asp:Label ID="tempStepU" runat="server" Text="0.001" Visible="False"></asp:Label>
                &nbsp;<asp:Label ID="tempSumaOptiU" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU7" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU7" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK7" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS7" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU7" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32"></td>
            <td class="auto-style20" style="background-color: #FFFFFF" colspan="4">
            </td>
            <td class="auto-style56"></td>
            <td class="auto-style32"></td>
            <td class="auto-style34">
                <asp:Label ID="pomocniU8" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style32"></td>
            <td class="auto-style34">
                <asp:Label ID="tempTextInputU8" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style34">
                <asp:Label ID="tempK8" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style32">
                <asp:Label ID="tempS8" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style32">
                <asp:Label ID="tempU8" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td class="auto-style59" style="background-color: #FFFFFF" colspan="4">
                &nbsp;</td>
            <td class="auto-style52">
                <asp:Label ID="tempStpCntr" runat="server" Text="0" Visible="False"></asp:Label>
                &nbsp;
                <asp:Label ID="tempForProbaj" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU9" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU9" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK9" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS9" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU9" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td class="auto-style59" style="background-color: #FFFFFF" colspan="4">
                &nbsp;</td>
            <td class="auto-style52">
                <asp:Label ID="tempForProbaj0" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU10" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU10" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK10" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS10" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU10" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style61"></td>
            <td class="auto-style62" style="background-color: #FFFFFF" colspan="4">
            </td>
            <td class="auto-style63"></td>
            <td class="auto-style61"></td>
            <td class="auto-style64">
                <asp:Label ID="pomocniU11" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style61"></td>
            <td class="auto-style64">
                <asp:Label ID="tempTextInputU11" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style64">
                <asp:Label ID="tempK11" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style61">
                <asp:Label ID="tempS11" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style61">
                <asp:Label ID="tempU11" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style32"></td>
            <td class="auto-style60" style="background-color: #CCCCCC" colspan="4">
                &nbsp;</td>
            <td class="auto-style65" style="background-color: #CCCCCC" colspan="4">
                <asp:Label ID="Label28" runat="server" ForeColor="#2B0055" Text="Ʃ="></asp:Label>
                <asp:TextBox ID="SumInvest" runat="server" BorderStyle="None" ReadOnly="True" Width="80px" BackColor="#CCCCCC" CssClass="auto-style5" Font-Names="Arial" ForeColor="#2B0055">0.00</asp:TextBox>
                </td>
            <td class="auto-style57" style="background-color: #CCCCCC" colspan="2">
                <asp:Label ID="Label29" runat="server" ForeColor="#009900" Text="Ʃ="></asp:Label>
                <asp:TextBox ID="SumOpti" runat="server" BorderStyle="None" CssClass="auto-style5" ReadOnly="True" Width="80px" BackColor="#CCCCCC" Font-Names="Arial" ForeColor="#009900">0.00</asp:TextBox>
            </td>
            <td class="auto-style57" style="background-color: #CCCCCC" colspan="2">
                &nbsp;</td>
            <td class="auto-style36" colspan="8" style="background-color: #CCCCCC">
                &nbsp;</td>
            <td class="auto-style36" colspan="4">
                &nbsp;</td>
            <td class="auto-style56">
                <asp:Label ID="tempForProbaj1" runat="server" Text="0" Visible="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="temporStop" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style32"></td>
            <td class="auto-style34">
                <asp:Label ID="pomocniU12" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style32"></td>
            <td class="auto-style34">
                <asp:Label ID="tempTextInputU12" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style34">
                <asp:Label ID="tempK12" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style32">
                <asp:Label ID="tempS12" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style32">
                <asp:Label ID="tempU12" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td colspan="24">
                &nbsp;</td>
            <td class="auto-style52">
                <asp:Label ID="tempForProbaj2" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU13" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU13" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK13" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS13" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU13" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style66">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
                <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
            </td>
            <td>
                &nbsp;</td>
            <td colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td class="auto-style52">
                &nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                &nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                &nbsp;</td>
            <td class="auto-style27">
                &nbsp;</td>
            <td class="style48">
                &nbsp;</td>
            <td class="style48">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td colspan="24">
                <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="281px" TextMode="MultiLine" Width="647px">Multi Kelly calculator..
</asp:TextBox>
                <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="502px" TextMode="MultiLine" Width="647px" Visible="False">„Multi Kelly“

Iako ovaj termin povezujemo sa Kelly-jevom metodom izračunavanja optimalnih uloga istina je da Kelly nije nikada predstavio verziju za simultane uloge.

Dok konačna jednadžba predstavlja velik problem za današnja računala, aproksimacija (koju sam stvorio krajem 2015.g). nije prevelik zalogaj ni za starija računala (ukoliko ostajemo unutar „razumnog“ broja varijabli).

Taj broj sam u online izvedbi ograničio na 9, a u desktop verziji na 16.

Ovo je trenutno JEDINI ispravni kalkulator višestrukih simultanih optimalnih uloga koji možete pronaći na internetu (ili izvan njega..).
Na internetu smo nailazili na pokušaje za izradama istih, ali su svi testirani davali kriva rješenja (čak i kad govorimo o aproksimacijama).

U svakom slučaju, kada zatrebate izračun optimalnih uloga kod istovremenog klađenja (ili općenito ulaganja bilo koje vrste) a poznati su vam rizici i pripadajući im povrati (tj. šanse i koeficijenti) imate i ovaj kalkulator na raspolaganju.

Upute za korištenje:
Lijevo ispod „Calculate“ (plavog ) i „Input“ (zelenog) gumba unesete koeficijent (Odds), šanse (Chances) i neki vaš proizvoljni ulog (Invest$) koji je tu samo zato da vam dočara razliku između toga što bi bilo kad bi ulagali toliko i onoga kad bi ulagali optimalne iznose koje će vam nakon svih unosa kalkulator i izračunati. Kad ste unesli ta tri podatka - kliknite „Input“ (zeleni) gumb. Unos će se tada prikazati na popisu ispod (na bijelom polju kalkulatora). Sad možete ponoviti postupak. Nakon svih unosa kliknite „Calculate“ (plavi) gumb i nakon nekoliko sekundi izračun će biti prikazan desno (na bijelom polju kalkulatora) za svaki unos  u njegovom redu. „Isplativost“ tj. bazno uvećanje naše „Banke“ ispisano je zelenom bojom a ljubičastom bojom je ispisano uvećanje koje bi postigli da ste ulagali one iznose koje ste unesli pokraj svakog unešenog koeficijenta.
</asp:TextBox>
                </td>
            <td class="auto-style52">
                <asp:Label ID="tempForProbaj3" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU14" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU14" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK14" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS14" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU14" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td colspan="24">
                &nbsp;</td>
            <td class="auto-style52">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="temporP2" runat="server" Text="0" Visible="False"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="temporTempP" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU15" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU15" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK15" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS15" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU15" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td rowspan="3" colspan="24">
                &nbsp;</td>
            <td class="auto-style52">
                <asp:Label ID="temporarP0" runat="server" Text="0" Visible="False"></asp:Label>
            &nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="pomocniU16" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">
                <asp:Label ID="tempTextInputU16" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="auto-style27">
                <asp:Label ID="tempK16" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempS16" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">
                <asp:Label ID="tempU16" runat="server" BackColor="White" ForeColor="Black" Text="0" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td class="auto-style52">
                <asp:Label ID="temporarP1" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="style48">&nbsp;</td>
        </tr>
        <tr>
            <td class="style48">&nbsp;</td>
            <td class="auto-style52">
                <asp:Label ID="tempOpet" runat="server" Text="0" Visible="False"></asp:Label>
            </td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="auto-style27">&nbsp;</td>
            <td class="style48">&nbsp;</td>
            <td class="style48">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
