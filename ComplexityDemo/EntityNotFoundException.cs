using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexityDemo
{
    public class EntityNotFoundException<T> : Exception where T : class
    {
    }
}
