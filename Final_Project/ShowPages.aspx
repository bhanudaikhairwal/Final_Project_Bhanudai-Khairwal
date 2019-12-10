<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowPages.aspx.cs" Inherits="Final_Project.ShowPages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="pages_info" class="one_view" runat="server">
        <h2 id="p_title" class="one_title"><span id="page_t" runat="server"></span></h2>

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
         </asp:Table>
        
        <div id="updatebutton" runat="server"></div>
        <a class="one_options one_delete" href="#" runat="server">DELETE</a>
     

    </div>
</asp:Content>
