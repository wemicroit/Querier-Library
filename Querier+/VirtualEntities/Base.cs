using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WeMicroIt.Utils.QuerierPlus.VirtualEntities
{
    public class Base
    {
        public int RecordId { get; }
        public int Count { get; }
        public int Unique { get; }
        public int Null { get; }
        public int NotNull { get; }
    }
}
