using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
   public class ChemGroup: PharmaGroup
    {
        private string AnatomMainGroup { get; set; }
        private string TherapSG { get; set; }
        private string PharmaSG { get; set; }
        private string ChemSG { get; set; }

        public ChemGroup()
        {
            PharmaSG = "";
            MedicName = "";
            Code = "";
            Level = 0;
            Index = 0;
        }
        public ChemGroup(string MedicName, string Code, string Description, int Level, int Index)
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
                /*без этого считает все подряд. почему?*/
                if (obj is TherapGroup || obj is AnatomGroup || obj is PharmaGroup)
                    continue;
                    if (obj is ChemGroup)
                    n++;
            }
            return n;
        }
    }
}

