using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Woman : Person, IBabySitter
    {
        protected override string HelloPhrase => "Привет, я - женщина";
        public bool HasMakeup { get; private set; } = false;

        public Woman(string name) : base(name)
        {
        }

        public Woman(string name, DateTime birthday) : base(name, birthday)
        {
        }

        public void PutMakeup()
        {
            
            Console.WriteLine("Наносит макияж");
            HasMakeup = true;
        }

        public void RemoveMakeup()
        {

            Console.WriteLine("Удаляет макияж");
            HasMakeup = false;
        }

        public override void SayHello()
        {
            Console.WriteLine($"Привет, я - женщина. Имя мне - {this.Name}");
        }

        protected override void TakeCareImplementation()
        {
                Console.WriteLine("hello, my child");
        }

        void IBabySitter.TakeCare()
        {
            if(Children != null)
                Console.WriteLine("hello, I'm Your BabySitter");
        }
    }
}
