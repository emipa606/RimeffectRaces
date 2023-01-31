using System;
using System.Reflection;
using HarmonyLib;
using SaveOurShip2;
using Verse;

namespace RimeffectRaces;

[StaticConstructorOnStartup]
public static class HarmonyPatches
{
    private static readonly Type patchType = typeof(HarmonyPatches);

    static HarmonyPatches()
    {
        var RimeffectRacesHarmony = new Harmony("com.RER.rimworld.mod");

        if (LoadedModManager.RunningModsListForReading.Any(x => x.Name == "Save Our Ship 2"))
        {
            SaveOurShip2_CompatibilityHook(RimeffectRacesHarmony);
        }

        RimeffectRacesHarmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    public static void SaveOurShip2_CompatibilityHook(Harmony harmony)
    {
        harmony.Patch(AccessTools.Method(typeof(ShipInteriorMod2), "HasSpaceSuitSlow"), null,
            new HarmonyMethod(typeof(HarmonyPatches), "SOS2CompatibilityHook_HasSpaceSuit_Postfix"));
    }

    public static void SOS2CompatibilityHook_HasSpaceSuit_Postfix(Pawn pawn, ref bool __result)
    {
        if (pawn == null || __result)
        {
            return;
        }

        if (pawn.def.HasModExtension<DefModExt_SpaceCapable>())
        {
            __result = true;
            return;
        }

        if (pawn.apparel != null)
        {
            __result = pawn.def.HasModExtension<DefModExt_SpaceCapable>();
        }
    }
}