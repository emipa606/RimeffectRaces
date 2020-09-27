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
    [DefOf]
    public static class RimeffectRacesDefOf
    {
        static RimeffectRacesDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(RimeffectRacesDefOf));
        }

        public static FactionDef AsariFaction;
        public static RaceSettings AsariRaceSettings;
        public static PawnKindDef AsariPlayer;

        public static FactionDef BatarianFaction;
        public static RaceSettings batarianRaceSettings;

        public static FactionDef EnkindlerFaction;
        public static RaceSettings drellRaceSettings;
        public static RaceSettings hanarRaceSettings;

        public static FactionDef Geth;

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

    }

}
