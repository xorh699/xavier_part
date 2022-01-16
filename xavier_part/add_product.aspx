<%@ Page Title="" Language="C#" MasterPageFile="~/customer.Master" AutoEventWireup="true" CodeBehind="add_product.aspx.cs" Inherits="xavier_part.add_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
            Product Id&nbsp;&nbsp;
            <asp:TextBox ID="tb_ProductID" runat="server"></asp:TextBox>
            <br />
            Product Name<asp:TextBox ID="tb_ProductName" runat="server"></asp:TextBox>
            <br />
            Product Description<asp:TextBox ID="tb_ProductDesc" runat="server"></asp:TextBox>
            <br />
            Unit Price<asp:TextBox ID="tb_UnitPrice" runat="server"></asp:TextBox>
            <br />
            Stock Level
            <asp:TextBox ID="tb_StockLevel" runat="server"></asp:TextBox>
            <br />
            Product Image<<asp:Label ID="lbl_Result" runat="server" Text="Label"></asp:Label>>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            Supplier Name
            <asp:Button ID="btn_Insert" runat="server" OnClick="btn_Insert_Click" Text="Insert" />
</asp:Content>
