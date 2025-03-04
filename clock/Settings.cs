using System;
using System.Windows.Forms;
using System.IO; //пространство имен для файлов

namespace clock
{
    public partial class Settings : Form
    {
        //змінні
        private static int alarmH10, alarmH01 = 7, alarmM10, alarmM01, hours, minutes;

        //свойства
        public static int AlarmH10 { get { return alarmH10; } set { alarmH10 = value / 10; } }
        public static int AlarmH01 { get { return alarmH01; } set { alarmH01 = value % 10; } }
        public static int AlarmM10 { get { return alarmM10; } set { alarmM10 = value / 10; } }
        public static int AlarmM01 { get { return alarmM01; } set { alarmM01 = value % 10; } }

        public Settings()
        {
            InitializeComponent();
        }

        //если закрыли форму, то закрыли всю прогу
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bye.End();
        }

        //проверка корректности и сохранение установленного времени
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (hours < 24 && hours >= 0)
            {
                if (minutes < 60 && minutes >= 0)
                {
                    AlarmH10 = hours;
                    AlarmH01 = hours;
                    AlarmM10 = minutes;
                    AlarmM01 = minutes;

                    // запись в файл об установке будильника
                    using (StreamWriter file = new StreamWriter(Hello.FilePath, true))
                    {
                        file.WriteLine(DateTime.Now.ToLongTimeString() + ".........................SetAlarm(" + AlarmH10 + AlarmH01 + ":" + AlarmM10 + AlarmM01 + ")");
                    }

                    // переоткрываем файл журнала в окне блокнота (типо обновление отображаемых данных)
                    if (!Hello.process.HasExited) { Hello.process.Kill(); }
                    Hello.process.Start();

                    clock.AlarmRang = false;
                    clock newForm = new clock();
                    newForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect time! \nOops.. Try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect time! \nOops.. Try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //значение часов - только числа, Enter прыгает в след. текстбокс
        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtMinutes.Focus();
                }
                return;
            }
            MessageBox.Show("Illegal symbol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Handled = true;
        }

        //принимаем введенное число часов
        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            int iTemp;
            if (Int32.TryParse(txtHours.Text, out iTemp))
                hours = Convert.ToInt32(txtHours.Text);
            else
                txtHours.Text = Convert.ToString(hours);
        }

        //принимаем введенное число минут
        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            int iTemp;
            if (Int32.TryParse(txtMinutes.Text, out iTemp))
                minutes = Convert.ToInt32(txtMinutes.Text);
            else
                txtMinutes.Text = Convert.ToString(minutes);
        }

        //значение минут - только числа, Enter прыгает в след. текстбокс
        private void txtMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txtHours.Focus();
                }
                return;
            }
            MessageBox.Show("Illegal symbol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Handled = true;
        }
    }
}
