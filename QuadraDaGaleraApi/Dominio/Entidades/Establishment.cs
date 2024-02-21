namespace QuadraDaGaleraApi.Dominio.Entidades
{
    public class Establishment : BaseObject
    {
        public string Name { get; set; } = string.Empty;
        public string? CNPJ{ get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime CloseTime { get; set; }
        public int SoccerFieldQuantity {get; set;}

    }
}
