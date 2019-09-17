using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Sales
    {
        public Sales() { }
        public Sales(string medicineCode, string quantitySold, string plannedSales, string actualSales, string region) : this()
        {
            this.MedicineCode = medicineCode;
            this.QuantitySold = quantitySold;
            this.PlannedSales = plannedSales;
            this.ActualSales = actualSales;
            this.Region = region;
        }

        public string ActualSales { get; private set; }
        public string MedicineCode { get; private set; }
        public string PlannedSales { get; private set; }
        public string QuantitySold { get; private set; }
        public string Region { get; private set; }
        public void Accept()
        {
            Console.Write("Medicine Code: ");
            MedicineCode = Console.ReadLine();
            Console.Write("ActualSales: ");
            ActualSales = Console.ReadLine();
            Console.Write("QuantitySold: ");
            QuantitySold = Console.ReadLine();
            Console.Write("PlannedSales: ");
            PlannedSales = Console.ReadLine();
            Console.Write("Region: ");
            Region = Console.ReadLine();
        }
        public override string ToString()
        {
            return "About sales\n"+ "Medicine Code: "+MedicineCode+ " ActualSales: "+ActualSales+ " QuantitySold: "+QuantitySold+ " PlannedSales: "+PlannedSales+" Region: "+ Region ;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }
        public void PrintAboutSales()
        {
            Console.WriteLine(this);
        }
        public void PrintActualSalesAndPlannedSales()
        {
            Console.WriteLine("ActualSales: "+ActualSales);
            Console.WriteLine("PlannedSales: " + PlannedSales);
        }
    }
}
