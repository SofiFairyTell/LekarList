using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LekarList.LekarClass;

namespace LekarList
{
    public class InitTree
    {
       // public static List<Medication> MedList = new List<Medication>();
        public static List<Medication> InitTreeFunc()
        {
            var MedList = new List<Medication>();
            AnatomGroup anatom1 = new AnatomGroup("A", 0, 0);
            TherapGroup therap1 = new TherapGroup("A", "01", 1, 1);
            PharmaGroup pharma1 = new PharmaGroup("A", "01", "A", 2, 2);
            ChemGroup chem1 = new ChemGroup("A", "01", "A", "A", 3, 3);

            AnatomGroup anatom2 = new AnatomGroup("B", 0, 6);
            TherapGroup therap2 = new TherapGroup("B", "01", 1, 7);
            PharmaGroup pharma2 = new PharmaGroup("B", "01", "A", 2, 8);

            MedList.Add(anatom1);
            MedList.Add(therap1);
            MedList.Add(pharma1);
            MedList.Add(anatom2);
            MedList.Add(therap2);
            MedList.Add(pharma2);
            return MedList;
        }
 }
}

