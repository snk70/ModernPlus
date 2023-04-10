
namespace Pay_Port_Server_Side
{
    public class Pay_Port_sc
    {

        public string Hardware_Licence, Product_Serial, Software_licence;




        public void Decomposition_Hardware_licence(string H_licence)
        {

            H_licence = H_licence.Substring(4, H_licence.Length - 4) + H_licence.Substring(0, 4);

            H_licence = Decryption_stn1(H_licence);

            Hardware_Licence = H_licence.Substring(0, H_licence.Length - 6);

            Hardware_Licence = Base64Decode(Hardware_Licence);

            Product_Serial = H_licence.Substring(H_licence.Length - 6, 6);

        }


        public string Creat_Software_Licence(string H_Licence, string P_ID)
        {
            string s_Licence = "";
            s_Licence = H_Licence + Base64Encode(P_ID);
            s_Licence = Encryption_stn1(s_Licence);
            s_Licence = Encryption_stn2(s_Licence);

            s_Licence = s_Licence.Substring(6, s_Licence.Length - 6) + s_Licence.Substring(0, 6);

            return s_Licence;
        }





        public string Encryption_stn1(string inp)
        {
            string txt = "", tx2, tx1 = inp;
            for (int i = 0; i < inp.Length; i++)
            {
                tx2 = tx1.Remove(1, tx1.Length - 1);
                tx1 = tx1.Remove(0, 1);
                txt += sina_ENC_stn1(tx2);
            }
            return txt;
        }


