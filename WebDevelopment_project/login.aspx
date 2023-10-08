<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebDevelopment_project.login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="vh-100">
         <% if (messageboxred.Text != ""){  %>
         <div class="alert-center">
             <div class="alert alert-danger" role="alert">
                 <asp:Label ID="messageboxred" runat="server"></asp:Label>
             </div>
         </div>
 <%} %>
  <div class="container py-5 h-100">
    <div class="row d-flex align-items-center justify-content-center h-100">
      <div class="col-md-8 col-lg-7 col-xl-6">
        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg"
          class="img-fluid" alt="Phone image">
      </div>
      <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
          <!-- Email input -->
          <div class="form-outline mb-4">
            <asp:TextBox ID="Email" TextMode="Email" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
            <asp:Label ID="Label_Email" runat="server" CssClass="form-label" Text="Email" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Email" ErrorMessage="Please Enter Username"></asp:RequiredFieldValidator>
          </div>

          <!-- Password input -->
          <div class="form-outline mb-4">
            <asp:TextBox ID="password" TextMode="Password" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
            <asp:Label ID="LabelPassword" CssClass="form-label" runat="server"  Text="Password"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="password" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
          </div>

          <div class="d-flex justify-content-around align-items-center mb-4">
            <a href="#!">Forgot password?</a>
          </div>

          <!-- Submit button -->
          <asp:Button ID="Button1" OnClick="Button1_Click" type="submit" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="Sign in" />
            <!-- Forgot -->
            <div class="d-flex justify-content-around align-items-center mb-4">
                <p> Don't Have a account?<a href="Default.aspx">Create Account</a> </p>
            </div>
      </div>
    </div>
  </div>
</section>
</asp:Content>
