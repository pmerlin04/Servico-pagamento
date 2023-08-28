
using System.Globalization;

namespace ExercicioInterface.Entities
{
    //class parcelas
    internal class Installment
    {
        public DateTime DueDate { get; set; }//data para o pagamento
        public double Amount { get; set; } //valor da "parcela"

        public Installment(DateTime dueDate, double tax)
        {
            DueDate = dueDate;
            Amount = tax;
        }

        
        public override string ToString()
        {
            
            return DueDate.ToString("(dd/MM/yyyy)")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
            
            
        }
    }

}
