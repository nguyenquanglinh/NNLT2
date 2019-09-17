using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Students:IComparable
    {
        public Students() { }
        public Students(string id,string name,string mediumScore)
        {
            this.Id = id;
            this.Name = name;
            this.MediumScore = mediumScore;
        }

        public void Acess()
        {
            Console.Write("id: ");
            this.Id = Console.ReadLine();
            Console.Write("name: ");
            this.Name = Console.ReadLine();
            Console.Write("MediumScore: ");
            this.MediumScore = Console.ReadLine();
        }
        public string Id { get; private set; }
        public string MediumScore { get; private set; }
        public string Name { get; private set; }


        public override string ToString()
        {
            return "About student:\n" + "id: " + Id + " name:" + Name + " medium score: " + MediumScore;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }
        public int CompareTo(object obj)
        {
            if (this.GetHashCode() > obj.GetHashCode())
                return 1;
            else if (this.GetHashCode() == obj.GetHashCode())
                return 0;
            else return -1;
        }

    }
}
