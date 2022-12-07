<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Smart Ticket.aspx.vb" Inherits="AdvancedBetCalc.com.SmartTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
    .style1
        {
            width: 47%;
        }
        
        .style4
        {
            width: 120px;
        }
        .style69
    {
        width: 30px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table class="style57" style="height: 697px">
    <tr>
        <td class="style69">
            &nbsp;</td>
        <td>
            <table align="center" cellpadding="0" cellspacing="0" class="style1" 
                style="font-size: small; font-family: Arial; color: #003366; background-color: #FFFFFF; border-style: none; height: 1px;">
                <tr>
                    <td align="center" class="style8" 
                        style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366">
                        &nbsp;&nbsp;</td>
                    <td align="center" class="style8" colspan="7" 
                        style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#CCCCCC" 
                            Text="To &quot;GO&quot; forward - pop-up in your browser must be allowed."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" 
                        style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366" 
                        width="25px">
                        &nbsp;</td>
                    <td align="center" 
                        style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366" 
                        width="25px">
                        <asp:Label ID="LabelOdds" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="White" Width="25px">odds</asp:Label>
                    </td>
                    <td align="center" bgcolor="#003366" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4" 
                        style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366">
                        <asp:Label ID="LabelsortedOdds" runat="server" Font-Bold="True" 
                            Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Width="120px">sorted odds</asp:Label>
                    </td>
                    <td align="center" 
                        style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366" 
                        width="75px">
                        <asp:Label ID="LbOddsTicket" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="White" Width="75px">Ticket No.</asp:Label>
                    </td>
                    <td style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366" 
                        width="25px">
                    </td>
                    <td align="left" 
                        style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366" 
                        width="25px">
                    </td>
                    <td style="font-family: Arial; font-size: small; font-weight: bold; color: #FFFFFF; background-color: #003366" 
                        width="10px">
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc1" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px">1.65</asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                        <asp:Button ID="group" runat="server" BackColor="#0033CC" Font-Bold="True" 
                            Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="20px" 
                            Text="smartGroup" Width="77px" />
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel1" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc1" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel21" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc21" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel41" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc41" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel61" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket1" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc61" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc2" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px">2.05</asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel2" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc2" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel22" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc22" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel42" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc42" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel62" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket2" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc62" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc3" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px">1.60</asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel3" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc3" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel23" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc23" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel43" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc43" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel63" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket3" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                style="margin-left: 0px" Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc63" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc4" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel4" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc4" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel24" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc24" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel44" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc44" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel64" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket4" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc64" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc5" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel5" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc5" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel25" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc25" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel45" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc45" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel65" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket5" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc65" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc6" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel6" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc6" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel26" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc26" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel46" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc46" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel66" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket6" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc66" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc7" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel7" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc7" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel27" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc27" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel47" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc47" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel67" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket7" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc67" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc8" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel8" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc8" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel28" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc28" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel48" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc48" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel68" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket8" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc68" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc9" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel9" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc9" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel29" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc29" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel49" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc49" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel69" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket9" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc69" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc10" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel10" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc10" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel30" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc30" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel50" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc50" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel70" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket10" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc70" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc11" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel11" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc11" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel31" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc31" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel51" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc51" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel71" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket11" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc71" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc12" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel12" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc12" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel32" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc32" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel52" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc52" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel72" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket12" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc72" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc13" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel13" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc13" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel33" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc33" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel53" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc53" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel73" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket13" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc73" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc14" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel14" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc14" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel34" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc34" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel54" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc54" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel74" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket14" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc74" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc15" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel15" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc15" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel35" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc35" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel55" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc55" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel75" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket15" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc75" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc16" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel16" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc16" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel36" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc36" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel56" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc56" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel76" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket16" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc76" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc17" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel17" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc17" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel37" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc37" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel57" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc57" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel77" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket17" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc77" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc18" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel18" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc18" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel38" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc38" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel58" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc58" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel78" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket18" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc78" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc19" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel19" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc19" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel39" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc39" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel59" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc59" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel79" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket19" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc79" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" width="25px">
                        &nbsp;</td>
                    <td align="center" width="25px">
                        <asp:TextBox ID="kfc20" runat="server" Font-Bold="True" Font-Names="Arial" 
                            Font-Size="Smaller" ForeColor="#003366" MaxLength="4" TabIndex="1" Width="25px"></asp:TextBox>
                    </td>
                    <td align="center" class="style35" width="77px">
                    </td>
                    <td align="center" class="style4">
                        <asp:Panel ID="Panel20" runat="server" BorderStyle="None" Height="20px" 
                            Width="120px">
                            <asp:Label ID="Labelkfc20" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="center" width="75px">
                        <asp:Panel ID="Panel40" runat="server" BorderStyle="None" Height="20px" 
                            Width="75px">
                            <asp:Label ID="Labelkfc40" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td width="25px">
                        <asp:Panel ID="Panel60" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Label ID="Labelkfc60" runat="server"></asp:Label>
                        </asp:Panel>
                    </td>
                    <td align="left" width="25px">
                        <asp:Panel ID="Panel80" runat="server" BorderStyle="None" Height="20px" 
                            Width="25px">
                            <asp:Button ID="Ticket20" runat="server" BackColor="#003366" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="Smaller" ForeColor="White" Height="18px" 
                                Text="GO" Visible="False" Width="25px" />
                        </asp:Panel>
                    </td>
                    <td width="10px">
                        <asp:Label ID="Labelkfc80" runat="server" ForeColor="White"></asp:Label>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
