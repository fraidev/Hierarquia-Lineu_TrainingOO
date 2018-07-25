namespace Hierarquia_Lineu.Domains
{
    public class Canidae:Carnivora
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Familia: " + typeof(Canidae).Name + "\n");
        }
    }
}