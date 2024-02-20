﻿namespace QuadraDaGaleraApi.Dominio.Entidades
{
    public class Establishment
    {
        Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? CNPJ{ get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime CloseTime { get; set; }
        public int SoccerFieldQuantity {get; set;}

    }
}
