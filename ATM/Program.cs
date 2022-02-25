using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{

    public class Bank
    {
        private string owner;
        private int balance;
        public Bank(string ow, int bal)
    {
        owner= ow;
        balance= bal;
    }
    public int Bal
        {
            get
            {
                return balance;
            }
        }
    public void Devid(int amount)
    {
        balance += amount;
    }
    public void withdraw(int amount)
    {
        balance -= amount;
    }
}
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bank obj =new Bank("manoj kumar", 500);
            Console.WriteLine("1 for check balance ? 2 for devid amount  ? 3 for withdraw amount ");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Your current  Balance is : " + obj.Bal);
                    break;
                case 2:
                    Console.WriteLine("Enter the amout to devid :");
                    int ad = int.Parse(Console.ReadLine());
                    obj.Devid(ad);
                    Console.WriteLine("Your divited amount is : " + ad);
                    Console.WriteLine("Your Account Total Balance is : " + obj.Bal);
                    break;
                case 3:
                    Console.WriteLine("Enter the amount to withdraw :");
                    int aw = int.Parse(Console.ReadLine());
                    obj.withdraw(aw);
                    Console.WriteLine("Your Withdraw amount is :" + aw);
                    Console.WriteLine("Your Account Total Balance is : " + obj.Bal);
                    break;
                default:
                    Console.WriteLine("Plz input valid Choice : ");
                    break;
            }
            Console.ReadLine();
        }
    }
}