namespace RoleplayGame
{
    public class Spell : IAtacar, IDefensa
    {
        public int AttackValue
        {
            get
            {
                return 70;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 70;
            }
        }
    }
}