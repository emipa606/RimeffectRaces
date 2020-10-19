using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using HarmonyLib;

namespace RimeffectRaces
{
    [StaticConstructorOnStartup]
    public static class HarmonyPatches
    {

        private static readonly Type patchType = typeof(HarmonyPatches);

        static HarmonyPatches()
        {

            Harmony RimeffectRacesHarmony = new Harmony("com.RER.rimworld.mod");

            if (LoadedModManager.RunningModsListForReading.Any(x => x.Name == "Save Our Ship 2"))
            {
                SaveOurShip2_CompatibilityHook(RimeffectRacesHarmony);
            }

            RimeffectRacesHarmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        public static void SaveOurShip2_CompatibilityHook(Harmony harmony)
        {
            harmony.Patch(AccessTools.Method(typeof(SaveOurShip2.ShipInteriorMod2), "hasSpaceSuit"), null, new HarmonyMethod(typeof(HarmonyPatches), "SOS2CompatibilityHook_hasSpaceSuit_Postfix"));
        }
        public static void SOS2CompatibilityHook_hasSpaceSuit_Postfix(Pawn thePawn, ref bool __result)
        {
            if (thePawn != null && __result == false)
            {
                if (thePawn.def.HasModExtension<DefModExt_HasSpacesuit>())
                {
                    __result = true;
                }
                else if (thePawn.apparel != null)
                {
                    bool raceSpaceCapable = false;
                    if (thePawn.def.HasModExtension<DefModExt_HasSpacesuit>())
                    {
                        raceSpaceCapable = true;
                    }

                    __result = raceSpaceCapable;
                }
            }
        }
    }

}
