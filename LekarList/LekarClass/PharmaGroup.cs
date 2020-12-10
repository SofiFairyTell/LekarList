using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    class PharmaGroup:Medication
    {
        private string AnatomMainGroup { get; set; }
        private string TherapSG { get; set; }
        private string PharmaSG { get; set; }
        public PharmaGroup()
        {
            PharmaSG = "";
            MedicName = "";
            Code = "";
            Level = 0;
            Index = 0;
        }
        public PharmaGroup(string MedicName, string Code, string Description, int Level, int Index)
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
                if (obj is PharmaGroup)
                    n++;
            }
            return n;
        }
    }
}