        public string sina_ENC_stn1(string v)
        {
            if (v == "0")
            {
                return "8TrD";
            }
            else if (v == "1")
            {
                return "dG3I";
            }
            else if (v == "2")
            {
                return "lKj^";
            }
            else if (v == "3")
            {
                return "U-Wx";
            }
            else if (v == "4")
            {
                return "cq`c";
            }
            else if (v == "5")
            {
                return "B&Up";
            }
            else if (v == "7")
            {
                return "3^n?";
            }
            else if (v == "8")
            {
                return "gT^2";
            }
            else if (v == "9")
            {
                return "Z+.c";
            }
            else if (v == "a")
            {
                return "p].D";
            }
            else if (v == "b")
            {
                return "<Jc)";
            }
            else if (v == "c")
            {
                return ",<e1";
            }
            else if (v == "d")
            {
                return "d)]t";
            }
            else if (v == "e")
            {
                return "Dnrw";
            }
            else if (v == "f")
            {
                return "64Sy";
            }
            else if (v == "g")
            {
                return "evOV";
            }
            else if (v == "h")
            {
                return "W3g&";
            }
            else if (v == "i")
            {
                return "KUBo";
            }
            else if (v == "j")
            {
                return "oF])";
            }
            else if (v == "k")
            {
                return "=jQ(";
            }
            else if (v == "l")
            {
                return "1BN&";
            }
            else if (v == "m")
            {
                return "_/!$";
            }
            else if (v == "n")
            {
                return "BsH/";
            }
            else if (v == "o")
            {
                return "8T$4";
            }
            else if (v == "p")
            {
                return ",)2]";
            }
            else if (v == "q")
            {
                return "Jq,N";
            }
            else if (v == "r")
            {
                return "{$]T";
            }
            else if (v == "s")
            {
                return "kGhY";
            }
            else if (v == "t")
            {
                return "T?W)";
            }
            else if (v == "u")
            {
                return "}+=p";
            }
            else if (v == "v")
            {
                return "jEK2";
            }
            else if (v == "w")
            {
                return "gy**";
            }
            else if (v == "x")
            {
                return "K7fM";
            }
            else if (v == "y")
            {
                return "VN=%";
            }
            else if (v == "z")
            {
                return "RC4T";
            }
            else if (v == "A")
            {
                return "/dhN";
            }
            else if (v == "B")
            {
                return "MBI_";
            }
            else if (v == "C")
            {
                return "FkZz";
            }
            else if (v == "D")
            {
                return "_Wx.";
            }
            else if (v == "E")
            {
                return "L`9s";
            }
            else if (v == "F")
            {
                return "x98&";
            }
            else if (v == "G")
            {
                return "%z/?";
            }
            else if (v == "H")
            {
                return "1glP";
            }
            else if (v == "I")
            {
                return "8OtO";
            }
            else if (v == "J")
            {
                return "B-D_";
            }
            else if (v == "K")
            {
                return ".3b!";
            }
            else if (v == "L")
            {
                return "e2[2";
            }
            else if (v == "M")
            {
                return "DtJ`";
            }
            else if (v == "N")
            {
                return "5t*5";
            }
            else if (v == "O")
            {
                return "UB^~";
            }
            else if (v == "P")
            {
                return "+yKp";
            }
            else if (v == "Q")
            {
                return "KUlK";
            }
            else if (v == "R")
            {
                return "~odq";
            }
            else if (v == "S")
            {
                return "#qi$";
            }
            else if (v == "T")
            {
                return "$3Qw";
            }
            else if (v == "U")
            {
                return "83x}";
            }
            else if (v == "V")
            {
                return "Inz.";
            }
            else if (v == "W")
            {
                return "$IO{";
            }
            else if (v == "X")
            {
                return ",7&L";
            }
            else if (v == "Y")
            {
                return ",fH?";
            }
            else if (v == "Z")
            {
                return "tj1}";
            }
            else if (v == "~")
            {
                return "<^dt";
            }
            else if (v == "`")
            {
                return "Gmp`";
            }
            else if (v == "!")
            {
                return "D=jX";
            }
            else if (v == "#")
            {
                return "F`mE";
            }
            else if (v == "$")
            {
                return "W44?";
            }
            else if (v == "%")
            {
                return "<LG4";
            }
            else if (v == "^")
            {
                return "plD/";
            }
            else if (v == "&")
            {
                return "#uk{";
            }
            else if (v == "*")
            {
                return "L,n[";
            }
            else if (v == "(")
            {
                return ">}(G";
            }
            else if (v == ")")
            {
                return "R}M6";
            }
            else if (v == "_")
            {
                return "_`mg";
            }
            else if (v == "-")
            {
                return ".%jm";
            }
            else if (v == "=")
            {
                return "iAs}";
            }
            else if (v == "+")
            {
                return "bGqV";
            }
            else if (v == "/")
            {
                return "[,f[";
            }
            else if (v == "?")
            {
                return "{`6T";
            }
            else if (v == "<")
            {
                return "sXCJ";
            }
            else if (v == ">")
            {
                return "l83=";
            }
            else if (v == ".")
            {
                return "%N6I";
            }
            else if (v == "{")
            {
                return "IS-4";
            }
            else if (v == "}")
            {
                return "bV?P";
            }
            else if (v == "[")
            {
                return "2Mw}";
            }
            else if (v == "]")
            {
                return "i%Oz";
            }
            else if (v == ",")
            {
                return "J+,7";
            }
            else if (v == "'")
            {
                return "1BB^";
            }
            else if (v == "6")
            {
                return "r,W5";
            }
            else
            {
                return v + v + v + v;
            }
        }





        public string Decryption_stn1(string inp)
        {
            int lng = 4;
            string txt = "", tx2, tx1 = inp;
            for (int i = 0; i < inp.Length / lng; i++)
            {
                tx2 = tx1.Remove(lng, tx1.Length - lng);
                tx1 = tx1.Remove(0, lng);
                txt += sina_DEC_stn1(tx2);
            }
            return txt;
        }


