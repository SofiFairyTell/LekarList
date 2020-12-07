using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LekarList
{
    public static class Animator
    {
        //    /*Здесь храним всю анимацию, которую напишем*/
        //    public static List<Animation> AnimationsList = new List<Animation>();
        //    public static int Count()
        //    {
        //        return AnimationsList.Count; //количество анимации???
        //    }
        //    private static Thread AnimationThread; //поток, где будет воспроизводиться анимация
        //    public static bool IsWork = false;
        //    private static double Interval; //для нецелых интервалов анимации

        //    public static void Start()
        //    {
        //        IsWork = true;
        //        Interval = 15;// FPS update every 15 vc
        //        AnimationThread = new Thread(AnimationInvoker)
        //        {
        //            IsBackground = true,
        //            Name = "Анимация"
        //        };
        //        AnimationThread.Start();
        //    }

        //    private static void AnimationInvoker()
        //    {
        //        while (IsWork)
        //        {
        //            AnimationsList.RemoveAll(anima => anima==null || anima.Status == Animation.AnimationStatus.Completed);//удалить всю выполненную анимацию
        //            Parallel.For(0, Count(), index =>
        //             {
        //                 AnimationsList[index].UpdateFrame();
        //             });
        //            Thread.Sleep((int)Interval);
        //        }
        //    }

        //    /*Для отправки анимации в списко*/
        //    public static void Request(Animation Anima, bool ReplaceIfExist)
        //    {
        //        Anima.Status = Animation.AnimationStatus.Requested;
        //        Animation DupAnim = GetDuplicate(Anima);
        //        if(DupAnim != null)
        //        {
        //            if(ReplaceIfExist == true)
        //            {
        //                DupAnim.Status = Animation.AnimationStatus.Completed;
        //            }
        //            else
        //            {
        //                return;
        //            }
        //        }
        //        AnimationsList.Add(Anima); //добавление анимации
        //    }
        //    /*Для вовзращения анимации в списке*/
        //    public static Animation GetDuplicate(Animation animation)
        //    {
        //       return  AnimationsList.Find(anima => anima.ID == animation.ID);
        //    }
        //}
        public static List<Animation> AnimationList = new List<Animation>();

        public static int Count()
        {
            return AnimationList.Count;
        }

        private static Thread AnimatorThread;

        private static double Interval;

        public static bool IsWork = false;

        public static void Start()
        {
            IsWork = true;
            Interval = 14; // FPS ~66

            AnimatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };

            AnimatorThread.Start();
        }

        private static void AnimationInvoker()
        {
            while (IsWork)
            {
                AnimationList.RemoveAll(a => a == null || a.Status == Animation.AnimationStatus.Completed);

                Parallel.For(0, Count(), index =>
                {
                    AnimationList[index].UpdateFrame();
                });

                Thread.Sleep((int)Interval);
            }
        }

        public static void Request(Animation Anim, bool ReplaceIfExists = true)
        {

            Anim.Status = Animation.AnimationStatus.Requested;

            Animation dupAnim = GetDuplicate(Anim);

            if (dupAnim != null)
            {
                if (ReplaceIfExists == true)
                {
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                }
                else
                {
                    return;
                }
            }

            AnimationList.Add(Anim);
        }

        private static Animation GetDuplicate(Animation Anim)
        {
            return AnimationList.Find(a => a.ID == Anim.ID);
        }
    }
}
   