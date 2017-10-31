using System;
using System.Linq.Expressions;

namespace ExpressionTreeHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockExpression blockExpr = Expression.Block(
                Expression.Call(null, typeof(Console).GetMethod("Write", new Type[] { typeof(String) }), Expression.Constant("Hello ")),
                Expression.Call(null, typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }), Expression.Constant("World!")),
                Expression.Call(null, typeof(Console).GetMethod("ReadLine")));
            Expression.Lambda<Action>(blockExpr).Compile()();
        }
    }
}
