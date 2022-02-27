<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">   
        <asp:Label ID="Label1" runat="server" Text="Alumnos"></asp:Label>
        <asp:TextBox ID="aluNombre" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Nota"></asp:Label>
        <asp:TextBox ID="aluNota" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Lista"></asp:Label>
          <asp:Button ID="button1" runat="server" Text="Guardar" />
        <br />
        <br />
        <asp:TextBox ID="listaAlumnos" runat="server" Multiline="true" ReadOnly="true" Height="500" Width="1000px"></asp:TextBox>
        
    </form>
</body>
</html>
