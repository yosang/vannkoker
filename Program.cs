using System;

namespace Program
{
    public class Vannkoker
    {
        private int roomTemp = 20;
        private int maxTemp = 100;
        public event EventHandler? TemperatureReached;

        public void StartBoiling()
        {
            for (int i = roomTemp; i < maxTemp; i++)
            {
                string? message = i switch
                {
                    30 or 50 or 70 or 100 => "Water is boiling, current temperature reached: " + i,
                    _ => null

                };

                if (message != null) Console.WriteLine(message);

            }

            BoilingComplete(EventArgs.Empty);
        }

        protected virtual void BoilingComplete(EventArgs e)
        {
            TemperatureReached?.Invoke(this, e);
        }
    }

    public class Smartphone
    {
        public void PushNotification(object? sender, EventArgs e)
        {
            Console.WriteLine("The water has finished boiling!");
        }
    }

    public class App
    {
        public static void Main()
        {
            Vannkoker norwegianKettle = new Vannkoker();
            Smartphone googlePixel = new Smartphone();

            norwegianKettle.TemperatureReached += googlePixel.PushNotification;

            norwegianKettle.StartBoiling();

        }
    }
}