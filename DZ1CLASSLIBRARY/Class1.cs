using System;

namespace DZ1CLASSLIBRARY
{
    public class Weather
    {
        private double temperature;
        private double windSpeed;
        private double humidity;
        private static readonly double c1 = -8.78469475556;
        private static readonly double c2 = 1.61139411;
        private static readonly double c3 = 2.33854883889;
        private static readonly double c4 = -0.14611605;
        private static readonly double c5 = -0.012308094;
        private static readonly double c6 = -0.0164248277778;
        private static readonly double c7 = 0.002211732;
        private static readonly double c8 = 0.00072546;
        private static readonly double c9 = -0.000003582;
        public Weather()
        {
        }
        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.windSpeed = windSpeed;
            this.humidity = humidity;
        }

        public void SetTemperature(double temperature)
        {
            this.temperature = temperature;
        }

        public double GetTemperature()
        {
            return temperature;
        }

        public void SetWindSpeed(double windSpeed)
        {
            this.windSpeed = windSpeed;
        }

        public double GetWindSpeed()
        {
            return windSpeed;
        }

        public void SetHumidity(double humidity)
        {
            this.humidity = humidity;
        }

        public double GetHumidity()
        {
            return humidity;
        }
        public double CalculateWindChill()
        {
            if (temperature > 10 || windSpeed <= 4.8)
                return 0;
            else
                return (13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16));

        }
        public double CalculateFeelsLikeTemperature()
        {
            return (c1 + c2 * temperature + c3 * humidity + c4 * temperature * humidity + c5 * temperature * temperature + c6 * humidity * humidity + c7 * temperature * temperature * humidity + c8 * temperature * humidity * humidity + c9 * temperature * temperature * humidity * humidity);
        }
    }

}
