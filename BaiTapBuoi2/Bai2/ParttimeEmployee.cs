using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class ParttimeEmployee:Employee
    {

        public override string CreateContract()
        {
            return "Contract part time:\n"+ base.CreateContract();
        }

    }
}
