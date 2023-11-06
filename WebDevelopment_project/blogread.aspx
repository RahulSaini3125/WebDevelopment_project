 <%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="blogread.aspx.cs" Inherits="WebDevelopment_project.blogread" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    
    </div>
    <div>
    </div>
    <div>
    </div>
    <div>
    
    </div>
    <section class="section">
    <div class="services-content">
        <h1 class="headingh1"> <asp:Label ID="Titles" runat="server"></asp:Label> </h1>
        <div class="services-features">
            <div class="services-feature">
                   <p class="p"> 
                   <asp:Label ID="blogtypelabel" runat="server" ></asp:Label>
             </p>
            </div>
            <div class="services-feature">
                <h3>Description</h3>
                <p class="p"> 
                         <asp:Label ID="Shortdes" runat="server"></asp:Label>
                </p>
            </div>
            <div class="services-feature">
                <h3>Blog</h3>
                <p class="p">
    <asp:Label ID="blog" runat="server" Text="Label"></asp:Label>
                </p>
            </div>
            <div class="services-feature">
                <p class="p"><asp:Label ID="datetime" runat="server" ></asp:Label> By
                    <asp:Label ID="upload" CssClass="blue" runat="server" ></asp:Label>
 </p>
            </div>
        </div>
    </div>
</section>
</asp:Content>
