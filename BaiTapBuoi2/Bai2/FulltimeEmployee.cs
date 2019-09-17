using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class FulltimeEmployee:Employee
    {
        public override string CreateContract()
        {
            return "Contract full time\n"+ base.CreateContract();
        }
    }
}
