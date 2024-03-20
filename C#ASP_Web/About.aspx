<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Table ID="Table1" runat="server" BackColor="White" Width="100%">
            <asp:TableRow runat="server" Height="150px" >                
            </asp:TableRow>
            
        </asp:Table>
        <asp:Label runat="server" Text="這是在中華科大，葉宗宴寫的店子商務平台。歡迎光臨!" BorderStyle="Double" Font-Italic="true">

            </asp:Label>
    </div>
    <div>
        <asp:ListView ID="ListView_Product" runat="server">
        </asp:ListView>
    </div>
    <asp:SqlDataSource ID="SqlDataSource_Product" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [商品原價], [商品名稱], [商品售價], [商品簡介] FROM [資料表1]"></asp:SqlDataSource>
</asp:Content>
