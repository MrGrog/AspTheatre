<%@ Page Title="Admin form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Theatre_test.Account.Admin" %>

<%@ Register assembly="Syncfusion.EJ.Web, Version=14.3460.0.49, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89" namespace="Syncfusion.JavaScript.Web" tagprefix="ej" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../Scripts/MyScripts/Admin.js"></script>
    
    <h1>
        Адміністратор
    </h1>
    
    <p>
               <ej:DateTimePicker ID="DateTimePicker1" runat="server">
</ej:DateTimePicker>
    </p>
    <p class="text-left">
        <asp:TextBox ID="TextBox1" runat="server" Text="назва вистави"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" Height="60px" Width="206px" Rows="4" TextMode="MultiLine">опис вистави</asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Actors" runat="server">Актори (потрібне відмітити)</asp:Label>
    </p>
    <p>
        <asp:CheckBoxList ID="ActorsCheck" runat="server" Height="62px" Width="341px" ></asp:CheckBoxList>
    </p>
    <p>
        <asp:Button ID="AddSpectacle" runat="server" Text="Додати виставу" CssClass="btn btn-default" OnClientClick="setspectacle()" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="message" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>