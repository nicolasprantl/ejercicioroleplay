using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Representa un personaje.
    /// Debes crear subclases de esta para poder instanciarlos.
    /// </summary>
    public abstract class Character
    {
        public Character(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        /// <summary>
        /// Nivel del vida del personaje.
        /// </summary>
        protected int health;
        public int Health 
        { 
            get
            {
                return this.health;
            }
            protected set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        /// <summary>
        /// Los items que posee este personaje.
        /// </summary>
        /// <typeparam name="IItem"></typeparam>
        /// <returns>La lista de items</returns>
        protected List<IItem> items = new List<IItem>();
        public List<IItem> Items {
            get
            {
                return this.items;
            }
        }

        /// <summary>
        /// Verdadero si el personaje está muerto.
        /// </summary>
        /// <value>Verdadero si está muerto</value>
        public bool IsDead
        {
            get
            {
                return this.health == 0;
            }
        }

        public void AddItem(IItem item)
        {
            this.Items.Add(item);
        }

        public void AddItems(List<IItem> items)
        {
            foreach (IItem item in items)
            {
                this.AddItem(item);
            }
        }

        public void RemoveItem(IItem item)
        {
            this.Items.Remove(item);
        }

        /// <summary>
        /// Calcula y devuelve el valor de ataque del personaje.
        /// </summary>
        /// <value>El valor de ataque.</value>
        public int AttackPower
        {
            get
            {
                int attackPower = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        attackPower += ((IAttackItem) item).AttackPower;
                    }
                }
                return attackPower;
            }
        }

        /// <summary>
        /// Calcula y devuelve el valor de defensa del personaje.
        /// </summary>
        /// <value>El valor de defensa.</value>
        public int DefensePower
        {
            get
            {
                int defensePower = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        defensePower += ((IDefenseItem) item).DefensePower;
                    }
                }
                return defensePower;
            }
        }

        /// <summary>
        /// Recibe el ataque de otro personaje.
        /// El valor que recibe es el poder de ataque. Se calcula
        /// el ataque total restandole el valor de defensa de este
        /// personaje.
        /// </summary>
        /// <param name="attackPower">Poder de ataque.</param>
        public void ReceiveAttack(int attackPower)
        {
            int delta = attackPower - this.DefensePower;
            if (delta > 0)
            {
                this.Health -= delta;
            }
        }

        public override string ToString()
        {
            string items = "";
            foreach (IItem item in this.items)
            {
                items += (items.Equals("") ? "" : ", ") + item.ToString();
            }
            return $"{ this.GetType().Name } called { this.Name } with a { items }. Health: { this.Health }";
        }
    }
}