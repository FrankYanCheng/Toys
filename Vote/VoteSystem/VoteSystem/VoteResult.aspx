<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="VoteResult.aspx.cs" Inherits="VoteResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script src='js/jquery.js'></script>
    <script src="js/index.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">    
    <table class="choice"><tr><td>
        选择类型<asp:DropDownList ID="listPart"  Height="23px" Width="121px"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="listPart_SelectedIndexChanged"></asp:DropDownList>
        </td></tr></table>
    <div class="showpage"><table><tr><td>
     <div class="voteResult">
            <asp:Repeater ID="rpVote" runat="server">
                <ItemTemplate>
                    <div class="skillbar clearfix "  data-percent='<%#Eval("percentage").ToString()+'%'%>'>
                        <div class="skillbar-title"><span><%#Eval("Name") %></span></div>
                        <div id='radomColor<%#Eval("Count")%>' class="skillbar-bar"></div>

                        <div class="skill-bar-percent"><%#Eval("Count")+"票"%></div>
                        <script type="text/javascript">
                            //获取随机颜色；
                            function getColor() {
                                return '#' +
                                  (function (color) {
                                      return (color += '0123456789abcdef'[Math.floor(Math.random() * 16)])
                                        && (color.length == 6) ? color : arguments.callee(color);
                                  })('');
                            }

                            //开始给div的背景颜色赋值；
                            $(document).ready(function () {
                                $("div[id^='radomColor']").each(function () {
                                    var color = getColor();
                                    $(this).css("background", color);
                                });
                            });
                        </script>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div></td></tr></table>
 </div>
</asp:Content>

