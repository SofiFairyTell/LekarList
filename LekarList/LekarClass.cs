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

        #region ������������
        public LekarListClass()
            {
                FirstCode = "A ��������������� ����� � ����� �������";
                SecondCode = "A01 ����������������� ���������";
                ThirdCode = "A01A ����������������� ���������";
                NameProblem = "����������������� ���������";
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