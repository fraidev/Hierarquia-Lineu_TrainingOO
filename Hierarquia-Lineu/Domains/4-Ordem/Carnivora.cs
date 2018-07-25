namespace Hierarquia_Lineu.Domains
{
    public class Carnivora:Mammalia
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Ordem: " + typeof(Carnivora).Name + "\n");
        }
    }
}