<%@ Page Title="Registrations" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDevelopment_project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Section Start -->

    <section class="vh-100">
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
        <!-- Form End -->
        <!-- Form Container Start -->
        <div class="container py-5 h-100">
            <div class="row d-flex align-items-center justify-content-center h-100">
                <!-- Images Start -->
                <div class="col-md-8 col-lg-7 col-xl-6">
                    <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg"
                        class="img-fluid" alt="Phone image">
                </div>
                <!-- Images End -->
                <!-- Form Start -->
                <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1">
                        <!--Name-->
                        <div class="form-outline mb-4">
                            <asp:TextBox ID="Name" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
                            <asp:Label ID="Label3" runat="server" CssClass="form-label" Text="Name" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Name" ErrorMessage="Please Enter name"></asp:RequiredFieldValidator>
                        </div>
                        <!-- Email input -->
                        <div class="form-outline mb-4">
                            <asp:TextBox ID="Email" TextMode="Email" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
                            <asp:Label ID="Label_Email" runat="server" CssClass="form-label" Text="Email" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Email" ErrorMessage="Please Enter Username"></asp:RequiredFieldValidator>
                        </div>
                        <!-- Password input -->
                        <div class="form-outline mb-4">
                            <asp:TextBox ID="password" TextMode="Password" CssClass="form-control form-control-lg" runat="server"></asp:TextBox>
                            <asp:Label ID="Label1" CssClass="form-label" runat="server" Text="Password" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="password" ErrorMessage="Please Enter Password"></asp:RequiredFieldValidator>
                        </div>
                        <!-- Submit button -->
                        <asp:Button ID="Button1" OnClick="Button1_Click" type="submit" CssClass="btn btn-primary btn-lg btn-block" runat="server" Text="Sign in" />
                        <!-- Account Info -->
                        <div class="d-flex justify-content-around align-items-center mb-4">
                               <p> Already have a Account?<a href="login.aspx">Login</a> </p>
                        </div>
                </div>
                <!-- Form End -->
            </div>
        </div>
        <!-- Form Container End -->
    </section>
    <!-- Section End -->
</asp:Content>
