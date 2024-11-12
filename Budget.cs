using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    public class Budget
    {
        public float Amount { get; set; }
        public Budget(float initialAmount)
        {
            Amount = initialAmount;
        }
        
        

        public float CurrentAmount {  get; set; }
        public void SpendMoney(float Amount)
        {
            if (Amount > CurrentAmount)
            {
                Console.WriteLine("Not enought money.");
            }
            else
            {
                CurrentAmount -= Amount;
                Console.WriteLine($"{Amount:C}$ spent it. remaining budget: {CurrentAmount:C}$");
            }
        }
    }
}
