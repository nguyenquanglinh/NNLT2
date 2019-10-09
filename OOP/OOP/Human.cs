using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_std
{
    public class Human
    {
        #region khoi tao
        public Human(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Human():this("no name", 0) { }
        public Human(string name) : this(name, 0) { }

        public Human(int age):this("no name", age) { }

        public int Age { get; private set; }
        public string Name { get; private set; }

        #endregion

        #region ham

        public virtual void Introduce()
        {
            Console.Write("\nToi ten la {0}  toi {1} tuoi ", Name,Age);
        }
        #endregion


    }
}
