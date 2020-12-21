using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    public class PharmaPreparat : PharmaGroup
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
        public static List<string> AntiemeticPreparat = new List<string>()
        {
            "Блокаторы серотониновых 5-HT3-рецепторов",
            "Другие противорвотные препараты"

        };
        /*Антикоагулянты*/
        public static List<string> AntiCoagulasPreparat = new List<string>()
        {
            "Антагонисты витамина К",
            "Гепарин и его производные",
            "Ингибиторы агрегации тромбоцитов (исключая гепарин)",
            "Ферментные препараты",
            "Прямые ингибиторы тромбина",
            "Прямые ингибиторы фактора Xa",
            "Прочие антикоагулянты"
        };
        public PharmaPreparat()
        {
            /*Просто инициализатор класса*/
        }
        /*Вернем хранящийся список в классе */
        public override List<string> Return(string Preparat)
        {
            switch (Preparat)
            {
                case "Стоматологические препараты":
                    return StomatPreparat;
                case "Противорвотные препараты ":
                    return AntiemeticPreparat;
                case "Антикоагулянты":
                    return AntiCoagulasPreparat;
                default: return null;
            }
        }
        //public List<string> Return()
        //{
        //    return null;
        //}
    }
}
