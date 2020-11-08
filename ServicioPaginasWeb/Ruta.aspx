<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ruta.aspx.cs" Inherits="Ruta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="CSS/estilos-registroRuta.css"/>
    <title>Sistema registro y visualización autobuses</title>
    <style type="text/css">
        #form1 {
            height: 773px;
        }
    </style>
</head>
<body style="height: 759px">

    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" Height="283px" ImageAlign="Middle" ImageUrl="imagen/sn.png" Width="1063px" />
    
         
        <asp:Label class="label" ID="Label1" runat="server" BorderStyle="None" Height="30px" Text="Seleccione la provincia" Width="264px" style="margin-top: 22px; top: 325px; left: 15px;" ></asp:Label>
          
        <asp:DropDownList class="drop1"  ID="DropProvincia" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>San Jose</asp:ListItem>
            <asp:ListItem>Alajuela</asp:ListItem>
            <asp:ListItem>Heredia</asp:ListItem>
            <asp:ListItem>Cartago</asp:ListItem>
            <asp:ListItem>Limon</asp:ListItem>
            <asp:ListItem>Guanacaste</asp:ListItem>
            <asp:ListItem>Puntarenas</asp:ListItem>
        </asp:DropDownList>
          
        <asp:Label class="label2" ID="TextBox1" runat="server">Inicio de Ruta</asp:Label>
        <asp:Label class="label3" ID="TextBox2" runat="server">Fin de ruta </asp:Label>
        <asp:Label class="label4" ID="TextBox3" runat="server">¿Esta rural?</asp:Label>
        <asp:Label class="label6" ID="TextBox5" runat="server">Cantidad de kilometros de la ruta</asp:Label>
          
        <asp:DropDownList class="drop3" ID="DropRural" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList> 
          
        <asp:TextBox class="text3" ID="TextInicio" runat="server"></asp:TextBox>
          
        <asp:TextBox class="text1" ID="TextFin" runat="server"></asp:TextBox>
        <asp:TextBox class="text2" ID="TextKilometros" runat="server"></asp:TextBox>

       

        <asp:Button class="img1" ID="ButtonRegistra" runat="server" Text="Registrar" OnClick="ButtonRegistra_Click" />


        <asp:Panel ID="Panel1" CssClass="paneles" runat="server">
            <asp:GridView ID="TextMostrar" style="position:absolute; top: 6px; left: 26px;" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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


        <asp:ImageButton class="img2" ID="ImageButton1" runat="server" ImageUrl="~/imagen/home.png" PostBackUrl="index.aspx"/>

        <asp:Button ID="VerTodos" class="img3" runat="server" Text="Ver Todos" OnClick="VerTodos_Click" />

        <asp:TextBox CssClass="text5" ID="TextClave" runat="server" onclick="value=''" OnTextChanged="TextBuscar_TextChanged">Digite clave ruta...</asp:TextBox>

        <asp:Button ID="ButtonElimina" CssClass="Boton" runat="server" Text="Eliminar" OnClick="ButtonElimina_Click" />


        <asp:TextBox ID="ResultadoOperacion" CssClass="paneles1" ReadOnly="true" runat="server" TextMode="MultiLine">Aqui aparecera el resultado de las operaiones</asp:TextBox>


    </form>
</body>
</html>
