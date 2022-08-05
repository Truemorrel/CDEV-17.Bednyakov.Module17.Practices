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
            var accountCalculator = new Calculator(new AccountRegular());

            accountCalculator.Calculate(new Account() { Type = "обычный", Balance = 3000f });
        }
    }
}
