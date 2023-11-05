<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contactus.aspx.cs" Inherits="WebDevelopment_project.Contactus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--Section: Contact v.2-->
<section class="margin-all">
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

    <!--Section heading-->
    <h2 class="h1-responsive font-weight-bold text-center my-4">Contact us</h2>
    <!--Section description-->
    <p class="text-center w-responsive mx-auto mb-5">Do you have any questions? Please do not hesitate to contact us directly. Our team will come back to you within
        a matter of hours to help you.</p>

    <div class="row">

        <!--Grid column-->
        <div class="col-md-9 mb-md-0 mb-5">

                <!--Grid row-->
                <div class="row">

                    <!--Grid column-->
                    <div class="col-md-6">
                        <div class="md-form mb-0">
                            <asp:TextBox ID="username" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
                            <label for="name" class="">Your name</label>
                        </div>
                    </div>
                    <!--Grid column-->

                    <!--Grid column-->
                    <div class="col-md-6">
                        <div class="md-form mb-0">
                            <asp:TextBox ID="useremail" TextMode="Email" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
                            <label for="email" class="">Your email</label>
                        </div>
                    </div>
                    <!--Grid column-->

                </div>
                <!--Grid row-->

                <!--Grid row-->
                <div class="row">
                    <div class="col-md-12">
                        <div class="md-form mb-0">
                            <asp:TextBox ID="usersubject" CssClass="form-control" runat="server"></asp:TextBox>
                            <label for="subject" class="">Subject</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="check" runat="server" ControlToValidate="usersubject" ErrorMessage="Required Subject"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <!--Grid row-->

                <!--Grid row-->
                <div class="row">

                    <!--Grid column-->
                    <div class="col-md-12">

                        <div class="md-form">
                            <asp:TextBox ID="usermessage" CssClass="form-control md-textarea" Rows="2" runat="server"></asp:TextBox>
                            <label for="message">Your message</label>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="check"  runat="server" ControlToValidate="usermessage" ErrorMessage="Required Message"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>


            <div class="text-center text-md-left">
                <asp:Button ID="Send" OnClick="Send_Click" ValidationGroup="check" CssClass="btn btn-primary" runat="server" Text="Send" />
            </div>
            <div class="status"></div>
        </div>
        <!--Grid column-->

    </div>

</section>
<!--Section: Contact v.2-->
</asp:Content>
