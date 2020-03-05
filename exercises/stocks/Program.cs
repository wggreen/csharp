using System;
using System.Collections.Generic;

namespace stocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("AAPL", "Apple");
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GOOGL", "Google");
            stocks.Add("AMZN", "Amazon");

            Dictionary<string, List<double>> portfolio = new Dictionary<string, List<double>>();
            List<double> AAPLList = new List<double>();
            AAPLList.Add(1214.90);
            AAPLList.Add(2881.95);

            List<double> GMList = new List<double>();
            GMList.Add(4892.12);

            List<double> CATList = new List<double>();
            CATList.Add(934.21);
            CATList.Add(9025.23);
            CATList.Add(4013.89);

            List<double> GOOGLList = new List<double>();
            GOOGLList.Add(180.44);
            GOOGLList.Add(298.01);
            GOOGLList.Add(9092.45);

            List<double> AMZNList = new List<double>();
            AMZNList.Add(500.23);
            AMZNList.Add(1223.73);
            AMZNList.Add(8201.12);

            portfolio.Add("AAPL", AAPLList);
            portfolio.Add("GM", GMList);
            portfolio.Add("CAT", CATList);
            portfolio.Add("GOOGL", GOOGLList);
            portfolio.Add("AMZN", AMZNList);

            foreach (KeyValuePair<string, List<double>> stock in portfolio)
            {
                double sum = 0;
                foreach (double element in stock.Value)
                {
                    sum += element;
                }
                string matchingStock = "";
                foreach (KeyValuePair<string, string> ticker in stocks)
                {
                    if (ticker.Key == stock.Key)
                    {
                        matchingStock = ticker.Value;
                    }
                }
                Console.WriteLine($"Investor has spent a total of $" + string.Format("{0:0.00}", sum) + $" on the stock for {matchingStock}");
            }
        }
    }
}
