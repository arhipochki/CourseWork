using System;
using System.IO;

namespace CourseWork
{
    internal class FilesModule
    {
        private string path = "tmp";
        /// <summary>
        /// Путь, где будут сохранены файлы
        /// </summary>
        public string Path { set { path = value; } }
        public FilesModule()
        {
            if (!Directory.Exists("tmp"))
                Directory.CreateDirectory("tmp");
        }
        /// <summary>
        /// Функция сохранения данных в TMP файл
        /// </summary>
        /// <param name="data">Данные для записи</param>
        public void SaveToTmp(string data)
        {
            string fileName = $"{path}/{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.tmp";

            StreamWriter file = new StreamWriter(fileName, append: true);
            file.WriteLine(data);
            file.Close();
        }
        /// <summary>
        /// Функция сохранения исходных данных в TXT файл
        /// </summary>
        /// <param name="data">Иходные данные для записи</param>
        public void SaveInitialData(string data)
        {
            string fileName = $"{path}/initialData-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.txt";

            StreamWriter file = new StreamWriter(fileName, append: true);
            file.WriteLine(data);
            file.Close();
        }
    }
}
