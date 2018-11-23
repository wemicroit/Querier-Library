using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace WeMicroIt.Utils.Querier.Extensions
{
    public static class OrderExtension
    {
        public static IQueryable<T> SortOrder<T>(this IQueryable<T> query, string order = "Created")
        {
            try
            {
                return query.OrderBy($"{order}");
            }
            catch (Exception)
            {
                return query;
            }
        }
    }
}
