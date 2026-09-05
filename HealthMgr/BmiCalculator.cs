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


        public float Calculate()
        {
            float result = 0;
            float height = Height / 100f;
            result = Weight / (height * height);

            return result;
        }
    }
}
