namespace Hierarquia_Lineu.Domains
{
    public class Hominidae:Primata
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Familia: " + typeof(Hominidae).Name + "\n");
        }
    }
}