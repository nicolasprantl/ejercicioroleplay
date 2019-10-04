namespace RoleplayGame.Items
{
    public class VaritaDeSauco : IAttackItem, IDefenseItem
    {
        public int AttackPower
        {
            get
            {
                return 80;
            }
        }
        public int DefensePower
        {
            get
            {
                return 100;
            }
        }

        public override string ToString()
        {
            return "Varita de Sauco";
        }
    }
}