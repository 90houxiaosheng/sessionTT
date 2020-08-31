using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ShopCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //取出对象集合，遍历后显示
            List<string> cart = (List<string>)Session["cart"];
            string info = string.Empty;
            foreach (string item in cart)
            {
                info += item + " ";
            }
            Response.Write("您选得商品为：" + info + "<br/>");

        }
    }
}