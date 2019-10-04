using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    class GuanteDePoderConGemas : IAttackitem, IDefenseItem
    {
        private GuanteDePoder guante = new GuanteDePoder();
        private List<Gema> gemas = new List<Gema>();
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
        public void AddGemas
        {
            this.gemas.Add
        }

        public override string ToString()
        {
            return "Palelota";
        }
    }
}