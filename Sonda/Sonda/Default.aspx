<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sonda.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                
                        
                <asp:Panel ID="PainelExped" runat="server">
                    <h2>
                        
                        Informe as Cordenadas do Ponto superior-direito do planalto que será explorado</h2>

                    <p>
                        <asp:Label ID="Label1" runat="server" Text="Cordenada X:"></asp:Label>
                        <asp:TextBox ID="CordX" runat="server" Width="42px"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="Cordenada Y:"></asp:Label>
                        <asp:TextBox ID="CordY" runat="server" Width="44px"></asp:TextBox>
                    </p>

                    <p>
                        <asp:ImageButton ID="btnExpedicao" runat="server" ImageUrl="~/img/btnexpedicao.png" OnClick="ImageButton1_Click" />
                    </p>

                </asp:Panel>
                
                
            </ContentTemplate>

        </asp:UpdatePanel>
        
    
    </div>
    </form>
</body>
</html>
