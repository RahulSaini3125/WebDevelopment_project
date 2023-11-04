<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="WebDevelopment_project.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <section>
             <% if (messageboxred.Text != ""){  %>
        <div class="alert-center">
            <div class="alert alert-danger" role="alert">
                <asp:Label ID="messageboxred" runat="server"></asp:Label>
            </div>
        </div>
<%}
%>
     <!--************************************-->
  <div class="container py-5">
    <div class="row">
      <div class="col-lg-4">
        <div class="card mb-4">
          <div class="card-body text-center">
            <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava3.webp" alt="avatar"
              class="rounded-circle img-fluid" style="width: 150px;">
              <div class="my-3">
                  <h3>
                    <asp:Label CssClass="my-3" ID="displayName" runat="server"></asp:Label>            
                  </h3>
              </div>
            <p class="text-muted mb-1">Full Stack Developer</p>
            <p class="text-muted mb-4">Bay Area, San Francisco, CA</p>
          </div>
        </div>
      </div>
      <div class="col-lg-8">
        <div class="card mb-4">
          <div class="card-body">
            <div class="row">
              <div class="col-sm-3">
                  <asp:Label CssClass="mb-0" ID="FullNameD" runat="server" Text="Full Name:"></asp:Label>
              </div>
              <div class="col-sm-9">
                 <asp:Label ID="FullName" CssClass="text-muted mb-0" runat="server" Text="Name"></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                  <asp:Label ID="IID" CssClass="mb-0" runat="server" Text="ID"></asp:Label>
              </div>
              <div class="col-sm-9">
                  <asp:Label ID="Id" CssClass="text-muted mb-0" runat="server" Text="Label"></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                  <asp:Label ID="EmailD" CssClass="mb-0" runat="server" Text="Email ID"></asp:Label>
              </div>
              <div class="col-sm-9">
                  <asp:Label ID="Email" CssClass="text-muted mb-0" runat="server" Text="Label"></asp:Label>
              </div>
            </div>
            <hr>
              <div class="row">
                 <div class="col-sm-3">
                     <asp:Label ID="Label1" CssClass="mb-0" runat="server" Text="Total Post Upload"></asp:Label>
                 </div>
                 <div class="col-sm-9">
                       <asp:Label ID="Totalpost" CssClass="text-muted mb-0" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
              <hr />
            <div class="row">
              <div class="col-sm-3">
                  <asp:Label ID="ACDTD" CssClass="mb-0" runat="server" Text="Account Create On"></asp:Label>
              </div>
              <div class="col-sm-9">
                  <asp:Label ID="ACDT" CssClass="text-muted mb-0" runat="server" Text="Label"></asp:Label>
              </div>
            </div>
            <hr>
            <div class="row">
              <div class="col-sm-3">
                  <asp:Label ID="Account_statusD" CssClass="mb-0" runat="server" Text="Account Status"></asp:Label>
              </div>
              <div class="col-sm-9">
                  <asp:Label ID="Account_status" CssClass="text-muted mb-0" runat="server" Text="Label"></asp:Label>
              </div>
            </div>
              <div>
                  <hr />
                  <asp:Button ID="Chnage_password_btn" runat="server" OnClick="Chnage_password_btn_Click" CssClass="btn btn-primary margin-5" Text="Change Password" />
                  <asp:Button ID="Delete_btn" runat="server" OnClick="Delete_btn_Click" CssClass="btn btn-danger margin-5" Text="Delete Your Account" />
              </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
    <section class="my-5">
        <div class="container" >
            <div class="text-center" >
                    <h4 class="mb-5"><strong>Your posts</strong></h4>
                <%if (Totalpost.Text != "0")
                    {%>
                    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                <%} %>
                <% else
                    {  %>
                <p class="p"> Your didn't Post Any Blog.</p>
                <p class="p"> Click On Below Button To Post Your First Blog.</p>
                    <asp:LinkButton ID="ownblog" CssClass="btn btn-primary" OnClick="ownblog_Click" runat="server">Post your first blog</asp:LinkButton>                    
                <%} %>
            </div>
        </div>
    </section>

</asp:Content>
