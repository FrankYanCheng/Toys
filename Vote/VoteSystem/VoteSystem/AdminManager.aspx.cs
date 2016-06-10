using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Model;

public partial class AdminManager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // 已登陆
        if (Session["admin"] != null)
        {
            if (!Page.IsPostBack)
            {
                rpItems.DataSource = new VoteDAO().selectAll();
                rpItems.DataBind();
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
    #region 裁剪字符串
    ///   <summary>   
    ///   将指定字符串按指定长度进行剪切，   
    ///   </summary>   
    ///   <param   name= "oldStr "> 需要截断的字符串 </param>   
    ///   <param   name= "maxLength "> 字符串的最大长度 </param>   
    ///   <param   name= "endWith "> 超过长度的后缀 </param>   
    ///   <returns> 如果超过长度，返回截断后的新字符串加上后缀，否则，返回原字符串 </returns>   
    public static string StringTruncat(string oldStr, int maxLength, string endWith)
    {
        if (string.IsNullOrEmpty(oldStr))
            //   throw   new   NullReferenceException( "原字符串不能为空 ");   
            return oldStr + endWith;
        if (maxLength < 1)
            throw new Exception("返回的字符串长度必须大于[0] ");
        if (oldStr.Length > maxLength)
        {
            string strTmp = oldStr.Substring(0, maxLength);
            if (string.IsNullOrEmpty(endWith))
                return strTmp;
            else
                return strTmp + endWith;
        }
        return oldStr;
    }
    public static string StringTruncat(string oldStr, int start, int maxLength, string endWith)
    {
        if (string.IsNullOrEmpty(oldStr))
            //   throw   new   NullReferenceException( "原字符串不能为空 ");   
            return oldStr + endWith;
        if (maxLength < 1)
            throw new Exception("返回的字符串长度必须大于[0] ");
        if (oldStr.Length > maxLength)
        {
            string strTmp = oldStr.Substring(start, maxLength);
            if (string.IsNullOrEmpty(endWith))
                return strTmp;
            else
                return strTmp + endWith;
        }
        return oldStr;
    }
    #endregion
    /// <summary>
    /// 确定通过
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lkPass_Click(object sender, EventArgs e)
    {
        Vote vote = new Vote();
        //获得学号
        vote.Sno = ((LinkButton)sender).CommandArgument.ToString();
        if (new VoteDAO().Permisson(vote))
        {
            Response.Write("<script language=javascript>alert( '操作成功！');window.location.href='AdminManager.aspx';</script>");
        };
    }
    /// <summary>
    /// 审核状态
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lkNotPass_Click(object sender, EventArgs e)
    {
        //Vote vote = new Vote();
        ////获得学号
        //vote.IsPermission = Convert.ToBoolean(((LinkButton)sender).CommandArgument);
        //if (vote.IsPermission == true)
        //{

        //}
    }
    /// <summary>
    /// 删除投票人信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lkDelNews_Click(object sender, EventArgs e)
    {
        Vote vote = new Vote();
        vote.Sno=((LinkButton)sender).CommandArgument.ToString();
        if(new VoteDAO().DeleteVote(vote))
        {
             Response.Write("<script language=javascript>alert( '操作成功！');window.location.href='AdminManager.aspx';</script>");
        }
    }
    /// <summary>
    /// 更新查询方式
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lkOk_Click(object sender, EventArgs e)
    {
        //根据类型分类
        if (RadioButton2.Checked == true)
        {

            Titles title = new Titles();
            title.Title = listPart.SelectedValue;
             rpItems.DataSource = new VoteDAO().selectByTitle(title);
             rpItems.DataBind();

        }
        //选择所有
        else
        {
            rpItems.DataSource = new VoteDAO().selectAll();
            rpItems.DataBind();
        }
    }
    protected void lkAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("TitlesAdd.aspx");
    }
    /// <summary>
    /// 修改主题信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lkAlter_Click(object sender, EventArgs e)
    {
        Response.Redirect("TitlesAlter.aspx");
    }
    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lkAlterBySno_Click(object sender, EventArgs e)
    {
        string sno = ((LinkButton)sender).CommandArgument.ToString();
        Response.Redirect("ManagerAlter.aspx?Sno=" + Server.UrlEncode(sno));
    }
}