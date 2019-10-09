using System;

namespace OOP_std
{
    public class Student : Human
    {
        #region khoi tao
        public Student() : base()
        {

        }

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string msv, string name, int age) : base(name, age)
        {
            this.MSV = msv;
        }

        public string MSV { get; private set; }
        #endregion

        #region ham
        public override void Introduce()
        {
            base.Introduce();
            Console.Write(" msv: {0}",MSV);
        }
        #endregion
    }
}
