// Na sequencia crie as classes aqui

using System.Diagnostics.Contracts;

public class Usuario
{
    public String name { get; set; }
    public String email { get; set; }
    public DateTime DateBirth { get; set; }
    public String telephone { get; set; }
    public bool isWhatsApp { get; set; }

}

public class Estabelecimento
{
    public String name { get; set; }
    public String? cnpj { get; set; }
    public String adress { get; set; }
    public DateTime OpeningTime { get; set;}
    public DateTime CloseTime { get; set; }

}

public class Quadra
{
    public String name { get; set; }
    public bool nightLighting {  get; set; }
    public String surfacetType {  get; set; }
    public bool isCovered {  get; set; }
    public int capacity {  get; set; }
    public string size { get; set; }
}

public class Partida
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public TimeSpan Duration { get { return HoraInicio - HoraTermino } }
    public List<Usuario> Players { get; set; }

    public Partida()
    {
        Players = new List<Usuario>();
    }
}