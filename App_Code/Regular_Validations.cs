using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


   public class Regular_Validations
    {


        public static bool Email(string mail_Address)
        {

            string s = mail_Address;
            bool valid = true;


            if (s.IndexOf("@") == -1)
            {

                valid = false;

            }
            else if (s.IndexOf(".") == -1)
            {

                valid = false;

            }
            else
            {

                Int32 atsain = s.IndexOf("@");
                Int32 dat = s.IndexOf(".");

                if (s.IndexOf("@", atsain + 1) != -1)
                {

                    valid = false;

                }


                while (s.IndexOf(".", dat + 1) != -1)
                {

                    dat = s.IndexOf(".", dat + 1);

                }





                ///////////////////////////////////////////////////

                if (atsain > dat)
                {
                    valid = false;
                }



            }

            return valid;
        }



    }

