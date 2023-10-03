using System;
using System.Management;

namespace CPUTemperatureSpace
{
    public class CPUTemperature
    {
        string CurrentTemperature = string.Empty;

        public CPUTemperature() { Load(); }

        public string Load()
        {
            CurrentTemperature = CheckTemperature();

            if (CheckTemperature() != CurrentTemperature) { CurrentTemperature = CheckTemperature(); }

            return CurrentTemperature;
        }

        string CheckTemperature()
        {
            double temperature;

            string tmp = string.Empty;

            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher(@"root\WMI", "Select * From MSAcpi_ThermalZoneTemperature");

                foreach (ManagementObject mo in mos.Get())
                {
                    temperature = Convert.ToDouble(Convert.ToDouble(mo.GetPropertyValue("CurrentTemperature").ToString()) - 2732) / 10;

                    tmp += temperature.ToString() + " °C";
                }
            }
            catch (Exception) { }

            return tmp;
        }
    }
}