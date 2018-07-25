namespace Hierarquia_Lineu.Domains
{
    public class Arthropoda:Animalia
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Filo: " + typeof(Arthropoda).Name + "\n");
        }
    }
}