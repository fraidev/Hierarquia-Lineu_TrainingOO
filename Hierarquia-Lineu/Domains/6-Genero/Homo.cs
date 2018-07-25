namespace Hierarquia_Lineu.Domains
{
    public class Homo:Hominidae
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Genero: " + typeof(Homo).Name + "\n");
        }
    }
}