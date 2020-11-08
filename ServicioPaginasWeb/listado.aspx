<%@ Page Language="C#" AutoEventWireup="true" CodeFile="listado.aspx.cs" Inherits="listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/estilos-listado.css"/>
    <title>Sistema registro y visualización autobuses</title>
    <style type="text/css">
        #form1 {
            height: 843px;
        }
    </style>
</head>
<body style="height: 812px; width: 1049px;">

    <form id="form1" runat="server">

        <asp:Image ID="Image1" runat="server" Height="283px" ImageAlign="Middle" ImageUrl="imagen/sn.png" Width="1063px" />
      
            <asp:DropDownList class="drop1" ID="DropProvinicia" runat="server">
                <asp:ListItem>---</asp:ListItem>
                <asp:ListItem>San Jose</asp:ListItem>
                <asp:ListItem>Alajuela</asp:ListItem>
                <asp:ListItem>Cartago</asp:ListItem>
                <asp:ListItem>Limon</asp:ListItem>
                <asp:ListItem>Guanacaste</asp:ListItem>
                <asp:ListItem>Puntarenas</asp:ListItem>
                <asp:ListItem>Heredia</asp:ListItem>
            </asp:DropDownList>

        <asp:TextBox ID="mensaje" CssClass="drop4" runat="server" TextMode="MultiLine">Resultado de las operaiones...</asp:TextBox>

        <asp:Panel ID="Panel1" style="position:absolute; overflow: auto; top: 512px; left: 314px; height: 292px; width: 475px;" runat="server">
            
            <asp:GridView ID="TextMostrar"  style="position:absolute; top: 12px; left: 61px;" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </asp:Panel>
      

            <asp:Button class="drop2" ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />

            <asp:ImageButton class="img1" ID="ImageButton1" runat="server" ImageUrl="~/imagen/home.png" PostBackUrl="index.aspx"/>

    </form>
</body>
</html>