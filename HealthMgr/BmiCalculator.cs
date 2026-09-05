namespace HealthMgr
{
    public class BmiCalculator
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public float BMI
        {
            get
            {
                return Calculate();
            }
        }

        public string GetHealthDescription()
        {
            if (Height <= 0 || Weight <= 0)
            {
                return "請輸入有效的身高與體重。";
            }

            float bmi = BMI;

            if (bmi < 18.5f)
            {
                return "體重過輕：建議增加營養與規律運動，維持健康體位。";
            }

            if (bmi < 25f)
            {
                return "正常範圍：保持均衡飲食與適度運動，維持健康體位。";
            }

            if (bmi < 30f)
            {
                return "過重：建議調整飲食與增加運動，逐步改善體重。";
            }

            return "肥胖：建議尋求專業醫療建議，並持續調整生活習慣。";
        }

        public float Calculate()
        {
            if (Height <= 0 || Weight <= 0)
            {
                return 0;
            }

            float result = 0;
            float height = Height / 100f;
            result = Weight / (height * height);

            return result;
        }
    }
}
