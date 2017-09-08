<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link rel="stylesheet" type="text/css" href="http://cdn.datatables.net/1.10.15/css/jquery.dataTables.css" />
    <!-- jQuery -->
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <!-- DataTables -->
    <script type="text/javascript" charset="utf8" src="http://cdn.datatables.net/1.10.15/js/jquery.dataTables.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
        
        <div class="column">
                <a href="#1F">所有域名</a>&nbsp;<a href="#2F">友情链接</a>
        </div>
        <div class="column">
            <a name="1F"></a>
            <dl>
                <dt><a id="所有域名"></a>所有域名<a href="#">more&#187;</a></dt>
                <%=trstring %>
            </dl>
        </div>
        <div class="column">
            <a name="2F"></a>
            <dl style="margin: 10px 0px; padding-bottom: 10px;">
                <dt style="display: inline;"><a id="友情链接"></a>友情链接</dt>
                <div class="links" style="margin: 5px 0;">
                   <%=linksstring %>
                </div>
            </dl>
        </div>
</asp:Content>

