using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Сalculator
{
    delegate string myDelegate(string myStr, string tmp);
    internal class Сalculation
    {
        static public string Plus(string num1, string num2)
        {
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            int res = n1 + n2;
            string result = Convert.ToString(res);
            return result;
        }
        static public string Minus(string num1, string num2)
        {
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            int res = n1 - n2;
            string result = Convert.ToString(res);
            return result;
        }
        static public string Multiply(string num1, string num2)
        {
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            int res = n1 * n2;
            string result = Convert.ToString(res);
            return result;
        }
        static public string Divide(string num1, string num2)
        {
            string result = "";
            double n1 = Convert.ToDouble(num1);
            double n2 = Convert.ToDouble(num2);
            double res = 0;
            if (n2 == 0)
            {
                result = "Дуление на ноль невозможно";
            }
            else
            {
                res = n1 / n2;
                result = Convert.ToString(res);
            }
            return result;
        }
    }
    internal class SearchExpression
    {
        static private Regex regex1 = new Regex(@"(\d+)", RegexOptions.IgnoreCase);
        static private Regex regex2 = new Regex(@"[+/*-]", RegexOptions.IgnoreCase);
        static private string a = "", result = "", b = "";
        public string SearchResults(string Expression)
        {
            myDelegate calculator;
            MatchCollection matches1 = regex1.Matches(Expression);

            a = Convert.ToString(matches1[0]);
            b = Convert.ToString(matches1[1]);
            MatchCollection matches2 = regex2.Matches(Expression);
            if (Convert.ToString(matches2[0]) == "*")
            {
                calculator = Сalculation.Multiply;
                result = calculator(a, b);
            }
            else if (Convert.ToString(matches2[0]) == "/")
            {
                calculator = Сalculation.Divide;
                result = calculator(a, b);
            }
            else if (Convert.ToString(matches2[0]) == "+")
            {
                calculator = Сalculation.Plus;
                result = calculator(a, b);
            }
            else if (Convert.ToString(matches2[0]) == "-")
            {
                calculator = Сalculation.Minus;
                result = calculator(a, b);
            }
            return result;
        }
    }

}
