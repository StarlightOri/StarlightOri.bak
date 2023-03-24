using BepInEx.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace StarlightOri.Utils
{
    internal class i18n
    {
        private static readonly ManualLogSource Logger = Globals.Logger;
        public static void Init()
        {
            Logger.LogInfo("Loading i18n...");
            string FilePath = Globals.CurrentModDirectory + "/Assets/lang/" + Configurantion.Language.Value + ".json";
            if (File.Exists(FilePath))
            {
                try
                {
                    Globals.LanguageData = File.ReadAllText(FilePath);
                }
                catch (Exception e)
                {
                    Logger.LogFatal("Unable to read " + FilePath + " file.");
                    Logger.LogFatal(e);
                }
            }
            else
            {
                Logger.LogWarning("Cannont find " + FilePath + " language file, will switch default language.");
                try
                {
                    Globals.LanguageData = File.ReadAllText(Globals.CurrentModDirectory + "/Assets/lang/zh_cn.json");
                }
                catch (Exception e)
                {
                    Logger.LogFatal("Unable to read " + Globals.CurrentModDirectory + "/Assets/lang/zh_cn.json" + " file.");
                    Logger.LogFatal(e);
                }
            }
        }
        /// <summary>
        /// 获取语言
        /// </summary>
        /// <param name="LangID"></param>
        /// <returns></returns>
        public static string Get(string LangID)
        {
            return (string)JObject.Parse(Globals.LanguageData)[LangID];
        }
    }
}