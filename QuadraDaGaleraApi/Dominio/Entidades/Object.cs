namespace QuadraDaGaleraApi.Dominio.Entidades
{
    public class BaseObject
    {
        public Guid Id { get; set; }   
    
        public BaseObject()
        {
            Id = Guid.NewGuid();
        } 
    }
}
