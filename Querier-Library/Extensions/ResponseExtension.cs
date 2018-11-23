using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeMicroIt.Utils.DataBase.Extensions;
using WeMicroIt.Utils.Querier.Request;
using WeMicroIt.Utils.Querier.Response;

namespace WeMicroIt.Utils.Querier.Extensions
{
    public static class ResponseExtension
    {
        public static ResponseModel BuildResponse<T>(IQueryable<T> queryable, RequestModel request, string Language)
        {
            queryable = queryable.Filter(request.Filter).FilterLanguage(Language);
            return new ResponseModel()
            {
                Count = queryable.Count(),
                Data = queryable.Paginate(request.Page, request.Size).Transform(request.Fields),
                Filter = request.Filter,
                Fields = request.Fields,
                Order = request.Order,
                Page = request.Page,
                Pages = (int)Math.Ceiling((decimal)queryable.Count() / request.Size),
                Size = request.Size
            };
        }
    }
}
