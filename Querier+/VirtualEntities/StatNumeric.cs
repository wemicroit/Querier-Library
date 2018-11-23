using System;
using System.Collections.Generic;
using System.Text;

namespace WeMicroIt.Utils.QuerierPlus.VirtualEntities
{
    public class StatNumeric : Base
    {
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Average { get; set; }
        public decimal Sum { get; set; }
        public decimal First { get; set; }
        public decimal Last { get; set; }

    }
}
