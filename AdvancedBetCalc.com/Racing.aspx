<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Racing.aspx.vb" Inherits="AdvancedBetCalc.com.HrcRc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .style1
        {
            width: 90%;
            height: 386px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <table style="border: 0px none #000000; padding: 0px; margin: 0px; border-spacing: 0px; width: 910px;">
        <tr>
            <td class="style35">
                &nbsp;</td>
            <td>
<table class="style1" 
                    style="border-style: none; border-width: 0px; padding: 0px; margin: 0px; border-spacing: 0px">
    <tr>
        <td width="12px" bgcolor="#666666">
            &nbsp;</td>
        <td width="65px" bgcolor="#666666">
            &nbsp;</td>
        <td width="80px" bgcolor="#666666">
            &nbsp;</td>
        <td width="80px" bgcolor="#666666">
            &nbsp;</td>
        <td width="80px" bgcolor="#666666">
            &nbsp;</td>
        <td width="80px" bgcolor="#666666">
            &nbsp;</td>
        <td width="80px" bgcolor="#666666">
            &nbsp;</td>
        <td width="100px" bgcolor="#666666">
            &nbsp;</td>
        <td bgcolor="#666666" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            &nbsp;</td>
        <td width="65px" bgcolor="Black">
            <asp:Button ID="Button1" runat="server" BackColor="#DDD200" Font-Size="Smaller" 
                ForeColor="Black" Height="21px" Text="Calculate" Width="52px" />
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="Place28" runat="server" ForeColor="#99CCFF">Win</asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="Place29" runat="server" ForeColor="#FF7777">Placed in 2</asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="Place30" runat="server" ForeColor="#99CCFF">Placed in 3</asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="Place61" runat="server" ForeColor="#FF7777">Placed in 4</asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="Place62" runat="server" ForeColor="#99CCFF">Placed in 5</asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            <asp:Label ID="Place63" runat="server" ForeColor="#FF7777">Forecast</asp:Label>
        </td>
        <td bgcolor="Black" class="style58">
            <asp:Label ID="Place64" runat="server" ForeColor="#99CCFF">Reverse Forecast</asp:Label>
        </td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place37" runat="server" ForeColor="#CCFFCC">1.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc1" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace1" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace1" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace1" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace1" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace1" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            <asp:Label ID="Place31" runat="server" ForeColor="#FF7777">1 - 2</asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="P1and2lace1" runat="server" ForeColor="#FFB0B0"></asp:Label>
        </td>
        <td bgcolor="Black" class="style58">
            <asp:Label ID="Place32" runat="server" ForeColor="#99CCFF">1-2 / 2-1</asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="P1and2or2and1lace01" runat="server" ForeColor="#C4E1FF"></asp:Label>
        </td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place38" runat="server" ForeColor="#CCFFCC">2.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc2" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace2" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace2" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace2" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace2" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace2" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            <asp:Label ID="Place36" runat="server" ForeColor="#FF7777">1 - 3</asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="P1and2lace3" runat="server" ForeColor="#FFB0B0"></asp:Label>
        </td>
        <td bgcolor="Black" class="style58">
            <asp:Label ID="Place34" runat="server" ForeColor="#99CCFF">1-3 / 3-1</asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="P1and2or2and1lace3" runat="server" ForeColor="#C4E1FF"></asp:Label>
        </td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place39" runat="server" ForeColor="#CCFFCC">3.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc3" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace3" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace3" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace3" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace3" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace3" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            <asp:Label ID="Place35" runat="server" ForeColor="#FF7777">2 - 3</asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="P1and2lace2" runat="server" ForeColor="#FFB0B0"></asp:Label>
        </td>
        <td bgcolor="Black" class="style58">
            <asp:Label ID="Place33" runat="server" ForeColor="#99CCFF">2-3 / 3-2</asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="P1and2or2and1lace2" runat="server" ForeColor="#C4E1FF"></asp:Label>
        </td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place40" runat="server" ForeColor="#CCFFCC">4.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc4" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace4" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace4" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace4" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace4" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace4" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place41" runat="server" ForeColor="#CCFFCC">5.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc5" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace5" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace5" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace5" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace5" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace5" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place42" runat="server" ForeColor="#CCFFCC">6.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc6" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace6" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace6" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace6" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace6" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace6" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place43" runat="server" ForeColor="#CCFFCC">7.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc7" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace7" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace7" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace7" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace7" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace7" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place44" runat="server" ForeColor="#CCFFCC">8.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc8" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace8" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace8" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace8" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace8" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace8" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place45" runat="server" ForeColor="#CCFFCC">9.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc9" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P01lace9" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2lace9" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3lace9" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2or3or4lace9" runat="server" ForeColor="#FF7777"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            <asp:Label ID="P1OR2OR3or4or5lace9" runat="server" ForeColor="#99CCFF"></asp:Label>
        </td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place46" runat="server" ForeColor="#CCFFCC">10.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc10" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td colspan="7" bgcolor="Black">
            <asp:Label ID="Labelconsolidate1" runat="server" 
                Text="Consolidation made from number 9 to number" Visible="False"></asp:Label>
            &nbsp;<asp:Label ID="Labelconsolidate2" runat="server" Text="22" Visible="False"></asp:Label>
            &nbsp;<asp:Label ID="Labelconsolidate3" runat="server" 
                Text="(all &quot;squeezed&quot; in number 9)." Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place47" runat="server" ForeColor="#CCFFCC">11.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc11" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place48" runat="server" ForeColor="#CCFFCC">12.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc12" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place49" runat="server" ForeColor="#CCFFCC">13.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc13" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place52" runat="server" ForeColor="#CCFFCC">14.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc14" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place51" runat="server" ForeColor="#CCFFCC">15.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc15" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place53" runat="server" ForeColor="#CCFFCC">16.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc16" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place54" runat="server" ForeColor="#CCFFCC">17.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc17" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place55" runat="server" ForeColor="#CCFFCC">18.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc18" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place56" runat="server" ForeColor="#CCFFCC">19.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc19" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place57" runat="server" ForeColor="#CCFFCC">20.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc20" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place58" runat="server" ForeColor="#CCFFCC">21.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc21" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            <asp:Label ID="Place59" runat="server" ForeColor="#CCFFCC">22.</asp:Label>
        </td>
        <td width="65px" bgcolor="Black">
            <asp:TextBox ID="Kfc22" runat="server" MaxLength="5" Width="32px"></asp:TextBox>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px" bgcolor="Black">
            &nbsp;</td>
        <td width="65px" bgcolor="Black">
            <asp:Label ID="Label1" runat="server" Text="-"></asp:Label>
        </td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="80px" bgcolor="Black">
            &nbsp;</td>
        <td width="100px" bgcolor="Black">
            &nbsp;</td>
        <td bgcolor="Black" class="style58">
            &nbsp;</td>
    </tr>
    <tr>
        <td width="12px">
            &nbsp;</td>
        <td width="65px">
            &nbsp;</td>
        <td width="80px">
            &nbsp;</td>
        <td width="80px">
            &nbsp;</td>
        <td width="80px">
            &nbsp;</td>
        <td width="80px">
            &nbsp;</td>
        <td width="80px">
            &nbsp;</td>
        <td width="100px">
            &nbsp;</td>
        <td class="style58">
            &nbsp;</td>
    </tr>
</table>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
