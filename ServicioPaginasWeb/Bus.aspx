<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Bus.aspx.cs" Inherits="Bus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <link rel="stylesheet" href="CSS/estilos-registroBus.css"/>
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
         
    
        <asp:Label class="label" ID="Label1" runat="server" BorderStyle="None" Height="30px" Text="Seleccione la provincia" Width="264px" style="margin-top: 22px; top: 331px; left: 13px;" ></asp:Label>
          
        <asp:Label class="label2" ID="TextBox1" runat="server">Ruta de pertenencia</asp:Label>
        <asp:Label class="label5" ID="TextBox4" runat="server">Cantidad pasajeros pie</asp:Label>
          
        <asp:DropDownList class="drop2" ID="DropInscrito" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList>

        
        <asp:DropDownList class="drop3" ID="DropAutorizado" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:DropDownList> 
          
        <asp:TextBox class="text3" ID="TextRuta" runat="server"></asp:TextBox>
          
        <asp:TextBox class="text1" ID="TextPaPie" runat="server"></asp:TextBox>
        <asp:TextBox class="text2" ID="TextPaSentados" runat="server"></asp:TextBox>

        
        <asp:ImageButton class="img2" ID="ImageButton1" runat="server" href="index.aspx" ImageUrl="imagen/home.png" PostBackUrl="index.aspx"/>
    

        <asp:Button CssClass="img5" ID="VerTodos" runat="server" Text="Ver Todos" OnClick="VerTodos_Click" />

        <asp:Button class="img3" ID="Editar" runat="server" OnClick="Button1_Click" Text="2-EditarBus" />


        <asp:Label class="label3" ID="TextBox2" runat="server">¿Esta inscrito?</asp:Label>
        <asp:Label class="label6" ID="TextBox5" runat="server">Cantidad pasajeros sentados</asp:Label>
          
        <asp:Label class="label4" ID="TextBox3" runat="server">¿Esta autorizado?</asp:Label>
    
        <asp:Panel ID="Panel1" runat="server" style="overflow:auto; position: absolute; top: 353px; left: 292px; height: 320px; width: 500px;">

        <asp:GridView class="text4" ID="TextMostrar" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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
    

        <asp:DropDownList class="drop1" ID="DropProvincia" runat="server">
            <asp:ListItem>---</asp:ListItem>
            <asp:ListItem>San Jose</asp:ListItem>
            <asp:ListItem>Heredia</asp:ListItem>
            <asp:ListItem>Cartago</asp:ListItem>
            <asp:ListItem>Limon</asp:ListItem>
            <asp:ListItem>Guanacaste</asp:ListItem>
            <asp:ListItem>Puntarenas</asp:ListItem>
            <asp:ListItem>Alajuela</asp:ListItem>
        </asp:DropDownList>

    

        <asp:TextBox class="text5" ID="TextClave" value="Digite clave bus..." runat="server" onclick="value=''"> </asp:TextBox>
    

        <asp:Button CssClass="img4" ID="Button1" runat="server" Text="1-BuscarBus" OnClick="Button1_Click1" />

    
        <asp:Button class="img1" ID="ButtonRegista" runat="server" Text="Agregar" OnClick="ButtonRegista_Click" />

    
        <asp:TextBox class="text6" ID="ResultadoOperacion" ReadOnly="true" runat="server" TextMode="MultiLine">Resultado operacion</asp:TextBox>

    
    </form> 
</body>
</html>
