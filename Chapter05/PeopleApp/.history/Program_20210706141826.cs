using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };
            WriteLine(
                format: "{0} was born on {1:dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth);

            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth);

            bob.FavoriteAcientWonder = WonderOfTheAncientWorld.StatueOfZeusAtOlympia;
            WriteLine(
                format: "{0}'s favorite wonder is {1}. It's integer is 2.",
                arg0: bob.Name,
                arg1: bob.FavoriteAcientWonder,
                arg2: (int)bob.FavoriteAcientWonder);

            bob.Bucklist = WonderOfTheAncientWorld.HangingGardensOfBabylon | WonderOfTheAncientWorld.MausoleumAtHalicarnassus;
            // bob.Bucketlist = (WonderOfTheAncientWold)18;
            WriteLine($"{bob.Name}'s bucket list is {bob.Bucklist}");

            bob.Children.Add(new Person { Name = "alfred" });
            bob.Children.Add(new Person { Name = "Zoe" });

            WriteLine($"{bob.Name} has {bob.Children.Count} Children:");
            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($" {bob.Children[child].Name}");
            }

            WriteLine($"{bob.Name} is a {Person.Species}");

            BankAccount.InterestRate = 0.012M;  // store a shared value
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;
            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate);
            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;
            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: gerrierAccount.AccountName,
                arg1: gerrierAccount.Balance * BankAccount.InterestRate);
        }
    }
}
