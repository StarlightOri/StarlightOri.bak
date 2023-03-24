using Game;
using HarmonyLib;
using System.Reflection;

namespace StarlightOri.Patch.Function.ChineseSinicization
{
    [HarmonyPatch(typeof(GameSettings), "Language", MethodType.Setter)]
    public class GameSettingsLanguageChinese
    {
        [HarmonyPatch]
        public static bool Prefix()
        {
            return false;
        }
        [HarmonyPatch]
        public static void Postfix(GameSettings __instance, ref Language value)
        {
            __instance.GetType().GetField("m_language", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(__instance, value);
            Events.Scheduler.OnGameLanguageChange.Call();
        }
    }
}
