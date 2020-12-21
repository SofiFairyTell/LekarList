﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekarList.LekarClass
{
    class AlimentaryClass : AnatomGroup
    {
        /*Здесь перечислены категории препаратов входящих в анатомическую группу*/
        public static List<string> Chapters = new List<string>()
            {
                "Препараты, влияющие на пищеварительный тракт и обмен веществ",
                "Препараты, влияющие на кроветворение и кровь",
                "Препараты для лечения заболеваний сердечно-сосудистой системы",
                "Препараты для лечения заболеваний кожи",
                "Препараты для лечения заболеваний урогенитальных органов и половые гормоны",
                "Гормональные препараты для системного использования (исключая половые гормоны)",
				"Противомикробные препараты для системного использования",
				"Противоопухолевые препараты и иммуномодуляторы",
				"Препараты для лечения заболеваний костно-мышечной системы",
				"Препараты для лечения заболеваний нервной системы",
				"Противопаразитарные препараты, инсектициды и репелленты",
				"Препараты для лечения заболеваний респираторной системы",
				"Препараты для лечения заболеваний органов чувств",
				"Прочие лекарственные препараты"
            };
        public AlimentaryClass ()
        {
         /*Просто инициализатор класса*/
        }
        /*Вернем хранящийся список в классе */
        public List<string> Return()
        {
           return Chapters;             
        }
    }
}
