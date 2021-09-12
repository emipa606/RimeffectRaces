using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;
using RimWorld;
using Verse;
using Verse.AI;

namespace RimeffectRaces
{
    public class BloodRageGiver : HediffGiver
    {
        public bool HarmedRecently(Pawn pawn) => Find.TickManager.TicksGame - ((Pawn_MindState)pawn.mindState).lastHarmTick < 2500;

        public override void OnIntervalPassed(Pawn pawn, Hediff cause)
        {
            if (!this.HarmedRecently(pawn))
                return;
            HealthUtility.AdjustSeverity(pawn, (HediffDef)this.hediff, 0.5f);
        }

    }
}
