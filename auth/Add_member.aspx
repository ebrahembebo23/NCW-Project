<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add_member.aspx.cs" Inherits="auth.Add_member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <link href="Content/Site.css" rel="stylesheet" />
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h2>اضافة عضو او ادمن</h2>
            </hgroup>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:Panel runat="server" ID="pl1" GroupingText="اضافة عضو" Direction="RightToLeft">
        <asp:Label ID="Label1" runat="server" Text="الكود: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUn" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="اسم المستخدم: "></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPass" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="كلمة المرور: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRole" runat="server"></asp:TextBox><br />
        <asp:Label ID="Label4" runat="server" Text="الدور: "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnAdd" runat="server" Text="اضافة" class="btn btn-primary btn-block btn-flat" OnClick="btnAdd_Click"/>
    </asp:Panel>
</asp:Content>
