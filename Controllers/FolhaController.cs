using Microsoft.AspNetCore.Mvc;
using FolhaDePagamento.Models;
using FolhaDePagamento.Data;
using Microsoft.EntityFrameworkCore; // Importe o namespace necessário

namespace FolhaDePagamento.Controllers
{
    [Route("api/folha")]
    [ApiController]
    public class FolhaController : ControllerBase
    {
        private readonly AppDataContext _context; // Variável de classe para o contexto de dados

        public FolhaController(AppDataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(Folha folha)
        {
            // Calcula os valores necessários
            decimal ir = folha.CalcularIR();
            decimal inss = folha.CalcularINSS();
            decimal fgts = folha.CalcularFGTS();
            decimal salarioLiquido = folha.CalcularSalarioLiquido();

            // Salve a folha de pagamento com os valores calculados no seu banco de dados
            _context.Folhas.Add(folha);
            _context.SaveChanges();

            // Retorna um status de sucesso
            return Ok("Folha de pagamento criada com sucesso.");
        }

       [HttpGet]
public IActionResult Get()
{
    // Recupera todas as folhas de pagamento do banco de dados
    var folhas = _context.Folhas.ToList();

    // Calcula os valores para cada folha
    var folhasCalculadas = folhas.Select(folha => new FolhaCalculada
    {
        SalarioBruto = folha.CalcularSalarioBruto(),
        ImpostoRenda = folha.CalcularIR(),
        INSS = folha.CalcularINSS(),
        FGTS = folha.CalcularFGTS(),
        SalarioLiquido = folha.CalcularSalarioLiquido()
    }).ToList();

    // Retorna todas as folhas de pagamento com os valores calculados
    return Ok(folhasCalculadas);
}
}

    public class FolhaCalculada
{
    public decimal SalarioBruto { get; set; }
    public decimal ImpostoRenda { get; set; }
    public decimal INSS { get; set; }
    public decimal FGTS { get; set; }
    public decimal SalarioLiquido { get; set; }
}

}



