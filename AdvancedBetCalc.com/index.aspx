<//%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="AdvancedBetCalc.com.Webform4" %>




<!doctype html>
<html>
    <head runat="server">
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <title>Fullscreen Video</title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="stylesheet" href="videobckgrndweb.css">
        <style type="text/css">


a:link, a:visited
{
    color: #034af3;
}

            .auto-style1 {
                width: 100%;
            }
            .auto-style2 {
                width: 170px;
                height: 36px;
            }
            .auto-style3 {
                height: 36px;
            }

            .auto-style4 {
                height: 100px;
            }

            .auto-style5 {
                height: 20px;
            }
            .auto-style6 {
                width: 170px;
                height: 20px;
            }
            .auto-style7 {
                height: 100px;
                text-align: center;
            }

            .auto-style8 {
                height: 100px;
                text-align: right;
            }

        </style>
    </head>
    <body>
        <div class="page">
        <form id="form1" runat="server">

    <div class="fullscreen-bg">
        <video loop muted autoplay poster="http://www.advancedbetcalc.com/download/bckgrnd227.jpg" class="fullscreen-bg__video">
            <source src="https://api.moremedia.tv/wp-content/uploads/2021/08/Home_Landingpage_video_MoreMedia.mp4" type="video/mp4">
        </video>
    </div>
                <table class="auto-style1" style="border-spacing: 0px;">
                    <tr>
                        <td class="auto-style5">
                        </td>
                        <td class="auto-style6"></td>
                        <td class="auto-style5">
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">
                            <asp:Image ID="Image1" runat="server" Height="16px" ImageUrl="~/Slike/Logosmall.gif" Width="16px" />
                            <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="6pt" ForeColor="White" Text="AdvancedBetCalc"></asp:Label>
                        </td>
                        <td class="auto-style2"></td>
                        <td class="auto-style3">
                <asp:Menu ID="Menu8" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" Font-Size="16pt" ForeColor="White" Orientation="Horizontal" DynamicHorizontalOffset="10">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/welcome.aspx" Text="Continue to main page" Value="Continue to main page"></asp:MenuItem>
                        <asp:MenuItem Text="Contact us" Value="Contact us" NavigateUrl="mailto:Contact@AdvancedBetCalc.com"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="Transparent" ForeColor="#0066FF" />
                    <StaticMenuItemStyle HorizontalPadding="100px" />
                    <StaticItemTemplate>
                        <%# Eval("Text") %>
                    </StaticItemTemplate>
            </asp:Menu>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                        </td>
                        <td class="auto-style8" colspan="2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    </tr>
                    <tr>
                        <td class="auto-style7" colspan="3">
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Names="Arial Narrow" Font-Size="50pt" ForeColor="White" Text="Welcome."></asp:Label>
&nbsp;
                            <br />
                            <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Names="Malgun Gothic Semilight" Font-Size="11pt" ForeColor="#CCCCFF" Text="&gt;&gt; It's  all  because  we  love  sports. &lt;&lt;"></asp:Label>
&nbsp;
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Names="Malgun Gothic Semilight" Font-Size="11pt" ForeColor="White" Text="mathematical approach to betting"></asp:Label>
&nbsp;&nbsp;
                        </td>
                    </tr>
            </table>
                </form>
            </div>
    </body>
</html>
