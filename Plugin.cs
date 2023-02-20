using BepInEx;
using HarmonyLib;
using System.Reflection;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MoonJump
{
    [BepInPlugin("com.archiverxp.nitwcheats", PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {"com.archiverxp.nitwcheats"} is loaded!");
            SceneManager.LoadScene("BusStation");
            var harmony = new Harmony("com.archiverxp.nitwcheats");
            Harmony.DEBUG = true;
            var assembly = Assembly.GetExecutingAssembly(); //copy and pasted from docs
            harmony.PatchAll(assembly);
        }
    }
}
