<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="UpdatePages.aspx.cs" Inherits="Final_Project.UpdatePages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
     <div id="page_update_container" class="one_view" runat="server">
        <h2 id="p_title" class="one_title">Update Page Record</h2>
        
        <section>
            <asp:label AssociatedControlID="update_page_title" runat="server">Page title:</asp:label>
            <asp:TextBox runat="server" ID="update_page_title"></asp:TextBox>
            <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" 
                ErrorMessage="Update as you wish" 
                ControlToValidate="update_page_title"></asp:RequiredFieldValidator>
        </section>

        <section>
            <asp:label AssociatedControlID="update_page_body" runat="server">Page body content:</asp:label>
            <asp:TextBox runat="server" ID="update_page_body"></asp:TextBox>
            <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" 
                ErrorMessage="Can't leave it blank!" 
                ControlToValidate="update_page_body"></asp:RequiredFieldValidator>
        </section>

        <asp:Button class="one_options one_update" Text="UPDATE" runat="server"/>
    </div>

</asp:Content>
