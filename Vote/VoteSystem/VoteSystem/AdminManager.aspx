<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminManager.aspx.cs" Inherits="AdminManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="showpage"><table class="adminTable1"><tr><td>
    <p class="admin_p">
         <asp:LinkButton ID="lkAdd" runat="server"  OnClick="lkAdd_Click">添加主题</asp:LinkButton>
        <asp:LinkButton ID="lkAlter" runat="server" OnClick="lkAlter_Click">修改主题</asp:LinkButton>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="显示所有" GroupName="one"/> 
        <asp:RadioButton ID="RadioButton2" runat="server"  Text="选择类型" GroupName="one" />
        <asp:DropDownList ID="listPart"  Height="23px" Width="121px"  runat="server" AutoPostBack="True"></asp:DropDownList>
        <asp:LinkButton ID="lkOk" runat="server"  OnClick="lkOk_Click">确定</asp:LinkButton>
    </p>
     <div class="clear"></div>
       <div class="manage">
            <table class="adminTable">
                <tr>
                    <th>学号
                    </th>
                    <th>人物名称
                    </th>
                    <th>主要事迹
                    </th>
                    <th>班级
                    </th>
                    <th>
                        申请主题
                    </th>
                    <th>
                        通过
                    </th>
                    <th>审核状态
                    </th>
                    <th>修改
                    </th>
                    <th>删除
                    </th>
                </tr>

                <asp:Repeater ID="rpItems" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td>
                                <%#Eval("Sno") %>
                            </td>
                            <td>
                                <%#Eval("Name") %>
                            </td>
                            <td>
                                 <%#StringTruncat(Eval("Introduce").ToString(),10,"...")%>
                            </td>
                            <td>
                                <%#Eval("ClassName")%>
                            </td>
                            <td><%#Eval("Title") %></td>
                            <td>
                                <asp:LinkButton ID="lkPass" runat="server" CommandArgument='<%#Eval("Sno")%>' OnClientClick='return confirm("确定该操作？")'
                                    OnClick="lkPass_Click">允许</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lkNotPass" runat="server" CommandArgument='<%#Eval("IsPermission")%>'> <%#Eval("IsPermission")%>

                                </asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lkAlterBySno" runat="server" CommandArgument='<%#Eval("Sno")%>'       OnClick="lkAlterBySno_Click">修改</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="lkDelNews" runat="server" CommandArgument='<%#Eval("Sno")%>' OnClientClick='return confirm("确定该操作？")'
                                    OnClick="lkDelNews_Click">删除</asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                </table>

                </div></td></tr></table>
</div>
</asp:Content>

