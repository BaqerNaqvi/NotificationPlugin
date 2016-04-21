

using System;

namespace DataAccess.DataModels
{
    public class Label
    {
        public long LabelId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public int LabelCounter { get; set; }
        public DateTime CounterResetDate { get; set; }
    }
}
