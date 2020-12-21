using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    public class ChemClass:ChemGroup
    {
        /*Препараты для профилактики кариеса*/
        public static List<string> CariesPreparat = new List<string>()
        {
            "Фторид натрия",
            "Натрия монофторфосфат",
            "Олафур",
            "Фторид олова",
            "Комбинации",
            "Комбинации фторида натрия"
        };
        /*Противомикробные препараты для местного лечения заболеваний*/
        public static List<string> AntiInfectivesPreparat = new List<string>()
        {
            "Пероксид водорода",
            "Хлоргексидин",
            "Амфотерицин",
            "Полиноксилин",
            "Домифена бромид",
            "Оксихинолин",
            "Неомицин",
            "Миконазол"
        };
        public List<string> Return(string Preparat)
        {
            switch (Preparat)
            {
                case "Препараты для профилактики кариеса":
                    return CariesPreparat;
                case "Противомикробные препараты для местного лечения заболеваний":
                    return AntiInfectivesPreparat;
                //case "Антикоагулянты":
                //    return AntiCoagulasPreparat;
                default: return null;
            }
        }
    }
}
