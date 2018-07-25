namespace Hierarquia_Lineu.Domains
{
    public class Canis:Canidae
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Genero: " + typeof(Canis).Name + "\n");
        }
    }
}