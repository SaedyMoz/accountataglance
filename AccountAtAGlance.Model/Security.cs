using System;
using System.Collections.Generic;

namespace AccountAtAGlance.Model
{
    public abstract class Security
    {
        public int Id { get; set; }
        public decimal Change { get; set; }

        public decimal PercentChange { get; set; }
        public decimal Last { get; set; }
        public decimal Shares { get; set; }
        public string Symbol { get; set; }
        public DateTime RetrievalDateTime { get; set; }
        public string Company { get; set; }
        public List<DataPoint> DataPoints { get; set; }
    }
}
