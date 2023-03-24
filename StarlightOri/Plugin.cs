using BepInEx;
using BepInEx.Logging;
using StarlightOri.Utils;

namespace StarlightOri
{
    [BepInPlugin("SarpIce.StarlightOri", "StarlightOri", "1.0.0.0")]
    [BepInProcess("oriDE.exe")]
    internal class Plugin : BaseUnityPlugin
    {
        private readonly new ManualLogSource Logger = Globals.Logger;
#pragma warning disable IDE0051 // 删除未使用的私有成员
        private void Awake()
#pragma warning restore IDE0051 // 删除未使用的私有成员
        {
            Logger.LogInfo("Loading...");
            Init(); // 初始化
            i18n.Init(); // 初始化i18n
            HarmonyPatchs.Init(); // 初始化补丁
        }

        private void Init()
        {
            // 初始化Configurantion
            Configurantion.Language = Config.Bind("General", "Language", "zh_cn", "设置语言，注意，这并非是游戏语言。");
        }
    }
}