using BepInEx.Logging;
using HarmonyLib;
using StarlightOri.Patch.Function.DataDirectory;
using StarlightOri.Patch.Function.ChineseSinicization;

namespace StarlightOri
{
    internal class HarmonyPatchs
    {
        private static readonly ManualLogSource Logger = Globals.Logger;
        public static void Init()
        {
            Logger.LogInfo("Loading Harmony...");

            Harmony DataDirectoryPatch = new Harmony("StarlightOri.Function.DataDirectory");
            DataDirectoryPatch.PatchAll(typeof(DataDirectory));
            DataDirectoryPatch.PatchAll(typeof(BackupSaveDirectory));
            DataDirectoryPatch.PatchAll(typeof(SaveDirectory));

            Harmony ChineseSinicization = new Harmony("StarlightOri.Function.ChineseSinicization");
            ChineseSinicization.PatchAll(typeof(AddLanguageOptions));
            ChineseSinicization.PatchAll(typeof(GameSettingsLanguageChinese));
        }
    }
}
