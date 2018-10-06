using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int MathDelegate(int val1, int val2);

    class Program
    {
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static void Main(string[] args)
        {
            //Using Method
            Program p = new Program();
            MathDelegate methodDel = new MathDelegate(p.Multiply);
            int methodResult = methodDel(23, 6);
            Console.WriteLine("Multiply Method  Result : " + methodResult);

            //Using Annonymous Method
            MathDelegate AnnDel = delegate(int num1, int num2) 
            {
                return num1 * num2;
            };
            int annResult = AnnDel(87, 12);
            Console.WriteLine("Annonymous Method Result : " + annResult);

            //Using Lambda Expression
            MathDelegate lambdaDel = (num1, num2) => num1 * num2;
            int lambdaResult = lambdaDel(45, 2);
            Console.WriteLine("Lambda Expression Result : " + lambdaResult);

            Console.ReadKey();
        }
    }
}
