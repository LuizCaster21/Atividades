﻿using Course.Entities;
using Course.Entities.Exceptions;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter account data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);
                
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     
            
            try
            {
                account.Withdraw(withdraw);
                Console.WriteLine(account);
            }
            catch (ValueException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}