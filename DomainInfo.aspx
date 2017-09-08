<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DomainInfo.aspx.cs" Inherits="DomainInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="table">
        <dl>
            <dt><a id="域名详细信息"></a>域名详细信息</dt>
        </dl>
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td height="350" valign="top">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="40%" valign="top" class="xunjia">
                                <table width="100%" border="0" align="center" cellpadding="0" cellspacing="1">
                                    <tr>
                                        <td width="25%" height="25" align="center">域&nbsp;&nbsp;&nbsp;&nbsp;名：</td>
                                        <td width="75%"><%=new Domain(Request.QueryString["id"].ToString()).yuming %> [<a href="http://whois.chinaz.com/<%=new Domain(Request.QueryString["id"].ToString()).yuming %>" style="color: #FF0000" target="_blank">查看Whois信息</a>]</td>
                                    </tr>
                                    <tr>
                                        <td width="25%" height="25" align="center">简&nbsp;&nbsp;&nbsp;&nbsp;介：</td>
                                        <td width="75%"><%=new Domain(Request.QueryString["id"].ToString()).hanyi %></td>
                                    </tr>
                                    <tr>
                                        <td height="25" align="center">价&nbsp;&nbsp;&nbsp;&nbsp;格：</td>
                                        <td><%=new Domain(Request.QueryString["id"].ToString()).biaojia.ToString()=="0"?"议价":new Domain(Request.QueryString["id"].ToString()).biaojia.ToString()+"元"%></td>
                                    </tr>
                                    <tr>
                                        <td height="25" align="center">状&nbsp;&nbsp;&nbsp;&nbsp;态：</td>
                                        <td><%=new Domain(Request.QueryString["id"].ToString()).zhuangtai %></td>
                                    </tr>

                                    <tr>
                                        <td height="25" align="center">出&nbsp;售&nbsp;页：</td>
                                        <td><a href="<%=new Domain(Request.QueryString["id"].ToString()).lianjie %>"><%=new Domain(Request.QueryString["id"].ToString()).lianjie %></a></td>
                                    </tr>

                                    <tr>
                                        <td height="25" align="center">注&nbsp;册&nbsp;商：</td>
                                        <td><%=new Domain(Request.QueryString["id"].ToString()).pingtai %></td>
                                    </tr>
                                    
                                    <tr>
                                        <td height="25" align="center" colspan="2"><a href="/">
                                            <img src="images/back.png" border="0"></a></td>
                                    </tr>
                                </table>
                            </td>

                        </tr>
                    </table>
                </td>
            </tr>
        </table>

    </div>
</asp:Content>

