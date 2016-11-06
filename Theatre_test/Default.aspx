<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Theatre_test._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p class="text-left">
        <asp:Label ID="Label1" runat="server" Text="name" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Visible="False" CssClass="label-default"></asp:TextBox>
</p>
    <p class="text-left">
        <asp:Label ID="Label2" runat="server" Text="surname" Visible="False" ></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Visible="False" CssClass="label-default"></asp:TextBox>
    <br />
</p>
    
    <p class="text-left">
        <asp:Label ID="Label3" runat="server" Text="e-mail"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="label-primary"></asp:TextBox>
    <br />
</p>
    <p class="text-left">
        <asp:Label ID="Label4" runat="server" Text="password"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" CssClass="label-primary"></asp:TextBox>
    <br />
</p>
    <p class="text-left">
        <asp:Label ID="Label5" runat="server" Text="repeat password" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" Visible="False" CssClass="label-warning"></asp:TextBox>
    <br />
</p>
    <p class="text-left">
        <asp:Label ID="Label6" runat="server" Text="address" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" Visible="False" CssClass="label-primary"></asp:TextBox>
    <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="registration" CssClass="btn-danger" />
</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="come in" CssClass="btn-primary" />
</p>
    <p>
        <asp:Label ID="Label7" runat="server">State: </asp:Label>
    <br />
</p>

</asp:Content>
