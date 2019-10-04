using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Encounters
{
    /// <summary>
    /// Interfaz para crear reporteros.
    /// Los reporteros describen lo que sucede.
    /// </summary>
    public interface IReporter
    {
        /// <summary>
        /// Reporta cuando un personaje ataca a otro personaje.
        /// </summary>
        /// <param name="attacker">Personaje atacante</param>
        /// <param name="attacked">Personaje atacado</param>
        void ReportAttack(Character attacker, Character attacked);

        /// <summary>
        /// Reporta cuando un personaje le pasa un item a otro.
        /// </summary>
        /// <param name="sender">Personaje emisor</param>
        /// <param name="receiver">Personaje receptor</param>
        /// <param name="item">El item intercambiado</param>
        void ReportExchange(Character sender, Character receiver, IItem item);

        /// <summary>
        /// Reporta cuando un personaje muere.
        /// </summary>
        /// <param name="character">El personaje que muere</param>
        void ReportDead(Character character);
    }
}