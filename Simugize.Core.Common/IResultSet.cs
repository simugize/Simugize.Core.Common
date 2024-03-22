using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simugize.Core.Common
{
    public interface IResultSet<T>
    {
        int? RecordCount { get; }
        int? StartAt { get; }
        int? FetchCount { get; }
        T? Records { get; }
    }
}
