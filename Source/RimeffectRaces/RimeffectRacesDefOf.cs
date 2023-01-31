using AlienRace;
using RimWorld;

namespace RimeffectRaces;

[DefOf]
public static class RimeffectRacesDefOf
{
    public static FactionDef AsariFaction;
    public static RaceSettings AsariRaceSettings;

    public static FactionDef BatarianFaction;
    public static RaceSettings batarianRaceSettings;

    public static FactionDef EnkindlerFaction;
    public static RaceSettings drellRaceSettings;
    public static RaceSettings hanarRaceSettings;

    public static FactionDef GethRER;

    public static FactionDef KroganFaction;
    public static RaceSettings kroganRaceSettings;

    public static FactionDef QuarianFaction;
    public static RaceSettings quarianRaceSettings;

    public static FactionDef Reapers;

    public static FactionDef SalarianFaction;
    public static RaceSettings salarianRaceSettings;

    public static FactionDef TurianFaction;
    public static RaceSettings turianRaceSettings;

    public static FactionDef VorchaFaction;
    public static RaceSettings vorchaRaceSettings;

    public static FactionDef WhiteHandFaction;

    static RimeffectRacesDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(RimeffectRacesDefOf));
    }
}