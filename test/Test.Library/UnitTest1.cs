using NUnit.Framework;

namespace Roleplay_PII_Grupal
{

    public class ExampleTest
    {

        [Test]
        public void ataqueTest()
        {
            Item palito = new Item("Palito", "Hola", 100, 50, 0);
            Magos mago1 = new Magos("Oswald", 100, palito);
            Magos mago2 = new Magos("Emi", 100, palito);
            mago1.Atacar(mago2);
            Assert.AreEqual(mago2.Vida, palito.ValorAtaque);
        }

        [Test]
        public void ataqueNegativo()
        {
            Item palito = new Item("Palito", "Hola", 100, 50, 0);
            Magos mago1 = new Magos("Oswald", 100, palito);
            Magos mago2 = new Magos("Emi", 100, palito);
            mago1.Atacar(mago2);
            mago1.Atacar(mago2);
            mago1.Atacar(mago2);
            Assert.AreEqual(mago2.Vida, 0);
        }

    }
}