using ExercicioInterface.Entities;
using ExercicioInterface.Services;
using System.Globalization;

namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());//numero do contrato
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());//data do contrato
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//valor do contrato
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());//meses para parcelar

            Contract contract = new Contract(number, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contract, months);


            Console.WriteLine("Installments: ");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }








        }
    }
}
