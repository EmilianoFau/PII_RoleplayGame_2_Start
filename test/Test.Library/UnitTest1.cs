using NUnit.Framework;

namespace RoleplayGame
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ataqueNegativo()
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            gimli.ReceiveAttack(gandalf.AttackValue);
            gimli.ReceiveAttack(gandalf.AttackValue);

            Assert.AreEqual(gimli.Health, 0);
        }

        [Test]
        public void TestAtaque()
        {
            Archer gandalf = new Archer("Gandalf");
            gandalf.Bow = new Bow();
            gandalf.Helmet = new Helmet();

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            gandalf.ReceiveAttack(gimli.AttackValue);

            Assert.AreEqual(gandalf.Health, 93);
        }
    }
}