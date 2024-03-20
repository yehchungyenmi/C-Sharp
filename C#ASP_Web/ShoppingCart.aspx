<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
        <asp:table id="Table2" runat="server" class="col-md-12">
            <asp:tablerow runat="server" height="120px">
            </asp:tablerow>
 
        </asp:table>
        <div style="text-align: center">
            <h1>中華科大電商網 </h1>
        </div>
        <div class="col-md-10">
            <asp:textbox id="TextBox1" runat="server" style="text-align: center" text="中華科大電商網購物明細：" font-size="large" forecolor="Blue" width="100%">
 
            </asp:textbox>
        </div>
    <br />
    <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="2" DataKeyNames="商品名稱" DataSourceID="SqlDataSource_購物車" 
            GridLines="None" Width="100%" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" OnRowCommand="GridView1_RowCommand" BackColor="LightGoldenrodYellow"
            bordercolor="Tan" BorderWidth="1px" ForeColor="Black" AllowPaging="True">
            <EmptyDataTemplate>
                No selected Item
            </EmptyDataTemplate>
            <FooterStyle BackColor="Tan"></footerstyle>
            <Columns>
                <asp:buttonfield buttontype="Button" headertext="刪除" text="刪除" itemstyle-horizontalalign="Center" headerstyle-horizontalalign="Center" commandname="DelItem"> </asp:buttonfield>
               
                <asp:boundfield datafield="商品名稱" headertext="商品名稱" itemstyle-horizontalalign="Center" headerstyle-horizontalalign="Center" sortexpression="商品名稱"></asp:boundfield>
                <asp:boundfield datafield="商品售價" dataformatstring="{0:c}" headertext="商品售價" itemstyle-horizontalalign="Center" headerstyle-horizontalalign="Center" sortexpression="商品售價"></asp:boundfield>
                <asp:templatefield headertext="數量"> </asp:templatefield>
                <asp:templatefield headertext="小計"></asp:templatefield> 

            </Columns>       
            <pagerstyle backcolor="PaleGoldenrod" forecolor="DarkSlateBlue" horizontalalign="Center" > </pagerstyle>
            <selectedrowstyle backcolor="DarkSlateBlue" forecolor="GhostWhite" > </selectedrowstyle>
            <headerstyle backcolor="Tan" font-bold="True"></headerstyle>
            <alternatingrowstyle backcolor="PaleGoldenrod"></alternatingrowstyle>
            <sortedascendingcellstyle backcolor="#FAFAE7"></sortedascendingcellstyle>
            <sortedascendingheaderstyle backcolor="#DAC09E"></sortedascendingheaderstyle>
            <sorteddescendingcellstyle backcolor="#E1DB9C"></sorteddescendingcellstyle>
            <sorteddescendingheaderstyle backcolor="#C2A47B"></sorteddescendingheaderstyle>
          </asp:gridview>
    
    <div style="text-align: center">
            <h1>請選擇物流方式</h1>
        <asp:RadioButtonList ID="RadioButtonList_物流方式" runat="server" AutoPostBack="true" Font-Size="Medium" OnSelectedIndexChanged="RadioButtonList_物流方式_SelectedIndexChanged" RepeatLayout="Flow" >
            <asp:ListItem Selected="True">快遞取貨</asp:ListItem>
            <asp:ListItem>自行取貨</asp:ListItem>
            <asp:ListItem>郵寄取貨</asp:ListItem>
            <asp:ListItem>臨櫃取貨</asp:ListItem>
            <asp:ListItem>超商取貨</asp:ListItem>
        </asp:RadioButtonList>
             
 
             
 
             
 
            <div>
                <asp:textbox id="TextBox_Message_Box" runat="server" width="100%" textmode="MultiLine">
 
                </asp:textbox>
                 
 
                <asp:textbox id="TextBox_Seven_Eleven_Address" runat="server" width="100%" textmode="MultiLine" visible="False">取貨之超商地址</asp:textbox>
            </div>
             
 
             
 
             
 
            <div>
                <asp:panel id="Panel1" runat="server" width="100%">
                    <a href="https://emap.pcsc.com.tw/" target="_blank" style="color: green">7-11門市查詢</a> |
              <a href="http://www.family.com.tw/marketing/inquiry.aspx" style="color: green" target="_blank">全家門市查詢</a>
                     
 
 
                </asp:panel>
            </div>
            <h1>請選擇付款方式</h1>
        <asp:RadioButtonList ID="RadioButtonList_付款方式" runat="server" autopostback="True" font-size="Medium" OnSelectedIndexChanged="RadioButtonList_付款方式_SelectedIndexChanged" repeatlayout="Flow">
            <asp:ListItem>信用卡支付</asp:ListItem>
            <asp:ListItem>支付寶支付</asp:ListItem>
            <asp:ListItem>跨境通支付</asp:ListItem>
            <asp:ListItem Selected="True" >貨到付款</asp:ListItem>
            <asp:ListItem>轉帳支付: 帳號 -> 郵政劃撥儲金帳戶 19207275</asp:ListItem>
        </asp:RadioButtonList>
        </div>
        <div class="col-md-12" style="text-align: center;">
            <asp:table id="Table1" runat="server" horizontalalign="Center" width="100%">
                <asp:tablerow runat="server" horizontalalign="Center">
                    <asp:tablecell runat="server" horizontalalign="Center">
                        <div class="form-group">
                            <asp:Button ID="Button_確認訂單" runat="server" Text="確認訂單" OnClick="Button_確認訂單_Click" Width="209px" BackColor="#0099FF">
                            </asp:button>
                           </div>
                        <div class="form-group">
                            <asp:Button ID="Button_繼續購物" runat="server" Text="繼續購物" onclick="Button_繼續購物_Click" Width="200px" BackColor="#FF99FF">
                            </asp:button>
                            
                        </div>
 
                    </asp:tablecell>
                </asp:tablerow>
            </asp:table>
        </div>
    <asp:SqlDataSource ID="SqlDataSource_購物車" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
        ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>"
        SelectCommand="SELECT [商品名稱], [商品售價] FROM [資料表1]"></asp:SqlDataSource>
           
        

</asp:Content>

