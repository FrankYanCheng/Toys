<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TitlesAlter.aspx.cs" Inherits="TitlesAlter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="additem" style="float:left;">
     <p>所有原主题<asp:DropDownList ID="listPart"  Height="23px" Width="121px"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="listPart_SelectedIndexChanged"></asp:DropDownList></p> 
      <p class="addTitle">修改主题（必填）：<asp:TextBox ID="tbTitle" runat="server" CssClass="addTb" Width="186px"></asp:TextBox></p>
      <p class="addTitle">修改主题说明&nbsp; ： <asp:TextBox ID="txtSummary" runat="server" CssClass="addTb" Width="185px "></asp:TextBox></p>
          </div>
    <div class="clear"></div>
       <asp:Button ID="btAlterOk" runat="server" Text="修改" OnClick="btAlterOk_Click" CssClass="btApply" Width="279px" OnClientClick='return confirm("确定该操作？")'/>
    <p>
        谨慎删除，删除将删除主题下所有人员信息
    </p>
    <p>
       <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click" BackColor="#ff0000" CssClass="btApply" Width="279px" OnClientClick='return confirm("确定该操作？")' />
        </p>
</asp:Content>

