using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Man:Person
    {
        protected override string HelloPhrase => "Привет, я - мужчина";
      
        public Man(string name) : base(name)
        {
        }

        public Man(string name, DateTime birthday) : base(name, birthday)
        {
        }

        public bool HasBeard { get; private set; } = true;

        public void Shave()
        {
            Console.WriteLine("Бреется");
            this.HasBeard = false;
        }

        public override void SayHello()
        {
            Console.WriteLine($"Привет, я - мужчина. Меня звать - {this.Name}");
        }

        public void SayHelloLikeParent()
        {
            base.SayHello();

        }

        public new void Print()
        {
            Console.WriteLine("Скрытый метод ");
        }
    }
}
