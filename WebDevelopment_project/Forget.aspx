<%@ Page Title="Forget Password" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Forget.aspx.cs" Inherits="WebDevelopment_project.Forget" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="Scripts/email.js"></script>
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
          <div runat="server" id="emaildiv">
              <h2> 
    Forget Password
</h2>
          <div class="form-outline mb-4">
            <asp:TextBox ID="emailID" TextMode="Email" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
            <asp:Label ID="Label_emailID" runat="server" CssClass="form-label" Text="Email ID" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailID" ErrorMessage="Please Enter Email"></asp:RequiredFieldValidator>
          </div>
          <asp:Button ID="Sendotp" OnClick="Sendotp_Click" type="submit" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="Send OTP" />
          </div>

 <div runat="server" id="otpdiv">
          <!-- Newpassword input -->
<div class="form-outline mb-4">
  <asp:TextBox ID="otptext" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
  <asp:Label ID="Label_newpass" runat="server" CssClass="form-label" Text="Enter OTP" />
  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="otptext"  ErrorMessage="Please Enter OTP"></asp:RequiredFieldValidator>
    <asp:Button ID="submitotp" runat="server" Text="Submit" CssClass="btn btn-primary btn-lg btn-block" OnClick="submitotp_Click" />
</div>
      </div>
 <div runat="server" id="newpassdiv">

          <!-- Password1 input -->
          <div class="form-outline mb-4">
              <h3>
                  New Password
              </h3>
            <asp:TextBox ID="newpassword1" TextMode="Password" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
            <asp:Label ID="LabelPassword" CssClass="form-label" runat="server"  Text="Password"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="newpassword1" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
              
          </div>
           <div class="form-outline mb-4">
            <asp:TextBox ID="newpassword" TextMode="Password" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
             <asp:Label ID="Labelpass" CssClass="form-label" runat="server"  Text="Password"/>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="newpassword" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
            </div>
          <asp:Button ID="update" OnClick="update_Click"  type="submit" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="Update Password" />
      </div>
          <asp:Button ID="homebtn" OnClick="homebtn_Click" runat="server" CssClass="btn btn-primary btn-lg btn-block" Text="Go To Login Page" />
 </div>

    </div>
</asp:Content>
