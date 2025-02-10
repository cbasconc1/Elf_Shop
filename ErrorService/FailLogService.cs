using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ErrorServices
{
    public  class FailLogService : IError
    {
        public string LoginError { get; set; }

    }
}
