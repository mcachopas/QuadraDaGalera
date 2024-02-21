namespace QuadraDaGaleraApi.Dominio.Dtos.EstablishmentDtos
{
    public class CreateEstablishmentDto
    {
        public string Name { get; set; } = string.Empty;
        public string? CNPJ{ get; set; }
        public string Address { get; set; } = string.Empty;
        public DateTime OpeningTime { get; set; }
        public DateTime CloseTime { get; set; }
    }
}