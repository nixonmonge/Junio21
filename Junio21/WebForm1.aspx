<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Junio21.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Paises.Nombre" HeaderText="Nombre Pais" />
                    <asp:BoundField DataField="Paises.Continentes.Nombre" HeaderText="Continentes" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
