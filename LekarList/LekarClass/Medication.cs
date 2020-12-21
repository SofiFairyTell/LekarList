using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.XmlConfiguration;

namespace LekarList.LekarClass
{
    public abstract class Medication : IComparable<Medication>
    {
        [XmlElement("MedicName")]
        public string MedicName { get; set; } //название группы верхнего уровня

        public string Description { get; set; }//текущее название препарата

        public string Code; //код, который состоит из номеров групп верхеного уровня

        List<string> Chapters = new List<string>(); //для объектов или содержимого класса

        /*Поля для формирования дерева*/
        [XmlElement("Level")]
        public int Level; 
        [XmlElement("Index")]
        public int Index;
        //public string ShowText;
        public int Child;

        
        /*Если уровень 0, то или А или B и т.д.*/
        public Medication()
        {
            this.MedicName = "V";
            this.Description = " ";
            this.Level = 0;
            this.Index = 0;
        }
        public Medication(string MedicName, string Code, string Description, int Level, int Index)
        {
            this.MedicName = MedicName;
            this.Code = Code;
            this.Description = Description;
            this.Level = Level;
            this.Index = Index;
        }

        //public static int Count(List<Medication> MedicGroups)
        //{
        //    int n = 0;
        //    foreach (var obj in MedicGroups)
        //    {
        //        if (obj is Medication)
        //            n++;
        //    }
        //    return n;
        //}
        public int CompareTo(Medication ComparedGroup)
        {
            string name1 = this.MedicName;
            string name2 = ComparedGroup.MedicName;
            int n = 0;
            if (name1.Length > name2.Length)
                n = name1.Length;
            else
                n = name2.Length;
            for (int i = 0; i < n; i++)
            {
                if (name1[i] > name2[i])
                    return 1;
                else if (name1[i] < name2[i])
                    return -1;
            }
            if (name1.Length < name2.Length)
                return 1;
            else if (name1.Length > name2.Length)
                return -1;
            else
                return 0;
        }

        public virtual List<string> Return()
        {
            return Chapters;
        }
        public virtual List<string> Return(string str)
        {
            return Chapters;
        }

    }
}
