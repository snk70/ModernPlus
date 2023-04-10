
namespace QueryString_Standards
{
    public class Interchange_Standard
    {
        public string Encryption_Query_String_stn(string inp)
        {
            string txt = "", tx2, tx1 = inp;
            for (int i = 0; i < inp.Length; i++)
            {
                tx2 = tx1.Remove(1, tx1.Length - 1);
                tx1 = tx1.Remove(0, 1);
                txt += sina_ENC_Query_String_stn(tx2);
            }
            return txt;
        }


        private string sina_ENC_Query_String_stn(string v)
        {
            if (v == "0")
            {
                return "wW";
            }
            else if (v == "1")
            {
                return "0A";
            }
            else if (v == "2")
            {
                return "LI";
            }
            else if (v == "3")
            {
                return "p5";
            }
            else if (v == "4")
            {
                return "Yf";
            }
            else if (v == "5")
            {
                return "9s";
            }
            else if (v == "7")
            {
                return "QD";
            }
            else if (v == "8")
            {
                return "1Y";
            }
            else if (v == "9")
            {
                return "vy";
            }
            else if (v == "a")
            {
                return "ZS";
            }
            else if (v == "b")
            {
                return "7P";
            }
            else if (v == "c")
            {
                return "NM";
            }
            else if (v == "d")
            {
                return "uO";
            }
            else if (v == "e")
            {
                return "W9";
            }
            else if (v == "f")
            {
                return "N2";
            }
            else if (v == "g")
            {
                return "co";
            }
            else if (v == "h")
            {
                return "bb";
            }
            else if (v == "i")
            {
                return "fb";
            }
            else if (v == "j")
            {
                return "ru";
            }
            else if (v == "k")
            {
                return "fw";
            }
            else if (v == "l")
            {
                return "gM";
            }
            else if (v == "m")
            {
                return "Ui";
            }
            else if (v == "n")
            {
                return "4b";
            }
            else if (v == "o")
            {
                return "WF";
            }
            else if (v == "p")
            {
                return "OT";
            }
            else if (v == "q")
            {
                return "sf";
            }
            else if (v == "r")
            {
                return "Ri";
            }
            else if (v == "s")
            {
                return "DN";
            }
            else if (v == "t")
            {
                return "TS";
            }
            else if (v == "u")
            {
                return "Il";
            }
            else if (v == "v")
            {
                return "2e";
            }
            else if (v == "w")
            {
                return "qF";
            }
            else if (v == "x")
            {
                return "GT";
            }
            else if (v == "y")
            {
                return "S7";
            }
            else if (v == "z")
            {
                return "Zf";
            }
            else if (v == "A")
            {
                return "1q";
            }
            else if (v == "B")
            {
                return "LY";
            }
            else if (v == "C")
            {
                return "2o";
            }
            else if (v == "D")
            {
                return "TD";
            }
            else if (v == "E")
            {
                return "76";
            }
            else if (v == "F")
            {
                return "Cm";
            }
            else if (v == "G")
            {
                return "9T";
            }
            else if (v == "H")
            {
                return "mo";
            }
            else if (v == "I")
            {
                return "5L";
            }
            else if (v == "J")
            {
                return "9Y";
            }
            else if (v == "K")
            {
                return "VE";
            }
            else if (v == "L")
            {
                return "cR";
            }
            else if (v == "M")
            {
                return "lX";
            }
            else if (v == "N")
            {
                return "2Z";
            }
            else if (v == "O")
            {
                return "3x";
            }
            else if (v == "P")
            {
                return "pz";
            }
            else if (v == "Q")
            {
                return "kg";
            }
            else if (v == "R")
            {
                return "oP";
            }
            else if (v == "S")
            {
                return "3F";
            }
            else if (v == "T")
            {
                return "3E";
            }
            else if (v == "U")
            {
                return "ST";
            }
            else if (v == "V")
            {
                return "pV";
            }
            else if (v == "W")
            {
                return "Zg";
            }
            else if (v == "X")
            {
                return "s4";
            }
            else if (v == "Y")
            {
                return "Ah";
            }
            else if (v == "Z")
            {
                return "bH";
            }
            else if (v == "~")
            {
                return "tP";
            }
            else if (v == "`")
            {
                return "qw";
            }
            else if (v == "!")
            {
                return "c7";
            }
            else if (v == "#")
            {
                return "oh";
            }
            else if (v == "$")
            {
                return "9b";
            }
            else if (v == "%")
            {
                return "q0";
            }
            else if (v == "^")
            {
                return "lW";
            }
            else if (v == "&")
            {
                return "su";
            }
            else if (v == "*")
            {
                return "bS";
            }
            else if (v == "(")
            {
                return "0p";
            }
            else if (v == ")")
            {
                return "GC";
            }
            else if (v == "_")
            {
                return "bc";
            }
            else if (v == "-")
            {
                return "YA";
            }
            else if (v == "=")
            {
                return "4i";
            }
            else if (v == "+")
            {
                return "N9";
            }
            else if (v == "/")
            {
                return "i8";
            }
            else if (v == "?")
            {
                return "xK";
            }
            else if (v == "<")
            {
                return "I3";
            }
            else if (v == ">")
            {
                return "2J";
            }
            else if (v == ".")
            {
                return "Nc";
            }
            else if (v == "{")
            {
                return "m7";
            }
            else if (v == "}")
            {
                return "0J";
            }
            else if (v == "[")
            {
                return "7S";
            }
            else if (v == "]")
            {
                return "QK";
            }
            else if (v == ",")
            {
                return "1f";
            }
            else if (v == "'")
            {
                return "PF";
            }
            else if (v == "6")
            {
                return "si";
            }
            else
            {
                return v + v;
            }
        }




