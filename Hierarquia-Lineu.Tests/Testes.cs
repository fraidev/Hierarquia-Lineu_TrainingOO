using System;
using Hierarquia_Lineu.Domains;
using NUnit.Framework;

namespace Hierarquia_Lineu.Tests
{
    public class Testes
    {
        [TestCase(typeof(HomoSapiens), "Reino: Animalia\nFilo: Chordata\nClasse: Mammalia\nOrdem: Primata\nFamilia: Hominidae\nGenero: Homo\nEspecie: HomoSapiens\n")]
        [TestCase(typeof(CanisFamiliaris), "Reino: Animalia\nFilo: Chordata\nClasse: Mammalia\nOrdem: Carnivora\nFamilia: Canidae\nGenero: Canis\nEspecie: CanisFamiliaris\n")]
        [TestCase(typeof(MuscaDomestica), "Reino: Animalia\nFilo: Arthropoda\nClasse: Insecta\nOrdem: Diptera\nFamilia: Muscidae\nGenero: Musca\nEspecie: MuscaDomestica\n")]
        public void Teste_de_hierarquia(Type tipo, string descricaoEsperada)
        {
            var x = (Animalia) Activator.CreateInstance(tipo);
            var descricao = x.GetDescricao();
            Assert.AreEqual(descricao, descricaoEsperada);
        }
    }
}