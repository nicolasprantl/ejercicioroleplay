using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    class GuanteDePoderConGemas : IAttackitem, IDefenseItem, ICombinedItem
    {
        private GuanteDePoder guante = new GuanteDePoder();
        private List<Gema> gemas = new List<Gema>();
        public void AddItem(Gema gema)
        {
            this.gemas.Add(gema);
        }
        public int AttackPower
        {
            get
            {
                return (200*this.gemas.Count);
            }
        }

        public int DefensePower
        {
            get
            {
                return (200*this.gemas.Count);
            }
        }

        public override string ToString()
        {
            return ("Guante con" + (this.gemas.Count).ToString());
        }
    }
}