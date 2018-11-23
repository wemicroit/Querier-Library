using System;
using System.Collections.Generic;
using System.Text;

namespace WeMicroIt.Utils.QuerierPlus.VirtualEntities
{
    public class StatDate : Base
    {
        public DateTimeOffset? Min { get; }
        public DateTimeOffset? Max { get; }
        public DateTimeOffset? First { get; }
        public DateTimeOffset? Last { get; }
    }
}
