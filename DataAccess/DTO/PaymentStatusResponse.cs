using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public record PaymentStatusResponse (string returnMessage, string subReturnMessage, bool isProcessing, int httpStatusCode)
    {
    }
}
