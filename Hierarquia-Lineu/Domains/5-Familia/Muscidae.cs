namespace Hierarquia_Lineu.Domains
{
    public class Muscidae:Diptera
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Familia: " + typeof(Muscidae).Name + "\n");
        }
    }
}