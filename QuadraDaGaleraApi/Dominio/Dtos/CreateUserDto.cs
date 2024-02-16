namespace QuadraDaGaleraApi.Dominio.Dtos
{
    public class CreateUserDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
        public string Telephone { get; set; } = string.Empty;
        public bool IsWhatsApp { get; set; }
    }
}
