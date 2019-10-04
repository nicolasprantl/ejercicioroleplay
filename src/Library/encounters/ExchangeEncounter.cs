using RoleplayGame.Characters;
using RoleplayGame.Items;
using System.Collections.Generic;

namespace RoleplayGame.Encounters
{
    /// <summary>
    /// Encuentro de intercambio de items entre dos personajes
    /// </summary>
    public class ExchangeEncounter : Encounter
    {
        /// <summary>
        /// Los items a ser intercambiados
        /// </summary>
        /// <typeparam name="IItem"></typeparam>
        /// <returns></returns>
        protected List<IItem> itemsToExchange = new List<IItem>();

        public ExchangeEncounter(Character sender, Character receiver)
            : base(sender, receiver)
        {
        }

        /// <summary>
        /// Constructor sobrecargado que recibe, además de los personajes, los
        /// items a ser intercambiados
        /// </summary>
        /// <param name="sender">El emisor</param>
        /// <param name="receiver">El receptor</param>
        /// <param name="items">Los items a intercambiar</param>
        public ExchangeEncounter(Character sender, Character receiver, List<IItem> items)
            : base(sender, receiver)
        {
            this.itemsToExchange = items;
        }

        public void AddItemToExchange(IItem item)
        {
            this.itemsToExchange.Add(item);
        }

        /// <summary>
        /// Ejecución del intercambio.
        /// Los items son quitados del personaje 1 y asignados al personaje 2
        /// </summary>
        public override void DoEncounter()
        {
            foreach (IItem item in this.itemsToExchange)
            {
                this.Character1.RemoveItem(item);
                this.Character2.AddItem(item);
                this.Reporter.ReportExchange(Character1, Character2, item);
            }
        }
    }
}