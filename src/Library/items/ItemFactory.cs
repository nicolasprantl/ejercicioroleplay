namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,
        chancleta = 3,
        Coraza = 4,
        Escoba = 5,
        GuanteDePoderConGemas = 6,
        Palelota = 7,
        Palo = 8,
        Termo = 9,
        Paleta = 10,
        Pelota = 11,
        VaritaSauco = 12
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.chancleta: return new chancleta();
                case ItemType.Coraza: return new Coraza();
                case ItemType.Escoba: return new Escoba();
                //case ItemType.GuanteDePoderConGemas: return new GuanteDePoderConGemas();
                case ItemType.Palelota: return new Palelota();
                case ItemType.Palo: return new Palo();
                case ItemType.Termo: return new Termo();
                case ItemType.Paleta: return new Paleta();
                case ItemType.Pelota: return new Pelota();
                case ItemType.VaritaSauco: return new VaritaDeSauco();


                default: return null;
            }
        }
    }
}