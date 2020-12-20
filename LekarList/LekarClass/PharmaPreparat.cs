using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    public class PharmaPreparat:PharmaGroup
    {
        public static List<string> StomatPreparat = new List<string>()
        {

        };
        public PharmaPreparat()
        {
            /*Просто инициализатор класса*/
        }
        /*Вернем хранящийся список в классе */
        public List<string> Return(string Preparat)
        {
            switch (Preparat)
            {
                case " ":
                    return StomatPreparat;
                case " ":
                    //return BloodPrepat;
                case " ":
                    //return HeartPrepat;
                default: return null;
            }
        }
        public List<string> Return()
        {
            return null;
        }
    }
}
