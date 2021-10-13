using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natura
{
    public interface IAnimal<T> where T : ICibo
    {

        string Mangia(T cibo);
       
    }
}
