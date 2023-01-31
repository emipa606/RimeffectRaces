using Verse;

namespace RimeffectRaces;

public class BloodRageGiver : HediffGiver
{
    public bool HarmedRecently(Pawn pawn)
    {
        return Find.TickManager.TicksGame - pawn.mindState.lastHarmTick < 2500;
    }

    public override void OnIntervalPassed(Pawn pawn, Hediff cause)
    {
        if (!HarmedRecently(pawn))
        {
            return;
        }

        HealthUtility.AdjustSeverity(pawn, hediff, 0.5f);
    }
}