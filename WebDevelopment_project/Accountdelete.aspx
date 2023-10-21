<%@ Page Title="Account Delete" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Accountdelete.aspx.cs" Inherits="WebDevelopment_project.Accountdelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <section class="vh-100">
         <% if (messageboxred.Text != ""){  %>
         <div class="alert-center">
             <div class="alert alert-danger" role="alert">
                 <asp:Label ID="messageboxred" runat="server"></asp:Label>
             </div>
         </div>
 <%} %>
                    <% if (messagebox.Text != ""){  %>
        <div class="alert-center">
            <div class="alert alert-primary" role="alert">
                <asp:Label ID="messagebox" runat="server"></asp:Label>
            </div>
        </div>
<%} %>
  <div class="container py-5 h-100">
      <div class="col-md-7 col-lg-5 col-xl-5 ">
          <!-- oldpassword input -->
          <div class="form-outline mb-4">
            <asp:TextBox ID="oldpassword" TextMode="Password" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
            <asp:Label ID="Label_oldpass" runat="server" CssClass="form-label" Text="Password" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="oldpassword" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
          </div>
          <asp:Button ID="AccountDelete" OnClick="AccountDelete_Click"  type="submit" CssClass="btn btn-danger btn-lg btn-block" runat="server" Text="Delete My Account" />
      </div>
    </div>
</section>
</asp:Content>
