using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using DAL;

public partial class AddItems : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            this.listPart.DataTextField = "Title";
            this.listPart.DataSource = new TitleDAO().SelectTitles();
            this.listPart.DataBind();
        }
        
    }
    protected void btUpload_Click(object sender, EventArgs e)
    {
       
    }
    protected void btOk_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
        
                string Name = FileUpload1.FileName;
                string extension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (extension == ".jpg" || extension == ".png" || extension == ".bmp" || extension == ".jpeg")
                {
                    if (FileUpload1.PostedFile.ContentLength < 2000000)//文件小于2M
                    {

                        //文档上传到的固定目录 如果需要修改必须必须3个都修改  
                        string SaveSoft = Server.MapPath("./Pic/");
                        string Fe = Name.Substring(Name.LastIndexOf(".") + 1);
                        string newName = "";
                        if (Name != "")
                        {
                            newName = DateTime.Now.ToString("yyyyMMddHHmmss") + "." + Fe;
                        }
                        SaveSoft += newName;
                        System.IO.Directory.CreateDirectory(Server.MapPath("./Pic/"));
                        FileUpload1.SaveAs(SaveSoft);
                        tbImgUrl.Text = "Pic/" + newName;
                        //tbDestImgUrl.Text = "UploadFiles/FinalPic/" + newName;
                    }
                    Vote vote = new Vote();
                    vote.Name = tbTitle.Text.Trim();
                    vote.Sno = txtSno.Text.Trim();
                    vote.ClassName = txtClass.Text.Trim();
                    vote.PicPath = tbImgUrl.Text;
                    vote.Introduce = tbContent.Text.Trim();
                    try
                    {
                        Titles title = new Titles();
                        title.Title = this.listPart.SelectedValue;
                        vote.Id = Convert.ToInt32(new TitleDAO().TitleToId(title).Rows[0][0]);

                    }
                    catch
                    {
                        Response.Write("<script language=javascript>alert( '填写出错');</script>");
                        Response.Redirect("ErrorPage.aspx");
                    }
                    if (vote.Name != "" && vote.Sno != "" && vote.Introduce != "")
                    {

                        if (new VoteDAO().InsertVote(vote))
                        {
                            Response.Write("<script language=javascript>alert( '申请成功！');</script>");

                        }
                        else
                        {
                            Response.Write("<script language=javascript>alert( '申请失败！');</script>");
                        }

                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert( '请完善相关信息！');</script>");
                    }
                }
                else
                {
                    Response.Write("<script language=javascript>alert( '请上传照片的格式为.jpg 或png、bmp格式！');</script>");
                }
            }
        else
        {
               Response.Write("<script language=javascript>alert( '请完善相关信息！');</script>");
        }
           
        }
}