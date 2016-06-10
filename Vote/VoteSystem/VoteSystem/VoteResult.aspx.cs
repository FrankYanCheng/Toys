using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;
public partial class VoteResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                rpVote.DataSource = new VoteDetailDAO().CountSelectAll();
                rpVote.DataBind();

                this.listPart.DataTextField = "Title";
                this.listPart.DataSource = new TitleDAO().SelectTitles();
                this.listPart.DataBind();
                this.listPart.Items.Add("所有类型");
                this.listPart.SelectedValue = "所有类型";

            }
        }
        catch
        {
            Response.Write("<script language=javascript>window.location.href='ErrorPage.aspx';</script>");
        }
    }
    protected void listPart_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.listPart.Text == "所有类型")
            {

                rpVote.DataSource = new VoteDetailDAO().CountSelectAll();
                rpVote.DataBind();
            }
            else
            {
                Titles title = new Titles();
                title.Title = this.listPart.Text.Trim();
                rpVote.DataSource = new VoteDetailDAO().CountSelectByTitle(title);
                rpVote.DataBind();
            }
        }
        catch
        {
            rpVote.DataSource = new VoteDetailDAO().CountSelectAll();
            rpVote.DataBind();
        }
    }
}