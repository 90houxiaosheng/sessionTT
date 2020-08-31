using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CratWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<string> cart = new List<string>();
                Session["cart"] = cart;
            }
            if (Session["CurrentUser"] != null)
            {
                this.ItaMsg.Text = "终于等到你 ❤ ： " + Session["CurrentUser"].ToString();
            }
            else
            {
                this.ItaMsg.Text = "请您先登录";
            }
        }

        protected void btnAddTocart_Click(object sender, EventArgs e)
        {
            if (Session["CurrentUser"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            else
            {
                foreach (Control item in form1.Controls)
                {
                    if (item is CheckBox)
                    {
                        CheckBox ckb = (CheckBox)item;
                        if (ckb.Checked)
                        {
                            // Session["cart"] 为object 类型 所以得转换成list
                            ((List<string>)Session["cart"]).Add(ckb.Text);
                        }
                    }
                }
            }

            this.btnAddTocart.Text = "添加成功";
        }

        protected void btnShowcart_Click(object sender, EventArgs e)
        {
            //首先判断用户是否登录
            if (Session["CurrentUser"] == null)
            {
                Response.Redirect("UserLogin.aspx");
            }
            //重定向
            Response.Redirect("ShopCart.aspx");
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {

            Session.Abandon();//清除Session
            this.ItaMsg.Text = "您还没有登录哟";
        }
    }
}