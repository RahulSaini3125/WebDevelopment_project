<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home_page.aspx.cs" Inherits="WebDevelopment_project.Home_page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1> This is Home Page...</h1>
        <asp:Label ID="Label1" runat="server" ></asp:Label>
        <asp:Label ID="Label2" runat="server" Enabled="false" Visible="false" ></asp:Label>
    <% if ( Label2.Text  == "True"){ %>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Button ID="Show_data" OnClick="Show_data_Click" runat="server" Text="Show Data" />
    <%} %>
</asp:Content>