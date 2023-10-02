using ViewSpace;
using ModelSpace;
using System.IO;
using System.Net.NetworkInformation;

namespace PresenterSpace
{
    public class Presenter
    {
        ViewForm viewForm;

        Model model;

        public Presenter(ViewForm viewForm, Model model) { this.viewForm = viewForm; this.model = model; Load(); }

        public void Load()
        {
            viewForm.CPUTempText.Text = model.CPUT;

            viewForm.SwapText.Text = $"{model.SwapPath} {model.Swap.ToString()} МБ";

            viewForm.CPUModelText.Text = model.CPU;

            viewForm.RAMSizeText.Text = model.RAM;

            viewForm.VideodriverText.Text = model.Video;

            viewForm.MDLPSizeText.Text = model.MDLP.ToString() + " МБ";

            int countESD = 0; int countAdm = 0; int countTJ = 0;

            foreach (string file in Directory.EnumerateFiles(model.ESD, "*.*", SearchOption.AllDirectories)) { countESD++; }

            foreach (string file in Directory.EnumerateFiles(model.AdmTemp, "*.*", SearchOption.AllDirectories)) { countAdm++; }

            foreach (string file in Directory.EnumerateFiles(model.TJ, "*.*", SearchOption.AllDirectories)) { countTJ++; }

            viewForm.DirSizeText.Text =
                
                $"В {model.ESD} файлов {countESD}\r\n" +

                $"В {model.AdmTemp} файлов {countAdm}\r\n" +

                $"В {model.TJ} файлов {countTJ}";
        }

        public void Ping()
        {
            viewForm.PingText.Text = $"Пингую {model.FirstIP}...\r\n";

            for (int i = 0; i < 4; i++) { viewForm.PingText.Text += new Ping().Send(model.FirstIP).Status.ToString() + "\r\n"; }

            viewForm.PingText.Text += $"\r\nПингую {model.SecondIP}...\r\n";

            for (int i = 0; i < 4; i++) { viewForm.PingText.Text += new Ping().Send(model.SecondIP).Status.ToString() + "\r\n"; }
        }
    }
}