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
            BusinessAccount businessAccount = new BusinessAccount(32, "jorge", 300, 100);

           // businessAccount.Balance = 300; proibido fazer essa alteração fora da classe ou subclasse com o tipo 'BusinessAccount'(protected).

        }
    }
}
