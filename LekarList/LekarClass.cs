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
        public string AnatomicalMainGroup; //GOURPS: A,B,C,D,G,H,J,L,M,N,P,R,S,V
        public string TherapeuticSG;
        public string PharmacologicalSG;
        public string ChemicalSG;
        public string ChemicalSubTance;

        #region Конструкторы
        public LekarListClass()
        {
            AnatomicalMainGroup = " "; 
            TherapeuticSG = " ";
            PharmacologicalSG = " ";
            ChemicalSG = " ";
            ChemicalSubTance = " ";
        }
        public LekarListClass(string ANMG, string THSG, string PHSG, string CHSG, string CHST)
        {
            AnatomicalMainGroup = ANMG;
            TherapeuticSG = ANMG+THSG;
            PharmacologicalSG = ANMG + THSG+PHSG;
            ChemicalSG = ANMG + THSG + PHSG+ CHSG;
            ChemicalSubTance = ANMG + THSG + PHSG + CHSG+CHST;

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