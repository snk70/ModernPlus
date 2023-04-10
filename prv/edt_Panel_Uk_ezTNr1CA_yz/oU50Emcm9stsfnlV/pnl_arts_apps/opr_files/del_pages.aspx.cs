using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using System.Globalization;
using System.Data.SqlClient;
using System.IO;

public partial class prv_edt_Panel_Uk_ezTNr1CA_yz_oU50Emcm9stsfnlV_pnl_arts_apps_opr_files_del_pages : System.Web.UI.Page
{
    string host_address;

    protected void Page_Load(object sender, EventArgs e)
    {

        host_address = Request.Url.ToString().Replace(Request.RawUrl.ToString(), "");

        SqlConnection con = new SqlConnection(Connectionst.ConnectionString_Main);
        con.Open();

        #region اگر مطلب بود
        if (Request.QueryString["posttype"] == "art")
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * From [tbl_art] Where (paper_link='" + Request.QueryString["link"] + "')", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                string url_post = Get_Path_in_Local_OR_Main.get("http://localhost/Modern_Plus_2.1/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/dfgsdfgsdfgsdfgs_add_art_fdgs.php", host_address + "/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/dfgsdfgsdfgsdfgs_add_art_fdgs.php");
                post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(url_post, "POST", "sgsjkdgjsdfg=del&del_r=" + dr["paper_link"] + "");

                if (wm.GetResponse() == "o")
                {
                    if (Directory.Exists(MapPath("~/" + Edit_Content_class.Posts_link_Path+"/" + dr["paper_link"])) == true)
                    {
                        Delete_Folder_With_Content(MapPath("~/" + Edit_Content_class.Posts_link_Path+"/" + dr["paper_link"]));
                        Directory.Delete(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + dr["paper_link"]));
                    }
                }
                else
                {
                    Response.Redirect("~/prv/error.aspx?p=حذف از MYSQL ناموفق بود");
                    return;
                }
                dr.Dispose();
                dr.Close();
                com.Dispose();
                com.Clone();

                com = new SqlCommand("Delete From [tbl_art] Where (paper_link='" + Request.QueryString["link"] + "')", con);
                com.ExecuteNonQuery();

                Response.Redirect(host_address + "/" + Edit_Content_class.ART_Manage);

            }
            catch (Exception d)
            {
                Response.Write(d.Message);
            }
        }
        #endregion

        #region اگر اپ بود
        else if (Request.QueryString["type"] == "app")
        {
            try
            {
                SqlCommand com = new SqlCommand("Select * From [tbl_app] Where (paper_link='" + Request.QueryString["link"] + "')", con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();

                string url_post = Get_Path_in_Local_OR_Main.get("http://localhost/Modern_Plus_2.1/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/sdfgsdfgsdfg_add_app.php", host_address + "/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/sdfgsdfgsdfg_add_app.php");
                post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(url_post, "POST", "sgsjkdgjsdfg=del&del_r=" + dr["paper_link"] + "");

                if (wm.GetResponse() == "o")
                {
                    if (Directory.Exists(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + dr["paper_link"])) == true)
                    {
                        Delete_Folder_With_Content(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + dr["paper_link"]));
                        Directory.Delete(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + dr["paper_link"]));
                    }
                }
                else
                {
                    Response.Redirect("~/prv/error.aspx?p=حذف از MYSQL ناموفق بود");
                    return;
                }
                dr.Dispose();
                dr.Close();
                com.Dispose();
                com.Clone();

                com = new SqlCommand("Delete From [tbl_app] Where (paper_link='" + Request.QueryString["link"] + "')", con);
                com.ExecuteNonQuery();

                Response.Redirect(host_address + "/" + Edit_Content_class.APP_Manage);

            }
            catch (Exception d)
            {
                Response.Write(d.Message);
            }
        }
        #endregion

        con.Dispose();
        con.Close();

    }

    private void Delete_Folder_With_Content(string Folder_Path)
    {
        string[] filePaths = Directory.GetFiles(Folder_Path);
        foreach (string filePath in filePaths)
            File.Delete(filePath);
    }


}
