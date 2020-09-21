using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;
using RimWorld;
using Verse;

namespace RimeffectRaces
{
    [StaticConstructorOnStartup]
    public static class FactionControl
    {
        static FactionControl()
        {
            RimeffectRacesSettings settings = RimeffectRacesMod.mod.settings;

            if (!settings.AsariFaction)
            {
                RimeffectRacesDefOf.AsariFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.AsariFaction.maxCountAtGameStart = 0;
            }

            if (!settings.BatarianFaction)
            {
                RimeffectRacesDefOf.BatarianFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.BatarianFaction.maxCountAtGameStart = 0;
            }

            if (!settings.EnkindlerFaction)
            {
                RimeffectRacesDefOf.EnkindlerFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.EnkindlerFaction.maxCountAtGameStart = 0;
            }

            if (!settings.KroganFaction)
            {
                RimeffectRacesDefOf.KroganFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.KroganFaction.maxCountAtGameStart = 0;
            }

            if (!settings.QuarianFaction)
            {
                RimeffectRacesDefOf.QuarianFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.QuarianFaction.maxCountAtGameStart = 0;
            }

            if (!settings.SalarianFaction)
            {
                RimeffectRacesDefOf.SalarianFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.SalarianFaction.maxCountAtGameStart = 0;
            }

            if (!settings.TurianFaction)
            {
                RimeffectRacesDefOf.TurianFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.TurianFaction.maxCountAtGameStart = 0;
            }

            if (!settings.VorchaFaction)
            {
                RimeffectRacesDefOf.VorchaFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.VorchaFaction.maxCountAtGameStart = 0;
            }

            if (!settings.Geth)
            {
                RimeffectRacesDefOf.Geth.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.Geth.maxCountAtGameStart = 0;
            }

            if (!settings.Reapers)
            {
                RimeffectRacesDefOf.Reapers.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.Reapers.maxCountAtGameStart = 0;
            }

        }
    }
}
