using ViewSpace;
using ModelSpace;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using CPUTemperatureSpace;

namespace PresenterSpace
{
    public class Presenter
    {
        ViewForm viewForm;

        Model model;

        public Presenter(ViewForm viewForm, Model model) { this.viewForm = viewForm; this.model = model; Load(); }

        public void Load()
        {
            viewForm.SwapText.Text = $"{model.SwapPath} {model.Swap.ToString()} МБ";

            viewForm.CPUModelText.Text = model.CPU;

            viewForm.RAMSizeText.Text = model.RAM;

            viewForm.VideodriverText.Text = model.Video;

            viewForm.MDLPSizeText.Text = model.MDLP.ToString() + " МБ";

            int countESD = 0; int countAdm = 0; int countTJ = 0;

            try { foreach (string file in Directory.EnumerateFiles(model.ESD, "*.*", SearchOption.AllDirectories)) { countESD++; } }

            catch (System.Exception)
            {
                MessageBox.Show("Путь к ESD неверный.", "Вторая строка файла настройки!");

                throw;
            }

            try { foreach (string file in Directory.EnumerateFiles(model.AdmTemp, "*.*", SearchOption.AllDirectories)) { countAdm++; } }

            catch (System.Exception)
            {
                MessageBox.Show("Путь к adm\\AppData\\Local\\Temp неверный.", "Третья строка файла настройки!");

                throw;
            }

            try { foreach (string file in Directory.EnumerateFiles(model.TJ, "*.*", SearchOption.AllDirectories)) { countTJ++; } }

            catch (System.Exception)
            {
                MessageBox.Show("Путь к TJ неверный.", "Четвёртая строка файла настройки!");

                throw;
            }

            viewForm.DirSizeText.Text =
                
                $"В {model.ESD} файлов {countESD}\r\n" +

                $"В {model.AdmTemp} файлов {countAdm}\r\n" +

                $"В {model.TJ} файлов {countTJ}";

            CPUTemperature cpuTemperature = new CPUTemperature();

            viewForm.CPUTempText.Text = cpuTemperature.Load();

            //while (true)
            //{
            //    System.Threading.Thread.Sleep(100000);

            //    viewForm.CPUTempText.Text = cpuTemperature.Load();
            //}
        }

        public void Ping()
        {
            try
            {
                viewForm.PingText.Text = $"Пингую {model.FirstIP}...\r\n";

                for (int i = 0; i < 4; i++) { viewForm.PingText.Text += new Ping().Send(model.FirstIP).Status.ToString() + "\r\n"; }

                viewForm.PingText.Text += $"\r\nПингую {model.SecondIP}...\r\n";

                for (int i = 0; i < 4; i++) { viewForm.PingText.Text += new Ping().Send(model.SecondIP).Status.ToString() + "\r\n"; }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Что то с IP-адресами.", "Седьмая и восьмая строки файла настройки!");

                throw;
            }
        }
    }
}