using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simugize.Core.Common
{
    public class ResultSet<T> : IResultSet<T>
    {
        public int? RecordCount { get; set; }

        public int? StartAt { get; set; }

        public int? FetchCount { get; set; }

        public T? Records { get; set; }

        public ResultSet(T? records = default(T), int? recordCount = null, int? startAt = null, int? fetchCount = null)
        {
            this.Records = records;
            this.RecordCount = recordCount;
            this.StartAt = startAt;
            this.FetchCount = fetchCount;
        }
    }
}
