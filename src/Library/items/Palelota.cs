using System;

namespace RoleplayGame.Items
{
    class Palelota : IAttackitem, IDefenseItem
    {
        private Pelota pelota = new Paleta();
        private Paleta paleta = new Pelota();
        public int AttackPower
        {
            get
            {
                return (pelota.AttackPower + paleta.AttackPower);
            }
        }

        public int DefensePower
        {
            get
            {
                return (pelota.DefensePower + pelota.DefensePower);
            }
        }

        public override string ToString()
        {
            return "Palelota";
        }
    }
}