namespace FolhaDePagamento.Models
{
    public class Folha
    {
        public int Id { get; set; }
        public decimal valor { get; set; }
        public int  quantidade { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }
        public Funcionario? Funcionario { get; set; }
        public int FuncionarioId { get; set; }

        public decimal CalcularSalarioBruto()
        {
            // Lógica para calcular o salário bruto
            decimal salarioBruto = (decimal)valor * quantidade;
            return salarioBruto;
        }

        public decimal CalcularIR()
        {
            // Lógica para calcular o Imposto de Renda (IR) com base no salário bruto
            decimal salarioBruto = CalcularSalarioBruto();
            decimal ir = 0;

            if (salarioBruto <= 1903.98m)
            {
                ir = 0;
            }
            else if (salarioBruto <= 2826.65m)
            {
                ir = (salarioBruto * 0.075m) - 142.80m;
            }
            else if (salarioBruto <= 3751.05m)
            {
                ir = (salarioBruto * 0.15m) - 354.80m;
            }
            else if (salarioBruto <= 4664.68m)
            {
                ir = (salarioBruto * 0.225m) - 636.13m;
            }
            else
            {
                ir = (salarioBruto * 0.275m) - 869.36m;
            }

            return ir;
        }

        public decimal CalcularINSS()
        {
            // Lógica para calcular o desconto do INSS com base no salário bruto
            decimal salarioBruto = CalcularSalarioBruto();
            decimal inss = 0;

            if (salarioBruto <= 1693.72m)
            {
                inss = salarioBruto * 0.08m;
            }
            else if (salarioBruto <= 2822.90m)
            {
                inss = salarioBruto * 0.09m;
            }
            else if (salarioBruto <= 5645.80m)
            {
                inss = salarioBruto * 0.11m;
            }
            else
            {
                inss = 621.03m; // Valor fixo
            }

            return inss;
        }

        public decimal CalcularFGTS()
        {
            // Lógica para calcular o FGTS com base no salário bruto
            decimal salarioBruto = CalcularSalarioBruto();
            decimal fgts = salarioBruto * 0.08m;
            return fgts;
        }

        public decimal CalcularSalarioLiquido()
        {
            // Lógica para calcular o salário líquido
            decimal salarioBruto = CalcularSalarioBruto();
            decimal ir = CalcularIR();
            decimal inss = CalcularINSS();
            decimal salarioLiquido = salarioBruto - ir - inss;

            return salarioLiquido;
        }
    }
}
