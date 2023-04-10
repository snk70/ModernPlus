<%@ Page Language="C#" %>

<%
    //try
    //{
    //    if (Session[Request.UserHostAddress].ToString() != Request.UserAgent.GetHashCode() + DateTime.Now.Hour.GetHashCode().ToString())
    //    {
    //        Session.RemoveAll();
    //        Response.Redirect("~/Error.html");
    //        return;
    //    }
    //}
    //catch
    //{
    //    Session.RemoveAll();
    //    Response.Redirect("~/Error.html");
    //    return;
    //}

    if (Request.QueryString["type"] == "art")
    {
        if (Request.QueryString["mode"] == "edit")
        {
            RemotePostData.RemotePost rm = new RemotePostData.RemotePost("arts_insert.aspx");
            rm.Add("link", Request.QueryString["link"]);
            rm.Add("mode", Request.QueryString["mode"].ToString());
            rm.Add("type", Request.Form["type"]);
            rm.Post();
        }
    }
    else if (Request.QueryString["type"] == "app")
    {
        if (Request.QueryString["mode"] == "edit")
        {
            RemotePostData.RemotePost rm = new RemotePostData.RemotePost("apps_insert.aspx");
            rm.Add("link", Request.QueryString["link"]);
            rm.Add("mode", Request.QueryString["mode"].ToString());
            rm.Add("type", Request.Form["type"]);
            rm.Post();
        }
    }    
%>