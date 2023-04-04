using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexityDemo
{
    public class DemoRepo
    {
        public DemoRepo() { }

        public virtual Client? GetClient()
        {
            throw new NotImplementedException();
        }

        public virtual User? GetUser()
        {
            throw new NotImplementedException();
        }

        public virtual Plan? GetPlan()
        {
            throw new NotImplementedException();
        }
    }

    public class Client { }
    public class User { }
    public class Plan { }
}
