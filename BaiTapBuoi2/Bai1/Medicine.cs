using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class Medicine
    {
        /// <summary>
        /// ham khoi tao thuoc
        /// </summary>
        public Medicine() { }
        public Medicine(string medicineCode, string medicineName, string manufacturerName, string unitPrice, string quantityOnHand, string manufacturedDate, string expiryDate, string batchNumber) : this()
        {
            this.MedicineCode = medicineCode;
            this.MedicineName = medicineName;
            this.ManufacturerName = manufacturerName;
            this.UnitPrice = unitPrice;
            this.QuantityOnHand = quantityOnHand;
            this.ManufacturedDate = manufacturedDate;
            this.ExpiryDate = expiryDate;
            this.BatchNumber = batchNumber;
        }

        public string BatchNumber { get; private set; }
        public string ExpiryDate { get; private set; }
        public string ManufacturedDate { get; private set; }
        public string ManufacturerName { get; private set; }
        public string MedicineCode { get; private set; }
        public string MedicineName { get; private set; }
        public string QuantityOnHand { get; private set; }
        public string UnitPrice { get; private set; }


        public void Accept()
        {
            Console.Write("Medicine Code :");
            this.MedicineCode = Console.ReadLine();
            Console.Write("Medicine Name :");
            this.MedicineName = Console.ReadLine();
            Console.Write("Manufacturer Name :");
            this.ManufacturerName = Console.ReadLine();
            Console.Write("Unit Price :");
            this.UnitPrice = Console.ReadLine();
            Console.Write("Quantity On Hand :");
            this.QuantityOnHand = Console.ReadLine();
            Console.Write("Manufacturer Date :");
            this.ManufacturedDate = Console.ReadLine();
            Console.Write("Expiry Date :");
            this.ExpiryDate = Console.ReadLine();
            this.BatchNumber = Console.ReadLine();
        }

        public override string ToString()
        {
            return "About medicine:\n" + "Batch Number: " + BatchNumber + " Expiry Date: " + ExpiryDate + " Manufactured Date: " + ManufacturedDate + " Medicine Code: " + MedicineCode + " Medicine Name: " + MedicineName+ " Quantity On Hand: "+ QuantityOnHand+" Unit Price: "+UnitPrice;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }

        public void PrintAboutMedicine()
        {
            Console.WriteLine(this);
        }
        public void PrintQuantityOnHand()
        {
            Console.WriteLine("QuantityOnHand: "+QuantityOnHand);
        }
        public void PrintExpiryDateAndManufactured()
        {
            Console.WriteLine( "ExpiryDate:" + ExpiryDate + "\nManufacturedDate:" + ManufacturedDate);
        }
    }
}
