using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    public class AnatomGroup: Medication
    {
        private string AnatomMainGroup; //GOURPS: A,B,C,D,G,H,J,L,M,N,P,R,S,V

        //public string ShowText;

        public AnatomGroup()
        {
            AnatomMainGroup = " ";
            MedicName = "";
            Level = 0;
            Index = 0;
        }

        public AnatomGroup(string ANMG, string CodeSG, int level, int index)
        {
            AnatomMainGroup = ANMG;
            MedicName = ANMG;
            Code = CodeSG;
            Level = level;
            Index = index;
        }
        public static new int Count(List<Medication> MedicGroups)
        {
            int n = 0;
            foreach (var obj in MedicGroups)
            {
                if (obj is AnatomGroup)
                    n++;
            }
            return n;
        }
        public static int CountAnatom(List<AnatomGroup> SubGroups)
        {
            int n = 0;
            foreach (var obj in SubGroups)
            {
                if (obj is AnatomGroup)
                    n++;
            }
            return n;
        }
    }
}
