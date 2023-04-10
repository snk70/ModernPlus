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
public partial class prv_hgvgvhvhv_a_dd_hh_art : System.Web.UI.Page
{

    bool edi = false;
    string host_address;


    string r_F = "Null", r_paper = "", up_img = "", Body_Source = "";



    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            if (Session[Request.UserHostAddress].ToString() != Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString())
            {
                Session.RemoveAll();
                Response.Redirect("~/Error.html");
                return;
            }
        }
        catch
        {
            Session.RemoveAll();
            Response.Redirect("~/Error.html");
            return;
        }


        host_address = Request.Url.ToString().Replace(Request.RawUrl.ToString(), "");

        try
        {
            #region    //لود برای ویرایش است
            if (title_txt.Text == "")
            {
                r_paper = Request.Form["rp"].ToString();
                edi = true;
                Session["edi"] = 1;

                link_label.Visible = false;
                paper_link.Visible = false;

                r_F = "'" + r_paper + "'";

                btn_publish.Text = "تأیید و ویرایش مطلب";
                SqlConnection con2 = new SqlConnection(Connectionst.ConnectionString_Main);
                con2.Open();
                SqlCommand com2 = new SqlCommand("Select * From tbl_art Where(r='" + r_paper + "')", con2);
                SqlDataReader dr2 = com2.ExecuteReader();
                dr2.Read();

                title_txt.Text = dr2["title"].ToString();
                meta_key.Text = dr2["meta_title"].ToString();
                meta_desc.Text = dr2["meta_desc"].ToString();
                paper_cmt.Text = dr2["paper_cmt"].ToString();
                paper_link.Text = dr2["paper_link"].ToString();
                CKEditorControl1.Text = dr2["text_boy"].ToString().Replace("img_special_url_address_pic", host_address + "/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text);

                Session["img"] = up_img = dr2["img"].ToString();

                com2.Dispose();
                con2.Dispose();
                con2.Close();
                try
                {
                    if (Session["rp"].ToString() == "")
                    {
                        Session["rp"] = r_paper;
                    }
                    else
                    {
                        Session["rp"] = r_paper;
                    }
                }
                catch
                {
                    Session["rp"] = r_paper;
                }
            }
            #endregion

        }
        catch
        {

            #region   //لود برای حالت معمولی و درج مطلب است
            Session["edi"] = 0;
            edi = false;
            try
            {
                SqlConnection con1 = new SqlConnection(Connectionst.ConnectionString_Main);
                con1.Open();
                SqlCommand com1 = new SqlCommand("SELECT MAX(r) FROM tbl_art", con1);
                SqlDataReader dr1 = com1.ExecuteReader();
                dr1.Read();
                r_paper = Convert.ToString(Convert.ToInt32(dr1[0]) + 1);
                com1.Dispose();
                con1.Dispose();
                con1.Close();
            }
            catch
            {
                r_paper = "1";
            }

            try
            {
                if (Session["rp"].ToString() == "")
                {
                    Session["rp"] = r_paper;
                }
                else
                {
                    Session["rp"] = r_paper;
                }
            }
            catch
            {
                Session["rp"] = r_paper;
            }

            #endregion
        }
    }


    protected void btn_publish_Click(object sender, EventArgs e)
    {
        r_paper = Session["rp"].ToString();

        #region //اگر مطلب برای ویرایش بود
        if (Session["edi"].ToString() == "1")
        {
            up_img = Session["img"].ToString();

            Session["edi"] = 0;
            string url_post = Get_Path_in_Local_OR_Main.get("http://localhost/Modern_Plus/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/asdfansfjkasjkdfjwefkqwQR/dfgsdfgsdfgsdfgs_add_art_fdgs.php", host_address + "/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/asdfansfjkasjkdfjwefkqwQR/dfgsdfgsdfgsdfgs_add_art_fdgs.php");


            if (img_Upload.HasFile == true)
            {
                up_img = Session["img"].ToString();
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

            post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(url_post, "POST", "sgsjkdgjsdfg=del&del_r=" + paper_link.Text + "");
            if (wm.GetResponse() == "o")
            {
                try
                {
                    File.Delete(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/index.php"));
                }
                catch { }
                Clear_vain_Image();


                Body_Source = File.ReadAllText(MapPath("~/" + Edit_Content_class.Body_Source_path));

                PersianCalendar pc = new PersianCalendar();
                string dt = pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now);
                string tm = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

                dtsetTableAdapters.tbl_artTableAdapter tb = new dtsetTableAdapters.tbl_artTableAdapter();



                post_get_information.MyWebRequest wm2 = new post_get_information.MyWebRequest(url_post, "POST", "r='" + Session["rp"] + "'&title=" + title_txt.Text + "&img=" + up_img + "&cmt=" + paper_cmt.Text + "&link=" + paper_link.Text + "&sgsjkdgjsdfg=sdgsdfgsirdgenrgernger");

                dtset ds = new dtset();

                tb.Fill(ds.tbl_art);


                if (wm2.GetResponse() == "o")
                {
                    CKEditorControl1.Text = CKEditorControl1.Text.Replace(host_address + "/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text, "img_special_url_address_pic").Replace("/>",">");
                    File.WriteAllText(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/index.php"), Body_Source.Replace("text_body_paper", CKEditorControl1.Text.Replace("/>", ">")).Replace("title_paper", title_txt.Text).Replace("meta_keywords", meta_key.Text).Replace("meta_desc", meta_desc.Text).Replace("tbl_cmt_code", "art_" + r_paper).Replace("img_special_url_address_pic/", ""));
                    tb.UpdateQuery(title_txt.Text, CKEditorControl1.Text, dt, tm, "", Request.Url.ToString().Replace("hgvgvhvhv_a_dd_hh-art.aspx", "") + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text, meta_key.Text, meta_desc.Text, paper_cmt.Text, paper_link.Text, up_img, 0, int.Parse(Session["rp"].ToString()));
                    Session.RemoveAll();
                    Session[Request.UserHostAddress] = Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString();
                    Response.Redirect(Edit_Content_class.direct_URL);
                }
                else
                {
                    Response.Redirect("~/Error.html");
                }

            }

        }
        #endregion

        #region //اگر مطلب برای درج کردن جدید بود
        else if (Session["edi"].ToString() == "0")
        {
            if (img_Upload.HasFile && paper_link.Text != "")
            {
                up_img = img_Upload.FileName.ToString();
                Heade_IMG_Name();

                Body_Source = File.ReadAllText(MapPath("~/" + Edit_Content_class.Body_Source_path));

                PersianCalendar pc = new PersianCalendar();
                string dt = pc.GetYear(DateTime.Now) + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now);
                string tm = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

                dtsetTableAdapters.tbl_artTableAdapter tb = new dtsetTableAdapters.tbl_artTableAdapter();



                string url_post = Get_Path_in_Local_OR_Main.get("http://localhost/Modern_Plus/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/asdfansfjkasjkdfjwefkqwQR/dfgsdfgsdfgsdfgs_add_art_fdgs.php", host_address+ "/prv/dfgasdfgsdfgsdfgsdfg/yaheidar/asfgasgafdgdfgdsgsdfgsdfgsdfgsdfg/asdfansfjkasjkdfjwefkqwQR/dfgsdfgsdfgsdfgs_add_art_fdgs.php");
                post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(url_post, "POST", "r='" + Session["rp"] + "'&title=" + title_txt.Text + "&img=" + up_img + "&cmt=" + paper_cmt.Text + "&link=" + paper_link.Text + "&sgsjkdgjsdfg=sdgsdfgsirdgenrgernger");

                dtset ds = new dtset();

                tb.Fill(ds.tbl_art);


                if (wm.GetResponse() == "o" && File.Exists(MapPath("~/" + Edit_Content_class.Header_IMG_Location + "/" + up_img)) == false)
                {
                    CKEditorControl1.Text = CKEditorControl1.Text.Replace(host_address + "/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text, "img_special_url_address_pic").Replace("/>", ">");
                    Directory.CreateDirectory(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text));
                    File.WriteAllText(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/index.php"), Body_Source.Replace("text_body_paper", CKEditorControl1.Text.Replace("/>", ">")).Replace("title_paper", title_txt.Text).Replace("meta_keywords", meta_key.Text).Replace("meta_desc", meta_desc.Text).Replace("tbl_cmt_code", "art_" + r_paper).Replace("img_special_url_address_pic/", ""));
                    tb.InsertQuery(title_txt.Text, CKEditorControl1.Text, dt, tm, "", Request.Url.ToString().Replace("hgvgvhvhv_a_dd_hh-art.aspx", "") + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text, meta_key.Text, meta_desc.Text, paper_cmt.Text, paper_link.Text, up_img, 0);
                    img_Upload.SaveAs(MapPath("~/" + Edit_Content_class.Header_IMG_Location + "/" + up_img));
                    Session.RemoveAll();
                    Session[Request.UserHostAddress] = Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString();
                    Response.Redirect(Edit_Content_class.direct_URL);
                }
                else
                {
                    Response.Redirect("~/Error.html");
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





    protected void add_pic_Click(object sender, EventArgs e)
    {


        if (paper_link.Text != "" && Directory.Exists(MapPath("~/posts/" + paper_link.Text)) == false || Directory.Exists(MapPath("~/posts/" + paper_link.Text)) == true && Session["edi"].ToString() == "1")
        {

            Directory.CreateDirectory(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text));
            edi_add.SaveAs(MapPath("~/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/" + edi_add.FileName));

            CKEditorControl1.Text += "<img alt=\"\" src=\"" + host_address + "/" + Edit_Content_class.Posts_link_Path + "/" + paper_link.Text + "/" + edi_add.FileName + "\">";
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
        Response.Redirect(Edit_Content_class.direct_URL);
    }
}