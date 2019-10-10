<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_01_HolaMundoWeb.WebForms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hola Mundo
            <br />
            <asp:Label ID="lbNombre" runat="server">Escriba su nombre:</asp:Label>
            <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
            <asp:Button ID="btnEnviar" runat="server" Text="Saludar" OnClick="btnEnviar_Click"  />
            <br />
            <asp:Label  ID="lbMuestra" runat="server"></asp:Label>

            <p>
                Sexo<br />
                Hombre<asp:RadioButton ID="hombre" runat="server" /> <br />
                Mujer<asp:RadioButton ID="mujer" runat="server" /> <br />
                No Definido<asp:RadioButton ID="nodefinido" runat="server" />
          <%--      <input id="hombre" type="radio" name ="sexo" /> Hombre <br />  
                <input id="mujer" type="radio" value ="Mujer" name ="sexo" /> Mujer<br />
                <input id="nd" type="radio" value ="No Definido" name ="sexo" /> No Definido--%>
            </p>

            <p>
                Elija sus aficiones <br />
                Deportes <asp:CheckBox ID="deportes" runat="server" />
                TV <asp:CheckBox ID="tv" runat="server" />
                Tecnologia<asp:CheckBox ID="informatica" runat="server" />
                Moda<asp:CheckBox ID="moda" runat="server" />
                Corazon<asp:CheckBox ID="cotilleo" runat="server" />
                Ilegales<asp:CheckBox ID="drogas" runat="server" />
            </p>

            <asp:Button ID="submit" runat="server" Text="Enviar" OnClick="submit_Click"  />
        </div>
    </form>
</body>
</html>
