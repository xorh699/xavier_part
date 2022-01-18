<%@ Page Title="" Language="C#" MasterPageFile="~/customer.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="xavier_part.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Poppins:300,400,700">
    <!-- Choices CSS-->
    <link rel="stylesheet" href="https://d19m59y37dris4.cloudfront.net/admin-premium/2-0/vendor/choices.js/public/assets/styles/choices.min.css">
    <!-- theme stylesheet-->
    <link rel="stylesheet" href="https://d19m59y37dris4.cloudfront.net/admin-premium/2-0/css/style.default.premium.2a30c8f8.css" id="theme-stylesheet">
    <!-- Custom stylesheet - for your changes-->
    <link rel="stylesheet" href="https://d19m59y37dris4.cloudfront.net/admin-premium/2-0/css/custom.0a822280.css">
    <!-- Favicon-->
    <link rel="shortcut icon" href="https://d19m59y37dris4.cloudfront.net/admin-premium/2-0/img/favicon.3903ee9d.ico">
    <link rel="stylesheet" href="css/home.css" />
   <div class="header" >
 
       <p>&nbsp;</p>
       <p>&nbsp;</p>
       <div class="headerbox" style="border:solid;margin-left:300px;margin-right:300px;padding:50px"> 
       <h1 style="font-size:50px;">Welcome to Kim Simi Zua</h1>
           <asp:Button ID="Button_shopnow" runat="server" Text="Shop Now" CssClass="btn btn-dark" style="scale:150%;" Height="50px" Width="100px" />
  
           </div>
       <br />
       <br />
       <br />
</div>
    <div class="popularproducts">
    <div>
        <center>
        <h1 style="font-size:50px; padding:50px;">Popular Products</h1>
            </center>
    </div>
    <center>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="Product_ID" DataSourceID="SqlDataSource1">
        <ItemTemplate>
           <div class="card" style="width:300px; height=100px; ">
               <asp:Image ID="Image1" runat="server" ImageUrl='<%# "/images/" + Eval("Product_Image") %>'   Height="300px" />
                    <div class="card-body">
                      <h5 class="card-title">
                          <asp:Label ID="Label1" runat="server" Text='<%# Eval("Product_Name") %>'></asp:Label></h5>
            
                        <p class="card-text">
                          <asp:Label ID="Label3" runat="server" Text='<%# Eval("Unit_Price", "{0:C}") %>'></asp:Label></p>
                        <a class="btn btn-primary" href="product_desc.aspx?id=<%#Eval("Product_ID")%>">View</a>
                      
                    </div>
                  </div>
                </div>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:product.mdf %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
   <asp:Button ID="ButtonViewProduct" runat="server" Text="View" CssClass="btn btn-dark" style="scale:150%;" Height="50px" Width="100px" />  
    </center>
    </div>
   
</asp:Content>