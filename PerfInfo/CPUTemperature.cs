using System;
using System.Management;

namespace CPUTemperatureSpace
{
    public class CPUTemperature
    {
        delegate string ChangeTemperature();

        event ChangeTemperature ChangeTemperatureHandler;

        public CPUTemperature() { Load(); }

        void Load()
        {
            string current = CheckTemperature();

            while (true)
            {
                if (CheckTemperature() != current)
                {
                    ChangeTemperatureHandler = CheckChange;

                    current = CheckTemperature();
                }
            }
        }

        string CheckChange() { return CheckTemperature(); }

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