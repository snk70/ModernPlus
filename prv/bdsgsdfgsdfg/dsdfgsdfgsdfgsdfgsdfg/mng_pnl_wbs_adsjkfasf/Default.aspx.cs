using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

public partial class prv_bdsgsdfgsdfg_dsdfgsdfgsdfgsdfgsdfg_mng_pnl_wbs_adsjkfasf_Default : System.Web.UI.Page
{
    string host_address;

    protected void Page_Load(object sender, EventArgs e)
    {
        host_address = Request.Url.ToString().Replace(Request.RawUrl.ToString(), "");

        try
        {
            if (Session[Request.UserHostAddress].ToString() == Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString())
            {
                correct_info(true);
            }
            else
            {
                correct_info(false);
            }
        }
        catch
        {
            correct_info(false);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if ((txt_username.Text == "sina" || txt_username.Text == "soroush") && txt_pass.Text == "snk@7975#sou")
        {
            Response.Write("<p class=\"right\">سلام " + txt_username.Text + "</p>");
            correct_info(true);
            Session[Request.UserHostAddress] = Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString();
            Session.Timeout = 2000;

        }
        else
        {
            Session.RemoveAll();
            Response.Redirect("~/Error.html");
        }

    }

    void correct_info(bool inf)
    {
        if (inf == true)
        {
            btn_comments_contacts.Visible = true;
            btn_Exit.Visible = true;
            Button1.Visible = false;
            txt_username.Visible = false;
            txt_pass.Visible = false;
            btn_insert_app.Visible = true;
            btn_edit_menu.Visible = true;
            btn_refresh_menu.Visible = true;
            btn_insert_art.Visible = true;
            btn_refresh.Visible = true;
            btn_refresh_sitemap.Visible = true;
            Session.Timeout = 9999;

        }
        else if (inf == false)
        {
            btn_comments_contacts.Visible = false;
            btn_Exit.Visible = false;
            Button1.Visible = true;
            txt_username.Visible = true;
            txt_pass.Visible = true;
            btn_insert_app.Visible = false;
            btn_edit_menu.Visible = false;
            btn_insert_art.Visible = false;
            btn_refresh_menu.Visible = false;
            btn_refresh.Visible = false;
            btn_refresh_sitemap.Visible = false;
        }

    }


    protected void btn_refresh_sitemap_Click(object sender, EventArgs e)
    {
        //post_get_information.MyWebRequest wm1 = new post_get_information.MyWebRequest(host_address + "/prv/Content _tools_dfgkdk/Default.aspx", "POST", "type=sitemap");
        //wm1.GetResponse();

        RemotePostData.RemotePost rmt = new RemotePostData.RemotePost(host_address + "/prv/Content _tools_dfgkdk/Default.aspx");
        rmt.Add("type", "sitemap");
        rmt.Post();
    }
    protected void btn_refresh_Click(object sender, EventArgs e)
    {
    //    post_get_information.MyWebRequest wm1 = new post_get_information.MyWebRequest(host_address + "/prv/Content _tools_dfgkdk/Default.aspx", "POST", "type=index");
    //    wm1.GetResponse();

        RemotePostData.RemotePost rmt = new RemotePostData.RemotePost(host_address + "/prv/Content _tools_dfgkdk/Default.aspx");
        rmt.Add("type", "index");
        rmt.Post();

    }
    protected void btn_insert_art_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/prv/hgvgvhvhv_a_dd_hh-art.aspx");
    }
    protected void btn_insert_app_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/prv/odfngsnd,fg_app.aspx");
    }
    protected void btn_Exit_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect(Request.Url.ToString());
    }
    protected void btn_refresh_menu_Click(object sender, EventArgs e)
    {
        RemotePostData.RemotePost rmt = new RemotePostData.RemotePost(host_address + "/prv/Content _tools_dfgkdk/Default.aspx");
        rmt.Add("type", "menu");
        rmt.Post();
    }
    protected void btn_edit_menu_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/prv/sdfasdfaskdfasdf_side_adfsasdfjkflkgfbwempk_menu.aspx");        
    }
    protected void btn_comments_contacts_Click1(object sender, EventArgs e)
    {
        Response.Redirect("~/prv/Content _tools_dfgkdk/adffs_comments_fdg.php");
    }
}