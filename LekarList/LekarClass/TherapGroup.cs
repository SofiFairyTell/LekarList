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
        public TherapGroup()
        {
            TherapSG = "";
            MedicName = "";
            Code = " ";
            Level = 0;
            Index = 0;
        }
        public TherapGroup(string MedicName, string Code, string Description, int Level, int Index)
        {
            this.MedicName = MedicName;
            this.Code = Code;
            this.Description = Description;
            this.Level = Level;
            this.Index = Index;
        }

        public static new int Count(List<Medication> MedicGroups)
        {
            int n = 0;
            foreach (var obj in MedicGroups)
            {
                if (obj is PharmaGroup || obj is ChemGroup)
                    continue;
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
