using UnityEngine;

namespace ConsoleUtility
{
    public static class ConsoleUtility
    {
        public const string LegacyConsoleName = "Console_LegacyInput";
        public const string UnityInputSystemConsoleName = "Console_NewInputSystem";


        /// <summary>
        /// You may call this method to instantiate the console manually.
        /// </summary>
        /// <param name="consoleName">The name of the prefab.</param>
        /// <param name="consoleGo">The instantiated prefab reference.</param>
        /// <returns>A <see cref="bool"/> result whether the console object could be instantiated or not.</returns>
        public static bool CreateConsole(string consoleName, out GameObject consoleGo)
        {
            if (string.IsNullOrWhiteSpace(consoleName))
            {
                Debug.LogError($"{nameof(CreateConsole)}: Invalid prefab name!");
                consoleGo = default;
                return false;
            }

            GameObject prefabInstance = GameObject.Instantiate(Resources.Load<GameObject>(consoleName));
            prefabInstance.name = "Console";

            consoleGo = prefabInstance;

            return consoleGo != null;
        }
    }
}