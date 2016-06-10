<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManagerAlter.aspx.cs" Inherits="ManagerAlter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>主题修改</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div class="additem">
           <p class="addTitle">学号&nbsp; ：<asp:TextBox ID="txtSno" runat="server" CssClass="addTb" Width="185px"></asp:TextBox></p>
            <p class="addTitle">参选人物：<asp:TextBox ID="tbTitle" runat="server" CssClass="addTb" Width="186px"></asp:TextBox></p>           
             <p class="addTitle">班级：<asp:TextBox ID="txtClass" runat="server" CssClass="addTb" Width="186px"></asp:TextBox></p>
            <div id="container">
                <p>
                    上传照片：上传照片：<asp:TextBox ID="tbImgUrl" runat="server" class="tbHidden" Style="display: none;"></asp:TextBox><asp:FileUpload
                        ID="FileUpload1" runat="server" class="fileLoad" />
                </p>参与主题：
                <asp:DropDownList ID="listPart"  Height="23px" Width="121px"  runat="server" AutoPostBack="True"></asp:DropDownList>
                <p style="display: none;">
                    照片路径：<asp:TextBox ID="tbDestImgUrl" runat="server"></asp:TextBox>
                </p>
            </div>

            <p class="pContent">参选事迹：<asp:TextBox ID="tbContent" runat="server" TextMode="MultiLine"  CssClass="addMultb" Height="77px" Width="463px"></asp:TextBox></p>
            <asp:Button ID="btOK" runat="server" Text="修改" OnClick="btOk_Click" CssClass="btApply" Width="282px"/>
        </div>
</asp:Content>

