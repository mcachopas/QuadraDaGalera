namespace QuadraDaGaleraApi.Dominio.Entidades
{
    public class User : BaseObject
    {

        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
        public string Telephone { get; set; } = string.Empty;
        public bool IsWhatsApp { get; set; }

    }
}
