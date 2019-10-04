using RoleplayGame.Characters;

namespace RoleplayGame.Encounters
{
    /// <summary>
    /// Representa un encuentro entre dos personajes.
    /// Se deben crear subclases de esta para representar
    /// encuentros concretos.
    /// </summary>
    public abstract class Encounter
    {
        public IReporter Reporter { get; set; }
        public Character Character1 { get; }
        public Character Character2 { get; }

        public Encounter(Character one, Character two)
        {
            this.Character1 = one;
            this.Character2 = two;
        }

        /// <summary>
        /// Ejecución del encuentro.
        /// </summary>
        public abstract void DoEncounter();
    }
}