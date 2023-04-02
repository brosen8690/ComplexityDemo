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

        public Client? GetClient()
        {
            throw new NotImplementedException();
        }

        public User? GetUser()
        {
            throw new NotImplementedException();
        }

        public Plan? GetPlan()
        {
            throw new NotImplementedException();
        }
    }

    public class Client { }
    public class User { }
    public class Plan { }
}
