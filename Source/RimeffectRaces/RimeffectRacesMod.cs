using UnityEngine;
using Verse;

namespace RimeffectRaces;

public class RimeffectRacesMod : Mod
{
    public static RimeffectRacesMod mod;
    public RimeffectRacesSettings settings;

    public RimeffectRacesMod(ModContentPack content) : base(content)
    {
        settings = GetSettings<RimeffectRacesSettings>();
        mod = this;
    }

    public override string SettingsCategory()
    {
        return "Rimeffect Races";
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        var listingStandard = new Listing_Standard();
        listingStandard.Begin(inRect);
        listingStandard.Label("FactionSettingsNotice".Translate());
        listingStandard.CheckboxLabeled("Asari", ref settings.AsariFaction, "Asari Union");
        listingStandard.CheckboxLabeled("Batarians", ref settings.BatarianFaction, "Batarian Expatriates");
        listingStandard.CheckboxLabeled("Drell and Hanar", ref settings.EnkindlerFaction, "Enkindler's Legacy");
        listingStandard.CheckboxLabeled("Krogan", ref settings.KroganFaction, "Krogan Castaways");
        listingStandard.CheckboxLabeled("Quarians", ref settings.QuarianFaction, "Quarian Colony");
        listingStandard.CheckboxLabeled("Salarians", ref settings.SalarianFaction, "Salarian Settlers");
        listingStandard.CheckboxLabeled("Turians", ref settings.TurianFaction, "Turian Militants");
        listingStandard.CheckboxLabeled("Vorcha", ref settings.VorchaFaction, "Vorcha Tribes");
        listingStandard.Label("CombinedFactionNotice".Translate());
        listingStandard.CheckboxLabeled("White Hand", ref settings.WhiteHandFaction, "The White Hand");
        listingStandard.Label("PermanentlyHostileFactions".Translate());
        listingStandard.CheckboxLabeled("Reapers", ref settings.Reapers, "Reaper Onslaught");
        listingStandard.CheckboxLabeled("Geth", ref settings.GethRER, "Geth Collective");
        listingStandard.End();
        base.DoSettingsWindowContents(inRect);
    }
}