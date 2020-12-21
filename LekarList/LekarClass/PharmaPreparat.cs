using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    public class PharmaPreparat:PharmaGroup
    {
        /*Стоматологические препараты*/
        public static List<string> StomatPreparat = new List<string>()
        {
            "Препараты для профилактики кариеса",
            "Противомикробные препараты для местного лечения заболеваний",
            "Глюкокортикостероиды для местного лечения заболеваний полости рта",
            "Прочие препараты для лечения заболеваний полости рта",
        };
        /*Противорвотные препараты*/
        public static List<string> AntiemeticPreparat= new List<string>()
        {
            "Блокаторы серотониновых 5-HT3-рецепторов",
            "Другие противорвотные препараты"

        };
        public PharmaPreparat()
        {
            /*Просто инициализатор класса*/
        }
        /*Вернем хранящийся список в классе */
        public List<string> Return(string Preparat)
        {
            switch (Preparat)
            {
                case "Стоматологические препараты":
                    return StomatPreparat;
                case "Противорвотные препараты ":
                    return AntiemeticPreparat;

                default: return null;
            }
        }
        public List<string> Return()
        {
            return null;
        }
    }
}
