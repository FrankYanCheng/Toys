<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddItems.aspx.cs" Inherits="AddItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <!--裁剪程序-->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="showpage">
    <!--  <div class="additem">-->
             <p>参选人物：<asp:TextBox ID="tbTitle" runat="server" CssClass="addTb" Width="186px"></asp:TextBox><label class="xing">*</label></p>
             <p>学&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;号：<asp:TextBox ID="txtSno" runat="server" CssClass="addTb" Width="186px"></asp:TextBox><label class="xing">*</label></p>
            <p> 班&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;级：<asp:TextBox ID="txtClass" runat="server" CssClass="addTb" Width="186px"></asp:TextBox><label class="xing">*</label></p>
            <div id="container">
                <p>
                   上传照片：<asp:TextBox ID="tbImgUrl" runat="server"  class="tbHidden" Style="display: none;" ></asp:TextBox><asp:FileUpload
                        ID="FileUpload1" runat="server" Width="186px" class="fileLoad" /><label class="xing">*(方形，500k以内)</label>
                </p>
                <p>参与主题：<asp:DropDownList ID="listPart"  Height="23px" Width="186px"  runat="server" AutoPostBack="True"></asp:DropDownList><label class="xing">*</label></p>
                <p style="display: none;">
                    照片路径：<asp:TextBox ID="tbDestImgUrl" runat="server"></asp:TextBox><label class="xing">*</label>
                </p>
            </div>

            <p class="pContent">参选事迹(限500字)：<br/><asp:TextBox ID="tbContent" runat="server" TextMode="MultiLine"  CssClass="addMultb" Height="175px" Width="750px"></asp:TextBox></p>
            <asp:Button ID="btOk" runat="server" Text="申请" class="btApply" OnClick="btOk_Click" CssClass="btApply"/>
     <!--  </div>-->
</div>
</asp:Content>
