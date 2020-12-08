using System;

namespace LekarList
{
    public class Animation
    {
        public string ID { get; set; }
        public float Value;
        public float StartValue;

        public float targetValue;

        public float TargetValue
        {
            get => targetValue;
            set
            {
                targetValue = value;//то что вводим
                Reverse = value < Value ? true : false;

            }
        }
        public float Volume;
        public bool Reverse = false;//увеличить или уменьшить VAlue
        public AnimationStatus Status { get; set; }
        public enum AnimationStatus //в каком состоянии се
        {
            Requested,
            Active,
            Completed
        }

        private float p15, p30, p70, p85;
        public int StepDivider = 11;
        public float Step()
        {
            float basicStep = Math.Abs(Volume) / StepDivider;
            float resultStep = 0;
            if (Reverse == false)
            {
                if (Value <= p15 || Value >= p85)
                {
                    resultStep = basicStep / 3.5f;
                }
                else if (Value <= p30 || Value >= p70)
                {
                    resultStep = basicStep / 2f;
                }
                else if (Value > p30 && Value < p70)
                {
                    resultStep = basicStep;
                }
            }
            else
            {
                if (Value >= p15 || Value <= p85)
                {
                    resultStep = basicStep / 3.5f;
                }
                else if (Value >= p30 || Value <= p70)
                {
                    resultStep = basicStep / 2f;
                }
                else if (Value < p30 && Value > p70)
                {
                    resultStep = basicStep;
                }
            }

            return Math.Abs(resultStep);
        }

        private float ValueByPercent(float Percent)
        {
            float COEFF = Percent / 100;
            float VolumeInPercent = Volume * COEFF;
            float ValueInPercent = StartValue + VolumeInPercent;

            return ValueInPercent;
        }

        public delegate void ControlMethod();
        private ControlMethod InvalidateControl;

        public void UpdateFrame()
        {
            Status = AnimationStatus.Active;

            if (Reverse == false)
            {
                if (Value <= targetValue)
                {
                    Value += Step();

                    if (Value >= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }
            else
            {
                if (Value >= targetValue)
                {
                    Value -= Step();

                    if (Value <= targetValue)
                    {
                        Value = targetValue;
                        Status = AnimationStatus.Completed;
                    }
                }
            }

            InvalidateControl.Invoke();
        }

        public Animation() { }

        public Animation(string ID, ControlMethod InvalidateControl, float Value, float TargetValue)
        {
            this.ID = ID;

            this.InvalidateControl = InvalidateControl;

            this.Value = Value;
            this.TargetValue = TargetValue;

            StartValue = Value;
            Volume = TargetValue - Value;

            p15 = ValueByPercent(15);
            p30 = ValueByPercent(30);
            p70 = ValueByPercent(70);
            p85 = ValueByPercent(85);
        }
    }
}