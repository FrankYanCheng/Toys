using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;
public partial class PersonNote : System.Web.UI.Page
{
    string sno;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                sno = HttpUtility.UrlEncode(Request.QueryString["Sno"]);
                Vote vote = new Vote();
                vote.Sno = sno;
                RtBinding.DataSource = new VoteDAO().selectBySnoRight(vote);
                RtBinding.DataBind();
            }
        }
        catch
        {
            Response.Write("<script language=javascript>window.location.href='ErrorPage.aspx';</script>");
        }
    }
    /// <summary>
    /// 投票
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lkVote_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["VoteTime"] != null)
        {
            if (Convert.ToInt32(Request.Cookies["VoteTime"].Value) <= 1)
            {
                string sno = ((LinkButton)sender).CommandArgument.ToString();
                VoteDetail detail = new VoteDetail();
                detail.Sno = sno;
                detail.Ip = System.Web.HttpContext.Current.Request.UserHostAddress;
                if (new VoteDetailDAO().Insert(detail))
                {
                    Response.Write("<script language=javascript>alert( '投票成功！');</script>");
                }
                int i = Convert.ToInt32(Request.Cookies["VoteTime"].Value);
                Response.Cookies["VoteTime"].Value = (i + 1).ToString();
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
}