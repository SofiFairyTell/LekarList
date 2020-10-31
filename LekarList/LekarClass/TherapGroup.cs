using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
   public class TherapGroup: Medication
   {
        private string AnatomMainGroup { get; set; }
        private string TherapSG { get; set; }


        public TherapGroup(string ANMG, string THSG, int level, int index)
        {
            AnatomMainGroup = ANMG;
            TherapSG = THSG;
            MedicName = ANMG + THSG;
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
    }
}