        public string sina_DEC_stn1(string v)
        {
            if (v == "8TrD")
            {
                return "0";
            }
            else if (v == "dG3I")
            {
                return "1";
            }
            else if (v == "lKj^")
            {
                return "2";
            }
            else if (v == "U-Wx")
            {
                return "3";
            }
            else if (v == "cq`c")
            {
                return "4";
            }
            else if (v == "B&Up")
            {
                return "5";
            }
            else if (v == "3^n?")
            {
                return "7";
            }
            else if (v == "gT^2")
            {
                return "8";
            }
            else if (v == "Z+.c")
            {
                return "9";
            }
            else if (v == "p].D")
            {
                return "a";
            }
            else if (v == "<Jc)")
            {
                return "b";
            }
            else if (v == ",<e1")
            {
                return "c";
            }
            else if (v == "d)]t")
            {
                return "d";
            }
            else if (v == "Dnrw")
            {
                return "e";
            }
            else if (v == "64Sy")
            {
                return "f";
            }
            else if (v == "evOV")
            {
                return "g";
            }
            else if (v == "W3g&")
            {
                return "h";
            }
            else if (v == "KUBo")
            {
                return "i";
            }
            else if (v == "oF])")
            {
                return "j";
            }
            else if (v == "=jQ(")
            {
                return "k";
            }
            else if (v == "1BN&")
            {
                return "l";
            }
            else if (v == "_/!$")
            {
                return "m";
            }
            else if (v == "BsH/")
            {
                return "n";
            }
            else if (v == "8T$4")
            {
                return "o";
            }
            else if (v == ",)2]")
            {
                return "p";
            }
            else if (v == "Jq,N")
            {
                return "q";
            }
            else if (v == "{$]T")
            {
                return "r";
            }
            else if (v == "kGhY")
            {
                return "s";
            }
            else if (v == "T?W)")
            {
                return "t";
            }
            else if (v == "}+=p")
            {
                return "u";
            }
            else if (v == "jEK2")
            {
                return "v";
            }
            else if (v == "gy**")
            {
                return "w";
            }
            else if (v == "K7fM")
            {
                return "x";
            }
            else if (v == "VN=%")
            {
                return "y";
            }
            else if (v == "RC4T")
            {
                return "z";
            }
            else if (v == "/dhN")
            {
                return "A";
            }
            else if (v == "MBI_")
            {
                return "B";
            }
            else if (v == "FkZz")
            {
                return "C";
            }
            else if (v == "_Wx.")
            {
                return "D";
            }
            else if (v == "L`9s")
            {
                return "E";
            }
            else if (v == "x98&")
            {
                return "F";
            }
            else if (v == "%z/?")
            {
                return "G";
            }
            else if (v == "1glP")
            {
                return "H";
            }
            else if (v == "8OtO")
            {
                return "I";
            }
            else if (v == "B-D_")
            {
                return "J";
            }
            else if (v == ".3b!")
            {
                return "K";
            }
            else if (v == "e2[2")
            {
                return "L";
            }
            else if (v == "DtJ`")
            {
                return "M";
            }
            else if (v == "5t*5")
            {
                return "N";
            }
            else if (v == "UB^~")
            {
                return "O";
            }
            else if (v == "+yKp")
            {
                return "P";
            }
            else if (v == "KUlK")
            {
                return "Q";
            }
            else if (v == "~odq")
            {
                return "R";
            }
            else if (v == "#qi$")
            {
                return "S";
            }
            else if (v == "$3Qw")
            {
                return "T";
            }
            else if (v == "83x}")
            {
                return "U";
            }
            else if (v == "Inz.")
            {
                return "V";
            }
            else if (v == "$IO{")
            {
                return "W";
            }
            else if (v == ",7&L")
            {
                return "X";
            }
            else if (v == ",fH?")
            {
                return "Y";
            }
            else if (v == "tj1}")
            {
                return "Z";
            }
            else if (v == "<^dt")
            {
                return "~";
            }
            else if (v == "Gmp`")
            {
                return "`";
            }
            else if (v == "D=jX")
            {
                return "!";
            }
            else if (v == "F`mE")
            {
                return "#";
            }
            else if (v == "W44?")
            {
                return "$";
            }
            else if (v == "<LG4")
            {
                return "%";
            }
            else if (v == "plD/")
            {
                return "^";
            }
            else if (v == "#uk{")
            {
                return "&";
            }
            else if (v == "L,n[")
            {
                return "*";
            }
            else if (v == ">}(G")
            {
                return "(";
            }
            else if (v == "R}M6")
            {
                return ")";
            }
            else if (v == "_`mg")
            {
                return "_";
            }
            else if (v == ".%jm")
            {
                return "-";
            }
            else if (v == "iAs}")
            {
                return "=";
            }
            else if (v == "bGqV")
            {
                return "+";
            }
            else if (v == "[,f[")
            {
                return "/";
            }
            else if (v == "{`6T")
            {
                return "?";
            }
            else if (v == "sXCJ")
            {
                return "<";
            }
            else if (v == "l83=")
            {
                return ">";
            }
            else if (v == "%N6I")
            {
                return ".";
            }
            else if (v == "IS-4")
            {
                return "{";
            }
            else if (v == "bV?P")
            {
                return "}";
            }
            else if (v == "2Mw}")
            {
                return "[";
            }
            else if (v == "i%Oz")
            {
                return "]";
            }
            else if (v == "J+,7")
            {
                return ",";
            }
            else if (v == "1BB^")
            {
                return "'";
            }
            else if (v == "r,W5")
            {
                return "6";
            }
            else
            {
                return v.Remove(1);
            }
        }


