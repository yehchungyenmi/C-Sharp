<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <div>
        <asp:Table ID="Table1" runat="server" class="col-md-12" BackColor="WhiteSmoke">
            <asp:TableRow runat="server" Height="150px">
            </asp:TableRow>
        </asp:Table>
    <div>
        <div class="row">
            <div class="col-md-12">
                <section id="Order_Form">
                    <div class="form-horizontal">

                        <h4 style="text-align: center">請輸入相關資料按確認訂單送出……</h4>
                        <hr />
                        <asp:Table ID="Table2" runat="server" HorizontalAlign="Center" Width="100%">
                            <asp:TableRow runat="server">
                                <asp:TableCell runat="server" HorizontalAlign="Center" Width="100%">
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="TextBox1" CssClass="col-md-5 control-label">購買者名稱</asp:Label>
                                        <div class="col-md-2">
                                            <asp:TextBox runat="server" ID="TextBox1" CssClass="form-control" TextMode="MultiLine" />
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox1"
                                                CssClass="text-danger" ErrorMessage="必須填寫購買者名稱欄位。" />
                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="TextBox2" CssClass="col-md-5 control-label">購買者地址</asp:Label>
                                        <div class="col-md-2">
                                            <asp:TextBox runat="server" ID="TextBox2" TextMode="MultiLine" CssClass="form-control" />
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox2"
                                                CssClass="text-danger" ErrorMessage="必須填寫購買者地址欄位。" />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="TextBox3" CssClass="col-md-5 control-label">購買者電子郵件</asp:Label>
                                        <div class="col-md-2">
                                            <asp:TextBox runat="server" ID="TextBox3" CssClass="form-control" TextMode="Email" />
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox3"
                                                CssClass="text-danger" ErrorMessage="必須填寫購買者電子郵件欄位。" />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:Label runat="server" AssociatedControlID="TextBox4" CssClass="col-md-5 control-label">購買者電話號碼</asp:Label>
                                        <div class="col-md-2">
                                            <asp:TextBox runat="server" ID="TextBox4" CssClass="form-control" TextMode="Number" />
                                            <asp:RequiredFieldValidator runat="server" ControlToValidate="TextBox4"
                                                CssClass="text-danger" ErrorMessage="必須填寫購買者電話號碼。" />
                                        </div>


                                    </div>

                                    <div class="form-group">
                                        <asp:Button ID="Button3" runat="server" Text="回首頁" OnClick="Button1_click" Width="200px" BackColor="#FF99FF" />
                                    </div>
                                    <div class="form-group">
                                        <asp:Button ID="Button2" runat="server" Text="確認訂單" OnClick="Button_確認訂單_Click" Width="200px" BackColor="#0099FF" />
                                       
                                    </div>
                                </asp:TableCell>
                            </asp:TableRow>
                        </asp:Table> 
                       
                    </div> 
                    <asp:Button ID="Button_確認訂單" runat="server" Text="確認訂單" OnClick="Button_確認訂單_Click" Width="200px" BackColor="#0099FF" />                   
                    <asp:Button ID="Button1" runat="server" Text="回首頁" OnClick="Button1_click" Width="200px" BackColor="#FF99FF" />
                    <p>
                    </p>

                </section>
            </div>
        </div>
</asp:Content>

