<%@ Page Title="AdvancedBetCalc.com" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Systems Table.aspx.vb" Inherits="AdvancedBetCalc.com.Systems_Table" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">


        .style1
        {
            width: 100%;
        }
        .style80
    {
        width: 100px;
        text-align: right;
    }
    .style81
    {
        width: 50px;
    }
    .style85
    {
        width: 100px;
    }
        .style13
        {
            width: 0px;
        }
        .style8
        {
            width: 30px;
        }
        .style84
    {
        width: 640px;
    }
    .style87
    {
        width: 100px;
        height: 20px;
        text-align: right;
    }
    .style76
    {
        width: 50px;
        height: 20px;
    }
    .style77
    {
        height: 20px;
    }
        .style74
    {
        width: 30px;
        height: 20px;
    }
    .style88
    {
        width: 150px;
    }
        .auto-style1 {
            width: 103px;
        }
        .auto-style2 {
            width: 501px;
        }
        .auto-style3 {
            width: 20px;
        }
        .auto-style4 {
            width: 180px;
        }
        .auto-style5 {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <table class="style1">
            <tr>
                <td>
                    <asp:Button ID="ReClcBtn" runat="server" BackColor="Red" Font-Bold="True" 
                    ForeColor="White" Text="CLICK TO  C A L C U L A T E " Width="277px" />
                &nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" 
                    Text="Winnings per system (1$ total investment per system)&nbsp;"></asp:Label>
                &nbsp;
                    <asp:Button ID="AdvancedBtn" runat="server" BackColor="#336699" 
                    Font-Names="Arial" ForeColor="White" Text="Advanced" Visible="False" />
                    <br />
                    <table align="left" bgcolor="#FFFFF2" class="style1" 
                    style="border: thin solid #000080; color: #FFFFFF; font-size: small;">
                        <tr bgcolor="Blue">
                            <td bgcolor="#336699" class="style80">System&nbsp;<br />X out of:</td>
                            <td bgcolor="#336699" class="style81" style="color: #FFFFFF;">
                                <asp:TextBox ID="sysoutofY" runat="server" Font-Bold="True" Font-Size="Smaller" 
                                Height="16px" MaxLength="2" Width="44px"></asp:TextBox>
                            </td>
                            <td bgcolor="#336699" colspan="21" rowspan="3" 
                            style="padding: inherit; font-size: small; color: #FFFFFF; border-style: none; background-repeat: no-repeat; background-image: url('http://advancedbetcalc.com/tenisbannerhorisont1.JPG');">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SYSTEM&nbsp;&nbsp; X/<asp:Label 
                                ID="LabelY" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr bgcolor="White">
                            <td bgcolor="#336699" class="style80">Average<br />Chances (%):</td>
                            <td bgcolor="#336699" class="style81" style="color: #FFFFFF;">
                                <asp:TextBox ID="avrgsanse" runat="server" Font-Size="Smaller" Height="16px" 
                                MaxLength="5" Width="43px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#336699" class="style85" style="color: #FFFFFF;">Avrg.Coefficient:</td>
                            <td bgcolor="#336699" style="color: #FFFFFF; ">
                                <asp:TextBox ID="AvrgKfc" runat="server" Font-Size="Smaller" Height="16px" 
                                MaxLength="5" Width="43px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#003366" class="auto-style5" colspan="2" style="background-color: #790000">
                                number of combinations&nbsp;
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_1" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_2" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_3" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" class="style35" style="background-color: #9D0000">
                                <asp:Label ID="Cmbnt_4" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" class="style35" style="background-color: #9D0000">
                                <asp:Label ID="Cmbnt_5" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_6" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_7" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_8" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_9" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_10" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_11" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_12" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_13" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_14" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_15" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_16" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_17" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_18" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="background-color: #9D0000;" 
                            width="30">
                                <asp:Label ID="Cmbnt_19" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" class="style35" style="background-color: #9D0000">
                                <asp:Label ID="Cmbnt_20" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#000066" class="style13" rowspan="2">
                                <asp:Label ID="Advancedtxt" runat="server" Text="   Advanced   " 
                                Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#003366" class="style80">
                                <asp:Label ID="sumch" runat="server" ClientIDMode="AutoID" Font-Size="Small" 
                                Text="% to hit exactly.."></asp:Label>
                            </td>
                            <td align="center" bgcolor="#003366" class="style81" style="color: #FFFFFF;">number of hits</td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x1" runat="server" Text="01"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x2" runat="server" Text="02"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x3" runat="server" Text="03"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" class="style35">
                                <asp:Label ID="x4" runat="server" Text="04"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" class="style35">
                                <asp:Label ID="x5" runat="server" Text="05"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x6" runat="server" Text="06"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x7" runat="server" Text="07"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x8" runat="server" Text="08"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x9" runat="server" Text="09"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x10" runat="server" Text="10"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x11" runat="server" Text="11"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x12" runat="server" Text="12"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x13" runat="server" Text="13"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x14" runat="server" Text="14"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x15" runat="server" Text="15"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x16" runat="server" Text="16"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x17" runat="server" Text="17"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x18" runat="server" Text="18"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" style="color: #FFFFFF" 
                            width="30">
                                <asp:Label ID="x19" runat="server" Text="19"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#CC0000" class="style35">
                                <asp:Label ID="x20" runat="server" Text="20"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch0" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog0" runat="server" Text="00"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr0" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style84">
                                <asp:Label ID="Recomendedsys" runat="server" Font-Names="Arial" 
                                Font-Size="Small" ForeColor="#000066" Text="Recomended System :" 
                                Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch1" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog1" runat="server" Text="01"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr1" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style84">
                                <asp:Label ID="rcmdsys" runat="server" Font-Names="Arial" Font-Size="Small" 
                                ForeColor="Red" Visible="False"></asp:Label>
                                <asp:Label ID="recomendedsys2" runat="server" Font-Names="Arial" 
                                Font-Size="Small" ForeColor="Red" Text="/" Visible="False"></asp:Label>
                                <asp:Label ID="showy" runat="server" Font-Names="Arial" Font-Size="Small" 
                                ForeColor="Red" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch2" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog2" runat="server" Text="02"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr2" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style84">
                                <asp:Label ID="RecomendedU" runat="server" Font-Names="Arial" Font-Size="Small" 
                                ForeColor="#000066" Visible="False">Recomended Invest :</asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch3" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog3" runat="server" Text="03"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr3" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style84">
                                <asp:Label ID="rcmdinv" runat="server" Font-Names="Arial" Font-Size="Small" 
                                ForeColor="Red" Visible="False"></asp:Label>
                                <asp:Label ID="recomendedu2" runat="server" Font-Names="Arial" 
                                Font-Size="Small" ForeColor="#000066" Text="% of Your Bank" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch4" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog4" runat="server" Text="04"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr4" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style84">
                                <asp:Label ID="TMaxBnk1" runat="server" Font-Names="Arial" Font-Size="Small" 
                                ForeColor="#000066" Visible="False">Theoretical BankMax^1:</asp:Label>
                                <asp:Label ID="TmBnk1" runat="server" Font-Names="Arial" Font-Size="Small" 
                                ForeColor="#009933" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch5" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog5" runat="server" Text="05"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr5" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style14" rowspan="18">
                                <asp:Image ID="graf1bad" runat="server" ImageUrl="~/Slike/graf1bad.JPG" 
                                Visible="False" Width="200px" />
                                <asp:Image ID="graf1avrg" runat="server" ImageUrl="~/Slike/graf1avrg.JPG" 
                                Visible="False" Width="200px" />
                                <asp:Image ID="graf1extrem" runat="server" ImageUrl="~/Slike/graf1extrem.JPG" 
                                Visible="False" Width="200px" />
                                <asp:Image ID="graf2bad" runat="server" ImageAlign="Bottom" 
                                ImageUrl="~/Slike/graf2bad.JPG" Visible="False" Width="200px" />
                                <asp:Image ID="graf2avrg" runat="server" ImageUrl="~/Slike/graf2avrg.JPG" 
                                Visible="False" Width="200px" />
                                <asp:Image ID="graf2extrem" runat="server" ImageUrl="~/Slike/graf2extrem.JPG" 
                                Visible="False" Width="200px" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch6" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog6" runat="server" Text="06"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr6" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch7" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog7" runat="server" Text="07"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr7" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch8" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog8" runat="server" Text="08"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr8" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch9" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog9" runat="server" Text="09"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr9" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch10" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog10" runat="server" Text="10"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr10" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch11" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog11" runat="server" Text="11"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr11" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch12" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog12" runat="server" Text="12"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr12" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch13" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog13" runat="server" Text="13"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr13" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch14" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog14" runat="server" Text="14"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr14" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch15" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog15" runat="server" Text="15"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr15" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch16" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog16" runat="server" Text="16"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr16" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch17" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style81" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog17" runat="server" Text="17"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr17" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch18" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog18" runat="server" Text="18"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr18" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style80">
                                <asp:Label ID="ch19" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" 
                            style="color: #FFFFFF; ">
                                <asp:Label ID="pog19" runat="server" Text="19"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r1kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r2kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r3kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r6kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r7kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r8kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r9kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r10kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r11kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r12kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r13kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r14kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r15kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r16kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r17kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r18kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" style="font-size: x-small; color: #000099" width="30">
                                <asp:Label ID="r19kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style8" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr19" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#336699" class="style87">
                                <asp:Label ID="ch20" runat="server"></asp:Label>
                            </td>
                            <td align="center" bgcolor="#336699" class="style76" style="color: #FFFFFF;">
                                <asp:Label ID="pog20" runat="server" Text="20"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r1kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r2kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r3kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style74" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r4kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style74" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r5kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r6kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r7kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r8kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r9kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r10kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r11kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r12kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r13kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r14kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r15kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r16kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r17kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r18kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style77" style="font-size: x-small; color: #000099" 
                            width="30">
                                <asp:Label ID="r19kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                            <td align="center" class="style74" style="font-size: x-small; color: #000099">
                                <asp:Label ID="r20kr20" runat="server" Font-Size="XX-Small"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#24496F" class="style88" colspan="2">
                                <asp:Label ID="LabelMaxba" runat="server" Font-Size="Small" 
                                Text="MaxBank (after 1 round)" Visible="False"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa1" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa2" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa3" runat="server"></asp:Label>
                            </td>
                            <td align="center" class="style8" 
                            
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;">
                                <asp:Label ID="MaxBa4" runat="server"></asp:Label>
                            </td>
                            <td align="center" class="style8" 
                            
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;">
                                <asp:Label ID="MaxBa5" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa6" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa7" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa8" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa9" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa10" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa11" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa12" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa13" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa14" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa15" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa16" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa17" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa18" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="MaxBa19" runat="server"></asp:Label>
                            </td>
                            <td align="center" class="style8" 
                            
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;">
                                <asp:Label ID="MaxBa20" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" bgcolor="#24496F" class="style88" colspan="2">
                                <asp:Label ID="LabelInvBnk" runat="server" Font-Size="Small" 
                                Text="Invest part of Bank to achive Max" Visible="False"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog1" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog2" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog3" runat="server"></asp:Label>
                            </td>
                            <td align="center" class="style8" 
                            
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;">
                                <asp:Label ID="BestUlog4" runat="server"></asp:Label>
                            </td>
                            <td align="center" class="style8" 
                            
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;">
                                <asp:Label ID="BestUlog5" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog6" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog7" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog8" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog9" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog10" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog11" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog12" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog13" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog14" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog15" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog16" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog17" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog18" runat="server"></asp:Label>
                            </td>
                            <td align="center" 
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;" 
                            width="30">
                                <asp:Label ID="BestUlog19" runat="server"></asp:Label>
                            </td>
                            <td align="center" class="style8" 
                            
                            style="font-size: small; color: #000091; background-color: #FFFF99; font-family: Arial;">
                                <asp:Label ID="BestUlog20" runat="server" Font-Bold="False"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </p>
    <p>
        &nbsp;</p>
    <table class="style1">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:ImageButton ID="ImageButtonUK" runat="server" Height="35px" ImageUrl="~/Styles/uk-round-flag-3d.png" ToolTip="Help text in English..." Width="35px" />
            </td>
            <td>
                <asp:ImageButton ID="ImageButtonHR" runat="server" Height="32px" ImageUrl="~/Styles/hr.png" ToolTip="Help text na hrvatskom..." Width="32px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td colspan="15">
                <asp:TextBox ID="TextBoxHelpHR" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="437px" TextMode="MultiLine" Width="856px" Visible="False">Služi za usporedbu sistemskih listića, tj. traženje onog najboljeg za odigrati.

U „System X out of:“ unesite broj parova na listiću, 
u „Average chances(%):“ unesite svoj postotak pogađanja jednog takvog događaja,
a u „Avrg.coefficient:“ prosječni koeficijent sa listića.

(Nije dobro u sistemu igrati prerazličite koeficijente tj. kombinirati jako velike s jako malima, jer tada podatak o prosjeku ne vrijedi previše.)
  
Klikom na „Calculate“ kalkulator izlistava sisteme u stupcima od „1 od X“ pa sve do „X od X“ (za max.X=20). Tako je moguće vidjeti sve moguće dobitke za svaki od sistema i prema broju očekivanih pogodaka na listiću odabrati najbolji sistem tj. onaj u kojemu je za taj neki broj pogodaka dobitak najveći.  Izračun je iskazan za $1.00 uplatu, pa samo trebate pomnožiti sa svojom ukupnom uplatom i eventualnim koeficijentom fikseva da bi dobili vaš konkretan listić.

Klikom na „Advanced“ kalkulator vam pokazuje koji je to optimalni sistem za vas (naravno, ako su podaci koje ste unijeli ispravni). Iznos pod „MaxBank(after 1 round)“  vam pokazuje kolika je baza koju trebate potencirati na broj igranja takvih listića da bi vidjeli očekivani iznos zarade. 
Npr. ako vam pokazuje bazu od 1.05 tada bi nakon 10 takvih listića imali 1.05^10=1.63, dakle vaša bi se početna banka uvećala za 63%. Također, pokazuje vam pri kojem je ulogu „Invest part of the bank to achive max“ postignut taj dugoročni maksimum, jer promjenom bilo kojeg faktora mijenja se, naravno, cijeli izračunati iznos.
</asp:TextBox>
                <asp:TextBox ID="TextBoxHelpUK" runat="server" BackColor="Transparent" BorderStyle="None" Font-Names="Arial" ForeColor="White" Height="437px" TextMode="MultiLine" Width="856px">Systems table:

Its purpose is to show system tickets side by side for easier comparison.

In „System X out of:“ input number of games on a ticket,
in „Average chances(%):“ input your percentage of guessing of that exact odds (average),
and in „Average.coefficient:“ input the average odds from a ticket.

(don&#39;t combine too big with too small odds because that way average does not mean much)

By clicking on &quot;Calculate&quot; calculator lists all systems side by side in vertical columns.

This way you can see where the biggest winning lies for some exact number of good picks. Probability for guessing some number of picks is shown left under &quot;%to hit exactly&quot;, so you can get better grasp on what is to be expected.

By clicking on &quot;Advanced&quot; button on the bottom of the table you can see two more rows showed up. &quot;MaxBank&quot; tells us what moneyback can we expect in a long term. It is written in a base of an exponent format, meaning that if you want to know how much you will have after 20 same tickets played - you should use that number as a base, and 20 as an exponent, and multiply with starting capital. The calculation is done for the optimum invest ammount, shown in last row.

E.g. if it sais 1.055 &amp; 0.35 that means that you should invest 35% of capital on this system ticket, and after 20 tickets you should expect to have starting capital multiplied with (1.055^20)= 2.92, so 2.92 times more...

This calculus has great variance for &quot;small&quot; sample, but having this tool is beyond valuabe for every serious bettor. Hopefully you&#39;ll see why.

</asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>
