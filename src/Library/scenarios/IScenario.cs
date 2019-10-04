namespace RoleplayGame.Scenarios
{
    /// <summary>
    /// Interfaz para crear Escenarios
    /// </summary>
    public interface IScenario
    {
        /// <summary>
        /// Creación de los elementos del escenario.
        /// </summary>
        void Setup();

        /// <summary>
        /// Ejecución del escenario.
        /// </summary>
        void Run();
    }
}