namespace Hierarquia_Lineu.Domains
{
    public class Chordata:Animalia
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Filo: " + typeof(Chordata).Name + "\n");
        }
    }
}