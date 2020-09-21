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
    [DefOf]
    public static class RimeffectRacesDefOf
    {
        static RimeffectRacesDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(RimeffectRacesDefOf));
        }

        public static FactionDef AsariFaction;

        public static FactionDef BatarianFaction;

        public static FactionDef EnkindlerFaction;

        public static FactionDef Geth;

        public static FactionDef KroganFaction;

        public static FactionDef QuarianFaction;

        public static FactionDef Reapers;

        public static FactionDef SalarianFaction;

        public static FactionDef TurianFaction;

        public static FactionDef VorchaFaction;

        public static FactionDef WhiteHandFaction;

    }

}
