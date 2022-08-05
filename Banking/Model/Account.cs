using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Model;


namespace Banking.Model
{
    public class Account
    {
        // тип учетной записи
        public string Type { get; set; }
        
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
        }
    }
}
