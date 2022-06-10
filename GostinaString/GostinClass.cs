using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GostinaString
{
    public class GostinClass
    {
        public string Gostin(string text)
        {
            char[] cArray = text.ToCharArray();
            string Gostina = string.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                Gostina += cArray[i];
            }
            return Gostina;
        }
        //public static bool OnlyLetters(string Text)
        //{
        //    if (Text == string.Empty)
        //        return false;
        //    foreach(var ch in Text)
        //    {
        //        if (!char.IsLetter(ch))
        //            return false;
        //    }
        //    return true;
        //}
    }
}
