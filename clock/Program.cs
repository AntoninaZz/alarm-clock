using System;
using System.Windows.Forms;
using System.IO; //пространство имен для файлов

namespace clock
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Hello.FilePath = Directory.GetCurrentDirectory(); // Получает текущий рабочий каталог приложения c помощью API
            FileStream fileStream = File.Open(Hello.FilePath, FileMode.OpenOrCreate); // открывает файл или создает, если такого нет
            fileStream.Close();

            // добавление в файл записи о запуске программы
            using (StreamWriter file = new StreamWriter(Hello.FilePath, true))
            {
                file.WriteLine("________________________________________________");
                file.WriteLine(DateTime.Now.ToLongTimeString() + ".........................Start");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hello());
        }
    }
}
