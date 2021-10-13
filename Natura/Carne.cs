using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natura
{
    public class Carne : ICibo
    {
        private string Name;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string nome)
        {
            Name = nome;
        }
    }
}
