using Hierarquia_Lineu.Domains;
using NUnit.Framework;

namespace Hierarquia_Lineu.Tests
{
    public class Testes
    {
        [Test]
        public void Humano_Deve_Retornar_Sua_Hierarquia()
        {
            var humano = new HomoSapiens();
            Assert.AreEqual(humano.GetDescricao(), "Reino: Animalia\nFilo: Chordata\nClasse: Mammalia\nOrdem: Primata\nFamilia: Hominidae\nGenero: Homo\nEspecie: HomoSapiens\n");
        }
        [Test]
        public void Cao_Deve_Retornar_Sua_Hierarquia()
        {
            var cao = new CanisFamiliaris();
            Assert.AreEqual(cao.GetDescricao(),
                "Reino: Animalia\nFilo: Chordata\nClasse: Mammalia\nOrdem: Carnivora\nFamilia: Canidae\nGenero: Canis\nEspecie: CanisFamiliaris\n");
        }
        [Test]
        public void Mao_Deve_Retornar_Sua_Hierarquia()
        {
            var mosca = new MuscaDomestica();
            Assert.AreEqual(mosca.GetDescricao(), 
                "Reino: Animalia\nFilo: Arthropoda\nClasse: Insecta\nOrdem: Diptera\nFamilia: Muscidae\nGenero: Musca\nEspecie: MuscaDomestica\n");
        }
    }
}