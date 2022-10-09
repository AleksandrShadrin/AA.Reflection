namespace Reflection.Presentaion
{
    public class ReflectedCalculator
    {
        private readonly Object _calculator;
        private readonly Type _calcType;

        public ReflectedCalculator(Type calculatorType)
        {
            _calcType = calculatorType;
            _calculator = Activator.CreateInstance(_calcType);
        }

        public void SetLeftOperand(int value)
        {
            var prop = _calcType.GetProperty("LeftOp");
            prop.SetValue(_calculator, value);
        }

        public void SetRightOperand(int value)
        {
            var prop = _calcType.GetProperty("RightOp");
            prop.SetValue(_calculator, value);
        }

        public int GetLeftOperand()
        {
            var prop = _calcType.GetProperty("LeftOp");
            return (int)(prop.GetValue(_calculator));
        }

        public int GetRightOperand()
        {
            var prop = _calcType.GetProperty("RightOp");
            return (int)(prop.GetValue(_calculator));
        }

        public int Substract()
        {
            var method = _calcType.GetMethod("Substract");
            return (int)method
                .Invoke(_calculator, Enumerable.Empty<Object>().ToArray());
        }
    }
}
