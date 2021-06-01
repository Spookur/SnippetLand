<%@ Page Title="Types" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Types.aspx.cs" Inherits="FirstWebFormApp.Types" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    
    <div>
        <asp:Button id="Button1" Text="Submit" BackColor="#000000" onClick="b1_Click" runat="server" />
    </div>
   
    <div> 
        <asp:Label ID="LoveMessageLabel" BackColor="Tomato" Visible="false" runat="server">I LOVE YOU</asp:Label>
    </div>

    <div>
        <asp:CheckBox ID="anus" BackColor="#000000" Visible="false" runat="server" />
    </div>

    

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>



