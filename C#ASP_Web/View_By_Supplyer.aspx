<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="View_By_Supplyer.aspx.cs" Inherits="View_By_Supplyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <asp:Table ID="Table2" runat="server" class="col-md-12">
            <asp:TableRow runat="server" Height="150px" Style="background-color: aqua">
            </asp:TableRow>

        </asp:Table>
      
        <table class="col-md-12" >
           <tr>
                        <td style="width:10%;height:40px;background-color:#FFFFCC;vertical-align:top">
                         
                                
                              <H3> 請選擇廠商 : </H3>
                           
                             <asp:DropDownList ID="DropDownList_By_Supplyer" runat="server" Height="40px" Width="100%" 
                                 valign ="top"  AutoPostBack="True" DataSourceID="SqlDataSource_商品廠商" DataTextField="商品廠商" DataValueField="商品廠商" Font-Size="Large">                             
                             </asp:DropDownList>
                            
                        
                        </td>  
               </tr>
        </table>
         <table class="col-md-12" style="width: 100%; height:100%">           
            <tr>              
                <td  class="col-md-12">
                    <br />                   
                    <div class="wrap">
                        <asp:ListView ID="ListView2" runat="server" DataSourceID="SqlDataSource_廠商商品" GroupItemCount="4" Style="width: 100%" OnLoad="Page_Load">
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
                                        <asp:Label ID="商品售價_Label" runat="server" Font-Size="Medium" Text='<%# Eval("商品售價") %>'  Font-Italic="False" ForeColor="Red">>

                                        </asp:Label>
                                         原價  :
                                        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text='<%# Eval("商品原價") %>' ForeColor="Black">>

                                        </asp:Label>
                                        <br />                          
                                        <div style ="font-size:small">     
                                         簡介 :  <%# Eval("商品簡介") %>
                                        </div>
                                        <div class="titleBox">
                                           原價 : <%# Eval("商品原價") %>
                                        </div>
                                    </div>
                                </div>
                            </AlternatingItemTemplate>
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
                                        <asp:Label ID="商品售價_Label" runat="server" Font-Size="Medium" Text='<%# Eval("商品售價") %>' ForeColor="Red">>

                                        </asp:Label>
                                         原價  :
                                        <asp:Label ID="Label1" runat="server" Font-Size="Medium" Text='<%# Eval("商品原價") %>' ForeColor="Black">>

                                        </asp:Label>
                                        <br />
                                      
                                        <div style="Font-Size:small">   
                                          簡介 :  <%# Eval("商品簡介") %>
                                        </div>
                                        <div class="titleBox">
                                             原價 : <%# Eval("商品原價") %>
                                        </div>

                                    </div>
                                </div>
                            </ItemTemplate>
                            <GroupTemplate>
                                <div id="itemPlaceholderContainer" runat="server">
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </div>
                            </GroupTemplate>
                            <LayoutTemplate>
                                <div runat="server" class="wrap" id="groupPlaceholderContainer">
                                    <div class="box" id="groupPlaceholder" runat="server">
                                        <div class="boxInner">
                                            <div class="titleBox">
                                            </div>
                                        </div>
                                    </div>
                                </div>
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
    <asp:SqlDataSource ID="SqlDataSource_商品廠商" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT DISTINCT [商品廠商]  FROM [資料表1]">

    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource_廠商商品" runat="server"
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT DISTINCT * FROM [資料表1] WHERE [商品廠商] = @商品廠商">
          <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList_By_Supplyer"
                 Name="商品廠商" PropertyName="SelectedValue" Type="String" />
        </SelectParameters>

    </asp:SqlDataSource>
</asp:Content>

