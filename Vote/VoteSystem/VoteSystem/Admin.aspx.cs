using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;
public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["admin"]!=null)
        {
            Response.Redirect("AdminManager.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string name = tbName.Text.Trim().ToString();
            string password = tbPassword.Text.Trim().ToString();
            Model.Manager manager = new Manager();
            manager.Pwd = password;
            manager.User = name;
            if (new ManagerDAO().IsAdministrator(manager))
            {
                Session["admin"] = name;
                Response.Redirect("AdminManager.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('登录失败，用户名或密码错误！');</script>");
                return;
            }
        }
        catch
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "message", "<script language='javascript' defer>alert('登录失败，用户名或密码错误！');</script>");
        }
    }
}