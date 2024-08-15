using System.ComponentModel.DataAnnotations;

namespace NossoEnxoval.Models
{
    public class EnxovalModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Name { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataDaCompra { get; set; } = DateTime.Now;
        public bool Comprado { get; set; } = false;
        public string? Comodo { get; set; }
    }
}
