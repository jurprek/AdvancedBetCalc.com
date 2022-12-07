<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="TennisTool.aspx.vb" Inherits="AdvancedBetCalc.com.TennisTool" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style69
    {
        width: 170px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table class="style57">
            <tr>
                <td class="style69">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="Label24" runat="server" BackColor="#FF3300" ForeColor="White" 
                        Text="Available for desktop "></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style69">
                    &nbsp;</td>
                <td>
                    <asp:ImageButton ID="ImageButtonTTool" runat="server" Height="413px" 
                        ImageUrl="~/Slike/tennistool.JPG" Width="783px" 
                        ToolTip="Click to download desktop version." />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
