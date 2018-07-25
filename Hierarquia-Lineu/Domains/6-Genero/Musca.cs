namespace Hierarquia_Lineu.Domains
{
    public class Musca:Muscidae
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Genero: " + typeof(Musca).Name + "\n");
        }
    }
}