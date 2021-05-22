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
    public class RimeffectRacesMod : Mod
    {
        public RimeffectRacesSettings settings;
        public static RimeffectRacesMod mod;

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
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Label("Faction Settings - Any changes made here will require a restart to take effect.");
            listingStandard.CheckboxLabeled("Asari", ref settings.AsariFaction, "Asari Union");
            listingStandard.CheckboxLabeled("Batarians", ref settings.BatarianFaction, "Batarian Expatriates");
            listingStandard.CheckboxLabeled("Drell and Hanar", ref settings.EnkindlerFaction, "Enkindler's Legacy");
            listingStandard.CheckboxLabeled("Krogan", ref settings.KroganFaction, "Krogan Castaways");
            listingStandard.CheckboxLabeled("Quarians", ref settings.QuarianFaction, "Quarian Colony");
            listingStandard.CheckboxLabeled("Salarians", ref settings.SalarianFaction, "Salarian Settlers");
            listingStandard.CheckboxLabeled("Turians", ref settings.TurianFaction, "Turian Militants");
            listingStandard.CheckboxLabeled("Vorcha", ref settings.VorchaFaction, "Vorcha Tribes");
            listingStandard.Label("The White Hand is a faction that combines the Krogan and Vorcha into a single faction.");
            listingStandard.CheckboxLabeled("White Hand", ref settings.WhiteHandFaction, "The White Hand");
            listingStandard.Label("Permanently Hostile Factions");
            listingStandard.CheckboxLabeled("Reapers", ref settings.Reapers, "Reaper Onslaught");
            listingStandard.CheckboxLabeled("Geth", ref settings.GethRER, "Geth Collective");
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

    }

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
}
