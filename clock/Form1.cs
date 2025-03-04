using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;//пространство имен для API
using System.IO; //пространство имен для файлов

namespace clock
{
    public partial class clock : Form
    {
        //змінні
        bool blink; //для мигания разделителя
        private int timeH10, timeH01, timeM10, timeM01; //для хранения текущего времени

        //свойства
        public int TimeH10 { get { return timeH10; } set { timeH10 = value / 10; } }
        public int TimeH01 { get { return timeH01; } set { timeH01 = value % 10; } }
        public int TimeM10 { get { return timeM10; } set { timeM10 = value / 10; } }
        public int TimeM01 { get { return timeM01; } set { timeM01 = value % 10; } }
        public static bool AlarmRang { get; set; }

        //Добавление атрибутов для API
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"OGG.wav");

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Keys vKeys);

        //если нажата клавиша
        private void clock_KeyPress(object sender, KeyPressEventArgs e)
        {
            var ctrl = GetAsyncKeyState(Keys.ControlKey) & 0x8000;
            var key = GetAsyncKeyState(Keys.G) & 0x8000;
            if (ctrl != 0 && key != 0)
            {
                Bye newForm = new Bye();
                newForm.Show();
                this.Hide();
                //API-функции остановки звука
                player.Stop();
            }
            else
            {
                MessageBox.Show("Oops.. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        //метод вывода текущего времени на экран в виде псевдографики
        private void GetTime()
        {
            //получение времени
            TimeH10 = DateTime.Now.Hour;
            TimeH01 = DateTime.Now.Hour;
            TimeM10 = DateTime.Now.Minute;
            TimeM01 = DateTime.Now.Minute;

            //распознавание цифр и вывод псевдографики
            switch (TimeH10)
            {
                case 0:
                    lblHour10.Text = "";
                    break;
                case 1:
                    lblHour10.Text = "     ▓▓  \n   ▓▓▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n   ▓▓▓▓▓▓";
                    break;
                case 2:
                    lblHour10.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n▓▓     ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n    ▓▓   \n   ▓▓    \n  ▓▓     \n ▓▓      \n▓▓       \n▓▓▓▓▓▓▓▓▓";
                    break;
            }
            switch (TimeH01)
            {
                case 0:
                    lblHour01.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
                case 1:
                    lblHour01.Text = "     ▓▓  \n   ▓▓▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n   ▓▓▓▓▓▓";
                    break;
                case 2:
                    lblHour01.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n▓▓     ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n    ▓▓   \n   ▓▓    \n  ▓▓     \n ▓▓      \n▓▓       \n▓▓▓▓▓▓▓▓▓";
                    break;
                case 3:
                    lblHour01.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n      ▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
                case 4:
                    lblHour01.Text = "       ▓▓\n      ▓▓▓\n     ▓▓▓▓\n    ▓▓ ▓▓\n   ▓▓  ▓▓\n  ▓▓   ▓▓\n ▓▓    ▓▓\n▓▓     ▓▓\n▓▓▓▓▓▓▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓";
                    break;
                case 5:
                    lblHour01.Text = "▓▓▓▓▓▓▓▓▓\n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓▓▓▓▓▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓▓▓▓▓▓▓";
                    break;
                case 6:
                    lblHour01.Text = "▓▓▓▓▓▓▓▓▓\n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓▓▓▓▓▓▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓▓▓▓▓▓▓";
                    break;
                case 7:
                    lblHour01.Text = "▓▓▓▓▓▓▓▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n    ▓▓   \n   ▓▓    \n  ▓▓     \n ▓▓      \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       ";
                    break;
                case 8:
                    lblHour01.Text = " ▓▓▓▓▓▓▓ \n▓▓▓   ▓▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓   ▓▓▓\n ▓▓▓▓▓▓▓ \n▓▓▓   ▓▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓   ▓▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
                case 9:
                    lblHour01.Text = " ▓▓▓▓▓▓▓ \n▓▓▓   ▓▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓    ▓▓\n ▓▓▓▓▓▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n▓▓     ▓▓\n▓▓▓   ▓▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
            }
            switch (TimeM10)
            {
                case 0:
                    lblMinute10.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
                case 1:
                    lblMinute10.Text = "     ▓▓  \n   ▓▓▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n   ▓▓▓▓▓▓";
                    break;
                case 2:
                    lblMinute10.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n▓▓     ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n    ▓▓   \n   ▓▓    \n  ▓▓     \n ▓▓      \n▓▓       \n▓▓▓▓▓▓▓▓▓";
                    break;
                case 3:
                    lblMinute10.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n      ▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
                case 4:
                    lblMinute10.Text = "       ▓▓\n      ▓▓▓\n     ▓▓▓▓\n    ▓▓ ▓▓\n   ▓▓  ▓▓\n  ▓▓   ▓▓\n ▓▓    ▓▓\n▓▓     ▓▓\n▓▓▓▓▓▓▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓";
                    break;
                case 5:
                    lblMinute10.Text = "▓▓▓▓▓▓▓▓▓\n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓▓▓▓▓▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓▓▓▓▓▓▓";
                    break;
            }
            switch (TimeM01)
            {
                case 0:
                    lblMinute01.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
                case 1:
                    lblMinute01.Text = "     ▓▓  \n   ▓▓▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n     ▓▓  \n   ▓▓▓▓▓▓";
                    break;
                case 2:
                    lblMinute01.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n▓▓     ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n    ▓▓   \n   ▓▓    \n  ▓▓     \n ▓▓      \n▓▓       \n▓▓▓▓▓▓▓▓▓";
                    break;
                case 3:
                    lblMinute01.Text = " ▓▓▓▓▓▓▓ \n▓▓     ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n      ▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
                case 4:
                    lblMinute01.Text = "       ▓▓\n      ▓▓▓\n     ▓▓▓▓\n    ▓▓ ▓▓\n   ▓▓  ▓▓\n  ▓▓   ▓▓\n ▓▓    ▓▓\n▓▓     ▓▓\n▓▓▓▓▓▓▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓";
                    break;
                case 5:
                    lblMinute01.Text = "▓▓▓▓▓▓▓▓▓\n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓▓▓▓▓▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓▓▓▓▓▓▓";
                    break;
                case 6:
                    lblMinute01.Text = "▓▓▓▓▓▓▓▓▓\n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓▓▓▓▓▓▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓▓▓▓▓▓▓";
                    break;
                case 7:
                    lblMinute01.Text = "▓▓▓▓▓▓▓▓▓\n       ▓▓\n      ▓▓ \n     ▓▓  \n    ▓▓   \n   ▓▓    \n  ▓▓     \n ▓▓      \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       \n▓▓       ";
                    break;
                case 8:
                    lblMinute01.Text = " ▓▓▓▓▓▓▓ \n▓▓▓   ▓▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓   ▓▓▓\n ▓▓▓▓▓▓▓ \n▓▓▓   ▓▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓   ▓▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
                case 9:
                    lblMinute01.Text = " ▓▓▓▓▓▓▓ \n▓▓▓   ▓▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓     ▓▓\n▓▓▓    ▓▓\n ▓▓▓▓▓▓▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n       ▓▓\n▓▓     ▓▓\n▓▓▓   ▓▓▓\n ▓▓▓▓▓▓▓ ";
                    break;
            }

            //распознавание цифр будильника и ввывод псевдографики
            switch (Settings.AlarmH10)
            {
                case 0:
                    lblAlarmH10.Text = " ";
                    break;
                case 1:
                    lblAlarmH10.Text = "   ▓▓  \n ▓▓▓▓  \n   ▓▓  \n   ▓▓  \n   ▓▓  \n   ▓▓  \n ▓▓▓▓▓▓";
                    break;
                case 2:
                    lblAlarmH10.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n     ▓▓\n    ▓▓ \n   ▓▓  \n ▓▓▓   \n▓▓▓▓▓▓▓";
                    break;
            }
            switch (Settings.AlarmH01)
            {
                case 0:
                    lblAlarmH01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 1:
                    lblAlarmH01.Text = "   ▓▓  \n ▓▓▓▓  \n   ▓▓  \n   ▓▓  \n   ▓▓  \n   ▓▓  \n ▓▓▓▓▓▓";
                    break;
                case 2:
                    lblAlarmH01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n     ▓▓\n    ▓▓ \n   ▓▓  \n ▓▓▓   \n▓▓▓▓▓▓▓";
                    break;
                case 3:
                    lblAlarmH01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n     ▓▓\n    ▓▓ \n     ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 4:
                    lblAlarmH01.Text = "▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓▓▓▓▓▓\n     ▓▓\n     ▓▓\n     ▓▓";
                    break;
                case 5:
                    lblAlarmH01.Text = "▓▓▓▓▓▓▓\n▓▓     \n▓▓     \n▓▓▓▓▓▓ \n     ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 6:
                    lblAlarmH01.Text = " ▓▓▓▓▓▓\n▓▓     \n▓▓     \n▓▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 7:
                    lblAlarmH01.Text = "▓▓▓▓▓▓▓\n     ▓▓\n    ▓▓ \n   ▓▓  \n  ▓▓   \n ▓▓    \n▓▓     ";
                    break;
                case 8:
                    lblAlarmH01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 9:
                    lblAlarmH01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓▓\n     ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
            }
            switch (Settings.AlarmM10)
            {
                case 0:
                    lblAlarmM10.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 1:
                    lblAlarmM10.Text = "   ▓▓  \n ▓▓▓▓  \n   ▓▓  \n   ▓▓  \n   ▓▓  \n   ▓▓  \n ▓▓▓▓▓▓";
                    break;
                case 2:
                    lblAlarmM10.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n     ▓▓\n    ▓▓ \n   ▓▓  \n ▓▓▓   \n▓▓▓▓▓▓▓";
                    break;
                case 3:
                    lblAlarmM10.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n     ▓▓\n    ▓▓ \n     ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 4:
                    lblAlarmM10.Text = "▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓▓▓▓▓▓\n     ▓▓\n     ▓▓\n     ▓▓";
                    break;
                case 5:
                    lblAlarmM10.Text = "▓▓▓▓▓▓▓\n▓▓     \n▓▓     \n▓▓▓▓▓▓ \n     ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
            }
            switch (Settings.AlarmM01)
            {
                case 0:
                    lblAlarmM01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 1:
                    lblAlarmM01.Text = "   ▓▓  \n ▓▓▓▓  \n   ▓▓  \n   ▓▓  \n   ▓▓  \n   ▓▓  \n ▓▓▓▓▓▓";
                    break;
                case 2:
                    lblAlarmM01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n     ▓▓\n    ▓▓ \n   ▓▓  \n ▓▓▓   \n▓▓▓▓▓▓▓";
                    break;
                case 3:
                    lblAlarmM01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n     ▓▓\n    ▓▓ \n     ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 4:
                    lblAlarmM01.Text = "▓▓   ▓▓\n▓▓   ▓▓\n▓▓   ▓▓\n▓▓▓▓▓▓▓\n     ▓▓\n     ▓▓\n     ▓▓";
                    break;
                case 5:
                    lblAlarmM01.Text = "▓▓▓▓▓▓▓\n▓▓     \n▓▓     \n▓▓▓▓▓▓ \n     ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 6:
                    lblAlarmM01.Text = " ▓▓▓▓▓▓\n▓▓     \n▓▓     \n▓▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 7:
                    lblAlarmM01.Text = "▓▓▓▓▓▓▓\n     ▓▓\n    ▓▓ \n   ▓▓  \n  ▓▓   \n ▓▓    \n▓▓     ";
                    break;
                case 8:
                    lblAlarmM01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
                case 9:
                    lblAlarmM01.Text = " ▓▓▓▓▓ \n▓▓   ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓▓\n     ▓▓\n▓▓   ▓▓\n ▓▓▓▓▓ ";
                    break;
            }
        }

        //обработчик события тик таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetTime(); //вызов метода вывода текущего времени

            //обработка мигания разделителя
            if (blink == false)
            {
                lblSep.Text = " \n \n \n \n■\n \n \n \n \n■\n \n \n \n ";
                blink = true;
            }
            else
            {
                lblSep.Text = " ";
                blink = false;
            }

            //блок срабатывания будильника
            if ((Settings.AlarmH10 == TimeH10) && (Settings.AlarmH01 == TimeH01) && (Settings.AlarmM10 == TimeM10) && (Settings.AlarmM01 == TimeM01))
            {
                this.ForeColor = Color.Red;

                if (!AlarmRang)
                {
                    AlarmRang = true;

                    // запись в файл о срабатывании будильника
                    using (StreamWriter file = new StreamWriter(Hello.FilePath, true))
                    {
                        file.WriteLine(DateTime.Now.ToLongTimeString() + ".........................AlarmRing");
                    }

                    // переоткрываем файл журнала в окне блокнота (типо обновление отображаемых данных)
                    if (!Hello.process.HasExited) { Hello.process.Kill(); }
                    Hello.process.Start();

                    //API-функции возпроизведения звука
                    player.Play();
                }
            }
            else
            {
                this.ForeColor = Color.Lime;
                AlarmRang = false;
                //API-функции остановки звука
                player.Stop();
            }
        }

        public clock()
        {
            InitializeComponent();

            timer1.Enabled = true; //запуск таймера вместе с запуском формы
            timer1.Interval = 1000; //1000 мс = 1 с - интервал срабатывания
            GetTime(); //отображает на экране время загрузки
        }

        //обработка выхода через меню
        private void exitCtrlgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bye newForm = new Bye();
            newForm.Show();
            this.Hide();
            //API-функции остонавки звука
            player.Stop();
        }

        //переход в установочный режим
        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // запись в файл о переходе в установочный режим
            using (StreamWriter file = new StreamWriter(Hello.FilePath, true))
            {
                file.WriteLine(DateTime.Now.ToLongTimeString() + ".........................GotoSetMode");
            }

            // переоткрываем файл журнала в окне блокнота (типо обновление отображаемых данных)
            if (!Hello.process.HasExited) { Hello.process.Kill(); }
            Hello.process.Start();

            Settings newForm = new Settings();
            newForm.Show();
            this.Hide();
            //API-функции остановки звука
            player.Stop();
        }

        //если закрыли форму, то закрыли всю прогу
        private void clock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Bye.End();
        }
    }
}
