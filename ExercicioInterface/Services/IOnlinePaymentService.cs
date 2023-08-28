using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Services
{
    internal interface IOnlinePaymentService
    {
        //função taxa de pagamento
        //essa função tem que pegar o resultado do Interest e multiplicar pela taxa de pagamento
        double PaymentFee(double amount);


        //função calcular juros simples a cada mês
        //o for serve para fazer a conta para cada parcela do mês
        //EX: amount + 1% + 1(mes um) e assim sucessivamente
        public double Interest(double amount, int months);
    }
}
