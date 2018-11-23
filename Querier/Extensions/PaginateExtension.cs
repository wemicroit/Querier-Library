using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;

namespace WeMicroIt.Utils.Querier.Extensions
{
    public static class PaginateExtension
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> query, int page = 1, int size = 25)
        {
            return query.Skip((page - 1) * size).Take(size);
        }
    }
}
