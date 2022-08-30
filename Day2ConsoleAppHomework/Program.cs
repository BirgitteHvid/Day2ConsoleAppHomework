using System;

namespace Day2ConsoleAppHomework
{
    enum TransactionType { Buy, Sell }

    class Program
    {
        string currency = "DKK";

        static void Main(string[] args)
        {
            string currency = "DKK";

            Console.WriteLine("Input the transaction type:");
            var userInput = Console.ReadLine();
            var transactionType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            Console.WriteLine("Input the nominal of the trade:");
            userInput = Console.ReadLine();
            var nominal = float.Parse(userInput);

            Console.WriteLine("Input the trade price:");
            userInput = Console.ReadLine();
            var tradePrice = float.Parse(userInput);
            
            Console.WriteLine("Input the trade price for the original trade (only used for sales):");
            userInput = Console.ReadLine();
            var origPrice = float.Parse(userInput);
            
            var sign=transactionType==TransactionType.Sell?-1:1;
            var costValue = sign*nominal*tradePrice;

            var factor = transactionType == TransactionType.Sell ? 1 : 0;
            var prl = factor * (tradePrice - origPrice) * nominal;

            var msg1 = "The calculated cost value is: {0:N2} {1}";
            var msg2 = transactionType == TransactionType.Sell ? (", and the profit/loss is: {2:N2} {3}") : "";

            Console.WriteLine(msg1+msg2,costValue,currency,prl,currency);
            Console.ReadKey();
        }
    }
}
