using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Get_Path_in_Local_OR_Main
/// </summary>
public class Get_Path_in_Local_OR_Main
{
	public Get_Path_in_Local_OR_Main()
	{
       
	}

    public static string get(string local_Path,string main_Path)
    {

        if (main_Path.IndexOf("localhost") != -1)
        {
            return local_Path;

        }else
        {
            return main_Path;
        }

    }

}