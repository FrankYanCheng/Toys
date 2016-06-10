<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="ErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p></p>
      <script type="text/javascript">
          var i = 5;
          asd = setInterval("fun()", 1000);
          function fun() {
              if (i == 0) {
                  window.location.href = "Default.aspx";
                  clearInterval(asd);
              }
              document.getElementById("mes").innerHTML = i;
              i--;
          }
    </script>
    <img src="img/Error.jpg" style="width: 480px" />
     <div style="float:left";>
           <p id="ErrorStyle" >将在 <span id="mes">5</span>S后返回首页</p>
     </div>
</asp:Content>

