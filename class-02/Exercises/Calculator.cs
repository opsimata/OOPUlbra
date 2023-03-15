namespace class_02.Exercises
{
    public class Calculator
    {

        // public static void Process(string option, double num1, double num2)
        // {
        //     switch (option)
        //     {
        //         case "1":
        //             double result = num1 * num2;
        //             break;
        //         case "2":
        //             Statement
        //         break;
        //         case "3":
        //             Statement
        //         break;
        //         case "4":
        //             Statement
        //         break;
        //         default:
        //             Utilities.Print("Statement");
        //             break;
        //     }
        // }

        public static double Multiplier(double num1, double num2)
        {
            double result = num1 * num2;

            return result;
        }
        public static double Divider(double num1, double num2)
        {
            double result = num1 / num2;

            return result;
        }
        public static double Subtractor(double num1, double num2)
        {
            double result = num1 - num2;

            return result;
        }
        public static double Adder(double num1, double num2)
        {
            double result = num1 + num2;

            return result;
        }
    }
}