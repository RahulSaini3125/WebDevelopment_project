<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="adminitration.aspx.cs" Inherits="WebDevelopment_project.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Admin" runat="server" Visible="false" Enabled="false" ></asp:Label>
    <asp:Label ID="Label2" runat="server"  ></asp:Label>

    <% if (Admin.Text == "True")
        {  %>
    <!-- ************************************-->
    <div runat="server" id="selectalert"  class="user-info-modal">
  <div  class="user-info-modal-dialog">
    <div  class="user-info-modal-content">
      <div class="user-info-modal-header">
        <h2 class="modal-title" id="exampleModalLabel">User Details</h2>
      </div>
          <hr />
      <div class="user-info-modal-body">
          <div class="user-info-modal-body-label">
            <asp:Label ID="id" runat="server" Text="ID: "></asp:Label>
            <asp:Label ID="User_id" runat="server" ></asp:Label>
          </div>
          <div class="user-info-modal-body-label" >
            <asp:Label ID="Name" runat="server" CssClass="user-info-modal-body-label" Text="Name:"></asp:Label>
            <asp:Label ID="UserName" runat="server"></asp:Label>
          </div>
          <div class="user-info-modal-body-label" >
            <asp:Label ID="email" runat="server" CssClass="user-info-modal-body-label" Text="Email: "></asp:Label>
            <asp:Label ID="UserEmail" runat="server"></asp:Label>
          </div>
          <div class="user-info-modal-body-label" >
               <asp:Label ID="admins" runat="server" CssClass="user-info-modal-body-label" Text="Status:"></asp:Label>
               <asp:Label ID="useradmin" runat="server"></asp:Label>
        </div>
          <div class="user-info-modal-body-label" >
            <asp:Label ID="ACDT" runat="server" CssClass="user-info-modal-body-label" Text="Created Date:"></asp:Label>
            <asp:Label ID="UserACDT" runat="server"></asp:Label>
          </div>
          <div class="user-info-modal-body-label" >
            <asp:Label ID="LLDT" runat="server" CssClass="user-info-modal-body-label" Text="Last Login:"></asp:Label>
            <asp:Label ID="UserLLDT" runat="server"></asp:Label>
          </div>
          <div class="user-info-modal-body-label" >
            <asp:Label ID="Status" runat="server" CssClass="user-info-modal-body-label" Text="Status:"></asp:Label>
            <asp:Label ID="UserStatus" runat="server"></asp:Label>
          </div>

      </div>
        <hr />
      <div class="user-info-modal-footer">
          <% if (UserStatus.Text == "Activate")
              { %>
          <asp:Button ID="Deactivate"  CssClass=" user-btn user-deactivate" OnClick="Deactivate_Click" runat="server" Text="Deactivate" />
          <% } %>
          <% else
              {  %>
          <asp:Button ID="activate"  CssClass=" user-btn user-activate" OnClick="activate_Click" runat="server" Text="Activate" />
          <% } %>
          <asp:Button ID="Delete" CssClass="user-delete user-btn" OnClick="Delete_Click" runat="server" Text="Delete" />
          <asp:Button ID="Close" CssClass="user-close user-btn " OnClick="Close_Click"  runat="server" Text="Close" />
      </div>
    </div>
  </div>
</div>

    <!--**************************************************-->
        <div runat="server" id="messagealertdone"  class="user-info-modal">
            <div  class="user-info-modal-dialog">
                <div runat="server" class="messagealert" id="Div3">
                     <h1>
                    <i class="bi bi-check2-all"></i>
                     </h1>
                    <h1>
                    <asp:Label ID="Label11" runat="server" Text="Update Successfully"></asp:Label>
                    </h1>
                </div>
                <div class="user-info-modal-footer">
                <asp:Button ID="Button3" CssClass="user-close user-btn" OnClick="Close_Click"  runat="server" Text="Close" />
                </div>
            </div>
        </div>

    <!-- ****************************************************** -->
    <div runat="server" id="messagealertundone"  class="user-info-modal">
    <div  class="user-info-modal-dialog">
        <div runat="server" class="messagealert" id="Div2">
             <h1>
            <i class="bi bi-x-circle"></i>
             </h1>
            <h1>
            <asp:Label ID="Label1" runat="server" Text="Update Error"></asp:Label>
            </h1>
        </div>
        <div class="user-info-modal-footer">
        <asp:Button ID="Button1" CssClass="user-close user-btn" OnClick="Close_Click"  runat="server" Text="Close" />
        </div>
    </div>
</div>


        <!-- ************************************-->
    <div runat="server" id="feedbackdiv"  class="user-info-modal">
  <div  class="user-info-modal-dialog">
    <div  class="user-info-modal-content">
      <div class="user-info-modal-header">
        <h2 class="modal-title" id="ModalLabel">User Details</h2>
      </div>
          <hr />
      <div class="user-info-modal-body">
          <div class="user-info-modal-body-label" >
<asp:Label ID="Label3" runat="server" CssClass="user-info-modal-body-label" Text="Name"></asp:Label>
<asp:Label ID="feedbackname" runat="server"></asp:Label>
 </div>
<div class="user-info-modal-body-label" >
<asp:Label ID="Label5" runat="server" CssClass="user-info-modal-body-label" Text="email"></asp:Label>
<asp:Label ID="feedbackemail" runat="server"></asp:Label>
 </div>
<div class="user-info-modal-body-label" >
<asp:Label ID="Label7" runat="server" CssClass="user-info-modal-body-label" Text="messgae"></asp:Label>
<asp:Label ID="feedbackmessage" runat="server"></asp:Label>
</div>
      </div>
        <hr />
      <div class="user-info-modal-footer">
          <asp:Button ID="feedbackClosediv" CssClass="user-close user-btn " OnClick="feedbackClosediv_Click"  runat="server" Text="Close" />
      </div>
    </div>
  </div>
</div>

    <!-- ************************************************* -->
        <section>
            <center>
                <h1>
                    ADMINISTRATOR
                </h1>
            </center>
            <asp:Button ID="UserDetails" OnClick="UserDetails_Click" CssClass="btn btn-primary" runat="server" Text="User Details" />
            <asp:Button ID="Feedback" OnClick="Feedback_Click" CssClass="btn btn-primary " runat="server" Text="Show User Feedback" />
            <div class="Gridview-div" runat="server" id="gridviewdiv" >
        <asp:GridView ID="GridView1" CssClass="Gridview"  AutoGenerateColumns="false" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" Width="100%" runat="server">
        <Columns >
            <asp:BoundField DataField="Id" HeaderStyle-CssClass="Gridview-Header Userid" ItemStyle-CssClass="Gridview-item "  HeaderText="User Id" />
            <asp:BoundField DataField="Name" HeaderStyle-CssClass="Gridview-Header" ItemStyle-CssClass="Gridview-item" HeaderText="User Name" />
            <asp:BoundField DataField="Email" HeaderStyle-CssClass="Gridview-Header" ItemStyle-CssClass="Gridview-item" HeaderText="User Email" />
            <asp:CommandField ShowSelectButton="true" HeaderText="Select Account" HeaderStyle-CssClass="Gridview-Header" ItemStyle-CssClass="Gridview-item" />
        </Columns>
        </asp:GridView>
        <asp:GridView ID="GridView2" OnSelectedIndexChanging="GridView2_SelectedIndexChanging" CssClass="Gridview" Width="100%" runat="server">
            <Columns>
            <asp:CommandField ShowSelectButton="true" HeaderText="Select Account" HeaderStyle-CssClass="Gridview-Header" ItemStyle-CssClass="Gridview-item" />
            </Columns>
        </asp:GridView>
            </div>
        </section>

    
    
    <% } %>
    <% else
        { %>
        <h1> <strong> Sorry You Not Administration of this.. </strong> </h1>
    <%} %>
</asp:Content>
