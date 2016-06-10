<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TitlesAdd.aspx.cs" Inherits="TitlesAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="additem" style="float:left";>
      <p class="addTitle">主题（必填）：<asp:TextBox ID="tbTitle" runat="server" CssClass="addTb" Width="186px"></asp:TextBox></p>
      <p class="addTitle">主题说明&nbsp; ： <asp:TextBox ID="txtSummary" runat="server" CssClass="addTb" Width="185px"></asp:TextBox></p>
          </div>
    <div class="clear"></div>
       <asp:Button ID="btOk" runat="server" Text="添加" OnClick="btOk_Click" CssClass="btApply" Width="279px"/>
</asp:Content>

