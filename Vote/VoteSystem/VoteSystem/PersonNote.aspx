<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PersonNote.aspx.cs" Inherits="PersonNote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="showpage">
    <asp:Repeater ID="RtBinding" runat="server" >
        <ItemTemplate>
              <div class="Personal">
                  <table class="Personal-table0"><tr>
                      <td>
                    <img src='<%#Eval("PicPath")%>' alt='<%#Eval("Name")%>' class="Photo" />
                     </td>
                     </tr>
                      <tr><td>
                    <asp:LinkButton ID="lkVote" runat="server" OnClick="lkVote_Click" commandargument='<%#Eval("Sno")%>'><p class="lkVote2">投票</p></asp:LinkButton>                 
                  </td></tr></table>
              </div>
                  <div class="Personaldiv">
                    <table class="Personal-Table">
                        <tr class="Personal-tr1">
                            <td>姓名</td>
                            <td>学号</td>
                            <td>班级</td>
                            <td>参投类型</td>
                         </tr>
                        <tr class="Personal-tr2">
                            <td><%#Eval("Name")%></td>
                            <td><%#Eval("Sno")%></td>
                            <td><%#Eval("ClassName")%></td>
                            <td><%#Eval("Title")%></td>
                        </tr>
                        <tr><td colspan="4" class="Personal-tr4">成绩展示</td></tr>
                        <tr class="Personal-tr3"><td colspan="4"><%#Eval("Introduce")%></td></tr>
                    </table>                   
                      </div>
                  
                  
                    
        </ItemTemplate>
    </asp:Repeater>
        </div>
</asp:Content>

