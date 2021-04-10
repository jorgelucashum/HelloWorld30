

namespace HelloWorld30.Entities
{
    class BusinessAccount : Account // ':' Sintaxe para a classe 'BusinessAccount' herdar todos os atributos e métodos da classe 'Account' (herança).
        // BusinessAccount = subclasse.
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) // ': base' sintaxe para herdar os argumentos do construtor da super classe(base class).
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) // Método para realizar emprestimo.

        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
