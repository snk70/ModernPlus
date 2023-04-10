using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using System.Globalization;
using System.Data.SqlClient;
using System.IO;

//صفحه مطالب

public partial class prv_edt_Panel_Uk_ezTNr1CA_yz_oU50Emcm9stsfnlV_pnl_arts_apps_arts_mng : System.Web.UI.Page
{

    bool edi = false;
    string host_address;

    string telegram_share_link = "";
    string r_F = "Null", L_paper = "", up_img = "", Body_Source = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Request.Form["mode"] == "edit")
            {
                try
                {
                    #region    //لود برای ویرایش است
                    if (title_txt.Text == "")
                    {
                        L_paper = Request.Form["link"];

                        lbl_mode.Text = "edit";

                        link_label.Visible = false;
                        paper_link.Visible = false;


                        btn_publish.Text = "تأیید و ویرایش مطلب";
                        SqlConnection con2 = new SqlConnection(Connectionst.ConnectionString_Main);
                        con2.Open();
                        SqlCommand com2 = new SqlCommand("Select * From tbl_art Where(paper_link='" + L_paper + "')", con2);
                        SqlDataReader dr2 = com2.ExecuteReader();
                        dr2.Read();

                        title_txt.Text = dr2["title"].ToString();
                        meta_key.Text = dr2["meta_title"].ToString();
                        meta_desc.Text = dr2["meta_desc"].ToString();
                        paper_cmt.Text = dr2["paper_cmt"].ToString();
                        paper_link.Text = dr2["paper_link"].ToString();
                        lbl_row.Text = dr2["r"].ToString();
                        CKEditorControl1.Text = dr2["text_boy"].ToString().Replace("img_special_url_address_pic", host_address + "/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text);
                        lbl_up_img.Text = up_img = dr2["img"].ToString();

                        com2.Dispose();
                        con2.Dispose();
                        con2.Close();
                    }
                    #endregion

                }
                catch { }
            }
        }
        catch { }

    }


    protected void btn_publish_Click(object sender, EventArgs e)
    {
        #region //اگر مطلب برای ویرایش بود
        if (lbl_mode.Text == "edit")
        {
            up_img = lbl_up_img.Text;

            //string url_post = Get_Path_in_Local_OR_Main.get("http://localhost/Modern_Plus/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/asdfansfjkasjkdfjwefkqwQR/dfgsdfgsdfgsdfgs_add_art_fdgs.php", host_address + "/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/asdfansfjkasjkdfjwefkqwQR/dfgsdfgsdfgsdfgs_add_art_fdgs.php");


            if (img_Upload.HasFile == true)
            {
                up_img = lbl_up_img.Text;
                //s1.Text = up_img;
                //return;
                try
                {
                    File.Delete(MapPath("~/" + Edit_Content_class.Header_IMG_Location + "/" + up_img));
                }
                catch
                { }
                up_img = img_Upload.FileName.ToString();
                Heade_IMG_Name();
                img_Upload.SaveAs(MapPath("~/" + Edit_Content_class.Header_IMG_Location + "/" + up_img));
            }

            //post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(url_post, "POST", "sgsjkdgjsdfg=del&del_r=" + paper_link.Text + "");
            //if (wm.GetResponse() == "o")
            {
                Clear_vain_Image();


                post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(Request.Url.ToString().Replace(Request.RawUrl.ToString(), "/Master_Pages/post_show.aspx?type=art&link=" + paper_link.Text));
                Body_Source = wm.GetResponse();

                PersianCalendar pc = new PersianCalendar();
                string dt = pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now);
                string tm = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

                dtsetTableAdapters.tbl_artTableAdapter tb = new dtsetTableAdapters.tbl_artTableAdapter();



                //post_get_information.MyWebRequest wm2 = new post_get_information.MyWebRequest(url_post, "POST", "r='" + Session["rp"] + "'&title=" + title_txt.Text + "&img=" + up_img + "&cmt=" + paper_cmt.Text + "&link=" + paper_link.Text + "&sgsjkdgjsdfg=sdgsdfgsirdgenrgernger");

                dtset ds = new dtset();

                tb.Fill(ds.tbl_art);


                //if (wm2.GetResponse() == "o")
                {
                    CKEditorControl1.Text = CKEditorControl1.Text.Replace(host_address + "/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text, "img_special_url_address_pic").Replace("/>", ">");
                    //File.WriteAllText(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/index.php"), Body_Source.Replace("text_body_paper", CKEditorControl1.Text.Replace("/>", ">")).Replace("title_paper", title_txt.Text).Replace("meta_keywords", meta_key.Text).Replace("meta_desc", meta_desc.Text).Replace("tbl_cmt_code", "art_" + L_paper).Replace("img_special_url_address_pic/", ""));
                    tb.UpdateQuery(title_txt.Text, CKEditorControl1.Text, dt, tm, "","", meta_key.Text, meta_desc.Text, paper_cmt.Text, paper_link.Text, up_img, 0, Convert.ToInt32(lbl_row.Text));
                    Session.RemoveAll();
                    //Session[Request.UserHostAddress] = Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString();
                    Response.Redirect("~/prv/edt_Panel_Uk_ezTNr1CA_yz/oU50Emcm9stsfnlV/pnl_arts_apps/arts_mng.aspx");
                }
                //else
                //{
                //    Response.Redirect("~/Error.html");
                //}
            }
        }
        #endregion

        #region //اگر مطلب برای درج کردن جدید بود
        else if (lbl_mode.Text == "new")
        {

            if(Directory.Exists(MapPath("~/"+Edit_Content_class.Posts_link_Path+"/"+paper_link.Text)))
            {
                Response.Redirect("~/prv/error.aspx?p=لینک مطلب تکراری است");
                return;
            }

            if (img_Upload.HasFile && paper_link.Text != "")
            {
                up_img = img_Upload.FileName.ToString();
                Heade_IMG_Name();


                post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(Request.Url.ToString().Replace(Request.RawUrl.ToString(), "/Master_Pages/post_show.aspx?type=art&link=" + paper_link.Text));
                Body_Source = wm.GetResponse();
                //Body_Source = File.ReadAllText(MapPath("~/" + Edit_Content_class.Body_Source_path));

                PersianCalendar pc = new PersianCalendar();
                string dt = pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now);
                string tm = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

                dtsetTableAdapters.tbl_artTableAdapter tb = new dtsetTableAdapters.tbl_artTableAdapter();



                //post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(url_post, "POST", "r='" + Session["rp"] + "'&title=" + title_txt.Text + "&img=" + up_img + "&cmt=" + paper_cmt.Text + "&link=" + paper_link.Text + "&sgsjkdgjsdfg=sdgsdfgsirdgenrgernger");

                dtset ds = new dtset();

                tb.Fill(ds.tbl_art);


                if (File.Exists(MapPath("~/" + Edit_Content_class.Header_IMG_Location + "/" + up_img)) == false)
                {
                    CKEditorControl1.Text = CKEditorControl1.Text.Replace(host_address + "/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text, "img_special_url_address_pic").Replace("/>", ">");
                    Directory.CreateDirectory(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text));
                    //File.WriteAllText(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/index.php"), Body_Source.Replace("text_body_paper", CKEditorControl1.Text.Replace("/>", ">")).Replace("title_paper", title_txt.Text).Replace("meta_keywords", meta_key.Text).Replace("meta_desc", meta_desc.Text).Replace("tbl_cmt_code", "art_" + L_paper).Replace("img_special_url_address_pic/", ""));
                    tb.InsertQuery(title_txt.Text, CKEditorControl1.Text, dt, tm, "", telegram_share_link, meta_key.Text, meta_desc.Text, paper_cmt.Text, paper_link.Text, up_img, 0);
                    img_Upload.SaveAs(MapPath("~/" + Edit_Content_class.Header_IMG_Location + "/" + up_img));
                    Session.RemoveAll();
                    //Session[Request.UserHostAddress] = Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString();
                    Response.Redirect("~/prv/edt_Panel_Uk_ezTNr1CA_yz/oU50Emcm9stsfnlV/pnl_arts_apps/arts_mng.aspx");
                }
                else
                {
                    Response.Redirect("~/prv/error.aspx?p=آدرس عکس تکراری است");
                }
            }
        }
        #endregion
    }

    
    void Heade_IMG_Name()
    {
        if (File.Exists(MapPath("~/" + Edit_Content_class.Header_IMG_Location + "/" + up_img)) == true)
        {
            up_img = DateTime.Now.Year.ToString() + "_" + up_img;
            if (File.Exists(MapPath("~/" + Edit_Content_class.Header_IMG_Location + "/" + up_img)) == true)
            {
                up_img = DateTime.Now.Second.ToString() + "_" + up_img;
                Heade_IMG_Name();
            }
        }
    }

    void Clear_vain_Image()
    {
        string[] images_path = Directory.GetFiles(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text));
        string image_Name = "";

        for (int x = 0; x < images_path.Length; x++)
        {
            image_Name = images_path[x].Replace(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/"), "");
            if (CKEditorControl1.Text.IndexOf(image_Name) == -1)
            {
                File.Delete(images_path[x]);
            }
        }
    }


    protected void btn_cp_Click(object sender, EventArgs e)
    {

    }
    protected void add_pic_Click(object sender, EventArgs e)
    {


        if (paper_link.Text != "" && Directory.Exists(MapPath("~/posts/" + paper_link.Text)) == false || Directory.Exists(MapPath("~/posts/" + paper_link.Text)) == true)
        {
            Directory.CreateDirectory(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text));
            edi_add.SaveAs(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/" + edi_add.FileName));

            CKEditorControl1.Text += "<img alt=\"\" src=\"" + host_address + "/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/" + edi_add.FileName + "\">";
        }
    }
}