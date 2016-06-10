<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="choice"><tr>        
        <td>选择类型: <asp:DropDownList ID="listPart"  Height="20px" Width="121px"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="listPart_SelectedIndexChanged"></asp:DropDownList></td>
        </tr></table>      
     <div class="showpage">
         <table><tr><td>
    <asp:Repeater ID="RtBinding" runat="server" >       
         <ItemTemplate>
              <div class="VoteItems">
                  <asp:ImageButton src='<%#Eval("PicPath")%>' alt='<%#Eval("Name")%>' commandargument='<%#Eval("Sno")%>' class="Photo" onclick="Personal_Click" runat="server" />
                        <span>
                            姓名:
                          <%#Eval("Name")%><br/>
                        </span>
                        <span>
                           班级:
                          <%#Eval("ClassName")%><br/>
                        </span>
                        <span>
                           参投类型:
                          <%#Eval("Title")%><br/>
                        </span>
                       
                        <asp:LinkButton ID="lkVote" runat="server" OnClick="lkVote_Click" class="lkVote2" CommandArgument='<%#Eval("Sno")%>'>投票</asp:LinkButton>
                    </div>
         </ItemTemplate>
      
    </asp:Repeater> </td></tr></table></div>
</asp:Content>

