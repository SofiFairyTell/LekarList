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

        public AnatomGroup(string MedicName, string Code, string Description, int Level, int Index)
        {
            this.MedicName = MedicName;
            this.Code = Code;
            this.Description = Description;
            this.Level = Level;
            this.Index = Index;
        }
        public static  int Count(List<Medication> MedicGroups)
        {
            int n = 0;
            foreach (var obj in MedicGroups)
            {
                if (obj is TherapGroup || obj is PharmaGroup || obj is ChemGroup)
                    continue;
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
