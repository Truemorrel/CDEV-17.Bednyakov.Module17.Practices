using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Model;

namespace Banking.Model
{
    public class InterestCalculator
    {
        // Метод для расчета процентной ставки
 
        public void Calculate(IProfileCalculate profile, Account account)
        {
            profile.CalculateInterest(account);
        }
    }
}
