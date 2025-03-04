using System;
using System.Windows.Forms;
using System.IO; //пространство имен для файлов

namespace clock
{
    public partial class Bye : Form
    {
        public static bool firstEnd = true; //если эта форма закрыта первой
        public Bye()
        {
            InitializeComponent();
        }

        public static void End()
        {
            if (firstEnd)
            {
                firstEnd = false;
                // запись в файл о закрытии программы
                using (StreamWriter file = new StreamWriter(Hello.FilePath, true))
                {
                    file.WriteLine(DateTime.Now.ToLongTimeString() + ".........................End");
                }

                // переоткрываем файл журнала в окне блокнота (типо обновление отображаемых данных)
                if (!Hello.process.HasExited) { Hello.process.Kill(); }
                Hello.process.Start();

                Hello.process.Close(); //высвобождение ресурсов
                Application.Exit();
            }
        }

        //закрытие программы
        private void btnOK_Click(object sender, EventArgs e)
        {
            End();
        }

        //если закрыли форму, то закрыли всю прогу
        private void Bye_FormClosed(object sender, FormClosedEventArgs e)
        {
            End();
        }
    }
}
