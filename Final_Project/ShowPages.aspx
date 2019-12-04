<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowPages.aspx.cs" Inherits="Final_Project.ShowPages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="pages_info" class="one_view" runat="server">
        <h2 id="p_title" class="one_title"><span id="page_title" runat="server"></span></h2>

        <asp:Table runat="server"
            CellPadding="10" GridLines="Both" HorizontalAlign="Center">
            <asp:TableRow>
                <asp:TableCell>Page Title</asp:TableCell>
                <asp:TableCell><span id="page_title" runat="server"></span></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Page Body</asp:TableCell>
                <asp:TableCell><span id="page_body" runat="server"></span></asp:TableCell>
            </asp:TableRow>
        
        <asp:Button class="one_options one_update" Text="UPDATE" runat="server"/>
        <asp:Button class="one_options one_delete" Text="DELETE" runat="server" />

    </div>
</asp:Content>
