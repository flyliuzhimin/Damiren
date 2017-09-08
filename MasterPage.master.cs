using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public static string wzjieshao = "fly的米铺,域名新闻门户,ymxw.cn";
    public static string wzguanjianzi = "VIP老店,老店,fly的米铺,域名列表,域名出售,ymxw.cn域名注册,双拼域名,VIP域名,免费主机,虚拟主机,米铺源码,域名投资";
    public static string wzbiaoti = "请设置米店名称";
    public static string wzyuming = "请设置米店域名";
    public static string menu = "";
    public static string qq = "请设置QQ";
    public static string mail = "请设置邮箱";
    public static string userid = "";
    public static string logo = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable siteset = SqlHalper.QueryDataTable("SELECT * FROM [SiteInfo] WHERE yuming='" + HttpContext.Current.Request.Url.Host + "'", ConfigurationManager.ConnectionStrings["damirendb"].ToString());
            if (siteset.Rows.Count == 0)
            {
                Response.Write("<div style='text-align:center;'><a href='/admin/SiteSet.aspx'><span style='color:red;'>请登陆并设置网站信息！</span></a></div>");
            }
            else { 
            wzjieshao = siteset.Rows[0]["jieshao"].ToString();
            wzguanjianzi = siteset.Rows[0]["guanjianzi"].ToString();
            wzbiaoti = siteset.Rows[0]["biaoti"].ToString();
            wzyuming = siteset.Rows[0]["yuming"].ToString();
            qq = siteset.Rows[0]["qq"].ToString();
            mail = siteset.Rows[0]["youxiang"].ToString();
                userid = siteset.Rows[0]["id"].ToString();
                logo = siteset.Rows[0]["logo"].ToString();
            }

        }
        catch {
            Response.Write("<div style='text-align:center;'><a href='/admin/SiteSet.aspx'><span style='color:red;'>请登陆并设置网站信息！</span></a></div>");
        }

        //以下设置菜单栏
        DataTable meunlinks = SqlHalper.QueryDataTable("SELECT * from [Links] where [leixing]='米店链接' and userid='"+userid+"' order by shunxu", ConfigurationManager.ConnectionStrings["damirendb"].ToString());
        StringBuilder sbuMeunlinks = new StringBuilder();
        sbuMeunlinks.Append("<li><a href='http://mibiao.liuzhimin.cn'>老店</a></li>");
        sbuMeunlinks.Append("<li class='current'><a href='http://jsgo.cn'>网站首页</a></li>");
        if (meunlinks.Rows.Count > 0)
        {
            foreach (DataRow dr in meunlinks.Rows)
            {
                if (dr["id"].ToString() != "" && dr["id"] != null)
                {
                    sbuMeunlinks.Append("<li>");
                    sbuMeunlinks.Append("<a href = '" + dr["dizhi"].ToString() + "''>");
                    sbuMeunlinks.Append(dr["mingcheng"].ToString());
                    sbuMeunlinks.Append("</a>");
                    sbuMeunlinks.Append("</li>");
                }
            }
        }

        menu = sbuMeunlinks.ToString();
    }
}
