using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
   public class TherapGroup: AnatomGroup
   {
        private string AnatomMainGroup { get; set; }
        private string TherapSG { get; set; }

        //int Child = PharmaGroup.Count();

        public TherapGroup(string THSG,string CodeSG, int level, int index)
        {
            TherapSG = THSG;
            MedicName = THSG;
            Code = CodeSG;
            Level = level;
            Index = index;
        }

        public static new int Count(List<Medication> MedicGroups)
        {
            int n = 0;
            foreach (var obj in MedicGroups)
            {
                if (obj is TherapGroup)
                    n++;
            }
            return n;
        }
        /*Придумать как посчитать количество элементов подгруппы?*/
        //public static int CountTherap(List<TherapGroup> SubGroups)
        //{
        //    int n = 0;
        //    foreach (var obj in SubGroups)
        //    {
        //        if (obj is TherapGroup)
        //            n++;
        //    }
        //    return n;
        //}
    }
}
