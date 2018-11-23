using System;
using System.Collections.Generic;
using System.Text;

namespace WeMicroIt.Utils.QuerierPlus.VirtualEntities
{
    public class StatString : Base
    {
        public string Shortest { get; }
        public string Longest { get; }
        public string Most { get; }
        //public int MostCount { get; }
        public string Least { get; }
        //public int LeastCount { get; }
        public string First { get; }
        public string Last { get; }
    }
}
