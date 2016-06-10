using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Model;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RtBinding.DataSource = new VoteDAO().selectAllRight();
            RtBinding.DataBind();
            this.listPart.DataTextField = "Title";
            this.listPart.DataSource = new TitleDAO().SelectTitles();
            this.listPart.DataBind();
            this.listPart.Items.Add("所有类型");
            this.listPart.SelectedValue = "所有类型";
        }
    }
    protected void lkVote_Click(object sender, EventArgs e)
    {
      if(Request.Cookies["VoteTime"]!=null)
      {              
          if(Convert.ToInt32(Request.Cookies["VoteTime"].Value)<=1)
          {
              string sno = ((LinkButton)sender).CommandArgument.ToString();
              VoteDetail detail = new VoteDetail();
              detail.Sno = sno;
              detail.Ip = System.Web.HttpContext.Current.Request.UserHostAddress;
              if (new VoteDetailDAO().Insert(detail))
              {
                  Response.Write("<script language=javascript>alert( '投票成功！');</script>");
              }
              int i =Convert.ToInt32(Request.Cookies["VoteTime"].Value);
              Response.Cookies["VoteTime"].Value = (i+1).ToString();
              Response.Cookies["VoteTime"].Expires = System.DateTime.Now.AddDays(1);
          }
          else
          {
              Response.Write("<script language=javascript>alert( '今天已投票，请耐心！');</script>");
          }
       }
      else
      {
          Response.Cookies["VoteTime"].Value = "1";
          Response.Cookies["VoteTime"].Expires = System.DateTime.Now.AddDays(1);
          string sno = ((LinkButton)sender).CommandArgument.ToString();
          VoteDetail detail = new VoteDetail();
          detail.Sno = sno;
          detail.Ip = System.Web.HttpContext.Current.Request.UserHostAddress;
          if (new VoteDetailDAO().Insert(detail))
          {
              Response.Write("<script language=javascript>alert( '投票成功！');</script>");
          }        
      }
   
    }
    /// <summary>
    /// 图片点击获取个人信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Personal_Click(object sender, EventArgs e)
    {
        string sno=((ImageButton)sender).CommandArgument.ToString();
        Response.Redirect("PersonNote.aspx?Sno=" + Server.UrlEncode(sno));

    }

    protected void listPart_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.listPart.Text == "所有类型")
            {

                RtBinding.DataSource = new VoteDAO().selectAllRight();
                RtBinding.DataBind();
            }
            else
            {
                Titles title = new Titles();
                title.Title = this.listPart.Text.Trim();
                RtBinding.DataSource = new VoteDAO().selectByTitleRight(title);
                RtBinding.DataBind();
            }
        }
        catch
        {
            RtBinding.DataSource = new VoteDAO().selectAllRight();
            RtBinding.DataBind();
        }
    }
}