namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() {}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;

            }
            else
            {

                // Implementado: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new ArgumentException($"Há mais hóspedes do que a capacidade da suite. Capacidade = {Suite.Capacidade} ≠ Hospedes = {hospedes.Count}");
            }
            
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
        
            decimal valor = Suite.ValorDiaria * DiasReservados;

            decimal valorTotal = valor;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10)
            {
                valorTotal = valor * 0.90M;
                Console.WriteLine($"Como os dias reservados passarão de 10, voce teve um desconto de 10%!!");
            }
            
            return valorTotal;
        }
    }
}