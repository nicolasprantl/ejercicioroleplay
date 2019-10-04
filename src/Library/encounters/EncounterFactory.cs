using RoleplayGame.Characters;

namespace RoleplayGame.Encounters
{
    /// <summary>
    /// Tipos de encuentro
    /// </summary>
    public enum EncounterType
    {
        Attack = 1,
        Exchange = 2
    }

    /// <summary>
    /// Crea objetos de tipo Encuentro
    /// </summary>
    public class EncounterFactory
    {
        /// <summary>
        /// Crea un encuentro basado en el tipo del encuentro y dos
        /// personajes.
        /// </summary>
        public static Encounter GetEncounter(EncounterType type, Character one, Character two)
        {
            switch (type)
            {
                case EncounterType.Attack: return new AttackEncounter(one, two);
                case EncounterType.Exchange: return new ExchangeEncounter(one, two);

                default: throw new System.Exception($"Invalid character {type}");
            }
        }
    }
}