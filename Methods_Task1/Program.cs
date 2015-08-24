using System;

namespace Methods_Task1
{
    class Program
    {
        static void Main()
        {
            double[] currencyRates = {23.05, 0.043, 0.039, 24.1, 1.04, 0.96}; //Currency rates
            try
            {
                string from, to;
                do
                {
                    Console.Write("Choose your currency (UAH, USD, EUR): ");
                    from = Console.ReadLine();
                } while (!from.Equals("UAH") & !from.Equals("USD") & !from.Equals("EUR"));
                do
                {
                    Console.Write("\nChoose target currency (UAH, USD, EUR): ");
                    to = Console.ReadLine();
                } while (!to.Equals("UAH") & !to.Equals("USD") & !to.Equals("EUR")); 

                Console.Write("\nEnter amount of money: ");
                double money = Double.Parse(Console.ReadLine());
                Console.WriteLine();
                Converter converter = new Converter(from, to, currencyRates);
                converter.Convert(money);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message + "\nTry Again!");
            }
            Console.ReadKey();
        }
    }

    internal class Converter
    {
        private string from, to;
        private double[] currencyRates;

        public Converter(string from, string to, double[] currencyRates)
        {
            this.from = from;
            this.to = to;
            this.currencyRates = currencyRates;
        }

        public double Convert(double cash)
        {
            if (from.Equals("USD") & to.Equals("UAH")) return USDtoUAH(cash);
            if(from.Equals("UAH") & to.Equals("USD")) return UAHtoUSD(cash);
            if(from.Equals("UAH") & to.Equals("EUR")) return UAHtoEUR(cash);
            if (from.Equals("EUR") & to.Equals("UAH")) return EURtoUAH(cash);
            if(from.Equals("USD") & to.Equals("EUR")) return USDtoEUR(cash);
            if (from.Equals("EUR") & to.Equals("USD")) return EURtoUSD(cash);
            Console.WriteLine("Can't convert.");
            return 0;
        }

        public double USDtoUAH(double usd)
        {
            double result = usd*currencyRates[0];
            Console.Write("{0} USD to UAH = {1} UAH (currencyRate: 1 USD = {2} UAH)\n", usd, result, currencyRates[0]);
            return result;
        }
        public double UAHtoUSD(double uah)
        {
            double result = uah * currencyRates[1];
            Console.Write("{0} UAH to USD = {1} USD (currencyRate: 1 UAH = {2} USD)\n", uah, result, currencyRates[1]);
            return result;
        }
        public double UAHtoEUR(double uah)
        {
            double result = uah * currencyRates[2];
            Console.Write("{0} UAH to EUR = {1} EUR (currencyRate: 1 UAH = {2} EUR)\n", uah, result, currencyRates[2]);
            return result;
        }
        public double EURtoUAH(double eur)
        {
            double result = eur * currencyRates[3];
            Console.Write("{0} EUR to UAH = {1} UAH (currencyRate: 1 EUR = {2} UAH)\n", eur, result, currencyRates[3]);
            return result;
        }
        public double USDtoEUR(double usd)
        {
            double result = usd * currencyRates[4];
            Console.Write("{0} USD to EUR = {1} EUR (currencyRate: 1 USD = {2} EUR)\n", usd, result, currencyRates[4]);
            return result;
        }
        public double EURtoUSD(double eur)
        {
            double result = eur * currencyRates[5];
            Console.Write("{0} EUR to USD = {1} USD (currencyRate: 1 EUR = {2} USD)\n", eur, result, currencyRates[5]);
            return result;
        }
    }
}
