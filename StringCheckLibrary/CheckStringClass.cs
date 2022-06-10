using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCheckLibrary
{
    public class CheckStringClass
    {
        public bool LoginCheck(string login){
            string correctSumbols = "";
            login = login.ToLower();
            if (!login.All(x => correctSumbols.Contains(x)))
            {
                throw new Exception("Логин содержить недопустимые символы");
            }
            if (login == String.Empty)
            {
                throw new Exception("Вы не ввели логин");
            }
            if (login.EndsWith("."))
            {
                throw new Exception("Логин не может заканчиваться символом'точка'");
            }
            return true;
        
        }   
        
    }
}
