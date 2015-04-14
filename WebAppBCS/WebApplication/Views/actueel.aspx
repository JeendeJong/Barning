<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actueel.aspx.cs" Inherits="WebApplication.Views.actueel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Actueel</title>
    </head>
    <body>
        <div style="height: 550px; border-color: #0033CC; background-color: #C0C0C0; top: 15px; left: 10px; position: absolute; width: 1000px;">
            <asp:Label ID="Label1" runat="server" Text="Actief"             style="position:absolute; top:60px; width:110px;  left: 100px;"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Gesloten"           style="position:absolute; top:60px; width:110px;  left: 220px;"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="SMS"                style="position:absolute; top:60px; width:30px;  left: 340px;"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Oproepfunctie"      style="position:absolute; top:60px; width:200px; left: 383px;"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Pers."              style="position:absolute; top:60px; width:35px;  left: 580px;"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Oproepfunctie naam" style="position:absolute; top:60px; width:230px; left: 620px;"></asp:Label>

            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 100px; top: 90px; position: absolute; width: 115px">11-2-2015 19:00:57</asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 220px; top: 90px; position: absolute; width: 115px">14-2-2015 10:01:02</asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 340px; top: 90px; position: absolute; width: 38px">7227</asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 383px; top: 90px; position: absolute; width: 198px">TCO BRW Haaglanden</asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 580px; top: 90px; position: absolute; width: 35px">waar</asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 620px; top: 90px; position: absolute; width: 270px">Oproep voor TCO BRW Haaglanden via P2000</asp:TextBox>

            <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 100px; top: 110px; position: absolute; width: 115px"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server" style="z-index: 1; left: 220px; top: 110px; position: absolute; width: 115px"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" style="z-index: 1; left: 340px; top: 110px; position: absolute; width: 38px"></asp:TextBox>
            <asp:TextBox ID="TextBox10" runat="server" style="z-index: 1; left: 383px; top: 110px; position: absolute; width: 198px"></asp:TextBox>
            <asp:TextBox ID="TextBox11" runat="server" style="z-index: 1; left: 580px; top: 110px; position: absolute; width: 35px"></asp:TextBox>
            <asp:TextBox ID="TextBox12" runat="server" style="z-index: 1; left: 620px; top: 110px; position: absolute; width: 270px"></asp:TextBox>

            <asp:TextBox ID="TextBox13" runat="server" style="z-index: 1; left: 100px; top: 130px; position: absolute; width: 115px"></asp:TextBox>
            <asp:TextBox ID="TextBox14" runat="server" style="z-index: 1; left: 220px; top: 130px; position: absolute; width: 115px"></asp:TextBox>
            <asp:TextBox ID="TextBox15" runat="server" style="z-index: 1; left: 340px; top: 130px; position: absolute; width: 38px"></asp:TextBox>
            <asp:TextBox ID="TextBox16" runat="server" style="z-index: 1; left: 383px; top: 130px; position: absolute; width: 198px"></asp:TextBox>
            <asp:TextBox ID="TextBox17" runat="server" style="z-index: 1; left: 580px; top: 130px; position: absolute; width: 35px"></asp:TextBox>
            <asp:TextBox ID="TextBox18" runat="server" style="z-index: 1; left: 620px; top: 130px; position: absolute; width: 270px"></asp:TextBox>

            <asp:TextBox ID="TextBox19" runat="server" style="z-index: 1; left: 100px; top: 150px; position: absolute; width: 115px"></asp:TextBox>
            <asp:TextBox ID="TextBox20" runat="server" style="z-index: 1; left: 220px; top: 150px; position: absolute; width: 115px"></asp:TextBox>
            <asp:TextBox ID="TextBox21" runat="server" style="z-index: 1; left: 340px; top: 150px; position: absolute; width: 38px"></asp:TextBox>
            <asp:TextBox ID="TextBox22" runat="server" style="z-index: 1; left: 383px; top: 150px; position: absolute; width: 198px"></asp:TextBox>
            <asp:TextBox ID="TextBox23" runat="server" style="z-index: 1; left: 580px; top: 150px; position: absolute; width: 35px"></asp:TextBox>
            <asp:TextBox ID="TextBox24" runat="server" style="z-index: 1; left: 620px; top: 150px; position: absolute; width: 270px"></asp:TextBox>

            <asp:TextBox ID="TextBox25" runat="server" style="z-index: 1; left: 100px; top: 170px; position: absolute; width: 115px"></asp:TextBox>
            <asp:TextBox ID="TextBox26" runat="server" style="z-index: 1; left: 220px; top: 170px; position: absolute; width: 115px"></asp:TextBox>
            <asp:TextBox ID="TextBox27" runat="server" style="z-index: 1; left: 340px; top: 170px; position: absolute; width: 38px"></asp:TextBox>
            <asp:TextBox ID="TextBox28" runat="server" style="z-index: 1; left: 383px; top: 170px; position: absolute; width: 198px"></asp:TextBox>
            <asp:TextBox ID="TextBox29" runat="server" style="z-index: 1; left: 580px; top: 170px; position: absolute; width: 35px"></asp:TextBox>
            <asp:TextBox ID="TextBox30" runat="server" style="z-index: 1; left: 620px; top: 170px; position: absolute; width: 270px"></asp:TextBox>











        </div>
    </body>
</html>
