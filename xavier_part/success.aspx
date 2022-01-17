<%@ Page Title="" Language="C#" MasterPageFile="~/customer.Master" AutoEventWireup="true" CodeBehind="success.aspx.cs" Inherits="xavier_part.success" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <head>
    <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:400,400i,700,900&display=swap" rel="stylesheet">
        <link href="css/successpage.css" rel="stylesheet"/>
</head>
<style>

</style>
<body>
    <div class="card">
        <div style="border-radius:200px; height:200px; width:200px; background: #F8FAF5; margin:0 auto;">
            <i class="checkmark">✓</i>
        </div>
        <h1>Success</h1>
        <p>We received your purchase request;<br /> we'll be in touch shortly!</p>
         <asp:Button ID="Button_shopnow" runat="server" Text="Home" CssClass="btn btn-dark" style="scale:150%;" Height="50px" Width="100px" OnClick="Button_shopnow_Click" />
    </div>
</body>
</html>
</asp:Content>
