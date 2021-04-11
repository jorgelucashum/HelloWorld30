using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld30.Entities; // Ter acesso as classes da pasta Entities

namespace HelloWorld30
{
// Herança:
// É um tipo de associação que permite que uma classe herde dados e comportamentos de outra.
// Vatagens:
// - Reuso
// - Polimorfismo

// Sintaxe:
// ':' = estende
// 'base' = referência para a superclasse

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bAcc = new BusinessAccount(1002, "Jorge", 0, 500);

            // businessAccount.Balance = 300; proibido fazer essa alteração fora da classe ou subclasse com o tipo 'BusinessAccount'(protected).

            // UPCASTING:
            Account acc1 = bAcc; // Trasnformando um tipo 'BusinessAccount' em um 'Account'.
            Account acc2 = new BusinessAccount(1003, "Maria", 0, 600); // Criando um tipo 'Account'(superclasse) e atribuindo a instanciação para o tipo 'BusinessAccount(subclasse)'.
            Account acc3 = new SavingsAccount(1004, "Joao", 0, 400); // Criando um tipo 'Account'(superclasse) e atribuindo a instanciação para o tipo 'SavingsAccount(subclasse)'.


            // DOWNCASTING: // É uma operação insegura, só será usado caso for realmente necessário e verificando a lógica da classe.
            // BusinessAccount acc4 = acc2; // Não funciona.
            // Porque 'acc4' é uma subclasse e 'acc2' é uma superclasse (superclasse > subclasse), é preciso realizar um casting informando o tipo da subclasse dentro da superclasse: '(BusinessAccount)acc2'.
            BusinessAccount acc4 = (BusinessAccount)acc2;

            // BusinessAccount acc5 = (BusinessAccount)acc3; // Dará erro porque o 'acc3' é do tipo SavingsAccount que não é compativel com o tipo 'BusinessAccount'
            if (acc3 is BusinessAccount) // 'is' para testar se 'acc3' é de um tipo compatível para realizar a conversão.
            {
                BusinessAccount acc5 = (BusinessAccount)acc3; // Outra forma de casting com operador 'as': // acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount) // 'is' para testar se 'acc3'
            {
                SavingsAccount acc5 = (SavingsAccount)acc3; // Outra forma de casting com operador 'as': // acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}
