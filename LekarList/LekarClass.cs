using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LekarClass
{
    public class LekarListClass
    {
        private string AnatomicalMainGroup; //GOURPS: A,B,C,D,G,H,J,L,M,N,P,R,S,V
        private string TherapeuticSG;
        private string PharmacologicalSG;
        private string ChemicalSG;
        private string ChemicalSubTance;
        public string ShowText;
        public int Level;
        public int Index;

        #region Конструкторы
        //По классификации ATC уровней 5. Здесь считаются: 0,1,2,3,4;
        public LekarListClass()
        {
            AnatomicalMainGroup = " "; 
            TherapeuticSG = " ";
            PharmacologicalSG = " ";
            ChemicalSG = " ";
            ChemicalSubTance = " ";
            Level = 0;
            Index = 0;
        }
        //Анатомическая группа - level 0
        public LekarListClass(string ANMG, int level, int index)
        {
            AnatomicalMainGroup = ANMG;
            Level = level;
            Index = index;
        }
        //Терапевтическая группа - level 1
        public LekarListClass(string ANMG, string THSG, int level, int index)
        {
            AnatomicalMainGroup = ANMG;
            TherapeuticSG = THSG;
            ShowText = AnatomicalMainGroup+TherapeuticSG;
            Level = level;
            Index = index;
        }
        //Фармакологическая группа - level 2
        public LekarListClass(string ANMG, string THSG, string PHSG, int level, int index)
        {
            AnatomicalMainGroup = ANMG;
            TherapeuticSG = THSG;
            PharmacologicalSG = PHSG;
            ShowText = AnatomicalMainGroup + TherapeuticSG+ PharmacologicalSG;
            Level = level;
            Index = index;
        }
        //Химическая группа - level 3
        public LekarListClass(string ANMG, string THSG, string PHSG, string CHSG, int level, int index)
        {
            AnatomicalMainGroup = ANMG;
            TherapeuticSG = THSG;
            PharmacologicalSG = PHSG;
            ChemicalSG = CHSG;
            ShowText = AnatomicalMainGroup + TherapeuticSG + PharmacologicalSG + ChemicalSG;
            Level = level;
            Index = index;
        }
        //Действующего вещества группа -  level 4
        public LekarListClass(string ANMG, string THSG, string PHSG, string CHSG, string CHST, int level, int index)
        {
            AnatomicalMainGroup = ANMG;
            TherapeuticSG =  THSG;
            PharmacologicalSG =  PHSG;
            ChemicalSG = CHSG;
            ChemicalSubTance =  CHST;
            ShowText = AnatomicalMainGroup + TherapeuticSG + PharmacologicalSG + ChemicalSG + ChemicalSubTance;
            Level = level;
            Index = index;
        }
      

        #endregion
        public void Show()
        {
            //Name = LekarListClass
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.AnatomicalMainGroup}{this.TherapeuticSG}{this.PharmacologicalSG}{this.ChemicalSG}{this.ChemicalSubTance}");
            return sb.ToString();
        }
    }
}