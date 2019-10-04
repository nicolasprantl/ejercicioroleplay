using System;

namespace RoleplayGame.Items
{
    class Palelota : IAttackItem, IDefenseItem
    {
        private Pelota pelota = new Pelota();
        private Paleta paleta = new Paleta();
        public int AttackPower
        {
            get
            {
                return (pelota.AttackPower);
            }
        }

        public int DefensePower
        {
            get
            {
                return (paleta.DefensePower);
            }
        }

        public override string ToString()
        {
            return "Palelota";
        }
    }
}