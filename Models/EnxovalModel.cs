namespace NossoEnxoval.Models
{
    public class EnxovalModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Comprado { get; set; } = false;
        public double Valor { get; set; }
        public DateTime DataDaCompra { get; set; }
    }
}
