<%@ Page Title="log in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="auth.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>log in form</h2>
            </hgroup>
            
        </div>
    </section>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Login ID="Login1" runat="server" UserNameRequiredErrorMessage="error username!" PasswordRequiredErrorMessage="Error Password!" OnAuthenticate="Login1_Authenticate">
        <TextBoxStyle  BackColor="Snow" BorderColor="WhiteSmoke" BorderWidth="6" BorderStyle="Double" Font-Bold="true" Font-Italic="false" Font-Strikeout="false"/>
        <LoginButtonStyle BackColor="SkyBlue" ForeColor="Tomato" BorderStyle="Double"/>
        
    </asp:Login>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"></asp:DropDownList>
      
</asp:Content>
