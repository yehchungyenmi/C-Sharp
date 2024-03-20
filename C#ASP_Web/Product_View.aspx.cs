using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Product_View : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            string Picture_Directory = Request.QueryString["ID"];


            int i = 1;
            try
            {
                DirectoryInfo dirs = new DirectoryInfo(Server.MapPath("~/images" + "/" + Picture_Directory));

                //html = dirs.GetFiles("*.jpg").Count().ToString();

                foreach (FileInfo s in dirs.GetFiles("*.jpg"))
                {
                    string Product_Image_Path = "~/images" + "/" + Picture_Directory + "/" + s.ToString();
                    if (i == 1)
                    {
                        Image1.ImageUrl = Product_Image_Path;
                        Image1.Visible = true;
                    }
                    if (i == 2)
                    {
                        Image2.ImageUrl = Product_Image_Path;
                        Image2.Visible = true;
                    }
                    if (i == 3)
                    {
                        Image3.ImageUrl = Product_Image_Path;
                        Image3.Visible = true;
                    }
                    if (i == 4)
                    {
                        Image4.ImageUrl = Product_Image_Path;
                        Image4.Visible = true;
                    }
                    if (i == 5)
                    {
                        Image5.ImageUrl = Product_Image_Path;
                        Image5.Visible = true;
                    }
                    if (i == 6)
                    {
                        Image6.ImageUrl = Product_Image_Path;
                        Image6.Visible = true;
                    }
                    if (i == 7)
                    {
                        Image7.ImageUrl = Product_Image_Path;
                        Image7.Visible = true;
                    }
                    if (i == 8)
                    {
                        Image8.ImageUrl = Product_Image_Path;
                        Image8.Visible = true;
                    }
                    if (i == 9)
                    {
                        Image9.ImageUrl = Product_Image_Path;
                        Image9.Visible = true;
                    }
                    i++;

                    //                 //dr["Image_URL"] = Product_Image_Path; 
                }
            }
            catch (Exception EX)
            {
                //Response.Write(EX.ToString()); // No Other Pictures
            }
        }
    }

    protected void Button_加入購物車_Click(object sender, EventArgs e)
    {
        string 商品名稱 = Request.QueryString["ID"];
        if(Request.Cookies["Cake Store" + 商品名稱] !=null)
        {
            int quantity = Convert.ToInt32(Request.Cookies["Cake Store" + 商品名稱]["Quantity"]);
            quantity += Convert.ToInt32(txtbox_購買數量.Text);
            Request.Cookies["Cake Store" + 商品名稱]["Quantity"] = quantity.ToString();
        }
        else
        {
            Response.Cookies["Cake Store" + 商品名稱]["Name"] = 商品名稱;
            Response.Cookies["Cake Store" + 商品名稱]["Quantity"] = txtbox_購買數量.Text;
        }
        Response.Cookies["Cake Store" + 商品名稱].Expires = DateTime.Today.AddDays(10);
        Response.Redirect("ShoppingCart.aspx?商品名稱=" + 商品名稱);
    }
}