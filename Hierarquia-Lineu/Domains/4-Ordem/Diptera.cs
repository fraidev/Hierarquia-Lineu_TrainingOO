namespace Hierarquia_Lineu.Domains
{
    public class Diptera:Insecta
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Ordem: " + typeof(Diptera).Name + "\n");
        }
    }
}