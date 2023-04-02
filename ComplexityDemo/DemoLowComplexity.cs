using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComplexityDemo.DemoHighComplexity;

namespace ComplexityDemo
{
    public class DemoLowComplexity
    {
        public int LowComplexityFunction(Param1 param1, Param2 param2)
        {
            ValidateEntities();

            if (param1 == Param1.Yes)
            {
                return HandleYes(param2);
            }
            return HandleNo(param2);
        }

        internal void ValidateEntities()
        {
            DemoRepo repo = new DemoRepo();
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
        }

        internal int HandleYes(Param2 param2)
        {
            if (param2 == Param2.A)
            {
                return 1;
            }
            return 2;
        }

        internal int HandleNo(Param2 param2)
        {
            if (param2 == Param2.A)
            {
                return 3;
            }
            return 4;
        }
    }
}