        ///////////////////////////////////////


        public string Encryption_stn2(string inp)
        {
            string txt = "", tx2, tx1 = inp;
            for (int i = 0; i < inp.Length; i++)
            {
                tx2 = tx1.Remove(1, tx1.Length - 1);
                tx1 = tx1.Remove(0, 1);
                txt += sina_ENC_stn2(tx2);
            }
            return txt;
        }


        public string sina_ENC_stn2(string v)
        {
            if (v == "0")
            {
                return "_%";
            }
            else if (v == "1")
            {
                return "8i";
            }
            else if (v == "2")
            {
                return "-f";
            }
            else if (v == "3")
            {
                return "?1";
            }
            else if (v == "4")
            {
                return "JM";
            }
            else if (v == "5")
            {
                return "<*";
            }
            else if (v == "7")
            {
                return "qO";
            }
            else if (v == "8")
            {
                return "[/";
            }
            else if (v == "9")
            {
                return "D>";
            }
            else if (v == "a")
            {
                return "JF";
            }
            else if (v == "b")
            {
                return "y/";
            }
            else if (v == "c")
            {
                return "7Q";
            }
            else if (v == "d")
            {
                return "TS";
            }
            else if (v == "e")
            {
                return "zB";
            }
            else if (v == "f")
            {
                return "9c";
            }
            else if (v == "g")
            {
                return "Ig";
            }
            else if (v == "h")
            {
                return "lt";
            }
            else if (v == "i")
            {
                return "Yl";
            }
            else if (v == "j")
            {
                return "&+";
            }
            else if (v == "k")
            {
                return "DT";
            }
            else if (v == "l")
            {
                return "-s";
            }
            else if (v == "m")
            {
                return "MH";
            }
            else if (v == "n")
            {
                return "aC";
            }
            else if (v == "o")
            {
                return "8n";
            }
            else if (v == "p")
            {
                return "J/";
            }
            else if (v == "q")
            {
                return "a%";
            }
            else if (v == "r")
            {
                return "J{";
            }
            else if (v == "s")
            {
                return ")n";
            }
            else if (v == "t")
            {
                return "_Y";
            }
            else if (v == "u")
            {
                return "V7";
            }
            else if (v == "v")
            {
                return "[f";
            }
            else if (v == "w")
            {
                return "2L";
            }
            else if (v == "x")
            {
                return "FM";
            }
            else if (v == "y")
            {
                return "{x";
            }
            else if (v == "z")
            {
                return "_d";
            }
            else if (v == "A")
            {
                return "Of";
            }
            else if (v == "B")
            {
                return "P[";
            }
            else if (v == "C")
            {
                return "b.";
            }
            else if (v == "D")
            {
                return "L1";
            }
            else if (v == "E")
            {
                return "LZ";
            }
            else if (v == "F")
            {
                return "GE";
            }
            else if (v == "G")
            {
                return "rj";
            }
            else if (v == "H")
            {
                return "gG";
            }
            else if (v == "I")
            {
                return "3U";
            }
            else if (v == "J")
            {
                return "aN";
            }
            else if (v == "K")
            {
                return "+&";
            }
            else if (v == "L")
            {
                return "7m";
            }
            else if (v == "M")
            {
                return "o4";
            }
            else if (v == "N")
            {
                return "D]";
            }
            else if (v == "O")
            {
                return "pG";
            }
            else if (v == "P")
            {
                return "2>";
            }
            else if (v == "Q")
            {
                return ")D";
            }
            else if (v == "R")
            {
                return "zJ";
            }
            else if (v == "S")
            {
                return "+x";
            }
            else if (v == "T")
            {
                return "0L";
            }
            else if (v == "U")
            {
                return "+6";
            }
            else if (v == "V")
            {
                return "bN";
            }
            else if (v == "W")
            {
                return ".E";
            }
            else if (v == "X")
            {
                return "oi";
            }
            else if (v == "Y")
            {
                return "b=";
            }
            else if (v == "Z")
            {
                return "-/";
            }
            else if (v == "~")
            {
                return "(6";
            }
            else if (v == "`")
            {
                return "xp";
            }
            else if (v == "!")
            {
                return "UN";
            }
            else if (v == "#")
            {
                return "ha";
            }
            else if (v == "$")
            {
                return "&F";
            }
            else if (v == "%")
            {
                return "[e";
            }
            else if (v == "^")
            {
                return "G9";
            }
            else if (v == "&")
            {
                return "yL";
            }
            else if (v == "*")
            {
                return "In";
            }
            else if (v == "(")
            {
                return "Ca";
            }
            else if (v == ")")
            {
                return "Xg";
            }
            else if (v == "_")
            {
                return "IP";
            }
            else if (v == "-")
            {
                return "lG";
            }
            else if (v == "=")
            {
                return "N!";
            }
            else if (v == "+")
            {
                return "OD";
            }
            else if (v == "/")
            {
                return "[c";
            }
            else if (v == "?")
            {
                return "!+";
            }
            else if (v == "<")
            {
                return "7s";
            }
            else if (v == ">")
            {
                return "m#";
            }
            else if (v == ".")
            {
                return "=b";
            }
            else if (v == "{")
            {
                return "*]";
            }
            else if (v == "}")
            {
                return "wc";
            }
            else if (v == "[")
            {
                return "#G";
            }
            else if (v == "]")
            {
                return "0T";
            }
            else if (v == ",")
            {
                return "<>";
            }
            else if (v == "'")
            {
                return "a*";
            }
            else if (v == "6")
            {
                return "rS";
            }
            else
            {
                return v + v;
            }
        }




