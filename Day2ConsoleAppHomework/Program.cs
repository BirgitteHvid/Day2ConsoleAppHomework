using System;

namespace Day2ConsoleAppHomework
{
    enum TransactionType { Buy, Sell }

    class Program
    {
        static void Main(string[] args)
        {
            const string currency = "DKK";

            Console.WriteLine("Input the transaction type:");
            var userInput = Console.ReadLine();
            var transactionType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            Console.WriteLine("Input the nominal of the trade:");
            var nominal = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the trade price:");
            var tradePrice = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the trade price for the original trade (only used for sales):");
            var originalPrice = float.Parse(Console.ReadLine());

            var sign = transactionType == TransactionType.Sell ? -1 : 1;
            var costValue = sign * nominal * tradePrice;

            var factor = transactionType == TransactionType.Sell ? 1 : 0;
            var profitLoss = factor * (tradePrice - originalPrice) * nominal;

            var msg1 = "The calculated cost value is: {0:N2} {2}";
            var msg2 = transactionType == TransactionType.Sell ? (", and the profit/loss is: {1:N2} {2}") : "";

            Console.WriteLine(msg1 + msg2, costValue, profitLoss, currency);
            Console.ReadKey();
        }
    }
}
