﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingCart : System.Web.UI.Page
{
    private double total = 0;
    private Boolean hasItem = false;
    static public string Order_List = "Cake Store \r\n";
    static string Seven_Eleven_Store_Address = "";
    protected void Page_Init(object sender, EventArgs e)
    {

        TextBox_Seven_Eleven_Address.Visible = false;
        // 宣告WHERE子句的IN條件 
        //  string Converted_string = HttpUtility.UrlEncode("商品編號");
        //  string where = "WHERE [Converted_string] IN (";

        string where = "WHERE [商品名稱] IN (";

        bool isFirst = true;
        // 取出所有Cookie
        foreach (string ProductItem in Request.Cookies)
        {
            // 是否是購物車的Cookie
            if (ProductItem.StartsWith("Cake Store"))
            {
                if (isFirst) // 第1次
                {

                    where += "'" + Request.Cookies[ProductItem]["Name"] + "'";
                    Order_List = "Cake Store";
                    isFirst = false;
                }
                else
                {
                    where += ", '" + Request.Cookies[ProductItem]["Name"] + "'";
                }
                hasItem = true;
            }
        }
        where += ")"; // 完成WHERE子句
        // 更改資料來源控制項的SELECT指令
        if (hasItem)
            SqlDataSource_購物車.SelectCommand += where;

        else
            SqlDataSource_購物車.SelectCommand += "WHERE [商品名稱] IN ('0000')";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["RefUrl"] = Request.UrlReferrer.ToString();
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int quantity;
        string 商品名稱 = Request.QueryString["商品名稱"];
        double subtotal, price;
        // 檢查是否是資料列
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // 指定數量
            Order_List += "\r\n";
            Order_List += " 商品名稱 " + e.Row.Cells[1].Text + " "; // Product Name
            //Order_List += " 商品編號 " + e.Row.Cells[2].Text + " "; // Product Number
            Order_List += " 商品售價 " + e.Row.Cells[2].Text + " "; // Product price
            //  Order_List += e.Row.Cells[4].Text + " "; // Product purchase amount
            e.Row.Cells[3].Text = Request.Cookies[("Cake Store" + e.Row.Cells[1].Text).Trim()]["Quantity"];
            price = Convert.ToDouble(e.Row.Cells[2].Text.Substring(3));
            quantity = Convert.ToInt32(e.Row.Cells[3].Text);
            Order_List += " 商品數量 " + quantity.ToString() + " \r\n"; // Product purchase amount
            subtotal = price * quantity;   // 小計
            total += subtotal;  // 計算總價
            e.Row.Cells[4].Text = subtotal.ToString("c");
        }
        if (e.Row.RowType == DataControlRowType.Footer)
        {

            e.Row.Cells[4].Text = total.ToString("c");
            Order_List += " \r\n 消費總金額 = " + total.ToString("c") + " "; // total purchase price

            Response.Cookies["P_List"].Value = Server.UrlEncode(Order_List);
            DateTime dtDay = DateTime.Today.AddDays(10);
            Response.Cookies["P_List"].Expires = dtDay;

        }
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int pos = 0;
        string Product_Name;
        if (e.CommandName == "DelItem")
        {
            pos = Convert.ToInt32(e.CommandArgument); // 

            Product_Name = GridView1.DataKeys[pos].Value.ToString();


            // 刪除Cookie
            Response.Cookies[("Cake Store" + Product_Name).Trim()].Expires = DateTime.Today.AddDays(-365);

            Response.Redirect("ShoppingCart.aspx");
        }
    }

    protected void RadioButtonList_物流方式_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (RadioButtonList_物流方式.SelectedIndex)
        {
            case 0:
                TextBox_Message_Box.Text = " 你選擇了 快遞 ! 送出訂單時 請記得填上送貨地址";
                break;
            case 1:
                TextBox_Message_Box.Text = " 你選擇了 自行取貨 ! 取貨地點為 中華科大實習商店";
                break;
            case 2:
                TextBox_Message_Box.Text = " 你選擇了 郵寄! 送出訂單時 請記得填上送貨地址";
                break;
            case 3:
                TextBox_Message_Box.Text = " 你選擇了 臨櫃取貨 ! 取貨地點為 中華科大實習商店";
                break;
            case 4:
                TextBox_Message_Box.Text = " 你選擇了 超商取貨 ! 請先使用下列超商連結 選擇取貨之超商地址 貼在下列 ";
                TextBox_Seven_Eleven_Address.Visible = true;
                break;
            default:
                break;
        }
    }

    protected void RadioButtonList_付款方式_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (RadioButtonList_付款方式.SelectedIndex)
        {
            case 0:
                TextBox_Message_Box.Text = " 你選擇了 信用卡支付 !";
                break;
            case 1:
                TextBox_Message_Box.Text = " 你選擇了 支付寶支付 ! 支付寶支付準備中!";
                break;
            case 2:
                TextBox_Message_Box.Text = " 你選擇了 跨境通支付 ! 跨境通支付準備中!";
                break;
            case 3:
                TextBox_Message_Box.Text = " 你選擇了 貨到付款 !";
                break;
            case 4:
                TextBox_Message_Box.Text = " 你選擇了 轉帳支付 ! 送出訂單時請填上轉帳帳號!";
                break;
            default:
                break;
        }
    }

    protected void Button_確認訂單_Click(object sender, EventArgs e)
    {
        Seven_Eleven_Store_Address = TextBox_Seven_Eleven_Address.Text.ToString();

        switch (RadioButtonList_付款方式.SelectedIndex)
        {
            case 0:
                {
                    Order_List += " 付款方式 : 信用卡支付";
                    break;
                }
            case 1:
                {
                    Order_List += " 付款方式 : 支付寶支付";
                    break;
                }
            case 2:
                {
                    Order_List += " 付款方式 : 跨境通支付";
                    break;
                }
            case 3:
                {
                    Order_List += " 付款方式 : 貨到付款";
                    break;
                }
            case 4:
                {
                    Order_List += " 付款方式 : 轉帳支付";
                    break;
                }
            default:
                {
                    break;
                }
        }
        switch (RadioButtonList_物流方式.SelectedIndex)
        {
            case 0:
                {
                    Order_List += " 物流方式 : 快遞";
                    break;
                }
            case 1:
                {
                    Order_List += " 物流方式 : 自行取貨";
                    break;
                }
            case 2:
                {
                    Order_List += " 物流方式 : 郵寄";
                    break;
                }
            case 3:
                {
                    Order_List += " 物流方式 : 臨櫃取貨";
                    break;
                }
            case 4:
                {
                    Order_List += " 物流方式 : 超商取貨";
                    Order_List += " 超商地址 : " + Seven_Eleven_Store_Address;
                    break;
                }
            default:
                {
                    break;
                }



        }
        TextBox_Seven_Eleven_Address.Text = " 取貨之超商地址";
        TextBox_Seven_Eleven_Address.Visible = false;
        Response.Redirect("Order.aspx?ShippingPayment=" + Server.UrlDecode(Order_List));
    }

    protected void Button_繼續購物_Click(object sender, EventArgs e)
    {
        object refUrl = ViewState["RefUrl"];
        if (refUrl != null)
            Response.Redirect((string)refUrl);

        //Response.Redirect(Request.UrlReferrer.ToString());
        //Response.Redirect("Default.aspx");
    }

   
}