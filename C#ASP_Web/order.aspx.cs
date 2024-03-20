using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class order : System.Web.UI.Page
{
    string Purchase_List1 = "";
    string Payment_Shipping_Payment_Method = "";
    string Customer_Phone_Number = "";
    string Customer_Shipping_Address = "";
    static string Decoded_Purchase_List1 = "";
    string Temp_Order_Number = "";
    static string Order_Number = "";
    double Purchase_Amount = 0.0d;
    string Purchase_Amount_String = "";
    static string Order_String = "";
    string OrgOrderNumber = "";
    bool Pay_By_Credit_Card = false;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private string Generate_Order_String()
    {
        var chars = "0123456789";
        var stringChars = new char[8];
        var random = new Random();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }
        var finalString = new String(stringChars);
        return finalString;
    }

    List<string> enErrors = new List<string>();

    protected int Get_Purchase_Amount(string Purchase_Amount_string)
    {
        int Position_消費總金額 = Purchase_Amount_string.IndexOf("消費總金額");

        string[] Temp_Purchase_Amount = Purchase_Amount_string.Substring(Position_消費總金額).Split();
        string Amount_String = Temp_Purchase_Amount[2];
        Amount_String = Amount_String.Replace(",", "");
        Amount_String = Amount_String.Substring(3);
        Purchase_Amount = Convert.ToDouble(Amount_String);
        return (int)Purchase_Amount;
    }
    protected void Button_確認訂單_Click(object sender, EventArgs e)
    {

        if (Request.Cookies["P_List"] != null)
        {
            Purchase_List1 = Request.Cookies["P_List"].Value;
            Payment_Shipping_Payment_Method = Request.QueryString["ShippingPayment"];
        }
        // string Purchase_List2 = Server.UrlDecode(Request.QueryString["Purchase_List"]); 
        // Purchase_List3 = Server.UrlDecode(Request.QueryString["Purchase_List"]);


        // TextBox Previous_Textbox = new TextBox();
        //    Previous_Textbox = (TextBox)PreviousPage.FindControl("TextBox_Pruchase_List");
        //    string Purchase_List3 = Previous_Textbox.Text;
        Customer_Phone_Number = TextBox4.Text.ToString();
        Customer_Shipping_Address = TextBox2.Text.ToString();
        MailMessage msg = new MailMessage();
        msg.SubjectEncoding = System.Text.Encoding.UTF8;
        msg.BodyEncoding = System.Text.Encoding.UTF8;//郵件內容編碼 
        // send order to shipping department
        msg.From = new MailAddress(TextBox3.Text.ToString(), "確認訂單", System.Text.Encoding.UTF8);
        msg.To.Add("kentsun0401@gmail.com");
        msg.Subject = "確認訂單 : " + TextBox1.Text.ToString();
        Decoded_Purchase_List1 = Server.UrlDecode(Purchase_List1);
        Decoded_Purchase_List1 += Payment_Shipping_Payment_Method;
        Decoded_Purchase_List1 += " 購買者電話號碼 : " + Customer_Phone_Number;
        Decoded_Purchase_List1 += " 購買者地址 : " + Customer_Shipping_Address;
        Temp_Order_Number = DateTime.Now.ToString();
        Temp_Order_Number = Temp_Order_Number.Replace(":", "");
        Order_String = Generate_Order_String();
        Order_Number = "Order_" + Order_String;
        Decoded_Purchase_List1 += " 訂單編號 " + Order_Number;
        Purchase_Amount = Get_Purchase_Amount(Decoded_Purchase_List1);
        Purchase_Amount_String = Convert.ToInt32(Purchase_Amount).ToString();
        Session["Purchase_Amount"] = Purchase_Amount;
        Session["Order_String"] = Order_String;
        // Pay_By_Credit_Card = Check_Pay_By_Credit_Card();
        // Response.Redirect("http://192.192.231.43/mPP_NPM.aspx?Order_Amount=" + Purchase_Amount_String + "&Order_String=" + Order_String);
        // Response.Redirect("Finish.cshtml?quid=" + quid + "&quod=" + quod);
        msg.Body = Decoded_Purchase_List1;
        //  msg.IsBodyHtml = true;     
        msg.Priority = MailPriority.Normal;//郵件優先級 
        SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);

        //telnet smtp.gmail.com 587
        //設定你的帳號密碼
        MySmtp.Credentials = new System.Net.NetworkCredential("kentsun0401@gmail.com", "victoria2");
        //Gmial 的 smtp 使用 SSL
        MySmtp.EnableSsl = true;
        //MySmtp.Send(msg);

        //send order message to buyer
        msg.From = new MailAddress("yehchungyen@gmail.com", "確認訂單", System.Text.Encoding.UTF8);
        msg.To.Add(TextBox3.Text.ToString());
        msg.Subject = "確認訂單 : " + TextBox1.Text;

        msg.Body = Decoded_Purchase_List1;
        //  msg.IsBodyHtml = true;     
        msg.Priority = MailPriority.Normal;//郵件優先級 
        //設定你的帳號密碼
        MySmtp.Credentials = new System.Net.NetworkCredential("yehchungyen@gmail.com", "yeh500721");
        //Gmial 的 smtp 使用 SSL

        // MySmtp.Send(msg);
        MySmtp.Dispose();
        // Update_Order_DataBase();
        try
        {

            if (Pay_By_Credit_Card)
            {
                Response.Redirect("http://192.192.231.43/Credit_Card_Process/AioCheckOut.aspx?Order_Amount=" + Purchase_Amount_String + "&Order_Content=中華科大電商網&Order_Number=" + Order_String);
                // Response.Redirect(String.Format("http://192.192.231.43/Credit_Card_Process/AioCheckOut.aspx?Order_Amount={0}&Order_Content={1}&Order_Number={2}", Purchase_Amount_String, Server.UrlEncode(Decoded_Purchase_List1), Server.UrlEncode(Order_String))); //Green Tech                                                                                                                                                                                                                                                                      //Response.Redirect("http://192.192.231.43/mPP_NPM/shop.aspx?Order_Amount=" + Purchase_Amount_String + "&Order_String=" + Order_String); //藍新
                // Response.Redirect("http://192.192.231.43/Credit_Card_Process/AioCheckOut.aspx?Order_Amount=Purchase_Amount_String&Order_Content=Server.UrlEncode(Decoded_Purchase_List1)&Order_Number=Order_String");                                                                                                                                                                                                                                                                     //Response.Redirect(String.Format("http://192.192.231.43/AioCheckOut/AioCheckOut.aspx?Order_Amoun={0}&Order_Content={1}&Order_Number={2}", Purchase_Amount_String, Server.UrlEncode(Decoded_Purchase_List1), Server.UrlEncode(Order_String)));                                                                                                                                                                                                                                                                      //Response.Redirect("http://192.192.231.43/AioCheckOut/AioCheckOut.aspx?Order_Amount="+ Purchase_Amount_String+"&Order_Content="+Decoded_Purchase_List1+ "&Order_Number=" + Order_String                                                                                                                                                                                                                                                                      // Response.Redirect("Default.aspx");
            }
        }
        catch (Exception EX)
        {
            enErrors.Add(EX.Message);
        }
        Response.Write("<script type=\"text/javascript\">alert('感謝您使用平台本! 您的訂單編號為 " + Order_Number + ".');location.href='Default.aspx'</script>");

    }
    protected void Button1_click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}