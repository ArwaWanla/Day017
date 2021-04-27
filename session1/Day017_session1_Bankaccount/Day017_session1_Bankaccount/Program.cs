using System;

namespace Day017_session1_Bankaccount
{
    class Program
    {
        abstract class BankAccount
        {

            public string AccountOwner;
            public string LastName;
            public decimal Balance;

            public BankAccount(string firstName, string secondName)
            {
                this.AccountOwner = firstName;
                this.LastName = secondName;
            }

            public abstract void Withdraw(decimal amount);

            public abstract void Deposite(decimal amount);


        }

        class CheckingAcc : BankAccount
        {
            public int WithdrawCount = 0;
            public int Charge = 0;
            public CheckingAcc(string f, string l, decimal b) : base(f, l)
            {
                this.AccountOwner = l;
                this.LastName = l;
                this.AccountOwner = f + l;
                this.Balance = b;

            }


            //methods
            public override void Withdraw(decimal amount)
            {
                if (amount > Balance)
                {
                    Console.WriteLine("Denide");

                }
                else
                {
                    Console.WriteLine("Accepted");
                    Balance = Balance - amount;
                    WithdrawCount++;
                    if (WithdrawCount > 3) Balance = Balance - 2;
                }
                // Console.WriteLine("you have withdrown over 3 time. \n you will be subject to extra charge of {0}", Charge);

            }

            public override void Deposite(decimal amount)
            {
                Console.WriteLine("Accepted");
                Balance = Balance + amount;
            }

        }

        class SavingsAcc : BankAccount
        {
            public int WithdrawCount = 0;
            public int Charge = 0;
            public SavingsAcc(string f, string l, decimal b) : base(f, l)
            {
                this.AccountOwner = l;
                this.LastName = l;
                this.AccountOwner = f + l;
                this.Balance = b;
            }


            //methods
            public override void Withdraw(decimal amount)
            {

                if (amount > Balance)
                {
                    Console.WriteLine("Denide");

                }
                else
                {
                    Console.WriteLine("Accepted");
                    Balance = Balance - amount;
                    WithdrawCount++;
                    if (WithdrawCount > 3) Balance = Balance - 2;

                }

                // Console.WriteLine("you have withdrown over 3 time. \n you will be subject to extra charge of {0}", Charge);

            }
            public override void Deposite(decimal amount)
            {
                Console.WriteLine("Accepted");
                Balance = Balance + amount;
            }
        }



        static void Main(string[] args)
        {
            //
            // Create the Checking Account with initial balance
            CheckingAcc checking = new CheckingAcc("Ahmad", "Nasser", 2500.0m);
            // Create the Savings Account with interest and initial balance
            SavingsAcc saving = new SavingsAcc("Ahmad", "Nasser", 1000.0m);
            // Check the balances
            // Expected output should be 2500 and 1000 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
            // Print the account owner information. Expected output: 
            // "Checking owner: Ahmad Nasser"
            // "Savings owner: Ahmad Nasser"
            Console.WriteLine($"Checking owner: {checking.AccountOwner}");
            Console.WriteLine($"Savings owner: {saving.AccountOwner}");
            // Deposit some money in each account
            checking.Deposite(200.0m);
            saving.Deposite(150.0m);
            // Check the balances
            // Expected output should be 2700 and 1150 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
            // Make some withdrawals from each account
            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);
            // Check the balances
            // Expected output should be 2650 and 1025 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
            // More than 3 Savings withdrawals should result in 2.00 charge
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);
            // Savings balance should now be 988.63
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
            // try to overdraw savings - this should be denied and print message
            saving.Withdraw(2000.0m);
            // try to overdraw checking - this should be denied and print message
            checking.Withdraw(3000.0m);
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
        }
    }
}
