using System.IO;

namespace CourseWork
{
    internal class SettingsModule
    {
        /// <summary>
        /// Загружаем данные
        /// </summary>
        /// <returns>Возвращает null - если файла не существует, иначе строку с настройками</returns>
        public string LoadSettings()
        {
            string fileName = "settings.ini";

            if (!File.Exists(fileName))
                return null;

            return File.ReadAllText(fileName);
        }

        /// <summary>
        /// Сохраняет настройки
        /// </summary>
        /// <param name="settings">Строка с настройками</param>
        public void SaveSettings(string settings)
        {
            string fileName = "settings.ini";

            File.WriteAllText(fileName, settings);
        }
    }
}
