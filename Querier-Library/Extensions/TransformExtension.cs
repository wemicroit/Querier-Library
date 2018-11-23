using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace WeMicroIt.Utils.Querier.Extensions
{
    public static class TransformExtension
    {
        public static List<Object> Transform<T>(this IQueryable<T> query, string Fields)
        {
            if (!string.IsNullOrWhiteSpace(Fields))
            {
                try
                {
                    return query.Select($"new({Fields})").Cast<object>().ToList();
                }
                catch (Exception)
                {
                    return null; 
                }
            }
            return query.Cast<object>().ToList();
        }
    }
}
