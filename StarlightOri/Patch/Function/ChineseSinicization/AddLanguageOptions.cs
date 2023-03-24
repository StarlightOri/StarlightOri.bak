using HarmonyLib;

namespace StarlightOri.Patch.Function.ChineseSinicization
{
    [HarmonyPatch(typeof(LanguageOptions), "OnEnable")]
    public class AddLanguageOptions
    {
        [HarmonyPatch]
        public static bool Prefix()
        {
            return false;
        }
        [HarmonyPatch]
        public static void Postfix(LanguageOptions __instance)
        {
            __instance.ClearItems();
            __instance.AddItem(Language.Chinese, Language.Chinese.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.Chinese);
            });
            __instance.AddItem(Language.English, Language.English.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.English);
            });
            __instance.AddItem(Language.French, Language.French.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.French);
            });
            __instance.AddItem(Language.Italian, Language.Italian.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.Italian);
            });
            __instance.AddItem(Language.German, Language.German.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.German);
            });
            __instance.AddItem(Language.Spanish, Language.Spanish.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.Spanish);
            });
            __instance.AddItem(Language.Japanese, Language.Japanese.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.Japanese);
            });
            __instance.AddItem(Language.Portuguese, Language.Portuguese.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.Portuguese);
            });
            __instance.AddItem(Language.Russian, Language.Russian.ToString(), delegate ()
            {
                __instance.SetLanguage(Language.Russian);
            });
            __instance.SetSelection(0);
        }
    }
}
