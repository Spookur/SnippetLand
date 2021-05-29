<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Default.aspx.cs" Inherits="ModalPopup.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<form runat="server"> 

<asp:Button ID="ClientButton" runat="server" Text="Launch Modal Popup (Client)" />

    <asp:Panel ID="Panel1" runat="server" Width="500px">
 ASP.NET AJAX is a free framework for quickly creating a new generation of more 
 efficient, more interactive and highly-personalized Web experiences that work 
 across all the most popular browsers.<br />
 <asp:Button ID="Button1" runat="server" Text="Close" />
</asp:Panel>

 <ajaxToolkit:ModalPopupExtender ID="mpe" runat="server" TargetControlId="ClientButton" 
 PopupControlID="ModalPanel" OkControlID="OKButton" />

    <asp:ScriptManager ID="asm" runat="server" />

    <asp:Button ID="ServerButton" runat="server" Text="Launch Modal Popup (Server)" 
 OnClick="ServerButton_Click" />

    <script runat="server">
 protected void ServerButton_Click(object sender, EventArgs e)
 {
 ClientScript.RegisterStartupScript(this.GetType(), "key", "launchModal();", true);
 }
</script>

    <script type="text/javascript">
 var launch = false;
 function launchModal() 
 {
 launch = true;
        }

        function pageLoad() {
            if (launch) {
                $find("mpe").show();
            }
        }
</script>

</form> 

