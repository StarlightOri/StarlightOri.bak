using HarmonyLib;
using System.IO;

namespace StarlightOri.Patch.Function.DataDirectory
{
    [HarmonyPatch(typeof(SaveGameController), "GetSaveFilePath")]
    public class SaveDirectory
    {
        [HarmonyPatch]
        public static bool Prefix()
        {
            return false;
        }
        [HarmonyPatch]
        public static void Postfix(int slotIndex, int backupIndex, ref string __result)
        {
            if (backupIndex == -1)
            {
                __result = Path.Combine(Globals.SavesDirectory, "saveFile" + slotIndex + ".sav");
            }
            else
            {
                __result = Path.Combine(Globals.BackupSavesDirectory, string.Format("saveFile{0}_backup{1}.sav", slotIndex, backupIndex));
            }
        }
    }
}
