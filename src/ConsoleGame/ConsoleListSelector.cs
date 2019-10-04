using System;
using System.Collections.Generic;

namespace Program
{
    /// <summary>
    /// Permite mostrar una lista por consola para que el usuario escoja
    /// un elemento.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConsoleListSelector<T>
    {
        /// <summary>
        /// Muestra la lista de opciones y un mensaje de prompt para que
        /// el usuario escoja una.
        /// </summary>
        /// <param name="options">Opciones disponibles</param>
        /// <param name="message">Mensaje de prompt</param>
        /// <returns>Opción elegida</returns>
        public static T Select(List<T> options, string message="Select one:")
        {
            Dictionary<string, string> numberedOptions = new Dictionary<string, string>();
            for (int i = 0; i < options.Count; i++)
            {
                numberedOptions.Add($"{i+1}", options[i].ToString());
            }
            
            Console.WriteLine(message);
            foreach (string key in numberedOptions.Keys)
            {
                Console.WriteLine($"  {key}. {numberedOptions[key]}");
            }
            Console.Write("Enter number (empty to finish): ");
            
            string selected = Console.ReadLine().Trim();
            if (selected != "")
            {
                return options[Int32.Parse(selected) - 1];
            }

            return default(T);
        }
    }
}