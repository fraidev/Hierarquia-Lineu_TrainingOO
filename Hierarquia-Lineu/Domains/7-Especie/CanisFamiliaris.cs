namespace Hierarquia_Lineu.Domains
{
    public class CanisFamiliaris:Canis
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Especie: " + typeof(CanisFamiliaris).Name + "\n");
        }
    }
}