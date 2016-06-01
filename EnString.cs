using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhString
{
    class EnString
    {
    }
    public class Format
    {
        ///////////////////////////////////////////////////////////////////////// http://stackoverflow.com/questions/1841874/
        private static Dictionary<string, string> transliter = new Dictionary<string, string>();
        private static void prepareTranslit()
        {
            transliter.Clear();
            transliter.Add("а", "a");
            transliter.Add("б", "b");
            transliter.Add("в", "v");
            transliter.Add("г", "g");
            transliter.Add("д", "d");
            transliter.Add("е", "e");
            transliter.Add("ё", "yo");
            transliter.Add("ж", "zh");
            transliter.Add("з", "z");
            transliter.Add("и", "i");
            transliter.Add("й", "j");
            transliter.Add("к", "k");
            transliter.Add("л", "l");
            transliter.Add("м", "m");
            transliter.Add("н", "n");
            transliter.Add("о", "o");
            transliter.Add("п", "p");
            transliter.Add("р", "r");
            transliter.Add("с", "s");
            transliter.Add("т", "t");
            transliter.Add("у", "u");
            transliter.Add("ф", "f");
            transliter.Add("х", "h");
            transliter.Add("ц", "c");
            transliter.Add("ч", "ch");
            transliter.Add("ш", "sh");
            transliter.Add("щ", "sch");
            transliter.Add("ъ", "j");
            transliter.Add("ы", "i");
            transliter.Add("ь", "j");
            transliter.Add("э", "e");
            transliter.Add("ю", "yu");
            transliter.Add("я", "ya");
            transliter.Add("А", "A");
            transliter.Add("Б", "B");
            transliter.Add("В", "V");
            transliter.Add("Г", "G");
            transliter.Add("Д", "D");
            transliter.Add("Е", "E");
            transliter.Add("Ё", "Yo");
            transliter.Add("Ж", "Zh");
            transliter.Add("З", "Z");
            transliter.Add("И", "I");
            transliter.Add("Й", "J");
            transliter.Add("К", "K");
            transliter.Add("Л", "L");
            transliter.Add("М", "M");
            transliter.Add("Н", "N");
            transliter.Add("О", "O");
            transliter.Add("П", "P");
            transliter.Add("Р", "R");
            transliter.Add("С", "S");
            transliter.Add("Т", "T");
            transliter.Add("У", "U");
            transliter.Add("Ф", "F");
            transliter.Add("Х", "H");
            transliter.Add("Ц", "C");
            transliter.Add("Ч", "Ch");
            transliter.Add("Ш", "Sh");
            transliter.Add("Щ", "Sch");
            transliter.Add("Ъ", "J");
            transliter.Add("Ы", "I");
            transliter.Add("Ь", "J");
            transliter.Add("Э", "E");
            transliter.Add("Ю", "Yu");
            transliter.Add("Я", "Ya");

            transliter.Add("ї", "yi");
            transliter.Add("Ї", "Yi");

            transliter.Add("ґ", "g");
            transliter.Add("Ґ", "G");

            transliter.Add("є", "ye");
            transliter.Add("Є", "Ye");

            transliter.Add("і", "i");
            transliter.Add("І", "I");
        }
        public static string GetTranslit(string sourceText)
        {
            prepareTranslit();
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < sourceText.Length; i++)
            {
                String key = sourceText[i].ToString();
                if (transliter.ContainsKey(key))
                {
                    ans.Append(transliter[sourceText[i].ToString()]);
                }
                else
                {
                    ans.Append(sourceText[i].ToString());
                }
            }
            return ans.ToString();
        }
        /////////////////////////////////////////////////////////////////////////
        public static string Translit(string str)
        {
            string[] lat_up = { "A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "Kh", "Ts", "Ch", "Sh", "Shch", "J", "Y", "J", "E", "Yu", "Ya", "Yi", "G", "Ye", "I"};
            string[] lat_low = { "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "shch", "j", "y", "j", "e", "yu", "ya", "yi", "g", "ye", "i"};
            string[] rus_up = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", "Ї", "Ґ", "Є", "І"};
            string[] rus_low = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "ї", "ґ", "є", "і"};
            for (int i = 0; i < lat_up.Length; i++)
            {
                str = str.Replace(rus_up[i], lat_up[i]);
                str = str.Replace(rus_low[i], lat_low[i]);
            }
            return str;
        }

        public static string TranslitUA(string str)
        {
            string[] lat_up = { "A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "Y", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "Kh", "Ts", "Ch", "Sh", "Shch", "J", "Y", "J", "E", "Yu", "Ya", "Yi", "G", "Ye", "I" };
            string[] lat_low = { "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "y", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "shch", "j", "y", "j", "e", "yu", "ya", "yi", "g", "ye", "i" };
            string[] rus_up = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я", "Ї", "Ґ", "Є", "І" };
            string[] rus_low = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "ї", "ґ", "є", "і" };
            for (int i = 0; i < lat_up.Length; i++)
            {
                str = str.Replace(rus_up[i], lat_up[i]);
                str = str.Replace(rus_low[i], lat_low[i]);
            }
            return str;
        }
        /////////////////////////////////////////////////////////////////////////
        public static int GetLesserDistance(String a, String b)
        {
            List<int> distance = new List<int>();
            distance.Add(GetEditDistance(a, b));
            distance.Add(GetEditDistance(Translit(String.Copy(a)), b));
            distance.Add(GetEditDistance(TranslitUA(String.Copy(a)), b));
            distance.Add(GetEditDistance(GetTranslit(String.Copy(a)), b));
            distance.Add(GetEditDistance(Translit(String.Copy(b)), a));
            distance.Add(GetEditDistance(TranslitUA(String.Copy(b)), a));
            distance.Add(GetEditDistance(GetTranslit(String.Copy(b)), a));
            distance.Sort((x, y) => x > y ? 1 : -1); // Sorting.
            return distance[0];
        }
        /////////////////////////////////////////////////////////////////////////

        private static int GetMinimum(int i1, int i2, int i3) // author: Alexander Yasko
        {
            return Math.Min(Math.Min(i1, i2), i3) + 1;
        }

        public static int GetEditDistance(string a, string b) // author: Alexander Yasko
        {
            if (b == null) b = "";

            int[,] array = new int[2000, 2000];

            int result = -1;

            for (int i = 0; i < b.Length + 1; i++)
            {
                array[i, 0] = i;
            }

            for (int i = 0; i < a.Length + 1; i++)
            {
                array[0, i] = i;
            }

            for (int k = 1; k < b.Length + 1; k++)
            {
                for (int i = 1; i < a.Length + 1; i++)
                {
                    if (b[k - 1] == a[i - 1])
                    {
                        array[k, i] = array[k - 1, i - 1];
                    }
                    else
                    {
                        array[k, i] = GetMinimum(array[k, i - 1], array[k - 1, i], array[k - 1, i - 1]);
                    }
                }
            }

            result = array[b.Length, a.Length];

            return result;
        }

        public static string FromB(string s)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }
        public static string ForB(string s)
        {
            return Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(s));
        }
        public static string ForH(string s)
        {
            return String.Concat(s.Select(b => String.Format("{0:X2}", (int)b)).ToArray());
            //return String.Join(String.Empty, s.Select(b => String.Format("{0:X2}", b)).ToArray());
        }
        public static string FromH(string s)
        {
            String str = "";
            //return String.Concat(s.Select(b => String.Format("{0:X2}", (int)b)).ToArray());
            //return String.Join(String.Empty, s.Select(b => String.Format("{0:X2}", b)).ToArray());
            while (s.Length > 0)
            {
                str += System.Convert.ToChar(System.Convert.ToUInt32(s.Substring(0, 2), 16)).ToString();
                s = s.Substring(2, s.Length - 2);
            }
            return str;
        }
        public static string Set(string s)
        {
            s = Format.ForB(s);
            s = Format.ForB(s);
            s = Format.ForH(s);
            s = Format.ForB(s);
            return s;
        }
        public static string Get(string s)
        {
            s = Format.FromB(s);
            s = Format.FromH(s);
            s = Format.FromB(s);
            s = Format.FromB(s);
            return s;
        }

        public static void Assign(Object o, String s1, String s2)
        {
            o.GetType().GetProperty(Format.Set(s1)).SetValue(o, Format.Set(s2));
        }

        public static String Request(Object o, String s)
        {
            return Format.Get(o.GetType().GetProperty(Format.Set(s)).GetValue(o).ToString());
        }

        public static String[] SortAlphabetically(String[] str)
        {
            List<String> list = str.ToList();
            SortAlphabetically(list);
            return list.ToArray();
        }
        public static List<String> SortAlphabetically(List<String> str)
        {
            str.Sort((x, y) => x.ToLower().CompareTo(y.ToLower())); // Sorting alphabetically.
            return str;
        }


        // new string(a.Reverse().ToArray()) 
        //return new string(originalString.Reverse().ToArray());
    }
}
