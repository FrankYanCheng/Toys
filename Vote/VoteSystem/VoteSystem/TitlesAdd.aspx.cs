using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;

public partial class TitlesAdd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 已登陆
        if (Session["admin"] != null)
        {
            if (!Page.IsPostBack)
            {
                 

            }

        }
        else
        {
            Response.Redirect("Admin.aspx");
        }
    }
    /// <summary>
    /// 添加主题
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btOk_Click(object sender, EventArgs e)
    {
        if (tbTitle.Text != "")
        {
            Titles title = new Titles();
            title.Title = tbTitle.Text.Trim();
            title.Summary = txtSummary.Text.Trim();
            if (new TitleDAO().InsertTitle(title))
            {
                Response.Write("<script language=javascript>alert( '添加成功！');window.location.href='AdminManager.aspx';</script>");
            }
        }
        else
        {
            Response.Write("<script language=javascript>alert( '信息不能为空！')</script>");
        }
    }
    protected void btAlterOk_Click(object sender, EventArgs e)
    {

    }
    
}