using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class Contact_Comment_order : System.Web.UI.Page
{
    string host_address = "";


    protected void Page_Load(object sender, EventArgs e)
    {

        host_address = Request.Url.ToString().Replace(Request.RawUrl.ToString(), "");


        PersianCalendar pc = new PersianCalendar();
        Anti_Injection.Anti_SQL_Injection ant = new Anti_Injection.Anti_SQL_Injection();



        string type = "سفارش";
        string name = ant.Filter_Text(Request.Form["name"]);
        string mail = ant.Filter_Text(Request.Form["mail"]);
        string cmt = type + "\n" + "and : " + Request.Form["and"] + "\n" + "web : " + Request.Form["web"] + "\n" + "win : " + Request.Form["win"] + "\n" + "\n" + Request.Form["cmt"];
        cmt = ant.Filter_Text(cmt);

        string date = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
        string time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();



        //بررسی و اعتبار سنجی اطلاعات وارد شده


        if (name == "" || cmt == "" || mail == "")
        {

            dv1.InnerHtml = "<center>";
            dv1.InnerHtml += ("<p class=\"err\" style=\"font-size :45px;\">خطا</p>");
            if (name == "")
            {
                dv1.InnerHtml += ("<p class=\"pt1\">" + "لطفا نام خود را وارد نمایید" + "</p>");

            }
            if (mail == "")
            {
                dv1.InnerHtml += ("<p class=\"pt1\">" + "لطفا آدرس ایمیل یا شماره تماس خود را وارد نمایید" + "</p>");

            }

            if (Request.Form["cmt"] == "")
            {

                dv1.InnerHtml += ("<p class=\"pt1\">" + "لطفا پیام خود را وارد نمایید" + "</p>");

            }

            dv1.InnerHtml += "</center>";
        }
        else
        {
            String Save_Path = Get_Path_in_Local_OR_Main.get("http://localhost/Modern_Plus/prv/adg/gfdf/fdgsdfgsdfgsdg.php", host_address + "/prv/adg/gfdf/fdgsdfgsdfgsdg.php");

            post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(Save_Path, "POST", "name=" + name + "&mail=" + mail + "&cmt=" + cmt + "&date=" + date + "&time=" + time + "&ip=" + Request.UserHostAddress.ToString() + "&sina=yahossein");
            String Query_Result = wm.GetResponse();
            if (Query_Result == "1")
            {
                dv1.InnerHtml = "<br /><br /><br /><br /><br /><br /><br /><br /><br /><center><p class=\"pt1\">با تشکر از شما ؛ سفارش شما ثبت شد و در اسرع وقت با شما تماس گرفته میشود .</p><p class=\"pt1\">برای انتقال به صفحه اصلی <a class=\"pt1\" href=\"http://www.modernplus.ir\"> اینجا کلیک کنید</a> .</p></center>";

            }

        }

    }
}