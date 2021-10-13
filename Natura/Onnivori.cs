﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natura
{
    public abstract class Onnivori : IAnimal<ICibo>, ICibo
    {
        private string Name;
        public string GetName() => Name;

        public string Mangia(ICibo cibo)
        {
            return cibo.GetName();
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
