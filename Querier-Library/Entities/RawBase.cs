using System;
using System.Collections.Generic;
using System.Text;
using WeMicroIt.Utils.Querier.Interfaces;

namespace WeMicroIt.Utils.Querier.Entities
{
    public class RawBase : DataBase.Entities.RawBase, ISort, IPaginate, IFilter, IField, ITransform
    {
    }
}
