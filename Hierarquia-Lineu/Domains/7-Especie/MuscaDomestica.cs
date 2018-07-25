namespace Hierarquia_Lineu.Domains
{
    public class MuscaDomestica:Musca
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Especie: " + typeof(MuscaDomestica).Name + "\n");
        }
    }
}