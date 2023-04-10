using System;
using System.IO;
/// <summary>
/// Summary description for Delete_full_Directory
/// </summary>
public class Delete_full_Directory
{
    public static void Delete_DIR(string path_dir)
    {
        if(Directory.Exists(path_dir)==true)
        {
            try
            {
                Directory.Delete(path_dir,true);
            }
            catch
            {
                Delete_DIR(path_dir);
            }
        }
    }
}