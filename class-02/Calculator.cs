namespace class_02
{
    public class Calculator
    {
        public double Process(double num1, double num2, string oprtn)
        {
            double result = 0;

            switch (oprtn)
            {
                case "+":
                result = num1 + num2;
                break;

                case "-":
                result = num1 - num2;
                break;

                case "/":
                result = num1 / num2;
                break;

                case "*":
                result = num1 * num2;
                break;
                
                default:
                    Utilities.Print("Informe uma operação válida");
                break;
            }
            return result;
        }

        // public double Multiplication(double num1, double num2)
        // {
        //     double result = num1 * num2;

        //     return result;
        // }

        // public double Division(double num1, double num2)
        // {
        //     double result = num1 / num2;

        //     return result;
        // }
        // public double Subtraction(double num1, double num2)
        // {
        //     double result = num1 - num2;

        //     return result;
        // }
        // public double Sum(double num1, double num2)
        // {
        //     double result = num1 + num2;

        //     return result;
        // }
    }
}