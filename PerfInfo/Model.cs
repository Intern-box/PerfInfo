using System;
using System.IO;
using System.Management;

namespace ModelSpace
{
    public class Model
    {
        public string CPUT { get; }

        public long Swap { get; }

        public string SwapPath { get; set; }

        public string CPU { get; }

        public string RAM { get; }

        public string Video { get; }

        public long MDLP { get; }

        public Model()
        {
            CPUT = CPUTemperature();

            Swap = SwapSize();

            CPU = CPUModel();

            RAM = RAMModel();

            Video = VideoModel();

            MDLP = MDLPSize();
        }

        public string CPUTemperature()
        {
            double CPUtprt;

            string tmp = string.Empty;

            ManagementObjectSearcher mos = new ManagementObjectSearcher(@"root\WMI", "Select * From MSAcpi_ThermalZoneTemperature");

            foreach (ManagementObject mo in mos.Get())
            {
                CPUtprt = Convert.ToDouble(Convert.ToDouble(mo.GetPropertyValue("CurrentTemperature").ToString()) - 2732) / 10;

                tmp += CPUtprt.ToString() + " °C";
            }

            return tmp;
        }

        public long SwapSize()
        {
            if (File.Exists("C:\\pagefile.sys"))
            {
                SwapPath = "C:\\pagefile.sys";

                return new FileInfo("C:\\pagefile.sys").Length / 1048576;
            }
            if (File.Exists("D:\\pagefile.sys"))
            {
                SwapPath = "D:\\pagefile.sys";

                return new FileInfo("C:\\pagefile.sys").Length / 1048576;
            }

            return 0;
        }

        public string CPUModel()
        {
            string tmp = string.Empty;

            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj1 in searcher1.Get())
                tmp = queryObj1["Name"].ToString();

            return tmp;
        }

        public string RAMModel()
        {
            string tmp = string.Empty;

            ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

            foreach (ManagementObject queryObj3 in searcher3.Get())
            {
                if ((UInt32)queryObj3["SMBIOSMemoryType"] == 26)
                {
                    tmp += "DDR4 " + (ulong)queryObj3["Capacity"] / 1073741824 + "GB " + queryObj3["Speed"] + "MHz" + "\r\n";
                }
                else if ((UInt32)queryObj3["SMBIOSMemoryType"] == 24)
                {
                    tmp += "DDR3 " + (ulong)queryObj3["Capacity"] / 1073741824 + "GB " + queryObj3["Speed"] + "MHz" + "\r\n";
                }
            }

            return tmp;
        }

        public string VideoModel()
        {
            string tmp = string.Empty;
        
            ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

                foreach (ManagementObject queryObj4 in searcher4.Get())
                    tmp = queryObj4["Description"].ToString();

            return tmp;
        }

        public long MDLPSize()
        {
            if (File.Exists("E:\\SQL_DATA\\userData\\MDLP.mdf"))
            {
                return new FileInfo("E:\\SQL_DATA\\userData\\MDLP.mdf").Length / 1048576;
            }

            return 0;
        }
    }
}