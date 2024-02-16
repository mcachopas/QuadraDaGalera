﻿namespace QuadraDaGaleraApi.Dominio.Entidades
{
    public class User
    {
        Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
        public string Telephone { get; set; } = string.Empty;
        public bool IsWhatsApp { get; set; }

    }
}
