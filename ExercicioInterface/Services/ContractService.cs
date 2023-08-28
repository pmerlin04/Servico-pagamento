using ExercicioInterface.Entities;

namespace ExercicioInterface.Services
{
    internal class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
           double parcela = contract.TotalValue/months;
            
            //looping para colocar valor nas parcelas
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);//adcionar um mes a cada data
                double updatedQuota = parcela + _onlinePaymentService.Interest(parcela, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallments(new Installment(date, fullQuota));
            }
           
                
            

        }
    }
}
