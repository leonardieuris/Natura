using System;


namespace Natura
{
    public class Erbivoro : IAnimal<Vegetale>, ICibo
    {
        private string Name;
        public string GetName() => Name;
        public string Mangia(Vegetale cibo)
        {
            return cibo.GetName();
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
