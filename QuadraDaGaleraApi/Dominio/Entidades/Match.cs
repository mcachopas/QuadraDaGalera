namespace QuadraDaGaleraApi.Dominio.Entidades
{
    public class Match
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get { return StartTime - EndTime; } }
        public List<User> Players { get; set; } = new();
    }
}
