using ViewSpace;
using ModelSpace;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System;

namespace PresenterSpace
{
    public class Presenter
    {
        ViewForm viewForm;

        Model model;

        public Presenter(ViewForm viewForm, Model model)
        {
            this.viewForm = viewForm;

            this.model = model;

            Load();
        }

        public void Load()
        {
            viewForm.CPUTempText.Text = model.CPUT;

            viewForm.SwapText.Text = $"{model.SwapPath} {model.Swap.ToString()} МБ";

            viewForm.CPUModelText.Text = model.CPU;

            viewForm.RAMSizeText.Text = model.RAM;

            viewForm.VideodriverText.Text = model.Video;

            viewForm.MDLPSizeText.Text = model.MDLP.ToString() + " МБ";

            int countESD = 0; int countAdm = 0; int countTJ = 0;

            foreach (string file in Directory.EnumerateFiles("C:\\ESD", "*.*", SearchOption.AllDirectories)) { countESD++; }

            foreach (string file in Directory.EnumerateFiles("C:\\Users\\adm\\AppData\\Local\\Temp", "*.*", SearchOption.AllDirectories)) { countAdm++; }

            foreach (string file in Directory.EnumerateFiles("C:\\Temp\\TJ", "*.*", SearchOption.AllDirectories)) { countTJ++; }

            viewForm.DirSizeText.Text =

                $"В C:\\ESD файлов {countESD}\r\nВ C:\\Users\\adm\\AppData\\Local\\Temp файлов {countAdm}\r\nВ C:\\Temp\\TJ файлов {countTJ}";
        }

        public void Ping()
        {
            viewForm.PingText.Text = "Пингую 192.168.133.2...\r\n";

            for (int i = 0; i < 4; i++)
            {
                viewForm.PingText.Text += new Ping().Send("192.168.133.2").Status.ToString() + "\r\n";
            }

            viewForm.PingText.Text += "\r\nПингую 172.31.254.198...\r\n";

            for (int i = 0; i < 4; i++)
            {
                viewForm.PingText.Text += new Ping().Send("172.31.254.198").Status.ToString() + "\r\n";
            }
        }
    }
}