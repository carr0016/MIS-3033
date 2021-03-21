using System;
using System.Collections.Generic;
using System.Text;

namespace Review_HW1
{
    public class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }
        private double SalesTaxPercent { get; set; }
        private double CogPrice { get; set; }
        private double GearPrice { get; set; }



        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = .089;
            CogPrice = 79.99;
            GearPrice = 250.00;
        }

        public Receipt(int id, int cog,int gear)
        {
            CustomerID = id;
            CogQuantity = cog;
            GearQuantity = gear;
        }

        public double CalculateTotal()
        {
            double netAmount = CalculateNetAmount();
            double taxAmount = CalculateTaxAmount();

            return netAmount + taxAmount;
        }

        public void PrintReceipt()
        {
            string receipt = 
                      $"\t{string.Empty.PadLeft(40, '#')}\n" +
                      $"\t{"".PadLeft(05, ' ') + "Customer:"} {CustomerID}\n" +
                      $"\t{string.Empty.PadLeft(40, '-')}\n" +
                      $"\t{"# of Cogs:".PadRight(15, ' ')}{CogQuantity.ToString("N0")}\\N" +
                      $"\t{"# of Gears:".PadRight(15, ' ')}{GearQuantity.ToString("N0")}\\N" +
                      $"\t{"Subtotal:".PadRight(15, ' ')}{CalculateNetAmount().ToString("C")}\\N" +
                      $"\t{"Sales Tax:".PadRight(15, ' ')}{CalculateTaxAmount().ToString("C")}\\N" +
                      $"\t{"Total:".PadRight(15, ' ')}{CalculateTotal().ToString("C")}\\N" +
                      $"\t{string.Empty.PadLeft(40, '#')}";
            //$"{"Customer:"} {CustomerID}" +
            //$"{"Number of COGS:"} {CogQuantity}" +
            //$"{"Number of Gears:"} {GearQuantity}" +
            //$"{"Sub Total:"} {CalculateNetAmount()}" +
            //$"{"Sales Tax:"} {CalculateTaxAmount()}" +
            //$"{Total:"} {CaclulateTotal()}";


        }

        private double CalculateTaxAmount()
        {
                return CalculateNetAmount() * SalesTaxPercent;

        }

        private double CalculateNetAmount()
        {
            double netAmount, cogpricewithMarkup, gearpricewithMarkup;
            if (CogQuantity>10 | GearQuantity>10 | (CogQuantity+GearQuantity) >16)
            {
                cogpricewithMarkup = CogPrice * .125;
                gearpricewithMarkup = GearPrice * .125;

            }
            else
            {
                cogpricewithMarkup = CogPrice * .15;
                gearpricewithMarkup = GearPrice * .15;
            }
            netAmount = CogQuantity * cogpricewithMarkup + GearQuantity * gearpricewithMarkup;
            return netAmount;
        }
    }

}
