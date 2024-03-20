<%@ Page Title="首頁" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div style="text-align: center">
            <asp:Label ID="Label3" runat="server" Text="Welcome! Pick one We delivery" Font-Size="XX-Large" ForeColor="#FFCC99" BorderStyle="Double" Font-Underline="True"></asp:Label>
        </div>
        <asp:Table ID="Table1" runat="server" Height="150px" BackColor="WhiteSmoke" Width="100%">

            <asp:TableRow runat="server" Height="100pt">
            </asp:TableRow>
        </asp:Table>
        <div>
        <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>

   <script src="js/jquery.slides.min.js"></script>
  <div id="myCarousel" class="carousel slide" data-ride="carousel" style="width: 80%; height:auto; margin: 0 auto">
    <!-- Indicators -->
    <ol class="carousel-indicators">
      <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
      <li data-target="#myCarousel" data-slide-to="1"></li>
      <li data-target="#myCarousel" data-slide-to="2"></li>
      <li data-target="#myCarousel" data-slide-to="3"></li>
      <li data-target="#myCarousel" data-slide-to="4"></li>
      <li data-target="#myCarousel" data-slide-to="5"></li>
      <li data-target="#myCarousel" data-slide-to="6"></li>
      <li data-target="#myCarousel" data-slide-to="7"></li>
      <li data-target="#myCarousel" data-slide-to="8"></li>
      <li data-target="#myCarousel" data-slide-to="9"></li>
      <li data-target="#myCarousel" data-slide-to="10"></li>
      <li data-target="#myCarousel" data-slide-to="11"></li>
    </ol>

    <!-- Wrapper for slides -->
      <div class="carousel-inner">
          <div class="item active">
              <img src="Slide_Picture/Slide_6.jpg" alt="Los Angeles" style="width: 100%">
               <div class="carousel-caption d-none d-md-block">
                    <h5 style="color: #800000"> 翠華會館 </h5>
                    <p style="color: #00FFFF; font-size: medium;">中華科大電商網 </p>
                </div>
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_1.jpg" alt="Chicago" style="width: 100%;">
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_10.jpg" alt="New york" style="width: 100%;">
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_2.jpg" alt="New york" style="width: 100%;">
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_3.jpg" alt="New york" style="width: 100%;">
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_4.jpg" alt="New york" style="width: 100%;">
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_9.jpg" alt="New york" style="width: 100%;">
          </div>
           <div class="item">
              <img src="Slide_Picture/Slide_11.jpg" alt="New york" style="width: 100%;">
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_12.jpg" alt="New york" style="width: 100%;">
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_13.jpg" alt="New york" style="width: 100%;">
          </div>
          <div class="item">
              <img src="Slide_Picture/Slide_14.jpg" alt="New york" style="width: 100%;">
          </div>
      </div>

    <!-- Left and right controls -->
    <a class="left carousel-control" href="#myCarousel" data-slide="prev">
      <span class="glyphicon glyphicon-chevron-left"></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#myCarousel" data-slide="next">
      <span class="glyphicon glyphicon-chevron-right"></span>
      <span class="sr-only">Next</span>
    </a>
  </div>
    </div>
        </div>
    <div>

        <table class="col-md-12" style="width: 100%; height: 100%">
            <tr>
                <td class="col-md-12">
                    <br />
                    <div class="wrap">
                        <asp:ListView ID="Listview_product" runat="server" DataSourceID="SqlDataSource_Product" GroupItemCount="4">
                            <AlternatingItemTemplate>
                                <div class="box">
                                    <div class="boxInner">
                                        <a href='<%# Eval("商品名稱", "Product_View.aspx?Id={0}") %>'>
                                            <asp:Image ID="Image_商品圖片" runat="server" ImageAlign="middle"
                                                ImageUrl='<%# Eval("商品名稱", "~/images/{0}.jpg") %>' CssClass="img" />
                                        </a>
                                        <asp:Label ID="商品名稱_Label" runat="server" Font-Size="small" role="menuitem" Text='<%# Eval("商品名稱") %>'>

                                        </asp:Label>
                                        <br />
                                        特價  :
                                        <asp:Label ID="商品售價_Label" runat="server" Font-Size="Medium" Text='<%# Eval("商品售價") %>' Font-Italic="False" ForeColor="Red">>

                                        </asp:Label>
                                        原價  :
                                        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text='<%# Eval("商品原價") %>' ForeColor="Black">>

                                        </asp:Label>
                                        <br />
                                        <div style="font-size: small">
                                            簡介 :  <%# Eval("商品簡介") %>
                                        </div>
                                        <div class="titleBox">
                                        </div>
                                    </div>
                                </div>
                            </AlternatingItemTemplate>
                            <EmptyDataTemplate>
                                <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                                    <tr>
                                        <td>NO PRODUCT。</td>
                                    </tr>
                                </table>
                            </EmptyDataTemplate>
                            <EmptyItemTemplate>
                                <td runat="server" />
                            </EmptyItemTemplate>
                            <GroupTemplate>
                                <tr id="itemPlaceholderContainer" runat="server">
                                    <td id="itemPlaceholder" runat="server"></td>
                                </tr>
                            </GroupTemplate>
                            <ItemTemplate>
                                <div class="box">
                                    <div class="boxInner">
                                        <a href='<%# Eval("商品名稱", "Product_View.aspx?Id={0}") %>'>
                                            <asp:Image ID="Image_商品圖片" runat="server" ImageAlign="middle"
                                                ImageUrl='<%# Eval("商品名稱", "~/images/{0}.jpg") %>' CssClass="img" />
                                        </a>
                                        <asp:Label ID="商品名稱_Label" runat="server" Font-Size="small" role="menuitem" Text='<%# Eval("商品名稱") %>'>

                                        </asp:Label>
                                        <br />
                                        特價  :
                                        <asp:Label ID="商品售價_Label" runat="server" Font-Size="Medium" Text='<%# Eval("商品售價") %>' Font-Italic="False" ForeColor="Red">>

                                        </asp:Label>
                                        原價  :
                                        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text='<%# Eval("商品原價") %>' ForeColor="Black">>

                                        </asp:Label>
                                        <br />
                                        <div style="font-size: small">
                                            簡介 :  <%# Eval("商品簡介") %>
                                        </div>
                                        <div class="titleBox">
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                            <LayoutTemplate>
                                <div runat="server" class="wrap" id="groupPlaceholderContainer">
                                    <div class="box" id="groupPlaceholder" runat="server">
                                        <div class="boxInner">
                                            <div class="img">
                                            </div>
                                            <div class="titleBox">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <asp:Table ID="Table1" runat="server" Height="10px" BackColor="Transparent" Width="100%">

                                    <asp:TableRow runat="server" Height="10px">
                                    </asp:TableRow>
                                </asp:Table>
                                <div style="text-align: center">
                                    <asp:DataPager ID="DataPager1" runat="server" PageSize="18">
                                        <Fields>
                                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True"
                                                ShowLastPageButton="True" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                            </LayoutTemplate>
                        </asp:ListView>
                    </div>

                </td>
            </tr>
        </table>

    </div>
    
    <asp:SqlDataSource ID="SqlDataSource_Product" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT [商品名稱], [商品售價], [商品簡介], [商品原價] FROM [資料表1]"></asp:SqlDataSource>

</asp:Content>
