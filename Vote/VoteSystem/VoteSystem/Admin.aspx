<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="showpage">
            <div id="Login" class="login">
                <p class="items">
                    用户名：<asp:TextBox ID="tbName" runat="server" Width="200px" CssClass="tbDefault"></asp:TextBox>
                </p>
                <p class="items">
                    密&nbsp;&nbsp;&nbsp;&nbsp;码：<asp:TextBox ID="tbPassword" runat="server" Width="200px" TextMode="Password" CssClass="tbDefault"></asp:TextBox>
                </p>
                <p class="pLogin">
                    <asp:Button ID="Button1" runat="server" Text="登录" Width="200px" CssClass="btDefault" OnClick="Button1_Click"></asp:Button>
                </p>
            </div>
        
      </div>
</asp:Content>

