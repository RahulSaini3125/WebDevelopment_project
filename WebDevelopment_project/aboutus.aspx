<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="aboutus.aspx.cs" Inherits="WebDevelopment_project.aboutus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="mb-4">
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
    <h2 class="h1-responsive font-weight-bold text-center my-4">About us</h2>
    <!--Section description-->
    <p class="text-center w-responsive mx-auto mb-5">Do you have any questions? Please do not hesitate to contact us directly. Our team will come back to you within
        a matter of hours to help you.</p>
         <div class="services-content">
     <div class="services-features">
             <h3> Blog </h3>
                <p class="p"> 
                    A blog is a type of website that is regularly updated with new content, usually in the form of articles or posts. It is run by an individual, group, or corporation and can be used for various purposes such as sharing personal experiences, promoting a business, or educating others on a specific topic. Blogs are written in an informal or conversational style and are presented in reverse chronological order. They can also include various widgets and plugins such as a social media feed, a contact form, or an author profile. If you’re interested in starting your own blog, you can check out this guide to learn more about the necessary components such as a hosting plan and common blog types.
          </p>
         </div>
             <div class="services-features">
        <h3> .NET</h3>
           <p class="p"> 
               .NET is a free, cross-platform, open source developer platform created by Microsoft for building many different types of applications. It is made up of tools, programming languages, and libraries. With .NET, you can use multiple languages, editors, and libraries to build for web, mobile, desktop, games, IoT, and more 1.

There are various implementations of .NET. Each implementation allows .NET code to execute in different places such as Linux, macOS, Windows, iOS, Android, and many more 12.

The first version of the .NET framework was 1.0 which came in the year 2002 3.

C# is a simple, modern, object-oriented, and type-safe programming language that is used to write .NET apps 1. F# is a programming language that makes it easy to write succinct, robust, and performant code 1. Visual Basic is an approachable language with a simple syntax for building type-safe, object-oriented apps 1.

The .NET package ecosystem is maintained by Microsoft and others. NuGet is a package manager built specifically for .NET that contains over 100,000 packages 1.
     </p>
    </div>
             </div>
</section>
<!--Section: Contact v.2-->

</asp:Content>
