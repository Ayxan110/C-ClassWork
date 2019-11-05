namespace ConsoleApp1
{
    class Calculator
    {
        public decimal firstNum;
        public decimal secondNum;
        public char Symbol;

        public decimal calculate()
        {
            if (Symbol == '+')
            {
                return Add();
            }
            else if (Symbol == '-')
            {
                return Sub();
            }
            else if (Symbol == '*')
            {
                return Mul();
            }
            else if (Symbol == '/')
            {
                return Div();
            }
            return 0;
        }
        public decimal Add()
        {
            return firstNum + secondNum;
        }
        public decimal Sub()
        {
            return firstNum - secondNum;
        }
        public decimal Mul()
        {
            return firstNum * secondNum;
        }
        public decimal Div()
        {
            return firstNum / secondNum;
        }                                                                           
    }

}
