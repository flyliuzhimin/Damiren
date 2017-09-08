using System;
using System.Configuration;
using System.Data;
using System.Text;
using System.Web;

public partial class _Default : System.Web.UI.Page
{
    public static string trstring = "";
    public static string linksstring = "";
    public static string userid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            userid = SqlHalper.ExecuteScalar("SELECT  [id] FROM [SiteInfo] where Yuming='"+ HttpContext.Current.Request.Url.Host + "'", ConfigurationManager.ConnectionStrings["damirendb"].ToString()).Trim();
            if (userid == "")
            {
                Response.Redirect("Error.aspx");
            }
        }
        catch {
            Response.Redirect("Error.aspx");
        }
        DataTable dt = SqlHalper.QueryDataTable("SELECT * from [Yumings] where [zhuangtai]='未售出' and userid='"+userid+"'  order by [biaojia] desc", ConfigurationManager.ConnectionStrings["damirendb"].ToString());
        StringBuilder sbu = new StringBuilder();
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["yuming"].ToString() != "" && dr["yuming"] != null)
                {

                    sbu.Append("<dd>");
                    sbu.Append("<a href = 'DomainInfo.aspx?id=" + dr["id"].ToString() + "' target = '_blank'>");
                    sbu.Append("<i> " + dr["yuming"].ToString() + " </i>");
                    sbu.Append("<em> " + dr["hanyi"].ToString() + " </em>");
                    sbu.Append("<span class='fr'> ");
                    if (dr["biaojia"].ToString() != ""&& decimal.Parse(dr["biaojia"].ToString().Trim()) != 0)
                    {
                        sbu.Append(double.Parse(dr["biaojia"].ToString())+" 元");
                    }
                    else {
                        sbu.Append("议价");
                    }
                    sbu.Append("</span>");

                    sbu.Append("</a>");
                    sbu.Append("</dd>");
                }
            }
        }

        trstring = sbu.ToString();

        DataTable dtlinks = SqlHalper.QueryDataTable("SELECT * from [Links] where [leixing]='友情链接' and userid='" + userid + "' order by shunxu", ConfigurationManager.ConnectionStrings["damirendb"].ToString());
        StringBuilder sbulinks = new StringBuilder();
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dtlinks.Rows)
            {
                if (dr["id"].ToString() != "" && dr["id"] != null)
                {

                    sbulinks.Append("<span>");
                    sbulinks.Append("<a href = '" + dr["dizhi"].ToString() + "' target = '_blank'style = 'margin: 0px; '>");
                    sbulinks.Append(dr["mingcheng"].ToString());
                    sbulinks.Append("</a>");
                    sbulinks.Append("</span>");
                }
            }
        }
        linksstring = sbulinks.ToString();
    }
}