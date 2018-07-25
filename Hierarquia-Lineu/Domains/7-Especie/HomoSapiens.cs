namespace Hierarquia_Lineu.Domains
{
    public class HomoSapiens:Homo
    {
        public override string GetDescricao()
        {
            return ( base.GetDescricao() + "Especie: " + typeof(HomoSapiens).Name + "\n");
        }
    }
}