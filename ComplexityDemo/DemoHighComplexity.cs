using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComplexityDemo.DemoHighComplexity;

namespace ComplexityDemo
{
    public class DemoHighComplexity
    {
        public int HighComplexityFunction(DemoRepo repo, Param1 param1, Param2 param2)
        {
            // All of our validation
            var client = repo.GetClient();
            if (client == null)
            {
                throw new EntityNotFoundException<Client>();
            }

            var user = repo.GetUser();
            if (user == null)
            {
                throw new EntityNotFoundException<User>();
            }

            var plan = repo.GetPlan();
            if (plan == null)
            {
                throw new EntityNotFoundException<Plan>();
            }

            if (param1 == Param1.Yes && param2 == Param2.A)
            {
                return 1;
            }
            if (param1 == Param1.Yes && param2 == Param2.B)
            {
                return 2;
            }
            if (param1 == Param1.No && param2 == Param2.A)
            {
                return 3;
            }
            //if (param1 == Param1.No && param2 == Param2.B)
            //{
                return 4;
            //}
        }

        public enum Param1
        {
            Yes = 1,
            No = 2
        }

        public enum Param2
        {
            A = 1,
            B = 2
        }
    }
}
