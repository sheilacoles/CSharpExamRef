using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2._59_Modifying_Expression_Tree
{
    public class MultiplyToAdd : ExpressionVisitor
    {
        public Expression Modify(Expression expression)
            return Visit(expression);

        protected override Expression VisitBinary (BinaryExpression b)
        {
            if(b.NodeType == ExpressionType.Multiply)
            {
                Expression left = this.Visit(b.Left);
                Expression right = this.Visit(b.Right);

                return Expression.Add(left, right);
            }
            return base.VisitBinary(b);
        }
    }
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

            //Modify
            MultiplyToAdd m = new MultiplyToAdd();
            Expression<Func<int, int>> addExpression = 
                (Expression<Func<int, int>>)m.Modify(square);
            Func<int, int> doAdd = addExpression.Compile();

            Console.WriteLine("Double of 4: {0}", doAdd(4));

            Console.ReadKey();

        }
    }
}