        public string Decryption_stn2(string inp)
        {
            int lng = 2;
            string txt = "", tx2, tx1 = inp;
            for (int i = 0; i < inp.Length / lng; i++)
            {
                tx2 = tx1.Remove(lng, tx1.Length - lng);
                tx1 = tx1.Remove(0, lng);
                txt += sina_DEC_stn2(tx2);
            }
            return txt;
        }


        public string sina_DEC_stn2(string v)
        {
            if (v == "_%")
            {
                return "0";
            }
            else if (v == "8i")
            {
                return "1";
            }
            else if (v == "-f")
            {
                return "2";
            }
            else if (v == "?1")
            {
                return "3";
            }
            else if (v == "JM")
            {
                return "4";
            }
            else if (v == "<*")
            {
                return "5";
            }
            else if (v == "qO")
            {
                return "7";
            }
            else if (v == "[/")
            {
                return "8";
            }
            else if (v == "D>")
            {
                return "9";
            }
            else if (v == "JF")
            {
                return "a";
            }
            else if (v == "y/")
            {
                return "b";
            }
            else if (v == "7Q")
            {
                return "c";
            }
            else if (v == "TS")
            {
                return "d";
            }
            else if (v == "zB")
            {
                return "e";
            }
            else if (v == "9c")
            {
                return "f";
            }
            else if (v == "Ig")
            {
                return "g";
            }
            else if (v == "lt")
            {
                return "h";
            }
            else if (v == "Yl")
            {
                return "i";
            }
            else if (v == "&+")
            {
                return "j";
            }
            else if (v == "DT")
            {
                return "k";
            }
            else if (v == "-s")
            {
                return "l";
            }
            else if (v == "MH")
            {
                return "m";
            }
            else if (v == "aC")
            {
                return "n";
            }
            else if (v == "8n")
            {
                return "o";
            }
            else if (v == "J/")
            {
                return "p";
            }
            else if (v == "a%")
            {
                return "q";
            }
            else if (v == "J{")
            {
                return "r";
            }
            else if (v == ")n")
            {
                return "s";
            }
            else if (v == "_Y")
            {
                return "t";
            }
            else if (v == "V7")
            {
                return "u";
            }
            else if (v == "[f")
            {
                return "v";
            }
            else if (v == "2L")
            {
                return "w";
            }
            else if (v == "FM")
            {
                return "x";
            }
            else if (v == "{x")
            {
                return "y";
            }
            else if (v == "_d")
            {
                return "z";
            }
            else if (v == "Of")
            {
                return "A";
            }
            else if (v == "P[")
            {
                return "B";
            }
            else if (v == "b.")
            {
                return "C";
            }
            else if (v == "L1")
            {
                return "D";
            }
            else if (v == "LZ")
            {
                return "E";
            }
            else if (v == "GE")
            {
                return "F";
            }
            else if (v == "rj")
            {
                return "G";
            }
            else if (v == "gG")
            {
                return "H";
            }
            else if (v == "3U")
            {
                return "I";
            }
            else if (v == "aN")
            {
                return "J";
            }
            else if (v == "+&")
            {
                return "K";
            }
            else if (v == "7m")
            {
                return "L";
            }
            else if (v == "o4")
            {
                return "M";
            }
            else if (v == "D]")
            {
                return "N";
            }
            else if (v == "pG")
            {
                return "O";
            }
            else if (v == "2>")
            {
                return "P";
            }
            else if (v == ")D")
            {
                return "Q";
            }
            else if (v == "zJ")
            {
                return "R";
            }
            else if (v == "+x")
            {
                return "S";
            }
            else if (v == "0L")
            {
                return "T";
            }
            else if (v == "+6")
            {
                return "U";
            }
            else if (v == "bN")
            {
                return "V";
            }
            else if (v == ".E")
            {
                return "W";
            }
            else if (v == "oi")
            {
                return "X";
            }
            else if (v == "b=")
            {
                return "Y";
            }
            else if (v == "-/")
            {
                return "Z";
            }
            else if (v == "(6")
            {
                return "~";
            }
            else if (v == "xp")
            {
                return "`";
            }
            else if (v == "UN")
            {
                return "!";
            }
            else if (v == "ha")
            {
                return "#";
            }
            else if (v == "&F")
            {
                return "$";
            }
            else if (v == "[e")
            {
                return "%";
            }
            else if (v == "G9")
            {
                return "^";
            }
            else if (v == "yL")
            {
                return "&";
            }
            else if (v == "In")
            {
                return "*";
            }
            else if (v == "Ca")
            {
                return "(";
            }
            else if (v == "Xg")
            {
                return ")";
            }
            else if (v == "IP")
            {
                return "_";
            }
            else if (v == "lG")
            {
                return "-";
            }
            else if (v == "N!")
            {
                return "=";
            }
            else if (v == "OD")
            {
                return "+";
            }
            else if (v == "[c")
            {
                return "/";
            }
            else if (v == "!+")
            {
                return "?";
            }
            else if (v == "7s")
            {
                return "<";
            }
            else if (v == "m#")
            {
                return ">";
            }
            else if (v == "=b")
            {
                return ".";
            }
            else if (v == "*]")
            {
                return "{";
            }
            else if (v == "wc")
            {
                return "}";
            }
            else if (v == "#G")
            {
                return "[";
            }
            else if (v == "0T")
            {
                return "]";
            }
            else if (v == "<>")
            {
                return ",";
            }
            else if (v == "a*")
            {
                return "'";
            }
            else if (v == "rS")
            {
                return "6";
            }
            else
            {
                return v.Remove(1);
            }
        }


        ///////////////////////////////////////////////




        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
