<%@ Page Title="MyPages" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="listpages.aspx.cs" Inherits="Final_Project.listpages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="body" runat="server">
    <div id="pages_header" class="list_header">
        <h1>Pages</h1>
        <div class="list_search">
            <asp:TextBox id="pages_search_textbox" runat="server"></asp:TextBox>
            <a id="pages_search_button" class="list_button search_button">Search</a>
        </div>
        <a  class="list_button add_button" href="AddPages.aspx">Add New Page</a>
        <div class="debugger" id="sql_debugger" runat="server"></div>
    </div>
    <div class="_table" runat="server">
        <div class="listitem  list_head">
            <div class="col4">page title</div>
            <div class="col4">page body</div>
            <div class="col4last">View Details</div>
        </div>
        <div id="pages_result" runat="server">

        </div>
    </div>
</asp:Content>
