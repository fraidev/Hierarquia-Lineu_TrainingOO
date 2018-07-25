namespace Hierarquia_Lineu.Domains
{
    public class Mammalia:Chordata
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Classe: " + typeof(Mammalia).Name + "\n");
        }
    }
}