<%@ Page Title="Blog" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="WebDevelopment_project.blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <header>
    <!-- Intro settings -->
    <style>
      #intro {
        /* Margin to fix overlapping fixed navbar */
        margin-top: 58px;
      }
      @media (max-width: 991px) {
        #intro {
          /* Margin to fix overlapping fixed navbar */
          margin-top: 45px;
        }
      }
    </style>
          </header>
  <!--Main layout-->
  <main class="my-5 margin-all">
        <asp:LinkButton ID="ownblog" CssClass="btn btn-primary" OnClick="ownblog_Click" runat="server">Create Your Own Blog</asp:LinkButton>
    <div class="container">
      <!--Section: Content-->
      <section class="text-center">

        <h4 class="mb-5"><strong>Latest posts</strong></h4>
          <asp:Panel ID="Panel1" runat="server"></asp:Panel>
          </section>
        </div>
  </main>
  <!--Main layout-->

  </asp:Content>
