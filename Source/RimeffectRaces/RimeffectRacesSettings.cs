using Verse;

namespace RimeffectRaces;

public class RimeffectRacesSettings : ModSettings
{
    public bool AsariFaction = true;
    public bool BatarianFaction = true;
    public bool EnkindlerFaction = true;
    public bool GethRER = true;
    public bool KroganFaction = true;
    public bool QuarianFaction = true;
    public bool Reapers = true;
    public bool SalarianFaction = true;
    public bool TurianFaction = true;
    public bool VorchaFaction = true;
    public bool WhiteHandFaction = true;

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref AsariFaction, "Asari_Union", true);
        Scribe_Values.Look(ref BatarianFaction, "Batarian_Expatriates", true);
        Scribe_Values.Look(ref EnkindlerFaction, "Enkindlers_Legacy", true);
        Scribe_Values.Look(ref GethRER, "Geth_Collective", true);
        Scribe_Values.Look(ref KroganFaction, "Krogan_Castaways", true);
        Scribe_Values.Look(ref QuarianFaction, "Quarian_Colony", true);
        Scribe_Values.Look(ref Reapers, "Reaper_Onslaught", true);
        Scribe_Values.Look(ref SalarianFaction, "Salarian_Settlers", true);
        Scribe_Values.Look(ref TurianFaction, "Turian_Militants", true);
        Scribe_Values.Look(ref VorchaFaction, "Vorcha_Tribes", true);
        Scribe_Values.Look(ref WhiteHandFaction, "White_Hand", true);
    }
}