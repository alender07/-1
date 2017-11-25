using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Animal
    {
        private int age;
        private string _name; 
        public virtual string name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        
            
        public virtual void vote()
        {

            Console.WriteLine();
        }
    }

    class Cat : Animal
    {
        public string typeWool;
        private string _name;
        public override string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Cat(string __name, string typeOfWool)
        {
            name = __name;
            typeWool = typeOfWool;
        }
       
        public override void vote()
        {
            Console.WriteLine("Meow-Meow");
        }
        
    }

    class Dog : Animal
    {
        private string _sizeEars;
        public string sizeEars
        {
            get { return _sizeEars; }
            set { _sizeEars = value; }
        }
        private string _name;
        
        public override string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public Dog(string _name, string _sizeEars)
        {
            sizeEars = _sizeEars;
            name = _name;
        }
        public override void vote()
        {
           
            Console.WriteLine("Gav-Gav");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat Bafa = new Cat("Baffa", "Длинношерстная");
            Dog Bobby = new Dog("Bobby", "Little");
            Bafa.name = "Baffi";
            Console.WriteLine("Имя кошки: "+Bafa.name +"\nИмя собаки: "+ Bobby.name);
            Console.WriteLine("Тип шерсти кошки: " + Bafa.typeWool + "\nРазмер ушей собаки: " + Bobby.sizeEars);
            Console.Write("Кошка говорит: ");
            Bafa.vote();
            Console.Write("Собака говорит: ");
            Bobby.vote();
        }
    }
}
