using BepInEx.Logging;
using HarmonyLib;
using System;
using System.IO;

namespace StarlightOri.Patch.Function.DataDirectory
{
    [HarmonyPatch(typeof(OutputFolder), "get_PlayerDataFolderPath")]
    public class DataDirectory
    {
        private static readonly ManualLogSource Logger = Globals.Logger;
        [HarmonyPatch]
        public static bool Prefix()
        {
            return false;
        }
        [HarmonyPatch]
        public static void Postfix(ref string __result)
        {
            if (!Directory.Exists(Globals.BackupSavesDirectory))
            {
                Logger.LogWarning("The " + Globals.BackupSavesDirectory + " folder cannot be found and is being created.");
                try
                {
                    Directory.CreateDirectory(Globals.BackupSavesDirectory);
                }
                catch (Exception e)
                {
                    Logger.LogFatal("Error createing " + Globals.BackupSavesDirectory + " folder.");
                    Logger.LogFatal(e);
                }
            }
            __result = Globals.DataDirectory;
        }
    }
}