<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Product_View.aspx.cs" Inherits="Product_View" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <div>
        <asp:Table ID="Table1" runat="server" Height="100px" BackColor="WhiteSmoke" Width="100%">
            <asp:TableRow runat="server" Height="100pt">
            </asp:TableRow>
        </asp:Table>
    </div>
    <div class="col-md-12" style="background-color:white">
        <asp:DetailsView ID="DetailsView3" runat="server" Height="50px" Width="100%" 
            AutoGenerateRows="False" DataSourceID="SqlDataSource_Detail_View" 
            BackColor="White" GridLines="None" Font-Size="Large">
            <Fields>
                <asp:BoundField DataField="商品名稱" HeaderText="商品名稱" SortExpression="商品名稱" />
            </Fields>

        </asp:DetailsView>
    </div>
    <div class="col-md-12" style="background-color:white">
        <div  class="col-md-1" style="background-color:white" >

        </div>
        <div class="col-md-4">
            <asp:DetailsView ID="DetailsView1" runat="server" Width="100%" height="100%" AutoGenerateRows="False" DataSourceID="SqlDataSource_Detail_View" BackColor="White" GridLines="None">
                <Fields>
                    <asp:ImageField DataImageUrlField="商品名稱" ControlStyle-Width="100%" 
                        DataImageUrlFormatString="~/images/{0}.jpg" HeaderText="" ReadOnly="true">
                    </asp:ImageField>
                </Fields>

            </asp:DetailsView>

        </div>
         <br /> 
        <div class="col-md-6">
            <asp:DetailsView ID="DetailsView2" runat="server" Height="100px" Width="100%" AutoGenerateRows="False" DataSourceID="SqlDataSource_Detail_View" BackColor="White" GridLines="None" Font-Size="Large">
                <Fields>
                    <asp:BoundField DataField="商品描述" HeaderText="商品描述" SortExpression="商品描述" ControlStyle-Height="500" ControlStyle-Width="500" ShowHeader="False" />
                </Fields>

            </asp:DetailsView>

        </div>
        <div class="col-md-1" style="background-color: white">
        </div>
    </div>
    <div>
        <asp:Table ID="Table2" runat="server" Height="10px" BackColor="Transparent" Width="100%">
            <asp:TableRow runat="server" Height="10pt">
            </asp:TableRow>
        </asp:Table>
    </div>
    <div>
        <p>產品的其他照片</p>
        <asp:Image ID="Image1" runat="server" Visible="False" CssClass="Other_Picture" />
        <asp:Image ID="Image2" runat="server" Visible="False" CssClass="Other_Picture" />
        <asp:Image ID="Image3" runat="server" Visible="False" CssClass="Other_Picture" />
        <br />
        <asp:Image ID="Image4" runat="server" Visible="False" CssClass="Other_Picture" />
        <asp:Image ID="Image5" runat="server" Visible="False" CssClass="Other_Picture" />
        <asp:Image ID="Image6" runat="server" Visible="False" CssClass="Other_Picture" />
        <br />
        <asp:Image ID="Image7" runat="server" Visible="False" CssClass="Other_Picture" />
        <asp:Image ID="Image8" runat="server" Visible="False" CssClass="Other_Picture" />
        <asp:Image ID="Image9" runat="server" Visible="False" CssClass="Other_Picture" />

    </div>
    <asp:Table ID="Table3" runat="server">
        <asp:TableRow runat="server" Type="Integer">
            <asp:TableCell runat="server">
                <asp:Label ID="Label1" runat="server" Text="請輸入購買數量"></asp:Label>
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:TextBox ID="txtbox_購買數量" runat="server" CssClass="text-center" Text="1" TextMode="Number">
                </asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="請輸入正確購買數量" 
                    MaximumValue="1000" MinimumValue="1" ControlToValidate="txtbox_購買數量" Type="Integer"></asp:RangeValidator>
            </asp:TableCell>
            <asp:TableCell runat="server"></asp:TableCell>
        </asp:TableRow>
     </asp:Table>
    <asp:Button ID="Button_加入購物車" runat="server" Text="加入購物車" OnClick="Button_加入購物車_Click" />
    <asp:SqlDataSource ID="SqlDataSource_Detail_View" 
        runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" 
        SelectCommand="SELECT [商品描述], [商品名稱], [商品編號] FROM [資料表1] WHERE ([商品名稱] = @商品名稱)">
         <SelectParameters>
            <asp:QueryStringParameter Name="商品名稱" QueryStringField="ID" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

</asp:Content>

