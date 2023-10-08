<%@ Page Title="Calculator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebDevelopment_project.Calculator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="html">
    <div class="calculator card">
        <asp:TextBox ID="Screen" runat="server" type="text" CssClass="calculator-screen z-depth-1" value=""> </asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" type="text" CssClass="calculator-op z-depth-1" value=""> </asp:TextBox>
    <div class="calculator-keys">
        <asp:Button ID="plus" runat="server" type="button" CssClass =" button operator btn btn-info" Text="+"  value="+" OnClick="plus_Click"></asp:Button>
        <asp:Button ID="minus" type="button" runat="server" CssClass=" button operator btn btn-info" Text="-" value="-" OnClick="minus_Click"></asp:Button>
        <asp:Button ID="mul" type="button" runat="server" CssClass ="operator button btn btn-info" Text="*" value="*" OnClick="mul_Click"></asp:Button>
        <asp:Button ID="div" type="button" runat="server" CssClass="operator btn button btn-info" Text="/" value="/" OnClick="div_Click"></asp:Button>

        <asp:Button ID="seven" type="button" runat="server" Text="7" value="7" CssClass =" button btn btn-light waves-effect" OnClick="seven_Click"></asp:Button>
        <asp:Button ID="eigth" type="button" runat="server" Text="8" value="8" CssClass =" button btn btn-light waves-effect" OnClick="eigth_Click"></asp:Button>
        <asp:Button ID="nine" type="button" runat="server" Text="9" value="9" CssClass=" button btn btn-light waves-effect" OnClick="nine_Click"></asp:Button>


        <asp:Button ID="four" type="button" runat="server" Text="4" value="4" CssClass =" button btn btn-light waves-effect" OnClick="four_Click"></asp:Button>
        <asp:Button ID="five" type="button" runat="server" Text="5" value="5" CssClass =" button btn btn-light waves-effect" OnClick="five_Click"></asp:Button>
        <asp:Button ID="six" type="button" runat="server" Text="6" value="6" CssClass ="btn button btn-light waves-effect" OnClick="six_Click"></asp:Button>


        <asp:Button ID="one" type="button" runat="server" Text="1" value="1" CssClass ="btn btn-light button waves-effect" OnClick="one_Click"></asp:Button>
        <asp:Button ID="two" type="button" runat="server" Text="2" value="2" CssClass ="btn btn-light button waves-effect" OnClick="two_Click"></asp:Button>
        <asp:Button ID="three" type="button" runat="server" Text="3" value="3" CssClass ="btn btn-light button waves-effect" OnClick="three_Click"></asp:Button>


        <asp:Button ID="zero" type="button" runat="server" Text="0" value="0" CssClass ="btn btn-light button waves-effect" OnClick="zero_Click"></asp:Button>
        <asp:Button ID="dot" type="button" runat="server" Text="." CssClass ="decimal function btn btn-secondary button" value="." OnClick="dot_Click"></asp:Button>
        <asp:Button ID="clear" type="button" runat="server" Text="AC" CssClass ="all-clear function btn btn-danger btn-sm button" value="all-clear" OnClick="clear_Click"></asp:Button>

        <asp:Button ID="equal" type="button" runat="server" Text="=" CssClass ="equal-sign button operator btn btn-default btn-light" value="=" OnClick="equal_Click"></asp:Button>
  </div>
        <asp:Label ID="Label1" runat="server" CssClass="Name" Text="Made By: Rahul Saini(21BCA1953)"></asp:Label>
</div>
    </section>
</asp:Content>
