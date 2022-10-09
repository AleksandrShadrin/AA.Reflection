namespace Reflection.NBR
{
    public class Calculator
    {
        public int LeftOp { get; set; }
        public int RightOp { get; set; }

        public int Substract()
            => LeftOp - RightOp;
    }
}
