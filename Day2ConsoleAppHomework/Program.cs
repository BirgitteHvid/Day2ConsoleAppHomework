using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ConsoleAppHomework
{
    enum TransactionType { Buy, Sell }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            var nominal = float.Parse(userInput);

            Console.WriteLine("Input the trade price:");
            userInput = Console.ReadLine();
            var tradePrice = float.Parse(userInput);

            Console.WriteLine("Input the transaction type:");
            userInput = Console.ReadLine();
            var transactionType = (TransactionType) Enum.Parse(typeof(TransactionType), userInput, true);

            var sign=transactionType==TransactionType.Sell?-1:1;
            var costValue = sign*nominal*tradePrice;

            Console.WriteLine($"The calculated cost value is: {costValue}");
            Console.ReadKey();
        }
    }
}
