namespace NossoEnxoval.Models
{
    public class EnxovalModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDaCompra { get; set; }

        public bool Comprado { get; set; }
        public string Comodo { get; set; }
    }
}