        public string Decryption_Query_String_stn(string inp)
        {
            int lng = 2;

            string txt = "", tx2, tx1 = inp;
            for (int i = 0; i < inp.Length / lng; i++)
            {
                tx2 = tx1.Remove(lng, tx1.Length - lng);
                tx1 = tx1.Remove(0, lng);
                txt += sina_DEC_Query_String_stn(tx2);
            }
            return txt;
        }


        private string sina_DEC_Query_String_stn(string v)
        {
            if (v == "wW")
            {
                return "0";
            }
            else if (v == "0A")
            {
                return "1";
            }
            else if (v == "LI")
            {
                return "2";
            }
            else if (v == "p5")
            {
                return "3";
            }
            else if (v == "Yf")
            {
                return "4";
            }
            else if (v == "9s")
            {
                return "5";
            }
            else if (v == "QD")
            {
                return "7";
            }
            else if (v == "1Y")
            {
                return "8";
            }
            else if (v == "vy")
            {
                return "9";
            }
            else if (v == "ZS")
            {
                return "a";
            }
            else if (v == "7P")
            {
                return "b";
            }
            else if (v == "NM")
            {
                return "c";
            }
            else if (v == "uO")
            {
                return "d";
            }
            else if (v == "W9")
            {
                return "e";
            }
            else if (v == "N2")
            {
                return "f";
            }
            else if (v == "co")
            {
                return "g";
            }
            else if (v == "bb")
            {
                return "h";
            }
            else if (v == "fb")
            {
                return "i";
            }
            else if (v == "ru")
            {
                return "j";
            }
            else if (v == "fw")
            {
                return "k";
            }
            else if (v == "gM")
            {
                return "l";
            }
            else if (v == "Ui")
            {
                return "m";
            }
            else if (v == "4b")
            {
                return "n";
            }
            else if (v == "WF")
            {
                return "o";
            }
            else if (v == "OT")
            {
                return "p";
            }
            else if (v == "sf")
            {
                return "q";
            }
            else if (v == "Ri")
            {
                return "r";
            }
            else if (v == "DN")
            {
                return "s";
            }
            else if (v == "TS")
            {
                return "t";
            }
            else if (v == "Il")
            {
                return "u";
            }
            else if (v == "2e")
            {
                return "v";
            }
            else if (v == "qF")
            {
                return "w";
            }
            else if (v == "GT")
            {
                return "x";
            }
            else if (v == "S7")
            {
                return "y";
            }
            else if (v == "Zf")
            {
                return "z";
            }
            else if (v == "1q")
            {
                return "A";
            }
            else if (v == "LY")
            {
                return "B";
            }
            else if (v == "2o")
            {
                return "C";
            }
            else if (v == "TD")
            {
                return "D";
            }
            else if (v == "76")
            {
                return "E";
            }
            else if (v == "Cm")
            {
                return "F";
            }
            else if (v == "9T")
            {
                return "G";
            }
            else if (v == "mo")
            {
                return "H";
            }
            else if (v == "5L")
            {
                return "I";
            }
            else if (v == "9Y")
            {
                return "J";
            }
            else if (v == "VE")
            {
                return "K";
            }
            else if (v == "cR")
            {
                return "L";
            }
            else if (v == "lX")
            {
                return "M";
            }
            else if (v == "2Z")
            {
                return "N";
            }
            else if (v == "3x")
            {
                return "O";
            }
            else if (v == "pz")
            {
                return "P";
            }
            else if (v == "kg")
            {
                return "Q";
            }
            else if (v == "oP")
            {
                return "R";
            }
            else if (v == "3F")
            {
                return "S";
            }
            else if (v == "3E")
            {
                return "T";
            }
            else if (v == "ST")
            {
                return "U";
            }
            else if (v == "pV")
            {
                return "V";
            }
            else if (v == "Zg")
            {
                return "W";
            }
            else if (v == "s4")
            {
                return "X";
            }
            else if (v == "Ah")
            {
                return "Y";
            }
            else if (v == "bH")
            {
                return "Z";
            }
            else if (v == "tP")
            {
                return "~";
            }
            else if (v == "qw")
            {
                return "`";
            }
            else if (v == "c7")
            {
                return "!";
            }
            else if (v == "oh")
            {
                return "#";
            }
            else if (v == "9b")
            {
                return "$";
            }
            else if (v == "q0")
            {
                return "%";
            }
            else if (v == "lW")
            {
                return "^";
            }
            else if (v == "su")
            {
                return "&";
            }
            else if (v == "bS")
            {
                return "*";
            }
            else if (v == "0p")
            {
                return "(";
            }
            else if (v == "GC")
            {
                return ")";
            }
            else if (v == "bc")
            {
                return "_";
            }
            else if (v == "YA")
            {
                return "-";
            }
            else if (v == "4i")
            {
                return "=";
            }
            else if (v == "N9")
            {
                return "+";
            }
            else if (v == "i8")
            {
                return "/";
            }
            else if (v == "xK")
            {
                return "?";
            }
            else if (v == "I3")
            {
                return "<";
            }
            else if (v == "2J")
            {
                return ">";
            }
            else if (v == "Nc")
            {
                return ".";
            }
            else if (v == "m7")
            {
                return "{";
            }
            else if (v == "0J")
            {
                return "}";
            }
            else if (v == "7S")
            {
                return "[";
            }
            else if (v == "QK")
            {
                return "]";
            }
            else if (v == "1f")
            {
                return ",";
            }
            else if (v == "PF")
            {
                return "'";
            }
            else if (v == "si")
            {
                return "6";
            }
            else
            {
                return v.Remove(1);
            }
        }

    }



}