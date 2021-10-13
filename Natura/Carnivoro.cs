using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natura
{
    public class Carnivoro : IAnimal<Carne>, ICibo
    {
        private string Nome;
        public string GetName()
        {
            return Nome;
        }

        public string Mangia(Carne cibo)
        {
            return cibo.GetName();
        }

        public void SetName(string name)
        {
            Nome = name;
        }
    }
}
