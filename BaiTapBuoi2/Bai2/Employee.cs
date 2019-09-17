using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai2
{
    public class Employee
    {
        public Employee() { }
        public Employee(string id, string name, string contractNumber, string dateStartWork) : this()
        {
            this.Id = id;
            this.Name = name;
            this.ContractNumber = contractNumber;
            this.DateStartWork = dateStartWork;
        }

        public string ContractNumber { get; private set; }
        public string DateStartWork { get; private set; }
        public string Id { get; private set; }
        public string Name { get; private set; }

        public virtual string CreateContract()
        {
            return "About Contract:\n"+ "id: "+Id+" name:"+Name+" date start work:"+DateStartWork;
        }

        public virtual void Access()
        {
            Console.Write("id: ");
            this.Id = Console.ReadLine();
            Console.Write("Name: ");
            this.Name = Console.ReadLine();
            Console.Write("Contract Number: ");
            this.ContractNumber = Console.ReadLine();
            Date();
        }
        private void Date()
        {
            while (true)
            {
                Console.Write("Date start work: ");
                this.DateStartWork = Console.ReadLine();
                if (Regex.IsMatch(DateStartWork, @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"))
                    return;
                Console.WriteLine("ban nhap sai cu phap vui long nhap theo cu phap DD/MM/YYYY");
            }
        }
    }
}
