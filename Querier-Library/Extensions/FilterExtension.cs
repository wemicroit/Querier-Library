using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace WeMicroIt.Utils.Querier.Extensions
{
    public static class FilterExtension
    {
        public static IQueryable<T> Filter<T>(this IQueryable<T> query, string filter = "")
        {
            if (!string.IsNullOrWhiteSpace(filter))
            {
                try
                {
                    return query.Where($"{filter}");
                }
                catch (Exception)
                {

                    return query;
                }

            }
            else
            {
                return query;
            }
        }
    }
}
