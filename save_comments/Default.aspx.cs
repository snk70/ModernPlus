using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class save_comments_Default : System.Web.UI.Page
{
    string host_address = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        host_address = Request.Url.ToString().Replace(Request.RawUrl.ToString(), "");

        PersianCalendar pc = new PersianCalendar();
        Anti_Injection.Anti_SQL_Injection ant = new Anti_Injection.Anti_SQL_Injection();

        string name = ant.Filter_Text(Request.Form["name"]);
        string mail = ant.Filter_Text(Request.Form["mail"]);
        string cmt = ant.Filter_Text(Request.Form["cmt"]);
        string date = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now) + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
        string time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        string tb = ant.Filter_Text(Request.Form["tb"]);






        //بررسی و اعتبار سنجی اطلاعات وارد شده


        if (name == "" || cmt == "" || mail == "" || Regular_Validations.Email(mail) == false)
        {

            dv1.InnerHtml = "<center>";
            dv1.InnerHtml += ("<p class=\"err\" style=\"font-size :45px;\">خطا</p>");
            if (name == "")
            {
                dv1.InnerHtml += ("<p class=\"pt1\">" + "لطفا نام خود را وارد نمایید" + "</p>");

            }
            if (mail == "")
            {
                dv1.InnerHtml += ("<p class=\"pt1\">" + "لطفا آدرس ایمیل خود را وارد نمایید" + "</p>");

            }
            else if (Regular_Validations.Email(mail) == false)
            {
                dv1.InnerHtml += ("<p class=\"pt1\">" + "لطفا آدرس ایمیل خود را صحیح وارد نمایید" + "</p>");

            }
            if (cmt == "")
            {

                dv1.InnerHtml += ("<p class=\"pt1\">" + "لطفا پیام خود را وارد نمایید" + "</p>");

            }

            dv1.InnerHtml += "</center>";





        }
        else
        {

            String Save_Path = Save_Path = Get_Path_in_Local_OR_Main.get("http://localhost/Modern_Plus/prv/adg/gfdf/fghdfgh.php", host_address + "/prv/adg/gfdf/fghdfgh.php");

            post_get_information.MyWebRequest wm = new post_get_information.MyWebRequest(Save_Path, "POST", "tb_cmt=" + tb + "&cmt=" + cmt + "&ip=" + HttpContext.Current.Request.UserHostAddress.ToString() + "&name=" + name + "&mail=" + mail + "&date=" + date + "&time=" + time + "&yamahmi=agelalazohorek");
            String query_result = wm.GetResponse();



            if (query_result == "1")
            {
                dv1.InnerHtml = "<br /><br /><br /><br /><br /><br /><br /><br /><br /><center><p class=\"pt1\" style=\"font-size:30px;\">با تشکر ؛ نظر شما ثبت شد و در حال بررسی میباشد</p><p class=\"pt1\" style=\"font-size:30px;\">برای انتقال به صفحه اصلی <a class=\"pt1\" href=\"http://www.modernplus.ir\"> اینجا کلیک کنید</a> .</p></center>";

            }


        }
    }
}