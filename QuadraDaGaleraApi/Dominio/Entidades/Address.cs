namespace QuadraDaGaleraApi.Dominio.Entidades
{
    public class Address
    {
        public int CEP { get; set; }
        public string State { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Neighborhood { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int Number { get; set; }
    }
}
