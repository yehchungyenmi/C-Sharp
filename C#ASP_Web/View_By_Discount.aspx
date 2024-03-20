<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="View_By_Discount.aspx.cs" Inherits="View_By_Discount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

<div>
        <asp:Table ID="Table1" runat="server" class="col-md-12" BackColor="White" Width="100%">
            <asp:TableRow runat="server" Height="100px">
            </asp:TableRow>

        </asp:Table>
    </div>
    <div>
        <table class="col-md-12" style="width: 100%; height: 100%">
            <tr>
                <td class="col-md-12">
                    <br />
                    <div class="wrap">
                        <asp:ListView ID="ListView_產品" runat="server" DataSourceID="SqlDataSource_產品" GroupItemCount="4">
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
                                        <td>無選定產品。</td>
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
                                <asp:Table ID="Table2" runat="server" class="col-md-12" BackColor="White" Width="100%">
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

     <asp:SqlDataSource ID="SqlDataSource_產品" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT * FROM [資料表1]  WHERE(商品折數) > 0">

    </asp:SqlDataSource>

</asp:Content>