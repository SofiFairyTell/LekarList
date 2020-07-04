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
        string FirstCode;
        string SecondCode;
        string ThirdCode;
        string FourthCode;
        string NameProblem;

        #region Конструкторы
        public LekarListClass()
            {
                FirstCode = "A Пищеварительный тракт и обмен веществ";
                SecondCode = "A01 Стоматологические препараты";
                ThirdCode = "A01A Стоматологические препараты";
                NameProblem = "Стоматологические препараты";
            }

        #endregion
        public void Show()
        {
            //Name = LekarListClass
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.NameProblem},{this.FirstCode}");
            return sb.ToString();
        }
    }
}