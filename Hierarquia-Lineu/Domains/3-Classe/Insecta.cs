namespace Hierarquia_Lineu.Domains
{
    public class Insecta:Arthropoda
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Classe: " + typeof(Insecta).Name + "\n");
        }
    }
}