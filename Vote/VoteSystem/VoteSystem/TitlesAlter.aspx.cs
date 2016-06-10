using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;

public partial class TitlesAlter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 已登陆
        if (Session["admin"] != null)
        {
            if (!Page.IsPostBack)
            {

                this.listPart.DataTextField = "Title";
                this.listPart.DataSource = new TitleDAO().SelectTitles();
                this.listPart.DataBind();

            }

        }
        else
        {
            Response.Redirect("Admin.aspx");
        }
    }
    /// <summary>
    /// 修改主题
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btAlterOk_Click(object sender, EventArgs e)
    {
        if (tbTitle.Text!= "")
        {
            Titles title = new Titles();
            title.Summary = txtSummary.Text.Trim();
            title.Title = listPart.Text.Trim();
            //原标题获得Id
            title.Id = Convert.ToInt32(new TitleDAO().TitleToId(title).Rows[0][0]);
            //修改标题
            title.Title = tbTitle.Text.Trim();
            if (new TitleDAO().AlterTitle(title))
            {
                Response.Write("<script language=javascript>alert( '修改成功！');window.location.href='AdminManager.aspx';</script>");
            }
        }
        else
        {
            Response.Write("<script language=javascript>alert( '信息不能为空！')</script>");
        }
    }
    /// <summary>
    /// 更改原主题选项
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void listPart_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbTitle.Text = listPart.Text.Trim();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Titles title=new Titles();
        title.Title=listPart.Text.Trim();
        title.Id =Convert.ToInt32(new TitleDAO().TitleToId(title).Rows[0][0]);
        if(new TitleDAO().DeleteTitle(title))
        {
            Response.Write("<script language=javascript>alert( '删除成功！');window.location.href='AdminManager.aspx';</script>");
        }
    }
}