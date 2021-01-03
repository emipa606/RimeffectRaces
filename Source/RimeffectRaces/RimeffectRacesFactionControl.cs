using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;
using RimWorld;
using Verse;
using AlienRace;

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
                PawnKindDef AsariPlayer = PawnKindDef.Named("AsariPlayer");
                PawnKindDef AsariSlave = PawnKindDef.Named("AsariSlave");
                PawnKindDef AsariRefugee = PawnKindDef.Named("AsariRefugee");
                PawnKindDef AsariColonist = PawnKindDef.Named("AsariColonist");
                RimeffectRacesDefOf.AsariRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(AsariPlayer)).First().chance = 0f;
                RimeffectRacesDefOf.AsariRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(AsariSlave)).First().chance = 0f;
                RimeffectRacesDefOf.AsariRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(AsariRefugee)).First().chance = 0f;
                RimeffectRacesDefOf.AsariRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(AsariColonist)).First().chance = 0f;
            }

            if (!settings.BatarianFaction)
            {
                RimeffectRacesDefOf.BatarianFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.BatarianFaction.maxCountAtGameStart = 0;
                PawnKindDef PlayerBatarian = PawnKindDef.Named("PlayerBatarian");
                PawnKindDef BatarianSlave01 = PawnKindDef.Named("BatarianSlave01");
                PawnKindDef BatarianColonist01 = PawnKindDef.Named("BatarianColonist01");
                PawnKindDef BatarianSoldier01 = PawnKindDef.Named("BatarianSoldier01");
                RimeffectRacesDefOf.batarianRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(PlayerBatarian)).First().chance = 0f;
                RimeffectRacesDefOf.batarianRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(BatarianSlave01)).First().chance = 0f;
                RimeffectRacesDefOf.batarianRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(BatarianColonist01)).First().chance = 0f;
                RimeffectRacesDefOf.batarianRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(BatarianSoldier01)).First().chance = 0f;
            }

            if (!settings.EnkindlerFaction)
            {
                RimeffectRacesDefOf.EnkindlerFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.EnkindlerFaction.maxCountAtGameStart = 0;
                PawnKindDef PlayerDrell = PawnKindDef.Named("PlayerDrell");
                PawnKindDef DrellSlave01 = PawnKindDef.Named("DrellSlave01");
                PawnKindDef DrellColonist01 = PawnKindDef.Named("DrellColonist01");
                PawnKindDef DrellSoldier01 = PawnKindDef.Named("DrellSoldier01");
                PawnKindDef PlayerHanar = PawnKindDef.Named("PlayerHanar");
                PawnKindDef HanarSlave01 = PawnKindDef.Named("HanarSlave01");
                PawnKindDef HanarColonist01 = PawnKindDef.Named("HanarColonist01");
                RimeffectRacesDefOf.drellRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(PlayerDrell)).First().chance = 0f;
                RimeffectRacesDefOf.drellRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(DrellSlave01)).First().chance = 0f;
                RimeffectRacesDefOf.drellRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(DrellColonist01)).First().chance = 0f;
                RimeffectRacesDefOf.drellRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(DrellSoldier01)).First().chance = 0f;
                RimeffectRacesDefOf.hanarRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(PlayerHanar)).First().chance = 0f;
                RimeffectRacesDefOf.hanarRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(HanarSlave01)).First().chance = 0f;
                RimeffectRacesDefOf.hanarRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(HanarColonist01)).First().chance = 0f;
                RimeffectRacesDefOf.hanarRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(HanarColonist01)).First().chance = 0f;
            }

            if (!settings.KroganFaction)
            {
                RimeffectRacesDefOf.KroganFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.KroganFaction.maxCountAtGameStart = 0;
                PawnKindDef PlayerKrogan = PawnKindDef.Named("PlayerKrogan");
                PawnKindDef KroganSlave01 = PawnKindDef.Named("KroganSlave01");
                PawnKindDef KroganColonist01 = PawnKindDef.Named("KroganColonist01");
                PawnKindDef KroganSoldier01 = PawnKindDef.Named("KroganSoldier01");
                RimeffectRacesDefOf.kroganRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(PlayerKrogan)).First().chance = 0f;
                RimeffectRacesDefOf.kroganRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(KroganSlave01)).First().chance = 0f;
                RimeffectRacesDefOf.kroganRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(KroganColonist01)).First().chance = 0f;
                RimeffectRacesDefOf.kroganRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(KroganSoldier01)).First().chance = 0f;
            }

            if (!settings.QuarianFaction)
            {
                RimeffectRacesDefOf.QuarianFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.QuarianFaction.maxCountAtGameStart = 0;
                PawnKindDef PlayerQuarian = PawnKindDef.Named("PlayerQuarian");
                PawnKindDef QuarianSlave01 = PawnKindDef.Named("QuarianSlave01");
                PawnKindDef QuarianColonist01 = PawnKindDef.Named("QuarianColonist01");
                PawnKindDef QuarianSoldier01 = PawnKindDef.Named("QuarianSoldier01");
                RimeffectRacesDefOf.quarianRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(PlayerQuarian)).First().chance = 0f;
                RimeffectRacesDefOf.quarianRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(QuarianSlave01)).First().chance = 0f;
                RimeffectRacesDefOf.quarianRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(QuarianColonist01)).First().chance = 0f;
                RimeffectRacesDefOf.quarianRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(QuarianSoldier01)).First().chance = 0f;
            }

            if (!settings.SalarianFaction)
            {
                RimeffectRacesDefOf.SalarianFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.SalarianFaction.maxCountAtGameStart = 0;
                PawnKindDef PlayerSalarian = PawnKindDef.Named("PlayerSalarian");
                PawnKindDef SalarianSlave01 = PawnKindDef.Named("SalarianSlave01");
                PawnKindDef SalarianColonist01 = PawnKindDef.Named("SalarianColonist01");
                PawnKindDef SalarianSoldier01 = PawnKindDef.Named("SalarianSoldier01");
                RimeffectRacesDefOf.salarianRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(PlayerSalarian)).First().chance = 0f;
                RimeffectRacesDefOf.salarianRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(SalarianSlave01)).First().chance = 0f;
                RimeffectRacesDefOf.salarianRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(SalarianColonist01)).First().chance = 0f;
                RimeffectRacesDefOf.salarianRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(SalarianSoldier01)).First().chance = 0f;
            }

            if (!settings.TurianFaction)
            {
                RimeffectRacesDefOf.TurianFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.TurianFaction.maxCountAtGameStart = 0;
                PawnKindDef PlayerTurian = PawnKindDef.Named("PlayerTurian");
                PawnKindDef TurianSlave01 = PawnKindDef.Named("TurianSlave01");
                PawnKindDef TurianColonist01 = PawnKindDef.Named("TurianColonist01");
                PawnKindDef TurianSoldier01 = PawnKindDef.Named("TurianSoldier01");
                RimeffectRacesDefOf.turianRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(PlayerTurian)).First().chance = 0f;
                RimeffectRacesDefOf.turianRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(TurianSlave01)).First().chance = 0f;
                RimeffectRacesDefOf.turianRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(TurianColonist01)).First().chance = 0f;
                RimeffectRacesDefOf.turianRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(TurianSoldier01)).First().chance = 0f;
            }

            if (!settings.VorchaFaction)
            {
                RimeffectRacesDefOf.VorchaFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.VorchaFaction.maxCountAtGameStart = 0;
                PawnKindDef PlayerVorcha = PawnKindDef.Named("PlayerVorcha");
                PawnKindDef VorchaSlave01 = PawnKindDef.Named("VorchaSlave01");
                PawnKindDef VorchaColonist01 = PawnKindDef.Named("VorchaColonist01");
                PawnKindDef VorchaSoldier01 = PawnKindDef.Named("VorchaSoldier01");
                RimeffectRacesDefOf.vorchaRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries.Where(x => x.kindDefs.Contains(PlayerVorcha)).First().chance = 0f;
                RimeffectRacesDefOf.vorchaRaceSettings.pawnKindSettings.alienslavekinds.Where(x => x.kindDefs.Contains(VorchaSlave01)).First().chance = 0f;
                RimeffectRacesDefOf.vorchaRaceSettings.pawnKindSettings.alienrefugeekinds.Where(x => x.kindDefs.Contains(VorchaColonist01)).First().chance = 0f;
                RimeffectRacesDefOf.vorchaRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries.Where(x => x.kindDefs.Contains(VorchaSoldier01)).First().chance = 0f;
            }

            if (!settings.WhiteHandFaction)
            {
                RimeffectRacesDefOf.WhiteHandFaction.requiredCountAtGameStart = 0;
                RimeffectRacesDefOf.WhiteHandFaction.maxCountAtGameStart = 0;
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
