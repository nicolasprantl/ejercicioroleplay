using System;
using System.Collections.Generic;

namespace RoleplayGame.Items
{
    class GuanteDePoderConGemas : IAttackItem, IDefenseItem, ICombinedItem
    {
        private Guante_de_poder guante = new Guante_de_poder();
        private List<IItem> items = new List<IItem>();
        public List<IItem> Items{ get;}
        public void AddItem(IItem gema)
        {
            this.items.Add((IItem)gema);
        }
        public int AttackPower
        {
            get
            {
                return (200*this.items.Count);
            }
        }

        public int DefensePower
        {
            get
            {
                return (200*this.items.Count);
            }
        }

        public override string ToString()
        {
            return ("Guante con" + (this.items.Count).ToString());
        }
    }
}