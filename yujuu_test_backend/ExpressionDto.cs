namespace yujuu_test_backend
{
    public class ExpressionDto
    {
        public string expression { get; set; }
        public char derivativeVar { get; set; }
        public string result { get; set; }
        public float[] evaluationArray { get; set; }
    }
}