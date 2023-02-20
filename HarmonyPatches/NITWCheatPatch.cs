using HarmonyLib;
using System.Reflection;

namespace NITWCheat.HarmonyPatches
{
    [HarmonyPatch]
    class Patch
    {
        static MethodBase TargetMethod()
        {
            return AccessTools.Method(typeof(Player), "Update");
        }
        static void Prefix(ref Player __instance)
        {
            __instance.jump = 30;
            __instance.runSpeedOverride = 80;
            __instance.deathWalkSpeed = 80;
            __instance.walkSpeed = 80;
            __instance.canJump = true;
        }
    }
}