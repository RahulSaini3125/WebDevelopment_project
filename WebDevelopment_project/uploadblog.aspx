<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="uploadblog.aspx.cs" Inherits="WebDevelopment_project.uploadblog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <!-- Message Box Start -->
 <% if (messagebox.Text != "")
     {  %>
 <div class="alert-center">
     <div class="alert alert-primary" role="alert">
         <asp:Label ID="messagebox" CssClass="block-mes" runat="server"></asp:Label>
     </div>
 </div>
 <%} %>
 <% if (messageboxred.Text != ""){  %>
         <div class="alert-center">
             <div class="alert alert-danger" role="alert">
                 <asp:Label ID="messageboxred" runat="server"></asp:Label>
             </div>
         </div>
 <%} %>
    <div style="margin:80px">
<div class="form-outline mb-4">
    <asp:TextBox ID="email" CssClass="form-control" runat="server"></asp:TextBox>
  <label class="form-label" for="form6Example3">Email</label>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="blog" runat="server" CssClass="text-red" ControlToValidate="email" ErrorMessage="Please Enter the Email"></asp:RequiredFieldValidator>
</div>
<div class="form-outline mb-4">
  <asp:TextBox ID="Titles" CssClass="form-control" runat="server"></asp:TextBox>
  <label class="form-label" for="form6Example4">Title</label>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="blog" CssClass="text-red" ControlToValidate="Titles" ErrorMessage="Please Enter the Title"></asp:RequiredFieldValidator>

</div>
<div class="form-outline mb-4">
  <label class="form-label" for="form6Example5">Blog Type</label>
    <asp:DropDownList ID="blogtype"  runat="server">
        <asp:ListItem>--SELECT--</asp:ListItem>
        <asp:ListItem>Travel Blogs</asp:ListItem>
        <asp:ListItem>Health and fitness blogs</asp:ListItem>
        <asp:ListItem>Lifestyle blogs</asp:ListItem>
        <asp:ListItem>Fashion and beauty blogs</asp:ListItem>
        <asp:ListItem>Photography blogs</asp:ListItem>
        <asp:ListItem>DIY craft blogs</asp:ListItem>
        <asp:ListItem>Parenting blogs</asp:ListItem>
        <asp:ListItem>Food Blog</asp:ListItem>
        <asp:ListItem>Music blogs</asp:ListItem>
        <asp:ListItem>Business blogs</asp:ListItem>
        <asp:ListItem>Art and desgin blogs</asp:ListItem>
        <asp:ListItem>Books and writing blogs</asp:ListItem>
        <asp:ListItem>News blogs</asp:ListItem>

    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ValidationGroup="blog" CssClass="text-red" ControlToValidate="blogtype" ErrorMessage="Please Select Blog Type"></asp:RequiredFieldValidator>

</div>
<div class="form-outline mb-4">
  <asp:TextBox ID="shortdes" CssClass="form-control" runat="server"></asp:TextBox>
  <label class="form-label" for="form6Example6">Short Description about Blog</label>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" CssClass="text-red" ValidationGroup="blog" ControlToValidate="shortdes" ErrorMessage="Please Enter the Blog Description"></asp:RequiredFieldValidator>
</div>
<div class="form-outline mb-4">
  <asp:TextBox ID="blogcon" CssClass="form-control" TextMode="MultiLine" Rows="4" runat="server"></asp:TextBox>
  <label class="form-label" for="form6Example7"> Your Blog</label>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ValidationGroup="blog" CssClass="text-red" ControlToValidate="blogcon" ErrorMessage="Please Enter the Blog"></asp:RequiredFieldValidator>
</div>
    <asp:Button ID="blogsubmit" OnClick="blogsubmit_Click" ValidationGroup="blog" CssClass="btn btn-primary btn-block mb-4" runat="server" Text="Submit" />
    </div>
</asp:Content>
