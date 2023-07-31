using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class SettingsManager
    {
        private SettingsManager()
        {
            // Özel kurucu metot, dışarıdan erişimi engellemek için private yapıldı
            Language = "English";
            SoundLevel = 50;
        }
        // Singleton örneğini tutacak statik değişken
        private static SettingsManager instance;

        // Örneğe erişmek için kullanılacak statik metot
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
        

        public void ShowSettings()
        {
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine($"Sound Level: {SoundLevel}");
        }
    }
}
