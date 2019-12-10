<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddPages.aspx.cs" Inherits="Final_Project.AddPages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
     <div id="page_form_container" runat="server">
        <h2 class="one_title">Add New Page</h2>
        
        <section>
            <asp:label AssociatedControlID="new_page_title" runat="server">Page Title:</asp:label>
            <asp:TextBox runat="server" ID="new_page_title"></asp:TextBox>
            <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" 
                ErrorMessage="Need a title!" 
                ControlToValidate="new_page_title"></asp:RequiredFieldValidator>
        </section>

        <section>
            <asp:label AssociatedControlID="new_page_body" runat="server">Page Body:</asp:label>
            <asp:TextBox runat="server" ID="new_page_body"></asp:TextBox>
            <asp:RequiredFieldValidator  runat="server" EnableClientScript="true" 
                ErrorMessage="enter something cool!" 
                ControlToValidate="new_page_body"></asp:RequiredFieldValidator>
        </section>

        <asp:Button class="one_options one_add" Text="ADD RECORD" runat="server"/>
    </div>
</asp:Content>
