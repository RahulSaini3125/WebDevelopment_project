<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminitration.aspx.cs" Inherits="WebDevelopment_project.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <center>
            <h1>
                ADMINISTRATOR
            </h1>
        </center>
    </section>
    <asp:GridView ID="GridView1" CssClass="Gridview" AutoGenerateColumns="false" runat="server">
        <Columns >
            <asp:BoundField DataField="Id" HeaderStyle-CssClass="Gridview-Header Userid" ItemStyle-CssClass="Gridview-item "  HeaderText="User Id" />
            <asp:BoundField DataField="Name" HeaderStyle-CssClass="Gridview-Header" ItemStyle-CssClass="Gridview-item" HeaderText="User Name" />
            <asp:BoundField DataField="Email" HeaderStyle-CssClass="Gridview-Header" ItemStyle-CssClass="Gridview-item" HeaderText="User Email" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="Delete Account" HeaderStyle-CssClass="Gridview-Header" ItemStyle-CssClass="Gridview-item" />
        </Columns>
    </asp:GridView>
</asp:Content>
