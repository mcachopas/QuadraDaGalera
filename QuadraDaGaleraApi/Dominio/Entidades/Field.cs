namespace QuadraDaGaleraApi.Dominio.Entidades
{
    public class Field : BaseObject
    {
        public string Name { get; set; } = string.Empty;
        public bool NightLighting { get; set; }
        public string SurfacetType { get; set; } = string.Empty;
        public bool IsCovered { get; set; }
        public int Capacity { get; set; }
        public string Size { get; set; } = string.Empty;
    }
}
