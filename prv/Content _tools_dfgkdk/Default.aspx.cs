using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Data.SqlClient;
using System.IO;
//using System.Web.UI;
//using System.Web.UI.WebControls;

public partial class prv_Content__tools_dfgkdk_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string dynam_region = "", host_address = Request.Url.ToString().Replace(Request.RawUrl.ToString(), "");

        if (Session[Request.UserHostAddress].ToString() == Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString())
        {
            if (Request.Form["type"] == "sitemap")
            {
                #region //بروز رسانی سایت مپ
                string sitemap_TXT = File.ReadAllText(MapPath("~/prv/Content _tools_dfgkdk/st.txt"));
                try
                {
                    File.Delete(MapPath("~/sitemap.xml"));
                }
                catch
                { }

                SqlConnection con1 = new SqlConnection(Connectionst.ConnectionString_Main);
                con1.Open();

                SqlCommand com1 = new SqlCommand("Select * from tbl_art", con1);


                SqlDataReader dr1 = com1.ExecuteReader();

                while (dr1.Read())
                {
                    sitemap_TXT += "\n" + "<url>" + "\n" + "  <loc>" + host_address + "/posts/" + dr1["paper_link"] + "</loc>" + "\n" + "<changefreq>monthly</changefreq>" + "\n" + "</url>";
                }

                com1.Dispose();
                com1 = new SqlCommand("Select * from tbl_app", con1);
                dr1.Dispose();
                dr1 = com1.ExecuteReader();

                while (dr1.Read())
                {
                    sitemap_TXT += "\n" + "<url>" + "\n" + "  <loc>" + host_address + "/posts/" + dr1["paper_link"] + "</loc>" + "\n" + "<changefreq>monthly</changefreq>" + "\n" + "</url>";
                }

                sitemap_TXT += "\n" + "</urlset>";

                con1.Dispose();
                con1.Close();

                File.WriteAllText(MapPath("~/sitemap.xml"), sitemap_TXT);
                #endregion
            }
            else if (Request.Form["type"] == "index")
            {
                #region //بروز رسانی صفحه اصلی
                string indet_TXT = File.ReadAllText(MapPath("~/prv/Content _tools_dfgkdk/askdjfjasdf.php"));
                string dynamic_menu = "";


                try
                {
                    File.Delete(MapPath("~/index.php"));
                }
                catch
                { }

                SqlConnection con1 = new SqlConnection(Connectionst.ConnectionString_Main);
                con1.Open();


                SqlCommand com1 = new SqlCommand("Select TOP(5) paper_link, img, title from tbl_art ORDER BY r DESC", con1);


                SqlDataReader dr1 = com1.ExecuteReader();

                //Response.Write("OK");
                //return;

                while (dr1.Read())
                {
                    dynam_region += "<a href=\"" + Edit_Content_class.Posts_link_Path + "/" + dr1["paper_link"] + "\"><div class=\"portfolio-item graphic-design isotope-item\"><div class=\"he-wrap tpl6\"><div class=\"dv_item_img\" style=\"background:url(" + Edit_Content_class.Header_IMG_Location + "/" + dr1["img"] + ");\"></div>"+" <div class=\"he-view\"><div class=\"bg a0\" data-animate=\"fadeIn\"><h3 class=\"pm1\" data-animate=\"fadeInDown\">" + dr1["title"] + "</h3> <a data-rel=\"prettyPhoto\" href=\"" + Edit_Content_class.Header_IMG_Location + "/" + dr1["img"] + "\" class=\"dmbutton a2\" data-animate=\"fadeInUp\"><i class=\"fa fa-picture-o\"></i></a> <a href=\"" + Edit_Content_class.Posts_link_Path + "/" + dr1["paper_link"] + "\" class=\"dmbutton a2\" data-animate=\"fadeInUp\"><i class=\"fa fa-link\"></i></a></div></div></div></div></a>";

                }

                com1.Dispose();
                com1 = new SqlCommand("Select TOP(5) paper_link, img, title from tbl_app ORDER BY r DESC", con1);
                dr1.Dispose();
                dr1 = com1.ExecuteReader();

                while (dr1.Read())
                {
                    dynam_region += "<a href=\"" + Edit_Content_class.Posts_link_Path + "/" + dr1["paper_link"] + "\"><div class=\"portfolio-item graphic-design isotope-item\"><div class=\"he-wrap tpl6\">"+"<div class=\"dv_item_img\" style=\"background:url(" + Edit_Content_class.Header_IMG_Location + "/" + dr1["img"] + ");\"></div>" + "<div class=\"he-view\"><div class=\"bg a0\" data-animate=\"fadeIn\"><h3 class=\"a1\" data-animate=\"fadeInDown\">" + dr1["title"] + "</h3> <a data-rel=\"prettyPhoto\" href=\"" + Edit_Content_class.Header_IMG_Location + "/" + dr1["img"] + "\" class=\"dmbutton a2\" data-animate=\"fadeInUp\"><i class=\"fa fa-picture-o\"></i></a> <a href=\"" + Edit_Content_class.Posts_link_Path + "/" + dr1["paper_link"] + "\" class=\"dmbutton a2\" data-animate=\"fadeInUp\"><i class=\"fa fa-link\"></i></a></div></div></div></div></a>";
                }



                con1.Dispose();
                con1.Close();

                //File.WriteAllText(MapPath("~/index.php"), indet_TXT.Replace("dynamic_content_for_edit_by_tools", dynam_region));

                File.WriteAllText(MapPath("~/index.php"), indet_TXT.Replace("dynamic_content_for_edit_by_tools", dynam_region).Replace("dynamic_content_menu_dyn", get_menu_content()));


                #endregion
            }
            else if (Request.Form["type"] == "menu")
            {
                string menu_val = "<div class=\"fl\" style=\"width:100%;\"><h4>جستجو در سایت</h4><p> <br/> <input type=\"text\" class=\"form-control\" placeholder=\"عبارت مورد نظر را وارد نمایید\" id=\"txt_search\"><br /> <a id=\"search-btn\" value=\"بگرد\" class=\"btn btn-theme\" style=\"width:100px;\" onClick=\"srch()\">جستجو</a><br /><br /></p><div class=\"spacing\"></div><h4>اپلیکیشن های پیشنهادی</h4><div class=\"hline\"></div> <br>";

                #region //بروز رسانی منوی کنار
                try
                {
                    File.Delete(MapPath("~/prv/side_console_bar_menu.html"));
                }
                catch
                { }

                SqlConnection con1 = new SqlConnection(Connectionst.ConnectionString_Main);
                con1.Open();


                SqlCommand com1 = new SqlCommand("Select * from tbl_menu_app ORDER BY r DESC", con1);


                SqlDataReader dr1 = com1.ExecuteReader();

                //Response.Write("OK");
                //return;

                while (dr1.Read())
                {

                    menu_val += "<p><a href=\"" + dr1["link"] + "\" >" + dr1["text"] + "</a></p><br>";
                }


                menu_val += "<br><h4>مطالب پیشنهادی</h4><div class=\"hline\"></div><ul class=\"popular-posts\"><br>";

                com1.Dispose();
                com1 = new SqlCommand("Select * from tbl_menu_art ORDER BY r DESC", con1);
                dr1.Dispose();
                dr1 = com1.ExecuteReader();

                while (dr1.Read())
                {
                    menu_val += "<p><a class=\"pc2\" href=\"" + dr1["link"] + "\" >" + dr1["text"] + "</a></p><br>";
                }

                menu_val += "</ul><div class=\"spacing\"></div></div>";

                con1.Dispose();
                con1.Close();

                File.WriteAllText(MapPath("~/prv/side_console_bar_menu.html"), menu_val);
                #endregion
            }
            Response.Redirect(Edit_Content_class.direct_URL);
        }
        else
        {
            Session.RemoveAll();
            Response.Redirect("~/Error.html");
        }
    }


    string get_menu_content()
    {

        string menu_val = "<div class=\"col-lg-3 fl\"><h4>مطالب پیشنهادی</h4><div class=\"hline\"></div> <br>";

        SqlConnection con1 = new SqlConnection(Connectionst.ConnectionString_Main);
        con1.Open();


        SqlCommand com1 = new SqlCommand("Select * from tbl_menu_art ORDER BY r DESC", con1);


        SqlDataReader dr1 = com1.ExecuteReader();

        //Response.Write("OK");
        //return;

        while (dr1.Read())
        {

            menu_val += "<p><a href=\"" + dr1["link"] + "\" >" + dr1["text"] + "</a></p>";
        }


        menu_val += "</div><div class=\"col-lg-3 fl\"><h4>اپلیکیشن های پیشنهادی</h4><div class=\"hline\"></div><ul class=\"popular-posts\"> <br>";

        com1.Dispose();
        com1 = new SqlCommand("Select * from tbl_menu_app ORDER BY r DESC", con1);
        dr1.Dispose();
        dr1 = com1.ExecuteReader();

        while (dr1.Read())
        {
            menu_val += "<li><p><a href=\"" + dr1["link"] + "\" >" + dr1["text"] + "</a></p></li>";
        }

        menu_val += "</ul></div>";

        con1.Dispose();
        con1.Close();

        return menu_val;

    }
}