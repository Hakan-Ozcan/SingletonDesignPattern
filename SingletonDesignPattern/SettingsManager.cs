using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SettingsManager
    {
        // Static variable to hold the Singleton instance
        private static SettingsManager instance;

        // Static property to access the Singleton instance
        public static SettingsManager Instance
        {
            get
            {
                // If the instance doesn't exist, create one
                if (instance == null)
                {
                    instance = new SettingsManager();
                }
                return instance;
            }
        }

        // Settings will be stored here
        public string Language { get; set; }
        public int SoundLevel { get; set; }

        // Private constructor to prevent external instantiation
        private SettingsManager()
        {
            // Perform any initialization here when the instance is created
            Language = "English";
            SoundLevel = 50;
        }

        public void ShowSettings()
        {
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine($"Sound Level: {SoundLevel}");
        }
    }
}
