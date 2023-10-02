using System.IO;

namespace ConfFileSpace
{
    public class ConfFile
    {
        public string Path { get; set; }
        public string MDLP { get; set; }
        public string ESD { get; set; }
        public string AdmTemp { get; set; }
        public string TJ { get; set; }
        public string SwapC { get; set; }
        public string SwapD { get; set; }
        public string FirstIP { get; set; }
        public string SecondIP { get; set; }

        string[] defaultConfig = new string[]
        {
            "D:\\SQL_DATA\\userData\\MDLP.mdf",
            "C:\\ESD",
            "C:\\Users\\adm\\AppData\\Local\\Temp",
            "C:\\Temp\\TJ",
            "C:\\pagefile.sys",
            "D:\\pagefile.sys",
            "192.168.133.2",
            "192.168.133.10"
        };

        string[] Config;

        public ConfFile() { Path = "PerfInfo.conf"; Load(); }

        public ConfFile(string path) { Path = path; Load(); }

        void Load() { ConfFileExists(); ReadConfFile(Path, Config); }

        void ConfFileExists() { if (!File.Exists(Path)) { File.AppendAllLines(Path, defaultConfig); } }

        void ReadConfFile(string path, string[] config)
        {
            Config = File.ReadAllLines(path);
            MDLP = Config[0];
            ESD = Config[1];
            AdmTemp = Config[2];
            TJ = Config[3];
            SwapC = Config[4];
            SwapD = Config[5];
            FirstIP = Config[6];
            SecondIP = Config[7];
        }
    }
}