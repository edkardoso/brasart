using System;
using System.Linq.Expressions;

namespace Brasart.Domain.Common.Extensions
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<TEntity, bool>> Combine<TEntity>(this Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, bool>> otherExpression)
        {
            var parameterExpression = Expression.Parameter(typeof(TEntity),"r");
            var binaryExpression = Expression.AndAlso(expression.Body, otherExpression.Body);
            var combinedExpression = Expression.Lambda<Func<TEntity, bool>>(binaryExpression, parameterExpression);
            return combinedExpression;
        }

    }
}