using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using training_task1.Models;

namespace training_task1
{
    internal static class Extensios
    {
        public static void AddBinding<TControl, TSource>(this TControl control, TSource source,
            Expression<Func<TControl, object>> targetProperty,
            Expression<Func<TSource, object>> sourceProperty)
            where TControl : Control
            where TSource : class
        {
            var controlName = GetMeberName(targetProperty);
            var sourceName = GetMeberName(sourceProperty);
            control.DataBindings.Add(new Binding(controlName, source, sourceName,
                false,
                DataSourceUpdateMode.OnPropertyChanged));
        }

        private static string GetMeberName<TItem, TMember>(Expression<Func<TItem, TMember>> targetMember)
        {
            if (targetMember.Body is MemberExpression memberExpression) 
            {
                return memberExpression.Member.Name;
            }

            if (targetMember.Body is UnaryExpression unaryExpression)
            {
                var operand = unaryExpression.Operand as MemberExpression;
                return operand.Member.Name;
            }

            throw new ArgumentException();
        }
    }
}
