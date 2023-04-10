using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

public partial class Master_Pages_post_show : System.Web.UI.Page
{

    public static string type = "art", post_link = "Knowledge_SettingUp_WebSite";
    public static string cn_Head, cn_dv_Blue_For_art_app_Pages, cn_PRP_Content, cn_Side_Menu, cn_DV_Center;

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(Connectionst.ConnectionString_Main);
        con.Open();

        string cmd = "";
        if (type == "app")
        {
            cmd = "Select * From [tbl_app] Where ([paper_link]='" + post_link + "')";
        }
        else if (type == "art")
        {
            cmd = "Select * From [tbl_art] Where ([paper_link]='" + post_link + "')";
        }

        SqlCommand com = new SqlCommand(cmd, con);

        SqlDataReader dr = com.ExecuteReader();

        if (dr.Read())
        {
            cn_Head = "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">";
            cn_Head += "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">";
            cn_Head += "<title>" + dr["title"].ToString() + "</title>";
            cn_Head += "<meta http-equiv=\"Content-Language\" content=\"fa\">";
            cn_Head += "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">";
            cn_Head += "<META NAME=\"description\" CONTENT=\"" + dr["meta_desc"].ToString() + "\">";
            cn_Head += "<META NAME=\"keywords\" CONTENT=\"" + dr["meta_title"].ToString() + "\">";

            cn_dv_Blue_For_art_app_Pages = dr["title"].ToString();
            cn_PRP_Content = dr["text_boy"].ToString();
            cn_Side_Menu = File.ReadAllText(MapPath("~/prv/side_console_bar_menu.html"));
            cn_DV_Center = "<iframe style=\"width:100%;border:none;height:600px;padding:5px;\" src=\"" + Request.Url.ToString().Replace(Request.RawUrl, "") + "/Contact_Comment/send_comment.aspx" + "\"></iframe>";
           
        }


        com.Dispose();
        con.Close();
    }
}