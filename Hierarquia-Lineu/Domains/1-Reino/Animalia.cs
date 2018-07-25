using System;

namespace Hierarquia_Lineu.Domains
{
    public class Animalia
    {
        public virtual string GetDescricao()
        {
            return ( "Reino: " + typeof(Animalia).Name +"\n");
        }
    }
}