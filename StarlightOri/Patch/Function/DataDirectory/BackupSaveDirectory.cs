using HarmonyLib;
using System.IO;

namespace StarlightOri.Patch.Function.DataDirectory
{
    [HarmonyPatch(typeof(SaveSlotBackupsManager), "BackupName")]
    public class BackupSaveDirectory
    {
        [HarmonyPatch]
        public static bool Prefix()
        {
            return false;
        }
        [HarmonyPatch]
        public static void Postfix(int slot, int index, ref string __result)
        {
            __result = Path.Combine(Globals.BackupSavesDirectory, string.Format("saveFile{0}backup{1}.sav", slot, index));
        }
    }
}
