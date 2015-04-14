<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="piketfunctionaris.aspx.cs" Inherits="WebApplication.Views.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>P2000</title>
    </head>
    <body>
        <form id="form1" runat="server">
        <div style="height: 550px; border-color: #0033CC; background-color: #CCCCCC; width: 770px;">
            <asp:Label ID="Label1" runat="server" Text="Regiovermelding" style="position:absolute; top:40px; width:110px;  left: 40px; font-style: italic;"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Naam"    style="position:absolute; top:40px; width:105px;  left: 650px; font-style: italic;"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Functie" style="position:absolute; top:60px; width:112px;  left: 650px; font-style: italic;"></asp:Label>

            <asp:Button ID="Button6" runat="server" Style="top: 275px; left: 250px; position: absolute; height: 120px; width: 120px" Text="Klant" BackColor="#FFFFCC" Font-Bold="True" OnClick="Button6_Click"  />
            <asp:Button ID="Button7" runat="server" Style="top: 275px; left: 375px; position: absolute; height: 120px; width: 120px" Text="Capcodes" BackColor="#FFFFCC" Font-Bold="True"  />
            <asp:Button ID="Button8" runat="server" Style="top: 275px; left: 500px; position: absolute; height: 120px; width: 120px" Text="Oproepfuncties" BackColor="#FFFFCC" Font-Bold="True"  />

                    <asp:Label ID="Label4" runat="server" Text="version build" style="position:absolute; top:500px; width:112px;  left: 650px; font-style: italic;"></asp:Label>
        </div>
        </form>
    </body>
</html>
