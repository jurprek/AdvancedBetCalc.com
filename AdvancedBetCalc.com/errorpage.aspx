<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="errorpage.aspx.vb" Inherits="AdvancedBetCalc.com.errorpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style69
    {
        width: 200px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label24" runat="server" BackColor="Red" Font-Names="Arial" 
    Font-Size="14pt" ForeColor="White" 
    Text="Sorry, there has been an error (probably server timeout error)."></asp:Label>
<br />
            <asp:Image ID="ImageError" runat="server" Height="531px" 
    ImageUrl="~/Slike/BrokenGlass.png" Width="814px" />
        <br />
</asp:Content>
