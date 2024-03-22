using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simugize.Core.Common
{
    public class ApiResponse<T> : IApiResponse<T>
    {
        public string? ErrorMessage { get; set; }

        public T? Results { get; set; }

        public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);

        public ApiResponse(T? results = default(T), string? errorMessage =null)
        {
            this.Results = results;
            this.ErrorMessage = errorMessage;
        }
            
    }
}
