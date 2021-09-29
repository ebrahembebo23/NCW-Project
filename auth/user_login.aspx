<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="user_login.aspx.cs" Inherits="auth.user_login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
        <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>User Login Page</h2>
            </hgroup>
            
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel runat="server" ID="p1" GroupingText="User Login" BackColor="Aqua">
        <asp:Label ID="Label1" runat="server" Text="User Name: "></asp:Label>
        <asp:TextBox ID="txtun" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:Button ID="btnLog" runat="server" Text="Login" Font-Bold="true" Font-Size="Large" ForeColor="DarkBlue" OnClick="btnLog_Click" />

    </asp:Panel>
</asp:Content>
