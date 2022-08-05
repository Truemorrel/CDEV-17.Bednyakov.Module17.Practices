using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Model;

namespace Banking.Model
{
    public class Calculator
    {
         IProfileCalculate _profile;
        // Метод для расчета процентной ставки
        public Calculator(IProfileCalculate profile)
        {
            _profile = profile;
        }
        public void Calculate(Account account)
        {
            _profile.CalculateInterest(account);
        }
    }
}
