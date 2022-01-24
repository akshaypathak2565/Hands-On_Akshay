namespace FirstProject.day5.Overriding {
    class Account {
        protected int AccountNo;
        protected decimal Balance;

        public void deposit(int accNumber, decimal balance) {
            this.AccountNo = accNumber;
            this.Balance = balance;
        }

        public virtual void withdraw(int accNumber, decimal amount) {
            this.Balance -= amount;
        }
    }

    class CurrentAccount : Account {
        public override void withdraw(int accNumber, decimal amount) {
            if (base.Balance < 5000) {
                Console.WriteLine("Cannot Withdraw. Insufficient Balance");
            } else {
                base.Balance -= amount;
                Console.WriteLine("Withdraw success");
            }
        }
    }

    class SavingAccount : Account {
        public void deposit(int accNumber, decimal amount) {
            base.deposit(accNumber, amount);
            base.Balance += (base.Balance * 2 / 100) + amount;
            Console.WriteLine("Deposit Success!\nNew Balance: " + Balance);
        }
    }

    class Assignment {
        static void Main(string[] args) {
            CurrentAccount ca = new CurrentAccount();
            ca.deposit(1234, 1000);
            ca.withdraw(1234, 500);

            SavingAccount sa = new SavingAccount();
            sa.deposit(1234, 1000);
            sa.withdraw(1234, 500);
        }
    }
}