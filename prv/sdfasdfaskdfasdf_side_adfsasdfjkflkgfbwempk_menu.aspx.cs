using System;
using System.Data.SqlClient;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

public partial class prv_sdfasdfaskdfasdf_side_adfsasdfjkflkgfbwempk_menu : System.Web.UI.Page
{
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
    }
    protected void btn_insert_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(Connectionst.ConnectionString_Main);
        con.Open();
        SqlCommand com = new SqlCommand("Insert Into ["+select_cat.SelectedValue.ToString()+"] ([text],[link]) Values (N'"+txt_text.Text+"',N'"+txt_link.Text+"')", con);
         com.ExecuteNonQuery();
        con.Dispose();
        con.Close();
        Response.Redirect(Request.Url.ToString());
    }
    protected void btn_back_Click(object sender, EventArgs e)
    {
        Response.Redirect(Edit_Content_class.direct_URL);        
    }
}