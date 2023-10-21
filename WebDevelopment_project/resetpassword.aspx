<%@ Page Title="Rest Password" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="resetpassword.aspx.cs" Inherits="WebDevelopment_project.resetpassword" %>
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
          <div runat="server" id="oldpassdiv">

          <div class="form-outline mb-4">
            <asp:TextBox ID="oldpassword" TextMode="Password" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
            <asp:Label ID="Label_oldpass" runat="server" CssClass="form-label" Text="Old Password" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="oldpassword" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
          </div>
          <asp:Button ID="verify" OnClick="verify_Click"  type="submit" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="Verify" />
          </div>

 <div runat="server" id="newpassdiv">
          <!-- Newpassword input -->
<div class="form-outline mb-4">
  <asp:TextBox ID="Newpassword" TextMode="Password" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
  <asp:Label ID="Label_newpass" runat="server" CssClass="form-label" Text="New Password" />
  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Newpassword"  ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
</div>
          <!-- Password1 input -->
          <div class="form-outline mb-4">
            <asp:TextBox ID="newpassword1" TextMode="Password" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
            <asp:Label ID="LabelPassword" CssClass="form-label" runat="server"  Text="Password"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="newpassword1" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
              
          </div>
          <asp:Button ID="update" OnClick="update_Click"  type="submit" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="Update Password" />
      </div>
      </div>
    </div>
</section>

</asp:Content>
