using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2._58_Lambda_Expression_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expression<Func<int, int>> square = num => num * num;

            ParameterExpression numParam = Expression.Parameter(typeof(int), "num");

            BinaryExpression squareOperation = Expression.Multiply(numParam, numParam);

            Expression<Func<int, int>> square =
                Expression.Lambda<Func<int, int>>(squareOperation,
                new ParameterExpression[] { numParam });

            Func<int, int> doSquare = square.Compile();

            Console.WriteLine("Square of 2: {0}", doSquare(2));

            Console.ReadKey();
        }
    }
}
