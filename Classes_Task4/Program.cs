using System;

namespace Classes_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "Oleg", "Notus");
            invoice.Article = "iphone6";
            invoice.PricePerUnit = 700;
            invoice.Quantity = 2;
            invoice.PrintSumCost();
            invoice.PrintSumCost(0.3);
            Console.ReadKey();
        }
    }

    internal class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        private string article;
        private int quantity;
        private double pricePerUnit;

        public string Article
        {
            get { return article; }
            set { article = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double PricePerUnit
        {
            get { return pricePerUnit; }
            set { pricePerUnit = value; }
        }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public double Cost(double nds)
        {
            double cost = 0;
            switch (Article)
            {
                case "iphone6":
                    cost = pricePerUnit * quantity;
                    break;
                case "sonyz3":
                    cost = pricePerUnit * quantity;
                    break;
                case "htcone":
                    cost = pricePerUnit * quantity;
                    break;
                case "nokialumia":
                    cost = pricePerUnit * quantity;
                    break;
                default:
                    Console.WriteLine("this product is not available.");
                    break;
            }
            if (nds > 0) cost += cost * nds;
            return cost;
        }

        public void PrintSumCost()
        {
            Console.WriteLine("Summary cost without NDS: " + Cost(0));
        }
        public void PrintSumCost(double nds)
        {
            Console.WriteLine("Summary cost with NDS: " + Cost(nds));
        }
    }
}
