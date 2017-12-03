<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Planalto.aspx.cs" Inherits="Sonda.Planalto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #tudo {
	width: 800px;
	height: 210px;
}
#sonda1 {
	position:relative;
	width: 250px;
	height: 200px;
	float: left;
}
#sonda2 {
	position: relative;
	width: 250px;
	height: 200px;
	float: left;
}
#sonda3 {
	position: relative;
	width: 250px;
	height: 200px;
	float: left;
}
#tudo4 {
	position: relative;
	width: 200px;
	height: 200px;
	background-color: purple;
	float:left;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="PainelControles" runat="server" visible ="false">

                    <div id="tudo">
	<div id="sonda1" runat="server" visible ="false">
        <center><asp:Image ID="Image1" runat="server" Width="100px" ImageUrl="~/img/1.png" /></center>
	    <br />
        <asp:ImageButton ID="btn1esquerda" runat="server" ImageUrl="~/img/btn1esquerda.png" OnClick="btn1esquerda_Click" />
	    <asp:ImageButton ID="btn1Seguir" runat="server" ImageUrl="~/img/btn1seguir.png" OnClick="btn1Seguir_Click" />
        <asp:ImageButton ID="btn1direita" runat="server" ImageUrl="~/img/btn1direita.png" OnClick="btn1direita_Click" />
	    <br />
        <center><asp:ImageButton ID="btnCapturar1" runat="server" ImageUrl="~/img/btncapturar.png" OnClick="btnCapturar1_Click" /></center>
	</div>
    <div id="sonda2" runat="server" visible ="false">
        
                        <center><asp:Image ID="Image2" runat="server" ImageUrl="~/img/2.png" Width="100px" /></center>
                        <br />
                        <asp:ImageButton ID="btn2esquerda" runat="server" ImageUrl="~/img/btn2esquerda.png" OnClick="btn2esquerda_Click" />
                        <asp:ImageButton ID="btn2seguir" runat="server" ImageUrl="~/img/btn2seguir.png" OnClick="btn2seguir_Click" />
                        <asp:ImageButton ID="btn2direita" runat="server" ImageUrl="~/img/btn2direita.png" OnClick="btn2direita_Click" />
        
                        <center>
                            <asp:ImageButton ID="btnCapturar2" runat="server" ImageUrl="~/img/btncapturar.png" OnClick="btnCapturar2_Click" />
                        </center>
        
                        </div>
    <div id="sonda3" runat="server" visible ="false">
        <center><asp:Image ID="Image3" runat="server" ImageUrl="~/img/3.png" Width="100px" /></center>
                        <br />
                        <asp:ImageButton ID="btn3esquerda" runat="server" ImageUrl="~/img/btn3esquerda.png" OnClick="btn3esquerda_Click" />
                        <asp:ImageButton ID="btn3seguir" runat="server" ImageUrl="~/img/btn3seguir.png" OnClick="btn3seguir_Click" />
                        <asp:ImageButton ID="ImageButton9" runat="server" ImageUrl="~/img/btn3dieita.png" OnClick="ImageButton9_Click" />
        
        <center>
            <asp:ImageButton ID="btnCapturar3" runat="server" ImageUrl="~/img/btncapturar.png" OnClick="btnCapturar3_Click" />
        </center>
        
    </div>

</div>

                </asp:Panel>
                <br />
                
                <asp:Panel ID="PainelPlanalto" runat="server">

                    

                </asp:Panel>

                <asp:Panel ID="NovaSonda" runat="server">

                    <asp:Label ID="Label1" runat="server" Text="Inicial X:"></asp:Label>
                    <asp:TextBox ID="CordX" runat="server" Width="39px"></asp:TextBox>
                    <asp:Label ID="Label2" runat="server" Text="Inicial Y:"></asp:Label>
                    <asp:TextBox ID="CordY" runat="server" Width="39px"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text="Sentido:"></asp:Label>
                    <asp:DropDownList ID="DDSentido" runat="server">
                        <asp:ListItem>n</asp:ListItem>
                        <asp:ListItem>s</asp:ListItem>
                        <asp:ListItem>w</asp:ListItem>
                        <asp:ListItem>e</asp:ListItem>
                    </asp:DropDownList>
                    <br />

                    <asp:ImageButton ID="BtnNovaSonda" runat="server" ImageUrl="~/img/btnenviasonda.png" OnClick="BtnNovaSonda_Click" />

                    <asp:HiddenField ID="Sonda1x" runat="server" />
                    <asp:HiddenField ID="Sonda1y" runat="server" />
                    <asp:HiddenField ID="Sonda1s" runat="server" />
                    <asp:HiddenField ID="Sonda2x" runat="server" />
                    <asp:HiddenField ID="Sonda2y" runat="server" />
                    <asp:HiddenField ID="Sonda2s" runat="server" />
                    <asp:HiddenField ID="Sonda3x" runat="server" />
                    <asp:HiddenField ID="Sonda3y" runat="server" />
                    <asp:HiddenField ID="Sonda3s" runat="server" />

                </asp:Panel>
                

                <asp:Panel ID="PainelCaptura" runat="server" Visible="false">
                    <asp:Image ID="ImgCapturada" runat="server" ImageUrl="~/img/marte/1.jpg" Width="400px" />
                    <br />
                    <asp:ImageButton ID="btnCapturar4" runat="server" ImageUrl="~/img/btnvoltar.png" OnClick="btnCapturar4_Click" />
                    <asp:HiddenField ID="HFiimagem" runat="server" Value="0" />
                </asp:Panel>
                </ContentTemplate>

        </asp:UpdatePanel>
        
    </div>
    </form>
</body>
</html>
