using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    class ChemGroup:Medication
    {
        private string AnatomMainGroup { get; set; }
        private string TherapSG { get; set; }
        private string PharmaSG { get; set; }
        private string ChemSG { get; set; }

        public ChemGroup(string CHSG, string CodeSG, int level, int index)
        {
            ChemSG = CHSG;
            MedicName = CHSG;
            Code = CodeSG;
            Level = level;
            Index = index;
        }

        public static new int Count(List<Medication> MedicGroups)
        {
            int n = 0;
            foreach (var obj in MedicGroups)
            {
                if (obj is ChemGroup);
                    n++;
            }
            return n;
        }
    }
}

