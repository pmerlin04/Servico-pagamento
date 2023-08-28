using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;//porcentagem de taxa de pagamento
        private const double MonthlyInterest = 0.01;//porcentagem de juros simples


        //função calcular juros simples a cada mês
        //o for serve para fazer a conta para cada parcela do mês
        //EX: amount + 1% + 1(mes um) e assim sucessivamente
        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        //função taxa de pagamento
        //essa função tem que pegar o resultado do Interest e multiplicar pela taxa de pagamento
        public double PaymentFee(double amount)
        {
           return amount * FeePercentage;
        }


        
    }
}
