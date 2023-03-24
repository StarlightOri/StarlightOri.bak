using BepInEx.Logging;

namespace StarlightOri
{
    internal class Globals
    {
        public static ManualLogSource Logger { get; } = BepInEx.Logging.Logger.CreateLogSource("StarlightOri");
        public static string BepInExDirectory { get; } = System.Environment.CurrentDirectory + @"\BepInEx";
        public static string DataDirectory { get; } = System.Environment.CurrentDirectory + @"\Data";
        public static string SavesDirectory { get; } = DataDirectory + @"\saves";
        public static string BackupSavesDirectory { get; } = SavesDirectory + @"\backup";
        public static string CurrentModDirectory { get; } = BepInExDirectory + @"\plugins\StarlightOri";
        public static string LanguageData;
    }
}
