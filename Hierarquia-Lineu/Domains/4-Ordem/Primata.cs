namespace Hierarquia_Lineu.Domains
{
    public class Primata:Mammalia
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Ordem: " + typeof(Primata).Name + "\n");
        }
    }
}