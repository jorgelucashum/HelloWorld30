
namespace HelloWorld30.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; } // 'private' somente a própria classe pode realizar alterações.
        public double Balance { get; protected set; } // o encapsulamento do tipo 'protected' permite sofrer alterações por subclasses (herança).

        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdray(double amount) // Método para sacar.
        {
            Balance -= amount;
        }

        public void Deposit(double amount) // Método para depositar.
        {
            Balance += amount;
        }




    }
}
