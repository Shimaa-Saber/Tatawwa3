using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Domain.Enums
{
    public enum ErrorCode
    {
        None = 0,
        ValidationError = 1,
        UnExcepectedError = 2,
        CategoryNotFound = 100,
        CategoryAlreadyExist = 101,
    }
}
