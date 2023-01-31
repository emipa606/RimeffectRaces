using System.Linq;
using Verse;

namespace RimeffectRaces;

[StaticConstructorOnStartup]
public static class FactionControl
{
    static FactionControl()
    {
        var settings = RimeffectRacesMod.mod.settings;

        if (!settings.AsariFaction)
        {
            RimeffectRacesDefOf.AsariFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.AsariFaction.maxCountAtGameStart = 0;
            var AsariPlayer = PawnKindDef.Named("AsariPlayer");
            var AsariSlave = PawnKindDef.Named("AsariSlave");
            var AsariRefugee = PawnKindDef.Named("AsariRefugee");
            var AsariColonist = PawnKindDef.Named("AsariColonist");
            RimeffectRacesDefOf.AsariRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(AsariPlayer)).chance = 0f;
            RimeffectRacesDefOf.AsariRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(AsariSlave)).chance = 0f;
            RimeffectRacesDefOf.AsariRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(AsariRefugee)).chance = 0f;
            RimeffectRacesDefOf.AsariRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(AsariColonist)).chance = 0f;
        }

        if (!settings.BatarianFaction)
        {
            RimeffectRacesDefOf.BatarianFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.BatarianFaction.maxCountAtGameStart = 0;
            var PlayerBatarian = PawnKindDef.Named("PlayerBatarian");
            var BatarianSlave01 = PawnKindDef.Named("BatarianSlave01");
            var BatarianColonist01 = PawnKindDef.Named("BatarianColonist01");
            var BatarianSoldier01 = PawnKindDef.Named("BatarianSoldier01");
            RimeffectRacesDefOf.batarianRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(PlayerBatarian)).chance = 0f;
            RimeffectRacesDefOf.batarianRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(BatarianSlave01)).chance = 0f;
            RimeffectRacesDefOf.batarianRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(BatarianColonist01)).chance = 0f;
            RimeffectRacesDefOf.batarianRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(BatarianSoldier01)).chance = 0f;
        }

        if (!settings.EnkindlerFaction)
        {
            RimeffectRacesDefOf.EnkindlerFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.EnkindlerFaction.maxCountAtGameStart = 0;
            var PlayerDrell = PawnKindDef.Named("PlayerDrell");
            var DrellSlave01 = PawnKindDef.Named("DrellSlave01");
            var DrellColonist01 = PawnKindDef.Named("DrellColonist01");
            var DrellSoldier01 = PawnKindDef.Named("DrellSoldier01");
            var PlayerHanar = PawnKindDef.Named("PlayerHanar");
            var HanarSlave01 = PawnKindDef.Named("HanarSlave01");
            var HanarColonist01 = PawnKindDef.Named("HanarColonist01");
            RimeffectRacesDefOf.drellRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(PlayerDrell)).chance = 0f;
            RimeffectRacesDefOf.drellRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(DrellSlave01)).chance = 0f;
            RimeffectRacesDefOf.drellRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(DrellColonist01)).chance = 0f;
            RimeffectRacesDefOf.drellRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(DrellSoldier01)).chance = 0f;
            RimeffectRacesDefOf.hanarRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(PlayerHanar)).chance = 0f;
            RimeffectRacesDefOf.hanarRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(HanarSlave01)).chance = 0f;
            RimeffectRacesDefOf.hanarRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(HanarColonist01)).chance = 0f;
            RimeffectRacesDefOf.hanarRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(HanarColonist01)).chance = 0f;
        }

        if (!settings.KroganFaction)
        {
            RimeffectRacesDefOf.KroganFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.KroganFaction.maxCountAtGameStart = 0;
            var PlayerKrogan = PawnKindDef.Named("PlayerKrogan");
            var KroganSlave01 = PawnKindDef.Named("KroganSlave01");
            var KroganColonist01 = PawnKindDef.Named("KroganColonist01");
            var KroganSoldier01 = PawnKindDef.Named("KroganSoldier01");
            RimeffectRacesDefOf.kroganRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(PlayerKrogan)).chance = 0f;
            RimeffectRacesDefOf.kroganRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(KroganSlave01)).chance = 0f;
            RimeffectRacesDefOf.kroganRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(KroganColonist01)).chance = 0f;
            RimeffectRacesDefOf.kroganRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(KroganSoldier01)).chance = 0f;
        }

        if (!settings.QuarianFaction)
        {
            RimeffectRacesDefOf.QuarianFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.QuarianFaction.maxCountAtGameStart = 0;
            var PlayerQuarian = PawnKindDef.Named("PlayerQuarian");
            var QuarianSlave01 = PawnKindDef.Named("QuarianSlave01");
            var QuarianColonist01 = PawnKindDef.Named("QuarianColonist01");
            var QuarianSoldier01 = PawnKindDef.Named("QuarianSoldier01");
            RimeffectRacesDefOf.quarianRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(PlayerQuarian)).chance = 0f;
            RimeffectRacesDefOf.quarianRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(QuarianSlave01)).chance = 0f;
            RimeffectRacesDefOf.quarianRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(QuarianColonist01)).chance = 0f;
            RimeffectRacesDefOf.quarianRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(QuarianSoldier01)).chance = 0f;
        }

        if (!settings.SalarianFaction)
        {
            RimeffectRacesDefOf.SalarianFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.SalarianFaction.maxCountAtGameStart = 0;
            var PlayerSalarian = PawnKindDef.Named("PlayerSalarian");
            var SalarianSlave01 = PawnKindDef.Named("SalarianSlave01");
            var SalarianColonist01 = PawnKindDef.Named("SalarianColonist01");
            var SalarianSoldier01 = PawnKindDef.Named("SalarianSoldier01");
            RimeffectRacesDefOf.salarianRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(PlayerSalarian)).chance = 0f;
            RimeffectRacesDefOf.salarianRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(SalarianSlave01)).chance = 0f;
            RimeffectRacesDefOf.salarianRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(SalarianColonist01)).chance = 0f;
            RimeffectRacesDefOf.salarianRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(SalarianSoldier01)).chance = 0f;
        }

        if (!settings.TurianFaction)
        {
            RimeffectRacesDefOf.TurianFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.TurianFaction.maxCountAtGameStart = 0;
            var PlayerTurian = PawnKindDef.Named("PlayerTurian");
            var TurianSlave01 = PawnKindDef.Named("TurianSlave01");
            var TurianColonist01 = PawnKindDef.Named("TurianColonist01");
            var TurianSoldier01 = PawnKindDef.Named("TurianSoldier01");
            RimeffectRacesDefOf.turianRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(PlayerTurian)).chance = 0f;
            RimeffectRacesDefOf.turianRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(TurianSlave01)).chance = 0f;
            RimeffectRacesDefOf.turianRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(TurianColonist01)).chance = 0f;
            RimeffectRacesDefOf.turianRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(TurianSoldier01)).chance = 0f;
        }

        if (!settings.VorchaFaction)
        {
            RimeffectRacesDefOf.VorchaFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.VorchaFaction.maxCountAtGameStart = 0;
            var PlayerVorcha = PawnKindDef.Named("PlayerVorcha");
            var VorchaSlave01 = PawnKindDef.Named("VorchaSlave01");
            var VorchaColonist01 = PawnKindDef.Named("VorchaColonist01");
            var VorchaSoldier01 = PawnKindDef.Named("VorchaSoldier01");
            RimeffectRacesDefOf.vorchaRaceSettings.pawnKindSettings.startingColonists.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(PlayerVorcha)).chance = 0f;
            RimeffectRacesDefOf.vorchaRaceSettings.pawnKindSettings.alienslavekinds
                .First(x => x.kindDefs.Contains(VorchaSlave01)).chance = 0f;
            RimeffectRacesDefOf.vorchaRaceSettings.pawnKindSettings.alienrefugeekinds
                .First(x => x.kindDefs.Contains(VorchaColonist01)).chance = 0f;
            RimeffectRacesDefOf.vorchaRaceSettings.pawnKindSettings.alienwandererkinds.First().pawnKindEntries
                .First(x => x.kindDefs.Contains(VorchaSoldier01)).chance = 0f;
        }

        if (!settings.WhiteHandFaction)
        {
            RimeffectRacesDefOf.WhiteHandFaction.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.WhiteHandFaction.maxCountAtGameStart = 0;
        }

        if (!settings.GethRER)
        {
            RimeffectRacesDefOf.GethRER.requiredCountAtGameStart = 0;
            RimeffectRacesDefOf.GethRER.maxCountAtGameStart = 0;
        }

        if (settings.Reapers)
        {
            return;
        }

        RimeffectRacesDefOf.Reapers.requiredCountAtGameStart = 0;
        RimeffectRacesDefOf.Reapers.maxCountAtGameStart = 0;
    }
}