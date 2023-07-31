using SingletonDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        // Getting an instance of the Singleton class
        SettingsManager settingsManager1 = SettingsManager.Instance;
        SettingsManager settingsManager2 = SettingsManager.Instance;

        // Both variables will reference the same instance, so there's only one instance
        Console.WriteLine("Are both variables referring to the same instance?");
        Console.WriteLine(settingsManager1 == settingsManager2); // true

        // Changes made on one instance will affect the other instance since they are the same
        settingsManager1.Language = "Turkish";
        settingsManager2.SoundLevel = 80;

        Console.WriteLine("settingsManager1:");
        settingsManager1.ShowSettings();

        Console.WriteLine("settingsManager2:");
        settingsManager2.ShowSettings();
    }
}