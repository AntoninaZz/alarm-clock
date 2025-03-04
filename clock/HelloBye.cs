using System;
using System.Windows.Forms;
using System.Diagnostics; //пространство имен для открытия файла в блокноте

namespace clock
{
    public partial class Hello : Form
    {
        private static string path = ""; //переменная для хранения пути к журналу
        public static Process process = new Process(); //переменная для журнала файла в блокноте

        //свойство для хранения пути к журналу
        public static string FilePath { get { return path; } set //преобразует полученный путь:
            {
                int i, n = value.Length;
                for( i = 0; i < value.Length; i++ )
                {
                    if (value[i] == '\\')
                    {
                        n = i;
                    }
                }                                                //делает выше на одну ступень файловой иерархии
                for (i = 0; i < n; i++)
                {
                    path += value[i];
                }
                path += @"\journal.txt"; }                       //и добавляет имя файла
            }

        public Hello()
        {
            InitializeComponent();

            lblLocation.Text = FilePath; // отображение пути на форме

            // открываем файл журнала в окне блокнота
            process.StartInfo = new ProcessStartInfo() { UseShellExecute = true, FileName = FilePath };
            process.Start();
        }

        //переход к след. форме
        private void btnOK_Click(object sender, EventArgs e)
        {
            clock newForm = new clock();
            newForm.Show();
            this.Hide();
        }

        //если закрыли форму, то закрыли всю прогу
        private void Hello_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bye.End();
        }
    }
}
