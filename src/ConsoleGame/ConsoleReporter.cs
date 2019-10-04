using System;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;

namespace Program
{
    /// <summary>
    /// Permite reportar los acontecimientos de un escenario por consola.
    /// </summary>
    public class ConsoleReporter : IReporter
    {
        /// <summary>
        /// Reporta un ataque.
        /// </summary>
        /// <param name="attacker">Personaje que ataca</param>
        /// <param name="attacked">Personaje que es atacado</param>
        public void ReportAttack(Character attacker, Character attacked)
        {
            Console.WriteLine($"\n⚔️  ATTACK!  \"{attacker.Name}\" attacked \"{attacked.Name}\".");
            Console.WriteLine($"    -> \"{attacked.Name}\" health's is now {attacked.Health}");
        }

        /// <summary>
        /// Reporta un intercambio de item entre dos personajes.
        /// </summary>
        /// <param name="sender">Personaje que entrega el item.</param>
        /// <param name="receiver">Personaje que recibe el item.</param>
        /// <param name="item">El item que se intercambia,</param>
        public void ReportExchange(Character sender, Character receiver, IItem item)
        {
            Console.WriteLine($"\n🔁  Exchange:  \"{sender.Name}\" sent \"{receiver.Name}\" a {item}");
            Console.WriteLine($"New state of the characters:");
            Console.WriteLine(sender);
            Console.WriteLine(receiver);
            Console.WriteLine("");
        }

        /// <summary>
        /// Reporta la muerte de un personaje.
        /// </summary>
        /// <param name="character">El personaje que muere.</param>
        public void ReportDead(Character character)
        {
            Console.WriteLine($"\n☠️  DEAD:  {character.Name} is now dead.");
            Console.WriteLine("");
        }
    }
}