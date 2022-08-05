using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Model;

namespace Banking
{
    public class Program
    {
        static void Main(string[] args)
        {
            var accountCalculator = new InterestCalculator();
            var regular = new AccountRegular();
            var budget = new AccountBudget();

            accountCalculator.Calculate(regular, new Account() { Type = "Обычный", Balance = 3000f });
            accountCalculator.Calculate(budget, new Account() { Type = "Зарплатный", Balance = 40000f });
        }
    }
}
